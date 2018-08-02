using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Monitoring {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.monitoring']/class[@name='MonitoringFactory']"
	[global::Android.Runtime.Register ("com/liveperson/monitoring/MonitoringFactory", DoNotGenerateAcw=true)]
	public sealed partial class MonitoringFactory : global::Java.Lang.Object {


		static IntPtr INSTANCE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.monitoring']/class[@name='MonitoringFactory']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Liveperson.Monitoring.MonitoringFactory Instance {
			get {
				if (INSTANCE_jfieldId == IntPtr.Zero)
					INSTANCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTANCE", "Lcom/liveperson/monitoring/MonitoringFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSTANCE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.MonitoringFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/monitoring/MonitoringFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MonitoringFactory); }
		}

		internal MonitoringFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isInitialized;
		public unsafe bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring']/class[@name='MonitoringFactory']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "GetIsInitializedHandler")]
			get {
				if (id_isInitialized == IntPtr.Zero)
					id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInitialized);
				} finally {
				}
			}
		}

		static IntPtr id_getMonitoring;
		public unsafe global::Com.Liveperson.Monitoring.Monitoring Monitoring {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring']/class[@name='MonitoringFactory']/method[@name='getMonitoring' and count(parameter)=0]"
			[Register ("getMonitoring", "()Lcom/liveperson/monitoring/Monitoring;", "GetGetMonitoringHandler")]
			get {
				if (id_getMonitoring == IntPtr.Zero)
					id_getMonitoring = JNIEnv.GetMethodID (class_ref, "getMonitoring", "()Lcom/liveperson/monitoring/Monitoring;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Monitoring> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMonitoring), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_initMonitoring_Lcom_liveperson_sdk_MonitoringInternalInitParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring']/class[@name='MonitoringFactory']/method[@name='initMonitoring' and count(parameter)=1 and parameter[1][@type='com.liveperson.sdk.MonitoringInternalInitParams']]"
		[Register ("initMonitoring", "(Lcom/liveperson/sdk/MonitoringInternalInitParams;)Z", "")]
		public unsafe bool InitMonitoring (global::Com.Liveperson.Sdk.MonitoringInternalInitParams p0)
		{
			if (id_initMonitoring_Lcom_liveperson_sdk_MonitoringInternalInitParams_ == IntPtr.Zero)
				id_initMonitoring_Lcom_liveperson_sdk_MonitoringInternalInitParams_ = JNIEnv.GetMethodID (class_ref, "initMonitoring", "(Lcom/liveperson/sdk/MonitoringInternalInitParams;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_initMonitoring_Lcom_liveperson_sdk_MonitoringInternalInitParams_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_logout_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring']/class[@name='MonitoringFactory']/method[@name='logout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("logout", "(Landroid/content/Context;)Z", "")]
		public unsafe bool Logout (global::Android.Content.Context p0)
		{
			if (id_logout_Landroid_content_Context_ == IntPtr.Zero)
				id_logout_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "logout", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_logout_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
