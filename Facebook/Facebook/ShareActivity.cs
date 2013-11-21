using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Content.PM;
using Android.Provider;
using Java.IO;
using Android.Graphics;
using Xamarin.Social.Services;
using Xamarin.Social;

namespace Facebook
{
	[Activity (Label = "ShareActivity")]			
	public class ShareActivity : Activity
	{
		//Creamos una variables con la informacion proporcionado por facebook
		private static readonly FacebookService Facebook = new FacebookService {
			ClientId = "Id Cliente",
			RedirectUrl = new Uri ("URL de Redireccionamiento")
		};

		//Creamos una variables con la informacion proporcionado por Twitter
		private static readonly TwitterService Twitter = new TwitterService {
			ConsumerKey = "Id ConsumerKey",
			ConsumerSecret = "Id ConsumerSecret",
			CallbackUrl = new Uri ("URL CallbackUrl")
		};

		//Generamos algunas variables globales
		//Variables en donde almacenaremos la direccion de la imagen que tomaremos
		Java.IO.File _Archivo;
		//Variables en donde almacenaremos la direccion donde guardaremos las imagenes
		Java.IO.File _Directorio;
		//Variables de nuestra UI
		//Imageview donde cargaremos nuestra fotografia tomada
		ImageView _imageViewFoto;
		//Campos donde el usuario podra escribir lo que quiere compartir
		EditText _txtEstado1, _txtEstado2, _txtEstado3;
		//Botones en donde haremos las acciones de publicacion
		Button _btnEstado, _btnEstadoLink, _btnCaptura, _btnPublicar;
		//Varibale en donde cargaremos el tipo de servicio que usaremos 0=Facebook, 1=Twitter
		int Tipo=0;

		//Generamos un Metodo en donde cargaremos nuestras variables de UI
		void AsignarUI()
		{
			_imageViewFoto = FindViewById<ImageView> (Resource.Id.imageViewFoto);
			_txtEstado1 = FindViewById<EditText> (Resource.Id.txtEstado1);
			_txtEstado2 = FindViewById<EditText> (Resource.Id.txtEstado2);
			_txtEstado3 = FindViewById<EditText> (Resource.Id.txtEstado3);
			_btnEstado = FindViewById<Button> (Resource.Id.btnEstado);
			_btnEstadoLink = FindViewById<Button> (Resource.Id.btnEstadoLink);
			_btnCaptura = FindViewById<Button> (Resource.Id.btnCaptura);
			_btnPublicar = FindViewById<Button> (Resource.Id.btnPublicar);
		}

		//Metodo en donde asignaremos las acciones a los botones
		void AsignarEventos()
		{
			_btnEstado.Click += _btnEstado_HandleClick;
			_btnEstadoLink.Click += _btnEstadoLink_HandleClick;
			_btnCaptura.Click += _btnCaptura_HandleClick;
			_btnPublicar.Click += _btnPublicar_HandleClick;
		}

		//Evento del boton de publicacion de fotografia
		void _btnPublicar_HandleClick (object sender, EventArgs e)
		{
			if(Tipo==0)
				ShareImage (Facebook, _txtEstado3.Text);
			else if(Tipo==1)
				ShareImage (Twitter, _txtEstado3.Text);
		}

		//Evento del boton de captura de fotografia
		void _btnCaptura_HandleClick (object sender, EventArgs e)
		{
			if (IsThereAnAppToTakePictures())
			{
				//Creamos el directorio en donde guardaremos las fotografias capturadas
				CreateDirectoryForPictures();

				//generamos una variable tipo intent en donde mandaremos llamar la camara
				Intent intent = new Intent(MediaStore.ActionImageCapture);

				//Asignamos la direccion del archivo a la varible
				_Archivo = new File(_Directorio, String.Format("Fotografia_{0}.jpg", Guid.NewGuid()));

				//Agregamos un extra con la direccion en donde guardaremos la foto capturada
				intent.PutExtra(MediaStore.ExtraOutput, Android.Net.Uri.FromFile(_Archivo));

				//Mandamos a llamar nuestro intent
				StartActivityForResult(intent, 0);
			}
		}

		//Evento del boton de Estado+Link
		void _btnEstadoLink_HandleClick (object sender, EventArgs e)
		{
			if(Tipo==0)
				ShareLink (Facebook, _txtEstado2.Text);
			else if(Tipo==1)
				ShareLink (Twitter, _txtEstado2.Text);
		}

		//Evento del boton de Estado
		void _btnEstado_HandleClick (object sender, EventArgs e)
		{
			if(Tipo==0)
				Share (Facebook, _txtEstado1.Text);
			else if(Tipo==1)
				Share (Twitter, _txtEstado1.Text);
		}

		//Evento de publicacion Estado+Link
		void ShareLink (Xamarin.Social.Service service, string textshare)
		{
			Item item = new Item {
				Text = textshare,
				Links = new List<Uri> {
					new Uri ("http://alejandroruizvarela.blogspot.mx/"),
				},
			};

			Intent intent = service.GetShareUI (this, item, shareResult => {
				RunOnUiThread(()=>{
					Toast.MakeText(this, shareResult.ToString(), ToastLength.Short).Show();
				});
			});

			StartActivity (intent);
		}

		//Evento de publicacion Estado
		void Share (Xamarin.Social.Service service, string textshare)
		{
			Item item = new Item {
				Text = textshare,
			};

			Intent intent = service.GetShareUI (this, item, shareResult => {
				RunOnUiThread(()=>{
					Toast.MakeText(this, shareResult.ToString(), ToastLength.Short).Show();
				});
			});

			StartActivity (intent);
		}

		//Evento de publicacion Fotografia
		void ShareImage (Xamarin.Social.Service service, string textshare)
		{
			Item item = new Item {
				Text = textshare,
			};
			item.Images.Add(new ImageData(BitmapFactory.DecodeFile(_Archivo.AbsoluteFile.ToString())));
			Intent intent = service.GetShareUI (this, item, shareResult => {
				RunOnUiThread(()=>{
					Toast.MakeText(this, shareResult.ToString(), ToastLength.Short).Show();
				});
			});

			StartActivity (intent);
		}

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			SetContentView (Resource.Layout.shareXML);
			AsignarUI ();
			AsignarEventos ();
			if (Intent.GetIntExtra ("Tipo", 0) != 0)
				Tipo = 1;
		}

		//Creamos el evento override OnActivityResult en donde capturaremos los resultados cuando mandamos a llamar
		//la actividad de la camara
		protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
		{
			base.OnActivityResult(requestCode, resultCode, data);

			//verificamos que nuestro requestCode sea el 0 con el que anteriormente mandamos a llamar la actividad de la camara
			if (requestCode == 0) {
				//Guardamos la foto para hacerla visible en la galeria
				Intent mediaScanIntent = new Intent (Intent.ActionMediaScannerScanFile);
				Android.Net.Uri contentUri = Android.Net.Uri.FromFile (_Archivo);
				mediaScanIntent.SetData (contentUri);
				SendBroadcast (mediaScanIntent);

				//Utilizamos un metodo para ajustar la imagen tomada a nuestro imageview
				int height = _imageViewFoto.Height;
				int width = _imageViewFoto.Width;
				using (Bitmap bitmap = _Archivo.Path.LoadAndResizeBitmap (width, height)) {
					_imageViewFoto.SetImageBitmap (bitmap);
				}
			}
		}

		//Mediante este metodo verificamos que nuestra app tenga permisos para tomar fotografias
		private bool IsThereAnAppToTakePictures()
		{
			Intent intent = new Intent(MediaStore.ActionImageCapture);
			IList<ResolveInfo> availableActivities = PackageManager.QueryIntentActivities(intent, PackageInfoFlags.MatchDefaultOnly);
			return availableActivities != null && availableActivities.Count > 0;
		}

		//Mediante este metodo verificamos si existe en directorio para guardar las fotografias en caso de no existir lo creamos
		private void CreateDirectoryForPictures()
		{
			_Directorio = new File(Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryPictures), "FacebookDemo");
			if (!_Directorio.Exists())
			{
				_Directorio.Mkdirs();
			}
		}
	}

	//Clase auxiliar con la cual redimensionamos nuestra imagen
	public static class BitmapHelpers
	{
		public static Bitmap LoadAndResizeBitmap(this string fileName, int width, int height)
		{
			// First we get the the dimensions of the file on disk
			BitmapFactory.Options options = new BitmapFactory.Options { InJustDecodeBounds = true };
			BitmapFactory.DecodeFile(fileName, options);

			// Next we calculate the ratio that we need to resize the image by
			// in order to fit the requested dimensions.
			int outHeight = options.OutHeight;
			int outWidth = options.OutWidth;
			int inSampleSize = 1;

			if (outHeight > height || outWidth > width)
			{
				inSampleSize = outWidth > outHeight
				           ? outHeight / height
				           : outWidth / width;
			}

			// Now we will load the image and have BitmapFactory resize it for us.
			options.InSampleSize = inSampleSize;
			options.InJustDecodeBounds = false;
						Bitmap resizedBitmap = BitmapFactory.DecodeFile(fileName, options);

			return resizedBitmap;
		}
	}
}

