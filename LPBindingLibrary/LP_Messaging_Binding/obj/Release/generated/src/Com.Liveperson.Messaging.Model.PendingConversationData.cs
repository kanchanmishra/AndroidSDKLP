using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='PendingConversationData']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/model/PendingConversationData", DoNotGenerateAcw=true)]
	public partial class PendingConversationData : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/model/PendingConversationData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PendingConversationData); }
		}

		protected PendingConversationData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='PendingConversationData']/constructor[@name='PendingConversationData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PendingConversationData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PendingConversationData)) {
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

		static Delegate cb_getPendingMessages;
#pragma warning disable 0169
		static Delegate GetGetPendingMessagesHandler ()
		{
			if (cb_getPendingMessages == null)
				cb_getPendingMessages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPendingMessages);
			return cb_getPendingMessages;
		}

		static IntPtr n_GetPendingMessages (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.PendingConversationData __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.PendingConversationData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest>.ToLocalJniHandle (__this.PendingMessages);
		}
#pragma warning restore 0169

		static IntPtr id_getPendingMessages;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest> PendingMessages {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='PendingConversationData']/method[@name='getPendingMessages' and count(parameter)=0]"
			[Register ("getPendingMessages", "()Ljava/util/ArrayList;", "GetGetPendingMessagesHandler")]
			get {
				if (id_getPendingMessages == IntPtr.Zero)
					id_getPendingMessages = JNIEnv.GetMethodID (class_ref, "getPendingMessages", "()Ljava/util/ArrayList;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPendingMessages), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPendingMessages", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addToPendingRequests_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_;
#pragma warning disable 0169
		static Delegate GetAddToPendingRequests_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_Handler ()
		{
			if (cb_addToPendingRequests_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_ == null)
				cb_addToPendingRequests_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddToPendingRequests_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_);
			return cb_addToPendingRequests_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_;
		}

		static void n_AddToPendingRequests_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.PendingConversationData __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.PendingConversationData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddToPendingRequests (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addToPendingRequests_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='PendingConversationData']/method[@name='addToPendingRequests' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.network.socket.requests.SendMessageRequest']]"
		[Register ("addToPendingRequests", "(Lcom/liveperson/messaging/network/socket/requests/SendMessageRequest;)V", "GetAddToPendingRequests_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_Handler")]
		public virtual unsafe void AddToPendingRequests (global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest p0)
		{
			if (id_addToPendingRequests_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_ == IntPtr.Zero)
				id_addToPendingRequests_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_ = JNIEnv.GetMethodID (class_ref, "addToPendingRequests", "(Lcom/liveperson/messaging/network/socket/requests/SendMessageRequest;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addToPendingRequests_Lcom_liveperson_messaging_network_socket_requests_SendMessageRequest_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addToPendingRequests", "(Lcom/liveperson/messaging/network/socket/requests/SendMessageRequest;)V"), __args);
			} finally {
			}
		}

	}
}
