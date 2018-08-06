using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Monitoring.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='LPMonitoringIdentity']"
	[global::Android.Runtime.Register ("com/liveperson/monitoring/model/LPMonitoringIdentity", DoNotGenerateAcw=true)]
	public sealed partial class LPMonitoringIdentity : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/monitoring/model/LPMonitoringIdentity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LPMonitoringIdentity); }
		}

		internal LPMonitoringIdentity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='LPMonitoringIdentity']/constructor[@name='LPMonitoringIdentity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LPMonitoringIdentity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LPMonitoringIdentity)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='LPMonitoringIdentity']/constructor[@name='LPMonitoringIdentity' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe LPMonitoringIdentity (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (LPMonitoringIdentity)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getConsumerId;
		public unsafe string ConsumerId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='LPMonitoringIdentity']/method[@name='getConsumerId' and count(parameter)=0]"
			[Register ("getConsumerId", "()Ljava/lang/String;", "GetGetConsumerIdHandler")]
			get {
				if (id_getConsumerId == IntPtr.Zero)
					id_getConsumerId = JNIEnv.GetMethodID (class_ref, "getConsumerId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConsumerId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getIssuer;
		public unsafe string Issuer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.model']/class[@name='LPMonitoringIdentity']/method[@name='getIssuer' and count(parameter)=0]"
			[Register ("getIssuer", "()Ljava/lang/String;", "GetGetIssuerHandler")]
			get {
				if (id_getIssuer == IntPtr.Zero)
					id_getIssuer = JNIEnv.GetMethodID (class_ref, "getIssuer", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIssuer), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
