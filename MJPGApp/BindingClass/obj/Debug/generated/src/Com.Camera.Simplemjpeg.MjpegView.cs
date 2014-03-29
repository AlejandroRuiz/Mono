using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Camera.Simplemjpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']"
	[global::Android.Runtime.Register ("com/camera/simplemjpeg/MjpegView", DoNotGenerateAcw=true)]
	public partial class MjpegView : global::Android.Views.SurfaceView, global::Android.Views.ISurfaceHolderCallback {


		static IntPtr IMG_HEIGHT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/field[@name='IMG_HEIGHT']"
		[Register ("IMG_HEIGHT")]
		public int ImgHeight {
			get {
				if (IMG_HEIGHT_jfieldId == IntPtr.Zero)
					IMG_HEIGHT_jfieldId = JNIEnv.GetFieldID (class_ref, "IMG_HEIGHT", "I");
				return JNIEnv.GetIntField (Handle, IMG_HEIGHT_jfieldId);
			}
			set {
				if (IMG_HEIGHT_jfieldId == IntPtr.Zero)
					IMG_HEIGHT_jfieldId = JNIEnv.GetFieldID (class_ref, "IMG_HEIGHT", "I");
				JNIEnv.SetField (Handle, IMG_HEIGHT_jfieldId, value);
			}
		}

		static IntPtr IMG_WIDTH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/field[@name='IMG_WIDTH']"
		[Register ("IMG_WIDTH")]
		public int ImgWidth {
			get {
				if (IMG_WIDTH_jfieldId == IntPtr.Zero)
					IMG_WIDTH_jfieldId = JNIEnv.GetFieldID (class_ref, "IMG_WIDTH", "I");
				return JNIEnv.GetIntField (Handle, IMG_WIDTH_jfieldId);
			}
			set {
				if (IMG_WIDTH_jfieldId == IntPtr.Zero)
					IMG_WIDTH_jfieldId = JNIEnv.GetFieldID (class_ref, "IMG_WIDTH", "I");
				JNIEnv.SetField (Handle, IMG_WIDTH_jfieldId, value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/field[@name='POSITION_LOWER_LEFT']"
		[Register ("POSITION_LOWER_LEFT")]
		public const int PositionLowerLeft = (int) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/field[@name='POSITION_LOWER_RIGHT']"
		[Register ("POSITION_LOWER_RIGHT")]
		public const int PositionLowerRight = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/field[@name='POSITION_UPPER_LEFT']"
		[Register ("POSITION_UPPER_LEFT")]
		public const int PositionUpperLeft = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/field[@name='POSITION_UPPER_RIGHT']"
		[Register ("POSITION_UPPER_RIGHT")]
		public const int PositionUpperRight = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/field[@name='SIZE_BEST_FIT']"
		[Register ("SIZE_BEST_FIT")]
		public const int SizeBestFit = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/field[@name='SIZE_FULLSCREEN']"
		[Register ("SIZE_FULLSCREEN")]
		public const int SizeFullscreen = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/field[@name='SIZE_STANDARD']"
		[Register ("SIZE_STANDARD")]
		public const int SizeStandard = (int) 1;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView.MjpegViewThread']"
		[global::Android.Runtime.Register ("com/camera/simplemjpeg/MjpegView$MjpegViewThread", DoNotGenerateAcw=true)]
		public partial class MjpegViewThread : global::Java.Lang.Thread {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/camera/simplemjpeg/MjpegView$MjpegViewThread", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MjpegViewThread); }
			}

			protected MjpegViewThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_camera_simplemjpeg_MjpegView_Landroid_view_SurfaceHolder_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView.MjpegViewThread']/constructor[@name='MjpegView.MjpegViewThread' and count(parameter)=3 and parameter[1][@type='com.camera.simplemjpeg.MjpegView'] and parameter[2][@type='android.view.SurfaceHolder'] and parameter[3][@type='android.content.Context']]"
			[Register (".ctor", "(Lcom/camera/simplemjpeg/MjpegView;Landroid/view/SurfaceHolder;Landroid/content/Context;)V", "")]
			public MjpegViewThread (global::Com.Camera.Simplemjpeg.MjpegView __self, global::Android.Views.ISurfaceHolder p1, global::Android.Content.Context p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (MjpegViewThread)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/SurfaceHolder;Landroid/content/Context;)V", new JValue (__self), new JValue (p1), new JValue (p2)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/SurfaceHolder;Landroid/content/Context;)V", new JValue (__self), new JValue (p1), new JValue (p2));
					return;
				}

				if (id_ctor_Lcom_camera_simplemjpeg_MjpegView_Landroid_view_SurfaceHolder_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Lcom_camera_simplemjpeg_MjpegView_Landroid_view_SurfaceHolder_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/camera/simplemjpeg/MjpegView;Landroid/view/SurfaceHolder;Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_camera_simplemjpeg_MjpegView_Landroid_view_SurfaceHolder_Landroid_content_Context_, new JValue (__self), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_camera_simplemjpeg_MjpegView_Landroid_view_SurfaceHolder_Landroid_content_Context_, new JValue (__self), new JValue (p1), new JValue (p2));
			}

			static Delegate cb_setSurfaceSize_II;
#pragma warning disable 0169
			static Delegate GetSetSurfaceSize_IIHandler ()
			{
				if (cb_setSurfaceSize_II == null)
					cb_setSurfaceSize_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetSurfaceSize_II);
				return cb_setSurfaceSize_II;
			}

			static void n_SetSurfaceSize_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				global::Com.Camera.Simplemjpeg.MjpegView.MjpegViewThread __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView.MjpegViewThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetSurfaceSize (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_setSurfaceSize_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView.MjpegViewThread']/method[@name='setSurfaceSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("setSurfaceSize", "(II)V", "GetSetSurfaceSize_IIHandler")]
			public virtual void SetSurfaceSize (int p0, int p1)
			{
				if (id_setSurfaceSize_II == IntPtr.Zero)
					id_setSurfaceSize_II = JNIEnv.GetMethodID (class_ref, "setSurfaceSize", "(II)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSurfaceSize_II, new JValue (p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setSurfaceSize_II, new JValue (p0), new JValue (p1));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/camera/simplemjpeg/MjpegView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MjpegView); }
		}

		protected MjpegView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/constructor[@name='MjpegView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public MjpegView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MjpegView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/constructor[@name='MjpegView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public MjpegView (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MjpegView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static Delegate cb_isStreaming;
#pragma warning disable 0169
		static Delegate GetIsStreamingHandler ()
		{
			if (cb_isStreaming == null)
				cb_isStreaming = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStreaming);
			return cb_isStreaming;
		}

		static bool n_IsStreaming (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStreaming;
		}
#pragma warning restore 0169

		static IntPtr id_isStreaming;
		public virtual bool IsStreaming {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='isStreaming' and count(parameter)=0]"
			[Register ("isStreaming", "()Z", "GetIsStreamingHandler")]
			get {
				if (id_isStreaming == IntPtr.Zero)
					id_isStreaming = JNIEnv.GetMethodID (class_ref, "isStreaming", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isStreaming);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, id_isStreaming);
			}
		}

		static Delegate cb_freeCameraMemory;
#pragma warning disable 0169
		static Delegate GetFreeCameraMemoryHandler ()
		{
			if (cb_freeCameraMemory == null)
				cb_freeCameraMemory = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FreeCameraMemory);
			return cb_freeCameraMemory;
		}

		static void n_FreeCameraMemory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FreeCameraMemory ();
		}
#pragma warning restore 0169

		static IntPtr id_freeCameraMemory;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='freeCameraMemory' and count(parameter)=0]"
		[Register ("freeCameraMemory", "()V", "GetFreeCameraMemoryHandler")]
		public virtual void FreeCameraMemory ()
		{
			if (id_freeCameraMemory == IntPtr.Zero)
				id_freeCameraMemory = JNIEnv.GetMethodID (class_ref, "freeCameraMemory", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_freeCameraMemory);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_freeCameraMemory);
		}

		static Delegate cb_resumePlayback;
#pragma warning disable 0169
		static Delegate GetResumePlaybackHandler ()
		{
			if (cb_resumePlayback == null)
				cb_resumePlayback = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResumePlayback);
			return cb_resumePlayback;
		}

		static void n_ResumePlayback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResumePlayback ();
		}
#pragma warning restore 0169

		static IntPtr id_resumePlayback;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='resumePlayback' and count(parameter)=0]"
		[Register ("resumePlayback", "()V", "GetResumePlaybackHandler")]
		public virtual void ResumePlayback ()
		{
			if (id_resumePlayback == IntPtr.Zero)
				id_resumePlayback = JNIEnv.GetMethodID (class_ref, "resumePlayback", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_resumePlayback);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_resumePlayback);
		}

		static Delegate cb_setDisplayMode_I;
#pragma warning disable 0169
		static Delegate GetSetDisplayMode_IHandler ()
		{
			if (cb_setDisplayMode_I == null)
				cb_setDisplayMode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDisplayMode_I);
			return cb_setDisplayMode_I;
		}

		static void n_SetDisplayMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplayMode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDisplayMode_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='setDisplayMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDisplayMode", "(I)V", "GetSetDisplayMode_IHandler")]
		public virtual void SetDisplayMode (int p0)
		{
			if (id_setDisplayMode_I == IntPtr.Zero)
				id_setDisplayMode_I = JNIEnv.GetMethodID (class_ref, "setDisplayMode", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setDisplayMode_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setDisplayMode_I, new JValue (p0));
		}

		static Delegate cb_setOverlayBackgroundColor_I;
#pragma warning disable 0169
		static Delegate GetSetOverlayBackgroundColor_IHandler ()
		{
			if (cb_setOverlayBackgroundColor_I == null)
				cb_setOverlayBackgroundColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetOverlayBackgroundColor_I);
			return cb_setOverlayBackgroundColor_I;
		}

		static void n_SetOverlayBackgroundColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOverlayBackgroundColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOverlayBackgroundColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='setOverlayBackgroundColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setOverlayBackgroundColor", "(I)V", "GetSetOverlayBackgroundColor_IHandler")]
		public virtual void SetOverlayBackgroundColor (int p0)
		{
			if (id_setOverlayBackgroundColor_I == IntPtr.Zero)
				id_setOverlayBackgroundColor_I = JNIEnv.GetMethodID (class_ref, "setOverlayBackgroundColor", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOverlayBackgroundColor_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setOverlayBackgroundColor_I, new JValue (p0));
		}

		static Delegate cb_setOverlayPaint_Landroid_graphics_Paint_;
#pragma warning disable 0169
		static Delegate GetSetOverlayPaint_Landroid_graphics_Paint_Handler ()
		{
			if (cb_setOverlayPaint_Landroid_graphics_Paint_ == null)
				cb_setOverlayPaint_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOverlayPaint_Landroid_graphics_Paint_);
			return cb_setOverlayPaint_Landroid_graphics_Paint_;
		}

		static void n_SetOverlayPaint_Landroid_graphics_Paint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOverlayPaint (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOverlayPaint_Landroid_graphics_Paint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='setOverlayPaint' and count(parameter)=1 and parameter[1][@type='android.graphics.Paint']]"
		[Register ("setOverlayPaint", "(Landroid/graphics/Paint;)V", "GetSetOverlayPaint_Landroid_graphics_Paint_Handler")]
		public virtual void SetOverlayPaint (global::Android.Graphics.Paint p0)
		{
			if (id_setOverlayPaint_Landroid_graphics_Paint_ == IntPtr.Zero)
				id_setOverlayPaint_Landroid_graphics_Paint_ = JNIEnv.GetMethodID (class_ref, "setOverlayPaint", "(Landroid/graphics/Paint;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOverlayPaint_Landroid_graphics_Paint_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setOverlayPaint_Landroid_graphics_Paint_, new JValue (p0));
		}

		static Delegate cb_setOverlayPosition_I;
#pragma warning disable 0169
		static Delegate GetSetOverlayPosition_IHandler ()
		{
			if (cb_setOverlayPosition_I == null)
				cb_setOverlayPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetOverlayPosition_I);
			return cb_setOverlayPosition_I;
		}

		static void n_SetOverlayPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOverlayPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOverlayPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='setOverlayPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setOverlayPosition", "(I)V", "GetSetOverlayPosition_IHandler")]
		public virtual void SetOverlayPosition (int p0)
		{
			if (id_setOverlayPosition_I == IntPtr.Zero)
				id_setOverlayPosition_I = JNIEnv.GetMethodID (class_ref, "setOverlayPosition", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOverlayPosition_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setOverlayPosition_I, new JValue (p0));
		}

		static Delegate cb_setOverlayTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetOverlayTextColor_IHandler ()
		{
			if (cb_setOverlayTextColor_I == null)
				cb_setOverlayTextColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetOverlayTextColor_I);
			return cb_setOverlayTextColor_I;
		}

		static void n_SetOverlayTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOverlayTextColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOverlayTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='setOverlayTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setOverlayTextColor", "(I)V", "GetSetOverlayTextColor_IHandler")]
		public virtual void SetOverlayTextColor (int p0)
		{
			if (id_setOverlayTextColor_I == IntPtr.Zero)
				id_setOverlayTextColor_I = JNIEnv.GetMethodID (class_ref, "setOverlayTextColor", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOverlayTextColor_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setOverlayTextColor_I, new JValue (p0));
		}

		static Delegate cb_setResolution_II;
#pragma warning disable 0169
		static Delegate GetSetResolution_IIHandler ()
		{
			if (cb_setResolution_II == null)
				cb_setResolution_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetResolution_II);
			return cb_setResolution_II;
		}

		static void n_SetResolution_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetResolution (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setResolution_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='setResolution' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setResolution", "(II)V", "GetSetResolution_IIHandler")]
		public virtual void SetResolution (int p0, int p1)
		{
			if (id_setResolution_II == IntPtr.Zero)
				id_setResolution_II = JNIEnv.GetMethodID (class_ref, "setResolution", "(II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setResolution_II, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setResolution_II, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setSource_Lcom_camera_simplemjpeg_MjpegInputStream_;
#pragma warning disable 0169
		static Delegate GetSetSource_Lcom_camera_simplemjpeg_MjpegInputStream_Handler ()
		{
			if (cb_setSource_Lcom_camera_simplemjpeg_MjpegInputStream_ == null)
				cb_setSource_Lcom_camera_simplemjpeg_MjpegInputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSource_Lcom_camera_simplemjpeg_MjpegInputStream_);
			return cb_setSource_Lcom_camera_simplemjpeg_MjpegInputStream_;
		}

		static void n_SetSource_Lcom_camera_simplemjpeg_MjpegInputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Camera.Simplemjpeg.MjpegInputStream p0 = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegInputStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSource (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSource_Lcom_camera_simplemjpeg_MjpegInputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='setSource' and count(parameter)=1 and parameter[1][@type='com.camera.simplemjpeg.MjpegInputStream']]"
		[Register ("setSource", "(Lcom/camera/simplemjpeg/MjpegInputStream;)V", "GetSetSource_Lcom_camera_simplemjpeg_MjpegInputStream_Handler")]
		public virtual void SetSource (global::Com.Camera.Simplemjpeg.MjpegInputStream p0)
		{
			if (id_setSource_Lcom_camera_simplemjpeg_MjpegInputStream_ == IntPtr.Zero)
				id_setSource_Lcom_camera_simplemjpeg_MjpegInputStream_ = JNIEnv.GetMethodID (class_ref, "setSource", "(Lcom/camera/simplemjpeg/MjpegInputStream;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setSource_Lcom_camera_simplemjpeg_MjpegInputStream_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setSource_Lcom_camera_simplemjpeg_MjpegInputStream_, new JValue (p0));
		}

		static Delegate cb_showFps_Z;
#pragma warning disable 0169
		static Delegate GetShowFps_ZHandler ()
		{
			if (cb_showFps_Z == null)
				cb_showFps_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ShowFps_Z);
			return cb_showFps_Z;
		}

		static void n_ShowFps_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowFps (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showFps_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='showFps' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showFps", "(Z)V", "GetShowFps_ZHandler")]
		public virtual void ShowFps (bool p0)
		{
			if (id_showFps_Z == IntPtr.Zero)
				id_showFps_Z = JNIEnv.GetMethodID (class_ref, "showFps", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_showFps_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_showFps_Z, new JValue (p0));
		}

		static Delegate cb_startPlayback;
#pragma warning disable 0169
		static Delegate GetStartPlaybackHandler ()
		{
			if (cb_startPlayback == null)
				cb_startPlayback = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartPlayback);
			return cb_startPlayback;
		}

		static void n_StartPlayback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartPlayback ();
		}
#pragma warning restore 0169

		static IntPtr id_startPlayback;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='startPlayback' and count(parameter)=0]"
		[Register ("startPlayback", "()V", "GetStartPlaybackHandler")]
		public virtual void StartPlayback ()
		{
			if (id_startPlayback == IntPtr.Zero)
				id_startPlayback = JNIEnv.GetMethodID (class_ref, "startPlayback", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_startPlayback);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_startPlayback);
		}

		static Delegate cb_stopPlayback;
#pragma warning disable 0169
		static Delegate GetStopPlaybackHandler ()
		{
			if (cb_stopPlayback == null)
				cb_stopPlayback = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopPlayback);
			return cb_stopPlayback;
		}

		static void n_StopPlayback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopPlayback ();
		}
#pragma warning restore 0169

		static IntPtr id_stopPlayback;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='stopPlayback' and count(parameter)=0]"
		[Register ("stopPlayback", "()V", "GetStopPlaybackHandler")]
		public virtual void StopPlayback ()
		{
			if (id_stopPlayback == IntPtr.Zero)
				id_stopPlayback = JNIEnv.GetMethodID (class_ref, "stopPlayback", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_stopPlayback);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_stopPlayback);
		}

		static Delegate cb_surfaceChanged_Landroid_view_SurfaceHolder_III;
#pragma warning disable 0169
		static Delegate GetSurfaceChanged_Landroid_view_SurfaceHolder_IIIHandler ()
		{
			if (cb_surfaceChanged_Landroid_view_SurfaceHolder_III == null)
				cb_surfaceChanged_Landroid_view_SurfaceHolder_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_SurfaceChanged_Landroid_view_SurfaceHolder_III);
			return cb_surfaceChanged_Landroid_view_SurfaceHolder_III;
		}

		static void n_SurfaceChanged_Landroid_view_SurfaceHolder_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1, int p2, int p3)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Format p1 = (global::Android.Graphics.Format) native_p1;
			__this.SurfaceChanged (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_surfaceChanged_Landroid_view_SurfaceHolder_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='surfaceChanged' and count(parameter)=4 and parameter[1][@type='android.view.SurfaceHolder'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("surfaceChanged", "(Landroid/view/SurfaceHolder;III)V", "GetSurfaceChanged_Landroid_view_SurfaceHolder_IIIHandler")]
		public virtual void SurfaceChanged (global::Android.Views.ISurfaceHolder p0, global::Android.Graphics.Format p1, int p2, int p3)
		{
			if (id_surfaceChanged_Landroid_view_SurfaceHolder_III == IntPtr.Zero)
				id_surfaceChanged_Landroid_view_SurfaceHolder_III = JNIEnv.GetMethodID (class_ref, "surfaceChanged", "(Landroid/view/SurfaceHolder;III)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_surfaceChanged_Landroid_view_SurfaceHolder_III, new JValue (p0), new JValue ((int) p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_surfaceChanged_Landroid_view_SurfaceHolder_III, new JValue (p0), new JValue ((int) p1), new JValue (p2), new JValue (p3));
		}

		static Delegate cb_surfaceCreated_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetSurfaceCreated_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_surfaceCreated_Landroid_view_SurfaceHolder_ == null)
				cb_surfaceCreated_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SurfaceCreated_Landroid_view_SurfaceHolder_);
			return cb_surfaceCreated_Landroid_view_SurfaceHolder_;
		}

		static void n_SurfaceCreated_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SurfaceCreated (p0);
		}
#pragma warning restore 0169

		static IntPtr id_surfaceCreated_Landroid_view_SurfaceHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='surfaceCreated' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("surfaceCreated", "(Landroid/view/SurfaceHolder;)V", "GetSurfaceCreated_Landroid_view_SurfaceHolder_Handler")]
		public virtual void SurfaceCreated (global::Android.Views.ISurfaceHolder p0)
		{
			if (id_surfaceCreated_Landroid_view_SurfaceHolder_ == IntPtr.Zero)
				id_surfaceCreated_Landroid_view_SurfaceHolder_ = JNIEnv.GetMethodID (class_ref, "surfaceCreated", "(Landroid/view/SurfaceHolder;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_surfaceCreated_Landroid_view_SurfaceHolder_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_surfaceCreated_Landroid_view_SurfaceHolder_, new JValue (p0));
		}

		static Delegate cb_surfaceDestroyed_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetSurfaceDestroyed_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_surfaceDestroyed_Landroid_view_SurfaceHolder_ == null)
				cb_surfaceDestroyed_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SurfaceDestroyed_Landroid_view_SurfaceHolder_);
			return cb_surfaceDestroyed_Landroid_view_SurfaceHolder_;
		}

		static void n_SurfaceDestroyed_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SurfaceDestroyed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_surfaceDestroyed_Landroid_view_SurfaceHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='surfaceDestroyed' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V", "GetSurfaceDestroyed_Landroid_view_SurfaceHolder_Handler")]
		public virtual void SurfaceDestroyed (global::Android.Views.ISurfaceHolder p0)
		{
			if (id_surfaceDestroyed_Landroid_view_SurfaceHolder_ == IntPtr.Zero)
				id_surfaceDestroyed_Landroid_view_SurfaceHolder_ = JNIEnv.GetMethodID (class_ref, "surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_surfaceDestroyed_Landroid_view_SurfaceHolder_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_surfaceDestroyed_Landroid_view_SurfaceHolder_, new JValue (p0));
		}

	}
}
