using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Commands.Tasks {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/interface[@name='BaseAmsAccountConnectionCallback']"
	[Register ("com/liveperson/messaging/commands/tasks/BaseAmsAccountConnectionCallback", "", "Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsAccountConnectionCallbackInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Throwable"})]
	public partial interface IBaseAmsAccountConnectionCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/interface[@name='BaseAmsAccountConnectionCallback']/method[@name='onTaskError' and count(parameter)=2 and parameter[1][@type='com.liveperson.messaging.TaskType'] and parameter[2][@type='E']]"
		[Register ("onTaskError", "(Lcom/liveperson/messaging/TaskType;Ljava/lang/Throwable;)V", "GetOnTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Throwable_Handler:Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsAccountConnectionCallbackInvoker, LP_Messaging_Binding")]
		void OnTaskError (global::Com.Liveperson.Messaging.TaskType p0, global::Java.Lang.Object p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/interface[@name='BaseAmsAccountConnectionCallback']/method[@name='onTaskSuccess' and count(parameter)=0]"
		[Register ("onTaskSuccess", "()V", "GetOnTaskSuccessHandler:Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsAccountConnectionCallbackInvoker, LP_Messaging_Binding")]
		void OnTaskSuccess ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/interface[@name='BaseAmsAccountConnectionCallback']/method[@name='setSecondaryTask' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSecondaryTask", "(Z)V", "GetSetSecondaryTask_ZHandler:Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsAccountConnectionCallbackInvoker, LP_Messaging_Binding")]
		void SetSecondaryTask (bool p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/messaging/commands/tasks/BaseAmsAccountConnectionCallback", DoNotGenerateAcw=true)]
	internal class IBaseAmsAccountConnectionCallbackInvoker : global::Java.Lang.Object, IBaseAmsAccountConnectionCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/messaging/commands/tasks/BaseAmsAccountConnectionCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBaseAmsAccountConnectionCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IBaseAmsAccountConnectionCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBaseAmsAccountConnectionCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.messaging.commands.tasks.BaseAmsAccountConnectionCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBaseAmsAccountConnectionCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Throwable_ == null)
				cb_onTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Throwable_);
			return cb_onTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Throwable_;
		}

		static void n_OnTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsAccountConnectionCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsAccountConnectionCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.TaskType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.TaskType> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnTaskError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Throwable_;
		public unsafe void OnTaskError (global::Com.Liveperson.Messaging.TaskType p0, global::Java.Lang.Object p1)
		{
			if (id_onTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onTaskError", "(Lcom/liveperson/messaging/TaskType;Ljava/lang/Throwable;)V");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTaskError_Lcom_liveperson_messaging_TaskType_Ljava_lang_Throwable_, __args);
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
			global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsAccountConnectionCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsAccountConnectionCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_setSecondaryTask_Z;
#pragma warning disable 0169
		static Delegate GetSetSecondaryTask_ZHandler ()
		{
			if (cb_setSecondaryTask_Z == null)
				cb_setSecondaryTask_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSecondaryTask_Z);
			return cb_setSecondaryTask_Z;
		}

		static void n_SetSecondaryTask_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsAccountConnectionCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsAccountConnectionCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSecondaryTask (p0);
		}
#pragma warning restore 0169

		IntPtr id_setSecondaryTask_Z;
		public unsafe void SetSecondaryTask (bool p0)
		{
			if (id_setSecondaryTask_Z == IntPtr.Zero)
				id_setSecondaryTask_Z = JNIEnv.GetMethodID (class_ref, "setSecondaryTask", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSecondaryTask_Z, __args);
		}

	}

}
