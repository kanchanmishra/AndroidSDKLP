using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Dialog {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.dialog']/class[@name='ClearHistoryConfirmationDialog']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/dialog/ClearHistoryConfirmationDialog", DoNotGenerateAcw=true)]
	public partial class ClearHistoryConfirmationDialog : global::Android.App.DialogFragment {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.dialog']/class[@name='ClearHistoryConfirmationDialog']/field[@name='TARGET_ID']"
		[Register ("TARGET_ID")]
		public const string TargetId = (string) "target_id";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/dialog/ClearHistoryConfirmationDialog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClearHistoryConfirmationDialog); }
		}

		protected ClearHistoryConfirmationDialog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.dialog']/class[@name='ClearHistoryConfirmationDialog']/constructor[@name='ClearHistoryConfirmationDialog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ClearHistoryConfirmationDialog ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ClearHistoryConfirmationDialog)) {
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

		static IntPtr id_getInstance_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.dialog']/class[@name='ClearHistoryConfirmationDialog']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getInstance", "(Ljava/lang/String;)Lcom/liveperson/infra/messaging_ui/dialog/ClearHistoryConfirmationDialog;", "")]
		public static unsafe global::Com.Liveperson.Infra.Messaging_ui.Dialog.ClearHistoryConfirmationDialog GetInstance (string p0)
		{
			if (id_getInstance_Ljava_lang_String_ == IntPtr.Zero)
				id_getInstance_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Ljava/lang/String;)Lcom/liveperson/infra/messaging_ui/dialog/ClearHistoryConfirmationDialog;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Infra.Messaging_ui.Dialog.ClearHistoryConfirmationDialog __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Dialog.ClearHistoryConfirmationDialog> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
