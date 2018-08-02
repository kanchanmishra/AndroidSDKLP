using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Monitoring.Cache {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.monitoring.cache']/interface[@name='ParamsCache']"
	[Register ("com/liveperson/monitoring/cache/ParamsCache", "", "Com.Liveperson.Monitoring.Cache.IParamsCacheInvoker")]
	public partial interface IParamsCache : IJavaObject {

		bool IsCsdsFilled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/interface[@name='ParamsCache']/method[@name='isCsdsFilled' and count(parameter)=0]"
			[Register ("isCsdsFilled", "()Z", "GetIsCsdsFilledHandler:Com.Liveperson.Monitoring.Cache.IParamsCacheInvoker, LP_Monitoring_Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/interface[@name='ParamsCache']/method[@name='getServiceDomain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getServiceDomain", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetServiceDomain_Ljava_lang_String_Handler:Com.Liveperson.Monitoring.Cache.IParamsCacheInvoker, LP_Monitoring_Binding")]
		string GetServiceDomain (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.cache']/interface[@name='ParamsCache']/method[@name='updateCsdsDomains' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("updateCsdsDomains", "(Ljava/util/HashMap;)Z", "GetUpdateCsdsDomains_Ljava_util_HashMap_Handler:Com.Liveperson.Monitoring.Cache.IParamsCacheInvoker, LP_Monitoring_Binding")]
		bool UpdateCsdsDomains (global::System.Collections.Generic.IDictionary<string, string> p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/monitoring/cache/ParamsCache", DoNotGenerateAcw=true)]
	internal class IParamsCacheInvoker : global::Java.Lang.Object, IParamsCache {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/monitoring/cache/ParamsCache");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IParamsCacheInvoker); }
		}

		IntPtr class_ref;

		public static IParamsCache GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IParamsCache> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.monitoring.cache.ParamsCache"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IParamsCacheInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isCsdsFilled;
#pragma warning disable 0169
		static Delegate GetIsCsdsFilledHandler ()
		{
			if (cb_isCsdsFilled == null)
				cb_isCsdsFilled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCsdsFilled);
			return cb_isCsdsFilled;
		}

		static bool n_IsCsdsFilled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Monitoring.Cache.IParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Cache.IParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCsdsFilled;
		}
#pragma warning restore 0169

		IntPtr id_isCsdsFilled;
		public unsafe bool IsCsdsFilled {
			get {
				if (id_isCsdsFilled == IntPtr.Zero)
					id_isCsdsFilled = JNIEnv.GetMethodID (class_ref, "isCsdsFilled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCsdsFilled);
			}
		}

		static Delegate cb_getServiceDomain_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetServiceDomain_Ljava_lang_String_Handler ()
		{
			if (cb_getServiceDomain_Ljava_lang_String_ == null)
				cb_getServiceDomain_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetServiceDomain_Ljava_lang_String_);
			return cb_getServiceDomain_Ljava_lang_String_;
		}

		static IntPtr n_GetServiceDomain_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Monitoring.Cache.IParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Cache.IParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetServiceDomain (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getServiceDomain_Ljava_lang_String_;
		public unsafe string GetServiceDomain (string p0)
		{
			if (id_getServiceDomain_Ljava_lang_String_ == IntPtr.Zero)
				id_getServiceDomain_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getServiceDomain", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServiceDomain_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_updateCsdsDomains_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetUpdateCsdsDomains_Ljava_util_HashMap_Handler ()
		{
			if (cb_updateCsdsDomains_Ljava_util_HashMap_ == null)
				cb_updateCsdsDomains_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_UpdateCsdsDomains_Ljava_util_HashMap_);
			return cb_updateCsdsDomains_Ljava_util_HashMap_;
		}

		static bool n_UpdateCsdsDomains_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Monitoring.Cache.IParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Cache.IParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateCsdsDomains (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_updateCsdsDomains_Ljava_util_HashMap_;
		public unsafe bool UpdateCsdsDomains (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_updateCsdsDomains_Ljava_util_HashMap_ == IntPtr.Zero)
				id_updateCsdsDomains_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "updateCsdsDomains", "(Ljava/util/HashMap;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_updateCsdsDomains_Ljava_util_HashMap_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
