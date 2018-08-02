using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Controller.Connection {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachineOld']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/ConnectionStateMachineOld", DoNotGenerateAcw=true)]
	public partial class ConnectionStateMachineOld : global::Com.Liveperson.Infra.Statemachine.BaseStateMachine, global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownAsync {


		static IntPtr mConnectingTasks_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachineOld']/field[@name='mConnectingTasks']"
		[Register ("mConnectingTasks")]
		protected global::System.Collections.IList MConnectingTasks {
			get {
				if (mConnectingTasks_jfieldId == IntPtr.Zero)
					mConnectingTasks_jfieldId = JNIEnv.GetFieldID (class_ref, "mConnectingTasks", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mConnectingTasks_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mConnectingTasks_jfieldId == IntPtr.Zero)
					mConnectingTasks_jfieldId = JNIEnv.GetFieldID (class_ref, "mConnectingTasks", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mConnectingTasks_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mController_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachineOld']/field[@name='mController']"
		[Register ("mController")]
		protected global::Com.Liveperson.Messaging.Messaging MController {
			get {
				if (mController_jfieldId == IntPtr.Zero)
					mController_jfieldId = JNIEnv.GetFieldID (class_ref, "mController", "Lcom/liveperson/messaging/Messaging;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mController_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mController_jfieldId == IntPtr.Zero)
					mController_jfieldId = JNIEnv.GetFieldID (class_ref, "mController", "Lcom/liveperson/messaging/Messaging;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mController_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mDisconnectingTasks_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachineOld']/field[@name='mDisconnectingTasks']"
		[Register ("mDisconnectingTasks")]
		protected global::System.Collections.IList MDisconnectingTasks {
			get {
				if (mDisconnectingTasks_jfieldId == IntPtr.Zero)
					mDisconnectingTasks_jfieldId = JNIEnv.GetFieldID (class_ref, "mDisconnectingTasks", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mDisconnectingTasks_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDisconnectingTasks_jfieldId == IntPtr.Zero)
					mDisconnectingTasks_jfieldId = JNIEnv.GetFieldID (class_ref, "mDisconnectingTasks", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mDisconnectingTasks_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachineOld.ConnectingState']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/ConnectionStateMachineOld$ConnectingState", DoNotGenerateAcw=true)]
		public partial class ConnectingState : global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/controller/connection/ConnectionStateMachineOld$ConnectingState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ConnectingState); }
			}

			protected ConnectingState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachineOld_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachineOld.ConnectingState']/constructor[@name='ConnectionStateMachineOld.ConnectingState' and count(parameter)=3 and parameter[1][@type='com.liveperson.messaging.controller.connection.ConnectionStateMachineOld'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachineOld;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe ConnectingState (global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachineOld __self, string p1, string p2)
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

					if (id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachineOld_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachineOld_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachineOld;Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachineOld_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachineOld_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachineOld.DisconnectingState']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/ConnectionStateMachineOld$DisconnectingState", DoNotGenerateAcw=true)]
		public partial class DisconnectingState : global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/controller/connection/ConnectionStateMachineOld$DisconnectingState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DisconnectingState); }
			}

			protected DisconnectingState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachineOld_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachineOld.DisconnectingState']/constructor[@name='ConnectionStateMachineOld.DisconnectingState' and count(parameter)=3 and parameter[1][@type='com.liveperson.messaging.controller.connection.ConnectionStateMachineOld'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachineOld;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe DisconnectingState (global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachineOld __self, string p1, string p2)
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

					if (id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachineOld_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachineOld_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachineOld;Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachineOld_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachineOld_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachineOld.IdleState']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/ConnectionStateMachineOld$IdleState", DoNotGenerateAcw=true)]
		public partial class IdleState : global::Com.Liveperson.Messaging.Controller.Connection.BaseConnectionState {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/controller/connection/ConnectionStateMachineOld$IdleState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IdleState); }
			}

			protected IdleState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachineOld_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachineOld.IdleState']/constructor[@name='ConnectionStateMachineOld.IdleState' and count(parameter)=3 and parameter[1][@type='com.liveperson.messaging.controller.connection.ConnectionStateMachineOld'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachineOld;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe IdleState (global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachineOld __self, string p1, string p2)
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
					if (((object) this).GetType () != typeof (IdleState)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachineOld_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachineOld_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/controller/connection/ConnectionStateMachineOld;Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachineOld_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_controller_connection_ConnectionStateMachineOld_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/controller/connection/ConnectionStateMachineOld", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectionStateMachineOld); }
		}

		protected ConnectionStateMachineOld (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_Messaging_Lcom_liveperson_messaging_controller_connection_InternetInformationProvider_Ljava_lang_String_Lcom_liveperson_messaging_controller_connection_IConnectionListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachineOld']/constructor[@name='ConnectionStateMachineOld' and count(parameter)=4 and parameter[1][@type='com.liveperson.messaging.Messaging'] and parameter[2][@type='com.liveperson.messaging.controller.connection.InternetInformationProvider'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.liveperson.messaging.controller.connection.IConnectionListener']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/Messaging;Lcom/liveperson/messaging/controller/connection/InternetInformationProvider;Ljava/lang/String;Lcom/liveperson/messaging/controller/connection/IConnectionListener;)V", "")]
		public unsafe ConnectionStateMachineOld (global::Com.Liveperson.Messaging.Messaging p0, global::Com.Liveperson.Messaging.Controller.Connection.IInternetInformationProvider p1, string p2, global::Com.Liveperson.Messaging.Controller.Connection.IConnectionListener p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (ConnectionStateMachineOld)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/Messaging;Lcom/liveperson/messaging/controller/connection/InternetInformationProvider;Ljava/lang/String;Lcom/liveperson/messaging/controller/connection/IConnectionListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/Messaging;Lcom/liveperson/messaging/controller/connection/InternetInformationProvider;Ljava/lang/String;Lcom/liveperson/messaging/controller/connection/IConnectionListener;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_Messaging_Lcom_liveperson_messaging_controller_connection_InternetInformationProvider_Ljava_lang_String_Lcom_liveperson_messaging_controller_connection_IConnectionListener_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_Messaging_Lcom_liveperson_messaging_controller_connection_InternetInformationProvider_Ljava_lang_String_Lcom_liveperson_messaging_controller_connection_IConnectionListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/Messaging;Lcom/liveperson/messaging/controller/connection/InternetInformationProvider;Ljava/lang/String;Lcom/liveperson/messaging/controller/connection/IConnectionListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Lcom_liveperson_messaging_controller_connection_InternetInformationProvider_Ljava_lang_String_Lcom_liveperson_messaging_controller_connection_IConnectionListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Lcom_liveperson_messaging_controller_connection_InternetInformationProvider_Ljava_lang_String_Lcom_liveperson_messaging_controller_connection_IConnectionListener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_setBrandId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBrandId_Ljava_lang_String_Handler ()
		{
			if (cb_setBrandId_Ljava_lang_String_ == null)
				cb_setBrandId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBrandId_Ljava_lang_String_);
			return cb_setBrandId_Ljava_lang_String_;
		}

		static void n_SetBrandId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachineOld __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachineOld> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBrandId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBrandId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachineOld']/method[@name='setBrandId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setBrandId", "(Ljava/lang/String;)V", "GetSetBrandId_Ljava_lang_String_Handler")]
		public virtual unsafe void SetBrandId (string p0)
		{
			if (id_setBrandId_Ljava_lang_String_ == IntPtr.Zero)
				id_setBrandId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBrandId", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBrandId_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBrandId", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachineOld __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachineOld> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetConnectingTasks (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setConnectingTasks_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachineOld']/method[@name='setConnectingTasks' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.liveperson.messaging.commands.tasks.BaseAmsAccountConnectionTask&gt;']]"
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
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachineOld __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachineOld> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsAccountConnectionTask>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDisconnectingTasks (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDisconnectingTasks_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachineOld']/method[@name='setDisconnectingTasks' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.liveperson.messaging.commands.tasks.BaseAmsAccountConnectionTask&gt;']]"
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
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachineOld __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachineOld> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener p0 = (global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShutDown (p0);
		}
#pragma warning restore 0169

		static IntPtr id_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachineOld']/method[@name='shutDown' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.shutdown.ShutDownCompletionListener']]"
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

		static Delegate cb_startConnecting;
#pragma warning disable 0169
		static Delegate GetStartConnectingHandler ()
		{
			if (cb_startConnecting == null)
				cb_startConnecting = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartConnecting);
			return cb_startConnecting;
		}

		static void n_StartConnecting (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachineOld __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachineOld> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartConnecting ();
		}
#pragma warning restore 0169

		static IntPtr id_startConnecting;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachineOld']/method[@name='startConnecting' and count(parameter)=0]"
		[Register ("startConnecting", "()V", "GetStartConnectingHandler")]
		public virtual unsafe void StartConnecting ()
		{
			if (id_startConnecting == IntPtr.Zero)
				id_startConnecting = JNIEnv.GetMethodID (class_ref, "startConnecting", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startConnecting);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startConnecting", "()V"));
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
			global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachineOld __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachineOld> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartDisconnecting ();
		}
#pragma warning restore 0169

		static IntPtr id_startDisconnecting;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/class[@name='ConnectionStateMachineOld']/method[@name='startDisconnecting' and count(parameter)=0]"
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
