using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Network.Socket.State {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.network.socket.state']/class[@name='SocketStateAdapter']"
	[global::Android.Runtime.Register ("com/liveperson/infra/network/socket/state/SocketStateAdapter", DoNotGenerateAcw=true)]
	public partial class SocketStateAdapter : global::Java.Lang.Object, global::Com.Liveperson.Infra.Network.Socket.State.ISocketStateListener {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/network/socket/state/SocketStateAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocketStateAdapter); }
		}

		protected SocketStateAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.network.socket.state']/class[@name='SocketStateAdapter']/constructor[@name='SocketStateAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SocketStateAdapter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SocketStateAdapter)) {
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
			global::Com.Liveperson.Infra.Network.Socket.State.SocketStateAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.State.SocketStateAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDisconnected (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onDisconnected_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket.state']/class[@name='SocketStateAdapter']/method[@name='onDisconnected' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onDisconnected", "(Ljava/lang/String;I)V", "GetOnDisconnected_Ljava_lang_String_IHandler")]
		public virtual unsafe void OnDisconnected (string p0, int p1)
		{
			if (id_onDisconnected_Ljava_lang_String_I == IntPtr.Zero)
				id_onDisconnected_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onDisconnected", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDisconnected_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDisconnected", "(Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Liveperson.Infra.Network.Socket.State.SocketStateAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.State.SocketStateAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Network.Socket.SocketState p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnStateChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onStateChanged_Lcom_liveperson_infra_network_socket_SocketState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket.state']/class[@name='SocketStateAdapter']/method[@name='onStateChanged' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.network.socket.SocketState']]"
		[Register ("onStateChanged", "(Lcom/liveperson/infra/network/socket/SocketState;)V", "GetOnStateChanged_Lcom_liveperson_infra_network_socket_SocketState_Handler")]
		public virtual unsafe void OnStateChanged (global::Com.Liveperson.Infra.Network.Socket.SocketState p0)
		{
			if (id_onStateChanged_Lcom_liveperson_infra_network_socket_SocketState_ == IntPtr.Zero)
				id_onStateChanged_Lcom_liveperson_infra_network_socket_SocketState_ = JNIEnv.GetMethodID (class_ref, "onStateChanged", "(Lcom/liveperson/infra/network/socket/SocketState;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStateChanged_Lcom_liveperson_infra_network_socket_SocketState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStateChanged", "(Lcom/liveperson/infra/network/socket/SocketState;)V"), __args);
			} finally {
			}
		}

	}
}
