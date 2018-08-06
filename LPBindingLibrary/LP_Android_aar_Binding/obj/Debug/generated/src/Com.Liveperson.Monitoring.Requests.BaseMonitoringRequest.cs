using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Monitoring.Requests {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']"
	[global::Android.Runtime.Register ("com/liveperson/monitoring/requests/BaseMonitoringRequest", DoNotGenerateAcw=true)]
	public abstract partial class BaseMonitoringRequest : global::Java.Lang.Object, global::Com.Liveperson.Monitoring.ICommand {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/monitoring/requests/BaseMonitoringRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseMonitoringRequest); }
		}

		protected BaseMonitoringRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']/constructor[@name='BaseMonitoringRequest' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List&lt;com.liveperson.monitoring.model.LPMonitoringIdentity&gt;'] and parameter[3][@type='com.liveperson.sdk.MonitoringParams']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/util/List;Lcom/liveperson/sdk/MonitoringParams;)V", "")]
		public unsafe BaseMonitoringRequest (global::Android.Content.Context p0, global::System.Collections.Generic.IList<global::Com.Liveperson.Monitoring.Model.LPMonitoringIdentity> p1, global::Com.Liveperson.Sdk.MonitoringParams p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Liveperson.Monitoring.Model.LPMonitoringIdentity>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (BaseMonitoringRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/util/List;Lcom/liveperson/sdk/MonitoringParams;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/util/List;Lcom/liveperson/sdk/MonitoringParams;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/util/List;Lcom/liveperson/sdk/MonitoringParams;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getACR;
		public unsafe string ACR {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']/method[@name='getACR' and count(parameter)=0]"
			[Register ("getACR", "()Ljava/lang/String;", "GetGetACRHandler")]
			get {
				if (id_getACR == IntPtr.Zero)
					id_getACR = JNIEnv.GetMethodID (class_ref, "getACR", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getACR), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getContext;
		public unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				if (id_getContext == IntPtr.Zero)
					id_getContext = JNIEnv.GetMethodID (class_ref, "getContext", "()Landroid/content/Context;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContext), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDEFAULT_AUTH_ACR;
		public unsafe string DEFAULT_AUTH_ACR {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']/method[@name='getDEFAULT_AUTH_ACR' and count(parameter)=0]"
			[Register ("getDEFAULT_AUTH_ACR", "()Ljava/lang/String;", "GetGetDEFAULT_AUTH_ACRHandler")]
			get {
				if (id_getDEFAULT_AUTH_ACR == IntPtr.Zero)
					id_getDEFAULT_AUTH_ACR = JNIEnv.GetMethodID (class_ref, "getDEFAULT_AUTH_ACR", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDEFAULT_AUTH_ACR), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDEFAULT_UNAUTH_ACR;
		public unsafe string DEFAULT_UNAUTH_ACR {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']/method[@name='getDEFAULT_UNAUTH_ACR' and count(parameter)=0]"
			[Register ("getDEFAULT_UNAUTH_ACR", "()Ljava/lang/String;", "GetGetDEFAULT_UNAUTH_ACRHandler")]
			get {
				if (id_getDEFAULT_UNAUTH_ACR == IntPtr.Zero)
					id_getDEFAULT_UNAUTH_ACR = JNIEnv.GetMethodID (class_ref, "getDEFAULT_UNAUTH_ACR", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDEFAULT_UNAUTH_ACR), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getISSUER;
		public unsafe string ISSUER {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']/method[@name='getISSUER' and count(parameter)=0]"
			[Register ("getISSUER", "()Ljava/lang/String;", "GetGetISSUERHandler")]
			get {
				if (id_getISSUER == IntPtr.Zero)
					id_getISSUER = JNIEnv.GetMethodID (class_ref, "getISSUER", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getISSUER), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getIdentities;
		public unsafe global::System.Collections.Generic.IList<global::Com.Liveperson.Monitoring.Model.LPMonitoringIdentity> Identities {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']/method[@name='getIdentities' and count(parameter)=0]"
			[Register ("getIdentities", "()Ljava/util/List;", "GetGetIdentitiesHandler")]
			get {
				if (id_getIdentities == IntPtr.Zero)
					id_getIdentities = JNIEnv.GetMethodID (class_ref, "getIdentities", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Com.Liveperson.Monitoring.Model.LPMonitoringIdentity>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIdentities), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getKEY_CONSUMER_ID_ENC;
		public unsafe string KEY_CONSUMER_ID_ENC {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']/method[@name='getKEY_CONSUMER_ID_ENC' and count(parameter)=0]"
			[Register ("getKEY_CONSUMER_ID_ENC", "()Ljava/lang/String;", "GetGetKEY_CONSUMER_ID_ENCHandler")]
			get {
				if (id_getKEY_CONSUMER_ID_ENC == IntPtr.Zero)
					id_getKEY_CONSUMER_ID_ENC = JNIEnv.GetMethodID (class_ref, "getKEY_CONSUMER_ID_ENC", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKEY_CONSUMER_ID_ENC), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMonitoringParams;
		public unsafe global::Com.Liveperson.Sdk.MonitoringParams MonitoringParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']/method[@name='getMonitoringParams' and count(parameter)=0]"
			[Register ("getMonitoringParams", "()Lcom/liveperson/sdk/MonitoringParams;", "GetGetMonitoringParamsHandler")]
			get {
				if (id_getMonitoringParams == IntPtr.Zero)
					id_getMonitoringParams = JNIEnv.GetMethodID (class_ref, "getMonitoringParams", "()Lcom/liveperson/sdk/MonitoringParams;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Sdk.MonitoringParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMonitoringParams), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getNUM_OF_RETRIES;
		protected unsafe int NUM_OF_RETRIES {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']/method[@name='getNUM_OF_RETRIES' and count(parameter)=0]"
			[Register ("getNUM_OF_RETRIES", "()I", "GetGetNUM_OF_RETRIESHandler")]
			get {
				if (id_getNUM_OF_RETRIES == IntPtr.Zero)
					id_getNUM_OF_RETRIES = JNIEnv.GetMethodID (class_ref, "getNUM_OF_RETRIES", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNUM_OF_RETRIES);
				} finally {
				}
			}
		}

		static IntPtr id_getParamsCache;
		protected unsafe global::Com.Liveperson.Monitoring.Cache.MonitoringParamsCache ParamsCache {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']/method[@name='getParamsCache' and count(parameter)=0]"
			[Register ("getParamsCache", "()Lcom/liveperson/monitoring/cache/MonitoringParamsCache;", "GetGetParamsCacheHandler")]
			get {
				if (id_getParamsCache == IntPtr.Zero)
					id_getParamsCache = JNIEnv.GetMethodID (class_ref, "getParamsCache", "()Lcom/liveperson/monitoring/cache/MonitoringParamsCache;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Cache.MonitoringParamsCache> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParamsCache), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRequest;
#pragma warning disable 0169
		static Delegate GetGetRequestHandler ()
		{
			if (cb_getRequest == null)
				cb_getRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequest);
			return cb_getRequest;
		}

		static IntPtr n_GetRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Monitoring.Requests.BaseMonitoringRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Requests.BaseMonitoringRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Request);
		}
#pragma warning restore 0169

		protected abstract global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lcom/liveperson/infra/network/http/request/HttpRequest;", "GetGetRequestHandler")] get;
		}

		static Delegate cb_getRequestUrl;
#pragma warning disable 0169
		static Delegate GetGetRequestUrlHandler ()
		{
			if (cb_getRequestUrl == null)
				cb_getRequestUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestUrl);
			return cb_getRequestUrl;
		}

		static IntPtr n_GetRequestUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Monitoring.Requests.BaseMonitoringRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Requests.BaseMonitoringRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestUrl);
		}
#pragma warning restore 0169

		protected abstract string RequestUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']/method[@name='getRequestUrl' and count(parameter)=0]"
			[Register ("getRequestUrl", "()Ljava/lang/String;", "GetGetRequestUrlHandler")] get;
		}

		static IntPtr id_getRetryCounter;
		static IntPtr id_setRetryCounter_I;
		protected unsafe int RetryCounter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']/method[@name='getRetryCounter' and count(parameter)=0]"
			[Register ("getRetryCounter", "()I", "GetGetRetryCounterHandler")]
			get {
				if (id_getRetryCounter == IntPtr.Zero)
					id_getRetryCounter = JNIEnv.GetMethodID (class_ref, "getRetryCounter", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRetryCounter);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']/method[@name='setRetryCounter' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRetryCounter", "(I)V", "GetSetRetryCounter_IHandler")]
			set {
				if (id_setRetryCounter_I == IntPtr.Zero)
					id_setRetryCounter_I = JNIEnv.GetMethodID (class_ref, "setRetryCounter", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRetryCounter_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getSUB;
		public unsafe string SUB {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']/method[@name='getSUB' and count(parameter)=0]"
			[Register ("getSUB", "()Ljava/lang/String;", "GetGetSUBHandler")]
			get {
				if (id_getSUB == IntPtr.Zero)
					id_getSUB = JNIEnv.GetMethodID (class_ref, "getSUB", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSUB), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_buildRequestBody_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_;
#pragma warning disable 0169
		static Delegate GetBuildRequestBody_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Handler ()
		{
			if (cb_buildRequestBody_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_ == null)
				cb_buildRequestBody_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_BuildRequestBody_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_);
			return cb_buildRequestBody_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_;
		}

		static IntPtr n_BuildRequestBody_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Monitoring.Requests.BaseMonitoringRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Requests.BaseMonitoringRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Liveperson.Monitoring.Model.LPMonitoringIdentity>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Sdk.MonitoringParams p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Sdk.MonitoringParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildRequestBody (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_buildRequestBody_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']/method[@name='buildRequestBody' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.liveperson.monitoring.model.LPMonitoringIdentity&gt;'] and parameter[2][@type='com.liveperson.sdk.MonitoringParams']]"
		[Register ("buildRequestBody", "(Ljava/util/List;Lcom/liveperson/sdk/MonitoringParams;)Lorg/json/JSONObject;", "GetBuildRequestBody_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Handler")]
		protected virtual unsafe global::Org.Json.JSONObject BuildRequestBody (global::System.Collections.Generic.IList<global::Com.Liveperson.Monitoring.Model.LPMonitoringIdentity> p0, global::Com.Liveperson.Sdk.MonitoringParams p1)
		{
			if (id_buildRequestBody_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_ == IntPtr.Zero)
				id_buildRequestBody_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_ = JNIEnv.GetMethodID (class_ref, "buildRequestBody", "(Ljava/util/List;Lcom/liveperson/sdk/MonitoringParams;)Lorg/json/JSONObject;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Liveperson.Monitoring.Model.LPMonitoringIdentity>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Org.Json.JSONObject __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buildRequestBody_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildRequestBody", "(Ljava/util/List;Lcom/liveperson/sdk/MonitoringParams;)Lorg/json/JSONObject;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_buildRequestUrl;
#pragma warning disable 0169
		static Delegate GetBuildRequestUrlHandler ()
		{
			if (cb_buildRequestUrl == null)
				cb_buildRequestUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BuildRequestUrl);
			return cb_buildRequestUrl;
		}

		static IntPtr n_BuildRequestUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Monitoring.Requests.BaseMonitoringRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Requests.BaseMonitoringRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BuildRequestUrl ());
		}
#pragma warning restore 0169

		static IntPtr id_buildRequestUrl;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']/method[@name='buildRequestUrl' and count(parameter)=0]"
		[Register ("buildRequestUrl", "()Ljava/lang/String;", "GetBuildRequestUrlHandler")]
		protected virtual unsafe string BuildRequestUrl ()
		{
			if (id_buildRequestUrl == IntPtr.Zero)
				id_buildRequestUrl = JNIEnv.GetMethodID (class_ref, "buildRequestUrl", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buildRequestUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildRequestUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_callErrorCallback_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetCallErrorCallback_Ljava_lang_Exception_Handler ()
		{
			if (cb_callErrorCallback_Ljava_lang_Exception_ == null)
				cb_callErrorCallback_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CallErrorCallback_Ljava_lang_Exception_);
			return cb_callErrorCallback_Ljava_lang_Exception_;
		}

		static void n_CallErrorCallback_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Monitoring.Requests.BaseMonitoringRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Requests.BaseMonitoringRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CallErrorCallback (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']/method[@name='callErrorCallback' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("callErrorCallback", "(Ljava/lang/Exception;)V", "GetCallErrorCallback_Ljava_lang_Exception_Handler")]
		protected abstract void CallErrorCallback (global::Java.Lang.Exception p0);

		static Delegate cb_execute;
#pragma warning disable 0169
		static Delegate GetExecuteHandler ()
		{
			if (cb_execute == null)
				cb_execute = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Execute);
			return cb_execute;
		}

		static void n_Execute (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Monitoring.Requests.BaseMonitoringRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Requests.BaseMonitoringRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		static IntPtr id_execute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()V", "GetExecuteHandler")]
		public virtual unsafe void Execute ()
		{
			if (id_execute == IntPtr.Zero)
				id_execute = JNIEnv.GetMethodID (class_ref, "execute", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_execute);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "()V"));
			} finally {
			}
		}

		static Delegate cb_handleError_Ljava_lang_Exception_Lcom_liveperson_infra_network_http_request_HttpRequest_;
#pragma warning disable 0169
		static Delegate GetHandleError_Ljava_lang_Exception_Lcom_liveperson_infra_network_http_request_HttpRequest_Handler ()
		{
			if (cb_handleError_Ljava_lang_Exception_Lcom_liveperson_infra_network_http_request_HttpRequest_ == null)
				cb_handleError_Ljava_lang_Exception_Lcom_liveperson_infra_network_http_request_HttpRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_HandleError_Ljava_lang_Exception_Lcom_liveperson_infra_network_http_request_HttpRequest_);
			return cb_handleError_Ljava_lang_Exception_Lcom_liveperson_infra_network_http_request_HttpRequest_;
		}

		static void n_HandleError_Ljava_lang_Exception_Lcom_liveperson_infra_network_http_request_HttpRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Monitoring.Requests.BaseMonitoringRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Requests.BaseMonitoringRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.HandleError (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_handleError_Ljava_lang_Exception_Lcom_liveperson_infra_network_http_request_HttpRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']/method[@name='handleError' and count(parameter)=2 and parameter[1][@type='java.lang.Exception'] and parameter[2][@type='com.liveperson.infra.network.http.request.HttpRequest']]"
		[Register ("handleError", "(Ljava/lang/Exception;Lcom/liveperson/infra/network/http/request/HttpRequest;)V", "GetHandleError_Ljava_lang_Exception_Lcom_liveperson_infra_network_http_request_HttpRequest_Handler")]
		protected virtual unsafe void HandleError (global::Java.Lang.Exception p0, global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest p1)
		{
			if (id_handleError_Ljava_lang_Exception_Lcom_liveperson_infra_network_http_request_HttpRequest_ == IntPtr.Zero)
				id_handleError_Ljava_lang_Exception_Lcom_liveperson_infra_network_http_request_HttpRequest_ = JNIEnv.GetMethodID (class_ref, "handleError", "(Ljava/lang/Exception;Lcom/liveperson/infra/network/http/request/HttpRequest;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleError_Ljava_lang_Exception_Lcom_liveperson_infra_network_http_request_HttpRequest_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleError", "(Ljava/lang/Exception;Lcom/liveperson/infra/network/http/request/HttpRequest;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_handleResponse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHandleResponse_Ljava_lang_String_Handler ()
		{
			if (cb_handleResponse_Ljava_lang_String_ == null)
				cb_handleResponse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleResponse_Ljava_lang_String_);
			return cb_handleResponse_Ljava_lang_String_;
		}

		static void n_HandleResponse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Monitoring.Requests.BaseMonitoringRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Requests.BaseMonitoringRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleResponse (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']/method[@name='handleResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("handleResponse", "(Ljava/lang/String;)V", "GetHandleResponse_Ljava_lang_String_Handler")]
		protected abstract void HandleResponse (string p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/monitoring/requests/BaseMonitoringRequest", DoNotGenerateAcw=true)]
	internal partial class BaseMonitoringRequestInvoker : BaseMonitoringRequest {

		public BaseMonitoringRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseMonitoringRequestInvoker); }
		}

		static IntPtr id_getRequest;
		protected override unsafe global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lcom/liveperson/infra/network/http/request/HttpRequest;", "GetGetRequestHandler")]
			get {
				if (id_getRequest == IntPtr.Zero)
					id_getRequest = JNIEnv.GetMethodID (class_ref, "getRequest", "()Lcom/liveperson/infra/network/http/request/HttpRequest;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequest), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getRequestUrl;
		protected override unsafe string RequestUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']/method[@name='getRequestUrl' and count(parameter)=0]"
			[Register ("getRequestUrl", "()Ljava/lang/String;", "GetGetRequestUrlHandler")]
			get {
				if (id_getRequestUrl == IntPtr.Zero)
					id_getRequestUrl = JNIEnv.GetMethodID (class_ref, "getRequestUrl", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestUrl), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_callErrorCallback_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']/method[@name='callErrorCallback' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("callErrorCallback", "(Ljava/lang/Exception;)V", "GetCallErrorCallback_Ljava_lang_Exception_Handler")]
		protected override unsafe void CallErrorCallback (global::Java.Lang.Exception p0)
		{
			if (id_callErrorCallback_Ljava_lang_Exception_ == IntPtr.Zero)
				id_callErrorCallback_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "callErrorCallback", "(Ljava/lang/Exception;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_callErrorCallback_Ljava_lang_Exception_, __args);
			} finally {
			}
		}

		static IntPtr id_handleResponse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='BaseMonitoringRequest']/method[@name='handleResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("handleResponse", "(Ljava/lang/String;)V", "GetHandleResponse_Ljava_lang_String_Handler")]
		protected override unsafe void HandleResponse (string p0)
		{
			if (id_handleResponse_Ljava_lang_String_ == IntPtr.Zero)
				id_handleResponse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "handleResponse", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleResponse_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
