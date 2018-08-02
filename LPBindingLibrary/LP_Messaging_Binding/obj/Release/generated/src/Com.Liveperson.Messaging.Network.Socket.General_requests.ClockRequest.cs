using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Network.Socket.General_requests {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.network.socket.general_requests']/class[@name='ClockRequest']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/network/socket/general_requests/ClockRequest", DoNotGenerateAcw=true)]
	public partial class ClockRequest : global::Com.Liveperson.Api.Request.BaseAMSSocketRequest {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.network.socket.general_requests']/class[@name='ClockRequest.ClockResponseHandler']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/network/socket/general_requests/ClockRequest$ClockResponseHandler", DoNotGenerateAcw=true)]
		public partial class ClockResponseHandler : global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/network/socket/general_requests/ClockRequest$ClockResponseHandler", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ClockResponseHandler); }
			}

			protected ClockResponseHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_messaging_network_socket_general_requests_ClockRequest_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.network.socket.general_requests']/class[@name='ClockRequest.ClockResponseHandler']/constructor[@name='ClockRequest.ClockResponseHandler' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.network.socket.general_requests.ClockRequest']]"
			[Register (".ctor", "(Lcom/liveperson/messaging/network/socket/general_requests/ClockRequest;)V", "")]
			public unsafe ClockResponseHandler (global::Com.Liveperson.Messaging.Network.Socket.General_requests.ClockRequest __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (ClockResponseHandler)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_messaging_network_socket_general_requests_ClockRequest_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_messaging_network_socket_general_requests_ClockRequest_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/network/socket/general_requests/ClockRequest;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_network_socket_general_requests_ClockRequest_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_network_socket_general_requests_ClockRequest_, __args);
				} finally {
				}
			}

			static Delegate cb_getAPIResponseType;
#pragma warning disable 0169
			static Delegate GetGetAPIResponseTypeHandler ()
			{
				if (cb_getAPIResponseType == null)
					cb_getAPIResponseType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAPIResponseType);
				return cb_getAPIResponseType;
			}

			static IntPtr n_GetAPIResponseType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Messaging.Network.Socket.General_requests.ClockRequest.ClockResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.General_requests.ClockRequest.ClockResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.APIResponseType);
			}
#pragma warning restore 0169

			static IntPtr id_getAPIResponseType;
			public override unsafe string APIResponseType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.general_requests']/class[@name='ClockRequest.ClockResponseHandler']/method[@name='getAPIResponseType' and count(parameter)=0]"
				[Register ("getAPIResponseType", "()Ljava/lang/String;", "GetGetAPIResponseTypeHandler")]
				get {
					if (id_getAPIResponseType == IntPtr.Zero)
						id_getAPIResponseType = JNIEnv.GetMethodID (class_ref, "getAPIResponseType", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAPIResponseType), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAPIResponseType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/network/socket/general_requests/ClockRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClockRequest); }
		}

		protected ClockRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_controller_ConnectionsController_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.network.socket.general_requests']/class[@name='ClockRequest']/constructor[@name='ClockRequest' and count(parameter)=3 and parameter[1][@type='com.liveperson.messaging.controller.ConnectionsController'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/controller/ConnectionsController;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe ClockRequest (global::Com.Liveperson.Messaging.Controller.ConnectionsController p0, string p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (ClockRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/controller/ConnectionsController;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/controller/ConnectionsController;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_controller_ConnectionsController_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_controller_ConnectionsController_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/controller/ConnectionsController;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_controller_ConnectionsController_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_controller_ConnectionsController_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
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
			global::Com.Liveperson.Messaging.Network.Socket.General_requests.ClockRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.General_requests.ClockRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Data);
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		protected override unsafe string Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.general_requests']/class[@name='ClockRequest']/method[@name='getData' and count(parameter)=0]"
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
			global::Com.Liveperson.Messaging.Network.Socket.General_requests.ClockRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.General_requests.ClockRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestName);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestName;
		protected override unsafe string RequestName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.general_requests']/class[@name='ClockRequest']/method[@name='getRequestName' and count(parameter)=0]"
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
			global::Com.Liveperson.Messaging.Network.Socket.General_requests.ClockRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.General_requests.ClockRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResponseHandler);
		}
#pragma warning restore 0169

		static IntPtr id_getResponseHandler;
		protected virtual unsafe global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler ResponseHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.general_requests']/class[@name='ClockRequest']/method[@name='getResponseHandler' and count(parameter)=0]"
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

	}
}
