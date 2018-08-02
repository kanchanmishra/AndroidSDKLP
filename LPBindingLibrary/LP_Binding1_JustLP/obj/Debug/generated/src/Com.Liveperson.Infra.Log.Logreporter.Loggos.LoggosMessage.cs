using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Log.Logreporter.Loggos {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='LoggosMessage']"
	[global::Android.Runtime.Register ("com/liveperson/infra/log/logreporter/loggos/LoggosMessage", DoNotGenerateAcw=true)]
	public partial class LoggosMessage : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='LoggosMessage']/field[@name='CONTEXT']"
		[Register ("CONTEXT")]
		protected const string Context = (string) "context";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='LoggosMessage']/field[@name='DATE_FORMAT']"
		[Register ("DATE_FORMAT")]
		protected const string DateFormat = (string) "yyyy-mm-dd HH:MM:SS,SSS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='LoggosMessage']/field[@name='LOG_LEVEL']"
		[Register ("LOG_LEVEL")]
		protected const string LogLevel = (string) "logLevel";

		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='LoggosMessage']/field[@name='TAG']"
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
				return JNIEnv.FindClass ("com/liveperson/infra/log/logreporter/loggos/LoggosMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LoggosMessage); }
		}

		protected LoggosMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='LoggosMessage']/constructor[@name='LoggosMessage' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe LoggosMessage (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (LoggosMessage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/json/JSONObject;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/json/JSONObject;)V", __args);
					return;
				}

				if (id_ctor_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_ctor_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/json/JSONObject;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_json_JSONObject_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_json_JSONObject_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='LoggosMessage']/constructor[@name='LoggosMessage' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe LoggosMessage (string p0, string p1, string p2, string p3, string p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				if (((object) this).GetType () != typeof (LoggosMessage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='LoggosMessage']/constructor[@name='LoggosMessage' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe LoggosMessage (string p0, string p1, string p2, string p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				if (((object) this).GetType () != typeof (LoggosMessage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_getAccountId;
#pragma warning disable 0169
		static Delegate GetGetAccountIdHandler ()
		{
			if (cb_getAccountId == null)
				cb_getAccountId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccountId);
			return cb_getAccountId;
		}

		static IntPtr n_GetAccountId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccountId);
		}
#pragma warning restore 0169

		static IntPtr id_getAccountId;
		public virtual unsafe string AccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='LoggosMessage']/method[@name='getAccountId' and count(parameter)=0]"
			[Register ("getAccountId", "()Ljava/lang/String;", "GetGetAccountIdHandler")]
			get {
				if (id_getAccountId == IntPtr.Zero)
					id_getAccountId = JNIEnv.GetMethodID (class_ref, "getAccountId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccountId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccountId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLevel;
#pragma warning disable 0169
		static Delegate GetGetLevelHandler ()
		{
			if (cb_getLevel == null)
				cb_getLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLevel);
			return cb_getLevel;
		}

		static IntPtr n_GetLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Level);
		}
#pragma warning restore 0169

		static IntPtr id_getLevel;
		public virtual unsafe string Level {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='LoggosMessage']/method[@name='getLevel' and count(parameter)=0]"
			[Register ("getLevel", "()Ljava/lang/String;", "GetGetLevelHandler")]
			get {
				if (id_getLevel == IntPtr.Zero)
					id_getLevel = JNIEnv.GetMethodID (class_ref, "getLevel", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLevel), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLevel", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLogContext;
#pragma warning disable 0169
		static Delegate GetGetLogContextHandler ()
		{
			if (cb_getLogContext == null)
				cb_getLogContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLogContext);
			return cb_getLogContext;
		}

		static IntPtr n_GetLogContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LogContext);
		}
#pragma warning restore 0169

		static IntPtr id_getLogContext;
		public virtual unsafe string LogContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='LoggosMessage']/method[@name='getLogContext' and count(parameter)=0]"
			[Register ("getLogContext", "()Ljava/lang/String;", "GetGetLogContextHandler")]
			get {
				if (id_getLogContext == IntPtr.Zero)
					id_getLogContext = JNIEnv.GetMethodID (class_ref, "getLogContext", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLogContext), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLogContext", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='LoggosMessage']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNamespace;
#pragma warning disable 0169
		static Delegate GetGetNamespaceHandler ()
		{
			if (cb_getNamespace == null)
				cb_getNamespace = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNamespace);
			return cb_getNamespace;
		}

		static IntPtr n_GetNamespace (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Namespace);
		}
#pragma warning restore 0169

		static IntPtr id_getNamespace;
		public virtual unsafe string Namespace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='LoggosMessage']/method[@name='getNamespace' and count(parameter)=0]"
			[Register ("getNamespace", "()Ljava/lang/String;", "GetGetNamespaceHandler")]
			get {
				if (id_getNamespace == IntPtr.Zero)
					id_getNamespace = JNIEnv.GetMethodID (class_ref, "getNamespace", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNamespace), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNamespace", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTime;
#pragma warning disable 0169
		static Delegate GetGetTimeHandler ()
		{
			if (cb_getTime == null)
				cb_getTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTime);
			return cb_getTime;
		}

		static IntPtr n_GetTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Time);
		}
#pragma warning restore 0169

		static IntPtr id_getTime;
		public virtual unsafe string Time {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='LoggosMessage']/method[@name='getTime' and count(parameter)=0]"
			[Register ("getTime", "()Ljava/lang/String;", "GetGetTimeHandler")]
			get {
				if (id_getTime == IntPtr.Zero)
					id_getTime = JNIEnv.GetMethodID (class_ref, "getTime", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTime), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTime", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		static IntPtr id_getUrl;
		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='LoggosMessage']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				if (id_getUrl == IntPtr.Zero)
					id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setAccountId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAccountId_Ljava_lang_String_Handler ()
		{
			if (cb_setAccountId_Ljava_lang_String_ == null)
				cb_setAccountId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAccountId_Ljava_lang_String_);
			return cb_setAccountId_Ljava_lang_String_;
		}

		static IntPtr n_SetAccountId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAccountId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setAccountId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='LoggosMessage']/method[@name='setAccountId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAccountId", "(Ljava/lang/String;)Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;", "GetSetAccountId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage SetAccountId (string p0)
		{
			if (id_setAccountId_Ljava_lang_String_ == IntPtr.Zero)
				id_setAccountId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAccountId", "(Ljava/lang/String;)Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAccountId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAccountId", "(Ljava/lang/String;)Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setLevel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLevel_Ljava_lang_String_Handler ()
		{
			if (cb_setLevel_Ljava_lang_String_ == null)
				cb_setLevel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLevel_Ljava_lang_String_);
			return cb_setLevel_Ljava_lang_String_;
		}

		static IntPtr n_SetLevel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetLevel (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setLevel_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='LoggosMessage']/method[@name='setLevel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setLevel", "(Ljava/lang/String;)Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;", "GetSetLevel_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage SetLevel (string p0)
		{
			if (id_setLevel_Ljava_lang_String_ == IntPtr.Zero)
				id_setLevel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLevel", "(Ljava/lang/String;)Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setLevel_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLevel", "(Ljava/lang/String;)Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setLogContext_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLogContext_Ljava_lang_String_Handler ()
		{
			if (cb_setLogContext_Ljava_lang_String_ == null)
				cb_setLogContext_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLogContext_Ljava_lang_String_);
			return cb_setLogContext_Ljava_lang_String_;
		}

		static IntPtr n_SetLogContext_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetLogContext (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setLogContext_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='LoggosMessage']/method[@name='setLogContext' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setLogContext", "(Ljava/lang/String;)Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;", "GetSetLogContext_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage SetLogContext (string p0)
		{
			if (id_setLogContext_Ljava_lang_String_ == IntPtr.Zero)
				id_setLogContext_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLogContext", "(Ljava/lang/String;)Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setLogContext_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLogContext", "(Ljava/lang/String;)Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setMessage_Ljava_lang_String_ == null)
				cb_setMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMessage_Ljava_lang_String_);
			return cb_setMessage_Ljava_lang_String_;
		}

		static IntPtr n_SetMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMessage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='LoggosMessage']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMessage", "(Ljava/lang/String;)Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;", "GetSetMessage_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage SetMessage (string p0)
		{
			if (id_setMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_setMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessage", "(Ljava/lang/String;)Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMessage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessage", "(Ljava/lang/String;)Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setNamespace_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNamespace_Ljava_lang_String_Handler ()
		{
			if (cb_setNamespace_Ljava_lang_String_ == null)
				cb_setNamespace_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetNamespace_Ljava_lang_String_);
			return cb_setNamespace_Ljava_lang_String_;
		}

		static IntPtr n_SetNamespace_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNamespace (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setNamespace_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='LoggosMessage']/method[@name='setNamespace' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setNamespace", "(Ljava/lang/String;)Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;", "GetSetNamespace_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage SetNamespace (string p0)
		{
			if (id_setNamespace_Ljava_lang_String_ == IntPtr.Zero)
				id_setNamespace_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNamespace", "(Ljava/lang/String;)Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setNamespace_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNamespace", "(Ljava/lang/String;)Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setTime_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTime_Ljava_lang_String_Handler ()
		{
			if (cb_setTime_Ljava_lang_String_ == null)
				cb_setTime_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTime_Ljava_lang_String_);
			return cb_setTime_Ljava_lang_String_;
		}

		static IntPtr n_SetTime_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTime (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setTime_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='LoggosMessage']/method[@name='setTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTime", "(Ljava/lang/String;)Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;", "GetSetTime_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage SetTime (string p0)
		{
			if (id_setTime_Ljava_lang_String_ == IntPtr.Zero)
				id_setTime_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTime", "(Ljava/lang/String;)Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTime_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTime", "(Ljava/lang/String;)Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setTime_J;
#pragma warning disable 0169
		static Delegate GetSetTime_JHandler ()
		{
			if (cb_setTime_J == null)
				cb_setTime_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetTime_J);
			return cb_setTime_J;
		}

		static IntPtr n_SetTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTime (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setTime_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='LoggosMessage']/method[@name='setTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setTime", "(J)Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;", "GetSetTime_JHandler")]
		public virtual unsafe global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage SetTime (long p0)
		{
			if (id_setTime_J == IntPtr.Zero)
				id_setTime_J = JNIEnv.GetMethodID (class_ref, "setTime", "(J)Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTime_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTime", "(J)Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setUrl_Ljava_lang_String_ == null)
				cb_setUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetUrl_Ljava_lang_String_);
			return cb_setUrl_Ljava_lang_String_;
		}

		static IntPtr n_SetUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUrl (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='LoggosMessage']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUrl", "(Ljava/lang/String;)Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;", "GetSetUrl_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage SetUrl (string p0)
		{
			if (id_setUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_setUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUrl", "(Ljava/lang/String;)Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUrl", "(Ljava/lang/String;)Lcom/liveperson/infra/log/logreporter/loggos/LoggosMessage;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_toJsonObject;
#pragma warning disable 0169
		static Delegate GetToJsonObjectHandler ()
		{
			if (cb_toJsonObject == null)
				cb_toJsonObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToJsonObject);
			return cb_toJsonObject;
		}

		static IntPtr n_ToJsonObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToJsonObject ());
		}
#pragma warning restore 0169

		static IntPtr id_toJsonObject;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos']/class[@name='LoggosMessage']/method[@name='toJsonObject' and count(parameter)=0]"
		[Register ("toJsonObject", "()Lorg/json/JSONObject;", "GetToJsonObjectHandler")]
		public virtual unsafe global::Org.Json.JSONObject ToJsonObject ()
		{
			if (id_toJsonObject == IntPtr.Zero)
				id_toJsonObject = JNIEnv.GetMethodID (class_ref, "toJsonObject", "()Lorg/json/JSONObject;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJsonObject), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toJsonObject", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
