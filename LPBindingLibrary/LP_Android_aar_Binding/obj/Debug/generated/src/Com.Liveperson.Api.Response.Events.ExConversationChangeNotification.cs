using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Response.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='ExConversationChangeNotification']"
	[global::Android.Runtime.Register ("com/liveperson/api/response/events/ExConversationChangeNotification", DoNotGenerateAcw=true)]
	public partial class ExConversationChangeNotification : global::Com.Liveperson.Api.Response.AbstractResponse {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='ExConversationChangeNotification']/field[@name='CONVERSATION_CHANGE_NOTIFICATION_TYPE']"
		[Register ("CONVERSATION_CHANGE_NOTIFICATION_TYPE")]
		public const string ConversationChangeNotificationType = (string) "cqm.ExConversationChangeNotification";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='ExConversationChangeNotification.Body']"
		[global::Android.Runtime.Register ("com/liveperson/api/response/events/ExConversationChangeNotification$Body", DoNotGenerateAcw=true)]
		public partial class Body : global::Java.Lang.Object {


			static IntPtr changes_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='ExConversationChangeNotification.Body']/field[@name='changes']"
			[Register ("changes")]
			public IList<Com.Liveperson.Api.Response.Model.Change> Changes {
				get {
					if (changes_jfieldId == IntPtr.Zero)
						changes_jfieldId = JNIEnv.GetFieldID (class_ref, "changes", "[Lcom/liveperson/api/response/model/Change;");
					return global::Android.Runtime.JavaArray<global::Com.Liveperson.Api.Response.Model.Change>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, changes_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (changes_jfieldId == IntPtr.Zero)
						changes_jfieldId = JNIEnv.GetFieldID (class_ref, "changes", "[Lcom/liveperson/api/response/model/Change;");
					IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.Liveperson.Api.Response.Model.Change>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, changes_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr subscriptionId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='ExConversationChangeNotification.Body']/field[@name='subscriptionId']"
			[Register ("subscriptionId")]
			public string SubscriptionId {
				get {
					if (subscriptionId_jfieldId == IntPtr.Zero)
						subscriptionId_jfieldId = JNIEnv.GetFieldID (class_ref, "subscriptionId", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, subscriptionId_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (subscriptionId_jfieldId == IntPtr.Zero)
						subscriptionId_jfieldId = JNIEnv.GetFieldID (class_ref, "subscriptionId", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, subscriptionId_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/api/response/events/ExConversationChangeNotification$Body", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Body); }
			}

			protected Body (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_json_JSONObject_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='ExConversationChangeNotification.Body']/constructor[@name='ExConversationChangeNotification.Body' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
			public unsafe Body (global::Org.Json.JSONObject p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (Body)) {
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

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/response/events/ExConversationChangeNotification", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExConversationChangeNotification); }
		}

		protected ExConversationChangeNotification (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='ExConversationChangeNotification']/constructor[@name='ExConversationChangeNotification' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe ExConversationChangeNotification (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ExConversationChangeNotification)) {
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

		static IntPtr id_getType;
		public static unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='ExConversationChangeNotification']/method[@name='getType' and count(parameter)=0]"
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

		static Delegate cb_getBody;
#pragma warning disable 0169
		static Delegate GetGetBodyHandler ()
		{
			if (cb_getBody == null)
				cb_getBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBody);
			return cb_getBody;
		}

		static IntPtr n_GetBody (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Response.Events.ExConversationChangeNotification __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Events.ExConversationChangeNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetBody ());
		}
#pragma warning restore 0169

		static IntPtr id_getBody;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='ExConversationChangeNotification']/method[@name='getBody' and count(parameter)=0]"
		[Register ("getBody", "()Lcom/liveperson/api/response/events/ExConversationChangeNotification$Body;", "GetGetBodyHandler")]
		public virtual unsafe global::Com.Liveperson.Api.Response.Events.ExConversationChangeNotification.Body GetBody ()
		{
			if (id_getBody == IntPtr.Zero)
				id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()Lcom/liveperson/api/response/events/ExConversationChangeNotification$Body;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Events.ExConversationChangeNotification.Body> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBody), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Events.ExConversationChangeNotification.Body> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBody", "()Lcom/liveperson/api/response/events/ExConversationChangeNotification$Body;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getResponseHandler_Lcom_liveperson_messaging_Messaging_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='ExConversationChangeNotification']/method[@name='getResponseHandler' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.Messaging']]"
		[Register ("getResponseHandler", "(Lcom/liveperson/messaging/Messaging;)Lcom/liveperson/infra/network/socket/BaseResponseHandler;", "")]
		public static unsafe global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler GetResponseHandler (global::Com.Liveperson.Messaging.Messaging p0)
		{
			if (id_getResponseHandler_Lcom_liveperson_messaging_Messaging_ == IntPtr.Zero)
				id_getResponseHandler_Lcom_liveperson_messaging_Messaging_ = JNIEnv.GetStaticMethodID (class_ref, "getResponseHandler", "(Lcom/liveperson/messaging/Messaging;)Lcom/liveperson/infra/network/socket/BaseResponseHandler;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getResponseHandler_Lcom_liveperson_messaging_Messaging_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
