using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Commands.Tasks {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/interface[@name='BaseAmsSocketConnectionCallback']"
	[Register ("com/liveperson/messaging/commands/tasks/BaseAmsSocketConnectionCallback", "", "Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsSocketConnectionCallbackInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Throwable"})]
	public partial interface IBaseAmsSocketConnectionCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/interface[@name='BaseAmsSocketConnectionCallback']/method[@name='onTaskError' and count(parameter)=2 and parameter[1][@type='com.liveperson.messaging.SocketTaskType'] and parameter[2][@type='E']]"
		[Register ("onTaskError", "(Lcom/liveperson/messaging/SocketTaskType;Ljava/lang/Throwable;)V", "GetOnTaskError_Lcom_liveperson_messaging_SocketTaskType_Ljava_lang_Throwable_Handler:Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsSocketConnectionCallbackInvoker, LP_Android_aar_Binding")]
		void OnTaskError (global::Com.Liveperson.Messaging.SocketTaskType p0, global::Java.Lang.Object p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/interface[@name='BaseAmsSocketConnectionCallback']/method[@name='onTaskSuccess' and count(parameter)=0]"
		[Register ("onTaskSuccess", "()V", "GetOnTaskSuccessHandler:Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsSocketConnectionCallbackInvoker, LP_Android_aar_Binding")]
		void OnTaskSuccess ();

	}

	[global::Android.Runtime.Register ("com/liveperson/messaging/commands/tasks/BaseAmsSocketConnectionCallback", DoNotGenerateAcw=true)]
	internal class IBaseAmsSocketConnectionCallbackInvoker : global::Java.Lang.Object, IBaseAmsSocketConnectionCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/messaging/commands/tasks/BaseAmsSocketConnectionCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBaseAmsSocketConnectionCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IBaseAmsSocketConnectionCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBaseAmsSocketConnectionCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.messaging.commands.tasks.BaseAmsSocketConnectionCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBaseAmsSocketConnectionCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onTaskError_Lcom_liveperson_messaging_SocketTaskType_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnTaskError_Lcom_liveperson_messaging_SocketTaskType_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onTaskError_Lcom_liveperson_messaging_SocketTaskType_Ljava_lang_Throwable_ == null)
				cb_onTaskError_Lcom_liveperson_messaging_SocketTaskType_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnTaskError_Lcom_liveperson_messaging_SocketTaskType_Ljava_lang_Throwable_);
			return cb_onTaskError_Lcom_liveperson_messaging_SocketTaskType_Ljava_lang_Throwable_;
		}

		static void n_OnTaskError_Lcom_liveperson_messaging_SocketTaskType_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsSocketConnectionCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsSocketConnectionCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.SocketTaskType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.SocketTaskType> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnTaskError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onTaskError_Lcom_liveperson_messaging_SocketTaskType_Ljava_lang_Throwable_;
		public unsafe void OnTaskError (global::Com.Liveperson.Messaging.SocketTaskType p0, global::Java.Lang.Object p1)
		{
			if (id_onTaskError_Lcom_liveperson_messaging_SocketTaskType_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onTaskError_Lcom_liveperson_messaging_SocketTaskType_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onTaskError", "(Lcom/liveperson/messaging/SocketTaskType;Ljava/lang/Throwable;)V");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTaskError_Lcom_liveperson_messaging_SocketTaskType_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onTaskSuccess;
#pragma warning disable 0169
		static Delegate GetOnTaskSuccessHandler ()
		{
			if (cb_onTaskSuccess == null)
				cb_onTaskSuccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnTaskSuccess);
			return cb_onTaskSuccess;
		}

		static void n_OnTaskSuccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsSocketConnectionCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsSocketConnectionCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTaskSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onTaskSuccess;
		public unsafe void OnTaskSuccess ()
		{
			if (id_onTaskSuccess == IntPtr.Zero)
				id_onTaskSuccess = JNIEnv.GetMethodID (class_ref, "onTaskSuccess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTaskSuccess);
		}

	}

}
