using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Commands.Tasks {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='HandlePendingMessagesTask']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/commands/tasks/HandlePendingMessagesTask", DoNotGenerateAcw=true)]
	public partial class HandlePendingMessagesTask : global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsSocketConnectionTask {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/commands/tasks/HandlePendingMessagesTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HandlePendingMessagesTask); }
		}

		protected HandlePendingMessagesTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_model_AmsMessages_Lcom_liveperson_messaging_model_AmsConversations_Lcom_liveperson_messaging_controller_ConnectionsController_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='HandlePendingMessagesTask']/constructor[@name='HandlePendingMessagesTask' and count(parameter)=3 and parameter[1][@type='com.liveperson.messaging.model.AmsMessages'] and parameter[2][@type='com.liveperson.messaging.model.AmsConversations'] and parameter[3][@type='com.liveperson.messaging.controller.ConnectionsController']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/model/AmsMessages;Lcom/liveperson/messaging/model/AmsConversations;Lcom/liveperson/messaging/controller/ConnectionsController;)V", "")]
		public unsafe HandlePendingMessagesTask (global::Com.Liveperson.Messaging.Model.AmsMessages p0, global::Com.Liveperson.Messaging.Model.AmsConversations p1, global::Com.Liveperson.Messaging.Controller.ConnectionsController p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (HandlePendingMessagesTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/model/AmsMessages;Lcom/liveperson/messaging/model/AmsConversations;Lcom/liveperson/messaging/controller/ConnectionsController;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/model/AmsMessages;Lcom/liveperson/messaging/model/AmsConversations;Lcom/liveperson/messaging/controller/ConnectionsController;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_model_AmsMessages_Lcom_liveperson_messaging_model_AmsConversations_Lcom_liveperson_messaging_controller_ConnectionsController_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_model_AmsMessages_Lcom_liveperson_messaging_model_AmsConversations_Lcom_liveperson_messaging_controller_ConnectionsController_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/model/AmsMessages;Lcom/liveperson/messaging/model/AmsConversations;Lcom/liveperson/messaging/controller/ConnectionsController;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_model_AmsMessages_Lcom_liveperson_messaging_model_AmsConversations_Lcom_liveperson_messaging_controller_ConnectionsController_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_model_AmsMessages_Lcom_liveperson_messaging_model_AmsConversations_Lcom_liveperson_messaging_controller_ConnectionsController_, __args);
			} finally {
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
			global::Com.Liveperson.Messaging.Commands.Tasks.HandlePendingMessagesTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.HandlePendingMessagesTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		static IntPtr id_execute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='HandlePendingMessagesTask']/method[@name='execute' and count(parameter)=0]"
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
