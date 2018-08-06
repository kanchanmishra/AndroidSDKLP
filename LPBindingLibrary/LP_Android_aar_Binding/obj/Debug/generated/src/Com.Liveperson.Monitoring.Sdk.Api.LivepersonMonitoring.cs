using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Monitoring.Sdk.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.monitoring.sdk.api']/class[@name='LivepersonMonitoring']"
	[global::Android.Runtime.Register ("com/liveperson/monitoring/sdk/api/LivepersonMonitoring", DoNotGenerateAcw=true)]
	public partial class LivepersonMonitoring : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.monitoring.sdk.api']/class[@name='LivepersonMonitoring']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "LivepersonMonitoring";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/monitoring/sdk/api/LivepersonMonitoring", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LivepersonMonitoring); }
		}

		protected LivepersonMonitoring (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getSDKVersion;
		public static unsafe string SDKVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.sdk.api']/class[@name='LivepersonMonitoring']/method[@name='getSDKVersion' and count(parameter)=0]"
			[Register ("getSDKVersion", "()Ljava/lang/String;", "GetGetSDKVersionHandler")]
			get {
				if (id_getSDKVersion == IntPtr.Zero)
					id_getSDKVersion = JNIEnv.GetStaticMethodID (class_ref, "getSDKVersion", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSDKVersion), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getEngagement_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_sdk_callbacks_EngagementCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.sdk.api']/class[@name='LivepersonMonitoring']/method[@name='getEngagement' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List&lt;com.liveperson.monitoring.model.LPMonitoringIdentity&gt;'] and parameter[3][@type='com.liveperson.sdk.MonitoringParams'] and parameter[4][@type='com.liveperson.sdk.callbacks.EngagementCallback']]"
		[Register ("getEngagement", "(Landroid/content/Context;Ljava/util/List;Lcom/liveperson/sdk/MonitoringParams;Lcom/liveperson/sdk/callbacks/EngagementCallback;)V", "")]
		public static unsafe void GetEngagement (global::Android.Content.Context p0, global::System.Collections.Generic.IList<global::Com.Liveperson.Monitoring.Model.LPMonitoringIdentity> p1, global::Com.Liveperson.Sdk.MonitoringParams p2, global::Com.Liveperson.Sdk.Callbacks.IEngagementCallback p3)
		{
			if (id_getEngagement_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_sdk_callbacks_EngagementCallback_ == IntPtr.Zero)
				id_getEngagement_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_sdk_callbacks_EngagementCallback_ = JNIEnv.GetStaticMethodID (class_ref, "getEngagement", "(Landroid/content/Context;Ljava/util/List;Lcom/liveperson/sdk/MonitoringParams;Lcom/liveperson/sdk/callbacks/EngagementCallback;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Liveperson.Monitoring.Model.LPMonitoringIdentity>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getEngagement_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_sdk_callbacks_EngagementCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_sendSde_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_monitoring_sdk_callbacks_SdeCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.sdk.api']/class[@name='LivepersonMonitoring']/method[@name='sendSde' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List&lt;com.liveperson.monitoring.model.LPMonitoringIdentity&gt;'] and parameter[3][@type='com.liveperson.sdk.MonitoringParams'] and parameter[4][@type='com.liveperson.monitoring.sdk.callbacks.SdeCallback']]"
		[Register ("sendSde", "(Landroid/content/Context;Ljava/util/List;Lcom/liveperson/sdk/MonitoringParams;Lcom/liveperson/monitoring/sdk/callbacks/SdeCallback;)V", "")]
		public static unsafe void SendSde (global::Android.Content.Context p0, global::System.Collections.Generic.IList<global::Com.Liveperson.Monitoring.Model.LPMonitoringIdentity> p1, global::Com.Liveperson.Sdk.MonitoringParams p2, global::Com.Liveperson.Monitoring.Sdk.Callbacks.ISdeCallback p3)
		{
			if (id_sendSde_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_monitoring_sdk_callbacks_SdeCallback_ == IntPtr.Zero)
				id_sendSde_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_monitoring_sdk_callbacks_SdeCallback_ = JNIEnv.GetStaticMethodID (class_ref, "sendSde", "(Landroid/content/Context;Ljava/util/List;Lcom/liveperson/sdk/MonitoringParams;Lcom/liveperson/monitoring/sdk/callbacks/SdeCallback;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Liveperson.Monitoring.Model.LPMonitoringIdentity>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendSde_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_monitoring_sdk_callbacks_SdeCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
