using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='UserProfileBundle']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/model/UserProfileBundle", DoNotGenerateAcw=true)]
	public partial class UserProfileBundle : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='UserProfileBundle.Builder']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/model/UserProfileBundle$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/model/UserProfileBundle$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='UserProfileBundle.Builder']/constructor[@name='UserProfileBundle.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Builder)) {
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

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='UserProfileBundle.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/liveperson/messaging/model/UserProfileBundle;", "GetBuildHandler")]
			public virtual unsafe global::Com.Liveperson.Messaging.Model.UserProfileBundle Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/liveperson/messaging/model/UserProfileBundle;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.UserProfileBundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.UserProfileBundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/liveperson/messaging/model/UserProfileBundle;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setAvatarUrl_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetAvatarUrl_Ljava_lang_String_Handler ()
			{
				if (cb_setAvatarUrl_Ljava_lang_String_ == null)
					cb_setAvatarUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAvatarUrl_Ljava_lang_String_);
				return cb_setAvatarUrl_Ljava_lang_String_;
			}

			static IntPtr n_SetAvatarUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAvatarUrl (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setAvatarUrl_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='UserProfileBundle.Builder']/method[@name='setAvatarUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAvatarUrl", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/UserProfileBundle$Builder;", "GetSetAvatarUrl_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder SetAvatarUrl (string p0)
			{
				if (id_setAvatarUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setAvatarUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAvatarUrl", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/UserProfileBundle$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAvatarUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAvatarUrl", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/UserProfileBundle$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setFirstName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetFirstName_Ljava_lang_String_Handler ()
			{
				if (cb_setFirstName_Ljava_lang_String_ == null)
					cb_setFirstName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFirstName_Ljava_lang_String_);
				return cb_setFirstName_Ljava_lang_String_;
			}

			static IntPtr n_SetFirstName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFirstName (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setFirstName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='UserProfileBundle.Builder']/method[@name='setFirstName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFirstName", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/UserProfileBundle$Builder;", "GetSetFirstName_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder SetFirstName (string p0)
			{
				if (id_setFirstName_Ljava_lang_String_ == IntPtr.Zero)
					id_setFirstName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFirstName", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/UserProfileBundle$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setFirstName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFirstName", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/UserProfileBundle$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setLastName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetLastName_Ljava_lang_String_Handler ()
			{
				if (cb_setLastName_Ljava_lang_String_ == null)
					cb_setLastName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLastName_Ljava_lang_String_);
				return cb_setLastName_Ljava_lang_String_;
			}

			static IntPtr n_SetLastName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetLastName (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setLastName_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='UserProfileBundle.Builder']/method[@name='setLastName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLastName", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/UserProfileBundle$Builder;", "GetSetLastName_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder SetLastName (string p0)
			{
				if (id_setLastName_Ljava_lang_String_ == IntPtr.Zero)
					id_setLastName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLastName", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/UserProfileBundle$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setLastName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastName", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/UserProfileBundle$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setNickname_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetNickname_Ljava_lang_String_Handler ()
			{
				if (cb_setNickname_Ljava_lang_String_ == null)
					cb_setNickname_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetNickname_Ljava_lang_String_);
				return cb_setNickname_Ljava_lang_String_;
			}

			static IntPtr n_SetNickname_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNickname (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setNickname_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='UserProfileBundle.Builder']/method[@name='setNickname' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNickname", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/UserProfileBundle$Builder;", "GetSetNickname_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder SetNickname (string p0)
			{
				if (id_setNickname_Ljava_lang_String_ == IntPtr.Zero)
					id_setNickname_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNickname", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/UserProfileBundle$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setNickname_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNickname", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/UserProfileBundle$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setPhoneNumber_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetPhoneNumber_Ljava_lang_String_Handler ()
			{
				if (cb_setPhoneNumber_Ljava_lang_String_ == null)
					cb_setPhoneNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPhoneNumber_Ljava_lang_String_);
				return cb_setPhoneNumber_Ljava_lang_String_;
			}

			static IntPtr n_SetPhoneNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPhoneNumber (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setPhoneNumber_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='UserProfileBundle.Builder']/method[@name='setPhoneNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPhoneNumber", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/UserProfileBundle$Builder;", "GetSetPhoneNumber_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder SetPhoneNumber (string p0)
			{
				if (id_setPhoneNumber_Ljava_lang_String_ == IntPtr.Zero)
					id_setPhoneNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPhoneNumber", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/UserProfileBundle$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPhoneNumber_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.UserProfileBundle.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPhoneNumber", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/UserProfileBundle$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/model/UserProfileBundle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UserProfileBundle); }
		}

		protected UserProfileBundle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Liveperson.Messaging.Model.UserProfileBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.UserProfileBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AvatarUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getAvatarUrl;
		public virtual unsafe string AvatarUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='UserProfileBundle']/method[@name='getAvatarUrl' and count(parameter)=0]"
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
			global::Com.Liveperson.Messaging.Model.UserProfileBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.UserProfileBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FirstName);
		}
#pragma warning restore 0169

		static IntPtr id_getFirstName;
		public virtual unsafe string FirstName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='UserProfileBundle']/method[@name='getFirstName' and count(parameter)=0]"
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
			global::Com.Liveperson.Messaging.Model.UserProfileBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.UserProfileBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LastName);
		}
#pragma warning restore 0169

		static IntPtr id_getLastName;
		public virtual unsafe string LastName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='UserProfileBundle']/method[@name='getLastName' and count(parameter)=0]"
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
			global::Com.Liveperson.Messaging.Model.UserProfileBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.UserProfileBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Nickname);
		}
#pragma warning restore 0169

		static IntPtr id_getNickname;
		public virtual unsafe string Nickname {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='UserProfileBundle']/method[@name='getNickname' and count(parameter)=0]"
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
		}

		static Delegate cb_getPhoneNumber;
#pragma warning disable 0169
		static Delegate GetGetPhoneNumberHandler ()
		{
			if (cb_getPhoneNumber == null)
				cb_getPhoneNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPhoneNumber);
			return cb_getPhoneNumber;
		}

		static IntPtr n_GetPhoneNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.UserProfileBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.UserProfileBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PhoneNumber);
		}
#pragma warning restore 0169

		static IntPtr id_getPhoneNumber;
		public virtual unsafe string PhoneNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='UserProfileBundle']/method[@name='getPhoneNumber' and count(parameter)=0]"
			[Register ("getPhoneNumber", "()Ljava/lang/String;", "GetGetPhoneNumberHandler")]
			get {
				if (id_getPhoneNumber == IntPtr.Zero)
					id_getPhoneNumber = JNIEnv.GetMethodID (class_ref, "getPhoneNumber", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPhoneNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPhoneNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
