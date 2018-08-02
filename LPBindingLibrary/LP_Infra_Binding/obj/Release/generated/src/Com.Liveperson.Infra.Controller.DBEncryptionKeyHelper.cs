using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Controller {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.controller']/class[@name='DBEncryptionKeyHelper']"
	[global::Android.Runtime.Register ("com/liveperson/infra/controller/DBEncryptionKeyHelper", DoNotGenerateAcw=true)]
	public partial class DBEncryptionKeyHelper : global::Java.Lang.Object, global::Com.Liveperson.Infra.IClearable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/controller/DBEncryptionKeyHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DBEncryptionKeyHelper); }
		}

		protected DBEncryptionKeyHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.controller']/class[@name='DBEncryptionKeyHelper']/constructor[@name='DBEncryptionKeyHelper' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe DBEncryptionKeyHelper (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (DBEncryptionKeyHelper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Controller.DBEncryptionKeyHelper __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Controller.DBEncryptionKeyHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.controller']/class[@name='DBEncryptionKeyHelper']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static IntPtr id_getAppEncryptionVersion_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.controller']/class[@name='DBEncryptionKeyHelper']/method[@name='getAppEncryptionVersion' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAppEncryptionVersion", "(Landroid/content/Context;)Lcom/liveperson/infra/utils/EncryptionVersion;", "")]
		public static unsafe global::Com.Liveperson.Infra.Utils.EncryptionVersion GetAppEncryptionVersion (global::Android.Content.Context p0)
		{
			if (id_getAppEncryptionVersion_Landroid_content_Context_ == IntPtr.Zero)
				id_getAppEncryptionVersion_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAppEncryptionVersion", "(Landroid/content/Context;)Lcom/liveperson/infra/utils/EncryptionVersion;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Liveperson.Infra.Utils.EncryptionVersion __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.EncryptionVersion> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppEncryptionVersion_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
