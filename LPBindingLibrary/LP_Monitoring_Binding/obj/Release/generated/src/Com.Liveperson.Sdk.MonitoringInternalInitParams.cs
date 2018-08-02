using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.sdk']/class[@name='MonitoringInternalInitParams']"
	[global::Android.Runtime.Register ("com/liveperson/sdk/MonitoringInternalInitParams", DoNotGenerateAcw=true)]
	public sealed partial class MonitoringInternalInitParams : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/sdk/MonitoringInternalInitParams", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MonitoringInternalInitParams); }
		}

		internal MonitoringInternalInitParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.sdk']/class[@name='MonitoringInternalInitParams']/constructor[@name='MonitoringInternalInitParams' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe MonitoringInternalInitParams (global::Android.Content.Context p0, string p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (MonitoringInternalInitParams)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_getAccountId;
		public unsafe string AccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.sdk']/class[@name='MonitoringInternalInitParams']/method[@name='getAccountId' and count(parameter)=0]"
			[Register ("getAccountId", "()Ljava/lang/String;", "GetGetAccountIdHandler")]
			get {
				if (id_getAccountId == IntPtr.Zero)
					id_getAccountId = JNIEnv.GetMethodID (class_ref, "getAccountId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccountId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getAppInstallId;
		public unsafe string AppInstallId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.sdk']/class[@name='MonitoringInternalInitParams']/method[@name='getAppInstallId' and count(parameter)=0]"
			[Register ("getAppInstallId", "()Ljava/lang/String;", "GetGetAppInstallIdHandler")]
			get {
				if (id_getAppInstallId == IntPtr.Zero)
					id_getAppInstallId = JNIEnv.GetMethodID (class_ref, "getAppInstallId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppInstallId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getApplicationContext;
		public unsafe global::Android.Content.Context ApplicationContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.sdk']/class[@name='MonitoringInternalInitParams']/method[@name='getApplicationContext' and count(parameter)=0]"
			[Register ("getApplicationContext", "()Landroid/content/Context;", "GetGetApplicationContextHandler")]
			get {
				if (id_getApplicationContext == IntPtr.Zero)
					id_getApplicationContext = JNIEnv.GetMethodID (class_ref, "getApplicationContext", "()Landroid/content/Context;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApplicationContext), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_component1;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.sdk']/class[@name='MonitoringInternalInitParams']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()Landroid/content/Context;", "")]
		public unsafe global::Android.Content.Context Component1 ()
		{
			if (id_component1 == IntPtr.Zero)
				id_component1 = JNIEnv.GetMethodID (class_ref, "component1", "()Landroid/content/Context;");
			try {
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_component1), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_component2;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.sdk']/class[@name='MonitoringInternalInitParams']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()Ljava/lang/String;", "")]
		public unsafe string Component2 ()
		{
			if (id_component2 == IntPtr.Zero)
				id_component2 = JNIEnv.GetMethodID (class_ref, "component2", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_component2), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_component3;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.sdk']/class[@name='MonitoringInternalInitParams']/method[@name='component3' and count(parameter)=0]"
		[Register ("component3", "()Ljava/lang/String;", "")]
		public unsafe string Component3 ()
		{
			if (id_component3 == IntPtr.Zero)
				id_component3 = JNIEnv.GetMethodID (class_ref, "component3", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_component3), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_copy_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.sdk']/class[@name='MonitoringInternalInitParams']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("copy", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/sdk/MonitoringInternalInitParams;", "")]
		public unsafe global::Com.Liveperson.Sdk.MonitoringInternalInitParams Copy (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_copy_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_copy_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "copy", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/sdk/MonitoringInternalInitParams;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::Com.Liveperson.Sdk.MonitoringInternalInitParams __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Sdk.MonitoringInternalInitParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_copy_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
