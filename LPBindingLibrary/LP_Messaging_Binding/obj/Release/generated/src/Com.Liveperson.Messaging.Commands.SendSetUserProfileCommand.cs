using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Commands {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendSetUserProfileCommand']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/commands/SendSetUserProfileCommand", DoNotGenerateAcw=true)]
	public partial class SendSetUserProfileCommand : global::Java.Lang.Object, global::Com.Liveperson.Infra.ICommand {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendSetUserProfileCommand']/field[@name='TAG']"
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
				return JNIEnv.FindClass ("com/liveperson/messaging/commands/SendSetUserProfileCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SendSetUserProfileCommand); }
		}

		protected SendSetUserProfileCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendSetUserProfileCommand']/constructor[@name='SendSetUserProfileCommand' and count(parameter)=3 and parameter[1][@type='com.liveperson.messaging.Messaging'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.messaging.model.UserProfileBundle']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Lcom/liveperson/messaging/model/UserProfileBundle;)V", "")]
		public unsafe SendSetUserProfileCommand (global::Com.Liveperson.Messaging.Messaging p0, string p1, global::Com.Liveperson.Messaging.Model.UserProfileBundle p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (SendSetUserProfileCommand)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Lcom/liveperson/messaging/model/UserProfileBundle;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Lcom/liveperson/messaging/model/UserProfileBundle;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Lcom/liveperson/messaging/model/UserProfileBundle;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Liveperson.Messaging.Commands.SendSetUserProfileCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.SendSetUserProfileCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		static IntPtr id_execute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendSetUserProfileCommand']/method[@name='execute' and count(parameter)=0]"
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
