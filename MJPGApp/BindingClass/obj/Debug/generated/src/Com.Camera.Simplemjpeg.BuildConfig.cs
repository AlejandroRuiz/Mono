using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Camera.Simplemjpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='BuildConfig']"
	[global::Android.Runtime.Register ("com/camera/simplemjpeg/BuildConfig", DoNotGenerateAcw=true)]
	public sealed partial class BuildConfig : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='BuildConfig']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public const bool Debug = (bool) true;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/camera/simplemjpeg/BuildConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BuildConfig); }
		}

		internal BuildConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='BuildConfig']/constructor[@name='BuildConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public BuildConfig () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BuildConfig)) {
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

	}
}
