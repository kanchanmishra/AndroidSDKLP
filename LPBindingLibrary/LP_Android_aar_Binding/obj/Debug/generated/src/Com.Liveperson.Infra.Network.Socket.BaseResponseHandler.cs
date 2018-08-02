using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Network.Socket {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='BaseResponseHandler']"
	[global::Android.Runtime.Register ("com/liveperson/infra/network/socket/BaseResponseHandler", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"DATA", "REQUEST extends com.liveperson.infra.network.socket.BaseSocketRequest"})]
	public abstract partial class BaseResponseHandler : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/network/socket/BaseResponseHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseResponseHandler); }
		}

		protected BaseResponseHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='BaseResponseHandler']/constructor[@name='BaseResponseHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseResponseHandler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BaseResponseHandler)) {
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

		static Delegate cb_getAPIResponseType;
#pragma warning disable 0169
		static Delegate GetGetAPIResponseTypeHandler ()
		{
			if (cb_getAPIResponseType == null)
				cb_getAPIResponseType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAPIResponseType);
			return cb_getAPIResponseType;
		}

		static IntPtr n_GetAPIResponseType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.APIResponseType);
		}
#pragma warning restore 0169

		public abstract string APIResponseType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='BaseResponseHandler']/method[@name='getAPIResponseType' and count(parameter)=0]"
			[Register ("getAPIResponseType", "()Ljava/lang/String;", "GetGetAPIResponseTypeHandler")] get;
		}

		static Delegate cb_getRequest;
#pragma warning disable 0169
		static Delegate GetGetRequestHandler ()
		{
			if (cb_getRequest == null)
				cb_getRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequest);
			return cb_getRequest;
		}

		static IntPtr n_GetRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Request);
		}
#pragma warning restore 0169

		static IntPtr id_getRequest;
		protected virtual unsafe global::Java.Lang.Object Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='BaseResponseHandler']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lcom/liveperson/infra/network/socket/BaseSocketRequest;", "GetGetRequestHandler")]
			get {
				if (id_getRequest == IntPtr.Zero)
					id_getRequest = JNIEnv.GetMethodID (class_ref, "getRequest", "()Lcom/liveperson/infra/network/socket/BaseSocketRequest;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequest), JniHandleOwnership.TransferLocalRef);
					else
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequest", "()Lcom/liveperson/infra/network/socket/BaseSocketRequest;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResponseByExpectedType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetResponseByExpectedType_Ljava_lang_String_Handler ()
		{
			if (cb_getResponseByExpectedType_Ljava_lang_String_ == null)
				cb_getResponseByExpectedType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetResponseByExpectedType_Ljava_lang_String_);
			return cb_getResponseByExpectedType_Ljava_lang_String_;
		}

		static IntPtr n_GetResponseByExpectedType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetResponseByExpectedType (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getResponseByExpectedType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='BaseResponseHandler']/method[@name='getResponseByExpectedType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getResponseByExpectedType", "(Ljava/lang/String;)Lcom/liveperson/infra/network/socket/BaseResponseHandler;", "GetGetResponseByExpectedType_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler GetResponseByExpectedType (string p0)
		{
			if (id_getResponseByExpectedType_Ljava_lang_String_ == IntPtr.Zero)
				id_getResponseByExpectedType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getResponseByExpectedType", "(Ljava/lang/String;)Lcom/liveperson/infra/network/socket/BaseResponseHandler;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseByExpectedType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseByExpectedType", "(Ljava/lang/String;)Lcom/liveperson/infra/network/socket/BaseResponseHandler;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getSupportedResponseHandler_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSupportedResponseHandler_Ljava_lang_String_Handler ()
		{
			if (cb_getSupportedResponseHandler_Ljava_lang_String_ == null)
				cb_getSupportedResponseHandler_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSupportedResponseHandler_Ljava_lang_String_);
			return cb_getSupportedResponseHandler_Ljava_lang_String_;
		}

		static IntPtr n_GetSupportedResponseHandler_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSupportedResponseHandler (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSupportedResponseHandler_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='BaseResponseHandler']/method[@name='getSupportedResponseHandler' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSupportedResponseHandler", "(Ljava/lang/String;)Lcom/liveperson/infra/network/socket/BaseResponseHandler;", "GetGetSupportedResponseHandler_Ljava_lang_String_Handler")]
		protected virtual unsafe global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler GetSupportedResponseHandler (string p0)
		{
			if (id_getSupportedResponseHandler_Ljava_lang_String_ == IntPtr.Zero)
				id_getSupportedResponseHandler_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getSupportedResponseHandler", "(Ljava/lang/String;)Lcom/liveperson/infra/network/socket/BaseResponseHandler;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSupportedResponseHandler_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSupportedResponseHandler", "(Ljava/lang/String;)Lcom/liveperson/infra/network/socket/BaseResponseHandler;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_giveUp;
#pragma warning disable 0169
		static Delegate GetGiveUpHandler ()
		{
			if (cb_giveUp == null)
				cb_giveUp = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_GiveUp);
			return cb_giveUp;
		}

		static void n_GiveUp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GiveUp ();
		}
#pragma warning restore 0169

		static IntPtr id_giveUp;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='BaseResponseHandler']/method[@name='giveUp' and count(parameter)=0]"
		[Register ("giveUp", "()V", "GetGiveUpHandler")]
		protected virtual unsafe void GiveUp ()
		{
			if (id_giveUp == IntPtr.Zero)
				id_giveUp = JNIEnv.GetMethodID (class_ref, "giveUp", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_giveUp);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "giveUp", "()V"));
			} finally {
			}
		}

		static Delegate cb_onParsingError;
#pragma warning disable 0169
		static Delegate GetOnParsingErrorHandler ()
		{
			if (cb_onParsingError == null)
				cb_onParsingError = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnParsingError);
			return cb_onParsingError;
		}

		static void n_OnParsingError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnParsingError ();
		}
#pragma warning restore 0169

		static IntPtr id_onParsingError;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='BaseResponseHandler']/method[@name='onParsingError' and count(parameter)=0]"
		[Register ("onParsingError", "()V", "GetOnParsingErrorHandler")]
		protected virtual unsafe void OnParsingError ()
		{
			if (id_onParsingError == IntPtr.Zero)
				id_onParsingError = JNIEnv.GetMethodID (class_ref, "onParsingError", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onParsingError);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onParsingError", "()V"));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/network/socket/BaseResponseHandler", DoNotGenerateAcw=true)]
	internal partial class BaseResponseHandlerInvoker : BaseResponseHandler {

		public BaseResponseHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseResponseHandlerInvoker); }
		}

		static IntPtr id_getAPIResponseType;
		public override unsafe string APIResponseType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='BaseResponseHandler']/method[@name='getAPIResponseType' and count(parameter)=0]"
			[Register ("getAPIResponseType", "()Ljava/lang/String;", "GetGetAPIResponseTypeHandler")]
			get {
				if (id_getAPIResponseType == IntPtr.Zero)
					id_getAPIResponseType = JNIEnv.GetMethodID (class_ref, "getAPIResponseType", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAPIResponseType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

}
