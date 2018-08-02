using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='SocketTaskType']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/SocketTaskType", DoNotGenerateAcw=true)]
	public sealed partial class SocketTaskType : global::Java.Lang.Enum {


		static IntPtr GET_CLOCK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='SocketTaskType']/field[@name='GET_CLOCK']"
		[Register ("GET_CLOCK")]
		public static global::Com.Liveperson.Messaging.SocketTaskType GetClock {
			get {
				if (GET_CLOCK_jfieldId == IntPtr.Zero)
					GET_CLOCK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GET_CLOCK", "Lcom/liveperson/messaging/SocketTaskType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GET_CLOCK_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.SocketTaskType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr GET_USER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='SocketTaskType']/field[@name='GET_USER']"
		[Register ("GET_USER")]
		public static global::Com.Liveperson.Messaging.SocketTaskType GetUser {
			get {
				if (GET_USER_jfieldId == IntPtr.Zero)
					GET_USER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GET_USER", "Lcom/liveperson/messaging/SocketTaskType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GET_USER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.SocketTaskType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr QUERY_MESSAGES_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='SocketTaskType']/field[@name='QUERY_MESSAGES']"
		[Register ("QUERY_MESSAGES")]
		public static global::Com.Liveperson.Messaging.SocketTaskType QueryMessages {
			get {
				if (QUERY_MESSAGES_jfieldId == IntPtr.Zero)
					QUERY_MESSAGES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QUERY_MESSAGES", "Lcom/liveperson/messaging/SocketTaskType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, QUERY_MESSAGES_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.SocketTaskType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SUBSCRIBE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='SocketTaskType']/field[@name='SUBSCRIBE']"
		[Register ("SUBSCRIBE")]
		public static global::Com.Liveperson.Messaging.SocketTaskType Subscribe {
			get {
				if (SUBSCRIBE_jfieldId == IntPtr.Zero)
					SUBSCRIBE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUBSCRIBE", "Lcom/liveperson/messaging/SocketTaskType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUBSCRIBE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.SocketTaskType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UN_SUBSCRIBE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='SocketTaskType']/field[@name='UN_SUBSCRIBE']"
		[Register ("UN_SUBSCRIBE")]
		public static global::Com.Liveperson.Messaging.SocketTaskType UnSubscribe {
			get {
				if (UN_SUBSCRIBE_jfieldId == IntPtr.Zero)
					UN_SUBSCRIBE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UN_SUBSCRIBE", "Lcom/liveperson/messaging/SocketTaskType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UN_SUBSCRIBE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.SocketTaskType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/SocketTaskType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocketTaskType); }
		}

		internal SocketTaskType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='SocketTaskType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/messaging/SocketTaskType;", "")]
		public static unsafe global::Com.Liveperson.Messaging.SocketTaskType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/messaging/SocketTaskType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Messaging.SocketTaskType __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.SocketTaskType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='SocketTaskType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/liveperson/messaging/SocketTaskType;", "")]
		public static unsafe global::Com.Liveperson.Messaging.SocketTaskType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/messaging/SocketTaskType;");
			try {
				return (global::Com.Liveperson.Messaging.SocketTaskType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Messaging.SocketTaskType));
			} finally {
			}
		}

	}
}
