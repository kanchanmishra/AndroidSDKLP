using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='MessagingFactory']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/MessagingFactory", DoNotGenerateAcw=true)]
	public partial class MessagingFactory : global::Java.Lang.Object {


		static IntPtr messagingController_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='MessagingFactory']/field[@name='messagingController']"
		[Register ("messagingController")]
		protected global::Com.Liveperson.Messaging.Messaging MessagingController {
			get {
				if (messagingController_jfieldId == IntPtr.Zero)
					messagingController_jfieldId = JNIEnv.GetFieldID (class_ref, "messagingController", "Lcom/liveperson/messaging/Messaging;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, messagingController_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (messagingController_jfieldId == IntPtr.Zero)
					messagingController_jfieldId = JNIEnv.GetFieldID (class_ref, "messagingController", "Lcom/liveperson/messaging/Messaging;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, messagingController_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/MessagingFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessagingFactory); }
		}

		protected MessagingFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='MessagingFactory']/constructor[@name='MessagingFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe MessagingFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MessagingFactory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getController;
#pragma warning disable 0169
		static Delegate GetGetControllerHandler ()
		{
			if (cb_getController == null)
				cb_getController = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetController);
			return cb_getController;
		}

		static IntPtr n_GetController (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.MessagingFactory __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.MessagingFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Controller);
		}
#pragma warning restore 0169

		static IntPtr id_getController;
		public virtual unsafe global::Com.Liveperson.Messaging.Messaging Controller {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='MessagingFactory']/method[@name='getController' and count(parameter)=0]"
			[Register ("getController", "()Lcom/liveperson/messaging/Messaging;", "GetGetControllerHandler")]
			get {
				if (id_getController == IntPtr.Zero)
					id_getController = JNIEnv.GetMethodID (class_ref, "getController", "()Lcom/liveperson/messaging/Messaging;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getController), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getController", "()Lcom/liveperson/messaging/Messaging;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Liveperson.Messaging.MessagingFactory Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='MessagingFactory']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/liveperson/messaging/MessagingFactory;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/liveperson/messaging/MessagingFactory;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.MessagingFactory> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isInitialized;
#pragma warning disable 0169
		static Delegate GetIsInitializedHandler ()
		{
			if (cb_isInitialized == null)
				cb_isInitialized = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInitialized);
			return cb_isInitialized;
		}

		static bool n_IsInitialized (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.MessagingFactory __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.MessagingFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInitialized;
		}
#pragma warning restore 0169

		static IntPtr id_isInitialized;
		public virtual unsafe bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='MessagingFactory']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "GetIsInitializedHandler")]
			get {
				if (id_isInitialized == IntPtr.Zero)
					id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInitialized);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInitialized", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_bootstrapRegistration;
#pragma warning disable 0169
		static Delegate GetBootstrapRegistrationHandler ()
		{
			if (cb_bootstrapRegistration == null)
				cb_bootstrapRegistration = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_BootstrapRegistration);
			return cb_bootstrapRegistration;
		}

		static void n_BootstrapRegistration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.MessagingFactory __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.MessagingFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BootstrapRegistration ();
		}
#pragma warning restore 0169

		static IntPtr id_bootstrapRegistration;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='MessagingFactory']/method[@name='bootstrapRegistration' and count(parameter)=0]"
		[Register ("bootstrapRegistration", "()V", "GetBootstrapRegistrationHandler")]
		protected virtual unsafe void BootstrapRegistration ()
		{
			if (id_bootstrapRegistration == IntPtr.Zero)
				id_bootstrapRegistration = JNIEnv.GetMethodID (class_ref, "bootstrapRegistration", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bootstrapRegistration);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bootstrapRegistration", "()V"));
			} finally {
			}
		}

		static Delegate cb_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_Handler ()
		{
			if (cb_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_ == null)
				cb_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_);
			return cb_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_;
		}

		static void n_Init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.MessagingFactory __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.MessagingFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.MessagingInitData p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.MessagingInitData> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.InitProcess p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.InitProcess> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='MessagingFactory']/method[@name='init' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.liveperson.messaging.MessagingInitData'] and parameter[3][@type='com.liveperson.infra.statemachine.InitProcess']]"
		[Register ("init", "(Landroid/content/Context;Lcom/liveperson/messaging/MessagingInitData;Lcom/liveperson/infra/statemachine/InitProcess;)V", "GetInit_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_Handler")]
		public virtual unsafe void Init (global::Android.Content.Context p0, global::Com.Liveperson.Messaging.MessagingInitData p1, global::Com.Liveperson.Infra.Statemachine.InitProcess p2)
		{
			if (id_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_ == IntPtr.Zero)
				id_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_ = JNIEnv.GetMethodID (class_ref, "init", "(Landroid/content/Context;Lcom/liveperson/messaging/MessagingInitData;Lcom/liveperson/infra/statemachine/InitProcess;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Landroid/content/Context;Lcom/liveperson/messaging/MessagingInitData;Lcom/liveperson/infra/statemachine/InitProcess;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_;
#pragma warning disable 0169
		static Delegate GetLogout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_Handler ()
		{
			if (cb_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_ == null)
				cb_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_);
			return cb_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_;
		}

		static void n_Logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.MessagingFactory __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.MessagingFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.MessagingInitData p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.MessagingInitData> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.LogoutProcess p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.LogoutProcess> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Logout (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='MessagingFactory']/method[@name='logout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.liveperson.messaging.MessagingInitData'] and parameter[3][@type='com.liveperson.infra.statemachine.LogoutProcess']]"
		[Register ("logout", "(Landroid/content/Context;Lcom/liveperson/messaging/MessagingInitData;Lcom/liveperson/infra/statemachine/LogoutProcess;)V", "GetLogout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_Handler")]
		public virtual unsafe void Logout (global::Android.Content.Context p0, global::Com.Liveperson.Messaging.MessagingInitData p1, global::Com.Liveperson.Infra.Statemachine.LogoutProcess p2)
		{
			if (id_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_ == IntPtr.Zero)
				id_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_ = JNIEnv.GetMethodID (class_ref, "logout", "(Landroid/content/Context;Lcom/liveperson/messaging/MessagingInitData;Lcom/liveperson/infra/statemachine/LogoutProcess;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logout", "(Landroid/content/Context;Lcom/liveperson/messaging/MessagingInitData;Lcom/liveperson/infra/statemachine/LogoutProcess;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_;
#pragma warning disable 0169
		static Delegate GetShutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_Handler ()
		{
			if (cb_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_ == null)
				cb_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_);
			return cb_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_;
		}

		static void n_ShutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.MessagingFactory __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.MessagingFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.ShutDownProcess p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.ShutDownProcess> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShutDown (p0);
		}
#pragma warning restore 0169

		static IntPtr id_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='MessagingFactory']/method[@name='shutDown' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.ShutDownProcess']]"
		[Register ("shutDown", "(Lcom/liveperson/infra/statemachine/ShutDownProcess;)V", "GetShutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_Handler")]
		public virtual unsafe void ShutDown (global::Com.Liveperson.Infra.Statemachine.ShutDownProcess p0)
		{
			if (id_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_ == IntPtr.Zero)
				id_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_ = JNIEnv.GetMethodID (class_ref, "shutDown", "(Lcom/liveperson/infra/statemachine/ShutDownProcess;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shutDown", "(Lcom/liveperson/infra/statemachine/ShutDownProcess;)V"), __args);
			} finally {
			}
		}

	}
}
