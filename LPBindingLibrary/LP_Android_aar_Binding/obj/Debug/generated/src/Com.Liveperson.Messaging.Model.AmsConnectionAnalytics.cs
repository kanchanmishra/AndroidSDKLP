using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/model/AmsConnectionAnalytics", DoNotGenerateAcw=true)]
	public partial class AmsConnectionAnalytics : global::Java.Lang.Object {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']/field[@name='TAG']"
		[Register ("TAG")]
		protected static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/model/AmsConnectionAnalytics", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsConnectionAnalytics); }
		}

		protected AmsConnectionAnalytics (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']/constructor[@name='AmsConnectionAnalytics' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AmsConnectionAnalytics ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AmsConnectionAnalytics)) {
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

		static IntPtr id_closeConnectionTaskEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']/method[@name='closeConnectionTaskEnd' and count(parameter)=0]"
		[Register ("closeConnectionTaskEnd", "()V", "")]
		public static unsafe void CloseConnectionTaskEnd ()
		{
			if (id_closeConnectionTaskEnd == IntPtr.Zero)
				id_closeConnectionTaskEnd = JNIEnv.GetStaticMethodID (class_ref, "closeConnectionTaskEnd", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_closeConnectionTaskEnd);
			} finally {
			}
		}

		static IntPtr id_closeConnectionTaskStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']/method[@name='closeConnectionTaskStart' and count(parameter)=0]"
		[Register ("closeConnectionTaskStart", "()V", "")]
		public static unsafe void CloseConnectionTaskStart ()
		{
			if (id_closeConnectionTaskStart == IntPtr.Zero)
				id_closeConnectionTaskStart = JNIEnv.GetStaticMethodID (class_ref, "closeConnectionTaskStart", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_closeConnectionTaskStart);
			} finally {
			}
		}

		static IntPtr id_collectSDKConfigurationDataTaskEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']/method[@name='collectSDKConfigurationDataTaskEnd' and count(parameter)=0]"
		[Register ("collectSDKConfigurationDataTaskEnd", "()V", "")]
		public static unsafe void CollectSDKConfigurationDataTaskEnd ()
		{
			if (id_collectSDKConfigurationDataTaskEnd == IntPtr.Zero)
				id_collectSDKConfigurationDataTaskEnd = JNIEnv.GetStaticMethodID (class_ref, "collectSDKConfigurationDataTaskEnd", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_collectSDKConfigurationDataTaskEnd);
			} finally {
			}
		}

		static IntPtr id_collectSDKConfigurationDataTaskStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']/method[@name='collectSDKConfigurationDataTaskStart' and count(parameter)=0]"
		[Register ("collectSDKConfigurationDataTaskStart", "()V", "")]
		public static unsafe void CollectSDKConfigurationDataTaskStart ()
		{
			if (id_collectSDKConfigurationDataTaskStart == IntPtr.Zero)
				id_collectSDKConfigurationDataTaskStart = JNIEnv.GetStaticMethodID (class_ref, "collectSDKConfigurationDataTaskStart", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_collectSDKConfigurationDataTaskStart);
			} finally {
			}
		}

		static IntPtr id_configurationFetcherTaskEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']/method[@name='configurationFetcherTaskEnd' and count(parameter)=0]"
		[Register ("configurationFetcherTaskEnd", "()V", "")]
		public static unsafe void ConfigurationFetcherTaskEnd ()
		{
			if (id_configurationFetcherTaskEnd == IntPtr.Zero)
				id_configurationFetcherTaskEnd = JNIEnv.GetStaticMethodID (class_ref, "configurationFetcherTaskEnd", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_configurationFetcherTaskEnd);
			} finally {
			}
		}

		static IntPtr id_configurationFetcherTaskStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']/method[@name='configurationFetcherTaskStart' and count(parameter)=0]"
		[Register ("configurationFetcherTaskStart", "()V", "")]
		public static unsafe void ConfigurationFetcherTaskStart ()
		{
			if (id_configurationFetcherTaskStart == IntPtr.Zero)
				id_configurationFetcherTaskStart = JNIEnv.GetStaticMethodID (class_ref, "configurationFetcherTaskStart", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_configurationFetcherTaskStart);
			} finally {
			}
		}

		static IntPtr id_connected;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']/method[@name='connected' and count(parameter)=0]"
		[Register ("connected", "()V", "")]
		public static unsafe void Connected ()
		{
			if (id_connected == IntPtr.Zero)
				id_connected = JNIEnv.GetStaticMethodID (class_ref, "connected", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_connected);
			} finally {
			}
		}

		static IntPtr id_csdsTaskEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']/method[@name='csdsTaskEnd' and count(parameter)=0]"
		[Register ("csdsTaskEnd", "()V", "")]
		public static unsafe void CsdsTaskEnd ()
		{
			if (id_csdsTaskEnd == IntPtr.Zero)
				id_csdsTaskEnd = JNIEnv.GetStaticMethodID (class_ref, "csdsTaskEnd", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_csdsTaskEnd);
			} finally {
			}
		}

		static IntPtr id_csdsTaskStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']/method[@name='csdsTaskStart' and count(parameter)=0]"
		[Register ("csdsTaskStart", "()V", "")]
		public static unsafe void CsdsTaskStart ()
		{
			if (id_csdsTaskStart == IntPtr.Zero)
				id_csdsTaskStart = JNIEnv.GetStaticMethodID (class_ref, "csdsTaskStart", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_csdsTaskStart);
			} finally {
			}
		}

		static IntPtr id_databaseTaskEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']/method[@name='databaseTaskEnd' and count(parameter)=0]"
		[Register ("databaseTaskEnd", "()V", "")]
		public static unsafe void DatabaseTaskEnd ()
		{
			if (id_databaseTaskEnd == IntPtr.Zero)
				id_databaseTaskEnd = JNIEnv.GetStaticMethodID (class_ref, "databaseTaskEnd", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_databaseTaskEnd);
			} finally {
			}
		}

		static IntPtr id_databaseTaskStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']/method[@name='databaseTaskStart' and count(parameter)=0]"
		[Register ("databaseTaskStart", "()V", "")]
		public static unsafe void DatabaseTaskStart ()
		{
			if (id_databaseTaskStart == IntPtr.Zero)
				id_databaseTaskStart = JNIEnv.GetStaticMethodID (class_ref, "databaseTaskStart", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_databaseTaskStart);
			} finally {
			}
		}

		static IntPtr id_idpTaskEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']/method[@name='idpTaskEnd' and count(parameter)=0]"
		[Register ("idpTaskEnd", "()V", "")]
		public static unsafe void IdpTaskEnd ()
		{
			if (id_idpTaskEnd == IntPtr.Zero)
				id_idpTaskEnd = JNIEnv.GetStaticMethodID (class_ref, "idpTaskEnd", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_idpTaskEnd);
			} finally {
			}
		}

		static IntPtr id_idpTaskStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']/method[@name='idpTaskStart' and count(parameter)=0]"
		[Register ("idpTaskStart", "()V", "")]
		public static unsafe void IdpTaskStart ()
		{
			if (id_idpTaskStart == IntPtr.Zero)
				id_idpTaskStart = JNIEnv.GetStaticMethodID (class_ref, "idpTaskStart", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_idpTaskStart);
			} finally {
			}
		}

		static IntPtr id_lptagTaskEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']/method[@name='lptagTaskEnd' and count(parameter)=0]"
		[Register ("lptagTaskEnd", "()V", "")]
		public static unsafe void LptagTaskEnd ()
		{
			if (id_lptagTaskEnd == IntPtr.Zero)
				id_lptagTaskEnd = JNIEnv.GetStaticMethodID (class_ref, "lptagTaskEnd", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_lptagTaskEnd);
			} finally {
			}
		}

		static IntPtr id_lptagTaskStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']/method[@name='lptagTaskStart' and count(parameter)=0]"
		[Register ("lptagTaskStart", "()V", "")]
		public static unsafe void LptagTaskStart ()
		{
			if (id_lptagTaskStart == IntPtr.Zero)
				id_lptagTaskStart = JNIEnv.GetStaticMethodID (class_ref, "lptagTaskStart", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_lptagTaskStart);
			} finally {
			}
		}

		static IntPtr id_openSocketTaskEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']/method[@name='openSocketTaskEnd' and count(parameter)=0]"
		[Register ("openSocketTaskEnd", "()V", "")]
		public static unsafe void OpenSocketTaskEnd ()
		{
			if (id_openSocketTaskEnd == IntPtr.Zero)
				id_openSocketTaskEnd = JNIEnv.GetStaticMethodID (class_ref, "openSocketTaskEnd", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_openSocketTaskEnd);
			} finally {
			}
		}

		static IntPtr id_openSocketTaskStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']/method[@name='openSocketTaskStart' and count(parameter)=0]"
		[Register ("openSocketTaskStart", "()V", "")]
		public static unsafe void OpenSocketTaskStart ()
		{
			if (id_openSocketTaskStart == IntPtr.Zero)
				id_openSocketTaskStart = JNIEnv.GetStaticMethodID (class_ref, "openSocketTaskStart", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_openSocketTaskStart);
			} finally {
			}
		}

		static IntPtr id_removeOlderImagesTaskEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']/method[@name='removeOlderImagesTaskEnd' and count(parameter)=0]"
		[Register ("removeOlderImagesTaskEnd", "()V", "")]
		public static unsafe void RemoveOlderImagesTaskEnd ()
		{
			if (id_removeOlderImagesTaskEnd == IntPtr.Zero)
				id_removeOlderImagesTaskEnd = JNIEnv.GetStaticMethodID (class_ref, "removeOlderImagesTaskEnd", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_removeOlderImagesTaskEnd);
			} finally {
			}
		}

		static IntPtr id_removeOlderImagesTaskStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']/method[@name='removeOlderImagesTaskStart' and count(parameter)=0]"
		[Register ("removeOlderImagesTaskStart", "()V", "")]
		public static unsafe void RemoveOlderImagesTaskStart ()
		{
			if (id_removeOlderImagesTaskStart == IntPtr.Zero)
				id_removeOlderImagesTaskStart = JNIEnv.GetStaticMethodID (class_ref, "removeOlderImagesTaskStart", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_removeOlderImagesTaskStart);
			} finally {
			}
		}

		static IntPtr id_siteSettingsFetcherTaskEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']/method[@name='siteSettingsFetcherTaskEnd' and count(parameter)=0]"
		[Register ("siteSettingsFetcherTaskEnd", "()V", "")]
		public static unsafe void SiteSettingsFetcherTaskEnd ()
		{
			if (id_siteSettingsFetcherTaskEnd == IntPtr.Zero)
				id_siteSettingsFetcherTaskEnd = JNIEnv.GetStaticMethodID (class_ref, "siteSettingsFetcherTaskEnd", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_siteSettingsFetcherTaskEnd);
			} finally {
			}
		}

		static IntPtr id_siteSettingsFetcherTaskStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']/method[@name='siteSettingsFetcherTaskStart' and count(parameter)=0]"
		[Register ("siteSettingsFetcherTaskStart", "()V", "")]
		public static unsafe void SiteSettingsFetcherTaskStart ()
		{
			if (id_siteSettingsFetcherTaskStart == IntPtr.Zero)
				id_siteSettingsFetcherTaskStart = JNIEnv.GetStaticMethodID (class_ref, "siteSettingsFetcherTaskStart", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_siteSettingsFetcherTaskStart);
			} finally {
			}
		}

		static IntPtr id_socketReady;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']/method[@name='socketReady' and count(parameter)=0]"
		[Register ("socketReady", "()V", "")]
		public static unsafe void SocketReady ()
		{
			if (id_socketReady == IntPtr.Zero)
				id_socketReady = JNIEnv.GetStaticMethodID (class_ref, "socketReady", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_socketReady);
			} finally {
			}
		}

		static IntPtr id_startConnecting;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']/method[@name='startConnecting' and count(parameter)=0]"
		[Register ("startConnecting", "()V", "")]
		public static unsafe void StartConnecting ()
		{
			if (id_startConnecting == IntPtr.Zero)
				id_startConnecting = JNIEnv.GetStaticMethodID (class_ref, "startConnecting", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_startConnecting);
			} finally {
			}
		}

		static IntPtr id_startDisconnecting;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsConnectionAnalytics']/method[@name='startDisconnecting' and count(parameter)=0]"
		[Register ("startDisconnecting", "()V", "")]
		public static unsafe void StartDisconnecting ()
		{
			if (id_startDisconnecting == IntPtr.Zero)
				id_startDisconnecting = JNIEnv.GetStaticMethodID (class_ref, "startDisconnecting", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_startDisconnecting);
			} finally {
			}
		}

	}
}
