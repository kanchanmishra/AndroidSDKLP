using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Network.Http.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest']"
	[global::Android.Runtime.Register ("com/liveperson/infra/network/http/request/HttpRequest", DoNotGenerateAcw=true)]
	public abstract partial class HttpRequest : global::Java.Lang.Object {


		static IntPtr mCallback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest']/field[@name='mCallback']"
		[Register ("mCallback")]
		protected global::Com.Liveperson.Infra.ICallback MCallback {
			get {
				if (mCallback_jfieldId == IntPtr.Zero)
					mCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mCallback", "Lcom/liveperson/infra/ICallback;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCallback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCallback_jfieldId == IntPtr.Zero)
					mCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mCallback", "Lcom/liveperson/infra/ICallback;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCallback_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mRequestBody_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest']/field[@name='mRequestBody']"
		[Register ("mRequestBody")]
		protected global::Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBody MRequestBody {
			get {
				if (mRequestBody_jfieldId == IntPtr.Zero)
					mRequestBody_jfieldId = JNIEnv.GetFieldID (class_ref, "mRequestBody", "Lcom/liveperson/infra/network/http/body/HttpRequestBody;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mRequestBody_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBody> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mRequestBody_jfieldId == IntPtr.Zero)
					mRequestBody_jfieldId = JNIEnv.GetFieldID (class_ref, "mRequestBody", "Lcom/liveperson/infra/network/http/body/HttpRequestBody;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mRequestBody_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest.HttpMethod']"
		[global::Android.Runtime.Register ("com/liveperson/infra/network/http/request/HttpRequest$HttpMethod", DoNotGenerateAcw=true)]
		public sealed partial class HttpMethod : global::Java.Lang.Enum {


			static IntPtr GET_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest.HttpMethod']/field[@name='GET']"
			[Register ("GET")]
			public static global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest.HttpMethod Get {
				get {
					if (GET_jfieldId == IntPtr.Zero)
						GET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GET", "Lcom/liveperson/infra/network/http/request/HttpRequest$HttpMethod;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GET_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest.HttpMethod> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr HEAD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest.HttpMethod']/field[@name='HEAD']"
			[Register ("HEAD")]
			public static global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest.HttpMethod Head {
				get {
					if (HEAD_jfieldId == IntPtr.Zero)
						HEAD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HEAD", "Lcom/liveperson/infra/network/http/request/HttpRequest$HttpMethod;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HEAD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest.HttpMethod> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr POST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest.HttpMethod']/field[@name='POST']"
			[Register ("POST")]
			public static global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest.HttpMethod Post {
				get {
					if (POST_jfieldId == IntPtr.Zero)
						POST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POST", "Lcom/liveperson/infra/network/http/request/HttpRequest$HttpMethod;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, POST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest.HttpMethod> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PUT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest.HttpMethod']/field[@name='PUT']"
			[Register ("PUT")]
			public static global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest.HttpMethod Put {
				get {
					if (PUT_jfieldId == IntPtr.Zero)
						PUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PUT", "Lcom/liveperson/infra/network/http/request/HttpRequest$HttpMethod;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PUT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest.HttpMethod> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/network/http/request/HttpRequest$HttpMethod", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HttpMethod); }
			}

			internal HttpMethod (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest.HttpMethod']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/network/http/request/HttpRequest$HttpMethod;", "")]
			public static unsafe global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest.HttpMethod ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/network/http/request/HttpRequest$HttpMethod;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest.HttpMethod __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest.HttpMethod> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest.HttpMethod']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/liveperson/infra/network/http/request/HttpRequest$HttpMethod;", "")]
			public static unsafe global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest.HttpMethod[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/infra/network/http/request/HttpRequest$HttpMethod;");
				try {
					return (global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest.HttpMethod[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest.HttpMethod));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/network/http/request/HttpRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpRequest); }
		}

		protected HttpRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_liveperson_infra_network_http_request_HttpRequest_HttpMethod_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest']/constructor[@name='HttpRequest' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.network.http.request.HttpRequest.HttpMethod']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/liveperson/infra/network/http/request/HttpRequest$HttpMethod;)V", "")]
		public unsafe HttpRequest (string p0, global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest.HttpMethod p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (HttpRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Lcom/liveperson/infra/network/http/request/HttpRequest$HttpMethod;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lcom/liveperson/infra/network/http/request/HttpRequest$HttpMethod;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_liveperson_infra_network_http_request_HttpRequest_HttpMethod_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_liveperson_infra_network_http_request_HttpRequest_HttpMethod_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/liveperson/infra/network/http/request/HttpRequest$HttpMethod;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_liveperson_infra_network_http_request_HttpRequest_HttpMethod_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_liveperson_infra_network_http_request_HttpRequest_HttpMethod_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getCallback;
#pragma warning disable 0169
		static Delegate GetGetCallbackHandler ()
		{
			if (cb_getCallback == null)
				cb_getCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCallback);
			return cb_getCallback;
		}

		static IntPtr n_GetCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Callback);
		}
#pragma warning restore 0169

		static Delegate cb_setCallback_Lcom_liveperson_infra_ICallback_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lcom_liveperson_infra_ICallback_Handler ()
		{
			if (cb_setCallback_Lcom_liveperson_infra_ICallback_ == null)
				cb_setCallback_Lcom_liveperson_infra_ICallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallback_Lcom_liveperson_infra_ICallback_);
			return cb_setCallback_Lcom_liveperson_infra_ICallback_;
		}

		static void n_SetCallback_Lcom_liveperson_infra_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ICallback p0 = (global::Com.Liveperson.Infra.ICallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Callback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCallback;
		static IntPtr id_setCallback_Lcom_liveperson_infra_ICallback_;
		public virtual unsafe global::Com.Liveperson.Infra.ICallback Callback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest']/method[@name='getCallback' and count(parameter)=0]"
			[Register ("getCallback", "()Lcom/liveperson/infra/ICallback;", "GetGetCallbackHandler")]
			get {
				if (id_getCallback == IntPtr.Zero)
					id_getCallback = JNIEnv.GetMethodID (class_ref, "getCallback", "()Lcom/liveperson/infra/ICallback;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCallback", "()Lcom/liveperson/infra/ICallback;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.ICallback']]"
			[Register ("setCallback", "(Lcom/liveperson/infra/ICallback;)V", "GetSetCallback_Lcom_liveperson_infra_ICallback_Handler")]
			set {
				if (id_setCallback_Lcom_liveperson_infra_ICallback_ == IntPtr.Zero)
					id_setCallback_Lcom_liveperson_infra_ICallback_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lcom/liveperson/infra/ICallback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCallback_Lcom_liveperson_infra_ICallback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallback", "(Lcom/liveperson/infra/ICallback;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCertificatePinningKeys;
#pragma warning disable 0169
		static Delegate GetGetCertificatePinningKeysHandler ()
		{
			if (cb_getCertificatePinningKeys == null)
				cb_getCertificatePinningKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCertificatePinningKeys);
			return cb_getCertificatePinningKeys;
		}

		static IntPtr n_GetCertificatePinningKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.CertificatePinningKeys);
		}
#pragma warning restore 0169

		static Delegate cb_setCertificatePinningKeys_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetCertificatePinningKeys_Ljava_util_List_Handler ()
		{
			if (cb_setCertificatePinningKeys_Ljava_util_List_ == null)
				cb_setCertificatePinningKeys_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCertificatePinningKeys_Ljava_util_List_);
			return cb_setCertificatePinningKeys_Ljava_util_List_;
		}

		static void n_SetCertificatePinningKeys_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CertificatePinningKeys = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCertificatePinningKeys;
		static IntPtr id_setCertificatePinningKeys_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<string> CertificatePinningKeys {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest']/method[@name='getCertificatePinningKeys' and count(parameter)=0]"
			[Register ("getCertificatePinningKeys", "()Ljava/util/List;", "GetGetCertificatePinningKeysHandler")]
			get {
				if (id_getCertificatePinningKeys == IntPtr.Zero)
					id_getCertificatePinningKeys = JNIEnv.GetMethodID (class_ref, "getCertificatePinningKeys", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCertificatePinningKeys), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCertificatePinningKeys", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest']/method[@name='setCertificatePinningKeys' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setCertificatePinningKeys", "(Ljava/util/List;)V", "GetSetCertificatePinningKeys_Ljava_util_List_Handler")]
			set {
				if (id_setCertificatePinningKeys_Ljava_util_List_ == IntPtr.Zero)
					id_setCertificatePinningKeys_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setCertificatePinningKeys", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCertificatePinningKeys_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCertificatePinningKeys", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFollowRedirect;
#pragma warning disable 0169
		static Delegate GetGetFollowRedirectHandler ()
		{
			if (cb_getFollowRedirect == null)
				cb_getFollowRedirect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetFollowRedirect);
			return cb_getFollowRedirect;
		}

		static bool n_GetFollowRedirect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FollowRedirect;
		}
#pragma warning restore 0169

		static Delegate cb_setFollowRedirect_Z;
#pragma warning disable 0169
		static Delegate GetSetFollowRedirect_ZHandler ()
		{
			if (cb_setFollowRedirect_Z == null)
				cb_setFollowRedirect_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFollowRedirect_Z);
			return cb_setFollowRedirect_Z;
		}

		static void n_SetFollowRedirect_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FollowRedirect = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFollowRedirect;
		static IntPtr id_setFollowRedirect_Z;
		public virtual unsafe bool FollowRedirect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest']/method[@name='getFollowRedirect' and count(parameter)=0]"
			[Register ("getFollowRedirect", "()Z", "GetGetFollowRedirectHandler")]
			get {
				if (id_getFollowRedirect == IntPtr.Zero)
					id_getFollowRedirect = JNIEnv.GetMethodID (class_ref, "getFollowRedirect", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getFollowRedirect);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFollowRedirect", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest']/method[@name='setFollowRedirect' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFollowRedirect", "(Z)V", "GetSetFollowRedirect_ZHandler")]
			set {
				if (id_setFollowRedirect_Z == IntPtr.Zero)
					id_setFollowRedirect_Z = JNIEnv.GetMethodID (class_ref, "setFollowRedirect", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFollowRedirect_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFollowRedirect", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHeaders;
#pragma warning disable 0169
		static Delegate GetGetHeadersHandler ()
		{
			if (cb_getHeaders == null)
				cb_getHeaders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeaders);
			return cb_getHeaders;
		}

		static IntPtr n_GetHeaders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Util.Pair>.ToLocalJniHandle (__this.Headers);
		}
#pragma warning restore 0169

		static IntPtr id_getHeaders;
		public virtual unsafe global::System.Collections.Generic.IList<global::Android.Util.Pair> Headers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest']/method[@name='getHeaders' and count(parameter)=0]"
			[Register ("getHeaders", "()Ljava/util/List;", "GetGetHeadersHandler")]
			get {
				if (id_getHeaders == IntPtr.Zero)
					id_getHeaders = JNIEnv.GetMethodID (class_ref, "getHeaders", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Android.Util.Pair>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeaders), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Android.Util.Pair>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaders", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMethod;
#pragma warning disable 0169
		static Delegate GetGetMethodHandler ()
		{
			if (cb_getMethod == null)
				cb_getMethod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMethod);
			return cb_getMethod;
		}

		static IntPtr n_GetMethod (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Method);
		}
#pragma warning restore 0169

		static IntPtr id_getMethod;
		public virtual unsafe global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest.HttpMethod Method {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest']/method[@name='getMethod' and count(parameter)=0]"
			[Register ("getMethod", "()Lcom/liveperson/infra/network/http/request/HttpRequest$HttpMethod;", "GetGetMethodHandler")]
			get {
				if (id_getMethod == IntPtr.Zero)
					id_getMethod = JNIEnv.GetMethodID (class_ref, "getMethod", "()Lcom/liveperson/infra/network/http/request/HttpRequest$HttpMethod;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest.HttpMethod> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMethod), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest.HttpMethod> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMethod", "()Lcom/liveperson/infra/network/http/request/HttpRequest$HttpMethod;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestBody);
		}
#pragma warning restore 0169

		public abstract global::Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBody RequestBody {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest']/method[@name='getRequestBody' and count(parameter)=0]"
			[Register ("getRequestBody", "()Lcom/liveperson/infra/network/http/body/HttpRequestBody;", "GetGetRequestBodyHandler")] get;
		}

		static Delegate cb_getTimeout;
#pragma warning disable 0169
		static Delegate GetGetTimeoutHandler ()
		{
			if (cb_getTimeout == null)
				cb_getTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTimeout);
			return cb_getTimeout;
		}

		static int n_GetTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timeout;
		}
#pragma warning restore 0169

		static Delegate cb_setTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetTimeout_IHandler ()
		{
			if (cb_setTimeout_I == null)
				cb_setTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTimeout_I);
			return cb_setTimeout_I;
		}

		static void n_SetTimeout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Timeout = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeout;
		static IntPtr id_setTimeout_I;
		public virtual unsafe int Timeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest']/method[@name='getTimeout' and count(parameter)=0]"
			[Register ("getTimeout", "()I", "GetGetTimeoutHandler")]
			get {
				if (id_getTimeout == IntPtr.Zero)
					id_getTimeout = JNIEnv.GetMethodID (class_ref, "getTimeout", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTimeout);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeout", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTimeout", "(I)V", "GetSetTimeout_IHandler")]
			set {
				if (id_setTimeout_I == IntPtr.Zero)
					id_setTimeout_I = JNIEnv.GetMethodID (class_ref, "setTimeout", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTimeout_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeout", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		static IntPtr id_getUrl;
		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				if (id_getUrl == IntPtr.Zero)
					id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addHeader_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddHeader_Ljava_lang_String_Ljava_lang_String_);
			return cb_addHeader_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddHeader_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddHeader (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addHeader_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest']/method[@name='addHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addHeader", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void AddHeader (string p0, string p1)
		{
			if (id_addHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addHeader_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_isResponseSuccessful_Lokhttp3_Response_;
#pragma warning disable 0169
		static Delegate GetIsResponseSuccessful_Lokhttp3_Response_Handler ()
		{
			if (cb_isResponseSuccessful_Lokhttp3_Response_ == null)
				cb_isResponseSuccessful_Lokhttp3_Response_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsResponseSuccessful_Lokhttp3_Response_);
			return cb_isResponseSuccessful_Lokhttp3_Response_;
		}

		static bool n_IsResponseSuccessful_Lokhttp3_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Square.OkHttp3.Response p0 = global::Java.Lang.Object.GetObject<global::Square.OkHttp3.Response> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsResponseSuccessful (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isResponseSuccessful_Lokhttp3_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest']/method[@name='isResponseSuccessful' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
		[Register ("isResponseSuccessful", "(Lokhttp3/Response;)Z", "GetIsResponseSuccessful_Lokhttp3_Response_Handler")]
		protected virtual unsafe bool IsResponseSuccessful (global::Square.OkHttp3.Response p0)
		{
			if (id_isResponseSuccessful_Lokhttp3_Response_ == IntPtr.Zero)
				id_isResponseSuccessful_Lokhttp3_Response_ = JNIEnv.GetMethodID (class_ref, "isResponseSuccessful", "(Lokhttp3/Response;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isResponseSuccessful_Lokhttp3_Response_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isResponseSuccessful", "(Lokhttp3/Response;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_processErrorResponse_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetProcessErrorResponse_Ljava_lang_Exception_Handler ()
		{
			if (cb_processErrorResponse_Ljava_lang_Exception_ == null)
				cb_processErrorResponse_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ProcessErrorResponse_Ljava_lang_Exception_);
			return cb_processErrorResponse_Ljava_lang_Exception_;
		}

		static void n_ProcessErrorResponse_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProcessErrorResponse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_processErrorResponse_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest']/method[@name='processErrorResponse' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("processErrorResponse", "(Ljava/lang/Exception;)V", "GetProcessErrorResponse_Ljava_lang_Exception_Handler")]
		public virtual unsafe void ProcessErrorResponse (global::Java.Lang.Exception p0)
		{
			if (id_processErrorResponse_Ljava_lang_Exception_ == IntPtr.Zero)
				id_processErrorResponse_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "processErrorResponse", "(Ljava/lang/Exception;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processErrorResponse_Ljava_lang_Exception_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processErrorResponse", "(Ljava/lang/Exception;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_processResponse_Lokhttp3_Response_;
#pragma warning disable 0169
		static Delegate GetProcessResponse_Lokhttp3_Response_Handler ()
		{
			if (cb_processResponse_Lokhttp3_Response_ == null)
				cb_processResponse_Lokhttp3_Response_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ProcessResponse_Lokhttp3_Response_);
			return cb_processResponse_Lokhttp3_Response_;
		}

		static void n_ProcessResponse_Lokhttp3_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Square.OkHttp3.Response p0 = global::Java.Lang.Object.GetObject<global::Square.OkHttp3.Response> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProcessResponse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_processResponse_Lokhttp3_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest']/method[@name='processResponse' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
		[Register ("processResponse", "(Lokhttp3/Response;)V", "GetProcessResponse_Lokhttp3_Response_Handler")]
		public virtual unsafe void ProcessResponse (global::Square.OkHttp3.Response p0)
		{
			if (id_processResponse_Lokhttp3_Response_ == IntPtr.Zero)
				id_processResponse_Lokhttp3_Response_ = JNIEnv.GetMethodID (class_ref, "processResponse", "(Lokhttp3/Response;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processResponse_Lokhttp3_Response_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processResponse", "(Lokhttp3/Response;)V"), __args);
			} finally {
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
			global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Square.OkHttp3.Response p0 = global::Java.Lang.Object.GetObject<global::Square.OkHttp3.Response> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReportSuccess (p0);
		}
#pragma warning restore 0169

		static IntPtr id_reportSuccess_Lokhttp3_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest']/method[@name='reportSuccess' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
		[Register ("reportSuccess", "(Lokhttp3/Response;)V", "GetReportSuccess_Lokhttp3_Response_Handler")]
		protected virtual unsafe void ReportSuccess (global::Square.OkHttp3.Response p0)
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
			global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBody p0 = (global::Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBody)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBody> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBody (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest']/method[@name='setBody' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.network.http.body.HttpRequestBody']]"
		[Register ("setBody", "(Lcom/liveperson/infra/network/http/body/HttpRequestBody;)V", "GetSetBody_Lcom_liveperson_infra_network_http_body_HttpRequestBody_Handler")]
		public abstract void SetBody (global::Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBody p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/network/http/request/HttpRequest", DoNotGenerateAcw=true)]
	internal partial class HttpRequestInvoker : HttpRequest {

		public HttpRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpRequestInvoker); }
		}

		static IntPtr id_getRequestBody;
		public override unsafe global::Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBody RequestBody {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest']/method[@name='getRequestBody' and count(parameter)=0]"
			[Register ("getRequestBody", "()Lcom/liveperson/infra/network/http/body/HttpRequestBody;", "GetGetRequestBodyHandler")]
			get {
				if (id_getRequestBody == IntPtr.Zero)
					id_getRequestBody = JNIEnv.GetMethodID (class_ref, "getRequestBody", "()Lcom/liveperson/infra/network/http/body/HttpRequestBody;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBody> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestBody), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_setBody_Lcom_liveperson_infra_network_http_body_HttpRequestBody_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.request']/class[@name='HttpRequest']/method[@name='setBody' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.network.http.body.HttpRequestBody']]"
		[Register ("setBody", "(Lcom/liveperson/infra/network/http/body/HttpRequestBody;)V", "GetSetBody_Lcom_liveperson_infra_network_http_body_HttpRequestBody_Handler")]
		public override unsafe void SetBody (global::Com.Liveperson.Infra.Network.Http.Body.IHttpRequestBody p0)
		{
			if (id_setBody_Lcom_liveperson_infra_network_http_body_HttpRequestBody_ == IntPtr.Zero)
				id_setBody_Lcom_liveperson_infra_network_http_body_HttpRequestBody_ = JNIEnv.GetMethodID (class_ref, "setBody", "(Lcom/liveperson/infra/network/http/body/HttpRequestBody;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBody_Lcom_liveperson_infra_network_http_body_HttpRequestBody_, __args);
			} finally {
			}
		}

	}

}
