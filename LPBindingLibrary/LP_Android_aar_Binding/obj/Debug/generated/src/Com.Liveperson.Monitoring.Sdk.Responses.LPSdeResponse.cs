using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Monitoring.Sdk.Responses {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.monitoring.sdk.responses']/class[@name='LPSdeResponse']"
	[global::Android.Runtime.Register ("com/liveperson/monitoring/sdk/responses/LPSdeResponse", DoNotGenerateAcw=true)]
	public partial class LPSdeResponse : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/monitoring/sdk/responses/LPSdeResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LPSdeResponse); }
		}

		protected LPSdeResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.monitoring.sdk.responses']/class[@name='LPSdeResponse']/constructor[@name='LPSdeResponse' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe LPSdeResponse (string p0, string p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (LPSdeResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_Lcom_liveperson_monitoring_model_EngagementWithSession_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.monitoring.sdk.responses']/class[@name='LPSdeResponse']/constructor[@name='LPSdeResponse' and count(parameter)=1 and parameter[1][@type='com.liveperson.monitoring.model.EngagementWithSession']]"
		[Register (".ctor", "(Lcom/liveperson/monitoring/model/EngagementWithSession;)V", "")]
		public unsafe LPSdeResponse (global::Com.Liveperson.Monitoring.Model.EngagementWithSession p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (LPSdeResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/monitoring/model/EngagementWithSession;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/monitoring/model/EngagementWithSession;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_monitoring_model_EngagementWithSession_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_monitoring_model_EngagementWithSession_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/monitoring/model/EngagementWithSession;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_monitoring_model_EngagementWithSession_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_monitoring_model_EngagementWithSession_, __args);
			} finally {
			}
		}

		static IntPtr id_getPageId;
		static IntPtr id_setPageId_Ljava_lang_String_;
		public unsafe string PageId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.sdk.responses']/class[@name='LPSdeResponse']/method[@name='getPageId' and count(parameter)=0]"
			[Register ("getPageId", "()Ljava/lang/String;", "GetGetPageIdHandler")]
			get {
				if (id_getPageId == IntPtr.Zero)
					id_getPageId = JNIEnv.GetMethodID (class_ref, "getPageId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPageId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.sdk.responses']/class[@name='LPSdeResponse']/method[@name='setPageId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPageId", "(Ljava/lang/String;)V", "GetSetPageId_Ljava_lang_String_Handler")]
			set {
				if (id_setPageId_Ljava_lang_String_ == IntPtr.Zero)
					id_setPageId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPageId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPageId_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getSessionId;
		public unsafe string SessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.sdk.responses']/class[@name='LPSdeResponse']/method[@name='getSessionId' and count(parameter)=0]"
			[Register ("getSessionId", "()Ljava/lang/String;", "GetGetSessionIdHandler")]
			get {
				if (id_getSessionId == IntPtr.Zero)
					id_getSessionId = JNIEnv.GetMethodID (class_ref, "getSessionId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSessionId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getVisitorId;
		public unsafe string VisitorId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.sdk.responses']/class[@name='LPSdeResponse']/method[@name='getVisitorId' and count(parameter)=0]"
			[Register ("getVisitorId", "()Ljava/lang/String;", "GetGetVisitorIdHandler")]
			get {
				if (id_getVisitorId == IntPtr.Zero)
					id_getVisitorId = JNIEnv.GetMethodID (class_ref, "getVisitorId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVisitorId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
