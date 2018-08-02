using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Network.Socket {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketStateManager']"
	[global::Android.Runtime.Register ("com/liveperson/infra/network/socket/SocketStateManager", DoNotGenerateAcw=true)]
	public partial class SocketStateManager : global::Java.Lang.Object, global::Com.Liveperson.Infra.IDisposable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/network/socket/SocketStateManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocketStateManager); }
		}

		protected SocketStateManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketStateManager']/constructor[@name='SocketStateManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SocketStateManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SocketStateManager)) {
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

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetState);
			return cb_getState;
		}

		static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Socket.SocketStateManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketStateManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.State);
		}
#pragma warning restore 0169

		static IntPtr id_getState;
		public virtual unsafe global::Com.Liveperson.Infra.Network.Socket.SocketState State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketStateManager']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Lcom/liveperson/infra/network/socket/SocketState;", "GetGetStateHandler")]
			get {
				if (id_getState == IntPtr.Zero)
					id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()Lcom/liveperson/infra/network/socket/SocketState;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getState), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketState> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getState", "()Lcom/liveperson/infra/network/socket/SocketState;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Socket.SocketStateManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketStateManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketStateManager']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispose);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispose", "()V"));
			} finally {
			}
		}

		static Delegate cb_register_Lcom_liveperson_infra_network_socket_state_SocketStateListener_;
#pragma warning disable 0169
		static Delegate GetRegister_Lcom_liveperson_infra_network_socket_state_SocketStateListener_Handler ()
		{
			if (cb_register_Lcom_liveperson_infra_network_socket_state_SocketStateListener_ == null)
				cb_register_Lcom_liveperson_infra_network_socket_state_SocketStateListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Register_Lcom_liveperson_infra_network_socket_state_SocketStateListener_);
			return cb_register_Lcom_liveperson_infra_network_socket_state_SocketStateListener_;
		}

		static void n_Register_Lcom_liveperson_infra_network_socket_state_SocketStateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Socket.SocketStateManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketStateManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Network.Socket.State.ISocketStateListener p0 = (global::Com.Liveperson.Infra.Network.Socket.State.ISocketStateListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.State.ISocketStateListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Register (p0);
		}
#pragma warning restore 0169

		static IntPtr id_register_Lcom_liveperson_infra_network_socket_state_SocketStateListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketStateManager']/method[@name='register' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.network.socket.state.SocketStateListener']]"
		[Register ("register", "(Lcom/liveperson/infra/network/socket/state/SocketStateListener;)V", "GetRegister_Lcom_liveperson_infra_network_socket_state_SocketStateListener_Handler")]
		public virtual unsafe void Register (global::Com.Liveperson.Infra.Network.Socket.State.ISocketStateListener p0)
		{
			if (id_register_Lcom_liveperson_infra_network_socket_state_SocketStateListener_ == IntPtr.Zero)
				id_register_Lcom_liveperson_infra_network_socket_state_SocketStateListener_ = JNIEnv.GetMethodID (class_ref, "register", "(Lcom/liveperson/infra/network/socket/state/SocketStateListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register_Lcom_liveperson_infra_network_socket_state_SocketStateListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "register", "(Lcom/liveperson/infra/network/socket/state/SocketStateListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_unregister_Lcom_liveperson_infra_network_socket_state_SocketStateListener_;
#pragma warning disable 0169
		static Delegate GetUnregister_Lcom_liveperson_infra_network_socket_state_SocketStateListener_Handler ()
		{
			if (cb_unregister_Lcom_liveperson_infra_network_socket_state_SocketStateListener_ == null)
				cb_unregister_Lcom_liveperson_infra_network_socket_state_SocketStateListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Unregister_Lcom_liveperson_infra_network_socket_state_SocketStateListener_);
			return cb_unregister_Lcom_liveperson_infra_network_socket_state_SocketStateListener_;
		}

		static void n_Unregister_Lcom_liveperson_infra_network_socket_state_SocketStateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Socket.SocketStateManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketStateManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Network.Socket.State.ISocketStateListener p0 = (global::Com.Liveperson.Infra.Network.Socket.State.ISocketStateListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.State.ISocketStateListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Unregister (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unregister_Lcom_liveperson_infra_network_socket_state_SocketStateListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketStateManager']/method[@name='unregister' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.network.socket.state.SocketStateListener']]"
		[Register ("unregister", "(Lcom/liveperson/infra/network/socket/state/SocketStateListener;)V", "GetUnregister_Lcom_liveperson_infra_network_socket_state_SocketStateListener_Handler")]
		public virtual unsafe void Unregister (global::Com.Liveperson.Infra.Network.Socket.State.ISocketStateListener p0)
		{
			if (id_unregister_Lcom_liveperson_infra_network_socket_state_SocketStateListener_ == IntPtr.Zero)
				id_unregister_Lcom_liveperson_infra_network_socket_state_SocketStateListener_ = JNIEnv.GetMethodID (class_ref, "unregister", "(Lcom/liveperson/infra/network/socket/state/SocketStateListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregister_Lcom_liveperson_infra_network_socket_state_SocketStateListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregister", "(Lcom/liveperson/infra/network/socket/state/SocketStateListener;)V"), __args);
			} finally {
			}
		}

	}
}
