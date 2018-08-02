using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.sdk']/class[@name='PermissionType']"
	[global::Android.Runtime.Register ("com/liveperson/api/sdk/PermissionType", DoNotGenerateAcw=true)]
	public sealed partial class PermissionType : global::Java.Lang.Enum {


		static IntPtr PHOTO_SHARING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.sdk']/class[@name='PermissionType']/field[@name='PHOTO_SHARING']"
		[Register ("PHOTO_SHARING")]
		public static global::Com.Liveperson.Api.Sdk.PermissionType PhotoSharing {
			get {
				if (PHOTO_SHARING_jfieldId == IntPtr.Zero)
					PHOTO_SHARING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PHOTO_SHARING", "Lcom/liveperson/api/sdk/PermissionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PHOTO_SHARING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Sdk.PermissionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VOICE_RECORDING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.sdk']/class[@name='PermissionType']/field[@name='VOICE_RECORDING']"
		[Register ("VOICE_RECORDING")]
		public static global::Com.Liveperson.Api.Sdk.PermissionType VoiceRecording {
			get {
				if (VOICE_RECORDING_jfieldId == IntPtr.Zero)
					VOICE_RECORDING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VOICE_RECORDING", "Lcom/liveperson/api/sdk/PermissionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VOICE_RECORDING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Sdk.PermissionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/sdk/PermissionType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PermissionType); }
		}

		internal PermissionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.sdk']/class[@name='PermissionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/sdk/PermissionType;", "")]
		public static unsafe global::Com.Liveperson.Api.Sdk.PermissionType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/sdk/PermissionType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Api.Sdk.PermissionType __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Sdk.PermissionType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.sdk']/class[@name='PermissionType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/liveperson/api/sdk/PermissionType;", "")]
		public static unsafe global::Com.Liveperson.Api.Sdk.PermissionType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/api/sdk/PermissionType;");
			try {
				return (global::Com.Liveperson.Api.Sdk.PermissionType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Api.Sdk.PermissionType));
			} finally {
			}
		}

	}
}
