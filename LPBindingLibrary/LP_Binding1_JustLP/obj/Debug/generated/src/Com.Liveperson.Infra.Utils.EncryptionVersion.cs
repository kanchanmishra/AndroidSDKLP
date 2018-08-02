using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='EncryptionVersion']"
	[global::Android.Runtime.Register ("com/liveperson/infra/utils/EncryptionVersion", DoNotGenerateAcw=true)]
	public sealed partial class EncryptionVersion : global::Java.Lang.Enum {


		static IntPtr NONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='EncryptionVersion']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Com.Liveperson.Infra.Utils.EncryptionVersion None {
			get {
				if (NONE_jfieldId == IntPtr.Zero)
					NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/liveperson/infra/utils/EncryptionVersion;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.EncryptionVersion> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VERSION_1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='EncryptionVersion']/field[@name='VERSION_1']"
		[Register ("VERSION_1")]
		public static global::Com.Liveperson.Infra.Utils.EncryptionVersion Version1 {
			get {
				if (VERSION_1_jfieldId == IntPtr.Zero)
					VERSION_1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERSION_1", "Lcom/liveperson/infra/utils/EncryptionVersion;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VERSION_1_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.EncryptionVersion> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/utils/EncryptionVersion", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EncryptionVersion); }
		}

		internal EncryptionVersion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_fromInt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='EncryptionVersion']/method[@name='fromInt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromInt", "(I)Lcom/liveperson/infra/utils/EncryptionVersion;", "")]
		public static unsafe global::Com.Liveperson.Infra.Utils.EncryptionVersion FromInt (int p0)
		{
			if (id_fromInt_I == IntPtr.Zero)
				id_fromInt_I = JNIEnv.GetStaticMethodID (class_ref, "fromInt", "(I)Lcom/liveperson/infra/utils/EncryptionVersion;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.EncryptionVersion> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromInt_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='EncryptionVersion']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/utils/EncryptionVersion;", "")]
		public static unsafe global::Com.Liveperson.Infra.Utils.EncryptionVersion ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/utils/EncryptionVersion;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Infra.Utils.EncryptionVersion __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.EncryptionVersion> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='EncryptionVersion']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/liveperson/infra/utils/EncryptionVersion;", "")]
		public static unsafe global::Com.Liveperson.Infra.Utils.EncryptionVersion[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/infra/utils/EncryptionVersion;");
			try {
				return (global::Com.Liveperson.Infra.Utils.EncryptionVersion[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Infra.Utils.EncryptionVersion));
			} finally {
			}
		}

	}
}
