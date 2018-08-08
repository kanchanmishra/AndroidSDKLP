using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Commands.Tasks {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='MessagingEventSubscriptionManager']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/commands/tasks/MessagingEventSubscriptionManager", DoNotGenerateAcw=true)]
	public sealed partial class MessagingEventSubscriptionManager : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/commands/tasks/MessagingEventSubscriptionManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessagingEventSubscriptionManager); }
		}

		internal MessagingEventSubscriptionManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='MessagingEventSubscriptionManager']/constructor[@name='MessagingEventSubscriptionManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MessagingEventSubscriptionManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MessagingEventSubscriptionManager)) {
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

		static IntPtr id_getERROR_MESSAGE;
		public static unsafe string ERROR_MESSAGE {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='MessagingEventSubscriptionManager']/method[@name='getERROR_MESSAGE' and count(parameter)=0]"
			[Register ("getERROR_MESSAGE", "()Ljava/lang/String;", "GetGetERROR_MESSAGEHandler")]
			get {
				if (id_getERROR_MESSAGE == IntPtr.Zero)
					id_getERROR_MESSAGE = JNIEnv.GetStaticMethodID (class_ref, "getERROR_MESSAGE", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getERROR_MESSAGE), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMESSAGE_EVENT_COMPLETED;
		public static unsafe string MESSAGE_EVENT_COMPLETED {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='MessagingEventSubscriptionManager']/method[@name='getMESSAGE_EVENT_COMPLETED' and count(parameter)=0]"
			[Register ("getMESSAGE_EVENT_COMPLETED", "()Ljava/lang/String;", "GetGetMESSAGE_EVENT_COMPLETEDHandler")]
			get {
				if (id_getMESSAGE_EVENT_COMPLETED == IntPtr.Zero)
					id_getMESSAGE_EVENT_COMPLETED = JNIEnv.GetStaticMethodID (class_ref, "getMESSAGE_EVENT_COMPLETED", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMESSAGE_EVENT_COMPLETED), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSUCCESS;
		public static unsafe string SUCCESS {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='MessagingEventSubscriptionManager']/method[@name='getSUCCESS' and count(parameter)=0]"
			[Register ("getSUCCESS", "()Ljava/lang/String;", "GetGetSUCCESSHandler")]
			get {
				if (id_getSUCCESS == IntPtr.Zero)
					id_getSUCCESS = JNIEnv.GetStaticMethodID (class_ref, "getSUCCESS", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSUCCESS), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_addSubscription_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='MessagingEventSubscriptionManager']/method[@name='addSubscription' and count(parameter)=5 and parameter[1][@type='com.liveperson.messaging.Messaging'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
		[Register ("addSubscription", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;IZ)V", "")]
		public unsafe void AddSubscription (global::Com.Liveperson.Messaging.Messaging p0, string p1, string p2, int p3, bool p4)
		{
			if (id_addSubscription_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_IZ == IntPtr.Zero)
				id_addSubscription_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_IZ = JNIEnv.GetMethodID (class_ref, "addSubscription", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;IZ)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addSubscription_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_IZ, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_clearAllSubscriptions;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='MessagingEventSubscriptionManager']/method[@name='clearAllSubscriptions' and count(parameter)=0]"
		[Register ("clearAllSubscriptions", "()V", "")]
		public unsafe void ClearAllSubscriptions ()
		{
			if (id_clearAllSubscriptions == IntPtr.Zero)
				id_clearAllSubscriptions = JNIEnv.GetMethodID (class_ref, "clearAllSubscriptions", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearAllSubscriptions);
			} finally {
			}
		}

		static IntPtr id_onReceivedEvent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='MessagingEventSubscriptionManager']/method[@name='onReceivedEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onReceivedEvent", "(Ljava/lang/String;)Z", "")]
		public unsafe bool OnReceivedEvent (string p0)
		{
			if (id_onReceivedEvent_Ljava_lang_String_ == IntPtr.Zero)
				id_onReceivedEvent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onReceivedEvent", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onReceivedEvent_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_shouldUpdateUI_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='MessagingEventSubscriptionManager']/method[@name='shouldUpdateUI' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("shouldUpdateUI", "(Ljava/lang/String;)Z", "")]
		public unsafe bool ShouldUpdateUI (string p0)
		{
			if (id_shouldUpdateUI_Ljava_lang_String_ == IntPtr.Zero)
				id_shouldUpdateUI_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "shouldUpdateUI", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_shouldUpdateUI_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
