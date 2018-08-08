using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Response.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='MessagingEventNotification']"
	[global::Android.Runtime.Register ("com/liveperson/api/response/events/MessagingEventNotification", DoNotGenerateAcw=true)]
	public sealed partial class MessagingEventNotification : global::Com.Liveperson.Api.Response.AbstractResponse {

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

	}
}
