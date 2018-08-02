using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/model/ConversationData", DoNotGenerateAcw=true)]
	public partial class ConversationData : global::Java.Lang.Object, global::Java.Lang.IComparable {


		static IntPtr allAgents_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/field[@name='allAgents']"
		[Register ("allAgents")]
		public IList<string> AllAgents {
			get {
				if (allAgents_jfieldId == IntPtr.Zero)
					allAgents_jfieldId = JNIEnv.GetFieldID (class_ref, "allAgents", "[Ljava/lang/String;");
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, allAgents_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (allAgents_jfieldId == IntPtr.Zero)
					allAgents_jfieldId = JNIEnv.GetFieldID (class_ref, "allAgents", "[Ljava/lang/String;");
				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, allAgents_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr assignedAgentServerId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/field[@name='assignedAgentServerId']"
		[Register ("assignedAgentServerId")]
		public string AssignedAgentServerId {
			get {
				if (assignedAgentServerId_jfieldId == IntPtr.Zero)
					assignedAgentServerId_jfieldId = JNIEnv.GetFieldID (class_ref, "assignedAgentServerId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, assignedAgentServerId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (assignedAgentServerId_jfieldId == IntPtr.Zero)
					assignedAgentServerId_jfieldId = JNIEnv.GetFieldID (class_ref, "assignedAgentServerId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, assignedAgentServerId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr brandId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/field[@name='brandId']"
		[Register ("brandId")]
		public string BrandId {
			get {
				if (brandId_jfieldId == IntPtr.Zero)
					brandId_jfieldId = JNIEnv.GetFieldID (class_ref, "brandId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, brandId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (brandId_jfieldId == IntPtr.Zero)
					brandId_jfieldId = JNIEnv.GetFieldID (class_ref, "brandId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, brandId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr closeReason_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/field[@name='closeReason']"
		[Register ("closeReason")]
		public global::Com.Liveperson.Api.Response.Types.CloseReason CloseReason {
			get {
				if (closeReason_jfieldId == IntPtr.Zero)
					closeReason_jfieldId = JNIEnv.GetFieldID (class_ref, "closeReason", "Lcom/liveperson/api/response/types/CloseReason;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, closeReason_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CloseReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (closeReason_jfieldId == IntPtr.Zero)
					closeReason_jfieldId = JNIEnv.GetFieldID (class_ref, "closeReason", "Lcom/liveperson/api/response/types/CloseReason;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, closeReason_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr consumerId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/field[@name='consumerId']"
		[Register ("consumerId")]
		public string ConsumerId {
			get {
				if (consumerId_jfieldId == IntPtr.Zero)
					consumerId_jfieldId = JNIEnv.GetFieldID (class_ref, "consumerId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, consumerId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (consumerId_jfieldId == IntPtr.Zero)
					consumerId_jfieldId = JNIEnv.GetFieldID (class_ref, "consumerId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, consumerId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr conversationId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/field[@name='conversationId']"
		[Register ("conversationId")]
		public string ConversationId {
			get {
				if (conversationId_jfieldId == IntPtr.Zero)
					conversationId_jfieldId = JNIEnv.GetFieldID (class_ref, "conversationId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, conversationId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (conversationId_jfieldId == IntPtr.Zero)
					conversationId_jfieldId = JNIEnv.GetFieldID (class_ref, "conversationId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, conversationId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr conversationTTRType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/field[@name='conversationTTRType']"
		[Register ("conversationTTRType")]
		public global::Com.Liveperson.Api.Response.Types.TTRType ConversationTTRType {
			get {
				if (conversationTTRType_jfieldId == IntPtr.Zero)
					conversationTTRType_jfieldId = JNIEnv.GetFieldID (class_ref, "conversationTTRType", "Lcom/liveperson/api/response/types/TTRType;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, conversationTTRType_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.TTRType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (conversationTTRType_jfieldId == IntPtr.Zero)
					conversationTTRType_jfieldId = JNIEnv.GetFieldID (class_ref, "conversationTTRType", "Lcom/liveperson/api/response/types/TTRType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, conversationTTRType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr csat_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/field[@name='csat']"
		[Register ("csat")]
		public global::Com.Liveperson.Api.Response.Types.CSAT Csat {
			get {
				if (csat_jfieldId == IntPtr.Zero)
					csat_jfieldId = JNIEnv.GetFieldID (class_ref, "csat", "Lcom/liveperson/api/response/types/CSAT;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, csat_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CSAT> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (csat_jfieldId == IntPtr.Zero)
					csat_jfieldId = JNIEnv.GetFieldID (class_ref, "csat", "Lcom/liveperson/api/response/types/CSAT;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, csat_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr delayTillWhen_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/field[@name='delayTillWhen']"
		[Register ("delayTillWhen")]
		public long DelayTillWhen {
			get {
				if (delayTillWhen_jfieldId == IntPtr.Zero)
					delayTillWhen_jfieldId = JNIEnv.GetFieldID (class_ref, "delayTillWhen", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, delayTillWhen_jfieldId);
			}
			set {
				if (delayTillWhen_jfieldId == IntPtr.Zero)
					delayTillWhen_jfieldId = JNIEnv.GetFieldID (class_ref, "delayTillWhen", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, delayTillWhen_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr delayType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/field[@name='delayType']"
		[Register ("delayType")]
		public global::Com.Liveperson.Api.Response.Types.TTRType DelayType {
			get {
				if (delayType_jfieldId == IntPtr.Zero)
					delayType_jfieldId = JNIEnv.GetFieldID (class_ref, "delayType", "Lcom/liveperson/api/response/types/TTRType;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, delayType_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.TTRType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (delayType_jfieldId == IntPtr.Zero)
					delayType_jfieldId = JNIEnv.GetFieldID (class_ref, "delayType", "Lcom/liveperson/api/response/types/TTRType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, delayType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr endTs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/field[@name='endTs']"
		[Register ("endTs")]
		public long EndTs {
			get {
				if (endTs_jfieldId == IntPtr.Zero)
					endTs_jfieldId = JNIEnv.GetFieldID (class_ref, "endTs", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, endTs_jfieldId);
			}
			set {
				if (endTs_jfieldId == IntPtr.Zero)
					endTs_jfieldId = JNIEnv.GetFieldID (class_ref, "endTs", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, endTs_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr manualTTR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/field[@name='manualTTR']"
		[Register ("manualTTR")]
		public long ManualTTR {
			get {
				if (manualTTR_jfieldId == IntPtr.Zero)
					manualTTR_jfieldId = JNIEnv.GetFieldID (class_ref, "manualTTR", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, manualTTR_jfieldId);
			}
			set {
				if (manualTTR_jfieldId == IntPtr.Zero)
					manualTTR_jfieldId = JNIEnv.GetFieldID (class_ref, "manualTTR", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, manualTTR_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr participants_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/field[@name='participants']"
		[Register ("participants")]
		public global::Com.Liveperson.Api.Response.Model.Participants Participants {
			get {
				if (participants_jfieldId == IntPtr.Zero)
					participants_jfieldId = JNIEnv.GetFieldID (class_ref, "participants", "Lcom/liveperson/api/response/model/Participants;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, participants_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.Participants> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (participants_jfieldId == IntPtr.Zero)
					participants_jfieldId = JNIEnv.GetFieldID (class_ref, "participants", "Lcom/liveperson/api/response/model/Participants;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, participants_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr requestId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/field[@name='requestId']"
		[Register ("requestId")]
		public long RequestId {
			get {
				if (requestId_jfieldId == IntPtr.Zero)
					requestId_jfieldId = JNIEnv.GetFieldID (class_ref, "requestId", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, requestId_jfieldId);
			}
			set {
				if (requestId_jfieldId == IntPtr.Zero)
					requestId_jfieldId = JNIEnv.GetFieldID (class_ref, "requestId", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, requestId_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr source_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/field[@name='source']"
		[Register ("source")]
		public global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager.DATA_SOURCE Source {
			get {
				if (source_jfieldId == IntPtr.Zero)
					source_jfieldId = JNIEnv.GetFieldID (class_ref, "source", "Lcom/liveperson/messaging/commands/tasks/FetchConversationManager$DATA_SOURCE;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, source_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager.DATA_SOURCE> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (source_jfieldId == IntPtr.Zero)
					source_jfieldId = JNIEnv.GetFieldID (class_ref, "source", "Lcom/liveperson/messaging/commands/tasks/FetchConversationManager$DATA_SOURCE;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, source_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr startTs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/field[@name='startTs']"
		[Register ("startTs")]
		public long StartTs {
			get {
				if (startTs_jfieldId == IntPtr.Zero)
					startTs_jfieldId = JNIEnv.GetFieldID (class_ref, "startTs", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, startTs_jfieldId);
			}
			set {
				if (startTs_jfieldId == IntPtr.Zero)
					startTs_jfieldId = JNIEnv.GetFieldID (class_ref, "startTs", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, startTs_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr state_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/field[@name='state']"
		[Register ("state")]
		public global::Com.Liveperson.Api.Response.Types.ConversationState State {
			get {
				if (state_jfieldId == IntPtr.Zero)
					state_jfieldId = JNIEnv.GetFieldID (class_ref, "state", "Lcom/liveperson/api/response/types/ConversationState;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, state_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.ConversationState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (state_jfieldId == IntPtr.Zero)
					state_jfieldId = JNIEnv.GetFieldID (class_ref, "state", "Lcom/liveperson/api/response/types/ConversationState;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, state_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr targetId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/field[@name='targetId']"
		[Register ("targetId")]
		public string TargetId {
			get {
				if (targetId_jfieldId == IntPtr.Zero)
					targetId_jfieldId = JNIEnv.GetFieldID (class_ref, "targetId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, targetId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (targetId_jfieldId == IntPtr.Zero)
					targetId_jfieldId = JNIEnv.GetFieldID (class_ref, "targetId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, targetId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ttrValue_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/field[@name='ttrValue']"
		[Register ("ttrValue")]
		public long TtrValue {
			get {
				if (ttrValue_jfieldId == IntPtr.Zero)
					ttrValue_jfieldId = JNIEnv.GetFieldID (class_ref, "ttrValue", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, ttrValue_jfieldId);
			}
			set {
				if (ttrValue_jfieldId == IntPtr.Zero)
					ttrValue_jfieldId = JNIEnv.GetFieldID (class_ref, "ttrValue", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ttrValue_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr unreadMessages_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/field[@name='unreadMessages']"
		[Register ("unreadMessages")]
		public int UnreadMessages {
			get {
				if (unreadMessages_jfieldId == IntPtr.Zero)
					unreadMessages_jfieldId = JNIEnv.GetFieldID (class_ref, "unreadMessages", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, unreadMessages_jfieldId);
			}
			set {
				if (unreadMessages_jfieldId == IntPtr.Zero)
					unreadMessages_jfieldId = JNIEnv.GetFieldID (class_ref, "unreadMessages", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, unreadMessages_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/model/ConversationData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConversationData); }
		}

		protected ConversationData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/constructor[@name='ConversationData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConversationData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ConversationData)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Lcom_liveperson_messaging_model_Conversation_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/constructor[@name='ConversationData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.messaging.model.Conversation']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/liveperson/messaging/model/Conversation;)V", "")]
		public unsafe ConversationData (string p0, global::Com.Liveperson.Messaging.Model.Conversation p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ConversationData)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Lcom/liveperson/messaging/model/Conversation;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lcom/liveperson/messaging/model/Conversation;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_liveperson_messaging_model_Conversation_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_liveperson_messaging_model_Conversation_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/liveperson/messaging/model/Conversation;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_liveperson_messaging_model_Conversation_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_liveperson_messaging_model_Conversation_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Lcom_liveperson_api_response_model_ConversationINCADetails_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/constructor[@name='ConversationData' and count(parameter)=2 and parameter[1][@type='com.liveperson.api.response.model.ConversationINCADetails'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/liveperson/api/response/model/ConversationINCADetails;Ljava/lang/String;)V", "")]
		public unsafe ConversationData (global::Com.Liveperson.Api.Response.Model.ConversationINCADetails p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (ConversationData)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/api/response/model/ConversationINCADetails;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/api/response/model/ConversationINCADetails;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_api_response_model_ConversationINCADetails_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_api_response_model_ConversationINCADetails_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/api/response/model/ConversationINCADetails;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_api_response_model_ConversationINCADetails_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_api_response_model_ConversationINCADetails_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Lcom_liveperson_api_response_types_ConversationState_Lcom_liveperson_api_response_model_Result_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/constructor[@name='ConversationData' and count(parameter)=3 and parameter[1][@type='com.liveperson.api.response.types.ConversationState'] and parameter[2][@type='com.liveperson.api.response.model.Result'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/liveperson/api/response/types/ConversationState;Lcom/liveperson/api/response/model/Result;Ljava/lang/String;)V", "")]
		public unsafe ConversationData (global::Com.Liveperson.Api.Response.Types.ConversationState p0, global::Com.Liveperson.Api.Response.Model.Result p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (ConversationData)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/api/response/types/ConversationState;Lcom/liveperson/api/response/model/Result;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/api/response/types/ConversationState;Lcom/liveperson/api/response/model/Result;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_api_response_types_ConversationState_Lcom_liveperson_api_response_model_Result_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_api_response_types_ConversationState_Lcom_liveperson_api_response_model_Result_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/api/response/types/ConversationState;Lcom/liveperson/api/response/model/Result;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_api_response_types_ConversationState_Lcom_liveperson_api_response_model_Result_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_api_response_types_ConversationState_Lcom_liveperson_api_response_model_Result_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_compareTo_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Ljava_lang_Object_Handler ()
		{
			if (cb_compareTo_Ljava_lang_Object_ == null)
				cb_compareTo_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Ljava_lang_Object_);
			return cb_compareTo_Ljava_lang_Object_;
		}

		static int n_CompareTo_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.ConversationData __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.ConversationData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
		public virtual unsafe int CompareTo (global::Java.Lang.Object p0)
		{
			if (id_compareTo_Ljava_lang_Object_ == IntPtr.Zero)
				id_compareTo_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Ljava/lang/Object;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_compareTo_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Ljava/lang/Object;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getAllAgentParticipants_Lcom_liveperson_api_response_model_Participants_;
#pragma warning disable 0169
		static Delegate GetGetAllAgentParticipants_Lcom_liveperson_api_response_model_Participants_Handler ()
		{
			if (cb_getAllAgentParticipants_Lcom_liveperson_api_response_model_Participants_ == null)
				cb_getAllAgentParticipants_Lcom_liveperson_api_response_model_Participants_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAllAgentParticipants_Lcom_liveperson_api_response_model_Participants_);
			return cb_getAllAgentParticipants_Lcom_liveperson_api_response_model_Participants_;
		}

		static IntPtr n_GetAllAgentParticipants_Lcom_liveperson_api_response_model_Participants_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.ConversationData __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.ConversationData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Response.Model.Participants p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.Participants> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetAllAgentParticipants (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAllAgentParticipants_Lcom_liveperson_api_response_model_Participants_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/method[@name='getAllAgentParticipants' and count(parameter)=1 and parameter[1][@type='com.liveperson.api.response.model.Participants']]"
		[Register ("getAllAgentParticipants", "(Lcom/liveperson/api/response/model/Participants;)[Ljava/lang/String;", "GetGetAllAgentParticipants_Lcom_liveperson_api_response_model_Participants_Handler")]
		protected virtual unsafe string[] GetAllAgentParticipants (global::Com.Liveperson.Api.Response.Model.Participants p0)
		{
			if (id_getAllAgentParticipants_Lcom_liveperson_api_response_model_Participants_ == IntPtr.Zero)
				id_getAllAgentParticipants_Lcom_liveperson_api_response_model_Participants_ = JNIEnv.GetMethodID (class_ref, "getAllAgentParticipants", "(Lcom/liveperson/api/response/model/Participants;)[Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllAgentParticipants_Lcom_liveperson_api_response_model_Participants_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					__ret = (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllAgentParticipants", "(Lcom/liveperson/api/response/model/Participants;)[Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getAssignedAgentId_Lcom_liveperson_api_response_model_Participants_;
#pragma warning disable 0169
		static Delegate GetGetAssignedAgentId_Lcom_liveperson_api_response_model_Participants_Handler ()
		{
			if (cb_getAssignedAgentId_Lcom_liveperson_api_response_model_Participants_ == null)
				cb_getAssignedAgentId_Lcom_liveperson_api_response_model_Participants_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAssignedAgentId_Lcom_liveperson_api_response_model_Participants_);
			return cb_getAssignedAgentId_Lcom_liveperson_api_response_model_Participants_;
		}

		static IntPtr n_GetAssignedAgentId_Lcom_liveperson_api_response_model_Participants_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.ConversationData __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.ConversationData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Response.Model.Participants p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.Participants> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetAssignedAgentId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAssignedAgentId_Lcom_liveperson_api_response_model_Participants_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationData']/method[@name='getAssignedAgentId' and count(parameter)=1 and parameter[1][@type='com.liveperson.api.response.model.Participants']]"
		[Register ("getAssignedAgentId", "(Lcom/liveperson/api/response/model/Participants;)Ljava/lang/String;", "GetGetAssignedAgentId_Lcom_liveperson_api_response_model_Participants_Handler")]
		protected virtual unsafe string GetAssignedAgentId (global::Com.Liveperson.Api.Response.Model.Participants p0)
		{
			if (id_getAssignedAgentId_Lcom_liveperson_api_response_model_Participants_ == IntPtr.Zero)
				id_getAssignedAgentId_Lcom_liveperson_api_response_model_Participants_ = JNIEnv.GetMethodID (class_ref, "getAssignedAgentId", "(Lcom/liveperson/api/response/model/Participants;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAssignedAgentId_Lcom_liveperson_api_response_model_Participants_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAssignedAgentId", "(Lcom/liveperson/api/response/model/Participants;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
