using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPAuthenticationParams']"
	[global::Android.Runtime.Register ("com/liveperson/infra/LPAuthenticationParams", DoNotGenerateAcw=true)]
	public partial class LPAuthenticationParams : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPAuthenticationParams']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPAuthenticationParams.LPAuthenticationType']"
		[global::Android.Runtime.Register ("com/liveperson/infra/LPAuthenticationParams$LPAuthenticationType", DoNotGenerateAcw=true)]
		public sealed partial class LPAuthenticationType : global::Java.Lang.Enum {


			static IntPtr AUTH_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPAuthenticationParams.LPAuthenticationType']/field[@name='AUTH']"
			[Register ("AUTH")]
			public static global::Com.Liveperson.Infra.LPAuthenticationParams.LPAuthenticationType Auth {
				get {
					if (AUTH_jfieldId == IntPtr.Zero)
						AUTH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTH", "Lcom/liveperson/infra/LPAuthenticationParams$LPAuthenticationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTH_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams.LPAuthenticationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SIGN_UP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPAuthenticationParams.LPAuthenticationType']/field[@name='SIGN_UP']"
			[Register ("SIGN_UP")]
			public static global::Com.Liveperson.Infra.LPAuthenticationParams.LPAuthenticationType SignUp {
				get {
					if (SIGN_UP_jfieldId == IntPtr.Zero)
						SIGN_UP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIGN_UP", "Lcom/liveperson/infra/LPAuthenticationParams$LPAuthenticationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SIGN_UP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams.LPAuthenticationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UN_AUTH_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPAuthenticationParams.LPAuthenticationType']/field[@name='UN_AUTH']"
			[Register ("UN_AUTH")]
			public static global::Com.Liveperson.Infra.LPAuthenticationParams.LPAuthenticationType UnAuth {
				get {
					if (UN_AUTH_jfieldId == IntPtr.Zero)
						UN_AUTH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UN_AUTH", "Lcom/liveperson/infra/LPAuthenticationParams$LPAuthenticationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UN_AUTH_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams.LPAuthenticationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/LPAuthenticationParams$LPAuthenticationType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LPAuthenticationType); }
			}

			internal LPAuthenticationType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPAuthenticationParams.LPAuthenticationType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/LPAuthenticationParams$LPAuthenticationType;", "")]
			public static unsafe global::Com.Liveperson.Infra.LPAuthenticationParams.LPAuthenticationType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/LPAuthenticationParams$LPAuthenticationType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Liveperson.Infra.LPAuthenticationParams.LPAuthenticationType __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams.LPAuthenticationType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPAuthenticationParams.LPAuthenticationType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/liveperson/infra/LPAuthenticationParams$LPAuthenticationType;", "")]
			public static unsafe global::Com.Liveperson.Infra.LPAuthenticationParams.LPAuthenticationType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/infra/LPAuthenticationParams$LPAuthenticationType;");
				try {
					return (global::Com.Liveperson.Infra.LPAuthenticationParams.LPAuthenticationType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Infra.LPAuthenticationParams.LPAuthenticationType));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/LPAuthenticationParams", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LPAuthenticationParams); }
		}

		protected LPAuthenticationParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPAuthenticationParams']/constructor[@name='LPAuthenticationParams' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe LPAuthenticationParams (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (LPAuthenticationParams)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/os/Parcel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Parcel;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
					id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Parcel_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_liveperson_infra_LPAuthenticationParams_LPAuthenticationType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPAuthenticationParams']/constructor[@name='LPAuthenticationParams' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.LPAuthenticationParams.LPAuthenticationType']]"
		[Register (".ctor", "(Lcom/liveperson/infra/LPAuthenticationParams$LPAuthenticationType;)V", "")]
		public unsafe LPAuthenticationParams (global::Com.Liveperson.Infra.LPAuthenticationParams.LPAuthenticationType p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (LPAuthenticationParams)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/infra/LPAuthenticationParams$LPAuthenticationType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/infra/LPAuthenticationParams$LPAuthenticationType;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_infra_LPAuthenticationParams_LPAuthenticationType_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_infra_LPAuthenticationParams_LPAuthenticationType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/LPAuthenticationParams$LPAuthenticationType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_LPAuthenticationParams_LPAuthenticationType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_LPAuthenticationParams_LPAuthenticationType_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPAuthenticationParams']/constructor[@name='LPAuthenticationParams' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LPAuthenticationParams ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LPAuthenticationParams)) {
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

		static Delegate cb_getAuthKey;
#pragma warning disable 0169
		static Delegate GetGetAuthKeyHandler ()
		{
			if (cb_getAuthKey == null)
				cb_getAuthKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthKey);
			return cb_getAuthKey;
		}

		static IntPtr n_GetAuthKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.LPAuthenticationParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthKey);
		}
#pragma warning restore 0169

		static IntPtr id_getAuthKey;
		public virtual unsafe string AuthKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPAuthenticationParams']/method[@name='getAuthKey' and count(parameter)=0]"
			[Register ("getAuthKey", "()Ljava/lang/String;", "GetGetAuthKeyHandler")]
			get {
				if (id_getAuthKey == IntPtr.Zero)
					id_getAuthKey = JNIEnv.GetMethodID (class_ref, "getAuthKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAuthType;
#pragma warning disable 0169
		static Delegate GetGetAuthTypeHandler ()
		{
			if (cb_getAuthType == null)
				cb_getAuthType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthType);
			return cb_getAuthType;
		}

		static IntPtr n_GetAuthType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.LPAuthenticationParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AuthType);
		}
#pragma warning restore 0169

		static IntPtr id_getAuthType;
		public virtual unsafe global::Com.Liveperson.Infra.LPAuthenticationParams.LPAuthenticationType AuthType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPAuthenticationParams']/method[@name='getAuthType' and count(parameter)=0]"
			[Register ("getAuthType", "()Lcom/liveperson/infra/LPAuthenticationParams$LPAuthenticationType;", "GetGetAuthTypeHandler")]
			get {
				if (id_getAuthType == IntPtr.Zero)
					id_getAuthType = JNIEnv.GetMethodID (class_ref, "getAuthType", "()Lcom/liveperson/infra/LPAuthenticationParams$LPAuthenticationType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams.LPAuthenticationType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams.LPAuthenticationType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthType", "()Lcom/liveperson/infra/LPAuthenticationParams$LPAuthenticationType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCertificatePinningKeys;
#pragma warning disable 0169
		static Delegate GetGetCertificatePinningKeysHandler ()
		{
			if (cb_getCertificatePinningKeys == null)
				cb_getCertificatePinningKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCertificatePinningKeys);
			return cb_getCertificatePinningKeys;
		}

		static IntPtr n_GetCertificatePinningKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.LPAuthenticationParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.CertificatePinningKeys);
		}
#pragma warning restore 0169

		static IntPtr id_getCertificatePinningKeys;
		public virtual unsafe global::System.Collections.Generic.IList<string> CertificatePinningKeys {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPAuthenticationParams']/method[@name='getCertificatePinningKeys' and count(parameter)=0]"
			[Register ("getCertificatePinningKeys", "()Ljava/util/List;", "GetGetCertificatePinningKeysHandler")]
			get {
				if (id_getCertificatePinningKeys == IntPtr.Zero)
					id_getCertificatePinningKeys = JNIEnv.GetMethodID (class_ref, "getCertificatePinningKeys", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCertificatePinningKeys), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCertificatePinningKeys", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHostAppJWT;
#pragma warning disable 0169
		static Delegate GetGetHostAppJWTHandler ()
		{
			if (cb_getHostAppJWT == null)
				cb_getHostAppJWT = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHostAppJWT);
			return cb_getHostAppJWT;
		}

		static IntPtr n_GetHostAppJWT (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.LPAuthenticationParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HostAppJWT);
		}
#pragma warning restore 0169

		static IntPtr id_getHostAppJWT;
		public virtual unsafe string HostAppJWT {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPAuthenticationParams']/method[@name='getHostAppJWT' and count(parameter)=0]"
			[Register ("getHostAppJWT", "()Ljava/lang/String;", "GetGetHostAppJWTHandler")]
			get {
				if (id_getHostAppJWT == IntPtr.Zero)
					id_getHostAppJWT = JNIEnv.GetMethodID (class_ref, "getHostAppJWT", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHostAppJWT), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHostAppJWT", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHostAppRedirectUri;
#pragma warning disable 0169
		static Delegate GetGetHostAppRedirectUriHandler ()
		{
			if (cb_getHostAppRedirectUri == null)
				cb_getHostAppRedirectUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHostAppRedirectUri);
			return cb_getHostAppRedirectUri;
		}

		static IntPtr n_GetHostAppRedirectUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.LPAuthenticationParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HostAppRedirectUri);
		}
#pragma warning restore 0169

		static IntPtr id_getHostAppRedirectUri;
		public virtual unsafe string HostAppRedirectUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPAuthenticationParams']/method[@name='getHostAppRedirectUri' and count(parameter)=0]"
			[Register ("getHostAppRedirectUri", "()Ljava/lang/String;", "GetGetHostAppRedirectUriHandler")]
			get {
				if (id_getHostAppRedirectUri == IntPtr.Zero)
					id_getHostAppRedirectUri = JNIEnv.GetMethodID (class_ref, "getHostAppRedirectUri", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHostAppRedirectUri), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHostAppRedirectUri", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isAuthenticated;
#pragma warning disable 0169
		static Delegate GetIsAuthenticatedHandler ()
		{
			if (cb_isAuthenticated == null)
				cb_isAuthenticated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAuthenticated);
			return cb_isAuthenticated;
		}

		static bool n_IsAuthenticated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.LPAuthenticationParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAuthenticated;
		}
#pragma warning restore 0169

		static IntPtr id_isAuthenticated;
		public virtual unsafe bool IsAuthenticated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPAuthenticationParams']/method[@name='isAuthenticated' and count(parameter)=0]"
			[Register ("isAuthenticated", "()Z", "GetIsAuthenticatedHandler")]
			get {
				if (id_isAuthenticated == IntPtr.Zero)
					id_isAuthenticated = JNIEnv.GetMethodID (class_ref, "isAuthenticated", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAuthenticated);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAuthenticated", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_addCertificatePinningKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddCertificatePinningKey_Ljava_lang_String_Handler ()
		{
			if (cb_addCertificatePinningKey_Ljava_lang_String_ == null)
				cb_addCertificatePinningKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddCertificatePinningKey_Ljava_lang_String_);
			return cb_addCertificatePinningKey_Ljava_lang_String_;
		}

		static IntPtr n_AddCertificatePinningKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.LPAuthenticationParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddCertificatePinningKey (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addCertificatePinningKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPAuthenticationParams']/method[@name='addCertificatePinningKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addCertificatePinningKey", "(Ljava/lang/String;)Lcom/liveperson/infra/LPAuthenticationParams;", "GetAddCertificatePinningKey_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.LPAuthenticationParams AddCertificatePinningKey (string p0)
		{
			if (id_addCertificatePinningKey_Ljava_lang_String_ == IntPtr.Zero)
				id_addCertificatePinningKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addCertificatePinningKey", "(Ljava/lang/String;)Lcom/liveperson/infra/LPAuthenticationParams;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.LPAuthenticationParams __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addCertificatePinningKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addCertificatePinningKey", "(Ljava/lang/String;)Lcom/liveperson/infra/LPAuthenticationParams;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.LPAuthenticationParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPAuthenticationParams']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static Delegate cb_setAuthKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAuthKey_Ljava_lang_String_Handler ()
		{
			if (cb_setAuthKey_Ljava_lang_String_ == null)
				cb_setAuthKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAuthKey_Ljava_lang_String_);
			return cb_setAuthKey_Ljava_lang_String_;
		}

		static IntPtr n_SetAuthKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.LPAuthenticationParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAuthKey (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setAuthKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPAuthenticationParams']/method[@name='setAuthKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAuthKey", "(Ljava/lang/String;)Lcom/liveperson/infra/LPAuthenticationParams;", "GetSetAuthKey_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.LPAuthenticationParams SetAuthKey (string p0)
		{
			if (id_setAuthKey_Ljava_lang_String_ == IntPtr.Zero)
				id_setAuthKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAuthKey", "(Ljava/lang/String;)Lcom/liveperson/infra/LPAuthenticationParams;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.LPAuthenticationParams __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAuthKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAuthKey", "(Ljava/lang/String;)Lcom/liveperson/infra/LPAuthenticationParams;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setHostAppJWT_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHostAppJWT_Ljava_lang_String_Handler ()
		{
			if (cb_setHostAppJWT_Ljava_lang_String_ == null)
				cb_setHostAppJWT_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetHostAppJWT_Ljava_lang_String_);
			return cb_setHostAppJWT_Ljava_lang_String_;
		}

		static IntPtr n_SetHostAppJWT_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.LPAuthenticationParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetHostAppJWT (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setHostAppJWT_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPAuthenticationParams']/method[@name='setHostAppJWT' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setHostAppJWT", "(Ljava/lang/String;)Lcom/liveperson/infra/LPAuthenticationParams;", "GetSetHostAppJWT_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.LPAuthenticationParams SetHostAppJWT (string p0)
		{
			if (id_setHostAppJWT_Ljava_lang_String_ == IntPtr.Zero)
				id_setHostAppJWT_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHostAppJWT", "(Ljava/lang/String;)Lcom/liveperson/infra/LPAuthenticationParams;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.LPAuthenticationParams __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setHostAppJWT_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHostAppJWT", "(Ljava/lang/String;)Lcom/liveperson/infra/LPAuthenticationParams;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setHostAppRedirectUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHostAppRedirectUri_Ljava_lang_String_Handler ()
		{
			if (cb_setHostAppRedirectUri_Ljava_lang_String_ == null)
				cb_setHostAppRedirectUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetHostAppRedirectUri_Ljava_lang_String_);
			return cb_setHostAppRedirectUri_Ljava_lang_String_;
		}

		static IntPtr n_SetHostAppRedirectUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.LPAuthenticationParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetHostAppRedirectUri (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setHostAppRedirectUri_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPAuthenticationParams']/method[@name='setHostAppRedirectUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setHostAppRedirectUri", "(Ljava/lang/String;)Lcom/liveperson/infra/LPAuthenticationParams;", "GetSetHostAppRedirectUri_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.LPAuthenticationParams SetHostAppRedirectUri (string p0)
		{
			if (id_setHostAppRedirectUri_Ljava_lang_String_ == IntPtr.Zero)
				id_setHostAppRedirectUri_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHostAppRedirectUri", "(Ljava/lang/String;)Lcom/liveperson/infra/LPAuthenticationParams;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.LPAuthenticationParams __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setHostAppRedirectUri_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHostAppRedirectUri", "(Ljava/lang/String;)Lcom/liveperson/infra/LPAuthenticationParams;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Com.Liveperson.Infra.LPAuthenticationParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPAuthenticationParams']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}
