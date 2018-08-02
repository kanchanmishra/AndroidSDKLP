using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.View.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/class[@name='ChatMessageRow']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/ChatMessageRow", DoNotGenerateAcw=true)]
	public partial class ChatMessageRow : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/view/adapter/ChatMessageRow", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChatMessageRow); }
		}

		protected ChatMessageRow (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_model_MessagingChatMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_FileMessage_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/class[@name='ChatMessageRow']/constructor[@name='ChatMessageRow' and count(parameter)=4 and parameter[1][@type='com.liveperson.messaging.model.MessagingChatMessage'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.liveperson.messaging.model.FileMessage']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/model/MessagingChatMessage;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/FileMessage;)V", "")]
		public unsafe ChatMessageRow (global::Com.Liveperson.Messaging.Model.MessagingChatMessage p0, string p1, string p2, global::Com.Liveperson.Messaging.Model.FileMessage p3)
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
				if (((object) this).GetType () != typeof (ChatMessageRow)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/model/MessagingChatMessage;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/FileMessage;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/model/MessagingChatMessage;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/FileMessage;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_model_MessagingChatMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_FileMessage_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_model_MessagingChatMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_FileMessage_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/model/MessagingChatMessage;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/FileMessage;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_model_MessagingChatMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_FileMessage_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_model_MessagingChatMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_FileMessage_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
