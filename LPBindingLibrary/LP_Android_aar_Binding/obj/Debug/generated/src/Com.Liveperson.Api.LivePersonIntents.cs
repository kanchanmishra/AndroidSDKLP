using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']"
	[global::Android.Runtime.Register ("com/liveperson/api/LivePersonIntents", DoNotGenerateAcw=true)]
	public partial class LivePersonIntents : global::Java.Lang.Object {

		[Register ("com/liveperson/api/LivePersonIntents$ILivePersonIntentAction", DoNotGenerateAcw=true)]
		public abstract class LivePersonIntentAction : Java.Lang.Object {

			internal LivePersonIntentAction ()
			{
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentAction']/field[@name='LP_ON_AGENT_AVATAR_TAPPED_INTENT_ACTION']"
			[Register ("LP_ON_AGENT_AVATAR_TAPPED_INTENT_ACTION")]
			public const string LpOnAgentAvatarTappedIntentAction = (string) "LP_ON_AGENT_AVATAR_TAPPED_INTENT_ACTION";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentAction']/field[@name='LP_ON_AGENT_DETAILS_CHANGED_INTENT_ACTION']"
			[Register ("LP_ON_AGENT_DETAILS_CHANGED_INTENT_ACTION")]
			public const string LpOnAgentDetailsChangedIntentAction = (string) "LP_ON_AGENT_DETAILS_CHANGED_INTENT_ACTION";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentAction']/field[@name='LP_ON_AGENT_TYPING_INTENT_ACTION']"
			[Register ("LP_ON_AGENT_TYPING_INTENT_ACTION")]
			public const string LpOnAgentTypingIntentAction = (string) "LP_ON_AGENT_TYPING_INTENT_ACTION";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentAction']/field[@name='LP_ON_CONNECTION_CHANGED_INTENT_ACTION']"
			[Register ("LP_ON_CONNECTION_CHANGED_INTENT_ACTION")]
			public const string LpOnConnectionChangedIntentAction = (string) "LP_ON_CONNECTION_CHANGED_INTENT_ACTION";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentAction']/field[@name='LP_ON_CONVERSATION_MARKED_AS_NORMAL_INTENT_ACTION']"
			[Register ("LP_ON_CONVERSATION_MARKED_AS_NORMAL_INTENT_ACTION")]
			public const string LpOnConversationMarkedAsNormalIntentAction = (string) "LP_ON_CONVERSATION_MARKED_AS_NORMAL_INTENT_ACTION";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentAction']/field[@name='LP_ON_CONVERSATION_MARKED_AS_URGENT_INTENT_ACTION']"
			[Register ("LP_ON_CONVERSATION_MARKED_AS_URGENT_INTENT_ACTION")]
			public const string LpOnConversationMarkedAsUrgentIntentAction = (string) "LP_ON_CONVERSATION_MARKED_AS_URGENT_INTENT_ACTION";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentAction']/field[@name='LP_ON_CONVERSATION_RESOLVED_INTENT_ACTION']"
			[Register ("LP_ON_CONVERSATION_RESOLVED_INTENT_ACTION")]
			public const string LpOnConversationResolvedIntentAction = (string) "LP_ON_CONVERSATION_RESOLVED_INTENT_ACTION";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentAction']/field[@name='LP_ON_CONVERSATION_STARTED_INTENT_ACTION']"
			[Register ("LP_ON_CONVERSATION_STARTED_INTENT_ACTION")]
			public const string LpOnConversationStartedIntentAction = (string) "LP_ON_CONVERSATION_STARTED_INTENT_ACTION";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentAction']/field[@name='LP_ON_CSAT_DISMISSED_INTENT_ACTION']"
			[Register ("LP_ON_CSAT_DISMISSED_INTENT_ACTION")]
			public const string LpOnCsatDismissedIntentAction = (string) "LP_ON_CSAT_DISMISSED_INTENT_ACTION";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentAction']/field[@name='LP_ON_CSAT_LAUNCHED_INTENT_ACTION']"
			[Register ("LP_ON_CSAT_LAUNCHED_INTENT_ACTION")]
			public const string LpOnCsatLaunchedIntentAction = (string) "LP_ON_CSAT_LAUNCHED_INTENT_ACTION";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentAction']/field[@name='LP_ON_CSAT_SKIPPED_INTENT_ACTION']"
			[Register ("LP_ON_CSAT_SKIPPED_INTENT_ACTION")]
			public const string LpOnCsatSkippedIntentAction = (string) "LP_ON_CSAT_SKIPPED_INTENT_ACTION";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentAction']/field[@name='LP_ON_CSAT_SUBMITTED_INTENT_ACTION']"
			[Register ("LP_ON_CSAT_SUBMITTED_INTENT_ACTION")]
			public const string LpOnCsatSubmittedIntentAction = (string) "LP_ON_CSAT_SUBMITTED_INTENT_ACTION";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentAction']/field[@name='LP_ON_ERROR_INTENT_ACTION']"
			[Register ("LP_ON_ERROR_INTENT_ACTION")]
			public const string LpOnErrorIntentAction = (string) "LP_ON_ERROR_INTENT_ACTION";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentAction']/field[@name='LP_ON_OFFLINE_HOURS_CHANGES_INTENT_ACTION']"
			[Register ("LP_ON_OFFLINE_HOURS_CHANGES_INTENT_ACTION")]
			public const string LpOnOfflineHoursChangesIntentAction = (string) "LP_ON_OFFLINE_HOURS_CHANGES_INTENT_ACTION";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentAction']/field[@name='LP_ON_STRUCTURED_CONTENT_LINK_CLICKED']"
			[Register ("LP_ON_STRUCTURED_CONTENT_LINK_CLICKED")]
			public const string LpOnStructuredContentLinkClicked = (string) "LP_ON_STRUCTURED_CONTENT_LINK_CLICKED";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentAction']/field[@name='LP_ON_TOKEN_EXPIRED_INTENT_ACTION']"
			[Register ("LP_ON_TOKEN_EXPIRED_INTENT_ACTION")]
			public const string LpOnTokenExpiredIntentAction = (string) "LP_ON_TOKEN_EXPIRED_INTENT_ACTION";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentAction']/field[@name='LP_ON_UNAUTHENTICATED_USER_EXPIRED_INTENT_ACTION']"
			[Register ("LP_ON_UNAUTHENTICATED_USER_EXPIRED_INTENT_ACTION")]
			public const string LpOnUnauthenticatedUserExpiredIntentAction = (string) "LP_ON_UNAUTHENTICATED_USER_EXPIRED_INTENT_ACTION";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentAction']/field[@name='LP_ON_USER_ACTION_ON_PREVENTED_PERMISSION']"
			[Register ("LP_ON_USER_ACTION_ON_PREVENTED_PERMISSION")]
			public const string LpOnUserActionOnPreventedPermission = (string) "LP_ON_USER_ACTION_ON_PREVENTED_PERMISSION";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentAction']/field[@name='LP_ON_USER_DENIED_PERMISSION']"
			[Register ("LP_ON_USER_DENIED_PERMISSION")]
			public const string LpOnUserDeniedPermission = (string) "LP_ON_USER_DENIED_PERMISSION";
		}

		[Register ("com/liveperson/api/LivePersonIntents$ILivePersonIntentAction", DoNotGenerateAcw=true)]
		[global::System.Obsolete ("Use the 'LivePersonIntentAction' type. This type will be removed in a future release.")]
		public abstract class LivePersonIntentActionConsts : LivePersonIntentAction {

			private LivePersonIntentActionConsts ()
			{
			}
		}


		[Register ("com/liveperson/api/LivePersonIntents$ILivePersonIntentExtras", DoNotGenerateAcw=true)]
		public abstract class LivePersonIntentExtras : Java.Lang.Object {

			internal LivePersonIntentExtras ()
			{
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentExtras']/field[@name='LP_AGENT_DATA_INTENT_PARCELABLE_EXTRA']"
			[Register ("LP_AGENT_DATA_INTENT_PARCELABLE_EXTRA")]
			public const string LpAgentDataIntentParcelableExtra = (string) "LP_AGENT_DATA_INTENT_PARCELABLE_EXTRA";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentExtras']/field[@name='LP_AGENT_IS_TYPING_INTENT_BOOLEAN_EXTRA']"
			[Register ("LP_AGENT_IS_TYPING_INTENT_BOOLEAN_EXTRA")]
			public const string LpAgentIsTypingIntentBooleanExtra = (string) "LP_AGENT_IS_TYPING_INTENT_BOOLEAN_EXTRA";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentExtras']/field[@name='LP_CONVERSATION_DATA_INTENT_PARCELABLE_EXTRA']"
			[Register ("LP_CONVERSATION_DATA_INTENT_PARCELABLE_EXTRA")]
			public const string LpConversationDataIntentParcelableExtra = (string) "LP_CONVERSATION_DATA_INTENT_PARCELABLE_EXTRA";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentExtras']/field[@name='LP_CONVERSATION_ID_INTENT_STRING_EXTRA']"
			[Register ("LP_CONVERSATION_ID_INTENT_STRING_EXTRA")]
			public const string LpConversationIdIntentStringExtra = (string) "LP_CONVERSATION_ID_INTENT_STRING_EXTRA";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentExtras']/field[@name='LP_IS_CONNECTED_INTENT_BOOLEAN_EXTRA']"
			[Register ("LP_IS_CONNECTED_INTENT_BOOLEAN_EXTRA")]
			public const string LpIsConnectedIntentBooleanExtra = (string) "LP_IS_CONNECTED_INTENT_BOOLEAN_EXTRA";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentExtras']/field[@name='LP_IS_OFFLINE_HOURS_ON_INTENT_BOOLEAN_EXTRA']"
			[Register ("LP_IS_OFFLINE_HOURS_ON_INTENT_BOOLEAN_EXTRA")]
			public const string LpIsOfflineHoursOnIntentBooleanExtra = (string) "LP_IS_OFFLINE_HOURS_ON_INTENT_BOOLEAN_EXTRA";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentExtras']/field[@name='LP_LINK_URI_EXTRA']"
			[Register ("LP_LINK_URI_EXTRA")]
			public const string LpLinkUriExtra = (string) "LP_LINK_URI_EXTRA";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentExtras']/field[@name='LP_ON_ERROR_MESSAGE_INTENT_STRING_EXTRA']"
			[Register ("LP_ON_ERROR_MESSAGE_INTENT_STRING_EXTRA")]
			public const string LpOnErrorMessageIntentStringExtra = (string) "LP_ON_ERROR_MESSAGE_INTENT_STRING_EXTRA";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentExtras']/field[@name='LP_ON_ERROR_TASK_TYPE_INTENT_INT_EXTRA']"
			[Register ("LP_ON_ERROR_TASK_TYPE_INTENT_INT_EXTRA")]
			public const string LpOnErrorTaskTypeIntentIntExtra = (string) "LP_ON_ERROR_TASK_TYPE_INTENT_INT_EXTRA";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentExtras']/field[@name='LP_PERMISSION_DO_NOT_SHOW_AGAIN_EXTRA']"
			[Register ("LP_PERMISSION_DO_NOT_SHOW_AGAIN_EXTRA")]
			public const string LpPermissionDoNotShowAgainExtra = (string) "LP_PERMISSION_DO_NOT_SHOW_AGAIN_EXTRA";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api']/interface[@name='LivePersonIntents.ILivePersonIntentExtras']/field[@name='LP_PERMISSION_TYPE_EXTRA']"
			[Register ("LP_PERMISSION_TYPE_EXTRA")]
			public const string LpPermissionTypeExtra = (string) "LP_PERMISSION_TYPE_EXTRA";
		}

		[Register ("com/liveperson/api/LivePersonIntents$ILivePersonIntentExtras", DoNotGenerateAcw=true)]
		[global::System.Obsolete ("Use the 'LivePersonIntentExtras' type. This type will be removed in a future release.")]
		public abstract class LivePersonIntentExtrasConsts : LivePersonIntentExtras {

			private LivePersonIntentExtrasConsts ()
			{
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/LivePersonIntents", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LivePersonIntents); }
		}

		protected LivePersonIntents (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/constructor[@name='LivePersonIntents' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LivePersonIntents ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LivePersonIntents)) {
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

		static IntPtr id_getIntentFilterForAllEvents;
		public static unsafe global::Android.Content.IntentFilter IntentFilterForAllEvents {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='getIntentFilterForAllEvents' and count(parameter)=0]"
			[Register ("getIntentFilterForAllEvents", "()Landroid/content/IntentFilter;", "GetGetIntentFilterForAllEventsHandler")]
			get {
				if (id_getIntentFilterForAllEvents == IntPtr.Zero)
					id_getIntentFilterForAllEvents = JNIEnv.GetStaticMethodID (class_ref, "getIntentFilterForAllEvents", "()Landroid/content/IntentFilter;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Content.IntentFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getIntentFilterForAllEvents), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getAgentData_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='getAgentData' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("getAgentData", "(Landroid/content/Intent;)Lcom/liveperson/messaging/model/AgentData;", "")]
		public static unsafe global::Com.Liveperson.Messaging.Model.AgentData GetAgentData (global::Android.Content.Intent p0)
		{
			if (id_getAgentData_Landroid_content_Intent_ == IntPtr.Zero)
				id_getAgentData_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "getAgentData", "(Landroid/content/Intent;)Lcom/liveperson/messaging/model/AgentData;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Liveperson.Messaging.Model.AgentData __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AgentData> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAgentData_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getAgentTypingValue_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='getAgentTypingValue' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("getAgentTypingValue", "(Landroid/content/Intent;)Z", "")]
		public static unsafe bool GetAgentTypingValue (global::Android.Content.Intent p0)
		{
			if (id_getAgentTypingValue_Landroid_content_Intent_ == IntPtr.Zero)
				id_getAgentTypingValue_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "getAgentTypingValue", "(Landroid/content/Intent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_getAgentTypingValue_Landroid_content_Intent_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getConnectedValue_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='getConnectedValue' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("getConnectedValue", "(Landroid/content/Intent;)Z", "")]
		public static unsafe bool GetConnectedValue (global::Android.Content.Intent p0)
		{
			if (id_getConnectedValue_Landroid_content_Intent_ == IntPtr.Zero)
				id_getConnectedValue_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "getConnectedValue", "(Landroid/content/Intent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_getConnectedValue_Landroid_content_Intent_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getConversationID_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='getConversationID' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("getConversationID", "(Landroid/content/Intent;)Ljava/lang/String;", "")]
		public static unsafe string GetConversationID (global::Android.Content.Intent p0)
		{
			if (id_getConversationID_Landroid_content_Intent_ == IntPtr.Zero)
				id_getConversationID_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "getConversationID", "(Landroid/content/Intent;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getConversationID_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getLPConversationData_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='getLPConversationData' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("getLPConversationData", "(Landroid/content/Intent;)Lcom/liveperson/api/sdk/LPConversationData;", "")]
		public static unsafe global::Com.Liveperson.Api.Sdk.LPConversationData GetLPConversationData (global::Android.Content.Intent p0)
		{
			if (id_getLPConversationData_Landroid_content_Intent_ == IntPtr.Zero)
				id_getLPConversationData_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "getLPConversationData", "(Landroid/content/Intent;)Lcom/liveperson/api/sdk/LPConversationData;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Liveperson.Api.Sdk.LPConversationData __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Sdk.LPConversationData> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLPConversationData_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getLinkUri_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='getLinkUri' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("getLinkUri", "(Landroid/content/Intent;)Ljava/lang/String;", "")]
		public static unsafe string GetLinkUri (global::Android.Content.Intent p0)
		{
			if (id_getLinkUri_Landroid_content_Intent_ == IntPtr.Zero)
				id_getLinkUri_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "getLinkUri", "(Landroid/content/Intent;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLinkUri_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getOfflineHoursOn_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='getOfflineHoursOn' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("getOfflineHoursOn", "(Landroid/content/Intent;)Z", "")]
		public static unsafe bool GetOfflineHoursOn (global::Android.Content.Intent p0)
		{
			if (id_getOfflineHoursOn_Landroid_content_Intent_ == IntPtr.Zero)
				id_getOfflineHoursOn_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "getOfflineHoursOn", "(Landroid/content/Intent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_getOfflineHoursOn_Landroid_content_Intent_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getOnErrorMessage_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='getOnErrorMessage' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("getOnErrorMessage", "(Landroid/content/Intent;)Ljava/lang/String;", "")]
		public static unsafe string GetOnErrorMessage (global::Android.Content.Intent p0)
		{
			if (id_getOnErrorMessage_Landroid_content_Intent_ == IntPtr.Zero)
				id_getOnErrorMessage_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "getOnErrorMessage", "(Landroid/content/Intent;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOnErrorMessage_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getOnErrorTaskType_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='getOnErrorTaskType' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("getOnErrorTaskType", "(Landroid/content/Intent;)Lcom/liveperson/messaging/TaskType;", "")]
		public static unsafe global::Com.Liveperson.Messaging.TaskType GetOnErrorTaskType (global::Android.Content.Intent p0)
		{
			if (id_getOnErrorTaskType_Landroid_content_Intent_ == IntPtr.Zero)
				id_getOnErrorTaskType_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "getOnErrorTaskType", "(Landroid/content/Intent;)Lcom/liveperson/messaging/TaskType;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Liveperson.Messaging.TaskType __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.TaskType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOnErrorTaskType_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getPermissionDoNotShowAgainMarked_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='getPermissionDoNotShowAgainMarked' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("getPermissionDoNotShowAgainMarked", "(Landroid/content/Intent;)Z", "")]
		public static unsafe bool GetPermissionDoNotShowAgainMarked (global::Android.Content.Intent p0)
		{
			if (id_getPermissionDoNotShowAgainMarked_Landroid_content_Intent_ == IntPtr.Zero)
				id_getPermissionDoNotShowAgainMarked_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "getPermissionDoNotShowAgainMarked", "(Landroid/content/Intent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_getPermissionDoNotShowAgainMarked_Landroid_content_Intent_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getPermissionType_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='getPermissionType' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("getPermissionType", "(Landroid/content/Intent;)Lcom/liveperson/api/sdk/PermissionType;", "")]
		public static unsafe global::Com.Liveperson.Api.Sdk.PermissionType GetPermissionType (global::Android.Content.Intent p0)
		{
			if (id_getPermissionType_Landroid_content_Intent_ == IntPtr.Zero)
				id_getPermissionType_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "getPermissionType", "(Landroid/content/Intent;)Lcom/liveperson/api/sdk/PermissionType;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Liveperson.Api.Sdk.PermissionType __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Sdk.PermissionType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPermissionType_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sendOnAgentAvatarTapped_Landroid_content_Context_Lcom_liveperson_messaging_model_AgentData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='sendOnAgentAvatarTapped' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.liveperson.messaging.model.AgentData']]"
		[Register ("sendOnAgentAvatarTapped", "(Landroid/content/Context;Lcom/liveperson/messaging/model/AgentData;)V", "")]
		public static unsafe void SendOnAgentAvatarTapped (global::Android.Content.Context p0, global::Com.Liveperson.Messaging.Model.AgentData p1)
		{
			if (id_sendOnAgentAvatarTapped_Landroid_content_Context_Lcom_liveperson_messaging_model_AgentData_ == IntPtr.Zero)
				id_sendOnAgentAvatarTapped_Landroid_content_Context_Lcom_liveperson_messaging_model_AgentData_ = JNIEnv.GetStaticMethodID (class_ref, "sendOnAgentAvatarTapped", "(Landroid/content/Context;Lcom/liveperson/messaging/model/AgentData;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendOnAgentAvatarTapped_Landroid_content_Context_Lcom_liveperson_messaging_model_AgentData_, __args);
			} finally {
			}
		}

		static IntPtr id_sendOnAgentDetailsChanged_Landroid_content_Context_Lcom_liveperson_messaging_model_AgentData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='sendOnAgentDetailsChanged' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.liveperson.messaging.model.AgentData']]"
		[Register ("sendOnAgentDetailsChanged", "(Landroid/content/Context;Lcom/liveperson/messaging/model/AgentData;)V", "")]
		public static unsafe void SendOnAgentDetailsChanged (global::Android.Content.Context p0, global::Com.Liveperson.Messaging.Model.AgentData p1)
		{
			if (id_sendOnAgentDetailsChanged_Landroid_content_Context_Lcom_liveperson_messaging_model_AgentData_ == IntPtr.Zero)
				id_sendOnAgentDetailsChanged_Landroid_content_Context_Lcom_liveperson_messaging_model_AgentData_ = JNIEnv.GetStaticMethodID (class_ref, "sendOnAgentDetailsChanged", "(Landroid/content/Context;Lcom/liveperson/messaging/model/AgentData;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendOnAgentDetailsChanged_Landroid_content_Context_Lcom_liveperson_messaging_model_AgentData_, __args);
			} finally {
			}
		}

		static IntPtr id_sendOnAgentTyping_Landroid_content_Context_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='sendOnAgentTyping' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("sendOnAgentTyping", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void SendOnAgentTyping (global::Android.Content.Context p0, bool p1)
		{
			if (id_sendOnAgentTyping_Landroid_content_Context_Z == IntPtr.Zero)
				id_sendOnAgentTyping_Landroid_content_Context_Z = JNIEnv.GetStaticMethodID (class_ref, "sendOnAgentTyping", "(Landroid/content/Context;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendOnAgentTyping_Landroid_content_Context_Z, __args);
			} finally {
			}
		}

		static IntPtr id_sendOnConnectionChanged_Landroid_content_Context_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='sendOnConnectionChanged' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("sendOnConnectionChanged", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void SendOnConnectionChanged (global::Android.Content.Context p0, bool p1)
		{
			if (id_sendOnConnectionChanged_Landroid_content_Context_Z == IntPtr.Zero)
				id_sendOnConnectionChanged_Landroid_content_Context_Z = JNIEnv.GetStaticMethodID (class_ref, "sendOnConnectionChanged", "(Landroid/content/Context;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendOnConnectionChanged_Landroid_content_Context_Z, __args);
			} finally {
			}
		}

		static IntPtr id_sendOnConversationMarkedAsNormal_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='sendOnConversationMarkedAsNormal' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("sendOnConversationMarkedAsNormal", "(Landroid/content/Context;)V", "")]
		public static unsafe void SendOnConversationMarkedAsNormal (global::Android.Content.Context p0)
		{
			if (id_sendOnConversationMarkedAsNormal_Landroid_content_Context_ == IntPtr.Zero)
				id_sendOnConversationMarkedAsNormal_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "sendOnConversationMarkedAsNormal", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendOnConversationMarkedAsNormal_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_sendOnConversationMarkedAsUrgent_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='sendOnConversationMarkedAsUrgent' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("sendOnConversationMarkedAsUrgent", "(Landroid/content/Context;)V", "")]
		public static unsafe void SendOnConversationMarkedAsUrgent (global::Android.Content.Context p0)
		{
			if (id_sendOnConversationMarkedAsUrgent_Landroid_content_Context_ == IntPtr.Zero)
				id_sendOnConversationMarkedAsUrgent_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "sendOnConversationMarkedAsUrgent", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendOnConversationMarkedAsUrgent_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_sendOnConversationResolved_Landroid_content_Context_Lcom_liveperson_api_sdk_LPConversationData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='sendOnConversationResolved' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.liveperson.api.sdk.LPConversationData']]"
		[Register ("sendOnConversationResolved", "(Landroid/content/Context;Lcom/liveperson/api/sdk/LPConversationData;)V", "")]
		public static unsafe void SendOnConversationResolved (global::Android.Content.Context p0, global::Com.Liveperson.Api.Sdk.LPConversationData p1)
		{
			if (id_sendOnConversationResolved_Landroid_content_Context_Lcom_liveperson_api_sdk_LPConversationData_ == IntPtr.Zero)
				id_sendOnConversationResolved_Landroid_content_Context_Lcom_liveperson_api_sdk_LPConversationData_ = JNIEnv.GetStaticMethodID (class_ref, "sendOnConversationResolved", "(Landroid/content/Context;Lcom/liveperson/api/sdk/LPConversationData;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendOnConversationResolved_Landroid_content_Context_Lcom_liveperson_api_sdk_LPConversationData_, __args);
			} finally {
			}
		}

		static IntPtr id_sendOnConversationStarted_Landroid_content_Context_Lcom_liveperson_api_sdk_LPConversationData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='sendOnConversationStarted' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.liveperson.api.sdk.LPConversationData']]"
		[Register ("sendOnConversationStarted", "(Landroid/content/Context;Lcom/liveperson/api/sdk/LPConversationData;)V", "")]
		public static unsafe void SendOnConversationStarted (global::Android.Content.Context p0, global::Com.Liveperson.Api.Sdk.LPConversationData p1)
		{
			if (id_sendOnConversationStarted_Landroid_content_Context_Lcom_liveperson_api_sdk_LPConversationData_ == IntPtr.Zero)
				id_sendOnConversationStarted_Landroid_content_Context_Lcom_liveperson_api_sdk_LPConversationData_ = JNIEnv.GetStaticMethodID (class_ref, "sendOnConversationStarted", "(Landroid/content/Context;Lcom/liveperson/api/sdk/LPConversationData;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendOnConversationStarted_Landroid_content_Context_Lcom_liveperson_api_sdk_LPConversationData_, __args);
			} finally {
			}
		}

		static IntPtr id_sendOnCsatDismissed_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='sendOnCsatDismissed' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("sendOnCsatDismissed", "(Landroid/content/Context;)V", "")]
		public static unsafe void SendOnCsatDismissed (global::Android.Content.Context p0)
		{
			if (id_sendOnCsatDismissed_Landroid_content_Context_ == IntPtr.Zero)
				id_sendOnCsatDismissed_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "sendOnCsatDismissed", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendOnCsatDismissed_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_sendOnCsatLaunched_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='sendOnCsatLaunched' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("sendOnCsatLaunched", "(Landroid/content/Context;)V", "")]
		public static unsafe void SendOnCsatLaunched (global::Android.Content.Context p0)
		{
			if (id_sendOnCsatLaunched_Landroid_content_Context_ == IntPtr.Zero)
				id_sendOnCsatLaunched_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "sendOnCsatLaunched", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendOnCsatLaunched_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_sendOnCsatSkipped_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='sendOnCsatSkipped' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("sendOnCsatSkipped", "(Landroid/content/Context;)V", "")]
		public static unsafe void SendOnCsatSkipped (global::Android.Content.Context p0)
		{
			if (id_sendOnCsatSkipped_Landroid_content_Context_ == IntPtr.Zero)
				id_sendOnCsatSkipped_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "sendOnCsatSkipped", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendOnCsatSkipped_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_sendOnCsatSubmitted_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='sendOnCsatSubmitted' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendOnCsatSubmitted", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SendOnCsatSubmitted (global::Android.Content.Context p0, string p1)
		{
			if (id_sendOnCsatSubmitted_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_sendOnCsatSubmitted_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sendOnCsatSubmitted", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendOnCsatSubmitted_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_sendOnErrorIntent_Landroid_content_Context_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='sendOnErrorIntent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.liveperson.messaging.TaskType'] and parameter[3][@type='java.lang.String']]"
		[Register ("sendOnErrorIntent", "(Landroid/content/Context;Lcom/liveperson/messaging/TaskType;Ljava/lang/String;)V", "")]
		public static unsafe void SendOnErrorIntent (global::Android.Content.Context p0, global::Com.Liveperson.Messaging.TaskType p1, string p2)
		{
			if (id_sendOnErrorIntent_Landroid_content_Context_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_ == IntPtr.Zero)
				id_sendOnErrorIntent_Landroid_content_Context_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sendOnErrorIntent", "(Landroid/content/Context;Lcom/liveperson/messaging/TaskType;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendOnErrorIntent_Landroid_content_Context_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_sendOnOfflineHoursChanges_Landroid_content_Context_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='sendOnOfflineHoursChanges' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("sendOnOfflineHoursChanges", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void SendOnOfflineHoursChanges (global::Android.Content.Context p0, bool p1)
		{
			if (id_sendOnOfflineHoursChanges_Landroid_content_Context_Z == IntPtr.Zero)
				id_sendOnOfflineHoursChanges_Landroid_content_Context_Z = JNIEnv.GetStaticMethodID (class_ref, "sendOnOfflineHoursChanges", "(Landroid/content/Context;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendOnOfflineHoursChanges_Landroid_content_Context_Z, __args);
			} finally {
			}
		}

		static IntPtr id_sendOnStructuredContentLinkClicked_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='sendOnStructuredContentLinkClicked' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendOnStructuredContentLinkClicked", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SendOnStructuredContentLinkClicked (global::Android.Content.Context p0, string p1)
		{
			if (id_sendOnStructuredContentLinkClicked_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_sendOnStructuredContentLinkClicked_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sendOnStructuredContentLinkClicked", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendOnStructuredContentLinkClicked_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_sendOnTokenExpired_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='sendOnTokenExpired' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("sendOnTokenExpired", "(Landroid/content/Context;)V", "")]
		public static unsafe void SendOnTokenExpired (global::Android.Content.Context p0)
		{
			if (id_sendOnTokenExpired_Landroid_content_Context_ == IntPtr.Zero)
				id_sendOnTokenExpired_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "sendOnTokenExpired", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendOnTokenExpired_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_sendOnUserActionOnPreventedPermission_Landroid_content_Context_Lcom_liveperson_api_sdk_PermissionType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='sendOnUserActionOnPreventedPermission' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.liveperson.api.sdk.PermissionType']]"
		[Register ("sendOnUserActionOnPreventedPermission", "(Landroid/content/Context;Lcom/liveperson/api/sdk/PermissionType;)V", "")]
		public static unsafe void SendOnUserActionOnPreventedPermission (global::Android.Content.Context p0, global::Com.Liveperson.Api.Sdk.PermissionType p1)
		{
			if (id_sendOnUserActionOnPreventedPermission_Landroid_content_Context_Lcom_liveperson_api_sdk_PermissionType_ == IntPtr.Zero)
				id_sendOnUserActionOnPreventedPermission_Landroid_content_Context_Lcom_liveperson_api_sdk_PermissionType_ = JNIEnv.GetStaticMethodID (class_ref, "sendOnUserActionOnPreventedPermission", "(Landroid/content/Context;Lcom/liveperson/api/sdk/PermissionType;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendOnUserActionOnPreventedPermission_Landroid_content_Context_Lcom_liveperson_api_sdk_PermissionType_, __args);
			} finally {
			}
		}

		static IntPtr id_sendOnUserDeniedPermission_Landroid_content_Context_Lcom_liveperson_api_sdk_PermissionType_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='sendOnUserDeniedPermission' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.liveperson.api.sdk.PermissionType'] and parameter[3][@type='boolean']]"
		[Register ("sendOnUserDeniedPermission", "(Landroid/content/Context;Lcom/liveperson/api/sdk/PermissionType;Z)V", "")]
		public static unsafe void SendOnUserDeniedPermission (global::Android.Content.Context p0, global::Com.Liveperson.Api.Sdk.PermissionType p1, bool p2)
		{
			if (id_sendOnUserDeniedPermission_Landroid_content_Context_Lcom_liveperson_api_sdk_PermissionType_Z == IntPtr.Zero)
				id_sendOnUserDeniedPermission_Landroid_content_Context_Lcom_liveperson_api_sdk_PermissionType_Z = JNIEnv.GetStaticMethodID (class_ref, "sendOnUserDeniedPermission", "(Landroid/content/Context;Lcom/liveperson/api/sdk/PermissionType;Z)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendOnUserDeniedPermission_Landroid_content_Context_Lcom_liveperson_api_sdk_PermissionType_Z, __args);
			} finally {
			}
		}

		static IntPtr id_sendOnUserExpired_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api']/class[@name='LivePersonIntents']/method[@name='sendOnUserExpired' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("sendOnUserExpired", "(Landroid/content/Context;)V", "")]
		public static unsafe void SendOnUserExpired (global::Android.Content.Context p0)
		{
			if (id_sendOnUserExpired_Landroid_content_Context_ == IntPtr.Zero)
				id_sendOnUserExpired_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "sendOnUserExpired", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendOnUserExpired_Landroid_content_Context_, __args);
			} finally {
			}
		}

	}
}
