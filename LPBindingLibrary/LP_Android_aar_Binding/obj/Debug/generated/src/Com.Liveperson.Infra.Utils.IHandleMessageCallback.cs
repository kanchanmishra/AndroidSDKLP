using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='HandleMessageCallback.NullHandleMessageCallback']"
	[global::Android.Runtime.Register ("com/liveperson/infra/utils/HandleMessageCallback$NullHandleMessageCallback", DoNotGenerateAcw=true)]
	public partial class HandleMessageCallbackNullHandleMessageCallback : global::Java.Lang.Object, global::Com.Liveperson.Infra.Utils.IHandleMessageCallback {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/utils/HandleMessageCallback$NullHandleMessageCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HandleMessageCallbackNullHandleMessageCallback); }
		}

		protected HandleMessageCallbackNullHandleMessageCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='HandleMessageCallback.NullHandleMessageCallback']/constructor[@name='HandleMessageCallback.NullHandleMessageCallback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HandleMessageCallbackNullHandleMessageCallback ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (HandleMessageCallbackNullHandleMessageCallback)) {
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

		static Delegate cb_onHandleMessage_Landroid_os_Message_;
#pragma warning disable 0169
		static Delegate GetOnHandleMessage_Landroid_os_Message_Handler ()
		{
			if (cb_onHandleMessage_Landroid_os_Message_ == null)
				cb_onHandleMessage_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnHandleMessage_Landroid_os_Message_);
			return cb_onHandleMessage_Landroid_os_Message_;
		}

		static void n_OnHandleMessage_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.HandleMessageCallbackNullHandleMessageCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.HandleMessageCallbackNullHandleMessageCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Message p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnHandleMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onHandleMessage_Landroid_os_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='HandleMessageCallback.NullHandleMessageCallback']/method[@name='onHandleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("onHandleMessage", "(Landroid/os/Message;)V", "GetOnHandleMessage_Landroid_os_Message_Handler")]
		public virtual unsafe void OnHandleMessage (global::Android.OS.Message p0)
		{
			if (id_onHandleMessage_Landroid_os_Message_ == IntPtr.Zero)
				id_onHandleMessage_Landroid_os_Message_ = JNIEnv.GetMethodID (class_ref, "onHandleMessage", "(Landroid/os/Message;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHandleMessage_Landroid_os_Message_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onHandleMessage", "(Landroid/os/Message;)V"), __args);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.utils']/interface[@name='HandleMessageCallback']"
	[Register ("com/liveperson/infra/utils/HandleMessageCallback", "", "Com.Liveperson.Infra.Utils.IHandleMessageCallbackInvoker")]
	public partial interface IHandleMessageCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/interface[@name='HandleMessageCallback']/method[@name='onHandleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("onHandleMessage", "(Landroid/os/Message;)V", "GetOnHandleMessage_Landroid_os_Message_Handler:Com.Liveperson.Infra.Utils.IHandleMessageCallbackInvoker, LP_Android_aar_Binding")]
		void OnHandleMessage (global::Android.OS.Message p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/utils/HandleMessageCallback", DoNotGenerateAcw=true)]
	internal class IHandleMessageCallbackInvoker : global::Java.Lang.Object, IHandleMessageCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/utils/HandleMessageCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IHandleMessageCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IHandleMessageCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHandleMessageCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.utils.HandleMessageCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHandleMessageCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onHandleMessage_Landroid_os_Message_;
#pragma warning disable 0169
		static Delegate GetOnHandleMessage_Landroid_os_Message_Handler ()
		{
			if (cb_onHandleMessage_Landroid_os_Message_ == null)
				cb_onHandleMessage_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnHandleMessage_Landroid_os_Message_);
			return cb_onHandleMessage_Landroid_os_Message_;
		}

		static void n_OnHandleMessage_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.IHandleMessageCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.IHandleMessageCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Message p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnHandleMessage (p0);
		}
#pragma warning restore 0169

		IntPtr id_onHandleMessage_Landroid_os_Message_;
		public unsafe void OnHandleMessage (global::Android.OS.Message p0)
		{
			if (id_onHandleMessage_Landroid_os_Message_ == IntPtr.Zero)
				id_onHandleMessage_Landroid_os_Message_ = JNIEnv.GetMethodID (class_ref, "onHandleMessage", "(Landroid/os/Message;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHandleMessage_Landroid_os_Message_, __args);
		}

	}

}
