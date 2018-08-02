using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingUserProfile']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/model/MessagingUserProfile", DoNotGenerateAcw=true)]
	public partial class MessagingUserProfile : global::Com.Liveperson.Api.Response.Model.UserProfile {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/model/MessagingUserProfile", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessagingUserProfile); }
		}

		protected MessagingUserProfile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingUserProfile']/constructor[@name='MessagingUserProfile' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.api.response.model.UserProfile.UserType']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/model/UserProfile$UserType;)V", "")]
		public unsafe MessagingUserProfile (string p0, string p1, global::Com.Liveperson.Api.Response.Model.UserProfile.UserType p2)
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
				if (((object) this).GetType () != typeof (MessagingUserProfile)) {
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

		static IntPtr id_ctor_Lcom_liveperson_api_response_model_UserProfile_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingUserProfile']/constructor[@name='MessagingUserProfile' and count(parameter)=1 and parameter[1][@type='com.liveperson.api.response.model.UserProfile']]"
		[Register (".ctor", "(Lcom/liveperson/api/response/model/UserProfile;)V", "")]
		public unsafe MessagingUserProfile (global::Com.Liveperson.Api.Response.Model.UserProfile p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MessagingUserProfile)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/api/response/model/UserProfile;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/api/response/model/UserProfile;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_api_response_model_UserProfile_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_api_response_model_UserProfile_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/api/response/model/UserProfile;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_api_response_model_UserProfile_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_api_response_model_UserProfile_, __args);
			} finally {
			}
		}

		static Delegate cb_getBrandId;
#pragma warning disable 0169
		static Delegate GetGetBrandIdHandler ()
		{
			if (cb_getBrandId == null)
				cb_getBrandId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBrandId);
			return cb_getBrandId;
		}

		static IntPtr n_GetBrandId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.MessagingUserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingUserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BrandId);
		}
#pragma warning restore 0169

		static IntPtr id_getBrandId;
		public virtual unsafe string BrandId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingUserProfile']/method[@name='getBrandId' and count(parameter)=0]"
			[Register ("getBrandId", "()Ljava/lang/String;", "GetGetBrandIdHandler")]
			get {
				if (id_getBrandId == IntPtr.Zero)
					id_getBrandId = JNIEnv.GetMethodID (class_ref, "getBrandId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBrandId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBrandId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isEmptyUser;
#pragma warning disable 0169
		static Delegate GetIsEmptyUserHandler ()
		{
			if (cb_isEmptyUser == null)
				cb_isEmptyUser = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEmptyUser);
			return cb_isEmptyUser;
		}

		static bool n_IsEmptyUser (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.MessagingUserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingUserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmptyUser;
		}
#pragma warning restore 0169

		static IntPtr id_isEmptyUser;
		public virtual unsafe bool IsEmptyUser {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingUserProfile']/method[@name='isEmptyUser' and count(parameter)=0]"
			[Register ("isEmptyUser", "()Z", "GetIsEmptyUserHandler")]
			get {
				if (id_isEmptyUser == IntPtr.Zero)
					id_isEmptyUser = JNIEnv.GetMethodID (class_ref, "isEmptyUser", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEmptyUser);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEmptyUser", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getUserEncryptionVersion;
#pragma warning disable 0169
		static Delegate GetGetUserEncryptionVersionHandler ()
		{
			if (cb_getUserEncryptionVersion == null)
				cb_getUserEncryptionVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserEncryptionVersion);
			return cb_getUserEncryptionVersion;
		}

		static IntPtr n_GetUserEncryptionVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.MessagingUserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingUserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UserEncryptionVersion);
		}
#pragma warning restore 0169

		static Delegate cb_setUserEncryptionVersion_Lcom_liveperson_infra_utils_EncryptionVersion_;
#pragma warning disable 0169
		static Delegate GetSetUserEncryptionVersion_Lcom_liveperson_infra_utils_EncryptionVersion_Handler ()
		{
			if (cb_setUserEncryptionVersion_Lcom_liveperson_infra_utils_EncryptionVersion_ == null)
				cb_setUserEncryptionVersion_Lcom_liveperson_infra_utils_EncryptionVersion_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserEncryptionVersion_Lcom_liveperson_infra_utils_EncryptionVersion_);
			return cb_setUserEncryptionVersion_Lcom_liveperson_infra_utils_EncryptionVersion_;
		}

		static void n_SetUserEncryptionVersion_Lcom_liveperson_infra_utils_EncryptionVersion_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.MessagingUserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingUserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Utils.EncryptionVersion p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.EncryptionVersion> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserEncryptionVersion = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserEncryptionVersion;
		static IntPtr id_setUserEncryptionVersion_Lcom_liveperson_infra_utils_EncryptionVersion_;
		public virtual unsafe global::Com.Liveperson.Infra.Utils.EncryptionVersion UserEncryptionVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingUserProfile']/method[@name='getUserEncryptionVersion' and count(parameter)=0]"
			[Register ("getUserEncryptionVersion", "()Lcom/liveperson/infra/utils/EncryptionVersion;", "GetGetUserEncryptionVersionHandler")]
			get {
				if (id_getUserEncryptionVersion == IntPtr.Zero)
					id_getUserEncryptionVersion = JNIEnv.GetMethodID (class_ref, "getUserEncryptionVersion", "()Lcom/liveperson/infra/utils/EncryptionVersion;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.EncryptionVersion> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserEncryptionVersion), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.EncryptionVersion> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserEncryptionVersion", "()Lcom/liveperson/infra/utils/EncryptionVersion;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingUserProfile']/method[@name='setUserEncryptionVersion' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.utils.EncryptionVersion']]"
			[Register ("setUserEncryptionVersion", "(Lcom/liveperson/infra/utils/EncryptionVersion;)V", "GetSetUserEncryptionVersion_Lcom_liveperson_infra_utils_EncryptionVersion_Handler")]
			set {
				if (id_setUserEncryptionVersion_Lcom_liveperson_infra_utils_EncryptionVersion_ == IntPtr.Zero)
					id_setUserEncryptionVersion_Lcom_liveperson_infra_utils_EncryptionVersion_ = JNIEnv.GetMethodID (class_ref, "setUserEncryptionVersion", "(Lcom/liveperson/infra/utils/EncryptionVersion;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserEncryptionVersion_Lcom_liveperson_infra_utils_EncryptionVersion_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserEncryptionVersion", "(Lcom/liveperson/infra/utils/EncryptionVersion;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_setBrandID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBrandID_Ljava_lang_String_Handler ()
		{
			if (cb_setBrandID_Ljava_lang_String_ == null)
				cb_setBrandID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBrandID_Ljava_lang_String_);
			return cb_setBrandID_Ljava_lang_String_;
		}

		static void n_SetBrandID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.MessagingUserProfile __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingUserProfile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBrandID (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBrandID_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingUserProfile']/method[@name='setBrandID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setBrandID", "(Ljava/lang/String;)V", "GetSetBrandID_Ljava_lang_String_Handler")]
		public virtual unsafe void SetBrandID (string p0)
		{
			if (id_setBrandID_Ljava_lang_String_ == IntPtr.Zero)
				id_setBrandID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBrandID", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBrandID_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBrandID", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
