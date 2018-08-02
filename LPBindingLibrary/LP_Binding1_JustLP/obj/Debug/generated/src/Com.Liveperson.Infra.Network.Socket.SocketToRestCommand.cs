using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Network.Socket {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketToRestCommand']"
	[global::Android.Runtime.Register ("com/liveperson/infra/network/socket/SocketToRestCommand", DoNotGenerateAcw=true)]
	public partial class SocketToRestCommand : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/network/socket/SocketToRestCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocketToRestCommand); }
		}

		protected SocketToRestCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketToRestCommand']/constructor[@name='SocketToRestCommand' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SocketToRestCommand ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SocketToRestCommand)) {
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

		static Delegate cb_getData_Lcom_liveperson_infra_network_socket_BaseSocketRequest_;
#pragma warning disable 0169
		static Delegate GetGetData_Lcom_liveperson_infra_network_socket_BaseSocketRequest_Handler ()
		{
			if (cb_getData_Lcom_liveperson_infra_network_socket_BaseSocketRequest_ == null)
				cb_getData_Lcom_liveperson_infra_network_socket_BaseSocketRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetData_Lcom_liveperson_infra_network_socket_BaseSocketRequest_);
			return cb_getData_Lcom_liveperson_infra_network_socket_BaseSocketRequest_;
		}

		static IntPtr n_GetData_Lcom_liveperson_infra_network_socket_BaseSocketRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Socket.SocketToRestCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketToRestCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetData (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getData_Lcom_liveperson_infra_network_socket_BaseSocketRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketToRestCommand']/method[@name='getData' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.network.socket.BaseSocketRequest']]"
		[Register ("getData", "(Lcom/liveperson/infra/network/socket/BaseSocketRequest;)Ljava/lang/String;", "GetGetData_Lcom_liveperson_infra_network_socket_BaseSocketRequest_Handler")]
		protected virtual unsafe string GetData (global::Com.Liveperson.Infra.Network.Socket.BaseSocketRequest p0)
		{
			if (id_getData_Lcom_liveperson_infra_network_socket_BaseSocketRequest_ == IntPtr.Zero)
				id_getData_Lcom_liveperson_infra_network_socket_BaseSocketRequest_ = JNIEnv.GetMethodID (class_ref, "getData", "(Lcom/liveperson/infra/network/socket/BaseSocketRequest;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData_Lcom_liveperson_infra_network_socket_BaseSocketRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "(Lcom/liveperson/infra/network/socket/BaseSocketRequest;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
