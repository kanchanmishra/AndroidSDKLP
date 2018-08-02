using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='Utils']"
	[global::Android.Runtime.Register ("com/liveperson/infra/utils/Utils", DoNotGenerateAcw=true)]
	public partial class Utils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='Utils']/field[@name='SHA1']"
		[Register ("SHA1")]
		public const string Sha1 = (string) "sha1/";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='Utils']/field[@name='SHA256']"
		[Register ("SHA256")]
		public const string Sha256 = (string) "sha256/";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/utils/Utils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Utils); }
		}

		protected Utils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='Utils']/constructor[@name='Utils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Utils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Utils)) {
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

		static IntPtr id_getResources;
		public static unsafe global::Android.Content.Res.Resources Resources {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='Utils']/method[@name='getResources' and count(parameter)=0]"
			[Register ("getResources", "()Landroid/content/res/Resources;", "GetGetResourcesHandler")]
			get {
				if (id_getResources == IntPtr.Zero)
					id_getResources = JNIEnv.GetStaticMethodID (class_ref, "getResources", "()Landroid/content/res/Resources;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getResources), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isValidCertificateKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='Utils']/method[@name='isValidCertificateKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isValidCertificateKey", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsValidCertificateKey (string p0)
		{
			if (id_isValidCertificateKey_Ljava_lang_String_ == IntPtr.Zero)
				id_isValidCertificateKey_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isValidCertificateKey", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isValidCertificateKey_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_tryParse_Ljava_lang_Object_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='Utils']/method[@name='tryParse' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='float']]"
		[Register ("tryParse", "(Ljava/lang/Object;F)F", "")]
		public static unsafe float TryParse (global::Java.Lang.Object p0, float p1)
		{
			if (id_tryParse_Ljava_lang_Object_F == IntPtr.Zero)
				id_tryParse_Ljava_lang_Object_F = JNIEnv.GetStaticMethodID (class_ref, "tryParse", "(Ljava/lang/Object;F)F");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_tryParse_Ljava_lang_Object_F, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_tryParse_Ljava_lang_Object_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='Utils']/method[@name='tryParse' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int']]"
		[Register ("tryParse", "(Ljava/lang/Object;I)I", "")]
		public static unsafe int TryParse (global::Java.Lang.Object p0, int p1)
		{
			if (id_tryParse_Ljava_lang_Object_I == IntPtr.Zero)
				id_tryParse_Ljava_lang_Object_I = JNIEnv.GetStaticMethodID (class_ref, "tryParse", "(Ljava/lang/Object;I)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_tryParse_Ljava_lang_Object_I, __args);
				return __ret;
			} finally {
			}
		}

	}
}
