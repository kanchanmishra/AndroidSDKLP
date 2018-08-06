using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Monitoring.Sdk.Callbacks {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.monitoring.sdk.callbacks']/interface[@name='SdeCallback']"
	[Register ("com/liveperson/monitoring/sdk/callbacks/SdeCallback", "", "Com.Liveperson.Monitoring.Sdk.Callbacks.ISdeCallbackInvoker")]
	public partial interface ISdeCallback : global::Com.Liveperson.Monitoring.Sdk.Callbacks.IMonitoringCallback {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.sdk.callbacks']/interface[@name='SdeCallback']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='com.liveperson.monitoring.sdk.callbacks.MonitoringErrorType'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("onError", "(Lcom/liveperson/monitoring/sdk/callbacks/MonitoringErrorType;Ljava/lang/Exception;)V", "GetOnError_Lcom_liveperson_monitoring_sdk_callbacks_MonitoringErrorType_Ljava_lang_Exception_Handler:Com.Liveperson.Monitoring.Sdk.Callbacks.ISdeCallbackInvoker, LP_Android_aar_Binding")]
		void OnError (global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType p0, global::Java.Lang.Exception p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.sdk.callbacks']/interface[@name='SdeCallback']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='com.liveperson.monitoring.sdk.responses.LPSdeResponse']]"
		[Register ("onSuccess", "(Lcom/liveperson/monitoring/sdk/responses/LPSdeResponse;)V", "GetOnSuccess_Lcom_liveperson_monitoring_sdk_responses_LPSdeResponse_Handler:Com.Liveperson.Monitoring.Sdk.Callbacks.ISdeCallbackInvoker, LP_Android_aar_Binding")]
		void OnSuccess (global::Com.Liveperson.Monitoring.Sdk.Responses.LPSdeResponse p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/monitoring/sdk/callbacks/SdeCallback", DoNotGenerateAcw=true)]
	internal class ISdeCallbackInvoker : global::Java.Lang.Object, ISdeCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/monitoring/sdk/callbacks/SdeCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISdeCallbackInvoker); }
		}

		IntPtr class_ref;

		public static ISdeCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISdeCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.monitoring.sdk.callbacks.SdeCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISdeCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Com.Liveperson.Monitoring.Sdk.Callbacks.ISdeCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Sdk.Callbacks.ISdeCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onSuccess_Lcom_liveperson_monitoring_sdk_responses_LPSdeResponse_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Lcom_liveperson_monitoring_sdk_responses_LPSdeResponse_Handler ()
		{
			if (cb_onSuccess_Lcom_liveperson_monitoring_sdk_responses_LPSdeResponse_ == null)
				cb_onSuccess_Lcom_liveperson_monitoring_sdk_responses_LPSdeResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Lcom_liveperson_monitoring_sdk_responses_LPSdeResponse_);
			return cb_onSuccess_Lcom_liveperson_monitoring_sdk_responses_LPSdeResponse_;
		}

		static void n_OnSuccess_Lcom_liveperson_monitoring_sdk_responses_LPSdeResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Monitoring.Sdk.Callbacks.ISdeCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Sdk.Callbacks.ISdeCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Monitoring.Sdk.Responses.LPSdeResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Sdk.Responses.LPSdeResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Lcom_liveperson_monitoring_sdk_responses_LPSdeResponse_;
		public unsafe void OnSuccess (global::Com.Liveperson.Monitoring.Sdk.Responses.LPSdeResponse p0)
		{
			if (id_onSuccess_Lcom_liveperson_monitoring_sdk_responses_LPSdeResponse_ == IntPtr.Zero)
				id_onSuccess_Lcom_liveperson_monitoring_sdk_responses_LPSdeResponse_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lcom/liveperson/monitoring/sdk/responses/LPSdeResponse;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Lcom_liveperson_monitoring_sdk_responses_LPSdeResponse_, __args);
		}

		static Delegate cb_onError_Lcom_liveperson_monitoring_sdk_callbacks_MonitoringErrorType_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_liveperson_monitoring_sdk_callbacks_MonitoringErrorType_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onError_Lcom_liveperson_monitoring_sdk_callbacks_MonitoringErrorType_Ljava_lang_Throwable_ == null)
				cb_onError_Lcom_liveperson_monitoring_sdk_callbacks_MonitoringErrorType_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnError_Lcom_liveperson_monitoring_sdk_callbacks_MonitoringErrorType_Ljava_lang_Throwable_);
			return cb_onError_Lcom_liveperson_monitoring_sdk_callbacks_MonitoringErrorType_Ljava_lang_Throwable_;
		}

		static void n_OnError_Lcom_liveperson_monitoring_sdk_callbacks_MonitoringErrorType_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Monitoring.Sdk.Callbacks.ISdeCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Sdk.Callbacks.ISdeCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_liveperson_monitoring_sdk_callbacks_MonitoringErrorType_Ljava_lang_Throwable_;
		public unsafe void OnError (global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType p0, global::Java.Lang.Object p1)
		{
			if (id_onError_Lcom_liveperson_monitoring_sdk_callbacks_MonitoringErrorType_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Lcom_liveperson_monitoring_sdk_callbacks_MonitoringErrorType_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/liveperson/monitoring/sdk/callbacks/MonitoringErrorType;Ljava/lang/Throwable;)V");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_liveperson_monitoring_sdk_callbacks_MonitoringErrorType_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onSuccess_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_lang_Object_Handler ()
		{
			if (cb_onSuccess_Ljava_lang_Object_ == null)
				cb_onSuccess_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Ljava_lang_Object_);
			return cb_onSuccess_Ljava_lang_Object_;
		}

		static void n_OnSuccess_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Monitoring.Sdk.Callbacks.ISdeCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Sdk.Callbacks.ISdeCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Ljava_lang_Object_;
		public unsafe void OnSuccess (global::Java.Lang.Object p0)
		{
			if (id_onSuccess_Ljava_lang_Object_ == IntPtr.Zero)
				id_onSuccess_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
