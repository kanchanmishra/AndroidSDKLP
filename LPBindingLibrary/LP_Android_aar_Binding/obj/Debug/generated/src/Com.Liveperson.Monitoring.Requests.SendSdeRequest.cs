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
