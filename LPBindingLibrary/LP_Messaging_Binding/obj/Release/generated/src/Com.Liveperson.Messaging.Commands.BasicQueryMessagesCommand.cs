using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Commands {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='BasicQueryMessagesCommand']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/commands/BasicQueryMessagesCommand", DoNotGenerateAcw=true)]
	public abstract partial class BasicQueryMessagesCommand : global::Java.Lang.Object, global::Com.Liveperson.Infra.ICommand {


		static IntPtr brandID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='BasicQueryMessagesCommand']/field[@name='brandID']"
		[Register ("brandID")]
		protected string BrandID {
			get {
				if (brandID_jfieldId == IntPtr.Zero)
					brandID_jfieldId = JNIEnv.GetFieldID (class_ref, "brandID", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, brandID_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (brandID_jfieldId == IntPtr.Zero)
					brandID_jfieldId = JNIEnv.GetFieldID (class_ref, "brandID", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, brandID_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr controller_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='BasicQueryMessagesCommand']/field[@name='controller']"
		[Register ("controller")]
		protected global::Com.Liveperson.Messaging.Messaging Controller {
			get {
				if (controller_jfieldId == IntPtr.Zero)
					controller_jfieldId = JNIEnv.GetFieldID (class_ref, "controller", "Lcom/liveperson/messaging/Messaging;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, controller_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (controller_jfieldId == IntPtr.Zero)
					controller_jfieldId = JNIEnv.GetFieldID (class_ref, "controller", "Lcom/liveperson/messaging/Messaging;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, controller_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr conversationServerId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='BasicQueryMessagesCommand']/field[@name='conversationServerId']"
		[Register ("conversationServerId")]
		protected string ConversationServerId {
			get {
				if (conversationServerId_jfieldId == IntPtr.Zero)
					conversationServerId_jfieldId = JNIEnv.GetFieldID (class_ref, "conversationServerId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, conversationServerId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (conversationServerId_jfieldId == IntPtr.Zero)
					conversationServerId_jfieldId = JNIEnv.GetFieldID (class_ref, "conversationServerId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, conversationServerId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mResponseCallBack_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='BasicQueryMessagesCommand']/field[@name='mResponseCallBack']"
		[Register ("mResponseCallBack")]
		protected global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsSocketConnectionCallback MResponseCallBack {
			get {
				if (mResponseCallBack_jfieldId == IntPtr.Zero)
					mResponseCallBack_jfieldId = JNIEnv.GetFieldID (class_ref, "mResponseCallBack", "Lcom/liveperson/messaging/commands/tasks/BaseAmsSocketConnectionCallback;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mResponseCallBack_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsSocketConnectionCallback> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mResponseCallBack_jfieldId == IntPtr.Zero)
					mResponseCallBack_jfieldId = JNIEnv.GetFieldID (class_ref, "mResponseCallBack", "Lcom/liveperson/messaging/commands/tasks/BaseAmsSocketConnectionCallback;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mResponseCallBack_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr targetId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='BasicQueryMessagesCommand']/field[@name='targetId']"
		[Register ("targetId")]
		protected string TargetId {
			get {
				if (targetId_jfieldId == IntPtr.Zero)
					targetId_jfieldId = JNIEnv.GetFieldID (class_ref, "targetId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, targetId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (targetId_jfieldId == IntPtr.Zero)
					targetId_jfieldId = JNIEnv.GetFieldID (class_ref, "targetId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, targetId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr updateUI_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='BasicQueryMessagesCommand']/field[@name='updateUI']"
		[Register ("updateUI")]
		protected bool UpdateUI {
			get {
				if (updateUI_jfieldId == IntPtr.Zero)
					updateUI_jfieldId = JNIEnv.GetFieldID (class_ref, "updateUI", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, updateUI_jfieldId);
			}
			set {
				if (updateUI_jfieldId == IntPtr.Zero)
					updateUI_jfieldId = JNIEnv.GetFieldID (class_ref, "updateUI", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, updateUI_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/commands/BasicQueryMessagesCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BasicQueryMessagesCommand); }
		}

		protected BasicQueryMessagesCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='BasicQueryMessagesCommand']/constructor[@name='BasicQueryMessagesCommand' and count(parameter)=5 and parameter[1][@type='com.liveperson.messaging.Messaging'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='boolean']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "")]
		public unsafe BasicQueryMessagesCommand (global::Com.Liveperson.Messaging.Messaging p0, string p1, string p2, string p3, bool p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				if (((object) this).GetType () != typeof (BasicQueryMessagesCommand)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_setResponseCallBack_Lcom_liveperson_messaging_commands_tasks_BaseAmsSocketConnectionCallback_;
#pragma warning disable 0169
		static Delegate GetSetResponseCallBack_Lcom_liveperson_messaging_commands_tasks_BaseAmsSocketConnectionCallback_Handler ()
		{
			if (cb_setResponseCallBack_Lcom_liveperson_messaging_commands_tasks_BaseAmsSocketConnectionCallback_ == null)
				cb_setResponseCallBack_Lcom_liveperson_messaging_commands_tasks_BaseAmsSocketConnectionCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResponseCallBack_Lcom_liveperson_messaging_commands_tasks_BaseAmsSocketConnectionCallback_);
			return cb_setResponseCallBack_Lcom_liveperson_messaging_commands_tasks_BaseAmsSocketConnectionCallback_;
		}

		static void n_SetResponseCallBack_Lcom_liveperson_messaging_commands_tasks_BaseAmsSocketConnectionCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Commands.BasicQueryMessagesCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.BasicQueryMessagesCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsSocketConnectionCallback p0 = (global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsSocketConnectionCallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsSocketConnectionCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetResponseCallBack (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setResponseCallBack_Lcom_liveperson_messaging_commands_tasks_BaseAmsSocketConnectionCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='BasicQueryMessagesCommand']/method[@name='setResponseCallBack' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.commands.tasks.BaseAmsSocketConnectionCallback']]"
		[Register ("setResponseCallBack", "(Lcom/liveperson/messaging/commands/tasks/BaseAmsSocketConnectionCallback;)V", "GetSetResponseCallBack_Lcom_liveperson_messaging_commands_tasks_BaseAmsSocketConnectionCallback_Handler")]
		public virtual unsafe void SetResponseCallBack (global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsSocketConnectionCallback p0)
		{
			if (id_setResponseCallBack_Lcom_liveperson_messaging_commands_tasks_BaseAmsSocketConnectionCallback_ == IntPtr.Zero)
				id_setResponseCallBack_Lcom_liveperson_messaging_commands_tasks_BaseAmsSocketConnectionCallback_ = JNIEnv.GetMethodID (class_ref, "setResponseCallBack", "(Lcom/liveperson/messaging/commands/tasks/BaseAmsSocketConnectionCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResponseCallBack_Lcom_liveperson_messaging_commands_tasks_BaseAmsSocketConnectionCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResponseCallBack", "(Lcom/liveperson/messaging/commands/tasks/BaseAmsSocketConnectionCallback;)V"), __args);
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
			global::Com.Liveperson.Messaging.Commands.BasicQueryMessagesCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.BasicQueryMessagesCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		[Register ("execute", "()V", "GetExecuteHandler")]
		public abstract void Execute ();

	}

	[global::Android.Runtime.Register ("com/liveperson/messaging/commands/BasicQueryMessagesCommand", DoNotGenerateAcw=true)]
	internal partial class BasicQueryMessagesCommandInvoker : BasicQueryMessagesCommand {

		public BasicQueryMessagesCommandInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BasicQueryMessagesCommandInvoker); }
		}

		static IntPtr id_execute;
		[Register ("execute", "()V", "GetExecuteHandler")]
		public override unsafe void Execute ()
		{
			if (id_execute == IntPtr.Zero)
				id_execute = JNIEnv.GetMethodID (class_ref, "execute", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_execute);
			} finally {
			}
		}

	}

}
