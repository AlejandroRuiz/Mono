using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Hoho.Android.Usbserial.Driver {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialProber']"
	[global::Android.Runtime.Register ("com/hoho/android/usbserial/driver/UsbSerialProber", DoNotGenerateAcw=true)]
	public abstract partial class UsbSerialProber : global::Java.Lang.Enum {


		static IntPtr CDC_ACM_SERIAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialProber']/field[@name='CDC_ACM_SERIAL']"
		[Register ("CDC_ACM_SERIAL")]
		public static global::Com.Hoho.Android.Usbserial.Driver.UsbSerialProber CdcAcmSerial {
			get {
				if (CDC_ACM_SERIAL_jfieldId == IntPtr.Zero)
					CDC_ACM_SERIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CDC_ACM_SERIAL", "Lcom/hoho/android/usbserial/driver/UsbSerialProber;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CDC_ACM_SERIAL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Driver.UsbSerialProber> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CDC_ACM_SERIAL_jfieldId == IntPtr.Zero)
					CDC_ACM_SERIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CDC_ACM_SERIAL", "Lcom/hoho/android/usbserial/driver/UsbSerialProber;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CDC_ACM_SERIAL_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr FTDI_SERIAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialProber']/field[@name='FTDI_SERIAL']"
		[Register ("FTDI_SERIAL")]
		public static global::Com.Hoho.Android.Usbserial.Driver.UsbSerialProber FtdiSerial {
			get {
				if (FTDI_SERIAL_jfieldId == IntPtr.Zero)
					FTDI_SERIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FTDI_SERIAL", "Lcom/hoho/android/usbserial/driver/UsbSerialProber;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FTDI_SERIAL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Driver.UsbSerialProber> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FTDI_SERIAL_jfieldId == IntPtr.Zero)
					FTDI_SERIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FTDI_SERIAL", "Lcom/hoho/android/usbserial/driver/UsbSerialProber;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, FTDI_SERIAL_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/hoho/android/usbserial/driver/UsbSerialProber", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UsbSerialProber); }
		}

		protected UsbSerialProber (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_acquire_Landroid_hardware_usb_UsbManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialProber']/method[@name='acquire' and count(parameter)=1 and parameter[1][@type='android.hardware.usb.UsbManager']]"
		[Register ("acquire", "(Landroid/hardware/usb/UsbManager;)Lcom/hoho/android/usbserial/driver/UsbSerialDriver;", "")]
		public static global::Com.Hoho.Android.Usbserial.Driver.UsbSerialDriver Acquire (global::Android.Hardware.Usb.UsbManager p0)
		{
			if (id_acquire_Landroid_hardware_usb_UsbManager_ == IntPtr.Zero)
				id_acquire_Landroid_hardware_usb_UsbManager_ = JNIEnv.GetStaticMethodID (class_ref, "acquire", "(Landroid/hardware/usb/UsbManager;)Lcom/hoho/android/usbserial/driver/UsbSerialDriver;");
			global::Com.Hoho.Android.Usbserial.Driver.UsbSerialDriver __ret = global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Driver.UsbSerialDriver> (JNIEnv.CallStaticObjectMethod  (class_ref, id_acquire_Landroid_hardware_usb_UsbManager_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_acquire_Landroid_hardware_usb_UsbManager_Landroid_hardware_usb_UsbDevice_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialProber']/method[@name='acquire' and count(parameter)=2 and parameter[1][@type='android.hardware.usb.UsbManager'] and parameter[2][@type='android.hardware.usb.UsbDevice']]"
		[Register ("acquire", "(Landroid/hardware/usb/UsbManager;Landroid/hardware/usb/UsbDevice;)Lcom/hoho/android/usbserial/driver/UsbSerialDriver;", "")]
		public static global::Com.Hoho.Android.Usbserial.Driver.UsbSerialDriver Acquire (global::Android.Hardware.Usb.UsbManager p0, global::Android.Hardware.Usb.UsbDevice p1)
		{
			if (id_acquire_Landroid_hardware_usb_UsbManager_Landroid_hardware_usb_UsbDevice_ == IntPtr.Zero)
				id_acquire_Landroid_hardware_usb_UsbManager_Landroid_hardware_usb_UsbDevice_ = JNIEnv.GetStaticMethodID (class_ref, "acquire", "(Landroid/hardware/usb/UsbManager;Landroid/hardware/usb/UsbDevice;)Lcom/hoho/android/usbserial/driver/UsbSerialDriver;");
			global::Com.Hoho.Android.Usbserial.Driver.UsbSerialDriver __ret = global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Driver.UsbSerialDriver> (JNIEnv.CallStaticObjectMethod  (class_ref, id_acquire_Landroid_hardware_usb_UsbManager_Landroid_hardware_usb_UsbDevice_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getDevice_Landroid_hardware_usb_UsbManager_Landroid_hardware_usb_UsbDevice_;
#pragma warning disable 0169
		static Delegate GetGetDevice_Landroid_hardware_usb_UsbManager_Landroid_hardware_usb_UsbDevice_Handler ()
		{
			if (cb_getDevice_Landroid_hardware_usb_UsbManager_Landroid_hardware_usb_UsbDevice_ == null)
				cb_getDevice_Landroid_hardware_usb_UsbManager_Landroid_hardware_usb_UsbDevice_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDevice_Landroid_hardware_usb_UsbManager_Landroid_hardware_usb_UsbDevice_);
			return cb_getDevice_Landroid_hardware_usb_UsbManager_Landroid_hardware_usb_UsbDevice_;
		}

		static IntPtr n_GetDevice_Landroid_hardware_usb_UsbManager_Landroid_hardware_usb_UsbDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Hoho.Android.Usbserial.Driver.UsbSerialProber __this = global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Driver.UsbSerialProber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.Usb.UsbManager p0 = global::Java.Lang.Object.GetObject<global::Android.Hardware.Usb.UsbManager> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.Usb.UsbDevice p1 = global::Java.Lang.Object.GetObject<global::Android.Hardware.Usb.UsbDevice> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDevice (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialProber']/method[@name='getDevice' and count(parameter)=2 and parameter[1][@type='android.hardware.usb.UsbManager'] and parameter[2][@type='android.hardware.usb.UsbDevice']]"
		[Register ("getDevice", "(Landroid/hardware/usb/UsbManager;Landroid/hardware/usb/UsbDevice;)Lcom/hoho/android/usbserial/driver/UsbSerialDriver;", "GetGetDevice_Landroid_hardware_usb_UsbManager_Landroid_hardware_usb_UsbDevice_Handler")]
		public abstract global::Com.Hoho.Android.Usbserial.Driver.UsbSerialDriver GetDevice (global::Android.Hardware.Usb.UsbManager p0, global::Android.Hardware.Usb.UsbDevice p1);

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialProber']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/hoho/android/usbserial/driver/UsbSerialProber;", "")]
		public static global::Com.Hoho.Android.Usbserial.Driver.UsbSerialProber ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/hoho/android/usbserial/driver/UsbSerialProber;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Hoho.Android.Usbserial.Driver.UsbSerialProber __ret = global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Driver.UsbSerialProber> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialProber']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/hoho/android/usbserial/driver/UsbSerialProber;", "")]
		public static global::Com.Hoho.Android.Usbserial.Driver.UsbSerialProber[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/hoho/android/usbserial/driver/UsbSerialProber;");
			return (global::Com.Hoho.Android.Usbserial.Driver.UsbSerialProber[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Hoho.Android.Usbserial.Driver.UsbSerialProber));
		}

	}

	[global::Android.Runtime.Register ("com/hoho/android/usbserial/driver/UsbSerialProber", DoNotGenerateAcw=true)]
	internal partial class UsbSerialProberInvoker : UsbSerialProber {

		public UsbSerialProberInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (UsbSerialProberInvoker); }
		}

		static IntPtr id_getDevice_Landroid_hardware_usb_UsbManager_Landroid_hardware_usb_UsbDevice_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialProber']/method[@name='getDevice' and count(parameter)=2 and parameter[1][@type='android.hardware.usb.UsbManager'] and parameter[2][@type='android.hardware.usb.UsbDevice']]"
		[Register ("getDevice", "(Landroid/hardware/usb/UsbManager;Landroid/hardware/usb/UsbDevice;)Lcom/hoho/android/usbserial/driver/UsbSerialDriver;", "GetGetDevice_Landroid_hardware_usb_UsbManager_Landroid_hardware_usb_UsbDevice_Handler")]
		public override global::Com.Hoho.Android.Usbserial.Driver.UsbSerialDriver GetDevice (global::Android.Hardware.Usb.UsbManager p0, global::Android.Hardware.Usb.UsbDevice p1)
		{
			if (id_getDevice_Landroid_hardware_usb_UsbManager_Landroid_hardware_usb_UsbDevice_ == IntPtr.Zero)
				id_getDevice_Landroid_hardware_usb_UsbManager_Landroid_hardware_usb_UsbDevice_ = JNIEnv.GetMethodID (class_ref, "getDevice", "(Landroid/hardware/usb/UsbManager;Landroid/hardware/usb/UsbDevice;)Lcom/hoho/android/usbserial/driver/UsbSerialDriver;");
			global::Com.Hoho.Android.Usbserial.Driver.UsbSerialDriver __ret = global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Driver.UsbSerialDriver> (JNIEnv.CallObjectMethod  (Handle, id_getDevice_Landroid_hardware_usb_UsbManager_Landroid_hardware_usb_UsbDevice_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
