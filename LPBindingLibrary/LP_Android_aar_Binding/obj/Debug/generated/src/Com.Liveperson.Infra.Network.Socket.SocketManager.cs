using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Network.Socket {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketManager']"
	[global::Android.Runtime.Register ("com/liveperson/infra/network/socket/SocketManager", DoNotGenerateAcw=true)]
	public partial class SocketManager : global::Java.Lang.Object, global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDown {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/network/socket/SocketManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocketManager); }
		}

		protected SocketManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Liveperson.Infra.Network.Socket.SocketManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/liveperson/infra/network/socket/SocketManager;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/liveperson/infra/network/socket/SocketManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_cancelDelayedRequest_Lcom_liveperson_infra_network_socket_BaseSocketRequest_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetCancelDelayedRequest_Lcom_liveperson_infra_network_socket_BaseSocketRequest_Ljava_lang_Runnable_Handler ()
		{
			if (cb_cancelDelayedRequest_Lcom_liveperson_infra_network_socket_BaseSocketRequest_Ljava_lang_Runnable_ == null)
				cb_cancelDelayedRequest_Lcom_liveperson_infra_network_socket_BaseSocketRequest_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CancelDelayedRequest_Lcom_liveperson_infra_network_socket_BaseSocketRequest_Ljava_lang_Runnable_);
			return cb_cancelDelayedRequest_Lcom_liveperson_infra_network_socket_BaseSocketRequest_Ljava_lang_Runnable_;
		}

		static void n_CancelDelayedRequest_Lcom_liveperson_infra_network_socket_BaseSocketRequest_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Network.Socket.SocketManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p1 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CancelDelayedRequest (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_cancelDelayedRequest_Lcom_liveperson_infra_network_socket_BaseSocketRequest_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketManager']/method[@name='cancelDelayedRequest' and count(parameter)=2 and parameter[1][@type='com.liveperson.infra.network.socket.BaseSocketRequest'] and parameter[2][@type='java.lang.Runnable']]"
		[Register ("cancelDelayedRequest", "(Lcom/liveperson/infra/network/socket/BaseSocketRequest;Ljava/lang/Runnable;)V", "GetCancelDelayedRequest_Lcom_liveperson_infra_network_socket_BaseSocketRequest_Ljava_lang_Runnable_Handler")]
		public virtual unsafe void CancelDelayedRequest (global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest p0, global::Java.Lang.IRunnable p1)
		{
			if (id_cancelDelayedRequest_Lcom_liveperson_infra_network_socket_BaseSocketRequest_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_cancelDelayedRequest_Lcom_liveperson_infra_network_socket_BaseSocketRequest_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "cancelDelayedRequest", "(Lcom/liveperson/infra/network/socket/BaseSocketRequest;Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelDelayedRequest_Lcom_liveperson_infra_network_socket_BaseSocketRequest_Ljava_lang_Runnable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelDelayedRequest", "(Lcom/liveperson/infra/network/socket/BaseSocketRequest;Ljava/lang/Runnable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_connect_Lcom_liveperson_infra_model_SocketConnectionParams_;
#pragma warning disable 0169
		static Delegate GetConnect_Lcom_liveperson_infra_model_SocketConnectionParams_Handler ()
		{
			if (cb_connect_Lcom_liveperson_infra_model_SocketConnectionParams_ == null)
				cb_connect_Lcom_liveperson_infra_model_SocketConnectionParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Connect_Lcom_liveperson_infra_model_SocketConnectionParams_);
			return cb_connect_Lcom_liveperson_infra_model_SocketConnectionParams_;
		}

		static void n_Connect_Lcom_liveperson_infra_model_SocketConnectionParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Socket.SocketManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Model.SocketConnectionParams p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.SocketConnectionParams> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0);
		}
#pragma warning restore 0169

		static IntPtr id_connect_Lcom_liveperson_infra_model_SocketConnectionParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketManager']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.model.SocketConnectionParams']]"
		[Register ("connect", "(Lcom/liveperson/infra/model/SocketConnectionParams;)V", "GetConnect_Lcom_liveperson_infra_model_SocketConnectionParams_Handler")]
		public virtual unsafe void Connect (global::Com.Liveperson.Infra.Model.SocketConnectionParams p0)
		{
			if (id_connect_Lcom_liveperson_infra_model_SocketConnectionParams_ == IntPtr.Zero)
				id_connect_Lcom_liveperson_infra_model_SocketConnectionParams_ = JNIEnv.GetMethodID (class_ref, "connect", "(Lcom/liveperson/infra/model/SocketConnectionParams;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect_Lcom_liveperson_infra_model_SocketConnectionParams_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "(Lcom/liveperson/infra/model/SocketConnectionParams;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_connect_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_lang_String_IHandler ()
		{
			if (cb_connect_Ljava_lang_String_I == null)
				cb_connect_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Connect_Ljava_lang_String_I);
			return cb_connect_Ljava_lang_String_I;
		}

		static void n_Connect_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Liveperson.Infra.Network.Socket.SocketManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_connect_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketManager']/method[@name='connect' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("connect", "(Ljava/lang/String;I)V", "GetConnect_Ljava_lang_String_IHandler")]
		public virtual unsafe void Connect (string p0, int p1)
		{
			if (id_connect_Ljava_lang_String_I == IntPtr.Zero)
				id_connect_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "connect", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "(Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_disconnect_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDisconnect_Ljava_lang_String_Handler ()
		{
			if (cb_disconnect_Ljava_lang_String_ == null)
				cb_disconnect_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Disconnect_Ljava_lang_String_);
			return cb_disconnect_Ljava_lang_String_;
		}

		static void n_Disconnect_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Socket.SocketManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect (p0);
		}
#pragma warning restore 0169

		static IntPtr id_disconnect_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketManager']/method[@name='disconnect' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("disconnect", "(Ljava/lang/String;)V", "GetDisconnect_Ljava_lang_String_Handler")]
		public virtual unsafe void Disconnect (string p0)
		{
			if (id_disconnect_Ljava_lang_String_ == IntPtr.Zero)
				id_disconnect_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "disconnect", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnect_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnect", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getSocketState_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSocketState_Ljava_lang_String_Handler ()
		{
			if (cb_getSocketState_Ljava_lang_String_ == null)
				cb_getSocketState_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSocketState_Ljava_lang_String_);
			return cb_getSocketState_Ljava_lang_String_;
		}

		static IntPtr n_GetSocketState_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Socket.SocketManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSocketState (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSocketState_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketManager']/method[@name='getSocketState' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSocketState", "(Ljava/lang/String;)Lcom/liveperson/infra/network/socket/SocketState;", "GetGetSocketState_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Network.Socket.SocketState GetSocketState (string p0)
		{
			if (id_getSocketState_Ljava_lang_String_ == IntPtr.Zero)
				id_getSocketState_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getSocketState", "(Ljava/lang/String;)Lcom/liveperson/infra/network/socket/SocketState;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Network.Socket.SocketState __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSocketState_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketState> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSocketState", "(Ljava/lang/String;)Lcom/liveperson/infra/network/socket/SocketState;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_killSocket_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetKillSocket_Ljava_lang_String_Handler ()
		{
			if (cb_killSocket_Ljava_lang_String_ == null)
				cb_killSocket_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_KillSocket_Ljava_lang_String_);
			return cb_killSocket_Ljava_lang_String_;
		}

		static void n_KillSocket_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Socket.SocketManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.KillSocket (p0);
		}
#pragma warning restore 0169

		static IntPtr id_killSocket_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketManager']/method[@name='killSocket' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("killSocket", "(Ljava/lang/String;)V", "GetKillSocket_Ljava_lang_String_Handler")]
		public virtual unsafe void KillSocket (string p0)
		{
			if (id_killSocket_Ljava_lang_String_ == IntPtr.Zero)
				id_killSocket_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "killSocket", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_killSocket_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "killSocket", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putGeneralHandlerMap_Lcom_liveperson_infra_network_socket_GeneralResponseHandler_;
#pragma warning disable 0169
		static Delegate GetPutGeneralHandlerMap_Lcom_liveperson_infra_network_socket_GeneralResponseHandler_Handler ()
		{
			if (cb_putGeneralHandlerMap_Lcom_liveperson_infra_network_socket_GeneralResponseHandler_ == null)
				cb_putGeneralHandlerMap_Lcom_liveperson_infra_network_socket_GeneralResponseHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutGeneralHandlerMap_Lcom_liveperson_infra_network_socket_GeneralResponseHandler_);
			return cb_putGeneralHandlerMap_Lcom_liveperson_infra_network_socket_GeneralResponseHandler_;
		}

		static void n_PutGeneralHandlerMap_Lcom_liveperson_infra_network_socket_GeneralResponseHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Socket.SocketManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Network.Socket.GeneralResponseHandler p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.GeneralResponseHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutGeneralHandlerMap (p0);
		}
#pragma warning restore 0169

		static IntPtr id_putGeneralHandlerMap_Lcom_liveperson_infra_network_socket_GeneralResponseHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketManager']/method[@name='putGeneralHandlerMap' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.network.socket.GeneralResponseHandler']]"
		[Register ("putGeneralHandlerMap", "(Lcom/liveperson/infra/network/socket/GeneralResponseHandler;)V", "GetPutGeneralHandlerMap_Lcom_liveperson_infra_network_socket_GeneralResponseHandler_Handler")]
		public virtual unsafe void PutGeneralHandlerMap (global::Com.Liveperson.Infra.Network.Socket.GeneralResponseHandler p0)
		{
			if (id_putGeneralHandlerMap_Lcom_liveperson_infra_network_socket_GeneralResponseHandler_ == IntPtr.Zero)
				id_putGeneralHandlerMap_Lcom_liveperson_infra_network_socket_GeneralResponseHandler_ = JNIEnv.GetMethodID (class_ref, "putGeneralHandlerMap", "(Lcom/liveperson/infra/network/socket/GeneralResponseHandler;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putGeneralHandlerMap_Lcom_liveperson_infra_network_socket_GeneralResponseHandler_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putGeneralHandlerMap", "(Lcom/liveperson/infra/network/socket/GeneralResponseHandler;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_registerToSocketState_Ljava_lang_String_Lcom_liveperson_infra_network_socket_state_SocketStateListener_;
#pragma warning disable 0169
		static Delegate GetRegisterToSocketState_Ljava_lang_String_Lcom_liveperson_infra_network_socket_state_SocketStateListener_Handler ()
		{
			if (cb_registerToSocketState_Ljava_lang_String_Lcom_liveperson_infra_network_socket_state_SocketStateListener_ == null)
				cb_registerToSocketState_Ljava_lang_String_Lcom_liveperson_infra_network_socket_state_SocketStateListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterToSocketState_Ljava_lang_String_Lcom_liveperson_infra_network_socket_state_SocketStateListener_);
			return cb_registerToSocketState_Ljava_lang_String_Lcom_liveperson_infra_network_socket_state_SocketStateListener_;
		}

		static void n_RegisterToSocketState_Ljava_lang_String_Lcom_liveperson_infra_network_socket_state_SocketStateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Network.Socket.SocketManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Network.Socket.State.ISocketStateListener p1 = (global::Com.Liveperson.Infra.Network.Socket.State.ISocketStateListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.State.ISocketStateListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RegisterToSocketState (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_registerToSocketState_Ljava_lang_String_Lcom_liveperson_infra_network_socket_state_SocketStateListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketManager']/method[@name='registerToSocketState' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.network.socket.state.SocketStateListener']]"
		[Register ("registerToSocketState", "(Ljava/lang/String;Lcom/liveperson/infra/network/socket/state/SocketStateListener;)V", "GetRegisterToSocketState_Ljava_lang_String_Lcom_liveperson_infra_network_socket_state_SocketStateListener_Handler")]
		public virtual unsafe void RegisterToSocketState (string p0, global::Com.Liveperson.Infra.Network.Socket.State.ISocketStateListener p1)
		{
			if (id_registerToSocketState_Ljava_lang_String_Lcom_liveperson_infra_network_socket_state_SocketStateListener_ == IntPtr.Zero)
				id_registerToSocketState_Ljava_lang_String_Lcom_liveperson_infra_network_socket_state_SocketStateListener_ = JNIEnv.GetMethodID (class_ref, "registerToSocketState", "(Ljava/lang/String;Lcom/liveperson/infra/network/socket/state/SocketStateListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerToSocketState_Ljava_lang_String_Lcom_liveperson_infra_network_socket_state_SocketStateListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerToSocketState", "(Ljava/lang/String;Lcom/liveperson/infra/network/socket/state/SocketStateListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_send_Lcom_liveperson_infra_network_socket_BaseSocketRequest_;
#pragma warning disable 0169
		static Delegate GetSend_Lcom_liveperson_infra_network_socket_BaseSocketRequest_Handler ()
		{
			if (cb_send_Lcom_liveperson_infra_network_socket_BaseSocketRequest_ == null)
				cb_send_Lcom_liveperson_infra_network_socket_BaseSocketRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Send_Lcom_liveperson_infra_network_socket_BaseSocketRequest_);
			return cb_send_Lcom_liveperson_infra_network_socket_BaseSocketRequest_;
		}

		static void n_Send_Lcom_liveperson_infra_network_socket_BaseSocketRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Socket.SocketManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0);
		}
#pragma warning restore 0169

		static IntPtr id_send_Lcom_liveperson_infra_network_socket_BaseSocketRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketManager']/method[@name='send' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.network.socket.BaseSocketRequest']]"
		[Register ("send", "(Lcom/liveperson/infra/network/socket/BaseSocketRequest;)V", "GetSend_Lcom_liveperson_infra_network_socket_BaseSocketRequest_Handler")]
		public virtual unsafe void Send (global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest p0)
		{
			if (id_send_Lcom_liveperson_infra_network_socket_BaseSocketRequest_ == IntPtr.Zero)
				id_send_Lcom_liveperson_infra_network_socket_BaseSocketRequest_ = JNIEnv.GetMethodID (class_ref, "send", "(Lcom/liveperson/infra/network/socket/BaseSocketRequest;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_send_Lcom_liveperson_infra_network_socket_BaseSocketRequest_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "(Lcom/liveperson/infra/network/socket/BaseSocketRequest;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_send_Lcom_liveperson_infra_network_socket_BaseSocketRequest_J;
#pragma warning disable 0169
		static Delegate GetSend_Lcom_liveperson_infra_network_socket_BaseSocketRequest_JHandler ()
		{
			if (cb_send_Lcom_liveperson_infra_network_socket_BaseSocketRequest_J == null)
				cb_send_Lcom_liveperson_infra_network_socket_BaseSocketRequest_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_Send_Lcom_liveperson_infra_network_socket_BaseSocketRequest_J);
			return cb_send_Lcom_liveperson_infra_network_socket_BaseSocketRequest_J;
		}

		static IntPtr n_Send_Lcom_liveperson_infra_network_socket_BaseSocketRequest_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Liveperson.Infra.Network.Socket.SocketManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Send (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_send_Lcom_liveperson_infra_network_socket_BaseSocketRequest_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketManager']/method[@name='send' and count(parameter)=2 and parameter[1][@type='com.liveperson.infra.network.socket.BaseSocketRequest'] and parameter[2][@type='long']]"
		[Register ("send", "(Lcom/liveperson/infra/network/socket/BaseSocketRequest;J)Ljava/lang/Runnable;", "GetSend_Lcom_liveperson_infra_network_socket_BaseSocketRequest_JHandler")]
		public virtual unsafe global::Java.Lang.IRunnable Send (global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest p0, long p1)
		{
			if (id_send_Lcom_liveperson_infra_network_socket_BaseSocketRequest_J == IntPtr.Zero)
				id_send_Lcom_liveperson_infra_network_socket_BaseSocketRequest_J = JNIEnv.GetMethodID (class_ref, "send", "(Lcom/liveperson/infra/network/socket/BaseSocketRequest;J)Ljava/lang/Runnable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Lang.IRunnable __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_send_Lcom_liveperson_infra_network_socket_BaseSocketRequest_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "(Lcom/liveperson/infra/network/socket/BaseSocketRequest;J)Ljava/lang/Runnable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_shutDown;
#pragma warning disable 0169
		static Delegate GetShutDownHandler ()
		{
			if (cb_shutDown == null)
				cb_shutDown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShutDown);
			return cb_shutDown;
		}

		static void n_ShutDown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Socket.SocketManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShutDown ();
		}
#pragma warning restore 0169

		static IntPtr id_shutDown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketManager']/method[@name='shutDown' and count(parameter)=0]"
		[Register ("shutDown", "()V", "GetShutDownHandler")]
		public virtual unsafe void ShutDown ()
		{
			if (id_shutDown == IntPtr.Zero)
				id_shutDown = JNIEnv.GetMethodID (class_ref, "shutDown", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutDown);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shutDown", "()V"));
			} finally {
			}
		}

		static Delegate cb_unregisterFromSocketState_Ljava_lang_String_Lcom_liveperson_infra_network_socket_state_SocketStateListener_;
#pragma warning disable 0169
		static Delegate GetUnregisterFromSocketState_Ljava_lang_String_Lcom_liveperson_infra_network_socket_state_SocketStateListener_Handler ()
		{
			if (cb_unregisterFromSocketState_Ljava_lang_String_Lcom_liveperson_infra_network_socket_state_SocketStateListener_ == null)
				cb_unregisterFromSocketState_Ljava_lang_String_Lcom_liveperson_infra_network_socket_state_SocketStateListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UnregisterFromSocketState_Ljava_lang_String_Lcom_liveperson_infra_network_socket_state_SocketStateListener_);
			return cb_unregisterFromSocketState_Ljava_lang_String_Lcom_liveperson_infra_network_socket_state_SocketStateListener_;
		}

		static void n_UnregisterFromSocketState_Ljava_lang_String_Lcom_liveperson_infra_network_socket_state_SocketStateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Network.Socket.SocketManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Network.Socket.State.ISocketStateListener p1 = (global::Com.Liveperson.Infra.Network.Socket.State.ISocketStateListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.State.ISocketStateListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterFromSocketState (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_unregisterFromSocketState_Ljava_lang_String_Lcom_liveperson_infra_network_socket_state_SocketStateListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketManager']/method[@name='unregisterFromSocketState' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.network.socket.state.SocketStateListener']]"
		[Register ("unregisterFromSocketState", "(Ljava/lang/String;Lcom/liveperson/infra/network/socket/state/SocketStateListener;)V", "GetUnregisterFromSocketState_Ljava_lang_String_Lcom_liveperson_infra_network_socket_state_SocketStateListener_Handler")]
		public virtual unsafe void UnregisterFromSocketState (string p0, global::Com.Liveperson.Infra.Network.Socket.State.ISocketStateListener p1)
		{
			if (id_unregisterFromSocketState_Ljava_lang_String_Lcom_liveperson_infra_network_socket_state_SocketStateListener_ == IntPtr.Zero)
				id_unregisterFromSocketState_Ljava_lang_String_Lcom_liveperson_infra_network_socket_state_SocketStateListener_ = JNIEnv.GetMethodID (class_ref, "unregisterFromSocketState", "(Ljava/lang/String;Lcom/liveperson/infra/network/socket/state/SocketStateListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterFromSocketState_Ljava_lang_String_Lcom_liveperson_infra_network_socket_state_SocketStateListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregisterFromSocketState", "(Ljava/lang/String;Lcom/liveperson/infra/network/socket/state/SocketStateListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
