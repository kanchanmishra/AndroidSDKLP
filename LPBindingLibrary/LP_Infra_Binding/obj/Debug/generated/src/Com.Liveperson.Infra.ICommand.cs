using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra']/interface[@name='Command']"
	[Register ("com/liveperson/infra/Command", "", "Com.Liveperson.Infra.ICommandInvoker")]
	public partial interface ICommand : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/interface[@name='Command']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()V", "GetExecuteHandler:Com.Liveperson.Infra.ICommandInvoker, LP_Infra_Binding")]
		void Execute ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/Command", DoNotGenerateAcw=true)]
	internal class ICommandInvoker : global::Java.Lang.Object, ICommand {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/Command");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICommandInvoker); }
		}

		IntPtr class_ref;

		public static ICommand GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICommand> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.Command"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICommandInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_execute;
#pragma warning disable 0169
		static Delegate GetExecuteHandler ()
		{
			if (cb_execute == null)
				cb_execute = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Execute);
			return cb_execute;
		}

		static void n_Execute (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.ICommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		IntPtr id_execute;
		public unsafe void Execute ()
		{
			if (id_execute == IntPtr.Zero)
				id_execute = JNIEnv.GetMethodID (class_ref, "execute", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_execute);
		}

	}

}
