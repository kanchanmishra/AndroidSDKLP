using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Response.Types {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='DeliveryStatus']"
	[global::Android.Runtime.Register ("com/liveperson/api/response/types/DeliveryStatus", DoNotGenerateAcw=true)]
	public sealed partial class DeliveryStatus : global::Java.Lang.Enum {


		static IntPtr ABORTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='DeliveryStatus']/field[@name='ABORTED']"
		[Register ("ABORTED")]
		public static global::Com.Liveperson.Api.Response.Types.DeliveryStatus Aborted {
			get {
				if (ABORTED_jfieldId == IntPtr.Zero)
					ABORTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ABORTED", "Lcom/liveperson/api/response/types/DeliveryStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ABORTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.DeliveryStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ACCEPT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='DeliveryStatus']/field[@name='ACCEPT']"
		[Register ("ACCEPT")]
		public static global::Com.Liveperson.Api.Response.Types.DeliveryStatus Accept {
			get {
				if (ACCEPT_jfieldId == IntPtr.Zero)
					ACCEPT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCEPT", "Lcom/liveperson/api/response/types/DeliveryStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACCEPT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.DeliveryStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ACTION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='DeliveryStatus']/field[@name='ACTION']"
		[Register ("ACTION")]
		public static global::Com.Liveperson.Api.Response.Types.DeliveryStatus Action {
			get {
				if (ACTION_jfieldId == IntPtr.Zero)
					ACTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTION", "Lcom/liveperson/api/response/types/DeliveryStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.DeliveryStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='DeliveryStatus']/field[@name='ERROR']"
		[Register ("ERROR")]
		public static global::Com.Liveperson.Api.Response.Types.DeliveryStatus Error {
			get {
				if (ERROR_jfieldId == IntPtr.Zero)
					ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lcom/liveperson/api/response/types/DeliveryStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.DeliveryStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr READ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='DeliveryStatus']/field[@name='READ']"
		[Register ("READ")]
		public static global::Com.Liveperson.Api.Response.Types.DeliveryStatus Read {
			get {
				if (READ_jfieldId == IntPtr.Zero)
					READ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "READ", "Lcom/liveperson/api/response/types/DeliveryStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, READ_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.DeliveryStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SUBMITTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='DeliveryStatus']/field[@name='SUBMITTED']"
		[Register ("SUBMITTED")]
		public static global::Com.Liveperson.Api.Response.Types.DeliveryStatus Submitted {
			get {
				if (SUBMITTED_jfieldId == IntPtr.Zero)
					SUBMITTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUBMITTED", "Lcom/liveperson/api/response/types/DeliveryStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUBMITTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.DeliveryStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIEWED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='DeliveryStatus']/field[@name='VIEWED']"
		[Register ("VIEWED")]
		public static global::Com.Liveperson.Api.Response.Types.DeliveryStatus Viewed {
			get {
				if (VIEWED_jfieldId == IntPtr.Zero)
					VIEWED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIEWED", "Lcom/liveperson/api/response/types/DeliveryStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIEWED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.DeliveryStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/response/types/DeliveryStatus", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeliveryStatus); }
		}

		internal DeliveryStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='DeliveryStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/response/types/DeliveryStatus;", "")]
		public static unsafe global::Com.Liveperson.Api.Response.Types.DeliveryStatus ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/response/types/DeliveryStatus;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Api.Response.Types.DeliveryStatus __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.DeliveryStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='DeliveryStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/liveperson/api/response/types/DeliveryStatus;", "")]
		public static unsafe global::Com.Liveperson.Api.Response.Types.DeliveryStatus[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/api/response/types/DeliveryStatus;");
			try {
				return (global::Com.Liveperson.Api.Response.Types.DeliveryStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Api.Response.Types.DeliveryStatus));
			} finally {
			}
		}

	}
}
