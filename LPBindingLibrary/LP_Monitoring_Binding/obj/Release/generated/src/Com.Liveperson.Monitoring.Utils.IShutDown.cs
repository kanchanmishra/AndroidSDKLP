using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Monitoring.Utils {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.monitoring.utils']/interface[@name='ShutDown']"
	[Register ("com/liveperson/monitoring/utils/ShutDown", "", "Com.Liveperson.Monitoring.Utils.IShutDownInvoker")]
	public partial interface IShutDown : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.monitoring.utils']/interface[@name='ShutDown']/method[@name='shutDown' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("shutDown", "(Landroid/content/Context;)V", "GetShutDown_Landroid_content_Context_Handler:Com.Liveperson.Monitoring.Utils.IShutDownInvoker, LP_Monitoring_Binding")]
		void ShutDown (global::Android.Content.Context p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/monitoring/utils/ShutDown", DoNotGenerateAcw=true)]
	internal class IShutDownInvoker : global::Java.Lang.Object, IShutDown {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/monitoring/utils/ShutDown");

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
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.monitoring.utils.ShutDown"));
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

		static Delegate cb_shutDown_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetShutDown_Landroid_content_Context_Handler ()
		{
			if (cb_shutDown_Landroid_content_Context_ == null)
				cb_shutDown_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShutDown_Landroid_content_Context_);
			return cb_shutDown_Landroid_content_Context_;
		}

		static void n_ShutDown_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Monitoring.Utils.IShutDown __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Monitoring.Utils.IShutDown> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShutDown (p0);
		}
#pragma warning restore 0169

		IntPtr id_shutDown_Landroid_content_Context_;
		public unsafe void ShutDown (global::Android.Content.Context p0)
		{
			if (id_shutDown_Landroid_content_Context_ == IntPtr.Zero)
				id_shutDown_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "shutDown", "(Landroid/content/Context;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutDown_Landroid_content_Context_, __args);
		}

	}

}
