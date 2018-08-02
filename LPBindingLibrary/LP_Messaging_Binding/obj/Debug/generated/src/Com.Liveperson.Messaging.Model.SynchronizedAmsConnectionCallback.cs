using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='SynchronizedAmsConnectionCallback']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/model/SynchronizedAmsConnectionCallback", DoNotGenerateAcw=true)]
	public partial class SynchronizedAmsConnectionCallback : global::Java.Lang.Object, global::Com.Liveperson.Infra.ICommand {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/model/SynchronizedAmsConnectionCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SynchronizedAmsConnectionCallback); }
		}

		protected SynchronizedAmsConnectionCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_controller_ConnectionsController_Ljava_lang_String_Ljava_lang_Runnable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='SynchronizedAmsConnectionCallback']/constructor[@name='SynchronizedAmsConnectionCallback' and count(parameter)=3 and parameter[1][@type='com.liveperson.messaging.controller.ConnectionsController'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Runnable']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/controller/ConnectionsController;Ljava/lang/String;Ljava/lang/Runnable;)V", "")]
		public unsafe SynchronizedAmsConnectionCallback (global::Com.Liveperson.Messaging.Controller.ConnectionsController p0, string p1, global::Java.Lang.IRunnable p2)
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
				if (((object) this).GetType () != typeof (SynchronizedAmsConnectionCallback)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/controller/ConnectionsController;Ljava/lang/String;Ljava/lang/Runnable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/controller/ConnectionsController;Ljava/lang/String;Ljava/lang/Runnable;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_controller_ConnectionsController_Ljava_lang_String_Ljava_lang_Runnable_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_controller_ConnectionsController_Ljava_lang_String_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/controller/ConnectionsController;Ljava/lang/String;Ljava/lang/Runnable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_controller_ConnectionsController_Ljava_lang_String_Ljava_lang_Runnable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_controller_ConnectionsController_Ljava_lang_String_Ljava_lang_Runnable_, __args);
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
			global::Com.Liveperson.Messaging.Model.SynchronizedAmsConnectionCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.SynchronizedAmsConnectionCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		static IntPtr id_execute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='SynchronizedAmsConnectionCallback']/method[@name='execute' and count(parameter)=0]"
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
