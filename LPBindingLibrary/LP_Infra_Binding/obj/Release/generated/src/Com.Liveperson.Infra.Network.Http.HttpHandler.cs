using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Network.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.network.http']/class[@name='HttpHandler']"
	[global::Android.Runtime.Register ("com/liveperson/infra/network/http/HttpHandler", DoNotGenerateAcw=true)]
	public partial class HttpHandler : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.network.http']/class[@name='HttpHandler.HttpRequestBuilder']"
		[global::Android.Runtime.Register ("com/liveperson/infra/network/http/HttpHandler$HttpRequestBuilder", DoNotGenerateAcw=true)]
		public partial class HttpRequestBuilder : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/network/http/HttpHandler$HttpRequestBuilder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HttpRequestBuilder); }
			}

			protected HttpRequestBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_build_Lcom_liveperson_infra_network_http_request_HttpRequest_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http']/class[@name='HttpHandler.HttpRequestBuilder']/method[@name='build' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.network.http.request.HttpRequest']]"
			[Register ("build", "(Lcom/liveperson/infra/network/http/request/HttpRequest;)Lokhttp3/Request;", "")]
			public static unsafe global::Square.OkHttp3.Request Build (global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest p0)
			{
				if (id_build_Lcom_liveperson_infra_network_http_request_HttpRequest_ == IntPtr.Zero)
					id_build_Lcom_liveperson_infra_network_http_request_HttpRequest_ = JNIEnv.GetStaticMethodID (class_ref, "build", "(Lcom/liveperson/infra/network/http/request/HttpRequest;)Lokhttp3/Request;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Square.OkHttp3.Request __ret = global::Java.Lang.Object.GetObject<global::Square.OkHttp3.Request> (JNIEnv.CallStaticObjectMethod  (class_ref, id_build_Lcom_liveperson_infra_network_http_request_HttpRequest_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/network/http/HttpHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpHandler); }
		}

		protected HttpHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.network.http']/class[@name='HttpHandler']/constructor[@name='HttpHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpHandler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (HttpHandler)) {
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

		static IntPtr id_execute_Lcom_liveperson_infra_network_http_request_HttpRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http']/class[@name='HttpHandler']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.network.http.request.HttpRequest']]"
		[Register ("execute", "(Lcom/liveperson/infra/network/http/request/HttpRequest;)V", "")]
		public static unsafe void Execute (global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest p0)
		{
			if (id_execute_Lcom_liveperson_infra_network_http_request_HttpRequest_ == IntPtr.Zero)
				id_execute_Lcom_liveperson_infra_network_http_request_HttpRequest_ = JNIEnv.GetStaticMethodID (class_ref, "execute", "(Lcom/liveperson/infra/network/http/request/HttpRequest;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_execute_Lcom_liveperson_infra_network_http_request_HttpRequest_, __args);
			} finally {
			}
		}

		static IntPtr id_executeDelayed_Lcom_liveperson_infra_network_http_request_HttpRequest_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http']/class[@name='HttpHandler']/method[@name='executeDelayed' and count(parameter)=2 and parameter[1][@type='com.liveperson.infra.network.http.request.HttpRequest'] and parameter[2][@type='long']]"
		[Register ("executeDelayed", "(Lcom/liveperson/infra/network/http/request/HttpRequest;J)V", "")]
		public static unsafe void ExecuteDelayed (global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest p0, long p1)
		{
			if (id_executeDelayed_Lcom_liveperson_infra_network_http_request_HttpRequest_J == IntPtr.Zero)
				id_executeDelayed_Lcom_liveperson_infra_network_http_request_HttpRequest_J = JNIEnv.GetStaticMethodID (class_ref, "executeDelayed", "(Lcom/liveperson/infra/network/http/request/HttpRequest;J)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_executeDelayed_Lcom_liveperson_infra_network_http_request_HttpRequest_J, __args);
			} finally {
			}
		}

	}
}
