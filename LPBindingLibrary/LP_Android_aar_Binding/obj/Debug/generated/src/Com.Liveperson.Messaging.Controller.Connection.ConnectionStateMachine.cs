using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Controller.Connection {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/ConnectionStateMachine", DoNotGenerateAcw=true)]
	public partial class ConnectionStateMachine : global::Com.Liveperson.Infra.Statemachine.BaseStateMachine, global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownAsync {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine.AbstractBackgroundParentState']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/ConnectionStateMachine$AbstractBackgroundParentState", DoNotGenerateAcw=true)]
		public abstract partial class AbstractBackgroundParentState : global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState {


			static IntPtr mBackgroundConnectionTimeoutEvent_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine.AbstractBackgroundParentState']/field[@name='mBackgroundConnectionTimeoutEvent']"
			[Register ("mBackgroundConnectionTimeoutEvent")]
			protected global::Java.Lang.IRunnable MBackgroundConnectionTimeoutEvent {
				get {
					if (mBackgroundConnectionTimeoutEvent_jfieldId == IntPtr.Zero)
						mBackgroundConnectionTimeoutEvent_jfieldId = JNIEnv.GetFieldID (class_ref, "mBackgroundConnectionTimeoutEvent", "Ljava/lang/Runnable;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mBackgroundConnectionTimeoutEvent_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mBackgroundConnectionTimeoutEvent_jfieldId == IntPtr.Zero)
						mBackgroundConnectionTimeoutEvent_jfieldId = JNIEnv.GetFieldID (class_ref, "mBackgroundConnectionTimeoutEvent", "Ljava/lang/Runnable;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mBackgroundConnectionTimeoutEvent_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/controller/connection/ConnectionStateMachine$AbstractBackgroundParentState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AbstractBackgroundParentState); }
			}

			protected AbstractBackgroundParentState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine.AbstractBackgroundParentState']/constructor[@name='ConnectionStateMachine.AbstractBackgroundParentState' and count(parameter)=3 and parameter[1][@type='com.liveperson.messaging.controller.connection.ConnectionStateMachine'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe AbstractBackgroundParentState (global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine __self, string p1, string p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					if (((object) this).GetType () != typeof (AbstractBackgroundParentState)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine;Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

			static Delegate cb_getBackgroundConnectionTimeoutEvent;
#pragma warning disable 0169
			static Delegate GetGetBackgroundConnectionTimeoutEventHandler ()
			{
				if (cb_getBackgroundConnectionTimeoutEvent == null)
					cb_getBackgroundConnectionTimeoutEvent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBackgroundConnectionTimeoutEvent);
				return cb_getBackgroundConnectionTimeoutEvent;
			}

			static IntPtr n_GetBackgroundConnectionTimeoutEvent (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine.AbstractBackgroundParentState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine.AbstractBackgroundParentState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.BackgroundConnectionTimeoutEvent);
			}
#pragma warning restore 0169

			static IntPtr id_getBackgroundConnectionTimeoutEvent;
			public virtual unsafe global::Java.Lang.IRunnable BackgroundConnectionTimeoutEvent {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine.AbstractBackgroundParentState']/method[@name='getBackgroundConnectionTimeoutEvent' and count(parameter)=0]"
				[Register ("getBackgroundConnectionTimeoutEvent", "()Ljava/lang/Runnable;", "GetGetBackgroundConnectionTimeoutEventHandler")]
				get {
					if (id_getBackgroundConnectionTimeoutEvent == IntPtr.Zero)
						id_getBackgroundConnectionTimeoutEvent = JNIEnv.GetMethodID (class_ref, "getBackgroundConnectionTimeoutEvent", "()Ljava/lang/Runnable;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBackgroundConnectionTimeoutEvent), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBackgroundConnectionTimeoutEvent", "()Ljava/lang/Runnable;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/ConnectionStateMachine$AbstractBackgroundParentState", DoNotGenerateAcw=true)]
		internal partial class AbstractBackgroundParentStateInvoker : AbstractBackgroundParentState {

			public AbstractBackgroundParentStateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (AbstractBackgroundParentStateInvoker); }
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine.BackgroundParentState']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/ConnectionStateMachine$BackgroundParentState", DoNotGenerateAcw=true)]
		public partial class BackgroundParentState : global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine.AbstractBackgroundParentState {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/controller/connection/ConnectionStateMachine$BackgroundParentState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BackgroundParentState); }
			}

			protected BackgroundParentState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine.BackgroundParentState']/constructor[@name='ConnectionStateMachine.BackgroundParentState' and count(parameter)=3 and parameter[1][@type='com.liveperson.messaging.controller.connection.ConnectionStateMachine'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe BackgroundParentState (global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine __self, string p1, string p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					if (((object) this).GetType () != typeof (BackgroundParentState)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine;Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine.ConnectedBackgroundServiceState']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/ConnectionStateMachine$ConnectedBackgroundServiceState", DoNotGenerateAcw=true)]
		public partial class ConnectedBackgroundServiceState : global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine.ConnectedBaseState {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/controller/connection/ConnectionStateMachine$ConnectedBackgroundServiceState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ConnectedBackgroundServiceState); }
			}

			protected ConnectedBackgroundServiceState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_AbstractBackgroundParentState_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine.ConnectedBackgroundServiceState']/constructor[@name='ConnectionStateMachine.ConnectedBackgroundServiceState' and count(parameter)=4 and parameter[1][@type='com.liveperson.messaging.controller.connection.ConnectionStateMachine'] and parameter[2][@type='com.liveperson.messaging.controller.connection.ConnectionStateMachine.AbstractBackgroundParentState'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine;Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine$AbstractBackgroundParentState;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe ConnectedBackgroundServiceState (global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine __self, global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine.AbstractBackgroundParentState p1, string p2, string p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p2 = JNIEnv.NewString (p2);
				IntPtr native_p3 = JNIEnv.NewString (p3);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (native_p3);
					if (((object) this).GetType () != typeof (ConnectedBackgroundServiceState)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine$AbstractBackgroundParentState;Ljava/lang/String;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine$AbstractBackgroundParentState;Ljava/lang/String;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_AbstractBackgroundParentState_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_AbstractBackgroundParentState_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine;Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine$AbstractBackgroundParentState;Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_AbstractBackgroundParentState_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_AbstractBackgroundParentState_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p2);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine.ConnectedBackgroundState']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/ConnectionStateMachine$ConnectedBackgroundState", DoNotGenerateAcw=true)]
		public partial class ConnectedBackgroundState : global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine.ConnectedBaseState {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/controller/connection/ConnectionStateMachine$ConnectedBackgroundState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ConnectedBackgroundState); }
			}

			protected ConnectedBackgroundState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Lcom_liveperson_messaging_controller_connection_BaseConnectionState_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine.ConnectedBackgroundState']/constructor[@name='ConnectionStateMachine.ConnectedBackgroundState' and count(parameter)=4 and parameter[1][@type='com.liveperson.messaging.controller.connection.ConnectionStateMachine'] and parameter[2][@type='com.liveperson.messaging.controller.connection.BaseConnectionState'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine;Lcom/liveperson/messaging/controller/connection/BaseConnectionState;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe ConnectedBackgroundState (global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine __self, global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState p1, string p2, string p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p2 = JNIEnv.NewString (p2);
				IntPtr native_p3 = JNIEnv.NewString (p3);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (native_p3);
					if (((object) this).GetType () != typeof (ConnectedBackgroundState)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/liveperson/messaging/controller/connection/BaseConnectionState;Ljava/lang/String;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/liveperson/messaging/controller/connection/BaseConnectionState;Ljava/lang/String;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Lcom_liveperson_messaging_controller_connection_BaseConnectionState_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Lcom_liveperson_messaging_controller_connection_BaseConnectionState_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine;Lcom/liveperson/messaging/controller/connection/BaseConnectionState;Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Lcom_liveperson_messaging_controller_connection_BaseConnectionState_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Lcom_liveperson_messaging_controller_connection_BaseConnectionState_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p2);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine.ConnectedBaseState']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/ConnectionStateMachine$ConnectedBaseState", DoNotGenerateAcw=true)]
		public abstract partial class ConnectedBaseState : global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/controller/connection/ConnectionStateMachine$ConnectedBaseState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ConnectedBaseState); }
			}

			protected ConnectedBaseState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Lcom_liveperson_messaging_controller_connection_BaseConnectionState_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine.ConnectedBaseState']/constructor[@name='ConnectionStateMachine.ConnectedBaseState' and count(parameter)=4 and parameter[1][@type='com.liveperson.messaging.controller.connection.ConnectionStateMachine'] and parameter[2][@type='com.liveperson.messaging.controller.connection.BaseConnectionState'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine;Lcom/liveperson/messaging/controller/connection/BaseConnectionState;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe ConnectedBaseState (global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine __self, global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState p1, string p2, string p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p2 = JNIEnv.NewString (p2);
				IntPtr native_p3 = JNIEnv.NewString (p3);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (native_p3);
					if (((object) this).GetType () != typeof (ConnectedBaseState)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/liveperson/messaging/controller/connection/BaseConnectionState;Ljava/lang/String;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/liveperson/messaging/controller/connection/BaseConnectionState;Ljava/lang/String;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Lcom_liveperson_messaging_controller_connection_BaseConnectionState_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Lcom_liveperson_messaging_controller_connection_BaseConnectionState_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine;Lcom/liveperson/messaging/controller/connection/BaseConnectionState;Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Lcom_liveperson_messaging_controller_connection_BaseConnectionState_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Lcom_liveperson_messaging_controller_connection_BaseConnectionState_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p2);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}

		}

		[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/ConnectionStateMachine$ConnectedBaseState", DoNotGenerateAcw=true)]
		internal partial class ConnectedBaseStateInvoker : ConnectedBaseState {

			public ConnectedBaseStateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (ConnectedBaseStateInvoker); }
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine.ConnectedForegroundServiceState']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/ConnectionStateMachine$ConnectedForegroundServiceState", DoNotGenerateAcw=true)]
		public partial class ConnectedForegroundServiceState : global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine.ConnectedBaseState {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/controller/connection/ConnectionStateMachine$ConnectedForegroundServiceState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ConnectedForegroundServiceState); }
			}

			protected ConnectedForegroundServiceState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Lcom_liveperson_messaging_controller_connection_BaseConnectionState_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine.ConnectedForegroundServiceState']/constructor[@name='ConnectionStateMachine.ConnectedForegroundServiceState' and count(parameter)=4 and parameter[1][@type='com.liveperson.messaging.controller.connection.ConnectionStateMachine'] and parameter[2][@type='com.liveperson.messaging.controller.connection.BaseConnectionState'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine;Lcom/liveperson/messaging/controller/connection/BaseConnectionState;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe ConnectedForegroundServiceState (global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine __self, global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState p1, string p2, string p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p2 = JNIEnv.NewString (p2);
				IntPtr native_p3 = JNIEnv.NewString (p3);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (native_p3);
					if (((object) this).GetType () != typeof (ConnectedForegroundServiceState)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/liveperson/messaging/controller/connection/BaseConnectionState;Ljava/lang/String;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/liveperson/messaging/controller/connection/BaseConnectionState;Ljava/lang/String;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Lcom_liveperson_messaging_controller_connection_BaseConnectionState_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Lcom_liveperson_messaging_controller_connection_BaseConnectionState_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine;Lcom/liveperson/messaging/controller/connection/BaseConnectionState;Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Lcom_liveperson_messaging_controller_connection_BaseConnectionState_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Lcom_liveperson_messaging_controller_connection_BaseConnectionState_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p2);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine.ConnectedForegroundState']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/ConnectionStateMachine$ConnectedForegroundState", DoNotGenerateAcw=true)]
		public partial class ConnectedForegroundState : global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine.ConnectedBaseState {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/controller/connection/ConnectionStateMachine$ConnectedForegroundState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ConnectedForegroundState); }
			}

			protected ConnectedForegroundState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Lcom_liveperson_messaging_controller_connection_BaseConnectionState_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine.ConnectedForegroundState']/constructor[@name='ConnectionStateMachine.ConnectedForegroundState' and count(parameter)=4 and parameter[1][@type='com.liveperson.messaging.controller.connection.ConnectionStateMachine'] and parameter[2][@type='com.liveperson.messaging.controller.connection.BaseConnectionState'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine;Lcom/liveperson/messaging/controller/connection/BaseConnectionState;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe ConnectedForegroundState (global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine __self, global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState p1, string p2, string p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p2 = JNIEnv.NewString (p2);
				IntPtr native_p3 = JNIEnv.NewString (p3);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (native_p3);
					if (((object) this).GetType () != typeof (ConnectedForegroundState)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/liveperson/messaging/controller/connection/BaseConnectionState;Ljava/lang/String;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/liveperson/messaging/controller/connection/BaseConnectionState;Ljava/lang/String;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Lcom_liveperson_messaging_controller_connection_BaseConnectionState_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Lcom_liveperson_messaging_controller_connection_BaseConnectionState_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine;Lcom/liveperson/messaging/controller/connection/BaseConnectionState;Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Lcom_liveperson_messaging_controller_connection_BaseConnectionState_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Lcom_liveperson_messaging_controller_connection_BaseConnectionState_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p2);
					JNIEnv.DeleteLocalRef (native_p3);
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
				global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine.ConnectedForegroundState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine.ConnectedForegroundState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ActionOnEntry ();
			}
#pragma warning restore 0169

			static IntPtr id_actionOnEntry;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine.ConnectedForegroundState']/method[@name='actionOnEntry' and count(parameter)=0]"
			[Register ("actionOnEntry", "()V", "GetActionOnEntryHandler")]
			public override unsafe void ActionOnEntry ()
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine.ConnectingState']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/ConnectionStateMachine$ConnectingState", DoNotGenerateAcw=true)]
		public partial class ConnectingState : global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/controller/connection/ConnectionStateMachine$ConnectingState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ConnectingState); }
			}

			protected ConnectingState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine.ConnectingState']/constructor[@name='ConnectionStateMachine.ConnectingState' and count(parameter)=3 and parameter[1][@type='com.liveperson.messaging.controller.connection.ConnectionStateMachine'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe ConnectingState (global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine __self, string p1, string p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					if (((object) this).GetType () != typeof (ConnectingState)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine;Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine.DisconnectedState']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/ConnectionStateMachine$DisconnectedState", DoNotGenerateAcw=true)]
		public partial class DisconnectedState : global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/controller/connection/ConnectionStateMachine$DisconnectedState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DisconnectedState); }
			}

			protected DisconnectedState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine.DisconnectedState']/constructor[@name='ConnectionStateMachine.DisconnectedState' and count(parameter)=3 and parameter[1][@type='com.liveperson.messaging.controller.connection.ConnectionStateMachine'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe DisconnectedState (global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine __self, string p1, string p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					if (((object) this).GetType () != typeof (DisconnectedState)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine;Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine.DisconnectingState']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/ConnectionStateMachine$DisconnectingState", DoNotGenerateAcw=true)]
		public partial class DisconnectingState : global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/controller/connection/ConnectionStateMachine$DisconnectingState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DisconnectingState); }
			}

			protected DisconnectingState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine.DisconnectingState']/constructor[@name='ConnectionStateMachine.DisconnectingState' and count(parameter)=3 and parameter[1][@type='com.liveperson.messaging.controller.connection.ConnectionStateMachine'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe DisconnectingState (global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine __self, string p1, string p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					if (((object) this).GetType () != typeof (DisconnectingState)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine;Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine.ForegroundParentState']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/ConnectionStateMachine$ForegroundParentState", DoNotGenerateAcw=true)]
		public partial class ForegroundParentState : global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/controller/connection/ConnectionStateMachine$ForegroundParentState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ForegroundParentState); }
			}

			protected ForegroundParentState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine.ForegroundParentState']/constructor[@name='ConnectionStateMachine.ForegroundParentState' and count(parameter)=3 and parameter[1][@type='com.liveperson.messaging.controller.connection.ConnectionStateMachine'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe ForegroundParentState (global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine __self, string p1, string p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					if (((object) this).GetType () != typeof (ForegroundParentState)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine;Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachine_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/controller/connection/ConnectionStateMachine", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectionStateMachine); }
		}

		protected ConnectionStateMachine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_controller_connection_MessagingStateMachineInterface_Lcom_liveperson_messaging_controller_connection_InternetInformationProvider_Lcom_liveperson_infra_ForegroundServiceInterface_Ljava_lang_String_Lcom_liveperson_messaging_controller_connection_IConnectionListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine']/constructor[@name='ConnectionStateMachine' and count(parameter)=5 and parameter[1][@type='com.liveperson.messaging.controller.connection.MessagingStateMachineInterface'] and parameter[2][@type='com.liveperson.messaging.controller.connection.InternetInformationProvider'] and parameter[3][@type='com.liveperson.infra.ForegroundServiceInterface'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.liveperson.messaging.controller.connection.IConnectionListener']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/controller/connection/MessagingStateMachineInterface;Lcom/liveperson/messaging/controller/connection/InternetInformationProvider;Lcom/liveperson/infra/ForegroundServiceInterface;Ljava/lang/String;Lcom/liveperson/messaging/controller/connection/IConnectionListener;)V", "")]
		public unsafe ConnectionStateMachine (global::Com.Liveperson.Messaging.Controller.Connection.IMessagingStateMachineInterface p0, global::Com.Liveperson.Messaging.Controller.Connection.IInternetInformationProvider p1, global::Com.Liveperson.Infra.IForegroundServiceInterface p2, string p3, global::Com.Liveperson.Messaging.Controller.Connection.IConnectionListener p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				if (((object) this).GetType () != typeof (ConnectionStateMachine)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/controller/connection/MessagingStateMachineInterface;Lcom/liveperson/messaging/controller/connection/InternetInformationProvider;Lcom/liveperson/infra/ForegroundServiceInterface;Ljava/lang/String;Lcom/liveperson/messaging/controller/connection/IConnectionListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/controller/connection/MessagingStateMachineInterface;Lcom/liveperson/messaging/controller/connection/InternetInformationProvider;Lcom/liveperson/infra/ForegroundServiceInterface;Ljava/lang/String;Lcom/liveperson/messaging/controller/connection/IConnectionListener;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_controller_connection_MessagingStateMachineInterface_Lcom_liveperson_messaging_controller_connection_InternetInformationProvider_Lcom_liveperson_infra_ForegroundServiceInterface_Ljava_lang_String_Lcom_liveperson_messaging_controller_connection_IConnectionListener_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_controller_connection_MessagingStateMachineInterface_Lcom_liveperson_messaging_controller_connection_InternetInformationProvider_Lcom_liveperson_infra_ForegroundServiceInterface_Ljava_lang_String_Lcom_liveperson_messaging_controller_connection_IConnectionListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/controller/connection/MessagingStateMachineInterface;Lcom/liveperson/messaging/controller/connection/InternetInformationProvider;Lcom/liveperson/infra/ForegroundServiceInterface;Ljava/lang/String;Lcom/liveperson/messaging/controller/connection/IConnectionListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_MessagingStateMachineInterface_Lcom_liveperson_messaging_controller_connection_InternetInformationProvider_Lcom_liveperson_infra_ForegroundServiceInterface_Ljava_lang_String_Lcom_liveperson_messaging_controller_connection_IConnectionListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_MessagingStateMachineInterface_Lcom_liveperson_messaging_controller_connection_InternetInformationProvider_Lcom_liveperson_infra_ForegroundServiceInterface_Ljava_lang_String_Lcom_liveperson_messaging_controller_connection_IConnectionListener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
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
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		static IntPtr id_isConnected;
		public virtual unsafe bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine']/method[@name='isConnected' and count(parameter)=0]"
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
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnecting;
		}
#pragma warning restore 0169

		static IntPtr id_isConnecting;
		public virtual unsafe bool IsConnecting {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine']/method[@name='isConnecting' and count(parameter)=0]"
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

		static Delegate cb_moveToBackground_J;
#pragma warning disable 0169
		static Delegate GetMoveToBackground_JHandler ()
		{
			if (cb_moveToBackground_J == null)
				cb_moveToBackground_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_MoveToBackground_J);
			return cb_moveToBackground_J;
		}

		static void n_MoveToBackground_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MoveToBackground (p0);
		}
#pragma warning restore 0169

		static IntPtr id_moveToBackground_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine']/method[@name='moveToBackground' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("moveToBackground", "(J)V", "GetMoveToBackground_JHandler")]
		public virtual unsafe void MoveToBackground (long p0)
		{
			if (id_moveToBackground_J == IntPtr.Zero)
				id_moveToBackground_J = JNIEnv.GetMethodID (class_ref, "moveToBackground", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_moveToBackground_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moveToBackground", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_moveToForeground;
#pragma warning disable 0169
		static Delegate GetMoveToForegroundHandler ()
		{
			if (cb_moveToForeground == null)
				cb_moveToForeground = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_MoveToForeground);
			return cb_moveToForeground;
		}

		static void n_MoveToForeground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MoveToForeground ();
		}
#pragma warning restore 0169

		static IntPtr id_moveToForeground;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine']/method[@name='moveToForeground' and count(parameter)=0]"
		[Register ("moveToForeground", "()V", "GetMoveToForegroundHandler")]
		public virtual unsafe void MoveToForeground ()
		{
			if (id_moveToForeground == IntPtr.Zero)
				id_moveToForeground = JNIEnv.GetMethodID (class_ref, "moveToForeground", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_moveToForeground);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moveToForeground", "()V"));
			} finally {
			}
		}

		static Delegate cb_networkAvailable;
#pragma warning disable 0169
		static Delegate GetNetworkAvailableHandler ()
		{
			if (cb_networkAvailable == null)
				cb_networkAvailable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NetworkAvailable);
			return cb_networkAvailable;
		}

		static void n_NetworkAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NetworkAvailable ();
		}
#pragma warning restore 0169

		static IntPtr id_networkAvailable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine']/method[@name='networkAvailable' and count(parameter)=0]"
		[Register ("networkAvailable", "()V", "GetNetworkAvailableHandler")]
		public virtual unsafe void NetworkAvailable ()
		{
			if (id_networkAvailable == IntPtr.Zero)
				id_networkAvailable = JNIEnv.GetMethodID (class_ref, "networkAvailable", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_networkAvailable);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "networkAvailable", "()V"));
			} finally {
			}
		}

		static Delegate cb_networkLost;
#pragma warning disable 0169
		static Delegate GetNetworkLostHandler ()
		{
			if (cb_networkLost == null)
				cb_networkLost = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NetworkLost);
			return cb_networkLost;
		}

		static void n_NetworkLost (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NetworkLost ();
		}
#pragma warning restore 0169

		static IntPtr id_networkLost;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine']/method[@name='networkLost' and count(parameter)=0]"
		[Register ("networkLost", "()V", "GetNetworkLostHandler")]
		public virtual unsafe void NetworkLost ()
		{
			if (id_networkLost == IntPtr.Zero)
				id_networkLost = JNIEnv.GetMethodID (class_ref, "networkLost", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_networkLost);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "networkLost", "()V"));
			} finally {
			}
		}

		static Delegate cb_onSocketProblem;
#pragma warning disable 0169
		static Delegate GetOnSocketProblemHandler ()
		{
			if (cb_onSocketProblem == null)
				cb_onSocketProblem = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSocketProblem);
			return cb_onSocketProblem;
		}

		static void n_OnSocketProblem (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSocketProblem ();
		}
#pragma warning restore 0169

		static IntPtr id_onSocketProblem;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine']/method[@name='onSocketProblem' and count(parameter)=0]"
		[Register ("onSocketProblem", "()V", "GetOnSocketProblemHandler")]
		public virtual unsafe void OnSocketProblem ()
		{
			if (id_onSocketProblem == IntPtr.Zero)
				id_onSocketProblem = JNIEnv.GetMethodID (class_ref, "onSocketProblem", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSocketProblem);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSocketProblem", "()V"));
			} finally {
			}
		}

		static Delegate cb_serviceStarted;
#pragma warning disable 0169
		static Delegate GetServiceStartedHandler ()
		{
			if (cb_serviceStarted == null)
				cb_serviceStarted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ServiceStarted);
			return cb_serviceStarted;
		}

		static void n_ServiceStarted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ServiceStarted ();
		}
#pragma warning restore 0169

		static IntPtr id_serviceStarted;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine']/method[@name='serviceStarted' and count(parameter)=0]"
		[Register ("serviceStarted", "()V", "GetServiceStartedHandler")]
		public virtual unsafe void ServiceStarted ()
		{
			if (id_serviceStarted == IntPtr.Zero)
				id_serviceStarted = JNIEnv.GetMethodID (class_ref, "serviceStarted", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_serviceStarted);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "serviceStarted", "()V"));
			} finally {
			}
		}

		static Delegate cb_serviceStopped;
#pragma warning disable 0169
		static Delegate GetServiceStoppedHandler ()
		{
			if (cb_serviceStopped == null)
				cb_serviceStopped = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ServiceStopped);
			return cb_serviceStopped;
		}

		static void n_ServiceStopped (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ServiceStopped ();
		}
#pragma warning restore 0169

		static IntPtr id_serviceStopped;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine']/method[@name='serviceStopped' and count(parameter)=0]"
		[Register ("serviceStopped", "()V", "GetServiceStoppedHandler")]
		public virtual unsafe void ServiceStopped ()
		{
			if (id_serviceStopped == IntPtr.Zero)
				id_serviceStopped = JNIEnv.GetMethodID (class_ref, "serviceStopped", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_serviceStopped);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "serviceStopped", "()V"));
			} finally {
			}
		}

		static Delegate cb_setConnectingTasks_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetConnectingTasks_Ljava_util_List_Handler ()
		{
			if (cb_setConnectingTasks_Ljava_util_List_ == null)
				cb_setConnectingTasks_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConnectingTasks_Ljava_util_List_);
			return cb_setConnectingTasks_Ljava_util_List_;
		}

		static void n_SetConnectingTasks_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetConnectingTasks (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setConnectingTasks_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine']/method[@name='setConnectingTasks' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.liveperson.messaging.commands.tasks.BaseAmsAccountConnectionTask&gt;']]"
		[Register ("setConnectingTasks", "(Ljava/util/List;)V", "GetSetConnectingTasks_Ljava_util_List_Handler")]
		public virtual unsafe void SetConnectingTasks (global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask> p0)
		{
			if (id_setConnectingTasks_Ljava_util_List_ == IntPtr.Zero)
				id_setConnectingTasks_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setConnectingTasks", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConnectingTasks_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConnectingTasks", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setDisconnectingTasks_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetDisconnectingTasks_Ljava_util_List_Handler ()
		{
			if (cb_setDisconnectingTasks_Ljava_util_List_ == null)
				cb_setDisconnectingTasks_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDisconnectingTasks_Ljava_util_List_);
			return cb_setDisconnectingTasks_Ljava_util_List_;
		}

		static void n_SetDisconnectingTasks_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDisconnectingTasks (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDisconnectingTasks_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine']/method[@name='setDisconnectingTasks' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.liveperson.messaging.commands.tasks.BaseAmsAccountConnectionTask&gt;']]"
		[Register ("setDisconnectingTasks", "(Ljava/util/List;)V", "GetSetDisconnectingTasks_Ljava_util_List_Handler")]
		public virtual unsafe void SetDisconnectingTasks (global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask> p0)
		{
			if (id_setDisconnectingTasks_Ljava_util_List_ == IntPtr.Zero)
				id_setDisconnectingTasks_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setDisconnectingTasks", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDisconnectingTasks_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisconnectingTasks", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_;
#pragma warning disable 0169
		static Delegate GetShutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_Handler ()
		{
			if (cb_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ == null)
				cb_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_);
			return cb_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_;
		}

		static void n_ShutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener p0 = (global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShutDown (p0);
		}
#pragma warning restore 0169

		static IntPtr id_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine']/method[@name='shutDown' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.shutdown.ShutDownCompletionListener']]"
		[Register ("shutDown", "(Lcom/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener;)V", "GetShutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_Handler")]
		public virtual unsafe void ShutDown (global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener p0)
		{
			if (id_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ == IntPtr.Zero)
				id_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ = JNIEnv.GetMethodID (class_ref, "shutDown", "(Lcom/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shutDown", "(Lcom/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startConnecting_Z;
#pragma warning disable 0169
		static Delegate GetStartConnecting_ZHandler ()
		{
			if (cb_startConnecting_Z == null)
				cb_startConnecting_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_StartConnecting_Z);
			return cb_startConnecting_Z;
		}

		static void n_StartConnecting_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartConnecting (p0);
		}
#pragma warning restore 0169

		static IntPtr id_startConnecting_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine']/method[@name='startConnecting' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("startConnecting", "(Z)V", "GetStartConnecting_ZHandler")]
		public virtual unsafe void StartConnecting (bool p0)
		{
			if (id_startConnecting_Z == IntPtr.Zero)
				id_startConnecting_Z = JNIEnv.GetMethodID (class_ref, "startConnecting", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startConnecting_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startConnecting", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startDisconnecting;
#pragma warning disable 0169
		static Delegate GetStartDisconnectingHandler ()
		{
			if (cb_startDisconnecting == null)
				cb_startDisconnecting = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartDisconnecting);
			return cb_startDisconnecting;
		}

		static void n_StartDisconnecting (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartDisconnecting ();
		}
#pragma warning restore 0169

		static IntPtr id_startDisconnecting;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachine']/method[@name='startDisconnecting' and count(parameter)=0]"
		[Register ("startDisconnecting", "()V", "GetStartDisconnectingHandler")]
		public virtual unsafe void StartDisconnecting ()
		{
			if (id_startDisconnecting == IntPtr.Zero)
				id_startDisconnecting = JNIEnv.GetMethodID (class_ref, "startDisconnecting", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startDisconnecting);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startDisconnecting", "()V"));
			} finally {
			}
		}

	}
}
