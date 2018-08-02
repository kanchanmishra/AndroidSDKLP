using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Uicomponents {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/interface[@name='ICloseMenuListener']"
	[Register ("com/liveperson/infra/ui/view/uicomponents/ICloseMenuListener", "", "Com.Liveperson.Infra.UI.View.Uicomponents.ICloseMenuListenerInvoker")]
	public partial interface ICloseMenuListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/interface[@name='ICloseMenuListener']/method[@name='onCloseMenu' and count(parameter)=0]"
		[Register ("onCloseMenu", "()V", "GetOnCloseMenuHandler:Com.Liveperson.Infra.UI.View.Uicomponents.ICloseMenuListenerInvoker, LP_UI_Binding")]
		void OnCloseMenu ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/uicomponents/ICloseMenuListener", DoNotGenerateAcw=true)]
	internal class ICloseMenuListenerInvoker : global::Java.Lang.Object, ICloseMenuListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/ui/view/uicomponents/ICloseMenuListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICloseMenuListenerInvoker); }
		}

		IntPtr class_ref;

		public static ICloseMenuListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICloseMenuListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.ui.view.uicomponents.ICloseMenuListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICloseMenuListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCloseMenu;
#pragma warning disable 0169
		static Delegate GetOnCloseMenuHandler ()
		{
			if (cb_onCloseMenu == null)
				cb_onCloseMenu = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCloseMenu);
			return cb_onCloseMenu;
		}

		static void n_OnCloseMenu (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.Uicomponents.ICloseMenuListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.ICloseMenuListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCloseMenu ();
		}
#pragma warning restore 0169

		IntPtr id_onCloseMenu;
		public unsafe void OnCloseMenu ()
		{
			if (id_onCloseMenu == IntPtr.Zero)
				id_onCloseMenu = JNIEnv.GetMethodID (class_ref, "onCloseMenu", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCloseMenu);
		}

	}

	[global::Android.Runtime.Register ("mono/com/liveperson/infra/ui/view/uicomponents/ICloseMenuListenerImplementor")]
	internal sealed partial class ICloseMenuListenerImplementor : global::Java.Lang.Object, ICloseMenuListener {

		object sender;

		public ICloseMenuListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/liveperson/infra/ui/view/uicomponents/ICloseMenuListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void OnCloseMenu ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (ICloseMenuListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
