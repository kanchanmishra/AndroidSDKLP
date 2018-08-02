using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Monitoring.Utils {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.monitoring.utils']/interface[@name='Clearable']"
	[Register ("com/liveperson/monitoring/utils/Clearable", "", "Com.Liveperson.Monitoring.Utils.IClearableInvoker")]
	public partial interface IClearable : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.utils']/interface[@name='Clearable']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler:Com.Liveperson.Monitoring.Utils.IClearableInvoker, LP_Monitoring_Binding")]
		void Clear ();

	}

	[global::Android.Runtime.Register ("com/liveperson/monitoring/utils/Clearable", DoNotGenerateAcw=true)]
	internal class IClearableInvoker : global::Java.Lang.Object, IClearable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/monitoring/utils/Clearable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IClearableInvoker); }
		}

		IntPtr class_ref;

		public static IClearable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IClearable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.monitoring.utils.Clearable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IClearableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Monitoring.Utils.IClearable __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Utils.IClearable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
		}

	}

}
