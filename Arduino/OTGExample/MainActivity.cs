using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Hardware.Usb;
using Com.Hoho.Android.Usbserial.Driver;
using System.IO;
using System.Threading.Tasks;
using Com.Hoho.Android.Usbserial.Util;

namespace OTGExample
{
	[Activity (Label = "OTGExample", MainLauncher = true)]
	[IntentFilter (new[]{"android.hardware.usb.action.USB_DEVICE_ATTACHED"})]
	[MetaData ("android.hardware.usb.action.USB_DEVICE_ATTACHED", Resource = "@xml/device_filter")]
	public class MainActivity : Activity
	{
		ToggleButton tgConnect=null;
		TextView Result=null;
		UsbManager manager=null;
		UsbSerialDriver driver=null;
		private Java.Lang.String dataToSend;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);
			manager = (UsbManager)this.GetSystemService (Context.UsbService);
			tgConnect = FindViewById<ToggleButton>(Resource.Id.toggleButton1);
			Result = FindViewById<TextView>(Resource.Id.textView1);
			tgConnect.CheckedChange += tgConnect_HandleCheckedChange;
		}

		void tgConnect_HandleCheckedChange (object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (e.IsChecked) {
				driver = UsbSerialProber.Acquire(manager);
				if (driver != null) {
					driver.Open ();
					driver.SetBaudRate (9600);
					beginListenForData ();
					dataToSend = new Java.Lang.String("e");
					writeData(dataToSend);
				}
				else
				{
					Toast.MakeText (this, "Error Arduino no detectado", ToastLength.Short).Show();
				}
			} else {
					try {
						driver.Close();
					} catch (System.Exception ex) {
						Console.WriteLine (ex.Message);
					}
			}
		}

		public void beginListenForData()   {
			Task.Factory.StartNew (() => {
				byte[] buffer = new byte[1024];
				int bytes;
				while (true) {
					try {
						bytes = driver.Read(buffer, buffer.Length);
						if(bytes>0)
						{
							RunOnUiThread(()=>{
								string valor = System.Text.Encoding.ASCII.GetString (buffer);
								Result.Text = Result.Text+"\n"+valor;                    
							});
						}
					} catch (Exception e) {
						driver.Close();
						RunOnUiThread(()=>{
							Toast.MakeText (this, e.Message, ToastLength.Short).Show ();
							Result.Text = string.Empty;                    
						});
						break;
					}
				}
			});
		}

		private void writeData(Java.Lang.String data) {
			Java.Lang.String message = data;
			byte[] msgBuffer = message.GetBytes();
			try {
				driver.Write(msgBuffer, 0);
			} catch (System.Exception e) {
				Toast.MakeText (this, e.Message, ToastLength.Short).Show ();
				System.Console.WriteLine("Error al enviar"+e.Message);
			}
		}
	}
}