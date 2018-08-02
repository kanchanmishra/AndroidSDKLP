using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='QueryMessages']"
	[global::Android.Runtime.Register ("com/liveperson/api/request/QueryMessages", DoNotGenerateAcw=true)]
	public partial class QueryMessages : global::Com.Liveperson.Api.Request.AbstractRequest {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='QueryMessages']/field[@name='BODY']"
		[Register ("BODY")]
		public const string Body = (string) "body";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='QueryMessages']/field[@name='DIALOG_ID']"
		[Register ("DIALOG_ID")]
		public const string DialogId = (string) "dialogId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='QueryMessages']/field[@name='EVENT']"
		[Register ("EVENT")]
		public const string Event = (string) "event";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='QueryMessages']/field[@name='MAX_QUANTITY']"
		[Register ("MAX_QUANTITY")]
		public const string MaxQuantity = (string) "maxQuantity";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='QueryMessages']/field[@name='NEWER_THAN_SEQUENCE']"
		[Register ("NEWER_THAN_SEQUENCE")]
		public const string NewerThanSequence = (string) "newerThanSequence";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='QueryMessages']/field[@name='OLDER_THAN_SEQUENCE']"
		[Register ("OLDER_THAN_SEQUENCE")]
		public const string OlderThanSequence = (string) "olderThanSequence";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='QueryMessages']/field[@name='ORIGINATOR_ID']"
		[Register ("ORIGINATOR_ID")]
		public const string OriginatorId = (string) "originatorId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='QueryMessages']/field[@name='SEQUENCE']"
		[Register ("SEQUENCE")]
		public const string Sequence = (string) "sequence";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='QueryMessages']/field[@name='SEQUENCE1']"
		[Register ("SEQUENCE1")]
		public const string Sequence1 = (string) "sequence";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='QueryMessages']/field[@name='SERVER_TIMESTAMP']"
		[Register ("SERVER_TIMESTAMP")]
		public const string ServerTimestamp = (string) "serverTimestamp";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='QueryMessages.Response']"
		[global::Android.Runtime.Register ("com/liveperson/api/request/QueryMessages$Response", DoNotGenerateAcw=true)]
		public partial class Response : global::Com.Liveperson.Api.Response.AbstractResponse {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='QueryMessages.Response']/field[@name='QUERY_MESSAGES_RESPONSE_TYPE']"
			[Register ("QUERY_MESSAGES_RESPONSE_TYPE")]
			public const string QueryMessagesResponseType = (string) ".ams.ms.QueryMessages$Response";
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/api/request/QueryMessages$Response", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Response); }
			}

			protected Response (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_json_JSONObject_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='QueryMessages.Response']/constructor[@name='QueryMessages.Response' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
			public unsafe Response (global::Org.Json.JSONObject p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (Response)) {
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

			static IntPtr id_ctor_Lorg_json_JSONArray_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='QueryMessages.Response']/constructor[@name='QueryMessages.Response' and count(parameter)=1 and parameter[1][@type='org.json.JSONArray']]"
			[Register (".ctor", "(Lorg/json/JSONArray;)V", "")]
			public unsafe Response (global::Org.Json.JSONArray p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (Response)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/json/JSONArray;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/json/JSONArray;)V", __args);
						return;
					}

					if (id_ctor_Lorg_json_JSONArray_ == IntPtr.Zero)
						id_ctor_Lorg_json_JSONArray_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/json/JSONArray;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_json_JSONArray_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_json_JSONArray_, __args);
				} finally {
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
				global::Com.Liveperson.Api.Request.QueryMessages.Response __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.QueryMessages.Response> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList<global::Com.Liveperson.Api.Response.Events.ContentEventNotification>.ToLocalJniHandle (__this.Body);
			}
#pragma warning restore 0169

			static IntPtr id_getBody;
			public virtual unsafe global::System.Collections.Generic.IList<global::Com.Liveperson.Api.Response.Events.ContentEventNotification> Body {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='QueryMessages.Response']/method[@name='getBody' and count(parameter)=0]"
				[Register ("getBody", "()Ljava/util/ArrayList;", "GetGetBodyHandler")]
				get {
					if (id_getBody == IntPtr.Zero)
						id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()Ljava/util/ArrayList;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Android.Runtime.JavaList<global::Com.Liveperson.Api.Response.Events.ContentEventNotification>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBody), JniHandleOwnership.TransferLocalRef);
						else
							return global::Android.Runtime.JavaList<global::Com.Liveperson.Api.Response.Events.ContentEventNotification>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBody", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/request/QueryMessages", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QueryMessages); }
		}

		protected QueryMessages (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_IJJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='QueryMessages']/constructor[@name='QueryMessages' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register (".ctor", "(Ljava/lang/String;IJJ)V", "")]
		public unsafe QueryMessages (string p0, int p1, long p2, long p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (QueryMessages)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;IJJ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;IJJ)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_IJJ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_IJJ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;IJJ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_IJJ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_IJJ, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getMessageType;
#pragma warning disable 0169
		static Delegate GetGetMessageTypeHandler ()
		{
			if (cb_getMessageType == null)
				cb_getMessageType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageType);
			return cb_getMessageType;
		}

		static IntPtr n_GetMessageType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Request.QueryMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.QueryMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageType);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageType;
		public override unsafe string MessageType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='QueryMessages']/method[@name='getMessageType' and count(parameter)=0]"
			[Register ("getMessageType", "()Ljava/lang/String;", "GetGetMessageTypeHandler")]
			get {
				if (id_getMessageType == IntPtr.Zero)
					id_getMessageType = JNIEnv.GetMethodID (class_ref, "getMessageType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_toJson_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetToJson_Lorg_json_JSONObject_Handler ()
		{
			if (cb_toJson_Lorg_json_JSONObject_ == null)
				cb_toJson_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ToJson_Lorg_json_JSONObject_);
			return cb_toJson_Lorg_json_JSONObject_;
		}

		static void n_ToJson_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Api.Request.QueryMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.QueryMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ToJson (p0);
		}
#pragma warning restore 0169

		static IntPtr id_toJson_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='QueryMessages']/method[@name='toJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("toJson", "(Lorg/json/JSONObject;)V", "GetToJson_Lorg_json_JSONObject_Handler")]
		protected override unsafe void ToJson (global::Org.Json.JSONObject p0)
		{
			if (id_toJson_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_toJson_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "toJson", "(Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toJson_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toJson", "(Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

	}
}
