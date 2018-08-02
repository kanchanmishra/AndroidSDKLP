using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Commands {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendImageCommand']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/commands/SendImageCommand", DoNotGenerateAcw=true)]
	public partial class SendImageCommand : global::Com.Liveperson.Messaging.Commands.SendFileCommand {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/commands/SendImageCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SendImageCommand); }
		}

		protected SendImageCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendImageCommand']/constructor[@name='SendImageCommand' and count(parameter)=8 and parameter[1][@type='com.liveperson.messaging.Messaging'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='com.liveperson.infra.utils.MaskedMessage']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/utils/MaskedMessage;)V", "")]
		public unsafe SendImageCommand (global::Com.Liveperson.Messaging.Messaging p0, string p1, string p2, string p3, string p4, string p5, string p6, global::Com.Liveperson.Infra.Utils.MaskedMessage p7)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (p7);
				if (((object) this).GetType () != typeof (SendImageCommand)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/utils/MaskedMessage;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/utils/MaskedMessage;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/utils/MaskedMessage;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static Delegate cb_getMessageType_Lcom_liveperson_infra_utils_MaskedMessage_;
#pragma warning disable 0169
		static Delegate GetGetMessageType_Lcom_liveperson_infra_utils_MaskedMessage_Handler ()
		{
			if (cb_getMessageType_Lcom_liveperson_infra_utils_MaskedMessage_ == null)
				cb_getMessageType_Lcom_liveperson_infra_utils_MaskedMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMessageType_Lcom_liveperson_infra_utils_MaskedMessage_);
			return cb_getMessageType_Lcom_liveperson_infra_utils_MaskedMessage_;
		}

		static IntPtr n_GetMessageType_Lcom_liveperson_infra_utils_MaskedMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Commands.SendImageCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.SendImageCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Utils.MaskedMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.MaskedMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMessageType (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageType_Lcom_liveperson_infra_utils_MaskedMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendImageCommand']/method[@name='getMessageType' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.utils.MaskedMessage']]"
		[Register ("getMessageType", "(Lcom/liveperson/infra/utils/MaskedMessage;)Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;", "GetGetMessageType_Lcom_liveperson_infra_utils_MaskedMessage_Handler")]
		protected override unsafe global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType GetMessageType (global::Com.Liveperson.Infra.Utils.MaskedMessage p0)
		{
			if (id_getMessageType_Lcom_liveperson_infra_utils_MaskedMessage_ == IntPtr.Zero)
				id_getMessageType_Lcom_liveperson_infra_utils_MaskedMessage_ = JNIEnv.GetMethodID (class_ref, "getMessageType", "(Lcom/liveperson/infra/utils/MaskedMessage;)Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageType_Lcom_liveperson_infra_utils_MaskedMessage_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageType", "(Lcom/liveperson/infra/utils/MaskedMessage;)Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
