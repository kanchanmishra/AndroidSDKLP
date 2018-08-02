using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='AccessibilityChecker']"
	[global::Android.Runtime.Register ("com/liveperson/infra/utils/AccessibilityChecker", DoNotGenerateAcw=true)]
	public partial class AccessibilityChecker : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/utils/AccessibilityChecker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AccessibilityChecker); }
		}

		protected AccessibilityChecker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='AccessibilityChecker']/constructor[@name='AccessibilityChecker' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AccessibilityChecker ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AccessibilityChecker)) {
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

		static IntPtr id_exploreByTouchEnabled_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='AccessibilityChecker']/method[@name='exploreByTouchEnabled' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("exploreByTouchEnabled", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool ExploreByTouchEnabled (global::Android.Content.Context p0)
		{
			if (id_exploreByTouchEnabled_Landroid_content_Context_ == IntPtr.Zero)
				id_exploreByTouchEnabled_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "exploreByTouchEnabled", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_exploreByTouchEnabled_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
