using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Notification {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.notification']/class[@name='NotificationController']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/notification/NotificationController", DoNotGenerateAcw=true)]
	public sealed partial class NotificationController : global::Java.Lang.Enum, global::Com.Liveperson.Infra.IClearable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.notification']/class[@name='NotificationController']/field[@name='ACTION_LP_UPDATE_NUM_UNREAD_MESSAGES_ACTION']"
		[Register ("ACTION_LP_UPDATE_NUM_UNREAD_MESSAGES_ACTION")]
		public const string ActionLpUpdateNumUnreadMessagesAction = (string) "ACTION_LP_UPDATE_NUM_UNREAD_MESSAGES_ACTION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.notification']/class[@name='NotificationController']/field[@name='ACTION_LP_UPDATE_NUM_UNREAD_MESSAGES_EXTRA']"
		[Register ("ACTION_LP_UPDATE_NUM_UNREAD_MESSAGES_EXTRA")]
		public const string ActionLpUpdateNumUnreadMessagesExtra = (string) "ACTION_LP_UPDATE_NUM_UNREAD_MESSAGES_EXTRA";

		static IntPtr instance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.notification']/class[@name='NotificationController']/field[@name='instance']"
		[Register ("instance")]
		public static global::Com.Liveperson.Infra.Messaging_ui.Notification.NotificationController Instance {
			get {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/liveperson/infra/messaging_ui/notification/NotificationController;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, instance_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Notification.NotificationController> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/notification/NotificationController", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NotificationController); }
		}

		internal NotificationController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_addMessageAndDisplayNotification_Landroid_content_Context_Ljava_lang_String_Lcom_liveperson_infra_model_PushMessage_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.notification']/class[@name='NotificationController']/method[@name='addMessageAndDisplayNotification' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.infra.model.PushMessage'] and parameter[4][@type='boolean'] and parameter[5][@type='int']]"
		[Register ("addMessageAndDisplayNotification", "(Landroid/content/Context;Ljava/lang/String;Lcom/liveperson/infra/model/PushMessage;ZI)V", "")]
		public unsafe void AddMessageAndDisplayNotification (global::Android.Content.Context p0, string p1, global::Com.Liveperson.Infra.Model.PushMessage p2, bool p3, int p4)
		{
			if (id_addMessageAndDisplayNotification_Landroid_content_Context_Ljava_lang_String_Lcom_liveperson_infra_model_PushMessage_ZI == IntPtr.Zero)
				id_addMessageAndDisplayNotification_Landroid_content_Context_Ljava_lang_String_Lcom_liveperson_infra_model_PushMessage_ZI = JNIEnv.GetMethodID (class_ref, "addMessageAndDisplayNotification", "(Landroid/content/Context;Ljava/lang/String;Lcom/liveperson/infra/model/PushMessage;ZI)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addMessageAndDisplayNotification_Landroid_content_Context_Ljava_lang_String_Lcom_liveperson_infra_model_PushMessage_ZI, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_addMessageToCounter_Ljava_lang_String_Lcom_liveperson_infra_model_PushMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.notification']/class[@name='NotificationController']/method[@name='addMessageToCounter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.model.PushMessage']]"
		[Register ("addMessageToCounter", "(Ljava/lang/String;Lcom/liveperson/infra/model/PushMessage;)I", "")]
		public unsafe int AddMessageToCounter (string p0, global::Com.Liveperson.Infra.Model.PushMessage p1)
		{
			if (id_addMessageToCounter_Ljava_lang_String_Lcom_liveperson_infra_model_PushMessage_ == IntPtr.Zero)
				id_addMessageToCounter_Ljava_lang_String_Lcom_liveperson_infra_model_PushMessage_ = JNIEnv.GetMethodID (class_ref, "addMessageToCounter", "(Ljava/lang/String;Lcom/liveperson/infra/model/PushMessage;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_addMessageToCounter_Ljava_lang_String_Lcom_liveperson_infra_model_PushMessage_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.notification']/class[@name='NotificationController']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
			} finally {
			}
		}

		static IntPtr id_clearMessagesForBrand_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.notification']/class[@name='NotificationController']/method[@name='clearMessagesForBrand' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("clearMessagesForBrand", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public unsafe void ClearMessagesForBrand (global::Android.Content.Context p0, string p1)
		{
			if (id_clearMessagesForBrand_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_clearMessagesForBrand_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "clearMessagesForBrand", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearMessagesForBrand_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getNumUnreadMessages_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.notification']/class[@name='NotificationController']/method[@name='getNumUnreadMessages' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getNumUnreadMessages", "(Ljava/lang/String;)I", "")]
		public unsafe int GetNumUnreadMessages (string p0)
		{
			if (id_getNumUnreadMessages_Ljava_lang_String_ == IntPtr.Zero)
				id_getNumUnreadMessages_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getNumUnreadMessages", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumUnreadMessages_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getNumUnreadMessages_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.notification']/class[@name='NotificationController']/method[@name='getNumUnreadMessages' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.infra.ICallback&lt;java.lang.Integer, java.lang.Exception&gt;']]"
		[Register ("getNumUnreadMessages", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V", "")]
		public unsafe void GetNumUnreadMessages (string p0, string p1, global::Com.Liveperson.Infra.ICallback p2)
		{
			if (id_getNumUnreadMessages_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ == IntPtr.Zero)
				id_getNumUnreadMessages_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ = JNIEnv.GetMethodID (class_ref, "getNumUnreadMessages", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getNumUnreadMessages_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.notification']/class[@name='NotificationController']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/messaging_ui/notification/NotificationController;", "")]
		public static unsafe global::Com.Liveperson.Infra.Messaging_ui.Notification.NotificationController ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/messaging_ui/notification/NotificationController;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Infra.Messaging_ui.Notification.NotificationController __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Notification.NotificationController> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.notification']/class[@name='NotificationController']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/liveperson/infra/messaging_ui/notification/NotificationController;", "")]
		public static unsafe global::Com.Liveperson.Infra.Messaging_ui.Notification.NotificationController[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/infra/messaging_ui/notification/NotificationController;");
			try {
				return (global::Com.Liveperson.Infra.Messaging_ui.Notification.NotificationController[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Infra.Messaging_ui.Notification.NotificationController));
			} finally {
			}
		}

	}
}
