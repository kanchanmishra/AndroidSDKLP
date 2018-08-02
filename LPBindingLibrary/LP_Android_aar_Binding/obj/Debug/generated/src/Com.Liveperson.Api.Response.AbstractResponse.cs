using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Response {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response']/class[@name='AbstractResponse']"
	[global::Android.Runtime.Register ("com/liveperson/api/response/AbstractResponse", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class AbstractResponse : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response']/class[@name='AbstractResponse']/field[@name='GENERAL_INNER_RESPONSE']"
		[Register ("GENERAL_INNER_RESPONSE")]
		public const string GeneralInnerResponse = (string) "$Response";

		static IntPtr code_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response']/class[@name='AbstractResponse']/field[@name='code']"
		[Register ("code")]
		public int Code {
			get {
				if (code_jfieldId == IntPtr.Zero)
					code_jfieldId = JNIEnv.GetFieldID (class_ref, "code", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, code_jfieldId);
			}
			set {
				if (code_jfieldId == IntPtr.Zero)
					code_jfieldId = JNIEnv.GetFieldID (class_ref, "code", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, code_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr reqId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response']/class[@name='AbstractResponse']/field[@name='reqId']"
		[Register ("reqId")]
		public int ReqId {
			get {
				if (reqId_jfieldId == IntPtr.Zero)
					reqId_jfieldId = JNIEnv.GetFieldID (class_ref, "reqId", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, reqId_jfieldId);
			}
			set {
				if (reqId_jfieldId == IntPtr.Zero)
					reqId_jfieldId = JNIEnv.GetFieldID (class_ref, "reqId", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, reqId_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/response/AbstractResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractResponse); }
		}

		protected AbstractResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.response']/class[@name='AbstractResponse']/constructor[@name='AbstractResponse' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe AbstractResponse (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AbstractResponse)) {
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

	[global::Android.Runtime.Register ("com/liveperson/api/response/AbstractResponse", DoNotGenerateAcw=true)]
	internal partial class AbstractResponseInvoker : AbstractResponse {

		public AbstractResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractResponseInvoker); }
		}

	}

}
