using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Background.Filesharing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseTaskBundle']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/background/filesharing/BaseTaskBundle", DoNotGenerateAcw=true)]
	public partial class BaseTaskBundle : global::Java.Lang.Object {


		static IntPtr mBrandId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseTaskBundle']/field[@name='mBrandId']"
		[Register ("mBrandId")]
		protected string MBrandId {
			get {
				if (mBrandId_jfieldId == IntPtr.Zero)
					mBrandId_jfieldId = JNIEnv.GetFieldID (class_ref, "mBrandId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mBrandId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mBrandId_jfieldId == IntPtr.Zero)
					mBrandId_jfieldId = JNIEnv.GetFieldID (class_ref, "mBrandId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mBrandId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mRestRequestParams_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseTaskBundle']/field[@name='mRestRequestParams']"
		[Register ("mRestRequestParams")]
		protected global::Com.Liveperson.Messaging.Network.Http.RestRequestParams MRestRequestParams {
			get {
				if (mRestRequestParams_jfieldId == IntPtr.Zero)
					mRestRequestParams_jfieldId = JNIEnv.GetFieldID (class_ref, "mRestRequestParams", "Lcom/liveperson/messaging/network/http/RestRequestParams;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mRestRequestParams_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.RestRequestParams> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mRestRequestParams_jfieldId == IntPtr.Zero)
					mRestRequestParams_jfieldId = JNIEnv.GetFieldID (class_ref, "mRestRequestParams", "Lcom/liveperson/messaging/network/http/RestRequestParams;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mRestRequestParams_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mSwiftDomain_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseTaskBundle']/field[@name='mSwiftDomain']"
		[Register ("mSwiftDomain")]
		protected string MSwiftDomain {
			get {
				if (mSwiftDomain_jfieldId == IntPtr.Zero)
					mSwiftDomain_jfieldId = JNIEnv.GetFieldID (class_ref, "mSwiftDomain", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mSwiftDomain_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSwiftDomain_jfieldId == IntPtr.Zero)
					mSwiftDomain_jfieldId = JNIEnv.GetFieldID (class_ref, "mSwiftDomain", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSwiftDomain_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mTargetId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseTaskBundle']/field[@name='mTargetId']"
		[Register ("mTargetId")]
		protected string MTargetId {
			get {
				if (mTargetId_jfieldId == IntPtr.Zero)
					mTargetId_jfieldId = JNIEnv.GetFieldID (class_ref, "mTargetId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mTargetId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTargetId_jfieldId == IntPtr.Zero)
					mTargetId_jfieldId = JNIEnv.GetFieldID (class_ref, "mTargetId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mTargetId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/background/filesharing/BaseTaskBundle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseTaskBundle); }
		}

		protected BaseTaskBundle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseTaskBundle']/constructor[@name='BaseTaskBundle' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseTaskBundle ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BaseTaskBundle)) {
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
			global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BrandId);
		}
#pragma warning restore 0169

		static IntPtr id_getBrandId;
		public virtual unsafe string BrandId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseTaskBundle']/method[@name='getBrandId' and count(parameter)=0]"
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

		static Delegate cb_getRestRequestParams;
#pragma warning disable 0169
		static Delegate GetGetRestRequestParamsHandler ()
		{
			if (cb_getRestRequestParams == null)
				cb_getRestRequestParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRestRequestParams);
			return cb_getRestRequestParams;
		}

		static IntPtr n_GetRestRequestParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RestRequestParams);
		}
#pragma warning restore 0169

		static IntPtr id_getRestRequestParams;
		public virtual unsafe global::Com.Liveperson.Messaging.Network.Http.RestRequestParams RestRequestParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseTaskBundle']/method[@name='getRestRequestParams' and count(parameter)=0]"
			[Register ("getRestRequestParams", "()Lcom/liveperson/messaging/network/http/RestRequestParams;", "GetGetRestRequestParamsHandler")]
			get {
				if (id_getRestRequestParams == IntPtr.Zero)
					id_getRestRequestParams = JNIEnv.GetMethodID (class_ref, "getRestRequestParams", "()Lcom/liveperson/messaging/network/http/RestRequestParams;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.RestRequestParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRestRequestParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.RestRequestParams> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRestRequestParams", "()Lcom/liveperson/messaging/network/http/RestRequestParams;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSwiftDomain;
#pragma warning disable 0169
		static Delegate GetGetSwiftDomainHandler ()
		{
			if (cb_getSwiftDomain == null)
				cb_getSwiftDomain = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSwiftDomain);
			return cb_getSwiftDomain;
		}

		static IntPtr n_GetSwiftDomain (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SwiftDomain);
		}
#pragma warning restore 0169

		static IntPtr id_getSwiftDomain;
		public virtual unsafe string SwiftDomain {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseTaskBundle']/method[@name='getSwiftDomain' and count(parameter)=0]"
			[Register ("getSwiftDomain", "()Ljava/lang/String;", "GetGetSwiftDomainHandler")]
			get {
				if (id_getSwiftDomain == IntPtr.Zero)
					id_getSwiftDomain = JNIEnv.GetMethodID (class_ref, "getSwiftDomain", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSwiftDomain), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSwiftDomain", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTargetId;
#pragma warning disable 0169
		static Delegate GetGetTargetIdHandler ()
		{
			if (cb_getTargetId == null)
				cb_getTargetId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTargetId);
			return cb_getTargetId;
		}

		static IntPtr n_GetTargetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TargetId);
		}
#pragma warning restore 0169

		static IntPtr id_getTargetId;
		public virtual unsafe string TargetId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseTaskBundle']/method[@name='getTargetId' and count(parameter)=0]"
			[Register ("getTargetId", "()Ljava/lang/String;", "GetGetTargetIdHandler")]
			get {
				if (id_getTargetId == IntPtr.Zero)
					id_getTargetId = JNIEnv.GetMethodID (class_ref, "getTargetId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTargetId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTargetId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addBrandId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddBrandId_Ljava_lang_String_Handler ()
		{
			if (cb_addBrandId_Ljava_lang_String_ == null)
				cb_addBrandId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddBrandId_Ljava_lang_String_);
			return cb_addBrandId_Ljava_lang_String_;
		}

		static IntPtr n_AddBrandId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddBrandId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addBrandId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseTaskBundle']/method[@name='addBrandId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addBrandId", "(Ljava/lang/String;)Lcom/liveperson/messaging/background/filesharing/BaseTaskBundle;", "GetAddBrandId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle AddBrandId (string p0)
		{
			if (id_addBrandId_Ljava_lang_String_ == IntPtr.Zero)
				id_addBrandId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addBrandId", "(Ljava/lang/String;)Lcom/liveperson/messaging/background/filesharing/BaseTaskBundle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addBrandId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addBrandId", "(Ljava/lang/String;)Lcom/liveperson/messaging/background/filesharing/BaseTaskBundle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addRestDomain_Lcom_liveperson_messaging_network_http_RestRequestParams_;
#pragma warning disable 0169
		static Delegate GetAddRestDomain_Lcom_liveperson_messaging_network_http_RestRequestParams_Handler ()
		{
			if (cb_addRestDomain_Lcom_liveperson_messaging_network_http_RestRequestParams_ == null)
				cb_addRestDomain_Lcom_liveperson_messaging_network_http_RestRequestParams_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddRestDomain_Lcom_liveperson_messaging_network_http_RestRequestParams_);
			return cb_addRestDomain_Lcom_liveperson_messaging_network_http_RestRequestParams_;
		}

		static IntPtr n_AddRestDomain_Lcom_liveperson_messaging_network_http_RestRequestParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Network.Http.RestRequestParams p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.RestRequestParams> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddRestDomain (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addRestDomain_Lcom_liveperson_messaging_network_http_RestRequestParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseTaskBundle']/method[@name='addRestDomain' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.network.http.RestRequestParams']]"
		[Register ("addRestDomain", "(Lcom/liveperson/messaging/network/http/RestRequestParams;)Lcom/liveperson/messaging/background/filesharing/BaseTaskBundle;", "GetAddRestDomain_Lcom_liveperson_messaging_network_http_RestRequestParams_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle AddRestDomain (global::Com.Liveperson.Messaging.Network.Http.RestRequestParams p0)
		{
			if (id_addRestDomain_Lcom_liveperson_messaging_network_http_RestRequestParams_ == IntPtr.Zero)
				id_addRestDomain_Lcom_liveperson_messaging_network_http_RestRequestParams_ = JNIEnv.GetMethodID (class_ref, "addRestDomain", "(Lcom/liveperson/messaging/network/http/RestRequestParams;)Lcom/liveperson/messaging/background/filesharing/BaseTaskBundle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addRestDomain_Lcom_liveperson_messaging_network_http_RestRequestParams_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addRestDomain", "(Lcom/liveperson/messaging/network/http/RestRequestParams;)Lcom/liveperson/messaging/background/filesharing/BaseTaskBundle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_addSwiftDomain_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddSwiftDomain_Ljava_lang_String_Handler ()
		{
			if (cb_addSwiftDomain_Ljava_lang_String_ == null)
				cb_addSwiftDomain_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddSwiftDomain_Ljava_lang_String_);
			return cb_addSwiftDomain_Ljava_lang_String_;
		}

		static IntPtr n_AddSwiftDomain_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddSwiftDomain (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addSwiftDomain_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseTaskBundle']/method[@name='addSwiftDomain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addSwiftDomain", "(Ljava/lang/String;)Lcom/liveperson/messaging/background/filesharing/BaseTaskBundle;", "GetAddSwiftDomain_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle AddSwiftDomain (string p0)
		{
			if (id_addSwiftDomain_Ljava_lang_String_ == IntPtr.Zero)
				id_addSwiftDomain_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addSwiftDomain", "(Ljava/lang/String;)Lcom/liveperson/messaging/background/filesharing/BaseTaskBundle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addSwiftDomain_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addSwiftDomain", "(Ljava/lang/String;)Lcom/liveperson/messaging/background/filesharing/BaseTaskBundle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addTargetId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddTargetId_Ljava_lang_String_Handler ()
		{
			if (cb_addTargetId_Ljava_lang_String_ == null)
				cb_addTargetId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddTargetId_Ljava_lang_String_);
			return cb_addTargetId_Ljava_lang_String_;
		}

		static IntPtr n_AddTargetId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddTargetId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addTargetId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseTaskBundle']/method[@name='addTargetId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addTargetId", "(Ljava/lang/String;)Lcom/liveperson/messaging/background/filesharing/BaseTaskBundle;", "GetAddTargetId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle AddTargetId (string p0)
		{
			if (id_addTargetId_Ljava_lang_String_ == IntPtr.Zero)
				id_addTargetId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addTargetId", "(Ljava/lang/String;)Lcom/liveperson/messaging/background/filesharing/BaseTaskBundle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addTargetId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addTargetId", "(Ljava/lang/String;)Lcom/liveperson/messaging/background/filesharing/BaseTaskBundle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
