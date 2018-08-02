using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/interface[@name='IMenuCallback']"
	[Register ("com/liveperson/infra/messaging_ui/view/adapter/copybehavior/IMenuCallback", "", "Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.IMenuCallbackInvoker")]
	public partial interface IMenuCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/interface[@name='IMenuCallback']/method[@name='onMenuClose' and count(parameter)=0]"
		[Register ("onMenuClose", "()V", "GetOnMenuCloseHandler:Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.IMenuCallbackInvoker, LP_Android_aar_Binding")]
		void OnMenuClose ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/interface[@name='IMenuCallback']/method[@name='onMenuOpen' and count(parameter)=0]"
		[Register ("onMenuOpen", "()V", "GetOnMenuOpenHandler:Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.IMenuCallbackInvoker, LP_Android_aar_Binding")]
		void OnMenuOpen ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/copybehavior/IMenuCallback", DoNotGenerateAcw=true)]
	internal class IMenuCallbackInvoker : global::Java.Lang.Object, IMenuCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/view/adapter/copybehavior/IMenuCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMenuCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IMenuCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMenuCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.messaging_ui.view.adapter.copybehavior.IMenuCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMenuCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onMenuClose;
#pragma warning disable 0169
		static Delegate GetOnMenuCloseHandler ()
		{
			if (cb_onMenuClose == null)
				cb_onMenuClose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMenuClose);
			return cb_onMenuClose;
		}

		static void n_OnMenuClose (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.IMenuCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.IMenuCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMenuClose ();
		}
#pragma warning restore 0169

		IntPtr id_onMenuClose;
		public unsafe void OnMenuClose ()
		{
			if (id_onMenuClose == IntPtr.Zero)
				id_onMenuClose = JNIEnv.GetMethodID (class_ref, "onMenuClose", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMenuClose);
		}

		static Delegate cb_onMenuOpen;
#pragma warning disable 0169
		static Delegate GetOnMenuOpenHandler ()
		{
			if (cb_onMenuOpen == null)
				cb_onMenuOpen = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMenuOpen);
			return cb_onMenuOpen;
		}

		static void n_OnMenuOpen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.IMenuCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.IMenuCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMenuOpen ();
		}
#pragma warning restore 0169

		IntPtr id_onMenuOpen;
		public unsafe void OnMenuOpen ()
		{
			if (id_onMenuOpen == IntPtr.Zero)
				id_onMenuOpen = JNIEnv.GetMethodID (class_ref, "onMenuOpen", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMenuOpen);
		}

	}

}
