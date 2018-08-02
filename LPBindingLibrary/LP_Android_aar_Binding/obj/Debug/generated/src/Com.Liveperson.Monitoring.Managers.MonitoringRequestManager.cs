using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Monitoring.Managers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.monitoring.managers']/class[@name='MonitoringRequestManager']"
	[global::Android.Runtime.Register ("com/liveperson/monitoring/managers/MonitoringRequestManager", DoNotGenerateAcw=true)]
	public sealed partial class MonitoringRequestManager : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/monitoring/managers/MonitoringRequestManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MonitoringRequestManager); }
		}

		internal MonitoringRequestManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_liveperson_monitoring_cache_MonitoringParamsCache_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.monitoring.managers']/class[@name='MonitoringRequestManager']/constructor[@name='MonitoringRequestManager' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.monitoring.cache.MonitoringParamsCache']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/liveperson/monitoring/cache/MonitoringParamsCache;)V", "")]
		public unsafe MonitoringRequestManager (string p0, global::Com.Liveperson.Monitoring.Cache.MonitoringParamsCache p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MonitoringRequestManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Lcom/liveperson/monitoring/cache/MonitoringParamsCache;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lcom/liveperson/monitoring/cache/MonitoringParamsCache;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_liveperson_monitoring_cache_MonitoringParamsCache_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_liveperson_monitoring_cache_MonitoringParamsCache_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/liveperson/monitoring/cache/MonitoringParamsCache;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_liveperson_monitoring_cache_MonitoringParamsCache_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_liveperson_monitoring_cache_MonitoringParamsCache_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getBrandId;
		public unsafe string BrandId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.managers']/class[@name='MonitoringRequestManager']/method[@name='getBrandId' and count(parameter)=0]"
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

		static IntPtr id_getParamsCache;
		public unsafe global::Com.Liveperson.Monitoring.Cache.MonitoringParamsCache ParamsCache {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.managers']/class[@name='MonitoringRequestManager']/method[@name='getParamsCache' and count(parameter)=0]"
			[Register ("getParamsCache", "()Lcom/liveperson/monitoring/cache/MonitoringParamsCache;", "GetGetParamsCacheHandler")]
			get {
				if (id_getParamsCache == IntPtr.Zero)
					id_getParamsCache = JNIEnv.GetMethodID (class_ref, "getParamsCache", "()Lcom/liveperson/monitoring/cache/MonitoringParamsCache;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Cache.MonitoringParamsCache> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParamsCache), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getTwentyFourHoursInMillis;
		public unsafe int TwentyFourHoursInMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.managers']/class[@name='MonitoringRequestManager']/method[@name='getTwentyFourHoursInMillis' and count(parameter)=0]"
			[Register ("getTwentyFourHoursInMillis", "()I", "GetGetTwentyFourHoursInMillisHandler")]
			get {
				if (id_getTwentyFourHoursInMillis == IntPtr.Zero)
					id_getTwentyFourHoursInMillis = JNIEnv.GetMethodID (class_ref, "getTwentyFourHoursInMillis", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTwentyFourHoursInMillis);
				} finally {
				}
			}
		}

	}
}
