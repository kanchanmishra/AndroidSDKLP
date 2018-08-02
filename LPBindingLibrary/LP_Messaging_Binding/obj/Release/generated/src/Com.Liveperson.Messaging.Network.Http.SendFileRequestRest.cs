using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Network.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='SendFileRequestRest']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/network/http/SendFileRequestRest", DoNotGenerateAcw=true)]
	public partial class SendFileRequestRest : global::Com.Liveperson.Infra.Network.Socket.SocketToRestCommand, global::Com.Liveperson.Infra.ICommand {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/network/http/SendFileRequestRest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SendFileRequestRest); }
		}

		protected SendFileRequestRest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_network_http_RestRequestParams_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='SendFileRequestRest']/constructor[@name='SendFileRequestRest' and count(parameter)=2 and parameter[1][@type='com.liveperson.messaging.network.http.RestRequestParams'] and parameter[2][@type='com.liveperson.messaging.network.socket.requests.SendMessageRequest']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/network/http/RestRequestParams;Lcom/liveperson/messaging/network/socket/requests/SendMessageRequest;)V", "")]
		public unsafe SendFileRequestRest (global::Com.Liveperson.Messaging.Network.Http.RestRequestParams p0, global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (SendFileRequestRest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/network/http/RestRequestParams;Lcom/liveperson/messaging/network/socket/requests/SendMessageRequest;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/network/http/RestRequestParams;Lcom/liveperson/messaging/network/socket/requests/SendMessageRequest;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_network_http_RestRequestParams_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_network_http_RestRequestParams_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/network/http/RestRequestParams;Lcom/liveperson/messaging/network/socket/requests/SendMessageRequest;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_network_http_RestRequestParams_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_network_http_RestRequestParams_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_, __args);
			} finally {
			}
		}

		static Delegate cb_execute;
#pragma warning disable 0169
		static Delegate GetExecuteHandler ()
		{
			if (cb_execute == null)
				cb_execute = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Execute);
			return cb_execute;
		}

		static void n_Execute (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Network.Http.SendFileRequestRest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.SendFileRequestRest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		static IntPtr id_execute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='SendFileRequestRest']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()V", "GetExecuteHandler")]
		public virtual unsafe void Execute ()
		{
			if (id_execute == IntPtr.Zero)
				id_execute = JNIEnv.GetMethodID (class_ref, "execute", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_execute);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "()V"));
			} finally {
			}
		}

	}
}
