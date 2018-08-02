using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Commands.Tasks {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='BaseAmsSocketConnectionTask']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/commands/tasks/BaseAmsSocketConnectionTask", DoNotGenerateAcw=true)]
	public abstract partial class BaseAmsSocketConnectionTask : global::Com.Liveperson.Messaging.Commands.Tasks.BaseConnectionTask {


		static IntPtr mCallback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='BaseAmsSocketConnectionTask']/field[@name='mCallback']"
		[Register ("mCallback")]
		protected global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsSocketConnectionCallback MCallback {
			get {
				if (mCallback_jfieldId == IntPtr.Zero)
					mCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mCallback", "Lcom/liveperson/messaging/commands/tasks/BaseAmsSocketConnectionCallback;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCallback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.IBaseAmsSocketConnectionCallback> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCallback_jfieldId == IntPtr.Zero)
					mCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mCallback", "Lcom/liveperson/messaging/commands/tasks/BaseAmsSocketConnectionCallback;");
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
				return JNIEnv.FindClass ("com/liveperson/messaging/commands/tasks/BaseAmsSocketConnectionTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseAmsSocketConnectionTask); }
		}

		protected BaseAmsSocketConnectionTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='BaseAmsSocketConnectionTask']/constructor[@name='BaseAmsSocketConnectionTask' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseAmsSocketConnectionTask ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BaseAmsSocketConnectionTask)) {
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

		static Delegate cb_setBrandId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBrandId_Ljava_lang_String_Handler ()
		{
			if (cb_setBrandId_Ljava_lang_String_ == null)
				cb_setBrandId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBrandId_Ljava_lang_String_);
			return cb_setBrandId_Ljava_lang_String_;
		}

		static void n_SetBrandId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsSocketConnectionTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.BaseAmsSocketConnectionTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBrandId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBrandId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='BaseAmsSocketConnectionTask']/method[@name='setBrandId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setBrandId", "(Ljava/lang/String;)V", "GetSetBrandId_Ljava_lang_String_Handler")]
		public override unsafe void SetBrandId (string p0)
		{
			if (id_setBrandId_Ljava_lang_String_ == IntPtr.Zero)
				id_setBrandId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBrandId", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBrandId_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBrandId", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/messaging/commands/tasks/BaseAmsSocketConnectionTask", DoNotGenerateAcw=true)]
	internal partial class BaseAmsSocketConnectionTaskInvoker : BaseAmsSocketConnectionTask {

		public BaseAmsSocketConnectionTaskInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseAmsSocketConnectionTaskInvoker); }
		}

		static IntPtr id_execute;
		[Register ("execute", "()V", "GetExecuteHandler")]
		public override unsafe void Execute ()
		{
			if (id_execute == IntPtr.Zero)
				id_execute = JNIEnv.GetMethodID (class_ref, "execute", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_execute);
			} finally {
			}
		}

	}

}
