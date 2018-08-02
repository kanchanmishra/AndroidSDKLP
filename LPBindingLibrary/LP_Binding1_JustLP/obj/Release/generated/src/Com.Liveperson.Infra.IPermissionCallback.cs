using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra']/interface[@name='IPermissionCallback']"
	[Register ("com/liveperson/infra/IPermissionCallback", "", "Com.Liveperson.Infra.IPermissionCallbackInvoker")]
	public partial interface IPermissionCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/interface[@name='IPermissionCallback']/method[@name='onPermissionsDenied' and count(parameter)=0]"
		[Register ("onPermissionsDenied", "()V", "GetOnPermissionsDeniedHandler:Com.Liveperson.Infra.IPermissionCallbackInvoker, LP_Binding1_JustLP")]
		void OnPermissionsDenied ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/interface[@name='IPermissionCallback']/method[@name='onPermissionsGranted' and count(parameter)=0]"
		[Register ("onPermissionsGranted", "()V", "GetOnPermissionsGrantedHandler:Com.Liveperson.Infra.IPermissionCallbackInvoker, LP_Binding1_JustLP")]
		void OnPermissionsGranted ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/IPermissionCallback", DoNotGenerateAcw=true)]
	internal class IPermissionCallbackInvoker : global::Java.Lang.Object, IPermissionCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/IPermissionCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPermissionCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IPermissionCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPermissionCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.IPermissionCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPermissionCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onPermissionsDenied;
#pragma warning disable 0169
		static Delegate GetOnPermissionsDeniedHandler ()
		{
			if (cb_onPermissionsDenied == null)
				cb_onPermissionsDenied = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPermissionsDenied);
			return cb_onPermissionsDenied;
		}

		static void n_OnPermissionsDenied (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.IPermissionCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.IPermissionCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPermissionsDenied ();
		}
#pragma warning restore 0169

		IntPtr id_onPermissionsDenied;
		public unsafe void OnPermissionsDenied ()
		{
			if (id_onPermissionsDenied == IntPtr.Zero)
				id_onPermissionsDenied = JNIEnv.GetMethodID (class_ref, "onPermissionsDenied", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPermissionsDenied);
		}

		static Delegate cb_onPermissionsGranted;
#pragma warning disable 0169
		static Delegate GetOnPermissionsGrantedHandler ()
		{
			if (cb_onPermissionsGranted == null)
				cb_onPermissionsGranted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPermissionsGranted);
			return cb_onPermissionsGranted;
		}

		static void n_OnPermissionsGranted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.IPermissionCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.IPermissionCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPermissionsGranted ();
		}
#pragma warning restore 0169

		IntPtr id_onPermissionsGranted;
		public unsafe void OnPermissionsGranted ()
		{
			if (id_onPermissionsGranted == IntPtr.Zero)
				id_onPermissionsGranted = JNIEnv.GetMethodID (class_ref, "onPermissionsGranted", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPermissionsGranted);
		}

	}

}
