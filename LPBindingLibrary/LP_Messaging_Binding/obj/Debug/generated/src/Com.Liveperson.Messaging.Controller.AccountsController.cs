using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Controller {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/controller/AccountsController", DoNotGenerateAcw=true)]
	public partial class AccountsController : global::Java.Lang.Object, global::Com.Liveperson.Infra.IClearable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/field[@name='ALPHA_CSDS_DOMAIN']"
		[Register ("ALPHA_CSDS_DOMAIN")]
		public const string AlphaCsdsDomain = (string) "adminlogin.liveperson.net";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/field[@name='DOMAIN_VERSION_QUERY']"
		[Register ("DOMAIN_VERSION_QUERY")]
		protected const string DomainVersionQuery = (string) "v";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/field[@name='DOMAIN_VERSION_VALUE']"
		[Register ("DOMAIN_VERSION_VALUE")]
		protected const int DomainVersionValue = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/field[@name='KEY_TOKEN']"
		[Register ("KEY_TOKEN")]
		protected const string KeyToken = (string) "brand_token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/field[@name='QA_CSDS_DOMAIN']"
		[Register ("QA_CSDS_DOMAIN")]
		public const string QaCsdsDomain = (string) "hc1n.dev.lprnd.net";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/field[@name='SOCKET_URL']"
		[Register ("SOCKET_URL")]
		protected const string SocketUrl = (string) "wss://%1$s/ws_api/account/%2$s/messaging/consumer";

		static IntPtr mAccounts_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/field[@name='mAccounts']"
		[Register ("mAccounts")]
		protected global::System.Collections.IDictionary MAccounts {
			get {
				if (mAccounts_jfieldId == IntPtr.Zero)
					mAccounts_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccounts", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAccounts_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAccounts_jfieldId == IntPtr.Zero)
					mAccounts_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccounts", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAccounts_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/controller/AccountsController", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AccountsController); }
		}

		protected AccountsController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_controller_ClientProperties_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/constructor[@name='AccountsController' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.controller.ClientProperties']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/controller/ClientProperties;)V", "")]
		public unsafe AccountsController (global::Com.Liveperson.Messaging.Controller.ClientProperties p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AccountsController)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/controller/ClientProperties;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/controller/ClientProperties;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_controller_ClientProperties_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_controller_ClientProperties_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/controller/ClientProperties;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_controller_ClientProperties_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_controller_ClientProperties_, __args);
			} finally {
			}
		}

		static Delegate cb_getClientProperties;
#pragma warning disable 0169
		static Delegate GetGetClientPropertiesHandler ()
		{
			if (cb_getClientProperties == null)
				cb_getClientProperties = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientProperties);
			return cb_getClientProperties;
		}

		static IntPtr n_GetClientProperties (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.AccountsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.AccountsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClientProperties);
		}
#pragma warning restore 0169

		static IntPtr id_getClientProperties;
		public virtual unsafe global::Com.Liveperson.Messaging.Controller.ClientProperties ClientProperties {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/method[@name='getClientProperties' and count(parameter)=0]"
			[Register ("getClientProperties", "()Lcom/liveperson/messaging/controller/ClientProperties;", "GetGetClientPropertiesHandler")]
			get {
				if (id_getClientProperties == IntPtr.Zero)
					id_getClientProperties = JNIEnv.GetMethodID (class_ref, "getClientProperties", "()Lcom/liveperson/messaging/controller/ClientProperties;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientProperties), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientProperties", "()Lcom/liveperson/messaging/controller/ClientProperties;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addNewAccount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddNewAccount_Ljava_lang_String_Handler ()
		{
			if (cb_addNewAccount_Ljava_lang_String_ == null)
				cb_addNewAccount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddNewAccount_Ljava_lang_String_);
			return cb_addNewAccount_Ljava_lang_String_;
		}

		static void n_AddNewAccount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.AccountsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.AccountsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddNewAccount (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addNewAccount_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/method[@name='addNewAccount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addNewAccount", "(Ljava/lang/String;)V", "GetAddNewAccount_Ljava_lang_String_Handler")]
		public virtual unsafe void AddNewAccount (string p0)
		{
			if (id_addNewAccount_Ljava_lang_String_ == IntPtr.Zero)
				id_addNewAccount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addNewAccount", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addNewAccount_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addNewAccount", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.AccountsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.AccountsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_getAccount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAccount_Ljava_lang_String_Handler ()
		{
			if (cb_getAccount_Ljava_lang_String_ == null)
				cb_getAccount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAccount_Ljava_lang_String_);
			return cb_getAccount_Ljava_lang_String_;
		}

		static IntPtr n_GetAccount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.AccountsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.AccountsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAccount (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAccount_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/method[@name='getAccount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAccount", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/AmsAccount;", "GetGetAccount_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Model.AmsAccount GetAccount (string p0)
		{
			if (id_getAccount_Ljava_lang_String_ == IntPtr.Zero)
				id_getAccount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAccount", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/AmsAccount;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Messaging.Model.AmsAccount __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccount_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccount", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/AmsAccount;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getCertificatePinningKeys_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCertificatePinningKeys_Ljava_lang_String_Handler ()
		{
			if (cb_getCertificatePinningKeys_Ljava_lang_String_ == null)
				cb_getCertificatePinningKeys_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetCertificatePinningKeys_Ljava_lang_String_);
			return cb_getCertificatePinningKeys_Ljava_lang_String_;
		}

		static IntPtr n_GetCertificatePinningKeys_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.AccountsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.AccountsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.GetCertificatePinningKeys (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getCertificatePinningKeys_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/method[@name='getCertificatePinningKeys' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCertificatePinningKeys", "(Ljava/lang/String;)Ljava/util/List;", "GetGetCertificatePinningKeys_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<string> GetCertificatePinningKeys (string p0)
		{
			if (id_getCertificatePinningKeys_Ljava_lang_String_ == IntPtr.Zero)
				id_getCertificatePinningKeys_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getCertificatePinningKeys", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IList<string> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCertificatePinningKeys_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCertificatePinningKeys", "(Ljava/lang/String;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getConnectionParamsCache_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetConnectionParamsCache_Ljava_lang_String_Handler ()
		{
			if (cb_getConnectionParamsCache_Ljava_lang_String_ == null)
				cb_getConnectionParamsCache_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConnectionParamsCache_Ljava_lang_String_);
			return cb_getConnectionParamsCache_Ljava_lang_String_;
		}

		static IntPtr n_GetConnectionParamsCache_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.AccountsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.AccountsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConnectionParamsCache (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConnectionParamsCache_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/method[@name='getConnectionParamsCache' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getConnectionParamsCache", "(Ljava/lang/String;)Lcom/liveperson/messaging/controller/connection/IConnectionParamsCache;", "GetGetConnectionParamsCache_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache GetConnectionParamsCache (string p0)
		{
			if (id_getConnectionParamsCache_Ljava_lang_String_ == IntPtr.Zero)
				id_getConnectionParamsCache_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getConnectionParamsCache", "(Ljava/lang/String;)Lcom/liveperson/messaging/controller/connection/IConnectionParamsCache;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConnectionParamsCache_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectionParamsCache", "(Ljava/lang/String;)Lcom/liveperson/messaging/controller/connection/IConnectionParamsCache;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getConnectionUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetConnectionUrl_Ljava_lang_String_Handler ()
		{
			if (cb_getConnectionUrl_Ljava_lang_String_ == null)
				cb_getConnectionUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConnectionUrl_Ljava_lang_String_);
			return cb_getConnectionUrl_Ljava_lang_String_;
		}

		static IntPtr n_GetConnectionUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.AccountsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.AccountsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetConnectionUrl (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConnectionUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/method[@name='getConnectionUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getConnectionUrl", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetConnectionUrl_Ljava_lang_String_Handler")]
		public virtual unsafe string GetConnectionUrl (string p0)
		{
			if (id_getConnectionUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_getConnectionUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getConnectionUrl", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConnectionUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectionUrl", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getConnectionUrlForLogs_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetConnectionUrlForLogs_Ljava_lang_String_Handler ()
		{
			if (cb_getConnectionUrlForLogs_Ljava_lang_String_ == null)
				cb_getConnectionUrlForLogs_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConnectionUrlForLogs_Ljava_lang_String_);
			return cb_getConnectionUrlForLogs_Ljava_lang_String_;
		}

		static IntPtr n_GetConnectionUrlForLogs_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.AccountsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.AccountsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetConnectionUrlForLogs (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConnectionUrlForLogs_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/method[@name='getConnectionUrlForLogs' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getConnectionUrlForLogs", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetConnectionUrlForLogs_Ljava_lang_String_Handler")]
		public virtual unsafe string GetConnectionUrlForLogs (string p0)
		{
			if (id_getConnectionUrlForLogs_Ljava_lang_String_ == IntPtr.Zero)
				id_getConnectionUrlForLogs_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getConnectionUrlForLogs", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConnectionUrlForLogs_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectionUrlForLogs", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getDomain_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDomain_Ljava_lang_String_Handler ()
		{
			if (cb_getDomain_Ljava_lang_String_ == null)
				cb_getDomain_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDomain_Ljava_lang_String_);
			return cb_getDomain_Ljava_lang_String_;
		}

		static IntPtr n_GetDomain_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.AccountsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.AccountsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetDomain (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDomain_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/method[@name='getDomain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDomain", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetDomain_Ljava_lang_String_Handler")]
		public virtual unsafe string GetDomain (string p0)
		{
			if (id_getDomain_Ljava_lang_String_ == IntPtr.Zero)
				id_getDomain_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getDomain", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDomain_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDomain", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getLPAuthenticationParams_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLPAuthenticationParams_Ljava_lang_String_Handler ()
		{
			if (cb_getLPAuthenticationParams_Ljava_lang_String_ == null)
				cb_getLPAuthenticationParams_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLPAuthenticationParams_Ljava_lang_String_);
			return cb_getLPAuthenticationParams_Ljava_lang_String_;
		}

		static IntPtr n_GetLPAuthenticationParams_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.AccountsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.AccountsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLPAuthenticationParams (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLPAuthenticationParams_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/method[@name='getLPAuthenticationParams' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLPAuthenticationParams", "(Ljava/lang/String;)Lcom/liveperson/infra/LPAuthenticationParams;", "GetGetLPAuthenticationParams_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.LPAuthenticationParams GetLPAuthenticationParams (string p0)
		{
			if (id_getLPAuthenticationParams_Ljava_lang_String_ == IntPtr.Zero)
				id_getLPAuthenticationParams_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLPAuthenticationParams", "(Ljava/lang/String;)Lcom/liveperson/infra/LPAuthenticationParams;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.LPAuthenticationParams __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLPAuthenticationParams_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLPAuthenticationParams", "(Ljava/lang/String;)Lcom/liveperson/infra/LPAuthenticationParams;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getServiceUrl_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetServiceUrl_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getServiceUrl_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getServiceUrl_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetServiceUrl_Ljava_lang_String_Ljava_lang_String_);
			return cb_getServiceUrl_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetServiceUrl_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Controller.AccountsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.AccountsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetServiceUrl (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getServiceUrl_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/method[@name='getServiceUrl' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getServiceUrl", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetServiceUrl_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string GetServiceUrl (string p0, string p1)
		{
			if (id_getServiceUrl_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getServiceUrl_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getServiceUrl", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServiceUrl_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServiceUrl", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetToken_Ljava_lang_String_Handler ()
		{
			if (cb_getToken_Ljava_lang_String_ == null)
				cb_getToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetToken_Ljava_lang_String_);
			return cb_getToken_Ljava_lang_String_;
		}

		static IntPtr n_GetToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.AccountsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.AccountsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetToken (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getToken_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/method[@name='getToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getToken", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetToken_Ljava_lang_String_Handler")]
		public virtual unsafe string GetToken (string p0)
		{
			if (id_getToken_Ljava_lang_String_ == IntPtr.Zero)
				id_getToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getToken", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getToken_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getToken", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getTokenizerUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTokenizerUrl_Ljava_lang_String_Handler ()
		{
			if (cb_getTokenizerUrl_Ljava_lang_String_ == null)
				cb_getTokenizerUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTokenizerUrl_Ljava_lang_String_);
			return cb_getTokenizerUrl_Ljava_lang_String_;
		}

		static IntPtr n_GetTokenizerUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.AccountsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.AccountsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetTokenizerUrl (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTokenizerUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/method[@name='getTokenizerUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTokenizerUrl", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetTokenizerUrl_Ljava_lang_String_Handler")]
		public virtual unsafe string GetTokenizerUrl (string p0)
		{
			if (id_getTokenizerUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_getTokenizerUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getTokenizerUrl", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTokenizerUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTokenizerUrl", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isAutoMessagesEnabled_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsAutoMessagesEnabled_Ljava_lang_String_Handler ()
		{
			if (cb_isAutoMessagesEnabled_Ljava_lang_String_ == null)
				cb_isAutoMessagesEnabled_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsAutoMessagesEnabled_Ljava_lang_String_);
			return cb_isAutoMessagesEnabled_Ljava_lang_String_;
		}

		static bool n_IsAutoMessagesEnabled_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.AccountsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.AccountsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsAutoMessagesEnabled (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isAutoMessagesEnabled_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/method[@name='isAutoMessagesEnabled' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isAutoMessagesEnabled", "(Ljava/lang/String;)Z", "GetIsAutoMessagesEnabled_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsAutoMessagesEnabled (string p0)
		{
			if (id_isAutoMessagesEnabled_Ljava_lang_String_ == IntPtr.Zero)
				id_isAutoMessagesEnabled_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isAutoMessagesEnabled", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAutoMessagesEnabled_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAutoMessagesEnabled", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isCsdsDataMissing_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsCsdsDataMissing_Ljava_lang_String_Handler ()
		{
			if (cb_isCsdsDataMissing_Ljava_lang_String_ == null)
				cb_isCsdsDataMissing_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsCsdsDataMissing_Ljava_lang_String_);
			return cb_isCsdsDataMissing_Ljava_lang_String_;
		}

		static bool n_IsCsdsDataMissing_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.AccountsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.AccountsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsCsdsDataMissing (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isCsdsDataMissing_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/method[@name='isCsdsDataMissing' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isCsdsDataMissing", "(Ljava/lang/String;)Z", "GetIsCsdsDataMissing_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsCsdsDataMissing (string p0)
		{
			if (id_isCsdsDataMissing_Ljava_lang_String_ == IntPtr.Zero)
				id_isCsdsDataMissing_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isCsdsDataMissing", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCsdsDataMissing_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCsdsDataMissing", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isTokenExpired_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsTokenExpired_Ljava_lang_String_Handler ()
		{
			if (cb_isTokenExpired_Ljava_lang_String_ == null)
				cb_isTokenExpired_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsTokenExpired_Ljava_lang_String_);
			return cb_isTokenExpired_Ljava_lang_String_;
		}

		static bool n_IsTokenExpired_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.AccountsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.AccountsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsTokenExpired (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isTokenExpired_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/method[@name='isTokenExpired' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isTokenExpired", "(Ljava/lang/String;)Z", "GetIsTokenExpired_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsTokenExpired (string p0)
		{
			if (id_isTokenExpired_Ljava_lang_String_ == IntPtr.Zero)
				id_isTokenExpired_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isTokenExpired", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTokenExpired_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isTokenExpired", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setAppId_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppId_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setAppId_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setAppId_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAppId_Ljava_lang_String_Ljava_lang_String_);
			return cb_setAppId_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetAppId_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Controller.AccountsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.AccountsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetAppId (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setAppId_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/method[@name='setAppId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setAppId", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetAppId_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAppId (string p0, string p1)
		{
			if (id_setAppId_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setAppId_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppId", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppId_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppId", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setCSDSMap_Ljava_lang_String_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetSetCSDSMap_Ljava_lang_String_Ljava_util_HashMap_Handler ()
		{
			if (cb_setCSDSMap_Ljava_lang_String_Ljava_util_HashMap_ == null)
				cb_setCSDSMap_Ljava_lang_String_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_SetCSDSMap_Ljava_lang_String_Ljava_util_HashMap_);
			return cb_setCSDSMap_Ljava_lang_String_Ljava_util_HashMap_;
		}

		static bool n_SetCSDSMap_Ljava_lang_String_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Controller.AccountsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.AccountsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetCSDSMap (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setCSDSMap_Ljava_lang_String_Ljava_util_HashMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/method[@name='setCSDSMap' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setCSDSMap", "(Ljava/lang/String;Ljava/util/HashMap;)Z", "GetSetCSDSMap_Ljava_lang_String_Ljava_util_HashMap_Handler")]
		public virtual unsafe bool SetCSDSMap (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_setCSDSMap_Ljava_lang_String_Ljava_util_HashMap_ == IntPtr.Zero)
				id_setCSDSMap_Ljava_lang_String_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "setCSDSMap", "(Ljava/lang/String;Ljava/util/HashMap;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setCSDSMap_Ljava_lang_String_Ljava_util_HashMap_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCSDSMap", "(Ljava/lang/String;Ljava/util/HashMap;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setLPAuthenticationParams_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_;
#pragma warning disable 0169
		static Delegate GetSetLPAuthenticationParams_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Handler ()
		{
			if (cb_setLPAuthenticationParams_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_ == null)
				cb_setLPAuthenticationParams_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLPAuthenticationParams_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_);
			return cb_setLPAuthenticationParams_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_;
		}

		static void n_SetLPAuthenticationParams_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Controller.AccountsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.AccountsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.LPAuthenticationParams p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetLPAuthenticationParams (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setLPAuthenticationParams_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/method[@name='setLPAuthenticationParams' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.LPAuthenticationParams']]"
		[Register ("setLPAuthenticationParams", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;)V", "GetSetLPAuthenticationParams_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Handler")]
		public virtual unsafe void SetLPAuthenticationParams (string p0, global::Com.Liveperson.Infra.LPAuthenticationParams p1)
		{
			if (id_setLPAuthenticationParams_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_ == IntPtr.Zero)
				id_setLPAuthenticationParams_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_ = JNIEnv.GetMethodID (class_ref, "setLPAuthenticationParams", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLPAuthenticationParams_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLPAuthenticationParams", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setToken_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetToken_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setToken_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setToken_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetToken_Ljava_lang_String_Ljava_lang_String_);
			return cb_setToken_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetToken_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Controller.AccountsController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.AccountsController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetToken (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setToken_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AccountsController']/method[@name='setToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setToken", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetToken_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetToken (string p0, string p1)
		{
			if (id_setToken_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setToken_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setToken", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setToken_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setToken", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
