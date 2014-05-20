using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MvvmXamarin.Android
{
	[Activity (Label = "MvvmCrossXamarin.Android", MainLauncher = true)]
	public class MainActivity : Activity
	{
		Model viewmodel;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			viewmodel = new Model ();
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			var et = FindViewById<EditText> (Resource.Id.Field);
			var lbl = FindViewById<TextView> (Resource.Id.Text);
            var btn = FindViewById<Button>(Resource.Id.Button);
            btn.Click += (sender, e) => viewmodel.ClickEvent.Execute(null);
			et.TextChanged += (sender, e) => {
				viewmodel.Text = e.Text.ToString();
			};
			viewmodel.PropertyChanged += (object sender, System.ComponentModel.PropertyChangedEventArgs e) => 
			{
                if (e.PropertyName == "Text")
                    lbl.Text = viewmodel.Text;
                else if (e.PropertyName == "TimesString")
                    btn.Text = viewmodel.TimesString;
			};
		}
	}
}


