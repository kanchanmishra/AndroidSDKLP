using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Controller.Connection.Connectionevents {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller.connection.connectionevents']/class[@name='TaskTimeOutEvent']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/connectionevents/TaskTimeOutEvent", DoNotGenerateAcw=true)]
	public partial class TaskTimeOutEvent : global::Com.Liveperson.Infra.Statemachine.BaseEvent {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller.connection.connectionevents']/class[@name='TaskTimeOutEvent.NullTaskCallbackAmsAccount']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/connectionevents/TaskTimeOutEvent$NullTaskCallbackAmsAccount", DoNotGenerateAcw=true)]
		public partial class NullTaskCallbackAmsAccount : global::Java.Lang.Object, global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsAccountConnectionCallback {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/controller/connection/connectionevents/TaskTimeOutEvent$NullTaskCallbackAmsAccount", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NullTaskCallbackAmsAccount); }
			}

			protected NullTaskCallbackAmsAccount (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskTimeOutEvent_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller.connection.connectionevents']/class[@name='TaskTimeOutEvent.NullTaskCallbackAmsAccount']/constructor[@name='TaskTimeOutEvent.NullTaskCallbackAmsAccount' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.controller.connection.connectionevents.TaskTimeOutEvent']]"
			[Register (".ctor", "(Lcom/liveperson/messaging/controller/connection/connectionevents/TaskTimeOutEvent;)V", "")]
			public unsafe NullTaskCallbackAmsAccount (global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.TaskTimeOutEvent __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (NullTaskCallbackAmsAccount)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskTimeOutEvent_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskTimeOutEvent_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/controller/connection/connectionevents/TaskTimeOutEvent;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskTimeOutEvent_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskTimeOutEvent_, __args);
				} finally {
				}
			}

			static Delegate cb_onTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Exception_;
#pragma warning disable 0169
			static Delegate GetOnTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Exception_Handler ()
			{
				if (cb_onTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Exception_ == null)
					cb_onTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Exception_);
				return cb_onTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Exception_;
			}

			static void n_OnTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.TaskTimeOutEvent.NullTaskCallbackAmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.TaskTimeOutEvent.NullTaskCallbackAmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Liveperson.Messaging.TaskType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.TaskType> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Exception p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnTaskError (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Exception_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection.connectionevents']/class[@name='TaskTimeOutEvent.NullTaskCallbackAmsAccount']/method[@name='onTaskError' and count(parameter)=2 and parameter[1][@type='com.liveperson.messaging.TaskType'] and parameter[2][@type='java.lang.Exception']]"
			[Register ("onTaskError", "(Lcom/liveperson/messaging/TaskType;Ljava/lang/Exception;)V", "GetOnTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Exception_Handler")]
			public virtual unsafe void OnTaskError (global::Com.Liveperson.Messaging.TaskType p0, global::Java.Lang.Exception p1)
			{
				if (id_onTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Exception_ == IntPtr.Zero)
					id_onTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onTaskError", "(Lcom/liveperson/messaging/TaskType;Ljava/lang/Exception;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Exception_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTaskError", "(Lcom/liveperson/messaging/TaskType;Ljava/lang/Exception;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetOnTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Throwable_Handler ()
			{
				if (cb_onTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Throwable_ == null)
					cb_onTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Throwable_);
				return cb_onTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Throwable_;
			}

			static void n_OnTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.TaskTimeOutEvent.NullTaskCallbackAmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.TaskTimeOutEvent.NullTaskCallbackAmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Liveperson.Messaging.TaskType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.TaskType> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnTaskError (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Throwable_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection.connectionevents']/class[@name='TaskTimeOutEvent.NullTaskCallbackAmsAccount']/method[@name='onTaskError' and count(parameter)=2 and parameter[1][@type='com.liveperson.messaging.TaskType'] and parameter[2][@type='java.lang.Throwable']]"
			[Register ("onTaskError", "(Lcom/liveperson/messaging/TaskType;Ljava/lang/Throwable;)V", "GetOnTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Throwable_Handler")]
			public virtual unsafe void OnTaskError (global::Com.Liveperson.Messaging.TaskType p0, global::Java.Lang.Throwable p1)
			{
				if (id_onTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_onTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onTaskError", "(Lcom/liveperson/messaging/TaskType;Ljava/lang/Throwable;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Throwable_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTaskError", "(Lcom/liveperson/messaging/TaskType;Ljava/lang/Throwable;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onTaskSuccess;
#pragma warning disable 0169
			static Delegate GetOnTaskSuccessHandler ()
			{
				if (cb_onTaskSuccess == null)
					cb_onTaskSuccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnTaskSuccess);
				return cb_onTaskSuccess;
			}

			static void n_OnTaskSuccess (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.TaskTimeOutEvent.NullTaskCallbackAmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.TaskTimeOutEvent.NullTaskCallbackAmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnTaskSuccess ();
			}
#pragma warning restore 0169

			static IntPtr id_onTaskSuccess;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection.connectionevents']/class[@name='TaskTimeOutEvent.NullTaskCallbackAmsAccount']/method[@name='onTaskSuccess' and count(parameter)=0]"
			[Register ("onTaskSuccess", "()V", "GetOnTaskSuccessHandler")]
			public virtual unsafe void OnTaskSuccess ()
			{
				if (id_onTaskSuccess == IntPtr.Zero)
					id_onTaskSuccess = JNIEnv.GetMethodID (class_ref, "onTaskSuccess", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTaskSuccess);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTaskSuccess", "()V"));
				} finally {
				}
			}

			static Delegate cb_setSecondaryTask_Z;
#pragma warning disable 0169
			static Delegate GetSetSecondaryTask_ZHandler ()
			{
				if (cb_setSecondaryTask_Z == null)
					cb_setSecondaryTask_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSecondaryTask_Z);
				return cb_setSecondaryTask_Z;
			}

			static void n_SetSecondaryTask_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.TaskTimeOutEvent.NullTaskCallbackAmsAccount __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.TaskTimeOutEvent.NullTaskCallbackAmsAccount> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetSecondaryTask (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setSecondaryTask_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection.connectionevents']/class[@name='TaskTimeOutEvent.NullTaskCallbackAmsAccount']/method[@name='setSecondaryTask' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSecondaryTask", "(Z)V", "GetSetSecondaryTask_ZHandler")]
			public virtual unsafe void SetSecondaryTask (bool p0)
			{
				if (id_setSecondaryTask_Z == IntPtr.Zero)
					id_setSecondaryTask_Z = JNIEnv.GetMethodID (class_ref, "setSecondaryTask", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSecondaryTask_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSecondaryTask", "(Z)V"), __args);
				} finally {
				}
			}

			// This method is explicitly implemented as a member of an instantiated Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsAccountConnectionCallback
			void global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsAccountConnectionCallback.OnTaskError (global::Com.Liveperson.Messaging.TaskType p0, global::Java.Lang.Object p1)
			{
				OnTaskError (p0, global::Java.Interop.JavaObjectExtensions.JavaCast<global::Java.Lang.Exception>(p1));
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/controller/connection/connectionevents/TaskTimeOutEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TaskTimeOutEvent); }
		}

		protected TaskTimeOutEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_commands_tasks_BaseAmsAccountConnectionTask_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller.connection.connectionevents']/class[@name='TaskTimeOutEvent']/constructor[@name='TaskTimeOutEvent' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.commands.tasks.BaseAmsAccountConnectionTask']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/commands/tasks/BaseAmsAccountConnectionTask;)V", "")]
		public unsafe TaskTimeOutEvent (global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (TaskTimeOutEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/commands/tasks/BaseAmsAccountConnectionTask;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/commands/tasks/BaseAmsAccountConnectionTask;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_commands_tasks_BaseAmsAccountConnectionTask_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_commands_tasks_BaseAmsAccountConnectionTask_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/commands/tasks/BaseAmsAccountConnectionTask;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_commands_tasks_BaseAmsAccountConnectionTask_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_commands_tasks_BaseAmsAccountConnectionTask_, __args);
			} finally {
			}
		}

		static Delegate cb_getTaskName;
#pragma warning disable 0169
		static Delegate GetGetTaskNameHandler ()
		{
			if (cb_getTaskName == null)
				cb_getTaskName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTaskName);
			return cb_getTaskName;
		}

		static IntPtr n_GetTaskName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.TaskTimeOutEvent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.TaskTimeOutEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TaskName);
		}
#pragma warning restore 0169

		static IntPtr id_getTaskName;
		public virtual unsafe string TaskName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection.connectionevents']/class[@name='TaskTimeOutEvent']/method[@name='getTaskName' and count(parameter)=0]"
			[Register ("getTaskName", "()Ljava/lang/String;", "GetGetTaskNameHandler")]
			get {
				if (id_getTaskName == IntPtr.Zero)
					id_getTaskName = JNIEnv.GetMethodID (class_ref, "getTaskName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTaskName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTaskName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.TaskTimeOutEvent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.TaskTimeOutEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.Interfaces.IState p0 = (global::Com.Liveperson.Infra.Statemachine.Interfaces.IState)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.Interfaces.IState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Accept (p0);
		}
#pragma warning restore 0169

		static IntPtr id_accept_Lcom_liveperson_infra_statemachine_interfaces_IState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection.connectionevents']/class[@name='TaskTimeOutEvent']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.interfaces.IState']]"
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

		static Delegate cb_failTask;
#pragma warning disable 0169
		static Delegate GetFailTaskHandler ()
		{
			if (cb_failTask == null)
				cb_failTask = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FailTask);
			return cb_failTask;
		}

		static void n_FailTask (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.TaskTimeOutEvent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.TaskTimeOutEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FailTask ();
		}
#pragma warning restore 0169

		static IntPtr id_failTask;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection.connectionevents']/class[@name='TaskTimeOutEvent']/method[@name='failTask' and count(parameter)=0]"
		[Register ("failTask", "()V", "GetFailTaskHandler")]
		public virtual unsafe void FailTask ()
		{
			if (id_failTask == IntPtr.Zero)
				id_failTask = JNIEnv.GetMethodID (class_ref, "failTask", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_failTask);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "failTask", "()V"));
			} finally {
			}
		}

	}
}
