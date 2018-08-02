using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Statemachine.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.statemachine.interfaces']/interface[@name='IStateMachineExecutor']"
	[Register ("com/liveperson/infra/statemachine/interfaces/IStateMachineExecutor", "", "Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineExecutorInvoker")]
	public partial interface IStateMachineExecutor : IJavaObject {

		bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine.interfaces']/interface[@name='IStateMachineExecutor']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "GetIsInitializedHandler:Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineExecutorInvoker, LP_Binding1_JustLP")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine.interfaces']/interface[@name='IStateMachineExecutor']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("cancel", "(Ljava/lang/Runnable;)V", "GetCancel_Ljava_lang_Runnable_Handler:Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineExecutorInvoker, LP_Binding1_JustLP")]
		void Cancel (global::Java.Lang.IRunnable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine.interfaces']/interface[@name='IStateMachineExecutor']/method[@name='post' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IEvent']]"
		[Register ("post", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;)V", "GetPost_Lcom_liveperson_infra_statemachine_interfaces_IEvent_Handler:Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineExecutorInvoker, LP_Binding1_JustLP")]
		void Post (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine.interfaces']/interface[@name='IStateMachineExecutor']/method[@name='schedule' and count(parameter)=2 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IEvent'] and parameter[2][@type='long']]"
		[Register ("schedule", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;J)Ljava/lang/Runnable;", "GetSchedule_Lcom_liveperson_infra_statemachine_interfaces_IEvent_JHandler:Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineExecutorInvoker, LP_Binding1_JustLP")]
		global::Java.Lang.IRunnable Schedule (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine.interfaces']/interface[@name='IStateMachineExecutor']/method[@name='shutdown' and count(parameter)=0]"
		[Register ("shutdown", "()V", "GetShutdownHandler:Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineExecutorInvoker, LP_Binding1_JustLP")]
		void Shutdown ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/statemachine/interfaces/IStateMachineExecutor", DoNotGenerateAcw=true)]
	internal class IStateMachineExecutorInvoker : global::Java.Lang.Object, IStateMachineExecutor {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/statemachine/interfaces/IStateMachineExecutor");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IStateMachineExecutorInvoker); }
		}

		IntPtr class_ref;

		public static IStateMachineExecutor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStateMachineExecutor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.statemachine.interfaces.IStateMachineExecutor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStateMachineExecutorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isInitialized;
#pragma warning disable 0169
		static Delegate GetIsInitializedHandler ()
		{
			if (cb_isInitialized == null)
				cb_isInitialized = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInitialized);
			return cb_isInitialized;
		}

		static bool n_IsInitialized (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineExecutor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInitialized;
		}
#pragma warning restore 0169

		IntPtr id_isInitialized;
		public unsafe bool IsInitialized {
			get {
				if (id_isInitialized == IntPtr.Zero)
					id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInitialized);
			}
		}

		static Delegate cb_cancel_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetCancel_Ljava_lang_Runnable_Handler ()
		{
			if (cb_cancel_Ljava_lang_Runnable_ == null)
				cb_cancel_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Cancel_Ljava_lang_Runnable_);
			return cb_cancel_Ljava_lang_Runnable_;
		}

		static void n_Cancel_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineExecutor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Cancel (p0);
		}
#pragma warning restore 0169

		IntPtr id_cancel_Ljava_lang_Runnable_;
		public unsafe void Cancel (global::Java.Lang.IRunnable p0)
		{
			if (id_cancel_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_cancel_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "cancel", "(Ljava/lang/Runnable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel_Ljava_lang_Runnable_, __args);
		}

		static Delegate cb_post_Lcom_liveperson_infra_statemachine_interfaces_IEvent_;
#pragma warning disable 0169
		static Delegate GetPost_Lcom_liveperson_infra_statemachine_interfaces_IEvent_Handler ()
		{
			if (cb_post_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ == null)
				cb_post_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Post_Lcom_liveperson_infra_statemachine_interfaces_IEvent_);
			return cb_post_Lcom_liveperson_infra_statemachine_interfaces_IEvent_;
		}

		static void n_Post_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineExecutor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Post (p0);
		}
#pragma warning restore 0169

		IntPtr id_post_Lcom_liveperson_infra_statemachine_interfaces_IEvent_;
		public unsafe void Post (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0)
		{
			if (id_post_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ == IntPtr.Zero)
				id_post_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ = JNIEnv.GetMethodID (class_ref, "post", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_post_Lcom_liveperson_infra_statemachine_interfaces_IEvent_, __args);
		}

		static Delegate cb_schedule_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J;
#pragma warning disable 0169
		static Delegate GetSchedule_Lcom_liveperson_infra_statemachine_interfaces_IEvent_JHandler ()
		{
			if (cb_schedule_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J == null)
				cb_schedule_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_Schedule_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J);
			return cb_schedule_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J;
		}

		static IntPtr n_Schedule_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineExecutor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Schedule (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_schedule_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J;
		public unsafe global::Java.Lang.IRunnable Schedule (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0, long p1)
		{
			if (id_schedule_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J == IntPtr.Zero)
				id_schedule_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J = JNIEnv.GetMethodID (class_ref, "schedule", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;J)Ljava/lang/Runnable;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			global::Java.Lang.IRunnable __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_schedule_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_shutdown;
#pragma warning disable 0169
		static Delegate GetShutdownHandler ()
		{
			if (cb_shutdown == null)
				cb_shutdown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Shutdown);
			return cb_shutdown;
		}

		static void n_Shutdown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineExecutor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shutdown ();
		}
#pragma warning restore 0169

		IntPtr id_shutdown;
		public unsafe void Shutdown ()
		{
			if (id_shutdown == IntPtr.Zero)
				id_shutdown = JNIEnv.GetMethodID (class_ref, "shutdown", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutdown);
		}

	}

}
