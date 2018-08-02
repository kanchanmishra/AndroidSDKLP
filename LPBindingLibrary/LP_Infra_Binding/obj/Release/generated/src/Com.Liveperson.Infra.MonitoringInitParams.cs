using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra']/class[@name='MonitoringInitParams']"
	[global::Android.Runtime.Register ("com/liveperson/infra/MonitoringInitParams", DoNotGenerateAcw=true)]
	public partial class MonitoringInitParams : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/MonitoringInitParams", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MonitoringInitParams); }
		}

		protected MonitoringInitParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra']/class[@name='MonitoringInitParams']/constructor[@name='MonitoringInitParams' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe MonitoringInitParams (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (MonitoringInitParams)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAppInstallId;
#pragma warning disable 0169
		static Delegate GetGetAppInstallIdHandler ()
		{
			if (cb_getAppInstallId == null)
				cb_getAppInstallId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppInstallId);
			return cb_getAppInstallId;
		}

		static IntPtr n_GetAppInstallId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.MonitoringInitParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.MonitoringInitParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppInstallId);
		}
#pragma warning restore 0169

		static Delegate cb_setAppInstallId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppInstallId_Ljava_lang_String_Handler ()
		{
			if (cb_setAppInstallId_Ljava_lang_String_ == null)
				cb_setAppInstallId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppInstallId_Ljava_lang_String_);
			return cb_setAppInstallId_Ljava_lang_String_;
		}

		static void n_SetAppInstallId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.MonitoringInitParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.MonitoringInitParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppInstallId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAppInstallId;
		static IntPtr id_setAppInstallId_Ljava_lang_String_;
		public virtual unsafe string AppInstallId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='MonitoringInitParams']/method[@name='getAppInstallId' and count(parameter)=0]"
			[Register ("getAppInstallId", "()Ljava/lang/String;", "GetGetAppInstallIdHandler")]
			get {
				if (id_getAppInstallId == IntPtr.Zero)
					id_getAppInstallId = JNIEnv.GetMethodID (class_ref, "getAppInstallId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppInstallId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppInstallId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='MonitoringInitParams']/method[@name='setAppInstallId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppInstallId", "(Ljava/lang/String;)V", "GetSetAppInstallId_Ljava_lang_String_Handler")]
			set {
				if (id_setAppInstallId_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppInstallId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppInstallId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppInstallId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppInstallId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
