using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentFormInvitationViewHolder']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsAgentFormInvitationViewHolder", DoNotGenerateAcw=true)]
	public partial class AmsAgentFormInvitationViewHolder : global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentViewHolder {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentFormInvitationViewHolder']/field[@name='EXTRA_MESSAGE_STATE']"
		[Register ("EXTRA_MESSAGE_STATE")]
		public const string ExtraMessageState = (string) "EXTRA_MESSAGE_STATE";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsAgentFormInvitationViewHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsAgentFormInvitationViewHolder); }
		}

		protected AmsAgentFormInvitationViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_Ljava_lang_String_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentFormInvitationViewHolder']/constructor[@name='AmsAgentFormInvitationViewHolder' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.infra.messaging_ui.view.adapter.copybehavior.CopyBehavior']]"
		[Register (".ctor", "(Landroid/view/View;Ljava/lang/String;Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior;)V", "")]
		public unsafe AmsAgentFormInvitationViewHolder (global::Android.Views.View p0, string p1, global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (AmsAgentFormInvitationViewHolder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/view/View;Ljava/lang/String;Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/view/View;Ljava/lang/String;Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior;)V", __args);
					return;
				}

				if (id_ctor_Landroid_view_View_Ljava_lang_String_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_ == IntPtr.Zero)
					id_ctor_Landroid_view_View_Ljava_lang_String_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;Ljava/lang/String;Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_Ljava_lang_String_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_view_View_Ljava_lang_String_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setViewAppearanceByState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_;
#pragma warning disable 0169
		static Delegate GetSetViewAppearanceByState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Handler ()
		{
			if (cb_setViewAppearanceByState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ == null)
				cb_setViewAppearanceByState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetViewAppearanceByState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_);
			return cb_setViewAppearanceByState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_;
		}

		static void n_SetViewAppearanceByState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentFormInvitationViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentFormInvitationViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetViewAppearanceByState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setViewAppearanceByState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentFormInvitationViewHolder']/method[@name='setViewAppearanceByState' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageState']]"
		[Register ("setViewAppearanceByState", "(Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;)V", "GetSetViewAppearanceByState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Handler")]
		public virtual unsafe void SetViewAppearanceByState (global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState p0)
		{
			if (id_setViewAppearanceByState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ == IntPtr.Zero)
				id_setViewAppearanceByState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ = JNIEnv.GetMethodID (class_ref, "setViewAppearanceByState", "(Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setViewAppearanceByState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setViewAppearanceByState", "(Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;)V"), __args);
			} finally {
			}
		}

	}
}
