using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Callbacks {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.callbacks']/interface[@name='LogoutLivePersonCallBack']"
	[Register ("com/liveperson/infra/callbacks/LogoutLivePersonCallBack", "", "Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBackInvoker")]
	public partial interface ILogoutLivePersonCallBack : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.callbacks']/interface[@name='LogoutLivePersonCallBack']/method[@name='onLogoutFailed' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onLogoutFailed", "(Ljava/lang/Exception;)V", "GetOnLogoutFailed_Ljava_lang_Exception_Handler:Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBackInvoker, LP_Android_aar_Binding")]
		void OnLogoutFailed (global::Java.Lang.Exception p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.callbacks']/interface[@name='LogoutLivePersonCallBack']/method[@name='onLogoutSucceed' and count(parameter)=0]"
		[Register ("onLogoutSucceed", "()V", "GetOnLogoutSucceedHandler:Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBackInvoker, LP_Android_aar_Binding")]
		void OnLogoutSucceed ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/callbacks/LogoutLivePersonCallBack", DoNotGenerateAcw=true)]
	internal class ILogoutLivePersonCallBackInvoker : global::Java.Lang.Object, ILogoutLivePersonCallBack {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/callbacks/LogoutLivePersonCallBack");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILogoutLivePersonCallBackInvoker); }
		}

		IntPtr class_ref;

		public static ILogoutLivePersonCallBack GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILogoutLivePersonCallBack> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.callbacks.LogoutLivePersonCallBack"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILogoutLivePersonCallBackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onLogoutFailed_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnLogoutFailed_Ljava_lang_Exception_Handler ()
		{
			if (cb_onLogoutFailed_Ljava_lang_Exception_ == null)
				cb_onLogoutFailed_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLogoutFailed_Ljava_lang_Exception_);
			return cb_onLogoutFailed_Ljava_lang_Exception_;
		}

		static void n_OnLogoutFailed_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBack __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLogoutFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onLogoutFailed_Ljava_lang_Exception_;
		public unsafe void OnLogoutFailed (global::Java.Lang.Exception p0)
		{
			if (id_onLogoutFailed_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onLogoutFailed_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onLogoutFailed", "(Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLogoutFailed_Ljava_lang_Exception_, __args);
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
			global::Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBack __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
