using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Model.Types {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.model.types']/class[@name='ChatState']"
	[global::Android.Runtime.Register ("com/liveperson/infra/model/types/ChatState", DoNotGenerateAcw=true)]
	public sealed partial class ChatState : global::Java.Lang.Enum {


		static IntPtr ACTIVE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.model.types']/class[@name='ChatState']/field[@name='ACTIVE']"
		[Register ("ACTIVE")]
		public static global::Com.Liveperson.Infra.Model.Types.ChatState Active {
			get {
				if (ACTIVE_jfieldId == IntPtr.Zero)
					ACTIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTIVE", "Lcom/liveperson/infra/model/types/ChatState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTIVE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Types.ChatState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BACKGROUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.model.types']/class[@name='ChatState']/field[@name='BACKGROUND']"
		[Register ("BACKGROUND")]
		public static global::Com.Liveperson.Infra.Model.Types.ChatState Background {
			get {
				if (BACKGROUND_jfieldId == IntPtr.Zero)
					BACKGROUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BACKGROUND", "Lcom/liveperson/infra/model/types/ChatState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BACKGROUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Types.ChatState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr COMPOSING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.model.types']/class[@name='ChatState']/field[@name='COMPOSING']"
		[Register ("COMPOSING")]
		public static global::Com.Liveperson.Infra.Model.Types.ChatState Composing {
			get {
				if (COMPOSING_jfieldId == IntPtr.Zero)
					COMPOSING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPOSING", "Lcom/liveperson/infra/model/types/ChatState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPOSING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Types.ChatState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr GONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.model.types']/class[@name='ChatState']/field[@name='GONE']"
		[Register ("GONE")]
		public static global::Com.Liveperson.Infra.Model.Types.ChatState Gone {
			get {
				if (GONE_jfieldId == IntPtr.Zero)
					GONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GONE", "Lcom/liveperson/infra/model/types/ChatState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Types.ChatState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INACTIVE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.model.types']/class[@name='ChatState']/field[@name='INACTIVE']"
		[Register ("INACTIVE")]
		public static global::Com.Liveperson.Infra.Model.Types.ChatState Inactive {
			get {
				if (INACTIVE_jfieldId == IntPtr.Zero)
					INACTIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INACTIVE", "Lcom/liveperson/infra/model/types/ChatState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INACTIVE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Types.ChatState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PAUSE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.model.types']/class[@name='ChatState']/field[@name='PAUSE']"
		[Register ("PAUSE")]
		public static global::Com.Liveperson.Infra.Model.Types.ChatState Pause {
			get {
				if (PAUSE_jfieldId == IntPtr.Zero)
					PAUSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAUSE", "Lcom/liveperson/infra/model/types/ChatState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAUSE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Types.ChatState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/model/types/ChatState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChatState); }
		}

		internal ChatState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model.types']/class[@name='ChatState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/model/types/ChatState;", "")]
		public static unsafe global::Com.Liveperson.Infra.Model.Types.ChatState ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/model/types/ChatState;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Infra.Model.Types.ChatState __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Types.ChatState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model.types']/class[@name='ChatState']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/liveperson/infra/model/types/ChatState;", "")]
		public static unsafe global::Com.Liveperson.Infra.Model.Types.ChatState[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/infra/model/types/ChatState;");
			try {
				return (global::Com.Liveperson.Infra.Model.Types.ChatState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Infra.Model.Types.ChatState));
			} finally {
			}
		}

	}
}
