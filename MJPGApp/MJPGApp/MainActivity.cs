using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Com.Camera.Simplemjpeg;
using System.Threading.Tasks;

namespace MJPGApp
{
	[Activity (Label = "MJPGApp", MainLauncher = true)]
	public class MainActivity : Activity
	{
		private MjpegView mv = null;
		Button button=null;
		EditText txturl=null;
		String URL = "http://webcam.st-malo.com/axis-cgi/mjpg/video.cgi?resolution=640x480";

		private int width = 640;
		private int height = 480;

		private bool suspending = false;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			mv = FindViewById<MjpegView>(Resource.Id.mv);
			if (mv != null)
			{
				mv.SetResolution(width, height);
			}

			button = FindViewById<Button> (Resource.Id.myButton);
			txturl = FindViewById<EditText> (Resource.Id.editText1);
			button.Click += delegate {
				URL = txturl.Text;
				BeginStreaming(URL);
			};
			BeginStreaming(URL);
		}

		protected override void OnResume()
		{
			base.OnResume();
			if (mv != null)
			{
				if (suspending)
				{
					BeginStreaming(URL);
					suspending = false;
				}
			}
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
			if (mv != null)
			{
				mv.FreeCameraMemory();
			}
		}

		protected override void OnPause()
		{
			base.OnPause();
			if (mv != null)
			{
				if (mv.IsStreaming)
				{
					mv.StopPlayback();
					suspending = true;
				}
			}
		}

		public void BeginStreaming(string url)
		{
			Task.Factory.StartNew(() =>
				{
					try
					{
						return MjpegInputStream.Read(url);
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
					return null;
				}).ContinueWith((t) =>
					{
						mv.SetSource(t.Result);
						if (t.Result != null)
						{
							t.Result.SetSkip(1);
							Title = "Connected";
						}
						else
						{
							Title = "Disconnected";
						}
						mv.SetDisplayMode(MjpegView.SizeFullscreen);
						mv.ShowFps(false);
					});
		}


	}
}


