using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Monitoring.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='EngagementWithSession']"
	[global::Android.Runtime.Register ("com/liveperson/monitoring/model/EngagementWithSession", DoNotGenerateAcw=true)]
	public sealed partial class EngagementWithSession : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='EngagementWithSession.Companion']"
		[global::Android.Runtime.Register ("com/liveperson/monitoring/model/EngagementWithSession$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/monitoring/model/EngagementWithSession$Companion", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Companion); }
			}

			internal Companion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_invoke_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='EngagementWithSession.Companion']/method[@name='invoke' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("invoke", "(Ljava/lang/String;)Lcom/liveperson/monitoring/model/EngagementWithSession;", "")]
			public unsafe global::Com.Liveperson.Monitoring.Model.EngagementWithSession Invoke (string p0)
			{
				if (id_invoke_Ljava_lang_String_ == IntPtr.Zero)
					id_invoke_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "invoke", "(Ljava/lang/String;)Lcom/liveperson/monitoring/model/EngagementWithSession;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Liveperson.Monitoring.Model.EngagementWithSession __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Model.EngagementWithSession> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_invoke_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/monitoring/model/EngagementWithSession", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EngagementWithSession); }
		}

		internal EngagementWithSession (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='EngagementWithSession']/constructor[@name='EngagementWithSession' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.List&lt;com.liveperson.monitoring.model.EngagementDetails&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V", "")]
		public unsafe EngagementWithSession (string p0, string p1, string p2, global::System.Collections.Generic.IList<global::Com.Liveperson.Monitoring.Model.EngagementDetails> p3)
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
				if (((object) this).GetType () != typeof (EngagementWithSession)) {
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='EngagementWithSession']/method[@name='getEngagementDetailsList' and count(parameter)=0]"
			[Register ("getEngagementDetailsList", "()Ljava/util/List;", "GetGetEngagementDetailsListHandler")]
			get {
				if (id_getEngagementDetailsList == IntPtr.Zero)
					id_getEngagementDetailsList = JNIEnv.GetMethodID (class_ref, "getEngagementDetailsList", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Com.Liveperson.Monitoring.Model.EngagementDetails>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEngagementDetailsList), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='EngagementWithSession']/method[@name='setEngagementDetailsList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.liveperson.monitoring.model.EngagementDetails&gt;']]"
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

		static IntPtr id_getPageId;
		public unsafe string PageId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='EngagementWithSession']/method[@name='getPageId' and count(parameter)=0]"
			[Register ("getPageId", "()Ljava/lang/String;", "GetGetPageIdHandler")]
			get {
				if (id_getPageId == IntPtr.Zero)
					id_getPageId = JNIEnv.GetMethodID (class_ref, "getPageId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPageId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSessionId;
		public unsafe string SessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='EngagementWithSession']/method[@name='getSessionId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='EngagementWithSession']/method[@name='getVisitorId' and count(parameter)=0]"
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
