using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Response.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Result']"
	[global::Android.Runtime.Register ("com/liveperson/api/response/model/Result", DoNotGenerateAcw=true)]
	public partial class Result : global::Java.Lang.Object {


		static IntPtr convId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Result']/field[@name='convId']"
		[Register ("convId")]
		public string ConvId {
			get {
				if (convId_jfieldId == IntPtr.Zero)
					convId_jfieldId = JNIEnv.GetFieldID (class_ref, "convId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, convId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (convId_jfieldId == IntPtr.Zero)
					convId_jfieldId = JNIEnv.GetFieldID (class_ref, "convId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, convId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr conversationDetails_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Result']/field[@name='conversationDetails']"
		[Register ("conversationDetails")]
		public global::Com.Liveperson.Api.Response.Model.ConversationUMSDetails ConversationDetails {
			get {
				if (conversationDetails_jfieldId == IntPtr.Zero)
					conversationDetails_jfieldId = JNIEnv.GetFieldID (class_ref, "conversationDetails", "Lcom/liveperson/api/response/model/ConversationUMSDetails;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, conversationDetails_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.ConversationUMSDetails> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (conversationDetails_jfieldId == IntPtr.Zero)
					conversationDetails_jfieldId = JNIEnv.GetFieldID (class_ref, "conversationDetails", "Lcom/liveperson/api/response/model/ConversationUMSDetails;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, conversationDetails_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr effectiveTTR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Result']/field[@name='effectiveTTR']"
		[Register ("effectiveTTR")]
		public long EffectiveTTR {
			get {
				if (effectiveTTR_jfieldId == IntPtr.Zero)
					effectiveTTR_jfieldId = JNIEnv.GetFieldID (class_ref, "effectiveTTR", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, effectiveTTR_jfieldId);
			}
			set {
				if (effectiveTTR_jfieldId == IntPtr.Zero)
					effectiveTTR_jfieldId = JNIEnv.GetFieldID (class_ref, "effectiveTTR", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, effectiveTTR_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/response/model/Result", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Result); }
		}

		protected Result (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Result']/constructor[@name='Result' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe Result (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (Result)) {
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

	}
}
