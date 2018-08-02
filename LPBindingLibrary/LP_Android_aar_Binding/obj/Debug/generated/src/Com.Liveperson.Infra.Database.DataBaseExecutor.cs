using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Database {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DataBaseExecutor']"
	[global::Android.Runtime.Register ("com/liveperson/infra/database/DataBaseExecutor", DoNotGenerateAcw=true)]
	public partial class DataBaseExecutor : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/database/DataBaseExecutor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataBaseExecutor); }
		}

		protected DataBaseExecutor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DataBaseExecutor']/constructor[@name='DataBaseExecutor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DataBaseExecutor ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DataBaseExecutor)) {
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

		static IntPtr id_execute_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DataBaseExecutor']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("execute", "(Ljava/lang/Runnable;)V", "")]
		public static unsafe void Execute (global::Java.Lang.IRunnable p0)
		{
			if (id_execute_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_execute_Ljava_lang_Runnable_ = JNIEnv.GetStaticMethodID (class_ref, "execute", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_execute_Ljava_lang_Runnable_, __args);
			} finally {
			}
		}

		static IntPtr id_killAll_Lcom_liveperson_infra_ICallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DataBaseExecutor']/method[@name='killAll' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.ICallback&lt;java.lang.Void, java.lang.Exception&gt;']]"
		[Register ("killAll", "(Lcom/liveperson/infra/ICallback;)V", "")]
		public static unsafe void KillAll (global::Com.Liveperson.Infra.ICallback p0)
		{
			if (id_killAll_Lcom_liveperson_infra_ICallback_ == IntPtr.Zero)
				id_killAll_Lcom_liveperson_infra_ICallback_ = JNIEnv.GetStaticMethodID (class_ref, "killAll", "(Lcom/liveperson/infra/ICallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_killAll_Lcom_liveperson_infra_ICallback_, __args);
			} finally {
			}
		}

	}
}
