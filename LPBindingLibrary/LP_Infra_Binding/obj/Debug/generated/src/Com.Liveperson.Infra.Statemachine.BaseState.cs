using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Statemachine {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='BaseState']"
	[global::Android.Runtime.Register ("com/liveperson/infra/statemachine/BaseState", DoNotGenerateAcw=true)]
	public abstract partial class BaseState : global::Java.Lang.Object, global::Com.Liveperson.Infra.Statemachine.Interfaces.IState {


		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='BaseState']/field[@name='name']"
		[Register ("name")]
		protected string Name {
			get {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, name_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, name_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr parent_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='BaseState']/field[@name='parent']"
		[Register ("parent")]
		protected global::Com.Liveperson.Infra.Statemachine.BaseState Parent {
			get {
				if (parent_jfieldId == IntPtr.Zero)
					parent_jfieldId = JNIEnv.GetFieldID (class_ref, "parent", "Lcom/liveperson/infra/statemachine/BaseState;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, parent_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.BaseState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (parent_jfieldId == IntPtr.Zero)
					parent_jfieldId = JNIEnv.GetFieldID (class_ref, "parent", "Lcom/liveperson/infra/statemachine/BaseState;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, parent_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/statemachine/BaseState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseState); }
		}

		protected BaseState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_infra_statemachine_BaseState_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='BaseState']/constructor[@name='BaseState' and count(parameter)=3 and parameter[1][@type='com.liveperson.infra.statemachine.BaseState'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/liveperson/infra/statemachine/BaseState;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe BaseState (global::Com.Liveperson.Infra.Statemachine.BaseState p0, string p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (BaseState)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/infra/statemachine/BaseState;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/infra/statemachine/BaseState;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_infra_statemachine_BaseState_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_infra_statemachine_BaseState_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/statemachine/BaseState;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_statemachine_BaseState_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_statemachine_BaseState_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_actionOnEntry;
#pragma warning disable 0169
		static Delegate GetActionOnEntryHandler ()
		{
			if (cb_actionOnEntry == null)
				cb_actionOnEntry = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ActionOnEntry);
			return cb_actionOnEntry;
		}

		static void n_ActionOnEntry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Statemachine.BaseState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.BaseState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ActionOnEntry ();
		}
#pragma warning restore 0169

		static IntPtr id_actionOnEntry;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='BaseState']/method[@name='actionOnEntry' and count(parameter)=0]"
		[Register ("actionOnEntry", "()V", "GetActionOnEntryHandler")]
		public virtual unsafe void ActionOnEntry ()
		{
			if (id_actionOnEntry == IntPtr.Zero)
				id_actionOnEntry = JNIEnv.GetMethodID (class_ref, "actionOnEntry", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_actionOnEntry);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "actionOnEntry", "()V"));
			} finally {
			}
		}

		static Delegate cb_actionOnExit;
#pragma warning disable 0169
		static Delegate GetActionOnExitHandler ()
		{
			if (cb_actionOnExit == null)
				cb_actionOnExit = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ActionOnExit);
			return cb_actionOnExit;
		}

		static void n_ActionOnExit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Statemachine.BaseState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.BaseState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ActionOnExit ();
		}
#pragma warning restore 0169

		static IntPtr id_actionOnExit;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='BaseState']/method[@name='actionOnExit' and count(parameter)=0]"
		[Register ("actionOnExit", "()V", "GetActionOnExitHandler")]
		public virtual unsafe void ActionOnExit ()
		{
			if (id_actionOnExit == IntPtr.Zero)
				id_actionOnExit = JNIEnv.GetMethodID (class_ref, "actionOnExit", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_actionOnExit);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "actionOnExit", "()V"));
			} finally {
			}
		}

		static Delegate cb_handleDefaultEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_;
#pragma warning disable 0169
		static Delegate GetHandleDefaultEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_Handler ()
		{
			if (cb_handleDefaultEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ == null)
				cb_handleDefaultEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleDefaultEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_);
			return cb_handleDefaultEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_;
		}

		static void n_HandleDefaultEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Statemachine.BaseState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.BaseState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleDefaultEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_handleDefaultEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine']/class[@name='BaseState']/method[@name='handleDefaultEvent' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IEvent']]"
		[Register ("handleDefaultEvent", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;)V", "GetHandleDefaultEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_Handler")]
		protected virtual unsafe void HandleDefaultEvent (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0)
		{
			if (id_handleDefaultEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ == IntPtr.Zero)
				id_handleDefaultEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_ = JNIEnv.GetMethodID (class_ref, "handleDefaultEvent", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleDefaultEvent_Lcom_liveperson_infra_statemachine_interfaces_IEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleDefaultEvent", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/statemachine/BaseState", DoNotGenerateAcw=true)]
	internal partial class BaseStateInvoker : BaseState {

		public BaseStateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseStateInvoker); }
		}

	}

}
