using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ForegroundService']"
	[global::Android.Runtime.Register ("com/liveperson/infra/ForegroundService", DoNotGenerateAcw=true)]
	public partial class ForegroundService : global::Java.Lang.Object, global::Com.Liveperson.Infra.IForegroundServiceInterface, global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDown {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ForegroundService']/field[@name='SCREEN_FOREGROUND_ACTION']"
		[Register ("SCREEN_FOREGROUND_ACTION")]
		public const string ScreenForegroundAction = (string) "SCREEN_FOREGROUND_ACTION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ForegroundService']/field[@name='SCREEN_FOREGROUND_EXTRA_BRAND_ID']"
		[Register ("SCREEN_FOREGROUND_EXTRA_BRAND_ID")]
		public const string ScreenForegroundExtraBrandId = (string) "brand_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ForegroundService']/field[@name='SCREEN_FOREGROUND_EXTRA_IS_FOREGROUND']"
		[Register ("SCREEN_FOREGROUND_EXTRA_IS_FOREGROUND")]
		public const string ScreenForegroundExtraIsForeground = (string) "is_foreground";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ForegroundService']/field[@name='SCREEN_FOREGROUND_EXTRA_TARGET_ID']"
		[Register ("SCREEN_FOREGROUND_EXTRA_TARGET_ID")]
		public const string ScreenForegroundExtraTargetId = (string) "target_id";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/ForegroundService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ForegroundService); }
		}

		protected ForegroundService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getForegroundBrandId;
#pragma warning disable 0169
		static Delegate GetGetForegroundBrandIdHandler ()
		{
			if (cb_getForegroundBrandId == null)
				cb_getForegroundBrandId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetForegroundBrandId);
			return cb_getForegroundBrandId;
		}

		static IntPtr n_GetForegroundBrandId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.ForegroundService __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ForegroundService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ForegroundBrandId);
		}
#pragma warning restore 0169

		static IntPtr id_getForegroundBrandId;
		public virtual unsafe global::Java.Util.HashSet ForegroundBrandId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ForegroundService']/method[@name='getForegroundBrandId' and count(parameter)=0]"
			[Register ("getForegroundBrandId", "()Ljava/util/HashSet;", "GetGetForegroundBrandIdHandler")]
			get {
				if (id_getForegroundBrandId == IntPtr.Zero)
					id_getForegroundBrandId = JNIEnv.GetMethodID (class_ref, "getForegroundBrandId", "()Ljava/util/HashSet;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.HashSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getForegroundBrandId), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.HashSet> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getForegroundBrandId", "()Ljava/util/HashSet;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Liveperson.Infra.ForegroundService Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ForegroundService']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/liveperson/infra/ForegroundService;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/liveperson/infra/ForegroundService;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ForegroundService> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isBrandForeground;
#pragma warning disable 0169
		static Delegate GetIsBrandForegroundHandler ()
		{
			if (cb_isBrandForeground == null)
				cb_isBrandForeground = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBrandForeground);
			return cb_isBrandForeground;
		}

		static bool n_IsBrandForeground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.ForegroundService __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ForegroundService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBrandForeground;
		}
#pragma warning restore 0169

		static IntPtr id_isBrandForeground;
		public virtual unsafe bool IsBrandForeground {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ForegroundService']/method[@name='isBrandForeground' and count(parameter)=0]"
			[Register ("isBrandForeground", "()Z", "GetIsBrandForegroundHandler")]
			get {
				if (id_isBrandForeground == IntPtr.Zero)
					id_isBrandForeground = JNIEnv.GetMethodID (class_ref, "isBrandForeground", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBrandForeground);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBrandForeground", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isBrandForeground_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInvokeIsBrandForeground_Ljava_lang_String_Handler ()
		{
			if (cb_isBrandForeground_Ljava_lang_String_ == null)
				cb_isBrandForeground_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_InvokeIsBrandForeground_Ljava_lang_String_);
			return cb_isBrandForeground_Ljava_lang_String_;
		}

		static bool n_InvokeIsBrandForeground_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.ForegroundService __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ForegroundService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InvokeIsBrandForeground (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isBrandForeground_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ForegroundService']/method[@name='isBrandForeground' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isBrandForeground", "(Ljava/lang/String;)Z", "GetInvokeIsBrandForeground_Ljava_lang_String_Handler")]
		public virtual unsafe bool InvokeIsBrandForeground (string p0)
		{
			if (id_isBrandForeground_Ljava_lang_String_ == IntPtr.Zero)
				id_isBrandForeground_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isBrandForeground", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBrandForeground_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBrandForeground", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isTargetForeground_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsTargetForeground_Ljava_lang_String_Handler ()
		{
			if (cb_isTargetForeground_Ljava_lang_String_ == null)
				cb_isTargetForeground_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsTargetForeground_Ljava_lang_String_);
			return cb_isTargetForeground_Ljava_lang_String_;
		}

		static bool n_IsTargetForeground_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.ForegroundService __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ForegroundService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsTargetForeground (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isTargetForeground_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ForegroundService']/method[@name='isTargetForeground' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isTargetForeground", "(Ljava/lang/String;)Z", "GetIsTargetForeground_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsTargetForeground (string p0)
		{
			if (id_isTargetForeground_Ljava_lang_String_ == IntPtr.Zero)
				id_isTargetForeground_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isTargetForeground", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTargetForeground_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isTargetForeground", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_register_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegister_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_register_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_register_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Register_Ljava_lang_String_Ljava_lang_String_);
			return cb_register_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Register_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.ForegroundService __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ForegroundService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Register (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_register_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ForegroundService']/method[@name='register' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("register", "(Ljava/lang/String;Ljava/lang/String;)V", "GetRegister_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Register (string p0, string p1)
		{
			if (id_register_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_register_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "register", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "register", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_restart;
#pragma warning disable 0169
		static Delegate GetRestartHandler ()
		{
			if (cb_restart == null)
				cb_restart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Restart);
			return cb_restart;
		}

		static void n_Restart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.ForegroundService __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ForegroundService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Restart ();
		}
#pragma warning restore 0169

		static IntPtr id_restart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ForegroundService']/method[@name='restart' and count(parameter)=0]"
		[Register ("restart", "()V", "GetRestartHandler")]
		public virtual unsafe void Restart ()
		{
			if (id_restart == IntPtr.Zero)
				id_restart = JNIEnv.GetMethodID (class_ref, "restart", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_restart);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "restart", "()V"));
			} finally {
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
			global::Com.Liveperson.Infra.ForegroundService __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ForegroundService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShutDown ();
		}
#pragma warning restore 0169

		static IntPtr id_shutDown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ForegroundService']/method[@name='shutDown' and count(parameter)=0]"
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

		static Delegate cb_unregisterAll;
#pragma warning disable 0169
		static Delegate GetUnregisterAllHandler ()
		{
			if (cb_unregisterAll == null)
				cb_unregisterAll = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnregisterAll);
			return cb_unregisterAll;
		}

		static void n_UnregisterAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.ForegroundService __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ForegroundService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterAll ();
		}
#pragma warning restore 0169

		static IntPtr id_unregisterAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ForegroundService']/method[@name='unregisterAll' and count(parameter)=0]"
		[Register ("unregisterAll", "()V", "GetUnregisterAllHandler")]
		public virtual unsafe void UnregisterAll ()
		{
			if (id_unregisterAll == IntPtr.Zero)
				id_unregisterAll = JNIEnv.GetMethodID (class_ref, "unregisterAll", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterAll);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregisterAll", "()V"));
			} finally {
			}
		}

		static Delegate cb_unregisterBrand_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnregisterBrand_Ljava_lang_String_Handler ()
		{
			if (cb_unregisterBrand_Ljava_lang_String_ == null)
				cb_unregisterBrand_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterBrand_Ljava_lang_String_);
			return cb_unregisterBrand_Ljava_lang_String_;
		}

		static void n_UnregisterBrand_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.ForegroundService __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ForegroundService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterBrand (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unregisterBrand_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ForegroundService']/method[@name='unregisterBrand' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unregisterBrand", "(Ljava/lang/String;)V", "GetUnregisterBrand_Ljava_lang_String_Handler")]
		public virtual unsafe void UnregisterBrand (string p0)
		{
			if (id_unregisterBrand_Ljava_lang_String_ == IntPtr.Zero)
				id_unregisterBrand_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unregisterBrand", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterBrand_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregisterBrand", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_unregisterTarget_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnregisterTarget_Ljava_lang_String_Handler ()
		{
			if (cb_unregisterTarget_Ljava_lang_String_ == null)
				cb_unregisterTarget_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterTarget_Ljava_lang_String_);
			return cb_unregisterTarget_Ljava_lang_String_;
		}

		static void n_UnregisterTarget_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.ForegroundService __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ForegroundService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterTarget (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unregisterTarget_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ForegroundService']/method[@name='unregisterTarget' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unregisterTarget", "(Ljava/lang/String;)V", "GetUnregisterTarget_Ljava_lang_String_Handler")]
		public virtual unsafe void UnregisterTarget (string p0)
		{
			if (id_unregisterTarget_Ljava_lang_String_ == IntPtr.Zero)
				id_unregisterTarget_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unregisterTarget", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterTarget_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregisterTarget", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
