using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Log.Logreporter.Loggos {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='Loggos']"
	[global::Android.Runtime.Register ("com/liveperson/infra/log/logreporter/loggos/Loggos", DoNotGenerateAcw=true)]
	public partial class Loggos : global::Java.Lang.Object, global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Logsender.ILogSenderCallback {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='Loggos']/field[@name='CERTIFICATE_ERROR_ACTION']"
		[Register ("CERTIFICATE_ERROR_ACTION")]
		public const string CertificateErrorAction = (string) "certificate_error_action";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='Loggos']/field[@name='PREFS_KEY_LOGGOS_DOMAIN']"
		[Register ("PREFS_KEY_LOGGOS_DOMAIN")]
		public const string PrefsKeyLoggosDomain = (string) "prefs_key_loggos_domain";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='Loggos']/field[@name='PREFS_KEY_LOGGOS_TARGETID']"
		[Register ("PREFS_KEY_LOGGOS_TARGETID")]
		public const string PrefsKeyLoggosTargetid = (string) "prefs_key_loggos_targetid";

		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='Loggos']/field[@name='TAG']"
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
				return JNIEnv.FindClass ("com/liveperson/infra/log/logreporter/loggos/Loggos", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Loggos); }
		}

		protected Loggos (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='Loggos']/constructor[@name='Loggos' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Loggos ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Loggos)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getDomain;
#pragma warning disable 0169
		static Delegate GetGetDomainHandler ()
		{
			if (cb_getDomain == null)
				cb_getDomain = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDomain);
			return cb_getDomain;
		}

		static IntPtr n_GetDomain (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Loggos __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Loggos> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Domain);
		}
#pragma warning restore 0169

		static Delegate cb_setDomain_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDomain_Ljava_lang_String_Handler ()
		{
			if (cb_setDomain_Ljava_lang_String_ == null)
				cb_setDomain_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDomain_Ljava_lang_String_);
			return cb_setDomain_Ljava_lang_String_;
		}

		static void n_SetDomain_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Loggos __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Loggos> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Domain = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDomain;
		static IntPtr id_setDomain_Ljava_lang_String_;
		public virtual unsafe string Domain {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='Loggos']/method[@name='getDomain' and count(parameter)=0]"
			[Register ("getDomain", "()Ljava/lang/String;", "GetGetDomainHandler")]
			get {
				if (id_getDomain == IntPtr.Zero)
					id_getDomain = JNIEnv.GetMethodID (class_ref, "getDomain", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDomain), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDomain", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='Loggos']/method[@name='setDomain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDomain", "(Ljava/lang/String;)V", "GetSetDomain_Ljava_lang_String_Handler")]
			set {
				if (id_setDomain_Ljava_lang_String_ == IntPtr.Zero)
					id_setDomain_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDomain", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDomain_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDomain", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isShouldSendError;
#pragma warning disable 0169
		static Delegate GetIsShouldSendErrorHandler ()
		{
			if (cb_isShouldSendError == null)
				cb_isShouldSendError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShouldSendError);
			return cb_isShouldSendError;
		}

		static bool n_IsShouldSendError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Loggos __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Loggos> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsShouldSendError;
		}
#pragma warning restore 0169

		static IntPtr id_isShouldSendError;
		public virtual unsafe bool IsShouldSendError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='Loggos']/method[@name='isShouldSendError' and count(parameter)=0]"
			[Register ("isShouldSendError", "()Z", "GetIsShouldSendErrorHandler")]
			get {
				if (id_isShouldSendError == IntPtr.Zero)
					id_isShouldSendError = JNIEnv.GetMethodID (class_ref, "isShouldSendError", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isShouldSendError);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isShouldSendError", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getTargetId;
#pragma warning disable 0169
		static Delegate GetGetTargetIdHandler ()
		{
			if (cb_getTargetId == null)
				cb_getTargetId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTargetId);
			return cb_getTargetId;
		}

		static IntPtr n_GetTargetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Loggos __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Loggos> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TargetId);
		}
#pragma warning restore 0169

		static Delegate cb_setTargetId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTargetId_Ljava_lang_String_Handler ()
		{
			if (cb_setTargetId_Ljava_lang_String_ == null)
				cb_setTargetId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTargetId_Ljava_lang_String_);
			return cb_setTargetId_Ljava_lang_String_;
		}

		static void n_SetTargetId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Loggos __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Loggos> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TargetId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTargetId;
		static IntPtr id_setTargetId_Ljava_lang_String_;
		public virtual unsafe string TargetId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='Loggos']/method[@name='getTargetId' and count(parameter)=0]"
			[Register ("getTargetId", "()Ljava/lang/String;", "GetGetTargetIdHandler")]
			get {
				if (id_getTargetId == IntPtr.Zero)
					id_getTargetId = JNIEnv.GetMethodID (class_ref, "getTargetId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTargetId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTargetId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='Loggos']/method[@name='setTargetId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTargetId", "(Ljava/lang/String;)V", "GetSetTargetId_Ljava_lang_String_Handler")]
			set {
				if (id_setTargetId_Ljava_lang_String_ == IntPtr.Zero)
					id_setTargetId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTargetId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTargetId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTargetId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_addMessage_Lcom_liveperson_infra_log_logreporter_loggos_LoggosMessage_;
#pragma warning disable 0169
		static Delegate GetAddMessage_Lcom_liveperson_infra_log_logreporter_loggos_LoggosMessage_Handler ()
		{
			if (cb_addMessage_Lcom_liveperson_infra_log_logreporter_loggos_LoggosMessage_ == null)
				cb_addMessage_Lcom_liveperson_infra_log_logreporter_loggos_LoggosMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddMessage_Lcom_liveperson_infra_log_logreporter_loggos_LoggosMessage_);
			return cb_addMessage_Lcom_liveperson_infra_log_logreporter_loggos_LoggosMessage_;
		}

		static void n_AddMessage_Lcom_liveperson_infra_log_logreporter_loggos_LoggosMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Loggos __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Loggos> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addMessage_Lcom_liveperson_infra_log_logreporter_loggos_LoggosMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='Loggos']/method[@name='addMessage' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.log.logreporter.loggos.LoggosMessage']]"
		[Register ("addMessage", "(Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;)V", "GetAddMessage_Lcom_liveperson_infra_log_logreporter_loggos_LoggosMessage_Handler")]
		public virtual unsafe void AddMessage (global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage p0)
		{
			if (id_addMessage_Lcom_liveperson_infra_log_logreporter_loggos_LoggosMessage_ == IntPtr.Zero)
				id_addMessage_Lcom_liveperson_infra_log_logreporter_loggos_LoggosMessage_ = JNIEnv.GetMethodID (class_ref, "addMessage", "(Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addMessage_Lcom_liveperson_infra_log_logreporter_loggos_LoggosMessage_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMessage", "(Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_init_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetInit_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Handler ()
		{
			if (cb_init_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ == null)
				cb_init_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Init_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_);
			return cb_init_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_;
		}

		static void n_Init_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Loggos __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Loggos> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_init_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='Loggos']/method[@name='init' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("init", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V", "GetInit_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Handler")]
		public virtual unsafe void Init (string p0, string p1, global::System.Collections.Generic.IList<string> p2)
		{
			if (id_init_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_init_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "init", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_onError_Ljava_util_List_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnError_Ljava_util_List_Ljava_lang_Exception_Handler ()
		{
			if (cb_onError_Ljava_util_List_Ljava_lang_Exception_ == null)
				cb_onError_Ljava_util_List_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_util_List_Ljava_lang_Exception_);
			return cb_onError_Ljava_util_List_Ljava_lang_Exception_;
		}

		static void n_OnError_Ljava_util_List_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Loggos __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Loggos> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onError_Ljava_util_List_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='Loggos']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.liveperson.infra.log.logreporter.loggos.LoggosMessage&gt;'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("onError", "(Ljava/util/List;Ljava/lang/Exception;)V", "GetOnError_Ljava_util_List_Ljava_lang_Exception_Handler")]
		public virtual unsafe void OnError (global::System.Collections.Generic.IList<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> p0, global::Java.Lang.Exception p1)
		{
			if (id_onError_Ljava_util_List_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onError_Ljava_util_List_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/util/List;Ljava/lang/Exception;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_util_List_Ljava_lang_Exception_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onError", "(Ljava/util/List;Ljava/lang/Exception;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onSuccess;
#pragma warning disable 0169
		static Delegate GetOnSuccessHandler ()
		{
			if (cb_onSuccess == null)
				cb_onSuccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSuccess);
			return cb_onSuccess;
		}

		static void n_OnSuccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Loggos __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Loggos> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess ();
		}
#pragma warning restore 0169

		static IntPtr id_onSuccess;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='Loggos']/method[@name='onSuccess' and count(parameter)=0]"
		[Register ("onSuccess", "()V", "GetOnSuccessHandler")]
		public virtual unsafe void OnSuccess ()
		{
			if (id_onSuccess == IntPtr.Zero)
				id_onSuccess = JNIEnv.GetMethodID (class_ref, "onSuccess", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSuccess", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendMessageImmediately_Lcom_liveperson_infra_log_logreporter_loggos_LoggosMessage_;
#pragma warning disable 0169
		static Delegate GetSendMessageImmediately_Lcom_liveperson_infra_log_logreporter_loggos_LoggosMessage_Handler ()
		{
			if (cb_sendMessageImmediately_Lcom_liveperson_infra_log_logreporter_loggos_LoggosMessage_ == null)
				cb_sendMessageImmediately_Lcom_liveperson_infra_log_logreporter_loggos_LoggosMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendMessageImmediately_Lcom_liveperson_infra_log_logreporter_loggos_LoggosMessage_);
			return cb_sendMessageImmediately_Lcom_liveperson_infra_log_logreporter_loggos_LoggosMessage_;
		}

		static void n_SendMessageImmediately_Lcom_liveperson_infra_log_logreporter_loggos_LoggosMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Loggos __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Loggos> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendMessageImmediately (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendMessageImmediately_Lcom_liveperson_infra_log_logreporter_loggos_LoggosMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='Loggos']/method[@name='sendMessageImmediately' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.log.logreporter.loggos.LoggosMessage']]"
		[Register ("sendMessageImmediately", "(Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;)V", "GetSendMessageImmediately_Lcom_liveperson_infra_log_logreporter_loggos_LoggosMessage_Handler")]
		public virtual unsafe void SendMessageImmediately (global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage p0)
		{
			if (id_sendMessageImmediately_Lcom_liveperson_infra_log_logreporter_loggos_LoggosMessage_ == IntPtr.Zero)
				id_sendMessageImmediately_Lcom_liveperson_infra_log_logreporter_loggos_LoggosMessage_ = JNIEnv.GetMethodID (class_ref, "sendMessageImmediately", "(Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessageImmediately_Lcom_liveperson_infra_log_logreporter_loggos_LoggosMessage_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendMessageImmediately", "(Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_shutdown;
#pragma warning disable 0169
		static Delegate GetShutdownHandler ()
		{
			if (cb_shutdown == null)
				cb_shutdown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Shutdown);
			return cb_shutdown;
		}

		static void n_Shutdown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Loggos __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Loggos> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shutdown ();
		}
#pragma warning restore 0169

		static IntPtr id_shutdown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='Loggos']/method[@name='shutdown' and count(parameter)=0]"
		[Register ("shutdown", "()V", "GetShutdownHandler")]
		public virtual unsafe void Shutdown ()
		{
			if (id_shutdown == IntPtr.Zero)
				id_shutdown = JNIEnv.GetMethodID (class_ref, "shutdown", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutdown);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shutdown", "()V"));
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Liveperson.Infra.Log.Logreporter.Loggos.Logsender.ILogSenderCallback
		void global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Logsender.ILogSenderCallback.OnError (global::System.Collections.Generic.IList<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> p0, global::Java.Lang.Object p1)
		{
			OnError (p0, global::Java.Interop.JavaObjectExtensions.JavaCast<global::Java.Lang.Exception>(p1));
		}

	}
}
