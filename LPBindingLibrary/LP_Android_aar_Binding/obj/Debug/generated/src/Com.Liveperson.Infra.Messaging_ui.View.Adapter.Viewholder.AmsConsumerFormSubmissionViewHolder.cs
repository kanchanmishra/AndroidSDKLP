using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerFormSubmissionViewHolder']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsConsumerFormSubmissionViewHolder", DoNotGenerateAcw=true)]
	public partial class AmsConsumerFormSubmissionViewHolder : global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerViewHolder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsConsumerFormSubmissionViewHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsConsumerFormSubmissionViewHolder); }
		}

		protected AmsConsumerFormSubmissionViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerFormSubmissionViewHolder']/constructor[@name='AmsConsumerFormSubmissionViewHolder' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageType']]"
		[Register (".ctor", "(Landroid/view/View;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)V", "")]
		public unsafe AmsConsumerFormSubmissionViewHolder (global::Android.Views.View p0, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (AmsConsumerFormSubmissionViewHolder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/view/View;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/view/View;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)V", __args);
					return;
				}

				if (id_ctor_Landroid_view_View_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ == IntPtr.Zero)
					id_ctor_Landroid_view_View_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_view_View_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_, __args);
			} finally {
			}
		}

	}
}
