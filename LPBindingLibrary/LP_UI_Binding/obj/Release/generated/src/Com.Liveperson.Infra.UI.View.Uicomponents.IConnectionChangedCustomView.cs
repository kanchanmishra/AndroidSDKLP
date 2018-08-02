using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Uicomponents {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/interface[@name='IConnectionChangedCustomView']"
	[Register ("com/liveperson/infra/ui/view/uicomponents/IConnectionChangedCustomView", "", "Com.Liveperson.Infra.UI.View.Uicomponents.IConnectionChangedCustomViewInvoker")]
	public partial interface IConnectionChangedCustomView : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/interface[@name='IConnectionChangedCustomView']/method[@name='onConnectionChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onConnectionChanged", "(Z)V", "GetOnConnectionChanged_ZHandler:Com.Liveperson.Infra.UI.View.Uicomponents.IConnectionChangedCustomViewInvoker, LP_UI_Binding")]
		void OnConnectionChanged (bool p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/uicomponents/IConnectionChangedCustomView", DoNotGenerateAcw=true)]
	internal class IConnectionChangedCustomViewInvoker : global::Java.Lang.Object, IConnectionChangedCustomView {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/ui/view/uicomponents/IConnectionChangedCustomView");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IConnectionChangedCustomViewInvoker); }
		}

		IntPtr class_ref;

		public static IConnectionChangedCustomView GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnectionChangedCustomView> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.ui.view.uicomponents.IConnectionChangedCustomView"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectionChangedCustomViewInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onConnectionChanged_Z;
#pragma warning disable 0169
		static Delegate GetOnConnectionChanged_ZHandler ()
		{
			if (cb_onConnectionChanged_Z == null)
				cb_onConnectionChanged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnConnectionChanged_Z);
			return cb_onConnectionChanged_Z;
		}

		static void n_OnConnectionChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Infra.UI.View.Uicomponents.IConnectionChangedCustomView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.IConnectionChangedCustomView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onConnectionChanged_Z;
		public unsafe void OnConnectionChanged (bool p0)
		{
			if (id_onConnectionChanged_Z == IntPtr.Zero)
				id_onConnectionChanged_Z = JNIEnv.GetMethodID (class_ref, "onConnectionChanged", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionChanged_Z, __args);
		}

	}

}
