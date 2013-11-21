using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Facebook
{
	[Activity (Label = "Facebook", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button buttonFB = FindViewById<Button> (Resource.Id.btnFacebook);
			Button buttonTW = FindViewById<Button> (Resource.Id.btnTwitter);

			//Asignamos el evento del boton de Facebook
			buttonFB.Click += buttonFB_HandleClick;

			//Asignamos el evento del boton de Twitter
			buttonTW.Click += buttonTW_HandleClick;
		}

		void buttonTW_HandleClick (object sender, EventArgs e)
		{
			//Iniciamos la siguiente Actividad enviando de parametro un numero
			//indicando que usaremos el framework de Twitter
			var activity2 = new Intent (this, typeof(ShareActivity));
			activity2.PutExtra ("Tipo", 1);
			StartActivity (activity2);  
		}

		void buttonFB_HandleClick (object sender, EventArgs e)
		{
			//Iniciamos la siguiente Actividad Normalmente
			StartActivity (typeof(ShareActivity));
		}
	}
}


