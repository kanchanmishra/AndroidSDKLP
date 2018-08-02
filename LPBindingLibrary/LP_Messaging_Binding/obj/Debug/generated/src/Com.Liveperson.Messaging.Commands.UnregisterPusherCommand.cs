using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Commands {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='UnregisterPusherCommand']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/commands/UnregisterPusherCommand", DoNotGenerateAcw=true)]
	public partial class UnregisterPusherCommand : global::Java.Lang.Object, global::Com.Liveperson.Infra.ICommand {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='UnregisterPusherCommand']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/commands/UnregisterPusherCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnregisterPusherCommand); }
		}

		protected UnregisterPusherCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_controller_AccountsController_Lcom_liveperson_messaging_model_AmsUsers_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='UnregisterPusherCommand']/constructor[@name='UnregisterPusherCommand' and count(parameter)=6 and parameter[1][@type='com.liveperson.messaging.controller.AccountsController'] and parameter[2][@type='com.liveperson.messaging.model.AmsUsers'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.liveperson.infra.ICallback&lt;java.lang.Void, java.lang.Exception&gt;'] and parameter[6][@type='boolean']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/controller/AccountsController;Lcom/liveperson/messaging/model/AmsUsers;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/ICallback;Z)V", "")]
		public unsafe UnregisterPusherCommand (global::Com.Liveperson.Messaging.Controller.AccountsController p0, global::Com.Liveperson.Messaging.Model.AmsUsers p1, string p2, string p3, global::Com.Liveperson.Infra.ICallback p4, bool p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				if (((object) this).GetType () != typeof (UnregisterPusherCommand)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/controller/AccountsController;Lcom/liveperson/messaging/model/AmsUsers;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/ICallback;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/controller/AccountsController;Lcom/liveperson/messaging/model/AmsUsers;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/ICallback;Z)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_controller_AccountsController_Lcom_liveperson_messaging_model_AmsUsers_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Z == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_controller_AccountsController_Lcom_liveperson_messaging_model_AmsUsers_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/controller/AccountsController;Lcom/liveperson/messaging/model/AmsUsers;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/ICallback;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_controller_AccountsController_Lcom_liveperson_messaging_model_AmsUsers_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_controller_AccountsController_Lcom_liveperson_messaging_model_AmsUsers_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
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
			global::Com.Liveperson.Messaging.Commands.UnregisterPusherCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.UnregisterPusherCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		static IntPtr id_execute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='UnregisterPusherCommand']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()V", "GetExecuteHandler")]
		public virtual unsafe void Execute ()
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
