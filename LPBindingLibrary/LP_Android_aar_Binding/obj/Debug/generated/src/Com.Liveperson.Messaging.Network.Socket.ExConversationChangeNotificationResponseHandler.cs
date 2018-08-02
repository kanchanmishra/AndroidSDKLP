using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Network.Socket {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='ExConversationChangeNotificationResponseHandler']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/network/socket/ExConversationChangeNotificationResponseHandler", DoNotGenerateAcw=true)]
	public partial class ExConversationChangeNotificationResponseHandler : global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler {


		static IntPtr mController_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='ExConversationChangeNotificationResponseHandler']/field[@name='mController']"
		[Register ("mController")]
		protected global::Com.Liveperson.Messaging.Messaging MController {
			get {
				if (mController_jfieldId == IntPtr.Zero)
					mController_jfieldId = JNIEnv.GetFieldID (class_ref, "mController", "Lcom/liveperson/messaging/Messaging;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mController_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mController_jfieldId == IntPtr.Zero)
					mController_jfieldId = JNIEnv.GetFieldID (class_ref, "mController", "Lcom/liveperson/messaging/Messaging;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mController_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mConversationUtils_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='ExConversationChangeNotificationResponseHandler']/field[@name='mConversationUtils']"
		[Register ("mConversationUtils")]
		protected global::Com.Liveperson.Messaging.Model.ConversationUtils MConversationUtils {
			get {
				if (mConversationUtils_jfieldId == IntPtr.Zero)
					mConversationUtils_jfieldId = JNIEnv.GetFieldID (class_ref, "mConversationUtils", "Lcom/liveperson/messaging/model/ConversationUtils;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mConversationUtils_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.ConversationUtils> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mConversationUtils_jfieldId == IntPtr.Zero)
					mConversationUtils_jfieldId = JNIEnv.GetFieldID (class_ref, "mConversationUtils", "Lcom/liveperson/messaging/model/ConversationUtils;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mConversationUtils_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/network/socket/ExConversationChangeNotificationResponseHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExConversationChangeNotificationResponseHandler); }
		}

		protected ExConversationChangeNotificationResponseHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_Messaging_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='ExConversationChangeNotificationResponseHandler']/constructor[@name='ExConversationChangeNotificationResponseHandler' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.Messaging']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/Messaging;)V", "")]
		public unsafe ExConversationChangeNotificationResponseHandler (global::Com.Liveperson.Messaging.Messaging p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ExConversationChangeNotificationResponseHandler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/Messaging;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/Messaging;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_Messaging_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_Messaging_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/Messaging;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_, __args);
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
			global::Com.Liveperson.Messaging.Network.Socket.ExConversationChangeNotificationResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.ExConversationChangeNotificationResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.APIResponseType);
		}
#pragma warning restore 0169

		static IntPtr id_getAPIResponseType;
		public override unsafe string APIResponseType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='ExConversationChangeNotificationResponseHandler']/method[@name='getAPIResponseType' and count(parameter)=0]"
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

		static Delegate cb_getFetchConversationManager;
#pragma warning disable 0169
		static Delegate GetGetFetchConversationManagerHandler ()
		{
			if (cb_getFetchConversationManager == null)
				cb_getFetchConversationManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFetchConversationManager);
			return cb_getFetchConversationManager;
		}

		static IntPtr n_GetFetchConversationManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Network.Socket.ExConversationChangeNotificationResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.ExConversationChangeNotificationResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FetchConversationManager);
		}
#pragma warning restore 0169

		static IntPtr id_getFetchConversationManager;
		protected virtual unsafe global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager FetchConversationManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='ExConversationChangeNotificationResponseHandler']/method[@name='getFetchConversationManager' and count(parameter)=0]"
			[Register ("getFetchConversationManager", "()Lcom/liveperson/messaging/commands/tasks/FetchConversationManager;", "GetGetFetchConversationManagerHandler")]
			get {
				if (id_getFetchConversationManager == IntPtr.Zero)
					id_getFetchConversationManager = JNIEnv.GetMethodID (class_ref, "getFetchConversationManager", "()Lcom/liveperson/messaging/commands/tasks/FetchConversationManager;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFetchConversationManager), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFetchConversationManager", "()Lcom/liveperson/messaging/commands/tasks/FetchConversationManager;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_createNewConversation_Lcom_liveperson_messaging_model_ConversationData_;
#pragma warning disable 0169
		static Delegate GetCreateNewConversation_Lcom_liveperson_messaging_model_ConversationData_Handler ()
		{
			if (cb_createNewConversation_Lcom_liveperson_messaging_model_ConversationData_ == null)
				cb_createNewConversation_Lcom_liveperson_messaging_model_ConversationData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CreateNewConversation_Lcom_liveperson_messaging_model_ConversationData_);
			return cb_createNewConversation_Lcom_liveperson_messaging_model_ConversationData_;
		}

		static void n_CreateNewConversation_Lcom_liveperson_messaging_model_ConversationData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Network.Socket.ExConversationChangeNotificationResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.ExConversationChangeNotificationResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.ConversationData p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.ConversationData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreateNewConversation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_createNewConversation_Lcom_liveperson_messaging_model_ConversationData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='ExConversationChangeNotificationResponseHandler']/method[@name='createNewConversation' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.ConversationData']]"
		[Register ("createNewConversation", "(Lcom/liveperson/messaging/model/ConversationData;)V", "GetCreateNewConversation_Lcom_liveperson_messaging_model_ConversationData_Handler")]
		protected virtual unsafe void CreateNewConversation (global::Com.Liveperson.Messaging.Model.ConversationData p0)
		{
			if (id_createNewConversation_Lcom_liveperson_messaging_model_ConversationData_ == IntPtr.Zero)
				id_createNewConversation_Lcom_liveperson_messaging_model_ConversationData_ = JNIEnv.GetMethodID (class_ref, "createNewConversation", "(Lcom/liveperson/messaging/model/ConversationData;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createNewConversation_Lcom_liveperson_messaging_model_ConversationData_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createNewConversation", "(Lcom/liveperson/messaging/model/ConversationData;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_handle_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetHandle_Ljava_util_List_Handler ()
		{
			if (cb_handle_Ljava_util_List_ == null)
				cb_handle_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Handle_Ljava_util_List_);
			return cb_handle_Ljava_util_List_;
		}

		static bool n_Handle_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Network.Socket.ExConversationChangeNotificationResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.ExConversationChangeNotificationResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Model.ConversationData>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Handle (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_handle_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='ExConversationChangeNotificationResponseHandler']/method[@name='handle' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.liveperson.messaging.model.ConversationData&gt;']]"
		[Register ("handle", "(Ljava/util/List;)Z", "GetHandle_Ljava_util_List_Handler")]
		protected new virtual unsafe bool Handle (global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Model.ConversationData> p0)
		{
			if (id_handle_Ljava_util_List_ == IntPtr.Zero)
				id_handle_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "handle", "(Ljava/util/List;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Model.ConversationData>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_handle_Ljava_util_List_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handle", "(Ljava/util/List;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Network.Socket.ExConversationChangeNotificationResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.ExConversationChangeNotificationResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='ExConversationChangeNotificationResponseHandler']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		protected virtual unsafe void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "()V"));
			} finally {
			}
		}

		static Delegate cb_isValidResponse_Lcom_liveperson_api_response_model_Result_;
#pragma warning disable 0169
		static Delegate GetIsValidResponse_Lcom_liveperson_api_response_model_Result_Handler ()
		{
			if (cb_isValidResponse_Lcom_liveperson_api_response_model_Result_ == null)
				cb_isValidResponse_Lcom_liveperson_api_response_model_Result_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsValidResponse_Lcom_liveperson_api_response_model_Result_);
			return cb_isValidResponse_Lcom_liveperson_api_response_model_Result_;
		}

		static bool n_IsValidResponse_Lcom_liveperson_api_response_model_Result_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Network.Socket.ExConversationChangeNotificationResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.ExConversationChangeNotificationResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Response.Model.Result p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.Result> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsValidResponse (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isValidResponse_Lcom_liveperson_api_response_model_Result_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='ExConversationChangeNotificationResponseHandler']/method[@name='isValidResponse' and count(parameter)=1 and parameter[1][@type='com.liveperson.api.response.model.Result']]"
		[Register ("isValidResponse", "(Lcom/liveperson/api/response/model/Result;)Z", "GetIsValidResponse_Lcom_liveperson_api_response_model_Result_Handler")]
		protected virtual unsafe bool IsValidResponse (global::Com.Liveperson.Api.Response.Model.Result p0)
		{
			if (id_isValidResponse_Lcom_liveperson_api_response_model_Result_ == IntPtr.Zero)
				id_isValidResponse_Lcom_liveperson_api_response_model_Result_ = JNIEnv.GetMethodID (class_ref, "isValidResponse", "(Lcom/liveperson/api/response/model/Result;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isValidResponse_Lcom_liveperson_api_response_model_Result_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isValidResponse", "(Lcom/liveperson/api/response/model/Result;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_parse_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetParse_Lorg_json_JSONObject_Handler ()
		{
			if (cb_parse_Lorg_json_JSONObject_ == null)
				cb_parse_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Parse_Lorg_json_JSONObject_);
			return cb_parse_Lorg_json_JSONObject_;
		}

		static IntPtr n_Parse_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Network.Socket.ExConversationChangeNotificationResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.ExConversationChangeNotificationResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Model.ConversationData>.ToLocalJniHandle (__this.Parse (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_parse_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='ExConversationChangeNotificationResponseHandler']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("parse", "(Lorg/json/JSONObject;)Ljava/util/List;", "GetParse_Lorg_json_JSONObject_Handler")]
		protected virtual unsafe global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Model.ConversationData> Parse (global::Org.Json.JSONObject p0)
		{
			if (id_parse_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_parse_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "parse", "(Lorg/json/JSONObject;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Model.ConversationData> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Model.ConversationData>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parse_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Model.ConversationData>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parse", "(Lorg/json/JSONObject;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_queryMessages_Lcom_liveperson_messaging_model_Conversation_Lcom_liveperson_messaging_commands_tasks_FetchConversationManager_DATA_SOURCE_;
#pragma warning disable 0169
		static Delegate GetQueryMessages_Lcom_liveperson_messaging_model_Conversation_Lcom_liveperson_messaging_commands_tasks_FetchConversationManager_DATA_SOURCE_Handler ()
		{
			if (cb_queryMessages_Lcom_liveperson_messaging_model_Conversation_Lcom_liveperson_messaging_commands_tasks_FetchConversationManager_DATA_SOURCE_ == null)
				cb_queryMessages_Lcom_liveperson_messaging_model_Conversation_Lcom_liveperson_messaging_commands_tasks_FetchConversationManager_DATA_SOURCE_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_QueryMessages_Lcom_liveperson_messaging_model_Conversation_Lcom_liveperson_messaging_commands_tasks_FetchConversationManager_DATA_SOURCE_);
			return cb_queryMessages_Lcom_liveperson_messaging_model_Conversation_Lcom_liveperson_messaging_commands_tasks_FetchConversationManager_DATA_SOURCE_;
		}

		static void n_QueryMessages_Lcom_liveperson_messaging_model_Conversation_Lcom_liveperson_messaging_commands_tasks_FetchConversationManager_DATA_SOURCE_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Network.Socket.ExConversationChangeNotificationResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.ExConversationChangeNotificationResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager.DATA_SOURCE p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager.DATA_SOURCE> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.QueryMessages (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_queryMessages_Lcom_liveperson_messaging_model_Conversation_Lcom_liveperson_messaging_commands_tasks_FetchConversationManager_DATA_SOURCE_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='ExConversationChangeNotificationResponseHandler']/method[@name='queryMessages' and count(parameter)=2 and parameter[1][@type='com.liveperson.messaging.model.Conversation'] and parameter[2][@type='com.liveperson.messaging.commands.tasks.FetchConversationManager.DATA_SOURCE']]"
		[Register ("queryMessages", "(Lcom/liveperson/messaging/model/Conversation;Lcom/liveperson/messaging/commands/tasks/FetchConversationManager$DATA_SOURCE;)V", "GetQueryMessages_Lcom_liveperson_messaging_model_Conversation_Lcom_liveperson_messaging_commands_tasks_FetchConversationManager_DATA_SOURCE_Handler")]
		protected virtual unsafe void QueryMessages (global::Com.Liveperson.Messaging.Model.Conversation p0, global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager.DATA_SOURCE p1)
		{
			if (id_queryMessages_Lcom_liveperson_messaging_model_Conversation_Lcom_liveperson_messaging_commands_tasks_FetchConversationManager_DATA_SOURCE_ == IntPtr.Zero)
				id_queryMessages_Lcom_liveperson_messaging_model_Conversation_Lcom_liveperson_messaging_commands_tasks_FetchConversationManager_DATA_SOURCE_ = JNIEnv.GetMethodID (class_ref, "queryMessages", "(Lcom/liveperson/messaging/model/Conversation;Lcom/liveperson/messaging/commands/tasks/FetchConversationManager$DATA_SOURCE;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_queryMessages_Lcom_liveperson_messaging_model_Conversation_Lcom_liveperson_messaging_commands_tasks_FetchConversationManager_DATA_SOURCE_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "queryMessages", "(Lcom/liveperson/messaging/model/Conversation;Lcom/liveperson/messaging/commands/tasks/FetchConversationManager$DATA_SOURCE;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateClosedConversation_Lcom_liveperson_messaging_model_ConversationData_Z;
#pragma warning disable 0169
		static Delegate GetUpdateClosedConversation_Lcom_liveperson_messaging_model_ConversationData_ZHandler ()
		{
			if (cb_updateClosedConversation_Lcom_liveperson_messaging_model_ConversationData_Z == null)
				cb_updateClosedConversation_Lcom_liveperson_messaging_model_ConversationData_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_UpdateClosedConversation_Lcom_liveperson_messaging_model_ConversationData_Z);
			return cb_updateClosedConversation_Lcom_liveperson_messaging_model_ConversationData_Z;
		}

		static void n_UpdateClosedConversation_Lcom_liveperson_messaging_model_ConversationData_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Liveperson.Messaging.Network.Socket.ExConversationChangeNotificationResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.ExConversationChangeNotificationResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.ConversationData p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.ConversationData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateClosedConversation (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateClosedConversation_Lcom_liveperson_messaging_model_ConversationData_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='ExConversationChangeNotificationResponseHandler']/method[@name='updateClosedConversation' and count(parameter)=2 and parameter[1][@type='com.liveperson.messaging.model.ConversationData'] and parameter[2][@type='boolean']]"
		[Register ("updateClosedConversation", "(Lcom/liveperson/messaging/model/ConversationData;Z)V", "GetUpdateClosedConversation_Lcom_liveperson_messaging_model_ConversationData_ZHandler")]
		protected virtual unsafe void UpdateClosedConversation (global::Com.Liveperson.Messaging.Model.ConversationData p0, bool p1)
		{
			if (id_updateClosedConversation_Lcom_liveperson_messaging_model_ConversationData_Z == IntPtr.Zero)
				id_updateClosedConversation_Lcom_liveperson_messaging_model_ConversationData_Z = JNIEnv.GetMethodID (class_ref, "updateClosedConversation", "(Lcom/liveperson/messaging/model/ConversationData;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateClosedConversation_Lcom_liveperson_messaging_model_ConversationData_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateClosedConversation", "(Lcom/liveperson/messaging/model/ConversationData;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateConversation_Lcom_liveperson_messaging_model_ConversationData_;
#pragma warning disable 0169
		static Delegate GetUpdateConversation_Lcom_liveperson_messaging_model_ConversationData_Handler ()
		{
			if (cb_updateConversation_Lcom_liveperson_messaging_model_ConversationData_ == null)
				cb_updateConversation_Lcom_liveperson_messaging_model_ConversationData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateConversation_Lcom_liveperson_messaging_model_ConversationData_);
			return cb_updateConversation_Lcom_liveperson_messaging_model_ConversationData_;
		}

		static void n_UpdateConversation_Lcom_liveperson_messaging_model_ConversationData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Network.Socket.ExConversationChangeNotificationResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.ExConversationChangeNotificationResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.ConversationData p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.ConversationData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateConversation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateConversation_Lcom_liveperson_messaging_model_ConversationData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='ExConversationChangeNotificationResponseHandler']/method[@name='updateConversation' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.ConversationData']]"
		[Register ("updateConversation", "(Lcom/liveperson/messaging/model/ConversationData;)V", "GetUpdateConversation_Lcom_liveperson_messaging_model_ConversationData_Handler")]
		protected virtual unsafe void UpdateConversation (global::Com.Liveperson.Messaging.Model.ConversationData p0)
		{
			if (id_updateConversation_Lcom_liveperson_messaging_model_ConversationData_ == IntPtr.Zero)
				id_updateConversation_Lcom_liveperson_messaging_model_ConversationData_ = JNIEnv.GetMethodID (class_ref, "updateConversation", "(Lcom/liveperson/messaging/model/ConversationData;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateConversation_Lcom_liveperson_messaging_model_ConversationData_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateConversation", "(Lcom/liveperson/messaging/model/ConversationData;)V"), __args);
			} finally {
			}
		}

	}
}
