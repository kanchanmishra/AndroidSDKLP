using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Statemachine {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='ShutDownProcess']"
	[global::Android.Runtime.Register ("com/liveperson/infra/statemachine/ShutDownProcess", DoNotGenerateAcw=true)]
	public abstract partial class ShutDownProcess : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/statemachine/ShutDownProcess", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ShutDownProcess); }
		}

		protected ShutDownProcess (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='ShutDownProcess']/constructor[@name='ShutDownProcess' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ShutDownProcess ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ShutDownProcess)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getShutDownCallback;
#pragma warning disable 0169
		static Delegate GetGetShutDownCallbackHandler ()
		{
			if (cb_getShutDownCallback == null)
				cb_getShutDownCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetShutDownCallback);
			return cb_getShutDownCallback;
		}

		static IntPtr n_GetShutDownCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Statemachine.ShutDownProcess __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.ShutDownProcess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShutDownCallback);
		}
#pragma warning restore 0169

		static IntPtr id_getShutDownCallback;
		public virtual unsafe global::Com.Liveperson.Infra.Callbacks.IShutDownLivePersonCallBack ShutDownCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='ShutDownProcess']/method[@name='getShutDownCallback' and count(parameter)=0]"
			[Register ("getShutDownCallback", "()Lcom/liveperson/infra/callbacks/ShutDownLivePersonCallBack;", "GetGetShutDownCallbackHandler")]
			get {
				if (id_getShutDownCallback == IntPtr.Zero)
					id_getShutDownCallback = JNIEnv.GetMethodID (class_ref, "getShutDownCallback", "()Lcom/liveperson/infra/callbacks/ShutDownLivePersonCallBack;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Callbacks.IShutDownLivePersonCallBack> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getShutDownCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Callbacks.IShutDownLivePersonCallBack> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShutDownCallback", "()Lcom/liveperson/infra/callbacks/ShutDownLivePersonCallBack;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_;
#pragma warning disable 0169
		static Delegate GetShutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_Handler ()
		{
			if (cb_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ == null)
				cb_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_);
			return cb_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_;
		}

		static void n_ShutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Statemachine.ShutDownProcess __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.ShutDownProcess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener p0 = (global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShutDown (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='ShutDownProcess']/method[@name='shutDown' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.shutdown.ShutDownCompletionListener']]"
		[Register ("shutDown", "(Lcom/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener;)V", "GetShutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_Handler")]
		public abstract void ShutDown (global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/statemachine/ShutDownProcess", DoNotGenerateAcw=true)]
	internal partial class ShutDownProcessInvoker : ShutDownProcess {

		public ShutDownProcessInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ShutDownProcessInvoker); }
		}

		static IntPtr id_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='ShutDownProcess']/method[@name='shutDown' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.shutdown.ShutDownCompletionListener']]"
		[Register ("shutDown", "(Lcom/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener;)V", "GetShutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_Handler")]
		public override unsafe void ShutDown (global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener p0)
		{
			if (id_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ == IntPtr.Zero)
				id_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ = JNIEnv.GetMethodID (class_ref, "shutDown", "(Lcom/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_, __args);
			} finally {
			}
		}

	}

}
