using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Network.Socket {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='BaseSocketRequest']"
	[global::Android.Runtime.Register ("com/liveperson/infra/network/socket/BaseSocketRequest", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "REQUEST extends com.liveperson.infra.network.socket.BaseSocketRequest"})]
	public abstract partial class BaseSocketRequest : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/network/socket/BaseSocketRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseSocketRequest); }
		}

		protected BaseSocketRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='BaseSocketRequest']/constructor[@name='BaseSocketRequest' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe BaseSocketRequest (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (BaseSocketRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(J)V", __args);
					return;
				}

				if (id_ctor_J == IntPtr.Zero)
					id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_J, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='BaseSocketRequest']/constructor[@name='BaseSocketRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseSocketRequest ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BaseSocketRequest)) {
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

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Data);
		}
#pragma warning restore 0169

		protected abstract string Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='BaseSocketRequest']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/lang/String;", "GetGetDataHandler")] get;
		}

		static Delegate cb_getResponseHandler;
#pragma warning disable 0169
		static Delegate GetGetResponseHandlerHandler ()
		{
			if (cb_getResponseHandler == null)
				cb_getResponseHandler = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseHandler);
			return cb_getResponseHandler;
		}

		static IntPtr n_GetResponseHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RawResponseHandler);
		}
#pragma warning restore 0169

		protected abstract global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler RawResponseHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='BaseSocketRequest']/method[@name='getResponseHandler' and count(parameter)=0]"
			[Register ("getResponseHandler", "()Lcom/liveperson/infra/network/socket/BaseResponseHandler;", "GetGetResponseHandlerHandler")] get;
		}

		static Delegate cb_getRequestId;
#pragma warning disable 0169
		static Delegate GetGetRequestIdHandler ()
		{
			if (cb_getRequestId == null)
				cb_getRequestId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetRequestId);
			return cb_getRequestId;
		}

		static long n_GetRequestId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequestId;
		}
#pragma warning restore 0169

		static IntPtr id_getRequestId;
		public virtual unsafe long RequestId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='BaseSocketRequest']/method[@name='getRequestId' and count(parameter)=0]"
			[Register ("getRequestId", "()J", "GetGetRequestIdHandler")]
			get {
				if (id_getRequestId == IntPtr.Zero)
					id_getRequestId = JNIEnv.GetMethodID (class_ref, "getRequestId", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getRequestId);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestId", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getRequestName;
#pragma warning disable 0169
		static Delegate GetGetRequestNameHandler ()
		{
			if (cb_getRequestName == null)
				cb_getRequestName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestName);
			return cb_getRequestName;
		}

		static IntPtr n_GetRequestName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestName);
		}
#pragma warning restore 0169

		protected abstract string RequestName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='BaseSocketRequest']/method[@name='getRequestName' and count(parameter)=0]"
			[Register ("getRequestName", "()Ljava/lang/String;", "GetGetRequestNameHandler")] get;
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
			global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SocketUrl);
		}
#pragma warning restore 0169

		protected abstract string SocketUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='BaseSocketRequest']/method[@name='getSocketUrl' and count(parameter)=0]"
			[Register ("getSocketUrl", "()Ljava/lang/String;", "GetGetSocketUrlHandler")] get;
		}

		static Delegate cb_addCallback_Lcom_liveperson_infra_network_socket_ResponseCallback_;
#pragma warning disable 0169
		static Delegate GetAddCallback_Lcom_liveperson_infra_network_socket_ResponseCallback_Handler ()
		{
			if (cb_addCallback_Lcom_liveperson_infra_network_socket_ResponseCallback_ == null)
				cb_addCallback_Lcom_liveperson_infra_network_socket_ResponseCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddCallback_Lcom_liveperson_infra_network_socket_ResponseCallback_);
			return cb_addCallback_Lcom_liveperson_infra_network_socket_ResponseCallback_;
		}

		static IntPtr n_AddCallback_Lcom_liveperson_infra_network_socket_ResponseCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Network.Socket.IResponseCallback p0 = (global::Com.Liveperson.Infra.Network.Socket.IResponseCallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.IResponseCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddCallback (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addCallback_Lcom_liveperson_infra_network_socket_ResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='BaseSocketRequest']/method[@name='addCallback' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.network.socket.ResponseCallback&lt;T&gt;']]"
		[Register ("addCallback", "(Lcom/liveperson/infra/network/socket/ResponseCallback;)Lcom/liveperson/infra/network/socket/BaseSocketRequest;", "GetAddCallback_Lcom_liveperson_infra_network_socket_ResponseCallback_Handler")]
		public virtual unsafe global::Java.Lang.Object AddCallback (global::Com.Liveperson.Infra.Network.Socket.IResponseCallback p0)
		{
			if (id_addCallback_Lcom_liveperson_infra_network_socket_ResponseCallback_ == IntPtr.Zero)
				id_addCallback_Lcom_liveperson_infra_network_socket_ResponseCallback_ = JNIEnv.GetMethodID (class_ref, "addCallback", "(Lcom/liveperson/infra/network/socket/ResponseCallback;)Lcom/liveperson/infra/network/socket/BaseSocketRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addCallback_Lcom_liveperson_infra_network_socket_ResponseCallback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addCallback", "(Lcom/liveperson/infra/network/socket/ResponseCallback;)Lcom/liveperson/infra/network/socket/BaseSocketRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createRequestId;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='BaseSocketRequest']/method[@name='createRequestId' and count(parameter)=0]"
		[Register ("createRequestId", "()J", "")]
		public static unsafe long CreateRequestId ()
		{
			if (id_createRequestId == IntPtr.Zero)
				id_createRequestId = JNIEnv.GetStaticMethodID (class_ref, "createRequestId", "()J");
			try {
				return JNIEnv.CallStaticLongMethod  (class_ref, id_createRequestId);
			} finally {
			}
		}

		static Delegate cb_removeCallback_Lcom_liveperson_infra_network_socket_ResponseCallback_;
#pragma warning disable 0169
		static Delegate GetRemoveCallback_Lcom_liveperson_infra_network_socket_ResponseCallback_Handler ()
		{
			if (cb_removeCallback_Lcom_liveperson_infra_network_socket_ResponseCallback_ == null)
				cb_removeCallback_Lcom_liveperson_infra_network_socket_ResponseCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveCallback_Lcom_liveperson_infra_network_socket_ResponseCallback_);
			return cb_removeCallback_Lcom_liveperson_infra_network_socket_ResponseCallback_;
		}

		static IntPtr n_RemoveCallback_Lcom_liveperson_infra_network_socket_ResponseCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Network.Socket.IResponseCallback p0 = (global::Com.Liveperson.Infra.Network.Socket.IResponseCallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.IResponseCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveCallback (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeCallback_Lcom_liveperson_infra_network_socket_ResponseCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='BaseSocketRequest']/method[@name='removeCallback' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.network.socket.ResponseCallback&lt;T&gt;']]"
		[Register ("removeCallback", "(Lcom/liveperson/infra/network/socket/ResponseCallback;)Lcom/liveperson/infra/network/socket/BaseSocketRequest;", "GetRemoveCallback_Lcom_liveperson_infra_network_socket_ResponseCallback_Handler")]
		public virtual unsafe global::Java.Lang.Object RemoveCallback (global::Com.Liveperson.Infra.Network.Socket.IResponseCallback p0)
		{
			if (id_removeCallback_Lcom_liveperson_infra_network_socket_ResponseCallback_ == IntPtr.Zero)
				id_removeCallback_Lcom_liveperson_infra_network_socket_ResponseCallback_ = JNIEnv.GetMethodID (class_ref, "removeCallback", "(Lcom/liveperson/infra/network/socket/ResponseCallback;)Lcom/liveperson/infra/network/socket/BaseSocketRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeCallback_Lcom_liveperson_infra_network_socket_ResponseCallback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeCallback", "(Lcom/liveperson/infra/network/socket/ResponseCallback;)Lcom/liveperson/infra/network/socket/BaseSocketRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setRequestId_J;
#pragma warning disable 0169
		static Delegate GetSetRequestId_JHandler ()
		{
			if (cb_setRequestId_J == null)
				cb_setRequestId_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetRequestId_J);
			return cb_setRequestId_J;
		}

		static IntPtr n_SetRequestId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetRequestId (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setRequestId_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='BaseSocketRequest']/method[@name='setRequestId' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setRequestId", "(J)Lcom/liveperson/infra/network/socket/BaseSocketRequest;", "GetSetRequestId_JHandler")]
		public virtual unsafe global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest SetRequestId (long p0)
		{
			if (id_setRequestId_J == IntPtr.Zero)
				id_setRequestId_J = JNIEnv.GetMethodID (class_ref, "setRequestId", "(J)Lcom/liveperson/infra/network/socket/BaseSocketRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setRequestId_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequestId", "(J)Lcom/liveperson/infra/network/socket/BaseSocketRequest;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/network/socket/BaseSocketRequest", DoNotGenerateAcw=true)]
	internal partial class BaseSocketRequestInvoker : BaseSocketRequest {

		public BaseSocketRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseSocketRequestInvoker); }
		}

		static IntPtr id_getData;
		protected override unsafe string Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='BaseSocketRequest']/method[@name='getData' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='BaseSocketRequest']/method[@name='getResponseHandler' and count(parameter)=0]"
			[Register ("getResponseHandler", "()Lcom/liveperson/infra/network/socket/BaseResponseHandler;", "GetGetResponseHandlerHandler")]
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
		protected override unsafe string RequestName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='BaseSocketRequest']/method[@name='getRequestName' and count(parameter)=0]"
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

		static IntPtr id_getSocketUrl;
		protected override unsafe string SocketUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='BaseSocketRequest']/method[@name='getSocketUrl' and count(parameter)=0]"
			[Register ("getSocketUrl", "()Ljava/lang/String;", "GetGetSocketUrlHandler")]
			get {
				if (id_getSocketUrl == IntPtr.Zero)
					id_getSocketUrl = JNIEnv.GetMethodID (class_ref, "getSocketUrl", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSocketUrl), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

}
