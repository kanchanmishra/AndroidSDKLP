using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Network.Http.Body {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.network.http.body']/class[@name='HttpImageRequestBody']"
	[global::Android.Runtime.Register ("com/liveperson/infra/network/http/body/HttpImageRequestBody", DoNotGenerateAcw=true)]
	public abstract partial class HttpImageRequestBody : global::Java.Lang.Object, global::Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBody {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/network/http/body/HttpImageRequestBody", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpImageRequestBody); }
		}

		protected HttpImageRequestBody (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.network.http.body']/class[@name='HttpImageRequestBody']/constructor[@name='HttpImageRequestBody' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpImageRequestBody ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (HttpImageRequestBody)) {
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
			global::Com.Liveperson.Infra.Network.Http.Body.HttpImageRequestBody __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Body.HttpImageRequestBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsString;
		}
#pragma warning restore 0169

		static IntPtr id_isString;
		public virtual unsafe bool IsString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.body']/class[@name='HttpImageRequestBody']/method[@name='isString' and count(parameter)=0]"
			[Register ("isString", "()Z", "GetIsStringHandler")]
			get {
				if (id_isString == IntPtr.Zero)
					id_isString = JNIEnv.GetMethodID (class_ref, "isString", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isString);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isString", "()Z"));
				} finally {
				}
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
			global::Com.Liveperson.Infra.Network.Http.Body.HttpImageRequestBody __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Body.HttpImageRequestBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.body']/interface[@name='HttpRequestBody']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Ljava/lang/Object;", "GetGetHandler")]
		public abstract global::Java.Lang.Object Get ();

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
			global::Com.Liveperson.Infra.Network.Http.Body.HttpImageRequestBody __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Body.HttpImageRequestBody> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentType);
		}
#pragma warning restore 0169

		public abstract string ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.body']/class[@name='HttpImageRequestBody']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Ljava/lang/String;", "GetGetContentTypeHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/network/http/body/HttpImageRequestBody", DoNotGenerateAcw=true)]
	internal partial class HttpImageRequestBodyInvoker : HttpImageRequestBody {

		public HttpImageRequestBodyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpImageRequestBodyInvoker); }
		}

		static IntPtr id_getContentType;
		public override unsafe string ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.body']/class[@name='HttpImageRequestBody']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Ljava/lang/String;", "GetGetContentTypeHandler")]
			get {
				if (id_getContentType == IntPtr.Zero)
					id_getContentType = JNIEnv.GetMethodID (class_ref, "getContentType", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.body']/interface[@name='HttpRequestBody']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Ljava/lang/Object;", "GetGetHandler")]
		public override unsafe global::Java.Lang.Object Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()Ljava/lang/Object;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
