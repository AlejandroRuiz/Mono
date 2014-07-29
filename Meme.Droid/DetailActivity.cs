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
using Android.Gms.Maps;
using Android.Support.V7.App;
using Android.Support.V4.App;

namespace Meme.Droid
{
	[Activity (Label = "Detalles", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait,Theme = "@style/Theme.AppCompat.Light", Icon = "@drawable/ic_launcher")]
	[MetaData("android.support.PARENT_ACTIVITY",
		Value = "meme.droid.Activity1")]
	public class DetailActivity : ActionBarActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			var mapFragment = new SupportMapFragment ();
			var fragmentTx = this.SupportFragmentManager.BeginTransaction ();
			fragmentTx.Add (Resource.Id.mapaFrag, mapFragment);
			fragmentTx.Commit ();
			SetContentView (Resource.Layout.Detail);
			SupportActionBar.SetDisplayHomeAsUpEnabled(true);
			SupportActionBar.SetDisplayShowHomeEnabled(true);

			string DOUBLE_BYTE_SPACE = "\u3000";
			AutoResizeTextView textView = (AutoResizeTextView) this.FindViewById(Resource.Id.txtL);
			String fixString = "";
			/*if (android.os.Build.VERSION.SDK_INT >= android.os.Build.VERSION_CODES.HONEYCOMB_MR1
				&& android.os.Build.VERSION.SDK_INT <= android.os.Build.VERSION_CODES.ICE_CREAM_SANDWICH_MR1) {  
				fixString = DOUBLE_BYTE_SPACE;
			}*/
			fixString = DOUBLE_BYTE_SPACE;
			textView.Text = fixString + "MEME SAN JUAN" + fixString;
		}

		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			switch (item.ItemId)
			{
			case Resource.Id.home:
				{
					var upIntent = NavUtils.GetParentActivityIntent(this);
					if (NavUtils.ShouldUpRecreateTask(this, upIntent))
					{
						// This activity is NOT part of this app's task, so create a new task
						// when navigating up, with a synthesized back stack.
						Android.Support.V4.App.TaskStackBuilder.Create(this).
						AddNextIntentWithParentStack(upIntent).StartActivities();
					}
					else
					{
						// This activity is part of this app's task, so simply
						// navigate up to the logical parent activity.
						NavUtils.NavigateUpTo(this, upIntent); 
					}
				}
				return true;

			}
			return base.OnOptionsItemSelected(item);
		}
	}
}

