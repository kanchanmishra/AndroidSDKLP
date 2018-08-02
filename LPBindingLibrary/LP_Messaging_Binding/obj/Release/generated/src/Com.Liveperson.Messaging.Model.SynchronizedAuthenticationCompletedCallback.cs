using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='SynchronizedAuthenticationCompletedCallback']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/model/SynchronizedAuthenticationCompletedCallback", DoNotGenerateAcw=true)]
	public partial class SynchronizedAuthenticationCompletedCallback : global::Java.Lang.Object, global::Com.Liveperson.Infra.ICommand {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/model/SynchronizedAuthenticationCompletedCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SynchronizedAuthenticationCompletedCallback); }
		}

		protected SynchronizedAuthenticationCompletedCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_controller_AccountsController_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='SynchronizedAuthenticationCompletedCallback']/constructor[@name='SynchronizedAuthenticationCompletedCallback' and count(parameter)=3 and parameter[1][@type='com.liveperson.messaging.controller.AccountsController'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.infra.ICallback&lt;java.lang.Void, java.lang.Exception&gt;']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/controller/AccountsController;Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V", "")]
		public unsafe SynchronizedAuthenticationCompletedCallback (global::Com.Liveperson.Messaging.Controller.AccountsController p0, string p1, global::Com.Liveperson.Infra.ICallback p2)
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
				if (((object) this).GetType () != typeof (SynchronizedAuthenticationCompletedCallback)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/controller/AccountsController;Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/controller/AccountsController;Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_controller_AccountsController_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_controller_AccountsController_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/controller/AccountsController;Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_controller_AccountsController_Ljava_lang_String_Lcom_liveperson_infra_ICallback_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_controller_AccountsController_Ljava_lang_String_Lcom_liveperson_infra_ICallback_, __args);
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
			global::Com.Liveperson.Messaging.Model.SynchronizedAuthenticationCompletedCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.SynchronizedAuthenticationCompletedCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		static IntPtr id_execute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='SynchronizedAuthenticationCompletedCallback']/method[@name='execute' and count(parameter)=0]"
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

		static Delegate cb_executeWithReturnValue;
#pragma warning disable 0169
		static Delegate GetExecuteWithReturnValueHandler ()
		{
			if (cb_executeWithReturnValue == null)
				cb_executeWithReturnValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ExecuteWithReturnValue);
			return cb_executeWithReturnValue;
		}

		static bool n_ExecuteWithReturnValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.SynchronizedAuthenticationCompletedCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.SynchronizedAuthenticationCompletedCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExecuteWithReturnValue ();
		}
#pragma warning restore 0169

		static IntPtr id_executeWithReturnValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='SynchronizedAuthenticationCompletedCallback']/method[@name='executeWithReturnValue' and count(parameter)=0]"
		[Register ("executeWithReturnValue", "()Z", "GetExecuteWithReturnValueHandler")]
		public virtual unsafe bool ExecuteWithReturnValue ()
		{
			if (id_executeWithReturnValue == IntPtr.Zero)
				id_executeWithReturnValue = JNIEnv.GetMethodID (class_ref, "executeWithReturnValue", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_executeWithReturnValue);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "executeWithReturnValue", "()Z"));
			} finally {
			}
		}

	}
}
