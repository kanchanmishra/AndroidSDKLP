using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Controller {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.controller']/interface[@name='AudioRecordable']"
	[Register ("com/liveperson/infra/controller/AudioRecordable", "", "Com.Liveperson.Infra.Controller.IAudioRecordableInvoker")]
	public partial interface IAudioRecordable : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.controller']/interface[@name='AudioRecordable']/method[@name='cancelRecording' and count(parameter)=0]"
		[Register ("cancelRecording", "()V", "GetCancelRecordingHandler:Com.Liveperson.Infra.Controller.IAudioRecordableInvoker, LP_Binding1_JustLP")]
		void CancelRecording ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/controller/AudioRecordable", DoNotGenerateAcw=true)]
	internal class IAudioRecordableInvoker : global::Java.Lang.Object, IAudioRecordable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/controller/AudioRecordable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAudioRecordableInvoker); }
		}

		IntPtr class_ref;

		public static IAudioRecordable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAudioRecordable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.controller.AudioRecordable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAudioRecordableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_cancelRecording;
#pragma warning disable 0169
		static Delegate GetCancelRecordingHandler ()
		{
			if (cb_cancelRecording == null)
				cb_cancelRecording = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CancelRecording);
			return cb_cancelRecording;
		}

		static void n_CancelRecording (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Controller.IAudioRecordable __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Controller.IAudioRecordable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelRecording ();
		}
#pragma warning restore 0169

		IntPtr id_cancelRecording;
		public unsafe void CancelRecording ()
		{
			if (id_cancelRecording == IntPtr.Zero)
				id_cancelRecording = JNIEnv.GetMethodID (class_ref, "cancelRecording", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelRecording);
		}

	}

}
