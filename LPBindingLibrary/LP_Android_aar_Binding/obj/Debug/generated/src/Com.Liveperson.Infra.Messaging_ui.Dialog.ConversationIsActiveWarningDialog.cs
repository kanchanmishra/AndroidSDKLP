using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Dialog {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.dialog']/class[@name='ConversationIsActiveWarningDialog']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/dialog/ConversationIsActiveWarningDialog", DoNotGenerateAcw=true)]
	public partial class ConversationIsActiveWarningDialog : global::Android.App.DialogFragment {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/dialog/ConversationIsActiveWarningDialog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConversationIsActiveWarningDialog); }
		}

		protected ConversationIsActiveWarningDialog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.dialog']/class[@name='ConversationIsActiveWarningDialog']/constructor[@name='ConversationIsActiveWarningDialog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConversationIsActiveWarningDialog ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ConversationIsActiveWarningDialog)) {
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

		static IntPtr id_getInstance;
		public static unsafe global::Com.Liveperson.Infra.Messaging_ui.Dialog.ConversationIsActiveWarningDialog Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.dialog']/class[@name='ConversationIsActiveWarningDialog']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/liveperson/infra/messaging_ui/dialog/ConversationIsActiveWarningDialog;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/liveperson/infra/messaging_ui/dialog/ConversationIsActiveWarningDialog;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Dialog.ConversationIsActiveWarningDialog> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
