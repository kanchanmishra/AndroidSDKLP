using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Monitoring.Requests {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='SendSdeRequest']"
	[global::Android.Runtime.Register ("com/liveperson/monitoring/requests/SendSdeRequest", DoNotGenerateAcw=true)]
	public sealed partial class SendSdeRequest : global::Com.Liveperson.Monitoring.Requests.BaseMonitoringRequest {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/monitoring/requests/SendSdeRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SendSdeRequest); }
		}

		internal SendSdeRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_monitoring_sdk_callbacks_SdeCallback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='SendSdeRequest']/constructor[@name='SendSdeRequest' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List&lt;com.liveperson.monitoring.model.LPMonitoringIdentity&gt;'] and parameter[3][@type='com.liveperson.sdk.MonitoringParams'] and parameter[4][@type='com.liveperson.monitoring.sdk.callbacks.SdeCallback']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/util/List;Lcom/liveperson/sdk/MonitoringParams;Lcom/liveperson/monitoring/sdk/callbacks/SdeCallback;)V", "")]
		public unsafe SendSdeRequest (global::Android.Content.Context p0, global::System.Collections.Generic.IList<global::Com.Liveperson.Monitoring.Model.LPMonitoringIdentity> p1, global::Com.Liveperson.Sdk.MonitoringParams p2, global::Com.Liveperson.Monitoring.Sdk.Callbacks.ISdeCallback p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Liveperson.Monitoring.Model.LPMonitoringIdentity>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (SendSdeRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/util/List;Lcom/liveperson/sdk/MonitoringParams;Lcom/liveperson/monitoring/sdk/callbacks/SdeCallback;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/util/List;Lcom/liveperson/sdk/MonitoringParams;Lcom/liveperson/monitoring/sdk/callbacks/SdeCallback;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_monitoring_sdk_callbacks_SdeCallback_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_monitoring_sdk_callbacks_SdeCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/util/List;Lcom/liveperson/sdk/MonitoringParams;Lcom/liveperson/monitoring/sdk/callbacks/SdeCallback;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_monitoring_sdk_callbacks_SdeCallback_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_monitoring_sdk_callbacks_SdeCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getCallback;
		public unsafe global::Com.Liveperson.Monitoring.Sdk.Callbacks.ISdeCallback Callback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='SendSdeRequest']/method[@name='getCallback' and count(parameter)=0]"
			[Register ("getCallback", "()Lcom/liveperson/monitoring/sdk/callbacks/SdeCallback;", "GetGetCallbackHandler")]
			get {
				if (id_getCallback == IntPtr.Zero)
					id_getCallback = JNIEnv.GetMethodID (class_ref, "getCallback", "()Lcom/liveperson/monitoring/sdk/callbacks/SdeCallback;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Sdk.Callbacks.ISdeCallback> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCallback), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getRequest;
		protected override unsafe global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='SendSdeRequest']/method[@name='getRequest' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='SendSdeRequest']/method[@name='getRequestUrl' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='SendSdeRequest']/method[@name='callErrorCallback' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("callErrorCallback", "(Ljava/lang/Exception;)V", "")]
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.requests']/class[@name='SendSdeRequest']/method[@name='handleResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("handleResponse", "(Ljava/lang/String;)V", "")]
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
