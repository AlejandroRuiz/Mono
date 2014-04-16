using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.App;
using Android.Media;
using System.Text;
using System.Net;
using System.IO;
using Android.Graphics;
using Android.Content.Res;

namespace MusicPlayerInfo
{
	[Activity (Label = "MusicPlayerInfo", MainLauncher = true)]
	public class MainActivity : Activity
	{
		//NotificationCompat builder
		static NotificationCompat.Builder builder;
		//Notification Manager
		static NotificationManager notificationManager;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);

			//button click Event
			button.Click += delegate {
				//star a new Mservice to cach music info
				StartService(new Intent(this, typeof(Mservice)));
				//Show tast message
				Toast.MakeText(this,"Music Service Started¡¡¡¡",ToastLength.Short).Show();
			};
			//Inicialize Notification builder
			builder = new NotificationCompat.Builder (this)
				.SetContentTitle (this.Title)
				.SetSmallIcon(Resource.Drawable.ic_launcher)
				.SetContentText (this.Title);
			//Set persistent notification 
			builder.SetOngoing (true);
			//Get notification manager service
			notificationManager = (NotificationManager)GetSystemService(Context.NotificationService);
		}

		//mCustomR this class reicibe the action activity from music players.
		public class mCustomR:BroadcastReceiver
		{
			/// <param name="context">The Context in which the receiver is running.</param>
			/// <param name="intent">The Intent being received.</param>
			/// <summary>
			/// This method is called when the BroadcastReceiver is receiving an Intent
			///  broadcast.
			/// </summary>
			public override void OnReceive (Context context, Intent intent)
			{
				//get action from intent
				string action = intent.Action;
				//get command from action
				string cmd = intent.GetStringExtra("command");
				//write info
				Console.WriteLine("mIntentReceiver.onReceive " + action + " / " + cmd);
				//get artist from intent
				String artist = intent.GetStringExtra("artist");
				//get album from intent
				String album = intent.GetStringExtra("album");
				//get track from intent
				String track = intent.GetStringExtra("track");
				//write all info
				Console.WriteLine(artist+":"+album+":"+track);

				//set content title to notification builder
				builder.SetContentTitle (artist);
				//set contennt text to notification builder
				builder.SetContentText (track+"-"+album);
				//set big style to builder
				builder.SetStyle (new NotificationCompat.BigTextStyle ().BigText (track + "-" + album));
				try
				{
					//seach album thumbnail from itunes api
					var json = new System.Net.WebClient().DownloadString("http://itunes.apple.com/search?term=" + Uri.EscapeDataString(track+" "+album+" "+artist) + "&country=mx&limit=1&entity=song");
					//parse json downloaded to json object
					Newtonsoft.Json.Linq.JObject o = Newtonsoft.Json.Linq.JObject.Parse(json);
					//get json results child
					var n = o["results"];
					//get firts "artworkUrl100" property
					string val = (string)n[0]["artworkUrl100"];
					//check if exist thumbnail
					if (string.IsNullOrEmpty(val))
					{
						//if thumbnail doesnt exists set default image to largeicon
						builder.SetLargeIcon(BitmapFactory.DecodeResource(null,Resource.Drawable.ic_launcher));
					}
					else
					{
						//change 100x100 size of thumbnail to 600x600 image
						StringBuilder builde = new StringBuilder(val);
						builde.Replace("100x100", "600x600");
						//webclient to download image
						WebClient c = new WebClient();
						//downloadimage to bytearray
						byte[] data = c.DownloadData(builde.ToString());
						//convert byte[] downloaded to bitmap and set large icon to builder
						builder.SetLargeIcon(Bitmap.CreateScaledBitmap(BitmapFactory.DecodeByteArray(data,0,data.Length),150,150,false));
					}
				}
				catch(Exception e)
				{
					//set default image to largeicon
					builder.SetLargeIcon(BitmapFactory.DecodeResource(null,Resource.Drawable.ic_launcher));
				}
				//update/create a notification
				notificationManager.Notify(0, builder.Build());
			}
		}

		//class type service to work in background
		[Service]
		public class Mservice: Service
		{
			//Receiver class
			private mCustomR mReceiver = new mCustomR ();
			/// <summary>
			/// Raises the bind event.
			/// </summary>
			/// <param name="intent">Intent.</param>
			public override IBinder OnBind (Intent intent)
			{
				return null;
			}
			/// <summary>
			/// Called by the system when the service is first created.
			/// </summary>
			public override void OnCreate ()
			{
				base.OnCreate ();
				//IntentnFilter all actities to receive information
				IntentFilter iF = new IntentFilter();
				iF.AddAction("com.android.music.metachanged");
				iF.AddAction("com.android.music.playstatechanged");
				iF.AddAction("com.android.music.playbackcomplete");
				iF.AddAction("com.android.music.queuechanged");
				iF.AddAction("com.htc.music.metachanged");
				iF.AddAction("fm.last.android.metachanged");
				iF.AddAction("com.sec.android.app.music.metachanged");
				iF.AddAction("com.nullsoft.winamp.metachanged");
				iF.AddAction("com.amazon.mp3.metachanged");     
				iF.AddAction("com.miui.player.metachanged");        
				iF.AddAction("com.real.IMP.metachanged");
				iF.AddAction("com.sonyericsson.music.metachanged");
				iF.AddAction("com.rdio.android.metachanged");
				iF.AddAction("com.samsung.sec.android.MusicPlayer.metachanged");
				iF.AddAction("com.andrew.apollo.metachanged");
				//register receiver with intentnfilter
				RegisterReceiver(mReceiver, iF);
			}
			public override void OnDestroy ()
			{
				base.OnDestroy ();
			}
		}
	}
}


