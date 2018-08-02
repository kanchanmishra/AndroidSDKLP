using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='TaskType']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/TaskType", DoNotGenerateAcw=true)]
	public sealed partial class TaskType : global::Java.Lang.Enum {


		static IntPtr CSDS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='TaskType']/field[@name='CSDS']"
		[Register ("CSDS")]
		public static global::Com.Liveperson.Messaging.TaskType Csds {
			get {
				if (CSDS_jfieldId == IntPtr.Zero)
					CSDS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CSDS", "Lcom/liveperson/messaging/TaskType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CSDS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.TaskType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr IDP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='TaskType']/field[@name='IDP']"
		[Register ("IDP")]
		public static global::Com.Liveperson.Messaging.TaskType Idp {
			get {
				if (IDP_jfieldId == IntPtr.Zero)
					IDP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IDP", "Lcom/liveperson/messaging/TaskType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IDP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.TaskType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INVALID_CERTIFICATE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='TaskType']/field[@name='INVALID_CERTIFICATE']"
		[Register ("INVALID_CERTIFICATE")]
		public static global::Com.Liveperson.Messaging.TaskType InvalidCertificate {
			get {
				if (INVALID_CERTIFICATE_jfieldId == IntPtr.Zero)
					INVALID_CERTIFICATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_CERTIFICATE", "Lcom/liveperson/messaging/TaskType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_CERTIFICATE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.TaskType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr OPEN_SOCKET_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='TaskType']/field[@name='OPEN_SOCKET']"
		[Register ("OPEN_SOCKET")]
		public static global::Com.Liveperson.Messaging.TaskType OpenSocket {
			get {
				if (OPEN_SOCKET_jfieldId == IntPtr.Zero)
					OPEN_SOCKET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPEN_SOCKET", "Lcom/liveperson/messaging/TaskType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OPEN_SOCKET_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.TaskType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr USER_EXPIRED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='TaskType']/field[@name='USER_EXPIRED']"
		[Register ("USER_EXPIRED")]
		public static global::Com.Liveperson.Messaging.TaskType UserExpired {
			get {
				if (USER_EXPIRED_jfieldId == IntPtr.Zero)
					USER_EXPIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_EXPIRED", "Lcom/liveperson/messaging/TaskType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_EXPIRED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.TaskType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VERSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='TaskType']/field[@name='VERSION']"
		[Register ("VERSION")]
		public static global::Com.Liveperson.Messaging.TaskType Version {
			get {
				if (VERSION_jfieldId == IntPtr.Zero)
					VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERSION", "Lcom/liveperson/messaging/TaskType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VERSION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.TaskType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/TaskType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TaskType); }
		}

		internal TaskType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='TaskType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/messaging/TaskType;", "")]
		public static unsafe global::Com.Liveperson.Messaging.TaskType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/messaging/TaskType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Messaging.TaskType __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.TaskType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='TaskType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/liveperson/messaging/TaskType;", "")]
		public static unsafe global::Com.Liveperson.Messaging.TaskType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/messaging/TaskType;");
			try {
				return (global::Com.Liveperson.Messaging.TaskType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Messaging.TaskType));
			} finally {
			}
		}

	}
}
