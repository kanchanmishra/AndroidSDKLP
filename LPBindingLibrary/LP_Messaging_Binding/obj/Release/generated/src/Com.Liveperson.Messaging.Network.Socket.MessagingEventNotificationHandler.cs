using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Network.Socket {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='MessagingEventNotificationHandler']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/network/socket/MessagingEventNotificationHandler", DoNotGenerateAcw=true)]
	public sealed partial class MessagingEventNotificationHandler : global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='MessagingEventNotificationHandler.Companion']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/network/socket/MessagingEventNotificationHandler$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/network/socket/MessagingEventNotificationHandler$Companion", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Companion); }
			}

			internal Companion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getAGENT_TYPING_ACTION;
			public unsafe string AGENT_TYPING_ACTION {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='MessagingEventNotificationHandler.Companion']/method[@name='getAGENT_TYPING_ACTION' and count(parameter)=0]"
				[Register ("getAGENT_TYPING_ACTION", "()Ljava/lang/String;", "GetGetAGENT_TYPING_ACTIONHandler")]
				get {
					if (id_getAGENT_TYPING_ACTION == IntPtr.Zero)
						id_getAGENT_TYPING_ACTION = JNIEnv.GetMethodID (class_ref, "getAGENT_TYPING_ACTION", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAGENT_TYPING_ACTION), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_getAGENT_TYPING_ACTION_IS_TYPING_EXTRA;
			public unsafe string AGENT_TYPING_ACTION_IS_TYPING_EXTRA {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='MessagingEventNotificationHandler.Companion']/method[@name='getAGENT_TYPING_ACTION_IS_TYPING_EXTRA' and count(parameter)=0]"
				[Register ("getAGENT_TYPING_ACTION_IS_TYPING_EXTRA", "()Ljava/lang/String;", "GetGetAGENT_TYPING_ACTION_IS_TYPING_EXTRAHandler")]
				get {
					if (id_getAGENT_TYPING_ACTION_IS_TYPING_EXTRA == IntPtr.Zero)
						id_getAGENT_TYPING_ACTION_IS_TYPING_EXTRA = JNIEnv.GetMethodID (class_ref, "getAGENT_TYPING_ACTION_IS_TYPING_EXTRA", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAGENT_TYPING_ACTION_IS_TYPING_EXTRA), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_getORIGINATOR_ID_EXTRA;
			public unsafe string ORIGINATOR_ID_EXTRA {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='MessagingEventNotificationHandler.Companion']/method[@name='getORIGINATOR_ID_EXTRA' and count(parameter)=0]"
				[Register ("getORIGINATOR_ID_EXTRA", "()Ljava/lang/String;", "GetGetORIGINATOR_ID_EXTRAHandler")]
				get {
					if (id_getORIGINATOR_ID_EXTRA == IntPtr.Zero)
						id_getORIGINATOR_ID_EXTRA = JNIEnv.GetMethodID (class_ref, "getORIGINATOR_ID_EXTRA", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getORIGINATOR_ID_EXTRA), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='MessagingEventNotificationHandler.WhenMappings']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/network/socket/MessagingEventNotificationHandler$WhenMappings", DoNotGenerateAcw=true)]
		public sealed partial class WhenMappings : global::Java.Lang.Object {


			static IntPtr $EnumSwitchMapping$0_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='MessagingEventNotificationHandler.WhenMappings']/field[@name='$EnumSwitchMapping$0']"
			[Register ("$EnumSwitchMapping$0")]
			public static IList<int> $EnumSwitchMapping$0 {
				get {
					if ($EnumSwitchMapping$0_jfieldId == IntPtr.Zero)
						$EnumSwitchMapping$0_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "$EnumSwitchMapping$0", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, $EnumSwitchMapping$0_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr $EnumSwitchMapping$1_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='MessagingEventNotificationHandler.WhenMappings']/field[@name='$EnumSwitchMapping$1']"
			[Register ("$EnumSwitchMapping$1")]
			public static IList<int> $EnumSwitchMapping$1 {
				get {
					if ($EnumSwitchMapping$1_jfieldId == IntPtr.Zero)
						$EnumSwitchMapping$1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "$EnumSwitchMapping$1", "[I");
					return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, $EnumSwitchMapping$1_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/network/socket/MessagingEventNotificationHandler$WhenMappings", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (WhenMappings); }
			}

			internal WhenMappings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/network/socket/MessagingEventNotificationHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessagingEventNotificationHandler); }
		}

		internal MessagingEventNotificationHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_Messaging_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='MessagingEventNotificationHandler']/constructor[@name='MessagingEventNotificationHandler' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.Messaging']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/Messaging;)V", "")]
		public unsafe MessagingEventNotificationHandler (global::Com.Liveperson.Messaging.Messaging p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MessagingEventNotificationHandler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/Messaging;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/Messaging;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_Messaging_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_Messaging_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/Messaging;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_, __args);
			} finally {
			}
		}

		static IntPtr id_getAPIResponseType;
		public override unsafe string APIResponseType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='MessagingEventNotificationHandler']/method[@name='getAPIResponseType' and count(parameter)=0]"
			[Register ("getAPIResponseType", "()Ljava/lang/String;", "GetGetAPIResponseTypeHandler")]
			get {
				if (id_getAPIResponseType == IntPtr.Zero)
					id_getAPIResponseType = JNIEnv.GetMethodID (class_ref, "getAPIResponseType", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAPIResponseType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMController$messaging_debug;
		static IntPtr id_setMController$messaging_debug_Lcom_liveperson_messaging_Messaging_;
		public unsafe global::Com.Liveperson.Messaging.Messaging MController$messaging_debug {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='MessagingEventNotificationHandler']/method[@name='getMController$messaging_debug' and count(parameter)=0]"
			[Register ("getMController$messaging_debug", "()Lcom/liveperson/messaging/Messaging;", "GetGetMController$messaging_debugHandler")]
			get {
				if (id_getMController$messaging_debug == IntPtr.Zero)
					id_getMController$messaging_debug = JNIEnv.GetMethodID (class_ref, "getMController$messaging_debug", "()Lcom/liveperson/messaging/Messaging;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMController$messaging_debug), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='MessagingEventNotificationHandler']/method[@name='setMController$messaging_debug' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.Messaging']]"
			[Register ("setMController$messaging_debug", "(Lcom/liveperson/messaging/Messaging;)V", "GetSetMController$messaging_debug_Lcom_liveperson_messaging_Messaging_Handler")]
			set {
				if (id_setMController$messaging_debug_Lcom_liveperson_messaging_Messaging_ == IntPtr.Zero)
					id_setMController$messaging_debug_Lcom_liveperson_messaging_Messaging_ = JNIEnv.GetMethodID (class_ref, "setMController$messaging_debug", "(Lcom/liveperson/messaging/Messaging;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMController$messaging_debug_Lcom_liveperson_messaging_Messaging_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getTAG;
		public unsafe string TAG {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='MessagingEventNotificationHandler']/method[@name='getTAG' and count(parameter)=0]"
			[Register ("getTAG", "()Ljava/lang/String;", "GetGetTAGHandler")]
			get {
				if (id_getTAG == IntPtr.Zero)
					id_getTAG = JNIEnv.GetMethodID (class_ref, "getTAG", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTAG), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_extractLinks_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket']/class[@name='MessagingEventNotificationHandler']/method[@name='extractLinks' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("extractLinks", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		public unsafe string[] ExtractLinks (string p0)
		{
			if (id_extractLinks_Ljava_lang_String_ == IntPtr.Zero)
				id_extractLinks_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "extractLinks", "(Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_extractLinks_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
