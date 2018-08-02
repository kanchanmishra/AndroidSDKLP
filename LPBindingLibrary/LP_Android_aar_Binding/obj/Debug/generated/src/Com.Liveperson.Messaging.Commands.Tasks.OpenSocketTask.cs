using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Commands.Tasks {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='OpenSocketTask']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/commands/tasks/OpenSocketTask", DoNotGenerateAcw=true)]
	public partial class OpenSocketTask : global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='OpenSocketTask']/field[@name='AUTHORIZATION']"
		[Register ("AUTHORIZATION")]
		public const string Authorization = (string) "Authorization";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='OpenSocketTask']/field[@name='CLIENT_PROPERTIES']"
		[Register ("CLIENT_PROPERTIES")]
		public const string ClientProperties = (string) "Client-Properties";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='OpenSocketTask']/field[@name='JWT']"
		[Register ("JWT")]
		public const string Jwt = (string) "jwt %1$s";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/commands/tasks/OpenSocketTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OpenSocketTask); }
		}

		protected OpenSocketTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_controller_AccountsController_Lcom_liveperson_messaging_controller_ConnectionsController_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='OpenSocketTask']/constructor[@name='OpenSocketTask' and count(parameter)=2 and parameter[1][@type='com.liveperson.messaging.controller.AccountsController'] and parameter[2][@type='com.liveperson.messaging.controller.ConnectionsController']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/controller/AccountsController;Lcom/liveperson/messaging/controller/ConnectionsController;)V", "")]
		public unsafe OpenSocketTask (global::Com.Liveperson.Messaging.Controller.AccountsController p0, global::Com.Liveperson.Messaging.Controller.ConnectionsController p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (OpenSocketTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/controller/AccountsController;Lcom/liveperson/messaging/controller/ConnectionsController;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/controller/AccountsController;Lcom/liveperson/messaging/controller/ConnectionsController;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_controller_AccountsController_Lcom_liveperson_messaging_controller_ConnectionsController_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_controller_AccountsController_Lcom_liveperson_messaging_controller_ConnectionsController_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/controller/AccountsController;Lcom/liveperson/messaging/controller/ConnectionsController;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_controller_AccountsController_Lcom_liveperson_messaging_controller_ConnectionsController_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_controller_AccountsController_Lcom_liveperson_messaging_controller_ConnectionsController_, __args);
			} finally {
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
			global::Com.Liveperson.Messaging.Commands.Tasks.OpenSocketTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.OpenSocketTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public override unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='OpenSocketTask']/method[@name='getName' and count(parameter)=0]"
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
			global::Com.Liveperson.Messaging.Commands.Tasks.OpenSocketTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.OpenSocketTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		static IntPtr id_execute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='OpenSocketTask']/method[@name='execute' and count(parameter)=0]"
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
