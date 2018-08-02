using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra']/interface[@name='ForegroundServiceInterface']"
	[Register ("com/liveperson/infra/ForegroundServiceInterface", "", "Com.Liveperson.Infra.IForegroundServiceInterfaceInvoker")]
	public partial interface IForegroundServiceInterface : IJavaObject {

		global::Java.Util.HashSet ForegroundBrandId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/interface[@name='ForegroundServiceInterface']/method[@name='getForegroundBrandId' and count(parameter)=0]"
			[Register ("getForegroundBrandId", "()Ljava/util/HashSet;", "GetGetForegroundBrandIdHandler:Com.Liveperson.Infra.IForegroundServiceInterfaceInvoker, LP_Android_aar_Binding")] get;
		}

		bool IsBrandForeground {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/interface[@name='ForegroundServiceInterface']/method[@name='isBrandForeground' and count(parameter)=0]"
			[Register ("isBrandForeground", "()Z", "GetIsBrandForegroundHandler:Com.Liveperson.Infra.IForegroundServiceInterfaceInvoker, LP_Android_aar_Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/interface[@name='ForegroundServiceInterface']/method[@name='isBrandForeground' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isBrandForeground", "(Ljava/lang/String;)Z", "GetInvokeIsBrandForeground_Ljava_lang_String_Handler:Com.Liveperson.Infra.IForegroundServiceInterfaceInvoker, LP_Android_aar_Binding")]
		bool InvokeIsBrandForeground (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/interface[@name='ForegroundServiceInterface']/method[@name='isTargetForeground' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isTargetForeground", "(Ljava/lang/String;)Z", "GetIsTargetForeground_Ljava_lang_String_Handler:Com.Liveperson.Infra.IForegroundServiceInterfaceInvoker, LP_Android_aar_Binding")]
		bool IsTargetForeground (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/interface[@name='ForegroundServiceInterface']/method[@name='register' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("register", "(Ljava/lang/String;Ljava/lang/String;)V", "GetRegister_Ljava_lang_String_Ljava_lang_String_Handler:Com.Liveperson.Infra.IForegroundServiceInterfaceInvoker, LP_Android_aar_Binding")]
		void Register (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/interface[@name='ForegroundServiceInterface']/method[@name='unregisterAll' and count(parameter)=0]"
		[Register ("unregisterAll", "()V", "GetUnregisterAllHandler:Com.Liveperson.Infra.IForegroundServiceInterfaceInvoker, LP_Android_aar_Binding")]
		void UnregisterAll ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/interface[@name='ForegroundServiceInterface']/method[@name='unregisterBrand' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unregisterBrand", "(Ljava/lang/String;)V", "GetUnregisterBrand_Ljava_lang_String_Handler:Com.Liveperson.Infra.IForegroundServiceInterfaceInvoker, LP_Android_aar_Binding")]
		void UnregisterBrand (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/interface[@name='ForegroundServiceInterface']/method[@name='unregisterTarget' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unregisterTarget", "(Ljava/lang/String;)V", "GetUnregisterTarget_Ljava_lang_String_Handler:Com.Liveperson.Infra.IForegroundServiceInterfaceInvoker, LP_Android_aar_Binding")]
		void UnregisterTarget (string p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/ForegroundServiceInterface", DoNotGenerateAcw=true)]
	internal class IForegroundServiceInterfaceInvoker : global::Java.Lang.Object, IForegroundServiceInterface {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/ForegroundServiceInterface");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IForegroundServiceInterfaceInvoker); }
		}

		IntPtr class_ref;

		public static IForegroundServiceInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IForegroundServiceInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.ForegroundServiceInterface"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IForegroundServiceInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

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
			global::Com.Liveperson.Infra.IForegroundServiceInterface __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.IForegroundServiceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ForegroundBrandId);
		}
#pragma warning restore 0169

		IntPtr id_getForegroundBrandId;
		public unsafe global::Java.Util.HashSet ForegroundBrandId {
			get {
				if (id_getForegroundBrandId == IntPtr.Zero)
					id_getForegroundBrandId = JNIEnv.GetMethodID (class_ref, "getForegroundBrandId", "()Ljava/util/HashSet;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.HashSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getForegroundBrandId), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Liveperson.Infra.IForegroundServiceInterface __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.IForegroundServiceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBrandForeground;
		}
#pragma warning restore 0169

		IntPtr id_isBrandForeground;
		public unsafe bool IsBrandForeground {
			get {
				if (id_isBrandForeground == IntPtr.Zero)
					id_isBrandForeground = JNIEnv.GetMethodID (class_ref, "isBrandForeground", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBrandForeground);
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
			global::Com.Liveperson.Infra.IForegroundServiceInterface __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.IForegroundServiceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InvokeIsBrandForeground (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isBrandForeground_Ljava_lang_String_;
		public unsafe bool InvokeIsBrandForeground (string p0)
		{
			if (id_isBrandForeground_Ljava_lang_String_ == IntPtr.Zero)
				id_isBrandForeground_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isBrandForeground", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBrandForeground_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
			global::Com.Liveperson.Infra.IForegroundServiceInterface __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.IForegroundServiceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsTargetForeground (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isTargetForeground_Ljava_lang_String_;
		public unsafe bool IsTargetForeground (string p0)
		{
			if (id_isTargetForeground_Ljava_lang_String_ == IntPtr.Zero)
				id_isTargetForeground_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isTargetForeground", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTargetForeground_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
			global::Com.Liveperson.Infra.IForegroundServiceInterface __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.IForegroundServiceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Register (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_register_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void Register (string p0, string p1)
		{
			if (id_register_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_register_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "register", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Liveperson.Infra.IForegroundServiceInterface __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.IForegroundServiceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterAll ();
		}
#pragma warning restore 0169

		IntPtr id_unregisterAll;
		public unsafe void UnregisterAll ()
		{
			if (id_unregisterAll == IntPtr.Zero)
				id_unregisterAll = JNIEnv.GetMethodID (class_ref, "unregisterAll", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterAll);
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
			global::Com.Liveperson.Infra.IForegroundServiceInterface __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.IForegroundServiceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterBrand (p0);
		}
#pragma warning restore 0169

		IntPtr id_unregisterBrand_Ljava_lang_String_;
		public unsafe void UnregisterBrand (string p0)
		{
			if (id_unregisterBrand_Ljava_lang_String_ == IntPtr.Zero)
				id_unregisterBrand_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unregisterBrand", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterBrand_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Liveperson.Infra.IForegroundServiceInterface __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.IForegroundServiceInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterTarget (p0);
		}
#pragma warning restore 0169

		IntPtr id_unregisterTarget_Ljava_lang_String_;
		public unsafe void UnregisterTarget (string p0)
		{
			if (id_unregisterTarget_Ljava_lang_String_ == IntPtr.Zero)
				id_unregisterTarget_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unregisterTarget", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterTarget_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
