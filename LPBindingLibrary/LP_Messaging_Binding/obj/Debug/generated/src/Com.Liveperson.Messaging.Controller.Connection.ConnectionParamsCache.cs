using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Controller.Connection {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/ConnectionParamsCache", DoNotGenerateAcw=true)]
	public partial class ConnectionParamsCache : global::Java.Lang.Object, global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/field[@name='AC_CDN_VERSION_KEY']"
		[Register ("AC_CDN_VERSION_KEY")]
		public const string AcCdnVersionKey = (string) "ac_cdn_version_key";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/field[@name='AUTO_MESSAGES_ENABLED_KEY']"
		[Register ("AUTO_MESSAGES_ENABLED_KEY")]
		public const string AutoMessagesEnabledKey = (string) "auto_messages_enabled_key";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/field[@name='CSDS_AC_CDN_DOMAIN_KEY']"
		[Register ("CSDS_AC_CDN_DOMAIN_KEY")]
		public const string CsdsAcCdnDomainKey = (string) "acCdnDomain";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/field[@name='CSDS_AMS_TOKENIZER_DOMAIN_KEY']"
		[Register ("CSDS_AMS_TOKENIZER_DOMAIN_KEY")]
		public const string CsdsAmsTokenizerDomainKey = (string) "tokenizer";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/field[@name='CSDS_IDP_DOMAIN_KEY']"
		[Register ("CSDS_IDP_DOMAIN_KEY")]
		public const string CsdsIdpDomainKey = (string) "idp";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/field[@name='CSDS_INCA_KEY']"
		[Register ("CSDS_INCA_KEY")]
		public const string CsdsIncaKey = (string) "msgHist";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/field[@name='CSDS_LE_CDN_DOMAIN_KEY']"
		[Register ("CSDS_LE_CDN_DOMAIN_KEY")]
		public const string CsdsLeCdnDomainKey = (string) "leCdnDomain";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/field[@name='CSDS_LOGGOS_DOMAIN_KEY']"
		[Register ("CSDS_LOGGOS_DOMAIN_KEY")]
		public const string CsdsLoggosDomainKey = (string) "loggos";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/field[@name='CSDS_PUSHER_DOMAIN_KEY']"
		[Register ("CSDS_PUSHER_DOMAIN_KEY")]
		public const string CsdsPusherDomainKey = (string) "pusher";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/field[@name='CSDS_SWIFT_DOMAIN_KEY']"
		[Register ("CSDS_SWIFT_DOMAIN_KEY")]
		public const string CsdsSwiftDomainKey = (string) "swift";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/field[@name='CSDS_UMS_DOMAIN_KEY']"
		[Register ("CSDS_UMS_DOMAIN_KEY")]
		public const string CsdsUmsDomainKey = (string) "asyncMessagingEnt";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/field[@name='FULL_CONNECTION_FLOW_REQUIRED_KEY']"
		[Register ("FULL_CONNECTION_FLOW_REQUIRED_KEY")]
		public const string FullConnectionFlowRequiredKey = (string) "full_connection_flow_required_key";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/field[@name='LE_CDN_VERSION_KEY']"
		[Register ("LE_CDN_VERSION_KEY")]
		public const string LeCdnVersionKey = (string) "le_cdn_version_key";

		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/field[@name='TAG']"
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
				return JNIEnv.FindClass ("com/liveperson/messaging/controller/connection/ConnectionParamsCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectionParamsCache); }
		}

		protected ConnectionParamsCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/constructor[@name='ConnectionParamsCache' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe ConnectionParamsCache (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (ConnectionParamsCache)) {
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

		static Delegate cb_getAcCdnSdkMinVersion;
#pragma warning disable 0169
		static Delegate GetGetAcCdnSdkMinVersionHandler ()
		{
			if (cb_getAcCdnSdkMinVersion == null)
				cb_getAcCdnSdkMinVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAcCdnSdkMinVersion);
			return cb_getAcCdnSdkMinVersion;
		}

		static IntPtr n_GetAcCdnSdkMinVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AcCdnSdkMinVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getAcCdnSdkMinVersion;
		public virtual unsafe string AcCdnSdkMinVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/method[@name='getAcCdnSdkMinVersion' and count(parameter)=0]"
			[Register ("getAcCdnSdkMinVersion", "()Ljava/lang/String;", "GetGetAcCdnSdkMinVersionHandler")]
			get {
				if (id_getAcCdnSdkMinVersion == IntPtr.Zero)
					id_getAcCdnSdkMinVersion = JNIEnv.GetMethodID (class_ref, "getAcCdnSdkMinVersion", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAcCdnSdkMinVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAcCdnSdkMinVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isAutoMessagesFeatureEnabled;
#pragma warning disable 0169
		static Delegate GetIsAutoMessagesFeatureEnabledHandler ()
		{
			if (cb_isAutoMessagesFeatureEnabled == null)
				cb_isAutoMessagesFeatureEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAutoMessagesFeatureEnabled);
			return cb_isAutoMessagesFeatureEnabled;
		}

		static bool n_IsAutoMessagesFeatureEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoMessagesFeatureEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setAutoMessagesFeatureEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetAutoMessagesFeatureEnabled_ZHandler ()
		{
			if (cb_setAutoMessagesFeatureEnabled_Z == null)
				cb_setAutoMessagesFeatureEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAutoMessagesFeatureEnabled_Z);
			return cb_setAutoMessagesFeatureEnabled_Z;
		}

		static void n_SetAutoMessagesFeatureEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AutoMessagesFeatureEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isAutoMessagesFeatureEnabled;
		static IntPtr id_setAutoMessagesFeatureEnabled_Z;
		public virtual unsafe bool AutoMessagesFeatureEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/method[@name='isAutoMessagesFeatureEnabled' and count(parameter)=0]"
			[Register ("isAutoMessagesFeatureEnabled", "()Z", "GetIsAutoMessagesFeatureEnabledHandler")]
			get {
				if (id_isAutoMessagesFeatureEnabled == IntPtr.Zero)
					id_isAutoMessagesFeatureEnabled = JNIEnv.GetMethodID (class_ref, "isAutoMessagesFeatureEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAutoMessagesFeatureEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAutoMessagesFeatureEnabled", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/method[@name='setAutoMessagesFeatureEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoMessagesFeatureEnabled", "(Z)V", "GetSetAutoMessagesFeatureEnabled_ZHandler")]
			set {
				if (id_setAutoMessagesFeatureEnabled_Z == IntPtr.Zero)
					id_setAutoMessagesFeatureEnabled_Z = JNIEnv.GetMethodID (class_ref, "setAutoMessagesFeatureEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAutoMessagesFeatureEnabled_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAutoMessagesFeatureEnabled", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isFullConnectionFlowRequired;
#pragma warning disable 0169
		static Delegate GetIsFullConnectionFlowRequiredHandler ()
		{
			if (cb_isFullConnectionFlowRequired == null)
				cb_isFullConnectionFlowRequired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFullConnectionFlowRequired);
			return cb_isFullConnectionFlowRequired;
		}

		static bool n_IsFullConnectionFlowRequired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FullConnectionFlowRequired;
		}
#pragma warning restore 0169

		static Delegate cb_setFullConnectionFlowRequired_Z;
#pragma warning disable 0169
		static Delegate GetSetFullConnectionFlowRequired_ZHandler ()
		{
			if (cb_setFullConnectionFlowRequired_Z == null)
				cb_setFullConnectionFlowRequired_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFullConnectionFlowRequired_Z);
			return cb_setFullConnectionFlowRequired_Z;
		}

		static void n_SetFullConnectionFlowRequired_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FullConnectionFlowRequired = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isFullConnectionFlowRequired;
		static IntPtr id_setFullConnectionFlowRequired_Z;
		public virtual unsafe bool FullConnectionFlowRequired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/method[@name='isFullConnectionFlowRequired' and count(parameter)=0]"
			[Register ("isFullConnectionFlowRequired", "()Z", "GetIsFullConnectionFlowRequiredHandler")]
			get {
				if (id_isFullConnectionFlowRequired == IntPtr.Zero)
					id_isFullConnectionFlowRequired = JNIEnv.GetMethodID (class_ref, "isFullConnectionFlowRequired", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFullConnectionFlowRequired);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFullConnectionFlowRequired", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/method[@name='setFullConnectionFlowRequired' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFullConnectionFlowRequired", "(Z)V", "GetSetFullConnectionFlowRequired_ZHandler")]
			set {
				if (id_setFullConnectionFlowRequired_Z == IntPtr.Zero)
					id_setFullConnectionFlowRequired_Z = JNIEnv.GetMethodID (class_ref, "setFullConnectionFlowRequired", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFullConnectionFlowRequired_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFullConnectionFlowRequired", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isCsdsFilled;
#pragma warning disable 0169
		static Delegate GetIsCsdsFilledHandler ()
		{
			if (cb_isCsdsFilled == null)
				cb_isCsdsFilled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCsdsFilled);
			return cb_isCsdsFilled;
		}

		static bool n_IsCsdsFilled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCsdsFilled;
		}
#pragma warning restore 0169

		static IntPtr id_isCsdsFilled;
		public virtual unsafe bool IsCsdsFilled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/method[@name='isCsdsFilled' and count(parameter)=0]"
			[Register ("isCsdsFilled", "()Z", "GetIsCsdsFilledHandler")]
			get {
				if (id_isCsdsFilled == IntPtr.Zero)
					id_isCsdsFilled = JNIEnv.GetMethodID (class_ref, "isCsdsFilled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCsdsFilled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCsdsFilled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isVersionsCompatible;
#pragma warning disable 0169
		static Delegate GetIsVersionsCompatibleHandler ()
		{
			if (cb_isVersionsCompatible == null)
				cb_isVersionsCompatible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsVersionsCompatible);
			return cb_isVersionsCompatible;
		}

		static bool n_IsVersionsCompatible (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsVersionsCompatible;
		}
#pragma warning restore 0169

		static IntPtr id_isVersionsCompatible;
		public virtual unsafe bool IsVersionsCompatible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/method[@name='isVersionsCompatible' and count(parameter)=0]"
			[Register ("isVersionsCompatible", "()Z", "GetIsVersionsCompatibleHandler")]
			get {
				if (id_isVersionsCompatible == IntPtr.Zero)
					id_isVersionsCompatible = JNIEnv.GetMethodID (class_ref, "isVersionsCompatible", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isVersionsCompatible);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isVersionsCompatible", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getLeCdnSdkMinVersion;
#pragma warning disable 0169
		static Delegate GetGetLeCdnSdkMinVersionHandler ()
		{
			if (cb_getLeCdnSdkMinVersion == null)
				cb_getLeCdnSdkMinVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLeCdnSdkMinVersion);
			return cb_getLeCdnSdkMinVersion;
		}

		static IntPtr n_GetLeCdnSdkMinVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LeCdnSdkMinVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getLeCdnSdkMinVersion;
		public virtual unsafe string LeCdnSdkMinVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/method[@name='getLeCdnSdkMinVersion' and count(parameter)=0]"
			[Register ("getLeCdnSdkMinVersion", "()Ljava/lang/String;", "GetGetLeCdnSdkMinVersionHandler")]
			get {
				if (id_getLeCdnSdkMinVersion == IntPtr.Zero)
					id_getLeCdnSdkMinVersion = JNIEnv.GetMethodID (class_ref, "getLeCdnSdkMinVersion", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLeCdnSdkMinVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLeCdnSdkMinVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getServiceDomain_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetServiceDomain_Ljava_lang_String_Handler ()
		{
			if (cb_getServiceDomain_Ljava_lang_String_ == null)
				cb_getServiceDomain_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetServiceDomain_Ljava_lang_String_);
			return cb_getServiceDomain_Ljava_lang_String_;
		}

		static IntPtr n_GetServiceDomain_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetServiceDomain (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getServiceDomain_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/method[@name='getServiceDomain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getServiceDomain", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetServiceDomain_Ljava_lang_String_Handler")]
		public virtual unsafe string GetServiceDomain (string p0)
		{
			if (id_getServiceDomain_Ljava_lang_String_ == IntPtr.Zero)
				id_getServiceDomain_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getServiceDomain", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServiceDomain_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServiceDomain", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateAcCdnVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateAcCdnVersion_Ljava_lang_String_Handler ()
		{
			if (cb_updateAcCdnVersion_Ljava_lang_String_ == null)
				cb_updateAcCdnVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_UpdateAcCdnVersion_Ljava_lang_String_);
			return cb_updateAcCdnVersion_Ljava_lang_String_;
		}

		static bool n_UpdateAcCdnVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateAcCdnVersion (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateAcCdnVersion_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/method[@name='updateAcCdnVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateAcCdnVersion", "(Ljava/lang/String;)Z", "GetUpdateAcCdnVersion_Ljava_lang_String_Handler")]
		public virtual unsafe bool UpdateAcCdnVersion (string p0)
		{
			if (id_updateAcCdnVersion_Ljava_lang_String_ == IntPtr.Zero)
				id_updateAcCdnVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateAcCdnVersion", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_updateAcCdnVersion_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateAcCdnVersion", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateCsdsDomains_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetUpdateCsdsDomains_Ljava_util_HashMap_Handler ()
		{
			if (cb_updateCsdsDomains_Ljava_util_HashMap_ == null)
				cb_updateCsdsDomains_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_UpdateCsdsDomains_Ljava_util_HashMap_);
			return cb_updateCsdsDomains_Ljava_util_HashMap_;
		}

		static bool n_UpdateCsdsDomains_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateCsdsDomains (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateCsdsDomains_Ljava_util_HashMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/method[@name='updateCsdsDomains' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("updateCsdsDomains", "(Ljava/util/HashMap;)Z", "GetUpdateCsdsDomains_Ljava_util_HashMap_Handler")]
		public virtual unsafe bool UpdateCsdsDomains (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_updateCsdsDomains_Ljava_util_HashMap_ == IntPtr.Zero)
				id_updateCsdsDomains_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "updateCsdsDomains", "(Ljava/util/HashMap;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_updateCsdsDomains_Ljava_util_HashMap_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateCsdsDomains", "(Ljava/util/HashMap;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateLeCdnVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateLeCdnVersion_Ljava_lang_String_Handler ()
		{
			if (cb_updateLeCdnVersion_Ljava_lang_String_ == null)
				cb_updateLeCdnVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_UpdateLeCdnVersion_Ljava_lang_String_);
			return cb_updateLeCdnVersion_Ljava_lang_String_;
		}

		static bool n_UpdateLeCdnVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateLeCdnVersion (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateLeCdnVersion_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionParamsCache']/method[@name='updateLeCdnVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateLeCdnVersion", "(Ljava/lang/String;)Z", "GetUpdateLeCdnVersion_Ljava_lang_String_Handler")]
		public virtual unsafe bool UpdateLeCdnVersion (string p0)
		{
			if (id_updateLeCdnVersion_Ljava_lang_String_ == IntPtr.Zero)
				id_updateLeCdnVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateLeCdnVersion", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_updateLeCdnVersion_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateLeCdnVersion", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
