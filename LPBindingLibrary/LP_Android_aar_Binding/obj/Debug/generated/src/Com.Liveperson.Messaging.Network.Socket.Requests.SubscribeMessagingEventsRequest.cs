using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Network.Socket.Requests {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SubscribeMessagingEventsRequest']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/network/socket/requests/SubscribeMessagingEventsRequest", DoNotGenerateAcw=true)]
	public sealed partial class SubscribeMessagingEventsRequest : global::Com.Liveperson.Api.Request.BaseAMSSocketRequest {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SubscribeMessagingEventsRequest.SubscribeMessagingEventsResponseHandler']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/network/socket/requests/SubscribeMessagingEventsRequest$SubscribeMessagingEventsResponseHandler", DoNotGenerateAcw=true)]
		public sealed partial class SubscribeMessagingEventsResponseHandler : global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/network/socket/requests/SubscribeMessagingEventsRequest$SubscribeMessagingEventsResponseHandler", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SubscribeMessagingEventsResponseHandler); }
			}

			internal SubscribeMessagingEventsResponseHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_messaging_network_socket_requests_SubscribeMessagingEventsRequest_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SubscribeMessagingEventsRequest.SubscribeMessagingEventsResponseHandler']/constructor[@name='SubscribeMessagingEventsRequest.SubscribeMessagingEventsResponseHandler' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.network.socket.requests.SubscribeMessagingEventsRequest']]"
			[Register (".ctor", "(Lcom/liveperson/messaging/network/socket/requests/SubscribeMessagingEventsRequest;)V", "")]
			public unsafe SubscribeMessagingEventsResponseHandler (global::Com.Liveperson.Messaging.Network.Socket.Requests.SubscribeMessagingEventsRequest __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (SubscribeMessagingEventsResponseHandler)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_messaging_network_socket_requests_SubscribeMessagingEventsRequest_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_messaging_network_socket_requests_SubscribeMessagingEventsRequest_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/network/socket/requests/SubscribeMessagingEventsRequest;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_network_socket_requests_SubscribeMessagingEventsRequest_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_network_socket_requests_SubscribeMessagingEventsRequest_, __args);
				} finally {
				}
			}

			static IntPtr id_getAPIResponseType;
			public override unsafe string APIResponseType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SubscribeMessagingEventsRequest.SubscribeMessagingEventsResponseHandler']/method[@name='getAPIResponseType' and count(parameter)=0]"
				[Register ("getAPIResponseType", "()Ljava/lang/String;", "GetGetAPIResponseTypeHandler")]
				get {
					if (id_getAPIResponseType == IntPtr.Zero)
						id_getAPIResponseType = JNIEnv.GetMethodID (class_ref, "getAPIResponseType", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAPIResponseType), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_handle_Lcom_liveperson_api_request_SubscribeMessagingEvents_Response_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SubscribeMessagingEventsRequest.SubscribeMessagingEventsResponseHandler']/method[@name='handle' and count(parameter)=1 and parameter[1][@type='com.liveperson.api.request.SubscribeMessagingEvents.Response']]"
			[Register ("handle", "(Lcom/liveperson/api/request/SubscribeMessagingEvents$Response;)Z", "")]
			protected new unsafe bool Handle (global::Com.Liveperson.Api.Request.SubscribeMessagingEvents.Response p0)
			{
				if (id_handle_Lcom_liveperson_api_request_SubscribeMessagingEvents_Response_ == IntPtr.Zero)
					id_handle_Lcom_liveperson_api_request_SubscribeMessagingEvents_Response_ = JNIEnv.GetMethodID (class_ref, "handle", "(Lcom/liveperson/api/request/SubscribeMessagingEvents$Response;)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_handle_Lcom_liveperson_api_request_SubscribeMessagingEvents_Response_, __args);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_parse_Lorg_json_JSONObject_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SubscribeMessagingEventsRequest.SubscribeMessagingEventsResponseHandler']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("parse", "(Lorg/json/JSONObject;)Lcom/liveperson/api/request/SubscribeMessagingEvents$Response;", "")]
			protected unsafe global::Com.Liveperson.Api.Request.SubscribeMessagingEvents.Response Parse (global::Org.Json.JSONObject p0)
			{
				if (id_parse_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_parse_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "parse", "(Lorg/json/JSONObject;)Lcom/liveperson/api/request/SubscribeMessagingEvents$Response;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Liveperson.Api.Request.SubscribeMessagingEvents.Response __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.SubscribeMessagingEvents.Response> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parse_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/network/socket/requests/SubscribeMessagingEventsRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SubscribeMessagingEventsRequest); }
		}

		internal SubscribeMessagingEventsRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SubscribeMessagingEventsRequest']/constructor[@name='SubscribeMessagingEventsRequest' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Integer']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;)V", "")]
		public unsafe SubscribeMessagingEventsRequest (string p0, string p1, global::Java.Lang.Integer p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (SubscribeMessagingEventsRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getConversationId;
		public unsafe string ConversationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SubscribeMessagingEventsRequest']/method[@name='getConversationId' and count(parameter)=0]"
			[Register ("getConversationId", "()Ljava/lang/String;", "GetGetConversationIdHandler")]
			get {
				if (id_getConversationId == IntPtr.Zero)
					id_getConversationId = JNIEnv.GetMethodID (class_ref, "getConversationId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getData;
		protected override unsafe string Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SubscribeMessagingEventsRequest']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/lang/String;", "GetGetDataHandler")]
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getFromSeq;
		public unsafe global::Java.Lang.Integer FromSeq {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SubscribeMessagingEventsRequest']/method[@name='getFromSeq' and count(parameter)=0]"
			[Register ("getFromSeq", "()Ljava/lang/Integer;", "GetGetFromSeqHandler")]
			get {
				if (id_getFromSeq == IntPtr.Zero)
					id_getFromSeq = JNIEnv.GetMethodID (class_ref, "getFromSeq", "()Ljava/lang/Integer;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFromSeq), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getRequestName;
		protected override unsafe string RequestName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SubscribeMessagingEventsRequest']/method[@name='getRequestName' and count(parameter)=0]"
			[Register ("getRequestName", "()Ljava/lang/String;", "GetGetRequestNameHandler")]
			get {
				if (id_getRequestName == IntPtr.Zero)
					id_getRequestName = JNIEnv.GetMethodID (class_ref, "getRequestName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getResponseHandler;
		protected unsafe global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler ResponseHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SubscribeMessagingEventsRequest']/method[@name='getResponseHandler' and count(parameter)=0]"
			[Register ("getResponseHandler", "()Lcom/liveperson/infra/network/socket/BaseResponseHandler;", "GetGetResponseHandlerHandler")]
			get {
				if (id_getResponseHandler == IntPtr.Zero)
					id_getResponseHandler = JNIEnv.GetMethodID (class_ref, "getResponseHandler", "()Lcom/liveperson/infra/network/socket/BaseResponseHandler;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseHandler), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
