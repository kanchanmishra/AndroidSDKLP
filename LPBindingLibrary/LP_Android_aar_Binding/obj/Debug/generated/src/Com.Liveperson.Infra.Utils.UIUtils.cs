using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='UIUtils']"
	[global::Android.Runtime.Register ("com/liveperson/infra/utils/UIUtils", DoNotGenerateAcw=true)]
	public partial class UIUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/utils/UIUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UIUtils); }
		}

		protected UIUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='UIUtils']/constructor[@name='UIUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UIUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UIUtils)) {
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

		static IntPtr id_hideKeyboard_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='UIUtils']/method[@name='hideKeyboard' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("hideKeyboard", "(Landroid/app/Activity;)V", "")]
		public static unsafe void HideKeyboard (global::Android.App.Activity p0)
		{
			if (id_hideKeyboard_Landroid_app_Activity_ == IntPtr.Zero)
				id_hideKeyboard_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "hideKeyboard", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_hideKeyboard_Landroid_app_Activity_, __args);
			} finally {
			}
		}

	}
}
