using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SDKUncaughtExceptionHandler']"
	[global::Android.Runtime.Register ("com/liveperson/infra/utils/SDKUncaughtExceptionHandler", DoNotGenerateAcw=true)]
	public partial class SDKUncaughtExceptionHandler : global::Java.Lang.Object, global::Java.Lang.Thread.IUncaughtExceptionHandler {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/utils/SDKUncaughtExceptionHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SDKUncaughtExceptionHandler); }
		}

		protected SDKUncaughtExceptionHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SDKUncaughtExceptionHandler']/constructor[@name='SDKUncaughtExceptionHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SDKUncaughtExceptionHandler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SDKUncaughtExceptionHandler)) {
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

		static IntPtr id_getInstance;
		protected static unsafe global::Com.Liveperson.Infra.Utils.SDKUncaughtExceptionHandler Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SDKUncaughtExceptionHandler']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/liveperson/infra/utils/SDKUncaughtExceptionHandler;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/liveperson/infra/utils/SDKUncaughtExceptionHandler;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SDKUncaughtExceptionHandler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance_Ljava_lang_Thread_UncaughtExceptionHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SDKUncaughtExceptionHandler']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='java.lang.Thread.UncaughtExceptionHandler']]"
		[Register ("getInstance", "(Ljava/lang/Thread$UncaughtExceptionHandler;)Lcom/liveperson/infra/utils/SDKUncaughtExceptionHandler;", "")]
		public static unsafe global::Com.Liveperson.Infra.Utils.SDKUncaughtExceptionHandler GetInstance (global::Java.Lang.Thread.IUncaughtExceptionHandler p0)
		{
			if (id_getInstance_Ljava_lang_Thread_UncaughtExceptionHandler_ == IntPtr.Zero)
				id_getInstance_Ljava_lang_Thread_UncaughtExceptionHandler_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Ljava/lang/Thread$UncaughtExceptionHandler;)Lcom/liveperson/infra/utils/SDKUncaughtExceptionHandler;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Liveperson.Infra.Utils.SDKUncaughtExceptionHandler __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SDKUncaughtExceptionHandler> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Ljava_lang_Thread_UncaughtExceptionHandler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetUncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_Handler ()
		{
			if (cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ == null)
				cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_);
			return cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_;
		}

		static void n_UncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Utils.SDKUncaughtExceptionHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SDKUncaughtExceptionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Thread p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UncaughtException (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SDKUncaughtExceptionHandler']/method[@name='uncaughtException' and count(parameter)=2 and parameter[1][@type='java.lang.Thread'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V", "GetUncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void UncaughtException (global::Java.Lang.Thread p0, global::Java.Lang.Throwable p1)
		{
			if (id_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V"), __args);
			} finally {
			}
		}

	}
}
