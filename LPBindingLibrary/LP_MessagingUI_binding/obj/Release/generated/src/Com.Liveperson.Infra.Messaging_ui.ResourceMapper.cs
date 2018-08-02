using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='ResourceMapper']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/ResourceMapper", DoNotGenerateAcw=true)]
	public sealed partial class ResourceMapper : global::Java.Lang.Enum {


		static IntPtr INSTANCE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='ResourceMapper']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Liveperson.Infra.Messaging_ui.ResourceMapper Instance {
			get {
				if (INSTANCE_jfieldId == IntPtr.Zero)
					INSTANCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTANCE", "Lcom/liveperson/infra/messaging_ui/ResourceMapper;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSTANCE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.ResourceMapper> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='ResourceMapper']/field[@name='KEY_AGENT_CONVERSATION_BUBBLE_BG_COLOR']"
		[Register ("KEY_AGENT_CONVERSATION_BUBBLE_BG_COLOR")]
		public const string KeyAgentConversationBubbleBgColor = (string) "agent conversation bg color";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='ResourceMapper']/field[@name='KEY_CONVERSATION_BG_COLOR']"
		[Register ("KEY_CONVERSATION_BG_COLOR")]
		public const string KeyConversationBgColor = (string) "conversation bg color";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='ResourceMapper']/field[@name='VALUE_AGENT_CONVERSATION_BUBBLE_BG_COLOR']"
		[Register ("VALUE_AGENT_CONVERSATION_BUBBLE_BG_COLOR")]
		public const string ValueAgentConversationBubbleBgColor = (string) "agent conversation bg color";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='ResourceMapper']/field[@name='VALUE_CONVERSATION_BG_COLOR']"
		[Register ("VALUE_CONVERSATION_BG_COLOR")]
		public const string ValueConversationBgColor = (string) "conversation bg color";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/ResourceMapper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResourceMapper); }
		}

		internal ResourceMapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='ResourceMapper']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/messaging_ui/ResourceMapper;", "")]
		public static unsafe global::Com.Liveperson.Infra.Messaging_ui.ResourceMapper ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/messaging_ui/ResourceMapper;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.Liveperson.Infra.Messaging_ui.ResourceMapper __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.ResourceMapper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='ResourceMapper']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/liveperson/infra/messaging_ui/ResourceMapper;", "")]
		public static unsafe global::Com.Liveperson.Infra.Messaging_ui.ResourceMapper[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/infra/messaging_ui/ResourceMapper;");
			try {
				return (global::Com.Liveperson.Infra.Messaging_ui.ResourceMapper[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Infra.Messaging_ui.ResourceMapper));
			} finally {
			}
		}

	}
}
