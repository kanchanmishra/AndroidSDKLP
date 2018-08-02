using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LivePersonConfiguration']"
	[global::Android.Runtime.Register ("com/liveperson/infra/LivePersonConfiguration", DoNotGenerateAcw=true)]
	public partial class LivePersonConfiguration : global::Java.Lang.Object {


		public static class InterfaceConsts {

			// The following are fields from: com.liveperson.infra.IConfiguration

			static IntPtr mFeaturesMap_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/interface[@name='IConfiguration']/field[@name='mFeaturesMap']"
			[Register ("mFeaturesMap")]
			public static global::System.Collections.IDictionary MFeaturesMap {
				get {
					if (mFeaturesMap_jfieldId == IntPtr.Zero)
						mFeaturesMap_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mFeaturesMap", "Ljava/util/HashMap;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, mFeaturesMap_jfieldId);
					return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/LivePersonConfiguration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LivePersonConfiguration); }
		}

		protected LivePersonConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_HashMap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LivePersonConfiguration']/constructor[@name='LivePersonConfiguration' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.Boolean&gt;']]"
		[Register (".ctor", "(Ljava/util/HashMap;)V", "")]
		public unsafe LivePersonConfiguration (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Boolean> p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (LivePersonConfiguration)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/HashMap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/HashMap;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_HashMap_ == IntPtr.Zero)
					id_ctor_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/HashMap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_HashMap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_HashMap_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
