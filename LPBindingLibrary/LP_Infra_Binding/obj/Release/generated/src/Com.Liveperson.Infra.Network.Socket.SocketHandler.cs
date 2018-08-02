using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Network.Socket {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketHandler']"
	[global::Android.Runtime.Register ("com/liveperson/infra/network/socket/SocketHandler", DoNotGenerateAcw=true)]
	public partial class SocketHandler : global::Java.Lang.Object, global::Com.Liveperson.Infra.IDisposable, global::Com.Liveperson.Infra.Network.Socket.ISocketCallbacks {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketHandler']/field[@name='CERTIFICATE_ERROR']"
		[Register ("CERTIFICATE_ERROR")]
		public const int CertificateError = (int) 1200;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketHandler']/field[@name='PERIODIC_PING_TIME']"
		[Register ("PERIODIC_PING_TIME")]
		public const int PeriodicPingTime = (int) 20000;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketHandler.SendMessageRunnable']"
		[global::Android.Runtime.Register ("com/liveperson/infra/network/socket/SocketHandler$SendMessageRunnable", DoNotGenerateAcw=true)]
		public partial class SendMessageRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/network/socket/SocketHandler$SendMessageRunnable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SendMessageRunnable); }
			}

			protected SendMessageRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_infra_network_socket_SocketHandler_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketHandler.SendMessageRunnable']/constructor[@name='SocketHandler.SendMessageRunnable' and count(parameter)=2 and parameter[1][@type='com.liveperson.infra.network.socket.SocketHandler'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/liveperson/infra/network/socket/SocketHandler;Ljava/lang/String;)V", "")]
			public unsafe SendMessageRunnable (global::Com.Liveperson.Infra.Network.Socket.SocketHandler __self, string p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p1);
					if (((object) this).GetType () != typeof (SendMessageRunnable)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_infra_network_socket_SocketHandler_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_infra_network_socket_SocketHandler_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/network/socket/SocketHandler;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_network_socket_SocketHandler_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_network_socket_SocketHandler_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.Network.Socket.SocketHandler.SendMessageRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketHandler.SendMessageRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketHandler.SendMessageRunnable']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/network/socket/SocketHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocketHandler); }
		}

		protected SocketHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_infra_network_socket_ResponseMap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketHandler']/constructor[@name='SocketHandler' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.network.socket.ResponseMap']]"
		[Register (".ctor", "(Lcom/liveperson/infra/network/socket/ResponseMap;)V", "")]
		public unsafe SocketHandler (global::Com.Liveperson.Infra.Network.Socket.ResponseMap p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (SocketHandler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/infra/network/socket/ResponseMap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/infra/network/socket/ResponseMap;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_infra_network_socket_ResponseMap_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_infra_network_socket_ResponseMap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/network/socket/ResponseMap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_network_socket_ResponseMap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_network_socket_ResponseMap_, __args);
			} finally {
			}
		}

		static Delegate cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Socket.SocketHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketHandler']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispose);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispose", "()V"));
			} finally {
			}
		}

		static Delegate cb_onDisconnected_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOnDisconnected_Ljava_lang_String_IHandler ()
		{
			if (cb_onDisconnected_Ljava_lang_String_I == null)
				cb_onDisconnected_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnDisconnected_Ljava_lang_String_I);
			return cb_onDisconnected_Ljava_lang_String_I;
		}

		static void n_OnDisconnected_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Liveperson.Infra.Network.Socket.SocketHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDisconnected (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onDisconnected_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketHandler']/method[@name='onDisconnected' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onDisconnected", "(Ljava/lang/String;I)V", "GetOnDisconnected_Ljava_lang_String_IHandler")]
		public virtual unsafe void OnDisconnected (string p0, int p1)
		{
			if (id_onDisconnected_Ljava_lang_String_I == IntPtr.Zero)
				id_onDisconnected_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onDisconnected", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDisconnected_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDisconnected", "(Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnMessage_Ljava_lang_String_Handler ()
		{
			if (cb_onMessage_Ljava_lang_String_ == null)
				cb_onMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMessage_Ljava_lang_String_);
			return cb_onMessage_Ljava_lang_String_;
		}

		static void n_OnMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Socket.SocketHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketHandler']/method[@name='onMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onMessage", "(Ljava/lang/String;)V", "GetOnMessage_Ljava_lang_String_Handler")]
		public virtual unsafe void OnMessage (string p0)
		{
			if (id_onMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_onMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onMessage", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMessage_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMessage", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onStateChanged_Lcom_liveperson_infra_network_socket_SocketState_;
#pragma warning disable 0169
		static Delegate GetOnStateChanged_Lcom_liveperson_infra_network_socket_SocketState_Handler ()
		{
			if (cb_onStateChanged_Lcom_liveperson_infra_network_socket_SocketState_ == null)
				cb_onStateChanged_Lcom_liveperson_infra_network_socket_SocketState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStateChanged_Lcom_liveperson_infra_network_socket_SocketState_);
			return cb_onStateChanged_Lcom_liveperson_infra_network_socket_SocketState_;
		}

		static void n_OnStateChanged_Lcom_liveperson_infra_network_socket_SocketState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Socket.SocketHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Network.Socket.SocketState p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnStateChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onStateChanged_Lcom_liveperson_infra_network_socket_SocketState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketHandler']/method[@name='onStateChanged' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.network.socket.SocketState']]"
		[Register ("onStateChanged", "(Lcom/liveperson/infra/network/socket/SocketState;)V", "GetOnStateChanged_Lcom_liveperson_infra_network_socket_SocketState_Handler")]
		public virtual unsafe void OnStateChanged (global::Com.Liveperson.Infra.Network.Socket.SocketState p0)
		{
			if (id_onStateChanged_Lcom_liveperson_infra_network_socket_SocketState_ == IntPtr.Zero)
				id_onStateChanged_Lcom_liveperson_infra_network_socket_SocketState_ = JNIEnv.GetMethodID (class_ref, "onStateChanged", "(Lcom/liveperson/infra/network/socket/SocketState;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStateChanged_Lcom_liveperson_infra_network_socket_SocketState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStateChanged", "(Lcom/liveperson/infra/network/socket/SocketState;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_send_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSend_Ljava_lang_String_Handler ()
		{
			if (cb_send_Ljava_lang_String_ == null)
				cb_send_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Send_Ljava_lang_String_);
			return cb_send_Ljava_lang_String_;
		}

		static void n_Send_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Socket.SocketHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0);
		}
#pragma warning restore 0169

		static IntPtr id_send_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketHandler']/method[@name='send' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("send", "(Ljava/lang/String;)V", "GetSend_Ljava_lang_String_Handler")]
		public virtual unsafe void Send (string p0)
		{
			if (id_send_Ljava_lang_String_ == IntPtr.Zero)
				id_send_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "send", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_send_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendDelayed_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetSendDelayed_Ljava_lang_String_JHandler ()
		{
			if (cb_sendDelayed_Ljava_lang_String_J == null)
				cb_sendDelayed_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_SendDelayed_Ljava_lang_String_J);
			return cb_sendDelayed_Ljava_lang_String_J;
		}

		static IntPtr n_SendDelayed_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Liveperson.Infra.Network.Socket.SocketHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SendDelayed (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sendDelayed_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketHandler']/method[@name='sendDelayed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("sendDelayed", "(Ljava/lang/String;J)Ljava/lang/Runnable;", "GetSendDelayed_Ljava_lang_String_JHandler")]
		public virtual unsafe global::Java.Lang.IRunnable SendDelayed (string p0, long p1)
		{
			if (id_sendDelayed_Ljava_lang_String_J == IntPtr.Zero)
				id_sendDelayed_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "sendDelayed", "(Ljava/lang/String;J)Ljava/lang/Runnable;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Java.Lang.IRunnable __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sendDelayed_Ljava_lang_String_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendDelayed", "(Ljava/lang/String;J)Ljava/lang/Runnable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
