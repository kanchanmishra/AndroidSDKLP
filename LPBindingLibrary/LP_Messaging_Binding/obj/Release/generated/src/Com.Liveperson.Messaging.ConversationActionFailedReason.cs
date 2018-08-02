using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='ConversationActionFailedReason']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/ConversationActionFailedReason", DoNotGenerateAcw=true)]
	public sealed partial class ConversationActionFailedReason : global::Java.Lang.Enum {


		static IntPtr CONVERSATION_NOT_ACTIVE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='ConversationActionFailedReason']/field[@name='CONVERSATION_NOT_ACTIVE']"
		[Register ("CONVERSATION_NOT_ACTIVE")]
		public static global::Com.Liveperson.Messaging.ConversationActionFailedReason ConversationNotActive {
			get {
				if (CONVERSATION_NOT_ACTIVE_jfieldId == IntPtr.Zero)
					CONVERSATION_NOT_ACTIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONVERSATION_NOT_ACTIVE", "Lcom/liveperson/messaging/ConversationActionFailedReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONVERSATION_NOT_ACTIVE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.ConversationActionFailedReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NO_NETWORK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='ConversationActionFailedReason']/field[@name='NO_NETWORK']"
		[Register ("NO_NETWORK")]
		public static global::Com.Liveperson.Messaging.ConversationActionFailedReason NoNetwork {
			get {
				if (NO_NETWORK_jfieldId == IntPtr.Zero)
					NO_NETWORK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_NETWORK", "Lcom/liveperson/messaging/ConversationActionFailedReason;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_NETWORK_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.ConversationActionFailedReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/ConversationActionFailedReason", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConversationActionFailedReason); }
		}

		internal ConversationActionFailedReason (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='ConversationActionFailedReason']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/messaging/ConversationActionFailedReason;", "")]
		public static unsafe global::Com.Liveperson.Messaging.ConversationActionFailedReason ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/messaging/ConversationActionFailedReason;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Messaging.ConversationActionFailedReason __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.ConversationActionFailedReason> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='ConversationActionFailedReason']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/liveperson/messaging/ConversationActionFailedReason;", "")]
		public static unsafe global::Com.Liveperson.Messaging.ConversationActionFailedReason[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/messaging/ConversationActionFailedReason;");
			try {
				return (global::Com.Liveperson.Messaging.ConversationActionFailedReason[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Messaging.ConversationActionFailedReason));
			} finally {
			}
		}

	}
}
