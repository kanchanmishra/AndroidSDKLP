using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Monitoring.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.monitoring.utils']/class[@name='ThreadPoolExecutor']"
	[global::Android.Runtime.Register ("com/liveperson/monitoring/utils/ThreadPoolExecutor", DoNotGenerateAcw=true)]
	public partial class ThreadPoolExecutor : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/monitoring/utils/ThreadPoolExecutor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ThreadPoolExecutor); }
		}

		protected ThreadPoolExecutor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.monitoring.utils']/class[@name='ThreadPoolExecutor']/constructor[@name='ThreadPoolExecutor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ThreadPoolExecutor ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ThreadPoolExecutor)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.utils']/class[@name='ThreadPoolExecutor']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
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

		static IntPtr id_executeDelayed_Ljava_lang_Runnable_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.utils']/class[@name='ThreadPoolExecutor']/method[@name='executeDelayed' and count(parameter)=2 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long']]"
		[Register ("executeDelayed", "(Ljava/lang/Runnable;J)V", "")]
		public static unsafe void ExecuteDelayed (global::Java.Lang.IRunnable p0, long p1)
		{
			if (id_executeDelayed_Ljava_lang_Runnable_J == IntPtr.Zero)
				id_executeDelayed_Ljava_lang_Runnable_J = JNIEnv.GetStaticMethodID (class_ref, "executeDelayed", "(Ljava/lang/Runnable;J)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_executeDelayed_Ljava_lang_Runnable_J, __args);
			} finally {
			}
		}

		static IntPtr id_killAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.utils']/class[@name='ThreadPoolExecutor']/method[@name='killAll' and count(parameter)=0]"
		[Register ("killAll", "()V", "")]
		public static unsafe void KillAll ()
		{
			if (id_killAll == IntPtr.Zero)
				id_killAll = JNIEnv.GetStaticMethodID (class_ref, "killAll", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_killAll);
			} finally {
			}
		}

	}
}
