using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Viewpager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.viewpager']/class[@name='ViewPaperPageListener']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/structuredcontent/viewpager/ViewPaperPageListener", DoNotGenerateAcw=true)]
	public partial class ViewPaperPageListener : global::Android.Support.V4.View.ViewPager.SimpleOnPageChangeListener {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.viewpager']/class[@name='ViewPaperPageListener']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/structuredcontent/viewpager/ViewPaperPageListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewPaperPageListener); }
		}

		protected ViewPaperPageListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
