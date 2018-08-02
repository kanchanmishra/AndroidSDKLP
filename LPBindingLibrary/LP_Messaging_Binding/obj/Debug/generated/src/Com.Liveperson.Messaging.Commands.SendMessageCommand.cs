using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Commands {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendMessageCommand']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/commands/SendMessageCommand", DoNotGenerateAcw=true)]
	public partial class SendMessageCommand : global::Java.Lang.Object, global::Com.Liveperson.Infra.ICommand {


		static IntPtr mBrandId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendMessageCommand']/field[@name='mBrandId']"
		[Register ("mBrandId")]
		protected string MBrandId {
			get {
				if (mBrandId_jfieldId == IntPtr.Zero)
					mBrandId_jfieldId = JNIEnv.GetFieldID (class_ref, "mBrandId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mBrandId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mBrandId_jfieldId == IntPtr.Zero)
					mBrandId_jfieldId = JNIEnv.GetFieldID (class_ref, "mBrandId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mBrandId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mConsumerId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendMessageCommand']/field[@name='mConsumerId']"
		[Register ("mConsumerId")]
		protected string MConsumerId {
			get {
				if (mConsumerId_jfieldId == IntPtr.Zero)
					mConsumerId_jfieldId = JNIEnv.GetFieldID (class_ref, "mConsumerId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mConsumerId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mConsumerId_jfieldId == IntPtr.Zero)
					mConsumerId_jfieldId = JNIEnv.GetFieldID (class_ref, "mConsumerId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mConsumerId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mController_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendMessageCommand']/field[@name='mController']"
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

		static IntPtr mEventId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendMessageCommand']/field[@name='mEventId']"
		[Register ("mEventId")]
		protected string MEventId {
			get {
				if (mEventId_jfieldId == IntPtr.Zero)
					mEventId_jfieldId = JNIEnv.GetFieldID (class_ref, "mEventId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mEventId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mEventId_jfieldId == IntPtr.Zero)
					mEventId_jfieldId = JNIEnv.GetFieldID (class_ref, "mEventId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mEventId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mMessage_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendMessageCommand']/field[@name='mMessage']"
		[Register ("mMessage")]
		protected global::Com.Liveperson.Infra.Utils.MaskedMessage MMessage {
			get {
				if (mMessage_jfieldId == IntPtr.Zero)
					mMessage_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessage", "Lcom/liveperson/infra/utils/MaskedMessage;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMessage_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.MaskedMessage> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMessage_jfieldId == IntPtr.Zero)
					mMessage_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessage", "Lcom/liveperson/infra/utils/MaskedMessage;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMessage_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mTargetId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendMessageCommand']/field[@name='mTargetId']"
		[Register ("mTargetId")]
		protected string MTargetId {
			get {
				if (mTargetId_jfieldId == IntPtr.Zero)
					mTargetId_jfieldId = JNIEnv.GetFieldID (class_ref, "mTargetId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mTargetId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTargetId_jfieldId == IntPtr.Zero)
					mTargetId_jfieldId = JNIEnv.GetFieldID (class_ref, "mTargetId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mTargetId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/commands/SendMessageCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SendMessageCommand); }
		}

		protected SendMessageCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendMessageCommand']/constructor[@name='SendMessageCommand' and count(parameter)=4 and parameter[1][@type='com.liveperson.messaging.Messaging'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.liveperson.infra.utils.MaskedMessage']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/utils/MaskedMessage;)V", "")]
		public unsafe SendMessageCommand (global::Com.Liveperson.Messaging.Messaging p0, string p1, string p2, global::Com.Liveperson.Infra.Utils.MaskedMessage p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (SendMessageCommand)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/utils/MaskedMessage;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/utils/MaskedMessage;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/utils/MaskedMessage;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getEventId;
#pragma warning disable 0169
		static Delegate GetGetEventIdHandler ()
		{
			if (cb_getEventId == null)
				cb_getEventId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventId);
			return cb_getEventId;
		}

		static IntPtr n_GetEventId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Commands.SendMessageCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.SendMessageCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EventId);
		}
#pragma warning restore 0169

		static IntPtr id_getEventId;
		public virtual unsafe string EventId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendMessageCommand']/method[@name='getEventId' and count(parameter)=0]"
			[Register ("getEventId", "()Ljava/lang/String;", "GetGetEventIdHandler")]
			get {
				if (id_getEventId == IntPtr.Zero)
					id_getEventId = JNIEnv.GetMethodID (class_ref, "getEventId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEventId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEventId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addMessageToDBAndSend_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_;
#pragma warning disable 0169
		static Delegate GetAddMessageToDBAndSend_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_Handler ()
		{
			if (cb_addMessageToDBAndSend_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_ == null)
				cb_addMessageToDBAndSend_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMessageToDBAndSend_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_);
			return cb_addMessageToDBAndSend_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_;
		}

		static void n_AddMessageToDBAndSend_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Commands.SendMessageCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.SendMessageCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Utils.MaskedMessage p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.MaskedMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddMessageToDBAndSend (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addMessageToDBAndSend_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendMessageCommand']/method[@name='addMessageToDBAndSend' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.utils.MaskedMessage']]"
		[Register ("addMessageToDBAndSend", "(Ljava/lang/String;Lcom/liveperson/infra/utils/MaskedMessage;)V", "GetAddMessageToDBAndSend_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_Handler")]
		protected virtual unsafe void AddMessageToDBAndSend (string p0, global::Com.Liveperson.Infra.Utils.MaskedMessage p1)
		{
			if (id_addMessageToDBAndSend_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_ == IntPtr.Zero)
				id_addMessageToDBAndSend_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_ = JNIEnv.GetMethodID (class_ref, "addMessageToDBAndSend", "(Ljava/lang/String;Lcom/liveperson/infra/utils/MaskedMessage;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addMessageToDBAndSend_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMessageToDBAndSend", "(Ljava/lang/String;Lcom/liveperson/infra/utils/MaskedMessage;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_createMessageRequest_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateMessageRequest_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_createMessageRequest_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_createMessageRequest_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateMessageRequest_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_createMessageRequest_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_CreateMessageRequest_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Liveperson.Messaging.Commands.SendMessageCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.SendMessageCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Messaging p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateMessageRequest (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createMessageRequest_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendMessageCommand']/method[@name='createMessageRequest' and count(parameter)=5 and parameter[1][@type='com.liveperson.messaging.Messaging'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("createMessageRequest", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/messaging/network/socket/requests/SendMessageRequest;", "GetCreateMessageRequest_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest CreateMessageRequest (global::Com.Liveperson.Messaging.Messaging p0, string p1, string p2, string p3, string p4)
		{
			if (id_createMessageRequest_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_createMessageRequest_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createMessageRequest", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/messaging/network/socket/requests/SendMessageRequest;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);

				global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createMessageRequest_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createMessageRequest", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/messaging/network/socket/requests/SendMessageRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_createNewChatMessage_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_;
#pragma warning disable 0169
		static Delegate GetCreateNewChatMessage_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_Handler ()
		{
			if (cb_createNewChatMessage_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_ == null)
				cb_createNewChatMessage_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateNewChatMessage_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_);
			return cb_createNewChatMessage_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_;
		}

		static IntPtr n_CreateNewChatMessage_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Commands.SendMessageCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.SendMessageCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Utils.MaskedMessage p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.MaskedMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateNewChatMessage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createNewChatMessage_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendMessageCommand']/method[@name='createNewChatMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.utils.MaskedMessage']]"
		[Register ("createNewChatMessage", "(Ljava/lang/String;Lcom/liveperson/infra/utils/MaskedMessage;)Lcom/liveperson/messaging/model/MessagingChatMessage;", "GetCreateNewChatMessage_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_Handler")]
		protected virtual unsafe global::Com.Liveperson.Messaging.Model.MessagingChatMessage CreateNewChatMessage (string p0, global::Com.Liveperson.Infra.Utils.MaskedMessage p1)
		{
			if (id_createNewChatMessage_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_ == IntPtr.Zero)
				id_createNewChatMessage_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_ = JNIEnv.GetMethodID (class_ref, "createNewChatMessage", "(Ljava/lang/String;Lcom/liveperson/infra/utils/MaskedMessage;)Lcom/liveperson/messaging/model/MessagingChatMessage;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Com.Liveperson.Messaging.Model.MessagingChatMessage __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createNewChatMessage_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createNewChatMessage", "(Ljava/lang/String;Lcom/liveperson/infra/utils/MaskedMessage;)Lcom/liveperson/messaging/model/MessagingChatMessage;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_createPendingConversation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreatePendingConversation_Ljava_lang_String_Handler ()
		{
			if (cb_createPendingConversation_Ljava_lang_String_ == null)
				cb_createPendingConversation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreatePendingConversation_Ljava_lang_String_);
			return cb_createPendingConversation_Ljava_lang_String_;
		}

		static IntPtr n_CreatePendingConversation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Commands.SendMessageCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.SendMessageCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreatePendingConversation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createPendingConversation_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendMessageCommand']/method[@name='createPendingConversation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createPendingConversation", "(Ljava/lang/String;)Lcom/liveperson/api/request/BaseAMSSocketRequest;", "GetCreatePendingConversation_Ljava_lang_String_Handler")]
		protected virtual unsafe global::Com.Liveperson.Api.Request.BaseAMSSocketRequest CreatePendingConversation (string p0)
		{
			if (id_createPendingConversation_Ljava_lang_String_ == IntPtr.Zero)
				id_createPendingConversation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createPendingConversation", "(Ljava/lang/String;)Lcom/liveperson/api/request/BaseAMSSocketRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Api.Request.BaseAMSSocketRequest __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.BaseAMSSocketRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createPendingConversation_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.BaseAMSSocketRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createPendingConversation", "(Ljava/lang/String;)Lcom/liveperson/api/request/BaseAMSSocketRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_createTempConversationId;
#pragma warning disable 0169
		static Delegate GetCreateTempConversationIdHandler ()
		{
			if (cb_createTempConversationId == null)
				cb_createTempConversationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateTempConversationId);
			return cb_createTempConversationId;
		}

		static IntPtr n_CreateTempConversationId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Commands.SendMessageCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.SendMessageCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreateTempConversationId ());
		}
#pragma warning restore 0169

		static IntPtr id_createTempConversationId;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendMessageCommand']/method[@name='createTempConversationId' and count(parameter)=0]"
		[Register ("createTempConversationId", "()Ljava/lang/String;", "GetCreateTempConversationIdHandler")]
		protected virtual unsafe string CreateTempConversationId ()
		{
			if (id_createTempConversationId == IntPtr.Zero)
				id_createTempConversationId = JNIEnv.GetMethodID (class_ref, "createTempConversationId", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createTempConversationId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createTempConversationId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_execute;
#pragma warning disable 0169
		static Delegate GetExecuteHandler ()
		{
			if (cb_execute == null)
				cb_execute = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Execute);
			return cb_execute;
		}

		static void n_Execute (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Commands.SendMessageCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.SendMessageCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		static IntPtr id_execute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendMessageCommand']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()V", "GetExecuteHandler")]
		public virtual unsafe void Execute ()
		{
			if (id_execute == IntPtr.Zero)
				id_execute = JNIEnv.GetMethodID (class_ref, "execute", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_execute);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendMessage_Ljava_lang_String_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Ljava_lang_String_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_Handler ()
		{
			if (cb_sendMessage_Ljava_lang_String_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_ == null)
				cb_sendMessage_Ljava_lang_String_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessage_Ljava_lang_String_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_);
			return cb_sendMessage_Ljava_lang_String_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_;
		}

		static void n_SendMessage_Ljava_lang_String_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Commands.SendMessageCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.SendMessageCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendMessage_Ljava_lang_String_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendMessageCommand']/method[@name='sendMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.messaging.network.socket.requests.SendMessageRequest']]"
		[Register ("sendMessage", "(Ljava/lang/String;Lcom/liveperson/messaging/network/socket/requests/SendMessageRequest;)V", "GetSendMessage_Ljava_lang_String_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_Handler")]
		protected virtual unsafe void SendMessage (string p0, global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest p1)
		{
			if (id_sendMessage_Ljava_lang_String_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_ == IntPtr.Zero)
				id_sendMessage_Ljava_lang_String_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Ljava/lang/String;Lcom/liveperson/messaging/network/socket/requests/SendMessageRequest;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Ljava_lang_String_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendMessage", "(Ljava/lang/String;Lcom/liveperson/messaging/network/socket/requests/SendMessageRequest;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendMessage_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_sendMessage_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_sendMessage_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessage_Ljava_lang_String_Ljava_lang_String_);
			return cb_sendMessage_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SendMessage_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Commands.SendMessageCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.SendMessageCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendMessage_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendMessageCommand']/method[@name='sendMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendMessage", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSendMessage_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe void SendMessage (string p0, string p1)
		{
			if (id_sendMessage_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendMessage_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendMessage", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_sendMessageIfConversationOpen;
#pragma warning disable 0169
		static Delegate GetSendMessageIfConversationOpenHandler ()
		{
			if (cb_sendMessageIfConversationOpen == null)
				cb_sendMessageIfConversationOpen = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendMessageIfConversationOpen);
			return cb_sendMessageIfConversationOpen;
		}

		static void n_SendMessageIfConversationOpen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Commands.SendMessageCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.SendMessageCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendMessageIfConversationOpen ();
		}
#pragma warning restore 0169

		static IntPtr id_sendMessageIfConversationOpen;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendMessageCommand']/method[@name='sendMessageIfConversationOpen' and count(parameter)=0]"
		[Register ("sendMessageIfConversationOpen", "()V", "GetSendMessageIfConversationOpenHandler")]
		protected virtual unsafe void SendMessageIfConversationOpen ()
		{
			if (id_sendMessageIfConversationOpen == IntPtr.Zero)
				id_sendMessageIfConversationOpen = JNIEnv.GetMethodID (class_ref, "sendMessageIfConversationOpen", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessageIfConversationOpen);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendMessageIfConversationOpen", "()V"));
			} finally {
			}
		}

	}
}
