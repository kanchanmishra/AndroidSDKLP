using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Response.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Dialog']"
	[global::Android.Runtime.Register ("com/liveperson/api/response/model/Dialog", DoNotGenerateAcw=true)]
	public partial class Dialog : global::Com.Liveperson.Api.Response.Model.MultiDialog {


		static IntPtr dialogId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Dialog']/field[@name='dialogId']"
		[Register ("dialogId")]
		public string DialogId {
			get {
				if (dialogId_jfieldId == IntPtr.Zero)
					dialogId_jfieldId = JNIEnv.GetFieldID (class_ref, "dialogId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, dialogId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (dialogId_jfieldId == IntPtr.Zero)
					dialogId_jfieldId = JNIEnv.GetFieldID (class_ref, "dialogId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, dialogId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr dialogType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Dialog']/field[@name='dialogType']"
		[Register ("dialogType")]
		public string DialogType {
			get {
				if (dialogType_jfieldId == IntPtr.Zero)
					dialogType_jfieldId = JNIEnv.GetFieldID (class_ref, "dialogType", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, dialogType_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (dialogType_jfieldId == IntPtr.Zero)
					dialogType_jfieldId = JNIEnv.GetFieldID (class_ref, "dialogType", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, dialogType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr open_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Dialog']/field[@name='open']"
		[Register ("open")]
		public bool Open {
			get {
				if (open_jfieldId == IntPtr.Zero)
					open_jfieldId = JNIEnv.GetFieldID (class_ref, "open", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, open_jfieldId);
			}
			set {
				if (open_jfieldId == IntPtr.Zero)
					open_jfieldId = JNIEnv.GetFieldID (class_ref, "open", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, open_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr participants_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Dialog']/field[@name='participants']"
		[Register ("participants")]
		public IList<string> Participants {
			get {
				if (participants_jfieldId == IntPtr.Zero)
					participants_jfieldId = JNIEnv.GetFieldID (class_ref, "participants", "[Ljava/lang/String;");
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, participants_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (participants_jfieldId == IntPtr.Zero)
					participants_jfieldId = JNIEnv.GetFieldID (class_ref, "participants", "[Ljava/lang/String;");
				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, participants_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/response/model/Dialog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Dialog); }
		}

		protected Dialog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Dialog']/constructor[@name='Dialog' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe Dialog (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (Dialog)) {
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
