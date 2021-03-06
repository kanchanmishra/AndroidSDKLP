using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Monitoring {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.monitoring']/class[@name='Monitoring']"
	[global::Android.Runtime.Register ("com/liveperson/monitoring/Monitoring", DoNotGenerateAcw=true)]
	public partial class Monitoring : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/monitoring/Monitoring", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Monitoring); }
		}

		protected Monitoring (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.monitoring']/class[@name='Monitoring']/constructor[@name='Monitoring' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Monitoring ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Monitoring)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_getApplicationContext;
		static IntPtr id_setApplicationContext_Landroid_content_Context_;
		public unsafe global::Android.Content.Context ApplicationContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring']/class[@name='Monitoring']/method[@name='getApplicationContext' and count(parameter)=0]"
			[Register ("getApplicationContext", "()Landroid/content/Context;", "GetGetApplicationContextHandler")]
			get {
				if (id_getApplicationContext == IntPtr.Zero)
					id_getApplicationContext = JNIEnv.GetMethodID (class_ref, "getApplicationContext", "()Landroid/content/Context;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApplicationContext), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring']/class[@name='Monitoring']/method[@name='setApplicationContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register ("setApplicationContext", "(Landroid/content/Context;)V", "GetSetApplicationContext_Landroid_content_Context_Handler")]
			set {
				if (id_setApplicationContext_Landroid_content_Context_ == IntPtr.Zero)
					id_setApplicationContext_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "setApplicationContext", "(Landroid/content/Context;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setApplicationContext_Landroid_content_Context_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getBrandId;
		static IntPtr id_setBrandId_Ljava_lang_String_;
		public unsafe string BrandId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring']/class[@name='Monitoring']/method[@name='getBrandId' and count(parameter)=0]"
			[Register ("getBrandId", "()Ljava/lang/String;", "GetGetBrandIdHandler")]
			get {
				if (id_getBrandId == IntPtr.Zero)
					id_getBrandId = JNIEnv.GetMethodID (class_ref, "getBrandId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBrandId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring']/class[@name='Monitoring']/method[@name='setBrandId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBrandId", "(Ljava/lang/String;)V", "GetSetBrandId_Ljava_lang_String_Handler")]
			set {
				if (id_setBrandId_Ljava_lang_String_ == IntPtr.Zero)
					id_setBrandId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBrandId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBrandId_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getInitialized;
		static IntPtr id_setInitialized_Z;
		public unsafe bool Initialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring']/class[@name='Monitoring']/method[@name='getInitialized' and count(parameter)=0]"
			[Register ("getInitialized", "()Z", "GetGetInitializedHandler")]
			get {
				if (id_getInitialized == IntPtr.Zero)
					id_getInitialized = JNIEnv.GetMethodID (class_ref, "getInitialized", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getInitialized);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring']/class[@name='Monitoring']/method[@name='setInitialized' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setInitialized", "(Z)V", "GetSetInitialized_ZHandler")]
			set {
				if (id_setInitialized_Z == IntPtr.Zero)
					id_setInitialized_Z = JNIEnv.GetMethodID (class_ref, "setInitialized", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInitialized_Z, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isInitialized;
#pragma warning disable 0169
		static Delegate GetIsInitializedHandler ()
		{
			if (cb_isInitialized == null)
				cb_isInitialized = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInitialized);
			return cb_isInitialized;
		}

		static bool n_IsInitialized (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Monitoring.Monitoring __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Monitoring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInitialized;
		}
#pragma warning restore 0169

		static IntPtr id_isInitialized;
		public virtual unsafe bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring']/class[@name='Monitoring']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "GetIsInitializedHandler")]
			get {
				if (id_isInitialized == IntPtr.Zero)
					id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInitialized);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInitialized", "()Z"));
				} finally {
				}
			}
		}

		static IntPtr id_getParamsCache;
		static IntPtr id_setParamsCache_Lcom_liveperson_monitoring_cache_MonitoringParamsCache_;
		public unsafe global::Com.Liveperson.Monitoring.Cache.MonitoringParamsCache ParamsCache {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring']/class[@name='Monitoring']/method[@name='getParamsCache' and count(parameter)=0]"
			[Register ("getParamsCache", "()Lcom/liveperson/monitoring/cache/MonitoringParamsCache;", "GetGetParamsCacheHandler")]
			get {
				if (id_getParamsCache == IntPtr.Zero)
					id_getParamsCache = JNIEnv.GetMethodID (class_ref, "getParamsCache", "()Lcom/liveperson/monitoring/cache/MonitoringParamsCache;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Cache.MonitoringParamsCache> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParamsCache), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring']/class[@name='Monitoring']/method[@name='setParamsCache' and count(parameter)=1 and parameter[1][@type='com.liveperson.monitoring.cache.MonitoringParamsCache']]"
			[Register ("setParamsCache", "(Lcom/liveperson/monitoring/cache/MonitoringParamsCache;)V", "GetSetParamsCache_Lcom_liveperson_monitoring_cache_MonitoringParamsCache_Handler")]
			set {
				if (id_setParamsCache_Lcom_liveperson_monitoring_cache_MonitoringParamsCache_ == IntPtr.Zero)
					id_setParamsCache_Lcom_liveperson_monitoring_cache_MonitoringParamsCache_ = JNIEnv.GetMethodID (class_ref, "setParamsCache", "(Lcom/liveperson/monitoring/cache/MonitoringParamsCache;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setParamsCache_Lcom_liveperson_monitoring_cache_MonitoringParamsCache_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_init_Lcom_liveperson_sdk_MonitoringInternalInitParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring']/class[@name='Monitoring']/method[@name='init' and count(parameter)=1 and parameter[1][@type='com.liveperson.sdk.MonitoringInternalInitParams']]"
		[Register ("init", "(Lcom/liveperson/sdk/MonitoringInternalInitParams;)Z", "")]
		public unsafe bool Init (global::Com.Liveperson.Sdk.MonitoringInternalInitParams p0)
		{
			if (id_init_Lcom_liveperson_sdk_MonitoringInternalInitParams_ == IntPtr.Zero)
				id_init_Lcom_liveperson_sdk_MonitoringInternalInitParams_ = JNIEnv.GetMethodID (class_ref, "init", "(Lcom/liveperson/sdk/MonitoringInternalInitParams;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_init_Lcom_liveperson_sdk_MonitoringInternalInitParams_, __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_logout_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetLogout_Landroid_content_Context_Handler ()
		{
			if (cb_logout_Landroid_content_Context_ == null)
				cb_logout_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Logout_Landroid_content_Context_);
			return cb_logout_Landroid_content_Context_;
		}

		static bool n_Logout_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Monitoring.Monitoring __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Monitoring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Logout (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_logout_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring']/class[@name='Monitoring']/method[@name='logout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("logout", "(Landroid/content/Context;)Z", "GetLogout_Landroid_content_Context_Handler")]
		public virtual unsafe bool Logout (global::Android.Content.Context p0)
		{
			if (id_logout_Landroid_content_Context_ == IntPtr.Zero)
				id_logout_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "logout", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_logout_Landroid_content_Context_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logout", "(Landroid/content/Context;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_postOnMainThread_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring']/class[@name='Monitoring']/method[@name='postOnMainThread' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("postOnMainThread", "(Ljava/lang/Runnable;)V", "")]
		public unsafe void PostOnMainThread (global::Java.Lang.IRunnable p0)
		{
			if (id_postOnMainThread_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_postOnMainThread_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "postOnMainThread", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_postOnMainThread_Ljava_lang_Runnable_, __args);
			} finally {
			}
		}

	}
}
