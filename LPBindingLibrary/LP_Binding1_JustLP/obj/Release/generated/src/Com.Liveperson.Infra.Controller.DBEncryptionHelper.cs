using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Controller {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.controller']/class[@name='DBEncryptionHelper']"
	[global::Android.Runtime.Register ("com/liveperson/infra/controller/DBEncryptionHelper", DoNotGenerateAcw=true)]
	public partial class DBEncryptionHelper : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/controller/DBEncryptionHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DBEncryptionHelper); }
		}

		protected DBEncryptionHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.controller']/class[@name='DBEncryptionHelper']/constructor[@name='DBEncryptionHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DBEncryptionHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DBEncryptionHelper)) {
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

		static IntPtr id_decrypt_Lcom_liveperson_infra_utils_EncryptionVersion_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.controller']/class[@name='DBEncryptionHelper']/method[@name='decrypt' and count(parameter)=2 and parameter[1][@type='com.liveperson.infra.utils.EncryptionVersion'] and parameter[2][@type='java.lang.String']]"
		[Register ("decrypt", "(Lcom/liveperson/infra/utils/EncryptionVersion;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Decrypt (global::Com.Liveperson.Infra.Utils.EncryptionVersion p0, string p1)
		{
			if (id_decrypt_Lcom_liveperson_infra_utils_EncryptionVersion_Ljava_lang_String_ == IntPtr.Zero)
				id_decrypt_Lcom_liveperson_infra_utils_EncryptionVersion_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decrypt", "(Lcom/liveperson/infra/utils/EncryptionVersion;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_decrypt_Lcom_liveperson_infra_utils_EncryptionVersion_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_encrypt_Lcom_liveperson_infra_utils_EncryptionVersion_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.controller']/class[@name='DBEncryptionHelper']/method[@name='encrypt' and count(parameter)=2 and parameter[1][@type='com.liveperson.infra.utils.EncryptionVersion'] and parameter[2][@type='java.lang.String']]"
		[Register ("encrypt", "(Lcom/liveperson/infra/utils/EncryptionVersion;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Encrypt (global::Com.Liveperson.Infra.Utils.EncryptionVersion p0, string p1)
		{
			if (id_encrypt_Lcom_liveperson_infra_utils_EncryptionVersion_Ljava_lang_String_ == IntPtr.Zero)
				id_encrypt_Lcom_liveperson_infra_utils_EncryptionVersion_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encrypt", "(Lcom/liveperson/infra/utils/EncryptionVersion;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encrypt_Lcom_liveperson_infra_utils_EncryptionVersion_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
