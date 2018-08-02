using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Network.Socket {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.network.socket']/interface[@name='ISocketWrapper']"
	[Register ("com/liveperson/infra/network/socket/ISocketWrapper", "", "Com.Liveperson.Infra.Network.Socket.ISocketWrapperInvoker")]
	public partial interface ISocketWrapper : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/interface[@name='ISocketWrapper']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.model.SocketConnectionParams']]"
		[Register ("connect", "(Lcom/liveperson/infra/model/SocketConnectionParams;)V", "GetConnect_Lcom_liveperson_infra_model_SocketConnectionParams_Handler:Com.Liveperson.Infra.Network.Socket.ISocketWrapperInvoker, LP_Binding1_JustLP")]
		void Connect (global::Com.Liveperson.Infra.Model.SocketConnectionParams p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/interface[@name='ISocketWrapper']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler:Com.Liveperson.Infra.Network.Socket.ISocketWrapperInvoker, LP_Binding1_JustLP")]
		void Disconnect ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/interface[@name='ISocketWrapper']/method[@name='send' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("send", "(Ljava/lang/String;)V", "GetSend_Ljava_lang_String_Handler:Com.Liveperson.Infra.Network.Socket.ISocketWrapperInvoker, LP_Binding1_JustLP")]
		void Send (string p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/network/socket/ISocketWrapper", DoNotGenerateAcw=true)]
	internal class ISocketWrapperInvoker : global::Java.Lang.Object, ISocketWrapper {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/network/socket/ISocketWrapper");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISocketWrapperInvoker); }
		}

		IntPtr class_ref;

		public static ISocketWrapper GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISocketWrapper> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.network.socket.ISocketWrapper"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISocketWrapperInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Liveperson.Infra.Network.Socket.ISocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.ISocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Model.SocketConnectionParams p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.SocketConnectionParams> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0);
		}
#pragma warning restore 0169

		IntPtr id_connect_Lcom_liveperson_infra_model_SocketConnectionParams_;
		public unsafe void Connect (global::Com.Liveperson.Infra.Model.SocketConnectionParams p0)
		{
			if (id_connect_Lcom_liveperson_infra_model_SocketConnectionParams_ == IntPtr.Zero)
				id_connect_Lcom_liveperson_infra_model_SocketConnectionParams_ = JNIEnv.GetMethodID (class_ref, "connect", "(Lcom/liveperson/infra/model/SocketConnectionParams;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect_Lcom_liveperson_infra_model_SocketConnectionParams_, __args);
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
			global::Com.Liveperson.Infra.Network.Socket.ISocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.ISocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		IntPtr id_disconnect;
		public unsafe void Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnect);
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
			global::Com.Liveperson.Infra.Network.Socket.ISocketWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.ISocketWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0);
		}
#pragma warning restore 0169

		IntPtr id_send_Ljava_lang_String_;
		public unsafe void Send (string p0)
		{
			if (id_send_Ljava_lang_String_ == IntPtr.Zero)
				id_send_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "send", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_send_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
