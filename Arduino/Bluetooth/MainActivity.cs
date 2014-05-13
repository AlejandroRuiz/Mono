using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;
using Java.Util;
using Android.Bluetooth;
using System.Threading.Tasks;
namespace Bluetooth
{
	[Activity (Label = "Bluetooth", MainLauncher = true)]
	public class MainActivity : Activity
	{
		ToggleButton tgConnect;
		TextView Result;
		private Java.Lang.String dataToSend;
		private BluetoothAdapter mBluetoothAdapter = null;
		private BluetoothSocket btSocket = null;
		private Stream outStream = null;
		private Stream inStream = null;
		private static string address = "00:13:01:07:01:59";
		private static UUID MY_UUID = UUID.FromString("00001101-0000-1000-8000-00805F9B34FB");
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);
			tgConnect = FindViewById<ToggleButton>(Resource.Id.toggleButton1);
			Result = FindViewById<TextView>(Resource.Id.textView1);
			tgConnect.CheckedChange += tgConnect_HandleCheckedChange;
			CheckBt();
		}
		private void CheckBt() {
			mBluetoothAdapter = BluetoothAdapter.DefaultAdapter;
			if (!mBluetoothAdapter.Enable()) {
				Toast.MakeText(this, "Bluetooth Desactivado",
					ToastLength.Short).Show();
			}
			if (mBluetoothAdapter == null) {
				Toast.MakeText(this,
					"Bluetooth No Existe o esta Ocupado", ToastLength.Short)
					.Show();
			}
		}
		void tgConnect_HandleCheckedChange (object sender, CompoundButton.CheckedChangeEventArgs e)
		{
			if (e.IsChecked) {
				Connect();
			} else {
				if (btSocket.IsConnected) {
					try {
						btSocket.Close();
					} catch (System.Exception ex) {
						Console.WriteLine (ex.Message);
					}
				}
			}
		}
		public void Connect() {
			BluetoothDevice device = mBluetoothAdapter.GetRemoteDevice(address);
			System.Console.WriteLine("Conexion en curso" + device);
			mBluetoothAdapter.CancelDiscovery();
			try {
				btSocket = device.CreateRfcommSocketToServiceRecord(MY_UUID);
				btSocket.Connect();
				System.Console.WriteLine("Conexion Correcta");
			} catch (System.Exception e) {
				Console.WriteLine (e.Message);
				try {
					btSocket.Close();
				} catch (System.Exception) {
					System.Console.WriteLine("Imposible Conectar");
				}
				System.Console.WriteLine("Socket Creado");
			}
			beginListenForData();
			dataToSend = new Java.Lang.String("e");
			writeData(dataToSend);
		}
		public void beginListenForData()   {
			try {
				inStream = btSocket.InputStream;
			} catch (System.IO.IOException ex) {
				Console.WriteLine (ex.Message);
			}
			Task.Factory.StartNew (() => {
				byte[] buffer = new byte[1024];
				int bytes;
				while (true) {
					try {
						bytes = inStream.Read(buffer, 0, buffer.Length);
						if(bytes>0)
						{
							RunOnUiThread(()=>{
								string valor = System.Text.Encoding.ASCII.GetString (buffer);
								Result.Text = Result.Text+"\n"+valor;                    
							});
						}
					} catch (Java.IO.IOException) {
						RunOnUiThread(()=>{
							Result.Text = string.Empty;                    
						});
						break;
					}
				}
			});
		}
		private void writeData(Java.Lang.String data) {
			try {
				outStream = btSocket.OutputStream;
			} catch (System.Exception e) {
				System.Console.WriteLine("Error al enviar"+e.Message);
			}
			Java.Lang.String message = data;
			byte[] msgBuffer = message.GetBytes();

			try {
				outStream.Write(msgBuffer, 0, msgBuffer.Length);
			} catch (System.Exception e) {
				System.Console.WriteLine("Error al enviar"+e.Message);
			}
		}
	}
} 