using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Commands {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='ChangeConversationTTRCommand']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/commands/ChangeConversationTTRCommand", DoNotGenerateAcw=true)]
	public partial class ChangeConversationTTRCommand : global::Java.Lang.Object, global::Com.Liveperson.Infra.ICommand {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/commands/ChangeConversationTTRCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChangeConversationTTRCommand); }
		}

		protected ChangeConversationTTRCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_model_AmsConversations_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='ChangeConversationTTRCommand']/constructor[@name='ChangeConversationTTRCommand' and count(parameter)=4 and parameter[1][@type='com.liveperson.messaging.model.AmsConversations'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.liveperson.api.response.types.TTRType']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/model/AmsConversations;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/types/TTRType;)V", "")]
		public unsafe ChangeConversationTTRCommand (global::Com.Liveperson.Messaging.Model.AmsConversations p0, string p1, string p2, global::Com.Liveperson.Api.Response.Types.TTRType p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (ChangeConversationTTRCommand)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/model/AmsConversations;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/types/TTRType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/model/AmsConversations;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/types/TTRType;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_model_AmsConversations_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_model_AmsConversations_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/model/AmsConversations;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/types/TTRType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_model_AmsConversations_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_model_AmsConversations_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_, __args);
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
			global::Com.Liveperson.Messaging.Commands.ChangeConversationTTRCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.ChangeConversationTTRCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		static IntPtr id_execute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='ChangeConversationTTRCommand']/method[@name='execute' and count(parameter)=0]"
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
