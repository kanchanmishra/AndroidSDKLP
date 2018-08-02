using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Sdk.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/sdk/api/LivePerson", DoNotGenerateAcw=true)]
	public partial class LivePerson : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/field[@name='ACTION_LP_UPDATE_NUM_UNREAD_MESSAGES_ACTION']"
		[Register ("ACTION_LP_UPDATE_NUM_UNREAD_MESSAGES_ACTION")]
		public const string ActionLpUpdateNumUnreadMessagesAction = (string) "ACTION_LP_UPDATE_NUM_UNREAD_MESSAGES_ACTION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/field[@name='ACTION_LP_UPDATE_NUM_UNREAD_MESSAGES_EXTRA']"
		[Register ("ACTION_LP_UPDATE_NUM_UNREAD_MESSAGES_EXTRA")]
		public const string ActionLpUpdateNumUnreadMessagesExtra = (string) "ACTION_LP_UPDATE_NUM_UNREAD_MESSAGES_EXTRA";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/sdk/api/LivePerson", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LivePerson); }
		}

		protected LivePerson (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getConversationFragment;
		[Obsolete (@"deprecated")]
		public static unsafe global::Android.Support.V4.App.Fragment ConversationFragment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='getConversationFragment' and count(parameter)=0]"
			[Register ("getConversationFragment", "()Landroid/support/v4/app/Fragment;", "GetGetConversationFragmentHandler")]
			get {
				if (id_getConversationFragment == IntPtr.Zero)
					id_getConversationFragment = JNIEnv.GetStaticMethodID (class_ref, "getConversationFragment", "()Landroid/support/v4/app/Fragment;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.Fragment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getConversationFragment), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSDKVersion;
		public static unsafe string SDKVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='getSDKVersion' and count(parameter)=0]"
			[Register ("getSDKVersion", "()Ljava/lang/String;", "GetGetSDKVersionHandler")]
			get {
				if (id_getSDKVersion == IntPtr.Zero)
					id_getSDKVersion = JNIEnv.GetStaticMethodID (class_ref, "getSDKVersion", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSDKVersion), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_checkActiveConversation_Lcom_liveperson_infra_ICallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='checkActiveConversation' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.ICallback&lt;java.lang.Boolean, java.lang.Exception&gt;']]"
		[Register ("checkActiveConversation", "(Lcom/liveperson/infra/ICallback;)V", "")]
		public static unsafe void CheckActiveConversation (global::Com.Liveperson.Infra.ICallback p0)
		{
			if (id_checkActiveConversation_Lcom_liveperson_infra_ICallback_ == IntPtr.Zero)
				id_checkActiveConversation_Lcom_liveperson_infra_ICallback_ = JNIEnv.GetStaticMethodID (class_ref, "checkActiveConversation", "(Lcom/liveperson/infra/ICallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkActiveConversation_Lcom_liveperson_infra_ICallback_, __args);
			} finally {
			}
		}

		static IntPtr id_checkAgentID_Lcom_liveperson_infra_ICallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='checkAgentID' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.ICallback&lt;com.liveperson.messaging.model.AgentData, java.lang.Exception&gt;']]"
		[Register ("checkAgentID", "(Lcom/liveperson/infra/ICallback;)V", "")]
		public static unsafe void CheckAgentID (global::Com.Liveperson.Infra.ICallback p0)
		{
			if (id_checkAgentID_Lcom_liveperson_infra_ICallback_ == IntPtr.Zero)
				id_checkAgentID_Lcom_liveperson_infra_ICallback_ = JNIEnv.GetStaticMethodID (class_ref, "checkAgentID", "(Lcom/liveperson/infra/ICallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkAgentID_Lcom_liveperson_infra_ICallback_, __args);
			} finally {
			}
		}

		static IntPtr id_checkConversationIsMarkedAsUrgent_Lcom_liveperson_infra_ICallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='checkConversationIsMarkedAsUrgent' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.ICallback&lt;java.lang.Boolean, java.lang.Exception&gt;']]"
		[Register ("checkConversationIsMarkedAsUrgent", "(Lcom/liveperson/infra/ICallback;)V", "")]
		public static unsafe void CheckConversationIsMarkedAsUrgent (global::Com.Liveperson.Infra.ICallback p0)
		{
			if (id_checkConversationIsMarkedAsUrgent_Lcom_liveperson_infra_ICallback_ == IntPtr.Zero)
				id_checkConversationIsMarkedAsUrgent_Lcom_liveperson_infra_ICallback_ = JNIEnv.GetStaticMethodID (class_ref, "checkConversationIsMarkedAsUrgent", "(Lcom/liveperson/infra/ICallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkConversationIsMarkedAsUrgent_Lcom_liveperson_infra_ICallback_, __args);
			} finally {
			}
		}

		static IntPtr id_clearHistory;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='clearHistory' and count(parameter)=0]"
		[Register ("clearHistory", "()Z", "")]
		public static unsafe bool ClearHistory ()
		{
			if (id_clearHistory == IntPtr.Zero)
				id_clearHistory = JNIEnv.GetStaticMethodID (class_ref, "clearHistory", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_clearHistory);
			} finally {
			}
		}

		static IntPtr id_getConversationFragment_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='getConversationFragment' and count(parameter)=2 and parameter[1][@type='com.liveperson.infra.LPAuthenticationParams'] and parameter[2][@type='com.liveperson.infra.ConversationViewParams']]"
		[Register ("getConversationFragment", "(Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ConversationViewParams;)Landroid/support/v4/app/Fragment;", "")]
		public static unsafe global::Android.Support.V4.App.Fragment GetConversationFragment (global::Com.Liveperson.Infra.LPAuthenticationParams p0, global::Com.Liveperson.Infra.ConversationViewParams p1)
		{
			if (id_getConversationFragment_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ == IntPtr.Zero)
				id_getConversationFragment_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ = JNIEnv.GetStaticMethodID (class_ref, "getConversationFragment", "(Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ConversationViewParams;)Landroid/support/v4/app/Fragment;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Support.V4.App.Fragment __ret = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.Fragment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getConversationFragment_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getConversationFragment_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='getConversationFragment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("getConversationFragment", "(Ljava/lang/String;)Landroid/support/v4/app/Fragment;", "")]
		public static unsafe global::Android.Support.V4.App.Fragment GetConversationFragment (string p0)
		{
			if (id_getConversationFragment_Ljava_lang_String_ == IntPtr.Zero)
				id_getConversationFragment_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getConversationFragment", "(Ljava/lang/String;)Landroid/support/v4/app/Fragment;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Android.Support.V4.App.Fragment __ret = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.Fragment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getConversationFragment_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getNumUnreadMessages_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='getNumUnreadMessages' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getNumUnreadMessages", "(Ljava/lang/String;)I", "")]
		public static unsafe int GetNumUnreadMessages (string p0)
		{
			if (id_getNumUnreadMessages_Ljava_lang_String_ == IntPtr.Zero)
				id_getNumUnreadMessages_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getNumUnreadMessages", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getNumUnreadMessages_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getNumUnreadMessages_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='getNumUnreadMessages' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.ICallback&lt;java.lang.Integer, java.lang.Exception&gt;']]"
		[Register ("getNumUnreadMessages", "(Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V", "")]
		public static unsafe void GetNumUnreadMessages (string p0, global::Com.Liveperson.Infra.ICallback p1)
		{
			if (id_getNumUnreadMessages_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ == IntPtr.Zero)
				id_getNumUnreadMessages_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ = JNIEnv.GetStaticMethodID (class_ref, "getNumUnreadMessages", "(Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getNumUnreadMessages_Ljava_lang_String_Lcom_liveperson_infra_ICallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_handlePush_Landroid_content_Context_Landroid_os_Bundle_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='handlePush' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("handlePush", "(Landroid/content/Context;Landroid/os/Bundle;Ljava/lang/String;Z)V", "")]
		public static unsafe void HandlePush (global::Android.Content.Context p0, global::Android.OS.Bundle p1, string p2, bool p3)
		{
			if (id_handlePush_Landroid_content_Context_Landroid_os_Bundle_Ljava_lang_String_Z == IntPtr.Zero)
				id_handlePush_Landroid_content_Context_Landroid_os_Bundle_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "handlePush", "(Landroid/content/Context;Landroid/os/Bundle;Ljava/lang/String;Z)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_handlePush_Landroid_content_Context_Landroid_os_Bundle_Ljava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_handlePushMessage_Landroid_content_Context_Ljava_util_Map_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='handlePushMessage' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("handlePushMessage", "(Landroid/content/Context;Ljava/util/Map;Ljava/lang/String;Z)Lcom/liveperson/infra/model/PushMessage;", "")]
		public static unsafe global::Com.Liveperson.Infra.Model.PushMessage HandlePushMessage (global::Android.Content.Context p0, global::System.Collections.Generic.IDictionary<string, string> p1, string p2, bool p3)
		{
			if (id_handlePushMessage_Landroid_content_Context_Ljava_util_Map_Ljava_lang_String_Z == IntPtr.Zero)
				id_handlePushMessage_Landroid_content_Context_Ljava_util_Map_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "handlePushMessage", "(Landroid/content/Context;Ljava/util/Map;Ljava/lang/String;Z)Lcom/liveperson/infra/model/PushMessage;");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				global::Com.Liveperson.Infra.Model.PushMessage __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.PushMessage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_handlePushMessage_Landroid_content_Context_Ljava_util_Map_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_hideConversation_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='hideConversation' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("hideConversation", "(Landroid/app/Activity;)V", "")]
		public static unsafe void HideConversation (global::Android.App.Activity p0)
		{
			if (id_hideConversation_Landroid_app_Activity_ == IntPtr.Zero)
				id_hideConversation_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "hideConversation", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_hideConversation_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_initialize_Landroid_content_Context_Lcom_liveperson_infra_InitLivePersonProperties_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.liveperson.infra.InitLivePersonProperties']]"
		[Register ("initialize", "(Landroid/content/Context;Lcom/liveperson/infra/InitLivePersonProperties;)V", "")]
		public static unsafe void Initialize (global::Android.Content.Context p0, global::Com.Liveperson.Infra.InitLivePersonProperties p1)
		{
			if (id_initialize_Landroid_content_Context_Lcom_liveperson_infra_InitLivePersonProperties_ == IntPtr.Zero)
				id_initialize_Landroid_content_Context_Lcom_liveperson_infra_InitLivePersonProperties_ = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Landroid/content/Context;Lcom/liveperson/infra/InitLivePersonProperties;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initialize_Landroid_content_Context_Lcom_liveperson_infra_InitLivePersonProperties_, __args);
			} finally {
			}
		}

		static IntPtr id_initialize_Landroid_content_Context_Ljava_lang_String_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='initialize' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.infra.callbacks.InitLivePersonCallBack']]"
		[Obsolete (@"deprecated")]
		[Register ("initialize", "(Landroid/content/Context;Ljava/lang/String;Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;)V", "")]
		public static unsafe void Initialize (global::Android.Content.Context p0, string p1, global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack p2)
		{
			if (id_initialize_Landroid_content_Context_Ljava_lang_String_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_ == IntPtr.Zero)
				id_initialize_Landroid_content_Context_Ljava_lang_String_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_ = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Landroid/content/Context;Ljava/lang/String;Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initialize_Landroid_content_Context_Ljava_lang_String_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_logOut_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_sdk_api_callbacks_LogoutLivePersonCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='logOut' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.liveperson.messaging.sdk.api.callbacks.LogoutLivePersonCallback']]"
		[Register ("logOut", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/sdk/api/callbacks/LogoutLivePersonCallback;)V", "")]
		public static unsafe void LogOut (global::Android.Content.Context p0, string p1, string p2, global::Com.Liveperson.Messaging.Sdk.Api.Callbacks.ILogoutLivePersonCallback p3)
		{
			if (id_logOut_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_sdk_api_callbacks_LogoutLivePersonCallback_ == IntPtr.Zero)
				id_logOut_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_sdk_api_callbacks_LogoutLivePersonCallback_ = JNIEnv.GetStaticMethodID (class_ref, "logOut", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/sdk/api/callbacks/LogoutLivePersonCallback;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_logOut_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_sdk_api_callbacks_LogoutLivePersonCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_markConversationAsNormal;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='markConversationAsNormal' and count(parameter)=0]"
		[Register ("markConversationAsNormal", "()V", "")]
		public static unsafe void MarkConversationAsNormal ()
		{
			if (id_markConversationAsNormal == IntPtr.Zero)
				id_markConversationAsNormal = JNIEnv.GetStaticMethodID (class_ref, "markConversationAsNormal", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_markConversationAsNormal);
			} finally {
			}
		}

		static IntPtr id_markConversationAsUrgent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='markConversationAsUrgent' and count(parameter)=0]"
		[Register ("markConversationAsUrgent", "()V", "")]
		public static unsafe void MarkConversationAsUrgent ()
		{
			if (id_markConversationAsUrgent == IntPtr.Zero)
				id_markConversationAsUrgent = JNIEnv.GetStaticMethodID (class_ref, "markConversationAsUrgent", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_markConversationAsUrgent);
			} finally {
			}
		}

		static IntPtr id_reconnect_Lcom_liveperson_infra_LPAuthenticationParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='reconnect' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.LPAuthenticationParams']]"
		[Register ("reconnect", "(Lcom/liveperson/infra/LPAuthenticationParams;)V", "")]
		public static unsafe void Reconnect (global::Com.Liveperson.Infra.LPAuthenticationParams p0)
		{
			if (id_reconnect_Lcom_liveperson_infra_LPAuthenticationParams_ == IntPtr.Zero)
				id_reconnect_Lcom_liveperson_infra_LPAuthenticationParams_ = JNIEnv.GetStaticMethodID (class_ref, "reconnect", "(Lcom/liveperson/infra/LPAuthenticationParams;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reconnect_Lcom_liveperson_infra_LPAuthenticationParams_, __args);
			} finally {
			}
		}

		static IntPtr id_reconnect_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='reconnect' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("reconnect", "(Ljava/lang/String;)V", "")]
		public static unsafe void Reconnect (string p0)
		{
			if (id_reconnect_Ljava_lang_String_ == IntPtr.Zero)
				id_reconnect_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "reconnect", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reconnect_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_registerLPPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='registerLPPusher' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("registerLPPusher", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void RegisterLPPusher (string p0, string p1, string p2)
		{
			if (id_registerLPPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_registerLPPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "registerLPPusher", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_registerLPPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_registerLPPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='registerLPPusher' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.liveperson.infra.LPAuthenticationParams'] and parameter[5][@type='com.liveperson.infra.ICallback&lt;java.lang.Void, java.lang.Exception&gt;']]"
		[Register ("registerLPPusher", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ICallback;)V", "")]
		public static unsafe void RegisterLPPusher (string p0, string p1, string p2, global::Com.Liveperson.Infra.LPAuthenticationParams p3, global::Com.Liveperson.Infra.ICallback p4)
		{
			if (id_registerLPPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_ == IntPtr.Zero)
				id_registerLPPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_ = JNIEnv.GetStaticMethodID (class_ref, "registerLPPusher", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_registerLPPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_removeCallBack;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='removeCallBack' and count(parameter)=0]"
		[Register ("removeCallBack", "()V", "")]
		public static unsafe void RemoveCallBack ()
		{
			if (id_removeCallBack == IntPtr.Zero)
				id_removeCallBack = JNIEnv.GetStaticMethodID (class_ref, "removeCallBack", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_removeCallBack);
			} finally {
			}
		}

		static IntPtr id_resolveConversation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='resolveConversation' and count(parameter)=0]"
		[Register ("resolveConversation", "()V", "")]
		public static unsafe void ResolveConversation ()
		{
			if (id_resolveConversation == IntPtr.Zero)
				id_resolveConversation = JNIEnv.GetStaticMethodID (class_ref, "resolveConversation", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_resolveConversation);
			} finally {
			}
		}

		static IntPtr id_setCallback_Lcom_liveperson_api_LivePersonCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.liveperson.api.LivePersonCallback']]"
		[Register ("setCallback", "(Lcom/liveperson/api/LivePersonCallback;)V", "")]
		public static unsafe void SetCallback (global::Com.Liveperson.Api.ILivePersonCallback p0)
		{
			if (id_setCallback_Lcom_liveperson_api_LivePersonCallback_ == IntPtr.Zero)
				id_setCallback_Lcom_liveperson_api_LivePersonCallback_ = JNIEnv.GetStaticMethodID (class_ref, "setCallback", "(Lcom/liveperson/api/LivePersonCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setCallback_Lcom_liveperson_api_LivePersonCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_setImageServiceDownloadNotificationBuilder_Landroid_app_Notification_Builder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='setImageServiceDownloadNotificationBuilder' and count(parameter)=1 and parameter[1][@type='android.app.Notification.Builder']]"
		[Register ("setImageServiceDownloadNotificationBuilder", "(Landroid/app/Notification$Builder;)V", "")]
		public static unsafe void SetImageServiceDownloadNotificationBuilder (global::Android.App.Notification.Builder p0)
		{
			if (id_setImageServiceDownloadNotificationBuilder_Landroid_app_Notification_Builder_ == IntPtr.Zero)
				id_setImageServiceDownloadNotificationBuilder_Landroid_app_Notification_Builder_ = JNIEnv.GetStaticMethodID (class_ref, "setImageServiceDownloadNotificationBuilder", "(Landroid/app/Notification$Builder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setImageServiceDownloadNotificationBuilder_Landroid_app_Notification_Builder_, __args);
			} finally {
			}
		}

		static IntPtr id_setImageServicePendingIntent_Landroid_app_PendingIntent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='setImageServicePendingIntent' and count(parameter)=1 and parameter[1][@type='android.app.PendingIntent']]"
		[Register ("setImageServicePendingIntent", "(Landroid/app/PendingIntent;)V", "")]
		public static unsafe void SetImageServicePendingIntent (global::Android.App.PendingIntent p0)
		{
			if (id_setImageServicePendingIntent_Landroid_app_PendingIntent_ == IntPtr.Zero)
				id_setImageServicePendingIntent_Landroid_app_PendingIntent_ = JNIEnv.GetStaticMethodID (class_ref, "setImageServicePendingIntent", "(Landroid/app/PendingIntent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setImageServicePendingIntent_Landroid_app_PendingIntent_, __args);
			} finally {
			}
		}

		static IntPtr id_setImageServiceUploadNotificationBuilder_Landroid_app_Notification_Builder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='setImageServiceUploadNotificationBuilder' and count(parameter)=1 and parameter[1][@type='android.app.Notification.Builder']]"
		[Register ("setImageServiceUploadNotificationBuilder", "(Landroid/app/Notification$Builder;)V", "")]
		public static unsafe void SetImageServiceUploadNotificationBuilder (global::Android.App.Notification.Builder p0)
		{
			if (id_setImageServiceUploadNotificationBuilder_Landroid_app_Notification_Builder_ == IntPtr.Zero)
				id_setImageServiceUploadNotificationBuilder_Landroid_app_Notification_Builder_ = JNIEnv.GetStaticMethodID (class_ref, "setImageServiceUploadNotificationBuilder", "(Landroid/app/Notification$Builder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setImageServiceUploadNotificationBuilder_Landroid_app_Notification_Builder_, __args);
			} finally {
			}
		}

		static IntPtr id_setUserProfile_Lcom_liveperson_messaging_sdk_api_model_ConsumerProfile_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='setUserProfile' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.sdk.api.model.ConsumerProfile']]"
		[Register ("setUserProfile", "(Lcom/liveperson/messaging/sdk/api/model/ConsumerProfile;)V", "")]
		public static unsafe void SetUserProfile (global::Com.Liveperson.Messaging.Sdk.Api.Model.ConsumerProfile p0)
		{
			if (id_setUserProfile_Lcom_liveperson_messaging_sdk_api_model_ConsumerProfile_ == IntPtr.Zero)
				id_setUserProfile_Lcom_liveperson_messaging_sdk_api_model_ConsumerProfile_ = JNIEnv.GetStaticMethodID (class_ref, "setUserProfile", "(Lcom/liveperson/messaging/sdk/api/model/ConsumerProfile;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setUserProfile_Lcom_liveperson_messaging_sdk_api_model_ConsumerProfile_, __args);
			} finally {
			}
		}

		static IntPtr id_setUserProfile_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='setUserProfile' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("setUserProfile", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SetUserProfile (string p0, string p1, string p2, string p3)
		{
			if (id_setUserProfile_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setUserProfile_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setUserProfile", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setUserProfile_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_showConversation_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='showConversation' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Obsolete (@"deprecated")]
		[Register ("showConversation", "(Landroid/app/Activity;)Z", "")]
		public static unsafe bool ShowConversation (global::Android.App.Activity p0)
		{
			if (id_showConversation_Landroid_app_Activity_ == IntPtr.Zero)
				id_showConversation_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "showConversation", "(Landroid/app/Activity;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_showConversation_Landroid_app_Activity_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_showConversation_Landroid_app_Activity_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='showConversation' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.liveperson.infra.LPAuthenticationParams'] and parameter[3][@type='com.liveperson.infra.ConversationViewParams']]"
		[Register ("showConversation", "(Landroid/app/Activity;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ConversationViewParams;)Z", "")]
		public static unsafe bool ShowConversation (global::Android.App.Activity p0, global::Com.Liveperson.Infra.LPAuthenticationParams p1, global::Com.Liveperson.Infra.ConversationViewParams p2)
		{
			if (id_showConversation_Landroid_app_Activity_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ == IntPtr.Zero)
				id_showConversation_Landroid_app_Activity_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ = JNIEnv.GetStaticMethodID (class_ref, "showConversation", "(Landroid/app/Activity;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ConversationViewParams;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_showConversation_Landroid_app_Activity_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_showConversation_Landroid_app_Activity_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='showConversation' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("showConversation", "(Landroid/app/Activity;Ljava/lang/String;)Z", "")]
		public static unsafe bool ShowConversation (global::Android.App.Activity p0, string p1)
		{
			if (id_showConversation_Landroid_app_Activity_Ljava_lang_String_ == IntPtr.Zero)
				id_showConversation_Landroid_app_Activity_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "showConversation", "(Landroid/app/Activity;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_showConversation_Landroid_app_Activity_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_shutDown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='shutDown' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("shutDown", "()V", "")]
		public static unsafe void ShutDown ()
		{
			if (id_shutDown == IntPtr.Zero)
				id_shutDown = JNIEnv.GetStaticMethodID (class_ref, "shutDown", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shutDown);
			} finally {
			}
		}

		static IntPtr id_shutDown_Lcom_liveperson_messaging_sdk_api_callbacks_ShutDownLivePersonCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='shutDown' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.sdk.api.callbacks.ShutDownLivePersonCallback']]"
		[Register ("shutDown", "(Lcom/liveperson/messaging/sdk/api/callbacks/ShutDownLivePersonCallback;)V", "")]
		public static unsafe void ShutDown (global::Com.Liveperson.Messaging.Sdk.Api.Callbacks.IShutDownLivePersonCallback p0)
		{
			if (id_shutDown_Lcom_liveperson_messaging_sdk_api_callbacks_ShutDownLivePersonCallback_ == IntPtr.Zero)
				id_shutDown_Lcom_liveperson_messaging_sdk_api_callbacks_ShutDownLivePersonCallback_ = JNIEnv.GetStaticMethodID (class_ref, "shutDown", "(Lcom/liveperson/messaging/sdk/api/callbacks/ShutDownLivePersonCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shutDown_Lcom_liveperson_messaging_sdk_api_callbacks_ShutDownLivePersonCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_unregisterLPPusher_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api']/class[@name='LivePerson']/method[@name='unregisterLPPusher' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("unregisterLPPusher", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void UnregisterLPPusher (string p0, string p1)
		{
			if (id_unregisterLPPusher_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_unregisterLPPusher_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "unregisterLPPusher", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_unregisterLPPusher_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
