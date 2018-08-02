using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Header.Caching {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.header.caching']/class[@name='HeaderViewCache']"
	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/header/caching/HeaderViewCache", DoNotGenerateAcw=true)]
	public partial class HeaderViewCache : global::Java.Lang.Object, global::Com.Liveperson.Infra.UI.View.Header.Caching.IHeaderProvider {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/ui/view/header/caching/HeaderViewCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HeaderViewCache); }
		}

		protected HeaderViewCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_infra_ui_view_header_StickyRecyclerHeadersAdapter_Lcom_liveperson_infra_ui_view_header_util_OrientationProvider_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.header.caching']/class[@name='HeaderViewCache']/constructor[@name='HeaderViewCache' and count(parameter)=2 and parameter[1][@type='com.liveperson.infra.ui.view.header.StickyRecyclerHeadersAdapter'] and parameter[2][@type='com.liveperson.infra.ui.view.header.util.OrientationProvider']]"
		[Register (".ctor", "(Lcom/liveperson/infra/ui/view/header/StickyRecyclerHeadersAdapter;Lcom/liveperson/infra/ui/view/header/util/OrientationProvider;)V", "")]
		public unsafe HeaderViewCache (global::Com.Liveperson.Infra.UI.View.Header.IStickyRecyclerHeadersAdapter p0, global::Com.Liveperson.Infra.UI.View.Header.Util.IOrientationProvider p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (HeaderViewCache)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/infra/ui/view/header/StickyRecyclerHeadersAdapter;Lcom/liveperson/infra/ui/view/header/util/OrientationProvider;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/infra/ui/view/header/StickyRecyclerHeadersAdapter;Lcom/liveperson/infra/ui/view/header/util/OrientationProvider;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_infra_ui_view_header_StickyRecyclerHeadersAdapter_Lcom_liveperson_infra_ui_view_header_util_OrientationProvider_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_infra_ui_view_header_StickyRecyclerHeadersAdapter_Lcom_liveperson_infra_ui_view_header_util_OrientationProvider_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/ui/view/header/StickyRecyclerHeadersAdapter;Lcom/liveperson/infra/ui/view/header/util/OrientationProvider;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_ui_view_header_StickyRecyclerHeadersAdapter_Lcom_liveperson_infra_ui_view_header_util_OrientationProvider_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_ui_view_header_StickyRecyclerHeadersAdapter_Lcom_liveperson_infra_ui_view_header_util_OrientationProvider_, __args);
			} finally {
			}
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
			global::Com.Liveperson.Infra.UI.View.Header.Caching.HeaderViewCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Header.Caching.HeaderViewCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.RecyclerView p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetHeader (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getHeader_Landroid_support_v7_widget_RecyclerView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.header.caching']/class[@name='HeaderViewCache']/method[@name='getHeader' and count(parameter)=2 and parameter[1][@type='android.support.v7.widget.RecyclerView'] and parameter[2][@type='int']]"
		[Register ("getHeader", "(Landroid/support/v7/widget/RecyclerView;I)Landroid/view/View;", "GetGetHeader_Landroid_support_v7_widget_RecyclerView_IHandler")]
		public virtual unsafe global::Android.Views.View GetHeader (global::Android.Support.V7.Widget.RecyclerView p0, int p1)
		{
			if (id_getHeader_Landroid_support_v7_widget_RecyclerView_I == IntPtr.Zero)
				id_getHeader_Landroid_support_v7_widget_RecyclerView_I = JNIEnv.GetMethodID (class_ref, "getHeader", "(Landroid/support/v7/widget/RecyclerView;I)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Android.Views.View __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeader_Landroid_support_v7_widget_RecyclerView_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeader", "(Landroid/support/v7/widget/RecyclerView;I)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
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
			global::Com.Liveperson.Infra.UI.View.Header.Caching.HeaderViewCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Header.Caching.HeaderViewCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Invalidate ();
		}
#pragma warning restore 0169

		static IntPtr id_invalidate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.header.caching']/class[@name='HeaderViewCache']/method[@name='invalidate' and count(parameter)=0]"
		[Register ("invalidate", "()V", "GetInvalidateHandler")]
		public virtual unsafe void Invalidate ()
		{
			if (id_invalidate == IntPtr.Zero)
				id_invalidate = JNIEnv.GetMethodID (class_ref, "invalidate", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_invalidate);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invalidate", "()V"));
			} finally {
			}
		}

	}
}
