using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='FeaturesWrapperUtil']"
	[global::Android.Runtime.Register ("com/liveperson/infra/utils/FeaturesWrapperUtil", DoNotGenerateAcw=true)]
	public partial class FeaturesWrapperUtil : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/utils/FeaturesWrapperUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FeaturesWrapperUtil); }
		}

		protected FeaturesWrapperUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='FeaturesWrapperUtil']/constructor[@name='FeaturesWrapperUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FeaturesWrapperUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FeaturesWrapperUtil)) {
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

		static IntPtr id_getAllFeatures;
		public static unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Boolean> AllFeatures {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='FeaturesWrapperUtil']/method[@name='getAllFeatures' and count(parameter)=0]"
			[Register ("getAllFeatures", "()Ljava/util/HashMap;", "GetGetAllFeaturesHandler")]
			get {
				if (id_getAllFeatures == IntPtr.Zero)
					id_getAllFeatures = JNIEnv.GetStaticMethodID (class_ref, "getAllFeatures", "()Ljava/util/HashMap;");
				try {
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAllFeatures), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Liveperson.Infra.Utils.FeaturesWrapperUtil Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='FeaturesWrapperUtil']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/liveperson/infra/utils/FeaturesWrapperUtil;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/liveperson/infra/utils/FeaturesWrapperUtil;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.FeaturesWrapperUtil> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getFeature_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='FeaturesWrapperUtil']/method[@name='getFeature' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFeature", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool GetFeature (string p0)
		{
			if (id_getFeature_Ljava_lang_String_ == IntPtr.Zero)
				id_getFeature_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getFeature", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_getFeature_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_putFeature_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='FeaturesWrapperUtil']/method[@name='putFeature' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("putFeature", "(Ljava/lang/String;Z)V", "")]
		public static unsafe void PutFeature (string p0, bool p1)
		{
			if (id_putFeature_Ljava_lang_String_Z == IntPtr.Zero)
				id_putFeature_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "putFeature", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_putFeature_Ljava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
