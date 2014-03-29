using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Camera.Simplemjpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegInputStream']"
	[global::Android.Runtime.Register ("com/camera/simplemjpeg/MjpegInputStream", DoNotGenerateAcw=true)]
	public partial class MjpegInputStream : global::Java.IO.DataInputStream {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/camera/simplemjpeg/MjpegInputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MjpegInputStream); }
		}

		protected MjpegInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_InputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegInputStream']/constructor[@name='MjpegInputStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
		public MjpegInputStream (global::System.IO.Stream p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);;
			if (GetType () != typeof (MjpegInputStream)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/InputStream;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/InputStream;)V", new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_io_InputStream_ == IntPtr.Zero)
				id_ctor_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_InputStream_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Camera.Simplemjpeg.MjpegInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FreeCameraMemory ();
		}
#pragma warning restore 0169

		static IntPtr id_freeCameraMemory;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegInputStream']/method[@name='freeCameraMemory' and count(parameter)=0]"
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

		static Delegate cb_pixeltobmp_arrayBILandroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetPixeltobmp_arrayBILandroid_graphics_Bitmap_Handler ()
		{
			if (cb_pixeltobmp_arrayBILandroid_graphics_Bitmap_ == null)
				cb_pixeltobmp_arrayBILandroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, int>) n_Pixeltobmp_arrayBILandroid_graphics_Bitmap_);
			return cb_pixeltobmp_arrayBILandroid_graphics_Bitmap_;
		}

		static int n_Pixeltobmp_arrayBILandroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Camera.Simplemjpeg.MjpegInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Android.Graphics.Bitmap p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Pixeltobmp (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_pixeltobmp_arrayBILandroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegInputStream']/method[@name='pixeltobmp' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Bitmap']]"
		[Register ("pixeltobmp", "([BILandroid/graphics/Bitmap;)I", "GetPixeltobmp_arrayBILandroid_graphics_Bitmap_Handler")]
		public virtual int Pixeltobmp (byte[] p0, int p1, global::Android.Graphics.Bitmap p2)
		{
			if (id_pixeltobmp_arrayBILandroid_graphics_Bitmap_ == IntPtr.Zero)
				id_pixeltobmp_arrayBILandroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "pixeltobmp", "([BILandroid/graphics/Bitmap;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_pixeltobmp_arrayBILandroid_graphics_Bitmap_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_pixeltobmp_arrayBILandroid_graphics_Bitmap_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static IntPtr id_read_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegInputStream']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("read", "(Ljava/lang/String;)Lcom/camera/simplemjpeg/MjpegInputStream;", "")]
		public static global::Com.Camera.Simplemjpeg.MjpegInputStream Read (string p0)
		{
			if (id_read_Ljava_lang_String_ == IntPtr.Zero)
				id_read_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Ljava/lang/String;)Lcom/camera/simplemjpeg/MjpegInputStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Camera.Simplemjpeg.MjpegInputStream __ret = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegInputStream> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_readMjpegFrame;
#pragma warning disable 0169
		static Delegate GetReadMjpegFrameHandler ()
		{
			if (cb_readMjpegFrame == null)
				cb_readMjpegFrame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReadMjpegFrame);
			return cb_readMjpegFrame;
		}

		static IntPtr n_ReadMjpegFrame (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Camera.Simplemjpeg.MjpegInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadMjpegFrame ());
		}
#pragma warning restore 0169

		static IntPtr id_readMjpegFrame;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegInputStream']/method[@name='readMjpegFrame' and count(parameter)=0]"
		[Register ("readMjpegFrame", "()Landroid/graphics/Bitmap;", "GetReadMjpegFrameHandler")]
		public virtual global::Android.Graphics.Bitmap ReadMjpegFrame ()
		{
			if (id_readMjpegFrame == IntPtr.Zero)
				id_readMjpegFrame = JNIEnv.GetMethodID (class_ref, "readMjpegFrame", "()Landroid/graphics/Bitmap;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_readMjpegFrame), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_readMjpegFrame), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_readMjpegFrame_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetReadMjpegFrame_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_readMjpegFrame_Landroid_graphics_Bitmap_ == null)
				cb_readMjpegFrame_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_ReadMjpegFrame_Landroid_graphics_Bitmap_);
			return cb_readMjpegFrame_Landroid_graphics_Bitmap_;
		}

		static int n_ReadMjpegFrame_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Camera.Simplemjpeg.MjpegInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ReadMjpegFrame (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_readMjpegFrame_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegInputStream']/method[@name='readMjpegFrame' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("readMjpegFrame", "(Landroid/graphics/Bitmap;)I", "GetReadMjpegFrame_Landroid_graphics_Bitmap_Handler")]
		public virtual int ReadMjpegFrame (global::Android.Graphics.Bitmap p0)
		{
			if (id_readMjpegFrame_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_readMjpegFrame_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "readMjpegFrame", "(Landroid/graphics/Bitmap;)I");

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_readMjpegFrame_Landroid_graphics_Bitmap_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, id_readMjpegFrame_Landroid_graphics_Bitmap_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_setSkip_I;
#pragma warning disable 0169
		static Delegate GetSetSkip_IHandler ()
		{
			if (cb_setSkip_I == null)
				cb_setSkip_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSkip_I);
			return cb_setSkip_I;
		}

		static void n_SetSkip_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Camera.Simplemjpeg.MjpegInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSkip (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSkip_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegInputStream']/method[@name='setSkip' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSkip", "(I)V", "GetSetSkip_IHandler")]
		public virtual void SetSkip (int p0)
		{
			if (id_setSkip_I == IntPtr.Zero)
				id_setSkip_I = JNIEnv.GetMethodID (class_ref, "setSkip", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setSkip_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_setSkip_I, new JValue (p0));
		}

	}
}
