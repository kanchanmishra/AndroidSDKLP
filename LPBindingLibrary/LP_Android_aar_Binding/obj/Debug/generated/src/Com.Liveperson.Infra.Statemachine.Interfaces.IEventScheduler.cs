using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Statemachine.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.statemachine.interfaces']/interface[@name='IEventScheduler.Cancelable']"
	[Register ("com/liveperson/infra/statemachine/interfaces/IEventScheduler$Cancelable", "", "Com.Liveperson.Infra.Statemachine.Interfaces.IEventSchedulerCancelableInvoker")]
	public partial interface IEventSchedulerCancelable : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine.interfaces']/interface[@name='IEventScheduler.Cancelable']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler:Com.Liveperson.Infra.Statemachine.Interfaces.IEventSchedulerCancelableInvoker, LP_Android_aar_Binding")]
		void Cancel ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/statemachine/interfaces/IEventScheduler$Cancelable", DoNotGenerateAcw=true)]
	internal class IEventSchedulerCancelableInvoker : global::Java.Lang.Object, IEventSchedulerCancelable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/statemachine/interfaces/IEventScheduler$Cancelable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IEventSchedulerCancelableInvoker); }
		}

		IntPtr class_ref;

		public static IEventSchedulerCancelable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEventSchedulerCancelable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.statemachine.interfaces.IEventScheduler.Cancelable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEventSchedulerCancelableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IEventSchedulerCancelable __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IEventSchedulerCancelable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		IntPtr id_cancel;
		public unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.statemachine.interfaces']/interface[@name='IEventScheduler']"
	[Register ("com/liveperson/infra/statemachine/interfaces/IEventScheduler", "", "Com.Liveperson.Infra.Statemachine.Interfaces.IEventSchedulerInvoker")]
	public partial interface IEventScheduler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine.interfaces']/interface[@name='IEventScheduler']/method[@name='schedule' and count(parameter)=2 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IEvent'] and parameter[2][@type='long']]"
		[Register ("schedule", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;J)Lcom/liveperson/infra/statemachine/interfaces/IEventScheduler$Cancelable;", "GetSchedule_Lcom_liveperson_infra_statemachine_interfaces_IEvent_JHandler:Com.Liveperson.Infra.Statemachine.Interfaces.IEventSchedulerInvoker, LP_Android_aar_Binding")]
		global::Com.Liveperson.Infra.Statemachine.Interfaces.IEventSchedulerCancelable Schedule (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.statemachine.interfaces']/interface[@name='IEventScheduler']/method[@name='shutdown' and count(parameter)=0]"
		[Register ("shutdown", "()V", "GetShutdownHandler:Com.Liveperson.Infra.Statemachine.Interfaces.IEventSchedulerInvoker, LP_Android_aar_Binding")]
		void Shutdown ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/statemachine/interfaces/IEventScheduler", DoNotGenerateAcw=true)]
	internal class IEventSchedulerInvoker : global::Java.Lang.Object, IEventScheduler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/statemachine/interfaces/IEventScheduler");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IEventSchedulerInvoker); }
		}

		IntPtr class_ref;

		public static IEventScheduler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEventScheduler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.statemachine.interfaces.IEventScheduler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEventSchedulerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IEventScheduler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IEventScheduler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Schedule (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_schedule_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J;
		public unsafe global::Com.Liveperson.Infra.Statemachine.Interfaces.IEventSchedulerCancelable Schedule (global::Com.Liveperson.Infra.Statemachine.Interfaces.IEvent p0, long p1)
		{
			if (id_schedule_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J == IntPtr.Zero)
				id_schedule_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J = JNIEnv.GetMethodID (class_ref, "schedule", "(Lcom/liveperson/infra/statemachine/interfaces/IEvent;J)Lcom/liveperson/infra/statemachine/interfaces/IEventScheduler$Cancelable;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IEventSchedulerCancelable __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IEventSchedulerCancelable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_schedule_Lcom_liveperson_infra_statemachine_interfaces_IEvent_J, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IEventScheduler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IEventScheduler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
