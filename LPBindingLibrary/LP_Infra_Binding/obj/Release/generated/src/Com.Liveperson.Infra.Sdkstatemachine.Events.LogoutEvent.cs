using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Sdkstatemachine.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine.events']/class[@name='LogoutEvent']"
	[global::Android.Runtime.Register ("com/liveperson/infra/sdkstatemachine/events/LogoutEvent", DoNotGenerateAcw=true)]
	public partial class LogoutEvent : global::Com.Liveperson.Infra.Statemachine.BaseEvent {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/sdkstatemachine/events/LogoutEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LogoutEvent); }
		}

		protected LogoutEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_infra_statemachine_LogoutProcess_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine.events']/class[@name='LogoutEvent']/constructor[@name='LogoutEvent' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.LogoutProcess']]"
		[Register (".ctor", "(Lcom/liveperson/infra/statemachine/LogoutProcess;)V", "")]
		public unsafe LogoutEvent (global::Com.Liveperson.Infra.Statemachine.LogoutProcess p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (LogoutEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/infra/statemachine/LogoutProcess;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/infra/statemachine/LogoutProcess;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_infra_statemachine_LogoutProcess_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_infra_statemachine_LogoutProcess_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/statemachine/LogoutProcess;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_statemachine_LogoutProcess_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_statemachine_LogoutProcess_, __args);
			} finally {
			}
		}

		static Delegate cb_getInitEvent;
#pragma warning disable 0169
		static Delegate GetGetInitEventHandler ()
		{
			if (cb_getInitEvent == null)
				cb_getInitEvent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInitEvent);
			return cb_getInitEvent;
		}

		static IntPtr n_GetInitEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Sdkstatemachine.Events.LogoutEvent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Events.LogoutEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InitEvent);
		}
#pragma warning restore 0169

		static IntPtr id_getInitEvent;
		public virtual unsafe global::Com.Liveperson.Infra.Sdkstatemachine.Events.InitEvent InitEvent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine.events']/class[@name='LogoutEvent']/method[@name='getInitEvent' and count(parameter)=0]"
			[Register ("getInitEvent", "()Lcom/liveperson/infra/sdkstatemachine/events/InitEvent;", "GetGetInitEventHandler")]
			get {
				if (id_getInitEvent == IntPtr.Zero)
					id_getInitEvent = JNIEnv.GetMethodID (class_ref, "getInitEvent", "()Lcom/liveperson/infra/sdkstatemachine/events/InitEvent;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Events.InitEvent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInitEvent), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Events.InitEvent> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInitEvent", "()Lcom/liveperson/infra/sdkstatemachine/events/InitEvent;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLogoutProcess;
#pragma warning disable 0169
		static Delegate GetGetLogoutProcessHandler ()
		{
			if (cb_getLogoutProcess == null)
				cb_getLogoutProcess = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLogoutProcess);
			return cb_getLogoutProcess;
		}

		static IntPtr n_GetLogoutProcess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Sdkstatemachine.Events.LogoutEvent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Events.LogoutEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LogoutProcess);
		}
#pragma warning restore 0169

		static IntPtr id_getLogoutProcess;
		public virtual unsafe global::Com.Liveperson.Infra.Statemachine.LogoutProcess LogoutProcess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine.events']/class[@name='LogoutEvent']/method[@name='getLogoutProcess' and count(parameter)=0]"
			[Register ("getLogoutProcess", "()Lcom/liveperson/infra/statemachine/LogoutProcess;", "GetGetLogoutProcessHandler")]
			get {
				if (id_getLogoutProcess == IntPtr.Zero)
					id_getLogoutProcess = JNIEnv.GetMethodID (class_ref, "getLogoutProcess", "()Lcom/liveperson/infra/statemachine/LogoutProcess;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.LogoutProcess> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLogoutProcess), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.LogoutProcess> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLogoutProcess", "()Lcom/liveperson/infra/statemachine/LogoutProcess;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Liveperson.Infra.Sdkstatemachine.Events.LogoutEvent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Events.LogoutEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IState p0 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IState)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Accept (p0);
		}
#pragma warning restore 0169

		static IntPtr id_accept_Lcom_liveperson_infra_statemachine_interfaces_IState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine.events']/class[@name='LogoutEvent']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IState']]"
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

		static Delegate cb_setInitAfterLogout_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_;
#pragma warning disable 0169
		static Delegate GetSetInitAfterLogout_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_Handler ()
		{
			if (cb_setInitAfterLogout_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_ == null)
				cb_setInitAfterLogout_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInitAfterLogout_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_);
			return cb_setInitAfterLogout_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_;
		}

		static void n_SetInitAfterLogout_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Sdkstatemachine.Events.LogoutEvent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Events.LogoutEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Sdkstatemachine.Events.InitEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Events.InitEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetInitAfterLogout (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInitAfterLogout_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine.events']/class[@name='LogoutEvent']/method[@name='setInitAfterLogout' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.events.InitEvent']]"
		[Register ("setInitAfterLogout", "(Lcom/liveperson/infra/sdkstatemachine/events/InitEvent;)V", "GetSetInitAfterLogout_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_Handler")]
		public virtual unsafe void SetInitAfterLogout (global::Com.Liveperson.Infra.Sdkstatemachine.Events.InitEvent p0)
		{
			if (id_setInitAfterLogout_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_ == IntPtr.Zero)
				id_setInitAfterLogout_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_ = JNIEnv.GetMethodID (class_ref, "setInitAfterLogout", "(Lcom/liveperson/infra/sdkstatemachine/events/InitEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInitAfterLogout_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInitAfterLogout", "(Lcom/liveperson/infra/sdkstatemachine/events/InitEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSkipInit_Z;
#pragma warning disable 0169
		static Delegate GetSetSkipInit_ZHandler ()
		{
			if (cb_setSkipInit_Z == null)
				cb_setSkipInit_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSkipInit_Z);
			return cb_setSkipInit_Z;
		}

		static void n_SetSkipInit_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Infra.Sdkstatemachine.Events.LogoutEvent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Events.LogoutEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSkipInit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSkipInit_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine.events']/class[@name='LogoutEvent']/method[@name='setSkipInit' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSkipInit", "(Z)V", "GetSetSkipInit_ZHandler")]
		public virtual unsafe void SetSkipInit (bool p0)
		{
			if (id_setSkipInit_Z == IntPtr.Zero)
				id_setSkipInit_Z = JNIEnv.GetMethodID (class_ref, "setSkipInit", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSkipInit_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSkipInit", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_skipInit;
#pragma warning disable 0169
		static Delegate GetSkipInitHandler ()
		{
			if (cb_skipInit == null)
				cb_skipInit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_SkipInit);
			return cb_skipInit;
		}

		static bool n_SkipInit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Sdkstatemachine.Events.LogoutEvent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Events.LogoutEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SkipInit ();
		}
#pragma warning restore 0169

		static IntPtr id_skipInit;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine.events']/class[@name='LogoutEvent']/method[@name='skipInit' and count(parameter)=0]"
		[Register ("skipInit", "()Z", "GetSkipInitHandler")]
		public virtual unsafe bool SkipInit ()
		{
			if (id_skipInit == IntPtr.Zero)
				id_skipInit = JNIEnv.GetMethodID (class_ref, "skipInit", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_skipInit);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "skipInit", "()Z"));
			} finally {
			}
		}

	}
}
