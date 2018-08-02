using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Monitoring.Sdk.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.monitoring.sdk.api']/class[@name='LivepersonMonitoring']"
	[global::Android.Runtime.Register ("com/liveperson/monitoring/sdk/api/LivepersonMonitoring", DoNotGenerateAcw=true)]
	public partial class LivepersonMonitoring : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.monitoring.sdk.api']/class[@name='LivepersonMonitoring']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "LivepersonMonitoring";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/monitoring/sdk/api/LivepersonMonitoring", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LivepersonMonitoring); }
		}

		protected LivepersonMonitoring (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getSDKVersion;
		public static unsafe string SDKVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.sdk.api']/class[@name='LivepersonMonitoring']/method[@name='getSDKVersion' and count(parameter)=0]"
			[Register ("getSDKVersion", "()Ljava/lang/String;", "GetGetSDKVersionHandler")]
			get {
				if (id_getSDKVersion == IntPtr.Zero)
					id_getSDKVersion = JNIEnv.GetStaticMethodID (class_ref, "getSDKVersion", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSDKVersion), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
