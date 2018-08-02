using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Statemachine {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='BaseStateMachine']"
	[global::Android.Runtime.Register ("com/liveperson/infra/statemachine/BaseStateMachine", DoNotGenerateAcw=true)]
	public abstract partial class BaseStateMachine : global::Java.Lang.Object, global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDown, global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/statemachine/BaseStateMachine", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseStateMachine); }
		}

		protected BaseStateMachine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='BaseStateMachine']/constructor[@name='BaseStateMachine' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		protected unsafe BaseStateMachine (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (BaseStateMachine)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
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
			global::Com.Liveperson.Infra.Statemachine.BaseStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.BaseStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInitialized;
		}
#pragma warning restore 0169

		static IntPtr id_isInitialized;
		public virtual unsafe bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='BaseStateMachine']/method[@name='isInitialized' and count(parameter)=0]"
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

		static Delegate cb_getTag;
#pragma warning disable 0169
		static Delegate GetGetTagHandler ()
		{
			if (cb_getTag == null)
				cb_getTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTag);
			return cb_getTag;
		}

		static IntPtr n_GetTag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Statemachine.BaseStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.BaseStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Tag);
		}
#pragma warning restore 0169

		static IntPtr id_getTag;
		public virtual unsafe string Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='BaseStateMachine']/method[@name='getTag' and count(parameter)=0]"
			[Register ("getTag", "()Ljava/lang/String;", "GetGetTagHandler")]
			get {
				if (id_getTag == IntPtr.Zero)
					id_getTag = JNIEnv.GetMethodID (class_ref, "getTag", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTag), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTag", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_activeState;
#pragma warning disable 0169
		static Delegate GetActiveStateHandler ()
		{
			if (cb_activeState == null)
				cb_activeState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ActiveState);
			return cb_activeState;
		}

		static IntPtr n_ActiveState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Statemachine.BaseStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.BaseStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ActiveState ());
		}
#pragma warning restore 0169

		static IntPtr id_activeState;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='BaseStateMachine']/method[@name='activeState' and count(parameter)=0]"
		[Register ("activeState", "()Lcom/liveperson/infra/statemachine/interfaces/IState;", "GetActiveStateHandler")]
		public virtual unsafe global::Java.Lang.Object ActiveState ()
		{
			if (id_activeState == IntPtr.Zero)
				id_activeState = JNIEnv.GetMethodID (class_ref, "activeState", "()Lcom/liveperson/infra/statemachine/interfaces/IState;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_activeState), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "activeState", "()Lcom/liveperson/infra/statemachine/interfaces/IState;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_apply_Lcom_liveperson_infra_statemachine_interfaces_IEvent_;
#pragma warning disable 0169
		static Delegate GetApply_Lcom_liveperson_infra_statemachine_interfaces_IEvent_Handler ()
		{
			if (cb_apply_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ == null)
				cb_apply_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Apply_Lcom_liveperson_infra_statemachine_interfaces_IEvent_);
			return cb_apply_Lcom_liveperson_infra_statemachine_interfaces_IEvent_;
		}

		static void n_Apply_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Statemachine.BaseStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.BaseStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Apply (p0);
		}
#pragma warning restore 0169

		static IntPtr id_apply_Lcom_liveperson_infra_statemachine_interfaces_IEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='BaseStateMachine']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IEvent']]"
		[Register ("apply", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;)V", "GetApply_Lcom_liveperson_infra_statemachine_interfaces_IEvent_Handler")]
		public virtual unsafe void Apply (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0)
		{
			if (id_apply_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ == IntPtr.Zero)
				id_apply_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ = JNIEnv.GetMethodID (class_ref, "apply", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_apply_Lcom_liveperson_infra_statemachine_interfaces_IEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "apply", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_cancelDelayedEvent_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetCancelDelayedEvent_Ljava_lang_Runnable_Handler ()
		{
			if (cb_cancelDelayedEvent_Ljava_lang_Runnable_ == null)
				cb_cancelDelayedEvent_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CancelDelayedEvent_Ljava_lang_Runnable_);
			return cb_cancelDelayedEvent_Ljava_lang_Runnable_;
		}

		static void n_CancelDelayedEvent_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Statemachine.BaseStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.BaseStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CancelDelayedEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_cancelDelayedEvent_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='BaseStateMachine']/method[@name='cancelDelayedEvent' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("cancelDelayedEvent", "(Ljava/lang/Runnable;)V", "GetCancelDelayedEvent_Ljava_lang_Runnable_Handler")]
		public virtual unsafe void CancelDelayedEvent (global::Java.Lang.IRunnable p0)
		{
			if (id_cancelDelayedEvent_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_cancelDelayedEvent_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "cancelDelayedEvent", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelDelayedEvent_Ljava_lang_Runnable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelDelayedEvent", "(Ljava/lang/Runnable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_changeState_Lcom_liveperson_infra_statemachine_interfaces_IState_;
#pragma warning disable 0169
		static Delegate GetChangeState_Lcom_liveperson_infra_statemachine_interfaces_IState_Handler ()
		{
			if (cb_changeState_Lcom_liveperson_infra_statemachine_interfaces_IState_ == null)
				cb_changeState_Lcom_liveperson_infra_statemachine_interfaces_IState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ChangeState_Lcom_liveperson_infra_statemachine_interfaces_IState_);
			return cb_changeState_Lcom_liveperson_infra_statemachine_interfaces_IState_;
		}

		static void n_ChangeState_Lcom_liveperson_infra_statemachine_interfaces_IState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Statemachine.BaseStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.BaseStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IState p0 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IState)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChangeState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_changeState_Lcom_liveperson_infra_statemachine_interfaces_IState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='BaseStateMachine']/method[@name='changeState' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IState']]"
		[Register ("changeState", "(Lcom/liveperson/infra/statemachine/interfaces/IState;)V", "GetChangeState_Lcom_liveperson_infra_statemachine_interfaces_IState_Handler")]
		public virtual unsafe void ChangeState (global::Com.Liveperson.Infra.Statemachine.Interfaces.IState p0)
		{
			if (id_changeState_Lcom_liveperson_infra_statemachine_interfaces_IState_ == IntPtr.Zero)
				id_changeState_Lcom_liveperson_infra_statemachine_interfaces_IState_ = JNIEnv.GetMethodID (class_ref, "changeState", "(Lcom/liveperson/infra/statemachine/interfaces/IState;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_changeState_Lcom_liveperson_infra_statemachine_interfaces_IState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "changeState", "(Lcom/liveperson/infra/statemachine/interfaces/IState;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_changeStateAndPassEvent_Lcom_liveperson_infra_statemachine_interfaces_IState_Lcom_liveperson_infra_statemachine_interfaces_IEvent_;
#pragma warning disable 0169
		static Delegate GetChangeStateAndPassEvent_Lcom_liveperson_infra_statemachine_interfaces_IState_Lcom_liveperson_infra_statemachine_interfaces_IEvent_Handler ()
		{
			if (cb_changeStateAndPassEvent_Lcom_liveperson_infra_statemachine_interfaces_IState_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ == null)
				cb_changeStateAndPassEvent_Lcom_liveperson_infra_statemachine_interfaces_IState_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ChangeStateAndPassEvent_Lcom_liveperson_infra_statemachine_interfaces_IState_Lcom_liveperson_infra_statemachine_interfaces_IEvent_);
			return cb_changeStateAndPassEvent_Lcom_liveperson_infra_statemachine_interfaces_IState_Lcom_liveperson_infra_statemachine_interfaces_IEvent_;
		}

		static void n_ChangeStateAndPassEvent_Lcom_liveperson_infra_statemachine_interfaces_IState_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Statemachine.BaseStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.BaseStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IState p0 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IState)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IState> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p1 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ChangeStateAndPassEvent (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_changeStateAndPassEvent_Lcom_liveperson_infra_statemachine_interfaces_IState_Lcom_liveperson_infra_statemachine_interfaces_IEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='BaseStateMachine']/method[@name='changeStateAndPassEvent' and count(parameter)=2 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IState'] and parameter[2][@type='com.liveperson.infra.statemachine.interfaces.IEvent']]"
		[Register ("changeStateAndPassEvent", "(Lcom/liveperson/infra/statemachine/interfaces/IState;Lcom/liveperson/infra/statemachine/interfaces/IEvent;)V", "GetChangeStateAndPassEvent_Lcom_liveperson_infra_statemachine_interfaces_IState_Lcom_liveperson_infra_statemachine_interfaces_IEvent_Handler")]
		public virtual unsafe void ChangeStateAndPassEvent (global::Com.Liveperson.Infra.Statemachine.Interfaces.IState p0, global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p1)
		{
			if (id_changeStateAndPassEvent_Lcom_liveperson_infra_statemachine_interfaces_IState_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ == IntPtr.Zero)
				id_changeStateAndPassEvent_Lcom_liveperson_infra_statemachine_interfaces_IState_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ = JNIEnv.GetMethodID (class_ref, "changeStateAndPassEvent", "(Lcom/liveperson/infra/statemachine/interfaces/IState;Lcom/liveperson/infra/statemachine/interfaces/IEvent;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_changeStateAndPassEvent_Lcom_liveperson_infra_statemachine_interfaces_IState_Lcom_liveperson_infra_statemachine_interfaces_IEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "changeStateAndPassEvent", "(Lcom/liveperson/infra/statemachine/interfaces/IState;Lcom/liveperson/infra/statemachine/interfaces/IEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_initActiveState_Lcom_liveperson_infra_statemachine_interfaces_IState_;
#pragma warning disable 0169
		static Delegate GetInitActiveState_Lcom_liveperson_infra_statemachine_interfaces_IState_Handler ()
		{
			if (cb_initActiveState_Lcom_liveperson_infra_statemachine_interfaces_IState_ == null)
				cb_initActiveState_Lcom_liveperson_infra_statemachine_interfaces_IState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InitActiveState_Lcom_liveperson_infra_statemachine_interfaces_IState_);
			return cb_initActiveState_Lcom_liveperson_infra_statemachine_interfaces_IState_;
		}

		static void n_InitActiveState_Lcom_liveperson_infra_statemachine_interfaces_IState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Statemachine.BaseStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.BaseStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IState p0 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IState)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InitActiveState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_initActiveState_Lcom_liveperson_infra_statemachine_interfaces_IState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='BaseStateMachine']/method[@name='initActiveState' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IState']]"
		[Register ("initActiveState", "(Lcom/liveperson/infra/statemachine/interfaces/IState;)V", "GetInitActiveState_Lcom_liveperson_infra_statemachine_interfaces_IState_Handler")]
		public virtual unsafe void InitActiveState (global::Com.Liveperson.Infra.Statemachine.Interfaces.IState p0)
		{
			if (id_initActiveState_Lcom_liveperson_infra_statemachine_interfaces_IState_ == IntPtr.Zero)
				id_initActiveState_Lcom_liveperson_infra_statemachine_interfaces_IState_ = JNIEnv.GetMethodID (class_ref, "initActiveState", "(Lcom/liveperson/infra/statemachine/interfaces/IState;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initActiveState_Lcom_liveperson_infra_statemachine_interfaces_IState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initActiveState", "(Lcom/liveperson/infra/statemachine/interfaces/IState;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_postDelayEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J;
#pragma warning disable 0169
		static Delegate GetPostDelayEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_JHandler ()
		{
			if (cb_postDelayEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J == null)
				cb_postDelayEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_PostDelayEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J);
			return cb_postDelayEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J;
		}

		static IntPtr n_PostDelayEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Liveperson.Infra.Statemachine.BaseStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.BaseStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PostDelayEvent (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_postDelayEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='BaseStateMachine']/method[@name='postDelayEvent' and count(parameter)=2 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IEvent'] and parameter[2][@type='long']]"
		[Register ("postDelayEvent", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;J)Ljava/lang/Runnable;", "GetPostDelayEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_JHandler")]
		public virtual unsafe global::Java.Lang.IRunnable PostDelayEvent (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0, long p1)
		{
			if (id_postDelayEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J == IntPtr.Zero)
				id_postDelayEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J = JNIEnv.GetMethodID (class_ref, "postDelayEvent", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;J)Ljava/lang/Runnable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Lang.IRunnable __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_postDelayEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postDelayEvent", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;J)Ljava/lang/Runnable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_postEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_;
#pragma warning disable 0169
		static Delegate GetPostEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_Handler ()
		{
			if (cb_postEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ == null)
				cb_postEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PostEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_);
			return cb_postEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_;
		}

		static void n_PostEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Statemachine.BaseStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.BaseStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PostEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_postEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='BaseStateMachine']/method[@name='postEvent' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IEvent']]"
		[Register ("postEvent", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;)V", "GetPostEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_Handler")]
		public virtual unsafe void PostEvent (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0)
		{
			if (id_postEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ == IntPtr.Zero)
				id_postEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ = JNIEnv.GetMethodID (class_ref, "postEvent", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_postEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postEvent", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setStateMachineExecutor_Lcom_liveperson_infra_statemachine_interfaces_IStateMachineExecutor_;
#pragma warning disable 0169
		static Delegate GetSetStateMachineExecutor_Lcom_liveperson_infra_statemachine_interfaces_IStateMachineExecutor_Handler ()
		{
			if (cb_setStateMachineExecutor_Lcom_liveperson_infra_statemachine_interfaces_IStateMachineExecutor_ == null)
				cb_setStateMachineExecutor_Lcom_liveperson_infra_statemachine_interfaces_IStateMachineExecutor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStateMachineExecutor_Lcom_liveperson_infra_statemachine_interfaces_IStateMachineExecutor_);
			return cb_setStateMachineExecutor_Lcom_liveperson_infra_statemachine_interfaces_IStateMachineExecutor_;
		}

		static void n_SetStateMachineExecutor_Lcom_liveperson_infra_statemachine_interfaces_IStateMachineExecutor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Statemachine.BaseStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.BaseStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineExecutor p0 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineExecutor)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineExecutor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetStateMachineExecutor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStateMachineExecutor_Lcom_liveperson_infra_statemachine_interfaces_IStateMachineExecutor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='BaseStateMachine']/method[@name='setStateMachineExecutor' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IStateMachineExecutor']]"
		[Register ("setStateMachineExecutor", "(Lcom/liveperson/infra/statemachine/interfaces/IStateMachineExecutor;)V", "GetSetStateMachineExecutor_Lcom_liveperson_infra_statemachine_interfaces_IStateMachineExecutor_Handler")]
		public virtual unsafe void SetStateMachineExecutor (global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineExecutor p0)
		{
			if (id_setStateMachineExecutor_Lcom_liveperson_infra_statemachine_interfaces_IStateMachineExecutor_ == IntPtr.Zero)
				id_setStateMachineExecutor_Lcom_liveperson_infra_statemachine_interfaces_IStateMachineExecutor_ = JNIEnv.GetMethodID (class_ref, "setStateMachineExecutor", "(Lcom/liveperson/infra/statemachine/interfaces/IStateMachineExecutor;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStateMachineExecutor_Lcom_liveperson_infra_statemachine_interfaces_IStateMachineExecutor_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStateMachineExecutor", "(Lcom/liveperson/infra/statemachine/interfaces/IStateMachineExecutor;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_shutDown;
#pragma warning disable 0169
		static Delegate GetShutDownHandler ()
		{
			if (cb_shutDown == null)
				cb_shutDown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShutDown);
			return cb_shutDown;
		}

		static void n_ShutDown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Statemachine.BaseStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.BaseStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShutDown ();
		}
#pragma warning restore 0169

		static IntPtr id_shutDown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='BaseStateMachine']/method[@name='shutDown' and count(parameter)=0]"
		[Register ("shutDown", "()V", "GetShutDownHandler")]
		public virtual unsafe void ShutDown ()
		{
			if (id_shutDown == IntPtr.Zero)
				id_shutDown = JNIEnv.GetMethodID (class_ref, "shutDown", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutDown);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shutDown", "()V"));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/statemachine/BaseStateMachine", DoNotGenerateAcw=true)]
	internal partial class BaseStateMachineInvoker : BaseStateMachine, global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine {

		public BaseStateMachineInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseStateMachineInvoker); }
		}

	}

}
