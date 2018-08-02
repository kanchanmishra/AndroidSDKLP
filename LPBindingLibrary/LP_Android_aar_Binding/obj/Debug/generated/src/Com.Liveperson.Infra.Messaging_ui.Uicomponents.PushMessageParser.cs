using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='PushMessageParser']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/PushMessageParser", DoNotGenerateAcw=true)]
	public partial class PushMessageParser : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/PushMessageParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushMessageParser); }
		}

		protected PushMessageParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='PushMessageParser']/constructor[@name='PushMessageParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PushMessageParser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PushMessageParser)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_convertDataToBundle_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='PushMessageParser']/method[@name='convertDataToBundle' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("convertDataToBundle", "(Ljava/util/Map;)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle ConvertDataToBundle (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_convertDataToBundle_Ljava_util_Map_ == IntPtr.Zero)
				id_convertDataToBundle_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "convertDataToBundle", "(Ljava/util/Map;)Landroid/os/Bundle;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertDataToBundle_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_parse_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='PushMessageParser']/method[@name='parse' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("parse", "(Ljava/lang/String;Ljava/util/Map;)Lcom/liveperson/infra/model/PushMessage;", "")]
		public static unsafe global::Com.Liveperson.Infra.Model.PushMessage Parse (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_parse_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_parse_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Ljava/lang/String;Ljava/util/Map;)Lcom/liveperson/infra/model/PushMessage;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.Liveperson.Infra.Model.PushMessage __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.PushMessage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Ljava_lang_String_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_parseBundle_Ljava_lang_String_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='PushMessageParser']/method[@name='parseBundle' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("parseBundle", "(Ljava/lang/String;Landroid/os/Bundle;)Lcom/liveperson/infra/model/PushMessage;", "")]
		public static unsafe global::Com.Liveperson.Infra.Model.PushMessage ParseBundle (string p0, global::Android.OS.Bundle p1)
		{
			if (id_parseBundle_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_parseBundle_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "parseBundle", "(Ljava/lang/String;Landroid/os/Bundle;)Lcom/liveperson/infra/model/PushMessage;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.Liveperson.Infra.Model.PushMessage __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.PushMessage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseBundle_Ljava_lang_String_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
