using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Network.Http.Requests {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='PushRequest']"
	[global::Android.Runtime.Register ("com/liveperson/infra/network/http/requests/PushRequest", DoNotGenerateAcw=true)]
	public partial class PushRequest : global::Java.Lang.Object, global::Com.Liveperson.Infra.ICommand {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='PushRequest']/field[@name='KEY_APP_ID']"
		[Register ("KEY_APP_ID")]
		protected const string KeyAppId = (string) "appId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='PushRequest']/field[@name='KEY_DEVICE_ID']"
		[Register ("KEY_DEVICE_ID")]
		protected const string KeyDeviceId = (string) "deviceId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='PushRequest']/field[@name='KEY_PLATFORM']"
		[Register ("KEY_PLATFORM")]
		protected const string KeyPlatform = (string) "platform";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='PushRequest']/field[@name='KEY_REGISTRATION_ID']"
		[Register ("KEY_REGISTRATION_ID")]
		protected const string KeyRegistrationId = (string) "pnToken";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='PushRequest']/field[@name='KEY_TOKEN_ID']"
		[Register ("KEY_TOKEN_ID")]
		protected const string KeyTokenId = (string) "jwt";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='PushRequest']/field[@name='KEY_USER_ID']"
		[Register ("KEY_USER_ID")]
		protected const string KeyUserId = (string) "lpid";

		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='PushRequest']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr mAppId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='PushRequest']/field[@name='mAppId']"
		[Register ("mAppId")]
		protected string MAppId {
			get {
				if (mAppId_jfieldId == IntPtr.Zero)
					mAppId_jfieldId = JNIEnv.GetFieldID (class_ref, "mAppId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAppId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAppId_jfieldId == IntPtr.Zero)
					mAppId_jfieldId = JNIEnv.GetFieldID (class_ref, "mAppId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAppId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCallback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='PushRequest']/field[@name='mCallback']"
		[Register ("mCallback")]
		protected global::Com.Liveperson.Infra.ICallback MCallback {
			get {
				if (mCallback_jfieldId == IntPtr.Zero)
					mCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mCallback", "Lcom/liveperson/infra/ICallback;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCallback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCallback_jfieldId == IntPtr.Zero)
					mCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mCallback", "Lcom/liveperson/infra/ICallback;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCallback_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCertificates_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='PushRequest']/field[@name='mCertificates']"
		[Register ("mCertificates")]
		protected global::System.Collections.IList MCertificates {
			get {
				if (mCertificates_jfieldId == IntPtr.Zero)
					mCertificates_jfieldId = JNIEnv.GetFieldID (class_ref, "mCertificates", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCertificates_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCertificates_jfieldId == IntPtr.Zero)
					mCertificates_jfieldId = JNIEnv.GetFieldID (class_ref, "mCertificates", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCertificates_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mDeviceId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='PushRequest']/field[@name='mDeviceId']"
		[Register ("mDeviceId")]
		protected string MDeviceId {
			get {
				if (mDeviceId_jfieldId == IntPtr.Zero)
					mDeviceId_jfieldId = JNIEnv.GetFieldID (class_ref, "mDeviceId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mDeviceId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDeviceId_jfieldId == IntPtr.Zero)
					mDeviceId_jfieldId = JNIEnv.GetFieldID (class_ref, "mDeviceId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mDeviceId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mGcmRegistrationId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='PushRequest']/field[@name='mGcmRegistrationId']"
		[Register ("mGcmRegistrationId")]
		protected string MGcmRegistrationId {
			get {
				if (mGcmRegistrationId_jfieldId == IntPtr.Zero)
					mGcmRegistrationId_jfieldId = JNIEnv.GetFieldID (class_ref, "mGcmRegistrationId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mGcmRegistrationId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mGcmRegistrationId_jfieldId == IntPtr.Zero)
					mGcmRegistrationId_jfieldId = JNIEnv.GetFieldID (class_ref, "mGcmRegistrationId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mGcmRegistrationId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mPlatform_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='PushRequest']/field[@name='mPlatform']"
		[Register ("mPlatform")]
		protected string MPlatform {
			get {
				if (mPlatform_jfieldId == IntPtr.Zero)
					mPlatform_jfieldId = JNIEnv.GetFieldID (class_ref, "mPlatform", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mPlatform_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPlatform_jfieldId == IntPtr.Zero)
					mPlatform_jfieldId = JNIEnv.GetFieldID (class_ref, "mPlatform", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mPlatform_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mPusherURL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='PushRequest']/field[@name='mPusherURL']"
		[Register ("mPusherURL")]
		protected string MPusherURL {
			get {
				if (mPusherURL_jfieldId == IntPtr.Zero)
					mPusherURL_jfieldId = JNIEnv.GetFieldID (class_ref, "mPusherURL", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mPusherURL_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPusherURL_jfieldId == IntPtr.Zero)
					mPusherURL_jfieldId = JNIEnv.GetFieldID (class_ref, "mPusherURL", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mPusherURL_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mTokenId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='PushRequest']/field[@name='mTokenId']"
		[Register ("mTokenId")]
		protected string MTokenId {
			get {
				if (mTokenId_jfieldId == IntPtr.Zero)
					mTokenId_jfieldId = JNIEnv.GetFieldID (class_ref, "mTokenId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mTokenId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTokenId_jfieldId == IntPtr.Zero)
					mTokenId_jfieldId = JNIEnv.GetFieldID (class_ref, "mTokenId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mTokenId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mUserId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='PushRequest']/field[@name='mUserId']"
		[Register ("mUserId")]
		protected string MUserId {
			get {
				if (mUserId_jfieldId == IntPtr.Zero)
					mUserId_jfieldId = JNIEnv.GetFieldID (class_ref, "mUserId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mUserId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mUserId_jfieldId == IntPtr.Zero)
					mUserId_jfieldId = JNIEnv.GetFieldID (class_ref, "mUserId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mUserId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/network/http/requests/PushRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushRequest); }
		}

		protected PushRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='PushRequest']/constructor[@name='PushRequest' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V", "")]
		public unsafe PushRequest (string p0, string p1, string p2, string p3, string p4, global::System.Collections.Generic.IList<string> p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				if (((object) this).GetType () != typeof (PushRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
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
			global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Body);
		}
#pragma warning restore 0169

		static IntPtr id_getBody;
		protected virtual unsafe global::Org.Json.JSONObject Body {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='PushRequest']/method[@name='getBody' and count(parameter)=0]"
			[Register ("getBody", "()Lorg/json/JSONObject;", "GetGetBodyHandler")]
			get {
				if (id_getBody == IntPtr.Zero)
					id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()Lorg/json/JSONObject;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBody), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBody", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_execute;
#pragma warning disable 0169
		static Delegate GetExecuteHandler ()
		{
			if (cb_execute == null)
				cb_execute = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Execute);
			return cb_execute;
		}

		static void n_Execute (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		static IntPtr id_execute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='PushRequest']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()V", "GetExecuteHandler")]
		public virtual unsafe void Execute ()
		{
			if (id_execute == IntPtr.Zero)
				id_execute = JNIEnv.GetMethodID (class_ref, "execute", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_execute);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "()V"));
			} finally {
			}
		}

		static Delegate cb_handleError_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetHandleError_Ljava_lang_Exception_Handler ()
		{
			if (cb_handleError_Ljava_lang_Exception_ == null)
				cb_handleError_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleError_Ljava_lang_Exception_);
			return cb_handleError_Ljava_lang_Exception_;
		}

		static void n_HandleError_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleError (p0);
		}
#pragma warning restore 0169

		static IntPtr id_handleError_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='PushRequest']/method[@name='handleError' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("handleError", "(Ljava/lang/Exception;)V", "GetHandleError_Ljava_lang_Exception_Handler")]
		protected virtual unsafe void HandleError (global::Java.Lang.Exception p0)
		{
			if (id_handleError_Ljava_lang_Exception_ == IntPtr.Zero)
				id_handleError_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "handleError", "(Ljava/lang/Exception;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleError_Ljava_lang_Exception_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleError", "(Ljava/lang/Exception;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_handleResponse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHandleResponse_Ljava_lang_String_Handler ()
		{
			if (cb_handleResponse_Ljava_lang_String_ == null)
				cb_handleResponse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleResponse_Ljava_lang_String_);
			return cb_handleResponse_Ljava_lang_String_;
		}

		static void n_HandleResponse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleResponse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_handleResponse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='PushRequest']/method[@name='handleResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("handleResponse", "(Ljava/lang/String;)V", "GetHandleResponse_Ljava_lang_String_Handler")]
		protected virtual unsafe void HandleResponse (string p0)
		{
			if (id_handleResponse_Ljava_lang_String_ == IntPtr.Zero)
				id_handleResponse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "handleResponse", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleResponse_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleResponse", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setAppId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppId_Ljava_lang_String_Handler ()
		{
			if (cb_setAppId_Ljava_lang_String_ == null)
				cb_setAppId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAppId_Ljava_lang_String_);
			return cb_setAppId_Ljava_lang_String_;
		}

		static IntPtr n_SetAppId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAppId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setAppId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='PushRequest']/method[@name='setAppId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAppId", "(Ljava/lang/String;)Lcom/liveperson/infra/network/http/requests/PushRequest;", "GetSetAppId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest SetAppId (string p0)
		{
			if (id_setAppId_Ljava_lang_String_ == IntPtr.Zero)
				id_setAppId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppId", "(Ljava/lang/String;)Lcom/liveperson/infra/network/http/requests/PushRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAppId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppId", "(Ljava/lang/String;)Lcom/liveperson/infra/network/http/requests/PushRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setCallback_Lcom_liveperson_infra_ICallback_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lcom_liveperson_infra_ICallback_Handler ()
		{
			if (cb_setCallback_Lcom_liveperson_infra_ICallback_ == null)
				cb_setCallback_Lcom_liveperson_infra_ICallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCallback_Lcom_liveperson_infra_ICallback_);
			return cb_setCallback_Lcom_liveperson_infra_ICallback_;
		}

		static IntPtr n_SetCallback_Lcom_liveperson_infra_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ICallback p0 = (global::Com.Liveperson.Infra.ICallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCallback (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setCallback_Lcom_liveperson_infra_ICallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='PushRequest']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.ICallback&lt;java.lang.Void, java.lang.Exception&gt;']]"
		[Register ("setCallback", "(Lcom/liveperson/infra/ICallback;)Lcom/liveperson/infra/network/http/requests/PushRequest;", "GetSetCallback_Lcom_liveperson_infra_ICallback_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest SetCallback (global::Com.Liveperson.Infra.ICallback p0)
		{
			if (id_setCallback_Lcom_liveperson_infra_ICallback_ == IntPtr.Zero)
				id_setCallback_Lcom_liveperson_infra_ICallback_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lcom/liveperson/infra/ICallback;)Lcom/liveperson/infra/network/http/requests/PushRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCallback_Lcom_liveperson_infra_ICallback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallback", "(Lcom/liveperson/infra/ICallback;)Lcom/liveperson/infra/network/http/requests/PushRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setDeviceId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceId_Ljava_lang_String_Handler ()
		{
			if (cb_setDeviceId_Ljava_lang_String_ == null)
				cb_setDeviceId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDeviceId_Ljava_lang_String_);
			return cb_setDeviceId_Ljava_lang_String_;
		}

		static IntPtr n_SetDeviceId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDeviceId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setDeviceId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='PushRequest']/method[@name='setDeviceId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDeviceId", "(Ljava/lang/String;)Lcom/liveperson/infra/network/http/requests/PushRequest;", "GetSetDeviceId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest SetDeviceId (string p0)
		{
			if (id_setDeviceId_Ljava_lang_String_ == IntPtr.Zero)
				id_setDeviceId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDeviceId", "(Ljava/lang/String;)Lcom/liveperson/infra/network/http/requests/PushRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDeviceId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDeviceId", "(Ljava/lang/String;)Lcom/liveperson/infra/network/http/requests/PushRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setPlatform_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPlatform_Ljava_lang_String_Handler ()
		{
			if (cb_setPlatform_Ljava_lang_String_ == null)
				cb_setPlatform_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPlatform_Ljava_lang_String_);
			return cb_setPlatform_Ljava_lang_String_;
		}

		static IntPtr n_SetPlatform_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPlatform (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setPlatform_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='PushRequest']/method[@name='setPlatform' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPlatform", "(Ljava/lang/String;)Lcom/liveperson/infra/network/http/requests/PushRequest;", "GetSetPlatform_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest SetPlatform (string p0)
		{
			if (id_setPlatform_Ljava_lang_String_ == IntPtr.Zero)
				id_setPlatform_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPlatform", "(Ljava/lang/String;)Lcom/liveperson/infra/network/http/requests/PushRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPlatform_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Requests.PushRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPlatform", "(Ljava/lang/String;)Lcom/liveperson/infra/network/http/requests/PushRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
