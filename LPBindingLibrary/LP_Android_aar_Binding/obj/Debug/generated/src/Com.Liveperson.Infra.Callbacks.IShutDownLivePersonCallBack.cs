using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Callbacks {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.callbacks']/interface[@name='ShutDownLivePersonCallBack']"
	[Register ("com/liveperson/infra/callbacks/ShutDownLivePersonCallBack", "", "Com.Liveperson.Infra.Callbacks.IShutDownLivePersonCallBackInvoker")]
	public partial interface IShutDownLivePersonCallBack : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.callbacks']/interface[@name='ShutDownLivePersonCallBack']/method[@name='onShutDownFailed' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onShutDownFailed", "(Ljava/lang/Exception;)V", "GetOnShutDownFailed_Ljava_lang_Exception_Handler:Com.Liveperson.Infra.Callbacks.IShutDownLivePersonCallBackInvoker, LP_Android_aar_Binding")]
		void OnShutDownFailed (global::Java.Lang.Exception p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.callbacks']/interface[@name='ShutDownLivePersonCallBack']/method[@name='onShutDownSucceed' and count(parameter)=0]"
		[Register ("onShutDownSucceed", "()V", "GetOnShutDownSucceedHandler:Com.Liveperson.Infra.Callbacks.IShutDownLivePersonCallBackInvoker, LP_Android_aar_Binding")]
		void OnShutDownSucceed ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/callbacks/ShutDownLivePersonCallBack", DoNotGenerateAcw=true)]
	internal class IShutDownLivePersonCallBackInvoker : global::Java.Lang.Object, IShutDownLivePersonCallBack {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/callbacks/ShutDownLivePersonCallBack");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IShutDownLivePersonCallBackInvoker); }
		}

		IntPtr class_ref;

		public static IShutDownLivePersonCallBack GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IShutDownLivePersonCallBack> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.callbacks.ShutDownLivePersonCallBack"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IShutDownLivePersonCallBackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onShutDownFailed_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnShutDownFailed_Ljava_lang_Exception_Handler ()
		{
			if (cb_onShutDownFailed_Ljava_lang_Exception_ == null)
				cb_onShutDownFailed_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnShutDownFailed_Ljava_lang_Exception_);
			return cb_onShutDownFailed_Ljava_lang_Exception_;
		}

		static void n_OnShutDownFailed_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Callbacks.IShutDownLivePersonCallBack __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Callbacks.IShutDownLivePersonCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnShutDownFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onShutDownFailed_Ljava_lang_Exception_;
		public unsafe void OnShutDownFailed (global::Java.Lang.Exception p0)
		{
			if (id_onShutDownFailed_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onShutDownFailed_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onShutDownFailed", "(Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onShutDownFailed_Ljava_lang_Exception_, __args);
		}

		static Delegate cb_onShutDownSucceed;
#pragma warning disable 0169
		static Delegate GetOnShutDownSucceedHandler ()
		{
			if (cb_onShutDownSucceed == null)
				cb_onShutDownSucceed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnShutDownSucceed);
			return cb_onShutDownSucceed;
		}

		static void n_OnShutDownSucceed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Callbacks.IShutDownLivePersonCallBack __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Callbacks.IShutDownLivePersonCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnShutDownSucceed ();
		}
#pragma warning restore 0169

		IntPtr id_onShutDownSucceed;
		public unsafe void OnShutDownSucceed ()
		{
			if (id_onShutDownSucceed == IntPtr.Zero)
				id_onShutDownSucceed = JNIEnv.GetMethodID (class_ref, "onShutDownSucceed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onShutDownSucceed);
		}

	}

}
