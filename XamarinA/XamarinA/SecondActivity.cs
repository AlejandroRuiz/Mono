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
using Xamarin.Auth;

namespace XamarinA
{
	[Activity (Label = "SecondActivity")]			
	public class SecondActivity : Activity
	{
		//Button to delete data
		Button bDelete;
		//Labels to view data
		TextView tFirstName, tLastName, tAge, tEmail;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Second);
			//button and labels assignations
			bDelete = FindViewById<Button> (Resource.Id.Btndelete);
			tFirstName = FindViewById<TextView> (Resource.Id.FNamelbl);
			tLastName = FindViewById<TextView> (Resource.Id.LNamelbl);
			tAge = FindViewById<TextView> (Resource.Id.Agelbl);
			tEmail = FindViewById<TextView> (Resource.Id.EMaillbl);
			bDelete.Click += bDelete_HandleClick;

			//check if account already exists
			var accounts = AccountStore.Create (this).FindAccountsForService ("XASample");
			foreach (var a in accounts) {
				//here you can use the account properties to set label's text
				tFirstName.Text = a.Properties["FName"];
				tLastName.Text = a.Properties["LName"];
				tAge.Text = a.Properties["Age"];
				tEmail.Text = a.Properties["Email"];
			}
		}

		//button click event
		void bDelete_HandleClick (object sender, EventArgs e)
		{
			//first search for accounts with the id and then we continue to delete it
			var accounts = AccountStore.Create (this).FindAccountsForService ("XASample");
			foreach (var a in accounts) {
				//delete each of accounts found
				AccountStore.Create (this).Delete (a, "XASample");
			}
			//returns to the firts activity
			StartActivity (typeof(MainActivity));
		}
	}
}

