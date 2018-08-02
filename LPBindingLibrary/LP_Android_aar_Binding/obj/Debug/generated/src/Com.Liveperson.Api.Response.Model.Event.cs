using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Response.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Event']"
	[global::Android.Runtime.Register ("com/liveperson/api/response/model/Event", DoNotGenerateAcw=true)]
	public partial class Event : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Event']/field[@name='CONTENT']"
		[Register ("CONTENT")]
		public const string Content = (string) "content";

		static IntPtr chatState_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Event']/field[@name='chatState']"
		[Register ("chatState")]
		public global::Com.Liveperson.Infra.Model.Types.ChatState ChatState {
			get {
				if (chatState_jfieldId == IntPtr.Zero)
					chatState_jfieldId = JNIEnv.GetFieldID (class_ref, "chatState", "Lcom/liveperson/infra/model/types/ChatState;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, chatState_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Types.ChatState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (chatState_jfieldId == IntPtr.Zero)
					chatState_jfieldId = JNIEnv.GetFieldID (class_ref, "chatState", "Lcom/liveperson/infra/model/types/ChatState;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, chatState_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr contentType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Event']/field[@name='contentType']"
		[Register ("contentType")]
		public string ContentType {
			get {
				if (contentType_jfieldId == IntPtr.Zero)
					contentType_jfieldId = JNIEnv.GetFieldID (class_ref, "contentType", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, contentType_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (contentType_jfieldId == IntPtr.Zero)
					contentType_jfieldId = JNIEnv.GetFieldID (class_ref, "contentType", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, contentType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr message_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Event']/field[@name='message']"
		[Register ("message")]
		public global::Com.Liveperson.Api.Request.Message.BasePublishMessage Message {
			get {
				if (message_jfieldId == IntPtr.Zero)
					message_jfieldId = JNIEnv.GetFieldID (class_ref, "message", "Lcom/liveperson/api/request/message/BasePublishMessage;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, message_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.BasePublishMessage> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (message_jfieldId == IntPtr.Zero)
					message_jfieldId = JNIEnv.GetFieldID (class_ref, "message", "Lcom/liveperson/api/request/message/BasePublishMessage;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, message_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr quickRepliesJsonString_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Event']/field[@name='quickRepliesJsonString']"
		[Register ("quickRepliesJsonString")]
		public string QuickRepliesJsonString {
			get {
				if (quickRepliesJsonString_jfieldId == IntPtr.Zero)
					quickRepliesJsonString_jfieldId = JNIEnv.GetFieldID (class_ref, "quickRepliesJsonString", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, quickRepliesJsonString_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (quickRepliesJsonString_jfieldId == IntPtr.Zero)
					quickRepliesJsonString_jfieldId = JNIEnv.GetFieldID (class_ref, "quickRepliesJsonString", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, quickRepliesJsonString_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sequenceList_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Event']/field[@name='sequenceList']"
		[Register ("sequenceList")]
		public IList<int> SequenceList {
			get {
				if (sequenceList_jfieldId == IntPtr.Zero)
					sequenceList_jfieldId = JNIEnv.GetFieldID (class_ref, "sequenceList", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, sequenceList_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sequenceList_jfieldId == IntPtr.Zero)
					sequenceList_jfieldId = JNIEnv.GetFieldID (class_ref, "sequenceList", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sequenceList_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr status_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Event']/field[@name='status']"
		[Register ("status")]
		public global::Com.Liveperson.Api.Response.Types.DeliveryStatus Status {
			get {
				if (status_jfieldId == IntPtr.Zero)
					status_jfieldId = JNIEnv.GetFieldID (class_ref, "status", "Lcom/liveperson/api/response/types/DeliveryStatus;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, status_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.DeliveryStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (status_jfieldId == IntPtr.Zero)
					status_jfieldId = JNIEnv.GetFieldID (class_ref, "status", "Lcom/liveperson/api/response/types/DeliveryStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, status_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Event']/field[@name='type']"
		[Register ("type")]
		public global::Com.Liveperson.Api.Response.Model.Event.Types Type {
			get {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lcom/liveperson/api/response/model/Event$Types;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, type_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.Event.Types> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lcom/liveperson/api/response/model/Event$Types;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, type_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Event.Types']"
		[global::Android.Runtime.Register ("com/liveperson/api/response/model/Event$Types", DoNotGenerateAcw=true)]
		public sealed partial class Types : global::Java.Lang.Enum {


			static IntPtr AcceptStatusEvent_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Event.Types']/field[@name='AcceptStatusEvent']"
			[Register ("AcceptStatusEvent")]
			public static global::Com.Liveperson.Api.Response.Model.Event.Types AcceptStatusEvent {
				get {
					if (AcceptStatusEvent_jfieldId == IntPtr.Zero)
						AcceptStatusEvent_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AcceptStatusEvent", "Lcom/liveperson/api/response/model/Event$Types;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AcceptStatusEvent_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.Event.Types> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ChatStateEvent_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Event.Types']/field[@name='ChatStateEvent']"
			[Register ("ChatStateEvent")]
			public static global::Com.Liveperson.Api.Response.Model.Event.Types ChatStateEvent {
				get {
					if (ChatStateEvent_jfieldId == IntPtr.Zero)
						ChatStateEvent_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ChatStateEvent", "Lcom/liveperson/api/response/model/Event$Types;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ChatStateEvent_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.Event.Types> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ContentEvent_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Event.Types']/field[@name='ContentEvent']"
			[Register ("ContentEvent")]
			public static global::Com.Liveperson.Api.Response.Model.Event.Types ContentEvent {
				get {
					if (ContentEvent_jfieldId == IntPtr.Zero)
						ContentEvent_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ContentEvent", "Lcom/liveperson/api/response/model/Event$Types;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ContentEvent_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.Event.Types> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RichContentEvent_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Event.Types']/field[@name='RichContentEvent']"
			[Register ("RichContentEvent")]
			public static global::Com.Liveperson.Api.Response.Model.Event.Types RichContentEvent {
				get {
					if (RichContentEvent_jfieldId == IntPtr.Zero)
						RichContentEvent_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RichContentEvent", "Lcom/liveperson/api/response/model/Event$Types;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RichContentEvent_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.Event.Types> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/api/response/model/Event$Types", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Types); }
			}

			internal Types (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Event.Types']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/response/model/Event$Types;", "")]
			public static unsafe global::Com.Liveperson.Api.Response.Model.Event.Types ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/response/model/Event$Types;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Liveperson.Api.Response.Model.Event.Types __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.Event.Types> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Event.Types']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/liveperson/api/response/model/Event$Types;", "")]
			public static unsafe global::Com.Liveperson.Api.Response.Model.Event.Types[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/api/response/model/Event$Types;");
				try {
					return (global::Com.Liveperson.Api.Response.Model.Event.Types[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Api.Response.Model.Event.Types));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/response/model/Event", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Event); }
		}

		protected Event (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Event']/constructor[@name='Event' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe Event (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (Event)) {
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

		static Delegate cb_extractLinks_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetExtractLinks_Ljava_lang_String_Handler ()
		{
			if (cb_extractLinks_Ljava_lang_String_ == null)
				cb_extractLinks_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ExtractLinks_Ljava_lang_String_);
			return cb_extractLinks_Ljava_lang_String_;
		}

		static IntPtr n_ExtractLinks_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Api.Response.Model.Event __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.Event> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.ExtractLinks (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_extractLinks_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Event']/method[@name='extractLinks' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("extractLinks", "(Ljava/lang/String;)[Ljava/lang/String;", "GetExtractLinks_Ljava_lang_String_Handler")]
		public virtual unsafe string[] ExtractLinks (string p0)
		{
			if (id_extractLinks_Ljava_lang_String_ == IntPtr.Zero)
				id_extractLinks_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "extractLinks", "(Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_extractLinks_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					__ret = (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "extractLinks", "(Ljava/lang/String;)[Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
