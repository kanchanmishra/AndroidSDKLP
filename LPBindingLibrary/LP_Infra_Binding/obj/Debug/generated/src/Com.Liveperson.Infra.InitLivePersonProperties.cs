using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra']/class[@name='InitLivePersonProperties']"
	[global::Android.Runtime.Register ("com/liveperson/infra/InitLivePersonProperties", DoNotGenerateAcw=true)]
	public partial class InitLivePersonProperties : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/InitLivePersonProperties", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InitLivePersonProperties); }
		}

		protected InitLivePersonProperties (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra']/class[@name='InitLivePersonProperties']/constructor[@name='InitLivePersonProperties' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.infra.callbacks.InitLivePersonCallBack']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;)V", "")]
		public unsafe InitLivePersonProperties (string p0, string p1, global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (InitLivePersonProperties)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_MonitoringInitParams_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra']/class[@name='InitLivePersonProperties']/constructor[@name='InitLivePersonProperties' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.infra.MonitoringInitParams'] and parameter[4][@type='com.liveperson.infra.callbacks.InitLivePersonCallBack']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/MonitoringInitParams;Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;)V", "")]
		public unsafe InitLivePersonProperties (string p0, string p1, global::Com.Liveperson.Infra.MonitoringInitParams p2, global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (InitLivePersonProperties)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/MonitoringInitParams;Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/MonitoringInitParams;Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_MonitoringInitParams_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_MonitoringInitParams_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/MonitoringInitParams;Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_MonitoringInitParams_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_MonitoringInitParams_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getAppId;
#pragma warning disable 0169
		static Delegate GetGetAppIdHandler ()
		{
			if (cb_getAppId == null)
				cb_getAppId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppId);
			return cb_getAppId;
		}

		static IntPtr n_GetAppId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.InitLivePersonProperties __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.InitLivePersonProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppId);
		}
#pragma warning restore 0169

		static IntPtr id_getAppId;
		public virtual unsafe string AppId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='InitLivePersonProperties']/method[@name='getAppId' and count(parameter)=0]"
			[Register ("getAppId", "()Ljava/lang/String;", "GetGetAppIdHandler")]
			get {
				if (id_getAppId == IntPtr.Zero)
					id_getAppId = JNIEnv.GetMethodID (class_ref, "getAppId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBrandId;
#pragma warning disable 0169
		static Delegate GetGetBrandIdHandler ()
		{
			if (cb_getBrandId == null)
				cb_getBrandId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBrandId);
			return cb_getBrandId;
		}

		static IntPtr n_GetBrandId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.InitLivePersonProperties __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.InitLivePersonProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BrandId);
		}
#pragma warning restore 0169

		static IntPtr id_getBrandId;
		public virtual unsafe string BrandId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='InitLivePersonProperties']/method[@name='getBrandId' and count(parameter)=0]"
			[Register ("getBrandId", "()Ljava/lang/String;", "GetGetBrandIdHandler")]
			get {
				if (id_getBrandId == IntPtr.Zero)
					id_getBrandId = JNIEnv.GetMethodID (class_ref, "getBrandId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBrandId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBrandId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Liveperson.Infra.InitLivePersonProperties __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.InitLivePersonProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InitCallBack);
		}
#pragma warning restore 0169

		static Delegate cb_setInitCallBack_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_;
#pragma warning disable 0169
		static Delegate GetSetInitCallBack_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_Handler ()
		{
			if (cb_setInitCallBack_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_ == null)
				cb_setInitCallBack_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInitCallBack_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_);
			return cb_setInitCallBack_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_;
		}

		static void n_SetInitCallBack_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.InitLivePersonProperties __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.InitLivePersonProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack p0 = (global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InitCallBack = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getInitCallBack;
		static IntPtr id_setInitCallBack_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_;
		public virtual unsafe global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack InitCallBack {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='InitLivePersonProperties']/method[@name='getInitCallBack' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='InitLivePersonProperties']/method[@name='setInitCallBack' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.callbacks.InitLivePersonCallBack']]"
			[Register ("setInitCallBack", "(Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;)V", "GetSetInitCallBack_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_Handler")]
			set {
				if (id_setInitCallBack_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_ == IntPtr.Zero)
					id_setInitCallBack_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_ = JNIEnv.GetMethodID (class_ref, "setInitCallBack", "(Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInitCallBack_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInitCallBack", "(Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isMonitoringParamsValid;
#pragma warning disable 0169
		static Delegate GetIsMonitoringParamsValidHandler ()
		{
			if (cb_isMonitoringParamsValid == null)
				cb_isMonitoringParamsValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMonitoringParamsValid);
			return cb_isMonitoringParamsValid;
		}

		static bool n_IsMonitoringParamsValid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.InitLivePersonProperties __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.InitLivePersonProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMonitoringParamsValid;
		}
#pragma warning restore 0169

		static IntPtr id_isMonitoringParamsValid;
		public virtual unsafe bool IsMonitoringParamsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='InitLivePersonProperties']/method[@name='isMonitoringParamsValid' and count(parameter)=0]"
			[Register ("isMonitoringParamsValid", "()Z", "GetIsMonitoringParamsValidHandler")]
			get {
				if (id_isMonitoringParamsValid == IntPtr.Zero)
					id_isMonitoringParamsValid = JNIEnv.GetMethodID (class_ref, "isMonitoringParamsValid", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMonitoringParamsValid);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMonitoringParamsValid", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMonitoringInitParams;
#pragma warning disable 0169
		static Delegate GetGetMonitoringInitParamsHandler ()
		{
			if (cb_getMonitoringInitParams == null)
				cb_getMonitoringInitParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMonitoringInitParams);
			return cb_getMonitoringInitParams;
		}

		static IntPtr n_GetMonitoringInitParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.InitLivePersonProperties __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.InitLivePersonProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MonitoringInitParams);
		}
#pragma warning restore 0169

		static IntPtr id_getMonitoringInitParams;
		public virtual unsafe global::Com.Liveperson.Infra.MonitoringInitParams MonitoringInitParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='InitLivePersonProperties']/method[@name='getMonitoringInitParams' and count(parameter)=0]"
			[Register ("getMonitoringInitParams", "()Lcom/liveperson/infra/MonitoringInitParams;", "GetGetMonitoringInitParamsHandler")]
			get {
				if (id_getMonitoringInitParams == IntPtr.Zero)
					id_getMonitoringInitParams = JNIEnv.GetMethodID (class_ref, "getMonitoringInitParams", "()Lcom/liveperson/infra/MonitoringInitParams;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.MonitoringInitParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMonitoringInitParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.MonitoringInitParams> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMonitoringInitParams", "()Lcom/liveperson/infra/MonitoringInitParams;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isValid_Lcom_liveperson_infra_InitLivePersonProperties_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='InitLivePersonProperties']/method[@name='isValid' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.InitLivePersonProperties']]"
		[Register ("isValid", "(Lcom/liveperson/infra/InitLivePersonProperties;)Z", "")]
		public static unsafe bool IsValid (global::Com.Liveperson.Infra.InitLivePersonProperties p0)
		{
			if (id_isValid_Lcom_liveperson_infra_InitLivePersonProperties_ == IntPtr.Zero)
				id_isValid_Lcom_liveperson_infra_InitLivePersonProperties_ = JNIEnv.GetStaticMethodID (class_ref, "isValid", "(Lcom/liveperson/infra/InitLivePersonProperties;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isValid_Lcom_liveperson_infra_InitLivePersonProperties_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
