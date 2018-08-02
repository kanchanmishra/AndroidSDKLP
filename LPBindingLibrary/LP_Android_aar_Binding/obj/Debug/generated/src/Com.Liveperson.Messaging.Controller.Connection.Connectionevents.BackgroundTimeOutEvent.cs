using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Controller.Connection.Connectionevents {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller.connection.connectionevents']/class[@name='BackgroundTimeOutEvent']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/connectionevents/BackgroundTimeOutEvent", DoNotGenerateAcw=true)]
	public partial class BackgroundTimeOutEvent : global::Com.Liveperson.Infra.Statemachine.BaseEvent {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/controller/connection/connectionevents/BackgroundTimeOutEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BackgroundTimeOutEvent); }
		}

		protected BackgroundTimeOutEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller.connection.connectionevents']/class[@name='BackgroundTimeOutEvent']/constructor[@name='BackgroundTimeOutEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BackgroundTimeOutEvent ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BackgroundTimeOutEvent)) {
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
			global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.BackgroundTimeOutEvent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.BackgroundTimeOutEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IState p0 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IState)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Accept (p0);
		}
#pragma warning restore 0169

		static IntPtr id_accept_Lcom_liveperson_infra_statemachine_interfaces_IState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection.connectionevents']/class[@name='BackgroundTimeOutEvent']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IState']]"
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
