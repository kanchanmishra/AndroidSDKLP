using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/model/AmsConversations", DoNotGenerateAcw=true)]
	public partial class AmsConversations : global::Com.Liveperson.Infra.Database.BaseDBRepository, global::Com.Liveperson.Infra.IClearable, global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDown {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/field[@name='BROADCAST_UPDATE_CONVERSATION']"
		[Register ("BROADCAST_UPDATE_CONVERSATION")]
		public const string BroadcastUpdateConversation = (string) "BROADCAST_UPDATE_CONVERSATION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/field[@name='BROADCAST_UPDATE_CONVERSATIONS_LIST']"
		[Register ("BROADCAST_UPDATE_CONVERSATIONS_LIST")]
		public const string BroadcastUpdateConversationsList = (string) "BROADCAST_UPDATE_CONVERSATIONS_LIST";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/field[@name='BROADCAST_UPDATE_CONVERSATION_CLOSED']"
		[Register ("BROADCAST_UPDATE_CONVERSATION_CLOSED")]
		public const string BroadcastUpdateConversationClosed = (string) "BROADCAST_UPDATE_CONVERSATION_CLOSED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/field[@name='BROADCAST_UPDATE_CONVERSATION_OFF_HOURS']"
		[Register ("BROADCAST_UPDATE_CONVERSATION_OFF_HOURS")]
		public const string BroadcastUpdateConversationOffHours = (string) "BROADCAST_UPDATE_CONVERSATION_OFF_HOURS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/field[@name='BROADCAST_UPDATE_CONVERSATION_TTR']"
		[Register ("BROADCAST_UPDATE_CONVERSATION_TTR")]
		public const string BroadcastUpdateConversationTtr = (string) "BROADCAST_UPDATE_CONVERSATION_TTR";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/field[@name='BROADCAST_UPDATE_CSAT_CONVERSATION']"
		[Register ("BROADCAST_UPDATE_CSAT_CONVERSATION")]
		public const string BroadcastUpdateCsatConversation = (string) "BROADCAST_UPDATE_CSAT_CONVERSATION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/field[@name='BROADCAST_UPDATE_FORM_URL']"
		[Register ("BROADCAST_UPDATE_FORM_URL")]
		public const string BroadcastUpdateFormUrl = (string) "BROADCAST_UPDATE_FORM_URL";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/field[@name='BROADCAST_UPDATE_NEW_CONVERSATION_MSG']"
		[Register ("BROADCAST_UPDATE_NEW_CONVERSATION_MSG")]
		public const string BroadcastUpdateNewConversationMsg = (string) "BROADCAST_UPDATE_NEW_CONVERSATION_MSG";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/field[@name='BROADCAST_UPDATE_UNREAD_MSG']"
		[Register ("BROADCAST_UPDATE_UNREAD_MSG")]
		public const string BroadcastUpdateUnreadMsg = (string) "BROADCAST_UPDATE_UNREAD_MSG";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/field[@name='DELAY_TILL_WHEN']"
		[Register ("DELAY_TILL_WHEN")]
		public const string DelayTillWhen = (string) "DELAY_TILL_WHEN";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/field[@name='DELAY_TILL_WHEN_CHANGED']"
		[Register ("DELAY_TILL_WHEN_CHANGED")]
		public const string DelayTillWhenChanged = (string) "DELAY_TILL_WHEN_CHANGED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/field[@name='KEY_CONVERSATION_ASSIGNED_AGENT']"
		[Register ("KEY_CONVERSATION_ASSIGNED_AGENT")]
		public const string KeyConversationAssignedAgent = (string) "KEY_CONVERSATION_ASSIGNED_AGENT";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/field[@name='KEY_CONVERSATION_ID']"
		[Register ("KEY_CONVERSATION_ID")]
		public const string KeyConversationId = (string) "KEY_CONVERSATION_ID";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/field[@name='KEY_CONVERSATION_SHOWED_CSAT']"
		[Register ("KEY_CONVERSATION_SHOWED_CSAT")]
		public const string KeyConversationShowedCsat = (string) "KEY_CONVERSATION_SHOWED_CSAT";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/field[@name='KEY_CONVERSATION_STATE']"
		[Register ("KEY_CONVERSATION_STATE")]
		public const string KeyConversationState = (string) "KEY_CONVERSATION_STATE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/field[@name='KEY_CONVERSATION_TARGET_ID']"
		[Register ("KEY_CONVERSATION_TARGET_ID")]
		public const string KeyConversationTargetId = (string) "KEY_CONVERSATION_TARGET_ID";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/field[@name='KEY_CONVERSATION_TTR_TIME']"
		[Register ("KEY_CONVERSATION_TTR_TIME")]
		public const string KeyConversationTtrTime = (string) "KEY_CONVERSATION_TTR_TIME";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/field[@name='KEY_WELCOME_CONVERSATION_ID']"
		[Register ("KEY_WELCOME_CONVERSATION_ID")]
		public const string KeyWelcomeConversationId = (string) "KEY_WELCOME_CONVERSATION_ID";

		static IntPtr acceptedSequenceEvents_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/field[@name='acceptedSequenceEvents']"
		[Register ("acceptedSequenceEvents")]
		protected global::Java.Util.HashSet AcceptedSequenceEvents {
			get {
				if (acceptedSequenceEvents_jfieldId == IntPtr.Zero)
					acceptedSequenceEvents_jfieldId = JNIEnv.GetFieldID (class_ref, "acceptedSequenceEvents", "Ljava/util/HashSet;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, acceptedSequenceEvents_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.HashSet> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (acceptedSequenceEvents_jfieldId == IntPtr.Zero)
					acceptedSequenceEvents_jfieldId = JNIEnv.GetFieldID (class_ref, "acceptedSequenceEvents", "Ljava/util/HashSet;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, acceptedSequenceEvents_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mController_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/field[@name='mController']"
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

		static IntPtr mConversationsByAccountId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/field[@name='mConversationsByAccountId']"
		[Register ("mConversationsByAccountId")]
		protected global::System.Collections.IDictionary MConversationsByAccountId {
			get {
				if (mConversationsByAccountId_jfieldId == IntPtr.Zero)
					mConversationsByAccountId_jfieldId = JNIEnv.GetFieldID (class_ref, "mConversationsByAccountId", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mConversationsByAccountId_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mConversationsByAccountId_jfieldId == IntPtr.Zero)
					mConversationsByAccountId_jfieldId = JNIEnv.GetFieldID (class_ref, "mConversationsByAccountId", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mConversationsByAccountId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mConversationsByServerId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/field[@name='mConversationsByServerId']"
		[Register ("mConversationsByServerId")]
		protected global::System.Collections.IDictionary MConversationsByServerId {
			get {
				if (mConversationsByServerId_jfieldId == IntPtr.Zero)
					mConversationsByServerId_jfieldId = JNIEnv.GetFieldID (class_ref, "mConversationsByServerId", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mConversationsByServerId_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mConversationsByServerId_jfieldId == IntPtr.Zero)
					mConversationsByServerId_jfieldId = JNIEnv.GetFieldID (class_ref, "mConversationsByServerId", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mConversationsByServerId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/model/AmsConversations", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsConversations); }
		}

		protected AmsConversations (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_Messaging_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/constructor[@name='AmsConversations' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.Messaging']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/Messaging;)V", "")]
		public unsafe AmsConversations (global::Com.Liveperson.Messaging.Messaging p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AmsConversations)) {
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

		static Delegate cb_getFetchConversationManager;
#pragma warning disable 0169
		static Delegate GetGetFetchConversationManagerHandler ()
		{
			if (cb_getFetchConversationManager == null)
				cb_getFetchConversationManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFetchConversationManager);
			return cb_getFetchConversationManager;
		}

		static IntPtr n_GetFetchConversationManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FetchConversationManager);
		}
#pragma warning restore 0169

		static IntPtr id_getFetchConversationManager;
		protected virtual unsafe global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager FetchConversationManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='getFetchConversationManager' and count(parameter)=0]"
			[Register ("getFetchConversationManager", "()Lcom/liveperson/messaging/commands/tasks/FetchConversationManager;", "GetGetFetchConversationManagerHandler")]
			get {
				if (id_getFetchConversationManager == IntPtr.Zero)
					id_getFetchConversationManager = JNIEnv.GetMethodID (class_ref, "getFetchConversationManager", "()Lcom/liveperson/messaging/commands/tasks/FetchConversationManager;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFetchConversationManager), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFetchConversationManager", "()Lcom/liveperson/messaging/commands/tasks/FetchConversationManager;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addConversationToMaps_Ljava_lang_String_Lcom_liveperson_messaging_model_Conversation_;
#pragma warning disable 0169
		static Delegate GetAddConversationToMaps_Ljava_lang_String_Lcom_liveperson_messaging_model_Conversation_Handler ()
		{
			if (cb_addConversationToMaps_Ljava_lang_String_Lcom_liveperson_messaging_model_Conversation_ == null)
				cb_addConversationToMaps_Ljava_lang_String_Lcom_liveperson_messaging_model_Conversation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddConversationToMaps_Ljava_lang_String_Lcom_liveperson_messaging_model_Conversation_);
			return cb_addConversationToMaps_Ljava_lang_String_Lcom_liveperson_messaging_model_Conversation_;
		}

		static void n_AddConversationToMaps_Ljava_lang_String_Lcom_liveperson_messaging_model_Conversation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.Conversation p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddConversationToMaps (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addConversationToMaps_Ljava_lang_String_Lcom_liveperson_messaging_model_Conversation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='addConversationToMaps' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.messaging.model.Conversation']]"
		[Register ("addConversationToMaps", "(Ljava/lang/String;Lcom/liveperson/messaging/model/Conversation;)V", "GetAddConversationToMaps_Ljava_lang_String_Lcom_liveperson_messaging_model_Conversation_Handler")]
		protected virtual unsafe void AddConversationToMaps (string p0, global::Com.Liveperson.Messaging.Model.Conversation p1)
		{
			if (id_addConversationToMaps_Ljava_lang_String_Lcom_liveperson_messaging_model_Conversation_ == IntPtr.Zero)
				id_addConversationToMaps_Ljava_lang_String_Lcom_liveperson_messaging_model_Conversation_ = JNIEnv.GetMethodID (class_ref, "addConversationToMaps", "(Ljava/lang/String;Lcom/liveperson/messaging/model/Conversation;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addConversationToMaps_Ljava_lang_String_Lcom_liveperson_messaging_model_Conversation_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addConversationToMaps", "(Ljava/lang/String;Lcom/liveperson/messaging/model/Conversation;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addUpdateRequestInProgress_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddUpdateRequestInProgress_Ljava_lang_String_Handler ()
		{
			if (cb_addUpdateRequestInProgress_Ljava_lang_String_ == null)
				cb_addUpdateRequestInProgress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddUpdateRequestInProgress_Ljava_lang_String_);
			return cb_addUpdateRequestInProgress_Ljava_lang_String_;
		}

		static void n_AddUpdateRequestInProgress_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddUpdateRequestInProgress (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addUpdateRequestInProgress_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='addUpdateRequestInProgress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addUpdateRequestInProgress", "(Ljava/lang/String;)V", "GetAddUpdateRequestInProgress_Ljava_lang_String_Handler")]
		public virtual unsafe void AddUpdateRequestInProgress (string p0)
		{
			if (id_addUpdateRequestInProgress_Ljava_lang_String_ == IntPtr.Zero)
				id_addUpdateRequestInProgress_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addUpdateRequestInProgress", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addUpdateRequestInProgress_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addUpdateRequestInProgress", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_calculateEffectiveTTR_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJJ;
#pragma warning disable 0169
		static Delegate GetCalculateEffectiveTTR_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJJHandler ()
		{
			if (cb_calculateEffectiveTTR_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJJ == null)
				cb_calculateEffectiveTTR_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, long, long, long, long, long>) n_CalculateEffectiveTTR_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJJ);
			return cb_calculateEffectiveTTR_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJJ;
		}

		static long n_CalculateEffectiveTTR_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2, long p3, long p4, long p5)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Response.Types.TTRType p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.TTRType> (native_p1, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.CalculateEffectiveTTR (p0, p1, p2, p3, p4, p5);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_calculateEffectiveTTR_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='calculateEffectiveTTR' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.api.response.types.TTRType'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='long']]"
		[Register ("calculateEffectiveTTR", "(Ljava/lang/String;Lcom/liveperson/api/response/types/TTRType;JJJJ)J", "GetCalculateEffectiveTTR_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJJHandler")]
		public virtual unsafe long CalculateEffectiveTTR (string p0, global::Com.Liveperson.Api.Response.Types.TTRType p1, long p2, long p3, long p4, long p5)
		{
			if (id_calculateEffectiveTTR_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJJ == IntPtr.Zero)
				id_calculateEffectiveTTR_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJJ = JNIEnv.GetMethodID (class_ref, "calculateEffectiveTTR", "(Ljava/lang/String;Lcom/liveperson/api/response/types/TTRType;JJJJ)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_calculateEffectiveTTR_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJJ, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calculateEffectiveTTR", "(Ljava/lang/String;Lcom/liveperson/api/response/types/TTRType;JJJJ)J"), __args);
				return __ret;
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
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='clear' and count(parameter)=0]"
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

		static Delegate cb_clearConversations_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetClearConversations_Ljava_lang_String_Handler ()
		{
			if (cb_clearConversations_Ljava_lang_String_ == null)
				cb_clearConversations_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ClearConversations_Ljava_lang_String_);
			return cb_clearConversations_Ljava_lang_String_;
		}

		static IntPtr n_ClearConversations_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ClearConversations (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_clearConversations_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='clearConversations' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("clearConversations", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetClearConversations_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand ClearConversations (string p0)
		{
			if (id_clearConversations_Ljava_lang_String_ == IntPtr.Zero)
				id_clearConversations_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "clearConversations", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clearConversations_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearConversations", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_createDummyConversationForFirstMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ;
#pragma warning disable 0169
		static Delegate GetCreateDummyConversationForFirstMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJHandler ()
		{
			if (cb_createDummyConversationForFirstMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ == null)
				cb_createDummyConversationForFirstMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long, long>) n_CreateDummyConversationForFirstMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ);
			return cb_createDummyConversationForFirstMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ;
		}

		static void n_CreateDummyConversationForFirstMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, long p3, long p4)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.CreateDummyConversationForFirstMessage (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_createDummyConversationForFirstMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='createDummyConversationForFirstMessage' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long'] and parameter[5][@type='long']]"
		[Register ("createDummyConversationForFirstMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JJ)V", "GetCreateDummyConversationForFirstMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJHandler")]
		public virtual unsafe void CreateDummyConversationForFirstMessage (string p0, string p1, string p2, long p3, long p4)
		{
			if (id_createDummyConversationForFirstMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ == IntPtr.Zero)
				id_createDummyConversationForFirstMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ = JNIEnv.GetMethodID (class_ref, "createDummyConversationForFirstMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JJ)V");
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

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createDummyConversationForFirstMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createDummyConversationForFirstMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JJ)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_createIdleConversation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetCreateIdleConversation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JHandler ()
		{
			if (cb_createIdleConversation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J == null)
				cb_createIdleConversation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long>) n_CreateIdleConversation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J);
			return cb_createIdleConversation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J;
		}

		static void n_CreateIdleConversation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, long p3)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.CreateIdleConversation (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_createIdleConversation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='createIdleConversation' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long']]"
		[Register ("createIdleConversation", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V", "GetCreateIdleConversation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JHandler")]
		public virtual unsafe void CreateIdleConversation (string p0, string p1, string p2, long p3)
		{
			if (id_createIdleConversation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J == IntPtr.Zero)
				id_createIdleConversation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "createIdleConversation", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createIdleConversation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createIdleConversation", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_createNewCurrentConversation_Lcom_liveperson_messaging_model_ConversationData_;
#pragma warning disable 0169
		static Delegate GetCreateNewCurrentConversation_Lcom_liveperson_messaging_model_ConversationData_Handler ()
		{
			if (cb_createNewCurrentConversation_Lcom_liveperson_messaging_model_ConversationData_ == null)
				cb_createNewCurrentConversation_Lcom_liveperson_messaging_model_ConversationData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateNewCurrentConversation_Lcom_liveperson_messaging_model_ConversationData_);
			return cb_createNewCurrentConversation_Lcom_liveperson_messaging_model_ConversationData_;
		}

		static IntPtr n_CreateNewCurrentConversation_Lcom_liveperson_messaging_model_ConversationData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.ConversationData p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.ConversationData> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateNewCurrentConversation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createNewCurrentConversation_Lcom_liveperson_messaging_model_ConversationData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='createNewCurrentConversation' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.ConversationData']]"
		[Register ("createNewCurrentConversation", "(Lcom/liveperson/messaging/model/ConversationData;)Lcom/liveperson/messaging/model/Conversation;", "GetCreateNewCurrentConversation_Lcom_liveperson_messaging_model_ConversationData_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Model.Conversation CreateNewCurrentConversation (global::Com.Liveperson.Messaging.Model.ConversationData p0)
		{
			if (id_createNewCurrentConversation_Lcom_liveperson_messaging_model_ConversationData_ == IntPtr.Zero)
				id_createNewCurrentConversation_Lcom_liveperson_messaging_model_ConversationData_ = JNIEnv.GetMethodID (class_ref, "createNewCurrentConversation", "(Lcom/liveperson/messaging/model/ConversationData;)Lcom/liveperson/messaging/model/Conversation;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Liveperson.Messaging.Model.Conversation __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createNewCurrentConversation_Lcom_liveperson_messaging_model_ConversationData_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createNewCurrentConversation", "(Lcom/liveperson/messaging/model/ConversationData;)Lcom/liveperson/messaging/model/Conversation;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_createPendingConversation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetCreatePendingConversation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JHandler ()
		{
			if (cb_createPendingConversation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J == null)
				cb_createPendingConversation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long>) n_CreatePendingConversation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J);
			return cb_createPendingConversation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J;
		}

		static void n_CreatePendingConversation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, long p3)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.CreatePendingConversation (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_createPendingConversation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='createPendingConversation' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long']]"
		[Register ("createPendingConversation", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V", "GetCreatePendingConversation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JHandler")]
		public virtual unsafe void CreatePendingConversation (string p0, string p1, string p2, long p3)
		{
			if (id_createPendingConversation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J == IntPtr.Zero)
				id_createPendingConversation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "createPendingConversation", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createPendingConversation_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createPendingConversation", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_deleteTempConversationServerID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteTempConversationServerID_Ljava_lang_String_Handler ()
		{
			if (cb_deleteTempConversationServerID_Ljava_lang_String_ == null)
				cb_deleteTempConversationServerID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteTempConversationServerID_Ljava_lang_String_);
			return cb_deleteTempConversationServerID_Ljava_lang_String_;
		}

		static IntPtr n_DeleteTempConversationServerID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DeleteTempConversationServerID (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteTempConversationServerID_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='deleteTempConversationServerID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteTempConversationServerID", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetDeleteTempConversationServerID_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand DeleteTempConversationServerID (string p0)
		{
			if (id_deleteTempConversationServerID_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteTempConversationServerID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteTempConversationServerID", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deleteTempConversationServerID_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteTempConversationServerID", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_fetchPreviousConversation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFetchPreviousConversation_Ljava_lang_String_Handler ()
		{
			if (cb_fetchPreviousConversation_Ljava_lang_String_ == null)
				cb_fetchPreviousConversation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FetchPreviousConversation_Ljava_lang_String_);
			return cb_fetchPreviousConversation_Ljava_lang_String_;
		}

		static IntPtr n_FetchPreviousConversation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FetchPreviousConversation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_fetchPreviousConversation_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='fetchPreviousConversation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fetchPreviousConversation", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetFetchPreviousConversation_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand FetchPreviousConversation (string p0)
		{
			if (id_fetchPreviousConversation_Ljava_lang_String_ == IntPtr.Zero)
				id_fetchPreviousConversation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "fetchPreviousConversation", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fetchPreviousConversation_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fetchPreviousConversation", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getActiveConversation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetActiveConversation_Ljava_lang_String_Handler ()
		{
			if (cb_getActiveConversation_Ljava_lang_String_ == null)
				cb_getActiveConversation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetActiveConversation_Ljava_lang_String_);
			return cb_getActiveConversation_Ljava_lang_String_;
		}

		static IntPtr n_GetActiveConversation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetActiveConversation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getActiveConversation_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='getActiveConversation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getActiveConversation", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetGetActiveConversation_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand GetActiveConversation (string p0)
		{
			if (id_getActiveConversation_Ljava_lang_String_ == IntPtr.Zero)
				id_getActiveConversation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getActiveConversation", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getActiveConversation_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActiveConversation", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getConversation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetConversation_Ljava_lang_String_Handler ()
		{
			if (cb_getConversation_Ljava_lang_String_ == null)
				cb_getConversation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConversation_Ljava_lang_String_);
			return cb_getConversation_Ljava_lang_String_;
		}

		static IntPtr n_GetConversation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConversation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConversation_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='getConversation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getConversation", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/Conversation;", "GetGetConversation_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Model.Conversation GetConversation (string p0)
		{
			if (id_getConversation_Ljava_lang_String_ == IntPtr.Zero)
				id_getConversation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getConversation", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/Conversation;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Messaging.Model.Conversation __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversation_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversation", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/Conversation;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getConversationById_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetConversationById_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getConversationById_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getConversationById_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConversationById_Ljava_lang_String_Ljava_lang_String_);
			return cb_getConversationById_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetConversationById_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConversationById (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConversationById_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='getConversationById' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getConversationById", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetGetConversationById_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand GetConversationById (string p0, string p1)
		{
			if (id_getConversationById_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getConversationById_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getConversationById", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationById_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationById", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getConversationByServerIDFromDB_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetConversationByServerIDFromDB_Ljava_lang_String_Handler ()
		{
			if (cb_getConversationByServerIDFromDB_Ljava_lang_String_ == null)
				cb_getConversationByServerIDFromDB_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConversationByServerIDFromDB_Ljava_lang_String_);
			return cb_getConversationByServerIDFromDB_Ljava_lang_String_;
		}

		static IntPtr n_GetConversationByServerIDFromDB_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConversationByServerIDFromDB (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConversationByServerIDFromDB_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='getConversationByServerIDFromDB' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getConversationByServerIDFromDB", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetGetConversationByServerIDFromDB_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand GetConversationByServerIDFromDB (string p0)
		{
			if (id_getConversationByServerIDFromDB_Ljava_lang_String_ == IntPtr.Zero)
				id_getConversationByServerIDFromDB_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getConversationByServerIDFromDB", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationByServerIDFromDB_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationByServerIDFromDB", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getConversationFromBrandIdMap_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetConversationFromBrandIdMap_Ljava_lang_String_Handler ()
		{
			if (cb_getConversationFromBrandIdMap_Ljava_lang_String_ == null)
				cb_getConversationFromBrandIdMap_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConversationFromBrandIdMap_Ljava_lang_String_);
			return cb_getConversationFromBrandIdMap_Ljava_lang_String_;
		}

		static IntPtr n_GetConversationFromBrandIdMap_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConversationFromBrandIdMap (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConversationFromBrandIdMap_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='getConversationFromBrandIdMap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getConversationFromBrandIdMap", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/Conversation;", "GetGetConversationFromBrandIdMap_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Model.Conversation GetConversationFromBrandIdMap (string p0)
		{
			if (id_getConversationFromBrandIdMap_Ljava_lang_String_ == IntPtr.Zero)
				id_getConversationFromBrandIdMap_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getConversationFromBrandIdMap", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/Conversation;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Messaging.Model.Conversation __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationFromBrandIdMap_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationFromBrandIdMap", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/Conversation;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getConversationFromServerIdMap_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetConversationFromServerIdMap_Ljava_lang_String_Handler ()
		{
			if (cb_getConversationFromServerIdMap_Ljava_lang_String_ == null)
				cb_getConversationFromServerIdMap_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConversationFromServerIdMap_Ljava_lang_String_);
			return cb_getConversationFromServerIdMap_Ljava_lang_String_;
		}

		static IntPtr n_GetConversationFromServerIdMap_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConversationFromServerIdMap (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConversationFromServerIdMap_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='getConversationFromServerIdMap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getConversationFromServerIdMap", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/Conversation;", "GetGetConversationFromServerIdMap_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Model.Conversation GetConversationFromServerIdMap (string p0)
		{
			if (id_getConversationFromServerIdMap_Ljava_lang_String_ == IntPtr.Zero)
				id_getConversationFromServerIdMap_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getConversationFromServerIdMap", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/Conversation;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Messaging.Model.Conversation __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationFromServerIdMap_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationFromServerIdMap", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/Conversation;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getConversationFromTargetIdMap_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetConversationFromTargetIdMap_Ljava_lang_String_Handler ()
		{
			if (cb_getConversationFromTargetIdMap_Ljava_lang_String_ == null)
				cb_getConversationFromTargetIdMap_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConversationFromTargetIdMap_Ljava_lang_String_);
			return cb_getConversationFromTargetIdMap_Ljava_lang_String_;
		}

		static IntPtr n_GetConversationFromTargetIdMap_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConversationFromTargetIdMap (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConversationFromTargetIdMap_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='getConversationFromTargetIdMap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getConversationFromTargetIdMap", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/Conversation;", "GetGetConversationFromTargetIdMap_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Model.Conversation GetConversationFromTargetIdMap (string p0)
		{
			if (id_getConversationFromTargetIdMap_Ljava_lang_String_ == IntPtr.Zero)
				id_getConversationFromTargetIdMap_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getConversationFromTargetIdMap", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/Conversation;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Messaging.Model.Conversation __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationFromTargetIdMap_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationFromTargetIdMap", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/Conversation;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getNewestClosedConversation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetNewestClosedConversation_Ljava_lang_String_Handler ()
		{
			if (cb_getNewestClosedConversation_Ljava_lang_String_ == null)
				cb_getNewestClosedConversation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetNewestClosedConversation_Ljava_lang_String_);
			return cb_getNewestClosedConversation_Ljava_lang_String_;
		}

		static IntPtr n_GetNewestClosedConversation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetNewestClosedConversation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getNewestClosedConversation_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='getNewestClosedConversation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getNewestClosedConversation", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/Conversation;", "GetGetNewestClosedConversation_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Model.Conversation GetNewestClosedConversation (string p0)
		{
			if (id_getNewestClosedConversation_Ljava_lang_String_ == IntPtr.Zero)
				id_getNewestClosedConversation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getNewestClosedConversation", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/Conversation;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Messaging.Model.Conversation __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNewestClosedConversation_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNewestClosedConversation", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/Conversation;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getNotUpdatedConversations_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetNotUpdatedConversations_Ljava_lang_String_Handler ()
		{
			if (cb_getNotUpdatedConversations_Ljava_lang_String_ == null)
				cb_getNotUpdatedConversations_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetNotUpdatedConversations_Ljava_lang_String_);
			return cb_getNotUpdatedConversations_Ljava_lang_String_;
		}

		static IntPtr n_GetNotUpdatedConversations_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetNotUpdatedConversations (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getNotUpdatedConversations_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='getNotUpdatedConversations' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getNotUpdatedConversations", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetGetNotUpdatedConversations_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand GetNotUpdatedConversations (string p0)
		{
			if (id_getNotUpdatedConversations_Ljava_lang_String_ == IntPtr.Zero)
				id_getNotUpdatedConversations_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getNotUpdatedConversations", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNotUpdatedConversations_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNotUpdatedConversations", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isConversationActive_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsConversationActive_Ljava_lang_String_Handler ()
		{
			if (cb_isConversationActive_Ljava_lang_String_ == null)
				cb_isConversationActive_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsConversationActive_Ljava_lang_String_);
			return cb_isConversationActive_Ljava_lang_String_;
		}

		static bool n_IsConversationActive_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsConversationActive (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isConversationActive_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='isConversationActive' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isConversationActive", "(Ljava/lang/String;)Z", "GetIsConversationActive_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsConversationActive (string p0)
		{
			if (id_isConversationActive_Ljava_lang_String_ == IntPtr.Zero)
				id_isConversationActive_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isConversationActive", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConversationActive_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConversationActive", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isMoreConversationAvailableToLoad_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsMoreConversationAvailableToLoad_Ljava_lang_String_Handler ()
		{
			if (cb_isMoreConversationAvailableToLoad_Ljava_lang_String_ == null)
				cb_isMoreConversationAvailableToLoad_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsMoreConversationAvailableToLoad_Ljava_lang_String_);
			return cb_isMoreConversationAvailableToLoad_Ljava_lang_String_;
		}

		static bool n_IsMoreConversationAvailableToLoad_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsMoreConversationAvailableToLoad (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isMoreConversationAvailableToLoad_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='isMoreConversationAvailableToLoad' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isMoreConversationAvailableToLoad", "(Ljava/lang/String;)Z", "GetIsMoreConversationAvailableToLoad_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsMoreConversationAvailableToLoad (string p0)
		{
			if (id_isMoreConversationAvailableToLoad_Ljava_lang_String_ == IntPtr.Zero)
				id_isMoreConversationAvailableToLoad_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isMoreConversationAvailableToLoad", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMoreConversationAvailableToLoad_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMoreConversationAvailableToLoad", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_loadConversationForBrand_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadConversationForBrand_Ljava_lang_String_Handler ()
		{
			if (cb_loadConversationForBrand_Ljava_lang_String_ == null)
				cb_loadConversationForBrand_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadConversationForBrand_Ljava_lang_String_);
			return cb_loadConversationForBrand_Ljava_lang_String_;
		}

		static void n_LoadConversationForBrand_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadConversationForBrand (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadConversationForBrand_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='loadConversationForBrand' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadConversationForBrand", "(Ljava/lang/String;)V", "GetLoadConversationForBrand_Ljava_lang_String_Handler")]
		public virtual unsafe void LoadConversationForBrand (string p0)
		{
			if (id_loadConversationForBrand_Ljava_lang_String_ == IntPtr.Zero)
				id_loadConversationForBrand_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadConversationForBrand", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadConversationForBrand_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadConversationForBrand", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_markAllPendingConversationsAsFailed_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMarkAllPendingConversationsAsFailed_Ljava_lang_String_Handler ()
		{
			if (cb_markAllPendingConversationsAsFailed_Ljava_lang_String_ == null)
				cb_markAllPendingConversationsAsFailed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MarkAllPendingConversationsAsFailed_Ljava_lang_String_);
			return cb_markAllPendingConversationsAsFailed_Ljava_lang_String_;
		}

		static void n_MarkAllPendingConversationsAsFailed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MarkAllPendingConversationsAsFailed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_markAllPendingConversationsAsFailed_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='markAllPendingConversationsAsFailed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("markAllPendingConversationsAsFailed", "(Ljava/lang/String;)V", "GetMarkAllPendingConversationsAsFailed_Ljava_lang_String_Handler")]
		public virtual unsafe void MarkAllPendingConversationsAsFailed (string p0)
		{
			if (id_markAllPendingConversationsAsFailed_Ljava_lang_String_ == IntPtr.Zero)
				id_markAllPendingConversationsAsFailed_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "markAllPendingConversationsAsFailed", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_markAllPendingConversationsAsFailed_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "markAllPendingConversationsAsFailed", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_notifyClosedConversationFromDB_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNotifyClosedConversationFromDB_Ljava_lang_String_Handler ()
		{
			if (cb_notifyClosedConversationFromDB_Ljava_lang_String_ == null)
				cb_notifyClosedConversationFromDB_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NotifyClosedConversationFromDB_Ljava_lang_String_);
			return cb_notifyClosedConversationFromDB_Ljava_lang_String_;
		}

		static void n_NotifyClosedConversationFromDB_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotifyClosedConversationFromDB (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifyClosedConversationFromDB_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='notifyClosedConversationFromDB' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("notifyClosedConversationFromDB", "(Ljava/lang/String;)V", "GetNotifyClosedConversationFromDB_Ljava_lang_String_Handler")]
		public virtual unsafe void NotifyClosedConversationFromDB (string p0)
		{
			if (id_notifyClosedConversationFromDB_Ljava_lang_String_ == IntPtr.Zero)
				id_notifyClosedConversationFromDB_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "notifyClosedConversationFromDB", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyClosedConversationFromDB_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyClosedConversationFromDB", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_notifyOffHoursStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNotifyOffHoursStatus_Ljava_lang_String_Handler ()
		{
			if (cb_notifyOffHoursStatus_Ljava_lang_String_ == null)
				cb_notifyOffHoursStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NotifyOffHoursStatus_Ljava_lang_String_);
			return cb_notifyOffHoursStatus_Ljava_lang_String_;
		}

		static void n_NotifyOffHoursStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotifyOffHoursStatus (p0);
		}
#pragma warning restore 0169

		static IntPtr id_notifyOffHoursStatus_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='notifyOffHoursStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("notifyOffHoursStatus", "(Ljava/lang/String;)V", "GetNotifyOffHoursStatus_Ljava_lang_String_Handler")]
		public virtual unsafe void NotifyOffHoursStatus (string p0)
		{
			if (id_notifyOffHoursStatus_Ljava_lang_String_ == IntPtr.Zero)
				id_notifyOffHoursStatus_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "notifyOffHoursStatus", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyOffHoursStatus_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyOffHoursStatus", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_removeUpdateRequestInProgress_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveUpdateRequestInProgress_Ljava_lang_String_Handler ()
		{
			if (cb_removeUpdateRequestInProgress_Ljava_lang_String_ == null)
				cb_removeUpdateRequestInProgress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveUpdateRequestInProgress_Ljava_lang_String_);
			return cb_removeUpdateRequestInProgress_Ljava_lang_String_;
		}

		static void n_RemoveUpdateRequestInProgress_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveUpdateRequestInProgress (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeUpdateRequestInProgress_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='removeUpdateRequestInProgress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeUpdateRequestInProgress", "(Ljava/lang/String;)V", "GetRemoveUpdateRequestInProgress_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveUpdateRequestInProgress (string p0)
		{
			if (id_removeUpdateRequestInProgress_Ljava_lang_String_ == IntPtr.Zero)
				id_removeUpdateRequestInProgress_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeUpdateRequestInProgress", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeUpdateRequestInProgress_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeUpdateRequestInProgress", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_resetEffectiveTTR_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetResetEffectiveTTR_Ljava_lang_String_Handler ()
		{
			if (cb_resetEffectiveTTR_Ljava_lang_String_ == null)
				cb_resetEffectiveTTR_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ResetEffectiveTTR_Ljava_lang_String_);
			return cb_resetEffectiveTTR_Ljava_lang_String_;
		}

		static void n_ResetEffectiveTTR_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResetEffectiveTTR (p0);
		}
#pragma warning restore 0169

		static IntPtr id_resetEffectiveTTR_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='resetEffectiveTTR' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("resetEffectiveTTR", "(Ljava/lang/String;)V", "GetResetEffectiveTTR_Ljava_lang_String_Handler")]
		public virtual unsafe void ResetEffectiveTTR (string p0)
		{
			if (id_resetEffectiveTTR_Ljava_lang_String_ == IntPtr.Zero)
				id_resetEffectiveTTR_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "resetEffectiveTTR", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetEffectiveTTR_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetEffectiveTTR", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_saveMessagesResult_Ljava_lang_String_Ljava_util_ArrayList_ZZLcom_liveperson_infra_ICallback_;
#pragma warning disable 0169
		static Delegate GetSaveMessagesResult_Ljava_lang_String_Ljava_util_ArrayList_ZZLcom_liveperson_infra_ICallback_Handler ()
		{
			if (cb_saveMessagesResult_Ljava_lang_String_Ljava_util_ArrayList_ZZLcom_liveperson_infra_ICallback_ == null)
				cb_saveMessagesResult_Ljava_lang_String_Ljava_util_ArrayList_ZZLcom_liveperson_infra_ICallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool, bool, IntPtr>) n_SaveMessagesResult_Ljava_lang_String_Ljava_util_ArrayList_ZZLcom_liveperson_infra_ICallback_);
			return cb_saveMessagesResult_Ljava_lang_String_Ljava_util_ArrayList_ZZLcom_liveperson_infra_ICallback_;
		}

		static void n_SaveMessagesResult_Ljava_lang_String_Ljava_util_ArrayList_ZZLcom_liveperson_infra_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2, bool p3, IntPtr native_p4)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Com.Liveperson.Api.Response.Events.ContentEventNotification>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ICallback p4 = (global::Com.Liveperson.Infra.ICallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.SaveMessagesResult (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_saveMessagesResult_Ljava_lang_String_Ljava_util_ArrayList_ZZLcom_liveperson_infra_ICallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='saveMessagesResult' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;com.liveperson.api.response.events.ContentEventNotification&gt;'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='com.liveperson.infra.ICallback&lt;com.liveperson.messaging.model.Conversation, java.lang.Exception&gt;']]"
		[Register ("saveMessagesResult", "(Ljava/lang/String;Ljava/util/ArrayList;ZZLcom/liveperson/infra/ICallback;)V", "GetSaveMessagesResult_Ljava_lang_String_Ljava_util_ArrayList_ZZLcom_liveperson_infra_ICallback_Handler")]
		public virtual unsafe void SaveMessagesResult (string p0, global::System.Collections.Generic.IList<global::Com.Liveperson.Api.Response.Events.ContentEventNotification> p1, bool p2, bool p3, global::Com.Liveperson.Infra.ICallback p4)
		{
			if (id_saveMessagesResult_Ljava_lang_String_Ljava_util_ArrayList_ZZLcom_liveperson_infra_ICallback_ == IntPtr.Zero)
				id_saveMessagesResult_Ljava_lang_String_Ljava_util_ArrayList_ZZLcom_liveperson_infra_ICallback_ = JNIEnv.GetMethodID (class_ref, "saveMessagesResult", "(Ljava/lang/String;Ljava/util/ArrayList;ZZLcom/liveperson/infra/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Liveperson.Api.Response.Events.ContentEventNotification>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveMessagesResult_Ljava_lang_String_Ljava_util_ArrayList_ZZLcom_liveperson_infra_ICallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveMessagesResult", "(Ljava/lang/String;Ljava/util/ArrayList;ZZLcom/liveperson/infra/ICallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_sendConversationClosedIntent_Lcom_liveperson_messaging_model_Conversation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='sendConversationClosedIntent' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.Conversation']]"
		[Register ("sendConversationClosedIntent", "(Lcom/liveperson/messaging/model/Conversation;)V", "")]
		protected static unsafe void SendConversationClosedIntent (global::Com.Liveperson.Messaging.Model.Conversation p0)
		{
			if (id_sendConversationClosedIntent_Lcom_liveperson_messaging_model_Conversation_ == IntPtr.Zero)
				id_sendConversationClosedIntent_Lcom_liveperson_messaging_model_Conversation_ = JNIEnv.GetStaticMethodID (class_ref, "sendConversationClosedIntent", "(Lcom/liveperson/messaging/model/Conversation;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendConversationClosedIntent_Lcom_liveperson_messaging_model_Conversation_, __args);
			} finally {
			}
		}

		static IntPtr id_sendUpdateCSATConversationIntent_Lcom_liveperson_messaging_model_Conversation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='sendUpdateCSATConversationIntent' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.Conversation']]"
		[Register ("sendUpdateCSATConversationIntent", "(Lcom/liveperson/messaging/model/Conversation;)V", "")]
		protected static unsafe void SendUpdateCSATConversationIntent (global::Com.Liveperson.Messaging.Model.Conversation p0)
		{
			if (id_sendUpdateCSATConversationIntent_Lcom_liveperson_messaging_model_Conversation_ == IntPtr.Zero)
				id_sendUpdateCSATConversationIntent_Lcom_liveperson_messaging_model_Conversation_ = JNIEnv.GetStaticMethodID (class_ref, "sendUpdateCSATConversationIntent", "(Lcom/liveperson/messaging/model/Conversation;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendUpdateCSATConversationIntent_Lcom_liveperson_messaging_model_Conversation_, __args);
			} finally {
			}
		}

		static IntPtr id_sendUpdateNewConversationIntent_Lcom_liveperson_messaging_model_Conversation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='sendUpdateNewConversationIntent' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.Conversation']]"
		[Register ("sendUpdateNewConversationIntent", "(Lcom/liveperson/messaging/model/Conversation;)V", "")]
		protected static unsafe void SendUpdateNewConversationIntent (global::Com.Liveperson.Messaging.Model.Conversation p0)
		{
			if (id_sendUpdateNewConversationIntent_Lcom_liveperson_messaging_model_Conversation_ == IntPtr.Zero)
				id_sendUpdateNewConversationIntent_Lcom_liveperson_messaging_model_Conversation_ = JNIEnv.GetStaticMethodID (class_ref, "sendUpdateNewConversationIntent", "(Lcom/liveperson/messaging/model/Conversation;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendUpdateNewConversationIntent_Lcom_liveperson_messaging_model_Conversation_, __args);
			} finally {
			}
		}

		static IntPtr id_sendUpdateStateIntent_Lcom_liveperson_messaging_model_Conversation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='sendUpdateStateIntent' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.Conversation']]"
		[Register ("sendUpdateStateIntent", "(Lcom/liveperson/messaging/model/Conversation;)V", "")]
		protected static unsafe void SendUpdateStateIntent (global::Com.Liveperson.Messaging.Model.Conversation p0)
		{
			if (id_sendUpdateStateIntent_Lcom_liveperson_messaging_model_Conversation_ == IntPtr.Zero)
				id_sendUpdateStateIntent_Lcom_liveperson_messaging_model_Conversation_ = JNIEnv.GetStaticMethodID (class_ref, "sendUpdateStateIntent", "(Lcom/liveperson/messaging/model/Conversation;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendUpdateStateIntent_Lcom_liveperson_messaging_model_Conversation_, __args);
			} finally {
			}
		}

		static IntPtr id_sendUpdateUnreadMsgIntent_Lcom_liveperson_messaging_model_Conversation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='sendUpdateUnreadMsgIntent' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.Conversation']]"
		[Register ("sendUpdateUnreadMsgIntent", "(Lcom/liveperson/messaging/model/Conversation;)V", "")]
		protected static unsafe void SendUpdateUnreadMsgIntent (global::Com.Liveperson.Messaging.Model.Conversation p0)
		{
			if (id_sendUpdateUnreadMsgIntent_Lcom_liveperson_messaging_model_Conversation_ == IntPtr.Zero)
				id_sendUpdateUnreadMsgIntent_Lcom_liveperson_messaging_model_Conversation_ = JNIEnv.GetStaticMethodID (class_ref, "sendUpdateUnreadMsgIntent", "(Lcom/liveperson/messaging/model/Conversation;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendUpdateUnreadMsgIntent_Lcom_liveperson_messaging_model_Conversation_, __args);
			} finally {
			}
		}

		static Delegate cb_setUpdateRequestInProgress_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetUpdateRequestInProgress_Ljava_lang_String_IHandler ()
		{
			if (cb_setUpdateRequestInProgress_Ljava_lang_String_I == null)
				cb_setUpdateRequestInProgress_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetUpdateRequestInProgress_Ljava_lang_String_I);
			return cb_setUpdateRequestInProgress_Ljava_lang_String_I;
		}

		static void n_SetUpdateRequestInProgress_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetUpdateRequestInProgress (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setUpdateRequestInProgress_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='setUpdateRequestInProgress' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("setUpdateRequestInProgress", "(Ljava/lang/String;I)V", "GetSetUpdateRequestInProgress_Ljava_lang_String_IHandler")]
		public virtual unsafe void SetUpdateRequestInProgress (string p0, int p1)
		{
			if (id_setUpdateRequestInProgress_Ljava_lang_String_I == IntPtr.Zero)
				id_setUpdateRequestInProgress_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setUpdateRequestInProgress", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUpdateRequestInProgress_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUpdateRequestInProgress", "(Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_showTTR_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShowTTR_Ljava_lang_String_Handler ()
		{
			if (cb_showTTR_Ljava_lang_String_ == null)
				cb_showTTR_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowTTR_Ljava_lang_String_);
			return cb_showTTR_Ljava_lang_String_;
		}

		static void n_ShowTTR_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShowTTR (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showTTR_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='showTTR' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("showTTR", "(Ljava/lang/String;)V", "GetShowTTR_Ljava_lang_String_Handler")]
		public virtual unsafe void ShowTTR (string p0)
		{
			if (id_showTTR_Ljava_lang_String_ == IntPtr.Zero)
				id_showTTR_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "showTTR", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showTTR_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showTTR", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShutDown ();
		}
#pragma warning restore 0169

		static IntPtr id_shutDown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='shutDown' and count(parameter)=0]"
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

		static Delegate cb_updateCSAT_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateCSAT_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_updateCSAT_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_updateCSAT_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateCSAT_Ljava_lang_String_Ljava_lang_String_);
			return cb_updateCSAT_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_UpdateCSAT_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateCSAT (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateCSAT_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='updateCSAT' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateCSAT", "(Ljava/lang/String;Ljava/lang/String;)V", "GetUpdateCSAT_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateCSAT (string p0, string p1)
		{
			if (id_updateCSAT_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_updateCSAT_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateCSAT", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateCSAT_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateCSAT", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateClosedConversation_Lcom_liveperson_messaging_model_ConversationData_Z;
#pragma warning disable 0169
		static Delegate GetUpdateClosedConversation_Lcom_liveperson_messaging_model_ConversationData_ZHandler ()
		{
			if (cb_updateClosedConversation_Lcom_liveperson_messaging_model_ConversationData_Z == null)
				cb_updateClosedConversation_Lcom_liveperson_messaging_model_ConversationData_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_UpdateClosedConversation_Lcom_liveperson_messaging_model_ConversationData_Z);
			return cb_updateClosedConversation_Lcom_liveperson_messaging_model_ConversationData_Z;
		}

		static IntPtr n_UpdateClosedConversation_Lcom_liveperson_messaging_model_ConversationData_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.ConversationData p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.ConversationData> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UpdateClosedConversation (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateClosedConversation_Lcom_liveperson_messaging_model_ConversationData_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='updateClosedConversation' and count(parameter)=2 and parameter[1][@type='com.liveperson.messaging.model.ConversationData'] and parameter[2][@type='boolean']]"
		[Register ("updateClosedConversation", "(Lcom/liveperson/messaging/model/ConversationData;Z)Lcom/liveperson/infra/database/DataBaseCommand;", "GetUpdateClosedConversation_Lcom_liveperson_messaging_model_ConversationData_ZHandler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand UpdateClosedConversation (global::Com.Liveperson.Messaging.Model.ConversationData p0, bool p1)
		{
			if (id_updateClosedConversation_Lcom_liveperson_messaging_model_ConversationData_Z == IntPtr.Zero)
				id_updateClosedConversation_Lcom_liveperson_messaging_model_ConversationData_Z = JNIEnv.GetMethodID (class_ref, "updateClosedConversation", "(Lcom/liveperson/messaging/model/ConversationData;Z)Lcom/liveperson/infra/database/DataBaseCommand;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_updateClosedConversation_Lcom_liveperson_messaging_model_ConversationData_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateClosedConversation", "(Lcom/liveperson/messaging/model/ConversationData;Z)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_updateConversationState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_ConversationState_;
#pragma warning disable 0169
		static Delegate GetUpdateConversationState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_ConversationState_Handler ()
		{
			if (cb_updateConversationState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_ConversationState_ == null)
				cb_updateConversationState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_ConversationState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateConversationState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_ConversationState_);
			return cb_updateConversationState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_ConversationState_;
		}

		static void n_UpdateConversationState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_ConversationState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Response.Types.ConversationState p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.ConversationState> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.UpdateConversationState (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_updateConversationState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_ConversationState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='updateConversationState' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.api.response.types.ConversationState']]"
		[Register ("updateConversationState", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/types/ConversationState;)V", "GetUpdateConversationState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_ConversationState_Handler")]
		public virtual unsafe void UpdateConversationState (string p0, string p1, global::Com.Liveperson.Api.Response.Types.ConversationState p2)
		{
			if (id_updateConversationState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_ConversationState_ == IntPtr.Zero)
				id_updateConversationState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_ConversationState_ = JNIEnv.GetMethodID (class_ref, "updateConversationState", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/types/ConversationState;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateConversationState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_ConversationState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateConversationState", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/types/ConversationState;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateCurrentConversation_Lcom_liveperson_messaging_model_ConversationData_;
#pragma warning disable 0169
		static Delegate GetUpdateCurrentConversation_Lcom_liveperson_messaging_model_ConversationData_Handler ()
		{
			if (cb_updateCurrentConversation_Lcom_liveperson_messaging_model_ConversationData_ == null)
				cb_updateCurrentConversation_Lcom_liveperson_messaging_model_ConversationData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateCurrentConversation_Lcom_liveperson_messaging_model_ConversationData_);
			return cb_updateCurrentConversation_Lcom_liveperson_messaging_model_ConversationData_;
		}

		static void n_UpdateCurrentConversation_Lcom_liveperson_messaging_model_ConversationData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.ConversationData p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.ConversationData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateCurrentConversation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateCurrentConversation_Lcom_liveperson_messaging_model_ConversationData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='updateCurrentConversation' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.ConversationData']]"
		[Register ("updateCurrentConversation", "(Lcom/liveperson/messaging/model/ConversationData;)V", "GetUpdateCurrentConversation_Lcom_liveperson_messaging_model_ConversationData_Handler")]
		public virtual unsafe void UpdateCurrentConversation (global::Com.Liveperson.Messaging.Model.ConversationData p0)
		{
			if (id_updateCurrentConversation_Lcom_liveperson_messaging_model_ConversationData_ == IntPtr.Zero)
				id_updateCurrentConversation_Lcom_liveperson_messaging_model_ConversationData_ = JNIEnv.GetMethodID (class_ref, "updateCurrentConversation", "(Lcom/liveperson/messaging/model/ConversationData;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateCurrentConversation_Lcom_liveperson_messaging_model_ConversationData_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateCurrentConversation", "(Lcom/liveperson/messaging/model/ConversationData;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateCurrentConversationServerID_Ljava_lang_String_Lcom_liveperson_messaging_model_ConversationData_;
#pragma warning disable 0169
		static Delegate GetUpdateCurrentConversationServerID_Ljava_lang_String_Lcom_liveperson_messaging_model_ConversationData_Handler ()
		{
			if (cb_updateCurrentConversationServerID_Ljava_lang_String_Lcom_liveperson_messaging_model_ConversationData_ == null)
				cb_updateCurrentConversationServerID_Ljava_lang_String_Lcom_liveperson_messaging_model_ConversationData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateCurrentConversationServerID_Ljava_lang_String_Lcom_liveperson_messaging_model_ConversationData_);
			return cb_updateCurrentConversationServerID_Ljava_lang_String_Lcom_liveperson_messaging_model_ConversationData_;
		}

		static IntPtr n_UpdateCurrentConversationServerID_Ljava_lang_String_Lcom_liveperson_messaging_model_ConversationData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.ConversationData p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.ConversationData> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UpdateCurrentConversationServerID (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateCurrentConversationServerID_Ljava_lang_String_Lcom_liveperson_messaging_model_ConversationData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='updateCurrentConversationServerID' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.messaging.model.ConversationData']]"
		[Register ("updateCurrentConversationServerID", "(Ljava/lang/String;Lcom/liveperson/messaging/model/ConversationData;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetUpdateCurrentConversationServerID_Ljava_lang_String_Lcom_liveperson_messaging_model_ConversationData_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand UpdateCurrentConversationServerID (string p0, global::Com.Liveperson.Messaging.Model.ConversationData p1)
		{
			if (id_updateCurrentConversationServerID_Ljava_lang_String_Lcom_liveperson_messaging_model_ConversationData_ == IntPtr.Zero)
				id_updateCurrentConversationServerID_Ljava_lang_String_Lcom_liveperson_messaging_model_ConversationData_ = JNIEnv.GetMethodID (class_ref, "updateCurrentConversationServerID", "(Ljava/lang/String;Lcom/liveperson/messaging/model/ConversationData;)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_updateCurrentConversationServerID_Ljava_lang_String_Lcom_liveperson_messaging_model_ConversationData_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateCurrentConversationServerID", "(Ljava/lang/String;Lcom/liveperson/messaging/model/ConversationData;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateLastServerSequenceByBrandId_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetUpdateLastServerSequenceByBrandId_Ljava_lang_String_IHandler ()
		{
			if (cb_updateLastServerSequenceByBrandId_Ljava_lang_String_I == null)
				cb_updateLastServerSequenceByBrandId_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_UpdateLastServerSequenceByBrandId_Ljava_lang_String_I);
			return cb_updateLastServerSequenceByBrandId_Ljava_lang_String_I;
		}

		static void n_UpdateLastServerSequenceByBrandId_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateLastServerSequenceByBrandId (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateLastServerSequenceByBrandId_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='updateLastServerSequenceByBrandId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("updateLastServerSequenceByBrandId", "(Ljava/lang/String;I)V", "GetUpdateLastServerSequenceByBrandId_Ljava_lang_String_IHandler")]
		public virtual unsafe void UpdateLastServerSequenceByBrandId (string p0, int p1)
		{
			if (id_updateLastServerSequenceByBrandId_Ljava_lang_String_I == IntPtr.Zero)
				id_updateLastServerSequenceByBrandId_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "updateLastServerSequenceByBrandId", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateLastServerSequenceByBrandId_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateLastServerSequenceByBrandId", "(Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateLastServerSequenceByConvId_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetUpdateLastServerSequenceByConvId_Ljava_lang_String_IHandler ()
		{
			if (cb_updateLastServerSequenceByConvId_Ljava_lang_String_I == null)
				cb_updateLastServerSequenceByConvId_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_UpdateLastServerSequenceByConvId_Ljava_lang_String_I);
			return cb_updateLastServerSequenceByConvId_Ljava_lang_String_I;
		}

		static void n_UpdateLastServerSequenceByConvId_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateLastServerSequenceByConvId (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateLastServerSequenceByConvId_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='updateLastServerSequenceByConvId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("updateLastServerSequenceByConvId", "(Ljava/lang/String;I)V", "GetUpdateLastServerSequenceByConvId_Ljava_lang_String_IHandler")]
		public virtual unsafe void UpdateLastServerSequenceByConvId (string p0, int p1)
		{
			if (id_updateLastServerSequenceByConvId_Ljava_lang_String_I == IntPtr.Zero)
				id_updateLastServerSequenceByConvId_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "updateLastServerSequenceByConvId", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateLastServerSequenceByConvId_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateLastServerSequenceByConvId", "(Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateLastServerSequenceByConvId_Ljava_lang_String_IIZ;
#pragma warning disable 0169
		static Delegate GetUpdateLastServerSequenceByConvId_Ljava_lang_String_IIZHandler ()
		{
			if (cb_updateLastServerSequenceByConvId_Ljava_lang_String_IIZ == null)
				cb_updateLastServerSequenceByConvId_Ljava_lang_String_IIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool, IntPtr>) n_UpdateLastServerSequenceByConvId_Ljava_lang_String_IIZ);
			return cb_updateLastServerSequenceByConvId_Ljava_lang_String_IIZ;
		}

		static IntPtr n_UpdateLastServerSequenceByConvId_Ljava_lang_String_IIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, bool p3)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UpdateLastServerSequenceByConvId (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateLastServerSequenceByConvId_Ljava_lang_String_IIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='updateLastServerSequenceByConvId' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("updateLastServerSequenceByConvId", "(Ljava/lang/String;IIZ)Lcom/liveperson/infra/database/DataBaseCommand;", "GetUpdateLastServerSequenceByConvId_Ljava_lang_String_IIZHandler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand UpdateLastServerSequenceByConvId (string p0, int p1, int p2, bool p3)
		{
			if (id_updateLastServerSequenceByConvId_Ljava_lang_String_IIZ == IntPtr.Zero)
				id_updateLastServerSequenceByConvId_Ljava_lang_String_IIZ = JNIEnv.GetMethodID (class_ref, "updateLastServerSequenceByConvId", "(Ljava/lang/String;IIZ)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_updateLastServerSequenceByConvId_Ljava_lang_String_IIZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateLastServerSequenceByConvId", "(Ljava/lang/String;IIZ)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateTTRType_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJ;
#pragma warning disable 0169
		static Delegate GetUpdateTTRType_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJHandler ()
		{
			if (cb_updateTTRType_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJ == null)
				cb_updateTTRType_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long, long, long>) n_UpdateTTRType_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJ);
			return cb_updateTTRType_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJ;
		}

		static void n_UpdateTTRType_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2, long p3, long p4)
		{
			global::Com.Liveperson.Messaging.Model.AmsConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Response.Types.TTRType p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.TTRType> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateTTRType (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_updateTTRType_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConversations']/method[@name='updateTTRType' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.api.response.types.TTRType'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='long']]"
		[Register ("updateTTRType", "(Ljava/lang/String;Lcom/liveperson/api/response/types/TTRType;JJJ)V", "GetUpdateTTRType_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJHandler")]
		public virtual unsafe void UpdateTTRType (string p0, global::Com.Liveperson.Api.Response.Types.TTRType p1, long p2, long p3, long p4)
		{
			if (id_updateTTRType_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJ == IntPtr.Zero)
				id_updateTTRType_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJ = JNIEnv.GetMethodID (class_ref, "updateTTRType", "(Ljava/lang/String;Lcom/liveperson/api/response/types/TTRType;JJJ)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateTTRType_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateTTRType", "(Ljava/lang/String;Lcom/liveperson/api/response/types/TTRType;JJJ)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
