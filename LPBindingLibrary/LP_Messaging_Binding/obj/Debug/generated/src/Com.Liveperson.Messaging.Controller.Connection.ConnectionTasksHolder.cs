using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Controller.Connection {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionTasksHolder']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/ConnectionTasksHolder", DoNotGenerateAcw=true)]
	public partial class ConnectionTasksHolder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/controller/connection/ConnectionTasksHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectionTasksHolder); }
		}

		protected ConnectionTasksHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_Lcom_liveperson_messaging_controller_connection_MessagingStateMachineInterface_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionTasksHolder']/constructor[@name='ConnectionTasksHolder' and count(parameter)=3 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IStateMachine'] and parameter[2][@type='com.liveperson.messaging.controller.connection.MessagingStateMachineInterface'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/liveperson/infra/statemachine/interfaces/IStateMachine;Lcom/liveperson/messaging/controller/connection/MessagingStateMachineInterface;Ljava/lang/String;)V", "")]
		public unsafe ConnectionTasksHolder (global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine p0, global::Com.Liveperson.Messaging.Controller.Connection.IMessagingStateMachineInterface p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (ConnectionTasksHolder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/infra/statemachine/interfaces/IStateMachine;Lcom/liveperson/messaging/controller/connection/MessagingStateMachineInterface;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/infra/statemachine/interfaces/IStateMachine;Lcom/liveperson/messaging/controller/connection/MessagingStateMachineInterface;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_Lcom_liveperson_messaging_controller_connection_MessagingStateMachineInterface_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_Lcom_liveperson_messaging_controller_connection_MessagingStateMachineInterface_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/statemachine/interfaces/IStateMachine;Lcom/liveperson/messaging/controller/connection/MessagingStateMachineInterface;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_Lcom_liveperson_messaging_controller_connection_MessagingStateMachineInterface_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_Lcom_liveperson_messaging_controller_connection_MessagingStateMachineInterface_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_constructPrimaryFullConnectionTasks;
#pragma warning disable 0169
		static Delegate GetConstructPrimaryFullConnectionTasksHandler ()
		{
			if (cb_constructPrimaryFullConnectionTasks == null)
				cb_constructPrimaryFullConnectionTasks = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ConstructPrimaryFullConnectionTasks);
			return cb_constructPrimaryFullConnectionTasks;
		}

		static IntPtr n_ConstructPrimaryFullConnectionTasks (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionTasksHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionTasksHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.ToLocalJniHandle (__this.ConstructPrimaryFullConnectionTasks ());
		}
#pragma warning restore 0169

		static IntPtr id_constructPrimaryFullConnectionTasks;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionTasksHolder']/method[@name='constructPrimaryFullConnectionTasks' and count(parameter)=0]"
		[Register ("constructPrimaryFullConnectionTasks", "()Ljava/util/List;", "GetConstructPrimaryFullConnectionTasksHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask> ConstructPrimaryFullConnectionTasks ()
		{
			if (id_constructPrimaryFullConnectionTasks == IntPtr.Zero)
				id_constructPrimaryFullConnectionTasks = JNIEnv.GetMethodID (class_ref, "constructPrimaryFullConnectionTasks", "()Ljava/util/List;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_constructPrimaryFullConnectionTasks), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "constructPrimaryFullConnectionTasks", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_constructPrimaryShortConnectionTasks;
#pragma warning disable 0169
		static Delegate GetConstructPrimaryShortConnectionTasksHandler ()
		{
			if (cb_constructPrimaryShortConnectionTasks == null)
				cb_constructPrimaryShortConnectionTasks = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ConstructPrimaryShortConnectionTasks);
			return cb_constructPrimaryShortConnectionTasks;
		}

		static IntPtr n_ConstructPrimaryShortConnectionTasks (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionTasksHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionTasksHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.ToLocalJniHandle (__this.ConstructPrimaryShortConnectionTasks ());
		}
#pragma warning restore 0169

		static IntPtr id_constructPrimaryShortConnectionTasks;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionTasksHolder']/method[@name='constructPrimaryShortConnectionTasks' and count(parameter)=0]"
		[Register ("constructPrimaryShortConnectionTasks", "()Ljava/util/List;", "GetConstructPrimaryShortConnectionTasksHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask> ConstructPrimaryShortConnectionTasks ()
		{
			if (id_constructPrimaryShortConnectionTasks == IntPtr.Zero)
				id_constructPrimaryShortConnectionTasks = JNIEnv.GetMethodID (class_ref, "constructPrimaryShortConnectionTasks", "()Ljava/util/List;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_constructPrimaryShortConnectionTasks), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "constructPrimaryShortConnectionTasks", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_constructSecondaryConnectionTasks;
#pragma warning disable 0169
		static Delegate GetConstructSecondaryConnectionTasksHandler ()
		{
			if (cb_constructSecondaryConnectionTasks == null)
				cb_constructSecondaryConnectionTasks = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ConstructSecondaryConnectionTasks);
			return cb_constructSecondaryConnectionTasks;
		}

		static IntPtr n_ConstructSecondaryConnectionTasks (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionTasksHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionTasksHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.ToLocalJniHandle (__this.ConstructSecondaryConnectionTasks ());
		}
#pragma warning restore 0169

		static IntPtr id_constructSecondaryConnectionTasks;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionTasksHolder']/method[@name='constructSecondaryConnectionTasks' and count(parameter)=0]"
		[Register ("constructSecondaryConnectionTasks", "()Ljava/util/List;", "GetConstructSecondaryConnectionTasksHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask> ConstructSecondaryConnectionTasks ()
		{
			if (id_constructSecondaryConnectionTasks == IntPtr.Zero)
				id_constructSecondaryConnectionTasks = JNIEnv.GetMethodID (class_ref, "constructSecondaryConnectionTasks", "()Ljava/util/List;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_constructSecondaryConnectionTasks), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "constructSecondaryConnectionTasks", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getDisconnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_;
#pragma warning disable 0169
		static Delegate GetGetDisconnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_Handler ()
		{
			if (cb_getDisconnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_ == null)
				cb_getDisconnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDisconnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_);
			return cb_getDisconnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_;
		}

		static IntPtr n_GetDisconnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionTasksHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionTasksHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine p0 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.ToLocalJniHandle (__this.GetDisconnectionTasks (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDisconnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionTasksHolder']/method[@name='getDisconnectionTasks' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IStateMachine']]"
		[Register ("getDisconnectionTasks", "(Lcom/liveperson/infra/statemachine/interfaces/IStateMachine;)Ljava/util/List;", "GetGetDisconnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask> GetDisconnectionTasks (global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine p0)
		{
			if (id_getDisconnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_ == IntPtr.Zero)
				id_getDisconnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_ = JNIEnv.GetMethodID (class_ref, "getDisconnectionTasks", "(Lcom/liveperson/infra/statemachine/interfaces/IStateMachine;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisconnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisconnectionTasks", "(Lcom/liveperson/infra/statemachine/interfaces/IStateMachine;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getPrimaryFullConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_;
#pragma warning disable 0169
		static Delegate GetGetPrimaryFullConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_Handler ()
		{
			if (cb_getPrimaryFullConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_ == null)
				cb_getPrimaryFullConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPrimaryFullConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_);
			return cb_getPrimaryFullConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_;
		}

		static IntPtr n_GetPrimaryFullConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionTasksHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionTasksHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine p0 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.ToLocalJniHandle (__this.GetPrimaryFullConnectionTasks (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPrimaryFullConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionTasksHolder']/method[@name='getPrimaryFullConnectionTasks' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IStateMachine']]"
		[Register ("getPrimaryFullConnectionTasks", "(Lcom/liveperson/infra/statemachine/interfaces/IStateMachine;)Ljava/util/List;", "GetGetPrimaryFullConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask> GetPrimaryFullConnectionTasks (global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine p0)
		{
			if (id_getPrimaryFullConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_ == IntPtr.Zero)
				id_getPrimaryFullConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_ = JNIEnv.GetMethodID (class_ref, "getPrimaryFullConnectionTasks", "(Lcom/liveperson/infra/statemachine/interfaces/IStateMachine;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrimaryFullConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrimaryFullConnectionTasks", "(Lcom/liveperson/infra/statemachine/interfaces/IStateMachine;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getPrimaryShortConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_;
#pragma warning disable 0169
		static Delegate GetGetPrimaryShortConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_Handler ()
		{
			if (cb_getPrimaryShortConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_ == null)
				cb_getPrimaryShortConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPrimaryShortConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_);
			return cb_getPrimaryShortConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_;
		}

		static IntPtr n_GetPrimaryShortConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionTasksHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionTasksHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine p0 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.ToLocalJniHandle (__this.GetPrimaryShortConnectionTasks (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPrimaryShortConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionTasksHolder']/method[@name='getPrimaryShortConnectionTasks' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IStateMachine']]"
		[Register ("getPrimaryShortConnectionTasks", "(Lcom/liveperson/infra/statemachine/interfaces/IStateMachine;)Ljava/util/List;", "GetGetPrimaryShortConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask> GetPrimaryShortConnectionTasks (global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine p0)
		{
			if (id_getPrimaryShortConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_ == IntPtr.Zero)
				id_getPrimaryShortConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_ = JNIEnv.GetMethodID (class_ref, "getPrimaryShortConnectionTasks", "(Lcom/liveperson/infra/statemachine/interfaces/IStateMachine;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrimaryShortConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrimaryShortConnectionTasks", "(Lcom/liveperson/infra/statemachine/interfaces/IStateMachine;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getSecondaryConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_;
#pragma warning disable 0169
		static Delegate GetGetSecondaryConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_Handler ()
		{
			if (cb_getSecondaryConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_ == null)
				cb_getSecondaryConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSecondaryConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_);
			return cb_getSecondaryConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_;
		}

		static IntPtr n_GetSecondaryConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionTasksHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionTasksHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine p0 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.ToLocalJniHandle (__this.GetSecondaryConnectionTasks (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSecondaryConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionTasksHolder']/method[@name='getSecondaryConnectionTasks' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IStateMachine']]"
		[Register ("getSecondaryConnectionTasks", "(Lcom/liveperson/infra/statemachine/interfaces/IStateMachine;)Ljava/util/List;", "GetGetSecondaryConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask> GetSecondaryConnectionTasks (global::Com.Liveperson.Infra.Statemachine.Interfaces.IStateMachine p0)
		{
			if (id_getSecondaryConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_ == IntPtr.Zero)
				id_getSecondaryConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_ = JNIEnv.GetMethodID (class_ref, "getSecondaryConnectionTasks", "(Lcom/liveperson/infra/statemachine/interfaces/IStateMachine;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSecondaryConnectionTasks_Lcom_liveperson_infra_statemachine_interfaces_IStateMachine_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSecondaryConnectionTasks", "(Lcom/liveperson/infra/statemachine/interfaces/IStateMachine;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
