using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='UniqueID']"
	[global::Android.Runtime.Register ("com/liveperson/infra/utils/UniqueID", DoNotGenerateAcw=true)]
	public partial class UniqueID : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/utils/UniqueID", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UniqueID); }
		}

		protected UniqueID (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='UniqueID']/constructor[@name='UniqueID' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UniqueID ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UniqueID)) {
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

		static IntPtr id_createUniqueMessageEventId;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='UniqueID']/method[@name='createUniqueMessageEventId' and count(parameter)=0]"
		[Register ("createUniqueMessageEventId", "()Ljava/lang/String;", "")]
		public static unsafe string CreateUniqueMessageEventId ()
		{
			if (id_createUniqueMessageEventId == IntPtr.Zero)
				id_createUniqueMessageEventId = JNIEnv.GetStaticMethodID (class_ref, "createUniqueMessageEventId", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_createUniqueMessageEventId), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getUniqueID;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='UniqueID']/method[@name='getUniqueID' and count(parameter)=0]"
		[Register ("getUniqueID", "()J", "")]
		public static unsafe long GetUniqueID ()
		{
			if (id_getUniqueID == IntPtr.Zero)
				id_getUniqueID = JNIEnv.GetStaticMethodID (class_ref, "getUniqueID", "()J");
			try {
				return JNIEnv.CallStaticLongMethod  (class_ref, id_getUniqueID);
			} finally {
			}
		}

	}
}
