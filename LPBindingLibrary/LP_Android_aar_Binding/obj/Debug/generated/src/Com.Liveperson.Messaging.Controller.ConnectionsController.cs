using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Controller {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/controller/ConnectionsController", DoNotGenerateAcw=true)]
	public partial class ConnectionsController : global::Java.Lang.Object, global::Com.Liveperson.Infra.IClearable, global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownAsync {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/field[@name='KEY_PREF_LAST_UPDATE_TIME']"
		[Register ("KEY_PREF_LAST_UPDATE_TIME")]
		public const string KeyPrefLastUpdateTime = (string) "KEY_PREF_LAST_UPDATE_TIME";

		static IntPtr mBrandConnection_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/field[@name='mBrandConnection']"
		[Register ("mBrandConnection")]
		protected global::System.Collections.IDictionary MBrandConnection {
			get {
				if (mBrandConnection_jfieldId == IntPtr.Zero)
					mBrandConnection_jfieldId = JNIEnv.GetFieldID (class_ref, "mBrandConnection", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mBrandConnection_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mBrandConnection_jfieldId == IntPtr.Zero)
					mBrandConnection_jfieldId = JNIEnv.GetFieldID (class_ref, "mBrandConnection", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mBrandConnection_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mConnectionReceiver_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/field[@name='mConnectionReceiver']"
		[Register ("mConnectionReceiver")]
		protected global::Com.Liveperson.Infra.LocalBroadcastReceiver MConnectionReceiver {
			get {
				if (mConnectionReceiver_jfieldId == IntPtr.Zero)
					mConnectionReceiver_jfieldId = JNIEnv.GetFieldID (class_ref, "mConnectionReceiver", "Lcom/liveperson/infra/LocalBroadcastReceiver;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mConnectionReceiver_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LocalBroadcastReceiver> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mConnectionReceiver_jfieldId == IntPtr.Zero)
					mConnectionReceiver_jfieldId = JNIEnv.GetFieldID (class_ref, "mConnectionReceiver", "Lcom/liveperson/infra/LocalBroadcastReceiver;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mConnectionReceiver_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mController_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/field[@name='mController']"
		[Register ("mController")]
		protected global::Com.Liveperson.Messaging.Messaging MController {
			get {
				if (mController_jfieldId == IntPtr.Zero)
					mController_jfieldId = JNIEnv.GetFieldID (class_ref, "mController", "Lcom/liveperson/messaging/Messaging;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mController_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mController_jfieldId == IntPtr.Zero)
					mController_jfieldId = JNIEnv.GetFieldID (class_ref, "mController", "Lcom/liveperson/messaging/Messaging;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mController_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mSubscriptionBrand_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/field[@name='mSubscriptionBrand']"
		[Register ("mSubscriptionBrand")]
		protected global::System.Collections.IDictionary MSubscriptionBrand {
			get {
				if (mSubscriptionBrand_jfieldId == IntPtr.Zero)
					mSubscriptionBrand_jfieldId = JNIEnv.GetFieldID (class_ref, "mSubscriptionBrand", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mSubscriptionBrand_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSubscriptionBrand_jfieldId == IntPtr.Zero)
					mSubscriptionBrand_jfieldId = JNIEnv.GetFieldID (class_ref, "mSubscriptionBrand", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSubscriptionBrand_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController.AmsConnectionShutDownCompletionListener']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/controller/ConnectionsController$AmsConnectionShutDownCompletionListener", DoNotGenerateAcw=true)]
		public partial class AmsConnectionShutDownCompletionListener : global::Java.Lang.Object, global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/controller/ConnectionsController$AmsConnectionShutDownCompletionListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AmsConnectionShutDownCompletionListener); }
			}

			protected AmsConnectionShutDownCompletionListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_ILcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController.AmsConnectionShutDownCompletionListener']/constructor[@name='ConnectionsController.AmsConnectionShutDownCompletionListener' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.liveperson.infra.sdkstatemachine.shutdown.ShutDownCompletionListener']]"
			[Register (".ctor", "(ILcom/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener;)V", "")]
			public unsafe AmsConnectionShutDownCompletionListener (int p0, global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (((object) this).GetType () != typeof (AmsConnectionShutDownCompletionListener)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(ILcom/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(ILcom/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener;)V", __args);
						return;
					}

					if (id_ctor_ILcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ == IntPtr.Zero)
						id_ctor_ILcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILcom/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_ILcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_, __args);
				} finally {
				}
			}

			static Delegate cb_shutDownCompleted;
#pragma warning disable 0169
			static Delegate GetShutDownCompletedHandler ()
			{
				if (cb_shutDownCompleted == null)
					cb_shutDownCompleted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShutDownCompleted);
				return cb_shutDownCompleted;
			}

			static void n_ShutDownCompleted (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Messaging.Controller.ConnectionsController.AmsConnectionShutDownCompletionListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController.AmsConnectionShutDownCompletionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ShutDownCompleted ();
			}
#pragma warning restore 0169

			static IntPtr id_shutDownCompleted;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController.AmsConnectionShutDownCompletionListener']/method[@name='shutDownCompleted' and count(parameter)=0]"
			[Register ("shutDownCompleted", "()V", "GetShutDownCompletedHandler")]
			public virtual unsafe void ShutDownCompleted ()
			{
				if (id_shutDownCompleted == IntPtr.Zero)
					id_shutDownCompleted = JNIEnv.GetMethodID (class_ref, "shutDownCompleted", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutDownCompleted);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shutDownCompleted", "()V"));
				} finally {
				}
			}

			static Delegate cb_shutDownFailed;
#pragma warning disable 0169
			static Delegate GetShutDownFailedHandler ()
			{
				if (cb_shutDownFailed == null)
					cb_shutDownFailed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShutDownFailed);
				return cb_shutDownFailed;
			}

			static void n_ShutDownFailed (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Messaging.Controller.ConnectionsController.AmsConnectionShutDownCompletionListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController.AmsConnectionShutDownCompletionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ShutDownFailed ();
			}
#pragma warning restore 0169

			static IntPtr id_shutDownFailed;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController.AmsConnectionShutDownCompletionListener']/method[@name='shutDownFailed' and count(parameter)=0]"
			[Register ("shutDownFailed", "()V", "GetShutDownFailedHandler")]
			public virtual unsafe void ShutDownFailed ()
			{
				if (id_shutDownFailed == IntPtr.Zero)
					id_shutDownFailed = JNIEnv.GetMethodID (class_ref, "shutDownFailed", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutDownFailed);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shutDownFailed", "()V"));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/controller/ConnectionsController", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectionsController); }
		}

		protected ConnectionsController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_Messaging_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/constructor[@name='ConnectionsController' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.Messaging']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/Messaging;)V", "")]
		public unsafe ConnectionsController (global::Com.Liveperson.Messaging.Messaging p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ConnectionsController)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/Messaging;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/Messaging;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_Messaging_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_Messaging_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/Messaging;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_, __args);
			} finally {
			}
		}

		static Delegate cb_addNewConnection_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddNewConnection_Ljava_lang_String_Handler ()
		{
			if (cb_addNewConnection_Ljava_lang_String_ == null)
				cb_addNewConnection_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddNewConnection_Ljava_lang_String_);
			return cb_addNewConnection_Ljava_lang_String_;
		}

		static void n_AddNewConnection_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddNewConnection (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addNewConnection_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='addNewConnection' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addNewConnection", "(Ljava/lang/String;)V", "GetAddNewConnection_Ljava_lang_String_Handler")]
		public virtual unsafe void AddNewConnection (string p0)
		{
			if (id_addNewConnection_Ljava_lang_String_ == IntPtr.Zero)
				id_addNewConnection_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addNewConnection", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addNewConnection_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addNewConnection", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_connect_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_lang_String_Handler ()
		{
			if (cb_connect_Ljava_lang_String_ == null)
				cb_connect_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Connect_Ljava_lang_String_);
			return cb_connect_Ljava_lang_String_;
		}

		static void n_Connect_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0);
		}
#pragma warning restore 0169

		static IntPtr id_connect_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("connect", "(Ljava/lang/String;)V", "GetConnect_Ljava_lang_String_Handler")]
		public virtual unsafe void Connect (string p0)
		{
			if (id_connect_Ljava_lang_String_ == IntPtr.Zero)
				id_connect_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "connect", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_connect_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_lang_String_ZHandler ()
		{
			if (cb_connect_Ljava_lang_String_Z == null)
				cb_connect_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_Connect_Ljava_lang_String_Z);
			return cb_connect_Ljava_lang_String_Z;
		}

		static void n_Connect_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_connect_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='connect' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("connect", "(Ljava/lang/String;Z)V", "GetConnect_Ljava_lang_String_ZHandler")]
		public virtual unsafe void Connect (string p0, bool p1)
		{
			if (id_connect_Ljava_lang_String_Z == IntPtr.Zero)
				id_connect_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "connect", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "(Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_disconnect_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDisconnect_Ljava_lang_String_Handler ()
		{
			if (cb_disconnect_Ljava_lang_String_ == null)
				cb_disconnect_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Disconnect_Ljava_lang_String_);
			return cb_disconnect_Ljava_lang_String_;
		}

		static void n_Disconnect_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect (p0);
		}
#pragma warning restore 0169

		static IntPtr id_disconnect_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='disconnect' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("disconnect", "(Ljava/lang/String;)V", "GetDisconnect_Ljava_lang_String_Handler")]
		public virtual unsafe void Disconnect (string p0)
		{
			if (id_disconnect_Ljava_lang_String_ == IntPtr.Zero)
				id_disconnect_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "disconnect", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnect_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnect", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getBrandIDForSubscription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBrandIDForSubscription_Ljava_lang_String_Handler ()
		{
			if (cb_getBrandIDForSubscription_Ljava_lang_String_ == null)
				cb_getBrandIDForSubscription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBrandIDForSubscription_Ljava_lang_String_);
			return cb_getBrandIDForSubscription_Ljava_lang_String_;
		}

		static IntPtr n_GetBrandIDForSubscription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetBrandIDForSubscription (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBrandIDForSubscription_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='getBrandIDForSubscription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBrandIDForSubscription", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetBrandIDForSubscription_Ljava_lang_String_Handler")]
		public virtual unsafe string GetBrandIDForSubscription (string p0)
		{
			if (id_getBrandIDForSubscription_Ljava_lang_String_ == IntPtr.Zero)
				id_getBrandIDForSubscription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getBrandIDForSubscription", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBrandIDForSubscription_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBrandIDForSubscription", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getClockDiff_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetClockDiff_Ljava_lang_String_Handler ()
		{
			if (cb_getClockDiff_Ljava_lang_String_ == null)
				cb_getClockDiff_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_GetClockDiff_Ljava_lang_String_);
			return cb_getClockDiff_Ljava_lang_String_;
		}

		static long n_GetClockDiff_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetClockDiff (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getClockDiff_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='getClockDiff' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getClockDiff", "(Ljava/lang/String;)J", "GetGetClockDiff_Ljava_lang_String_Handler")]
		public virtual unsafe long GetClockDiff (string p0)
		{
			if (id_getClockDiff_Ljava_lang_String_ == IntPtr.Zero)
				id_getClockDiff_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getClockDiff", "(Ljava/lang/String;)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getClockDiff_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClockDiff", "(Ljava/lang/String;)J"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getConnection_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetConnection_Ljava_lang_String_Handler ()
		{
			if (cb_getConnection_Ljava_lang_String_ == null)
				cb_getConnection_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConnection_Ljava_lang_String_);
			return cb_getConnection_Ljava_lang_String_;
		}

		static IntPtr n_GetConnection_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConnection (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConnection_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='getConnection' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getConnection", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/AmsConnection;", "GetGetConnection_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Model.AmsConnection GetConnection (string p0)
		{
			if (id_getConnection_Ljava_lang_String_ == IntPtr.Zero)
				id_getConnection_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getConnection", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/AmsConnection;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Messaging.Model.AmsConnection __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConnection_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnection", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/AmsConnection;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getLastUpdateTime_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLastUpdateTime_Ljava_lang_String_Handler ()
		{
			if (cb_getLastUpdateTime_Ljava_lang_String_ == null)
				cb_getLastUpdateTime_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_GetLastUpdateTime_Ljava_lang_String_);
			return cb_getLastUpdateTime_Ljava_lang_String_;
		}

		static long n_GetLastUpdateTime_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetLastUpdateTime (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLastUpdateTime_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='getLastUpdateTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLastUpdateTime", "(Ljava/lang/String;)J", "GetGetLastUpdateTime_Ljava_lang_String_Handler")]
		public virtual unsafe long GetLastUpdateTime (string p0)
		{
			if (id_getLastUpdateTime_Ljava_lang_String_ == IntPtr.Zero)
				id_getLastUpdateTime_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLastUpdateTime", "(Ljava/lang/String;)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLastUpdateTime_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastUpdateTime", "(Ljava/lang/String;)J"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getSubscriptionId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSubscriptionId_Ljava_lang_String_Handler ()
		{
			if (cb_getSubscriptionId_Ljava_lang_String_ == null)
				cb_getSubscriptionId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSubscriptionId_Ljava_lang_String_);
			return cb_getSubscriptionId_Ljava_lang_String_;
		}

		static IntPtr n_GetSubscriptionId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetSubscriptionId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSubscriptionId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='getSubscriptionId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSubscriptionId", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetSubscriptionId_Ljava_lang_String_Handler")]
		public virtual unsafe string GetSubscriptionId (string p0)
		{
			if (id_getSubscriptionId_Ljava_lang_String_ == IntPtr.Zero)
				id_getSubscriptionId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getSubscriptionId", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubscriptionId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSubscriptionId", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_initConnectionReceiver;
#pragma warning disable 0169
		static Delegate GetInitConnectionReceiverHandler ()
		{
			if (cb_initConnectionReceiver == null)
				cb_initConnectionReceiver = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitConnectionReceiver);
			return cb_initConnectionReceiver;
		}

		static void n_InitConnectionReceiver (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitConnectionReceiver ();
		}
#pragma warning restore 0169

		static IntPtr id_initConnectionReceiver;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='initConnectionReceiver' and count(parameter)=0]"
		[Register ("initConnectionReceiver", "()V", "GetInitConnectionReceiverHandler")]
		public virtual unsafe void InitConnectionReceiver ()
		{
			if (id_initConnectionReceiver == IntPtr.Zero)
				id_initConnectionReceiver = JNIEnv.GetMethodID (class_ref, "initConnectionReceiver", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initConnectionReceiver);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initConnectionReceiver", "()V"));
			} finally {
			}
		}

		static Delegate cb_isConnecting_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsConnecting_Ljava_lang_String_Handler ()
		{
			if (cb_isConnecting_Ljava_lang_String_ == null)
				cb_isConnecting_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsConnecting_Ljava_lang_String_);
			return cb_isConnecting_Ljava_lang_String_;
		}

		static bool n_IsConnecting_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsConnecting (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isConnecting_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='isConnecting' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isConnecting", "(Ljava/lang/String;)Z", "GetIsConnecting_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsConnecting (string p0)
		{
			if (id_isConnecting_Ljava_lang_String_ == IntPtr.Zero)
				id_isConnecting_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isConnecting", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConnecting_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConnecting", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isFirstNotificationAfterSubscribe_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsFirstNotificationAfterSubscribe_Ljava_lang_String_Handler ()
		{
			if (cb_isFirstNotificationAfterSubscribe_Ljava_lang_String_ == null)
				cb_isFirstNotificationAfterSubscribe_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsFirstNotificationAfterSubscribe_Ljava_lang_String_);
			return cb_isFirstNotificationAfterSubscribe_Ljava_lang_String_;
		}

		static bool n_IsFirstNotificationAfterSubscribe_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsFirstNotificationAfterSubscribe (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isFirstNotificationAfterSubscribe_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='isFirstNotificationAfterSubscribe' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isFirstNotificationAfterSubscribe", "(Ljava/lang/String;)Z", "GetIsFirstNotificationAfterSubscribe_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsFirstNotificationAfterSubscribe (string p0)
		{
			if (id_isFirstNotificationAfterSubscribe_Ljava_lang_String_ == IntPtr.Zero)
				id_isFirstNotificationAfterSubscribe_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isFirstNotificationAfterSubscribe", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFirstNotificationAfterSubscribe_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFirstNotificationAfterSubscribe", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isLastUpdateTimeExists_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsLastUpdateTimeExists_Ljava_lang_String_Handler ()
		{
			if (cb_isLastUpdateTimeExists_Ljava_lang_String_ == null)
				cb_isLastUpdateTimeExists_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsLastUpdateTimeExists_Ljava_lang_String_);
			return cb_isLastUpdateTimeExists_Ljava_lang_String_;
		}

		static bool n_IsLastUpdateTimeExists_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsLastUpdateTimeExists (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isLastUpdateTimeExists_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='isLastUpdateTimeExists' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isLastUpdateTimeExists", "(Ljava/lang/String;)Z", "GetIsLastUpdateTimeExists_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsLastUpdateTimeExists (string p0)
		{
			if (id_isLastUpdateTimeExists_Ljava_lang_String_ == IntPtr.Zero)
				id_isLastUpdateTimeExists_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isLastUpdateTimeExists", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLastUpdateTimeExists_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLastUpdateTimeExists", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isSocketOpen_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsSocketOpen_Ljava_lang_String_Handler ()
		{
			if (cb_isSocketOpen_Ljava_lang_String_ == null)
				cb_isSocketOpen_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsSocketOpen_Ljava_lang_String_);
			return cb_isSocketOpen_Ljava_lang_String_;
		}

		static bool n_IsSocketOpen_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsSocketOpen (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isSocketOpen_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='isSocketOpen' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isSocketOpen", "(Ljava/lang/String;)Z", "GetIsSocketOpen_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsSocketOpen (string p0)
		{
			if (id_isSocketOpen_Ljava_lang_String_ == IntPtr.Zero)
				id_isSocketOpen_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isSocketOpen", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSocketOpen_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSocketOpen", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isSocketReady_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsSocketReady_Ljava_lang_String_Handler ()
		{
			if (cb_isSocketReady_Ljava_lang_String_ == null)
				cb_isSocketReady_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsSocketReady_Ljava_lang_String_);
			return cb_isSocketReady_Ljava_lang_String_;
		}

		static bool n_IsSocketReady_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsSocketReady (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isSocketReady_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='isSocketReady' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isSocketReady", "(Ljava/lang/String;)Z", "GetIsSocketReady_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsSocketReady (string p0)
		{
			if (id_isSocketReady_Ljava_lang_String_ == IntPtr.Zero)
				id_isSocketReady_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isSocketReady", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSocketReady_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSocketReady", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isUpdated_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsUpdated_Ljava_lang_String_Handler ()
		{
			if (cb_isUpdated_Ljava_lang_String_ == null)
				cb_isUpdated_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsUpdated_Ljava_lang_String_);
			return cb_isUpdated_Ljava_lang_String_;
		}

		static bool n_IsUpdated_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsUpdated (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isUpdated_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='isUpdated' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isUpdated", "(Ljava/lang/String;)Z", "GetIsUpdated_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsUpdated (string p0)
		{
			if (id_isUpdated_Ljava_lang_String_ == IntPtr.Zero)
				id_isUpdated_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isUpdated", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUpdated_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUpdated", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_moveToBackground_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetMoveToBackground_Ljava_lang_String_JHandler ()
		{
			if (cb_moveToBackground_Ljava_lang_String_J == null)
				cb_moveToBackground_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_MoveToBackground_Ljava_lang_String_J);
			return cb_moveToBackground_Ljava_lang_String_J;
		}

		static void n_MoveToBackground_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MoveToBackground (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_moveToBackground_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='moveToBackground' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("moveToBackground", "(Ljava/lang/String;J)V", "GetMoveToBackground_Ljava_lang_String_JHandler")]
		public virtual unsafe void MoveToBackground (string p0, long p1)
		{
			if (id_moveToBackground_Ljava_lang_String_J == IntPtr.Zero)
				id_moveToBackground_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "moveToBackground", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_moveToBackground_Ljava_lang_String_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moveToBackground", "(Ljava/lang/String;J)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_moveToForeground_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMoveToForeground_Ljava_lang_String_Handler ()
		{
			if (cb_moveToForeground_Ljava_lang_String_ == null)
				cb_moveToForeground_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MoveToForeground_Ljava_lang_String_);
			return cb_moveToForeground_Ljava_lang_String_;
		}

		static void n_MoveToForeground_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MoveToForeground (p0);
		}
#pragma warning restore 0169

		static IntPtr id_moveToForeground_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='moveToForeground' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("moveToForeground", "(Ljava/lang/String;)V", "GetMoveToForeground_Ljava_lang_String_Handler")]
		public virtual unsafe void MoveToForeground (string p0)
		{
			if (id_moveToForeground_Ljava_lang_String_ == IntPtr.Zero)
				id_moveToForeground_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "moveToForeground", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_moveToForeground_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moveToForeground", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_networkAvailable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNetworkAvailable_Ljava_lang_String_Handler ()
		{
			if (cb_networkAvailable_Ljava_lang_String_ == null)
				cb_networkAvailable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NetworkAvailable_Ljava_lang_String_);
			return cb_networkAvailable_Ljava_lang_String_;
		}

		static void n_NetworkAvailable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NetworkAvailable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_networkAvailable_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='networkAvailable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("networkAvailable", "(Ljava/lang/String;)V", "GetNetworkAvailable_Ljava_lang_String_Handler")]
		public virtual unsafe void NetworkAvailable (string p0)
		{
			if (id_networkAvailable_Ljava_lang_String_ == IntPtr.Zero)
				id_networkAvailable_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "networkAvailable", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_networkAvailable_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "networkAvailable", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_networkLost_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNetworkLost_Ljava_lang_String_Handler ()
		{
			if (cb_networkLost_Ljava_lang_String_ == null)
				cb_networkLost_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NetworkLost_Ljava_lang_String_);
			return cb_networkLost_Ljava_lang_String_;
		}

		static void n_NetworkLost_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NetworkLost (p0);
		}
#pragma warning restore 0169

		static IntPtr id_networkLost_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='networkLost' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("networkLost", "(Ljava/lang/String;)V", "GetNetworkLost_Ljava_lang_String_Handler")]
		public virtual unsafe void NetworkLost (string p0)
		{
			if (id_networkLost_Ljava_lang_String_ == IntPtr.Zero)
				id_networkLost_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "networkLost", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_networkLost_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "networkLost", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onResumeConnection;
#pragma warning disable 0169
		static Delegate GetOnResumeConnectionHandler ()
		{
			if (cb_onResumeConnection == null)
				cb_onResumeConnection = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResumeConnection);
			return cb_onResumeConnection;
		}

		static void n_OnResumeConnection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResumeConnection ();
		}
#pragma warning restore 0169

		static IntPtr id_onResumeConnection;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='onResumeConnection' and count(parameter)=0]"
		[Register ("onResumeConnection", "()V", "GetOnResumeConnectionHandler")]
		protected virtual unsafe void OnResumeConnection ()
		{
			if (id_onResumeConnection == IntPtr.Zero)
				id_onResumeConnection = JNIEnv.GetMethodID (class_ref, "onResumeConnection", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResumeConnection);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResumeConnection", "()V"));
			} finally {
			}
		}

		static Delegate cb_registerSocket_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterSocket_Ljava_lang_String_Handler ()
		{
			if (cb_registerSocket_Ljava_lang_String_ == null)
				cb_registerSocket_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterSocket_Ljava_lang_String_);
			return cb_registerSocket_Ljava_lang_String_;
		}

		static IntPtr n_RegisterSocket_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RegisterSocket (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_registerSocket_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='registerSocket' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("registerSocket", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/AmsConnection$AmsSocketState;", "GetRegisterSocket_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Model.AmsConnection.AmsSocketState RegisterSocket (string p0)
		{
			if (id_registerSocket_Ljava_lang_String_ == IntPtr.Zero)
				id_registerSocket_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "registerSocket", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/AmsConnection$AmsSocketState;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Messaging.Model.AmsConnection.AmsSocketState __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection.AmsSocketState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_registerSocket_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection.AmsSocketState> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerSocket", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/AmsConnection$AmsSocketState;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_serviceStarted_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetServiceStarted_Ljava_lang_String_Handler ()
		{
			if (cb_serviceStarted_Ljava_lang_String_ == null)
				cb_serviceStarted_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ServiceStarted_Ljava_lang_String_);
			return cb_serviceStarted_Ljava_lang_String_;
		}

		static void n_ServiceStarted_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ServiceStarted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_serviceStarted_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='serviceStarted' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("serviceStarted", "(Ljava/lang/String;)V", "GetServiceStarted_Ljava_lang_String_Handler")]
		public virtual unsafe void ServiceStarted (string p0)
		{
			if (id_serviceStarted_Ljava_lang_String_ == IntPtr.Zero)
				id_serviceStarted_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "serviceStarted", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_serviceStarted_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "serviceStarted", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_serviceStopped_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetServiceStopped_Ljava_lang_String_Handler ()
		{
			if (cb_serviceStopped_Ljava_lang_String_ == null)
				cb_serviceStopped_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ServiceStopped_Ljava_lang_String_);
			return cb_serviceStopped_Ljava_lang_String_;
		}

		static void n_ServiceStopped_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ServiceStopped (p0);
		}
#pragma warning restore 0169

		static IntPtr id_serviceStopped_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='serviceStopped' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("serviceStopped", "(Ljava/lang/String;)V", "GetServiceStopped_Ljava_lang_String_Handler")]
		public virtual unsafe void ServiceStopped (string p0)
		{
			if (id_serviceStopped_Ljava_lang_String_ == IntPtr.Zero)
				id_serviceStopped_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "serviceStopped", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_serviceStopped_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "serviceStopped", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setClockDiff_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetSetClockDiff_Ljava_lang_String_JHandler ()
		{
			if (cb_setClockDiff_Ljava_lang_String_J == null)
				cb_setClockDiff_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_SetClockDiff_Ljava_lang_String_J);
			return cb_setClockDiff_Ljava_lang_String_J;
		}

		static void n_SetClockDiff_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetClockDiff (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setClockDiff_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='setClockDiff' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("setClockDiff", "(Ljava/lang/String;J)V", "GetSetClockDiff_Ljava_lang_String_JHandler")]
		public virtual unsafe void SetClockDiff (string p0, long p1)
		{
			if (id_setClockDiff_Ljava_lang_String_J == IntPtr.Zero)
				id_setClockDiff_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "setClockDiff", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setClockDiff_Ljava_lang_String_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClockDiff", "(Ljava/lang/String;J)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setFirstNotificationAfterSubscribe_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSetFirstNotificationAfterSubscribe_Ljava_lang_String_ZHandler ()
		{
			if (cb_setFirstNotificationAfterSubscribe_Ljava_lang_String_Z == null)
				cb_setFirstNotificationAfterSubscribe_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetFirstNotificationAfterSubscribe_Ljava_lang_String_Z);
			return cb_setFirstNotificationAfterSubscribe_Ljava_lang_String_Z;
		}

		static void n_SetFirstNotificationAfterSubscribe_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetFirstNotificationAfterSubscribe (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setFirstNotificationAfterSubscribe_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='setFirstNotificationAfterSubscribe' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("setFirstNotificationAfterSubscribe", "(Ljava/lang/String;Z)V", "GetSetFirstNotificationAfterSubscribe_Ljava_lang_String_ZHandler")]
		public virtual unsafe void SetFirstNotificationAfterSubscribe (string p0, bool p1)
		{
			if (id_setFirstNotificationAfterSubscribe_Ljava_lang_String_Z == IntPtr.Zero)
				id_setFirstNotificationAfterSubscribe_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "setFirstNotificationAfterSubscribe", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFirstNotificationAfterSubscribe_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFirstNotificationAfterSubscribe", "(Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setLastUpdateTime_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetSetLastUpdateTime_Ljava_lang_String_JHandler ()
		{
			if (cb_setLastUpdateTime_Ljava_lang_String_J == null)
				cb_setLastUpdateTime_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_SetLastUpdateTime_Ljava_lang_String_J);
			return cb_setLastUpdateTime_Ljava_lang_String_J;
		}

		static void n_SetLastUpdateTime_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLastUpdateTime (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setLastUpdateTime_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='setLastUpdateTime' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("setLastUpdateTime", "(Ljava/lang/String;J)V", "GetSetLastUpdateTime_Ljava_lang_String_JHandler")]
		public virtual unsafe void SetLastUpdateTime (string p0, long p1)
		{
			if (id_setLastUpdateTime_Ljava_lang_String_J == IntPtr.Zero)
				id_setLastUpdateTime_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "setLastUpdateTime", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastUpdateTime_Ljava_lang_String_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastUpdateTime", "(Ljava/lang/String;J)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setSubscription_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSubscription_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setSubscription_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setSubscription_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetSubscription_Ljava_lang_String_Ljava_lang_String_);
			return cb_setSubscription_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetSubscription_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetSubscription (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setSubscription_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='setSubscription' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setSubscription", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetSubscription_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetSubscription (string p0, string p1)
		{
			if (id_setSubscription_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setSubscription_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSubscription", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSubscription_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSubscription", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_;
#pragma warning disable 0169
		static Delegate GetShutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_Handler ()
		{
			if (cb_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ == null)
				cb_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_);
			return cb_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_;
		}

		static void n_ShutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener p0 = (global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShutDown (p0);
		}
#pragma warning restore 0169

		static IntPtr id_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='shutDown' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.shutdown.ShutDownCompletionListener']]"
		[Register ("shutDown", "(Lcom/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener;)V", "GetShutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_Handler")]
		public virtual unsafe void ShutDown (global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener p0)
		{
			if (id_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ == IntPtr.Zero)
				id_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ = JNIEnv.GetMethodID (class_ref, "shutDown", "(Lcom/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shutDown", "(Lcom/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_unregisterConnectionReceiver;
#pragma warning disable 0169
		static Delegate GetUnregisterConnectionReceiverHandler ()
		{
			if (cb_unregisterConnectionReceiver == null)
				cb_unregisterConnectionReceiver = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnregisterConnectionReceiver);
			return cb_unregisterConnectionReceiver;
		}

		static void n_UnregisterConnectionReceiver (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.ConnectionsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterConnectionReceiver ();
		}
#pragma warning restore 0169

		static IntPtr id_unregisterConnectionReceiver;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ConnectionsController']/method[@name='unregisterConnectionReceiver' and count(parameter)=0]"
		[Register ("unregisterConnectionReceiver", "()V", "GetUnregisterConnectionReceiverHandler")]
		public virtual unsafe void UnregisterConnectionReceiver ()
		{
			if (id_unregisterConnectionReceiver == IntPtr.Zero)
				id_unregisterConnectionReceiver = JNIEnv.GetMethodID (class_ref, "unregisterConnectionReceiver", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterConnectionReceiver);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregisterConnectionReceiver", "()V"));
			} finally {
			}
		}

	}
}
