using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Network.Socket {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketWrapperOK']"
	[global::Android.Runtime.Register ("com/liveperson/infra/network/socket/SocketWrapperOK", DoNotGenerateAcw=true)]
	public partial class SocketWrapperOK : global::Java.Lang.Object, global::Com.Liveperson.Infra.Network.Socket.ISocketWrapper {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketWrapperOK.WebSocketCallbacks']"
		[global::Android.Runtime.Register ("com/liveperson/infra/network/socket/SocketWrapperOK$WebSocketCallbacks", DoNotGenerateAcw=true)]
		public partial class WebSocketCallbacks : global::Square.OkHttp3.WebSocketListener {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/network/socket/SocketWrapperOK$WebSocketCallbacks", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (WebSocketCallbacks); }
			}

			protected WebSocketCallbacks (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/network/socket/SocketWrapperOK", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocketWrapperOK); }
		}

		protected SocketWrapperOK (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_infra_network_socket_ISocketCallbacks_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketWrapperOK']/constructor[@name='SocketWrapperOK' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.network.socket.ISocketCallbacks']]"
		[Register (".ctor", "(Lcom/liveperson/infra/network/socket/ISocketCallbacks;)V", "")]
		public unsafe SocketWrapperOK (global::Com.Liveperson.Infra.Network.Socket.ISocketCallbacks p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (SocketWrapperOK)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/infra/network/socket/ISocketCallbacks;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/infra/network/socket/ISocketCallbacks;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_infra_network_socket_ISocketCallbacks_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_infra_network_socket_ISocketCallbacks_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/network/socket/ISocketCallbacks;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_network_socket_ISocketCallbacks_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_network_socket_ISocketCallbacks_, __args);
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
			global::Com.Liveperson.Infra.Network.Socket.SocketWrapperOK __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketWrapperOK> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Model.SocketConnectionParams p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.SocketConnectionParams> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0);
		}
#pragma warning restore 0169

		static IntPtr id_connect_Lcom_liveperson_infra_model_SocketConnectionParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketWrapperOK']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.model.SocketConnectionParams']]"
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

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disconnect);
			return cb_disconnect;
		}

		static void n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Socket.SocketWrapperOK __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketWrapperOK> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		static IntPtr id_disconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketWrapperOK']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler")]
		public virtual unsafe void Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnect);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnect", "()V"));
			} finally {
			}
		}

		static Delegate cb_send_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSend_Ljava_lang_String_Handler ()
		{
			if (cb_send_Ljava_lang_String_ == null)
				cb_send_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Send_Ljava_lang_String_);
			return cb_send_Ljava_lang_String_;
		}

		static void n_Send_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Socket.SocketWrapperOK __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketWrapperOK> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0);
		}
#pragma warning restore 0169

		static IntPtr id_send_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketWrapperOK']/method[@name='send' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("send", "(Ljava/lang/String;)V", "GetSend_Ljava_lang_String_Handler")]
		public virtual unsafe void Send (string p0)
		{
			if (id_send_Ljava_lang_String_ == IntPtr.Zero)
				id_send_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "send", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_send_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
