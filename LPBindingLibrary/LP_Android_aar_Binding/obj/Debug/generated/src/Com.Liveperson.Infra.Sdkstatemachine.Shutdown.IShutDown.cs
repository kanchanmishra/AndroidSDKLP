using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Sdkstatemachine.Shutdown {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine.shutdown']/interface[@name='ShutDown']"
	[Register ("com/liveperson/infra/sdkstatemachine/shutdown/ShutDown", "", "Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownInvoker")]
	public partial interface IShutDown : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine.shutdown']/interface[@name='ShutDown']/method[@name='shutDown' and count(parameter)=0]"
		[Register ("shutDown", "()V", "GetShutDownHandler:Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownInvoker, LP_Android_aar_Binding")]
		void ShutDown ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/sdkstatemachine/shutdown/ShutDown", DoNotGenerateAcw=true)]
	internal class IShutDownInvoker : global::Java.Lang.Object, IShutDown {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/sdkstatemachine/shutdown/ShutDown");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IShutDownInvoker); }
		}

		IntPtr class_ref;

		public static IShutDown GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IShutDown> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.sdkstatemachine.shutdown.ShutDown"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IShutDownInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_shutDown;
#pragma warning disable 0169
		static Delegate GetShutDownHandler ()
		{
			if (cb_shutDown == null)
				cb_shutDown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShutDown);
			return cb_shutDown;
		}

		static void n_ShutDown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDown __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDown> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShutDown ();
		}
#pragma warning restore 0169

		IntPtr id_shutDown;
		public unsafe void ShutDown ()
		{
			if (id_shutDown == IntPtr.Zero)
				id_shutDown = JNIEnv.GetMethodID (class_ref, "shutDown", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutDown);
		}

	}

}
