using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Uicomponents {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/interface[@name='IOverflowMenu']"
	[Register ("com/liveperson/infra/ui/view/uicomponents/IOverflowMenu", "", "Com.Liveperson.Infra.UI.View.Uicomponents.IOverflowMenuInvoker")]
	public partial interface IOverflowMenu : IJavaObject {

		bool IsMenuOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/interface[@name='IOverflowMenu']/method[@name='isMenuOpen' and count(parameter)=0]"
			[Register ("isMenuOpen", "()Z", "GetIsMenuOpenHandler:Com.Liveperson.Infra.UI.View.Uicomponents.IOverflowMenuInvoker, LP_UI_Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/interface[@name='IOverflowMenu']/method[@name='hide' and count(parameter)=0]"
		[Register ("hide", "()V", "GetHideHandler:Com.Liveperson.Infra.UI.View.Uicomponents.IOverflowMenuInvoker, LP_UI_Binding")]
		void Hide ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/interface[@name='IOverflowMenu']/method[@name='setOnCloseListener' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.ui.view.uicomponents.ICloseMenuListener']]"
		[Register ("setOnCloseListener", "(Lcom/liveperson/infra/ui/view/uicomponents/ICloseMenuListener;)V", "GetSetOnCloseListener_Lcom_liveperson_infra_ui_view_uicomponents_ICloseMenuListener_Handler:Com.Liveperson.Infra.UI.View.Uicomponents.IOverflowMenuInvoker, LP_UI_Binding")]
		void SetOnCloseListener (global::Com.Liveperson.Infra.UI.View.Uicomponents.ICloseMenuListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/interface[@name='IOverflowMenu']/method[@name='show' and count(parameter)=0]"
		[Register ("show", "()V", "GetShowHandler:Com.Liveperson.Infra.UI.View.Uicomponents.IOverflowMenuInvoker, LP_UI_Binding")]
		void Show ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/uicomponents/IOverflowMenu", DoNotGenerateAcw=true)]
	internal class IOverflowMenuInvoker : global::Java.Lang.Object, IOverflowMenu {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/ui/view/uicomponents/IOverflowMenu");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOverflowMenuInvoker); }
		}

		IntPtr class_ref;

		public static IOverflowMenu GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOverflowMenu> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.ui.view.uicomponents.IOverflowMenu"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOverflowMenuInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isMenuOpen;
#pragma warning disable 0169
		static Delegate GetIsMenuOpenHandler ()
		{
			if (cb_isMenuOpen == null)
				cb_isMenuOpen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMenuOpen);
			return cb_isMenuOpen;
		}

		static bool n_IsMenuOpen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.Uicomponents.IOverflowMenu __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.IOverflowMenu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMenuOpen;
		}
#pragma warning restore 0169

		IntPtr id_isMenuOpen;
		public unsafe bool IsMenuOpen {
			get {
				if (id_isMenuOpen == IntPtr.Zero)
					id_isMenuOpen = JNIEnv.GetMethodID (class_ref, "isMenuOpen", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMenuOpen);
			}
		}

		static Delegate cb_hide;
#pragma warning disable 0169
		static Delegate GetHideHandler ()
		{
			if (cb_hide == null)
				cb_hide = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Hide);
			return cb_hide;
		}

		static void n_Hide (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.Uicomponents.IOverflowMenu __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.IOverflowMenu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Hide ();
		}
#pragma warning restore 0169

		IntPtr id_hide;
		public unsafe void Hide ()
		{
			if (id_hide == IntPtr.Zero)
				id_hide = JNIEnv.GetMethodID (class_ref, "hide", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hide);
		}

		static Delegate cb_setOnCloseListener_Lcom_liveperson_infra_ui_view_uicomponents_ICloseMenuListener_;
#pragma warning disable 0169
		static Delegate GetSetOnCloseListener_Lcom_liveperson_infra_ui_view_uicomponents_ICloseMenuListener_Handler ()
		{
			if (cb_setOnCloseListener_Lcom_liveperson_infra_ui_view_uicomponents_ICloseMenuListener_ == null)
				cb_setOnCloseListener_Lcom_liveperson_infra_ui_view_uicomponents_ICloseMenuListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnCloseListener_Lcom_liveperson_infra_ui_view_uicomponents_ICloseMenuListener_);
			return cb_setOnCloseListener_Lcom_liveperson_infra_ui_view_uicomponents_ICloseMenuListener_;
		}

		static void n_SetOnCloseListener_Lcom_liveperson_infra_ui_view_uicomponents_ICloseMenuListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.Uicomponents.IOverflowMenu __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.IOverflowMenu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.UI.View.Uicomponents.ICloseMenuListener p0 = (global::Com.Liveperson.Infra.UI.View.Uicomponents.ICloseMenuListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.ICloseMenuListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnCloseListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnCloseListener_Lcom_liveperson_infra_ui_view_uicomponents_ICloseMenuListener_;
		public unsafe void SetOnCloseListener (global::Com.Liveperson.Infra.UI.View.Uicomponents.ICloseMenuListener p0)
		{
			if (id_setOnCloseListener_Lcom_liveperson_infra_ui_view_uicomponents_ICloseMenuListener_ == IntPtr.Zero)
				id_setOnCloseListener_Lcom_liveperson_infra_ui_view_uicomponents_ICloseMenuListener_ = JNIEnv.GetMethodID (class_ref, "setOnCloseListener", "(Lcom/liveperson/infra/ui/view/uicomponents/ICloseMenuListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnCloseListener_Lcom_liveperson_infra_ui_view_uicomponents_ICloseMenuListener_, __args);
		}

		static Delegate cb_show;
#pragma warning disable 0169
		static Delegate GetShowHandler ()
		{
			if (cb_show == null)
				cb_show = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Show);
			return cb_show;
		}

		static void n_Show (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.Uicomponents.IOverflowMenu __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.IOverflowMenu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Show ();
		}
#pragma warning restore 0169

		IntPtr id_show;
		public unsafe void Show ()
		{
			if (id_show == IntPtr.Zero)
				id_show = JNIEnv.GetMethodID (class_ref, "show", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_show);
		}

	}

}
