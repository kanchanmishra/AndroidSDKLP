using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Response.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']"
	[global::Android.Runtime.Register ("com/liveperson/api/response/model/UserProfile", DoNotGenerateAcw=true)]
	public partial class UserProfile : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/field[@name='CERT_NAME']"
		[Register ("CERT_NAME")]
		public const string CertName = (string) "certName";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/field[@name='MAIL']"
		[Register ("MAIL")]
		public const string Mail = (string) "mail";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/field[@name='MOBILE_NUM']"
		[Register ("MOBILE_NUM")]
		public const string MobileNum = (string) "mobileNum";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/field[@name='SERVICE_NAME']"
		[Register ("SERVICE_NAME")]
		public const string ServiceName = (string) "serviceName";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/field[@name='TOKEN']"
		[Register ("TOKEN")]
		public const string Token = (string) "token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/field[@name='USER_ID']"
		[Register ("USER_ID")]
		public const string UserId = (string) "userId";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile.PrivateData']"
		[global::Android.Runtime.Register ("com/liveperson/api/response/model/UserProfile$PrivateData", DoNotGenerateAcw=true)]
		public partial class PrivateData : global::Java.Lang.Object {


			static IntPtr mail_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile.PrivateData']/field[@name='mail']"
			[Register ("mail")]
			public string Mail {
				get {
					if (mail_jfieldId == IntPtr.Zero)
						mail_jfieldId = JNIEnv.GetFieldID (class_ref, "mail", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mail_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mail_jfieldId == IntPtr.Zero)
						mail_jfieldId = JNIEnv.GetFieldID (class_ref, "mail", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mail_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr mobileNum_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile.PrivateData']/field[@name='mobileNum']"
			[Register ("mobileNum")]
			public string MobileNum {
				get {
					if (mobileNum_jfieldId == IntPtr.Zero)
						mobileNum_jfieldId = JNIEnv.GetFieldID (class_ref, "mobileNum", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mobileNum_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mobileNum_jfieldId == IntPtr.Zero)
						mobileNum_jfieldId = JNIEnv.GetFieldID (class_ref, "mobileNum", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mobileNum_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/api/response/model/UserProfile$PrivateData", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PrivateData); }
			}

			protected PrivateData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile.PrivateData']/constructor[@name='UserProfile.PrivateData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe PrivateData (string p0, string p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					if (((object) this).GetType () != typeof (PrivateData)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static IntPtr id_ctor_Lorg_json_JSONObject_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile.PrivateData']/constructor[@name='UserProfile.PrivateData' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
			public unsafe PrivateData (global::Org.Json.JSONObject p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (PrivateData)) {
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

			static Delegate cb_addToJson_Lorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetAddToJson_Lorg_json_JSONObject_Handler ()
			{
				if (cb_addToJson_Lorg_json_JSONObject_ == null)
					cb_addToJson_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddToJson_Lorg_json_JSONObject_);
				return cb_addToJson_Lorg_json_JSONObject_;
			}

			static void n_AddToJson_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Api.Response.Model.UserProfile.PrivateData __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile.PrivateData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.AddToJson (p0);
			}
#pragma warning restore 0169

			static IntPtr id_addToJson_Lorg_json_JSONObject_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile.PrivateData']/method[@name='addToJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("addToJson", "(Lorg/json/JSONObject;)V", "GetAddToJson_Lorg_json_JSONObject_Handler")]
			public virtual unsafe void AddToJson (global::Org.Json.JSONObject p0)
			{
				if (id_addToJson_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_addToJson_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "addToJson", "(Lorg/json/JSONObject;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addToJson_Lorg_json_JSONObject_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addToJson", "(Lorg/json/JSONObject;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile.PushNotificationData']"
		[global::Android.Runtime.Register ("com/liveperson/api/response/model/UserProfile$PushNotificationData", DoNotGenerateAcw=true)]
		public partial class PushNotificationData : global::Java.Lang.Object {


			static IntPtr certName_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile.PushNotificationData']/field[@name='certName']"
			[Register ("certName")]
			public string CertName {
				get {
					if (certName_jfieldId == IntPtr.Zero)
						certName_jfieldId = JNIEnv.GetFieldID (class_ref, "certName", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, certName_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (certName_jfieldId == IntPtr.Zero)
						certName_jfieldId = JNIEnv.GetFieldID (class_ref, "certName", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, certName_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr serviceName_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile.PushNotificationData']/field[@name='serviceName']"
			[Register ("serviceName")]
			public string ServiceName {
				get {
					if (serviceName_jfieldId == IntPtr.Zero)
						serviceName_jfieldId = JNIEnv.GetFieldID (class_ref, "serviceName", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, serviceName_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (serviceName_jfieldId == IntPtr.Zero)
						serviceName_jfieldId = JNIEnv.GetFieldID (class_ref, "serviceName", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, serviceName_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr token_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile.PushNotificationData']/field[@name='token']"
			[Register ("token")]
			public string Token {
				get {
					if (token_jfieldId == IntPtr.Zero)
						token_jfieldId = JNIEnv.GetFieldID (class_ref, "token", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, token_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (token_jfieldId == IntPtr.Zero)
						token_jfieldId = JNIEnv.GetFieldID (class_ref, "token", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, token_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/api/response/model/UserProfile$PushNotificationData", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PushNotificationData); }
			}

			protected PushNotificationData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile.PushNotificationData']/constructor[@name='UserProfile.PushNotificationData' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe PushNotificationData (string p0, string p1, string p2)
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
					if (((object) this).GetType () != typeof (PushNotificationData)) {
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

			static IntPtr id_ctor_Lorg_json_JSONObject_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile.PushNotificationData']/constructor[@name='UserProfile.PushNotificationData' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
			public unsafe PushNotificationData (global::Org.Json.JSONObject p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (PushNotificationData)) {
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

			static Delegate cb_addToJson_Lorg_json_JSONObject_;
#pragma warning disable 0169
			static Delegate GetAddToJson_Lorg_json_JSONObject_Handler ()
			{
				if (cb_addToJson_Lorg_json_JSONObject_ == null)
					cb_addToJson_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddToJson_Lorg_json_JSONObject_);
				return cb_addToJson_Lorg_json_JSONObject_;
			}

			static void n_AddToJson_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Api.Response.Model.UserProfile.PushNotificationData __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile.PushNotificationData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.AddToJson (p0);
			}
#pragma warning restore 0169

			static IntPtr id_addToJson_Lorg_json_JSONObject_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile.PushNotificationData']/method[@name='addToJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("addToJson", "(Lorg/json/JSONObject;)V", "GetAddToJson_Lorg_json_JSONObject_Handler")]
			public virtual unsafe void AddToJson (global::Org.Json.JSONObject p0)
			{
				if (id_addToJson_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_addToJson_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "addToJson", "(Lorg/json/JSONObject;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addToJson_Lorg_json_JSONObject_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addToJson", "(Lorg/json/JSONObject;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile.UserType']"
		[global::Android.Runtime.Register ("com/liveperson/api/response/model/UserProfile$UserType", DoNotGenerateAcw=true)]
		public sealed partial class UserType : global::Java.Lang.Enum {


			static IntPtr AGENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile.UserType']/field[@name='AGENT']"
			[Register ("AGENT")]
			public static global::Com.Liveperson.Api.Response.Model.UserProfile.UserType Agent {
				get {
					if (AGENT_jfieldId == IntPtr.Zero)
						AGENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AGENT", "Lcom/liveperson/api/response/model/UserProfile$UserType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AGENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile.UserType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONSUMER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile.UserType']/field[@name='CONSUMER']"
			[Register ("CONSUMER")]
			public static global::Com.Liveperson.Api.Response.Model.UserProfile.UserType Consumer {
				get {
					if (CONSUMER_jfieldId == IntPtr.Zero)
						CONSUMER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONSUMER", "Lcom/liveperson/api/response/model/UserProfile$UserType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONSUMER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile.UserType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONTROLLER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile.UserType']/field[@name='CONTROLLER']"
			[Register ("CONTROLLER")]
			public static global::Com.Liveperson.Api.Response.Model.UserProfile.UserType Controller {
				get {
					if (CONTROLLER_jfieldId == IntPtr.Zero)
						CONTROLLER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTROLLER", "Lcom/liveperson/api/response/model/UserProfile$UserType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONTROLLER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile.UserType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/api/response/model/UserProfile$UserType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UserType); }
			}

			internal UserType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile.UserType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/response/model/UserProfile$UserType;", "")]
			public static unsafe global::Com.Liveperson.Api.Response.Model.UserProfile.UserType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/response/model/UserProfile$UserType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Liveperson.Api.Response.Model.UserProfile.UserType __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile.UserType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile.UserType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/liveperson/api/response/model/UserProfile$UserType;", "")]
			public static unsafe global::Com.Liveperson.Api.Response.Model.UserProfile.UserType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/api/response/model/UserProfile$UserType;");
				try {
					return (global::Com.Liveperson.Api.Response.Model.UserProfile.UserType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Api.Response.Model.UserProfile.UserType));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/response/model/UserProfile", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UserProfile); }
		}

		protected UserProfile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/constructor[@name='UserProfile' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.api.response.model.UserProfile.UserType']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/model/UserProfile$UserType;)V", "")]
		public unsafe UserProfile (string p0, string p1, global::Com.Liveperson.Api.Response.Model.UserProfile.UserType p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (UserProfile)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/model/UserProfile$UserType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/model/UserProfile$UserType;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/model/UserProfile$UserType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/constructor[@name='UserProfile' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe UserProfile (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (UserProfile)) {
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

		static Delegate cb_getAvatarUrl;
#pragma warning disable 0169
		static Delegate GetGetAvatarUrlHandler ()
		{
			if (cb_getAvatarUrl == null)
				cb_getAvatarUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAvatarUrl);
			return cb_getAvatarUrl;
		}

		static IntPtr n_GetAvatarUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AvatarUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setAvatarUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAvatarUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setAvatarUrl_Ljava_lang_String_ == null)
				cb_setAvatarUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAvatarUrl_Ljava_lang_String_);
			return cb_setAvatarUrl_Ljava_lang_String_;
		}

		static void n_SetAvatarUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AvatarUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAvatarUrl;
		static IntPtr id_setAvatarUrl_Ljava_lang_String_;
		public virtual unsafe string AvatarUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='getAvatarUrl' and count(parameter)=0]"
			[Register ("getAvatarUrl", "()Ljava/lang/String;", "GetGetAvatarUrlHandler")]
			get {
				if (id_getAvatarUrl == IntPtr.Zero)
					id_getAvatarUrl = JNIEnv.GetMethodID (class_ref, "getAvatarUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAvatarUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAvatarUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='setAvatarUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAvatarUrl", "(Ljava/lang/String;)V", "GetSetAvatarUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setAvatarUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setAvatarUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAvatarUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAvatarUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAvatarUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBackgndImgUri;
#pragma warning disable 0169
		static Delegate GetGetBackgndImgUriHandler ()
		{
			if (cb_getBackgndImgUri == null)
				cb_getBackgndImgUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBackgndImgUri);
			return cb_getBackgndImgUri;
		}

		static IntPtr n_GetBackgndImgUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BackgndImgUri);
		}
#pragma warning restore 0169

		static Delegate cb_setBackgndImgUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBackgndImgUri_Ljava_lang_String_Handler ()
		{
			if (cb_setBackgndImgUri_Ljava_lang_String_ == null)
				cb_setBackgndImgUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBackgndImgUri_Ljava_lang_String_);
			return cb_setBackgndImgUri_Ljava_lang_String_;
		}

		static void n_SetBackgndImgUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BackgndImgUri = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBackgndImgUri;
		static IntPtr id_setBackgndImgUri_Ljava_lang_String_;
		public virtual unsafe string BackgndImgUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='getBackgndImgUri' and count(parameter)=0]"
			[Register ("getBackgndImgUri", "()Ljava/lang/String;", "GetGetBackgndImgUriHandler")]
			get {
				if (id_getBackgndImgUri == IntPtr.Zero)
					id_getBackgndImgUri = JNIEnv.GetMethodID (class_ref, "getBackgndImgUri", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBackgndImgUri), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBackgndImgUri", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='setBackgndImgUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBackgndImgUri", "(Ljava/lang/String;)V", "GetSetBackgndImgUri_Ljava_lang_String_Handler")]
			set {
				if (id_setBackgndImgUri_Ljava_lang_String_ == IntPtr.Zero)
					id_setBackgndImgUri_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBackgndImgUri", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBackgndImgUri_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBackgndImgUri", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description);
		}
#pragma warning restore 0169

		static Delegate cb_setDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDescription_Ljava_lang_String_Handler ()
		{
			if (cb_setDescription_Ljava_lang_String_ == null)
				cb_setDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDescription_Ljava_lang_String_);
			return cb_setDescription_Ljava_lang_String_;
		}

		static void n_SetDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Description = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDescription;
		static IntPtr id_setDescription_Ljava_lang_String_;
		public virtual unsafe string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDescription", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='setDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDescription", "(Ljava/lang/String;)V", "GetSetDescription_Ljava_lang_String_Handler")]
			set {
				if (id_setDescription_Ljava_lang_String_ == IntPtr.Zero)
					id_setDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDescription", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDescription_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDescription", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEmail;
#pragma warning disable 0169
		static Delegate GetGetEmailHandler ()
		{
			if (cb_getEmail == null)
				cb_getEmail = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmail);
			return cb_getEmail;
		}

		static IntPtr n_GetEmail (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Email);
		}
#pragma warning restore 0169

		static Delegate cb_setEmail_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEmail_Ljava_lang_String_Handler ()
		{
			if (cb_setEmail_Ljava_lang_String_ == null)
				cb_setEmail_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEmail_Ljava_lang_String_);
			return cb_setEmail_Ljava_lang_String_;
		}

		static void n_SetEmail_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Email = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmail;
		static IntPtr id_setEmail_Ljava_lang_String_;
		public virtual unsafe string Email {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='getEmail' and count(parameter)=0]"
			[Register ("getEmail", "()Ljava/lang/String;", "GetGetEmailHandler")]
			get {
				if (id_getEmail == IntPtr.Zero)
					id_getEmail = JNIEnv.GetMethodID (class_ref, "getEmail", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEmail), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmail", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='setEmail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEmail", "(Ljava/lang/String;)V", "GetSetEmail_Ljava_lang_String_Handler")]
			set {
				if (id_setEmail_Ljava_lang_String_ == IntPtr.Zero)
					id_setEmail_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEmail", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEmail_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmail", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFirstName;
#pragma warning disable 0169
		static Delegate GetGetFirstNameHandler ()
		{
			if (cb_getFirstName == null)
				cb_getFirstName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFirstName);
			return cb_getFirstName;
		}

		static IntPtr n_GetFirstName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FirstName);
		}
#pragma warning restore 0169

		static Delegate cb_setFirstName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFirstName_Ljava_lang_String_Handler ()
		{
			if (cb_setFirstName_Ljava_lang_String_ == null)
				cb_setFirstName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFirstName_Ljava_lang_String_);
			return cb_setFirstName_Ljava_lang_String_;
		}

		static void n_SetFirstName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FirstName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFirstName;
		static IntPtr id_setFirstName_Ljava_lang_String_;
		public virtual unsafe string FirstName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='getFirstName' and count(parameter)=0]"
			[Register ("getFirstName", "()Ljava/lang/String;", "GetGetFirstNameHandler")]
			get {
				if (id_getFirstName == IntPtr.Zero)
					id_getFirstName = JNIEnv.GetMethodID (class_ref, "getFirstName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFirstName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirstName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='setFirstName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFirstName", "(Ljava/lang/String;)V", "GetSetFirstName_Ljava_lang_String_Handler")]
			set {
				if (id_setFirstName_Ljava_lang_String_ == IntPtr.Zero)
					id_setFirstName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFirstName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFirstName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFirstName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFullName;
#pragma warning disable 0169
		static Delegate GetGetFullNameHandler ()
		{
			if (cb_getFullName == null)
				cb_getFullName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFullName);
			return cb_getFullName;
		}

		static IntPtr n_GetFullName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FullName);
		}
#pragma warning restore 0169

		static IntPtr id_getFullName;
		public virtual unsafe string FullName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='getFullName' and count(parameter)=0]"
			[Register ("getFullName", "()Ljava/lang/String;", "GetGetFullNameHandler")]
			get {
				if (id_getFullName == IntPtr.Zero)
					id_getFullName = JNIEnv.GetMethodID (class_ref, "getFullName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFullName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFullName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLastName;
#pragma warning disable 0169
		static Delegate GetGetLastNameHandler ()
		{
			if (cb_getLastName == null)
				cb_getLastName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastName);
			return cb_getLastName;
		}

		static IntPtr n_GetLastName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LastName);
		}
#pragma warning restore 0169

		static Delegate cb_setLastName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLastName_Ljava_lang_String_Handler ()
		{
			if (cb_setLastName_Ljava_lang_String_ == null)
				cb_setLastName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLastName_Ljava_lang_String_);
			return cb_setLastName_Ljava_lang_String_;
		}

		static void n_SetLastName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LastName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLastName;
		static IntPtr id_setLastName_Ljava_lang_String_;
		public virtual unsafe string LastName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='getLastName' and count(parameter)=0]"
			[Register ("getLastName", "()Ljava/lang/String;", "GetGetLastNameHandler")]
			get {
				if (id_getLastName == IntPtr.Zero)
					id_getLastName = JNIEnv.GetMethodID (class_ref, "getLastName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='setLastName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLastName", "(Ljava/lang/String;)V", "GetSetLastName_Ljava_lang_String_Handler")]
			set {
				if (id_setLastName_Ljava_lang_String_ == IntPtr.Zero)
					id_setLastName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLastName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getLocalId;
#pragma warning disable 0169
		static Delegate GetGetLocalIdHandler ()
		{
			if (cb_getLocalId == null)
				cb_getLocalId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLocalId);
			return cb_getLocalId;
		}

		static long n_GetLocalId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LocalId;
		}
#pragma warning restore 0169

		static Delegate cb_setLocalId_J;
#pragma warning disable 0169
		static Delegate GetSetLocalId_JHandler ()
		{
			if (cb_setLocalId_J == null)
				cb_setLocalId_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetLocalId_J);
			return cb_setLocalId_J;
		}

		static void n_SetLocalId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LocalId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLocalId;
		static IntPtr id_setLocalId_J;
		public virtual unsafe long LocalId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='getLocalId' and count(parameter)=0]"
			[Register ("getLocalId", "()J", "GetGetLocalIdHandler")]
			get {
				if (id_getLocalId == IntPtr.Zero)
					id_getLocalId = JNIEnv.GetMethodID (class_ref, "getLocalId", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLocalId);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocalId", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='setLocalId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setLocalId", "(J)V", "GetSetLocalId_JHandler")]
			set {
				if (id_setLocalId_J == IntPtr.Zero)
					id_setLocalId_J = JNIEnv.GetMethodID (class_ref, "setLocalId", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLocalId_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocalId", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNickname;
#pragma warning disable 0169
		static Delegate GetGetNicknameHandler ()
		{
			if (cb_getNickname == null)
				cb_getNickname = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNickname);
			return cb_getNickname;
		}

		static IntPtr n_GetNickname (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Nickname);
		}
#pragma warning restore 0169

		static Delegate cb_setNickname_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNickname_Ljava_lang_String_Handler ()
		{
			if (cb_setNickname_Ljava_lang_String_ == null)
				cb_setNickname_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNickname_Ljava_lang_String_);
			return cb_setNickname_Ljava_lang_String_;
		}

		static void n_SetNickname_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Nickname = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNickname;
		static IntPtr id_setNickname_Ljava_lang_String_;
		public virtual unsafe string Nickname {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='getNickname' and count(parameter)=0]"
			[Register ("getNickname", "()Ljava/lang/String;", "GetGetNicknameHandler")]
			get {
				if (id_getNickname == IntPtr.Zero)
					id_getNickname = JNIEnv.GetMethodID (class_ref, "getNickname", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNickname), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNickname", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='setNickname' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNickname", "(Ljava/lang/String;)V", "GetSetNickname_Ljava_lang_String_Handler")]
			set {
				if (id_setNickname_Ljava_lang_String_ == IntPtr.Zero)
					id_setNickname_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNickname", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNickname_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNickname", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getOriginatorId;
#pragma warning disable 0169
		static Delegate GetGetOriginatorIdHandler ()
		{
			if (cb_getOriginatorId == null)
				cb_getOriginatorId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOriginatorId);
			return cb_getOriginatorId;
		}

		static IntPtr n_GetOriginatorId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OriginatorId);
		}
#pragma warning restore 0169

		static IntPtr id_getOriginatorId;
		public virtual unsafe string OriginatorId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='getOriginatorId' and count(parameter)=0]"
			[Register ("getOriginatorId", "()Ljava/lang/String;", "GetGetOriginatorIdHandler")]
			get {
				if (id_getOriginatorId == IntPtr.Zero)
					id_getOriginatorId = JNIEnv.GetMethodID (class_ref, "getOriginatorId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOriginatorId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOriginatorId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestId;
#pragma warning disable 0169
		static Delegate GetGetRequestIdHandler ()
		{
			if (cb_getRequestId == null)
				cb_getRequestId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetRequestId);
			return cb_getRequestId;
		}

		static long n_GetRequestId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequestId;
		}
#pragma warning restore 0169

		static Delegate cb_setRequestId_J;
#pragma warning disable 0169
		static Delegate GetSetRequestId_JHandler ()
		{
			if (cb_setRequestId_J == null)
				cb_setRequestId_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetRequestId_J);
			return cb_setRequestId_J;
		}

		static void n_SetRequestId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRequestId;
		static IntPtr id_setRequestId_J;
		public virtual unsafe long RequestId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='getRequestId' and count(parameter)=0]"
			[Register ("getRequestId", "()J", "GetGetRequestIdHandler")]
			get {
				if (id_getRequestId == IntPtr.Zero)
					id_getRequestId = JNIEnv.GetMethodID (class_ref, "getRequestId", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getRequestId);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestId", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='setRequestId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setRequestId", "(J)V", "GetSetRequestId_JHandler")]
			set {
				if (id_setRequestId_J == IntPtr.Zero)
					id_setRequestId_J = JNIEnv.GetMethodID (class_ref, "setRequestId", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRequestId_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequestId", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRole;
#pragma warning disable 0169
		static Delegate GetGetRoleHandler ()
		{
			if (cb_getRole == null)
				cb_getRole = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRole);
			return cb_getRole;
		}

		static IntPtr n_GetRole (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Role);
		}
#pragma warning restore 0169

		static Delegate cb_setRole_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRole_Ljava_lang_String_Handler ()
		{
			if (cb_setRole_Ljava_lang_String_ == null)
				cb_setRole_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRole_Ljava_lang_String_);
			return cb_setRole_Ljava_lang_String_;
		}

		static void n_SetRole_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Role = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRole;
		static IntPtr id_setRole_Ljava_lang_String_;
		public virtual unsafe string Role {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='getRole' and count(parameter)=0]"
			[Register ("getRole", "()Ljava/lang/String;", "GetGetRoleHandler")]
			get {
				if (id_getRole == IntPtr.Zero)
					id_getRole = JNIEnv.GetMethodID (class_ref, "getRole", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRole), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRole", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='setRole' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRole", "(Ljava/lang/String;)V", "GetSetRole_Ljava_lang_String_Handler")]
			set {
				if (id_setRole_Ljava_lang_String_ == IntPtr.Zero)
					id_setRole_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRole", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRole_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRole", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_addToJson_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetAddToJson_Lorg_json_JSONObject_Handler ()
		{
			if (cb_addToJson_Lorg_json_JSONObject_ == null)
				cb_addToJson_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddToJson_Lorg_json_JSONObject_);
			return cb_addToJson_Lorg_json_JSONObject_;
		}

		static void n_AddToJson_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddToJson (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addToJson_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='addToJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("addToJson", "(Lorg/json/JSONObject;)V", "GetAddToJson_Lorg_json_JSONObject_Handler")]
		public virtual unsafe void AddToJson (global::Org.Json.JSONObject p0)
		{
			if (id_addToJson_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_addToJson_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "addToJson", "(Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addToJson_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addToJson", "(Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getPrivateData;
#pragma warning disable 0169
		static Delegate GetGetPrivateDataHandler ()
		{
			if (cb_getPrivateData == null)
				cb_getPrivateData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrivateData);
			return cb_getPrivateData;
		}

		static IntPtr n_GetPrivateData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetPrivateData ());
		}
#pragma warning restore 0169

		static IntPtr id_getPrivateData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='getPrivateData' and count(parameter)=0]"
		[Register ("getPrivateData", "()Lcom/liveperson/api/response/model/UserProfile$PrivateData;", "GetGetPrivateDataHandler")]
		public virtual unsafe global::Com.Liveperson.Api.Response.Model.UserProfile.PrivateData GetPrivateData ()
		{
			if (id_getPrivateData == IntPtr.Zero)
				id_getPrivateData = JNIEnv.GetMethodID (class_ref, "getPrivateData", "()Lcom/liveperson/api/response/model/UserProfile$PrivateData;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile.PrivateData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrivateData), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile.PrivateData> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrivateData", "()Lcom/liveperson/api/response/model/UserProfile$PrivateData;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getUserType;
#pragma warning disable 0169
		static Delegate GetGetUserTypeHandler ()
		{
			if (cb_getUserType == null)
				cb_getUserType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserType);
			return cb_getUserType;
		}

		static IntPtr n_GetUserType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetUserType ());
		}
#pragma warning restore 0169

		static IntPtr id_getUserType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='getUserType' and count(parameter)=0]"
		[Register ("getUserType", "()Lcom/liveperson/api/response/model/UserProfile$UserType;", "GetGetUserTypeHandler")]
		public virtual unsafe global::Com.Liveperson.Api.Response.Model.UserProfile.UserType GetUserType ()
		{
			if (id_getUserType == IntPtr.Zero)
				id_getUserType = JNIEnv.GetMethodID (class_ref, "getUserType", "()Lcom/liveperson/api/response/model/UserProfile$UserType;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile.UserType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile.UserType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserType", "()Lcom/liveperson/api/response/model/UserProfile$UserType;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMobileNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMobileNumber_Ljava_lang_String_Handler ()
		{
			if (cb_setMobileNumber_Ljava_lang_String_ == null)
				cb_setMobileNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMobileNumber_Ljava_lang_String_);
			return cb_setMobileNumber_Ljava_lang_String_;
		}

		static void n_SetMobileNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMobileNumber (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMobileNumber_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='setMobileNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMobileNumber", "(Ljava/lang/String;)V", "GetSetMobileNumber_Ljava_lang_String_Handler")]
		public virtual unsafe void SetMobileNumber (string p0)
		{
			if (id_setMobileNumber_Ljava_lang_String_ == IntPtr.Zero)
				id_setMobileNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMobileNumber", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMobileNumber_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMobileNumber", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setOriginatorID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOriginatorID_Ljava_lang_String_Handler ()
		{
			if (cb_setOriginatorID_Ljava_lang_String_ == null)
				cb_setOriginatorID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOriginatorID_Ljava_lang_String_);
			return cb_setOriginatorID_Ljava_lang_String_;
		}

		static void n_SetOriginatorID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOriginatorID (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOriginatorID_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='setOriginatorID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setOriginatorID", "(Ljava/lang/String;)V", "GetSetOriginatorID_Ljava_lang_String_Handler")]
		public virtual unsafe void SetOriginatorID (string p0)
		{
			if (id_setOriginatorID_Ljava_lang_String_ == IntPtr.Zero)
				id_setOriginatorID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOriginatorID", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOriginatorID_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOriginatorID", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setPrivateData_Lcom_liveperson_api_response_model_UserProfile_PrivateData_;
#pragma warning disable 0169
		static Delegate GetSetPrivateData_Lcom_liveperson_api_response_model_UserProfile_PrivateData_Handler ()
		{
			if (cb_setPrivateData_Lcom_liveperson_api_response_model_UserProfile_PrivateData_ == null)
				cb_setPrivateData_Lcom_liveperson_api_response_model_UserProfile_PrivateData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPrivateData_Lcom_liveperson_api_response_model_UserProfile_PrivateData_);
			return cb_setPrivateData_Lcom_liveperson_api_response_model_UserProfile_PrivateData_;
		}

		static void n_SetPrivateData_Lcom_liveperson_api_response_model_UserProfile_PrivateData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Response.Model.UserProfile.PrivateData p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile.PrivateData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPrivateData (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPrivateData_Lcom_liveperson_api_response_model_UserProfile_PrivateData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='setPrivateData' and count(parameter)=1 and parameter[1][@type='com.liveperson.api.response.model.UserProfile.PrivateData']]"
		[Register ("setPrivateData", "(Lcom/liveperson/api/response/model/UserProfile$PrivateData;)V", "GetSetPrivateData_Lcom_liveperson_api_response_model_UserProfile_PrivateData_Handler")]
		public virtual unsafe void SetPrivateData (global::Com.Liveperson.Api.Response.Model.UserProfile.PrivateData p0)
		{
			if (id_setPrivateData_Lcom_liveperson_api_response_model_UserProfile_PrivateData_ == IntPtr.Zero)
				id_setPrivateData_Lcom_liveperson_api_response_model_UserProfile_PrivateData_ = JNIEnv.GetMethodID (class_ref, "setPrivateData", "(Lcom/liveperson/api/response/model/UserProfile$PrivateData;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPrivateData_Lcom_liveperson_api_response_model_UserProfile_PrivateData_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPrivateData", "(Lcom/liveperson/api/response/model/UserProfile$PrivateData;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setUserType_Lcom_liveperson_api_response_model_UserProfile_UserType_;
#pragma warning disable 0169
		static Delegate GetSetUserType_Lcom_liveperson_api_response_model_UserProfile_UserType_Handler ()
		{
			if (cb_setUserType_Lcom_liveperson_api_response_model_UserProfile_UserType_ == null)
				cb_setUserType_Lcom_liveperson_api_response_model_UserProfile_UserType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserType_Lcom_liveperson_api_response_model_UserProfile_UserType_);
			return cb_setUserType_Lcom_liveperson_api_response_model_UserProfile_UserType_;
		}

		static void n_SetUserType_Lcom_liveperson_api_response_model_UserProfile_UserType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Api.Response.Model.UserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Response.Model.UserProfile.UserType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile.UserType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetUserType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setUserType_Lcom_liveperson_api_response_model_UserProfile_UserType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='UserProfile']/method[@name='setUserType' and count(parameter)=1 and parameter[1][@type='com.liveperson.api.response.model.UserProfile.UserType']]"
		[Register ("setUserType", "(Lcom/liveperson/api/response/model/UserProfile$UserType;)V", "GetSetUserType_Lcom_liveperson_api_response_model_UserProfile_UserType_Handler")]
		public virtual unsafe void SetUserType (global::Com.Liveperson.Api.Response.Model.UserProfile.UserType p0)
		{
			if (id_setUserType_Lcom_liveperson_api_response_model_UserProfile_UserType_ == IntPtr.Zero)
				id_setUserType_Lcom_liveperson_api_response_model_UserProfile_UserType_ = JNIEnv.GetMethodID (class_ref, "setUserType", "(Lcom/liveperson/api/response/model/UserProfile$UserType;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserType_Lcom_liveperson_api_response_model_UserProfile_UserType_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserType", "(Lcom/liveperson/api/response/model/UserProfile$UserType;)V"), __args);
			} finally {
			}
		}

	}
}
