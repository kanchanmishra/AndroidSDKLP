using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Response.Types {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='TTRType']"
	[global::Android.Runtime.Register ("com/liveperson/api/response/types/TTRType", DoNotGenerateAcw=true)]
	public sealed partial class TTRType : global::Java.Lang.Enum {


		static IntPtr CUSTOM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='TTRType']/field[@name='CUSTOM']"
		[Register ("CUSTOM")]
		public static global::Com.Liveperson.Api.Response.Types.TTRType Custom {
			get {
				if (CUSTOM_jfieldId == IntPtr.Zero)
					CUSTOM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CUSTOM", "Lcom/liveperson/api/response/types/TTRType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CUSTOM_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.TTRType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NIGHT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='TTRType']/field[@name='NIGHT']"
		[Register ("NIGHT")]
		public static global::Com.Liveperson.Api.Response.Types.TTRType Night {
			get {
				if (NIGHT_jfieldId == IntPtr.Zero)
					NIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NIGHT", "Lcom/liveperson/api/response/types/TTRType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NIGHT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.TTRType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NORMAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='TTRType']/field[@name='NORMAL']"
		[Register ("NORMAL")]
		public static global::Com.Liveperson.Api.Response.Types.TTRType Normal {
			get {
				if (NORMAL_jfieldId == IntPtr.Zero)
					NORMAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NORMAL", "Lcom/liveperson/api/response/types/TTRType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NORMAL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.TTRType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PRIORITIZED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='TTRType']/field[@name='PRIORITIZED']"
		[Register ("PRIORITIZED")]
		public static global::Com.Liveperson.Api.Response.Types.TTRType Prioritized {
			get {
				if (PRIORITIZED_jfieldId == IntPtr.Zero)
					PRIORITIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PRIORITIZED", "Lcom/liveperson/api/response/types/TTRType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PRIORITIZED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.TTRType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr URGENT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='TTRType']/field[@name='URGENT']"
		[Register ("URGENT")]
		public static global::Com.Liveperson.Api.Response.Types.TTRType Urgent {
			get {
				if (URGENT_jfieldId == IntPtr.Zero)
					URGENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "URGENT", "Lcom/liveperson/api/response/types/TTRType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, URGENT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.TTRType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/response/types/TTRType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TTRType); }
		}

		internal TTRType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='TTRType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/response/types/TTRType;", "")]
		public static unsafe global::Com.Liveperson.Api.Response.Types.TTRType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/response/types/TTRType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Api.Response.Types.TTRType __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.TTRType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='TTRType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/liveperson/api/response/types/TTRType;", "")]
		public static unsafe global::Com.Liveperson.Api.Response.Types.TTRType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/api/response/types/TTRType;");
			try {
				return (global::Com.Liveperson.Api.Response.Types.TTRType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Api.Response.Types.TTRType));
			} finally {
			}
		}

	}
}
