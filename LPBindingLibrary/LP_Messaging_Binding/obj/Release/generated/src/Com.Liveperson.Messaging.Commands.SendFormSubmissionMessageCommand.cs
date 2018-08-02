using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Commands {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendFormSubmissionMessageCommand']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/commands/SendFormSubmissionMessageCommand", DoNotGenerateAcw=true)]
	public partial class SendFormSubmissionMessageCommand : global::Com.Liveperson.Messaging.Commands.SendMessageCommand {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/commands/SendFormSubmissionMessageCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SendFormSubmissionMessageCommand); }
		}

		protected SendFormSubmissionMessageCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_model_Form_Lcom_liveperson_infra_utils_MaskedMessage_Lcom_liveperson_messaging_Messaging_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendFormSubmissionMessageCommand']/constructor[@name='SendFormSubmissionMessageCommand' and count(parameter)=3 and parameter[1][@type='com.liveperson.messaging.model.Form'] and parameter[2][@type='com.liveperson.infra.utils.MaskedMessage'] and parameter[3][@type='com.liveperson.messaging.Messaging']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/model/Form;Lcom/liveperson/infra/utils/MaskedMessage;Lcom/liveperson/messaging/Messaging;)V", "")]
		public unsafe SendFormSubmissionMessageCommand (global::Com.Liveperson.Messaging.Model.Form p0, global::Com.Liveperson.Infra.Utils.MaskedMessage p1, global::Com.Liveperson.Messaging.Messaging p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (SendFormSubmissionMessageCommand)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/model/Form;Lcom/liveperson/infra/utils/MaskedMessage;Lcom/liveperson/messaging/Messaging;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/model/Form;Lcom/liveperson/infra/utils/MaskedMessage;Lcom/liveperson/messaging/Messaging;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_model_Form_Lcom_liveperson_infra_utils_MaskedMessage_Lcom_liveperson_messaging_Messaging_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_model_Form_Lcom_liveperson_infra_utils_MaskedMessage_Lcom_liveperson_messaging_Messaging_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/model/Form;Lcom/liveperson/infra/utils/MaskedMessage;Lcom/liveperson/messaging/Messaging;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_model_Form_Lcom_liveperson_infra_utils_MaskedMessage_Lcom_liveperson_messaging_Messaging_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_model_Form_Lcom_liveperson_infra_utils_MaskedMessage_Lcom_liveperson_messaging_Messaging_, __args);
			} finally {
			}
		}

	}
}
