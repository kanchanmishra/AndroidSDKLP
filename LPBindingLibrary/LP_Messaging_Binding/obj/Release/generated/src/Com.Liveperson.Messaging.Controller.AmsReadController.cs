using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Controller {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AmsReadController']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/controller/AmsReadController", DoNotGenerateAcw=true)]
	public partial class AmsReadController : global::Java.Lang.Object, global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDown {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AmsReadController']/field[@name='TAG']"
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
				return JNIEnv.FindClass ("com/liveperson/messaging/controller/AmsReadController", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsReadController); }
		}

		protected AmsReadController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_Messaging_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AmsReadController']/constructor[@name='AmsReadController' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.Messaging']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/Messaging;)V", "")]
		public unsafe AmsReadController (global::Com.Liveperson.Messaging.Messaging p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AmsReadController)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/Messaging;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/Messaging;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_Messaging_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_Messaging_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/Messaging;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_, __args);
			} finally {
			}
		}

		static Delegate cb_registerForegroundConnectionReceiver_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterForegroundConnectionReceiver_Ljava_lang_String_Handler ()
		{
			if (cb_registerForegroundConnectionReceiver_Ljava_lang_String_ == null)
				cb_registerForegroundConnectionReceiver_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterForegroundConnectionReceiver_Ljava_lang_String_);
			return cb_registerForegroundConnectionReceiver_Ljava_lang_String_;
		}

		static void n_RegisterForegroundConnectionReceiver_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.AmsReadController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.AmsReadController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterForegroundConnectionReceiver (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerForegroundConnectionReceiver_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AmsReadController']/method[@name='registerForegroundConnectionReceiver' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("registerForegroundConnectionReceiver", "(Ljava/lang/String;)V", "GetRegisterForegroundConnectionReceiver_Ljava_lang_String_Handler")]
		public virtual unsafe void RegisterForegroundConnectionReceiver (string p0)
		{
			if (id_registerForegroundConnectionReceiver_Ljava_lang_String_ == IntPtr.Zero)
				id_registerForegroundConnectionReceiver_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "registerForegroundConnectionReceiver", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerForegroundConnectionReceiver_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerForegroundConnectionReceiver", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_shutDown;
#pragma warning disable 0169
		static Delegate GetShutDownHandler ()
		{
			if (cb_shutDown == null)
				cb_shutDown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShutDown);
			return cb_shutDown;
		}

		static void n_ShutDown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.AmsReadController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.AmsReadController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShutDown ();
		}
#pragma warning restore 0169

		static IntPtr id_shutDown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='AmsReadController']/method[@name='shutDown' and count(parameter)=0]"
		[Register ("shutDown", "()V", "GetShutDownHandler")]
		public virtual unsafe void ShutDown ()
		{
			if (id_shutDown == IntPtr.Zero)
				id_shutDown = JNIEnv.GetMethodID (class_ref, "shutDown", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutDown);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shutDown", "()V"));
			} finally {
			}
		}

	}
}
