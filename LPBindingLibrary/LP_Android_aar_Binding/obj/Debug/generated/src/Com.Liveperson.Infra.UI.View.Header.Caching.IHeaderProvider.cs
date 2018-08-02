using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Header.Caching {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.ui.view.header.caching']/interface[@name='HeaderProvider']"
	[Register ("com/liveperson/infra/ui/view/header/caching/HeaderProvider", "", "Com.Liveperson.Infra.UI.View.Header.Caching.IHeaderProviderInvoker")]
	public partial interface IHeaderProvider : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.header.caching']/interface[@name='HeaderProvider']/method[@name='getHeader' and count(parameter)=2 and parameter[1][@type='android.support.v7.widget.RecyclerView'] and parameter[2][@type='int']]"
		[Register ("getHeader", "(Landroid/support/v7/widget/RecyclerView;I)Landroid/view/View;", "GetGetHeader_Landroid_support_v7_widget_RecyclerView_IHandler:Com.Liveperson.Infra.UI.View.Header.Caching.IHeaderProviderInvoker, LP_Android_aar_Binding")]
		global::Android.Views.View GetHeader (global::Android.Support.V7.Widget.RecyclerView p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.header.caching']/interface[@name='HeaderProvider']/method[@name='invalidate' and count(parameter)=0]"
		[Register ("invalidate", "()V", "GetInvalidateHandler:Com.Liveperson.Infra.UI.View.Header.Caching.IHeaderProviderInvoker, LP_Android_aar_Binding")]
		void Invalidate ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/header/caching/HeaderProvider", DoNotGenerateAcw=true)]
	internal class IHeaderProviderInvoker : global::Java.Lang.Object, IHeaderProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/ui/view/header/caching/HeaderProvider");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IHeaderProviderInvoker); }
		}

		IntPtr class_ref;

		public static IHeaderProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHeaderProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.ui.view.header.caching.HeaderProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHeaderProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getHeader_Landroid_support_v7_widget_RecyclerView_I;
#pragma warning disable 0169
		static Delegate GetGetHeader_Landroid_support_v7_widget_RecyclerView_IHandler ()
		{
			if (cb_getHeader_Landroid_support_v7_widget_RecyclerView_I == null)
				cb_getHeader_Landroid_support_v7_widget_RecyclerView_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_GetHeader_Landroid_support_v7_widget_RecyclerView_I);
			return cb_getHeader_Landroid_support_v7_widget_RecyclerView_I;
		}

		static IntPtr n_GetHeader_Landroid_support_v7_widget_RecyclerView_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Liveperson.Infra.UI.View.Header.Caching.IHeaderProvider __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Header.Caching.IHeaderProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.RecyclerView p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetHeader (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getHeader_Landroid_support_v7_widget_RecyclerView_I;
		public unsafe global::Android.Views.View GetHeader (global::Android.Support.V7.Widget.RecyclerView p0, int p1)
		{
			if (id_getHeader_Landroid_support_v7_widget_RecyclerView_I == IntPtr.Zero)
				id_getHeader_Landroid_support_v7_widget_RecyclerView_I = JNIEnv.GetMethodID (class_ref, "getHeader", "(Landroid/support/v7/widget/RecyclerView;I)Landroid/view/View;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeader_Landroid_support_v7_widget_RecyclerView_I, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_invalidate;
#pragma warning disable 0169
		static Delegate GetInvalidateHandler ()
		{
			if (cb_invalidate == null)
				cb_invalidate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Invalidate);
			return cb_invalidate;
		}

		static void n_Invalidate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.Header.Caching.IHeaderProvider __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Header.Caching.IHeaderProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Invalidate ();
		}
#pragma warning restore 0169

		IntPtr id_invalidate;
		public unsafe void Invalidate ()
		{
			if (id_invalidate == IntPtr.Zero)
				id_invalidate = JNIEnv.GetMethodID (class_ref, "invalidate", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_invalidate);
		}

	}

}
