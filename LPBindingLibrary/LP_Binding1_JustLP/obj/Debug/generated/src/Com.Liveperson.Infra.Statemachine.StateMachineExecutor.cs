using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Statemachine {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='StateMachineExecutor']"
	[global::Android.Runtime.Register ("com/liveperson/infra/statemachine/StateMachineExecutor", DoNotGenerateAcw=true)]
	public partial class StateMachineExecutor : global::Java.Lang.Object, global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineExecutor {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='StateMachineExecutor.RunnableWrapper']"
		[global::Android.Runtime.Register ("com/liveperson/infra/statemachine/StateMachineExecutor$RunnableWrapper", DoNotGenerateAcw=true)]
		public partial class RunnableWrapper : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/statemachine/StateMachineExecutor$RunnableWrapper", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RunnableWrapper); }
			}

			protected RunnableWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.Statemachine.StateMachineExecutor.RunnableWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.StateMachineExecutor.RunnableWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='StateMachineExecutor.RunnableWrapper']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/statemachine/StateMachineExecutor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StateMachineExecutor); }
		}

		protected StateMachineExecutor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='StateMachineExecutor']/constructor[@name='StateMachineExecutor' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.statemachine.interfaces.IStateMachine']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/liveperson/infra/statemachine/interfaces/IStateMachine;)V", "")]
		public unsafe StateMachineExecutor (string p0, global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (StateMachineExecutor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Lcom/liveperson/infra/statemachine/interfaces/IStateMachine;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lcom/liveperson/infra/statemachine/interfaces/IStateMachine;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/liveperson/infra/statemachine/interfaces/IStateMachine;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Liveperson.Infra.Statemachine.StateMachineExecutor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.StateMachineExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInitialized;
		}
#pragma warning restore 0169

		static IntPtr id_isInitialized;
		public virtual unsafe bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='StateMachineExecutor']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "GetIsInitializedHandler")]
			get {
				if (id_isInitialized == IntPtr.Zero)
					id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInitialized);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInitialized", "()Z"));
				} finally {
				}
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
			global::Com.Liveperson.Infra.Statemachine.StateMachineExecutor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.StateMachineExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Cancel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_cancel_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='StateMachineExecutor']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("cancel", "(Ljava/lang/Runnable;)V", "GetCancel_Ljava_lang_Runnable_Handler")]
		public virtual unsafe void Cancel (global::Java.Lang.IRunnable p0)
		{
			if (id_cancel_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_cancel_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "cancel", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel_Ljava_lang_Runnable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancel", "(Ljava/lang/Runnable;)V"), __args);
			} finally {
			}
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
			global::Com.Liveperson.Infra.Statemachine.StateMachineExecutor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.StateMachineExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Post (p0);
		}
#pragma warning restore 0169

		static IntPtr id_post_Lcom_liveperson_infra_statemachine_interfaces_IEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='StateMachineExecutor']/method[@name='post' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IEvent']]"
		[Register ("post", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;)V", "GetPost_Lcom_liveperson_infra_statemachine_interfaces_IEvent_Handler")]
		public virtual unsafe void Post (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0)
		{
			if (id_post_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ == IntPtr.Zero)
				id_post_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ = JNIEnv.GetMethodID (class_ref, "post", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_post_Lcom_liveperson_infra_statemachine_interfaces_IEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "post", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;)V"), __args);
			} finally {
			}
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
			global::Com.Liveperson.Infra.Statemachine.StateMachineExecutor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.StateMachineExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Schedule (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_schedule_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='StateMachineExecutor']/method[@name='schedule' and count(parameter)=2 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IEvent'] and parameter[2][@type='long']]"
		[Register ("schedule", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;J)Ljava/lang/Runnable;", "GetSchedule_Lcom_liveperson_infra_statemachine_interfaces_IEvent_JHandler")]
		public virtual unsafe global::Java.Lang.IRunnable Schedule (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0, long p1)
		{
			if (id_schedule_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J == IntPtr.Zero)
				id_schedule_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J = JNIEnv.GetMethodID (class_ref, "schedule", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;J)Ljava/lang/Runnable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Lang.IRunnable __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_schedule_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "schedule", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;J)Ljava/lang/Runnable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
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
			global::Com.Liveperson.Infra.Statemachine.StateMachineExecutor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.StateMachineExecutor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shutdown ();
		}
#pragma warning restore 0169

		static IntPtr id_shutdown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='StateMachineExecutor']/method[@name='shutdown' and count(parameter)=0]"
		[Register ("shutdown", "()V", "GetShutdownHandler")]
		public virtual unsafe void Shutdown ()
		{
			if (id_shutdown == IntPtr.Zero)
				id_shutdown = JNIEnv.GetMethodID (class_ref, "shutdown", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutdown);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shutdown", "()V"));
			} finally {
			}
		}

	}
}
