using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Statemachine.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.statemachine.interfaces']/interface[@name='IStateMachine']"
	[Register ("com/liveperson/infra/statemachine/interfaces/IStateMachine", "", "Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"STATE extends com.liveperson.infra.statemachine.interfaces.IState"})]
	public partial interface IStateMachine : IJavaObject {

		string Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine.interfaces']/interface[@name='IStateMachine']/method[@name='getTag' and count(parameter)=0]"
			[Register ("getTag", "()Ljava/lang/String;", "GetGetTagHandler:Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineInvoker, LP_Android_aar_Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine.interfaces']/interface[@name='IStateMachine']/method[@name='activeState' and count(parameter)=0]"
		[Register ("activeState", "()Lcom/liveperson/infra/statemachine/interfaces/IState;", "GetActiveStateHandler:Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineInvoker, LP_Android_aar_Binding")]
		global::Java.Lang.Object ActiveState ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine.interfaces']/interface[@name='IStateMachine']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IEvent']]"
		[Register ("apply", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;)V", "GetApply_Lcom_liveperson_infra_statemachine_interfaces_IEvent_Handler:Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineInvoker, LP_Android_aar_Binding")]
		void Apply (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine.interfaces']/interface[@name='IStateMachine']/method[@name='changeState' and count(parameter)=1 and parameter[1][@type='STATE']]"
		[Register ("changeState", "(Lcom/liveperson/infra/statemachine/interfaces/IState;)V", "GetChangeState_Lcom_liveperson_infra_statemachine_interfaces_IState_Handler:Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineInvoker, LP_Android_aar_Binding")]
		void ChangeState (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine.interfaces']/interface[@name='IStateMachine']/method[@name='initActiveState' and count(parameter)=1 and parameter[1][@type='STATE']]"
		[Register ("initActiveState", "(Lcom/liveperson/infra/statemachine/interfaces/IState;)V", "GetInitActiveState_Lcom_liveperson_infra_statemachine_interfaces_IState_Handler:Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineInvoker, LP_Android_aar_Binding")]
		void InitActiveState (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine.interfaces']/interface[@name='IStateMachine']/method[@name='postDelayEvent' and count(parameter)=2 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IEvent'] and parameter[2][@type='long']]"
		[Register ("postDelayEvent", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;J)Ljava/lang/Runnable;", "GetPostDelayEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_JHandler:Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineInvoker, LP_Android_aar_Binding")]
		global::Java.Lang.IRunnable PostDelayEvent (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine.interfaces']/interface[@name='IStateMachine']/method[@name='postEvent' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IEvent']]"
		[Register ("postEvent", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;)V", "GetPostEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_Handler:Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineInvoker, LP_Android_aar_Binding")]
		void PostEvent (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine.interfaces']/interface[@name='IStateMachine']/method[@name='setStateMachineExecutor' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IStateMachineExecutor']]"
		[Register ("setStateMachineExecutor", "(Lcom/liveperson/infra/statemachine/interfaces/IStateMachineExecutor;)V", "GetSetStateMachineExecutor_Lcom_liveperson_infra_statemachine_interfaces_IStateMachineExecutor_Handler:Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineInvoker, LP_Android_aar_Binding")]
		void SetStateMachineExecutor (global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineExecutor p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/statemachine/interfaces/IStateMachine", DoNotGenerateAcw=true)]
	internal class IStateMachineInvoker : global::Java.Lang.Object, IStateMachine {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/statemachine/interfaces/IStateMachine");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IStateMachineInvoker); }
		}

		IntPtr class_ref;

		public static IStateMachine GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStateMachine> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.statemachine.interfaces.IStateMachine"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStateMachineInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Tag);
		}
#pragma warning restore 0169

		IntPtr id_getTag;
		public unsafe string Tag {
			get {
				if (id_getTag == IntPtr.Zero)
					id_getTag = JNIEnv.GetMethodID (class_ref, "getTag", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTag), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ActiveState ());
		}
#pragma warning restore 0169

		IntPtr id_activeState;
		public unsafe global::Java.Lang.Object ActiveState ()
		{
			if (id_activeState == IntPtr.Zero)
				id_activeState = JNIEnv.GetMethodID (class_ref, "activeState", "()Lcom/liveperson/infra/statemachine/interfaces/IState;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_activeState), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Apply (p0);
		}
#pragma warning restore 0169

		IntPtr id_apply_Lcom_liveperson_infra_statemachine_interfaces_IEvent_;
		public unsafe void Apply (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0)
		{
			if (id_apply_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ == IntPtr.Zero)
				id_apply_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ = JNIEnv.GetMethodID (class_ref, "apply", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_apply_Lcom_liveperson_infra_statemachine_interfaces_IEvent_, __args);
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
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChangeState (p0);
		}
#pragma warning restore 0169

		IntPtr id_changeState_Lcom_liveperson_infra_statemachine_interfaces_IState_;
		public unsafe void ChangeState (global::Java.Lang.Object p0)
		{
			if (id_changeState_Lcom_liveperson_infra_statemachine_interfaces_IState_ == IntPtr.Zero)
				id_changeState_Lcom_liveperson_infra_statemachine_interfaces_IState_ = JNIEnv.GetMethodID (class_ref, "changeState", "(Lcom/liveperson/infra/statemachine/interfaces/IState;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_changeState_Lcom_liveperson_infra_statemachine_interfaces_IState_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InitActiveState (p0);
		}
#pragma warning restore 0169

		IntPtr id_initActiveState_Lcom_liveperson_infra_statemachine_interfaces_IState_;
		public unsafe void InitActiveState (global::Java.Lang.Object p0)
		{
			if (id_initActiveState_Lcom_liveperson_infra_statemachine_interfaces_IState_ == IntPtr.Zero)
				id_initActiveState_Lcom_liveperson_infra_statemachine_interfaces_IState_ = JNIEnv.GetMethodID (class_ref, "initActiveState", "(Lcom/liveperson/infra/statemachine/interfaces/IState;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initActiveState_Lcom_liveperson_infra_statemachine_interfaces_IState_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PostDelayEvent (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_postDelayEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J;
		public unsafe global::Java.Lang.IRunnable PostDelayEvent (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0, long p1)
		{
			if (id_postDelayEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J == IntPtr.Zero)
				id_postDelayEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J = JNIEnv.GetMethodID (class_ref, "postDelayEvent", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;J)Ljava/lang/Runnable;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			global::Java.Lang.IRunnable __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_postDelayEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PostEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_postEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_;
		public unsafe void PostEvent (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0)
		{
			if (id_postEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ == IntPtr.Zero)
				id_postEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ = JNIEnv.GetMethodID (class_ref, "postEvent", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_postEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_, __args);
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
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineExecutor p0 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineExecutor)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineExecutor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetStateMachineExecutor (p0);
		}
#pragma warning restore 0169

		IntPtr id_setStateMachineExecutor_Lcom_liveperson_infra_statemachine_interfaces_IStateMachineExecutor_;
		public unsafe void SetStateMachineExecutor (global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachineExecutor p0)
		{
			if (id_setStateMachineExecutor_Lcom_liveperson_infra_statemachine_interfaces_IStateMachineExecutor_ == IntPtr.Zero)
				id_setStateMachineExecutor_Lcom_liveperson_infra_statemachine_interfaces_IStateMachineExecutor_ = JNIEnv.GetMethodID (class_ref, "setStateMachineExecutor", "(Lcom/liveperson/infra/statemachine/interfaces/IStateMachineExecutor;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStateMachineExecutor_Lcom_liveperson_infra_statemachine_interfaces_IStateMachineExecutor_, __args);
		}

	}

}
