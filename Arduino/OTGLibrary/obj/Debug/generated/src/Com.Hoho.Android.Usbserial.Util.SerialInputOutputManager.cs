using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Hoho.Android.Usbserial.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.hoho.android.usbserial.util']/class[@name='SerialInputOutputManager']"
	[global::Android.Runtime.Register ("com/hoho/android/usbserial/util/SerialInputOutputManager", DoNotGenerateAcw=true)]
	public partial class SerialInputOutputManager : global::Java.Lang.Object, global::Java.Lang.IRunnable {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.hoho.android.usbserial.util']/interface[@name='SerialInputOutputManager.Listener']"
		[Register ("com/hoho/android/usbserial/util/SerialInputOutputManager$Listener", "", "Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager/IListenerInvoker")]
		public partial interface IListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.util']/interface[@name='SerialInputOutputManager.Listener']/method[@name='onNewData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("onNewData", "([B)V", "GetOnNewData_arrayBHandler:Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager/IListenerInvoker, OTGLibrary")]
			void OnNewData (byte[] p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.util']/interface[@name='SerialInputOutputManager.Listener']/method[@name='onRunError' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
			[Register ("onRunError", "(Ljava/lang/Exception;)V", "GetOnRunError_Ljava_lang_Exception_Handler:Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager/IListenerInvoker, OTGLibrary")]
			void OnRunError (global::Java.Lang.Exception p0);

		}

		[global::Android.Runtime.Register ("com/hoho/android/usbserial/util/SerialInputOutputManager$Listener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : global::Java.Lang.Object, IListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/hoho/android/usbserial/util/SerialInputOutputManager$Listener");
			IntPtr class_ref;

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.hoho.android.usbserial.util.SerialInputOutputManager.Listener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IListenerInvoker); }
			}

			static Delegate cb_onNewData_arrayB;
#pragma warning disable 0169
			static Delegate GetOnNewData_arrayBHandler ()
			{
				if (cb_onNewData_arrayB == null)
					cb_onNewData_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNewData_arrayB);
				return cb_onNewData_arrayB;
			}

			static void n_OnNewData_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.OnNewData (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			IntPtr id_onNewData_arrayB;
			public void OnNewData (byte[] p0)
			{
				if (id_onNewData_arrayB == IntPtr.Zero)
					id_onNewData_arrayB = JNIEnv.GetMethodID (class_ref, "onNewData", "([B)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				JNIEnv.CallVoidMethod (Handle, id_onNewData_arrayB, new JValue (native_p0));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_onRunError_Ljava_lang_Exception_;
#pragma warning disable 0169
			static Delegate GetOnRunError_Ljava_lang_Exception_Handler ()
			{
				if (cb_onRunError_Ljava_lang_Exception_ == null)
					cb_onRunError_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRunError_Ljava_lang_Exception_);
				return cb_onRunError_Ljava_lang_Exception_;
			}

			static void n_OnRunError_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnRunError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onRunError_Ljava_lang_Exception_;
			public void OnRunError (global::Java.Lang.Exception p0)
			{
				if (id_onRunError_Ljava_lang_Exception_ == IntPtr.Zero)
					id_onRunError_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onRunError", "(Ljava/lang/Exception;)V");
				JNIEnv.CallVoidMethod (Handle, id_onRunError_Ljava_lang_Exception_, new JValue (p0));
			}

		}

		public partial class NewDataEventArgs : global::System.EventArgs {

			public NewDataEventArgs (byte[] p0)
			{
				this.p0 = p0;
			}

			byte[] p0;
			public byte[] P0 {
				get { return p0; }
			}
		}

		public partial class RunErrorEventArgs : global::System.EventArgs {

			public RunErrorEventArgs (global::Java.Lang.Exception p0)
			{
				this.p0 = p0;
			}

			global::Java.Lang.Exception p0;
			public global::Java.Lang.Exception P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/hoho/android/usbserial/util/SerialInputOutputManager_ListenerImplementor")]
		internal sealed class IListenerImplementor : global::Java.Lang.Object, IListener {

			object sender;

			public IListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/hoho/android/usbserial/util/SerialInputOutputManager_ListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<NewDataEventArgs> OnNewDataHandler;
#pragma warning restore 0649

			public void OnNewData (byte[] p0)
			{
				var __h = OnNewDataHandler;
				if (__h != null)
					__h (sender, new NewDataEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<RunErrorEventArgs> OnRunErrorHandler;
#pragma warning restore 0649

			public void OnRunError (global::Java.Lang.Exception p0)
			{
				var __h = OnRunErrorHandler;
				if (__h != null)
					__h (sender, new RunErrorEventArgs (p0));
			}

			internal static bool __IsEmpty (IListenerImplementor value)
			{
				return value.OnNewDataHandler == null && value.OnRunErrorHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.hoho.android.usbserial.util']/class[@name='SerialInputOutputManager.State']"
		[global::Android.Runtime.Register ("com/hoho/android/usbserial/util/SerialInputOutputManager$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {


			static IntPtr RUNNING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.util']/class[@name='SerialInputOutputManager.State']/field[@name='RUNNING']"
			[Register ("RUNNING")]
			public static global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager.State Running {
				get {
					if (RUNNING_jfieldId == IntPtr.Zero)
						RUNNING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RUNNING", "Lcom/hoho/android/usbserial/util/SerialInputOutputManager$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RUNNING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (RUNNING_jfieldId == IntPtr.Zero)
						RUNNING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RUNNING", "Lcom/hoho/android/usbserial/util/SerialInputOutputManager$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, RUNNING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr STOPPED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.util']/class[@name='SerialInputOutputManager.State']/field[@name='STOPPED']"
			[Register ("STOPPED")]
			public static global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager.State Stopped {
				get {
					if (STOPPED_jfieldId == IntPtr.Zero)
						STOPPED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STOPPED", "Lcom/hoho/android/usbserial/util/SerialInputOutputManager$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STOPPED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (STOPPED_jfieldId == IntPtr.Zero)
						STOPPED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STOPPED", "Lcom/hoho/android/usbserial/util/SerialInputOutputManager$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, STOPPED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr STOPPING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.hoho.android.usbserial.util']/class[@name='SerialInputOutputManager.State']/field[@name='STOPPING']"
			[Register ("STOPPING")]
			public static global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager.State Stopping {
				get {
					if (STOPPING_jfieldId == IntPtr.Zero)
						STOPPING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STOPPING", "Lcom/hoho/android/usbserial/util/SerialInputOutputManager$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STOPPING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (STOPPING_jfieldId == IntPtr.Zero)
						STOPPING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STOPPING", "Lcom/hoho/android/usbserial/util/SerialInputOutputManager$State;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, STOPPING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/hoho/android/usbserial/util/SerialInputOutputManager$State", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (State); }
			}

			internal State (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/hoho/android/usbserial/util/SerialInputOutputManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SerialInputOutputManager); }
		}

		protected SerialInputOutputManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_hoho_android_usbserial_driver_UsbSerialDriver_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.hoho.android.usbserial.util']/class[@name='SerialInputOutputManager']/constructor[@name='SerialInputOutputManager' and count(parameter)=1 and parameter[1][@type='com.hoho.android.usbserial.driver.UsbSerialDriver']]"
		[Register (".ctor", "(Lcom/hoho/android/usbserial/driver/UsbSerialDriver;)V", "")]
		public SerialInputOutputManager (global::Com.Hoho.Android.Usbserial.Driver.UsbSerialDriver p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SerialInputOutputManager)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/hoho/android/usbserial/driver/UsbSerialDriver;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/hoho/android/usbserial/driver/UsbSerialDriver;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lcom_hoho_android_usbserial_driver_UsbSerialDriver_ == IntPtr.Zero)
				id_ctor_Lcom_hoho_android_usbserial_driver_UsbSerialDriver_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/hoho/android/usbserial/driver/UsbSerialDriver;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_hoho_android_usbserial_driver_UsbSerialDriver_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_hoho_android_usbserial_driver_UsbSerialDriver_, new JValue (p0));
		}

		static IntPtr id_ctor_Lcom_hoho_android_usbserial_driver_UsbSerialDriver_Lcom_hoho_android_usbserial_util_SerialInputOutputManager_Listener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.hoho.android.usbserial.util']/class[@name='SerialInputOutputManager']/constructor[@name='SerialInputOutputManager' and count(parameter)=2 and parameter[1][@type='com.hoho.android.usbserial.driver.UsbSerialDriver'] and parameter[2][@type='com.hoho.android.usbserial.util.SerialInputOutputManager.Listener']]"
		[Register (".ctor", "(Lcom/hoho/android/usbserial/driver/UsbSerialDriver;Lcom/hoho/android/usbserial/util/SerialInputOutputManager$Listener;)V", "")]
		public SerialInputOutputManager (global::Com.Hoho.Android.Usbserial.Driver.UsbSerialDriver p0, global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager.IListener p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SerialInputOutputManager)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/hoho/android/usbserial/driver/UsbSerialDriver;Lcom/hoho/android/usbserial/util/SerialInputOutputManager$Listener;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/hoho/android/usbserial/driver/UsbSerialDriver;Lcom/hoho/android/usbserial/util/SerialInputOutputManager$Listener;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lcom_hoho_android_usbserial_driver_UsbSerialDriver_Lcom_hoho_android_usbserial_util_SerialInputOutputManager_Listener_ == IntPtr.Zero)
				id_ctor_Lcom_hoho_android_usbserial_driver_UsbSerialDriver_Lcom_hoho_android_usbserial_util_SerialInputOutputManager_Listener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/hoho/android/usbserial/driver/UsbSerialDriver;Lcom/hoho/android/usbserial/util/SerialInputOutputManager$Listener;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_hoho_android_usbserial_driver_UsbSerialDriver_Lcom_hoho_android_usbserial_util_SerialInputOutputManager_Listener_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_hoho_android_usbserial_driver_UsbSerialDriver_Lcom_hoho_android_usbserial_util_SerialInputOutputManager_Listener_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getListener;
#pragma warning disable 0169
		static Delegate GetGetListenerHandler ()
		{
			if (cb_getListener == null)
				cb_getListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetListener);
			return cb_getListener;
		}

		static IntPtr n_GetListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager __this = global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Listener);
		}
#pragma warning restore 0169

		static Delegate cb_setListener_Lcom_hoho_android_usbserial_util_SerialInputOutputManager_Listener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_hoho_android_usbserial_util_SerialInputOutputManager_Listener_Handler ()
		{
			if (cb_setListener_Lcom_hoho_android_usbserial_util_SerialInputOutputManager_Listener_ == null)
				cb_setListener_Lcom_hoho_android_usbserial_util_SerialInputOutputManager_Listener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListener_Lcom_hoho_android_usbserial_util_SerialInputOutputManager_Listener_);
			return cb_setListener_Lcom_hoho_android_usbserial_util_SerialInputOutputManager_Listener_;
		}

		static void n_SetListener_Lcom_hoho_android_usbserial_util_SerialInputOutputManager_Listener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager __this = global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager.IListener p0 = (global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager.IListener)global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager.IListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Listener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getListener;
		static IntPtr id_setListener_Lcom_hoho_android_usbserial_util_SerialInputOutputManager_Listener_;
		public virtual global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager.IListener Listener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.util']/class[@name='SerialInputOutputManager']/method[@name='getListener' and count(parameter)=0]"
			[Register ("getListener", "()Lcom/hoho/android/usbserial/util/SerialInputOutputManager$Listener;", "GetGetListenerHandler")]
			get {
				if (id_getListener == IntPtr.Zero)
					id_getListener = JNIEnv.GetMethodID (class_ref, "getListener", "()Lcom/hoho/android/usbserial/util/SerialInputOutputManager$Listener;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager.IListener> (JNIEnv.CallObjectMethod  (Handle, id_getListener), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager.IListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getListener", "()Lcom/hoho/android/usbserial/util/SerialInputOutputManager$Listener;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.util']/class[@name='SerialInputOutputManager']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.hoho.android.usbserial.util.SerialInputOutputManager.Listener']]"
			[Register ("setListener", "(Lcom/hoho/android/usbserial/util/SerialInputOutputManager$Listener;)V", "GetSetListener_Lcom_hoho_android_usbserial_util_SerialInputOutputManager_Listener_Handler")]
			set {
				if (id_setListener_Lcom_hoho_android_usbserial_util_SerialInputOutputManager_Listener_ == IntPtr.Zero)
					id_setListener_Lcom_hoho_android_usbserial_util_SerialInputOutputManager_Listener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcom/hoho/android/usbserial/util/SerialInputOutputManager$Listener;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setListener_Lcom_hoho_android_usbserial_util_SerialInputOutputManager_Listener_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setListener", "(Lcom/hoho/android/usbserial/util/SerialInputOutputManager$Listener;)V"), new JValue (value));
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager __this = global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.util']/class[@name='SerialInputOutputManager']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_run);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager __this = global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.util']/class[@name='SerialInputOutputManager']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_stop);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
		}

		static Delegate cb_writeAsync_arrayB;
#pragma warning disable 0169
		static Delegate GetWriteAsync_arrayBHandler ()
		{
			if (cb_writeAsync_arrayB == null)
				cb_writeAsync_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteAsync_arrayB);
			return cb_writeAsync_arrayB;
		}

		static void n_WriteAsync_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager __this = global::Java.Lang.Object.GetObject<global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.WriteAsync (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeAsync_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.hoho.android.usbserial.util']/class[@name='SerialInputOutputManager']/method[@name='writeAsync' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("writeAsync", "([B)V", "GetWriteAsync_arrayBHandler")]
		public virtual void WriteAsync (byte[] p0)
		{
			if (id_writeAsync_arrayB == IntPtr.Zero)
				id_writeAsync_arrayB = JNIEnv.GetMethodID (class_ref, "writeAsync", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writeAsync_arrayB, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeAsync", "([B)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

#region "Event implementation for Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager.IListener"

		global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager.IListenerImplementor __CreateIListenerImplementor ()
		{
			return new global::Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager.IListenerImplementor (this);
		}
#endregion
	}
}
