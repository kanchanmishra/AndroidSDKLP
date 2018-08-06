using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Monitoring.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='EngagementDetails']"
	[global::Android.Runtime.Register ("com/liveperson/monitoring/model/EngagementDetails", DoNotGenerateAcw=true)]
	public sealed partial class EngagementDetails : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='EngagementDetails.Companion']"
		[global::Android.Runtime.Register ("com/liveperson/monitoring/model/EngagementDetails$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/monitoring/model/EngagementDetails$Companion", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Companion); }
			}

			internal Companion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_invoke_Lorg_json_JSONObject_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='EngagementDetails.Companion']/method[@name='invoke' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("invoke", "(Lorg/json/JSONObject;)Lcom/liveperson/monitoring/model/EngagementDetails;", "")]
			public unsafe global::Com.Liveperson.Monitoring.Model.EngagementDetails Invoke (global::Org.Json.JSONObject p0)
			{
				if (id_invoke_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_invoke_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "invoke", "(Lorg/json/JSONObject;)Lcom/liveperson/monitoring/model/EngagementDetails;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Liveperson.Monitoring.Model.EngagementDetails __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Model.EngagementDetails> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_invoke_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/monitoring/model/EngagementDetails", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EngagementDetails); }
		}

		internal EngagementDetails (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='EngagementDetails']/constructor[@name='EngagementDetails' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe EngagementDetails (string p0, string p1, string p2, string p3, string p4, string p5, string p6)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				if (((object) this).GetType () != typeof (EngagementDetails)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static IntPtr id_getCampaignId;
		public unsafe string CampaignId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='EngagementDetails']/method[@name='getCampaignId' and count(parameter)=0]"
			[Register ("getCampaignId", "()Ljava/lang/String;", "GetGetCampaignIdHandler")]
			get {
				if (id_getCampaignId == IntPtr.Zero)
					id_getCampaignId = JNIEnv.GetMethodID (class_ref, "getCampaignId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCampaignId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getConnectorId;
		static IntPtr id_setConnectorId_Ljava_lang_String_;
		public unsafe string ConnectorId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='EngagementDetails']/method[@name='getConnectorId' and count(parameter)=0]"
			[Register ("getConnectorId", "()Ljava/lang/String;", "GetGetConnectorIdHandler")]
			get {
				if (id_getConnectorId == IntPtr.Zero)
					id_getConnectorId = JNIEnv.GetMethodID (class_ref, "getConnectorId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConnectorId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='EngagementDetails']/method[@name='setConnectorId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setConnectorId", "(Ljava/lang/String;)V", "GetSetConnectorId_Ljava_lang_String_Handler")]
			set {
				if (id_setConnectorId_Ljava_lang_String_ == IntPtr.Zero)
					id_setConnectorId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setConnectorId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConnectorId_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getContextId;
		public unsafe string ContextId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='EngagementDetails']/method[@name='getContextId' and count(parameter)=0]"
			[Register ("getContextId", "()Ljava/lang/String;", "GetGetContextIdHandler")]
			get {
				if (id_getContextId == IntPtr.Zero)
					id_getContextId = JNIEnv.GetMethodID (class_ref, "getContextId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContextId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getConversationId;
		static IntPtr id_setConversationId_Ljava_lang_String_;
		public unsafe string ConversationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='EngagementDetails']/method[@name='getConversationId' and count(parameter)=0]"
			[Register ("getConversationId", "()Ljava/lang/String;", "GetGetConversationIdHandler")]
			get {
				if (id_getConversationId == IntPtr.Zero)
					id_getConversationId = JNIEnv.GetMethodID (class_ref, "getConversationId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='EngagementDetails']/method[@name='setConversationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setConversationId", "(Ljava/lang/String;)V", "GetSetConversationId_Ljava_lang_String_Handler")]
			set {
				if (id_setConversationId_Ljava_lang_String_ == IntPtr.Zero)
					id_setConversationId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setConversationId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConversationId_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getEngagementId;
		public unsafe string EngagementId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='EngagementDetails']/method[@name='getEngagementId' and count(parameter)=0]"
			[Register ("getEngagementId", "()Ljava/lang/String;", "GetGetEngagementIdHandler")]
			get {
				if (id_getEngagementId == IntPtr.Zero)
					id_getEngagementId = JNIEnv.GetMethodID (class_ref, "getEngagementId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEngagementId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getEngagementRevision;
		public unsafe string EngagementRevision {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='EngagementDetails']/method[@name='getEngagementRevision' and count(parameter)=0]"
			[Register ("getEngagementRevision", "()Ljava/lang/String;", "GetGetEngagementRevisionHandler")]
			get {
				if (id_getEngagementRevision == IntPtr.Zero)
					id_getEngagementRevision = JNIEnv.GetMethodID (class_ref, "getEngagementRevision", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEngagementRevision), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getStatus;
		static IntPtr id_setStatus_Ljava_lang_String_;
		public unsafe string Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='EngagementDetails']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Ljava/lang/String;", "GetGetStatusHandler")]
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='EngagementDetails']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStatus", "(Ljava/lang/String;)V", "GetSetStatus_Ljava_lang_String_Handler")]
			set {
				if (id_setStatus_Ljava_lang_String_ == IntPtr.Zero)
					id_setStatus_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStatus", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStatus_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
