using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='MessagingUiInitData']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/MessagingUiInitData", DoNotGenerateAcw=true)]
	public partial class MessagingUiInitData : global::Com.Liveperson.Messaging.MessagingInitData {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/MessagingUiInitData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessagingUiInitData); }
		}

		protected MessagingUiInitData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_infra_InitLivePersonProperties_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='MessagingUiInitData']/constructor[@name='MessagingUiInitData' and count(parameter)=2 and parameter[1][@type='com.liveperson.infra.InitLivePersonProperties'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/liveperson/infra/InitLivePersonProperties;Ljava/lang/String;)V", "")]
		public unsafe MessagingUiInitData (global::Com.Liveperson.Infra.InitLivePersonProperties p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (MessagingUiInitData)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/infra/InitLivePersonProperties;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/infra/InitLivePersonProperties;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_infra_InitLivePersonProperties_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_infra_InitLivePersonProperties_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/InitLivePersonProperties;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_InitLivePersonProperties_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_InitLivePersonProperties_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='MessagingUiInitData']/constructor[@name='MessagingUiInitData' and count(parameter)=2 and parameter[1][@type='com.liveperson.infra.callbacks.InitLivePersonCallBack'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;Ljava/lang/String;)V", "")]
		public unsafe MessagingUiInitData (global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (MessagingUiInitData)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getInitCallBack;
#pragma warning disable 0169
		static Delegate GetGetInitCallBackHandler ()
		{
			if (cb_getInitCallBack == null)
				cb_getInitCallBack = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInitCallBack);
			return cb_getInitCallBack;
		}

		static IntPtr n_GetInitCallBack (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.MessagingUiInitData __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.MessagingUiInitData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InitCallBack);
		}
#pragma warning restore 0169

		static IntPtr id_getInitCallBack;
		public virtual unsafe global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack InitCallBack {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='MessagingUiInitData']/method[@name='getInitCallBack' and count(parameter)=0]"
			[Register ("getInitCallBack", "()Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;", "GetGetInitCallBackHandler")]
			get {
				if (id_getInitCallBack == IntPtr.Zero)
					id_getInitCallBack = JNIEnv.GetMethodID (class_ref, "getInitCallBack", "()Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInitCallBack), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInitCallBack", "()Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
