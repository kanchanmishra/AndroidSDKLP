using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Controller.Connection {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='MessagingStateMachineInterface']"
	[Register ("com/liveperson/messaging/controller/connection/MessagingStateMachineInterface", "", "Com.Liveperson.Messaging.Controller.Connection.IMessagingStateMachineInterfaceInvoker")]
	public partial interface IMessagingStateMachineInterface : IJavaObject {

		global::Com.Liveperson.Messaging.Controller.AccountsController AccountsController {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='MessagingStateMachineInterface']/method[@name='getAccountsController' and count(parameter)=0]"
			[Register ("getAccountsController", "()Lcom/liveperson/messaging/controller/AccountsController;", "GetGetAccountsControllerHandler:Com.Liveperson.Messaging.Controller.Connection.IMessagingStateMachineInterfaceInvoker, LP_Messaging_Binding")] get;
		}

		global::Com.Liveperson.Messaging.Model.AmsConversations AmsConversations {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='MessagingStateMachineInterface']/method[@name='getAmsConversations' and count(parameter)=0]"
			[Register ("getAmsConversations", "()Lcom/liveperson/messaging/model/AmsConversations;", "GetGetAmsConversationsHandler:Com.Liveperson.Messaging.Controller.Connection.IMessagingStateMachineInterfaceInvoker, LP_Messaging_Binding")] get;
		}

		global::Com.Liveperson.Messaging.Model.AmsMessages AmsMessages {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='MessagingStateMachineInterface']/method[@name='getAmsMessages' and count(parameter)=0]"
			[Register ("getAmsMessages", "()Lcom/liveperson/messaging/model/AmsMessages;", "GetGetAmsMessagesHandler:Com.Liveperson.Messaging.Controller.Connection.IMessagingStateMachineInterfaceInvoker, LP_Messaging_Binding")] get;
		}

		global::Com.Liveperson.Messaging.Model.AmsUsers AmsUsers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='MessagingStateMachineInterface']/method[@name='getAmsUsers' and count(parameter)=0]"
			[Register ("getAmsUsers", "()Lcom/liveperson/messaging/model/AmsUsers;", "GetGetAmsUsersHandler:Com.Liveperson.Messaging.Controller.Connection.IMessagingStateMachineInterfaceInvoker, LP_Messaging_Binding")] get;
		}

		global::Com.Liveperson.Messaging.Controller.ConnectionsController ConnectionController {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='MessagingStateMachineInterface']/method[@name='getConnectionController' and count(parameter)=0]"
			[Register ("getConnectionController", "()Lcom/liveperson/messaging/controller/ConnectionsController;", "GetGetConnectionControllerHandler:Com.Liveperson.Messaging.Controller.Connection.IMessagingStateMachineInterfaceInvoker, LP_Messaging_Binding")] get;
		}

		global::Com.Liveperson.Messaging.IMessaging MessagingController {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='MessagingStateMachineInterface']/method[@name='getMessagingController' and count(parameter)=0]"
			[Register ("getMessagingController", "()Lcom/liveperson/messaging/IMessaging;", "GetGetMessagingControllerHandler:Com.Liveperson.Messaging.Controller.Connection.IMessagingStateMachineInterfaceInvoker, LP_Messaging_Binding")] get;
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/MessagingStateMachineInterface", DoNotGenerateAcw=true)]
	internal class IMessagingStateMachineInterfaceInvoker : global::Java.Lang.Object, IMessagingStateMachineInterface {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/messaging/controller/connection/MessagingStateMachineInterface");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMessagingStateMachineInterfaceInvoker); }
		}

		IntPtr class_ref;

		public static IMessagingStateMachineInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMessagingStateMachineInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.messaging.controller.connection.MessagingStateMachineInterface"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMessagingStateMachineInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAccountsController;
#pragma warning disable 0169
		static Delegate GetGetAccountsControllerHandler ()
		{
			if (cb_getAccountsController == null)
				cb_getAccountsController = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccountsController);
			return cb_getAccountsController;
		}

		static IntPtr n_GetAccountsController (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.IMessagingStateMachineInterface __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IMessagingStateMachineInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AccountsController);
		}
#pragma warning restore 0169

		IntPtr id_getAccountsController;
		public unsafe global::Com.Liveperson.Messaging.Controller.AccountsController AccountsController {
			get {
				if (id_getAccountsController == IntPtr.Zero)
					id_getAccountsController = JNIEnv.GetMethodID (class_ref, "getAccountsController", "()Lcom/liveperson/messaging/controller/AccountsController;");
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.AccountsController> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccountsController), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAmsConversations;
#pragma warning disable 0169
		static Delegate GetGetAmsConversationsHandler ()
		{
			if (cb_getAmsConversations == null)
				cb_getAmsConversations = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAmsConversations);
			return cb_getAmsConversations;
		}

		static IntPtr n_GetAmsConversations (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.IMessagingStateMachineInterface __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IMessagingStateMachineInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AmsConversations);
		}
#pragma warning restore 0169

		IntPtr id_getAmsConversations;
		public unsafe global::Com.Liveperson.Messaging.Model.AmsConversations AmsConversations {
			get {
				if (id_getAmsConversations == IntPtr.Zero)
					id_getAmsConversations = JNIEnv.GetMethodID (class_ref, "getAmsConversations", "()Lcom/liveperson/messaging/model/AmsConversations;");
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAmsConversations), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAmsMessages;
#pragma warning disable 0169
		static Delegate GetGetAmsMessagesHandler ()
		{
			if (cb_getAmsMessages == null)
				cb_getAmsMessages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAmsMessages);
			return cb_getAmsMessages;
		}

		static IntPtr n_GetAmsMessages (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.IMessagingStateMachineInterface __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IMessagingStateMachineInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AmsMessages);
		}
#pragma warning restore 0169

		IntPtr id_getAmsMessages;
		public unsafe global::Com.Liveperson.Messaging.Model.AmsMessages AmsMessages {
			get {
				if (id_getAmsMessages == IntPtr.Zero)
					id_getAmsMessages = JNIEnv.GetMethodID (class_ref, "getAmsMessages", "()Lcom/liveperson/messaging/model/AmsMessages;");
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAmsMessages), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAmsUsers;
#pragma warning disable 0169
		static Delegate GetGetAmsUsersHandler ()
		{
			if (cb_getAmsUsers == null)
				cb_getAmsUsers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAmsUsers);
			return cb_getAmsUsers;
		}

		static IntPtr n_GetAmsUsers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.IMessagingStateMachineInterface __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IMessagingStateMachineInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AmsUsers);
		}
#pragma warning restore 0169

		IntPtr id_getAmsUsers;
		public unsafe global::Com.Liveperson.Messaging.Model.AmsUsers AmsUsers {
			get {
				if (id_getAmsUsers == IntPtr.Zero)
					id_getAmsUsers = JNIEnv.GetMethodID (class_ref, "getAmsUsers", "()Lcom/liveperson/messaging/model/AmsUsers;");
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsUsers> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAmsUsers), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getConnectionController;
#pragma warning disable 0169
		static Delegate GetGetConnectionControllerHandler ()
		{
			if (cb_getConnectionController == null)
				cb_getConnectionController = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnectionController);
			return cb_getConnectionController;
		}

		static IntPtr n_GetConnectionController (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.IMessagingStateMachineInterface __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IMessagingStateMachineInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConnectionController);
		}
#pragma warning restore 0169

		IntPtr id_getConnectionController;
		public unsafe global::Com.Liveperson.Messaging.Controller.ConnectionsController ConnectionController {
			get {
				if (id_getConnectionController == IntPtr.Zero)
					id_getConnectionController = JNIEnv.GetMethodID (class_ref, "getConnectionController", "()Lcom/liveperson/messaging/controller/ConnectionsController;");
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConnectionController), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMessagingController;
#pragma warning disable 0169
		static Delegate GetGetMessagingControllerHandler ()
		{
			if (cb_getMessagingController == null)
				cb_getMessagingController = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessagingController);
			return cb_getMessagingController;
		}

		static IntPtr n_GetMessagingController (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.IMessagingStateMachineInterface __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IMessagingStateMachineInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MessagingController);
		}
#pragma warning restore 0169

		IntPtr id_getMessagingController;
		public unsafe global::Com.Liveperson.Messaging.IMessaging MessagingController {
			get {
				if (id_getMessagingController == IntPtr.Zero)
					id_getMessagingController = JNIEnv.GetMethodID (class_ref, "getMessagingController", "()Lcom/liveperson/messaging/IMessaging;");
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessagingController), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
