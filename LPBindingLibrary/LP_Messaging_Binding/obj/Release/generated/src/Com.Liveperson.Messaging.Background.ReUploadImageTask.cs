using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Background {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='ReUploadImageTask']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/background/ReUploadImageTask", DoNotGenerateAcw=true)]
	public partial class ReUploadImageTask : global::Com.Liveperson.Messaging.Background.UploadImageTask {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/background/ReUploadImageTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReUploadImageTask); }
		}

		protected ReUploadImageTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_background_filesharing_image_ReUploadImageTaskBundle_Ljava_lang_Integer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='ReUploadImageTask']/constructor[@name='ReUploadImageTask' and count(parameter)=2 and parameter[1][@type='com.liveperson.messaging.background.filesharing.image.ReUploadImageTaskBundle'] and parameter[2][@type='java.lang.Integer']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/background/filesharing/image/ReUploadImageTaskBundle;Ljava/lang/Integer;)V", "")]
		public unsafe ReUploadImageTask (global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle p0, global::Java.Lang.Integer p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ReUploadImageTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/background/filesharing/image/ReUploadImageTaskBundle;Ljava/lang/Integer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/background/filesharing/image/ReUploadImageTaskBundle;Ljava/lang/Integer;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_background_filesharing_image_ReUploadImageTaskBundle_Ljava_lang_Integer_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_background_filesharing_image_ReUploadImageTaskBundle_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/background/filesharing/image/ReUploadImageTaskBundle;Ljava/lang/Integer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_background_filesharing_image_ReUploadImageTaskBundle_Ljava_lang_Integer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_background_filesharing_image_ReUploadImageTaskBundle_Ljava_lang_Integer_, __args);
			} finally {
			}
		}

	}
}
