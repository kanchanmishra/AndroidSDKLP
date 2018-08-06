using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Monitoring.Sdk.Responses {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.monitoring.sdk.responses']/class[@name='LPEngagementResponse']"
	[global::Android.Runtime.Register ("com/liveperson/monitoring/sdk/responses/LPEngagementResponse", DoNotGenerateAcw=true)]
	public sealed partial class LPEngagementResponse : global::Com.Liveperson.Monitoring.Sdk.Responses.LPSdeResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/monitoring/sdk/responses/LPEngagementResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LPEngagementResponse); }
		}

		internal LPEngagementResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_monitoring_model_EngagementWithSession_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.monitoring.sdk.responses']/class[@name='LPEngagementResponse']/constructor[@name='LPEngagementResponse' and count(parameter)=1 and parameter[1][@type='com.liveperson.monitoring.model.EngagementWithSession']]"
		[Register (".ctor", "(Lcom/liveperson/monitoring/model/EngagementWithSession;)V", "")]
		public unsafe LPEngagementResponse (global::Com.Liveperson.Monitoring.Model.EngagementWithSession p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (LPEngagementResponse)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.monitoring.sdk.responses']/class[@name='LPEngagementResponse']/constructor[@name='LPEngagementResponse' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.List&lt;com.liveperson.monitoring.model.EngagementDetails&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V", "")]
		public unsafe LPEngagementResponse (string p0, string p1, string p2, global::System.Collections.Generic.IList<global::Com.Liveperson.Monitoring.Model.EngagementDetails> p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::Com.Liveperson.Monitoring.Model.EngagementDetails>.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				if (((object) this).GetType () != typeof (LPEngagementResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_getEngagementDetailsList;
		static IntPtr id_setEngagementDetailsList_Ljava_util_List_;
		public unsafe global::System.Collections.Generic.IList<global::Com.Liveperson.Monitoring.Model.EngagementDetails> EngagementDetailsList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.sdk.responses']/class[@name='LPEngagementResponse']/method[@name='getEngagementDetailsList' and count(parameter)=0]"
			[Register ("getEngagementDetailsList", "()Ljava/util/List;", "GetGetEngagementDetailsListHandler")]
			get {
				if (id_getEngagementDetailsList == IntPtr.Zero)
					id_getEngagementDetailsList = JNIEnv.GetMethodID (class_ref, "getEngagementDetailsList", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Com.Liveperson.Monitoring.Model.EngagementDetails>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEngagementDetailsList), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.sdk.responses']/class[@name='LPEngagementResponse']/method[@name='setEngagementDetailsList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.liveperson.monitoring.model.EngagementDetails&gt;']]"
			[Register ("setEngagementDetailsList", "(Ljava/util/List;)V", "GetSetEngagementDetailsList_Ljava_util_List_Handler")]
			set {
				if (id_setEngagementDetailsList_Ljava_util_List_ == IntPtr.Zero)
					id_setEngagementDetailsList_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setEngagementDetailsList", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Liveperson.Monitoring.Model.EngagementDetails>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEngagementDetailsList_Ljava_util_List_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
