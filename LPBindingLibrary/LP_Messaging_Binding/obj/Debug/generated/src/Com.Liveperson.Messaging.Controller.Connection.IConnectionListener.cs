using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Controller.Connection {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='IConnectionListener']"
	[Register ("com/liveperson/messaging/controller/connection/IConnectionListener", "", "Com.Liveperson.Messaging.Controller.Connection.IConnectionListenerInvoker")]
	public partial interface IConnectionListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='IConnectionListener']/method[@name='notifyConnected' and count(parameter)=0]"
		[Register ("notifyConnected", "()V", "GetNotifyConnectedHandler:Com.Liveperson.Messaging.Controller.Connection.IConnectionListenerInvoker, LP_Messaging_Binding")]
		void NotifyConnected ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='IConnectionListener']/method[@name='notifyDisconnected' and count(parameter)=0]"
		[Register ("notifyDisconnected", "()V", "GetNotifyDisconnectedHandler:Com.Liveperson.Messaging.Controller.Connection.IConnectionListenerInvoker, LP_Messaging_Binding")]
		void NotifyDisconnected ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='IConnectionListener']/method[@name='notifyError' and count(parameter)=2 and parameter[1][@type='com.liveperson.messaging.TaskType'] and parameter[2][@type='java.lang.String']]"
		[Register ("notifyError", "(Lcom/liveperson/messaging/TaskType;Ljava/lang/String;)V", "GetNotifyError_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_Handler:Com.Liveperson.Messaging.Controller.Connection.IConnectionListenerInvoker, LP_Messaging_Binding")]
		void NotifyError (global::Com.Liveperson.Messaging.TaskType p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='IConnectionListener']/method[@name='notifyStartConnecting' and count(parameter)=0]"
		[Register ("notifyStartConnecting", "()V", "GetNotifyStartConnectingHandler:Com.Liveperson.Messaging.Controller.Connection.IConnectionListenerInvoker, LP_Messaging_Binding")]
		void NotifyStartConnecting ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='IConnectionListener']/method[@name='notifyStartDisconnecting' and count(parameter)=0]"
		[Register ("notifyStartDisconnecting", "()V", "GetNotifyStartDisconnectingHandler:Com.Liveperson.Messaging.Controller.Connection.IConnectionListenerInvoker, LP_Messaging_Binding")]
		void NotifyStartDisconnecting ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='IConnectionListener']/method[@name='notifyTokenExpired' and count(parameter)=0]"
		[Register ("notifyTokenExpired", "()V", "GetNotifyTokenExpiredHandler:Com.Liveperson.Messaging.Controller.Connection.IConnectionListenerInvoker, LP_Messaging_Binding")]
		void NotifyTokenExpired ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='IConnectionListener']/method[@name='notifyUserExpired' and count(parameter)=0]"
		[Register ("notifyUserExpired", "()V", "GetNotifyUserExpiredHandler:Com.Liveperson.Messaging.Controller.Connection.IConnectionListenerInvoker, LP_Messaging_Binding")]
		void NotifyUserExpired ();

	}

	[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/IConnectionListener", DoNotGenerateAcw=true)]
	internal class IConnectionListenerInvoker : global::Java.Lang.Object, IConnectionListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/messaging/controller/connection/IConnectionListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IConnectionListenerInvoker); }
		}

		IntPtr class_ref;

		public static IConnectionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnectionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.messaging.controller.connection.IConnectionListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_notifyConnected;
#pragma warning disable 0169
		static Delegate GetNotifyConnectedHandler ()
		{
			if (cb_notifyConnected == null)
				cb_notifyConnected = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyConnected);
			return cb_notifyConnected;
		}

		static void n_NotifyConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.IConnectionListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IConnectionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyConnected ();
		}
#pragma warning restore 0169

		IntPtr id_notifyConnected;
		public unsafe void NotifyConnected ()
		{
			if (id_notifyConnected == IntPtr.Zero)
				id_notifyConnected = JNIEnv.GetMethodID (class_ref, "notifyConnected", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyConnected);
		}

		static Delegate cb_notifyDisconnected;
#pragma warning disable 0169
		static Delegate GetNotifyDisconnectedHandler ()
		{
			if (cb_notifyDisconnected == null)
				cb_notifyDisconnected = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyDisconnected);
			return cb_notifyDisconnected;
		}

		static void n_NotifyDisconnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.IConnectionListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IConnectionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyDisconnected ();
		}
#pragma warning restore 0169

		IntPtr id_notifyDisconnected;
		public unsafe void NotifyDisconnected ()
		{
			if (id_notifyDisconnected == IntPtr.Zero)
				id_notifyDisconnected = JNIEnv.GetMethodID (class_ref, "notifyDisconnected", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyDisconnected);
		}

		static Delegate cb_notifyError_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNotifyError_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_Handler ()
		{
			if (cb_notifyError_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_ == null)
				cb_notifyError_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_NotifyError_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_);
			return cb_notifyError_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_;
		}

		static void n_NotifyError_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.IConnectionListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IConnectionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.TaskType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.TaskType> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.NotifyError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_notifyError_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_;
		public unsafe void NotifyError (global::Com.Liveperson.Messaging.TaskType p0, string p1)
		{
			if (id_notifyError_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_ == IntPtr.Zero)
				id_notifyError_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "notifyError", "(Lcom/liveperson/messaging/TaskType;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyError_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_notifyStartConnecting;
#pragma warning disable 0169
		static Delegate GetNotifyStartConnectingHandler ()
		{
			if (cb_notifyStartConnecting == null)
				cb_notifyStartConnecting = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyStartConnecting);
			return cb_notifyStartConnecting;
		}

		static void n_NotifyStartConnecting (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.IConnectionListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IConnectionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyStartConnecting ();
		}
#pragma warning restore 0169

		IntPtr id_notifyStartConnecting;
		public unsafe void NotifyStartConnecting ()
		{
			if (id_notifyStartConnecting == IntPtr.Zero)
				id_notifyStartConnecting = JNIEnv.GetMethodID (class_ref, "notifyStartConnecting", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyStartConnecting);
		}

		static Delegate cb_notifyStartDisconnecting;
#pragma warning disable 0169
		static Delegate GetNotifyStartDisconnectingHandler ()
		{
			if (cb_notifyStartDisconnecting == null)
				cb_notifyStartDisconnecting = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyStartDisconnecting);
			return cb_notifyStartDisconnecting;
		}

		static void n_NotifyStartDisconnecting (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.IConnectionListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IConnectionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyStartDisconnecting ();
		}
#pragma warning restore 0169

		IntPtr id_notifyStartDisconnecting;
		public unsafe void NotifyStartDisconnecting ()
		{
			if (id_notifyStartDisconnecting == IntPtr.Zero)
				id_notifyStartDisconnecting = JNIEnv.GetMethodID (class_ref, "notifyStartDisconnecting", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyStartDisconnecting);
		}

		static Delegate cb_notifyTokenExpired;
#pragma warning disable 0169
		static Delegate GetNotifyTokenExpiredHandler ()
		{
			if (cb_notifyTokenExpired == null)
				cb_notifyTokenExpired = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyTokenExpired);
			return cb_notifyTokenExpired;
		}

		static void n_NotifyTokenExpired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.IConnectionListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IConnectionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyTokenExpired ();
		}
#pragma warning restore 0169

		IntPtr id_notifyTokenExpired;
		public unsafe void NotifyTokenExpired ()
		{
			if (id_notifyTokenExpired == IntPtr.Zero)
				id_notifyTokenExpired = JNIEnv.GetMethodID (class_ref, "notifyTokenExpired", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyTokenExpired);
		}

		static Delegate cb_notifyUserExpired;
#pragma warning disable 0169
		static Delegate GetNotifyUserExpiredHandler ()
		{
			if (cb_notifyUserExpired == null)
				cb_notifyUserExpired = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyUserExpired);
			return cb_notifyUserExpired;
		}

		static void n_NotifyUserExpired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.IConnectionListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IConnectionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyUserExpired ();
		}
#pragma warning restore 0169

		IntPtr id_notifyUserExpired;
		public unsafe void NotifyUserExpired ()
		{
			if (id_notifyUserExpired == IntPtr.Zero)
				id_notifyUserExpired = JNIEnv.GetMethodID (class_ref, "notifyUserExpired", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyUserExpired);
		}

	}

	public partial class NotifyErrorEventArgs : global::System.EventArgs {

		public NotifyErrorEventArgs (global::Com.Liveperson.Messaging.TaskType p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Liveperson.Messaging.TaskType p0;
		public global::Com.Liveperson.Messaging.TaskType P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/liveperson/messaging/controller/connection/IConnectionListenerImplementor")]
	internal sealed partial class IConnectionListenerImplementor : global::Java.Lang.Object, IConnectionListener {

		object sender;

		public IConnectionListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/liveperson/messaging/controller/connection/IConnectionListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler NotifyConnectedHandler;
#pragma warning restore 0649

		public void NotifyConnected ()
		{
			var __h = NotifyConnectedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler NotifyDisconnectedHandler;
#pragma warning restore 0649

		public void NotifyDisconnected ()
		{
			var __h = NotifyDisconnectedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<NotifyErrorEventArgs> NotifyErrorHandler;
#pragma warning restore 0649

		public void NotifyError (global::Com.Liveperson.Messaging.TaskType p0, string p1)
		{
			var __h = NotifyErrorHandler;
			if (__h != null)
				__h (sender, new NotifyErrorEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler NotifyStartConnectingHandler;
#pragma warning restore 0649

		public void NotifyStartConnecting ()
		{
			var __h = NotifyStartConnectingHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler NotifyStartDisconnectingHandler;
#pragma warning restore 0649

		public void NotifyStartDisconnecting ()
		{
			var __h = NotifyStartDisconnectingHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler NotifyTokenExpiredHandler;
#pragma warning restore 0649

		public void NotifyTokenExpired ()
		{
			var __h = NotifyTokenExpiredHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler NotifyUserExpiredHandler;
#pragma warning restore 0649

		public void NotifyUserExpired ()
		{
			var __h = NotifyUserExpiredHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IConnectionListenerImplementor value)
		{
			return value.NotifyConnectedHandler == null && value.NotifyDisconnectedHandler == null && value.NotifyErrorHandler == null && value.NotifyStartConnectingHandler == null && value.NotifyStartDisconnectingHandler == null && value.NotifyTokenExpiredHandler == null && value.NotifyUserExpiredHandler == null;
		}
	}

}
