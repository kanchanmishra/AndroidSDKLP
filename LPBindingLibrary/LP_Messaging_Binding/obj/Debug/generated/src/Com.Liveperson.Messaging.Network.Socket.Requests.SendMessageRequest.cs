using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Network.Socket.Requests {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SendMessageRequest']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/network/socket/requests/SendMessageRequest", DoNotGenerateAcw=true)]
	public partial class SendMessageRequest : global::Com.Liveperson.Api.Request.BaseAMSSocketRequest {


		static IntPtr mMessage_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SendMessageRequest']/field[@name='mMessage']"
		[Register ("mMessage")]
		protected global::Com.Liveperson.Api.Request.Message.IPublishMessage MMessage {
			get {
				if (mMessage_jfieldId == IntPtr.Zero)
					mMessage_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessage", "Lcom/liveperson/api/request/message/PublishMessage;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMessage_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.IPublishMessage> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMessage_jfieldId == IntPtr.Zero)
					mMessage_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessage", "Lcom/liveperson/api/request/message/PublishMessage;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMessage_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/network/socket/requests/SendMessageRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SendMessageRequest); }
		}

		protected SendMessageRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SendMessageRequest']/constructor[@name='SendMessageRequest' and count(parameter)=5 and parameter[1][@type='com.liveperson.messaging.Messaging'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe SendMessageRequest (global::Com.Liveperson.Messaging.Messaging p0, string p1, string p2, string p3, string p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				if (((object) this).GetType () != typeof (SendMessageRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SendMessageRequest']/constructor[@name='SendMessageRequest' and count(parameter)=6 and parameter[1][@type='com.liveperson.messaging.Messaging'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe SendMessageRequest (global::Com.Liveperson.Messaging.Messaging p0, string p1, string p2, string p3, string p4, string p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				if (((object) this).GetType () != typeof (SendMessageRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_model_ContentType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SendMessageRequest']/constructor[@name='SendMessageRequest' and count(parameter)=7 and parameter[1][@type='com.liveperson.messaging.Messaging'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='com.liveperson.api.response.model.ContentType']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/model/ContentType;)V", "")]
		public unsafe SendMessageRequest (global::Com.Liveperson.Messaging.Messaging p0, string p1, string p2, string p3, string p4, string p5, global::Com.Liveperson.Api.Response.Model.ContentType p6)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				if (((object) this).GetType () != typeof (SendMessageRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/model/ContentType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/model/ContentType;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_model_ContentType_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_model_ContentType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/model/ContentType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_model_ContentType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_model_ContentType_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
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
			global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Data);
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		protected override unsafe string Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SendMessageRequest']/method[@name='getData' and count(parameter)=0]"
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

		static Delegate cb_getEventId;
#pragma warning disable 0169
		static Delegate GetGetEventIdHandler ()
		{
			if (cb_getEventId == null)
				cb_getEventId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventId);
			return cb_getEventId;
		}

		static IntPtr n_GetEventId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EventId);
		}
#pragma warning restore 0169

		static IntPtr id_getEventId;
		public virtual unsafe string EventId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SendMessageRequest']/method[@name='getEventId' and count(parameter)=0]"
			[Register ("getEventId", "()Ljava/lang/String;", "GetGetEventIdHandler")]
			get {
				if (id_getEventId == IntPtr.Zero)
					id_getEventId = JNIEnv.GetMethodID (class_ref, "getEventId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEventId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEventId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestName);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestName;
		protected override unsafe string RequestName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SendMessageRequest']/method[@name='getRequestName' and count(parameter)=0]"
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
			global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResponseHandler);
		}
#pragma warning restore 0169

		static IntPtr id_getResponseHandler;
		protected virtual unsafe global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler ResponseHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SendMessageRequest']/method[@name='getResponseHandler' and count(parameter)=0]"
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

		static Delegate cb_setContentType_Lcom_liveperson_api_response_model_ContentType_;
#pragma warning disable 0169
		static Delegate GetSetContentType_Lcom_liveperson_api_response_model_ContentType_Handler ()
		{
			if (cb_setContentType_Lcom_liveperson_api_response_model_ContentType_ == null)
				cb_setContentType_Lcom_liveperson_api_response_model_ContentType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetContentType_Lcom_liveperson_api_response_model_ContentType_);
			return cb_setContentType_Lcom_liveperson_api_response_model_ContentType_;
		}

		static IntPtr n_SetContentType_Lcom_liveperson_api_response_model_ContentType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Response.Model.ContentType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.ContentType> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetContentType (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setContentType_Lcom_liveperson_api_response_model_ContentType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SendMessageRequest']/method[@name='setContentType' and count(parameter)=1 and parameter[1][@type='com.liveperson.api.response.model.ContentType']]"
		[Register ("setContentType", "(Lcom/liveperson/api/response/model/ContentType;)Lcom/liveperson/messaging/network/socket/requests/SendMessageRequest;", "GetSetContentType_Lcom_liveperson_api_response_model_ContentType_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest SetContentType (global::Com.Liveperson.Api.Response.Model.ContentType p0)
		{
			if (id_setContentType_Lcom_liveperson_api_response_model_ContentType_ == IntPtr.Zero)
				id_setContentType_Lcom_liveperson_api_response_model_ContentType_ = JNIEnv.GetMethodID (class_ref, "setContentType", "(Lcom/liveperson/api/response/model/ContentType;)Lcom/liveperson/messaging/network/socket/requests/SendMessageRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setContentType_Lcom_liveperson_api_response_model_ContentType_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContentType", "(Lcom/liveperson/api/response/model/ContentType;)Lcom/liveperson/messaging/network/socket/requests/SendMessageRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setConversationId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetConversationId_Ljava_lang_String_Handler ()
		{
			if (cb_setConversationId_Ljava_lang_String_ == null)
				cb_setConversationId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetConversationId_Ljava_lang_String_);
			return cb_setConversationId_Ljava_lang_String_;
		}

		static IntPtr n_SetConversationId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetConversationId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setConversationId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SendMessageRequest']/method[@name='setConversationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setConversationId", "(Ljava/lang/String;)Lcom/liveperson/messaging/network/socket/requests/SendMessageRequest;", "GetSetConversationId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest SetConversationId (string p0)
		{
			if (id_setConversationId_Ljava_lang_String_ == IntPtr.Zero)
				id_setConversationId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setConversationId", "(Ljava/lang/String;)Lcom/liveperson/messaging/network/socket/requests/SendMessageRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setConversationId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConversationId", "(Ljava/lang/String;)Lcom/liveperson/messaging/network/socket/requests/SendMessageRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setMessageContent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessageContent_Ljava_lang_String_Handler ()
		{
			if (cb_setMessageContent_Ljava_lang_String_ == null)
				cb_setMessageContent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessageContent_Ljava_lang_String_);
			return cb_setMessageContent_Ljava_lang_String_;
		}

		static void n_SetMessageContent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.SendMessageRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMessageContent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMessageContent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='SendMessageRequest']/method[@name='setMessageContent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMessageContent", "(Ljava/lang/String;)V", "GetSetMessageContent_Ljava_lang_String_Handler")]
		public virtual unsafe void SetMessageContent (string p0)
		{
			if (id_setMessageContent_Ljava_lang_String_ == IntPtr.Zero)
				id_setMessageContent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessageContent", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessageContent_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageContent", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
