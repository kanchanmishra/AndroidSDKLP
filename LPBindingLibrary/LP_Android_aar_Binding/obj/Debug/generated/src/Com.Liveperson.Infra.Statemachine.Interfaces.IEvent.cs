using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Statemachine.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.statemachine.interfaces']/interface[@name='IEvent']"
	[Register ("com/liveperson/infra/statemachine/interfaces/IEvent", "", "Com.Liveperson.Infra.Statemachine.Interfaces.IEventInvoker")]
	public partial interface IEvent : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine.interfaces']/interface[@name='IEvent']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IState']]"
		[Register ("accept", "(Lcom/liveperson/infra/statemachine/interfaces/IState;)V", "GetAccept_Lcom_liveperson_infra_statemachine_interfaces_IState_Handler:Com.Liveperson.Infra.Statemachine.Interfaces.IEventInvoker, LP_Android_aar_Binding")]
		void Accept (global::Com.Liveperson.Infra.Statemachine.Interfaces.IState p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/statemachine/interfaces/IEvent", DoNotGenerateAcw=true)]
	internal class IEventInvoker : global::Java.Lang.Object, IEvent {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/statemachine/interfaces/IEvent");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IEventInvoker); }
		}

		IntPtr class_ref;

		public static IEvent GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEvent> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.statemachine.interfaces.IEvent"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEventInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IState p0 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IState)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Accept (p0);
		}
#pragma warning restore 0169

		IntPtr id_accept_Lcom_liveperson_infra_statemachine_interfaces_IState_;
		public unsafe void Accept (global::Com.Liveperson.Infra.Statemachine.Interfaces.IState p0)
		{
			if (id_accept_Lcom_liveperson_infra_statemachine_interfaces_IState_ == IntPtr.Zero)
				id_accept_Lcom_liveperson_infra_statemachine_interfaces_IState_ = JNIEnv.GetMethodID (class_ref, "accept", "(Lcom/liveperson/infra/statemachine/interfaces/IState;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_accept_Lcom_liveperson_infra_statemachine_interfaces_IState_, __args);
		}

	}

}
