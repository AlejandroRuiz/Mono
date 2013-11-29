using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
//Importaremos la librearia necesaria para el uso del TTS "Android.Speech.Tts"
using Android.Speech.Tts;
//Importaremos la libreria para el uso de colecciones "System.Collections.Generic"
using System.Collections.Generic;

namespace TTSDemo
{
	//Implementaremos el tipo TextToSpeech.IOnInitListener para poder activar nuestro TTS al iniciar nuestra app
	[Activity (Label = "TTSDemo", MainLauncher = true)]
	public class MainActivity : Activity, TextToSpeech.IOnInitListener
	{
		//Declararemos nuestra variable del tipo TextToSpeech
		private TextToSpeech tts;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			//Inicializaremos nuestra variable principal que nos pide dos parametros nuestro contexto y una clase
			//tipo TextToSpeech.IOnInitListener la cual heredamos mediante la implementacion de la clase
			tts = new TextToSpeech (this, this);

			Button button = FindViewById<Button> (Resource.Id.Button1);
			EditText caja = FindViewById<EditText> (Resource.Id.Texto);
			button.Click += delegate {
				//Verificamos que nuestra variable tipo TextToSpeech sea diferente de null
				if (tts!=null) {
					//En una variable tipo string depositamos el contenido de nuestro textbox
					String text = caja.Text;
					//Verificamos que nuestra variable de texto no sea nula para evitar una excepcion
					if (text!=null) {
						//Verificamos que nuestro telefono no este usando la funcion de dictado
						if (!tts.IsSpeaking) {
							//mandamos a llamar la funcion de dictado que nos pedida tres parametros
							//1 Texto a dictar
							//2 Modo
							//3 Diccionario de parametros el cual ira vacio en esta ocacion
							tts.Speak(text, QueueMode.Flush, new Dictionary<string, string>());
						}
					}
				}
			};
		}

		//Nuestro metodo importante en el cual nos devolvera al momento de inicializar nuestro TTS
		public void OnInit (OperationResult status)
		{
			//Verificamos que nuestra variable haya sido inicializada correctamente
			if (status.Equals (OperationResult.Success)) {
				//Asignamos el idima a utlizar en este caso seleccionamos el idioma por default del sistema
				tts.SetLanguage (Java.Util.Locale.Default);
				//Enviamos una notificacion de que se activo nuestro TTS correctamente
				Toast.MakeText (this, "TTS Activado Correctamente", ToastLength.Long).Show ();
			}
			else {
				//Enviamos una notificacion si no se activo nuestro TTS correctamente
				Toast.MakeText (this, "Error al activar TTS", ToastLength.Long).Show ();
			}
		}

		//En nuestro metodo de destruccion paramos y apagamos el dictado
		protected override void OnDestroy ()
		{
			if (tts!=null) {
				tts.Stop ();
				tts.Shutdown();
			}
			base.OnDestroy ();
		}
	}
}