using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Network.Socket.Requests {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='QueryMessagesRequest']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/network/socket/requests/QueryMessagesRequest", DoNotGenerateAcw=true)]
	public partial class QueryMessagesRequest : global::Com.Liveperson.Api.Request.BaseAMSSocketRequest {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/network/socket/requests/QueryMessagesRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QueryMessagesRequest); }
		}

		protected QueryMessagesRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='QueryMessagesRequest']/constructor[@name='QueryMessagesRequest' and count(parameter)=5 and parameter[1][@type='com.liveperson.messaging.Messaging'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public unsafe QueryMessagesRequest (global::Com.Liveperson.Messaging.Messaging p0, string p1, string p2, string p3, int p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				if (((object) this).GetType () != typeof (QueryMessagesRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_getConversationId;
#pragma warning disable 0169
		static Delegate GetGetConversationIdHandler ()
		{
			if (cb_getConversationId == null)
				cb_getConversationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConversationId);
			return cb_getConversationId;
		}

		static IntPtr n_GetConversationId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Network.Socket.Requests.QueryMessagesRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.QueryMessagesRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConversationId);
		}
#pragma warning restore 0169

		static IntPtr id_getConversationId;
		public virtual unsafe string ConversationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='QueryMessagesRequest']/method[@name='getConversationId' and count(parameter)=0]"
			[Register ("getConversationId", "()Ljava/lang/String;", "GetGetConversationIdHandler")]
			get {
				if (id_getConversationId == IntPtr.Zero)
					id_getConversationId = JNIEnv.GetMethodID (class_ref, "getConversationId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Liveperson.Messaging.Network.Socket.Requests.QueryMessagesRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.QueryMessagesRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Data);
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		protected override unsafe string Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='QueryMessagesRequest']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/lang/String;", "GetGetDataHandler")]
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Liveperson.Messaging.Network.Socket.Requests.QueryMessagesRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.QueryMessagesRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestName);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestName;
		protected override unsafe string RequestName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='QueryMessagesRequest']/method[@name='getRequestName' and count(parameter)=0]"
			[Register ("getRequestName", "()Ljava/lang/String;", "GetGetRequestNameHandler")]
			get {
				if (id_getRequestName == IntPtr.Zero)
					id_getRequestName = JNIEnv.GetMethodID (class_ref, "getRequestName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
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
			global::Com.Liveperson.Messaging.Network.Socket.Requests.QueryMessagesRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.QueryMessagesRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResponseHandler);
		}
#pragma warning restore 0169

		static IntPtr id_getResponseHandler;
		protected virtual unsafe global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler ResponseHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='QueryMessagesRequest']/method[@name='getResponseHandler' and count(parameter)=0]"
			[Register ("getResponseHandler", "()Lcom/liveperson/infra/network/socket/BaseResponseHandler;", "GetGetResponseHandlerHandler")]
			get {
				if (id_getResponseHandler == IntPtr.Zero)
					id_getResponseHandler = JNIEnv.GetMethodID (class_ref, "getResponseHandler", "()Lcom/liveperson/infra/network/socket/BaseResponseHandler;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseHandler), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseHandler", "()Lcom/liveperson/infra/network/socket/BaseResponseHandler;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setMaxSize_I;
#pragma warning disable 0169
		static Delegate GetSetMaxSize_IHandler ()
		{
			if (cb_setMaxSize_I == null)
				cb_setMaxSize_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetMaxSize_I);
			return cb_setMaxSize_I;
		}

		static IntPtr n_SetMaxSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Messaging.Network.Socket.Requests.QueryMessagesRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.QueryMessagesRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMaxSize (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setMaxSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='QueryMessagesRequest']/method[@name='setMaxSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxSize", "(I)Lcom/liveperson/messaging/network/socket/requests/QueryMessagesRequest;", "GetSetMaxSize_IHandler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Network.Socket.Requests.QueryMessagesRequest SetMaxSize (int p0)
		{
			if (id_setMaxSize_I == IntPtr.Zero)
				id_setMaxSize_I = JNIEnv.GetMethodID (class_ref, "setMaxSize", "(I)Lcom/liveperson/messaging/network/socket/requests/QueryMessagesRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.QueryMessagesRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMaxSize_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.QueryMessagesRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxSize", "(I)Lcom/liveperson/messaging/network/socket/requests/QueryMessagesRequest;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setOlderThanSequenceId_I;
#pragma warning disable 0169
		static Delegate GetSetOlderThanSequenceId_IHandler ()
		{
			if (cb_setOlderThanSequenceId_I == null)
				cb_setOlderThanSequenceId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetOlderThanSequenceId_I);
			return cb_setOlderThanSequenceId_I;
		}

		static IntPtr n_SetOlderThanSequenceId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Messaging.Network.Socket.Requests.QueryMessagesRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.QueryMessagesRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetOlderThanSequenceId (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setOlderThanSequenceId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='QueryMessagesRequest']/method[@name='setOlderThanSequenceId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setOlderThanSequenceId", "(I)Lcom/liveperson/messaging/network/socket/requests/QueryMessagesRequest;", "GetSetOlderThanSequenceId_IHandler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Network.Socket.Requests.QueryMessagesRequest SetOlderThanSequenceId (int p0)
		{
			if (id_setOlderThanSequenceId_I == IntPtr.Zero)
				id_setOlderThanSequenceId_I = JNIEnv.GetMethodID (class_ref, "setOlderThanSequenceId", "(I)Lcom/liveperson/messaging/network/socket/requests/QueryMessagesRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.QueryMessagesRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setOlderThanSequenceId_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.QueryMessagesRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOlderThanSequenceId", "(I)Lcom/liveperson/messaging/network/socket/requests/QueryMessagesRequest;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setResponseCallBack_Lcom_liveperson_messaging_commands_tasks_BaseAmsSocketConnectionCallback_;
#pragma warning disable 0169
		static Delegate GetSetResponseCallBack_Lcom_liveperson_messaging_commands_tasks_BaseAmsSocketConnectionCallback_Handler ()
		{
			if (cb_setResponseCallBack_Lcom_liveperson_messaging_commands_tasks_BaseAmsSocketConnectionCallback_ == null)
				cb_setResponseCallBack_Lcom_liveperson_messaging_commands_tasks_BaseAmsSocketConnectionCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResponseCallBack_Lcom_liveperson_messaging_commands_tasks_BaseAmsSocketConnectionCallback_);
			return cb_setResponseCallBack_Lcom_liveperson_messaging_commands_tasks_BaseAmsSocketConnectionCallback_;
		}

		static void n_SetResponseCallBack_Lcom_liveperson_messaging_commands_tasks_BaseAmsSocketConnectionCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Network.Socket.Requests.QueryMessagesRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.QueryMessagesRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsSocketConnectionCallback p0 = (global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsSocketConnectionCallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsSocketConnectionCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetResponseCallBack (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setResponseCallBack_Lcom_liveperson_messaging_commands_tasks_BaseAmsSocketConnectionCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='QueryMessagesRequest']/method[@name='setResponseCallBack' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.commands.tasks.BaseAmsSocketConnectionCallback']]"
		[Register ("setResponseCallBack", "(Lcom/liveperson/messaging/commands/tasks/BaseAmsSocketConnectionCallback;)V", "GetSetResponseCallBack_Lcom_liveperson_messaging_commands_tasks_BaseAmsSocketConnectionCallback_Handler")]
		public virtual unsafe void SetResponseCallBack (global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsSocketConnectionCallback p0)
		{
			if (id_setResponseCallBack_Lcom_liveperson_messaging_commands_tasks_BaseAmsSocketConnectionCallback_ == IntPtr.Zero)
				id_setResponseCallBack_Lcom_liveperson_messaging_commands_tasks_BaseAmsSocketConnectionCallback_ = JNIEnv.GetMethodID (class_ref, "setResponseCallBack", "(Lcom/liveperson/messaging/commands/tasks/BaseAmsSocketConnectionCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResponseCallBack_Lcom_liveperson_messaging_commands_tasks_BaseAmsSocketConnectionCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResponseCallBack", "(Lcom/liveperson/messaging/commands/tasks/BaseAmsSocketConnectionCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setShouldUpdateUI_Z;
#pragma warning disable 0169
		static Delegate GetSetShouldUpdateUI_ZHandler ()
		{
			if (cb_setShouldUpdateUI_Z == null)
				cb_setShouldUpdateUI_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShouldUpdateUI_Z);
			return cb_setShouldUpdateUI_Z;
		}

		static void n_SetShouldUpdateUI_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Messaging.Network.Socket.Requests.QueryMessagesRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.QueryMessagesRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShouldUpdateUI (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShouldUpdateUI_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='QueryMessagesRequest']/method[@name='setShouldUpdateUI' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShouldUpdateUI", "(Z)V", "GetSetShouldUpdateUI_ZHandler")]
		public virtual unsafe void SetShouldUpdateUI (bool p0)
		{
			if (id_setShouldUpdateUI_Z == IntPtr.Zero)
				id_setShouldUpdateUI_Z = JNIEnv.GetMethodID (class_ref, "setShouldUpdateUI", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShouldUpdateUI_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShouldUpdateUI", "(Z)V"), __args);
			} finally {
			}
		}

	}
}
