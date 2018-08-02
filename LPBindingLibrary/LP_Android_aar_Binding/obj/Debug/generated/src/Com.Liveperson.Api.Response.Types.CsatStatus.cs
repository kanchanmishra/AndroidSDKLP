using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Response.Types {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CsatStatus']"
	[global::Android.Runtime.Register ("com/liveperson/api/response/types/CsatStatus", DoNotGenerateAcw=true)]
	public sealed partial class CsatStatus : global::Java.Lang.Enum {


		static IntPtr EMPTY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CsatStatus']/field[@name='EMPTY']"
		[Register ("EMPTY")]
		public static global::Com.Liveperson.Api.Response.Types.CsatStatus Empty {
			get {
				if (EMPTY_jfieldId == IntPtr.Zero)
					EMPTY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY", "Lcom/liveperson/api/response/types/CsatStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EMPTY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CsatStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FILLED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CsatStatus']/field[@name='FILLED']"
		[Register ("FILLED")]
		public static global::Com.Liveperson.Api.Response.Types.CsatStatus Filled {
			get {
				if (FILLED_jfieldId == IntPtr.Zero)
					FILLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FILLED", "Lcom/liveperson/api/response/types/CsatStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FILLED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CsatStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PARTIALLY_FILLED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CsatStatus']/field[@name='PARTIALLY_FILLED']"
		[Register ("PARTIALLY_FILLED")]
		public static global::Com.Liveperson.Api.Response.Types.CsatStatus PartiallyFilled {
			get {
				if (PARTIALLY_FILLED_jfieldId == IntPtr.Zero)
					PARTIALLY_FILLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PARTIALLY_FILLED", "Lcom/liveperson/api/response/types/CsatStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PARTIALLY_FILLED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CsatStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SKIPPED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CsatStatus']/field[@name='SKIPPED']"
		[Register ("SKIPPED")]
		public static global::Com.Liveperson.Api.Response.Types.CsatStatus Skipped {
			get {
				if (SKIPPED_jfieldId == IntPtr.Zero)
					SKIPPED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SKIPPED", "Lcom/liveperson/api/response/types/CsatStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SKIPPED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CsatStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/response/types/CsatStatus", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CsatStatus); }
		}

		internal CsatStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getValue;
		public unsafe string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CsatStatus']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CsatStatus']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lcom/liveperson/api/response/types/CsatStatus;", "")]
		public static unsafe global::Com.Liveperson.Api.Response.Types.CsatStatus Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Ljava/lang/String;)Lcom/liveperson/api/response/types/CsatStatus;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Api.Response.Types.CsatStatus __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CsatStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CsatStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/response/types/CsatStatus;", "")]
		public static unsafe global::Com.Liveperson.Api.Response.Types.CsatStatus ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/response/types/CsatStatus;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Api.Response.Types.CsatStatus __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CsatStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CsatStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/liveperson/api/response/types/CsatStatus;", "")]
		public static unsafe global::Com.Liveperson.Api.Response.Types.CsatStatus[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/api/response/types/CsatStatus;");
			try {
				return (global::Com.Liveperson.Api.Response.Types.CsatStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Api.Response.Types.CsatStatus));
			} finally {
			}
		}

	}
}
