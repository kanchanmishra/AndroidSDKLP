using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Monitoring.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']"
	[global::Android.Runtime.Register ("com/liveperson/monitoring/cache/MonitoringParamsCache", DoNotGenerateAcw=true)]
	public partial class MonitoringParamsCache : global::Java.Lang.Object, global::Com.Liveperson.Monitoring.Cache.IParamsCache, global::Com.Liveperson.Monitoring.Utils.IClearable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/monitoring/cache/MonitoringParamsCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MonitoringParamsCache); }
		}

		protected MonitoringParamsCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/constructor[@name='MonitoringParamsCache' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe MonitoringParamsCache (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (MonitoringParamsCache)) {
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

		static IntPtr id_getAPP_INSTALL_ID_KEY;
		public unsafe string APP_INSTALL_ID_KEY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='getAPP_INSTALL_ID_KEY' and count(parameter)=0]"
			[Register ("getAPP_INSTALL_ID_KEY", "()Ljava/lang/String;", "GetGetAPP_INSTALL_ID_KEYHandler")]
			get {
				if (id_getAPP_INSTALL_ID_KEY == IntPtr.Zero)
					id_getAPP_INSTALL_ID_KEY = JNIEnv.GetMethodID (class_ref, "getAPP_INSTALL_ID_KEY", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAPP_INSTALL_ID_KEY), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getAppInstallId;
		static IntPtr id_setAppInstallId_Ljava_lang_String_;
		public unsafe string AppInstallId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='getAppInstallId' and count(parameter)=0]"
			[Register ("getAppInstallId", "()Ljava/lang/String;", "GetGetAppInstallIdHandler")]
			get {
				if (id_getAppInstallId == IntPtr.Zero)
					id_getAppInstallId = JNIEnv.GetMethodID (class_ref, "getAppInstallId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppInstallId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='setAppInstallId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppInstallId", "(Ljava/lang/String;)V", "GetSetAppInstallId_Ljava_lang_String_Handler")]
			set {
				if (id_setAppInstallId_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppInstallId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppInstallId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppInstallId_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getBrandId;
		public unsafe string BrandId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='getBrandId' and count(parameter)=0]"
			[Register ("getBrandId", "()Ljava/lang/String;", "GetGetBrandIdHandler")]
			get {
				if (id_getBrandId == IntPtr.Zero)
					id_getBrandId = JNIEnv.GetMethodID (class_ref, "getBrandId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBrandId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCSDS_IDP_DOMAIN_KEY;
		public unsafe string CSDS_IDP_DOMAIN_KEY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='getCSDS_IDP_DOMAIN_KEY' and count(parameter)=0]"
			[Register ("getCSDS_IDP_DOMAIN_KEY", "()Ljava/lang/String;", "GetGetCSDS_IDP_DOMAIN_KEYHandler")]
			get {
				if (id_getCSDS_IDP_DOMAIN_KEY == IntPtr.Zero)
					id_getCSDS_IDP_DOMAIN_KEY = JNIEnv.GetMethodID (class_ref, "getCSDS_IDP_DOMAIN_KEY", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCSDS_IDP_DOMAIN_KEY), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCSDS_LOGGOS_DOMAIN_KEY;
		public unsafe string CSDS_LOGGOS_DOMAIN_KEY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='getCSDS_LOGGOS_DOMAIN_KEY' and count(parameter)=0]"
			[Register ("getCSDS_LOGGOS_DOMAIN_KEY", "()Ljava/lang/String;", "GetGetCSDS_LOGGOS_DOMAIN_KEYHandler")]
			get {
				if (id_getCSDS_LOGGOS_DOMAIN_KEY == IntPtr.Zero)
					id_getCSDS_LOGGOS_DOMAIN_KEY = JNIEnv.GetMethodID (class_ref, "getCSDS_LOGGOS_DOMAIN_KEY", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCSDS_LOGGOS_DOMAIN_KEY), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCSDS_SHARK_DOMAIN_KEY;
		public unsafe string CSDS_SHARK_DOMAIN_KEY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='getCSDS_SHARK_DOMAIN_KEY' and count(parameter)=0]"
			[Register ("getCSDS_SHARK_DOMAIN_KEY", "()Ljava/lang/String;", "GetGetCSDS_SHARK_DOMAIN_KEYHandler")]
			get {
				if (id_getCSDS_SHARK_DOMAIN_KEY == IntPtr.Zero)
					id_getCSDS_SHARK_DOMAIN_KEY = JNIEnv.GetMethodID (class_ref, "getCSDS_SHARK_DOMAIN_KEY", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCSDS_SHARK_DOMAIN_KEY), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCsdsMainDomain;
		static IntPtr id_setCsdsMainDomain_Ljava_lang_String_;
		public unsafe string CsdsMainDomain {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='getCsdsMainDomain' and count(parameter)=0]"
			[Register ("getCsdsMainDomain", "()Ljava/lang/String;", "GetGetCsdsMainDomainHandler")]
			get {
				if (id_getCsdsMainDomain == IntPtr.Zero)
					id_getCsdsMainDomain = JNIEnv.GetMethodID (class_ref, "getCsdsMainDomain", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCsdsMainDomain), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='setCsdsMainDomain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCsdsMainDomain", "(Ljava/lang/String;)V", "GetSetCsdsMainDomain_Ljava_lang_String_Handler")]
			set {
				if (id_setCsdsMainDomain_Ljava_lang_String_ == IntPtr.Zero)
					id_setCsdsMainDomain_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCsdsMainDomain", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCsdsMainDomain_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getIdpDomain;
		static IntPtr id_setIdpDomain_Ljava_lang_String_;
		public unsafe string IdpDomain {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='getIdpDomain' and count(parameter)=0]"
			[Register ("getIdpDomain", "()Ljava/lang/String;", "GetGetIdpDomainHandler")]
			get {
				if (id_getIdpDomain == IntPtr.Zero)
					id_getIdpDomain = JNIEnv.GetMethodID (class_ref, "getIdpDomain", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIdpDomain), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='setIdpDomain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setIdpDomain", "(Ljava/lang/String;)V", "GetSetIdpDomain_Ljava_lang_String_Handler")]
			set {
				if (id_setIdpDomain_Ljava_lang_String_ == IntPtr.Zero)
					id_setIdpDomain_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setIdpDomain", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIdpDomain_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Liveperson.Monitoring.Cache.MonitoringParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Cache.MonitoringParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCsdsFilled;
		}
#pragma warning restore 0169

		static IntPtr id_isCsdsFilled;
		public virtual unsafe bool IsCsdsFilled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='isCsdsFilled' and count(parameter)=0]"
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

		static IntPtr id_getLAST_CSDS_UPDATE_TIMESTAMP_KEY;
		public unsafe string LAST_CSDS_UPDATE_TIMESTAMP_KEY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='getLAST_CSDS_UPDATE_TIMESTAMP_KEY' and count(parameter)=0]"
			[Register ("getLAST_CSDS_UPDATE_TIMESTAMP_KEY", "()Ljava/lang/String;", "GetGetLAST_CSDS_UPDATE_TIMESTAMP_KEYHandler")]
			get {
				if (id_getLAST_CSDS_UPDATE_TIMESTAMP_KEY == IntPtr.Zero)
					id_getLAST_CSDS_UPDATE_TIMESTAMP_KEY = JNIEnv.GetMethodID (class_ref, "getLAST_CSDS_UPDATE_TIMESTAMP_KEY", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLAST_CSDS_UPDATE_TIMESTAMP_KEY), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getLastCsdsUpdateTimestamp;
		static IntPtr id_setLastCsdsUpdateTimestamp_J;
		public unsafe long LastCsdsUpdateTimestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='getLastCsdsUpdateTimestamp' and count(parameter)=0]"
			[Register ("getLastCsdsUpdateTimestamp", "()J", "GetGetLastCsdsUpdateTimestampHandler")]
			get {
				if (id_getLastCsdsUpdateTimestamp == IntPtr.Zero)
					id_getLastCsdsUpdateTimestamp = JNIEnv.GetMethodID (class_ref, "getLastCsdsUpdateTimestamp", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLastCsdsUpdateTimestamp);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='setLastCsdsUpdateTimestamp' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setLastCsdsUpdateTimestamp", "(J)V", "GetSetLastCsdsUpdateTimestamp_JHandler")]
			set {
				if (id_setLastCsdsUpdateTimestamp_J == IntPtr.Zero)
					id_setLastCsdsUpdateTimestamp_J = JNIEnv.GetMethodID (class_ref, "setLastCsdsUpdateTimestamp", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastCsdsUpdateTimestamp_J, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getLoggosDomain;
		static IntPtr id_setLoggosDomain_Ljava_lang_String_;
		public unsafe string LoggosDomain {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='getLoggosDomain' and count(parameter)=0]"
			[Register ("getLoggosDomain", "()Ljava/lang/String;", "GetGetLoggosDomainHandler")]
			get {
				if (id_getLoggosDomain == IntPtr.Zero)
					id_getLoggosDomain = JNIEnv.GetMethodID (class_ref, "getLoggosDomain", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLoggosDomain), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='setLoggosDomain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLoggosDomain", "(Ljava/lang/String;)V", "GetSetLoggosDomain_Ljava_lang_String_Handler")]
			set {
				if (id_setLoggosDomain_Ljava_lang_String_ == IntPtr.Zero)
					id_setLoggosDomain_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLoggosDomain", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLoggosDomain_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getSDK_INFO_SEND_KEY;
		public unsafe string SDK_INFO_SEND_KEY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='getSDK_INFO_SEND_KEY' and count(parameter)=0]"
			[Register ("getSDK_INFO_SEND_KEY", "()Ljava/lang/String;", "GetGetSDK_INFO_SEND_KEYHandler")]
			get {
				if (id_getSDK_INFO_SEND_KEY == IntPtr.Zero)
					id_getSDK_INFO_SEND_KEY = JNIEnv.GetMethodID (class_ref, "getSDK_INFO_SEND_KEY", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSDK_INFO_SEND_KEY), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSESSION_ID_KEY;
		public unsafe string SESSION_ID_KEY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='getSESSION_ID_KEY' and count(parameter)=0]"
			[Register ("getSESSION_ID_KEY", "()Ljava/lang/String;", "GetGetSESSION_ID_KEYHandler")]
			get {
				if (id_getSESSION_ID_KEY == IntPtr.Zero)
					id_getSESSION_ID_KEY = JNIEnv.GetMethodID (class_ref, "getSESSION_ID_KEY", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSESSION_ID_KEY), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSdkInfoSent;
		static IntPtr id_setSdkInfoSent_Z;
		public unsafe bool SdkInfoSent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='getSdkInfoSent' and count(parameter)=0]"
			[Register ("getSdkInfoSent", "()Z", "GetGetSdkInfoSentHandler")]
			get {
				if (id_getSdkInfoSent == IntPtr.Zero)
					id_getSdkInfoSent = JNIEnv.GetMethodID (class_ref, "getSdkInfoSent", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getSdkInfoSent);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='setSdkInfoSent' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSdkInfoSent", "(Z)V", "GetSetSdkInfoSent_ZHandler")]
			set {
				if (id_setSdkInfoSent_Z == IntPtr.Zero)
					id_setSdkInfoSent_Z = JNIEnv.GetMethodID (class_ref, "setSdkInfoSent", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSdkInfoSent_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getSessionId;
		static IntPtr id_setSessionId_Ljava_lang_String_;
		public unsafe string SessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='getSessionId' and count(parameter)=0]"
			[Register ("getSessionId", "()Ljava/lang/String;", "GetGetSessionIdHandler")]
			get {
				if (id_getSessionId == IntPtr.Zero)
					id_getSessionId = JNIEnv.GetMethodID (class_ref, "getSessionId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSessionId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='setSessionId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSessionId", "(Ljava/lang/String;)V", "GetSetSessionId_Ljava_lang_String_Handler")]
			set {
				if (id_setSessionId_Ljava_lang_String_ == IntPtr.Zero)
					id_setSessionId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSessionId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSessionId_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getSharkDomain;
		static IntPtr id_setSharkDomain_Ljava_lang_String_;
		public unsafe string SharkDomain {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='getSharkDomain' and count(parameter)=0]"
			[Register ("getSharkDomain", "()Ljava/lang/String;", "GetGetSharkDomainHandler")]
			get {
				if (id_getSharkDomain == IntPtr.Zero)
					id_getSharkDomain = JNIEnv.GetMethodID (class_ref, "getSharkDomain", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSharkDomain), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='setSharkDomain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSharkDomain", "(Ljava/lang/String;)V", "GetSetSharkDomain_Ljava_lang_String_Handler")]
			set {
				if (id_setSharkDomain_Ljava_lang_String_ == IntPtr.Zero)
					id_setSharkDomain_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSharkDomain", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSharkDomain_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getVISITOR_ID_KEY;
		public unsafe string VISITOR_ID_KEY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='getVISITOR_ID_KEY' and count(parameter)=0]"
			[Register ("getVISITOR_ID_KEY", "()Ljava/lang/String;", "GetGetVISITOR_ID_KEYHandler")]
			get {
				if (id_getVISITOR_ID_KEY == IntPtr.Zero)
					id_getVISITOR_ID_KEY = JNIEnv.GetMethodID (class_ref, "getVISITOR_ID_KEY", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVISITOR_ID_KEY), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getVisitorId;
		static IntPtr id_setVisitorId_Ljava_lang_String_;
		public unsafe string VisitorId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='getVisitorId' and count(parameter)=0]"
			[Register ("getVisitorId", "()Ljava/lang/String;", "GetGetVisitorIdHandler")]
			get {
				if (id_getVisitorId == IntPtr.Zero)
					id_getVisitorId = JNIEnv.GetMethodID (class_ref, "getVisitorId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVisitorId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='setVisitorId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setVisitorId", "(Ljava/lang/String;)V", "GetSetVisitorId_Ljava_lang_String_Handler")]
			set {
				if (id_setVisitorId_Ljava_lang_String_ == IntPtr.Zero)
					id_setVisitorId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setVisitorId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVisitorId_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
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
			global::Com.Liveperson.Monitoring.Cache.MonitoringParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Cache.MonitoringParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='clear' and count(parameter)=0]"
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
			global::Com.Liveperson.Monitoring.Cache.MonitoringParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Cache.MonitoringParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetServiceDomain (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getServiceDomain_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='getServiceDomain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Liveperson.Monitoring.Cache.MonitoringParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Cache.MonitoringParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateCsdsDomains (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateCsdsDomains_Ljava_util_HashMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/class[@name='MonitoringParamsCache']/method[@name='updateCsdsDomains' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
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

	}
}
