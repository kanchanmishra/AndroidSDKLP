using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Controller.Connection {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/BaseConnectionState", DoNotGenerateAcw=true)]
	public partial class BaseConnectionState : global::Java.Lang.Object, global::Com.Liveperson.Infra.Statemachine.Interfaces.IState {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']/field[@name='TAG']"
		[Register ("TAG")]
		protected string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, TAG_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']/field[@name='name']"
		[Register ("name")]
		protected string Name {
			get {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, name_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, name_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/controller/connection/BaseConnectionState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseConnectionState); }
		}

		protected BaseConnectionState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_controller_connection_BaseConnectionState_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']/constructor[@name='BaseConnectionState' and count(parameter)=3 and parameter[1][@type='com.liveperson.messaging.controller.connection.BaseConnectionState'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/controller/connection/BaseConnectionState;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe BaseConnectionState (global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState p0, string p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (BaseConnectionState)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/controller/connection/BaseConnectionState;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/controller/connection/BaseConnectionState;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_controller_connection_BaseConnectionState_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_controller_connection_BaseConnectionState_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/controller/connection/BaseConnectionState;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_BaseConnectionState_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_BaseConnectionState_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']/constructor[@name='BaseConnectionState' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe BaseConnectionState (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (BaseConnectionState)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		static IntPtr id_isConnected;
		public virtual unsafe bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				if (id_isConnected == IntPtr.Zero)
					id_isConnected = JNIEnv.GetMethodID (class_ref, "isConnected", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConnected);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConnected", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isConnecting;
#pragma warning disable 0169
		static Delegate GetIsConnectingHandler ()
		{
			if (cb_isConnecting == null)
				cb_isConnecting = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnecting);
			return cb_isConnecting;
		}

		static bool n_IsConnecting (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnecting;
		}
#pragma warning restore 0169

		static IntPtr id_isConnecting;
		public virtual unsafe bool IsConnecting {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']/method[@name='isConnecting' and count(parameter)=0]"
			[Register ("isConnecting", "()Z", "GetIsConnectingHandler")]
			get {
				if (id_isConnecting == IntPtr.Zero)
					id_isConnecting = JNIEnv.GetMethodID (class_ref, "isConnecting", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConnecting);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConnecting", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_actionOnEntry;
#pragma warning disable 0169
		static Delegate GetActionOnEntryHandler ()
		{
			if (cb_actionOnEntry == null)
				cb_actionOnEntry = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ActionOnEntry);
			return cb_actionOnEntry;
		}

		static void n_ActionOnEntry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ActionOnEntry ();
		}
#pragma warning restore 0169

		static IntPtr id_actionOnEntry;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']/method[@name='actionOnEntry' and count(parameter)=0]"
		[Register ("actionOnEntry", "()V", "GetActionOnEntryHandler")]
		public virtual unsafe void ActionOnEntry ()
		{
			if (id_actionOnEntry == IntPtr.Zero)
				id_actionOnEntry = JNIEnv.GetMethodID (class_ref, "actionOnEntry", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_actionOnEntry);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "actionOnEntry", "()V"));
			} finally {
			}
		}

		static Delegate cb_actionOnExit;
#pragma warning disable 0169
		static Delegate GetActionOnExitHandler ()
		{
			if (cb_actionOnExit == null)
				cb_actionOnExit = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ActionOnExit);
			return cb_actionOnExit;
		}

		static void n_ActionOnExit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ActionOnExit ();
		}
#pragma warning restore 0169

		static IntPtr id_actionOnExit;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']/method[@name='actionOnExit' and count(parameter)=0]"
		[Register ("actionOnExit", "()V", "GetActionOnExitHandler")]
		public virtual unsafe void ActionOnExit ()
		{
			if (id_actionOnExit == IntPtr.Zero)
				id_actionOnExit = JNIEnv.GetMethodID (class_ref, "actionOnExit", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_actionOnExit);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "actionOnExit", "()V"));
			} finally {
			}
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_BackgroundEvent_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_BackgroundEvent_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_BackgroundEvent_ == null)
				cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_BackgroundEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_BackgroundEvent_);
			return cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_BackgroundEvent_;
		}

		static void n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_BackgroundEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.BackgroundEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.BackgroundEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_BackgroundEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.controller.connection.connectionevents.BackgroundEvent']]"
		[Register ("visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/BackgroundEvent;)V", "GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_BackgroundEvent_Handler")]
		public virtual unsafe void Visit (global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.BackgroundEvent p0)
		{
			if (id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_BackgroundEvent_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_BackgroundEvent_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/BackgroundEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_BackgroundEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/BackgroundEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_BackgroundTimeOutEvent_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_BackgroundTimeOutEvent_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_BackgroundTimeOutEvent_ == null)
				cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_BackgroundTimeOutEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_BackgroundTimeOutEvent_);
			return cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_BackgroundTimeOutEvent_;
		}

		static void n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_BackgroundTimeOutEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.BackgroundTimeOutEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.BackgroundTimeOutEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_BackgroundTimeOutEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.controller.connection.connectionevents.BackgroundTimeOutEvent']]"
		[Register ("visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/BackgroundTimeOutEvent;)V", "GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_BackgroundTimeOutEvent_Handler")]
		public virtual unsafe void Visit (global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.BackgroundTimeOutEvent p0)
		{
			if (id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_BackgroundTimeOutEvent_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_BackgroundTimeOutEvent_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/BackgroundTimeOutEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_BackgroundTimeOutEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/BackgroundTimeOutEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ConnectEvent_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_ConnectEvent_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ConnectEvent_ == null)
				cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ConnectEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ConnectEvent_);
			return cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ConnectEvent_;
		}

		static void n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ConnectEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.ConnectEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.ConnectEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ConnectEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.controller.connection.connectionevents.ConnectEvent']]"
		[Register ("visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/ConnectEvent;)V", "GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_ConnectEvent_Handler")]
		public virtual unsafe void Visit (global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.ConnectEvent p0)
		{
			if (id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ConnectEvent_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ConnectEvent_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/ConnectEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ConnectEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/ConnectEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_DisconnectEvent_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_DisconnectEvent_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_DisconnectEvent_ == null)
				cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_DisconnectEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_DisconnectEvent_);
			return cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_DisconnectEvent_;
		}

		static void n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_DisconnectEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.DisconnectEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.DisconnectEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_DisconnectEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.controller.connection.connectionevents.DisconnectEvent']]"
		[Register ("visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/DisconnectEvent;)V", "GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_DisconnectEvent_Handler")]
		public virtual unsafe void Visit (global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.DisconnectEvent p0)
		{
			if (id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_DisconnectEvent_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_DisconnectEvent_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/DisconnectEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_DisconnectEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/DisconnectEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ForegroundEvent_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_ForegroundEvent_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ForegroundEvent_ == null)
				cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ForegroundEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ForegroundEvent_);
			return cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ForegroundEvent_;
		}

		static void n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ForegroundEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.ForegroundEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.ForegroundEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ForegroundEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.controller.connection.connectionevents.ForegroundEvent']]"
		[Register ("visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/ForegroundEvent;)V", "GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_ForegroundEvent_Handler")]
		public virtual unsafe void Visit (global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.ForegroundEvent p0)
		{
			if (id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ForegroundEvent_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ForegroundEvent_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/ForegroundEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ForegroundEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/ForegroundEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_NetworkAvailableEvent_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_NetworkAvailableEvent_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_NetworkAvailableEvent_ == null)
				cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_NetworkAvailableEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_NetworkAvailableEvent_);
			return cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_NetworkAvailableEvent_;
		}

		static void n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_NetworkAvailableEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.NetworkAvailableEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.NetworkAvailableEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_NetworkAvailableEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.controller.connection.connectionevents.NetworkAvailableEvent']]"
		[Register ("visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/NetworkAvailableEvent;)V", "GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_NetworkAvailableEvent_Handler")]
		public virtual unsafe void Visit (global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.NetworkAvailableEvent p0)
		{
			if (id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_NetworkAvailableEvent_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_NetworkAvailableEvent_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/NetworkAvailableEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_NetworkAvailableEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/NetworkAvailableEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_NetworkLostEvent_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_NetworkLostEvent_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_NetworkLostEvent_ == null)
				cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_NetworkLostEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_NetworkLostEvent_);
			return cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_NetworkLostEvent_;
		}

		static void n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_NetworkLostEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.NetworkLostEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.NetworkLostEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_NetworkLostEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.controller.connection.connectionevents.NetworkLostEvent']]"
		[Register ("visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/NetworkLostEvent;)V", "GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_NetworkLostEvent_Handler")]
		public virtual unsafe void Visit (global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.NetworkLostEvent p0)
		{
			if (id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_NetworkLostEvent_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_NetworkLostEvent_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/NetworkLostEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_NetworkLostEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/NetworkLostEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_RunTaskEvent_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_RunTaskEvent_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_RunTaskEvent_ == null)
				cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_RunTaskEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_RunTaskEvent_);
			return cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_RunTaskEvent_;
		}

		static void n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_RunTaskEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.RunTaskEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.RunTaskEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_RunTaskEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.controller.connection.connectionevents.RunTaskEvent']]"
		[Register ("visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/RunTaskEvent;)V", "GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_RunTaskEvent_Handler")]
		public virtual unsafe void Visit (global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.RunTaskEvent p0)
		{
			if (id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_RunTaskEvent_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_RunTaskEvent_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/RunTaskEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_RunTaskEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/RunTaskEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SecondaryConnectEvent_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_SecondaryConnectEvent_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SecondaryConnectEvent_ == null)
				cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SecondaryConnectEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SecondaryConnectEvent_);
			return cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SecondaryConnectEvent_;
		}

		static void n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SecondaryConnectEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.SecondaryConnectEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.SecondaryConnectEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SecondaryConnectEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.controller.connection.connectionevents.SecondaryConnectEvent']]"
		[Register ("visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/SecondaryConnectEvent;)V", "GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_SecondaryConnectEvent_Handler")]
		public virtual unsafe void Visit (global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.SecondaryConnectEvent p0)
		{
			if (id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SecondaryConnectEvent_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SecondaryConnectEvent_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/SecondaryConnectEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SecondaryConnectEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/SecondaryConnectEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SecondaryTaskSuccessEvent_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_SecondaryTaskSuccessEvent_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SecondaryTaskSuccessEvent_ == null)
				cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SecondaryTaskSuccessEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SecondaryTaskSuccessEvent_);
			return cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SecondaryTaskSuccessEvent_;
		}

		static void n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SecondaryTaskSuccessEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.SecondaryTaskSuccessEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.SecondaryTaskSuccessEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SecondaryTaskSuccessEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.controller.connection.connectionevents.SecondaryTaskSuccessEvent']]"
		[Register ("visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/SecondaryTaskSuccessEvent;)V", "GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_SecondaryTaskSuccessEvent_Handler")]
		public virtual unsafe void Visit (global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.SecondaryTaskSuccessEvent p0)
		{
			if (id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SecondaryTaskSuccessEvent_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SecondaryTaskSuccessEvent_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/SecondaryTaskSuccessEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SecondaryTaskSuccessEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/SecondaryTaskSuccessEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SendStateEvent_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_SendStateEvent_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SendStateEvent_ == null)
				cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SendStateEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SendStateEvent_);
			return cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SendStateEvent_;
		}

		static void n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SendStateEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.SendStateEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.SendStateEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SendStateEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.controller.connection.connectionevents.SendStateEvent']]"
		[Register ("visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/SendStateEvent;)V", "GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_SendStateEvent_Handler")]
		public virtual unsafe void Visit (global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.SendStateEvent p0)
		{
			if (id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SendStateEvent_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SendStateEvent_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/SendStateEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SendStateEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/SendStateEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ServiceOffEvent_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_ServiceOffEvent_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ServiceOffEvent_ == null)
				cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ServiceOffEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ServiceOffEvent_);
			return cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ServiceOffEvent_;
		}

		static void n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ServiceOffEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.ServiceOffEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.ServiceOffEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ServiceOffEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.controller.connection.connectionevents.ServiceOffEvent']]"
		[Register ("visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/ServiceOffEvent;)V", "GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_ServiceOffEvent_Handler")]
		public virtual unsafe void Visit (global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.ServiceOffEvent p0)
		{
			if (id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ServiceOffEvent_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ServiceOffEvent_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/ServiceOffEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ServiceOffEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/ServiceOffEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ServiceOnEvent_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_ServiceOnEvent_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ServiceOnEvent_ == null)
				cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ServiceOnEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ServiceOnEvent_);
			return cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ServiceOnEvent_;
		}

		static void n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ServiceOnEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.ServiceOnEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.ServiceOnEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ServiceOnEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.controller.connection.connectionevents.ServiceOnEvent']]"
		[Register ("visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/ServiceOnEvent;)V", "GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_ServiceOnEvent_Handler")]
		public virtual unsafe void Visit (global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.ServiceOnEvent p0)
		{
			if (id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ServiceOnEvent_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ServiceOnEvent_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/ServiceOnEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ServiceOnEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/ServiceOnEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ShutDownEvent_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_ShutDownEvent_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ShutDownEvent_ == null)
				cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ShutDownEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ShutDownEvent_);
			return cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ShutDownEvent_;
		}

		static void n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ShutDownEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.ShutDownEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.ShutDownEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ShutDownEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.controller.connection.connectionevents.ShutDownEvent']]"
		[Register ("visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/ShutDownEvent;)V", "GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_ShutDownEvent_Handler")]
		public virtual unsafe void Visit (global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.ShutDownEvent p0)
		{
			if (id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ShutDownEvent_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ShutDownEvent_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/ShutDownEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_ShutDownEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/ShutDownEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SocketProblemEvent_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_SocketProblemEvent_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SocketProblemEvent_ == null)
				cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SocketProblemEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SocketProblemEvent_);
			return cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SocketProblemEvent_;
		}

		static void n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SocketProblemEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.SocketProblemEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.SocketProblemEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SocketProblemEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.controller.connection.connectionevents.SocketProblemEvent']]"
		[Register ("visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/SocketProblemEvent;)V", "GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_SocketProblemEvent_Handler")]
		public virtual unsafe void Visit (global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.SocketProblemEvent p0)
		{
			if (id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SocketProblemEvent_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SocketProblemEvent_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/SocketProblemEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_SocketProblemEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/SocketProblemEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskFailedEvent_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskFailedEvent_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskFailedEvent_ == null)
				cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskFailedEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskFailedEvent_);
			return cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskFailedEvent_;
		}

		static void n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskFailedEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.TaskFailedEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.TaskFailedEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskFailedEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.controller.connection.connectionevents.TaskFailedEvent']]"
		[Register ("visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/TaskFailedEvent;)V", "GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskFailedEvent_Handler")]
		public virtual unsafe void Visit (global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.TaskFailedEvent p0)
		{
			if (id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskFailedEvent_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskFailedEvent_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/TaskFailedEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskFailedEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/TaskFailedEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskSuccessEvent_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskSuccessEvent_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskSuccessEvent_ == null)
				cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskSuccessEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskSuccessEvent_);
			return cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskSuccessEvent_;
		}

		static void n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskSuccessEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.TaskSuccessEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.TaskSuccessEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskSuccessEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.controller.connection.connectionevents.TaskSuccessEvent']]"
		[Register ("visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/TaskSuccessEvent;)V", "GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskSuccessEvent_Handler")]
		public virtual unsafe void Visit (global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.TaskSuccessEvent p0)
		{
			if (id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskSuccessEvent_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskSuccessEvent_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/TaskSuccessEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskSuccessEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/TaskSuccessEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskTimeOutEvent_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskTimeOutEvent_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskTimeOutEvent_ == null)
				cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskTimeOutEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskTimeOutEvent_);
			return cb_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskTimeOutEvent_;
		}

		static void n_Visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskTimeOutEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.TaskTimeOutEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.TaskTimeOutEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskTimeOutEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='BaseConnectionState']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.controller.connection.connectionevents.TaskTimeOutEvent']]"
		[Register ("visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/TaskTimeOutEvent;)V", "GetVisit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskTimeOutEvent_Handler")]
		public virtual unsafe void Visit (global::Com.Liveperson.Messaging.Controller.Connection.Connectionevents.TaskTimeOutEvent p0)
		{
			if (id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskTimeOutEvent_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskTimeOutEvent_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/TaskTimeOutEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_controller_connection_connectionevents_TaskTimeOutEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/controller/connection/connectionevents/TaskTimeOutEvent;)V"), __args);
			} finally {
			}
		}

	}
}
