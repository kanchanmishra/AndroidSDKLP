using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LinkPreviewLruCache']"
	[global::Android.Runtime.Register ("com/liveperson/infra/utils/LinkPreviewLruCache", DoNotGenerateAcw=true)]
	public partial class LinkPreviewLruCache : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LinkPreviewLruCache']/field[@name='DEFAULT_NUM_OF_OBJECTS']"
		[Register ("DEFAULT_NUM_OF_OBJECTS")]
		public const int DefaultNumOfObjects = (int) 10;

		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LinkPreviewLruCache']/field[@name='TAG']"
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
				return JNIEnv.FindClass ("com/liveperson/infra/utils/LinkPreviewLruCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LinkPreviewLruCache); }
		}

		protected LinkPreviewLruCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Liveperson.Infra.Utils.LinkPreviewLruCache Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LinkPreviewLruCache']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/liveperson/infra/utils/LinkPreviewLruCache;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/liveperson/infra/utils/LinkPreviewLruCache;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LinkPreviewLruCache> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addSourceContentToCache_Ljava_lang_String_Lcom_liveperson_infra_utils_SourceContent_;
#pragma warning disable 0169
		static Delegate GetAddSourceContentToCache_Ljava_lang_String_Lcom_liveperson_infra_utils_SourceContent_Handler ()
		{
			if (cb_addSourceContentToCache_Ljava_lang_String_Lcom_liveperson_infra_utils_SourceContent_ == null)
				cb_addSourceContentToCache_Ljava_lang_String_Lcom_liveperson_infra_utils_SourceContent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddSourceContentToCache_Ljava_lang_String_Lcom_liveperson_infra_utils_SourceContent_);
			return cb_addSourceContentToCache_Ljava_lang_String_Lcom_liveperson_infra_utils_SourceContent_;
		}

		static void n_AddSourceContentToCache_Ljava_lang_String_Lcom_liveperson_infra_utils_SourceContent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Utils.LinkPreviewLruCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LinkPreviewLruCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Utils.SourceContent p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddSourceContentToCache (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addSourceContentToCache_Ljava_lang_String_Lcom_liveperson_infra_utils_SourceContent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LinkPreviewLruCache']/method[@name='addSourceContentToCache' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.utils.SourceContent']]"
		[Register ("addSourceContentToCache", "(Ljava/lang/String;Lcom/liveperson/infra/utils/SourceContent;)V", "GetAddSourceContentToCache_Ljava_lang_String_Lcom_liveperson_infra_utils_SourceContent_Handler")]
		public virtual unsafe void AddSourceContentToCache (string p0, global::Com.Liveperson.Infra.Utils.SourceContent p1)
		{
			if (id_addSourceContentToCache_Ljava_lang_String_Lcom_liveperson_infra_utils_SourceContent_ == IntPtr.Zero)
				id_addSourceContentToCache_Ljava_lang_String_Lcom_liveperson_infra_utils_SourceContent_ = JNIEnv.GetMethodID (class_ref, "addSourceContentToCache", "(Ljava/lang/String;Lcom/liveperson/infra/utils/SourceContent;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addSourceContentToCache_Ljava_lang_String_Lcom_liveperson_infra_utils_SourceContent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addSourceContentToCache", "(Ljava/lang/String;Lcom/liveperson/infra/utils/SourceContent;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getSourceContentFromCache_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSourceContentFromCache_Ljava_lang_String_Handler ()
		{
			if (cb_getSourceContentFromCache_Ljava_lang_String_ == null)
				cb_getSourceContentFromCache_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSourceContentFromCache_Ljava_lang_String_);
			return cb_getSourceContentFromCache_Ljava_lang_String_;
		}

		static IntPtr n_GetSourceContentFromCache_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.LinkPreviewLruCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LinkPreviewLruCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSourceContentFromCache (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSourceContentFromCache_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LinkPreviewLruCache']/method[@name='getSourceContentFromCache' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSourceContentFromCache", "(Ljava/lang/String;)Lcom/liveperson/infra/utils/SourceContent;", "GetGetSourceContentFromCache_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Utils.SourceContent GetSourceContentFromCache (string p0)
		{
			if (id_getSourceContentFromCache_Ljava_lang_String_ == IntPtr.Zero)
				id_getSourceContentFromCache_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getSourceContentFromCache", "(Ljava/lang/String;)Lcom/liveperson/infra/utils/SourceContent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Utils.SourceContent __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSourceContentFromCache_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSourceContentFromCache", "(Ljava/lang/String;)Lcom/liveperson/infra/utils/SourceContent;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
