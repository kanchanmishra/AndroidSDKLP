using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Commands.Tasks {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='IdpTask']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/commands/tasks/IdpTask", DoNotGenerateAcw=true)]
	public partial class IdpTask : global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='IdpTask']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "IdpTask";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='IdpTask.IDPExceptionICallback']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/commands/tasks/IdpTask$IDPExceptionICallback", DoNotGenerateAcw=true)]
		public partial class IDPExceptionICallback : global::Java.Lang.Object, global::Com.Liveperson.Infra.ICallback {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/commands/tasks/IdpTask$IDPExceptionICallback", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IDPExceptionICallback); }
			}

			protected IDPExceptionICallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_messaging_commands_tasks_IdpTask_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='IdpTask.IDPExceptionICallback']/constructor[@name='IdpTask.IDPExceptionICallback' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.commands.tasks.IdpTask']]"
			[Register (".ctor", "(Lcom/liveperson/messaging/commands/tasks/IdpTask;)V", "")]
			public unsafe IDPExceptionICallback (global::Com.Liveperson.Messaging.Commands.Tasks.IdpTask __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (IDPExceptionICallback)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_messaging_commands_tasks_IdpTask_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_messaging_commands_tasks_IdpTask_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/commands/tasks/IdpTask;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_commands_tasks_IdpTask_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_commands_tasks_IdpTask_, __args);
				} finally {
				}
			}

			static Delegate cb_onError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Exception_;
#pragma warning disable 0169
			static Delegate GetOnError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Exception_Handler ()
			{
				if (cb_onError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Exception_ == null)
					cb_onError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Exception_);
				return cb_onError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Exception_;
			}

			static void n_OnError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Liveperson.Messaging.Commands.Tasks.IdpTask.IDPExceptionICallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.IdpTask.IDPExceptionICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Liveperson.Messaging.TaskType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.TaskType> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Exception p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Exception_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='IdpTask.IDPExceptionICallback']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='com.liveperson.messaging.TaskType'] and parameter[2][@type='java.lang.Exception']]"
			[Register ("onError", "(Lcom/liveperson/messaging/TaskType;Ljava/lang/Exception;)V", "GetOnError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Exception_Handler")]
			public virtual unsafe void OnError (global::Com.Liveperson.Messaging.TaskType p0, global::Java.Lang.Exception p1)
			{
				if (id_onError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Exception_ == IntPtr.Zero)
					id_onError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/liveperson/messaging/TaskType;Ljava/lang/Exception;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Exception_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onError", "(Lcom/liveperson/messaging/TaskType;Ljava/lang/Exception;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onError_Ljava_lang_Exception_;
#pragma warning disable 0169
			static Delegate GetOnError_Ljava_lang_Exception_Handler ()
			{
				if (cb_onError_Ljava_lang_Exception_ == null)
					cb_onError_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_lang_Exception_);
				return cb_onError_Ljava_lang_Exception_;
			}

			static void n_OnError_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Messaging.Commands.Tasks.IdpTask.IDPExceptionICallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.IdpTask.IDPExceptionICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onError_Ljava_lang_Exception_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='IdpTask.IDPExceptionICallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
			[Register ("onError", "(Ljava/lang/Exception;)V", "GetOnError_Ljava_lang_Exception_Handler")]
			public virtual unsafe void OnError (global::Java.Lang.Exception p0)
			{
				if (id_onError_Ljava_lang_Exception_ == IntPtr.Zero)
					id_onError_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Exception;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_Exception_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onError", "(Ljava/lang/Exception;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onSuccess_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnSuccess_Ljava_lang_String_Handler ()
			{
				if (cb_onSuccess_Ljava_lang_String_ == null)
					cb_onSuccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Ljava_lang_String_);
				return cb_onSuccess_Ljava_lang_String_;
			}

			static void n_OnSuccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Messaging.Commands.Tasks.IdpTask.IDPExceptionICallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.IdpTask.IDPExceptionICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onSuccess_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='IdpTask.IDPExceptionICallback']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onSuccess", "(Ljava/lang/String;)V", "GetOnSuccess_Ljava_lang_String_Handler")]
			public virtual unsafe void OnSuccess (string p0)
			{
				if (id_onSuccess_Ljava_lang_String_ == IntPtr.Zero)
					id_onSuccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSuccess", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/commands/tasks/IdpTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IdpTask); }
		}

		protected IdpTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_controller_AccountsController_Lcom_liveperson_messaging_model_AmsUsers_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='IdpTask']/constructor[@name='IdpTask' and count(parameter)=3 and parameter[1][@type='com.liveperson.messaging.controller.AccountsController'] and parameter[2][@type='com.liveperson.messaging.model.AmsUsers'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/controller/AccountsController;Lcom/liveperson/messaging/model/AmsUsers;Ljava/lang/String;)V", "")]
		public unsafe IdpTask (global::Com.Liveperson.Messaging.Controller.AccountsController p0, global::Com.Liveperson.Messaging.Model.AmsUsers p1, string p2)
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
				if (((object) this).GetType () != typeof (IdpTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/controller/AccountsController;Lcom/liveperson/messaging/model/AmsUsers;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/controller/AccountsController;Lcom/liveperson/messaging/model/AmsUsers;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_controller_AccountsController_Lcom_liveperson_messaging_model_AmsUsers_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_controller_AccountsController_Lcom_liveperson_messaging_model_AmsUsers_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/controller/AccountsController;Lcom/liveperson/messaging/model/AmsUsers;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_controller_AccountsController_Lcom_liveperson_messaging_model_AmsUsers_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_controller_AccountsController_Lcom_liveperson_messaging_model_AmsUsers_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Commands.Tasks.IdpTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.IdpTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public override unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='IdpTask']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_execute;
#pragma warning disable 0169
		static Delegate GetExecuteHandler ()
		{
			if (cb_execute == null)
				cb_execute = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Execute);
			return cb_execute;
		}

		static void n_Execute (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Commands.Tasks.IdpTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.IdpTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		static IntPtr id_execute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='IdpTask']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()V", "GetExecuteHandler")]
		public override unsafe void Execute ()
		{
			if (id_execute == IntPtr.Zero)
				id_execute = JNIEnv.GetMethodID (class_ref, "execute", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_execute);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "()V"));
			} finally {
			}
		}

	}
}
