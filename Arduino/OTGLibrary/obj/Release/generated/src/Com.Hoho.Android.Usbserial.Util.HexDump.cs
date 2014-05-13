using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Hoho.Android.Usbserial.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.hoho.android.usbserial.util']/class[@name='HexDump']"
	[global::Android.Runtime.Register ("com/hoho/android/usbserial/util/HexDump", DoNotGenerateAcw=true)]
	public partial class HexDump : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/hoho/android/usbserial/util/HexDump", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HexDump); }
		}

		protected HexDump (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.hoho.android.usbserial.util']/class[@name='HexDump']/constructor[@name='HexDump' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public HexDump () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (HexDump)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static IntPtr id_dumpHexString_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.util']/class[@name='HexDump']/method[@name='dumpHexString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("dumpHexString", "([B)Ljava/lang/String;", "")]
		public static string DumpHexString (byte[] p0)
		{
			if (id_dumpHexString_arrayB == IntPtr.Zero)
				id_dumpHexString_arrayB = JNIEnv.GetStaticMethodID (class_ref, "dumpHexString", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_dumpHexString_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_dumpHexString_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.util']/class[@name='HexDump']/method[@name='dumpHexString' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("dumpHexString", "([BII)Ljava/lang/String;", "")]
		public static string DumpHexString (byte[] p0, int p1, int p2)
		{
			if (id_dumpHexString_arrayBII == IntPtr.Zero)
				id_dumpHexString_arrayBII = JNIEnv.GetStaticMethodID (class_ref, "dumpHexString", "([BII)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_dumpHexString_arrayBII, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_hexStringToByteArray_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.util']/class[@name='HexDump']/method[@name='hexStringToByteArray' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hexStringToByteArray", "(Ljava/lang/String;)[B", "")]
		public static byte[] HexStringToByteArray (string p0)
		{
			if (id_hexStringToByteArray_Ljava_lang_String_ == IntPtr.Zero)
				id_hexStringToByteArray_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hexStringToByteArray", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_hexStringToByteArray_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_toByteArray_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.util']/class[@name='HexDump']/method[@name='toByteArray' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("toByteArray", "(B)[B", "")]
		public static byte[] ToByteArray (sbyte p0)
		{
			if (id_toByteArray_B == IntPtr.Zero)
				id_toByteArray_B = JNIEnv.GetStaticMethodID (class_ref, "toByteArray", "(B)[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toByteArray_B, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static IntPtr id_toByteArray_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.util']/class[@name='HexDump']/method[@name='toByteArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("toByteArray", "(I)[B", "")]
		public static byte[] ToByteArray (int p0)
		{
			if (id_toByteArray_I == IntPtr.Zero)
				id_toByteArray_I = JNIEnv.GetStaticMethodID (class_ref, "toByteArray", "(I)[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toByteArray_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static IntPtr id_toHexString_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.util']/class[@name='HexDump']/method[@name='toHexString' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("toHexString", "(B)Ljava/lang/String;", "")]
		public static string ToHexString (sbyte p0)
		{
			if (id_toHexString_B == IntPtr.Zero)
				id_toHexString_B = JNIEnv.GetStaticMethodID (class_ref, "toHexString", "(B)Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toHexString_B, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_toHexString_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.util']/class[@name='HexDump']/method[@name='toHexString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("toHexString", "([B)Ljava/lang/String;", "")]
		public static string ToHexString (byte[] p0)
		{
			if (id_toHexString_arrayB == IntPtr.Zero)
				id_toHexString_arrayB = JNIEnv.GetStaticMethodID (class_ref, "toHexString", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toHexString_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_toHexString_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.util']/class[@name='HexDump']/method[@name='toHexString' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("toHexString", "([BII)Ljava/lang/String;", "")]
		public static string ToHexString (byte[] p0, int p1, int p2)
		{
			if (id_toHexString_arrayBII == IntPtr.Zero)
				id_toHexString_arrayBII = JNIEnv.GetStaticMethodID (class_ref, "toHexString", "([BII)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toHexString_arrayBII, new JValue (native_p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_toHexString_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.util']/class[@name='HexDump']/method[@name='toHexString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("toHexString", "(I)Ljava/lang/String;", "")]
		public static string ToHexString (int p0)
		{
			if (id_toHexString_I == IntPtr.Zero)
				id_toHexString_I = JNIEnv.GetStaticMethodID (class_ref, "toHexString", "(I)Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toHexString_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
