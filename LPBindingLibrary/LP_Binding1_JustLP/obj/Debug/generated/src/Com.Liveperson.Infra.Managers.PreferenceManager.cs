using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Managers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.managers']/class[@name='PreferenceManager']"
	[global::Android.Runtime.Register ("com/liveperson/infra/managers/PreferenceManager", DoNotGenerateAcw=true)]
	public partial class PreferenceManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.managers']/class[@name='PreferenceManager']/field[@name='APP_LEVEL_PREFERENCES']"
		[Register ("APP_LEVEL_PREFERENCES")]
		public const string AppLevelPreferences = (string) "appLevelPreferences";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.managers']/class[@name='PreferenceManager']/field[@name='CONFIGURATION_DATA_PUBLISH_DATE_PREFERENCE_KEY']"
		[Register ("CONFIGURATION_DATA_PUBLISH_DATE_PREFERENCE_KEY")]
		public const string ConfigurationDataPublishDatePreferenceKey = (string) "configuration_data_publish_date_preference_key";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.managers']/class[@name='PreferenceManager']/field[@name='KILL_SWITCH_PHOTO_SHARING_ENABLED_PREFERENCE_KEY']"
		[Register ("KILL_SWITCH_PHOTO_SHARING_ENABLED_PREFERENCE_KEY")]
		public const string KillSwitchPhotoSharingEnabledPreferenceKey = (string) "kill_switch_photo_sharing_enabled_preference_key";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.managers']/class[@name='PreferenceManager']/field[@name='SITE_SETTINGS_PHOTO_SHARING_ENABLED_PREFERENCE_KEY']"
		[Register ("SITE_SETTINGS_PHOTO_SHARING_ENABLED_PREFERENCE_KEY")]
		public const string SiteSettingsPhotoSharingEnabledPreferenceKey = (string) "site_settings_photo_sharing_enabled_preference_key";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.managers']/class[@name='PreferenceManager']/field[@name='SITE_SETTINGS_VOICE_SHARING_ENABLED_PREFERENCE_KEY']"
		[Register ("SITE_SETTINGS_VOICE_SHARING_ENABLED_PREFERENCE_KEY")]
		public const string SiteSettingsVoiceSharingEnabledPreferenceKey = (string) "site_settings_voice_sharing_enabled_preference_key";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/managers/PreferenceManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PreferenceManager); }
		}

		protected PreferenceManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Liveperson.Infra.Managers.PreferenceManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.managers']/class[@name='PreferenceManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/liveperson/infra/managers/PreferenceManager;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/liveperson/infra/managers/PreferenceManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Managers.PreferenceManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clearAll;
#pragma warning disable 0169
		static Delegate GetClearAllHandler ()
		{
			if (cb_clearAll == null)
				cb_clearAll = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ClearAll);
			return cb_clearAll;
		}

		static bool n_ClearAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Managers.PreferenceManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Managers.PreferenceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ClearAll ();
		}
#pragma warning restore 0169

		static IntPtr id_clearAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.managers']/class[@name='PreferenceManager']/method[@name='clearAll' and count(parameter)=0]"
		[Register ("clearAll", "()Z", "GetClearAllHandler")]
		public virtual unsafe bool ClearAll ()
		{
			if (id_clearAll == IntPtr.Zero)
				id_clearAll = JNIEnv.GetMethodID (class_ref, "clearAll", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_clearAll);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearAll", "()Z"));
			} finally {
			}
		}

		static Delegate cb_contains_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetContains_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_contains_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_contains_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Contains_Ljava_lang_String_Ljava_lang_String_);
			return cb_contains_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_Contains_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Managers.PreferenceManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Managers.PreferenceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_contains_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.managers']/class[@name='PreferenceManager']/method[@name='contains' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("contains", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetContains_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool Contains (string p0, string p1)
		{
			if (id_contains_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_contains_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "contains", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_contains_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "contains", "(Ljava/lang/String;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getBooleanValue_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGetBooleanValue_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_getBooleanValue_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_getBooleanValue_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, bool>) n_GetBooleanValue_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_getBooleanValue_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static bool n_GetBooleanValue_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Com.Liveperson.Infra.Managers.PreferenceManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Managers.PreferenceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetBooleanValue (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBooleanValue_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.managers']/class[@name='PreferenceManager']/method[@name='getBooleanValue' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("getBooleanValue", "(Ljava/lang/String;Ljava/lang/String;Z)Z", "GetGetBooleanValue_Ljava_lang_String_Ljava_lang_String_ZHandler")]
		public virtual unsafe bool GetBooleanValue (string p0, string p1, bool p2)
		{
			if (id_getBooleanValue_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_getBooleanValue_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "getBooleanValue", "(Ljava/lang/String;Ljava/lang/String;Z)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getBooleanValue_Ljava_lang_String_Ljava_lang_String_Z, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBooleanValue", "(Ljava/lang/String;Ljava/lang/String;Z)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getIntValue_Ljava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetIntValue_Ljava_lang_String_Ljava_lang_String_IHandler ()
		{
			if (cb_getIntValue_Ljava_lang_String_Ljava_lang_String_I == null)
				cb_getIntValue_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_GetIntValue_Ljava_lang_String_Ljava_lang_String_I);
			return cb_getIntValue_Ljava_lang_String_Ljava_lang_String_I;
		}

		static int n_GetIntValue_Ljava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Com.Liveperson.Infra.Managers.PreferenceManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Managers.PreferenceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetIntValue (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getIntValue_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.managers']/class[@name='PreferenceManager']/method[@name='getIntValue' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("getIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I", "GetGetIntValue_Ljava_lang_String_Ljava_lang_String_IHandler")]
		public virtual unsafe int GetIntValue (string p0, string p1, int p2)
		{
			if (id_getIntValue_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_getIntValue_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "getIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIntValue_Ljava_lang_String_Ljava_lang_String_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIntValue", "(Ljava/lang/String;Ljava/lang/String;I)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getLongValue_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGetLongValue_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_getLongValue_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_getLongValue_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, bool>) n_GetLongValue_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_getLongValue_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static bool n_GetLongValue_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Com.Liveperson.Infra.Managers.PreferenceManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Managers.PreferenceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetLongValue (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLongValue_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.managers']/class[@name='PreferenceManager']/method[@name='getLongValue' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("getLongValue", "(Ljava/lang/String;Ljava/lang/String;Z)Z", "GetGetLongValue_Ljava_lang_String_Ljava_lang_String_ZHandler")]
		public virtual unsafe bool GetLongValue (string p0, string p1, bool p2)
		{
			if (id_getLongValue_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_getLongValue_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "getLongValue", "(Ljava/lang/String;Ljava/lang/String;Z)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getLongValue_Ljava_lang_String_Ljava_lang_String_Z, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLongValue", "(Ljava/lang/String;Ljava/lang/String;Z)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getLongValue_Ljava_lang_String_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetGetLongValue_Ljava_lang_String_Ljava_lang_String_JHandler ()
		{
			if (cb_getLongValue_Ljava_lang_String_Ljava_lang_String_J == null)
				cb_getLongValue_Ljava_lang_String_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, long, long>) n_GetLongValue_Ljava_lang_String_Ljava_lang_String_J);
			return cb_getLongValue_Ljava_lang_String_Ljava_lang_String_J;
		}

		static long n_GetLongValue_Ljava_lang_String_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2)
		{
			global::Com.Liveperson.Infra.Managers.PreferenceManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Managers.PreferenceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetLongValue (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLongValue_Ljava_lang_String_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.managers']/class[@name='PreferenceManager']/method[@name='getLongValue' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("getLongValue", "(Ljava/lang/String;Ljava/lang/String;J)J", "GetGetLongValue_Ljava_lang_String_Ljava_lang_String_JHandler")]
		public virtual unsafe long GetLongValue (string p0, string p1, long p2)
		{
			if (id_getLongValue_Ljava_lang_String_Ljava_lang_String_J == IntPtr.Zero)
				id_getLongValue_Ljava_lang_String_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "getLongValue", "(Ljava/lang/String;Ljava/lang/String;J)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLongValue_Ljava_lang_String_Ljava_lang_String_J, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLongValue", "(Ljava/lang/String;Ljava/lang/String;J)J"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetGetStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_Handler ()
		{
			if (cb_getStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_ == null)
				cb_getStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_);
			return cb_getStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_;
		}

		static IntPtr n_GetStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Infra.Managers.PreferenceManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Managers.PreferenceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.GetStringSet (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.managers']/class[@name='PreferenceManager']/method[@name='getStringSet' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("getStringSet", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Set;)Ljava/util/Set;", "GetGetStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_Handler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<string> GetStringSet (string p0, string p1, global::System.Collections.Generic.ICollection<string> p2)
		{
			if (id_getStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_ == IntPtr.Zero)
				id_getStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "getStringSet", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Set;)Ljava/util/Set;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				global::System.Collections.Generic.ICollection<string> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStringSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStringSet", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Set;)Ljava/util/Set;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getStringValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetStringValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getStringValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getStringValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetStringValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getStringValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetStringValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Infra.Managers.PreferenceManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Managers.PreferenceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetStringValue (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getStringValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.managers']/class[@name='PreferenceManager']/method[@name='getStringValue' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getStringValue", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetStringValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string GetStringValue (string p0, string p1, string p2)
		{
			if (id_getStringValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getStringValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getStringValue", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStringValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStringValue", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_remove_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_String_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Remove_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Managers.PreferenceManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Managers.PreferenceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_remove_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.managers']/class[@name='PreferenceManager']/method[@name='remove' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;Ljava/lang/String;)V", "GetRemove_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Remove (string p0, string p1)
		{
			if (id_remove_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setBooleanValue_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSetBooleanValue_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_setBooleanValue_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_setBooleanValue_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_SetBooleanValue_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_setBooleanValue_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static void n_SetBooleanValue_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Com.Liveperson.Infra.Managers.PreferenceManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Managers.PreferenceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetBooleanValue (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setBooleanValue_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.managers']/class[@name='PreferenceManager']/method[@name='setBooleanValue' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("setBooleanValue", "(Ljava/lang/String;Ljava/lang/String;Z)V", "GetSetBooleanValue_Ljava_lang_String_Ljava_lang_String_ZHandler")]
		public virtual unsafe void SetBooleanValue (string p0, string p1, bool p2)
		{
			if (id_setBooleanValue_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_setBooleanValue_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "setBooleanValue", "(Ljava/lang/String;Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBooleanValue_Ljava_lang_String_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBooleanValue", "(Ljava/lang/String;Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setIntValue_Ljava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetIntValue_Ljava_lang_String_Ljava_lang_String_IHandler ()
		{
			if (cb_setIntValue_Ljava_lang_String_Ljava_lang_String_I == null)
				cb_setIntValue_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_SetIntValue_Ljava_lang_String_Ljava_lang_String_I);
			return cb_setIntValue_Ljava_lang_String_Ljava_lang_String_I;
		}

		static void n_SetIntValue_Ljava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Com.Liveperson.Infra.Managers.PreferenceManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Managers.PreferenceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetIntValue (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setIntValue_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.managers']/class[@name='PreferenceManager']/method[@name='setIntValue' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("setIntValue", "(Ljava/lang/String;Ljava/lang/String;I)V", "GetSetIntValue_Ljava_lang_String_Ljava_lang_String_IHandler")]
		public virtual unsafe void SetIntValue (string p0, string p1, int p2)
		{
			if (id_setIntValue_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_setIntValue_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setIntValue", "(Ljava/lang/String;Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIntValue_Ljava_lang_String_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIntValue", "(Ljava/lang/String;Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setLongValue_Ljava_lang_String_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetSetLongValue_Ljava_lang_String_Ljava_lang_String_JHandler ()
		{
			if (cb_setLongValue_Ljava_lang_String_Ljava_lang_String_J == null)
				cb_setLongValue_Ljava_lang_String_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long>) n_SetLongValue_Ljava_lang_String_Ljava_lang_String_J);
			return cb_setLongValue_Ljava_lang_String_Ljava_lang_String_J;
		}

		static void n_SetLongValue_Ljava_lang_String_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2)
		{
			global::Com.Liveperson.Infra.Managers.PreferenceManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Managers.PreferenceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetLongValue (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setLongValue_Ljava_lang_String_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.managers']/class[@name='PreferenceManager']/method[@name='setLongValue' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("setLongValue", "(Ljava/lang/String;Ljava/lang/String;J)V", "GetSetLongValue_Ljava_lang_String_Ljava_lang_String_JHandler")]
		public virtual unsafe void SetLongValue (string p0, string p1, long p2)
		{
			if (id_setLongValue_Ljava_lang_String_Ljava_lang_String_J == IntPtr.Zero)
				id_setLongValue_Ljava_lang_String_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "setLongValue", "(Ljava/lang/String;Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLongValue_Ljava_lang_String_Ljava_lang_String_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLongValue", "(Ljava/lang/String;Ljava/lang/String;J)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setStringValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStringValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setStringValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setStringValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetStringValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_setStringValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetStringValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Infra.Managers.PreferenceManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Managers.PreferenceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetStringValue (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setStringValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.managers']/class[@name='PreferenceManager']/method[@name='setStringValue' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("setStringValue", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSetStringValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetStringValue (string p0, string p1, string p2)
		{
			if (id_setStringValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setStringValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStringValue", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStringValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStringValue", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_setStringsSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetSetStringsSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_Handler ()
		{
			if (cb_setStringsSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_ == null)
				cb_setStringsSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetStringsSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_);
			return cb_setStringsSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_;
		}

		static void n_SetStringsSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Infra.Managers.PreferenceManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Managers.PreferenceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetStringsSet (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setStringsSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.managers']/class[@name='PreferenceManager']/method[@name='setStringsSet' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("setStringsSet", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Set;)V", "GetSetStringsSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_Handler")]
		public virtual unsafe void SetStringsSet (string p0, string p1, global::System.Collections.Generic.ICollection<string> p2)
		{
			if (id_setStringsSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_ == IntPtr.Zero)
				id_setStringsSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "setStringsSet", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Set;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStringsSet_Ljava_lang_String_Ljava_lang_String_Ljava_util_Set_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStringsSet", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Set;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
