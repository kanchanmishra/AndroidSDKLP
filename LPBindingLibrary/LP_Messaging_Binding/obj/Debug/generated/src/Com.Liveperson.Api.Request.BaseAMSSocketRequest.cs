using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='BaseAMSSocketRequest']"
	[global::Android.Runtime.Register ("com/liveperson/api/request/BaseAMSSocketRequest", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"DATA", "REQUEST extends com.liveperson.infra.network.socket.BaseSocketRequest"})]
	public abstract partial class BaseAMSSocketRequest : global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/request/BaseAMSSocketRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseAMSSocketRequest); }
		}

		protected BaseAMSSocketRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='BaseAMSSocketRequest']/constructor[@name='BaseAMSSocketRequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe BaseAMSSocketRequest (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (BaseAMSSocketRequest)) {
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

		static IntPtr id_ctor_Ljava_lang_String_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='BaseAMSSocketRequest']/constructor[@name='BaseAMSSocketRequest' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register (".ctor", "(Ljava/lang/String;J)V", "")]
		public unsafe BaseAMSSocketRequest (string p0, long p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (BaseAMSSocketRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;J)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_J == IntPtr.Zero)
					id_ctor_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_J, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getSocketUrl;
#pragma warning disable 0169
		static Delegate GetGetSocketUrlHandler ()
		{
			if (cb_getSocketUrl == null)
				cb_getSocketUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSocketUrl);
			return cb_getSocketUrl;
		}

		static IntPtr n_GetSocketUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Request.BaseAMSSocketRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.BaseAMSSocketRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SocketUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getSocketUrl;
		protected override unsafe string SocketUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='BaseAMSSocketRequest']/method[@name='getSocketUrl' and count(parameter)=0]"
			[Register ("getSocketUrl", "()Ljava/lang/String;", "GetGetSocketUrlHandler")]
			get {
				if (id_getSocketUrl == IntPtr.Zero)
					id_getSocketUrl = JNIEnv.GetMethodID (class_ref, "getSocketUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSocketUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSocketUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/api/request/BaseAMSSocketRequest", DoNotGenerateAcw=true)]
	internal partial class BaseAMSSocketRequestInvoker : BaseAMSSocketRequest {

		public BaseAMSSocketRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseAMSSocketRequestInvoker); }
		}

		static IntPtr id_getData;
		protected override unsafe global::System.String Data {
			[Register ("getData", "()Ljava/lang/String;", "GetGetDataHandler")]
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getResponseHandler;
		protected override unsafe global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler RawResponseHandler {
			[Register ("getResponseHandler", "()Lcom/liveperson/infra/network/socket/BaseResponseHandler;", "GetGetRawResponseHandlerHandler")]
			get {
				if (id_getResponseHandler == IntPtr.Zero)
					id_getResponseHandler = JNIEnv.GetMethodID (class_ref, "getResponseHandler", "()Lcom/liveperson/infra/network/socket/BaseResponseHandler;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseHandler), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getRequestName;
		protected override unsafe global::System.String RequestName {
			[Register ("getRequestName", "()Ljava/lang/String;", "GetGetRequestNameHandler")]
			get {
				if (id_getRequestName == IntPtr.Zero)
					id_getRequestName = JNIEnv.GetMethodID (class_ref, "getRequestName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

}
