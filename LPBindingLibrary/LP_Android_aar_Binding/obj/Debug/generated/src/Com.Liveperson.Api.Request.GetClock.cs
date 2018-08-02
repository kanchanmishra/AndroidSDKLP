using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GetClock']"
	[global::Android.Runtime.Register ("com/liveperson/api/request/GetClock", DoNotGenerateAcw=true)]
	public partial class GetClock : global::Com.Liveperson.Api.Request.AbstractRequest {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GetClock']/field[@name='CURRENT_TIME']"
		[Register ("CURRENT_TIME")]
		public const string CurrentTime = (string) "currentTime";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GetClock']/field[@name='GET_CLOCK_TYPE']"
		[Register ("GET_CLOCK_TYPE")]
		public const string GetClockType = (string) "GetClock";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GetClock.Response']"
		[global::Android.Runtime.Register ("com/liveperson/api/request/GetClock$Response", DoNotGenerateAcw=true)]
		public partial class Response : global::Com.Liveperson.Api.Response.AbstractResponse {


			static IntPtr GET_CLOCK_RESPONSE_TYPE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GetClock.Response']/field[@name='GET_CLOCK_RESPONSE_TYPE']"
			[Register ("GET_CLOCK_RESPONSE_TYPE")]
			public static string GetClockResponseType {
				get {
					if (GET_CLOCK_RESPONSE_TYPE_jfieldId == IntPtr.Zero)
						GET_CLOCK_RESPONSE_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GET_CLOCK_RESPONSE_TYPE", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GET_CLOCK_RESPONSE_TYPE_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (GET_CLOCK_RESPONSE_TYPE_jfieldId == IntPtr.Zero)
						GET_CLOCK_RESPONSE_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GET_CLOCK_RESPONSE_TYPE", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetStaticField (class_ref, GET_CLOCK_RESPONSE_TYPE_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GetClock.Response.Body']"
			[global::Android.Runtime.Register ("com/liveperson/api/request/GetClock$Response$Body", DoNotGenerateAcw=true)]
			public partial class Body : global::Java.Lang.Object {


				static IntPtr currentTime_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GetClock.Response.Body']/field[@name='currentTime']"
				[Register ("currentTime")]
				public long CurrentTime {
					get {
						if (currentTime_jfieldId == IntPtr.Zero)
							currentTime_jfieldId = JNIEnv.GetFieldID (class_ref, "currentTime", "J");
						return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, currentTime_jfieldId);
					}
					set {
						if (currentTime_jfieldId == IntPtr.Zero)
							currentTime_jfieldId = JNIEnv.GetFieldID (class_ref, "currentTime", "J");
						try {
							JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, currentTime_jfieldId, value);
						} finally {
						}
					}
				}
				internal static new IntPtr java_class_handle;
				internal static new IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/liveperson/api/request/GetClock$Response$Body", ref java_class_handle);
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
				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GetClock.Response.Body']/constructor[@name='GetClock.Response.Body' and count(parameter)=0]"
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
					return JNIEnv.FindClass ("com/liveperson/api/request/GetClock$Response", ref java_class_handle);
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
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GetClock.Response']/constructor[@name='GetClock.Response' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
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
				global::Com.Liveperson.Api.Request.GetClock.Response __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.GetClock.Response> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.GetBody ());
			}
#pragma warning restore 0169

			static IntPtr id_getBody;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GetClock.Response']/method[@name='getBody' and count(parameter)=0]"
			[Register ("getBody", "()Lcom/liveperson/api/request/GetClock$Response$Body;", "GetGetBodyHandler")]
			public virtual unsafe global::Com.Liveperson.Api.Request.GetClock.Response.Body GetBody ()
			{
				if (id_getBody == IntPtr.Zero)
					id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()Lcom/liveperson/api/request/GetClock$Response$Body;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.GetClock.Response.Body> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBody), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.GetClock.Response.Body> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBody", "()Lcom/liveperson/api/request/GetClock$Response$Body;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/request/GetClock", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GetClock); }
		}

		protected GetClock (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GetClock']/constructor[@name='GetClock' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GetClock ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GetClock)) {
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
			global::Com.Liveperson.Api.Request.GetClock __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.GetClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageType);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageType;
		public override unsafe string MessageType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GetClock']/method[@name='getMessageType' and count(parameter)=0]"
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
			global::Com.Liveperson.Api.Request.GetClock __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.GetClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ToJson (p0);
		}
#pragma warning restore 0169

		static IntPtr id_toJson_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='GetClock']/method[@name='toJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
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
