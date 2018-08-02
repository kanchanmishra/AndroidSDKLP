using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Network.Socket.Requests {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='GetUserProfileRequest']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/network/socket/requests/GetUserProfileRequest", DoNotGenerateAcw=true)]
	public partial class GetUserProfileRequest : global::Com.Liveperson.Api.Request.BaseAMSSocketRequest {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/network/socket/requests/GetUserProfileRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GetUserProfileRequest); }
		}

		protected GetUserProfileRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='GetUserProfileRequest']/constructor[@name='GetUserProfileRequest' and count(parameter)=4 and parameter[1][@type='com.liveperson.messaging.Messaging'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.liveperson.api.response.model.UserProfile.UserType']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/model/UserProfile$UserType;)V", "")]
		public unsafe GetUserProfileRequest (global::Com.Liveperson.Messaging.Messaging p0, string p1, string p2, global::Com.Liveperson.Api.Response.Model.UserProfile.UserType p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (GetUserProfileRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/model/UserProfile$UserType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/model/UserProfile$UserType;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/model/UserProfile$UserType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_, __args);
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
			global::Com.Liveperson.Messaging.Network.Socket.Requests.GetUserProfileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.GetUserProfileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Data);
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		protected override unsafe string Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='GetUserProfileRequest']/method[@name='getData' and count(parameter)=0]"
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
			global::Com.Liveperson.Messaging.Network.Socket.Requests.GetUserProfileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.GetUserProfileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestName);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestName;
		protected override unsafe string RequestName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='GetUserProfileRequest']/method[@name='getRequestName' and count(parameter)=0]"
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
			global::Com.Liveperson.Messaging.Network.Socket.Requests.GetUserProfileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.GetUserProfileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResponseHandler);
		}
#pragma warning restore 0169

		static IntPtr id_getResponseHandler;
		protected virtual unsafe global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler ResponseHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='GetUserProfileRequest']/method[@name='getResponseHandler' and count(parameter)=0]"
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

		static Delegate cb_setServerConversationId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetServerConversationId_Ljava_lang_String_Handler ()
		{
			if (cb_setServerConversationId_Ljava_lang_String_ == null)
				cb_setServerConversationId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetServerConversationId_Ljava_lang_String_);
			return cb_setServerConversationId_Ljava_lang_String_;
		}

		static IntPtr n_SetServerConversationId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Network.Socket.Requests.GetUserProfileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.GetUserProfileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetServerConversationId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setServerConversationId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='GetUserProfileRequest']/method[@name='setServerConversationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setServerConversationId", "(Ljava/lang/String;)Lcom/liveperson/messaging/network/socket/requests/GetUserProfileRequest;", "GetSetServerConversationId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Network.Socket.Requests.GetUserProfileRequest SetServerConversationId (string p0)
		{
			if (id_setServerConversationId_Ljava_lang_String_ == IntPtr.Zero)
				id_setServerConversationId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setServerConversationId", "(Ljava/lang/String;)Lcom/liveperson/messaging/network/socket/requests/GetUserProfileRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Messaging.Network.Socket.Requests.GetUserProfileRequest __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.GetUserProfileRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setServerConversationId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.GetUserProfileRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setServerConversationId", "(Ljava/lang/String;)Lcom/liveperson/messaging/network/socket/requests/GetUserProfileRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setShouldUpdateUI_Z;
#pragma warning disable 0169
		static Delegate GetSetShouldUpdateUI_ZHandler ()
		{
			if (cb_setShouldUpdateUI_Z == null)
				cb_setShouldUpdateUI_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetShouldUpdateUI_Z);
			return cb_setShouldUpdateUI_Z;
		}

		static IntPtr n_SetShouldUpdateUI_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Messaging.Network.Socket.Requests.GetUserProfileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.GetUserProfileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetShouldUpdateUI (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setShouldUpdateUI_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='GetUserProfileRequest']/method[@name='setShouldUpdateUI' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShouldUpdateUI", "(Z)Lcom/liveperson/messaging/network/socket/requests/GetUserProfileRequest;", "GetSetShouldUpdateUI_ZHandler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Network.Socket.Requests.GetUserProfileRequest SetShouldUpdateUI (bool p0)
		{
			if (id_setShouldUpdateUI_Z == IntPtr.Zero)
				id_setShouldUpdateUI_Z = JNIEnv.GetMethodID (class_ref, "setShouldUpdateUI", "(Z)Lcom/liveperson/messaging/network/socket/requests/GetUserProfileRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.GetUserProfileRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setShouldUpdateUI_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.GetUserProfileRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShouldUpdateUI", "(Z)Lcom/liveperson/messaging/network/socket/requests/GetUserProfileRequest;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setUserId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserId_Ljava_lang_String_Handler ()
		{
			if (cb_setUserId_Ljava_lang_String_ == null)
				cb_setUserId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetUserId_Ljava_lang_String_);
			return cb_setUserId_Ljava_lang_String_;
		}

		static IntPtr n_SetUserId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Network.Socket.Requests.GetUserProfileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.GetUserProfileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUserId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setUserId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='GetUserProfileRequest']/method[@name='setUserId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUserId", "(Ljava/lang/String;)Lcom/liveperson/messaging/network/socket/requests/GetUserProfileRequest;", "GetSetUserId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Network.Socket.Requests.GetUserProfileRequest SetUserId (string p0)
		{
			if (id_setUserId_Ljava_lang_String_ == IntPtr.Zero)
				id_setUserId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUserId", "(Ljava/lang/String;)Lcom/liveperson/messaging/network/socket/requests/GetUserProfileRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Messaging.Network.Socket.Requests.GetUserProfileRequest __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.GetUserProfileRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setUserId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.GetUserProfileRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserId", "(Ljava/lang/String;)Lcom/liveperson/messaging/network/socket/requests/GetUserProfileRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
