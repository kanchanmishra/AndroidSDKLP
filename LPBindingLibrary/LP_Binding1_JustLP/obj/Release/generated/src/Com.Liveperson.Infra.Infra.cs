using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']"
	[global::Android.Runtime.Register ("com/liveperson/infra/Infra", DoNotGenerateAcw=true)]
	public sealed partial class Infra : global::Java.Lang.Enum, global::Com.Liveperson.Infra.IClearable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/field[@name='CLEAR_HISTORY_SHOW_CONFIRM_DIALOG']"
		[Register ("CLEAR_HISTORY_SHOW_CONFIRM_DIALOG")]
		public const string ClearHistoryShowConfirmDialog = (string) "clear_history_show_confirm_dialog";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/field[@name='CONTEXTUAL_MENU_ON_TOOLBAR']"
		[Register ("CONTEXTUAL_MENU_ON_TOOLBAR")]
		public const string ContextualMenuOnToolbar = (string) "contextual_menu_on_toolbar";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/field[@name='DISABLE_TTR_POPUP']"
		[Register ("DISABLE_TTR_POPUP")]
		public const string DisableTtrPopup = (string) "disableTTRPopup";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/field[@name='FEATURES_CONFIGURATION']"
		[Register ("FEATURES_CONFIGURATION")]
		public const string FeaturesConfiguration = (string) "features_configuration";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/field[@name='KEY_AUTH_KEY']"
		[Register ("KEY_AUTH_KEY")]
		public const string KeyAuthKey = (string) "auth_key";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/field[@name='KEY_BRAND_ID']"
		[Register ("KEY_BRAND_ID")]
		public const string KeyBrandId = (string) "brand_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/field[@name='KEY_READ_ONLY']"
		[Register ("KEY_READ_ONLY")]
		public const string KeyReadOnly = (string) "read_only";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/field[@name='KEY_TARGET_ID']"
		[Register ("KEY_TARGET_ID")]
		public const string KeyTargetId = (string) "target_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/field[@name='KEY_VIEW_PARAMS']"
		[Register ("KEY_VIEW_PARAMS")]
		public const string KeyViewParams = (string) "view_params";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/field[@name='SDK_VERSION']"
		[Register ("SDK_VERSION")]
		public const string SdkVersion = (string) "SDK_VERSION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/field[@name='SHOULD_USE_CONFIGURATION']"
		[Register ("SHOULD_USE_CONFIGURATION")]
		public const string ShouldUseConfiguration = (string) "should_use_configuration";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/field[@name='SHOW_AGENT_DETAILS_CSAT']"
		[Register ("SHOW_AGENT_DETAILS_CSAT")]
		public const string ShowAgentDetailsCsat = (string) "show_agent_details_csat";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/field[@name='SHOW_CSAT_THANK_YOU']"
		[Register ("SHOW_CSAT_THANK_YOU")]
		public const string ShowCsatThankYou = (string) "show_csat_thank_you";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/field[@name='SHOW_FEEDBACK']"
		[Register ("SHOW_FEEDBACK")]
		public const string ShowFeedback = (string) "show_feedback";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/field[@name='SHOW_TIMESTAMP_IN_TTR_NOTIFICATION']"
		[Register ("SHOW_TIMESTAMP_IN_TTR_NOTIFICATION")]
		public const string ShowTimestampInTtrNotification = (string) "show_timestamp_in_ttr_notification";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/field[@name='SHOW_YES_NO_QUESTION']"
		[Register ("SHOW_YES_NO_QUESTION")]
		public const string ShowYesNoQuestion = (string) "show_yes_no_question";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/field[@name='TTR_MESSAGE_OFF_HOURS_ENABLED']"
		[Register ("TTR_MESSAGE_OFF_HOURS_ENABLED")]
		public const string TtrMessageOffHoursEnabled = (string) "ttr_message_off_hours_enabled";

		static IntPtr instance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/field[@name='instance']"
		[Register ("instance")]
		public static global::Com.Liveperson.Infra.Infra Instance {
			get {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/liveperson/infra/Infra;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, instance_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Infra> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra.InfraInitProcess']"
		[global::Android.Runtime.Register ("com/liveperson/infra/Infra$InfraInitProcess", DoNotGenerateAcw=true)]
		public partial class InfraInitProcess : global::Com.Liveperson.Infra.Statemachine.InitProcess {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/Infra$InfraInitProcess", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InfraInitProcess); }
			}

			protected InfraInitProcess (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_infra_Infra_Landroid_content_Context_Lcom_liveperson_infra_sdkstatemachine_init_InfraInitData_Lcom_liveperson_infra_statemachine_InitProcess_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra.InfraInitProcess']/constructor[@name='Infra.InfraInitProcess' and count(parameter)=4 and parameter[1][@type='com.liveperson.infra.Infra'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.liveperson.infra.sdkstatemachine.init.InfraInitData'] and parameter[4][@type='com.liveperson.infra.statemachine.InitProcess']]"
			[Register (".ctor", "(Lcom/liveperson/infra/Infra;Landroid/content/Context;Lcom/liveperson/infra/sdkstatemachine/init/InfraInitData;Lcom/liveperson/infra/statemachine/InitProcess;)V", "")]
			public unsafe InfraInitProcess (global::Com.Liveperson.Infra.Infra __self, global::Android.Content.Context p1, global::Com.Liveperson.Infra.Sdkstatemachine.Init.InfraInitData p2, global::Com.Liveperson.Infra.Statemachine.InitProcess p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					if (((object) this).GetType () != typeof (InfraInitProcess)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;Lcom/liveperson/infra/sdkstatemachine/init/InfraInitData;Lcom/liveperson/infra/statemachine/InitProcess;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;Lcom/liveperson/infra/sdkstatemachine/init/InfraInitData;Lcom/liveperson/infra/statemachine/InitProcess;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_infra_Infra_Landroid_content_Context_Lcom_liveperson_infra_sdkstatemachine_init_InfraInitData_Lcom_liveperson_infra_statemachine_InitProcess_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_infra_Infra_Landroid_content_Context_Lcom_liveperson_infra_sdkstatemachine_init_InfraInitData_Lcom_liveperson_infra_statemachine_InitProcess_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/Infra;Landroid/content/Context;Lcom/liveperson/infra/sdkstatemachine/init/InfraInitData;Lcom/liveperson/infra/statemachine/InitProcess;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_Infra_Landroid_content_Context_Lcom_liveperson_infra_sdkstatemachine_init_InfraInitData_Lcom_liveperson_infra_statemachine_InitProcess_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_Infra_Landroid_content_Context_Lcom_liveperson_infra_sdkstatemachine_init_InfraInitData_Lcom_liveperson_infra_statemachine_InitProcess_, __args);
				} finally {
				}
			}

			static Delegate cb_init;
#pragma warning disable 0169
			static Delegate GetInitHandler ()
			{
				if (cb_init == null)
					cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
				return cb_init;
			}

			static void n_Init (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.Infra.InfraInitProcess __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Infra.InfraInitProcess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Init ();
			}
#pragma warning restore 0169

			static IntPtr id_init;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra.InfraInitProcess']/method[@name='init' and count(parameter)=0]"
			[Register ("init", "()V", "GetInitHandler")]
			public override unsafe void Init ()
			{
				if (id_init == IntPtr.Zero)
					id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "()V"));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra.InfraLogoutProcess']"
		[global::Android.Runtime.Register ("com/liveperson/infra/Infra$InfraLogoutProcess", DoNotGenerateAcw=true)]
		public partial class InfraLogoutProcess : global::Com.Liveperson.Infra.Statemachine.LogoutProcess {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/Infra$InfraLogoutProcess", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InfraLogoutProcess); }
			}

			protected InfraLogoutProcess (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_infra_Infra_Landroid_content_Context_Lcom_liveperson_infra_sdkstatemachine_init_InfraInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra.InfraLogoutProcess']/constructor[@name='Infra.InfraLogoutProcess' and count(parameter)=4 and parameter[1][@type='com.liveperson.infra.Infra'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.liveperson.infra.sdkstatemachine.init.InfraInitData'] and parameter[4][@type='com.liveperson.infra.statemachine.LogoutProcess']]"
			[Register (".ctor", "(Lcom/liveperson/infra/Infra;Landroid/content/Context;Lcom/liveperson/infra/sdkstatemachine/init/InfraInitData;Lcom/liveperson/infra/statemachine/LogoutProcess;)V", "")]
			public unsafe InfraLogoutProcess (global::Com.Liveperson.Infra.Infra __self, global::Android.Content.Context p1, global::Com.Liveperson.Infra.Sdkstatemachine.Init.InfraInitData p2, global::Com.Liveperson.Infra.Statemachine.LogoutProcess p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					if (((object) this).GetType () != typeof (InfraLogoutProcess)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;Lcom/liveperson/infra/sdkstatemachine/init/InfraInitData;Lcom/liveperson/infra/statemachine/LogoutProcess;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;Lcom/liveperson/infra/sdkstatemachine/init/InfraInitData;Lcom/liveperson/infra/statemachine/LogoutProcess;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_infra_Infra_Landroid_content_Context_Lcom_liveperson_infra_sdkstatemachine_init_InfraInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_infra_Infra_Landroid_content_Context_Lcom_liveperson_infra_sdkstatemachine_init_InfraInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/Infra;Landroid/content/Context;Lcom/liveperson/infra/sdkstatemachine/init/InfraInitData;Lcom/liveperson/infra/statemachine/LogoutProcess;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_Infra_Landroid_content_Context_Lcom_liveperson_infra_sdkstatemachine_init_InfraInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_Infra_Landroid_content_Context_Lcom_liveperson_infra_sdkstatemachine_init_InfraInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_, __args);
				} finally {
				}
			}

			static Delegate cb_getLogoutCallback;
#pragma warning disable 0169
			static Delegate GetGetLogoutCallbackHandler ()
			{
				if (cb_getLogoutCallback == null)
					cb_getLogoutCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLogoutCallback);
				return cb_getLogoutCallback;
			}

			static IntPtr n_GetLogoutCallback (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.Infra.InfraLogoutProcess __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Infra.InfraLogoutProcess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.LogoutCallback);
			}
#pragma warning restore 0169

			static IntPtr id_getLogoutCallback;
			public override unsafe global::Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBack LogoutCallback {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra.InfraLogoutProcess']/method[@name='getLogoutCallback' and count(parameter)=0]"
				[Register ("getLogoutCallback", "()Lcom/liveperson/infra/callbacks/LogoutLivePersonCallBack;", "GetGetLogoutCallbackHandler")]
				get {
					if (id_getLogoutCallback == IntPtr.Zero)
						id_getLogoutCallback = JNIEnv.GetMethodID (class_ref, "getLogoutCallback", "()Lcom/liveperson/infra/callbacks/LogoutLivePersonCallBack;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBack> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLogoutCallback), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBack> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLogoutCallback", "()Lcom/liveperson/infra/callbacks/LogoutLivePersonCallBack;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_initForLogout;
#pragma warning disable 0169
			static Delegate GetInitForLogoutHandler ()
			{
				if (cb_initForLogout == null)
					cb_initForLogout = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitForLogout);
				return cb_initForLogout;
			}

			static void n_InitForLogout (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.Infra.InfraLogoutProcess __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Infra.InfraLogoutProcess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.InitForLogout ();
			}
#pragma warning restore 0169

			static IntPtr id_initForLogout;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra.InfraLogoutProcess']/method[@name='initForLogout' and count(parameter)=0]"
			[Register ("initForLogout", "()V", "GetInitForLogoutHandler")]
			public override unsafe void InitForLogout ()
			{
				if (id_initForLogout == IntPtr.Zero)
					id_initForLogout = JNIEnv.GetMethodID (class_ref, "initForLogout", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initForLogout);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initForLogout", "()V"));
				} finally {
				}
			}

			static Delegate cb_logout;
#pragma warning disable 0169
			static Delegate GetLogoutHandler ()
			{
				if (cb_logout == null)
					cb_logout = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Logout);
				return cb_logout;
			}

			static void n_Logout (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.Infra.InfraLogoutProcess __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Infra.InfraLogoutProcess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Logout ();
			}
#pragma warning restore 0169

			static IntPtr id_logout;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra.InfraLogoutProcess']/method[@name='logout' and count(parameter)=0]"
			[Register ("logout", "()V", "GetLogoutHandler")]
			public override unsafe void Logout ()
			{
				if (id_logout == IntPtr.Zero)
					id_logout = JNIEnv.GetMethodID (class_ref, "logout", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_logout);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logout", "()V"));
				} finally {
				}
			}

			static Delegate cb_preLogout_Lcom_liveperson_infra_sdkstatemachine_logout_PreLogoutCompletionListener_;
#pragma warning disable 0169
			static Delegate GetPreLogout_Lcom_liveperson_infra_sdkstatemachine_logout_PreLogoutCompletionListener_Handler ()
			{
				if (cb_preLogout_Lcom_liveperson_infra_sdkstatemachine_logout_PreLogoutCompletionListener_ == null)
					cb_preLogout_Lcom_liveperson_infra_sdkstatemachine_logout_PreLogoutCompletionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PreLogout_Lcom_liveperson_infra_sdkstatemachine_logout_PreLogoutCompletionListener_);
				return cb_preLogout_Lcom_liveperson_infra_sdkstatemachine_logout_PreLogoutCompletionListener_;
			}

			static void n_PreLogout_Lcom_liveperson_infra_sdkstatemachine_logout_PreLogoutCompletionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Infra.Infra.InfraLogoutProcess __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Infra.InfraLogoutProcess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Liveperson.Infra.Sdkstatemachine.Logout.IPreLogoutCompletionListener p0 = (global::Com.Liveperson.Infra.Sdkstatemachine.Logout.IPreLogoutCompletionListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Logout.IPreLogoutCompletionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.PreLogout (p0);
			}
#pragma warning restore 0169

			static IntPtr id_preLogout_Lcom_liveperson_infra_sdkstatemachine_logout_PreLogoutCompletionListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra.InfraLogoutProcess']/method[@name='preLogout' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.logout.PreLogoutCompletionListener']]"
			[Register ("preLogout", "(Lcom/liveperson/infra/sdkstatemachine/logout/PreLogoutCompletionListener;)V", "GetPreLogout_Lcom_liveperson_infra_sdkstatemachine_logout_PreLogoutCompletionListener_Handler")]
			public override unsafe void PreLogout (global::Com.Liveperson.Infra.Sdkstatemachine.Logout.IPreLogoutCompletionListener p0)
			{
				if (id_preLogout_Lcom_liveperson_infra_sdkstatemachine_logout_PreLogoutCompletionListener_ == IntPtr.Zero)
					id_preLogout_Lcom_liveperson_infra_sdkstatemachine_logout_PreLogoutCompletionListener_ = JNIEnv.GetMethodID (class_ref, "preLogout", "(Lcom/liveperson/infra/sdkstatemachine/logout/PreLogoutCompletionListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_preLogout_Lcom_liveperson_infra_sdkstatemachine_logout_PreLogoutCompletionListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "preLogout", "(Lcom/liveperson/infra/sdkstatemachine/logout/PreLogoutCompletionListener;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_shutDownForLogout_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_;
#pragma warning disable 0169
			static Delegate GetShutDownForLogout_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_Handler ()
			{
				if (cb_shutDownForLogout_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ == null)
					cb_shutDownForLogout_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShutDownForLogout_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_);
				return cb_shutDownForLogout_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_;
			}

			static void n_ShutDownForLogout_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Infra.Infra.InfraLogoutProcess __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Infra.InfraLogoutProcess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener p0 = (global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ShutDownForLogout (p0);
			}
#pragma warning restore 0169

			static IntPtr id_shutDownForLogout_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra.InfraLogoutProcess']/method[@name='shutDownForLogout' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.shutdown.ShutDownCompletionListener']]"
			[Register ("shutDownForLogout", "(Lcom/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener;)V", "GetShutDownForLogout_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_Handler")]
			public override unsafe void ShutDownForLogout (global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener p0)
			{
				if (id_shutDownForLogout_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ == IntPtr.Zero)
					id_shutDownForLogout_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ = JNIEnv.GetMethodID (class_ref, "shutDownForLogout", "(Lcom/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutDownForLogout_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shutDownForLogout", "(Lcom/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra.InfraShutDownProcess']"
		[global::Android.Runtime.Register ("com/liveperson/infra/Infra$InfraShutDownProcess", DoNotGenerateAcw=true)]
		public partial class InfraShutDownProcess : global::Com.Liveperson.Infra.Statemachine.ShutDownProcess {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/Infra$InfraShutDownProcess", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InfraShutDownProcess); }
			}

			protected InfraShutDownProcess (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_infra_Infra_Lcom_liveperson_infra_statemachine_ShutDownProcess_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra.InfraShutDownProcess']/constructor[@name='Infra.InfraShutDownProcess' and count(parameter)=2 and parameter[1][@type='com.liveperson.infra.Infra'] and parameter[2][@type='com.liveperson.infra.statemachine.ShutDownProcess']]"
			[Register (".ctor", "(Lcom/liveperson/infra/Infra;Lcom/liveperson/infra/statemachine/ShutDownProcess;)V", "")]
			public unsafe InfraShutDownProcess (global::Com.Liveperson.Infra.Infra __self, global::Com.Liveperson.Infra.Statemachine.ShutDownProcess p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (((object) this).GetType () != typeof (InfraShutDownProcess)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/liveperson/infra/statemachine/ShutDownProcess;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/liveperson/infra/statemachine/ShutDownProcess;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_infra_Infra_Lcom_liveperson_infra_statemachine_ShutDownProcess_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_infra_Infra_Lcom_liveperson_infra_statemachine_ShutDownProcess_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/Infra;Lcom/liveperson/infra/statemachine/ShutDownProcess;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_Infra_Lcom_liveperson_infra_statemachine_ShutDownProcess_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_Infra_Lcom_liveperson_infra_statemachine_ShutDownProcess_, __args);
				} finally {
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
				global::Com.Liveperson.Infra.Infra.InfraShutDownProcess __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Infra.InfraShutDownProcess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener p0 = (global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.ShutDown (p0);
			}
#pragma warning restore 0169

			static IntPtr id_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra.InfraShutDownProcess']/method[@name='shutDown' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.shutdown.ShutDownCompletionListener']]"
			[Register ("shutDown", "(Lcom/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener;)V", "GetShutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_Handler")]
			public override unsafe void ShutDown (global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener p0)
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

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/Infra", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Infra); }
		}

		internal Infra (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getApplicationContext;
		public unsafe global::Android.Content.Context ApplicationContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/method[@name='getApplicationContext' and count(parameter)=0]"
			[Register ("getApplicationContext", "()Landroid/content/Context;", "GetGetApplicationContextHandler")]
			get {
				if (id_getApplicationContext == IntPtr.Zero)
					id_getApplicationContext = JNIEnv.GetMethodID (class_ref, "getApplicationContext", "()Landroid/content/Context;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApplicationContext), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getApplicationHandler;
		public unsafe global::Android.OS.Handler ApplicationHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/method[@name='getApplicationHandler' and count(parameter)=0]"
			[Register ("getApplicationHandler", "()Landroid/os/Handler;", "GetGetApplicationHandlerHandler")]
			get {
				if (id_getApplicationHandler == IntPtr.Zero)
					id_getApplicationHandler = JNIEnv.GetMethodID (class_ref, "getApplicationHandler", "()Landroid/os/Handler;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApplicationHandler), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDbEncryptionKeyHelper;
		public unsafe global::Com.Liveperson.Infra.Controller.DBEncryptionKeyHelper DbEncryptionKeyHelper {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/method[@name='getDbEncryptionKeyHelper' and count(parameter)=0]"
			[Register ("getDbEncryptionKeyHelper", "()Lcom/liveperson/infra/controller/DBEncryptionKeyHelper;", "GetGetDbEncryptionKeyHelperHandler")]
			get {
				if (id_getDbEncryptionKeyHelper == IntPtr.Zero)
					id_getDbEncryptionKeyHelper = JNIEnv.GetMethodID (class_ref, "getDbEncryptionKeyHelper", "()Lcom/liveperson/infra/controller/DBEncryptionKeyHelper;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Controller.DBEncryptionKeyHelper> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDbEncryptionKeyHelper), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getFileProviderAuthorityPrefix;
		public static unsafe string FileProviderAuthorityPrefix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/method[@name='getFileProviderAuthorityPrefix' and count(parameter)=0]"
			[Register ("getFileProviderAuthorityPrefix", "()Ljava/lang/String;", "GetGetFileProviderAuthorityPrefixHandler")]
			get {
				if (id_getFileProviderAuthorityPrefix == IntPtr.Zero)
					id_getFileProviderAuthorityPrefix = JNIEnv.GetStaticMethodID (class_ref, "getFileProviderAuthorityPrefix", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFileProviderAuthorityPrefix), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getHostVersion;
		public unsafe string HostVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/method[@name='getHostVersion' and count(parameter)=0]"
			[Register ("getHostVersion", "()Ljava/lang/String;", "GetGetHostVersionHandler")]
			get {
				if (id_getHostVersion == IntPtr.Zero)
					id_getHostVersion = JNIEnv.GetMethodID (class_ref, "getHostVersion", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHostVersion), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isInitialized;
		public unsafe bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "GetIsInitializedHandler")]
			get {
				if (id_isInitialized == IntPtr.Zero)
					id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInitialized);
				} finally {
				}
			}
		}

		static IntPtr id_getLoggos;
		public unsafe global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Loggos Loggos {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/method[@name='getLoggos' and count(parameter)=0]"
			[Register ("getLoggos", "()Lcom/liveperson/infra/log/logreporter/loggos/Loggos;", "GetGetLoggosHandler")]
			get {
				if (id_getLoggos == IntPtr.Zero)
					id_getLoggos = JNIEnv.GetMethodID (class_ref, "getLoggos", "()Lcom/liveperson/infra/log/logreporter/loggos/Loggos;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Loggos> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLoggos), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getLptagEnvironment;
		public unsafe global::Com.Liveperson.Infra.Configuration.LptagEnvironment LptagEnvironment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/method[@name='getLptagEnvironment' and count(parameter)=0]"
			[Register ("getLptagEnvironment", "()Lcom/liveperson/infra/configuration/LptagEnvironment;", "GetGetLptagEnvironmentHandler")]
			get {
				if (id_getLptagEnvironment == IntPtr.Zero)
					id_getLptagEnvironment = JNIEnv.GetMethodID (class_ref, "getLptagEnvironment", "()Lcom/liveperson/infra/configuration/LptagEnvironment;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Configuration.LptagEnvironment> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLptagEnvironment), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
			} finally {
			}
		}

		static IntPtr id_init_Landroid_content_Context_Lcom_liveperson_infra_sdkstatemachine_init_InfraInitData_Lcom_liveperson_infra_statemachine_InitProcess_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/method[@name='init' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.liveperson.infra.sdkstatemachine.init.InfraInitData'] and parameter[3][@type='com.liveperson.infra.statemachine.InitProcess']]"
		[Register ("init", "(Landroid/content/Context;Lcom/liveperson/infra/sdkstatemachine/init/InfraInitData;Lcom/liveperson/infra/statemachine/InitProcess;)V", "")]
		public unsafe void Init (global::Android.Content.Context p0, global::Com.Liveperson.Infra.Sdkstatemachine.Init.InfraInitData p1, global::Com.Liveperson.Infra.Statemachine.InitProcess p2)
		{
			if (id_init_Landroid_content_Context_Lcom_liveperson_infra_sdkstatemachine_init_InfraInitData_Lcom_liveperson_infra_statemachine_InitProcess_ == IntPtr.Zero)
				id_init_Landroid_content_Context_Lcom_liveperson_infra_sdkstatemachine_init_InfraInitData_Lcom_liveperson_infra_statemachine_InitProcess_ = JNIEnv.GetMethodID (class_ref, "init", "(Landroid/content/Context;Lcom/liveperson/infra/sdkstatemachine/init/InfraInitData;Lcom/liveperson/infra/statemachine/InitProcess;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Landroid_content_Context_Lcom_liveperson_infra_sdkstatemachine_init_InfraInitData_Lcom_liveperson_infra_statemachine_InitProcess_, __args);
			} finally {
			}
		}

		static IntPtr id_logout_Landroid_content_Context_Lcom_liveperson_infra_sdkstatemachine_init_InfraInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/method[@name='logout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.liveperson.infra.sdkstatemachine.init.InfraInitData'] and parameter[3][@type='com.liveperson.infra.statemachine.LogoutProcess']]"
		[Register ("logout", "(Landroid/content/Context;Lcom/liveperson/infra/sdkstatemachine/init/InfraInitData;Lcom/liveperson/infra/statemachine/LogoutProcess;)V", "")]
		public unsafe void Logout (global::Android.Content.Context p0, global::Com.Liveperson.Infra.Sdkstatemachine.Init.InfraInitData p1, global::Com.Liveperson.Infra.Statemachine.LogoutProcess p2)
		{
			if (id_logout_Landroid_content_Context_Lcom_liveperson_infra_sdkstatemachine_init_InfraInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_ == IntPtr.Zero)
				id_logout_Landroid_content_Context_Lcom_liveperson_infra_sdkstatemachine_init_InfraInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_ = JNIEnv.GetMethodID (class_ref, "logout", "(Landroid/content/Context;Lcom/liveperson/infra/sdkstatemachine/init/InfraInitData;Lcom/liveperson/infra/statemachine/LogoutProcess;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_logout_Landroid_content_Context_Lcom_liveperson_infra_sdkstatemachine_init_InfraInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_, __args);
			} finally {
			}
		}

		static IntPtr id_postOnMainThread_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/method[@name='postOnMainThread' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("postOnMainThread", "(Ljava/lang/Runnable;)V", "")]
		public unsafe void PostOnMainThread (global::Java.Lang.IRunnable p0)
		{
			if (id_postOnMainThread_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_postOnMainThread_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "postOnMainThread", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_postOnMainThread_Ljava_lang_Runnable_, __args);
			} finally {
			}
		}

		static IntPtr id_registerToNetworkChanges;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/method[@name='registerToNetworkChanges' and count(parameter)=0]"
		[Register ("registerToNetworkChanges", "()V", "")]
		public unsafe void RegisterToNetworkChanges ()
		{
			if (id_registerToNetworkChanges == IntPtr.Zero)
				id_registerToNetworkChanges = JNIEnv.GetMethodID (class_ref, "registerToNetworkChanges", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerToNetworkChanges);
			} finally {
			}
		}

		static IntPtr id_restart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/method[@name='restart' and count(parameter)=0]"
		[Register ("restart", "()V", "")]
		public unsafe void Restart ()
		{
			if (id_restart == IntPtr.Zero)
				id_restart = JNIEnv.GetMethodID (class_ref, "restart", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_restart);
			} finally {
			}
		}

		static IntPtr id_setContext_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("setContext", "(Landroid/content/Context;)V", "")]
		public unsafe void SetContext (global::Android.Content.Context p0)
		{
			if (id_setContext_Landroid_content_Context_ == IntPtr.Zero)
				id_setContext_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "setContext", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContext_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/method[@name='shutDown' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.ShutDownProcess']]"
		[Register ("shutDown", "(Lcom/liveperson/infra/statemachine/ShutDownProcess;)V", "")]
		public unsafe void ShutDown (global::Com.Liveperson.Infra.Statemachine.ShutDownProcess p0)
		{
			if (id_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_ == IntPtr.Zero)
				id_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_ = JNIEnv.GetMethodID (class_ref, "shutDown", "(Lcom/liveperson/infra/statemachine/ShutDownProcess;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_, __args);
			} finally {
			}
		}

		static IntPtr id_unregisterToNetworkChanges;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/method[@name='unregisterToNetworkChanges' and count(parameter)=0]"
		[Register ("unregisterToNetworkChanges", "()V", "")]
		public unsafe void UnregisterToNetworkChanges ()
		{
			if (id_unregisterToNetworkChanges == IntPtr.Zero)
				id_unregisterToNetworkChanges = JNIEnv.GetMethodID (class_ref, "unregisterToNetworkChanges", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterToNetworkChanges);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/Infra;", "")]
		public static unsafe global::Com.Liveperson.Infra.Infra ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/Infra;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Infra.Infra __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Infra> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='Infra']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/liveperson/infra/Infra;", "")]
		public static unsafe global::Com.Liveperson.Infra.Infra[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/infra/Infra;");
			try {
				return (global::Com.Liveperson.Infra.Infra[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Infra.Infra));
			} finally {
			}
		}

	}
}
