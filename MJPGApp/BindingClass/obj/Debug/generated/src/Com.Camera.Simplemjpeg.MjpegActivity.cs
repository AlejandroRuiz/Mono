using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Camera.Simplemjpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegActivity']"
	[global::Android.Runtime.Register ("com/camera/simplemjpeg/MjpegActivity", DoNotGenerateAcw=true)]
	public partial class MjpegActivity : global::Android.App.Activity {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/camera/simplemjpeg/MjpegActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MjpegActivity); }
		}

		protected MjpegActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegActivity']/constructor[@name='MjpegActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MjpegActivity () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MjpegActivity)) {
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

		static Delegate cb_onCreate_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreate_Landroid_os_Bundle_ == null)
				cb_onCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_os_Bundle_);
			return cb_onCreate_Landroid_os_Bundle_;
		}

		static void n_OnCreate_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Camera.Simplemjpeg.MjpegActivity __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCreate_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegActivity']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler")]
		public virtual void OnCreate (global::Android.OS.Bundle p0)
		{
			if (id_onCreate_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreate_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/os/Bundle;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onCreate_Landroid_os_Bundle_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onCreate_Landroid_os_Bundle_, new JValue (p0));
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Camera.Simplemjpeg.MjpegActivity __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegActivity']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onDestroy);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onDestroy);
		}

		static Delegate cb_onPause;
#pragma warning disable 0169
		static Delegate GetOnPauseHandler ()
		{
			if (cb_onPause == null)
				cb_onPause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPause);
			return cb_onPause;
		}

		static void n_OnPause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Camera.Simplemjpeg.MjpegActivity __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		static IntPtr id_onPause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegActivity']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler")]
		public virtual void OnPause ()
		{
			if (id_onPause == IntPtr.Zero)
				id_onPause = JNIEnv.GetMethodID (class_ref, "onPause", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onPause);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onPause);
		}

		static Delegate cb_onResume;
#pragma warning disable 0169
		static Delegate GetOnResumeHandler ()
		{
			if (cb_onResume == null)
				cb_onResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResume);
			return cb_onResume;
		}

		static void n_OnResume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Camera.Simplemjpeg.MjpegActivity __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		static IntPtr id_onResume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegActivity']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler")]
		public virtual void OnResume ()
		{
			if (id_onResume == IntPtr.Zero)
				id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onResume);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onResume);
		}

		static Delegate cb_onStart;
#pragma warning disable 0169
		static Delegate GetOnStartHandler ()
		{
			if (cb_onStart == null)
				cb_onStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStart);
			return cb_onStart;
		}

		static void n_OnStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Camera.Simplemjpeg.MjpegActivity __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStart ();
		}
#pragma warning restore 0169

		static IntPtr id_onStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegActivity']/method[@name='onStart' and count(parameter)=0]"
		[Register ("onStart", "()V", "GetOnStartHandler")]
		public virtual void OnStart ()
		{
			if (id_onStart == IntPtr.Zero)
				id_onStart = JNIEnv.GetMethodID (class_ref, "onStart", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onStart);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onStart);
		}

		static Delegate cb_onStop;
#pragma warning disable 0169
		static Delegate GetOnStopHandler ()
		{
			if (cb_onStop == null)
				cb_onStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStop);
			return cb_onStop;
		}

		static void n_OnStop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Camera.Simplemjpeg.MjpegActivity __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStop ();
		}
#pragma warning restore 0169

		static IntPtr id_onStop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegActivity']/method[@name='onStop' and count(parameter)=0]"
		[Register ("onStop", "()V", "GetOnStopHandler")]
		public virtual void OnStop ()
		{
			if (id_onStop == IntPtr.Zero)
				id_onStop = JNIEnv.GetMethodID (class_ref, "onStop", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onStop);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onStop);
		}

		static Delegate cb_setImageError;
#pragma warning disable 0169
		static Delegate GetSetImageErrorHandler ()
		{
			if (cb_setImageError == null)
				cb_setImageError = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetImageError);
			return cb_setImageError;
		}

		static void n_SetImageError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Camera.Simplemjpeg.MjpegActivity __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetImageError ();
		}
#pragma warning restore 0169

		static IntPtr id_setImageError;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegActivity']/method[@name='setImageError' and count(parameter)=0]"
		[Register ("setImageError", "()V", "GetSetImageErrorHandler")]
		public virtual void SetImageError ()
		{
			if (id_setImageError == IntPtr.Zero)
				id_setImageError = JNIEnv.GetMethodID (class_ref, "setImageError", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setImageError);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setImageError);
		}

	}
}
