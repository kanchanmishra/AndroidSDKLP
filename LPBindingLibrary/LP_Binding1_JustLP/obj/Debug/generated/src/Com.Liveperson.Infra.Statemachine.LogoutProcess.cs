using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Statemachine {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='LogoutProcess']"
	[global::Android.Runtime.Register ("com/liveperson/infra/statemachine/LogoutProcess", DoNotGenerateAcw=true)]
	public abstract partial class LogoutProcess : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/statemachine/LogoutProcess", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LogoutProcess); }
		}

		protected LogoutProcess (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='LogoutProcess']/constructor[@name='LogoutProcess' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LogoutProcess ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LogoutProcess)) {
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

		static Delegate cb_getLogoutCallback;
#pragma warning disable 0169
		static Delegate GetGetLogoutCallbackHandler ()
		{
			if (cb_getLogoutCallback == null)
				cb_getLogoutCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLogoutCallback);
			return cb_getLogoutCallback;
		}

		static IntPtr n_GetLogoutCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Statemachine.LogoutProcess __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.LogoutProcess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LogoutCallback);
		}
#pragma warning restore 0169

		public abstract global::Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBack LogoutCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='LogoutProcess']/method[@name='getLogoutCallback' and count(parameter)=0]"
			[Register ("getLogoutCallback", "()Lcom/liveperson/infra/callbacks/LogoutLivePersonCallBack;", "GetGetLogoutCallbackHandler")] get;
		}

		static Delegate cb_initForLogout;
#pragma warning disable 0169
		static Delegate GetInitForLogoutHandler ()
		{
			if (cb_initForLogout == null)
				cb_initForLogout = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitForLogout);
			return cb_initForLogout;
		}

		static void n_InitForLogout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Statemachine.LogoutProcess __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.LogoutProcess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitForLogout ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='LogoutProcess']/method[@name='initForLogout' and count(parameter)=0]"
		[Register ("initForLogout", "()V", "GetInitForLogoutHandler")]
		public abstract void InitForLogout ();

		static Delegate cb_logout;
#pragma warning disable 0169
		static Delegate GetLogoutHandler ()
		{
			if (cb_logout == null)
				cb_logout = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Logout);
			return cb_logout;
		}

		static void n_Logout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Statemachine.LogoutProcess __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.LogoutProcess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Logout ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='LogoutProcess']/method[@name='logout' and count(parameter)=0]"
		[Register ("logout", "()V", "GetLogoutHandler")]
		public abstract void Logout ();

		static Delegate cb_preLogout_Lcom_liveperson_infra_sdkstatemachine_logout_PreLogoutCompletionListener_;
#pragma warning disable 0169
		static Delegate GetPreLogout_Lcom_liveperson_infra_sdkstatemachine_logout_PreLogoutCompletionListener_Handler ()
		{
			if (cb_preLogout_Lcom_liveperson_infra_sdkstatemachine_logout_PreLogoutCompletionListener_ == null)
				cb_preLogout_Lcom_liveperson_infra_sdkstatemachine_logout_PreLogoutCompletionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PreLogout_Lcom_liveperson_infra_sdkstatemachine_logout_PreLogoutCompletionListener_);
			return cb_preLogout_Lcom_liveperson_infra_sdkstatemachine_logout_PreLogoutCompletionListener_;
		}

		static void n_PreLogout_Lcom_liveperson_infra_sdkstatemachine_logout_PreLogoutCompletionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Statemachine.LogoutProcess __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.LogoutProcess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Sdkstatemachine.Logout.IPreLogoutCompletionListener p0 = (global::Com.Liveperson.Infra.Sdkstatemachine.Logout.IPreLogoutCompletionListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Logout.IPreLogoutCompletionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PreLogout (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='LogoutProcess']/method[@name='preLogout' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.logout.PreLogoutCompletionListener']]"
		[Register ("preLogout", "(Lcom/liveperson/infra/sdkstatemachine/logout/PreLogoutCompletionListener;)V", "GetPreLogout_Lcom_liveperson_infra_sdkstatemachine_logout_PreLogoutCompletionListener_Handler")]
		public abstract void PreLogout (global::Com.Liveperson.Infra.Sdkstatemachine.Logout.IPreLogoutCompletionListener p0);

		static Delegate cb_shutDownForLogout_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_;
#pragma warning disable 0169
		static Delegate GetShutDownForLogout_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_Handler ()
		{
			if (cb_shutDownForLogout_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ == null)
				cb_shutDownForLogout_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShutDownForLogout_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_);
			return cb_shutDownForLogout_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_;
		}

		static void n_ShutDownForLogout_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Statemachine.LogoutProcess __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.LogoutProcess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener p0 = (global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShutDownForLogout (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='LogoutProcess']/method[@name='shutDownForLogout' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.shutdown.ShutDownCompletionListener']]"
		[Register ("shutDownForLogout", "(Lcom/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener;)V", "GetShutDownForLogout_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_Handler")]
		public abstract void ShutDownForLogout (global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/statemachine/LogoutProcess", DoNotGenerateAcw=true)]
	internal partial class LogoutProcessInvoker : LogoutProcess {

		public LogoutProcessInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (LogoutProcessInvoker); }
		}

		static IntPtr id_getLogoutCallback;
		public override unsafe global::Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBack LogoutCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='LogoutProcess']/method[@name='getLogoutCallback' and count(parameter)=0]"
			[Register ("getLogoutCallback", "()Lcom/liveperson/infra/callbacks/LogoutLivePersonCallBack;", "GetGetLogoutCallbackHandler")]
			get {
				if (id_getLogoutCallback == IntPtr.Zero)
					id_getLogoutCallback = JNIEnv.GetMethodID (class_ref, "getLogoutCallback", "()Lcom/liveperson/infra/callbacks/LogoutLivePersonCallBack;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBack> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLogoutCallback), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_initForLogout;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='LogoutProcess']/method[@name='initForLogout' and count(parameter)=0]"
		[Register ("initForLogout", "()V", "GetInitForLogoutHandler")]
		public override unsafe void InitForLogout ()
		{
			if (id_initForLogout == IntPtr.Zero)
				id_initForLogout = JNIEnv.GetMethodID (class_ref, "initForLogout", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initForLogout);
			} finally {
			}
		}

		static IntPtr id_logout;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='LogoutProcess']/method[@name='logout' and count(parameter)=0]"
		[Register ("logout", "()V", "GetLogoutHandler")]
		public override unsafe void Logout ()
		{
			if (id_logout == IntPtr.Zero)
				id_logout = JNIEnv.GetMethodID (class_ref, "logout", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_logout);
			} finally {
			}
		}

		static IntPtr id_preLogout_Lcom_liveperson_infra_sdkstatemachine_logout_PreLogoutCompletionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='LogoutProcess']/method[@name='preLogout' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.logout.PreLogoutCompletionListener']]"
		[Register ("preLogout", "(Lcom/liveperson/infra/sdkstatemachine/logout/PreLogoutCompletionListener;)V", "GetPreLogout_Lcom_liveperson_infra_sdkstatemachine_logout_PreLogoutCompletionListener_Handler")]
		public override unsafe void PreLogout (global::Com.Liveperson.Infra.Sdkstatemachine.Logout.IPreLogoutCompletionListener p0)
		{
			if (id_preLogout_Lcom_liveperson_infra_sdkstatemachine_logout_PreLogoutCompletionListener_ == IntPtr.Zero)
				id_preLogout_Lcom_liveperson_infra_sdkstatemachine_logout_PreLogoutCompletionListener_ = JNIEnv.GetMethodID (class_ref, "preLogout", "(Lcom/liveperson/infra/sdkstatemachine/logout/PreLogoutCompletionListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_preLogout_Lcom_liveperson_infra_sdkstatemachine_logout_PreLogoutCompletionListener_, __args);
			} finally {
			}
		}

		static IntPtr id_shutDownForLogout_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='LogoutProcess']/method[@name='shutDownForLogout' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.shutdown.ShutDownCompletionListener']]"
		[Register ("shutDownForLogout", "(Lcom/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener;)V", "GetShutDownForLogout_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_Handler")]
		public override unsafe void ShutDownForLogout (global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener p0)
		{
			if (id_shutDownForLogout_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ == IntPtr.Zero)
				id_shutDownForLogout_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ = JNIEnv.GetMethodID (class_ref, "shutDownForLogout", "(Lcom/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutDownForLogout_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_, __args);
			} finally {
			}
		}

	}

}
