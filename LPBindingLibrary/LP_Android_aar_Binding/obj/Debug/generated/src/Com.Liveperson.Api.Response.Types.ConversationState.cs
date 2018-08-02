using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Response.Types {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='ConversationState']"
	[global::Android.Runtime.Register ("com/liveperson/api/response/types/ConversationState", DoNotGenerateAcw=true)]
	public sealed partial class ConversationState : global::Java.Lang.Enum {


		static IntPtr CLOSE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='ConversationState']/field[@name='CLOSE']"
		[Register ("CLOSE")]
		public static global::Com.Liveperson.Api.Response.Types.ConversationState Close {
			get {
				if (CLOSE_jfieldId == IntPtr.Zero)
					CLOSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLOSE", "Lcom/liveperson/api/response/types/ConversationState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLOSE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.ConversationState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LOCKED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='ConversationState']/field[@name='LOCKED']"
		[Register ("LOCKED")]
		public static global::Com.Liveperson.Api.Response.Types.ConversationState Locked {
			get {
				if (LOCKED_jfieldId == IntPtr.Zero)
					LOCKED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOCKED", "Lcom/liveperson/api/response/types/ConversationState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOCKED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.ConversationState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr OPEN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='ConversationState']/field[@name='OPEN']"
		[Register ("OPEN")]
		public static global::Com.Liveperson.Api.Response.Types.ConversationState Open {
			get {
				if (OPEN_jfieldId == IntPtr.Zero)
					OPEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPEN", "Lcom/liveperson/api/response/types/ConversationState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OPEN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.ConversationState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PENDING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='ConversationState']/field[@name='PENDING']"
		[Register ("PENDING")]
		public static global::Com.Liveperson.Api.Response.Types.ConversationState Pending {
			get {
				if (PENDING_jfieldId == IntPtr.Zero)
					PENDING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PENDING", "Lcom/liveperson/api/response/types/ConversationState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PENDING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.ConversationState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr QUEUED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='ConversationState']/field[@name='QUEUED']"
		[Register ("QUEUED")]
		public static global::Com.Liveperson.Api.Response.Types.ConversationState Queued {
			get {
				if (QUEUED_jfieldId == IntPtr.Zero)
					QUEUED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QUEUED", "Lcom/liveperson/api/response/types/ConversationState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, QUEUED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.ConversationState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/response/types/ConversationState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConversationState); }
		}

		internal ConversationState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='ConversationState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/response/types/ConversationState;", "")]
		public static unsafe global::Com.Liveperson.Api.Response.Types.ConversationState ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/response/types/ConversationState;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Api.Response.Types.ConversationState __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.ConversationState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.types']/class[@name='ConversationState']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/liveperson/api/response/types/ConversationState;", "")]
		public static unsafe global::Com.Liveperson.Api.Response.Types.ConversationState[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/api/response/types/ConversationState;");
			try {
				return (global::Com.Liveperson.Api.Response.Types.ConversationState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Api.Response.Types.ConversationState));
			} finally {
			}
		}

	}
}
