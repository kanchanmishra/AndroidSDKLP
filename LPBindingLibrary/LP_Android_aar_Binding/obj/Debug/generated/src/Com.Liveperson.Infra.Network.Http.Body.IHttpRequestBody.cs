using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Network.Http.Body {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.network.http.body']/interface[@name='HttpRequestBody']"
	[Register ("com/liveperson/infra/network/http/body/HttpRequestBody", "", "Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBodyInvoker")]
	public partial interface IHttpRequestBody : IJavaObject {

		string ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.body']/interface[@name='HttpRequestBody']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Ljava/lang/String;", "GetGetContentTypeHandler:Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBodyInvoker, LP_Android_aar_Binding")] get;
		}

		bool IsString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.body']/interface[@name='HttpRequestBody']/method[@name='isString' and count(parameter)=0]"
			[Register ("isString", "()Z", "GetIsStringHandler:Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBodyInvoker, LP_Android_aar_Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.body']/interface[@name='HttpRequestBody']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Ljava/lang/Object;", "GetGetHandler:Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBodyInvoker, LP_Android_aar_Binding")]
		global::Java.Lang.Object Get ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/network/http/body/HttpRequestBody", DoNotGenerateAcw=true)]
	internal class IHttpRequestBodyInvoker : global::Java.Lang.Object, IHttpRequestBody {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/network/http/body/HttpRequestBody");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IHttpRequestBodyInvoker); }
		}

		IntPtr class_ref;

		public static IHttpRequestBody GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHttpRequestBody> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.network.http.body.HttpRequestBody"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHttpRequestBodyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getContentType;
#pragma warning disable 0169
		static Delegate GetGetContentTypeHandler ()
		{
			if (cb_getContentType == null)
				cb_getContentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentType);
			return cb_getContentType;
		}

		static IntPtr n_GetContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBody __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentType);
		}
#pragma warning restore 0169

		IntPtr id_getContentType;
		public unsafe string ContentType {
			get {
				if (id_getContentType == IntPtr.Zero)
					id_getContentType = JNIEnv.GetMethodID (class_ref, "getContentType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isString;
#pragma warning disable 0169
		static Delegate GetIsStringHandler ()
		{
			if (cb_isString == null)
				cb_isString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsString);
			return cb_isString;
		}

		static bool n_IsString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBody __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsString;
		}
#pragma warning restore 0169

		IntPtr id_isString;
		public unsafe bool IsString {
			get {
				if (id_isString == IntPtr.Zero)
					id_isString = JNIEnv.GetMethodID (class_ref, "isString", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isString);
			}
		}

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get);
			return cb_get;
		}

		static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBody __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get ());
		}
#pragma warning restore 0169

		IntPtr id_get;
		public unsafe global::Java.Lang.Object Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()Ljava/lang/Object;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get), JniHandleOwnership.TransferLocalRef);
		}

	}

}
