using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Commands {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='ResolveConversationCommand']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/commands/ResolveConversationCommand", DoNotGenerateAcw=true)]
	public partial class ResolveConversationCommand : global::Java.Lang.Object, global::Com.Liveperson.Infra.ICommand {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/commands/ResolveConversationCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResolveConversationCommand); }
		}

		protected ResolveConversationCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_model_AmsConversations_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='ResolveConversationCommand']/constructor[@name='ResolveConversationCommand' and count(parameter)=3 and parameter[1][@type='com.liveperson.messaging.model.AmsConversations'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/model/AmsConversations;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe ResolveConversationCommand (global::Com.Liveperson.Messaging.Model.AmsConversations p0, string p1, string p2)
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
				if (((object) this).GetType () != typeof (ResolveConversationCommand)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/model/AmsConversations;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/model/AmsConversations;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_model_AmsConversations_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_model_AmsConversations_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/model/AmsConversations;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_model_AmsConversations_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_model_AmsConversations_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
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
			global::Com.Liveperson.Messaging.Commands.ResolveConversationCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.ResolveConversationCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		static IntPtr id_execute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='ResolveConversationCommand']/method[@name='execute' and count(parameter)=0]"
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

		static Delegate cb_setOfflineMode_Z;
#pragma warning disable 0169
		static Delegate GetSetOfflineMode_ZHandler ()
		{
			if (cb_setOfflineMode_Z == null)
				cb_setOfflineMode_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetOfflineMode_Z);
			return cb_setOfflineMode_Z;
		}

		static void n_SetOfflineMode_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Messaging.Commands.ResolveConversationCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.ResolveConversationCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOfflineMode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOfflineMode_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='ResolveConversationCommand']/method[@name='setOfflineMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setOfflineMode", "(Z)V", "GetSetOfflineMode_ZHandler")]
		public virtual unsafe void SetOfflineMode (bool p0)
		{
			if (id_setOfflineMode_Z == IntPtr.Zero)
				id_setOfflineMode_Z = JNIEnv.GetMethodID (class_ref, "setOfflineMode", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOfflineMode_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOfflineMode", "(Z)V"), __args);
			} finally {
			}
		}

	}
}
