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
using Android.Support.V7.App;
using Android.Support.V4.App;

namespace Meme.Droid
{
	[Activity(Label = "Favoritos", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait,Theme = "@style/Theme.AppCompat.Light", Icon = "@drawable/ic_launcher")]
	[MetaData("android.support.PARENT_ACTIVITY",
		Value = "meme.droid.Activity1")]
	public class FavActivity : ActionBarActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			SetContentView (Resource.Layout.Favorites);
			SupportActionBar.SetDisplayHomeAsUpEnabled(true);
			SupportActionBar.SetDisplayShowHomeEnabled(true);
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

