using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Sdkstatemachine.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine.events']/class[@name='InitEvent']"
	[global::Android.Runtime.Register ("com/liveperson/infra/sdkstatemachine/events/InitEvent", DoNotGenerateAcw=true)]
	public partial class InitEvent : global::Com.Liveperson.Infra.Statemachine.BaseEvent {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/sdkstatemachine/events/InitEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InitEvent); }
		}

		protected InitEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_infra_statemachine_InitProcess_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine.events']/class[@name='InitEvent']/constructor[@name='InitEvent' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.InitProcess']]"
		[Register (".ctor", "(Lcom/liveperson/infra/statemachine/InitProcess;)V", "")]
		public unsafe InitEvent (global::Com.Liveperson.Infra.Statemachine.InitProcess p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (InitEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/infra/statemachine/InitProcess;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/infra/statemachine/InitProcess;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_infra_statemachine_InitProcess_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_infra_statemachine_InitProcess_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/statemachine/InitProcess;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_statemachine_InitProcess_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_statemachine_InitProcess_, __args);
			} finally {
			}
		}

		static Delegate cb_getInitProcess;
#pragma warning disable 0169
		static Delegate GetGetInitProcessHandler ()
		{
			if (cb_getInitProcess == null)
				cb_getInitProcess = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInitProcess);
			return cb_getInitProcess;
		}

		static IntPtr n_GetInitProcess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Sdkstatemachine.Events.InitEvent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Events.InitEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InitProcess);
		}
#pragma warning restore 0169

		static IntPtr id_getInitProcess;
		public virtual unsafe global::Com.Liveperson.Infra.Statemachine.InitProcess InitProcess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine.events']/class[@name='InitEvent']/method[@name='getInitProcess' and count(parameter)=0]"
			[Register ("getInitProcess", "()Lcom/liveperson/infra/statemachine/InitProcess;", "GetGetInitProcessHandler")]
			get {
				if (id_getInitProcess == IntPtr.Zero)
					id_getInitProcess = JNIEnv.GetMethodID (class_ref, "getInitProcess", "()Lcom/liveperson/infra/statemachine/InitProcess;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.InitProcess> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInitProcess), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.InitProcess> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInitProcess", "()Lcom/liveperson/infra/statemachine/InitProcess;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_accept_Lcom_liveperson_infra_statemachine_interfaces_IState_;
#pragma warning disable 0169
		static Delegate GetAccept_Lcom_liveperson_infra_statemachine_interfaces_IState_Handler ()
		{
			if (cb_accept_Lcom_liveperson_infra_statemachine_interfaces_IState_ == null)
				cb_accept_Lcom_liveperson_infra_statemachine_interfaces_IState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Accept_Lcom_liveperson_infra_statemachine_interfaces_IState_);
			return cb_accept_Lcom_liveperson_infra_statemachine_interfaces_IState_;
		}

		static void n_Accept_Lcom_liveperson_infra_statemachine_interfaces_IState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Sdkstatemachine.Events.InitEvent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Events.InitEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IState p0 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IState)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Accept (p0);
		}
#pragma warning restore 0169

		static IntPtr id_accept_Lcom_liveperson_infra_statemachine_interfaces_IState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine.events']/class[@name='InitEvent']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IState']]"
		[Register ("accept", "(Lcom/liveperson/infra/statemachine/interfaces/IState;)V", "GetAccept_Lcom_liveperson_infra_statemachine_interfaces_IState_Handler")]
		public override unsafe void Accept (global::Com.Liveperson.Infra.Statemachine.Interfaces.IState p0)
		{
			if (id_accept_Lcom_liveperson_infra_statemachine_interfaces_IState_ == IntPtr.Zero)
				id_accept_Lcom_liveperson_infra_statemachine_interfaces_IState_ = JNIEnv.GetMethodID (class_ref, "accept", "(Lcom/liveperson/infra/statemachine/interfaces/IState;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_accept_Lcom_liveperson_infra_statemachine_interfaces_IState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "accept", "(Lcom/liveperson/infra/statemachine/interfaces/IState;)V"), __args);
			} finally {
			}
		}

	}
}
