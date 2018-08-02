using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Response.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Ttr']"
	[global::Android.Runtime.Register ("com/liveperson/api/response/model/Ttr", DoNotGenerateAcw=true)]
	public partial class Ttr : global::Java.Lang.Object {


		static IntPtr ttrType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Ttr']/field[@name='ttrType']"
		[Register ("ttrType")]
		public string TtrType {
			get {
				if (ttrType_jfieldId == IntPtr.Zero)
					ttrType_jfieldId = JNIEnv.GetFieldID (class_ref, "ttrType", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, ttrType_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ttrType_jfieldId == IntPtr.Zero)
					ttrType_jfieldId = JNIEnv.GetFieldID (class_ref, "ttrType", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ttrType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr value_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Ttr']/field[@name='value']"
		[Register ("value")]
		public int Value {
			get {
				if (value_jfieldId == IntPtr.Zero)
					value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, value_jfieldId);
			}
			set {
				if (value_jfieldId == IntPtr.Zero)
					value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, value_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/response/model/Ttr", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Ttr); }
		}

		protected Ttr (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Ttr']/constructor[@name='Ttr' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe Ttr (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (Ttr)) {
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
