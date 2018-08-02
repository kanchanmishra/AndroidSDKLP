using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Callbacks {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.callbacks']/interface[@name='InitLivePersonCallBack']"
	[Register ("com/liveperson/infra/callbacks/InitLivePersonCallBack", "", "Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBackInvoker")]
	public partial interface IInitLivePersonCallBack : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.callbacks']/interface[@name='InitLivePersonCallBack']/method[@name='onInitFailed' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onInitFailed", "(Ljava/lang/Exception;)V", "GetOnInitFailed_Ljava_lang_Exception_Handler:Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBackInvoker, LP_Infra_Binding")]
		void OnInitFailed (global::Java.Lang.Exception p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.callbacks']/interface[@name='InitLivePersonCallBack']/method[@name='onInitSucceed' and count(parameter)=0]"
		[Register ("onInitSucceed", "()V", "GetOnInitSucceedHandler:Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBackInvoker, LP_Infra_Binding")]
		void OnInitSucceed ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/callbacks/InitLivePersonCallBack", DoNotGenerateAcw=true)]
	internal class IInitLivePersonCallBackInvoker : global::Java.Lang.Object, IInitLivePersonCallBack {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/callbacks/InitLivePersonCallBack");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IInitLivePersonCallBackInvoker); }
		}

		IntPtr class_ref;

		public static IInitLivePersonCallBack GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInitLivePersonCallBack> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.callbacks.InitLivePersonCallBack"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInitLivePersonCallBackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onInitFailed_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnInitFailed_Ljava_lang_Exception_Handler ()
		{
			if (cb_onInitFailed_Ljava_lang_Exception_ == null)
				cb_onInitFailed_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInitFailed_Ljava_lang_Exception_);
			return cb_onInitFailed_Ljava_lang_Exception_;
		}

		static void n_OnInitFailed_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnInitFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onInitFailed_Ljava_lang_Exception_;
		public unsafe void OnInitFailed (global::Java.Lang.Exception p0)
		{
			if (id_onInitFailed_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onInitFailed_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onInitFailed", "(Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInitFailed_Ljava_lang_Exception_, __args);
		}

		static Delegate cb_onInitSucceed;
#pragma warning disable 0169
		static Delegate GetOnInitSucceedHandler ()
		{
			if (cb_onInitSucceed == null)
				cb_onInitSucceed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInitSucceed);
			return cb_onInitSucceed;
		}

		static void n_OnInitSucceed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInitSucceed ();
		}
#pragma warning restore 0169

		IntPtr id_onInitSucceed;
		public unsafe void OnInitSucceed ()
		{
			if (id_onInitSucceed == IntPtr.Zero)
				id_onInitSucceed = JNIEnv.GetMethodID (class_ref, "onInitSucceed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInitSucceed);
		}

	}

}
