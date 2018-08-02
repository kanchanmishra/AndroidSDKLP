using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.Utils']/class[@name='TokenUtils']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/Utils/TokenUtils", DoNotGenerateAcw=true)]
	public partial class TokenUtils : global::Java.Lang.Object {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.Utils']/class[@name='TokenUtils']/field[@name='TAG']"
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
				return JNIEnv.FindClass ("com/liveperson/messaging/Utils/TokenUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TokenUtils); }
		}

		protected TokenUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.Utils']/class[@name='TokenUtils']/constructor[@name='TokenUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TokenUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TokenUtils)) {
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

		static IntPtr id_getConsumerUserId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.Utils']/class[@name='TokenUtils']/method[@name='getConsumerUserId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getConsumerUserId", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetConsumerUserId (string p0)
		{
			if (id_getConsumerUserId_Ljava_lang_String_ == IntPtr.Zero)
				id_getConsumerUserId_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getConsumerUserId", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getConsumerUserId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getOriginalConsumerIdFromJWT_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.Utils']/class[@name='TokenUtils']/method[@name='getOriginalConsumerIdFromJWT' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getOriginalConsumerIdFromJWT", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetOriginalConsumerIdFromJWT (string p0)
		{
			if (id_getOriginalConsumerIdFromJWT_Ljava_lang_String_ == IntPtr.Zero)
				id_getOriginalConsumerIdFromJWT_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getOriginalConsumerIdFromJWT", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOriginalConsumerIdFromJWT_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isJwtExpired_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.Utils']/class[@name='TokenUtils']/method[@name='isJwtExpired' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isJwtExpired", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsJwtExpired (string p0)
		{
			if (id_isJwtExpired_Ljava_lang_String_ == IntPtr.Zero)
				id_isJwtExpired_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isJwtExpired", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isJwtExpired_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
