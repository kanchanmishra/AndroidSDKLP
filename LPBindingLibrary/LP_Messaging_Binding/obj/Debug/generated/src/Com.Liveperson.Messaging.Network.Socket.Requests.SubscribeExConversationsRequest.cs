using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Network.Socket.Requests {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SubscribeExConversationsRequest']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/network/socket/requests/SubscribeExConversationsRequest", DoNotGenerateAcw=true)]
	public partial class SubscribeExConversationsRequest : global::Com.Liveperson.Api.Request.BaseAMSSocketRequest {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SubscribeExConversationsRequest']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/network/socket/requests/SubscribeExConversationsRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SubscribeExConversationsRequest); }
		}

		protected SubscribeExConversationsRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_controller_ConnectionsController_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SubscribeExConversationsRequest']/constructor[@name='SubscribeExConversationsRequest' and count(parameter)=5 and parameter[1][@type='com.liveperson.messaging.controller.ConnectionsController'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/controller/ConnectionsController;JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe SubscribeExConversationsRequest (global::Com.Liveperson.Messaging.Controller.ConnectionsController p0, long p1, string p2, string p3, string p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				if (((object) this).GetType () != typeof (SubscribeExConversationsRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/controller/ConnectionsController;JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/controller/ConnectionsController;JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_controller_ConnectionsController_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_controller_ConnectionsController_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/controller/ConnectionsController;JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_controller_ConnectionsController_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_controller_ConnectionsController_JLjava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_ctor_Lcom_liveperson_messaging_controller_ConnectionsController_JLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SubscribeExConversationsRequest']/constructor[@name='SubscribeExConversationsRequest' and count(parameter)=5 and parameter[1][@type='com.liveperson.messaging.controller.ConnectionsController'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String[]']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/controller/ConnectionsController;JLjava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V", "")]
		public unsafe SubscribeExConversationsRequest (global::Com.Liveperson.Messaging.Controller.ConnectionsController p0, long p1, string p2, string p3, string[] p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				if (((object) this).GetType () != typeof (SubscribeExConversationsRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/controller/ConnectionsController;JLjava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/controller/ConnectionsController;JLjava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_controller_ConnectionsController_JLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_controller_ConnectionsController_JLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/controller/ConnectionsController;JLjava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_controller_ConnectionsController_JLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_controller_ConnectionsController_JLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
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
			global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Data);
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		protected override unsafe string Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SubscribeExConversationsRequest']/method[@name='getData' and count(parameter)=0]"
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
			global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestName);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestName;
		protected override unsafe string RequestName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SubscribeExConversationsRequest']/method[@name='getRequestName' and count(parameter)=0]"
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
			global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResponseHandler);
		}
#pragma warning restore 0169

		static IntPtr id_getResponseHandler;
		protected virtual unsafe global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler ResponseHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SubscribeExConversationsRequest']/method[@name='getResponseHandler' and count(parameter)=0]"
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

		static Delegate cb_setAgentIds_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAgentIds_arrayLjava_lang_String_Handler ()
		{
			if (cb_setAgentIds_arrayLjava_lang_String_ == null)
				cb_setAgentIds_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAgentIds_arrayLjava_lang_String_);
			return cb_setAgentIds_arrayLjava_lang_String_;
		}

		static IntPtr n_SetAgentIds_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAgentIds (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setAgentIds_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SubscribeExConversationsRequest']/method[@name='setAgentIds' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setAgentIds", "([Ljava/lang/String;)Lcom/liveperson/messaging/network/socket/requests/SubscribeExConversationsRequest;", "GetSetAgentIds_arrayLjava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest SetAgentIds (string[] p0)
		{
			if (id_setAgentIds_arrayLjava_lang_String_ == IntPtr.Zero)
				id_setAgentIds_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAgentIds", "([Ljava/lang/String;)Lcom/liveperson/messaging/network/socket/requests/SubscribeExConversationsRequest;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAgentIds_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAgentIds", "([Ljava/lang/String;)Lcom/liveperson/messaging/network/socket/requests/SubscribeExConversationsRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setConvState_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetConvState_arrayLjava_lang_String_Handler ()
		{
			if (cb_setConvState_arrayLjava_lang_String_ == null)
				cb_setConvState_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetConvState_arrayLjava_lang_String_);
			return cb_setConvState_arrayLjava_lang_String_;
		}

		static IntPtr n_SetConvState_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetConvState (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setConvState_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SubscribeExConversationsRequest']/method[@name='setConvState' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setConvState", "([Ljava/lang/String;)Lcom/liveperson/messaging/network/socket/requests/SubscribeExConversationsRequest;", "GetSetConvState_arrayLjava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest SetConvState (string[] p0)
		{
			if (id_setConvState_arrayLjava_lang_String_ == IntPtr.Zero)
				id_setConvState_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setConvState", "([Ljava/lang/String;)Lcom/liveperson/messaging/network/socket/requests/SubscribeExConversationsRequest;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setConvState_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConvState", "([Ljava/lang/String;)Lcom/liveperson/messaging/network/socket/requests/SubscribeExConversationsRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setMaxETTR_I;
#pragma warning disable 0169
		static Delegate GetSetMaxETTR_IHandler ()
		{
			if (cb_setMaxETTR_I == null)
				cb_setMaxETTR_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetMaxETTR_I);
			return cb_setMaxETTR_I;
		}

		static IntPtr n_SetMaxETTR_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMaxETTR (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setMaxETTR_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SubscribeExConversationsRequest']/method[@name='setMaxETTR' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxETTR", "(I)Lcom/liveperson/messaging/network/socket/requests/SubscribeExConversationsRequest;", "GetSetMaxETTR_IHandler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest SetMaxETTR (int p0)
		{
			if (id_setMaxETTR_I == IntPtr.Zero)
				id_setMaxETTR_I = JNIEnv.GetMethodID (class_ref, "setMaxETTR", "(I)Lcom/liveperson/messaging/network/socket/requests/SubscribeExConversationsRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMaxETTR_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxETTR", "(I)Lcom/liveperson/messaging/network/socket/requests/SubscribeExConversationsRequest;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMaxLastUpdatedTime_J;
#pragma warning disable 0169
		static Delegate GetSetMaxLastUpdatedTime_JHandler ()
		{
			if (cb_setMaxLastUpdatedTime_J == null)
				cb_setMaxLastUpdatedTime_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetMaxLastUpdatedTime_J);
			return cb_setMaxLastUpdatedTime_J;
		}

		static IntPtr n_SetMaxLastUpdatedTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMaxLastUpdatedTime (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setMaxLastUpdatedTime_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SubscribeExConversationsRequest']/method[@name='setMaxLastUpdatedTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setMaxLastUpdatedTime", "(J)Lcom/liveperson/messaging/network/socket/requests/SubscribeExConversationsRequest;", "GetSetMaxLastUpdatedTime_JHandler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest SetMaxLastUpdatedTime (long p0)
		{
			if (id_setMaxLastUpdatedTime_J == IntPtr.Zero)
				id_setMaxLastUpdatedTime_J = JNIEnv.GetMethodID (class_ref, "setMaxLastUpdatedTime", "(J)Lcom/liveperson/messaging/network/socket/requests/SubscribeExConversationsRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMaxLastUpdatedTime_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeExConversationsRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxLastUpdatedTime", "(J)Lcom/liveperson/messaging/network/socket/requests/SubscribeExConversationsRequest;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
