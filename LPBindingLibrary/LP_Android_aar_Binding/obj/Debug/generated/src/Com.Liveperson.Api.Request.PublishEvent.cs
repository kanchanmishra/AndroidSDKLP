using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent']"
	[global::Android.Runtime.Register ("com/liveperson/api/request/PublishEvent", DoNotGenerateAcw=true)]
	public partial class PublishEvent : global::Com.Liveperson.Api.Request.AbstractRequest {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent']/field[@name='CHAT_TYPE']"
		[Register ("CHAT_TYPE")]
		public const string ChatType = (string) "chatState";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent']/field[@name='DIALOG_ID']"
		[Register ("DIALOG_ID")]
		public const string DialogId = (string) "dialogId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent']/field[@name='EVENT']"
		[Register ("EVENT")]
		public const string Event = (string) "event";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent']/field[@name='MESSAGE']"
		[Register ("MESSAGE")]
		public const string Message = (string) "message";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent']/field[@name='METADATA']"
		[Register ("METADATA")]
		public const string Metadata = (string) "metadata";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent']/field[@name='PUBLISH_EVENT_TYPE']"
		[Register ("PUBLISH_EVENT_TYPE")]
		public const string PublishEventType = (string) "ms.PublishEvent";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent']/field[@name='SEQUENCE']"
		[Register ("SEQUENCE")]
		public const string Sequence = (string) "sequence";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent']/field[@name='SEQUENCE_LIST']"
		[Register ("SEQUENCE_LIST")]
		public const string SequenceList = (string) "sequenceList";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent']/field[@name='STATUS']"
		[Register ("STATUS")]
		public const string Status = (string) "status";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent']/field[@name='SUBSCRIPTION_ID']"
		[Register ("SUBSCRIPTION_ID")]
		public const string SubscriptionId = (string) "subscriptionId";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent.Response']"
		[global::Android.Runtime.Register ("com/liveperson/api/request/PublishEvent$Response", DoNotGenerateAcw=true)]
		public partial class Response : global::Com.Liveperson.Api.Response.AbstractResponse {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent.Response']/field[@name='PUBLISH_EVENT_RESPONSE_TYPE']"
			[Register ("PUBLISH_EVENT_RESPONSE_TYPE")]
			public const string PublishEventResponseType = (string) "ms.PublishEventResponse";
			// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent.Response.Body']"
			[global::Android.Runtime.Register ("com/liveperson/api/request/PublishEvent$Response$Body", DoNotGenerateAcw=true)]
			public partial class Body : global::Java.Lang.Object {


				static IntPtr sequence_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent.Response.Body']/field[@name='sequence']"
				[Register ("sequence")]
				public int Sequence {
					get {
						if (sequence_jfieldId == IntPtr.Zero)
							sequence_jfieldId = JNIEnv.GetFieldID (class_ref, "sequence", "I");
						return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, sequence_jfieldId);
					}
					set {
						if (sequence_jfieldId == IntPtr.Zero)
							sequence_jfieldId = JNIEnv.GetFieldID (class_ref, "sequence", "I");
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sequence_jfieldId, value);
						} finally {
						}
					}
				}
				internal static new IntPtr java_class_handle;
				internal static new IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/liveperson/api/request/PublishEvent$Response$Body", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (Body); }
				}

				protected Body (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_ctor;
				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent.Response.Body']/constructor[@name='PublishEvent.Response.Body' and count(parameter)=0]"
				[Register (".ctor", "()V", "")]
				public unsafe Body ()
					: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
				{
					if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
						return;

					try {
						if (((object) this).GetType () != typeof (Body)) {
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

			}

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/api/request/PublishEvent$Response", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent.Response']/constructor[@name='PublishEvent.Response' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
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
				global::Com.Liveperson.Api.Request.PublishEvent.Response __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.PublishEvent.Response> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.GetBody ());
			}
#pragma warning restore 0169

			static IntPtr id_getBody;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent.Response']/method[@name='getBody' and count(parameter)=0]"
			[Register ("getBody", "()Lcom/liveperson/api/request/PublishEvent$Response$Body;", "GetGetBodyHandler")]
			public virtual unsafe global::Com.Liveperson.Api.Request.PublishEvent.Response.Body GetBody ()
			{
				if (id_getBody == IntPtr.Zero)
					id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()Lcom/liveperson/api/request/PublishEvent$Response$Body;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.PublishEvent.Response.Body> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBody), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.PublishEvent.Response.Body> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBody", "()Lcom/liveperson/api/request/PublishEvent$Response$Body;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent.Type']"
		[global::Android.Runtime.Register ("com/liveperson/api/request/PublishEvent$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr AcceptStatusEvent_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent.Type']/field[@name='AcceptStatusEvent']"
			[Register ("AcceptStatusEvent")]
			public static global::Com.Liveperson.Api.Request.PublishEvent.Type AcceptStatusEvent {
				get {
					if (AcceptStatusEvent_jfieldId == IntPtr.Zero)
						AcceptStatusEvent_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AcceptStatusEvent", "Lcom/liveperson/api/request/PublishEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AcceptStatusEvent_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.PublishEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ChatStateEvent_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent.Type']/field[@name='ChatStateEvent']"
			[Register ("ChatStateEvent")]
			public static global::Com.Liveperson.Api.Request.PublishEvent.Type ChatStateEvent {
				get {
					if (ChatStateEvent_jfieldId == IntPtr.Zero)
						ChatStateEvent_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ChatStateEvent", "Lcom/liveperson/api/request/PublishEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ChatStateEvent_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.PublishEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ContentEvent_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent.Type']/field[@name='ContentEvent']"
			[Register ("ContentEvent")]
			public static global::Com.Liveperson.Api.Request.PublishEvent.Type ContentEvent {
				get {
					if (ContentEvent_jfieldId == IntPtr.Zero)
						ContentEvent_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ContentEvent", "Lcom/liveperson/api/request/PublishEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ContentEvent_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.PublishEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/api/request/PublishEvent$Type", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Type); }
			}

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/request/PublishEvent$Type;", "")]
			public static unsafe global::Com.Liveperson.Api.Request.PublishEvent.Type ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/request/PublishEvent$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Liveperson.Api.Request.PublishEvent.Type __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.PublishEvent.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/liveperson/api/request/PublishEvent$Type;", "")]
			public static unsafe global::Com.Liveperson.Api.Request.PublishEvent.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/api/request/PublishEvent$Type;");
				try {
					return (global::Com.Liveperson.Api.Request.PublishEvent.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Api.Request.PublishEvent.Type));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/request/PublishEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PublishEvent); }
		}

		protected PublishEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_liveperson_api_request_PublishEvent_Type_Ljava_lang_String_arrayILcom_liveperson_api_response_model_DeliveryStatusUpdateInfo_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent']/constructor[@name='PublishEvent' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.api.request.PublishEvent.Type'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int[]'] and parameter[5][@type='com.liveperson.api.response.model.DeliveryStatusUpdateInfo']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/liveperson/api/request/PublishEvent$Type;Ljava/lang/String;[ILcom/liveperson/api/response/model/DeliveryStatusUpdateInfo;)V", "")]
		public unsafe PublishEvent (string p0, global::Com.Liveperson.Api.Request.PublishEvent.Type p1, string p2, int[] p3, global::Com.Liveperson.Api.Response.Model.DeliveryStatusUpdateInfo p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				if (((object) this).GetType () != typeof (PublishEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Lcom/liveperson/api/request/PublishEvent$Type;Ljava/lang/String;[ILcom/liveperson/api/response/model/DeliveryStatusUpdateInfo;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lcom/liveperson/api/request/PublishEvent$Type;Ljava/lang/String;[ILcom/liveperson/api/response/model/DeliveryStatusUpdateInfo;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_liveperson_api_request_PublishEvent_Type_Ljava_lang_String_arrayILcom_liveperson_api_response_model_DeliveryStatusUpdateInfo_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_liveperson_api_request_PublishEvent_Type_Ljava_lang_String_arrayILcom_liveperson_api_response_model_DeliveryStatusUpdateInfo_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/liveperson/api/request/PublishEvent$Type;Ljava/lang/String;[ILcom/liveperson/api/response/model/DeliveryStatusUpdateInfo;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_liveperson_api_request_PublishEvent_Type_Ljava_lang_String_arrayILcom_liveperson_api_response_model_DeliveryStatusUpdateInfo_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_liveperson_api_request_PublishEvent_Type_Ljava_lang_String_arrayILcom_liveperson_api_response_model_DeliveryStatusUpdateInfo_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_liveperson_api_request_PublishEvent_Type_Lcom_liveperson_infra_model_types_ChatState_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent']/constructor[@name='PublishEvent' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.api.request.PublishEvent.Type'] and parameter[3][@type='com.liveperson.infra.model.types.ChatState']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/liveperson/api/request/PublishEvent$Type;Lcom/liveperson/infra/model/types/ChatState;)V", "")]
		public unsafe PublishEvent (string p0, global::Com.Liveperson.Api.Request.PublishEvent.Type p1, global::Com.Liveperson.Infra.Model.Types.ChatState p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (PublishEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Lcom/liveperson/api/request/PublishEvent$Type;Lcom/liveperson/infra/model/types/ChatState;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lcom/liveperson/api/request/PublishEvent$Type;Lcom/liveperson/infra/model/types/ChatState;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_liveperson_api_request_PublishEvent_Type_Lcom_liveperson_infra_model_types_ChatState_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_liveperson_api_request_PublishEvent_Type_Lcom_liveperson_infra_model_types_ChatState_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/liveperson/api/request/PublishEvent$Type;Lcom/liveperson/infra/model/types/ChatState;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_liveperson_api_request_PublishEvent_Type_Lcom_liveperson_infra_model_types_ChatState_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_liveperson_api_request_PublishEvent_Type_Lcom_liveperson_infra_model_types_ChatState_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_liveperson_api_request_message_PublishMessage_Lcom_liveperson_api_request_PublishEvent_Type_Lcom_liveperson_api_response_model_ContentType_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent']/constructor[@name='PublishEvent' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.api.request.message.PublishMessage'] and parameter[3][@type='com.liveperson.api.request.PublishEvent.Type'] and parameter[4][@type='com.liveperson.api.response.model.ContentType'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/liveperson/api/request/message/PublishMessage;Lcom/liveperson/api/request/PublishEvent$Type;Lcom/liveperson/api/response/model/ContentType;Ljava/lang/String;)V", "")]
		public unsafe PublishEvent (string p0, global::Com.Liveperson.Api.Request.Message.IPublishMessage p1, global::Com.Liveperson.Api.Request.PublishEvent.Type p2, global::Com.Liveperson.Api.Response.Model.ContentType p3, string p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				if (((object) this).GetType () != typeof (PublishEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Lcom/liveperson/api/request/message/PublishMessage;Lcom/liveperson/api/request/PublishEvent$Type;Lcom/liveperson/api/response/model/ContentType;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lcom/liveperson/api/request/message/PublishMessage;Lcom/liveperson/api/request/PublishEvent$Type;Lcom/liveperson/api/response/model/ContentType;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_liveperson_api_request_message_PublishMessage_Lcom_liveperson_api_request_PublishEvent_Type_Lcom_liveperson_api_response_model_ContentType_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_liveperson_api_request_message_PublishMessage_Lcom_liveperson_api_request_PublishEvent_Type_Lcom_liveperson_api_response_model_ContentType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/liveperson/api/request/message/PublishMessage;Lcom/liveperson/api/request/PublishEvent$Type;Lcom/liveperson/api/response/model/ContentType;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_liveperson_api_request_message_PublishMessage_Lcom_liveperson_api_request_PublishEvent_Type_Lcom_liveperson_api_response_model_ContentType_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_liveperson_api_request_message_PublishMessage_Lcom_liveperson_api_request_PublishEvent_Type_Lcom_liveperson_api_response_model_ContentType_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p4);
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
			global::Com.Liveperson.Api.Request.PublishEvent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.PublishEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageType);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageType;
		public override unsafe string MessageType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent']/method[@name='getMessageType' and count(parameter)=0]"
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
			global::Com.Liveperson.Api.Request.PublishEvent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.PublishEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ToJson (p0);
		}
#pragma warning restore 0169

		static IntPtr id_toJson_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='PublishEvent']/method[@name='toJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
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
