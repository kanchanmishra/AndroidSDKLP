using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Log.Logreporter.Loggos.Logsender {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos.logsender']/class[@name='LogSender']"
	[global::Android.Runtime.Register ("com/liveperson/infra/log/logreporter/loggos/logsender/LogSender", DoNotGenerateAcw=true)]
	public abstract partial class LogSender : global::Java.Lang.Object {


		static IntPtr mCallback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos.logsender']/class[@name='LogSender']/field[@name='mCallback']"
		[Register ("mCallback")]
		protected global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Logsender.ILogSenderCallback MCallback {
			get {
				if (mCallback_jfieldId == IntPtr.Zero)
					mCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mCallback", "Lcom/liveperson/infra/log/logreporter/loggos/logsender/LogSenderCallback;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCallback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Logsender.ILogSenderCallback> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCallback_jfieldId == IntPtr.Zero)
					mCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mCallback", "Lcom/liveperson/infra/log/logreporter/loggos/logsender/LogSenderCallback;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCallback_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/log/logreporter/loggos/logsender/LogSender", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LogSender); }
		}

		protected LogSender (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos.logsender']/class[@name='LogSender']/constructor[@name='LogSender' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LogSender ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LogSender)) {
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

		static Delegate cb_sendBulk_Ljava_lang_String_Ljava_util_List_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSendBulk_Ljava_lang_String_Ljava_util_List_Ljava_util_List_Handler ()
		{
			if (cb_sendBulk_Ljava_lang_String_Ljava_util_List_Ljava_util_List_ == null)
				cb_sendBulk_Ljava_lang_String_Ljava_util_List_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendBulk_Ljava_lang_String_Ljava_util_List_Ljava_util_List_);
			return cb_sendBulk_Ljava_lang_String_Ljava_util_List_Ljava_util_List_;
		}

		static void n_SendBulk_Ljava_lang_String_Ljava_util_List_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Logsender.LogSender __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Logsender.LogSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendBulk (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos.logsender']/class[@name='LogSender']/method[@name='sendBulk' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;com.liveperson.infra.log.logreporter.loggos.LoggosMessage&gt;'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("sendBulk", "(Ljava/lang/String;Ljava/util/List;Ljava/util/List;)V", "GetSendBulk_Ljava_lang_String_Ljava_util_List_Ljava_util_List_Handler")]
		public abstract void SendBulk (string p0, global::System.Collections.Generic.IList<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> p1, global::System.Collections.Generic.IList<string> p2);

		static Delegate cb_setCallback_Lcom_liveperson_infra_log_logreporter_loggos_logsender_LogSenderCallback_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lcom_liveperson_infra_log_logreporter_loggos_logsender_LogSenderCallback_Handler ()
		{
			if (cb_setCallback_Lcom_liveperson_infra_log_logreporter_loggos_logsender_LogSenderCallback_ == null)
				cb_setCallback_Lcom_liveperson_infra_log_logreporter_loggos_logsender_LogSenderCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallback_Lcom_liveperson_infra_log_logreporter_loggos_logsender_LogSenderCallback_);
			return cb_setCallback_Lcom_liveperson_infra_log_logreporter_loggos_logsender_LogSenderCallback_;
		}

		static void n_SetCallback_Lcom_liveperson_infra_log_logreporter_loggos_logsender_LogSenderCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Logsender.LogSender __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Logsender.LogSender> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Logsender.ILogSenderCallback p0 = (global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Logsender.ILogSenderCallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Logsender.ILogSenderCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCallback_Lcom_liveperson_infra_log_logreporter_loggos_logsender_LogSenderCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos.logsender']/class[@name='LogSender']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.log.logreporter.loggos.logsender.LogSenderCallback']]"
		[Register ("setCallback", "(Lcom/liveperson/infra/log/logreporter/loggos/logsender/LogSenderCallback;)V", "GetSetCallback_Lcom_liveperson_infra_log_logreporter_loggos_logsender_LogSenderCallback_Handler")]
		public virtual unsafe void SetCallback (global::Com.Liveperson.Infra.Log.Logreporter.Loggos.Logsender.ILogSenderCallback p0)
		{
			if (id_setCallback_Lcom_liveperson_infra_log_logreporter_loggos_logsender_LogSenderCallback_ == IntPtr.Zero)
				id_setCallback_Lcom_liveperson_infra_log_logreporter_loggos_logsender_LogSenderCallback_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lcom/liveperson/infra/log/logreporter/loggos/logsender/LogSenderCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCallback_Lcom_liveperson_infra_log_logreporter_loggos_logsender_LogSenderCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallback", "(Lcom/liveperson/infra/log/logreporter/loggos/logsender/LogSenderCallback;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/log/logreporter/loggos/logsender/LogSender", DoNotGenerateAcw=true)]
	internal partial class LogSenderInvoker : LogSender {

		public LogSenderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (LogSenderInvoker); }
		}

		static IntPtr id_sendBulk_Ljava_lang_String_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.log.logreporter.loggos.logsender']/class[@name='LogSender']/method[@name='sendBulk' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;com.liveperson.infra.log.logreporter.loggos.LoggosMessage&gt;'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("sendBulk", "(Ljava/lang/String;Ljava/util/List;Ljava/util/List;)V", "GetSendBulk_Ljava_lang_String_Ljava_util_List_Ljava_util_List_Handler")]
		public override unsafe void SendBulk (string p0, global::System.Collections.Generic.IList<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage> p1, global::System.Collections.Generic.IList<string> p2)
		{
			if (id_sendBulk_Ljava_lang_String_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_sendBulk_Ljava_lang_String_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "sendBulk", "(Ljava/lang/String;Ljava/util/List;Ljava/util/List;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Liveperson.Infra.Log.Logreporter.Loggos.LoggosMessage>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendBulk_Ljava_lang_String_Ljava_util_List_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}

}
