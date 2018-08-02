using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Structuredcontent.Parsers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.parsers']/class[@name='ElementParser']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/structuredcontent/parsers/ElementParser", DoNotGenerateAcw=true)]
	public partial class ElementParser : global::Java.Lang.Object {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.parsers']/class[@name='ElementParser']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/structuredcontent/parsers/ElementParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ElementParser); }
		}

		protected ElementParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.parsers']/class[@name='ElementParser']/constructor[@name='ElementParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ElementParser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ElementParser)) {
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

		static IntPtr id_parse_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.parsers']/class[@name='ElementParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("parse", "(Lorg/json/JSONObject;)Lcom/liveperson/messaging/structuredcontent/model/elements/SimpleElement;", "")]
		public static unsafe global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement Parse (global::Org.Json.JSONObject p0)
		{
			if (id_parse_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_parse_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Lorg/json/JSONObject;)Lcom/liveperson/messaging/structuredcontent/model/elements/SimpleElement;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
