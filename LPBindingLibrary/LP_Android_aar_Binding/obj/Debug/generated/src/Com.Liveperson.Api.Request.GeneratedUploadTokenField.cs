using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GeneratedUploadTokenField']"
	[global::Android.Runtime.Register ("com/liveperson/api/request/GeneratedUploadTokenField", DoNotGenerateAcw=true)]
	public partial class GeneratedUploadTokenField : global::Com.Liveperson.Api.Request.BaseGenerateURL {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GeneratedUploadTokenField']/field[@name='GENERATE_UPLOAD_TOKEN_TYPE']"
		[Register ("GENERATE_UPLOAD_TOKEN_TYPE")]
		public const string GenerateUploadTokenType = (string) "ms.GenerateUploadToken";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GeneratedUploadTokenField']/field[@name='READ_OTK']"
		[Register ("READ_OTK")]
		public const string ReadOtk = (string) "readOtk";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GeneratedUploadTokenField']/field[@name='WRITE_OTK']"
		[Register ("WRITE_OTK")]
		public const string WriteOtk = (string) "writeOtk";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GeneratedUploadTokenField.Response']"
		[global::Android.Runtime.Register ("com/liveperson/api/request/GeneratedUploadTokenField$Response", DoNotGenerateAcw=true)]
		public new partial class Response : global::Com.Liveperson.Api.Response.AbstractResponse {


			static IntPtr GENERATE_UPLOAD_RESPONSE_TYPE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GeneratedUploadTokenField.Response']/field[@name='GENERATE_UPLOAD_RESPONSE_TYPE']"
			[Register ("GENERATE_UPLOAD_RESPONSE_TYPE")]
			public static string GenerateUploadResponseType {
				get {
					if (GENERATE_UPLOAD_RESPONSE_TYPE_jfieldId == IntPtr.Zero)
						GENERATE_UPLOAD_RESPONSE_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GENERATE_UPLOAD_RESPONSE_TYPE", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GENERATE_UPLOAD_RESPONSE_TYPE_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (GENERATE_UPLOAD_RESPONSE_TYPE_jfieldId == IntPtr.Zero)
						GENERATE_UPLOAD_RESPONSE_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GENERATE_UPLOAD_RESPONSE_TYPE", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetStaticField (class_ref, GENERATE_UPLOAD_RESPONSE_TYPE_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GeneratedUploadTokenField.Response.Body']"
			[global::Android.Runtime.Register ("com/liveperson/api/request/GeneratedUploadTokenField$Response$Body", DoNotGenerateAcw=true)]
			public partial class Body : global::Java.Lang.Object {


				static IntPtr readOtk_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GeneratedUploadTokenField.Response.Body']/field[@name='readOtk']"
				[Register ("readOtk")]
				public string ReadOtk {
					get {
						if (readOtk_jfieldId == IntPtr.Zero)
							readOtk_jfieldId = JNIEnv.GetFieldID (class_ref, "readOtk", "Ljava/lang/String;");
						IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, readOtk_jfieldId);
						return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (readOtk_jfieldId == IntPtr.Zero)
							readOtk_jfieldId = JNIEnv.GetFieldID (class_ref, "readOtk", "Ljava/lang/String;");
						IntPtr native_value = JNIEnv.NewString (value);
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, readOtk_jfieldId, native_value);
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}

				static IntPtr type_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GeneratedUploadTokenField.Response.Body']/field[@name='type']"
				[Register ("type")]
				public string Type {
					get {
						if (type_jfieldId == IntPtr.Zero)
							type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Ljava/lang/String;");
						IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, type_jfieldId);
						return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (type_jfieldId == IntPtr.Zero)
							type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Ljava/lang/String;");
						IntPtr native_value = JNIEnv.NewString (value);
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, type_jfieldId, native_value);
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}

				static IntPtr writeOtk_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GeneratedUploadTokenField.Response.Body']/field[@name='writeOtk']"
				[Register ("writeOtk")]
				public string WriteOtk {
					get {
						if (writeOtk_jfieldId == IntPtr.Zero)
							writeOtk_jfieldId = JNIEnv.GetFieldID (class_ref, "writeOtk", "Ljava/lang/String;");
						IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, writeOtk_jfieldId);
						return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
					}
					set {
						if (writeOtk_jfieldId == IntPtr.Zero)
							writeOtk_jfieldId = JNIEnv.GetFieldID (class_ref, "writeOtk", "Ljava/lang/String;");
						IntPtr native_value = JNIEnv.NewString (value);
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, writeOtk_jfieldId, native_value);
						} finally {
							JNIEnv.DeleteLocalRef (native_value);
						}
					}
				}
				internal static new IntPtr java_class_handle;
				internal static new IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/liveperson/api/request/GeneratedUploadTokenField$Response$Body", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (Body); }
				}

				protected Body (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_ctor;
				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GeneratedUploadTokenField.Response.Body']/constructor[@name='GeneratedUploadTokenField.Response.Body' and count(parameter)=0]"
				[Register (".ctor", "()V", "")]
				public unsafe Body ()
					: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
				{
					if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
						return;

					try {
						if (((object) this).GetType () != typeof (Body)) {
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

			}

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/api/request/GeneratedUploadTokenField$Response", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Response); }
			}

			protected Response (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_json_JSONObject_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GeneratedUploadTokenField.Response']/constructor[@name='GeneratedUploadTokenField.Response' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
			public unsafe Response (global::Org.Json.JSONObject p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (Response)) {
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

			static Delegate cb_getBody;
#pragma warning disable 0169
			static Delegate GetGetBodyHandler ()
			{
				if (cb_getBody == null)
					cb_getBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBody);
				return cb_getBody;
			}

			static IntPtr n_GetBody (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Api.Request.GeneratedUploadTokenField.Response __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.GeneratedUploadTokenField.Response> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.GetBody ());
			}
#pragma warning restore 0169

			static IntPtr id_getBody;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GeneratedUploadTokenField.Response']/method[@name='getBody' and count(parameter)=0]"
			[Register ("getBody", "()Lcom/liveperson/api/request/GeneratedUploadTokenField$Response$Body;", "GetGetBodyHandler")]
			public virtual unsafe global::Com.Liveperson.Api.Request.GeneratedUploadTokenField.Response.Body GetBody ()
			{
				if (id_getBody == IntPtr.Zero)
					id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()Lcom/liveperson/api/request/GeneratedUploadTokenField$Response$Body;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.GeneratedUploadTokenField.Response.Body> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBody), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.GeneratedUploadTokenField.Response.Body> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBody", "()Lcom/liveperson/api/request/GeneratedUploadTokenField$Response$Body;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/request/GeneratedUploadTokenField", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeneratedUploadTokenField); }
		}

		protected GeneratedUploadTokenField (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GeneratedUploadTokenField']/constructor[@name='GeneratedUploadTokenField' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe GeneratedUploadTokenField (string p0, string p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (GeneratedUploadTokenField)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getMessageType;
#pragma warning disable 0169
		static Delegate GetGetMessageTypeHandler ()
		{
			if (cb_getMessageType == null)
				cb_getMessageType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageType);
			return cb_getMessageType;
		}

		static IntPtr n_GetMessageType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Request.GeneratedUploadTokenField __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.GeneratedUploadTokenField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageType);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageType;
		public override unsafe string MessageType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GeneratedUploadTokenField']/method[@name='getMessageType' and count(parameter)=0]"
			[Register ("getMessageType", "()Ljava/lang/String;", "GetGetMessageTypeHandler")]
			get {
				if (id_getMessageType == IntPtr.Zero)
					id_getMessageType = JNIEnv.GetMethodID (class_ref, "getMessageType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_toJson_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetToJson_Lorg_json_JSONObject_Handler ()
		{
			if (cb_toJson_Lorg_json_JSONObject_ == null)
				cb_toJson_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ToJson_Lorg_json_JSONObject_);
			return cb_toJson_Lorg_json_JSONObject_;
		}

		static void n_ToJson_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Api.Request.GeneratedUploadTokenField __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.GeneratedUploadTokenField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ToJson (p0);
		}
#pragma warning restore 0169

		static IntPtr id_toJson_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GeneratedUploadTokenField']/method[@name='toJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("toJson", "(Lorg/json/JSONObject;)V", "GetToJson_Lorg_json_JSONObject_Handler")]
		protected override unsafe void ToJson (global::Org.Json.JSONObject p0)
		{
			if (id_toJson_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_toJson_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "toJson", "(Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toJson_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toJson", "(Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

	}
}
