using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Network.Http.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpPostRequest']"
	[global::Android.Runtime.Register ("com/liveperson/infra/network/http/request/HttpPostRequest", DoNotGenerateAcw=true)]
	public partial class HttpPostRequest : global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/network/http/request/HttpPostRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpPostRequest); }
		}

		protected HttpPostRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpPostRequest']/constructor[@name='HttpPostRequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe HttpPostRequest (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (HttpPostRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getRequestBody;
#pragma warning disable 0169
		static Delegate GetGetRequestBodyHandler ()
		{
			if (cb_getRequestBody == null)
				cb_getRequestBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestBody);
			return cb_getRequestBody;
		}

		static IntPtr n_GetRequestBody (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Http.Request.HttpPostRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpPostRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestBody);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestBody;
		public override unsafe global::Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBody RequestBody {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpPostRequest']/method[@name='getRequestBody' and count(parameter)=0]"
			[Register ("getRequestBody", "()Lcom/liveperson/infra/network/http/body/HttpRequestBody;", "GetGetRequestBodyHandler")]
			get {
				if (id_getRequestBody == IntPtr.Zero)
					id_getRequestBody = JNIEnv.GetMethodID (class_ref, "getRequestBody", "()Lcom/liveperson/infra/network/http/body/HttpRequestBody;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBody> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestBody), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBody> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestBody", "()Lcom/liveperson/infra/network/http/body/HttpRequestBody;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setBody_Lcom_liveperson_infra_network_http_body_HttpRequestBody_;
#pragma warning disable 0169
		static Delegate GetSetBody_Lcom_liveperson_infra_network_http_body_HttpRequestBody_Handler ()
		{
			if (cb_setBody_Lcom_liveperson_infra_network_http_body_HttpRequestBody_ == null)
				cb_setBody_Lcom_liveperson_infra_network_http_body_HttpRequestBody_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBody_Lcom_liveperson_infra_network_http_body_HttpRequestBody_);
			return cb_setBody_Lcom_liveperson_infra_network_http_body_HttpRequestBody_;
		}

		static void n_SetBody_Lcom_liveperson_infra_network_http_body_HttpRequestBody_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Http.Request.HttpPostRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpPostRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBody p0 = (global::Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBody)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBody> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBody (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBody_Lcom_liveperson_infra_network_http_body_HttpRequestBody_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpPostRequest']/method[@name='setBody' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.network.http.body.HttpRequestBody']]"
		[Register ("setBody", "(Lcom/liveperson/infra/network/http/body/HttpRequestBody;)V", "GetSetBody_Lcom_liveperson_infra_network_http_body_HttpRequestBody_Handler")]
		public override unsafe void SetBody (global::Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBody p0)
		{
			if (id_setBody_Lcom_liveperson_infra_network_http_body_HttpRequestBody_ == IntPtr.Zero)
				id_setBody_Lcom_liveperson_infra_network_http_body_HttpRequestBody_ = JNIEnv.GetMethodID (class_ref, "setBody", "(Lcom/liveperson/infra/network/http/body/HttpRequestBody;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBody_Lcom_liveperson_infra_network_http_body_HttpRequestBody_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBody", "(Lcom/liveperson/infra/network/http/body/HttpRequestBody;)V"), __args);
			} finally {
			}
		}

	}
}
