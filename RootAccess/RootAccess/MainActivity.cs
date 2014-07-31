﻿using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace RootAccess
{
	[Activity (Label = "RootAccess", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				bool rootaccess = ExecuteAsRootBase.canRunRootCommands();
				button.Text = rootaccess.ToString();
				if(rootaccess)
				{
					Java.Lang.Runtime.GetRuntime().Exec ("su -c" + "command to exec");
				}
			};
		}
	}
}


