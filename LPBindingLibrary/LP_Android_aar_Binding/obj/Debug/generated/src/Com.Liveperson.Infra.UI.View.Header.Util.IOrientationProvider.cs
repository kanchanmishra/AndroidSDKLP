using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Header.Util {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.ui.view.header.util']/interface[@name='OrientationProvider']"
	[Register ("com/liveperson/infra/ui/view/header/util/OrientationProvider", "", "Com.Liveperson.Infra.UI.View.Header.Util.IOrientationProviderInvoker")]
	public partial interface IOrientationProvider : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.header.util']/interface[@name='OrientationProvider']/method[@name='getOrientation' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView']]"
		[Register ("getOrientation", "(Landroid/support/v7/widget/RecyclerView;)I", "GetGetOrientation_Landroid_support_v7_widget_RecyclerView_Handler:Com.Liveperson.Infra.UI.View.Header.Util.IOrientationProviderInvoker, LP_Android_aar_Binding")]
		int GetOrientation (global::Android.Support.V7.Widget.RecyclerView p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.header.util']/interface[@name='OrientationProvider']/method[@name='isReverseLayout' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView']]"
		[Register ("isReverseLayout", "(Landroid/support/v7/widget/RecyclerView;)Z", "GetIsReverseLayout_Landroid_support_v7_widget_RecyclerView_Handler:Com.Liveperson.Infra.UI.View.Header.Util.IOrientationProviderInvoker, LP_Android_aar_Binding")]
		bool IsReverseLayout (global::Android.Support.V7.Widget.RecyclerView p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/header/util/OrientationProvider", DoNotGenerateAcw=true)]
	internal class IOrientationProviderInvoker : global::Java.Lang.Object, IOrientationProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/ui/view/header/util/OrientationProvider");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOrientationProviderInvoker); }
		}

		IntPtr class_ref;

		public static IOrientationProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOrientationProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.ui.view.header.util.OrientationProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOrientationProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getOrientation_Landroid_support_v7_widget_RecyclerView_;
#pragma warning disable 0169
		static Delegate GetGetOrientation_Landroid_support_v7_widget_RecyclerView_Handler ()
		{
			if (cb_getOrientation_Landroid_support_v7_widget_RecyclerView_ == null)
				cb_getOrientation_Landroid_support_v7_widget_RecyclerView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetOrientation_Landroid_support_v7_widget_RecyclerView_);
			return cb_getOrientation_Landroid_support_v7_widget_RecyclerView_;
		}

		static int n_GetOrientation_Landroid_support_v7_widget_RecyclerView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.Header.Util.IOrientationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Header.Util.IOrientationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.RecyclerView p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetOrientation (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getOrientation_Landroid_support_v7_widget_RecyclerView_;
		public unsafe int GetOrientation (global::Android.Support.V7.Widget.RecyclerView p0)
		{
			if (id_getOrientation_Landroid_support_v7_widget_RecyclerView_ == IntPtr.Zero)
				id_getOrientation_Landroid_support_v7_widget_RecyclerView_ = JNIEnv.GetMethodID (class_ref, "getOrientation", "(Landroid/support/v7/widget/RecyclerView;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getOrientation_Landroid_support_v7_widget_RecyclerView_, __args);
			return __ret;
		}

		static Delegate cb_isReverseLayout_Landroid_support_v7_widget_RecyclerView_;
#pragma warning disable 0169
		static Delegate GetIsReverseLayout_Landroid_support_v7_widget_RecyclerView_Handler ()
		{
			if (cb_isReverseLayout_Landroid_support_v7_widget_RecyclerView_ == null)
				cb_isReverseLayout_Landroid_support_v7_widget_RecyclerView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsReverseLayout_Landroid_support_v7_widget_RecyclerView_);
			return cb_isReverseLayout_Landroid_support_v7_widget_RecyclerView_;
		}

		static bool n_IsReverseLayout_Landroid_support_v7_widget_RecyclerView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.Header.Util.IOrientationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Header.Util.IOrientationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.RecyclerView p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsReverseLayout (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isReverseLayout_Landroid_support_v7_widget_RecyclerView_;
		public unsafe bool IsReverseLayout (global::Android.Support.V7.Widget.RecyclerView p0)
		{
			if (id_isReverseLayout_Landroid_support_v7_widget_RecyclerView_ == IntPtr.Zero)
				id_isReverseLayout_Landroid_support_v7_widget_RecyclerView_ = JNIEnv.GetMethodID (class_ref, "isReverseLayout", "(Landroid/support/v7/widget/RecyclerView;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isReverseLayout_Landroid_support_v7_widget_RecyclerView_, __args);
			return __ret;
		}

	}

}
