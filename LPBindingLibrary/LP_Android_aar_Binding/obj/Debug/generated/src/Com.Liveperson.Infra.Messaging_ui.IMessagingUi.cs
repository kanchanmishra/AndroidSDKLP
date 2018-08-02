using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/interface[@name='IMessagingUi']"
	[Register ("com/liveperson/infra/messaging_ui/IMessagingUi", "", "Com.Liveperson.Infra.Messaging_ui.IMessagingUiInvoker")]
	public partial interface IMessagingUi : IJavaObject {

		bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/interface[@name='IMessagingUi']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "GetIsInitializedHandler:Com.Liveperson.Infra.Messaging_ui.IMessagingUiInvoker, LP_Android_aar_Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/interface[@name='IMessagingUi']/method[@name='getConversationFragment' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.LPAuthenticationParams'] and parameter[3][@type='com.liveperson.infra.ConversationViewParams']]"
		[Register ("getConversationFragment", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ConversationViewParams;)Landroid/support/v4/app/Fragment;", "GetGetConversationFragment_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Handler:Com.Liveperson.Infra.Messaging_ui.IMessagingUiInvoker, LP_Android_aar_Binding")]
		global::Android.Support.V4.App.Fragment GetConversationFragment (string p0, global::Com.Liveperson.Infra.LPAuthenticationParams p1, global::Com.Liveperson.Infra.ConversationViewParams p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/interface[@name='IMessagingUi']/method[@name='hideConversation' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("hideConversation", "(Landroid/app/Activity;)V", "GetHideConversation_Landroid_app_Activity_Handler:Com.Liveperson.Infra.Messaging_ui.IMessagingUiInvoker, LP_Android_aar_Binding")]
		void HideConversation (global::Android.App.Activity p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/interface[@name='IMessagingUi']/method[@name='init' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.liveperson.infra.messaging_ui.MessagingUiInitData'] and parameter[3][@type='com.liveperson.infra.messaging_ui.MessagingUiConfiguration']]"
		[Register ("init", "(Landroid/content/Context;Lcom/liveperson/infra/messaging_ui/MessagingUiInitData;Lcom/liveperson/infra/messaging_ui/MessagingUiConfiguration;)V", "GetInit_Landroid_content_Context_Lcom_liveperson_infra_messaging_ui_MessagingUiInitData_Lcom_liveperson_infra_messaging_ui_MessagingUiConfiguration_Handler:Com.Liveperson.Infra.Messaging_ui.IMessagingUiInvoker, LP_Android_aar_Binding")]
		void Init (global::Android.Content.Context p0, global::Com.Liveperson.Infra.Messaging_ui.MessagingUiInitData p1, global::Com.Liveperson.Infra.Messaging_ui.MessagingUiConfiguration p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/interface[@name='IMessagingUi']/method[@name='logout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.liveperson.infra.messaging_ui.MessagingUiInitData'] and parameter[3][@type='com.liveperson.infra.callbacks.LogoutLivePersonCallBack']]"
		[Register ("logout", "(Landroid/content/Context;Lcom/liveperson/infra/messaging_ui/MessagingUiInitData;Lcom/liveperson/infra/callbacks/LogoutLivePersonCallBack;)V", "GetLogout_Landroid_content_Context_Lcom_liveperson_infra_messaging_ui_MessagingUiInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_Handler:Com.Liveperson.Infra.Messaging_ui.IMessagingUiInvoker, LP_Android_aar_Binding")]
		void Logout (global::Android.Content.Context p0, global::Com.Liveperson.Infra.Messaging_ui.MessagingUiInitData p1, global::Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBack p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/interface[@name='IMessagingUi']/method[@name='onAgentAvatarTapped' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onAgentAvatarTapped", "(Ljava/lang/String;)V", "GetOnAgentAvatarTapped_Ljava_lang_String_Handler:Com.Liveperson.Infra.Messaging_ui.IMessagingUiInvoker, LP_Android_aar_Binding")]
		void OnAgentAvatarTapped (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/interface[@name='IMessagingUi']/method[@name='setConfiguration' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.messaging_ui.MessagingUiConfiguration']]"
		[Register ("setConfiguration", "(Lcom/liveperson/infra/messaging_ui/MessagingUiConfiguration;)V", "GetSetConfiguration_Lcom_liveperson_infra_messaging_ui_MessagingUiConfiguration_Handler:Com.Liveperson.Infra.Messaging_ui.IMessagingUiInvoker, LP_Android_aar_Binding")]
		void SetConfiguration (global::Com.Liveperson.Infra.Messaging_ui.MessagingUiConfiguration p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/interface[@name='IMessagingUi']/method[@name='showConversation' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.infra.LPAuthenticationParams'] and parameter[4][@type='com.liveperson.infra.ConversationViewParams']]"
		[Register ("showConversation", "(Landroid/app/Activity;Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ConversationViewParams;)Z", "GetShowConversation_Landroid_app_Activity_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Handler:Com.Liveperson.Infra.Messaging_ui.IMessagingUiInvoker, LP_Android_aar_Binding")]
		bool ShowConversation (global::Android.App.Activity p0, string p1, global::Com.Liveperson.Infra.LPAuthenticationParams p2, global::Com.Liveperson.Infra.ConversationViewParams p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/interface[@name='IMessagingUi']/method[@name='shutDown' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.shutdown.ShutDownCompletionListener']]"
		[Register ("shutDown", "(Lcom/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener;)V", "GetShutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_Handler:Com.Liveperson.Infra.Messaging_ui.IMessagingUiInvoker, LP_Android_aar_Binding")]
		void ShutDown (global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/IMessagingUi", DoNotGenerateAcw=true)]
	internal class IMessagingUiInvoker : global::Java.Lang.Object, IMessagingUi {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/IMessagingUi");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMessagingUiInvoker); }
		}

		IntPtr class_ref;

		public static IMessagingUi GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMessagingUi> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.messaging_ui.IMessagingUi"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMessagingUiInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Liveperson.Infra.Messaging_ui.IMessagingUi __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.IMessagingUi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInitialized;
		}
#pragma warning restore 0169

		IntPtr id_isInitialized;
		public unsafe bool IsInitialized {
			get {
				if (id_isInitialized == IntPtr.Zero)
					id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInitialized);
			}
		}

		static Delegate cb_getConversationFragment_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_;
#pragma warning disable 0169
		static Delegate GetGetConversationFragment_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Handler ()
		{
			if (cb_getConversationFragment_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ == null)
				cb_getConversationFragment_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConversationFragment_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_);
			return cb_getConversationFragment_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_;
		}

		static IntPtr n_GetConversationFragment_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Infra.Messaging_ui.IMessagingUi __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.IMessagingUi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.LPAuthenticationParams p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ConversationViewParams p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConversationFragment (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getConversationFragment_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_;
		public unsafe global::Android.Support.V4.App.Fragment GetConversationFragment (string p0, global::Com.Liveperson.Infra.LPAuthenticationParams p1, global::Com.Liveperson.Infra.ConversationViewParams p2)
		{
			if (id_getConversationFragment_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ == IntPtr.Zero)
				id_getConversationFragment_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ = JNIEnv.GetMethodID (class_ref, "getConversationFragment", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ConversationViewParams;)Landroid/support/v4/app/Fragment;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			global::Android.Support.V4.App.Fragment __ret = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.Fragment> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationFragment_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_hideConversation_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetHideConversation_Landroid_app_Activity_Handler ()
		{
			if (cb_hideConversation_Landroid_app_Activity_ == null)
				cb_hideConversation_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HideConversation_Landroid_app_Activity_);
			return cb_hideConversation_Landroid_app_Activity_;
		}

		static void n_HideConversation_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.IMessagingUi __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.IMessagingUi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HideConversation (p0);
		}
#pragma warning restore 0169

		IntPtr id_hideConversation_Landroid_app_Activity_;
		public unsafe void HideConversation (global::Android.App.Activity p0)
		{
			if (id_hideConversation_Landroid_app_Activity_ == IntPtr.Zero)
				id_hideConversation_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "hideConversation", "(Landroid/app/Activity;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hideConversation_Landroid_app_Activity_, __args);
		}

		static Delegate cb_init_Landroid_content_Context_Lcom_liveperson_infra_messaging_ui_MessagingUiInitData_Lcom_liveperson_infra_messaging_ui_MessagingUiConfiguration_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Lcom_liveperson_infra_messaging_ui_MessagingUiInitData_Lcom_liveperson_infra_messaging_ui_MessagingUiConfiguration_Handler ()
		{
			if (cb_init_Landroid_content_Context_Lcom_liveperson_infra_messaging_ui_MessagingUiInitData_Lcom_liveperson_infra_messaging_ui_MessagingUiConfiguration_ == null)
				cb_init_Landroid_content_Context_Lcom_liveperson_infra_messaging_ui_MessagingUiInitData_Lcom_liveperson_infra_messaging_ui_MessagingUiConfiguration_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Init_Landroid_content_Context_Lcom_liveperson_infra_messaging_ui_MessagingUiInitData_Lcom_liveperson_infra_messaging_ui_MessagingUiConfiguration_);
			return cb_init_Landroid_content_Context_Lcom_liveperson_infra_messaging_ui_MessagingUiInitData_Lcom_liveperson_infra_messaging_ui_MessagingUiConfiguration_;
		}

		static void n_Init_Landroid_content_Context_Lcom_liveperson_infra_messaging_ui_MessagingUiInitData_Lcom_liveperson_infra_messaging_ui_MessagingUiConfiguration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Infra.Messaging_ui.IMessagingUi __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.IMessagingUi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.MessagingUiInitData p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.MessagingUiInitData> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.MessagingUiConfiguration p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.MessagingUiConfiguration> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_init_Landroid_content_Context_Lcom_liveperson_infra_messaging_ui_MessagingUiInitData_Lcom_liveperson_infra_messaging_ui_MessagingUiConfiguration_;
		public unsafe void Init (global::Android.Content.Context p0, global::Com.Liveperson.Infra.Messaging_ui.MessagingUiInitData p1, global::Com.Liveperson.Infra.Messaging_ui.MessagingUiConfiguration p2)
		{
			if (id_init_Landroid_content_Context_Lcom_liveperson_infra_messaging_ui_MessagingUiInitData_Lcom_liveperson_infra_messaging_ui_MessagingUiConfiguration_ == IntPtr.Zero)
				id_init_Landroid_content_Context_Lcom_liveperson_infra_messaging_ui_MessagingUiInitData_Lcom_liveperson_infra_messaging_ui_MessagingUiConfiguration_ = JNIEnv.GetMethodID (class_ref, "init", "(Landroid/content/Context;Lcom/liveperson/infra/messaging_ui/MessagingUiInitData;Lcom/liveperson/infra/messaging_ui/MessagingUiConfiguration;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Landroid_content_Context_Lcom_liveperson_infra_messaging_ui_MessagingUiInitData_Lcom_liveperson_infra_messaging_ui_MessagingUiConfiguration_, __args);
		}

		static Delegate cb_logout_Landroid_content_Context_Lcom_liveperson_infra_messaging_ui_MessagingUiInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_;
#pragma warning disable 0169
		static Delegate GetLogout_Landroid_content_Context_Lcom_liveperson_infra_messaging_ui_MessagingUiInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_Handler ()
		{
			if (cb_logout_Landroid_content_Context_Lcom_liveperson_infra_messaging_ui_MessagingUiInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_ == null)
				cb_logout_Landroid_content_Context_Lcom_liveperson_infra_messaging_ui_MessagingUiInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Logout_Landroid_content_Context_Lcom_liveperson_infra_messaging_ui_MessagingUiInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_);
			return cb_logout_Landroid_content_Context_Lcom_liveperson_infra_messaging_ui_MessagingUiInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_;
		}

		static void n_Logout_Landroid_content_Context_Lcom_liveperson_infra_messaging_ui_MessagingUiInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Infra.Messaging_ui.IMessagingUi __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.IMessagingUi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.MessagingUiInitData p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.MessagingUiInitData> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBack p2 = (global::Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBack)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBack> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Logout (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_logout_Landroid_content_Context_Lcom_liveperson_infra_messaging_ui_MessagingUiInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_;
		public unsafe void Logout (global::Android.Content.Context p0, global::Com.Liveperson.Infra.Messaging_ui.MessagingUiInitData p1, global::Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBack p2)
		{
			if (id_logout_Landroid_content_Context_Lcom_liveperson_infra_messaging_ui_MessagingUiInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_ == IntPtr.Zero)
				id_logout_Landroid_content_Context_Lcom_liveperson_infra_messaging_ui_MessagingUiInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_ = JNIEnv.GetMethodID (class_ref, "logout", "(Landroid/content/Context;Lcom/liveperson/infra/messaging_ui/MessagingUiInitData;Lcom/liveperson/infra/callbacks/LogoutLivePersonCallBack;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_logout_Landroid_content_Context_Lcom_liveperson_infra_messaging_ui_MessagingUiInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_, __args);
		}

		static Delegate cb_onAgentAvatarTapped_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAgentAvatarTapped_Ljava_lang_String_Handler ()
		{
			if (cb_onAgentAvatarTapped_Ljava_lang_String_ == null)
				cb_onAgentAvatarTapped_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAgentAvatarTapped_Ljava_lang_String_);
			return cb_onAgentAvatarTapped_Ljava_lang_String_;
		}

		static void n_OnAgentAvatarTapped_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.IMessagingUi __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.IMessagingUi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAgentAvatarTapped (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAgentAvatarTapped_Ljava_lang_String_;
		public unsafe void OnAgentAvatarTapped (string p0)
		{
			if (id_onAgentAvatarTapped_Ljava_lang_String_ == IntPtr.Zero)
				id_onAgentAvatarTapped_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAgentAvatarTapped", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAgentAvatarTapped_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setConfiguration_Lcom_liveperson_infra_messaging_ui_MessagingUiConfiguration_;
#pragma warning disable 0169
		static Delegate GetSetConfiguration_Lcom_liveperson_infra_messaging_ui_MessagingUiConfiguration_Handler ()
		{
			if (cb_setConfiguration_Lcom_liveperson_infra_messaging_ui_MessagingUiConfiguration_ == null)
				cb_setConfiguration_Lcom_liveperson_infra_messaging_ui_MessagingUiConfiguration_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConfiguration_Lcom_liveperson_infra_messaging_ui_MessagingUiConfiguration_);
			return cb_setConfiguration_Lcom_liveperson_infra_messaging_ui_MessagingUiConfiguration_;
		}

		static void n_SetConfiguration_Lcom_liveperson_infra_messaging_ui_MessagingUiConfiguration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.IMessagingUi __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.IMessagingUi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.MessagingUiConfiguration p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.MessagingUiConfiguration> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetConfiguration (p0);
		}
#pragma warning restore 0169

		IntPtr id_setConfiguration_Lcom_liveperson_infra_messaging_ui_MessagingUiConfiguration_;
		public unsafe void SetConfiguration (global::Com.Liveperson.Infra.Messaging_ui.MessagingUiConfiguration p0)
		{
			if (id_setConfiguration_Lcom_liveperson_infra_messaging_ui_MessagingUiConfiguration_ == IntPtr.Zero)
				id_setConfiguration_Lcom_liveperson_infra_messaging_ui_MessagingUiConfiguration_ = JNIEnv.GetMethodID (class_ref, "setConfiguration", "(Lcom/liveperson/infra/messaging_ui/MessagingUiConfiguration;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConfiguration_Lcom_liveperson_infra_messaging_ui_MessagingUiConfiguration_, __args);
		}

		static Delegate cb_showConversation_Landroid_app_Activity_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_;
#pragma warning disable 0169
		static Delegate GetShowConversation_Landroid_app_Activity_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Handler ()
		{
			if (cb_showConversation_Landroid_app_Activity_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ == null)
				cb_showConversation_Landroid_app_Activity_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_ShowConversation_Landroid_app_Activity_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_);
			return cb_showConversation_Landroid_app_Activity_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_;
		}

		static bool n_ShowConversation_Landroid_app_Activity_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Liveperson.Infra.Messaging_ui.IMessagingUi __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.IMessagingUi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.LPAuthenticationParams p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ConversationViewParams p3 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ShowConversation (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_showConversation_Landroid_app_Activity_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_;
		public unsafe bool ShowConversation (global::Android.App.Activity p0, string p1, global::Com.Liveperson.Infra.LPAuthenticationParams p2, global::Com.Liveperson.Infra.ConversationViewParams p3)
		{
			if (id_showConversation_Landroid_app_Activity_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ == IntPtr.Zero)
				id_showConversation_Landroid_app_Activity_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ = JNIEnv.GetMethodID (class_ref, "showConversation", "(Landroid/app/Activity;Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ConversationViewParams;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_showConversation_Landroid_app_Activity_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
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
			global::Com.Liveperson.Infra.Messaging_ui.IMessagingUi __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.IMessagingUi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener p0 = (global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShutDown (p0);
		}
#pragma warning restore 0169

		IntPtr id_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_;
		public unsafe void ShutDown (global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener p0)
		{
			if (id_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ == IntPtr.Zero)
				id_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ = JNIEnv.GetMethodID (class_ref, "shutDown", "(Lcom/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_, __args);
		}

	}

}
