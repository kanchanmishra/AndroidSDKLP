using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Monitoring.Sdk.Callbacks {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.monitoring.sdk.callbacks']/class[@name='MonitoringErrorType']"
	[global::Android.Runtime.Register ("com/liveperson/monitoring/sdk/callbacks/MonitoringErrorType", DoNotGenerateAcw=true)]
	public sealed partial class MonitoringErrorType : global::Java.Lang.Enum {


		static IntPtr CSDS_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.monitoring.sdk.callbacks']/class[@name='MonitoringErrorType']/field[@name='CSDS_ERROR']"
		[Register ("CSDS_ERROR")]
		public static global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType CsdsError {
			get {
				if (CSDS_ERROR_jfieldId == IntPtr.Zero)
					CSDS_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CSDS_ERROR", "Lcom/liveperson/monitoring/sdk/callbacks/MonitoringErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CSDS_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INITIALIZATION_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.monitoring.sdk.callbacks']/class[@name='MonitoringErrorType']/field[@name='INITIALIZATION_ERROR']"
		[Register ("INITIALIZATION_ERROR")]
		public static global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType InitializationError {
			get {
				if (INITIALIZATION_ERROR_jfieldId == IntPtr.Zero)
					INITIALIZATION_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INITIALIZATION_ERROR", "Lcom/liveperson/monitoring/sdk/callbacks/MonitoringErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INITIALIZATION_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LOGOUT_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.monitoring.sdk.callbacks']/class[@name='MonitoringErrorType']/field[@name='LOGOUT_ERROR']"
		[Register ("LOGOUT_ERROR")]
		public static global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType LogoutError {
			get {
				if (LOGOUT_ERROR_jfieldId == IntPtr.Zero)
					LOGOUT_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOGOUT_ERROR", "Lcom/liveperson/monitoring/sdk/callbacks/MonitoringErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOGOUT_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NOT_INITIALIZED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.monitoring.sdk.callbacks']/class[@name='MonitoringErrorType']/field[@name='NOT_INITIALIZED']"
		[Register ("NOT_INITIALIZED")]
		public static global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType NotInitialized {
			get {
				if (NOT_INITIALIZED_jfieldId == IntPtr.Zero)
					NOT_INITIALIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_INITIALIZED", "Lcom/liveperson/monitoring/sdk/callbacks/MonitoringErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_INITIALIZED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NO_NETWORK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.monitoring.sdk.callbacks']/class[@name='MonitoringErrorType']/field[@name='NO_NETWORK']"
		[Register ("NO_NETWORK")]
		public static global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType NoNetwork {
			get {
				if (NO_NETWORK_jfieldId == IntPtr.Zero)
					NO_NETWORK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_NETWORK", "Lcom/liveperson/monitoring/sdk/callbacks/MonitoringErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_NETWORK_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PARAMETER_MISSING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.monitoring.sdk.callbacks']/class[@name='MonitoringErrorType']/field[@name='PARAMETER_MISSING']"
		[Register ("PARAMETER_MISSING")]
		public static global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType ParameterMissing {
			get {
				if (PARAMETER_MISSING_jfieldId == IntPtr.Zero)
					PARAMETER_MISSING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PARAMETER_MISSING", "Lcom/liveperson/monitoring/sdk/callbacks/MonitoringErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PARAMETER_MISSING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr REQUEST_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.monitoring.sdk.callbacks']/class[@name='MonitoringErrorType']/field[@name='REQUEST_ERROR']"
		[Register ("REQUEST_ERROR")]
		public static global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType RequestError {
			get {
				if (REQUEST_ERROR_jfieldId == IntPtr.Zero)
					REQUEST_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REQUEST_ERROR", "Lcom/liveperson/monitoring/sdk/callbacks/MonitoringErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REQUEST_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/monitoring/sdk/callbacks/MonitoringErrorType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MonitoringErrorType); }
		}

		internal MonitoringErrorType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.sdk.callbacks']/class[@name='MonitoringErrorType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/monitoring/sdk/callbacks/MonitoringErrorType;", "")]
		public static unsafe global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/monitoring/sdk/callbacks/MonitoringErrorType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.sdk.callbacks']/class[@name='MonitoringErrorType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/liveperson/monitoring/sdk/callbacks/MonitoringErrorType;", "")]
		public static unsafe global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/monitoring/sdk/callbacks/MonitoringErrorType;");
			try {
				return (global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType));
			} finally {
			}
		}

	}
}
