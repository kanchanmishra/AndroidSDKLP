using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Monitoring.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='EngagementWithSession']"
	[global::Android.Runtime.Register ("com/liveperson/monitoring/model/EngagementWithSession", DoNotGenerateAcw=true)]
	public sealed partial class EngagementWithSession : global::Java.Lang.Object {

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
