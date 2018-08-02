using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Response {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.api.response']/interface[@name='IOnUrlReady']"
	[Register ("com/liveperson/api/response/IOnUrlReady", "", "Com.Liveperson.Api.Response.IOnUrlReadyInvoker")]
	public partial interface IOnUrlReady : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response']/interface[@name='IOnUrlReady']/method[@name='onUrlError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onUrlError", "(Ljava/lang/String;)V", "GetOnUrlError_Ljava_lang_String_Handler:Com.Liveperson.Api.Response.IOnUrlReadyInvoker, LP_Android_aar_Binding")]
		void OnUrlError (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response']/interface[@name='IOnUrlReady']/method[@name='onUrlReady' and count(parameter)=1 and parameter[1][@type='com.liveperson.api.response.BaseGenerateURLResponse']]"
		[Register ("onUrlReady", "(Lcom/liveperson/api/response/BaseGenerateURLResponse;)V", "GetOnUrlReady_Lcom_liveperson_api_response_BaseGenerateURLResponse_Handler:Com.Liveperson.Api.Response.IOnUrlReadyInvoker, LP_Android_aar_Binding")]
		void OnUrlReady (global::Com.Liveperson.Api.Response.BaseGenerateURLResponse p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/api/response/IOnUrlReady", DoNotGenerateAcw=true)]
	internal class IOnUrlReadyInvoker : global::Java.Lang.Object, IOnUrlReady {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/api/response/IOnUrlReady");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnUrlReadyInvoker); }
		}

		IntPtr class_ref;

		public static IOnUrlReady GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnUrlReady> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.api.response.IOnUrlReady"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnUrlReadyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onUrlError_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnUrlError_Ljava_lang_String_Handler ()
		{
			if (cb_onUrlError_Ljava_lang_String_ == null)
				cb_onUrlError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUrlError_Ljava_lang_String_);
			return cb_onUrlError_Ljava_lang_String_;
		}

		static void n_OnUrlError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Api.Response.IOnUrlReady __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.IOnUrlReady> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUrlError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onUrlError_Ljava_lang_String_;
		public unsafe void OnUrlError (string p0)
		{
			if (id_onUrlError_Ljava_lang_String_ == IntPtr.Zero)
				id_onUrlError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onUrlError", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUrlError_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onUrlReady_Lcom_liveperson_api_response_BaseGenerateURLResponse_;
#pragma warning disable 0169
		static Delegate GetOnUrlReady_Lcom_liveperson_api_response_BaseGenerateURLResponse_Handler ()
		{
			if (cb_onUrlReady_Lcom_liveperson_api_response_BaseGenerateURLResponse_ == null)
				cb_onUrlReady_Lcom_liveperson_api_response_BaseGenerateURLResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUrlReady_Lcom_liveperson_api_response_BaseGenerateURLResponse_);
			return cb_onUrlReady_Lcom_liveperson_api_response_BaseGenerateURLResponse_;
		}

		static void n_OnUrlReady_Lcom_liveperson_api_response_BaseGenerateURLResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Api.Response.IOnUrlReady __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.IOnUrlReady> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Response.BaseGenerateURLResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.BaseGenerateURLResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUrlReady (p0);
		}
#pragma warning restore 0169

		IntPtr id_onUrlReady_Lcom_liveperson_api_response_BaseGenerateURLResponse_;
		public unsafe void OnUrlReady (global::Com.Liveperson.Api.Response.BaseGenerateURLResponse p0)
		{
			if (id_onUrlReady_Lcom_liveperson_api_response_BaseGenerateURLResponse_ == IntPtr.Zero)
				id_onUrlReady_Lcom_liveperson_api_response_BaseGenerateURLResponse_ = JNIEnv.GetMethodID (class_ref, "onUrlReady", "(Lcom/liveperson/api/response/BaseGenerateURLResponse;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUrlReady_Lcom_liveperson_api_response_BaseGenerateURLResponse_, __args);
		}

	}

}
