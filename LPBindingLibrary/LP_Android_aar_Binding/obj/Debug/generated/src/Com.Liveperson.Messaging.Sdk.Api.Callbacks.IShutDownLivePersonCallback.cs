using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Sdk.Api.Callbacks {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.messaging.sdk.api.callbacks']/interface[@name='ShutDownLivePersonCallback']"
	[Register ("com/liveperson/messaging/sdk/api/callbacks/ShutDownLivePersonCallback", "", "Com.Liveperson.Messaging.Sdk.Api.Callbacks.IShutDownLivePersonCallbackInvoker")]
	public partial interface IShutDownLivePersonCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api.callbacks']/interface[@name='ShutDownLivePersonCallback']/method[@name='onShutdownFailed' and count(parameter)=0]"
		[Register ("onShutdownFailed", "()V", "GetOnShutdownFailedHandler:Com.Liveperson.Messaging.Sdk.Api.Callbacks.IShutDownLivePersonCallbackInvoker, LP_Android_aar_Binding")]
		void OnShutdownFailed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api.callbacks']/interface[@name='ShutDownLivePersonCallback']/method[@name='onShutdownSucceed' and count(parameter)=0]"
		[Register ("onShutdownSucceed", "()V", "GetOnShutdownSucceedHandler:Com.Liveperson.Messaging.Sdk.Api.Callbacks.IShutDownLivePersonCallbackInvoker, LP_Android_aar_Binding")]
		void OnShutdownSucceed ();

	}

	[global::Android.Runtime.Register ("com/liveperson/messaging/sdk/api/callbacks/ShutDownLivePersonCallback", DoNotGenerateAcw=true)]
	internal class IShutDownLivePersonCallbackInvoker : global::Java.Lang.Object, IShutDownLivePersonCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/messaging/sdk/api/callbacks/ShutDownLivePersonCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IShutDownLivePersonCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IShutDownLivePersonCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IShutDownLivePersonCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.messaging.sdk.api.callbacks.ShutDownLivePersonCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IShutDownLivePersonCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onShutdownFailed;
#pragma warning disable 0169
		static Delegate GetOnShutdownFailedHandler ()
		{
			if (cb_onShutdownFailed == null)
				cb_onShutdownFailed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnShutdownFailed);
			return cb_onShutdownFailed;
		}

		static void n_OnShutdownFailed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Sdk.Api.Callbacks.IShutDownLivePersonCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Sdk.Api.Callbacks.IShutDownLivePersonCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnShutdownFailed ();
		}
#pragma warning restore 0169

		IntPtr id_onShutdownFailed;
		public unsafe void OnShutdownFailed ()
		{
			if (id_onShutdownFailed == IntPtr.Zero)
				id_onShutdownFailed = JNIEnv.GetMethodID (class_ref, "onShutdownFailed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onShutdownFailed);
		}

		static Delegate cb_onShutdownSucceed;
#pragma warning disable 0169
		static Delegate GetOnShutdownSucceedHandler ()
		{
			if (cb_onShutdownSucceed == null)
				cb_onShutdownSucceed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnShutdownSucceed);
			return cb_onShutdownSucceed;
		}

		static void n_OnShutdownSucceed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Sdk.Api.Callbacks.IShutDownLivePersonCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Sdk.Api.Callbacks.IShutDownLivePersonCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnShutdownSucceed ();
		}
#pragma warning restore 0169

		IntPtr id_onShutdownSucceed;
		public unsafe void OnShutdownSucceed ()
		{
			if (id_onShutdownSucceed == IntPtr.Zero)
				id_onShutdownSucceed = JNIEnv.GetMethodID (class_ref, "onShutdownSucceed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onShutdownSucceed);
		}

	}

}
