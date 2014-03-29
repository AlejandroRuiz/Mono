using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Camera.Simplemjpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R']"
	[global::Android.Runtime.Register ("com/camera/simplemjpeg/R", DoNotGenerateAcw=true)]
	public sealed partial class R : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.array']"
		[global::Android.Runtime.Register ("com/camera/simplemjpeg/R$array", DoNotGenerateAcw=true)]
		public sealed partial class Array : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.array']/field[@name='resolution_array']"
			[Register ("resolution_array")]
			public const int ResolutionArray = (int) 2131034112;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/camera/simplemjpeg/R$array", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Array); }
			}

			internal Array (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.array']/constructor[@name='R.array' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public Array () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Array)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.attr']"
		[global::Android.Runtime.Register ("com/camera/simplemjpeg/R$attr", DoNotGenerateAcw=true)]
		public sealed partial class Attr : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/camera/simplemjpeg/R$attr", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Attr); }
			}

			internal Attr (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.attr']/constructor[@name='R.attr' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public Attr () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Attr)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.drawable']"
		[global::Android.Runtime.Register ("com/camera/simplemjpeg/R$drawable", DoNotGenerateAcw=true)]
		public sealed partial class Drawable : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.drawable']/field[@name='ic_launcher']"
			[Register ("ic_launcher")]
			public const int IcLauncher = (int) 2130837504;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/camera/simplemjpeg/R$drawable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Drawable); }
			}

			internal Drawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.drawable']/constructor[@name='R.drawable' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public Drawable () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Drawable)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']"
		[global::Android.Runtime.Register ("com/camera/simplemjpeg/R$id", DoNotGenerateAcw=true)]
		public sealed partial class Id : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/field[@name='address1_decrement']"
			[Register ("address1_decrement")]
			public const int Address1Decrement = (int) 2131099655;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/field[@name='address1_increment']"
			[Register ("address1_increment")]
			public const int Address1Increment = (int) 2131099653;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/field[@name='address1_input']"
			[Register ("address1_input")]
			public const int Address1Input = (int) 2131099654;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/field[@name='address2_decrement']"
			[Register ("address2_decrement")]
			public const int Address2Decrement = (int) 2131099658;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/field[@name='address2_increment']"
			[Register ("address2_increment")]
			public const int Address2Increment = (int) 2131099656;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/field[@name='address2_input']"
			[Register ("address2_input")]
			public const int Address2Input = (int) 2131099657;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/field[@name='address3_decrement']"
			[Register ("address3_decrement")]
			public const int Address3Decrement = (int) 2131099661;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/field[@name='address3_increment']"
			[Register ("address3_increment")]
			public const int Address3Increment = (int) 2131099659;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/field[@name='address3_input']"
			[Register ("address3_input")]
			public const int Address3Input = (int) 2131099660;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/field[@name='address4_decrement']"
			[Register ("address4_decrement")]
			public const int Address4Decrement = (int) 2131099664;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/field[@name='address4_increment']"
			[Register ("address4_increment")]
			public const int Address4Increment = (int) 2131099662;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/field[@name='address4_input']"
			[Register ("address4_input")]
			public const int Address4Input = (int) 2131099663;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/field[@name='command_input']"
			[Register ("command_input")]
			public const int CommandInput = (int) 2131099669;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/field[@name='command_radiogroup']"
			[Register ("command_radiogroup")]
			public const int CommandRadiogroup = (int) 2131099670;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/field[@name='command_streaming']"
			[Register ("command_streaming")]
			public const int CommandStreaming = (int) 2131099671;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/field[@name='command_videofeed']"
			[Register ("command_videofeed")]
			public const int CommandVideofeed = (int) 2131099672;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/field[@name='height_input']"
			[Register ("height_input")]
			public const int HeightInput = (int) 2131099652;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/field[@name='mv']"
			[Register ("mv")]
			public const int Mv = (int) 2131099648;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/field[@name='port_80']"
			[Register ("port_80")]
			public const int Port80 = (int) 2131099667;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/field[@name='port_8080']"
			[Register ("port_8080")]
			public const int Port8080 = (int) 2131099668;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/field[@name='port_input']"
			[Register ("port_input")]
			public const int PortInput = (int) 2131099665;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/field[@name='port_radiogroup']"
			[Register ("port_radiogroup")]
			public const int PortRadiogroup = (int) 2131099666;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/field[@name='resolution_spinner']"
			[Register ("resolution_spinner")]
			public const int ResolutionSpinner = (int) 2131099650;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/field[@name='settings']"
			[Register ("settings")]
			public const int Settings = (int) 2131099649;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/field[@name='settings_done']"
			[Register ("settings_done")]
			public const int SettingsDone = (int) 2131099673;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/field[@name='width_input']"
			[Register ("width_input")]
			public const int WidthInput = (int) 2131099651;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/camera/simplemjpeg/R$id", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Id); }
			}

			internal Id (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.id']/constructor[@name='R.id' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public Id () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Id)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.layout']"
		[global::Android.Runtime.Register ("com/camera/simplemjpeg/R$layout", DoNotGenerateAcw=true)]
		public sealed partial class Layout : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.layout']/field[@name='main']"
			[Register ("main")]
			public const int Main = (int) 2130903040;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.layout']/field[@name='option_menu']"
			[Register ("option_menu")]
			public const int OptionMenu = (int) 2130903041;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.layout']/field[@name='settings']"
			[Register ("settings")]
			public const int Settings = (int) 2130903042;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/camera/simplemjpeg/R$layout", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Layout); }
			}

			internal Layout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.layout']/constructor[@name='R.layout' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public Layout () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (Layout)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.string']"
		[global::Android.Runtime.Register ("com/camera/simplemjpeg/R$string", DoNotGenerateAcw=true)]
		public sealed partial class String : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.string']/field[@name='address_dot']"
			[Register ("address_dot")]
			public const int AddressDot = (int) 2130968585;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.string']/field[@name='app_name']"
			[Register ("app_name")]
			public const int AppName = (int) 2130968576;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.string']/field[@name='command_setting_label']"
			[Register ("command_setting_label")]
			public const int CommandSettingLabel = (int) 2130968582;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.string']/field[@name='command_streaming']"
			[Register ("command_streaming")]
			public const int CommandStreaming = (int) 2130968590;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.string']/field[@name='command_streaming_with_explanation']"
			[Register ("command_streaming_with_explanation")]
			public const int CommandStreamingWithExplanation = (int) 2130968592;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.string']/field[@name='command_videofeed']"
			[Register ("command_videofeed")]
			public const int CommandVideofeed = (int) 2130968591;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.string']/field[@name='command_videofeed_with_explanation']"
			[Register ("command_videofeed_with_explanation")]
			public const int CommandVideofeedWithExplanation = (int) 2130968593;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.string']/field[@name='digits_decrement']"
			[Register ("digits_decrement")]
			public const int DigitsDecrement = (int) 2130968584;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.string']/field[@name='digits_increment']"
			[Register ("digits_increment")]
			public const int DigitsIncrement = (int) 2130968583;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.string']/field[@name='ip_setting_label']"
			[Register ("ip_setting_label")]
			public const int IpSettingLabel = (int) 2130968580;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.string']/field[@name='port_80']"
			[Register ("port_80")]
			public const int Port80 = (int) 2130968586;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.string']/field[@name='port_8080']"
			[Register ("port_8080")]
			public const int Port8080 = (int) 2130968587;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.string']/field[@name='port_8080_with_explanation']"
			[Register ("port_8080_with_explanation")]
			public const int Port8080WithExplanation = (int) 2130968589;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.string']/field[@name='port_80_with_explanation']"
			[Register ("port_80_with_explanation")]
			public const int Port80WithExplanation = (int) 2130968588;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.string']/field[@name='port_setting_label']"
			[Register ("port_setting_label")]
			public const int PortSettingLabel = (int) 2130968581;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.string']/field[@name='resolution_label']"
			[Register ("resolution_label")]
			public const int ResolutionLabel = (int) 2130968578;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.string']/field[@name='resolution_times']"
			[Register ("resolution_times")]
			public const int ResolutionTimes = (int) 2130968579;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.string']/field[@name='settings']"
			[Register ("settings")]
			public const int Settings = (int) 2130968577;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.string']/field[@name='settings_done']"
			[Register ("settings_done")]
			public const int SettingsDone = (int) 2130968594;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.string']/field[@name='title_connecting']"
			[Register ("title_connecting")]
			public const int TitleConnecting = (int) 2130968596;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.string']/field[@name='title_disconnected']"
			[Register ("title_disconnected")]
			public const int TitleDisconnected = (int) 2130968595;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.string']/field[@name='title_imageerror']"
			[Register ("title_imageerror")]
			public const int TitleImageerror = (int) 2130968597;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/camera/simplemjpeg/R$string", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (String); }
			}

			internal String (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R.string']/constructor[@name='R.string' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public String () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (String)) {
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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/camera/simplemjpeg/R", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (R); }
		}

		internal R (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='R']/constructor[@name='R' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public R () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (R)) {
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
