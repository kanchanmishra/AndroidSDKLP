using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Monitoring.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.monitoring.utils']/class[@name='LocalBroadcast']"
	[global::Android.Runtime.Register ("com/liveperson/monitoring/utils/LocalBroadcast", DoNotGenerateAcw=true)]
	public partial class LocalBroadcast : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/monitoring/utils/LocalBroadcast", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocalBroadcast); }
		}

		protected LocalBroadcast (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.monitoring.utils']/class[@name='LocalBroadcast']/constructor[@name='LocalBroadcast' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LocalBroadcast ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LocalBroadcast)) {
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

		static IntPtr id_sendBroadcast_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.utils']/class[@name='LocalBroadcast']/method[@name='sendBroadcast' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendBroadcast", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SendBroadcast (global::Android.Content.Context p0, string p1)
		{
			if (id_sendBroadcast_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_sendBroadcast_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sendBroadcast", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendBroadcast_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_sendBroadcast_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.utils']/class[@name='LocalBroadcast']/method[@name='sendBroadcast' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("sendBroadcast", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)V", "")]
		public static unsafe void SendBroadcast (global::Android.Content.Context p0, string p1, global::Android.OS.Bundle p2)
		{
			if (id_sendBroadcast_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_sendBroadcast_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "sendBroadcast", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendBroadcast_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
