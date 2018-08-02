using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/model/AmsConnection", DoNotGenerateAcw=true)]
	public partial class AmsConnection : global::Java.Lang.Object, global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownAsync {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/field[@name='BROADCAST_AMS_CONNECTION_UPDATE_ACTION']"
		[Register ("BROADCAST_AMS_CONNECTION_UPDATE_ACTION")]
		public const string BroadcastAmsConnectionUpdateAction = (string) "BROADCAST_AMS_CONNECTION_UPDATE_ACTION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/field[@name='BROADCAST_AMS_CONNECTION_UPDATE_EXTRA']"
		[Register ("BROADCAST_AMS_CONNECTION_UPDATE_EXTRA")]
		public const string BroadcastAmsConnectionUpdateExtra = (string) "BROADCAST_AMS_CONNECTION_UPDATE_EXTRA";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/field[@name='BROADCAST_CONNECTING_TO_SERVER_ERROR']"
		[Register ("BROADCAST_CONNECTING_TO_SERVER_ERROR")]
		public const string BroadcastConnectingToServerError = (string) "BROADCAST_CONNECTING_TO_SERVER_ERROR";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/field[@name='BROADCAST_KEY_BRAND_ID']"
		[Register ("BROADCAST_KEY_BRAND_ID")]
		public const string BroadcastKeyBrandId = (string) "BROADCAST_KEY_BRAND_ID";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/field[@name='BROADCAST_KEY_SOCKET_READY_ACTION']"
		[Register ("BROADCAST_KEY_SOCKET_READY_ACTION")]
		public const string BroadcastKeySocketReadyAction = (string) "BROADCAST_KEY_SOCKET_READY_ACTION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/field[@name='BROADCAST_KEY_SOCKET_READY_EXTRA']"
		[Register ("BROADCAST_KEY_SOCKET_READY_EXTRA")]
		public const string BroadcastKeySocketReadyExtra = (string) "BROADCAST_KEY_SOCKET_READY_EXTRA";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/field[@name='BROADCAST_SOCKET_OPEN_ACTION']"
		[Register ("BROADCAST_SOCKET_OPEN_ACTION")]
		public const string BroadcastSocketOpenAction = (string) "BROADCAST_SOCKET_OPEN_ACTION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/field[@name='BROADCAST_START_CONNECTING']"
		[Register ("BROADCAST_START_CONNECTING")]
		public const string BroadcastStartConnecting = (string) "BROADCAST_START_CONNECTING";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/field[@name='LOGIN_FLOW_TAG']"
		[Register ("LOGIN_FLOW_TAG")]
		public const string LoginFlowTag = (string) "_LoginFlow";

		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/field[@name='TAG']"
		[Register ("TAG")]
		protected static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr mBrandId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/field[@name='mBrandId']"
		[Register ("mBrandId")]
		protected string MBrandId {
			get {
				if (mBrandId_jfieldId == IntPtr.Zero)
					mBrandId_jfieldId = JNIEnv.GetFieldID (class_ref, "mBrandId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mBrandId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mBrandId_jfieldId == IntPtr.Zero)
					mBrandId_jfieldId = JNIEnv.GetFieldID (class_ref, "mBrandId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mBrandId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mClockDiff_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/field[@name='mClockDiff']"
		[Register ("mClockDiff")]
		protected long MClockDiff {
			get {
				if (mClockDiff_jfieldId == IntPtr.Zero)
					mClockDiff_jfieldId = JNIEnv.GetFieldID (class_ref, "mClockDiff", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, mClockDiff_jfieldId);
			}
			set {
				if (mClockDiff_jfieldId == IntPtr.Zero)
					mClockDiff_jfieldId = JNIEnv.GetFieldID (class_ref, "mClockDiff", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mClockDiff_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mController_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/field[@name='mController']"
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

		static IntPtr mLastUpdateTime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/field[@name='mLastUpdateTime']"
		[Register ("mLastUpdateTime")]
		protected long MLastUpdateTime {
			get {
				if (mLastUpdateTime_jfieldId == IntPtr.Zero)
					mLastUpdateTime_jfieldId = JNIEnv.GetFieldID (class_ref, "mLastUpdateTime", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, mLastUpdateTime_jfieldId);
			}
			set {
				if (mLastUpdateTime_jfieldId == IntPtr.Zero)
					mLastUpdateTime_jfieldId = JNIEnv.GetFieldID (class_ref, "mLastUpdateTime", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mLastUpdateTime_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mPreferenceManager_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/field[@name='mPreferenceManager']"
		[Register ("mPreferenceManager")]
		protected global::Com.Liveperson.Infra.Managers.PreferenceManager MPreferenceManager {
			get {
				if (mPreferenceManager_jfieldId == IntPtr.Zero)
					mPreferenceManager_jfieldId = JNIEnv.GetFieldID (class_ref, "mPreferenceManager", "Lcom/liveperson/infra/managers/PreferenceManager;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mPreferenceManager_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Managers.PreferenceManager> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPreferenceManager_jfieldId == IntPtr.Zero)
					mPreferenceManager_jfieldId = JNIEnv.GetFieldID (class_ref, "mPreferenceManager", "Lcom/liveperson/infra/managers/PreferenceManager;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mPreferenceManager_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mSocketState_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/field[@name='mSocketState']"
		[Register ("mSocketState")]
		protected global::Com.Liveperson.Messaging.Model.AmsConnection.AmsSocketState MSocketState {
			get {
				if (mSocketState_jfieldId == IntPtr.Zero)
					mSocketState_jfieldId = JNIEnv.GetFieldID (class_ref, "mSocketState", "Lcom/liveperson/messaging/model/AmsConnection$AmsSocketState;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mSocketState_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection.AmsSocketState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSocketState_jfieldId == IntPtr.Zero)
					mSocketState_jfieldId = JNIEnv.GetFieldID (class_ref, "mSocketState", "Lcom/liveperson/messaging/model/AmsConnection$AmsSocketState;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSocketState_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mStateMachine_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/field[@name='mStateMachine']"
		[Register ("mStateMachine")]
		protected global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine MStateMachine {
			get {
				if (mStateMachine_jfieldId == IntPtr.Zero)
					mStateMachine_jfieldId = JNIEnv.GetFieldID (class_ref, "mStateMachine", "Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mStateMachine_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.ConnectionStateMachine> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mStateMachine_jfieldId == IntPtr.Zero)
					mStateMachine_jfieldId = JNIEnv.GetFieldID (class_ref, "mStateMachine", "Lcom/liveperson/messaging/controller/connection/ConnectionStateMachine;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mStateMachine_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection.AmsSocketState']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/model/AmsConnection$AmsSocketState", DoNotGenerateAcw=true)]
		public partial class AmsSocketState : global::Java.Lang.Object, global::Com.Liveperson.Infra.Network.Socket.State.ISocketStateListener {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/model/AmsConnection$AmsSocketState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AmsSocketState); }
			}

			protected AmsSocketState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_messaging_model_AmsConnection_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection.AmsSocketState']/constructor[@name='AmsConnection.AmsSocketState' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.AmsConnection']]"
			[Register (".ctor", "(Lcom/liveperson/messaging/model/AmsConnection;)V", "")]
			public unsafe AmsSocketState (global::Com.Liveperson.Messaging.Model.AmsConnection __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (AmsSocketState)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_messaging_model_AmsConnection_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_messaging_model_AmsConnection_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/model/AmsConnection;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_model_AmsConnection_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_model_AmsConnection_, __args);
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
				global::Com.Liveperson.Messaging.Model.AmsConnection.AmsSocketState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection.AmsSocketState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDisconnected (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onDisconnected_Ljava_lang_String_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection.AmsSocketState']/method[@name='onDisconnected' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
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
				global::Com.Liveperson.Messaging.Model.AmsConnection.AmsSocketState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection.AmsSocketState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Liveperson.Infra.Network.Socket.SocketState p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketState> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnStateChanged (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onStateChanged_Lcom_liveperson_infra_network_socket_SocketState_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection.AmsSocketState']/method[@name='onStateChanged' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.network.socket.SocketState']]"
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

			static Delegate cb_setCallback_Lcom_liveperson_messaging_commands_tasks_BaseAmsAccountConnectionCallback_;
#pragma warning disable 0169
			static Delegate GetSetCallback_Lcom_liveperson_messaging_commands_tasks_BaseAmsAccountConnectionCallback_Handler ()
			{
				if (cb_setCallback_Lcom_liveperson_messaging_commands_tasks_BaseAmsAccountConnectionCallback_ == null)
					cb_setCallback_Lcom_liveperson_messaging_commands_tasks_BaseAmsAccountConnectionCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallback_Lcom_liveperson_messaging_commands_tasks_BaseAmsAccountConnectionCallback_);
				return cb_setCallback_Lcom_liveperson_messaging_commands_tasks_BaseAmsAccountConnectionCallback_;
			}

			static void n_SetCallback_Lcom_liveperson_messaging_commands_tasks_BaseAmsAccountConnectionCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Messaging.Model.AmsConnection.AmsSocketState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection.AmsSocketState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsAccountConnectionCallback p0 = (global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsAccountConnectionCallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsAccountConnectionCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetCallback (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setCallback_Lcom_liveperson_messaging_commands_tasks_BaseAmsAccountConnectionCallback_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection.AmsSocketState']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.commands.tasks.BaseAmsAccountConnectionCallback']]"
			[Register ("setCallback", "(Lcom/liveperson/messaging/commands/tasks/BaseAmsAccountConnectionCallback;)V", "GetSetCallback_Lcom_liveperson_messaging_commands_tasks_BaseAmsAccountConnectionCallback_Handler")]
			public virtual unsafe void SetCallback (global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsAccountConnectionCallback p0)
			{
				if (id_setCallback_Lcom_liveperson_messaging_commands_tasks_BaseAmsAccountConnectionCallback_ == IntPtr.Zero)
					id_setCallback_Lcom_liveperson_messaging_commands_tasks_BaseAmsAccountConnectionCallback_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lcom/liveperson/messaging/commands/tasks/BaseAmsAccountConnectionCallback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCallback_Lcom_liveperson_messaging_commands_tasks_BaseAmsAccountConnectionCallback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallback", "(Lcom/liveperson/messaging/commands/tasks/BaseAmsAccountConnectionCallback;)V"), __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/model/AmsConnection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsConnection); }
		}

		protected AmsConnection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/constructor[@name='AmsConnection' and count(parameter)=2 and parameter[1][@type='com.liveperson.messaging.Messaging'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;)V", "")]
		public unsafe AmsConnection (global::Com.Liveperson.Messaging.Messaging p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (AmsConnection)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_isAgentDetailsUpdated;
#pragma warning disable 0169
		static Delegate GetIsAgentDetailsUpdatedHandler ()
		{
			if (cb_isAgentDetailsUpdated == null)
				cb_isAgentDetailsUpdated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAgentDetailsUpdated);
			return cb_isAgentDetailsUpdated;
		}

		static bool n_IsAgentDetailsUpdated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AgentDetailsUpdated;
		}
#pragma warning restore 0169

		static Delegate cb_setAgentDetailsUpdated_Z;
#pragma warning disable 0169
		static Delegate GetSetAgentDetailsUpdated_ZHandler ()
		{
			if (cb_setAgentDetailsUpdated_Z == null)
				cb_setAgentDetailsUpdated_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAgentDetailsUpdated_Z);
			return cb_setAgentDetailsUpdated_Z;
		}

		static void n_SetAgentDetailsUpdated_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AgentDetailsUpdated = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isAgentDetailsUpdated;
		static IntPtr id_setAgentDetailsUpdated_Z;
		public virtual unsafe bool AgentDetailsUpdated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='isAgentDetailsUpdated' and count(parameter)=0]"
			[Register ("isAgentDetailsUpdated", "()Z", "GetIsAgentDetailsUpdatedHandler")]
			get {
				if (id_isAgentDetailsUpdated == IntPtr.Zero)
					id_isAgentDetailsUpdated = JNIEnv.GetMethodID (class_ref, "isAgentDetailsUpdated", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAgentDetailsUpdated);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAgentDetailsUpdated", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='setAgentDetailsUpdated' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAgentDetailsUpdated", "(Z)V", "GetSetAgentDetailsUpdated_ZHandler")]
			set {
				if (id_setAgentDetailsUpdated_Z == IntPtr.Zero)
					id_setAgentDetailsUpdated_Z = JNIEnv.GetMethodID (class_ref, "setAgentDetailsUpdated", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAgentDetailsUpdated_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAgentDetailsUpdated", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getClockDiff;
#pragma warning disable 0169
		static Delegate GetGetClockDiffHandler ()
		{
			if (cb_getClockDiff == null)
				cb_getClockDiff = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetClockDiff);
			return cb_getClockDiff;
		}

		static long n_GetClockDiff (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ClockDiff;
		}
#pragma warning restore 0169

		static IntPtr id_getClockDiff;
		public virtual unsafe long ClockDiff {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='getClockDiff' and count(parameter)=0]"
			[Register ("getClockDiff", "()J", "GetGetClockDiffHandler")]
			get {
				if (id_getClockDiff == IntPtr.Zero)
					id_getClockDiff = JNIEnv.GetMethodID (class_ref, "getClockDiff", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getClockDiff);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClockDiff", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_isFirstNotificationAfterSubscribe;
#pragma warning disable 0169
		static Delegate GetIsFirstNotificationAfterSubscribeHandler ()
		{
			if (cb_isFirstNotificationAfterSubscribe == null)
				cb_isFirstNotificationAfterSubscribe = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFirstNotificationAfterSubscribe);
			return cb_isFirstNotificationAfterSubscribe;
		}

		static bool n_IsFirstNotificationAfterSubscribe (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FirstNotificationAfterSubscribe;
		}
#pragma warning restore 0169

		static Delegate cb_setFirstNotificationAfterSubscribe_Z;
#pragma warning disable 0169
		static Delegate GetSetFirstNotificationAfterSubscribe_ZHandler ()
		{
			if (cb_setFirstNotificationAfterSubscribe_Z == null)
				cb_setFirstNotificationAfterSubscribe_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFirstNotificationAfterSubscribe_Z);
			return cb_setFirstNotificationAfterSubscribe_Z;
		}

		static void n_SetFirstNotificationAfterSubscribe_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FirstNotificationAfterSubscribe = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isFirstNotificationAfterSubscribe;
		static IntPtr id_setFirstNotificationAfterSubscribe_Z;
		public virtual unsafe bool FirstNotificationAfterSubscribe {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='isFirstNotificationAfterSubscribe' and count(parameter)=0]"
			[Register ("isFirstNotificationAfterSubscribe", "()Z", "GetIsFirstNotificationAfterSubscribeHandler")]
			get {
				if (id_isFirstNotificationAfterSubscribe == IntPtr.Zero)
					id_isFirstNotificationAfterSubscribe = JNIEnv.GetMethodID (class_ref, "isFirstNotificationAfterSubscribe", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFirstNotificationAfterSubscribe);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFirstNotificationAfterSubscribe", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='setFirstNotificationAfterSubscribe' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFirstNotificationAfterSubscribe", "(Z)V", "GetSetFirstNotificationAfterSubscribe_ZHandler")]
			set {
				if (id_setFirstNotificationAfterSubscribe_Z == IntPtr.Zero)
					id_setFirstNotificationAfterSubscribe_Z = JNIEnv.GetMethodID (class_ref, "setFirstNotificationAfterSubscribe", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFirstNotificationAfterSubscribe_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFirstNotificationAfterSubscribe", "(Z)V"), __args);
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
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnecting;
		}
#pragma warning restore 0169

		static IntPtr id_isConnecting;
		public virtual unsafe bool IsConnecting {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='isConnecting' and count(parameter)=0]"
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

		static Delegate cb_isLastUpdateTimeExists;
#pragma warning disable 0169
		static Delegate GetIsLastUpdateTimeExistsHandler ()
		{
			if (cb_isLastUpdateTimeExists == null)
				cb_isLastUpdateTimeExists = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLastUpdateTimeExists);
			return cb_isLastUpdateTimeExists;
		}

		static bool n_IsLastUpdateTimeExists (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLastUpdateTimeExists;
		}
#pragma warning restore 0169

		static IntPtr id_isLastUpdateTimeExists;
		public virtual unsafe bool IsLastUpdateTimeExists {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='isLastUpdateTimeExists' and count(parameter)=0]"
			[Register ("isLastUpdateTimeExists", "()Z", "GetIsLastUpdateTimeExistsHandler")]
			get {
				if (id_isLastUpdateTimeExists == IntPtr.Zero)
					id_isLastUpdateTimeExists = JNIEnv.GetMethodID (class_ref, "isLastUpdateTimeExists", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLastUpdateTimeExists);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLastUpdateTimeExists", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isSocketOpen;
#pragma warning disable 0169
		static Delegate GetIsSocketOpenHandler ()
		{
			if (cb_isSocketOpen == null)
				cb_isSocketOpen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSocketOpen);
			return cb_isSocketOpen;
		}

		static bool n_IsSocketOpen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSocketOpen;
		}
#pragma warning restore 0169

		static IntPtr id_isSocketOpen;
		public virtual unsafe bool IsSocketOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='isSocketOpen' and count(parameter)=0]"
			[Register ("isSocketOpen", "()Z", "GetIsSocketOpenHandler")]
			get {
				if (id_isSocketOpen == IntPtr.Zero)
					id_isSocketOpen = JNIEnv.GetMethodID (class_ref, "isSocketOpen", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSocketOpen);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSocketOpen", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isUpdated;
#pragma warning disable 0169
		static Delegate GetIsUpdatedHandler ()
		{
			if (cb_isUpdated == null)
				cb_isUpdated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUpdated);
			return cb_isUpdated;
		}

		static bool n_IsUpdated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUpdated;
		}
#pragma warning restore 0169

		static Delegate cb_setIsUpdated_Z;
#pragma warning disable 0169
		static Delegate GetSetIsUpdated_ZHandler ()
		{
			if (cb_setIsUpdated_Z == null)
				cb_setIsUpdated_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsUpdated_Z);
			return cb_setIsUpdated_Z;
		}

		static void n_SetIsUpdated_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsUpdated = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isUpdated;
		static IntPtr id_setIsUpdated_Z;
		public virtual unsafe bool IsUpdated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='isUpdated' and count(parameter)=0]"
			[Register ("isUpdated", "()Z", "GetIsUpdatedHandler")]
			get {
				if (id_isUpdated == IntPtr.Zero)
					id_isUpdated = JNIEnv.GetMethodID (class_ref, "isUpdated", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUpdated);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUpdated", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='setIsUpdated' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsUpdated", "(Z)V", "GetSetIsUpdated_ZHandler")]
			set {
				if (id_setIsUpdated_Z == IntPtr.Zero)
					id_setIsUpdated_Z = JNIEnv.GetMethodID (class_ref, "setIsUpdated", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIsUpdated_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsUpdated", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLastUpdateTime;
#pragma warning disable 0169
		static Delegate GetGetLastUpdateTimeHandler ()
		{
			if (cb_getLastUpdateTime == null)
				cb_getLastUpdateTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLastUpdateTime);
			return cb_getLastUpdateTime;
		}

		static long n_GetLastUpdateTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastUpdateTime;
		}
#pragma warning restore 0169

		static IntPtr id_getLastUpdateTime;
		public virtual unsafe long LastUpdateTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='getLastUpdateTime' and count(parameter)=0]"
			[Register ("getLastUpdateTime", "()J", "GetGetLastUpdateTimeHandler")]
			get {
				if (id_getLastUpdateTime == IntPtr.Zero)
					id_getLastUpdateTime = JNIEnv.GetMethodID (class_ref, "getLastUpdateTime", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLastUpdateTime);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastUpdateTime", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_isSocketReady;
#pragma warning disable 0169
		static Delegate GetIsSocketReadyHandler ()
		{
			if (cb_isSocketReady == null)
				cb_isSocketReady = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSocketReady);
			return cb_isSocketReady;
		}

		static bool n_IsSocketReady (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SocketReady;
		}
#pragma warning restore 0169

		static Delegate cb_setSocketReady_Z;
#pragma warning disable 0169
		static Delegate GetSetSocketReady_ZHandler ()
		{
			if (cb_setSocketReady_Z == null)
				cb_setSocketReady_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSocketReady_Z);
			return cb_setSocketReady_Z;
		}

		static void n_SetSocketReady_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SocketReady = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isSocketReady;
		static IntPtr id_setSocketReady_Z;
		public virtual unsafe bool SocketReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='isSocketReady' and count(parameter)=0]"
			[Register ("isSocketReady", "()Z", "GetIsSocketReadyHandler")]
			get {
				if (id_isSocketReady == IntPtr.Zero)
					id_isSocketReady = JNIEnv.GetMethodID (class_ref, "isSocketReady", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSocketReady);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSocketReady", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='setSocketReady' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSocketReady", "(Z)V", "GetSetSocketReady_ZHandler")]
			set {
				if (id_setSocketReady_Z == IntPtr.Zero)
					id_setSocketReady_Z = JNIEnv.GetMethodID (class_ref, "setSocketReady", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSocketReady_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSocketReady", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUpdates;
#pragma warning disable 0169
		static Delegate GetGetUpdatesHandler ()
		{
			if (cb_getUpdates == null)
				cb_getUpdates = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_GetUpdates);
			return cb_getUpdates;
		}

		static void n_GetUpdates (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GetUpdates ();
		}
#pragma warning restore 0169

		static IntPtr id_getUpdates;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='getUpdates' and count(parameter)=0]"
		[Register ("getUpdates", "()V", "GetGetUpdatesHandler")]
		protected virtual unsafe void GetUpdates ()
		{
			if (id_getUpdates == IntPtr.Zero)
				id_getUpdates = JNIEnv.GetMethodID (class_ref, "getUpdates", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getUpdates);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUpdates", "()V"));
			} finally {
			}
		}

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		public virtual unsafe void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "()V"));
			} finally {
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
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MoveToBackground (p0);
		}
#pragma warning restore 0169

		static IntPtr id_moveToBackground_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='moveToBackground' and count(parameter)=1 and parameter[1][@type='long']]"
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
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MoveToForeground ();
		}
#pragma warning restore 0169

		static IntPtr id_moveToForeground;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='moveToForeground' and count(parameter)=0]"
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
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NetworkAvailable ();
		}
#pragma warning restore 0169

		static IntPtr id_networkAvailable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='networkAvailable' and count(parameter)=0]"
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
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NetworkLost ();
		}
#pragma warning restore 0169

		static IntPtr id_networkLost;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='networkLost' and count(parameter)=0]"
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
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSocketProblem ();
		}
#pragma warning restore 0169

		static IntPtr id_onSocketProblem;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='onSocketProblem' and count(parameter)=0]"
		[Register ("onSocketProblem", "()V", "GetOnSocketProblemHandler")]
		protected virtual unsafe void OnSocketProblem ()
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

		static Delegate cb_registerSocket;
#pragma warning disable 0169
		static Delegate GetRegisterSocketHandler ()
		{
			if (cb_registerSocket == null)
				cb_registerSocket = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RegisterSocket);
			return cb_registerSocket;
		}

		static IntPtr n_RegisterSocket (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RegisterSocket ());
		}
#pragma warning restore 0169

		static IntPtr id_registerSocket;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='registerSocket' and count(parameter)=0]"
		[Register ("registerSocket", "()Lcom/liveperson/messaging/model/AmsConnection$AmsSocketState;", "GetRegisterSocketHandler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Model.AmsConnection.AmsSocketState RegisterSocket ()
		{
			if (id_registerSocket == IntPtr.Zero)
				id_registerSocket = JNIEnv.GetMethodID (class_ref, "registerSocket", "()Lcom/liveperson/messaging/model/AmsConnection$AmsSocketState;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection.AmsSocketState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_registerSocket), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection.AmsSocketState> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerSocket", "()Lcom/liveperson/messaging/model/AmsConnection$AmsSocketState;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ServiceStarted ();
		}
#pragma warning restore 0169

		static IntPtr id_serviceStarted;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='serviceStarted' and count(parameter)=0]"
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
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ServiceStopped ();
		}
#pragma warning restore 0169

		static IntPtr id_serviceStopped;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='serviceStopped' and count(parameter)=0]"
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

		static Delegate cb_setClock_J;
#pragma warning disable 0169
		static Delegate GetSetClock_JHandler ()
		{
			if (cb_setClock_J == null)
				cb_setClock_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetClock_J);
			return cb_setClock_J;
		}

		static void n_SetClock_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetClock (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setClock_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='setClock' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setClock", "(J)V", "GetSetClock_JHandler")]
		public virtual unsafe void SetClock (long p0)
		{
			if (id_setClock_J == IntPtr.Zero)
				id_setClock_J = JNIEnv.GetMethodID (class_ref, "setClock", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setClock_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClock", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setLastUpdateTime_J;
#pragma warning disable 0169
		static Delegate GetSetLastUpdateTime_JHandler ()
		{
			if (cb_setLastUpdateTime_J == null)
				cb_setLastUpdateTime_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_SetLastUpdateTime_J);
			return cb_setLastUpdateTime_J;
		}

		static bool n_SetLastUpdateTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetLastUpdateTime (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLastUpdateTime_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='setLastUpdateTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setLastUpdateTime", "(J)Z", "GetSetLastUpdateTime_JHandler")]
		public virtual unsafe bool SetLastUpdateTime (long p0)
		{
			if (id_setLastUpdateTime_J == IntPtr.Zero)
				id_setLastUpdateTime_J = JNIEnv.GetMethodID (class_ref, "setLastUpdateTime", "(J)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setLastUpdateTime_J, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastUpdateTime", "(J)Z"), __args);
			} finally {
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
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener p0 = (global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShutDown (p0);
		}
#pragma warning restore 0169

		static IntPtr id_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='shutDown' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.shutdown.ShutDownCompletionListener']]"
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
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartConnecting (p0);
		}
#pragma warning restore 0169

		static IntPtr id_startConnecting_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='startConnecting' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartDisconnecting ();
		}
#pragma warning restore 0169

		static IntPtr id_startDisconnecting;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='startDisconnecting' and count(parameter)=0]"
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

		static Delegate cb_unregisterSocketListener;
#pragma warning disable 0169
		static Delegate GetUnregisterSocketListenerHandler ()
		{
			if (cb_unregisterSocketListener == null)
				cb_unregisterSocketListener = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnregisterSocketListener);
			return cb_unregisterSocketListener;
		}

		static void n_UnregisterSocketListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsConnection __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterSocketListener ();
		}
#pragma warning restore 0169

		static IntPtr id_unregisterSocketListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnection']/method[@name='unregisterSocketListener' and count(parameter)=0]"
		[Register ("unregisterSocketListener", "()V", "GetUnregisterSocketListenerHandler")]
		public virtual unsafe void UnregisterSocketListener ()
		{
			if (id_unregisterSocketListener == IntPtr.Zero)
				id_unregisterSocketListener = JNIEnv.GetMethodID (class_ref, "unregisterSocketListener", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterSocketListener);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregisterSocketListener", "()V"));
			} finally {
			}
		}

	}
}
