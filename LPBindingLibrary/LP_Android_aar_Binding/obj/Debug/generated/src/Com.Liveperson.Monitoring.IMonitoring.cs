using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Monitoring {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.monitoring']/interface[@name='IMonitoring']"
	[Register ("com/liveperson/monitoring/IMonitoring", "", "Com.Liveperson.Monitoring.IMonitoringInvoker")]
	public partial interface IMonitoring : IJavaObject {

		bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring']/interface[@name='IMonitoring']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "GetIsInitializedHandler:Com.Liveperson.Monitoring.IMonitoringInvoker, LP_Android_aar_Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring']/interface[@name='IMonitoring']/method[@name='getEngagement' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List&lt;com.liveperson.monitoring.model.LPMonitoringIdentity&gt;'] and parameter[3][@type='com.liveperson.sdk.MonitoringParams'] and parameter[4][@type='com.liveperson.sdk.callbacks.EngagementCallback']]"
		[Register ("getEngagement", "(Landroid/content/Context;Ljava/util/List;Lcom/liveperson/sdk/MonitoringParams;Lcom/liveperson/sdk/callbacks/EngagementCallback;)V", "GetGetEngagement_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_sdk_callbacks_EngagementCallback_Handler:Com.Liveperson.Monitoring.IMonitoringInvoker, LP_Android_aar_Binding")]
		void GetEngagement (global::Android.Content.Context p0, global::System.Collections.Generic.IList<global::Com.Liveperson.Monitoring.Model.LPMonitoringIdentity> p1, global::Com.Liveperson.Sdk.MonitoringParams p2, global::Com.Liveperson.Sdk.Callbacks.IEngagementCallback p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring']/interface[@name='IMonitoring']/method[@name='logout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("logout", "(Landroid/content/Context;)Z", "GetLogout_Landroid_content_Context_Handler:Com.Liveperson.Monitoring.IMonitoringInvoker, LP_Android_aar_Binding")]
		bool Logout (global::Android.Content.Context p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring']/interface[@name='IMonitoring']/method[@name='sendSde' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List&lt;com.liveperson.monitoring.model.LPMonitoringIdentity&gt;'] and parameter[3][@type='com.liveperson.sdk.MonitoringParams'] and parameter[4][@type='com.liveperson.monitoring.sdk.callbacks.SdeCallback']]"
		[Register ("sendSde", "(Landroid/content/Context;Ljava/util/List;Lcom/liveperson/sdk/MonitoringParams;Lcom/liveperson/monitoring/sdk/callbacks/SdeCallback;)V", "GetSendSde_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_monitoring_sdk_callbacks_SdeCallback_Handler:Com.Liveperson.Monitoring.IMonitoringInvoker, LP_Android_aar_Binding")]
		void SendSde (global::Android.Content.Context p0, global::System.Collections.Generic.IList<global::Com.Liveperson.Monitoring.Model.LPMonitoringIdentity> p1, global::Com.Liveperson.Sdk.MonitoringParams p2, global::Com.Liveperson.Monitoring.Sdk.Callbacks.ISdeCallback p3);

	}

	[global::Android.Runtime.Register ("com/liveperson/monitoring/IMonitoring", DoNotGenerateAcw=true)]
	internal class IMonitoringInvoker : global::Java.Lang.Object, IMonitoring {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/monitoring/IMonitoring");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMonitoringInvoker); }
		}

		IntPtr class_ref;

		public static IMonitoring GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMonitoring> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.monitoring.IMonitoring"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMonitoringInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Liveperson.Monitoring.IMonitoring __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.IMonitoring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInitialized;
		}
#pragma warning restore 0169

		IntPtr id_isInitialized;
		public unsafe bool IsInitialized {
			get {
				if (id_isInitialized == IntPtr.Zero)
					id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInitialized);
			}
		}

		static Delegate cb_getEngagement_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_sdk_callbacks_EngagementCallback_;
#pragma warning disable 0169
		static Delegate GetGetEngagement_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_sdk_callbacks_EngagementCallback_Handler ()
		{
			if (cb_getEngagement_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_sdk_callbacks_EngagementCallback_ == null)
				cb_getEngagement_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_sdk_callbacks_EngagementCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetEngagement_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_sdk_callbacks_EngagementCallback_);
			return cb_getEngagement_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_sdk_callbacks_EngagementCallback_;
		}

		static void n_GetEngagement_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_sdk_callbacks_EngagementCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Liveperson.Monitoring.IMonitoring __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.IMonitoring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Com.Liveperson.Monitoring.Model.LPMonitoringIdentity>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Sdk.MonitoringParams p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Sdk.MonitoringParams> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Sdk.Callbacks.IEngagementCallback p3 = (global::Com.Liveperson.Sdk.Callbacks.IEngagementCallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Sdk.Callbacks.IEngagementCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.GetEngagement (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_getEngagement_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_sdk_callbacks_EngagementCallback_;
		public unsafe void GetEngagement (global::Android.Content.Context p0, global::System.Collections.Generic.IList<global::Com.Liveperson.Monitoring.Model.LPMonitoringIdentity> p1, global::Com.Liveperson.Sdk.MonitoringParams p2, global::Com.Liveperson.Sdk.Callbacks.IEngagementCallback p3)
		{
			if (id_getEngagement_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_sdk_callbacks_EngagementCallback_ == IntPtr.Zero)
				id_getEngagement_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_sdk_callbacks_EngagementCallback_ = JNIEnv.GetMethodID (class_ref, "getEngagement", "(Landroid/content/Context;Ljava/util/List;Lcom/liveperson/sdk/MonitoringParams;Lcom/liveperson/sdk/callbacks/EngagementCallback;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Liveperson.Monitoring.Model.LPMonitoringIdentity>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getEngagement_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_sdk_callbacks_EngagementCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Liveperson.Monitoring.IMonitoring __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.IMonitoring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Logout (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_logout_Landroid_content_Context_;
		public unsafe bool Logout (global::Android.Content.Context p0)
		{
			if (id_logout_Landroid_content_Context_ == IntPtr.Zero)
				id_logout_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "logout", "(Landroid/content/Context;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_logout_Landroid_content_Context_, __args);
			return __ret;
		}

		static Delegate cb_sendSde_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_monitoring_sdk_callbacks_SdeCallback_;
#pragma warning disable 0169
		static Delegate GetSendSde_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_monitoring_sdk_callbacks_SdeCallback_Handler ()
		{
			if (cb_sendSde_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_monitoring_sdk_callbacks_SdeCallback_ == null)
				cb_sendSde_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_monitoring_sdk_callbacks_SdeCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendSde_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_monitoring_sdk_callbacks_SdeCallback_);
			return cb_sendSde_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_monitoring_sdk_callbacks_SdeCallback_;
		}

		static void n_SendSde_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_monitoring_sdk_callbacks_SdeCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Liveperson.Monitoring.IMonitoring __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.IMonitoring> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Com.Liveperson.Monitoring.Model.LPMonitoringIdentity>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Sdk.MonitoringParams p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Sdk.MonitoringParams> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Monitoring.Sdk.Callbacks.ISdeCallback p3 = (global::Com.Liveperson.Monitoring.Sdk.Callbacks.ISdeCallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Sdk.Callbacks.ISdeCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SendSde (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_sendSde_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_monitoring_sdk_callbacks_SdeCallback_;
		public unsafe void SendSde (global::Android.Content.Context p0, global::System.Collections.Generic.IList<global::Com.Liveperson.Monitoring.Model.LPMonitoringIdentity> p1, global::Com.Liveperson.Sdk.MonitoringParams p2, global::Com.Liveperson.Monitoring.Sdk.Callbacks.ISdeCallback p3)
		{
			if (id_sendSde_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_monitoring_sdk_callbacks_SdeCallback_ == IntPtr.Zero)
				id_sendSde_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_monitoring_sdk_callbacks_SdeCallback_ = JNIEnv.GetMethodID (class_ref, "sendSde", "(Landroid/content/Context;Ljava/util/List;Lcom/liveperson/sdk/MonitoringParams;Lcom/liveperson/monitoring/sdk/callbacks/SdeCallback;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Liveperson.Monitoring.Model.LPMonitoringIdentity>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendSde_Landroid_content_Context_Ljava_util_List_Lcom_liveperson_sdk_MonitoringParams_Lcom_liveperson_monitoring_sdk_callbacks_SdeCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
