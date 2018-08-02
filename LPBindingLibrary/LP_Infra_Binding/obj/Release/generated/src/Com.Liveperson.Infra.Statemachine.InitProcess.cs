using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Statemachine {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='InitProcess']"
	[global::Android.Runtime.Register ("com/liveperson/infra/statemachine/InitProcess", DoNotGenerateAcw=true)]
	public abstract partial class InitProcess : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/statemachine/InitProcess", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InitProcess); }
		}

		protected InitProcess (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='InitProcess']/constructor[@name='InitProcess' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InitProcess ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (InitProcess)) {
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

		static Delegate cb_getInitCallback;
#pragma warning disable 0169
		static Delegate GetGetInitCallbackHandler ()
		{
			if (cb_getInitCallback == null)
				cb_getInitCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInitCallback);
			return cb_getInitCallback;
		}

		static IntPtr n_GetInitCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Statemachine.InitProcess __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.InitProcess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InitCallback);
		}
#pragma warning restore 0169

		static IntPtr id_getInitCallback;
		public virtual unsafe global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack InitCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='InitProcess']/method[@name='getInitCallback' and count(parameter)=0]"
			[Register ("getInitCallback", "()Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;", "GetGetInitCallbackHandler")]
			get {
				if (id_getInitCallback == IntPtr.Zero)
					id_getInitCallback = JNIEnv.GetMethodID (class_ref, "getInitCallback", "()Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInitCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInitCallback", "()Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Statemachine.InitProcess __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.InitProcess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='InitProcess']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		public abstract void Init ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/statemachine/InitProcess", DoNotGenerateAcw=true)]
	internal partial class InitProcessInvoker : InitProcess {

		public InitProcessInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (InitProcessInvoker); }
		}

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='InitProcess']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		public override unsafe void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init);
			} finally {
			}
		}

	}

}
