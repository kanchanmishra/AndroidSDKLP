using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Monitoring.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='ModelKeyNames']"
	[global::Android.Runtime.Register ("com/liveperson/monitoring/model/ModelKeyNames", DoNotGenerateAcw=true)]
	public partial class ModelKeyNames : global::Java.Lang.Object {


		static IntPtr CAMPAIGN_ID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='ModelKeyNames']/field[@name='CAMPAIGN_ID']"
		[Register ("CAMPAIGN_ID")]
		public static string CampaignId {
			get {
				if (CAMPAIGN_ID_jfieldId == IntPtr.Zero)
					CAMPAIGN_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAMPAIGN_ID", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CAMPAIGN_ID_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CAMPAIGN_ID_jfieldId == IntPtr.Zero)
					CAMPAIGN_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAMPAIGN_ID", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, CAMPAIGN_ID_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr CONNECTOR_ID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='ModelKeyNames']/field[@name='CONNECTOR_ID']"
		[Register ("CONNECTOR_ID")]
		public static string ConnectorId {
			get {
				if (CONNECTOR_ID_jfieldId == IntPtr.Zero)
					CONNECTOR_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTOR_ID", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONNECTOR_ID_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CONNECTOR_ID_jfieldId == IntPtr.Zero)
					CONNECTOR_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTOR_ID", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, CONNECTOR_ID_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr CONTEXT_ID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='ModelKeyNames']/field[@name='CONTEXT_ID']"
		[Register ("CONTEXT_ID")]
		public static string ContextId {
			get {
				if (CONTEXT_ID_jfieldId == IntPtr.Zero)
					CONTEXT_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTEXT_ID", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONTEXT_ID_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CONTEXT_ID_jfieldId == IntPtr.Zero)
					CONTEXT_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTEXT_ID", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, CONTEXT_ID_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr CONVERSATION_ID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='ModelKeyNames']/field[@name='CONVERSATION_ID']"
		[Register ("CONVERSATION_ID")]
		public static string ConversationId {
			get {
				if (CONVERSATION_ID_jfieldId == IntPtr.Zero)
					CONVERSATION_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONVERSATION_ID", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONVERSATION_ID_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CONVERSATION_ID_jfieldId == IntPtr.Zero)
					CONVERSATION_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONVERSATION_ID", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, CONVERSATION_ID_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ENGAGEMENT_DETAILS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='ModelKeyNames']/field[@name='ENGAGEMENT_DETAILS']"
		[Register ("ENGAGEMENT_DETAILS")]
		public static string EngagementDetails {
			get {
				if (ENGAGEMENT_DETAILS_jfieldId == IntPtr.Zero)
					ENGAGEMENT_DETAILS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENGAGEMENT_DETAILS", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ENGAGEMENT_DETAILS_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ENGAGEMENT_DETAILS_jfieldId == IntPtr.Zero)
					ENGAGEMENT_DETAILS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENGAGEMENT_DETAILS", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, ENGAGEMENT_DETAILS_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ENGAGEMENT_ID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='ModelKeyNames']/field[@name='ENGAGEMENT_ID']"
		[Register ("ENGAGEMENT_ID")]
		public static string EngagementId {
			get {
				if (ENGAGEMENT_ID_jfieldId == IntPtr.Zero)
					ENGAGEMENT_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENGAGEMENT_ID", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ENGAGEMENT_ID_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ENGAGEMENT_ID_jfieldId == IntPtr.Zero)
					ENGAGEMENT_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENGAGEMENT_ID", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, ENGAGEMENT_ID_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ENGAGEMENT_REVISION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='ModelKeyNames']/field[@name='ENGAGEMENT_REVISION']"
		[Register ("ENGAGEMENT_REVISION")]
		public static string EngagementRevision {
			get {
				if (ENGAGEMENT_REVISION_jfieldId == IntPtr.Zero)
					ENGAGEMENT_REVISION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENGAGEMENT_REVISION", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ENGAGEMENT_REVISION_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ENGAGEMENT_REVISION_jfieldId == IntPtr.Zero)
					ENGAGEMENT_REVISION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENGAGEMENT_REVISION", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, ENGAGEMENT_REVISION_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr PAGE_ID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='ModelKeyNames']/field[@name='PAGE_ID']"
		[Register ("PAGE_ID")]
		public static string PageId {
			get {
				if (PAGE_ID_jfieldId == IntPtr.Zero)
					PAGE_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAGE_ID", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAGE_ID_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PAGE_ID_jfieldId == IntPtr.Zero)
					PAGE_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAGE_ID", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, PAGE_ID_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SESSION_ID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='ModelKeyNames']/field[@name='SESSION_ID']"
		[Register ("SESSION_ID")]
		public static string SessionId {
			get {
				if (SESSION_ID_jfieldId == IntPtr.Zero)
					SESSION_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SESSION_ID", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SESSION_ID_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SESSION_ID_jfieldId == IntPtr.Zero)
					SESSION_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SESSION_ID", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, SESSION_ID_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr STATUS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='ModelKeyNames']/field[@name='STATUS']"
		[Register ("STATUS")]
		public static string Status {
			get {
				if (STATUS_jfieldId == IntPtr.Zero)
					STATUS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STATUS", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STATUS_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (STATUS_jfieldId == IntPtr.Zero)
					STATUS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STATUS", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, STATUS_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr VISITOR_ID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='ModelKeyNames']/field[@name='VISITOR_ID']"
		[Register ("VISITOR_ID")]
		public static string VisitorId {
			get {
				if (VISITOR_ID_jfieldId == IntPtr.Zero)
					VISITOR_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VISITOR_ID", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VISITOR_ID_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (VISITOR_ID_jfieldId == IntPtr.Zero)
					VISITOR_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VISITOR_ID", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, VISITOR_ID_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/monitoring/model/ModelKeyNames", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ModelKeyNames); }
		}

		protected ModelKeyNames (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='ModelKeyNames']/constructor[@name='ModelKeyNames' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ModelKeyNames ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ModelKeyNames)) {
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
}
