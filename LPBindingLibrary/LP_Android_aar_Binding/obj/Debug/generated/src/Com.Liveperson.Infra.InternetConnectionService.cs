using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra']/class[@name='InternetConnectionService']"
	[global::Android.Runtime.Register ("com/liveperson/infra/InternetConnectionService", DoNotGenerateAcw=true)]
	public partial class InternetConnectionService : global::Java.Lang.Object, global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDown {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='InternetConnectionService']/field[@name='BROADCAST_INTERNET_CONNECTION_CONNECTED']"
		[Register ("BROADCAST_INTERNET_CONNECTION_CONNECTED")]
		public const string BroadcastInternetConnectionConnected = (string) "CONNECTION_CONNECTED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='InternetConnectionService']/field[@name='BROADCAST_INTERNET_CONNECTION_DISCONNECTED']"
		[Register ("BROADCAST_INTERNET_CONNECTION_DISCONNECTED")]
		public const string BroadcastInternetConnectionDisconnected = (string) "CONNECTION_DISCONNECTED";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra']/class[@name='InternetConnectionService.ConnectionReceiver']"
		[global::Android.Runtime.Register ("com/liveperson/infra/InternetConnectionService$ConnectionReceiver", DoNotGenerateAcw=true)]
		public partial class ConnectionReceiver : global::Android.Content.BroadcastReceiver {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/InternetConnectionService$ConnectionReceiver", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ConnectionReceiver); }
			}

			protected ConnectionReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_infra_InternetConnectionService_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra']/class[@name='InternetConnectionService.ConnectionReceiver']/constructor[@name='InternetConnectionService.ConnectionReceiver' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.InternetConnectionService']]"
			[Register (".ctor", "(Lcom/liveperson/infra/InternetConnectionService;)V", "")]
			public unsafe ConnectionReceiver (global::Com.Liveperson.Infra.InternetConnectionService __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (ConnectionReceiver)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_infra_InternetConnectionService_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_infra_InternetConnectionService_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/InternetConnectionService;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_InternetConnectionService_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_InternetConnectionService_, __args);
				} finally {
				}
			}

			static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
			static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler ()
			{
				if (cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
					cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReceive_Landroid_content_Context_Landroid_content_Intent_);
				return cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
			}

			static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Liveperson.Infra.InternetConnectionService.ConnectionReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.InternetConnectionService.ConnectionReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnReceive (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onReceive_Landroid_content_Context_Landroid_content_Intent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='InternetConnectionService.ConnectionReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
			[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
			public override unsafe void OnReceive (global::Android.Content.Context p0, global::Android.Content.Intent p1)
			{
				if (id_onReceive_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
					id_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceive_Landroid_content_Context_Landroid_content_Intent_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_register_Landroid_content_Context_;
#pragma warning disable 0169
			static Delegate GetRegister_Landroid_content_Context_Handler ()
			{
				if (cb_register_Landroid_content_Context_ == null)
					cb_register_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Register_Landroid_content_Context_);
				return cb_register_Landroid_content_Context_;
			}

			static void n_Register_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Infra.InternetConnectionService.ConnectionReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.InternetConnectionService.ConnectionReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Register (p0);
			}
#pragma warning restore 0169

			static IntPtr id_register_Landroid_content_Context_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='InternetConnectionService.ConnectionReceiver']/method[@name='register' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register ("register", "(Landroid/content/Context;)V", "GetRegister_Landroid_content_Context_Handler")]
			public virtual unsafe void Register (global::Android.Content.Context p0)
			{
				if (id_register_Landroid_content_Context_ == IntPtr.Zero)
					id_register_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "register", "(Landroid/content/Context;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register_Landroid_content_Context_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "register", "(Landroid/content/Context;)V"), __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/InternetConnectionService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InternetConnectionService); }
		}

		protected InternetConnectionService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isNetworkAvailable;
		public static unsafe bool IsNetworkAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='InternetConnectionService']/method[@name='isNetworkAvailable' and count(parameter)=0]"
			[Register ("isNetworkAvailable", "()Z", "GetIsNetworkAvailableHandler")]
			get {
				if (id_isNetworkAvailable == IntPtr.Zero)
					id_isNetworkAvailable = JNIEnv.GetStaticMethodID (class_ref, "isNetworkAvailable", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNetworkAvailable);
				} finally {
				}
			}
		}

		static Delegate cb_registeredReceiver;
#pragma warning disable 0169
		static Delegate GetRegisteredReceiverHandler ()
		{
			if (cb_registeredReceiver == null)
				cb_registeredReceiver = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RegisteredReceiver);
			return cb_registeredReceiver;
		}

		static void n_RegisteredReceiver (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.InternetConnectionService __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.InternetConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RegisteredReceiver ();
		}
#pragma warning restore 0169

		static IntPtr id_registeredReceiver;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='InternetConnectionService']/method[@name='registeredReceiver' and count(parameter)=0]"
		[Register ("registeredReceiver", "()V", "GetRegisteredReceiverHandler")]
		public virtual unsafe void RegisteredReceiver ()
		{
			if (id_registeredReceiver == IntPtr.Zero)
				id_registeredReceiver = JNIEnv.GetMethodID (class_ref, "registeredReceiver", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registeredReceiver);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registeredReceiver", "()V"));
			} finally {
			}
		}

		static Delegate cb_shutDown;
#pragma warning disable 0169
		static Delegate GetShutDownHandler ()
		{
			if (cb_shutDown == null)
				cb_shutDown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShutDown);
			return cb_shutDown;
		}

		static void n_ShutDown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.InternetConnectionService __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.InternetConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShutDown ();
		}
#pragma warning restore 0169

		static IntPtr id_shutDown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='InternetConnectionService']/method[@name='shutDown' and count(parameter)=0]"
		[Register ("shutDown", "()V", "GetShutDownHandler")]
		public virtual unsafe void ShutDown ()
		{
			if (id_shutDown == IntPtr.Zero)
				id_shutDown = JNIEnv.GetMethodID (class_ref, "shutDown", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutDown);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shutDown", "()V"));
			} finally {
			}
		}

		static Delegate cb_unRegisteredReceiver;
#pragma warning disable 0169
		static Delegate GetUnRegisteredReceiverHandler ()
		{
			if (cb_unRegisteredReceiver == null)
				cb_unRegisteredReceiver = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnRegisteredReceiver);
			return cb_unRegisteredReceiver;
		}

		static void n_UnRegisteredReceiver (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.InternetConnectionService __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.InternetConnectionService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnRegisteredReceiver ();
		}
#pragma warning restore 0169

		static IntPtr id_unRegisteredReceiver;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='InternetConnectionService']/method[@name='unRegisteredReceiver' and count(parameter)=0]"
		[Register ("unRegisteredReceiver", "()V", "GetUnRegisteredReceiverHandler")]
		public virtual unsafe void UnRegisteredReceiver ()
		{
			if (id_unRegisteredReceiver == IntPtr.Zero)
				id_unRegisteredReceiver = JNIEnv.GetMethodID (class_ref, "unRegisteredReceiver", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unRegisteredReceiver);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unRegisteredReceiver", "()V"));
			} finally {
			}
		}

	}
}
