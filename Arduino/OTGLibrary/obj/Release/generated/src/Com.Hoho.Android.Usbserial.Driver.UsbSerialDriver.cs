using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Hoho.Android.Usbserial.Driver {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialDriver']"
	[global::Android.Runtime.Register ("com/hoho/android/usbserial/driver/UsbSerialDriver", DoNotGenerateAcw=true)]
	public abstract partial class UsbSerialDriver : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialDriver']/field[@name='DEFAULT_READ_BUFFER_SIZE']"
		[Register ("DEFAULT_READ_BUFFER_SIZE")]
		public const int DefaultReadBufferSize = (int) 16384;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialDriver']/field[@name='DEFAULT_WRITE_BUFFER_SIZE']"
		[Register ("DEFAULT_WRITE_BUFFER_SIZE")]
		public const int DefaultWriteBufferSize = (int) 16384;

		static IntPtr mConnection_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialDriver']/field[@name='mConnection']"
		[Register ("mConnection")]
		protected global::Android.Hardware.Usb.UsbDeviceConnection MConnection {
			get {
				if (mConnection_jfieldId == IntPtr.Zero)
					mConnection_jfieldId = JNIEnv.GetFieldID (class_ref, "mConnection", "Landroid/hardware/usb/UsbDeviceConnection;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mConnection_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Hardware.Usb.UsbDeviceConnection> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mConnection_jfieldId == IntPtr.Zero)
					mConnection_jfieldId = JNIEnv.GetFieldID (class_ref, "mConnection", "Landroid/hardware/usb/UsbDeviceConnection;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mConnection_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mDevice_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialDriver']/field[@name='mDevice']"
		[Register ("mDevice")]
		protected global::Android.Hardware.Usb.UsbDevice MDevice {
			get {
				if (mDevice_jfieldId == IntPtr.Zero)
					mDevice_jfieldId = JNIEnv.GetFieldID (class_ref, "mDevice", "Landroid/hardware/usb/UsbDevice;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mDevice_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Hardware.Usb.UsbDevice> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDevice_jfieldId == IntPtr.Zero)
					mDevice_jfieldId = JNIEnv.GetFieldID (class_ref, "mDevice", "Landroid/hardware/usb/UsbDevice;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mDevice_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mReadBuffer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialDriver']/field[@name='mReadBuffer']"
		[Register ("mReadBuffer")]
		protected IList<byte> MReadBuffer {
			get {
				if (mReadBuffer_jfieldId == IntPtr.Zero)
					mReadBuffer_jfieldId = JNIEnv.GetFieldID (class_ref, "mReadBuffer", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, mReadBuffer_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mReadBuffer_jfieldId == IntPtr.Zero)
					mReadBuffer_jfieldId = JNIEnv.GetFieldID (class_ref, "mReadBuffer", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mReadBuffer_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mReadBufferLock_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialDriver']/field[@name='mReadBufferLock']"
		[Register ("mReadBufferLock")]
		protected global::Java.Lang.Object MReadBufferLock {
			get {
				if (mReadBufferLock_jfieldId == IntPtr.Zero)
					mReadBufferLock_jfieldId = JNIEnv.GetFieldID (class_ref, "mReadBufferLock", "Ljava/lang/Object;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mReadBufferLock_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mReadBufferLock_jfieldId == IntPtr.Zero)
					mReadBufferLock_jfieldId = JNIEnv.GetFieldID (class_ref, "mReadBufferLock", "Ljava/lang/Object;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mReadBufferLock_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mWriteBuffer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialDriver']/field[@name='mWriteBuffer']"
		[Register ("mWriteBuffer")]
		protected IList<byte> MWriteBuffer {
			get {
				if (mWriteBuffer_jfieldId == IntPtr.Zero)
					mWriteBuffer_jfieldId = JNIEnv.GetFieldID (class_ref, "mWriteBuffer", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, mWriteBuffer_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mWriteBuffer_jfieldId == IntPtr.Zero)
					mWriteBuffer_jfieldId = JNIEnv.GetFieldID (class_ref, "mWriteBuffer", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mWriteBuffer_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mWriteBufferLock_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialDriver']/field[@name='mWriteBufferLock']"
		[Register ("mWriteBufferLock")]
		protected global::Java.Lang.Object MWriteBufferLock {
			get {
				if (mWriteBufferLock_jfieldId == IntPtr.Zero)
					mWriteBufferLock_jfieldId = JNIEnv.GetFieldID (class_ref, "mWriteBufferLock", "Ljava/lang/Object;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mWriteBufferLock_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mWriteBufferLock_jfieldId == IntPtr.Zero)
					mWriteBufferLock_jfieldId = JNIEnv.GetFieldID (class_ref, "mWriteBufferLock", "Ljava/lang/Object;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mWriteBufferLock_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/hoho/android/usbserial/driver/UsbSerialDriver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UsbSerialDriver); }
		}

		protected UsbSerialDriver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_hardware_usb_UsbDevice_Landroid_hardware_usb_UsbDeviceConnection_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialDriver']/constructor[@name='UsbSerialDriver' and count(parameter)=2 and parameter[1][@type='android.hardware.usb.UsbDevice'] and parameter[2][@type='android.hardware.usb.UsbDeviceConnection']]"
		[Register (".ctor", "(Landroid/hardware/usb/UsbDevice;Landroid/hardware/usb/UsbDeviceConnection;)V", "")]
		public UsbSerialDriver (global::Android.Hardware.Usb.UsbDevice p0, global::Android.Hardware.Usb.UsbDeviceConnection p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (UsbSerialDriver)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/hardware/usb/UsbDevice;Landroid/hardware/usb/UsbDeviceConnection;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/hardware/usb/UsbDevice;Landroid/hardware/usb/UsbDeviceConnection;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_hardware_usb_UsbDevice_Landroid_hardware_usb_UsbDeviceConnection_ == IntPtr.Zero)
				id_ctor_Landroid_hardware_usb_UsbDevice_Landroid_hardware_usb_UsbDeviceConnection_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/hardware/usb/UsbDevice;Landroid/hardware/usb/UsbDeviceConnection;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_hardware_usb_UsbDevice_Landroid_hardware_usb_UsbDeviceConnection_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_hardware_usb_UsbDevice_Landroid_hardware_usb_UsbDeviceConnection_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_getDevice;
		public global::Android.Hardware.Usb.UsbDevice Device {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialDriver']/method[@name='getDevice' and count(parameter)=0]"
			[Register ("getDevice", "()Landroid/hardware/usb/UsbDevice;", "GetGetDeviceHandler")]
			get {
				if (id_getDevice == IntPtr.Zero)
					id_getDevice = JNIEnv.GetMethodID (class_ref, "getDevice", "()Landroid/hardware/usb/UsbDevice;");
				return global::Java.Lang.Object.GetObject<global::Android.Hardware.Usb.UsbDevice> (JNIEnv.CallObjectMethod  (Handle, id_getDevice), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hoho.Android.Usbserial.Driver.UsbSerialDriver __this = global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Driver.UsbSerialDriver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialDriver']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public abstract void Close ();

		static Delegate cb_open;
#pragma warning disable 0169
		static Delegate GetOpenHandler ()
		{
			if (cb_open == null)
				cb_open = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Open);
			return cb_open;
		}

		static void n_Open (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hoho.Android.Usbserial.Driver.UsbSerialDriver __this = global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Driver.UsbSerialDriver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Open ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialDriver']/method[@name='open' and count(parameter)=0]"
		[Register ("open", "()V", "GetOpenHandler")]
		public abstract void Open ();

		static Delegate cb_read_arrayBI;
#pragma warning disable 0169
		static Delegate GetRead_arrayBIHandler ()
		{
			if (cb_read_arrayBI == null)
				cb_read_arrayBI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_Read_arrayBI);
			return cb_read_arrayBI;
		}

		static int n_Read_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Hoho.Android.Usbserial.Driver.UsbSerialDriver __this = global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Driver.UsbSerialDriver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Read (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialDriver']/method[@name='read' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("read", "([BI)I", "GetRead_arrayBIHandler")]
		public abstract int Read (byte[] p0, int p1);

		static Delegate cb_setBaudRate_I;
#pragma warning disable 0169
		static Delegate GetSetBaudRate_IHandler ()
		{
			if (cb_setBaudRate_I == null)
				cb_setBaudRate_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_SetBaudRate_I);
			return cb_setBaudRate_I;
		}

		static int n_SetBaudRate_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Hoho.Android.Usbserial.Driver.UsbSerialDriver __this = global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Driver.UsbSerialDriver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetBaudRate (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialDriver']/method[@name='setBaudRate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBaudRate", "(I)I", "GetSetBaudRate_IHandler")]
		public abstract int SetBaudRate (int p0);

		static IntPtr id_setReadBufferSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialDriver']/method[@name='setReadBufferSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setReadBufferSize", "(I)V", "")]
		public void SetReadBufferSize (int p0)
		{
			if (id_setReadBufferSize_I == IntPtr.Zero)
				id_setReadBufferSize_I = JNIEnv.GetMethodID (class_ref, "setReadBufferSize", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setReadBufferSize_I, new JValue (p0));
		}

		static IntPtr id_setWriteBufferSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialDriver']/method[@name='setWriteBufferSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setWriteBufferSize", "(I)V", "")]
		public void SetWriteBufferSize (int p0)
		{
			if (id_setWriteBufferSize_I == IntPtr.Zero)
				id_setWriteBufferSize_I = JNIEnv.GetMethodID (class_ref, "setWriteBufferSize", "(I)V");
			JNIEnv.CallVoidMethod  (Handle, id_setWriteBufferSize_I, new JValue (p0));
		}

		static Delegate cb_write_arrayBI;
#pragma warning disable 0169
		static Delegate GetWrite_arrayBIHandler ()
		{
			if (cb_write_arrayBI == null)
				cb_write_arrayBI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_Write_arrayBI);
			return cb_write_arrayBI;
		}

		static int n_Write_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Hoho.Android.Usbserial.Driver.UsbSerialDriver __this = global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Driver.UsbSerialDriver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Write (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialDriver']/method[@name='write' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("write", "([BI)I", "GetWrite_arrayBIHandler")]
		public abstract int Write (byte[] p0, int p1);

	}

	[global::Android.Runtime.Register ("com/hoho/android/usbserial/driver/UsbSerialDriver", DoNotGenerateAcw=true)]
	internal partial class UsbSerialDriverInvoker : UsbSerialDriver {

		public UsbSerialDriverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (UsbSerialDriverInvoker); }
		}

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialDriver']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_close);
		}

		static IntPtr id_open;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialDriver']/method[@name='open' and count(parameter)=0]"
		[Register ("open", "()V", "GetOpenHandler")]
		public override void Open ()
		{
			if (id_open == IntPtr.Zero)
				id_open = JNIEnv.GetMethodID (class_ref, "open", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_open);
		}

		static IntPtr id_read_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialDriver']/method[@name='read' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("read", "([BI)I", "GetRead_arrayBIHandler")]
		public override int Read (byte[] p0, int p1)
		{
			if (id_read_arrayBI == IntPtr.Zero)
				id_read_arrayBI = JNIEnv.GetMethodID (class_ref, "read", "([BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			int __ret = JNIEnv.CallIntMethod  (Handle, id_read_arrayBI, new JValue (native_p0), new JValue (p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_setBaudRate_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialDriver']/method[@name='setBaudRate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBaudRate", "(I)I", "GetSetBaudRate_IHandler")]
		public override int SetBaudRate (int p0)
		{
			if (id_setBaudRate_I == IntPtr.Zero)
				id_setBaudRate_I = JNIEnv.GetMethodID (class_ref, "setBaudRate", "(I)I");
			return JNIEnv.CallIntMethod  (Handle, id_setBaudRate_I, new JValue (p0));
		}

		static IntPtr id_write_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.driver']/class[@name='UsbSerialDriver']/method[@name='write' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("write", "([BI)I", "GetWrite_arrayBIHandler")]
		public override int Write (byte[] p0, int p1)
		{
			if (id_write_arrayBI == IntPtr.Zero)
				id_write_arrayBI = JNIEnv.GetMethodID (class_ref, "write", "([BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			int __ret = JNIEnv.CallIntMethod  (Handle, id_write_arrayBI, new JValue (native_p0), new JValue (p1));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}

}
