using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Configuration {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='LptagEnvironment']"
	[global::Android.Runtime.Register ("com/liveperson/infra/configuration/LptagEnvironment", DoNotGenerateAcw=true)]
	public partial class LptagEnvironment : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='LptagEnvironment']/field[@name='LPTAG_ALPHA_DOMAIN']"
		[Register ("LPTAG_ALPHA_DOMAIN")]
		public const string LptagAlphaDomain = (string) "lptag-a.liveperson.net";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='LptagEnvironment']/field[@name='LPTAG_PRODUCTION_DOMAIN']"
		[Register ("LPTAG_PRODUCTION_DOMAIN")]
		public const string LptagProductionDomain = (string) "lptag.liveperson.net";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='LptagEnvironment']/field[@name='LPTAG_QA_DOMAIN']"
		[Register ("LPTAG_QA_DOMAIN")]
		public const string LptagQaDomain = (string) "lptag-dev.dev.lprnd.net";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='LptagEnvironment.Env']"
		[global::Android.Runtime.Register ("com/liveperson/infra/configuration/LptagEnvironment$Env", DoNotGenerateAcw=true)]
		public sealed partial class Env : global::Java.Lang.Enum {


			static IntPtr ALPHA_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='LptagEnvironment.Env']/field[@name='ALPHA']"
			[Register ("ALPHA")]
			public static global::Com.Liveperson.Infra.Configuration.LptagEnvironment.Env Alpha {
				get {
					if (ALPHA_jfieldId == IntPtr.Zero)
						ALPHA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALPHA", "Lcom/liveperson/infra/configuration/LptagEnvironment$Env;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALPHA_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Configuration.LptagEnvironment.Env> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PRODUCTION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='LptagEnvironment.Env']/field[@name='PRODUCTION']"
			[Register ("PRODUCTION")]
			public static global::Com.Liveperson.Infra.Configuration.LptagEnvironment.Env Production {
				get {
					if (PRODUCTION_jfieldId == IntPtr.Zero)
						PRODUCTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PRODUCTION", "Lcom/liveperson/infra/configuration/LptagEnvironment$Env;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PRODUCTION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Configuration.LptagEnvironment.Env> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr QA_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='LptagEnvironment.Env']/field[@name='QA']"
			[Register ("QA")]
			public static global::Com.Liveperson.Infra.Configuration.LptagEnvironment.Env Qa {
				get {
					if (QA_jfieldId == IntPtr.Zero)
						QA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QA", "Lcom/liveperson/infra/configuration/LptagEnvironment$Env;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, QA_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Configuration.LptagEnvironment.Env> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/configuration/LptagEnvironment$Env", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Env); }
			}

			internal Env (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='LptagEnvironment.Env']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/configuration/LptagEnvironment$Env;", "")]
			public static unsafe global::Com.Liveperson.Infra.Configuration.LptagEnvironment.Env ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/configuration/LptagEnvironment$Env;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Liveperson.Infra.Configuration.LptagEnvironment.Env __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Configuration.LptagEnvironment.Env> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='LptagEnvironment.Env']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/liveperson/infra/configuration/LptagEnvironment$Env;", "")]
			public static unsafe global::Com.Liveperson.Infra.Configuration.LptagEnvironment.Env[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/infra/configuration/LptagEnvironment$Env;");
				try {
					return (global::Com.Liveperson.Infra.Configuration.LptagEnvironment.Env[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Infra.Configuration.LptagEnvironment.Env));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/configuration/LptagEnvironment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LptagEnvironment); }
		}

		protected LptagEnvironment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='LptagEnvironment']/constructor[@name='LptagEnvironment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LptagEnvironment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LptagEnvironment)) {
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

		static Delegate cb_getEnvironment;
#pragma warning disable 0169
		static Delegate GetGetEnvironmentHandler ()
		{
			if (cb_getEnvironment == null)
				cb_getEnvironment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEnvironment);
			return cb_getEnvironment;
		}

		static IntPtr n_GetEnvironment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Configuration.LptagEnvironment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Configuration.LptagEnvironment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Environment);
		}
#pragma warning restore 0169

		static Delegate cb_setEnvironment_Lcom_liveperson_infra_configuration_LptagEnvironment_Env_;
#pragma warning disable 0169
		static Delegate GetSetEnvironment_Lcom_liveperson_infra_configuration_LptagEnvironment_Env_Handler ()
		{
			if (cb_setEnvironment_Lcom_liveperson_infra_configuration_LptagEnvironment_Env_ == null)
				cb_setEnvironment_Lcom_liveperson_infra_configuration_LptagEnvironment_Env_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEnvironment_Lcom_liveperson_infra_configuration_LptagEnvironment_Env_);
			return cb_setEnvironment_Lcom_liveperson_infra_configuration_LptagEnvironment_Env_;
		}

		static void n_SetEnvironment_Lcom_liveperson_infra_configuration_LptagEnvironment_Env_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Configuration.LptagEnvironment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Configuration.LptagEnvironment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Configuration.LptagEnvironment.Env p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Configuration.LptagEnvironment.Env> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Environment = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEnvironment;
		static IntPtr id_setEnvironment_Lcom_liveperson_infra_configuration_LptagEnvironment_Env_;
		public virtual unsafe global::Com.Liveperson.Infra.Configuration.LptagEnvironment.Env Environment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='LptagEnvironment']/method[@name='getEnvironment' and count(parameter)=0]"
			[Register ("getEnvironment", "()Lcom/liveperson/infra/configuration/LptagEnvironment$Env;", "GetGetEnvironmentHandler")]
			get {
				if (id_getEnvironment == IntPtr.Zero)
					id_getEnvironment = JNIEnv.GetMethodID (class_ref, "getEnvironment", "()Lcom/liveperson/infra/configuration/LptagEnvironment$Env;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Configuration.LptagEnvironment.Env> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEnvironment), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Configuration.LptagEnvironment.Env> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEnvironment", "()Lcom/liveperson/infra/configuration/LptagEnvironment$Env;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='LptagEnvironment']/method[@name='setEnvironment' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.configuration.LptagEnvironment.Env']]"
			[Register ("setEnvironment", "(Lcom/liveperson/infra/configuration/LptagEnvironment$Env;)V", "GetSetEnvironment_Lcom_liveperson_infra_configuration_LptagEnvironment_Env_Handler")]
			set {
				if (id_setEnvironment_Lcom_liveperson_infra_configuration_LptagEnvironment_Env_ == IntPtr.Zero)
					id_setEnvironment_Lcom_liveperson_infra_configuration_LptagEnvironment_Env_ = JNIEnv.GetMethodID (class_ref, "setEnvironment", "(Lcom/liveperson/infra/configuration/LptagEnvironment$Env;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEnvironment_Lcom_liveperson_infra_configuration_LptagEnvironment_Env_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEnvironment", "(Lcom/liveperson/infra/configuration/LptagEnvironment$Env;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLptagDomain;
#pragma warning disable 0169
		static Delegate GetGetLptagDomainHandler ()
		{
			if (cb_getLptagDomain == null)
				cb_getLptagDomain = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLptagDomain);
			return cb_getLptagDomain;
		}

		static IntPtr n_GetLptagDomain (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Configuration.LptagEnvironment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Configuration.LptagEnvironment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LptagDomain);
		}
#pragma warning restore 0169

		static IntPtr id_getLptagDomain;
		public virtual unsafe string LptagDomain {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='LptagEnvironment']/method[@name='getLptagDomain' and count(parameter)=0]"
			[Register ("getLptagDomain", "()Ljava/lang/String;", "GetGetLptagDomainHandler")]
			get {
				if (id_getLptagDomain == IntPtr.Zero)
					id_getLptagDomain = JNIEnv.GetMethodID (class_ref, "getLptagDomain", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLptagDomain), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLptagDomain", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
