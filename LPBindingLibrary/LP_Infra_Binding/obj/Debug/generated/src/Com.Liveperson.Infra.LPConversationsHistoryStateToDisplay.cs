using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPConversationsHistoryStateToDisplay']"
	[global::Android.Runtime.Register ("com/liveperson/infra/LPConversationsHistoryStateToDisplay", DoNotGenerateAcw=true)]
	public sealed partial class LPConversationsHistoryStateToDisplay : global::Java.Lang.Enum {


		static IntPtr ALL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPConversationsHistoryStateToDisplay']/field[@name='ALL']"
		[Register ("ALL")]
		public static global::Com.Liveperson.Infra.LPConversationsHistoryStateToDisplay All {
			get {
				if (ALL_jfieldId == IntPtr.Zero)
					ALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL", "Lcom/liveperson/infra/LPConversationsHistoryStateToDisplay;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPConversationsHistoryStateToDisplay> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CLOSE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPConversationsHistoryStateToDisplay']/field[@name='CLOSE']"
		[Register ("CLOSE")]
		public static global::Com.Liveperson.Infra.LPConversationsHistoryStateToDisplay Close {
			get {
				if (CLOSE_jfieldId == IntPtr.Zero)
					CLOSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLOSE", "Lcom/liveperson/infra/LPConversationsHistoryStateToDisplay;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLOSE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPConversationsHistoryStateToDisplay> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr OPEN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPConversationsHistoryStateToDisplay']/field[@name='OPEN']"
		[Register ("OPEN")]
		public static global::Com.Liveperson.Infra.LPConversationsHistoryStateToDisplay Open {
			get {
				if (OPEN_jfieldId == IntPtr.Zero)
					OPEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPEN", "Lcom/liveperson/infra/LPConversationsHistoryStateToDisplay;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OPEN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPConversationsHistoryStateToDisplay> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/LPConversationsHistoryStateToDisplay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LPConversationsHistoryStateToDisplay); }
		}

		internal LPConversationsHistoryStateToDisplay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPConversationsHistoryStateToDisplay']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/LPConversationsHistoryStateToDisplay;", "")]
		public static unsafe global::Com.Liveperson.Infra.LPConversationsHistoryStateToDisplay ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/LPConversationsHistoryStateToDisplay;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Infra.LPConversationsHistoryStateToDisplay __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPConversationsHistoryStateToDisplay> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPConversationsHistoryStateToDisplay']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/liveperson/infra/LPConversationsHistoryStateToDisplay;", "")]
		public static unsafe global::Com.Liveperson.Infra.LPConversationsHistoryStateToDisplay[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/infra/LPConversationsHistoryStateToDisplay;");
			try {
				return (global::Com.Liveperson.Infra.LPConversationsHistoryStateToDisplay[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Infra.LPConversationsHistoryStateToDisplay));
			} finally {
			}
		}

	}
}
