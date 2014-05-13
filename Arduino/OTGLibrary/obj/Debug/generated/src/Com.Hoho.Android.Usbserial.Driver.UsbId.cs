using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Hoho.Android.Usbserial.Driver {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbId']"
	[global::Android.Runtime.Register ("com/hoho/android/usbserial/driver/UsbId", DoNotGenerateAcw=true)]
	public sealed partial class UsbId : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbId']/field[@name='ARDUINO_LEONARDO']"
		[Register ("ARDUINO_LEONARDO")]
		public const int ArduinoLeonardo = (int) 32822;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbId']/field[@name='ARDUINO_MEGA_2560']"
		[Register ("ARDUINO_MEGA_2560")]
		public const int ArduinoMega2560 = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbId']/field[@name='ARDUINO_MEGA_2560_R3']"
		[Register ("ARDUINO_MEGA_2560_R3")]
		public const int ArduinoMega2560R3 = (int) 66;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbId']/field[@name='ARDUINO_MEGA_ADK']"
		[Register ("ARDUINO_MEGA_ADK")]
		public const int ArduinoMegaAdk = (int) 63;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbId']/field[@name='ARDUINO_MEGA_ADK_R3']"
		[Register ("ARDUINO_MEGA_ADK_R3")]
		public const int ArduinoMegaAdkR3 = (int) 68;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbId']/field[@name='ARDUINO_SERIAL_ADAPTER']"
		[Register ("ARDUINO_SERIAL_ADAPTER")]
		public const int ArduinoSerialAdapter = (int) 59;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbId']/field[@name='ARDUINO_SERIAL_ADAPTER_R3']"
		[Register ("ARDUINO_SERIAL_ADAPTER_R3")]
		public const int ArduinoSerialAdapterR3 = (int) 68;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbId']/field[@name='ARDUINO_UNO']"
		[Register ("ARDUINO_UNO")]
		public const int ArduinoUno = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbId']/field[@name='ARDUINO_UNO_R3']"
		[Register ("ARDUINO_UNO_R3")]
		public const int ArduinoUnoR3 = (int) 67;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbId']/field[@name='FTDI_FT232R']"
		[Register ("FTDI_FT232R")]
		public const int FtdiFt232r = (int) 24577;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbId']/field[@name='VAN_OOIJEN_TECH_TEENSYDUINO_SERIAL']"
		[Register ("VAN_OOIJEN_TECH_TEENSYDUINO_SERIAL")]
		public const int VanOoijenTechTeensyduinoSerial = (int) 1155;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbId']/field[@name='VENDOR_ARDUINO']"
		[Register ("VENDOR_ARDUINO")]
		public const int VendorArduino = (int) 9025;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbId']/field[@name='VENDOR_FTDI']"
		[Register ("VENDOR_FTDI")]
		public const int VendorFtdi = (int) 1027;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbId']/field[@name='VENDOR_VAN_OOIJEN_TECH']"
		[Register ("VENDOR_VAN_OOIJEN_TECH")]
		public const int VendorVanOoijenTech = (int) 5824;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/hoho/android/usbserial/driver/UsbId", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UsbId); }
		}

		internal UsbId (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
