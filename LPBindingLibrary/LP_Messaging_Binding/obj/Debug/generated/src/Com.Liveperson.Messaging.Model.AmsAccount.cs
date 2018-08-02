using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/model/AmsAccount", DoNotGenerateAcw=true)]
	public partial class AmsAccount : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/field[@name='BROADCAST_KEY_AUTH_COMPLETED_ACTION']"
		[Register ("BROADCAST_KEY_AUTH_COMPLETED_ACTION")]
		public const string BroadcastKeyAuthCompletedAction = (string) "BROADCAST_KEY_AUTH_COMPLETED_ACTION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/field[@name='KEY_ACCOUNT_NON_AUTH_ENC']"
		[Register ("KEY_ACCOUNT_NON_AUTH_ENC")]
		public const string KeyAccountNonAuthEnc = (string) "account_non_auth_enc";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/field[@name='KEY_ACCOUNT_TOKEN']"
		[Register ("KEY_ACCOUNT_TOKEN")]
		public const string KeyAccountToken = (string) "account_token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/field[@name='KEY_ACCOUNT_TOKEN_ENC']"
		[Register ("KEY_ACCOUNT_TOKEN_ENC")]
		public const string KeyAccountTokenEnc = (string) "account_token_enc";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/field[@name='KEY_CONNECTOR_ID_ENC']"
		[Register ("KEY_CONNECTOR_ID_ENC")]
		public const string KeyConnectorIdEnc = (string) "account_connector_id_enc";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/field[@name='KEY_CONSUMER_ID_ENC']"
		[Register ("KEY_CONSUMER_ID_ENC")]
		public const string KeyConsumerIdEnc = (string) "account_original_consumer_id_enc";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/model/AmsAccount", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsAccount); }
		}

		protected AmsAccount (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/constructor[@name='AmsAccount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe AmsAccount (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (AmsAccount)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAppId;
#pragma warning disable 0169
		static Delegate GetGetAppIdHandler ()
		{
			if (cb_getAppId == null)
				cb_getAppId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppId);
			return cb_getAppId;
		}

		static IntPtr n_GetAppId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppId);
		}
#pragma warning restore 0169

		static Delegate cb_setAppId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppId_Ljava_lang_String_Handler ()
		{
			if (cb_setAppId_Ljava_lang_String_ == null)
				cb_setAppId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppId_Ljava_lang_String_);
			return cb_setAppId_Ljava_lang_String_;
		}

		static void n_SetAppId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAppId;
		static IntPtr id_setAppId_Ljava_lang_String_;
		public virtual unsafe string AppId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/method[@name='getAppId' and count(parameter)=0]"
			[Register ("getAppId", "()Ljava/lang/String;", "GetGetAppIdHandler")]
			get {
				if (id_getAppId == IntPtr.Zero)
					id_getAppId = JNIEnv.GetMethodID (class_ref, "getAppId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/method[@name='setAppId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppId", "(Ljava/lang/String;)V", "GetSetAppId_Ljava_lang_String_Handler")]
			set {
				if (id_setAppId_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCertificatePinningKeys;
#pragma warning disable 0169
		static Delegate GetGetCertificatePinningKeysHandler ()
		{
			if (cb_getCertificatePinningKeys == null)
				cb_getCertificatePinningKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCertificatePinningKeys);
			return cb_getCertificatePinningKeys;
		}

		static IntPtr n_GetCertificatePinningKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.CertificatePinningKeys);
		}
#pragma warning restore 0169

		static IntPtr id_getCertificatePinningKeys;
		public virtual unsafe global::System.Collections.Generic.IList<string> CertificatePinningKeys {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/method[@name='getCertificatePinningKeys' and count(parameter)=0]"
			[Register ("getCertificatePinningKeys", "()Ljava/util/List;", "GetGetCertificatePinningKeysHandler")]
			get {
				if (id_getCertificatePinningKeys == IntPtr.Zero)
					id_getCertificatePinningKeys = JNIEnv.GetMethodID (class_ref, "getCertificatePinningKeys", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCertificatePinningKeys), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCertificatePinningKeys", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConnectionParamsCache;
#pragma warning disable 0169
		static Delegate GetGetConnectionParamsCacheHandler ()
		{
			if (cb_getConnectionParamsCache == null)
				cb_getConnectionParamsCache = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnectionParamsCache);
			return cb_getConnectionParamsCache;
		}

		static IntPtr n_GetConnectionParamsCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConnectionParamsCache);
		}
#pragma warning restore 0169

		static IntPtr id_getConnectionParamsCache;
		public virtual unsafe global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache ConnectionParamsCache {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/method[@name='getConnectionParamsCache' and count(parameter)=0]"
			[Register ("getConnectionParamsCache", "()Lcom/liveperson/messaging/controller/connection/IConnectionParamsCache;", "GetGetConnectionParamsCacheHandler")]
			get {
				if (id_getConnectionParamsCache == IntPtr.Zero)
					id_getConnectionParamsCache = JNIEnv.GetMethodID (class_ref, "getConnectionParamsCache", "()Lcom/liveperson/messaging/controller/connection/IConnectionParamsCache;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConnectionParamsCache), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectionParamsCache", "()Lcom/liveperson/messaging/controller/connection/IConnectionParamsCache;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConnectorId;
#pragma warning disable 0169
		static Delegate GetGetConnectorIdHandler ()
		{
			if (cb_getConnectorId == null)
				cb_getConnectorId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnectorId);
			return cb_getConnectorId;
		}

		static IntPtr n_GetConnectorId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConnectorId);
		}
#pragma warning restore 0169

		static Delegate cb_setConnectorId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetConnectorId_Ljava_lang_String_Handler ()
		{
			if (cb_setConnectorId_Ljava_lang_String_ == null)
				cb_setConnectorId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConnectorId_Ljava_lang_String_);
			return cb_setConnectorId_Ljava_lang_String_;
		}

		static void n_SetConnectorId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConnectorId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getConnectorId;
		static IntPtr id_setConnectorId_Ljava_lang_String_;
		public virtual unsafe string ConnectorId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/method[@name='getConnectorId' and count(parameter)=0]"
			[Register ("getConnectorId", "()Ljava/lang/String;", "GetGetConnectorIdHandler")]
			get {
				if (id_getConnectorId == IntPtr.Zero)
					id_getConnectorId = JNIEnv.GetMethodID (class_ref, "getConnectorId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConnectorId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectorId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/method[@name='setConnectorId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setConnectorId", "(Ljava/lang/String;)V", "GetSetConnectorId_Ljava_lang_String_Handler")]
			set {
				if (id_setConnectorId_Ljava_lang_String_ == IntPtr.Zero)
					id_setConnectorId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setConnectorId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConnectorId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConnectorId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDomain;
#pragma warning disable 0169
		static Delegate GetGetDomainHandler ()
		{
			if (cb_getDomain == null)
				cb_getDomain = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDomain);
			return cb_getDomain;
		}

		static IntPtr n_GetDomain (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Domain);
		}
#pragma warning restore 0169

		static IntPtr id_getDomain;
		public virtual unsafe string Domain {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/method[@name='getDomain' and count(parameter)=0]"
			[Register ("getDomain", "()Ljava/lang/String;", "GetGetDomainHandler")]
			get {
				if (id_getDomain == IntPtr.Zero)
					id_getDomain = JNIEnv.GetMethodID (class_ref, "getDomain", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDomain), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDomain", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isAuthenticated;
#pragma warning disable 0169
		static Delegate GetIsAuthenticatedHandler ()
		{
			if (cb_isAuthenticated == null)
				cb_isAuthenticated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAuthenticated);
			return cb_isAuthenticated;
		}

		static bool n_IsAuthenticated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAuthenticated;
		}
#pragma warning restore 0169

		static IntPtr id_isAuthenticated;
		public virtual unsafe bool IsAuthenticated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/method[@name='isAuthenticated' and count(parameter)=0]"
			[Register ("isAuthenticated", "()Z", "GetIsAuthenticatedHandler")]
			get {
				if (id_isAuthenticated == IntPtr.Zero)
					id_isAuthenticated = JNIEnv.GetMethodID (class_ref, "isAuthenticated", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAuthenticated);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAuthenticated", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isAuthenticatedCompleted;
#pragma warning disable 0169
		static Delegate GetIsAuthenticatedCompletedHandler ()
		{
			if (cb_isAuthenticatedCompleted == null)
				cb_isAuthenticatedCompleted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAuthenticatedCompleted);
			return cb_isAuthenticatedCompleted;
		}

		static bool n_IsAuthenticatedCompleted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAuthenticatedCompleted;
		}
#pragma warning restore 0169

		static IntPtr id_isAuthenticatedCompleted;
		public virtual unsafe bool IsAuthenticatedCompleted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/method[@name='isAuthenticatedCompleted' and count(parameter)=0]"
			[Register ("isAuthenticatedCompleted", "()Z", "GetIsAuthenticatedCompletedHandler")]
			get {
				if (id_isAuthenticatedCompleted == IntPtr.Zero)
					id_isAuthenticatedCompleted = JNIEnv.GetMethodID (class_ref, "isAuthenticatedCompleted", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAuthenticatedCompleted);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAuthenticatedCompleted", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isAutoMessagesEnabled;
#pragma warning disable 0169
		static Delegate GetIsAutoMessagesEnabledHandler ()
		{
			if (cb_isAutoMessagesEnabled == null)
				cb_isAutoMessagesEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAutoMessagesEnabled);
			return cb_isAutoMessagesEnabled;
		}

		static bool n_IsAutoMessagesEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAutoMessagesEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isAutoMessagesEnabled;
		public virtual unsafe bool IsAutoMessagesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/method[@name='isAutoMessagesEnabled' and count(parameter)=0]"
			[Register ("isAutoMessagesEnabled", "()Z", "GetIsAutoMessagesEnabledHandler")]
			get {
				if (id_isAutoMessagesEnabled == IntPtr.Zero)
					id_isAutoMessagesEnabled = JNIEnv.GetMethodID (class_ref, "isAutoMessagesEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAutoMessagesEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAutoMessagesEnabled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isCsdsDataMissing;
#pragma warning disable 0169
		static Delegate GetIsCsdsDataMissingHandler ()
		{
			if (cb_isCsdsDataMissing == null)
				cb_isCsdsDataMissing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCsdsDataMissing);
			return cb_isCsdsDataMissing;
		}

		static bool n_IsCsdsDataMissing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCsdsDataMissing;
		}
#pragma warning restore 0169

		static IntPtr id_isCsdsDataMissing;
		public virtual unsafe bool IsCsdsDataMissing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/method[@name='isCsdsDataMissing' and count(parameter)=0]"
			[Register ("isCsdsDataMissing", "()Z", "GetIsCsdsDataMissingHandler")]
			get {
				if (id_isCsdsDataMissing == IntPtr.Zero)
					id_isCsdsDataMissing = JNIEnv.GetMethodID (class_ref, "isCsdsDataMissing", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCsdsDataMissing);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCsdsDataMissing", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isHostAppJWTExpired;
#pragma warning disable 0169
		static Delegate GetIsHostAppJWTExpiredHandler ()
		{
			if (cb_isHostAppJWTExpired == null)
				cb_isHostAppJWTExpired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHostAppJWTExpired);
			return cb_isHostAppJWTExpired;
		}

		static bool n_IsHostAppJWTExpired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHostAppJWTExpired;
		}
#pragma warning restore 0169

		static IntPtr id_isHostAppJWTExpired;
		public virtual unsafe bool IsHostAppJWTExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/method[@name='isHostAppJWTExpired' and count(parameter)=0]"
			[Register ("isHostAppJWTExpired", "()Z", "GetIsHostAppJWTExpiredHandler")]
			get {
				if (id_isHostAppJWTExpired == IntPtr.Zero)
					id_isHostAppJWTExpired = JNIEnv.GetMethodID (class_ref, "isHostAppJWTExpired", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHostAppJWTExpired);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isHostAppJWTExpired", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isTokenExpired;
#pragma warning disable 0169
		static Delegate GetIsTokenExpiredHandler ()
		{
			if (cb_isTokenExpired == null)
				cb_isTokenExpired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTokenExpired);
			return cb_isTokenExpired;
		}

		static bool n_IsTokenExpired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTokenExpired;
		}
#pragma warning restore 0169

		static IntPtr id_isTokenExpired;
		public virtual unsafe bool IsTokenExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/method[@name='isTokenExpired' and count(parameter)=0]"
			[Register ("isTokenExpired", "()Z", "GetIsTokenExpiredHandler")]
			get {
				if (id_isTokenExpired == IntPtr.Zero)
					id_isTokenExpired = JNIEnv.GetMethodID (class_ref, "isTokenExpired", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTokenExpired);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isTokenExpired", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getLPAuthenticationParams;
#pragma warning disable 0169
		static Delegate GetGetLPAuthenticationParamsHandler ()
		{
			if (cb_getLPAuthenticationParams == null)
				cb_getLPAuthenticationParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLPAuthenticationParams);
			return cb_getLPAuthenticationParams;
		}

		static IntPtr n_GetLPAuthenticationParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LPAuthenticationParams);
		}
#pragma warning restore 0169

		static Delegate cb_setLPAuthenticationParams_Lcom_liveperson_infra_LPAuthenticationParams_;
#pragma warning disable 0169
		static Delegate GetSetLPAuthenticationParams_Lcom_liveperson_infra_LPAuthenticationParams_Handler ()
		{
			if (cb_setLPAuthenticationParams_Lcom_liveperson_infra_LPAuthenticationParams_ == null)
				cb_setLPAuthenticationParams_Lcom_liveperson_infra_LPAuthenticationParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLPAuthenticationParams_Lcom_liveperson_infra_LPAuthenticationParams_);
			return cb_setLPAuthenticationParams_Lcom_liveperson_infra_LPAuthenticationParams_;
		}

		static void n_SetLPAuthenticationParams_Lcom_liveperson_infra_LPAuthenticationParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.LPAuthenticationParams p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LPAuthenticationParams = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLPAuthenticationParams;
		static IntPtr id_setLPAuthenticationParams_Lcom_liveperson_infra_LPAuthenticationParams_;
		public virtual unsafe global::Com.Liveperson.Infra.LPAuthenticationParams LPAuthenticationParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/method[@name='getLPAuthenticationParams' and count(parameter)=0]"
			[Register ("getLPAuthenticationParams", "()Lcom/liveperson/infra/LPAuthenticationParams;", "GetGetLPAuthenticationParamsHandler")]
			get {
				if (id_getLPAuthenticationParams == IntPtr.Zero)
					id_getLPAuthenticationParams = JNIEnv.GetMethodID (class_ref, "getLPAuthenticationParams", "()Lcom/liveperson/infra/LPAuthenticationParams;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLPAuthenticationParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLPAuthenticationParams", "()Lcom/liveperson/infra/LPAuthenticationParams;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/method[@name='setLPAuthenticationParams' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.LPAuthenticationParams']]"
			[Register ("setLPAuthenticationParams", "(Lcom/liveperson/infra/LPAuthenticationParams;)V", "GetSetLPAuthenticationParams_Lcom_liveperson_infra_LPAuthenticationParams_Handler")]
			set {
				if (id_setLPAuthenticationParams_Lcom_liveperson_infra_LPAuthenticationParams_ == IntPtr.Zero)
					id_setLPAuthenticationParams_Lcom_liveperson_infra_LPAuthenticationParams_ = JNIEnv.GetMethodID (class_ref, "setLPAuthenticationParams", "(Lcom/liveperson/infra/LPAuthenticationParams;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLPAuthenticationParams_Lcom_liveperson_infra_LPAuthenticationParams_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLPAuthenticationParams", "(Lcom/liveperson/infra/LPAuthenticationParams;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNonAuthCode;
#pragma warning disable 0169
		static Delegate GetGetNonAuthCodeHandler ()
		{
			if (cb_getNonAuthCode == null)
				cb_getNonAuthCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNonAuthCode);
			return cb_getNonAuthCode;
		}

		static IntPtr n_GetNonAuthCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NonAuthCode);
		}
#pragma warning restore 0169

		static Delegate cb_setNonAuthCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNonAuthCode_Ljava_lang_String_Handler ()
		{
			if (cb_setNonAuthCode_Ljava_lang_String_ == null)
				cb_setNonAuthCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNonAuthCode_Ljava_lang_String_);
			return cb_setNonAuthCode_Ljava_lang_String_;
		}

		static void n_SetNonAuthCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NonAuthCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNonAuthCode;
		static IntPtr id_setNonAuthCode_Ljava_lang_String_;
		public virtual unsafe string NonAuthCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/method[@name='getNonAuthCode' and count(parameter)=0]"
			[Register ("getNonAuthCode", "()Ljava/lang/String;", "GetGetNonAuthCodeHandler")]
			get {
				if (id_getNonAuthCode == IntPtr.Zero)
					id_getNonAuthCode = JNIEnv.GetMethodID (class_ref, "getNonAuthCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNonAuthCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNonAuthCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/method[@name='setNonAuthCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNonAuthCode", "(Ljava/lang/String;)V", "GetSetNonAuthCode_Ljava_lang_String_Handler")]
			set {
				if (id_setNonAuthCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setNonAuthCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNonAuthCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNonAuthCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNonAuthCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getOriginalConsumerId;
#pragma warning disable 0169
		static Delegate GetGetOriginalConsumerIdHandler ()
		{
			if (cb_getOriginalConsumerId == null)
				cb_getOriginalConsumerId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOriginalConsumerId);
			return cb_getOriginalConsumerId;
		}

		static IntPtr n_GetOriginalConsumerId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OriginalConsumerId);
		}
#pragma warning restore 0169

		static Delegate cb_setOriginalConsumerId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOriginalConsumerId_Ljava_lang_String_Handler ()
		{
			if (cb_setOriginalConsumerId_Ljava_lang_String_ == null)
				cb_setOriginalConsumerId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOriginalConsumerId_Ljava_lang_String_);
			return cb_setOriginalConsumerId_Ljava_lang_String_;
		}

		static void n_SetOriginalConsumerId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OriginalConsumerId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOriginalConsumerId;
		static IntPtr id_setOriginalConsumerId_Ljava_lang_String_;
		public virtual unsafe string OriginalConsumerId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/method[@name='getOriginalConsumerId' and count(parameter)=0]"
			[Register ("getOriginalConsumerId", "()Ljava/lang/String;", "GetGetOriginalConsumerIdHandler")]
			get {
				if (id_getOriginalConsumerId == IntPtr.Zero)
					id_getOriginalConsumerId = JNIEnv.GetMethodID (class_ref, "getOriginalConsumerId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOriginalConsumerId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOriginalConsumerId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/method[@name='setOriginalConsumerId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setOriginalConsumerId", "(Ljava/lang/String;)V", "GetSetOriginalConsumerId_Ljava_lang_String_Handler")]
			set {
				if (id_setOriginalConsumerId_Ljava_lang_String_ == IntPtr.Zero)
					id_setOriginalConsumerId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOriginalConsumerId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOriginalConsumerId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOriginalConsumerId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getToken;
#pragma warning disable 0169
		static Delegate GetGetTokenHandler ()
		{
			if (cb_getToken == null)
				cb_getToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetToken);
			return cb_getToken;
		}

		static IntPtr n_GetToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Token);
		}
#pragma warning restore 0169

		static Delegate cb_setToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetToken_Ljava_lang_String_Handler ()
		{
			if (cb_setToken_Ljava_lang_String_ == null)
				cb_setToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetToken_Ljava_lang_String_);
			return cb_setToken_Ljava_lang_String_;
		}

		static void n_SetToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Token = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getToken;
		static IntPtr id_setToken_Ljava_lang_String_;
		public virtual unsafe string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/method[@name='getToken' and count(parameter)=0]"
			[Register ("getToken", "()Ljava/lang/String;", "GetGetTokenHandler")]
			get {
				if (id_getToken == IntPtr.Zero)
					id_getToken = JNIEnv.GetMethodID (class_ref, "getToken", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getToken), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/method[@name='setToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setToken", "(Ljava/lang/String;)V", "GetSetToken_Ljava_lang_String_Handler")]
			set {
				if (id_setToken_Ljava_lang_String_ == IntPtr.Zero)
					id_setToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setToken", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setToken_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setToken", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getServiceUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetServiceUrl_Ljava_lang_String_Handler ()
		{
			if (cb_getServiceUrl_Ljava_lang_String_ == null)
				cb_getServiceUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetServiceUrl_Ljava_lang_String_);
			return cb_getServiceUrl_Ljava_lang_String_;
		}

		static IntPtr n_GetServiceUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetServiceUrl (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getServiceUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/method[@name='getServiceUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getServiceUrl", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetServiceUrl_Ljava_lang_String_Handler")]
		public virtual unsafe string GetServiceUrl (string p0)
		{
			if (id_getServiceUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_getServiceUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getServiceUrl", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServiceUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServiceUrl", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendAuthenticationCompletedStatus;
#pragma warning disable 0169
		static Delegate GetSendAuthenticationCompletedStatusHandler ()
		{
			if (cb_sendAuthenticationCompletedStatus == null)
				cb_sendAuthenticationCompletedStatus = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendAuthenticationCompletedStatus);
			return cb_sendAuthenticationCompletedStatus;
		}

		static void n_SendAuthenticationCompletedStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendAuthenticationCompletedStatus ();
		}
#pragma warning restore 0169

		static IntPtr id_sendAuthenticationCompletedStatus;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/method[@name='sendAuthenticationCompletedStatus' and count(parameter)=0]"
		[Register ("sendAuthenticationCompletedStatus", "()V", "GetSendAuthenticationCompletedStatusHandler")]
		public virtual unsafe void SendAuthenticationCompletedStatus ()
		{
			if (id_sendAuthenticationCompletedStatus == IntPtr.Zero)
				id_sendAuthenticationCompletedStatus = JNIEnv.GetMethodID (class_ref, "sendAuthenticationCompletedStatus", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendAuthenticationCompletedStatus);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendAuthenticationCompletedStatus", "()V"));
			} finally {
			}
		}

		static Delegate cb_setCSDSMap_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetSetCSDSMap_Ljava_util_HashMap_Handler ()
		{
			if (cb_setCSDSMap_Ljava_util_HashMap_ == null)
				cb_setCSDSMap_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetCSDSMap_Ljava_util_HashMap_);
			return cb_setCSDSMap_Ljava_util_HashMap_;
		}

		static bool n_SetCSDSMap_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetCSDSMap (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setCSDSMap_Ljava_util_HashMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsAccount']/method[@name='setCSDSMap' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setCSDSMap", "(Ljava/util/HashMap;)Z", "GetSetCSDSMap_Ljava_util_HashMap_Handler")]
		public virtual unsafe bool SetCSDSMap (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_setCSDSMap_Ljava_util_HashMap_ == IntPtr.Zero)
				id_setCSDSMap_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "setCSDSMap", "(Ljava/util/HashMap;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setCSDSMap_Ljava_util_HashMap_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCSDSMap", "(Ljava/util/HashMap;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
