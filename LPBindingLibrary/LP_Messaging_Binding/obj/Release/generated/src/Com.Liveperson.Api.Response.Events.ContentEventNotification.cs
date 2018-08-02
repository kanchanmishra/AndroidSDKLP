using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Response.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='ContentEventNotification']"
	[global::Android.Runtime.Register ("com/liveperson/api/response/events/ContentEventNotification", DoNotGenerateAcw=true)]
	public partial class ContentEventNotification : global::Java.Lang.Object {


		static IntPtr dialogId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='ContentEventNotification']/field[@name='dialogId']"
		[Register ("dialogId")]
		public string DialogId {
			get {
				if (dialogId_jfieldId == IntPtr.Zero)
					dialogId_jfieldId = JNIEnv.GetFieldID (class_ref, "dialogId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, dialogId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (dialogId_jfieldId == IntPtr.Zero)
					dialogId_jfieldId = JNIEnv.GetFieldID (class_ref, "dialogId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, dialogId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr event_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='ContentEventNotification']/field[@name='event']"
		[Register ("event")]
		public global::Com.Liveperson.Api.Response.Model.Event Event {
			get {
				if (event_jfieldId == IntPtr.Zero)
					event_jfieldId = JNIEnv.GetFieldID (class_ref, "event", "Lcom/liveperson/api/response/model/Event;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, event_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.Event> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (event_jfieldId == IntPtr.Zero)
					event_jfieldId = JNIEnv.GetFieldID (class_ref, "event", "Lcom/liveperson/api/response/model/Event;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, event_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr eventId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='ContentEventNotification']/field[@name='eventId']"
		[Register ("eventId")]
		public string EventId {
			get {
				if (eventId_jfieldId == IntPtr.Zero)
					eventId_jfieldId = JNIEnv.GetFieldID (class_ref, "eventId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, eventId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (eventId_jfieldId == IntPtr.Zero)
					eventId_jfieldId = JNIEnv.GetFieldID (class_ref, "eventId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, eventId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr originatorId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='ContentEventNotification']/field[@name='originatorId']"
		[Register ("originatorId")]
		public string OriginatorId {
			get {
				if (originatorId_jfieldId == IntPtr.Zero)
					originatorId_jfieldId = JNIEnv.GetFieldID (class_ref, "originatorId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, originatorId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (originatorId_jfieldId == IntPtr.Zero)
					originatorId_jfieldId = JNIEnv.GetFieldID (class_ref, "originatorId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, originatorId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr originatorMetadata_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='ContentEventNotification']/field[@name='originatorMetadata']"
		[Register ("originatorMetadata")]
		public global::Com.Liveperson.Api.Response.Model.OriginatorMetadata OriginatorMetadata {
			get {
				if (originatorMetadata_jfieldId == IntPtr.Zero)
					originatorMetadata_jfieldId = JNIEnv.GetFieldID (class_ref, "originatorMetadata", "Lcom/liveperson/api/response/model/OriginatorMetadata;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, originatorMetadata_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.OriginatorMetadata> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (originatorMetadata_jfieldId == IntPtr.Zero)
					originatorMetadata_jfieldId = JNIEnv.GetFieldID (class_ref, "originatorMetadata", "Lcom/liveperson/api/response/model/OriginatorMetadata;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, originatorMetadata_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sequence_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='ContentEventNotification']/field[@name='sequence']"
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

		static IntPtr serverTimestamp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='ContentEventNotification']/field[@name='serverTimestamp']"
		[Register ("serverTimestamp")]
		public long ServerTimestamp {
			get {
				if (serverTimestamp_jfieldId == IntPtr.Zero)
					serverTimestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "serverTimestamp", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, serverTimestamp_jfieldId);
			}
			set {
				if (serverTimestamp_jfieldId == IntPtr.Zero)
					serverTimestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "serverTimestamp", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, serverTimestamp_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/response/events/ContentEventNotification", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContentEventNotification); }
		}

		protected ContentEventNotification (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.response.events']/class[@name='ContentEventNotification']/constructor[@name='ContentEventNotification' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe ContentEventNotification (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ContentEventNotification)) {
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
}
