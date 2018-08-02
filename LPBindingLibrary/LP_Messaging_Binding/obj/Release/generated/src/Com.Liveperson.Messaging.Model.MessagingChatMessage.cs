using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/model/MessagingChatMessage", DoNotGenerateAcw=true)]
	public partial class MessagingChatMessage : global::Com.Liveperson.Infra.Model.Message {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage']/field[@name='EXTRA_CONVERSATION_ID']"
		[Register ("EXTRA_CONVERSATION_ID")]
		public const string ExtraConversationId = (string) "EXTRA_CONVERSATION_ID";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage']/field[@name='EXTRA_MESSAGE_STATE']"
		[Register ("EXTRA_MESSAGE_STATE")]
		public const string ExtraMessageState = (string) "EXTRA_MESSAGE_STATE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage']/field[@name='EXTRA_SERVER_SEQUENCE']"
		[Register ("EXTRA_SERVER_SEQUENCE")]
		public const string ExtraServerSequence = (string) "EXTRA_SERVER_SEQUENCE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "MessagingChatMessage";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageState']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/model/MessagingChatMessage$MessageState", DoNotGenerateAcw=true)]
		public sealed partial class MessageState : global::Java.Lang.Enum {


			static IntPtr ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageState']/field[@name='ERROR']"
			[Register ("ERROR")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState Error {
				get {
					if (ERROR_jfieldId == IntPtr.Zero)
						ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr EXPIRED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageState']/field[@name='EXPIRED']"
			[Register ("EXPIRED")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState Expired {
				get {
					if (EXPIRED_jfieldId == IntPtr.Zero)
						EXPIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXPIRED", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXPIRED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PENDING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageState']/field[@name='PENDING']"
			[Register ("PENDING")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState Pending {
				get {
					if (PENDING_jfieldId == IntPtr.Zero)
						PENDING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PENDING", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PENDING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr QUEUED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageState']/field[@name='QUEUED']"
			[Register ("QUEUED")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState Queued {
				get {
					if (QUEUED_jfieldId == IntPtr.Zero)
						QUEUED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QUEUED", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, QUEUED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr READ_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageState']/field[@name='READ']"
			[Register ("READ")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState Read {
				get {
					if (READ_jfieldId == IntPtr.Zero)
						READ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "READ", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, READ_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RECEIVED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageState']/field[@name='RECEIVED']"
			[Register ("RECEIVED")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState Received {
				get {
					if (RECEIVED_jfieldId == IntPtr.Zero)
						RECEIVED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RECEIVED", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RECEIVED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageState']/field[@name='SENT']"
			[Register ("SENT")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState Sent {
				get {
					if (SENT_jfieldId == IntPtr.Zero)
						SENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SENT", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SUBMITTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageState']/field[@name='SUBMITTED']"
			[Register ("SUBMITTED")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState Submitted {
				get {
					if (SUBMITTED_jfieldId == IntPtr.Zero)
						SUBMITTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUBMITTED", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUBMITTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIEWED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageState']/field[@name='VIEWED']"
			[Register ("VIEWED")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState Viewed {
				get {
					if (VIEWED_jfieldId == IntPtr.Zero)
						VIEWED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIEWED", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIEWED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/model/MessagingChatMessage$MessageState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MessageState); }
			}

			internal MessageState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_isReceivedMessageNotRead;
			public unsafe bool IsReceivedMessageNotRead {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageState']/method[@name='isReceivedMessageNotRead' and count(parameter)=0]"
				[Register ("isReceivedMessageNotRead", "()Z", "GetIsReceivedMessageNotReadHandler")]
				get {
					if (id_isReceivedMessageNotRead == IntPtr.Zero)
						id_isReceivedMessageNotRead = JNIEnv.GetMethodID (class_ref, "isReceivedMessageNotRead", "()Z");
					try {
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isReceivedMessageNotRead);
					} finally {
					}
				}
			}

			static IntPtr id_validChange_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageState']/method[@name='validChange' and count(parameter)=2 and parameter[1][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageState'] and parameter[2][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageState']]"
			[Register ("validChange", "(Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;)Z", "")]
			public static unsafe bool ValidChange (global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState p0, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState p1)
			{
				if (id_validChange_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ == IntPtr.Zero)
					id_validChange_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ = JNIEnv.GetStaticMethodID (class_ref, "validChange", "(Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;)Z");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_validChange_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_, __args);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;", "")]
			public static unsafe global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;", "")]
			public static unsafe global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;");
				try {
					return (global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/model/MessagingChatMessage$MessageType", DoNotGenerateAcw=true)]
		public sealed partial class MessageType : global::Java.Lang.Enum {


			static IntPtr AGENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/field[@name='AGENT']"
			[Register ("AGENT")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType Agent {
				get {
					if (AGENT_jfieldId == IntPtr.Zero)
						AGENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AGENT", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AGENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AGENT_FORM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/field[@name='AGENT_FORM']"
			[Register ("AGENT_FORM")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType AgentForm {
				get {
					if (AGENT_FORM_jfieldId == IntPtr.Zero)
						AGENT_FORM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AGENT_FORM", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AGENT_FORM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AGENT_IS_TYPING_INDICATOR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/field[@name='AGENT_IS_TYPING_INDICATOR']"
			[Register ("AGENT_IS_TYPING_INDICATOR")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType AgentIsTypingIndicator {
				get {
					if (AGENT_IS_TYPING_INDICATOR_jfieldId == IntPtr.Zero)
						AGENT_IS_TYPING_INDICATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AGENT_IS_TYPING_INDICATOR", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AGENT_IS_TYPING_INDICATOR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AGENT_QUICK_REPLIES_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/field[@name='AGENT_QUICK_REPLIES']"
			[Register ("AGENT_QUICK_REPLIES")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType AgentQuickReplies {
				get {
					if (AGENT_QUICK_REPLIES_jfieldId == IntPtr.Zero)
						AGENT_QUICK_REPLIES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AGENT_QUICK_REPLIES", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AGENT_QUICK_REPLIES_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AGENT_STRUCTURED_CONTENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/field[@name='AGENT_STRUCTURED_CONTENT']"
			[Register ("AGENT_STRUCTURED_CONTENT")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType AgentStructuredContent {
				get {
					if (AGENT_STRUCTURED_CONTENT_jfieldId == IntPtr.Zero)
						AGENT_STRUCTURED_CONTENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AGENT_STRUCTURED_CONTENT", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AGENT_STRUCTURED_CONTENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AGENT_URL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/field[@name='AGENT_URL']"
			[Register ("AGENT_URL")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType AgentUrl {
				get {
					if (AGENT_URL_jfieldId == IntPtr.Zero)
						AGENT_URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AGENT_URL", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AGENT_URL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BRAND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/field[@name='BRAND']"
			[Register ("BRAND")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType Brand {
				get {
					if (BRAND_jfieldId == IntPtr.Zero)
						BRAND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BRAND", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BRAND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONSUMER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/field[@name='CONSUMER']"
			[Register ("CONSUMER")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType Consumer {
				get {
					if (CONSUMER_jfieldId == IntPtr.Zero)
						CONSUMER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONSUMER", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONSUMER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONSUMER_FORM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/field[@name='CONSUMER_FORM']"
			[Register ("CONSUMER_FORM")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType ConsumerForm {
				get {
					if (CONSUMER_FORM_jfieldId == IntPtr.Zero)
						CONSUMER_FORM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONSUMER_FORM", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONSUMER_FORM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONSUMER_IMAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/field[@name='CONSUMER_IMAGE']"
			[Register ("CONSUMER_IMAGE")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType ConsumerImage {
				get {
					if (CONSUMER_IMAGE_jfieldId == IntPtr.Zero)
						CONSUMER_IMAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONSUMER_IMAGE", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONSUMER_IMAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONSUMER_IMAGE_MASKED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/field[@name='CONSUMER_IMAGE_MASKED']"
			[Register ("CONSUMER_IMAGE_MASKED")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType ConsumerImageMasked {
				get {
					if (CONSUMER_IMAGE_MASKED_jfieldId == IntPtr.Zero)
						CONSUMER_IMAGE_MASKED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONSUMER_IMAGE_MASKED", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONSUMER_IMAGE_MASKED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONSUMER_MASKED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/field[@name='CONSUMER_MASKED']"
			[Register ("CONSUMER_MASKED")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType ConsumerMasked {
				get {
					if (CONSUMER_MASKED_jfieldId == IntPtr.Zero)
						CONSUMER_MASKED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONSUMER_MASKED", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONSUMER_MASKED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONSUMER_URL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/field[@name='CONSUMER_URL']"
			[Register ("CONSUMER_URL")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType ConsumerUrl {
				get {
					if (CONSUMER_URL_jfieldId == IntPtr.Zero)
						CONSUMER_URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONSUMER_URL", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONSUMER_URL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONSUMER_URL_MASKED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/field[@name='CONSUMER_URL_MASKED']"
			[Register ("CONSUMER_URL_MASKED")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType ConsumerUrlMasked {
				get {
					if (CONSUMER_URL_MASKED_jfieldId == IntPtr.Zero)
						CONSUMER_URL_MASKED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONSUMER_URL_MASKED", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONSUMER_URL_MASKED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONSUMER_VOICE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/field[@name='CONSUMER_VOICE']"
			[Register ("CONSUMER_VOICE")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType ConsumerVoice {
				get {
					if (CONSUMER_VOICE_jfieldId == IntPtr.Zero)
						CONSUMER_VOICE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONSUMER_VOICE", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONSUMER_VOICE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONTROLLER_SYSTEM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/field[@name='CONTROLLER_SYSTEM']"
			[Register ("CONTROLLER_SYSTEM")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType ControllerSystem {
				get {
					if (CONTROLLER_SYSTEM_jfieldId == IntPtr.Zero)
						CONTROLLER_SYSTEM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTROLLER_SYSTEM", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONTROLLER_SYSTEM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LOADING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/field[@name='LOADING']"
			[Register ("LOADING")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType Loading {
				get {
					if (LOADING_jfieldId == IntPtr.Zero)
						LOADING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOADING", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOADING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SYSTEM_MASKED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/field[@name='SYSTEM_MASKED']"
			[Register ("SYSTEM_MASKED")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType SystemMasked {
				get {
					if (SYSTEM_MASKED_jfieldId == IntPtr.Zero)
						SYSTEM_MASKED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SYSTEM_MASKED", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SYSTEM_MASKED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SYSTEM_RESOLVED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/field[@name='SYSTEM_RESOLVED']"
			[Register ("SYSTEM_RESOLVED")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType SystemResolved {
				get {
					if (SYSTEM_RESOLVED_jfieldId == IntPtr.Zero)
						SYSTEM_RESOLVED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SYSTEM_RESOLVED", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SYSTEM_RESOLVED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNREAD_INDICATOR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/field[@name='UNREAD_INDICATOR']"
			[Register ("UNREAD_INDICATOR")]
			public static global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType UnreadIndicator {
				get {
					if (UNREAD_INDICATOR_jfieldId == IntPtr.Zero)
						UNREAD_INDICATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNREAD_INDICATOR", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNREAD_INDICATOR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/model/MessagingChatMessage$MessageType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MessageType); }
			}

			internal MessageType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getMessageTypeForAgent_Lcom_liveperson_api_response_model_ContentType_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/method[@name='getMessageTypeForAgent' and count(parameter)=1 and parameter[1][@type='com.liveperson.api.response.model.ContentType']]"
			[Register ("getMessageTypeForAgent", "(Lcom/liveperson/api/response/model/ContentType;)Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;", "")]
			public static unsafe global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType GetMessageTypeForAgent (global::Com.Liveperson.Api.Response.Model.ContentType p0)
			{
				if (id_getMessageTypeForAgent_Lcom_liveperson_api_response_model_ContentType_ == IntPtr.Zero)
					id_getMessageTypeForAgent_Lcom_liveperson_api_response_model_ContentType_ = JNIEnv.GetStaticMethodID (class_ref, "getMessageTypeForAgent", "(Lcom/liveperson/api/response/model/ContentType;)Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMessageTypeForAgent_Lcom_liveperson_api_response_model_ContentType_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_getMessageTypeForConsumer_Lcom_liveperson_api_response_model_Event_Lcom_liveperson_api_response_model_ContentType_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/method[@name='getMessageTypeForConsumer' and count(parameter)=2 and parameter[1][@type='com.liveperson.api.response.model.Event'] and parameter[2][@type='com.liveperson.api.response.model.ContentType']]"
			[Register ("getMessageTypeForConsumer", "(Lcom/liveperson/api/response/model/Event;Lcom/liveperson/api/response/model/ContentType;)Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;", "")]
			public static unsafe global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType GetMessageTypeForConsumer (global::Com.Liveperson.Api.Response.Model.Event p0, global::Com.Liveperson.Api.Response.Model.ContentType p1)
			{
				if (id_getMessageTypeForConsumer_Lcom_liveperson_api_response_model_Event_Lcom_liveperson_api_response_model_ContentType_ == IntPtr.Zero)
					id_getMessageTypeForConsumer_Lcom_liveperson_api_response_model_Event_Lcom_liveperson_api_response_model_ContentType_ = JNIEnv.GetStaticMethodID (class_ref, "getMessageTypeForConsumer", "(Lcom/liveperson/api/response/model/Event;Lcom/liveperson/api/response/model/ContentType;)Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMessageTypeForConsumer_Lcom_liveperson_api_response_model_Event_Lcom_liveperson_api_response_model_ContentType_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_isAgent_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/method[@name='isAgent' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageType']]"
			[Register ("isAgent", "(Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)Z", "")]
			public static unsafe bool IsAgent (global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p0)
			{
				if (id_isAgent_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ == IntPtr.Zero)
					id_isAgent_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ = JNIEnv.GetStaticMethodID (class_ref, "isAgent", "(Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAgent_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_, __args);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_isConsumerMaskedMessage_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/method[@name='isConsumerMaskedMessage' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageType']]"
			[Register ("isConsumerMaskedMessage", "(Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)Z", "")]
			public static unsafe bool IsConsumerMaskedMessage (global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p0)
			{
				if (id_isConsumerMaskedMessage_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ == IntPtr.Zero)
					id_isConsumerMaskedMessage_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ = JNIEnv.GetStaticMethodID (class_ref, "isConsumerMaskedMessage", "(Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isConsumerMaskedMessage_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_, __args);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_isImage_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/method[@name='isImage' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageType']]"
			[Register ("isImage", "(Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)Z", "")]
			public static unsafe bool IsImage (global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p0)
			{
				if (id_isImage_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ == IntPtr.Zero)
					id_isImage_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ = JNIEnv.GetStaticMethodID (class_ref, "isImage", "(Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isImage_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_, __args);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_isSystem_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/method[@name='isSystem' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageType']]"
			[Register ("isSystem", "(Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)Z", "")]
			public static unsafe bool IsSystem (global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p0)
			{
				if (id_isSystem_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ == IntPtr.Zero)
					id_isSystem_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ = JNIEnv.GetStaticMethodID (class_ref, "isSystem", "(Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSystem_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_, __args);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;", "")]
			public static unsafe global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage.MessageType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;", "")]
			public static unsafe global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
				try {
					return (global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/model/MessagingChatMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessagingChatMessage); }
		}

		protected MessagingChatMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Lcom_liveperson_infra_utils_EncryptionVersion_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage']/constructor[@name='MessagingChatMessage' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageType'] and parameter[7][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageState'] and parameter[8][@type='com.liveperson.infra.utils.EncryptionVersion']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;Lcom/liveperson/infra/utils/EncryptionVersion;)V", "")]
		public unsafe MessagingChatMessage (string p0, string p1, long p2, string p3, string p4, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p5, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState p6, global::Com.Liveperson.Infra.Utils.EncryptionVersion p7)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				if (((object) this).GetType () != typeof (MessagingChatMessage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;Lcom/liveperson/infra/utils/EncryptionVersion;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;Lcom/liveperson/infra/utils/EncryptionVersion;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Lcom_liveperson_infra_utils_EncryptionVersion_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Lcom_liveperson_infra_utils_EncryptionVersion_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;Lcom/liveperson/infra/utils/EncryptionVersion;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Lcom_liveperson_infra_utils_EncryptionVersion_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Lcom_liveperson_infra_utils_EncryptionVersion_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ILjava_lang_String_Lcom_liveperson_infra_utils_EncryptionVersion_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage']/constructor[@name='MessagingChatMessage' and count(parameter)=10 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageType'] and parameter[7][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageState'] and parameter[8][@type='int'] and parameter[9][@type='java.lang.String'] and parameter[10][@type='com.liveperson.infra.utils.EncryptionVersion']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;ILjava/lang/String;Lcom/liveperson/infra/utils/EncryptionVersion;)V", "")]
		public unsafe MessagingChatMessage (string p0, string p1, long p2, string p3, string p4, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p5, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState p6, int p7, string p8, global::Com.Liveperson.Infra.Utils.EncryptionVersion p9)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p8 = JNIEnv.NewString (p8);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (native_p8);
				__args [9] = new JValue (p9);
				if (((object) this).GetType () != typeof (MessagingChatMessage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;ILjava/lang/String;Lcom/liveperson/infra/utils/EncryptionVersion;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;ILjava/lang/String;Lcom/liveperson/infra/utils/EncryptionVersion;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ILjava_lang_String_Lcom_liveperson_infra_utils_EncryptionVersion_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ILjava_lang_String_Lcom_liveperson_infra_utils_EncryptionVersion_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;ILjava/lang/String;Lcom/liveperson/infra/utils/EncryptionVersion;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ILjava_lang_String_Lcom_liveperson_infra_utils_EncryptionVersion_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ILjava_lang_String_Lcom_liveperson_infra_utils_EncryptionVersion_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p8);
			}
		}

		static Delegate cb_getAccessibilityMessage;
#pragma warning disable 0169
		static Delegate GetGetAccessibilityMessageHandler ()
		{
			if (cb_getAccessibilityMessage == null)
				cb_getAccessibilityMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccessibilityMessage);
			return cb_getAccessibilityMessage;
		}

		static IntPtr n_GetAccessibilityMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccessibilityMessage);
		}
#pragma warning restore 0169

		static IntPtr id_getAccessibilityMessage;
		public virtual unsafe string AccessibilityMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage']/method[@name='getAccessibilityMessage' and count(parameter)=0]"
			[Register ("getAccessibilityMessage", "()Ljava/lang/String;", "GetGetAccessibilityMessageHandler")]
			get {
				if (id_getAccessibilityMessage == IntPtr.Zero)
					id_getAccessibilityMessage = JNIEnv.GetMethodID (class_ref, "getAccessibilityMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccessibilityMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccessibilityMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFormalMessage;
#pragma warning disable 0169
		static Delegate GetGetFormalMessageHandler ()
		{
			if (cb_getFormalMessage == null)
				cb_getFormalMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFormalMessage);
			return cb_getFormalMessage;
		}

		static IntPtr n_GetFormalMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FormalMessage);
		}
#pragma warning restore 0169

		static IntPtr id_getFormalMessage;
		public virtual unsafe string FormalMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage']/method[@name='getFormalMessage' and count(parameter)=0]"
			[Register ("getFormalMessage", "()Ljava/lang/String;", "GetGetFormalMessageHandler")]
			get {
				if (id_getFormalMessage == IntPtr.Zero)
					id_getFormalMessage = JNIEnv.GetMethodID (class_ref, "getFormalMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormalMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFormalMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMessageState;
#pragma warning disable 0169
		static Delegate GetGetMessageStateHandler ()
		{
			if (cb_getMessageState == null)
				cb_getMessageState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageState);
			return cb_getMessageState;
		}

		static IntPtr n_GetMessageState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetMessageState ());
		}
#pragma warning restore 0169

		static IntPtr id_getMessageState;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage']/method[@name='getMessageState' and count(parameter)=0]"
		[Register ("getMessageState", "()Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;", "GetGetMessageStateHandler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState GetMessageState ()
		{
			if (id_getMessageState == IntPtr.Zero)
				id_getMessageState = JNIEnv.GetMethodID (class_ref, "getMessageState", "()Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageState), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageState", "()Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getMessageType;
#pragma warning disable 0169
		static Delegate GetGetMessageTypeHandler ()
		{
			if (cb_getMessageType == null)
				cb_getMessageType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageType);
			return cb_getMessageType;
		}

		static IntPtr n_GetMessageType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetMessageType ());
		}
#pragma warning restore 0169

		static IntPtr id_getMessageType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage']/method[@name='getMessageType' and count(parameter)=0]"
		[Register ("getMessageType", "()Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;", "GetGetMessageTypeHandler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType GetMessageType ()
		{
			if (id_getMessageType == IntPtr.Zero)
				id_getMessageType = JNIEnv.GetMethodID (class_ref, "getMessageType", "()Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageType", "()Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isSystemMessageFromAgent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsSystemMessageFromAgent_Ljava_lang_String_Handler ()
		{
			if (cb_isSystemMessageFromAgent_Ljava_lang_String_ == null)
				cb_isSystemMessageFromAgent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsSystemMessageFromAgent_Ljava_lang_String_);
			return cb_isSystemMessageFromAgent_Ljava_lang_String_;
		}

		static bool n_IsSystemMessageFromAgent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsSystemMessageFromAgent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isSystemMessageFromAgent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage']/method[@name='isSystemMessageFromAgent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isSystemMessageFromAgent", "(Ljava/lang/String;)Z", "GetIsSystemMessageFromAgent_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsSystemMessageFromAgent (string p0)
		{
			if (id_isSystemMessageFromAgent_Ljava_lang_String_ == IntPtr.Zero)
				id_isSystemMessageFromAgent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isSystemMessageFromAgent", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSystemMessageFromAgent_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSystemMessageFromAgent", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setMessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_;
#pragma warning disable 0169
		static Delegate GetSetMessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Handler ()
		{
			if (cb_setMessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ == null)
				cb_setMessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_);
			return cb_setMessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_;
		}

		static void n_SetMessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMessageState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage']/method[@name='setMessageState' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageState']]"
		[Register ("setMessageState", "(Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;)V", "GetSetMessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Handler")]
		public virtual unsafe void SetMessageState (global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState p0)
		{
			if (id_setMessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ == IntPtr.Zero)
				id_setMessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ = JNIEnv.GetMethodID (class_ref, "setMessageState", "(Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageState", "(Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
#pragma warning disable 0169
		static Delegate GetSetMessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Handler ()
		{
			if (cb_setMessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ == null)
				cb_setMessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_);
			return cb_setMessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
		}

		static void n_SetMessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMessageType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage']/method[@name='setMessageType' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageType']]"
		[Register ("setMessageType", "(Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)V", "GetSetMessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Handler")]
		public virtual unsafe void SetMessageType (global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p0)
		{
			if (id_setMessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ == IntPtr.Zero)
				id_setMessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ = JNIEnv.GetMethodID (class_ref, "setMessageType", "(Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageType", "(Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_update_Lcom_liveperson_messaging_model_MessagingChatMessage_;
#pragma warning disable 0169
		static Delegate GetUpdate_Lcom_liveperson_messaging_model_MessagingChatMessage_Handler ()
		{
			if (cb_update_Lcom_liveperson_messaging_model_MessagingChatMessage_ == null)
				cb_update_Lcom_liveperson_messaging_model_MessagingChatMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Update_Lcom_liveperson_messaging_model_MessagingChatMessage_);
			return cb_update_Lcom_liveperson_messaging_model_MessagingChatMessage_;
		}

		static IntPtr n_Update_Lcom_liveperson_messaging_model_MessagingChatMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Update (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_update_Lcom_liveperson_messaging_model_MessagingChatMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingChatMessage']/method[@name='update' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.MessagingChatMessage']]"
		[Register ("update", "(Lcom/liveperson/messaging/model/MessagingChatMessage;)Landroid/os/Bundle;", "GetUpdate_Lcom_liveperson_messaging_model_MessagingChatMessage_Handler")]
		public virtual unsafe global::Android.OS.Bundle Update (global::Com.Liveperson.Messaging.Model.MessagingChatMessage p0)
		{
			if (id_update_Lcom_liveperson_messaging_model_MessagingChatMessage_ == IntPtr.Zero)
				id_update_Lcom_liveperson_messaging_model_MessagingChatMessage_ = JNIEnv.GetMethodID (class_ref, "update", "(Lcom/liveperson/messaging/model/MessagingChatMessage;)Landroid/os/Bundle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.OS.Bundle __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_update_Lcom_liveperson_messaging_model_MessagingChatMessage_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "update", "(Lcom/liveperson/messaging/model/MessagingChatMessage;)Landroid/os/Bundle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
