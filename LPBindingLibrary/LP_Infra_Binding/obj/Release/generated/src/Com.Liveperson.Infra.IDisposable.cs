using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra']/interface[@name='IDisposable']"
	[Register ("com/liveperson/infra/IDisposable", "", "Com.Liveperson.Infra.IDisposableInvoker")]
	public partial interface IDisposable : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/interface[@name='IDisposable']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler:Com.Liveperson.Infra.IDisposableInvoker, LP_Infra_Binding")]
		void Dispose ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/IDisposable", DoNotGenerateAcw=true)]
	internal class IDisposableInvoker : global::Java.Lang.Object, IDisposable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/IDisposable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDisposableInvoker); }
		}

		IntPtr class_ref;

		public static IDisposable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDisposable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.IDisposable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDisposableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.IDisposable __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.IDisposable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		IntPtr id_dispose;
		public unsafe void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispose);
		}

	}

}
