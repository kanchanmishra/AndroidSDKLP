using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeMessagingEvents']"
	[global::Android.Runtime.Register ("com/liveperson/api/request/SubscribeMessagingEvents", DoNotGenerateAcw=true)]
	public sealed partial class SubscribeMessagingEvents : global::Com.Liveperson.Api.Request.AbstractRequest {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeMessagingEvents.Response']"
		[global::Android.Runtime.Register ("com/liveperson/api/request/SubscribeMessagingEvents$Response", DoNotGenerateAcw=true)]
		public sealed partial class Response : global::Com.Liveperson.Api.Response.AbstractResponse {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/api/request/SubscribeMessagingEvents$Response", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Response); }
			}

			internal Response (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_json_JSONObject_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeMessagingEvents.Response']/constructor[@name='SubscribeMessagingEvents.Response' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
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

			static IntPtr id_getObj;
			static IntPtr id_setObj_Lorg_json_JSONObject_;
			public unsafe global::Org.Json.JSONObject Obj {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeMessagingEvents.Response']/method[@name='getObj' and count(parameter)=0]"
				[Register ("getObj", "()Lorg/json/JSONObject;", "GetGetObjHandler")]
				get {
					if (id_getObj == IntPtr.Zero)
						id_getObj = JNIEnv.GetMethodID (class_ref, "getObj", "()Lorg/json/JSONObject;");
					try {
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getObj), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeMessagingEvents.Response']/method[@name='setObj' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
				[Register ("setObj", "(Lorg/json/JSONObject;)V", "GetSetObj_Lorg_json_JSONObject_Handler")]
				set {
					if (id_setObj_Lorg_json_JSONObject_ == IntPtr.Zero)
						id_setObj_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "setObj", "(Lorg/json/JSONObject;)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setObj_Lorg_json_JSONObject_, __args);
					} finally {
					}
				}
			}

			static IntPtr id_getBody;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeMessagingEvents.Response']/method[@name='getBody' and count(parameter)=0]"
			[Register ("getBody", "()V", "")]
			public unsafe void GetBody ()
			{
				if (id_getBody == IntPtr.Zero)
					id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()V");
				try {
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getBody);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/request/SubscribeMessagingEvents", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SubscribeMessagingEvents); }
		}

		internal SubscribeMessagingEvents (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Integer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeMessagingEvents']/constructor[@name='SubscribeMessagingEvents' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Integer;)V", "")]
		public unsafe SubscribeMessagingEvents (string p0, global::Java.Lang.Integer p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (SubscribeMessagingEvents)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/Integer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/Integer;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_Integer_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Integer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Integer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Integer_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getConvId;
		public unsafe string ConvId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeMessagingEvents']/method[@name='getConvId' and count(parameter)=0]"
			[Register ("getConvId", "()Ljava/lang/String;", "GetGetConvIdHandler")]
			get {
				if (id_getConvId == IntPtr.Zero)
					id_getConvId = JNIEnv.GetMethodID (class_ref, "getConvId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConvId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getFromSeq;
		public unsafe global::Java.Lang.Integer FromSeq {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeMessagingEvents']/method[@name='getFromSeq' and count(parameter)=0]"
			[Register ("getFromSeq", "()Ljava/lang/Integer;", "GetGetFromSeqHandler")]
			get {
				if (id_getFromSeq == IntPtr.Zero)
					id_getFromSeq = JNIEnv.GetMethodID (class_ref, "getFromSeq", "()Ljava/lang/Integer;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFromSeq), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMessageType;
		protected override unsafe string MessageType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeMessagingEvents']/method[@name='getMessageType' and count(parameter)=0]"
			[Register ("getMessageType", "()Ljava/lang/String;", "GetGetMessageTypeHandler")]
			get {
				if (id_getMessageType == IntPtr.Zero)
					id_getMessageType = JNIEnv.GetMethodID (class_ref, "getMessageType", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_toJson_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='SubscribeMessagingEvents']/method[@name='toJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("toJson", "(Lorg/json/JSONObject;)V", "")]
		protected override unsafe void ToJson (global::Org.Json.JSONObject p0)
		{
			if (id_toJson_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_toJson_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "toJson", "(Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toJson_Lorg_json_JSONObject_, __args);
			} finally {
			}
		}

	}
}
