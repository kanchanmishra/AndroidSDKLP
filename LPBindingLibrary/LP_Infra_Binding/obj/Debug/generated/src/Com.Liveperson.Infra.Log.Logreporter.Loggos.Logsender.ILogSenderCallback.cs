using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Log.Logreporter.Loggos.Logsender {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos.logsender']/interface[@name='LogSenderCallback']"
	[Register ("com/liveperson/infra/log/logreporter/loggos/logsender/LogSenderCallback", "", "Com.Liveperson.Infra.Log.Logreporter.Loggos.Logsender.ILogSenderCallbackInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Throwable"})]
	public partial interface ILogSenderCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos.logsender']/interface[@name='LogSenderCallback']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.liveperson.infra.log.logreporter.loggos.LoggosMessage&gt;'] and parameter[2][@type='E']]"
		[Register ("onError", "(Ljava/util/List;Ljava/lang/Throwable;)V", "GetOnError_Ljava_util_List_Ljava_lang_Throwable_Handler:Com.Liveperson.Infra.Log.Logreporter.Loggos.Logsender.ILogSenderCallbackInvoker, LP_Infra_Binding")]
		void OnError (global::System.Collections.Generic.IList<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> p0, global::Java.Lang.Object p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos.logsender']/interface[@name='LogSenderCallback']/method[@name='onSuccess' and count(parameter)=0]"
		[Register ("onSuccess", "()V", "GetOnSuccessHandler:Com.Liveperson.Infra.Log.Logreporter.Loggos.Logsender.ILogSenderCallbackInvoker, LP_Infra_Binding")]
		void OnSuccess ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/log/logreporter/loggos/logsender/LogSenderCallback", DoNotGenerateAcw=true)]
	internal class ILogSenderCallbackInvoker : global::Java.Lang.Object, ILogSenderCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/log/logreporter/loggos/logsender/LogSenderCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILogSenderCallbackInvoker); }
		}

		IntPtr class_ref;

		public static ILogSenderCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILogSenderCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.log.logreporter.loggos.logsender.LogSenderCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILogSenderCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onError_Ljava_util_List_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnError_Ljava_util_List_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onError_Ljava_util_List_Ljava_lang_Throwable_ == null)
				cb_onError_Ljava_util_List_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_util_List_Ljava_lang_Throwable_);
			return cb_onError_Ljava_util_List_Ljava_lang_Throwable_;
		}

		static void n_OnError_Ljava_util_List_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Logsender.ILogSenderCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Logsender.ILogSenderCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onError_Ljava_util_List_Ljava_lang_Throwable_;
		public unsafe void OnError (global::System.Collections.Generic.IList<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> p0, global::Java.Lang.Object p1)
		{
			if (id_onError_Ljava_util_List_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Ljava_util_List_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/util/List;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_util_List_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onSuccess;
#pragma warning disable 0169
		static Delegate GetOnSuccessHandler ()
		{
			if (cb_onSuccess == null)
				cb_onSuccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSuccess);
			return cb_onSuccess;
		}

		static void n_OnSuccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Logsender.ILogSenderCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Logsender.ILogSenderCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onSuccess;
		public unsafe void OnSuccess ()
		{
			if (id_onSuccess == IntPtr.Zero)
				id_onSuccess = JNIEnv.GetMethodID (class_ref, "onSuccess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess);
		}

	}

}
