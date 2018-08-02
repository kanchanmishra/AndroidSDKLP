using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GetUserProfile']"
	[global::Android.Runtime.Register ("com/liveperson/api/request/GetUserProfile", DoNotGenerateAcw=true)]
	public partial class GetUserProfile : global::Com.Liveperson.Api.Request.AbstractRequest {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GetUserProfile']/field[@name='BODY']"
		[Register ("BODY")]
		public const string Body = (string) "body";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GetUserProfile']/field[@name='GET_USER_PROFILE_TYPE']"
		[Register ("GET_USER_PROFILE_TYPE")]
		public const string GetUserProfileType = (string) "userprofile.GetUserProfile";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GetUserProfile.Response']"
		[global::Android.Runtime.Register ("com/liveperson/api/request/GetUserProfile$Response", DoNotGenerateAcw=true)]
		public partial class Response : global::Com.Liveperson.Api.Response.AbstractResponse {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GetUserProfile.Response']/field[@name='GET_USER_PROFILE_RESPONSE_TYPE']"
			[Register ("GET_USER_PROFILE_RESPONSE_TYPE")]
			public const string GetUserProfileResponseType = (string) "userprofile.GetUserProfileResponse";
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/api/request/GetUserProfile$Response", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GetUserProfile.Response']/constructor[@name='GetUserProfile.Response' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
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
				global::Com.Liveperson.Api.Request.GetUserProfile.Response __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.GetUserProfile.Response> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Body);
			}
#pragma warning restore 0169

			static IntPtr id_getBody;
			public virtual unsafe global::Com.Liveperson.Api.Response.Model.UserProfile Body {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GetUserProfile.Response']/method[@name='getBody' and count(parameter)=0]"
				[Register ("getBody", "()Lcom/liveperson/api/response/model/UserProfile;", "GetGetBodyHandler")]
				get {
					if (id_getBody == IntPtr.Zero)
						id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()Lcom/liveperson/api/response/model/UserProfile;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBody), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBody", "()Lcom/liveperson/api/response/model/UserProfile;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/request/GetUserProfile", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GetUserProfile); }
		}

		protected GetUserProfile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GetUserProfile']/constructor[@name='GetUserProfile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe GetUserProfile (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (GetUserProfile)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Liveperson.Api.Request.GetUserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.GetUserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageType);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageType;
		public override unsafe string MessageType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GetUserProfile']/method[@name='getMessageType' and count(parameter)=0]"
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
			global::Com.Liveperson.Api.Request.GetUserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.GetUserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ToJson (p0);
		}
#pragma warning restore 0169

		static IntPtr id_toJson_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GetUserProfile']/method[@name='toJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
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
