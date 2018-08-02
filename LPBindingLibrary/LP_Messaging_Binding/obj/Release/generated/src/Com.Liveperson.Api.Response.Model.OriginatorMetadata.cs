using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Response.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='OriginatorMetadata']"
	[global::Android.Runtime.Register ("com/liveperson/api/response/model/OriginatorMetadata", DoNotGenerateAcw=true)]
	public partial class OriginatorMetadata : global::Java.Lang.Object {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='OriginatorMetadata']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr mId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='OriginatorMetadata']/field[@name='mId']"
		[Register ("mId")]
		public string MId {
			get {
				if (mId_jfieldId == IntPtr.Zero)
					mId_jfieldId = JNIEnv.GetFieldID (class_ref, "mId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mId_jfieldId == IntPtr.Zero)
					mId_jfieldId = JNIEnv.GetFieldID (class_ref, "mId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mRole_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='OriginatorMetadata']/field[@name='mRole']"
		[Register ("mRole")]
		public global::Com.Liveperson.Api.Response.Model.Participants.ParticipantRole MRole {
			get {
				if (mRole_jfieldId == IntPtr.Zero)
					mRole_jfieldId = JNIEnv.GetFieldID (class_ref, "mRole", "Lcom/liveperson/api/response/model/Participants$ParticipantRole;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mRole_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.Participants.ParticipantRole> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mRole_jfieldId == IntPtr.Zero)
					mRole_jfieldId = JNIEnv.GetFieldID (class_ref, "mRole", "Lcom/liveperson/api/response/model/Participants$ParticipantRole;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mRole_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/response/model/OriginatorMetadata", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OriginatorMetadata); }
		}

		protected OriginatorMetadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='OriginatorMetadata']/constructor[@name='OriginatorMetadata' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OriginatorMetadata ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (OriginatorMetadata)) {
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

		static IntPtr id_fromJson_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='OriginatorMetadata']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("fromJson", "(Lorg/json/JSONObject;)Lcom/liveperson/api/response/model/OriginatorMetadata;", "")]
		public static unsafe global::Com.Liveperson.Api.Response.Model.OriginatorMetadata FromJson (global::Org.Json.JSONObject p0)
		{
			if (id_fromJson_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_fromJson_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "fromJson", "(Lorg/json/JSONObject;)Lcom/liveperson/api/response/model/OriginatorMetadata;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Liveperson.Api.Response.Model.OriginatorMetadata __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.OriginatorMetadata> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromJson_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
