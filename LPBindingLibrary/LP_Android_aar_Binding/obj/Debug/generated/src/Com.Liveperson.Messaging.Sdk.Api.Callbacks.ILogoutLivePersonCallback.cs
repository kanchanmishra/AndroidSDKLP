using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Sdk.Api.Callbacks {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.messaging.sdk.api.callbacks']/interface[@name='LogoutLivePersonCallback']"
	[Register ("com/liveperson/messaging/sdk/api/callbacks/LogoutLivePersonCallback", "", "Com.Liveperson.Messaging.Sdk.Api.Callbacks.ILogoutLivePersonCallbackInvoker")]
	public partial interface ILogoutLivePersonCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api.callbacks']/interface[@name='LogoutLivePersonCallback']/method[@name='onLogoutFailed' and count(parameter)=0]"
		[Register ("onLogoutFailed", "()V", "GetOnLogoutFailedHandler:Com.Liveperson.Messaging.Sdk.Api.Callbacks.ILogoutLivePersonCallbackInvoker, LP_Android_aar_Binding")]
		void OnLogoutFailed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.sdk.api.callbacks']/interface[@name='LogoutLivePersonCallback']/method[@name='onLogoutSucceed' and count(parameter)=0]"
		[Register ("onLogoutSucceed", "()V", "GetOnLogoutSucceedHandler:Com.Liveperson.Messaging.Sdk.Api.Callbacks.ILogoutLivePersonCallbackInvoker, LP_Android_aar_Binding")]
		void OnLogoutSucceed ();

	}

	[global::Android.Runtime.Register ("com/liveperson/messaging/sdk/api/callbacks/LogoutLivePersonCallback", DoNotGenerateAcw=true)]
	internal class ILogoutLivePersonCallbackInvoker : global::Java.Lang.Object, ILogoutLivePersonCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/messaging/sdk/api/callbacks/LogoutLivePersonCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILogoutLivePersonCallbackInvoker); }
		}

		IntPtr class_ref;

		public static ILogoutLivePersonCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILogoutLivePersonCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.messaging.sdk.api.callbacks.LogoutLivePersonCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILogoutLivePersonCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onLogoutFailed;
#pragma warning disable 0169
		static Delegate GetOnLogoutFailedHandler ()
		{
			if (cb_onLogoutFailed == null)
				cb_onLogoutFailed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLogoutFailed);
			return cb_onLogoutFailed;
		}

		static void n_OnLogoutFailed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Sdk.Api.Callbacks.ILogoutLivePersonCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Sdk.Api.Callbacks.ILogoutLivePersonCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLogoutFailed ();
		}
#pragma warning restore 0169

		IntPtr id_onLogoutFailed;
		public unsafe void OnLogoutFailed ()
		{
			if (id_onLogoutFailed == IntPtr.Zero)
				id_onLogoutFailed = JNIEnv.GetMethodID (class_ref, "onLogoutFailed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLogoutFailed);
		}

		static Delegate cb_onLogoutSucceed;
#pragma warning disable 0169
		static Delegate GetOnLogoutSucceedHandler ()
		{
			if (cb_onLogoutSucceed == null)
				cb_onLogoutSucceed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLogoutSucceed);
			return cb_onLogoutSucceed;
		}

		static void n_OnLogoutSucceed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Sdk.Api.Callbacks.ILogoutLivePersonCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Sdk.Api.Callbacks.ILogoutLivePersonCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLogoutSucceed ();
		}
#pragma warning restore 0169

		IntPtr id_onLogoutSucceed;
		public unsafe void OnLogoutSucceed ()
		{
			if (id_onLogoutSucceed == IntPtr.Zero)
				id_onLogoutSucceed = JNIEnv.GetMethodID (class_ref, "onLogoutSucceed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLogoutSucceed);
		}

	}

}
