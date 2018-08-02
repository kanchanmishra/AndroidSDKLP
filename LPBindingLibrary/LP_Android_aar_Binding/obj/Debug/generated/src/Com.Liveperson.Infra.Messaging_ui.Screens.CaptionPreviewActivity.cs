using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Screens {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.screens']/class[@name='CaptionPreviewActivity']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/screens/CaptionPreviewActivity", DoNotGenerateAcw=true)]
	public partial class CaptionPreviewActivity : global::Android.Support.V7.App.AppCompatActivity {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.screens']/class[@name='CaptionPreviewActivity']/field[@name='AUTH_KEY']"
		[Register ("AUTH_KEY")]
		public const string AuthKey = (string) "AUTH_KEY";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.screens']/class[@name='CaptionPreviewActivity']/field[@name='BRAND_ID']"
		[Register ("BRAND_ID")]
		public const string BrandId = (string) "BRAND_ID";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.screens']/class[@name='CaptionPreviewActivity']/field[@name='IMAGE_FROM_CAMERA']"
		[Register ("IMAGE_FROM_CAMERA")]
		public const string ImageFromCamera = (string) "IMAGE_FROM_CAMERA";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.screens']/class[@name='CaptionPreviewActivity']/field[@name='IMAGE_ORIENTATION']"
		[Register ("IMAGE_ORIENTATION")]
		public const string ImageOrientation = (string) "IMAGE_ORIENTATION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.screens']/class[@name='CaptionPreviewActivity']/field[@name='IMAGE_URI']"
		[Register ("IMAGE_URI")]
		public const string ImageUri = (string) "IMAGE_URI";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.screens']/class[@name='CaptionPreviewActivity']/field[@name='TARGET_ID']"
		[Register ("TARGET_ID")]
		public const string TargetId = (string) "TARGET_ID";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.screens']/class[@name='CaptionPreviewActivity']/field[@name='VIEW_PARAMS']"
		[Register ("VIEW_PARAMS")]
		public const string ViewParams = (string) "VIEW_PARAMS";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/screens/CaptionPreviewActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CaptionPreviewActivity); }
		}

		protected CaptionPreviewActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.screens']/class[@name='CaptionPreviewActivity']/constructor[@name='CaptionPreviewActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CaptionPreviewActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CaptionPreviewActivity)) {
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

	}
}
