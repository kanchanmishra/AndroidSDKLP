using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Sdkstatemachine.Shutdown {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine.shutdown']/interface[@name='ShutDownCompletionListener']"
	[Register ("com/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener", "", "Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListenerInvoker")]
	public partial interface IShutDownCompletionListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine.shutdown']/interface[@name='ShutDownCompletionListener']/method[@name='shutDownCompleted' and count(parameter)=0]"
		[Register ("shutDownCompleted", "()V", "GetShutDownCompletedHandler:Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListenerInvoker, LP_Infra_Binding")]
		void ShutDownCompleted ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine.shutdown']/interface[@name='ShutDownCompletionListener']/method[@name='shutDownFailed' and count(parameter)=0]"
		[Register ("shutDownFailed", "()V", "GetShutDownFailedHandler:Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListenerInvoker, LP_Infra_Binding")]
		void ShutDownFailed ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener", DoNotGenerateAcw=true)]
	internal class IShutDownCompletionListenerInvoker : global::Java.Lang.Object, IShutDownCompletionListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IShutDownCompletionListenerInvoker); }
		}

		IntPtr class_ref;

		public static IShutDownCompletionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IShutDownCompletionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.sdkstatemachine.shutdown.ShutDownCompletionListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IShutDownCompletionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_shutDownCompleted;
#pragma warning disable 0169
		static Delegate GetShutDownCompletedHandler ()
		{
			if (cb_shutDownCompleted == null)
				cb_shutDownCompleted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShutDownCompleted);
			return cb_shutDownCompleted;
		}

		static void n_ShutDownCompleted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShutDownCompleted ();
		}
#pragma warning restore 0169

		IntPtr id_shutDownCompleted;
		public unsafe void ShutDownCompleted ()
		{
			if (id_shutDownCompleted == IntPtr.Zero)
				id_shutDownCompleted = JNIEnv.GetMethodID (class_ref, "shutDownCompleted", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutDownCompleted);
		}

		static Delegate cb_shutDownFailed;
#pragma warning disable 0169
		static Delegate GetShutDownFailedHandler ()
		{
			if (cb_shutDownFailed == null)
				cb_shutDownFailed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShutDownFailed);
			return cb_shutDownFailed;
		}

		static void n_ShutDownFailed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShutDownFailed ();
		}
#pragma warning restore 0169

		IntPtr id_shutDownFailed;
		public unsafe void ShutDownFailed ()
		{
			if (id_shutDownFailed == IntPtr.Zero)
				id_shutDownFailed = JNIEnv.GetMethodID (class_ref, "shutDownFailed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutDownFailed);
		}

	}

	[global::Android.Runtime.Register ("mono/com/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListenerImplementor")]
	internal sealed partial class IShutDownCompletionListenerImplementor : global::Java.Lang.Object, IShutDownCompletionListener {

		object sender;

		public IShutDownCompletionListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler ShutDownCompletedHandler;
#pragma warning restore 0649

		public void ShutDownCompleted ()
		{
			var __h = ShutDownCompletedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler ShutDownFailedHandler;
#pragma warning restore 0649

		public void ShutDownFailed ()
		{
			var __h = ShutDownFailedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IShutDownCompletionListenerImplementor value)
		{
			return value.ShutDownCompletedHandler == null && value.ShutDownFailedHandler == null;
		}
	}

}
