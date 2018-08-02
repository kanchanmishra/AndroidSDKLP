using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Network.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IdpRequest']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/network/http/IdpRequest", DoNotGenerateAcw=true)]
	public partial class IdpRequest : global::Java.Lang.Object, global::Com.Liveperson.Infra.ICommand {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IdpRequest']/field[@name='AUTHENTICATE']"
		[Register ("AUTHENTICATE")]
		protected const string Authenticate = (string) "authenticate";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IdpRequest']/field[@name='DEFAULT_REDIRECT_URI']"
		[Register ("DEFAULT_REDIRECT_URI")]
		protected const string DefaultRedirectUri = (string) "https://liveperson.net";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IdpRequest']/field[@name='IDP_REQUEST_TIMEOUT']"
		[Register ("IDP_REQUEST_TIMEOUT")]
		protected const int IdpRequestTimeout = (int) 30000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IdpRequest']/field[@name='SIGNUP']"
		[Register ("SIGNUP")]
		protected const string Signup = (string) "signup";

		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IdpRequest']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IdpRequest']/field[@name='USER_EXPIRED_ERROR']"
		[Register ("USER_EXPIRED_ERROR")]
		public const string UserExpiredError = (string) "2001";

		static IntPtr mAccount_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IdpRequest']/field[@name='mAccount']"
		[Register ("mAccount")]
		protected global::Com.Liveperson.Messaging.Model.AmsAccount MAccount {
			get {
				if (mAccount_jfieldId == IntPtr.Zero)
					mAccount_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccount", "Lcom/liveperson/messaging/model/AmsAccount;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAccount_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAccount_jfieldId == IntPtr.Zero)
					mAccount_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccount", "Lcom/liveperson/messaging/model/AmsAccount;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAccount_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mBrandId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IdpRequest']/field[@name='mBrandId']"
		[Register ("mBrandId")]
		protected string MBrandId {
			get {
				if (mBrandId_jfieldId == IntPtr.Zero)
					mBrandId_jfieldId = JNIEnv.GetFieldID (class_ref, "mBrandId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mBrandId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mBrandId_jfieldId == IntPtr.Zero)
					mBrandId_jfieldId = JNIEnv.GetFieldID (class_ref, "mBrandId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mBrandId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCallback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IdpRequest']/field[@name='mCallback']"
		[Register ("mCallback")]
		protected global::Com.Liveperson.Messaging.Commands.Tasks.IdpTask.IDPExceptionICallback MCallback {
			get {
				if (mCallback_jfieldId == IntPtr.Zero)
					mCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mCallback", "Lcom/liveperson/messaging/commands/tasks/IdpTask$IDPExceptionICallback;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCallback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.IdpTask.IDPExceptionICallback> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCallback_jfieldId == IntPtr.Zero)
					mCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mCallback", "Lcom/liveperson/messaging/commands/tasks/IdpTask$IDPExceptionICallback;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCallback_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCertificates_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IdpRequest']/field[@name='mCertificates']"
		[Register ("mCertificates")]
		protected global::System.Collections.IList MCertificates {
			get {
				if (mCertificates_jfieldId == IntPtr.Zero)
					mCertificates_jfieldId = JNIEnv.GetFieldID (class_ref, "mCertificates", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCertificates_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCertificates_jfieldId == IntPtr.Zero)
					mCertificates_jfieldId = JNIEnv.GetFieldID (class_ref, "mCertificates", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCertificates_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mHostVersion_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IdpRequest']/field[@name='mHostVersion']"
		[Register ("mHostVersion")]
		protected string MHostVersion {
			get {
				if (mHostVersion_jfieldId == IntPtr.Zero)
					mHostVersion_jfieldId = JNIEnv.GetFieldID (class_ref, "mHostVersion", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mHostVersion_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mHostVersion_jfieldId == IntPtr.Zero)
					mHostVersion_jfieldId = JNIEnv.GetFieldID (class_ref, "mHostVersion", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mHostVersion_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mIdpDomain_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IdpRequest']/field[@name='mIdpDomain']"
		[Register ("mIdpDomain")]
		protected string MIdpDomain {
			get {
				if (mIdpDomain_jfieldId == IntPtr.Zero)
					mIdpDomain_jfieldId = JNIEnv.GetFieldID (class_ref, "mIdpDomain", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mIdpDomain_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mIdpDomain_jfieldId == IntPtr.Zero)
					mIdpDomain_jfieldId = JNIEnv.GetFieldID (class_ref, "mIdpDomain", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mIdpDomain_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mLPAuthenticationParams_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IdpRequest']/field[@name='mLPAuthenticationParams']"
		[Register ("mLPAuthenticationParams")]
		protected global::Com.Liveperson.Infra.LPAuthenticationParams MLPAuthenticationParams {
			get {
				if (mLPAuthenticationParams_jfieldId == IntPtr.Zero)
					mLPAuthenticationParams_jfieldId = JNIEnv.GetFieldID (class_ref, "mLPAuthenticationParams", "Lcom/liveperson/infra/LPAuthenticationParams;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mLPAuthenticationParams_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mLPAuthenticationParams_jfieldId == IntPtr.Zero)
					mLPAuthenticationParams_jfieldId = JNIEnv.GetFieldID (class_ref, "mLPAuthenticationParams", "Lcom/liveperson/infra/LPAuthenticationParams;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mLPAuthenticationParams_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/network/http/IdpRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IdpRequest); }
		}

		protected IdpRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_model_AmsAccount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Ljava_lang_String_Lcom_liveperson_messaging_commands_tasks_IdpTask_IDPExceptionICallback_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IdpRequest']/constructor[@name='IdpRequest' and count(parameter)=7 and parameter[1][@type='com.liveperson.messaging.model.AmsAccount'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.liveperson.infra.LPAuthenticationParams'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.liveperson.messaging.commands.tasks.IdpTask.IDPExceptionICallback'] and parameter[7][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/model/AmsAccount;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Ljava/lang/String;Lcom/liveperson/messaging/commands/tasks/IdpTask$IDPExceptionICallback;Ljava/util/List;)V", "")]
		public unsafe IdpRequest (global::Com.Liveperson.Messaging.Model.AmsAccount p0, string p1, string p2, global::Com.Liveperson.Infra.LPAuthenticationParams p3, string p4, global::Com.Liveperson.Messaging.Commands.Tasks.IdpTask.IDPExceptionICallback p5, global::System.Collections.Generic.IList<string> p6)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p6 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p6);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (native_p6);
				if (((object) this).GetType () != typeof (IdpRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/model/AmsAccount;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Ljava/lang/String;Lcom/liveperson/messaging/commands/tasks/IdpTask$IDPExceptionICallback;Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/model/AmsAccount;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Ljava/lang/String;Lcom/liveperson/messaging/commands/tasks/IdpTask$IDPExceptionICallback;Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_model_AmsAccount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Ljava_lang_String_Lcom_liveperson_messaging_commands_tasks_IdpTask_IDPExceptionICallback_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_model_AmsAccount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Ljava_lang_String_Lcom_liveperson_messaging_commands_tasks_IdpTask_IDPExceptionICallback_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/model/AmsAccount;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Ljava/lang/String;Lcom/liveperson/messaging/commands/tasks/IdpTask$IDPExceptionICallback;Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_model_AmsAccount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Ljava_lang_String_Lcom_liveperson_messaging_commands_tasks_IdpTask_IDPExceptionICallback_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_model_AmsAccount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Ljava_lang_String_Lcom_liveperson_messaging_commands_tasks_IdpTask_IDPExceptionICallback_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static Delegate cb_addHeaders_Lcom_liveperson_infra_network_http_request_HttpPostRequest_;
#pragma warning disable 0169
		static Delegate GetAddHeaders_Lcom_liveperson_infra_network_http_request_HttpPostRequest_Handler ()
		{
			if (cb_addHeaders_Lcom_liveperson_infra_network_http_request_HttpPostRequest_ == null)
				cb_addHeaders_Lcom_liveperson_infra_network_http_request_HttpPostRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddHeaders_Lcom_liveperson_infra_network_http_request_HttpPostRequest_);
			return cb_addHeaders_Lcom_liveperson_infra_network_http_request_HttpPostRequest_;
		}

		static void n_AddHeaders_Lcom_liveperson_infra_network_http_request_HttpPostRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Network.Http.IdpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.IdpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Network.Http.Request.HttpPostRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpPostRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddHeaders (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addHeaders_Lcom_liveperson_infra_network_http_request_HttpPostRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IdpRequest']/method[@name='addHeaders' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.network.http.request.HttpPostRequest']]"
		[Register ("addHeaders", "(Lcom/liveperson/infra/network/http/request/HttpPostRequest;)V", "GetAddHeaders_Lcom_liveperson_infra_network_http_request_HttpPostRequest_Handler")]
		protected virtual unsafe void AddHeaders (global::Com.Liveperson.Infra.Network.Http.Request.HttpPostRequest p0)
		{
			if (id_addHeaders_Lcom_liveperson_infra_network_http_request_HttpPostRequest_ == IntPtr.Zero)
				id_addHeaders_Lcom_liveperson_infra_network_http_request_HttpPostRequest_ = JNIEnv.GetMethodID (class_ref, "addHeaders", "(Lcom/liveperson/infra/network/http/request/HttpPostRequest;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addHeaders_Lcom_liveperson_infra_network_http_request_HttpPostRequest_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addHeaders", "(Lcom/liveperson/infra/network/http/request/HttpPostRequest;)V"), __args);
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
			global::Com.Liveperson.Messaging.Network.Http.IdpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.IdpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		static IntPtr id_execute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IdpRequest']/method[@name='execute' and count(parameter)=0]"
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

		static Delegate cb_getBodyForIDPJwtFlow_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBodyForIDPJwtFlow_Ljava_lang_String_Handler ()
		{
			if (cb_getBodyForIDPJwtFlow_Ljava_lang_String_ == null)
				cb_getBodyForIDPJwtFlow_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBodyForIDPJwtFlow_Ljava_lang_String_);
			return cb_getBodyForIDPJwtFlow_Ljava_lang_String_;
		}

		static IntPtr n_GetBodyForIDPJwtFlow_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Network.Http.IdpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.IdpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBodyForIDPJwtFlow (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBodyForIDPJwtFlow_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IdpRequest']/method[@name='getBodyForIDPJwtFlow' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBodyForIDPJwtFlow", "(Ljava/lang/String;)Lorg/json/JSONObject;", "GetGetBodyForIDPJwtFlow_Ljava_lang_String_Handler")]
		protected virtual unsafe global::Org.Json.JSONObject GetBodyForIDPJwtFlow (string p0)
		{
			if (id_getBodyForIDPJwtFlow_Ljava_lang_String_ == IntPtr.Zero)
				id_getBodyForIDPJwtFlow_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getBodyForIDPJwtFlow", "(Ljava/lang/String;)Lorg/json/JSONObject;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Org.Json.JSONObject __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBodyForIDPJwtFlow_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBodyForIDPJwtFlow", "(Ljava/lang/String;)Lorg/json/JSONObject;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendErrorCallback_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetSendErrorCallback_Ljava_lang_Exception_Handler ()
		{
			if (cb_sendErrorCallback_Ljava_lang_Exception_ == null)
				cb_sendErrorCallback_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendErrorCallback_Ljava_lang_Exception_);
			return cb_sendErrorCallback_Ljava_lang_Exception_;
		}

		static void n_SendErrorCallback_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Network.Http.IdpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.IdpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendErrorCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendErrorCallback_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IdpRequest']/method[@name='sendErrorCallback' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("sendErrorCallback", "(Ljava/lang/Exception;)V", "GetSendErrorCallback_Ljava_lang_Exception_Handler")]
		protected virtual unsafe void SendErrorCallback (global::Java.Lang.Exception p0)
		{
			if (id_sendErrorCallback_Ljava_lang_Exception_ == IntPtr.Zero)
				id_sendErrorCallback_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "sendErrorCallback", "(Ljava/lang/Exception;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendErrorCallback_Ljava_lang_Exception_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendErrorCallback", "(Ljava/lang/Exception;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sendGeneralRequest_Lcom_liveperson_infra_network_http_request_HttpPostRequest_;
#pragma warning disable 0169
		static Delegate GetSendGeneralRequest_Lcom_liveperson_infra_network_http_request_HttpPostRequest_Handler ()
		{
			if (cb_sendGeneralRequest_Lcom_liveperson_infra_network_http_request_HttpPostRequest_ == null)
				cb_sendGeneralRequest_Lcom_liveperson_infra_network_http_request_HttpPostRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendGeneralRequest_Lcom_liveperson_infra_network_http_request_HttpPostRequest_);
			return cb_sendGeneralRequest_Lcom_liveperson_infra_network_http_request_HttpPostRequest_;
		}

		static void n_SendGeneralRequest_Lcom_liveperson_infra_network_http_request_HttpPostRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Network.Http.IdpRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.IdpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Network.Http.Request.HttpPostRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpPostRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendGeneralRequest (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendGeneralRequest_Lcom_liveperson_infra_network_http_request_HttpPostRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IdpRequest']/method[@name='sendGeneralRequest' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.network.http.request.HttpPostRequest']]"
		[Register ("sendGeneralRequest", "(Lcom/liveperson/infra/network/http/request/HttpPostRequest;)V", "GetSendGeneralRequest_Lcom_liveperson_infra_network_http_request_HttpPostRequest_Handler")]
		protected virtual unsafe void SendGeneralRequest (global::Com.Liveperson.Infra.Network.Http.Request.HttpPostRequest p0)
		{
			if (id_sendGeneralRequest_Lcom_liveperson_infra_network_http_request_HttpPostRequest_ == IntPtr.Zero)
				id_sendGeneralRequest_Lcom_liveperson_infra_network_http_request_HttpPostRequest_ = JNIEnv.GetMethodID (class_ref, "sendGeneralRequest", "(Lcom/liveperson/infra/network/http/request/HttpPostRequest;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendGeneralRequest_Lcom_liveperson_infra_network_http_request_HttpPostRequest_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendGeneralRequest", "(Lcom/liveperson/infra/network/http/request/HttpPostRequest;)V"), __args);
			} finally {
			}
		}

	}
}
