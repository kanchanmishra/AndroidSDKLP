using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPConversationHistoryMaxDaysDateType']"
	[global::Android.Runtime.Register ("com/liveperson/infra/LPConversationHistoryMaxDaysDateType", DoNotGenerateAcw=true)]
	public sealed partial class LPConversationHistoryMaxDaysDateType : global::Java.Lang.Enum {


		static IntPtr endConversationDate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPConversationHistoryMaxDaysDateType']/field[@name='endConversationDate']"
		[Register ("endConversationDate")]
		public static global::Com.Liveperson.Infra.LPConversationHistoryMaxDaysDateType EndConversationDate {
			get {
				if (endConversationDate_jfieldId == IntPtr.Zero)
					endConversationDate_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "endConversationDate", "Lcom/liveperson/infra/LPConversationHistoryMaxDaysDateType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, endConversationDate_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPConversationHistoryMaxDaysDateType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr startConversationDate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPConversationHistoryMaxDaysDateType']/field[@name='startConversationDate']"
		[Register ("startConversationDate")]
		public static global::Com.Liveperson.Infra.LPConversationHistoryMaxDaysDateType StartConversationDate {
			get {
				if (startConversationDate_jfieldId == IntPtr.Zero)
					startConversationDate_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "startConversationDate", "Lcom/liveperson/infra/LPConversationHistoryMaxDaysDateType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, startConversationDate_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPConversationHistoryMaxDaysDateType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/LPConversationHistoryMaxDaysDateType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LPConversationHistoryMaxDaysDateType); }
		}

		internal LPConversationHistoryMaxDaysDateType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPConversationHistoryMaxDaysDateType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/LPConversationHistoryMaxDaysDateType;", "")]
		public static unsafe global::Com.Liveperson.Infra.LPConversationHistoryMaxDaysDateType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/LPConversationHistoryMaxDaysDateType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Infra.LPConversationHistoryMaxDaysDateType __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPConversationHistoryMaxDaysDateType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LPConversationHistoryMaxDaysDateType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/liveperson/infra/LPConversationHistoryMaxDaysDateType;", "")]
		public static unsafe global::Com.Liveperson.Infra.LPConversationHistoryMaxDaysDateType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/infra/LPConversationHistoryMaxDaysDateType;");
			try {
				return (global::Com.Liveperson.Infra.LPConversationHistoryMaxDaysDateType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Infra.LPConversationHistoryMaxDaysDateType));
			} finally {
			}
		}

	}
}
