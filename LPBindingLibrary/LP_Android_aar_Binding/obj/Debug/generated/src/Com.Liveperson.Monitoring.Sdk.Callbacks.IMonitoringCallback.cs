using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Monitoring.Sdk.Callbacks {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.monitoring.sdk.callbacks']/interface[@name='IMonitoringCallback']"
	[Register ("com/liveperson/monitoring/sdk/callbacks/IMonitoringCallback", "", "Com.Liveperson.Monitoring.Sdk.Callbacks.IMonitoringCallbackInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "E extends java.lang.Throwable"})]
	public partial interface IMonitoringCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.sdk.callbacks']/interface[@name='IMonitoringCallback']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='com.liveperson.monitoring.sdk.callbacks.MonitoringErrorType'] and parameter[2][@type='E']]"
		[Register ("onError", "(Lcom/liveperson/monitoring/sdk/callbacks/MonitoringErrorType;Ljava/lang/Throwable;)V", "GetOnError_Lcom_liveperson_monitoring_sdk_callbacks_MonitoringErrorType_Ljava_lang_Throwable_Handler:Com.Liveperson.Monitoring.Sdk.Callbacks.IMonitoringCallbackInvoker, LP_Android_aar_Binding")]
		void OnError (global::Com.Liveperson.Monitoring.Sdk.Callbacks.MonitoringErrorType p0, global::Java.Lang.Object p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.sdk.callbacks']/interface[@name='IMonitoringCallback']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onSuccess", "(Ljava/lang/Object;)V", "GetOnSuccess_Ljava_lang_Object_Handler:Com.Liveperson.Monitoring.Sdk.Callbacks.IMonitoringCallbackInvoker, LP_Android_aar_Binding")]
		void OnSuccess (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/monitoring/sdk/callbacks/IMonitoringCallback", DoNotGenerateAcw=true)]
	internal class IMonitoringCallbackInvoker : global::Java.Lang.Object, IMonitoringCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/monitoring/sdk/callbacks/IMonitoringCallback");

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
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.monitoring.sdk.callbacks.IMonitoringCallback"));
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
			global::Com.Liveperson.Monitoring.Sdk.Callbacks.IMonitoringCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Sdk.Callbacks.IMonitoringCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Liveperson.Monitoring.Sdk.Callbacks.IMonitoringCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Sdk.Callbacks.IMonitoringCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
