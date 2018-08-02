using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Network.Http.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpOpenStreamRequest']"
	[global::Android.Runtime.Register ("com/liveperson/infra/network/http/request/HttpOpenStreamRequest", DoNotGenerateAcw=true)]
	public partial class HttpOpenStreamRequest : global::Com.Liveperson.Infra.Network.Http.Request.HttpGetRequest {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/network/http/request/HttpOpenStreamRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpOpenStreamRequest); }
		}

		protected HttpOpenStreamRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpOpenStreamRequest']/constructor[@name='HttpOpenStreamRequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe HttpOpenStreamRequest (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (HttpOpenStreamRequest)) {
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

		static Delegate cb_reportSuccess_Lokhttp3_Response_;
#pragma warning disable 0169
		static Delegate GetReportSuccess_Lokhttp3_Response_Handler ()
		{
			if (cb_reportSuccess_Lokhttp3_Response_ == null)
				cb_reportSuccess_Lokhttp3_Response_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReportSuccess_Lokhttp3_Response_);
			return cb_reportSuccess_Lokhttp3_Response_;
		}

		static void n_ReportSuccess_Lokhttp3_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Http.Request.HttpOpenStreamRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpOpenStreamRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Square.OkHttp3.Response p0 = global::Java.Lang.Object.GetObject<global::Square.OkHttp3.Response> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReportSuccess (p0);
		}
#pragma warning restore 0169

		static IntPtr id_reportSuccess_Lokhttp3_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpOpenStreamRequest']/method[@name='reportSuccess' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
		[Register ("reportSuccess", "(Lokhttp3/Response;)V", "GetReportSuccess_Lokhttp3_Response_Handler")]
		public virtual unsafe void ReportSuccess (global::Square.OkHttp3.Response p0)
		{
			if (id_reportSuccess_Lokhttp3_Response_ == IntPtr.Zero)
				id_reportSuccess_Lokhttp3_Response_ = JNIEnv.GetMethodID (class_ref, "reportSuccess", "(Lokhttp3/Response;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reportSuccess_Lokhttp3_Response_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reportSuccess", "(Lokhttp3/Response;)V"), __args);
			} finally {
			}
		}

	}
}
