using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Net.Http;
using System.IO;
using Android.Graphics;
using AndroidHUD;
using System.Threading.Tasks;

namespace Responsive
{
	[Activity (Label = "Responsive  App", MainLauncher = true)]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button AsyncButton = FindViewById<Button> (Resource.Id.btnAsync);
			Button ParallelButton = FindViewById<Button> (Resource.Id.btnParallel);
			TextView LabelSize = FindViewById<TextView> (Resource.Id.lblSize);
			ImageView ImageDonwloaded = FindViewById<ImageView> (Resource.Id.imageD);
			CheckBox ckbHUD = FindViewById<CheckBox> (Resource.Id.checkBoxHUD);
			var showHUD = false;

			ParallelButton.Click += (sender, e) => {
				showHUD = ckbHUD.Checked;
				Task.Factory.StartNew(()=>{
					if(showHUD)
						AndHUD.Shared.Show(this, "Downloading Image via Parallel", -1, MaskType.Clear);
					var httpClient = new HttpClient();
					byte[] imageBytes  = httpClient.GetByteArrayAsync("http://upload.wikimedia.org/wikipedia/commons/6/66/Big_size_chess_6759_CRI_08_2009_Langosta_Beach.jpg").Result;
					return imageBytes; 
				}).ContinueWith(res=>{
					string documents = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
					string localPath = System.IO.Path.Combine (documents, "image.png");
					File.WriteAllBytes (localPath, res.Result);
					var localImage = new Java.IO.File (localPath);
					if (localImage.Exists ()) {
						var teamBitmap = BitmapFactory.DecodeFile (localImage.AbsolutePath);
						RunOnUiThread(()=>{
							LabelSize.Text = string.Format("Size: {0} MB", ConvertBytesToMegabytes(res.Result.Length));
							ImageDonwloaded.SetImageBitmap (teamBitmap);
						});
					}
					if(showHUD)
						AndHUD.Shared.Dismiss(this);
				});
			};

			AsyncButton.Click += async (sender, e) => {
				showHUD = ckbHUD.Checked;
				if(showHUD)
					AndHUD.Shared.Show(this, "Downloading Image via Async/Await", -1, MaskType.Clear);
				var httpClient = new HttpClient();
				byte[] imageBytes  = await httpClient.GetByteArrayAsync("http://upload.wikimedia.org/wikipedia/commons/6/66/Big_size_chess_6759_CRI_08_2009_Langosta_Beach.jpg");
				string documents = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
				string localPath = System.IO.Path.Combine (documents, "image.png");
				File.WriteAllBytes (localPath, imageBytes);
				var localImage = new Java.IO.File (localPath);
				if (localImage.Exists ()) {
					var teamBitmap = BitmapFactory.DecodeFile (localImage.AbsolutePath);
					LabelSize.Text = string.Format("Size: {0} MB", ConvertBytesToMegabytes(imageBytes.Length));
					ImageDonwloaded.SetImageBitmap (teamBitmap);
				}
				if(showHUD)
					AndHUD.Shared.Dismiss(this);
			};
		}

		static double ConvertBytesToMegabytes(long bytes)
		{
			return (bytes / 1024f) / 1024f;
		}
	}
}


