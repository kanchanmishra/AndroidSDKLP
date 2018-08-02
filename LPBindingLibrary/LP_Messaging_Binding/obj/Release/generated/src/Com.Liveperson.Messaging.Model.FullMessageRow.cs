using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FullMessageRow']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/model/FullMessageRow", DoNotGenerateAcw=true)]
	public partial class FullMessageRow : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FullMessageRow']/field[@name='EXTRA_AGENT_AVATAR']"
		[Register ("EXTRA_AGENT_AVATAR")]
		public const string ExtraAgentAvatar = (string) "EXTRA_AGENT_AVATAR";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FullMessageRow']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "FullMessageRow";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/model/FullMessageRow", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FullMessageRow); }
		}

		protected FullMessageRow (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_model_MessagingChatMessage_Ljava_lang_String_Lcom_liveperson_messaging_model_FileMessage_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FullMessageRow']/constructor[@name='FullMessageRow' and count(parameter)=3 and parameter[1][@type='com.liveperson.messaging.model.MessagingChatMessage'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.messaging.model.FileMessage']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/model/MessagingChatMessage;Ljava/lang/String;Lcom/liveperson/messaging/model/FileMessage;)V", "")]
		public unsafe FullMessageRow (global::Com.Liveperson.Messaging.Model.MessagingChatMessage p0, string p1, global::Com.Liveperson.Messaging.Model.FileMessage p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (FullMessageRow)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/model/MessagingChatMessage;Ljava/lang/String;Lcom/liveperson/messaging/model/FileMessage;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/model/MessagingChatMessage;Ljava/lang/String;Lcom/liveperson/messaging/model/FileMessage;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_model_MessagingChatMessage_Ljava_lang_String_Lcom_liveperson_messaging_model_FileMessage_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_model_MessagingChatMessage_Ljava_lang_String_Lcom_liveperson_messaging_model_FileMessage_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/model/MessagingChatMessage;Ljava/lang/String;Lcom/liveperson/messaging/model/FileMessage;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_model_MessagingChatMessage_Ljava_lang_String_Lcom_liveperson_messaging_model_FileMessage_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_model_MessagingChatMessage_Ljava_lang_String_Lcom_liveperson_messaging_model_FileMessage_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Landroid_database_Cursor_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FullMessageRow']/constructor[@name='FullMessageRow' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register (".ctor", "(Landroid/database/Cursor;)V", "")]
		public unsafe FullMessageRow (global::Android.Database.ICursor p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (FullMessageRow)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/database/Cursor;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/database/Cursor;)V", __args);
					return;
				}

				if (id_ctor_Landroid_database_Cursor_ == IntPtr.Zero)
					id_ctor_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/database/Cursor;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_database_Cursor_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_database_Cursor_, __args);
			} finally {
			}
		}

		static Delegate cb_getAgentAvatar;
#pragma warning disable 0169
		static Delegate GetGetAgentAvatarHandler ()
		{
			if (cb_getAgentAvatar == null)
				cb_getAgentAvatar = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAgentAvatar);
			return cb_getAgentAvatar;
		}

		static IntPtr n_GetAgentAvatar (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.FullMessageRow __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FullMessageRow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AgentAvatar);
		}
#pragma warning restore 0169

		static IntPtr id_getAgentAvatar;
		public virtual unsafe string AgentAvatar {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FullMessageRow']/method[@name='getAgentAvatar' and count(parameter)=0]"
			[Register ("getAgentAvatar", "()Ljava/lang/String;", "GetGetAgentAvatarHandler")]
			get {
				if (id_getAgentAvatar == IntPtr.Zero)
					id_getAgentAvatar = JNIEnv.GetMethodID (class_ref, "getAgentAvatar", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAgentAvatar), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAgentAvatar", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFileMessage;
#pragma warning disable 0169
		static Delegate GetGetFileMessageHandler ()
		{
			if (cb_getFileMessage == null)
				cb_getFileMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileMessage);
			return cb_getFileMessage;
		}

		static IntPtr n_GetFileMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.FullMessageRow __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FullMessageRow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FileMessage);
		}
#pragma warning restore 0169

		static IntPtr id_getFileMessage;
		public virtual unsafe global::Com.Liveperson.Messaging.Model.FileMessage FileMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FullMessageRow']/method[@name='getFileMessage' and count(parameter)=0]"
			[Register ("getFileMessage", "()Lcom/liveperson/messaging/model/FileMessage;", "GetGetFileMessageHandler")]
			get {
				if (id_getFileMessage == IntPtr.Zero)
					id_getFileMessage = JNIEnv.GetMethodID (class_ref, "getFileMessage", "()Lcom/liveperson/messaging/model/FileMessage;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FileMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFileMessage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FileMessage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileMessage", "()Lcom/liveperson/messaging/model/FileMessage;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMessagingChatMessage;
#pragma warning disable 0169
		static Delegate GetGetMessagingChatMessageHandler ()
		{
			if (cb_getMessagingChatMessage == null)
				cb_getMessagingChatMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessagingChatMessage);
			return cb_getMessagingChatMessage;
		}

		static IntPtr n_GetMessagingChatMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.FullMessageRow __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FullMessageRow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MessagingChatMessage);
		}
#pragma warning restore 0169

		static IntPtr id_getMessagingChatMessage;
		public virtual unsafe global::Com.Liveperson.Messaging.Model.MessagingChatMessage MessagingChatMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FullMessageRow']/method[@name='getMessagingChatMessage' and count(parameter)=0]"
			[Register ("getMessagingChatMessage", "()Lcom/liveperson/messaging/model/MessagingChatMessage;", "GetGetMessagingChatMessageHandler")]
			get {
				if (id_getMessagingChatMessage == IntPtr.Zero)
					id_getMessagingChatMessage = JNIEnv.GetMethodID (class_ref, "getMessagingChatMessage", "()Lcom/liveperson/messaging/model/MessagingChatMessage;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessagingChatMessage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessagingChatMessage", "()Lcom/liveperson/messaging/model/MessagingChatMessage;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRootElement;
#pragma warning disable 0169
		static Delegate GetGetRootElementHandler ()
		{
			if (cb_getRootElement == null)
				cb_getRootElement = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRootElement);
			return cb_getRootElement;
		}

		static IntPtr n_GetRootElement (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.FullMessageRow __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FullMessageRow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RootElement);
		}
#pragma warning restore 0169

		static Delegate cb_setRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_;
#pragma warning disable 0169
		static Delegate GetSetRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Handler ()
		{
			if (cb_setRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_ == null)
				cb_setRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_);
			return cb_setRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_;
		}

		static void n_SetRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.FullMessageRow __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FullMessageRow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RootElement = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRootElement;
		static IntPtr id_setRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_;
		public virtual unsafe global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement RootElement {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FullMessageRow']/method[@name='getRootElement' and count(parameter)=0]"
			[Register ("getRootElement", "()Lcom/liveperson/messaging/structuredcontent/model/elements/SimpleElement;", "GetGetRootElementHandler")]
			get {
				if (id_getRootElement == IntPtr.Zero)
					id_getRootElement = JNIEnv.GetMethodID (class_ref, "getRootElement", "()Lcom/liveperson/messaging/structuredcontent/model/elements/SimpleElement;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRootElement), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRootElement", "()Lcom/liveperson/messaging/structuredcontent/model/elements/SimpleElement;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FullMessageRow']/method[@name='setRootElement' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.SimpleElement']]"
			[Register ("setRootElement", "(Lcom/liveperson/messaging/structuredcontent/model/elements/SimpleElement;)V", "GetSetRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Handler")]
			set {
				if (id_setRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_ == IntPtr.Zero)
					id_setRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_ = JNIEnv.GetMethodID (class_ref, "setRootElement", "(Lcom/liveperson/messaging/structuredcontent/model/elements/SimpleElement;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRootElement", "(Lcom/liveperson/messaging/structuredcontent/model/elements/SimpleElement;)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_generateAgentQuickReplyMessage_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FullMessageRow']/method[@name='generateAgentQuickReplyMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("generateAgentQuickReplyMessage", "(Ljava/lang/String;J)Lcom/liveperson/messaging/model/FullMessageRow;", "")]
		public static unsafe global::Com.Liveperson.Messaging.Model.FullMessageRow GenerateAgentQuickReplyMessage (string p0, long p1)
		{
			if (id_generateAgentQuickReplyMessage_Ljava_lang_String_J == IntPtr.Zero)
				id_generateAgentQuickReplyMessage_Ljava_lang_String_J = JNIEnv.GetStaticMethodID (class_ref, "generateAgentQuickReplyMessage", "(Ljava/lang/String;J)Lcom/liveperson/messaging/model/FullMessageRow;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.Liveperson.Messaging.Model.FullMessageRow __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FullMessageRow> (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateAgentQuickReplyMessage_Ljava_lang_String_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_generateAgentTypingIndicatorMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FullMessageRow']/method[@name='generateAgentTypingIndicatorMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("generateAgentTypingIndicatorMessage", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/FullMessageRow;", "")]
		public static unsafe global::Com.Liveperson.Messaging.Model.FullMessageRow GenerateAgentTypingIndicatorMessage (string p0)
		{
			if (id_generateAgentTypingIndicatorMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_generateAgentTypingIndicatorMessage_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "generateAgentTypingIndicatorMessage", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/FullMessageRow;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Messaging.Model.FullMessageRow __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FullMessageRow> (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateAgentTypingIndicatorMessage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_generateUnreadIndicatorMessage_Landroid_content_Context_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FullMessageRow']/method[@name='generateUnreadIndicatorMessage' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("generateUnreadIndicatorMessage", "(Landroid/content/Context;IJ)Lcom/liveperson/messaging/model/FullMessageRow;", "")]
		public static unsafe global::Com.Liveperson.Messaging.Model.FullMessageRow GenerateUnreadIndicatorMessage (global::Android.Content.Context p0, int p1, long p2)
		{
			if (id_generateUnreadIndicatorMessage_Landroid_content_Context_IJ == IntPtr.Zero)
				id_generateUnreadIndicatorMessage_Landroid_content_Context_IJ = JNIEnv.GetStaticMethodID (class_ref, "generateUnreadIndicatorMessage", "(Landroid/content/Context;IJ)Lcom/liveperson/messaging/model/FullMessageRow;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Liveperson.Messaging.Model.FullMessageRow __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FullMessageRow> (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateUnreadIndicatorMessage_Landroid_content_Context_IJ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDummyMessage_Landroid_content_Context_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FullMessageRow']/method[@name='getDummyMessage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long']]"
		[Register ("getDummyMessage", "(Landroid/content/Context;J)Lcom/liveperson/messaging/model/FullMessageRow;", "")]
		public static unsafe global::Com.Liveperson.Messaging.Model.FullMessageRow GetDummyMessage (global::Android.Content.Context p0, long p1)
		{
			if (id_getDummyMessage_Landroid_content_Context_J == IntPtr.Zero)
				id_getDummyMessage_Landroid_content_Context_J = JNIEnv.GetStaticMethodID (class_ref, "getDummyMessage", "(Landroid/content/Context;J)Lcom/liveperson/messaging/model/FullMessageRow;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Liveperson.Messaging.Model.FullMessageRow __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FullMessageRow> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDummyMessage_Landroid_content_Context_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getLoadingHistoryIndicatorMessage_Landroid_content_Context_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FullMessageRow']/method[@name='getLoadingHistoryIndicatorMessage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long']]"
		[Register ("getLoadingHistoryIndicatorMessage", "(Landroid/content/Context;J)Lcom/liveperson/messaging/model/FullMessageRow;", "")]
		public static unsafe global::Com.Liveperson.Messaging.Model.FullMessageRow GetLoadingHistoryIndicatorMessage (global::Android.Content.Context p0, long p1)
		{
			if (id_getLoadingHistoryIndicatorMessage_Landroid_content_Context_J == IntPtr.Zero)
				id_getLoadingHistoryIndicatorMessage_Landroid_content_Context_J = JNIEnv.GetStaticMethodID (class_ref, "getLoadingHistoryIndicatorMessage", "(Landroid/content/Context;J)Lcom/liveperson/messaging/model/FullMessageRow;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Liveperson.Messaging.Model.FullMessageRow __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FullMessageRow> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLoadingHistoryIndicatorMessage_Landroid_content_Context_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getLoadingIndicatorMessage_Landroid_content_Context_JZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FullMessageRow']/method[@name='getLoadingIndicatorMessage' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long'] and parameter[3][@type='boolean']]"
		[Register ("getLoadingIndicatorMessage", "(Landroid/content/Context;JZ)Lcom/liveperson/messaging/model/FullMessageRow;", "")]
		public static unsafe global::Com.Liveperson.Messaging.Model.FullMessageRow GetLoadingIndicatorMessage (global::Android.Content.Context p0, long p1, bool p2)
		{
			if (id_getLoadingIndicatorMessage_Landroid_content_Context_JZ == IntPtr.Zero)
				id_getLoadingIndicatorMessage_Landroid_content_Context_JZ = JNIEnv.GetStaticMethodID (class_ref, "getLoadingIndicatorMessage", "(Landroid/content/Context;JZ)Lcom/liveperson/messaging/model/FullMessageRow;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Liveperson.Messaging.Model.FullMessageRow __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FullMessageRow> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLoadingIndicatorMessage_Landroid_content_Context_JZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getLoadingIndicatorMessageDiff_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FullMessageRow']/method[@name='getLoadingIndicatorMessageDiff' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getLoadingIndicatorMessageDiff", "(Landroid/content/Context;)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle GetLoadingIndicatorMessageDiff (global::Android.Content.Context p0)
		{
			if (id_getLoadingIndicatorMessageDiff_Landroid_content_Context_ == IntPtr.Zero)
				id_getLoadingIndicatorMessageDiff_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getLoadingIndicatorMessageDiff", "(Landroid/content/Context;)Landroid/os/Bundle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLoadingIndicatorMessageDiff_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getMessageDetails_Lcom_liveperson_messaging_model_FullMessageRow_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FullMessageRow']/method[@name='getMessageDetails' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.FullMessageRow']]"
		[Register ("getMessageDetails", "(Lcom/liveperson/messaging/model/FullMessageRow;)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle GetMessageDetails (global::Com.Liveperson.Messaging.Model.FullMessageRow p0)
		{
			if (id_getMessageDetails_Lcom_liveperson_messaging_model_FullMessageRow_ == IntPtr.Zero)
				id_getMessageDetails_Lcom_liveperson_messaging_model_FullMessageRow_ = JNIEnv.GetStaticMethodID (class_ref, "getMessageDetails", "(Lcom/liveperson/messaging/model/FullMessageRow;)Landroid/os/Bundle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMessageDetails_Lcom_liveperson_messaging_model_FullMessageRow_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_newerThan_Lcom_liveperson_messaging_model_FullMessageRow_;
#pragma warning disable 0169
		static Delegate GetNewerThan_Lcom_liveperson_messaging_model_FullMessageRow_Handler ()
		{
			if (cb_newerThan_Lcom_liveperson_messaging_model_FullMessageRow_ == null)
				cb_newerThan_Lcom_liveperson_messaging_model_FullMessageRow_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_NewerThan_Lcom_liveperson_messaging_model_FullMessageRow_);
			return cb_newerThan_Lcom_liveperson_messaging_model_FullMessageRow_;
		}

		static int n_NewerThan_Lcom_liveperson_messaging_model_FullMessageRow_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.FullMessageRow __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FullMessageRow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.FullMessageRow p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FullMessageRow> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.NewerThan (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newerThan_Lcom_liveperson_messaging_model_FullMessageRow_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FullMessageRow']/method[@name='newerThan' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.FullMessageRow']]"
		[Register ("newerThan", "(Lcom/liveperson/messaging/model/FullMessageRow;)I", "GetNewerThan_Lcom_liveperson_messaging_model_FullMessageRow_Handler")]
		public virtual unsafe int NewerThan (global::Com.Liveperson.Messaging.Model.FullMessageRow p0)
		{
			if (id_newerThan_Lcom_liveperson_messaging_model_FullMessageRow_ == IntPtr.Zero)
				id_newerThan_Lcom_liveperson_messaging_model_FullMessageRow_ = JNIEnv.GetMethodID (class_ref, "newerThan", "(Lcom/liveperson/messaging/model/FullMessageRow;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_newerThan_Lcom_liveperson_messaging_model_FullMessageRow_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newerThan", "(Lcom/liveperson/messaging/model/FullMessageRow;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_update_Lcom_liveperson_messaging_model_FullMessageRow_;
#pragma warning disable 0169
		static Delegate GetUpdate_Lcom_liveperson_messaging_model_FullMessageRow_Handler ()
		{
			if (cb_update_Lcom_liveperson_messaging_model_FullMessageRow_ == null)
				cb_update_Lcom_liveperson_messaging_model_FullMessageRow_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Update_Lcom_liveperson_messaging_model_FullMessageRow_);
			return cb_update_Lcom_liveperson_messaging_model_FullMessageRow_;
		}

		static IntPtr n_Update_Lcom_liveperson_messaging_model_FullMessageRow_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.FullMessageRow __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FullMessageRow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.FullMessageRow p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FullMessageRow> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Update (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_update_Lcom_liveperson_messaging_model_FullMessageRow_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FullMessageRow']/method[@name='update' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.FullMessageRow']]"
		[Register ("update", "(Lcom/liveperson/messaging/model/FullMessageRow;)Landroid/os/Bundle;", "GetUpdate_Lcom_liveperson_messaging_model_FullMessageRow_Handler")]
		public virtual unsafe global::Android.OS.Bundle Update (global::Com.Liveperson.Messaging.Model.FullMessageRow p0)
		{
			if (id_update_Lcom_liveperson_messaging_model_FullMessageRow_ == IntPtr.Zero)
				id_update_Lcom_liveperson_messaging_model_FullMessageRow_ = JNIEnv.GetMethodID (class_ref, "update", "(Lcom/liveperson/messaging/model/FullMessageRow;)Landroid/os/Bundle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.OS.Bundle __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_update_Lcom_liveperson_messaging_model_FullMessageRow_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "update", "(Lcom/liveperson/messaging/model/FullMessageRow;)Landroid/os/Bundle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
