using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Network.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='UnAuthRequest']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/network/http/UnAuthRequest", DoNotGenerateAcw=true)]
	public partial class UnAuthRequest : global::Com.Liveperson.Messaging.Network.Http.IdpRequest {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='UnAuthRequest']/field[@name='IDP_ANONYMOUS_URL']"
		[Register ("IDP_ANONYMOUS_URL")]
		public const string IdpAnonymousUrl = (string) "https://%s/api/account/%s/anonymous/authorize";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='UnAuthRequest']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "UnAuthRequest";

		static IntPtr mConnectorId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='UnAuthRequest']/field[@name='mConnectorId']"
		[Register ("mConnectorId")]
		protected string MConnectorId {
			get {
				if (mConnectorId_jfieldId == IntPtr.Zero)
					mConnectorId_jfieldId = JNIEnv.GetFieldID (class_ref, "mConnectorId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mConnectorId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mConnectorId_jfieldId == IntPtr.Zero)
					mConnectorId_jfieldId = JNIEnv.GetFieldID (class_ref, "mConnectorId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mConnectorId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/network/http/UnAuthRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnAuthRequest); }
		}

		protected UnAuthRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_model_AmsAccount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Ljava_lang_String_Lcom_liveperson_messaging_commands_tasks_IdpTask_IDPExceptionICallback_Ljava_util_List_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='UnAuthRequest']/constructor[@name='UnAuthRequest' and count(parameter)=8 and parameter[1][@type='com.liveperson.messaging.model.AmsAccount'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.liveperson.infra.LPAuthenticationParams'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.liveperson.messaging.commands.tasks.IdpTask.IDPExceptionICallback'] and parameter[7][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[8][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/model/AmsAccount;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Ljava/lang/String;Lcom/liveperson/messaging/commands/tasks/IdpTask$IDPExceptionICallback;Ljava/util/List;Ljava/lang/String;)V", "")]
		public unsafe UnAuthRequest (global::Com.Liveperson.Messaging.Model.AmsAccount p0, string p1, string p2, global::Com.Liveperson.Infra.LPAuthenticationParams p3, string p4, global::Com.Liveperson.Messaging.Commands.Tasks.IdpTask.IDPExceptionICallback p5, global::System.Collections.Generic.IList<string> p6, string p7)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p6 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p6);
			IntPtr native_p7 = JNIEnv.NewString (p7);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (native_p7);
				if (((object) this).GetType () != typeof (UnAuthRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/model/AmsAccount;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Ljava/lang/String;Lcom/liveperson/messaging/commands/tasks/IdpTask$IDPExceptionICallback;Ljava/util/List;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/model/AmsAccount;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Ljava/lang/String;Lcom/liveperson/messaging/commands/tasks/IdpTask$IDPExceptionICallback;Ljava/util/List;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_model_AmsAccount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Ljava_lang_String_Lcom_liveperson_messaging_commands_tasks_IdpTask_IDPExceptionICallback_Ljava_util_List_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_model_AmsAccount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Ljava_lang_String_Lcom_liveperson_messaging_commands_tasks_IdpTask_IDPExceptionICallback_Ljava_util_List_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/model/AmsAccount;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Ljava/lang/String;Lcom/liveperson/messaging/commands/tasks/IdpTask$IDPExceptionICallback;Ljava/util/List;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_model_AmsAccount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Ljava_lang_String_Lcom_liveperson_messaging_commands_tasks_IdpTask_IDPExceptionICallback_Ljava_util_List_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_model_AmsAccount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Ljava_lang_String_Lcom_liveperson_messaging_commands_tasks_IdpTask_IDPExceptionICallback_Ljava_util_List_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p6);
				JNIEnv.DeleteLocalRef (native_p7);
			}
		}

		static Delegate cb_getHttpPostRequestForIDPV3_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetHttpPostRequestForIDPV3_Ljava_lang_String_Handler ()
		{
			if (cb_getHttpPostRequestForIDPV3_Ljava_lang_String_ == null)
				cb_getHttpPostRequestForIDPV3_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetHttpPostRequestForIDPV3_Ljava_lang_String_);
			return cb_getHttpPostRequestForIDPV3_Ljava_lang_String_;
		}

		static IntPtr n_GetHttpPostRequestForIDPV3_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Network.Http.UnAuthRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.UnAuthRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetHttpPostRequestForIDPV3 (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getHttpPostRequestForIDPV3_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='UnAuthRequest']/method[@name='getHttpPostRequestForIDPV3' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getHttpPostRequestForIDPV3", "(Ljava/lang/String;)Lcom/liveperson/infra/network/http/request/HttpPostRequest;", "GetGetHttpPostRequestForIDPV3_Ljava_lang_String_Handler")]
		protected virtual unsafe global::Com.Liveperson.Infra.Network.Http.Request.HttpPostRequest GetHttpPostRequestForIDPV3 (string p0)
		{
			if (id_getHttpPostRequestForIDPV3_Ljava_lang_String_ == IntPtr.Zero)
				id_getHttpPostRequestForIDPV3_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getHttpPostRequestForIDPV3", "(Ljava/lang/String;)Lcom/liveperson/infra/network/http/request/HttpPostRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Network.Http.Request.HttpPostRequest __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpPostRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHttpPostRequestForIDPV3_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Request.HttpPostRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHttpPostRequestForIDPV3", "(Ljava/lang/String;)Lcom/liveperson/infra/network/http/request/HttpPostRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendUnAuthRequest;
#pragma warning disable 0169
		static Delegate GetSendUnAuthRequestHandler ()
		{
			if (cb_sendUnAuthRequest == null)
				cb_sendUnAuthRequest = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendUnAuthRequest);
			return cb_sendUnAuthRequest;
		}

		static void n_SendUnAuthRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Network.Http.UnAuthRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.UnAuthRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendUnAuthRequest ();
		}
#pragma warning restore 0169

		static IntPtr id_sendUnAuthRequest;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='UnAuthRequest']/method[@name='sendUnAuthRequest' and count(parameter)=0]"
		[Register ("sendUnAuthRequest", "()V", "GetSendUnAuthRequestHandler")]
		public virtual unsafe void SendUnAuthRequest ()
		{
			if (id_sendUnAuthRequest == IntPtr.Zero)
				id_sendUnAuthRequest = JNIEnv.GetMethodID (class_ref, "sendUnAuthRequest", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendUnAuthRequest);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendUnAuthRequest", "()V"));
			} finally {
			}
		}

	}
}
