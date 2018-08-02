using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeExConversations']"
	[global::Android.Runtime.Register ("com/liveperson/api/request/SubscribeExConversations", DoNotGenerateAcw=true)]
	public partial class SubscribeExConversations : global::Com.Liveperson.Api.Request.AbstractRequest {


		static IntPtr agentIds_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeExConversations']/field[@name='agentIds']"
		[Register ("agentIds")]
		public IList<string> AgentIds {
			get {
				if (agentIds_jfieldId == IntPtr.Zero)
					agentIds_jfieldId = JNIEnv.GetFieldID (class_ref, "agentIds", "[Ljava/lang/String;");
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, agentIds_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (agentIds_jfieldId == IntPtr.Zero)
					agentIds_jfieldId = JNIEnv.GetFieldID (class_ref, "agentIds", "[Ljava/lang/String;");
				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, agentIds_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr brandId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeExConversations']/field[@name='brandId']"
		[Register ("brandId")]
		public string BrandId {
			get {
				if (brandId_jfieldId == IntPtr.Zero)
					brandId_jfieldId = JNIEnv.GetFieldID (class_ref, "brandId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, brandId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (brandId_jfieldId == IntPtr.Zero)
					brandId_jfieldId = JNIEnv.GetFieldID (class_ref, "brandId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, brandId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr consumerId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeExConversations']/field[@name='consumerId']"
		[Register ("consumerId")]
		public string ConsumerId {
			get {
				if (consumerId_jfieldId == IntPtr.Zero)
					consumerId_jfieldId = JNIEnv.GetFieldID (class_ref, "consumerId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, consumerId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (consumerId_jfieldId == IntPtr.Zero)
					consumerId_jfieldId = JNIEnv.GetFieldID (class_ref, "consumerId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, consumerId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr convState_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeExConversations']/field[@name='convState']"
		[Register ("convState")]
		public IList<string> ConvState {
			get {
				if (convState_jfieldId == IntPtr.Zero)
					convState_jfieldId = JNIEnv.GetFieldID (class_ref, "convState", "[Ljava/lang/String;");
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, convState_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (convState_jfieldId == IntPtr.Zero)
					convState_jfieldId = JNIEnv.GetFieldID (class_ref, "convState", "[Ljava/lang/String;");
				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, convState_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr maxETTR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeExConversations']/field[@name='maxETTR']"
		[Register ("maxETTR")]
		public int MaxETTR {
			get {
				if (maxETTR_jfieldId == IntPtr.Zero)
					maxETTR_jfieldId = JNIEnv.GetFieldID (class_ref, "maxETTR", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, maxETTR_jfieldId);
			}
			set {
				if (maxETTR_jfieldId == IntPtr.Zero)
					maxETTR_jfieldId = JNIEnv.GetFieldID (class_ref, "maxETTR", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, maxETTR_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr maxLastUpdatedTime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeExConversations']/field[@name='maxLastUpdatedTime']"
		[Register ("maxLastUpdatedTime")]
		public long MaxLastUpdatedTime {
			get {
				if (maxLastUpdatedTime_jfieldId == IntPtr.Zero)
					maxLastUpdatedTime_jfieldId = JNIEnv.GetFieldID (class_ref, "maxLastUpdatedTime", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, maxLastUpdatedTime_jfieldId);
			}
			set {
				if (maxLastUpdatedTime_jfieldId == IntPtr.Zero)
					maxLastUpdatedTime_jfieldId = JNIEnv.GetFieldID (class_ref, "maxLastUpdatedTime", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, maxLastUpdatedTime_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr minLastUpdatedTime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeExConversations']/field[@name='minLastUpdatedTime']"
		[Register ("minLastUpdatedTime")]
		public long MinLastUpdatedTime {
			get {
				if (minLastUpdatedTime_jfieldId == IntPtr.Zero)
					minLastUpdatedTime_jfieldId = JNIEnv.GetFieldID (class_ref, "minLastUpdatedTime", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, minLastUpdatedTime_jfieldId);
			}
			set {
				if (minLastUpdatedTime_jfieldId == IntPtr.Zero)
					minLastUpdatedTime_jfieldId = JNIEnv.GetFieldID (class_ref, "minLastUpdatedTime", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, minLastUpdatedTime_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeExConversations.Response']"
		[global::Android.Runtime.Register ("com/liveperson/api/request/SubscribeExConversations$Response", DoNotGenerateAcw=true)]
		public partial class Response : global::Com.Liveperson.Api.Response.AbstractResponse {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeExConversations.Response']/field[@name='SUBSCRIBE_EX_CONVERSATIONS_RESPONSE_TYPE']"
			[Register ("SUBSCRIBE_EX_CONVERSATIONS_RESPONSE_TYPE")]
			public const string SubscribeExConversationsResponseType = (string) "cqm.SubscribeExConversationsResponse";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeExConversations.Response']/field[@name='SUBSCRIPTION_ID']"
			[Register ("SUBSCRIPTION_ID")]
			public const string SubscriptionId = (string) "subscriptionId";
			// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeExConversations.Response.Body']"
			[global::Android.Runtime.Register ("com/liveperson/api/request/SubscribeExConversations$Response$Body", DoNotGenerateAcw=true)]
			public partial class Body : global::Java.Lang.Object {


				static IntPtr subscriptionId_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeExConversations.Response.Body']/field[@name='subscriptionId']"
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
						return JNIEnv.FindClass ("com/liveperson/api/request/SubscribeExConversations$Response$Body", ref java_class_handle);
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
				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeExConversations.Response.Body']/constructor[@name='SubscribeExConversations.Response.Body' and count(parameter)=0]"
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
					return JNIEnv.FindClass ("com/liveperson/api/request/SubscribeExConversations$Response", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeExConversations.Response']/constructor[@name='SubscribeExConversations.Response' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
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
				global::Com.Liveperson.Api.Request.SubscribeExConversations.Response __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.SubscribeExConversations.Response> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.GetBody ());
			}
#pragma warning restore 0169

			static IntPtr id_getBody;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeExConversations.Response']/method[@name='getBody' and count(parameter)=0]"
			[Register ("getBody", "()Ljava/lang/Object;", "GetGetBodyHandler")]
			public virtual unsafe global::Java.Lang.Object GetBody ()
			{
				if (id_getBody == IntPtr.Zero)
					id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()Ljava/lang/Object;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBody), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBody", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/request/SubscribeExConversations", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SubscribeExConversations); }
		}

		protected SubscribeExConversations (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_JJarrayLjava_lang_String_Ljava_lang_String_IarrayLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeExConversations']/constructor[@name='SubscribeExConversations' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='int'] and parameter[7][@type='java.lang.String[]']]"
		[Register (".ctor", "(Ljava/lang/String;JJ[Ljava/lang/String;Ljava/lang/String;I[Ljava/lang/String;)V", "")]
		public unsafe SubscribeExConversations (string p0, long p1, long p2, string[] p3, string p4, int p5, string[] p6)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (native_p6);
				if (((object) this).GetType () != typeof (SubscribeExConversations)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;JJ[Ljava/lang/String;Ljava/lang/String;I[Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;JJ[Ljava/lang/String;Ljava/lang/String;I[Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_JJarrayLjava_lang_String_Ljava_lang_String_IarrayLjava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_JJarrayLjava_lang_String_Ljava_lang_String_IarrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;JJ[Ljava/lang/String;Ljava/lang/String;I[Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_JJarrayLjava_lang_String_Ljava_lang_String_IarrayLjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_JJarrayLjava_lang_String_Ljava_lang_String_IarrayLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				JNIEnv.DeleteLocalRef (native_p4);
				if (p6 != null) {
					JNIEnv.CopyArray (native_p6, p6);
					JNIEnv.DeleteLocalRef (native_p6);
				}
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
			global::Com.Liveperson.Api.Request.SubscribeExConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.SubscribeExConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageType);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageType;
		public override unsafe string MessageType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeExConversations']/method[@name='getMessageType' and count(parameter)=0]"
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
			global::Com.Liveperson.Api.Request.SubscribeExConversations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.SubscribeExConversations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ToJson (p0);
		}
#pragma warning restore 0169

		static IntPtr id_toJson_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeExConversations']/method[@name='toJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
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
