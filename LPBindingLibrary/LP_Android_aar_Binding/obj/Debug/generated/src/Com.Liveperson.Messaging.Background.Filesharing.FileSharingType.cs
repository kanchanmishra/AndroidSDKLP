using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Background.Filesharing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='FileSharingType']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/background/filesharing/FileSharingType", DoNotGenerateAcw=true)]
	public sealed partial class FileSharingType : global::Java.Lang.Enum {


		static IntPtr IMAGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='FileSharingType']/field[@name='IMAGE']"
		[Register ("IMAGE")]
		public static global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType Image {
			get {
				if (IMAGE_jfieldId == IntPtr.Zero)
					IMAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IMAGE", "Lcom/liveperson/messaging/background/filesharing/FileSharingType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IMAGE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VOICE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='FileSharingType']/field[@name='VOICE']"
		[Register ("VOICE")]
		public static global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType Voice {
			get {
				if (VOICE_jfieldId == IntPtr.Zero)
					VOICE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VOICE", "Lcom/liveperson/messaging/background/filesharing/FileSharingType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VOICE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/background/filesharing/FileSharingType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileSharingType); }
		}

		internal FileSharingType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='FileSharingType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/messaging/background/filesharing/FileSharingType;", "")]
		public static unsafe global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/messaging/background/filesharing/FileSharingType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='FileSharingType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/liveperson/messaging/background/filesharing/FileSharingType;", "")]
		public static unsafe global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/messaging/background/filesharing/FileSharingType;");
			try {
				return (global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType));
			} finally {
			}
		}

	}
}
