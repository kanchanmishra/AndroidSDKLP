using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Monitoring {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.monitoring']/class[@name='MonitoringFactory']"
	[global::Android.Runtime.Register ("com/liveperson/monitoring/MonitoringFactory", DoNotGenerateAcw=true)]
	public sealed partial class MonitoringFactory : global::Java.Lang.Object, global::Com.Liveperson.Monitoring.IMonitoring {


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

		static IntPtr id_getEngagement_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_sdk_callbacks_EngagementCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring']/class[@name='MonitoringFactory']/method[@name='getEngagement' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List&lt;com.liveperson.monitoring.model.LPMonitoringIdentity&gt;'] and parameter[3][@type='com.liveperson.sdk.MonitoringParams'] and parameter[4][@type='com.liveperson.sdk.callbacks.EngagementCallback']]"
		[Register ("getEngagement", "(Landroid/content/Context;Ljava/util/List;Lcom/liveperson/sdk/MonitoringParams;Lcom/liveperson/sdk/callbacks/EngagementCallback;)V", "")]
		public unsafe void GetEngagement (global::Android.Content.Context p0, global::System.Collections.Generic.IList<global::Com.Liveperson.Monitoring.Model.LPMonitoringIdentity> p1, global::Com.Liveperson.Sdk.MonitoringParams p2, global::Com.Liveperson.Sdk.Callbacks.IEngagementCallback p3)
		{
			if (id_getEngagement_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_sdk_callbacks_EngagementCallback_ == IntPtr.Zero)
				id_getEngagement_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_sdk_callbacks_EngagementCallback_ = JNIEnv.GetMethodID (class_ref, "getEngagement", "(Landroid/content/Context;Ljava/util/List;Lcom/liveperson/sdk/MonitoringParams;Lcom/liveperson/sdk/callbacks/EngagementCallback;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Liveperson.Monitoring.Model.LPMonitoringIdentity>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getEngagement_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_sdk_callbacks_EngagementCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
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

		static IntPtr id_sendSde_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_monitoring_sdk_callbacks_SdeCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring']/class[@name='MonitoringFactory']/method[@name='sendSde' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List&lt;com.liveperson.monitoring.model.LPMonitoringIdentity&gt;'] and parameter[3][@type='com.liveperson.sdk.MonitoringParams'] and parameter[4][@type='com.liveperson.monitoring.sdk.callbacks.SdeCallback']]"
		[Register ("sendSde", "(Landroid/content/Context;Ljava/util/List;Lcom/liveperson/sdk/MonitoringParams;Lcom/liveperson/monitoring/sdk/callbacks/SdeCallback;)V", "")]
		public unsafe void SendSde (global::Android.Content.Context p0, global::System.Collections.Generic.IList<global::Com.Liveperson.Monitoring.Model.LPMonitoringIdentity> p1, global::Com.Liveperson.Sdk.MonitoringParams p2, global::Com.Liveperson.Monitoring.Sdk.Callbacks.ISdeCallback p3)
		{
			if (id_sendSde_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_monitoring_sdk_callbacks_SdeCallback_ == IntPtr.Zero)
				id_sendSde_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_monitoring_sdk_callbacks_SdeCallback_ = JNIEnv.GetMethodID (class_ref, "sendSde", "(Landroid/content/Context;Ljava/util/List;Lcom/liveperson/sdk/MonitoringParams;Lcom/liveperson/monitoring/sdk/callbacks/SdeCallback;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Liveperson.Monitoring.Model.LPMonitoringIdentity>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendSde_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_monitoring_sdk_callbacks_SdeCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
