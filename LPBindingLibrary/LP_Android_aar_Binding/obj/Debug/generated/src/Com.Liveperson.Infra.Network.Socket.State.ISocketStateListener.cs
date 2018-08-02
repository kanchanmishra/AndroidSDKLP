using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Network.Socket.State {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.network.socket.state']/interface[@name='SocketStateListener']"
	[Register ("com/liveperson/infra/network/socket/state/SocketStateListener", "", "Com.Liveperson.Infra.Network.Socket.State.ISocketStateListenerInvoker")]
	public partial interface ISocketStateListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket.state']/interface[@name='SocketStateListener']/method[@name='onDisconnected' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onDisconnected", "(Ljava/lang/String;I)V", "GetOnDisconnected_Ljava_lang_String_IHandler:Com.Liveperson.Infra.Network.Socket.State.ISocketStateListenerInvoker, LP_Android_aar_Binding")]
		void OnDisconnected (string p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket.state']/interface[@name='SocketStateListener']/method[@name='onStateChanged' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.network.socket.SocketState']]"
		[Register ("onStateChanged", "(Lcom/liveperson/infra/network/socket/SocketState;)V", "GetOnStateChanged_Lcom_liveperson_infra_network_socket_SocketState_Handler:Com.Liveperson.Infra.Network.Socket.State.ISocketStateListenerInvoker, LP_Android_aar_Binding")]
		void OnStateChanged (global::Com.Liveperson.Infra.Network.Socket.SocketState p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/network/socket/state/SocketStateListener", DoNotGenerateAcw=true)]
	internal class ISocketStateListenerInvoker : global::Java.Lang.Object, ISocketStateListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/network/socket/state/SocketStateListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISocketStateListenerInvoker); }
		}

		IntPtr class_ref;

		public static ISocketStateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISocketStateListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.network.socket.state.SocketStateListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISocketStateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDisconnected_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOnDisconnected_Ljava_lang_String_IHandler ()
		{
			if (cb_onDisconnected_Ljava_lang_String_I == null)
				cb_onDisconnected_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnDisconnected_Ljava_lang_String_I);
			return cb_onDisconnected_Ljava_lang_String_I;
		}

		static void n_OnDisconnected_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Liveperson.Infra.Network.Socket.State.ISocketStateListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.State.ISocketStateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDisconnected (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onDisconnected_Ljava_lang_String_I;
		public unsafe void OnDisconnected (string p0, int p1)
		{
			if (id_onDisconnected_Ljava_lang_String_I == IntPtr.Zero)
				id_onDisconnected_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onDisconnected", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDisconnected_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onStateChanged_Lcom_liveperson_infra_network_socket_SocketState_;
#pragma warning disable 0169
		static Delegate GetOnStateChanged_Lcom_liveperson_infra_network_socket_SocketState_Handler ()
		{
			if (cb_onStateChanged_Lcom_liveperson_infra_network_socket_SocketState_ == null)
				cb_onStateChanged_Lcom_liveperson_infra_network_socket_SocketState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStateChanged_Lcom_liveperson_infra_network_socket_SocketState_);
			return cb_onStateChanged_Lcom_liveperson_infra_network_socket_SocketState_;
		}

		static void n_OnStateChanged_Lcom_liveperson_infra_network_socket_SocketState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Socket.State.ISocketStateListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.State.ISocketStateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Network.Socket.SocketState p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnStateChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onStateChanged_Lcom_liveperson_infra_network_socket_SocketState_;
		public unsafe void OnStateChanged (global::Com.Liveperson.Infra.Network.Socket.SocketState p0)
		{
			if (id_onStateChanged_Lcom_liveperson_infra_network_socket_SocketState_ == IntPtr.Zero)
				id_onStateChanged_Lcom_liveperson_infra_network_socket_SocketState_ = JNIEnv.GetMethodID (class_ref, "onStateChanged", "(Lcom/liveperson/infra/network/socket/SocketState;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStateChanged_Lcom_liveperson_infra_network_socket_SocketState_, __args);
		}

	}

	public partial class DisconnectedEventArgs : global::System.EventArgs {

		public DisconnectedEventArgs (string p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	public partial class StateChangedEventArgs : global::System.EventArgs {

		public StateChangedEventArgs (global::Com.Liveperson.Infra.Network.Socket.SocketState p0)
		{
			this.p0 = p0;
		}

		global::Com.Liveperson.Infra.Network.Socket.SocketState p0;
		public global::Com.Liveperson.Infra.Network.Socket.SocketState P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/liveperson/infra/network/socket/state/SocketStateListenerImplementor")]
	internal sealed partial class ISocketStateListenerImplementor : global::Java.Lang.Object, ISocketStateListener {

		object sender;

		public ISocketStateListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/liveperson/infra/network/socket/state/SocketStateListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<DisconnectedEventArgs> OnDisconnectedHandler;
#pragma warning restore 0649

		public void OnDisconnected (string p0, int p1)
		{
			var __h = OnDisconnectedHandler;
			if (__h != null)
				__h (sender, new DisconnectedEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<StateChangedEventArgs> OnStateChangedHandler;
#pragma warning restore 0649

		public void OnStateChanged (global::Com.Liveperson.Infra.Network.Socket.SocketState p0)
		{
			var __h = OnStateChangedHandler;
			if (__h != null)
				__h (sender, new StateChangedEventArgs (p0));
		}

		internal static bool __IsEmpty (ISocketStateListenerImplementor value)
		{
			return value.OnDisconnectedHandler == null && value.OnStateChangedHandler == null;
		}
	}

}
