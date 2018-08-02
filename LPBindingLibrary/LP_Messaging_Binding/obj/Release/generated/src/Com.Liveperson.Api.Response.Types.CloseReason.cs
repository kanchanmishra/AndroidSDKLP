using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Response.Types {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CloseReason']"
	[global::Android.Runtime.Register ("com/liveperson/api/response/types/CloseReason", DoNotGenerateAcw=true)]
	public sealed partial class CloseReason : global::Java.Lang.Enum {


		static IntPtr AGENT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CloseReason']/field[@name='AGENT']"
		[Register ("AGENT")]
		public static global::Com.Liveperson.Api.Response.Types.CloseReason Agent {
			get {
				if (AGENT_jfieldId == IntPtr.Zero)
					AGENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AGENT", "Lcom/liveperson/api/response/types/CloseReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AGENT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CloseReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CONSUMER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CloseReason']/field[@name='CONSUMER']"
		[Register ("CONSUMER")]
		public static global::Com.Liveperson.Api.Response.Types.CloseReason Consumer {
			get {
				if (CONSUMER_jfieldId == IntPtr.Zero)
					CONSUMER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONSUMER", "Lcom/liveperson/api/response/types/CloseReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONSUMER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CloseReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SYSTEM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CloseReason']/field[@name='SYSTEM']"
		[Register ("SYSTEM")]
		public static global::Com.Liveperson.Api.Response.Types.CloseReason System {
			get {
				if (SYSTEM_jfieldId == IntPtr.Zero)
					SYSTEM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SYSTEM", "Lcom/liveperson/api/response/types/CloseReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SYSTEM_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CloseReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TIMEOUT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CloseReason']/field[@name='TIMEOUT']"
		[Register ("TIMEOUT")]
		public static global::Com.Liveperson.Api.Response.Types.CloseReason Timeout {
			get {
				if (TIMEOUT_jfieldId == IntPtr.Zero)
					TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TIMEOUT", "Lcom/liveperson/api/response/types/CloseReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TIMEOUT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CloseReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/response/types/CloseReason", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CloseReason); }
		}

		internal CloseReason (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CloseReason']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/response/types/CloseReason;", "")]
		public static unsafe global::Com.Liveperson.Api.Response.Types.CloseReason ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/response/types/CloseReason;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Api.Response.Types.CloseReason __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CloseReason> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CloseReason']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/liveperson/api/response/types/CloseReason;", "")]
		public static unsafe global::Com.Liveperson.Api.Response.Types.CloseReason[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/api/response/types/CloseReason;");
			try {
				return (global::Com.Liveperson.Api.Response.Types.CloseReason[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Api.Response.Types.CloseReason));
			} finally {
			}
		}

	}
}
