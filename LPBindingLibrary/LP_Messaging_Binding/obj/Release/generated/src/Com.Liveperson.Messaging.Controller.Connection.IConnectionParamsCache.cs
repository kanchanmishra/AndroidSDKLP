using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Controller.Connection {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='IConnectionParamsCache']"
	[Register ("com/liveperson/messaging/controller/connection/IConnectionParamsCache", "", "Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCacheInvoker")]
	public partial interface IConnectionParamsCache : IJavaObject {

		bool AutoMessagesFeatureEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='IConnectionParamsCache']/method[@name='isAutoMessagesFeatureEnabled' and count(parameter)=0]"
			[Register ("isAutoMessagesFeatureEnabled", "()Z", "GetIsAutoMessagesFeatureEnabledHandler:Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCacheInvoker, LP_Messaging_Binding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='IConnectionParamsCache']/method[@name='setAutoMessagesFeatureEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoMessagesFeatureEnabled", "(Z)V", "GetSetAutoMessagesFeatureEnabled_ZHandler:Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCacheInvoker, LP_Messaging_Binding")] set;
		}

		bool FullConnectionFlowRequired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='IConnectionParamsCache']/method[@name='isFullConnectionFlowRequired' and count(parameter)=0]"
			[Register ("isFullConnectionFlowRequired", "()Z", "GetIsFullConnectionFlowRequiredHandler:Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCacheInvoker, LP_Messaging_Binding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='IConnectionParamsCache']/method[@name='setFullConnectionFlowRequired' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFullConnectionFlowRequired", "(Z)V", "GetSetFullConnectionFlowRequired_ZHandler:Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCacheInvoker, LP_Messaging_Binding")] set;
		}

		bool IsCsdsFilled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='IConnectionParamsCache']/method[@name='isCsdsFilled' and count(parameter)=0]"
			[Register ("isCsdsFilled", "()Z", "GetIsCsdsFilledHandler:Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCacheInvoker, LP_Messaging_Binding")] get;
		}

		bool IsVersionsCompatible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='IConnectionParamsCache']/method[@name='isVersionsCompatible' and count(parameter)=0]"
			[Register ("isVersionsCompatible", "()Z", "GetIsVersionsCompatibleHandler:Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCacheInvoker, LP_Messaging_Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='IConnectionParamsCache']/method[@name='getServiceDomain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getServiceDomain", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetServiceDomain_Ljava_lang_String_Handler:Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCacheInvoker, LP_Messaging_Binding")]
		string GetServiceDomain (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='IConnectionParamsCache']/method[@name='updateAcCdnVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateAcCdnVersion", "(Ljava/lang/String;)Z", "GetUpdateAcCdnVersion_Ljava_lang_String_Handler:Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCacheInvoker, LP_Messaging_Binding")]
		bool UpdateAcCdnVersion (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='IConnectionParamsCache']/method[@name='updateCsdsDomains' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("updateCsdsDomains", "(Ljava/util/HashMap;)Z", "GetUpdateCsdsDomains_Ljava_util_HashMap_Handler:Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCacheInvoker, LP_Messaging_Binding")]
		bool UpdateCsdsDomains (global::System.Collections.Generic.IDictionary<string, string> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='IConnectionParamsCache']/method[@name='updateLeCdnVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateLeCdnVersion", "(Ljava/lang/String;)Z", "GetUpdateLeCdnVersion_Ljava_lang_String_Handler:Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCacheInvoker, LP_Messaging_Binding")]
		bool UpdateLeCdnVersion (string p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/IConnectionParamsCache", DoNotGenerateAcw=true)]
	internal class IConnectionParamsCacheInvoker : global::Java.Lang.Object, IConnectionParamsCache {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/messaging/controller/connection/IConnectionParamsCache");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IConnectionParamsCacheInvoker); }
		}

		IntPtr class_ref;

		public static IConnectionParamsCache GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnectionParamsCache> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.messaging.controller.connection.IConnectionParamsCache"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectionParamsCacheInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isAutoMessagesFeatureEnabled;
#pragma warning disable 0169
		static Delegate GetIsAutoMessagesFeatureEnabledHandler ()
		{
			if (cb_isAutoMessagesFeatureEnabled == null)
				cb_isAutoMessagesFeatureEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAutoMessagesFeatureEnabled);
			return cb_isAutoMessagesFeatureEnabled;
		}

		static bool n_IsAutoMessagesFeatureEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoMessagesFeatureEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setAutoMessagesFeatureEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetAutoMessagesFeatureEnabled_ZHandler ()
		{
			if (cb_setAutoMessagesFeatureEnabled_Z == null)
				cb_setAutoMessagesFeatureEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAutoMessagesFeatureEnabled_Z);
			return cb_setAutoMessagesFeatureEnabled_Z;
		}

		static void n_SetAutoMessagesFeatureEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AutoMessagesFeatureEnabled = p0;
		}
#pragma warning restore 0169

		IntPtr id_isAutoMessagesFeatureEnabled;
		IntPtr id_setAutoMessagesFeatureEnabled_Z;
		public unsafe bool AutoMessagesFeatureEnabled {
			get {
				if (id_isAutoMessagesFeatureEnabled == IntPtr.Zero)
					id_isAutoMessagesFeatureEnabled = JNIEnv.GetMethodID (class_ref, "isAutoMessagesFeatureEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAutoMessagesFeatureEnabled);
			}
			set {
				if (id_setAutoMessagesFeatureEnabled_Z == IntPtr.Zero)
					id_setAutoMessagesFeatureEnabled_Z = JNIEnv.GetMethodID (class_ref, "setAutoMessagesFeatureEnabled", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAutoMessagesFeatureEnabled_Z, __args);
			}
		}

		static Delegate cb_isFullConnectionFlowRequired;
#pragma warning disable 0169
		static Delegate GetIsFullConnectionFlowRequiredHandler ()
		{
			if (cb_isFullConnectionFlowRequired == null)
				cb_isFullConnectionFlowRequired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFullConnectionFlowRequired);
			return cb_isFullConnectionFlowRequired;
		}

		static bool n_IsFullConnectionFlowRequired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FullConnectionFlowRequired;
		}
#pragma warning restore 0169

		static Delegate cb_setFullConnectionFlowRequired_Z;
#pragma warning disable 0169
		static Delegate GetSetFullConnectionFlowRequired_ZHandler ()
		{
			if (cb_setFullConnectionFlowRequired_Z == null)
				cb_setFullConnectionFlowRequired_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFullConnectionFlowRequired_Z);
			return cb_setFullConnectionFlowRequired_Z;
		}

		static void n_SetFullConnectionFlowRequired_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FullConnectionFlowRequired = p0;
		}
#pragma warning restore 0169

		IntPtr id_isFullConnectionFlowRequired;
		IntPtr id_setFullConnectionFlowRequired_Z;
		public unsafe bool FullConnectionFlowRequired {
			get {
				if (id_isFullConnectionFlowRequired == IntPtr.Zero)
					id_isFullConnectionFlowRequired = JNIEnv.GetMethodID (class_ref, "isFullConnectionFlowRequired", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFullConnectionFlowRequired);
			}
			set {
				if (id_setFullConnectionFlowRequired_Z == IntPtr.Zero)
					id_setFullConnectionFlowRequired_Z = JNIEnv.GetMethodID (class_ref, "setFullConnectionFlowRequired", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFullConnectionFlowRequired_Z, __args);
			}
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
			global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_isVersionsCompatible;
#pragma warning disable 0169
		static Delegate GetIsVersionsCompatibleHandler ()
		{
			if (cb_isVersionsCompatible == null)
				cb_isVersionsCompatible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsVersionsCompatible);
			return cb_isVersionsCompatible;
		}

		static bool n_IsVersionsCompatible (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsVersionsCompatible;
		}
#pragma warning restore 0169

		IntPtr id_isVersionsCompatible;
		public unsafe bool IsVersionsCompatible {
			get {
				if (id_isVersionsCompatible == IntPtr.Zero)
					id_isVersionsCompatible = JNIEnv.GetMethodID (class_ref, "isVersionsCompatible", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isVersionsCompatible);
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
			global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_updateAcCdnVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateAcCdnVersion_Ljava_lang_String_Handler ()
		{
			if (cb_updateAcCdnVersion_Ljava_lang_String_ == null)
				cb_updateAcCdnVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_UpdateAcCdnVersion_Ljava_lang_String_);
			return cb_updateAcCdnVersion_Ljava_lang_String_;
		}

		static bool n_UpdateAcCdnVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateAcCdnVersion (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_updateAcCdnVersion_Ljava_lang_String_;
		public unsafe bool UpdateAcCdnVersion (string p0)
		{
			if (id_updateAcCdnVersion_Ljava_lang_String_ == IntPtr.Zero)
				id_updateAcCdnVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateAcCdnVersion", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_updateAcCdnVersion_Ljava_lang_String_, __args);
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
			global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_updateLeCdnVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateLeCdnVersion_Ljava_lang_String_Handler ()
		{
			if (cb_updateLeCdnVersion_Ljava_lang_String_ == null)
				cb_updateLeCdnVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_UpdateLeCdnVersion_Ljava_lang_String_);
			return cb_updateLeCdnVersion_Ljava_lang_String_;
		}

		static bool n_UpdateLeCdnVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IConnectionParamsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateLeCdnVersion (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_updateLeCdnVersion_Ljava_lang_String_;
		public unsafe bool UpdateLeCdnVersion (string p0)
		{
			if (id_updateLeCdnVersion_Ljava_lang_String_ == IntPtr.Zero)
				id_updateLeCdnVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateLeCdnVersion", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_updateLeCdnVersion_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
