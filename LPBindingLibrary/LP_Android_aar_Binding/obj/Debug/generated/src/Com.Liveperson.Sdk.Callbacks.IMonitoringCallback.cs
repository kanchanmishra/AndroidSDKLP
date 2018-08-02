using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Sdk.Callbacks {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.sdk.callbacks']/interface[@name='MonitoringCallback']"
	[Register ("com/liveperson/sdk/callbacks/MonitoringCallback", "", "Com.Liveperson.Sdk.Callbacks.IMonitoringCallbackInvoker")]
	public partial interface IMonitoringCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.sdk.callbacks']/interface[@name='MonitoringCallback']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='com.liveperson.monitoring.sdk.callbacks.MonitoringErrorType'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("onError", "(Lcom/liveperson/monitoring/sdk/callbacks/MonitoringErrorType;Ljava/lang/Exception;)V", "GetOnError_Lcom_liveperson_monitoring_sdk_callbacks_MonitoringErrorType_Ljava_lang_Exception_Handler:Com.Liveperson.Sdk.Callbacks.IMonitoringCallbackInvoker, LP_Android_aar_Binding")]
		void OnError (global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType p0, global::Java.Lang.Exception p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.sdk.callbacks']/interface[@name='MonitoringCallback']/method[@name='onSuccess' and count(parameter)=0]"
		[Register ("onSuccess", "()V", "GetOnSuccessHandler:Com.Liveperson.Sdk.Callbacks.IMonitoringCallbackInvoker, LP_Android_aar_Binding")]
		void OnSuccess ();

	}

	[global::Android.Runtime.Register ("com/liveperson/sdk/callbacks/MonitoringCallback", DoNotGenerateAcw=true)]
	internal class IMonitoringCallbackInvoker : global::Java.Lang.Object, IMonitoringCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/sdk/callbacks/MonitoringCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMonitoringCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IMonitoringCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMonitoringCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.sdk.callbacks.MonitoringCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMonitoringCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onError_Lcom_liveperson_monitoring_sdk_callbacks_MonitoringErrorType_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_liveperson_monitoring_sdk_callbacks_MonitoringErrorType_Ljava_lang_Exception_Handler ()
		{
			if (cb_onError_Lcom_liveperson_monitoring_sdk_callbacks_MonitoringErrorType_Ljava_lang_Exception_ == null)
				cb_onError_Lcom_liveperson_monitoring_sdk_callbacks_MonitoringErrorType_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnError_Lcom_liveperson_monitoring_sdk_callbacks_MonitoringErrorType_Ljava_lang_Exception_);
			return cb_onError_Lcom_liveperson_monitoring_sdk_callbacks_MonitoringErrorType_Ljava_lang_Exception_;
		}

		static void n_OnError_Lcom_liveperson_monitoring_sdk_callbacks_MonitoringErrorType_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Sdk.Callbacks.IMonitoringCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Sdk.Callbacks.IMonitoringCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_liveperson_monitoring_sdk_callbacks_MonitoringErrorType_Ljava_lang_Exception_;
		public unsafe void OnError (global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType p0, global::Java.Lang.Exception p1)
		{
			if (id_onError_Lcom_liveperson_monitoring_sdk_callbacks_MonitoringErrorType_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onError_Lcom_liveperson_monitoring_sdk_callbacks_MonitoringErrorType_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/liveperson/monitoring/sdk/callbacks/MonitoringErrorType;Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_liveperson_monitoring_sdk_callbacks_MonitoringErrorType_Ljava_lang_Exception_, __args);
		}

		static Delegate cb_onSuccess;
#pragma warning disable 0169
		static Delegate GetOnSuccessHandler ()
		{
			if (cb_onSuccess == null)
				cb_onSuccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSuccess);
			return cb_onSuccess;
		}

		static void n_OnSuccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Sdk.Callbacks.IMonitoringCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Sdk.Callbacks.IMonitoringCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onSuccess;
		public unsafe void OnSuccess ()
		{
			if (id_onSuccess == IntPtr.Zero)
				id_onSuccess = JNIEnv.GetMethodID (class_ref, "onSuccess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess);
		}

	}

}
