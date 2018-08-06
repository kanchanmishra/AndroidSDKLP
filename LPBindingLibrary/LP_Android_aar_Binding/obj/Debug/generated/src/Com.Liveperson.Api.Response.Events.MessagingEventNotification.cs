using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Response.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='MessagingEventNotification']"
	[global::Android.Runtime.Register ("com/liveperson/api/response/events/MessagingEventNotification", DoNotGenerateAcw=true)]
	public sealed partial class MessagingEventNotification : global::Com.Liveperson.Api.Response.AbstractResponse {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='MessagingEventNotification.Companion']"
		[global::Android.Runtime.Register ("com/liveperson/api/response/events/MessagingEventNotification$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/api/response/events/MessagingEventNotification$Companion", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Companion); }
			}

			internal Companion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getMESSAGING_EVENT_NOTIFICATION_TYPE;
			public unsafe string MESSAGING_EVENT_NOTIFICATION_TYPE {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='MessagingEventNotification.Companion']/method[@name='getMESSAGING_EVENT_NOTIFICATION_TYPE' and count(parameter)=0]"
				[Register ("getMESSAGING_EVENT_NOTIFICATION_TYPE", "()Ljava/lang/String;", "GetGetMESSAGING_EVENT_NOTIFICATION_TYPEHandler")]
				get {
					if (id_getMESSAGING_EVENT_NOTIFICATION_TYPE == IntPtr.Zero)
						id_getMESSAGING_EVENT_NOTIFICATION_TYPE = JNIEnv.GetMethodID (class_ref, "getMESSAGING_EVENT_NOTIFICATION_TYPE", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMESSAGING_EVENT_NOTIFICATION_TYPE), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_getType;
			public unsafe string Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='MessagingEventNotification.Companion']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
				get {
					if (id_getType == IntPtr.Zero)
						id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_getResponseHandler_Lcom_liveperson_messaging_Messaging_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='MessagingEventNotification.Companion']/method[@name='getResponseHandler' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.Messaging']]"
			[Register ("getResponseHandler", "(Lcom/liveperson/messaging/Messaging;)Lcom/liveperson/messaging/network/socket/MessagingEventNotificationHandler;", "")]
			public unsafe global::Com.Liveperson.Messaging.Network.Socket.MessagingEventNotificationHandler GetResponseHandler (global::Com.Liveperson.Messaging.Messaging p0)
			{
				if (id_getResponseHandler_Lcom_liveperson_messaging_Messaging_ == IntPtr.Zero)
					id_getResponseHandler_Lcom_liveperson_messaging_Messaging_ = JNIEnv.GetMethodID (class_ref, "getResponseHandler", "(Lcom/liveperson/messaging/Messaging;)Lcom/liveperson/messaging/network/socket/MessagingEventNotificationHandler;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Liveperson.Messaging.Network.Socket.MessagingEventNotificationHandler __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.MessagingEventNotificationHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseHandler_Lcom_liveperson_messaging_Messaging_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/response/events/MessagingEventNotification", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessagingEventNotification); }
		}

		internal MessagingEventNotification (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='MessagingEventNotification']/constructor[@name='MessagingEventNotification' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe MessagingEventNotification (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MessagingEventNotification)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/json/JSONObject;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/json/JSONObject;)V", __args);
					return;
				}

				if (id_ctor_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_ctor_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/json/JSONObject;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_json_JSONObject_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_json_JSONObject_, __args);
			} finally {
			}
		}

		static IntPtr id_getBody;
		public unsafe global::System.Collections.Generic.IList<global::Com.Liveperson.Api.Response.Events.ContentEventNotification> Body {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='MessagingEventNotification']/method[@name='getBody' and count(parameter)=0]"
			[Register ("getBody", "()Ljava/util/ArrayList;", "GetGetBodyHandler")]
			get {
				if (id_getBody == IntPtr.Zero)
					id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()Ljava/util/ArrayList;");
				try {
					return global::Android.Runtime.JavaList<global::Com.Liveperson.Api.Response.Events.ContentEventNotification>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBody), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getTAG;
		public unsafe string TAG {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='MessagingEventNotification']/method[@name='getTAG' and count(parameter)=0]"
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

		static IntPtr id_getType;
		public static unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='MessagingEventNotification']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetStaticMethodID (class_ref, "getType", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getResponseHandler_Lcom_liveperson_messaging_Messaging_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='MessagingEventNotification']/method[@name='getResponseHandler' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.Messaging']]"
		[Register ("getResponseHandler", "(Lcom/liveperson/messaging/Messaging;)Lcom/liveperson/messaging/network/socket/MessagingEventNotificationHandler;", "")]
		public static unsafe global::Com.Liveperson.Messaging.Network.Socket.MessagingEventNotificationHandler GetResponseHandler (global::Com.Liveperson.Messaging.Messaging p0)
		{
			if (id_getResponseHandler_Lcom_liveperson_messaging_Messaging_ == IntPtr.Zero)
				id_getResponseHandler_Lcom_liveperson_messaging_Messaging_ = JNIEnv.GetStaticMethodID (class_ref, "getResponseHandler", "(Lcom/liveperson/messaging/Messaging;)Lcom/liveperson/messaging/network/socket/MessagingEventNotificationHandler;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Liveperson.Messaging.Network.Socket.MessagingEventNotificationHandler __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.MessagingEventNotificationHandler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getResponseHandler_Lcom_liveperson_messaging_Messaging_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
