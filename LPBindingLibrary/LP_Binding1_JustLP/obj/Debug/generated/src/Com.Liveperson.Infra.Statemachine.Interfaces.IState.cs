using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Statemachine.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.statemachine.interfaces']/interface[@name='IState']"
	[Register ("com/liveperson/infra/statemachine/interfaces/IState", "", "Com.Liveperson.Infra.Statemachine.Interfaces.IStateInvoker")]
	public partial interface IState : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine.interfaces']/interface[@name='IState']/method[@name='actionOnEntry' and count(parameter)=0]"
		[Register ("actionOnEntry", "()V", "GetActionOnEntryHandler:Com.Liveperson.Infra.Statemachine.Interfaces.IStateInvoker, LP_Binding1_JustLP")]
		void ActionOnEntry ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine.interfaces']/interface[@name='IState']/method[@name='actionOnExit' and count(parameter)=0]"
		[Register ("actionOnExit", "()V", "GetActionOnExitHandler:Com.Liveperson.Infra.Statemachine.Interfaces.IStateInvoker, LP_Binding1_JustLP")]
		void ActionOnExit ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/statemachine/interfaces/IState", DoNotGenerateAcw=true)]
	internal class IStateInvoker : global::Java.Lang.Object, IState {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/statemachine/interfaces/IState");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IStateInvoker); }
		}

		IntPtr class_ref;

		public static IState GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IState> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.statemachine.interfaces.IState"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ActionOnEntry ();
		}
#pragma warning restore 0169

		IntPtr id_actionOnEntry;
		public unsafe void ActionOnEntry ()
		{
			if (id_actionOnEntry == IntPtr.Zero)
				id_actionOnEntry = JNIEnv.GetMethodID (class_ref, "actionOnEntry", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_actionOnEntry);
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
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ActionOnExit ();
		}
#pragma warning restore 0169

		IntPtr id_actionOnExit;
		public unsafe void ActionOnExit ()
		{
			if (id_actionOnExit == IntPtr.Zero)
				id_actionOnExit = JNIEnv.GetMethodID (class_ref, "actionOnExit", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_actionOnExit);
		}

	}

}
