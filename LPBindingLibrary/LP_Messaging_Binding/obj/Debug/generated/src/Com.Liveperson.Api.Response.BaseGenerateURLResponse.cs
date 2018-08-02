using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Response {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response']/class[@name='BaseGenerateURLResponse']"
	[global::Android.Runtime.Register ("com/liveperson/api/response/BaseGenerateURLResponse", DoNotGenerateAcw=true)]
	public partial class BaseGenerateURLResponse : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response']/class[@name='BaseGenerateURLResponse']/field[@name='QUERY_PARAMS']"
		[Register ("QUERY_PARAMS")]
		public const string QueryParams = (string) "queryParams";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response']/class[@name='BaseGenerateURLResponse']/field[@name='RELATIVE_PATH']"
		[Register ("RELATIVE_PATH")]
		public const string RelativePath = (string) "relativePath";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/response/BaseGenerateURLResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseGenerateURLResponse); }
		}

		protected BaseGenerateURLResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.response']/class[@name='BaseGenerateURLResponse']/constructor[@name='BaseGenerateURLResponse' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe BaseGenerateURLResponse (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (BaseGenerateURLResponse)) {
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
