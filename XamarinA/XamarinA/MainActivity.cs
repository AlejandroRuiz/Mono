using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Auth;

namespace XamarinA
{
	[Activity (Label = "XamarinA", MainLauncher = true)]
	public class MainActivity : Activity
	{
		//Button to save data
		Button bSave;
		//Textfield to write data
		EditText eFirstName, eLastName, eAge, eEmail;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			//button and textfields assignations
			bSave = FindViewById<Button> (Resource.Id.Btnsave);
			eFirstName = FindViewById<EditText> (Resource.Id.FNametxt);
			eLastName = FindViewById<EditText> (Resource.Id.LNametxt);
			eAge = FindViewById<EditText> (Resource.Id.Agetxt);
			eEmail = FindViewById<EditText> (Resource.Id.EMailtxt);

			//set button click event
			bSave.Click += bSave_HandleClick;

			//check if account already exists
			var accounts = AccountStore.Create (this).FindAccountsForService ("XASample");
			foreach (var a in accounts) {
				//if the account has stored we proceed to start next activity
				StartActivity (typeof(SecondActivity));
				break;
			}
		}

		//Button Click event
		void bSave_HandleClick (object sender, EventArgs e)
		{

			string FName = eFirstName.Text;
			string LName = eLastName.Text;
			string Age = eAge.Text;
			string Email = eEmail.Text;
			//Create Account variable with a new Account(username, Dictionary of properties)
			Account ac = new Account(FName, AccountCore.Dictionary(FName,LName,Age,Email));
			//Save the account we create with(Account,ServiceId)
			//for service id you can use an unique id of your app
			AccountStore.Create (this).Save (ac, "XASample");
			StartActivity (typeof(SecondActivity));
		}
	}
}


