using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Response.Types {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CSAT']"
	[global::Android.Runtime.Register ("com/liveperson/api/response/types/CSAT", DoNotGenerateAcw=true)]
	public partial class CSAT : global::Java.Lang.Object {


		static IntPtr csatRate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CSAT']/field[@name='csatRate']"
		[Register ("csatRate")]
		public int CsatRate {
			get {
				if (csatRate_jfieldId == IntPtr.Zero)
					csatRate_jfieldId = JNIEnv.GetFieldID (class_ref, "csatRate", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, csatRate_jfieldId);
			}
			set {
				if (csatRate_jfieldId == IntPtr.Zero)
					csatRate_jfieldId = JNIEnv.GetFieldID (class_ref, "csatRate", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, csatRate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr csatResolutionConfirmation_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CSAT']/field[@name='csatResolutionConfirmation']"
		[Register ("csatResolutionConfirmation")]
		public string CsatResolutionConfirmation {
			get {
				if (csatResolutionConfirmation_jfieldId == IntPtr.Zero)
					csatResolutionConfirmation_jfieldId = JNIEnv.GetFieldID (class_ref, "csatResolutionConfirmation", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, csatResolutionConfirmation_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (csatResolutionConfirmation_jfieldId == IntPtr.Zero)
					csatResolutionConfirmation_jfieldId = JNIEnv.GetFieldID (class_ref, "csatResolutionConfirmation", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, csatResolutionConfirmation_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr csatStatus_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CSAT']/field[@name='csatStatus']"
		[Register ("csatStatus")]
		public global::Com.Liveperson.Api.Response.Types.CsatStatus CsatStatus {
			get {
				if (csatStatus_jfieldId == IntPtr.Zero)
					csatStatus_jfieldId = JNIEnv.GetFieldID (class_ref, "csatStatus", "Lcom/liveperson/api/response/types/CsatStatus;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, csatStatus_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CsatStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (csatStatus_jfieldId == IntPtr.Zero)
					csatStatus_jfieldId = JNIEnv.GetFieldID (class_ref, "csatStatus", "Lcom/liveperson/api/response/types/CsatStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, csatStatus_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CSAT.CSAT_SHOW_STATUS']"
		[global::Android.Runtime.Register ("com/liveperson/api/response/types/CSAT$CSAT_SHOW_STATUS", DoNotGenerateAcw=true)]
		public sealed partial class CSAT_SHOW_STATUS : global::Java.Lang.Enum {


			static IntPtr NOT_SHOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CSAT.CSAT_SHOW_STATUS']/field[@name='NOT_SHOWN']"
			[Register ("NOT_SHOWN")]
			public static global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS NotShown {
				get {
					if (NOT_SHOWN_jfieldId == IntPtr.Zero)
						NOT_SHOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_SHOWN", "Lcom/liveperson/api/response/types/CSAT$CSAT_SHOW_STATUS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_SHOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NO_NEED_TO_SHOW_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CSAT.CSAT_SHOW_STATUS']/field[@name='NO_NEED_TO_SHOW']"
			[Register ("NO_NEED_TO_SHOW")]
			public static global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS NoNeedToShow {
				get {
					if (NO_NEED_TO_SHOW_jfieldId == IntPtr.Zero)
						NO_NEED_TO_SHOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_NEED_TO_SHOW", "Lcom/liveperson/api/response/types/CSAT$CSAT_SHOW_STATUS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_NEED_TO_SHOW_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NO_VALUE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CSAT.CSAT_SHOW_STATUS']/field[@name='NO_VALUE']"
			[Register ("NO_VALUE")]
			public static global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS NoValue {
				get {
					if (NO_VALUE_jfieldId == IntPtr.Zero)
						NO_VALUE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_VALUE", "Lcom/liveperson/api/response/types/CSAT$CSAT_SHOW_STATUS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_VALUE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SHOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CSAT.CSAT_SHOW_STATUS']/field[@name='SHOWN']"
			[Register ("SHOWN")]
			public static global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS Shown {
				get {
					if (SHOWN_jfieldId == IntPtr.Zero)
						SHOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHOWN", "Lcom/liveperson/api/response/types/CSAT$CSAT_SHOW_STATUS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SHOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/api/response/types/CSAT$CSAT_SHOW_STATUS", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CSAT_SHOW_STATUS); }
			}

			internal CSAT_SHOW_STATUS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getCsatValue;
			public unsafe int CsatValue {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CSAT.CSAT_SHOW_STATUS']/method[@name='getCsatValue' and count(parameter)=0]"
				[Register ("getCsatValue", "()I", "GetGetCsatValueHandler")]
				get {
					if (id_getCsatValue == IntPtr.Zero)
						id_getCsatValue = JNIEnv.GetMethodID (class_ref, "getCsatValue", "()I");
					try {
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCsatValue);
					} finally {
					}
				}
			}

			static IntPtr id_getShownCsatForValue_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CSAT.CSAT_SHOW_STATUS']/method[@name='getShownCsatForValue' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getShownCsatForValue", "(I)Lcom/liveperson/api/response/types/CSAT$CSAT_SHOW_STATUS;", "")]
			public static unsafe global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS GetShownCsatForValue (int p0)
			{
				if (id_getShownCsatForValue_I == IntPtr.Zero)
					id_getShownCsatForValue_I = JNIEnv.GetStaticMethodID (class_ref, "getShownCsatForValue", "(I)Lcom/liveperson/api/response/types/CSAT$CSAT_SHOW_STATUS;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getShownCsatForValue_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CSAT.CSAT_SHOW_STATUS']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/response/types/CSAT$CSAT_SHOW_STATUS;", "")]
			public static unsafe global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/response/types/CSAT$CSAT_SHOW_STATUS;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CSAT.CSAT_SHOW_STATUS']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/liveperson/api/response/types/CSAT$CSAT_SHOW_STATUS;", "")]
			public static unsafe global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/api/response/types/CSAT$CSAT_SHOW_STATUS;");
				try {
					return (global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/response/types/CSAT", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CSAT); }
		}

		protected CSAT (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CSAT']/constructor[@name='CSAT' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe CSAT (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (CSAT)) {
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

		static Delegate cb_isShowedCsat;
#pragma warning disable 0169
		static Delegate GetIsShowedCsatHandler ()
		{
			if (cb_isShowedCsat == null)
				cb_isShowedCsat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsShowedCsat);
			return cb_isShowedCsat;
		}

		static IntPtr n_IsShowedCsat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Response.Types.CSAT __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CSAT> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsShowedCsat ());
		}
#pragma warning restore 0169

		static IntPtr id_isShowedCsat;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='CSAT']/method[@name='isShowedCsat' and count(parameter)=0]"
		[Register ("isShowedCsat", "()Lcom/liveperson/api/response/types/CSAT$CSAT_SHOW_STATUS;", "GetIsShowedCsatHandler")]
		public virtual unsafe global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS IsShowedCsat ()
		{
			if (id_isShowedCsat == IntPtr.Zero)
				id_isShowedCsat = JNIEnv.GetMethodID (class_ref, "isShowedCsat", "()Lcom/liveperson/api/response/types/CSAT$CSAT_SHOW_STATUS;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_isShowedCsat), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isShowedCsat", "()Lcom/liveperson/api/response/types/CSAT$CSAT_SHOW_STATUS;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
