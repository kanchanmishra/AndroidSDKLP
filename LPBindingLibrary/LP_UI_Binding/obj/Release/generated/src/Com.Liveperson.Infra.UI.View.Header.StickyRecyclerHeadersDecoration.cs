using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Header {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.header']/class[@name='StickyRecyclerHeadersDecoration']"
	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/header/StickyRecyclerHeadersDecoration", DoNotGenerateAcw=true)]
	public partial class StickyRecyclerHeadersDecoration : global::Android.Support.V7.Widget.RecyclerView.ItemDecoration {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/ui/view/header/StickyRecyclerHeadersDecoration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StickyRecyclerHeadersDecoration); }
		}

		protected StickyRecyclerHeadersDecoration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_infra_ui_view_header_StickyRecyclerHeadersAdapter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.header']/class[@name='StickyRecyclerHeadersDecoration']/constructor[@name='StickyRecyclerHeadersDecoration' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.ui.view.header.StickyRecyclerHeadersAdapter']]"
		[Register (".ctor", "(Lcom/liveperson/infra/ui/view/header/StickyRecyclerHeadersAdapter;)V", "")]
		public unsafe StickyRecyclerHeadersDecoration (global::Com.Liveperson.Infra.UI.View.Header.IStickyRecyclerHeadersAdapter p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (StickyRecyclerHeadersDecoration)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/infra/ui/view/header/StickyRecyclerHeadersAdapter;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/infra/ui/view/header/StickyRecyclerHeadersAdapter;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_infra_ui_view_header_StickyRecyclerHeadersAdapter_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_infra_ui_view_header_StickyRecyclerHeadersAdapter_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/ui/view/header/StickyRecyclerHeadersAdapter;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_ui_view_header_StickyRecyclerHeadersAdapter_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_ui_view_header_StickyRecyclerHeadersAdapter_, __args);
			} finally {
			}
		}

		static Delegate cb_findHeaderPositionUnder_II;
#pragma warning disable 0169
		static Delegate GetFindHeaderPositionUnder_IIHandler ()
		{
			if (cb_findHeaderPositionUnder_II == null)
				cb_findHeaderPositionUnder_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_FindHeaderPositionUnder_II);
			return cb_findHeaderPositionUnder_II;
		}

		static int n_FindHeaderPositionUnder_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Liveperson.Infra.UI.View.Header.StickyRecyclerHeadersDecoration __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Header.StickyRecyclerHeadersDecoration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FindHeaderPositionUnder (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_findHeaderPositionUnder_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.header']/class[@name='StickyRecyclerHeadersDecoration']/method[@name='findHeaderPositionUnder' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("findHeaderPositionUnder", "(II)I", "GetFindHeaderPositionUnder_IIHandler")]
		public virtual unsafe int FindHeaderPositionUnder (int p0, int p1)
		{
			if (id_findHeaderPositionUnder_II == IntPtr.Zero)
				id_findHeaderPositionUnder_II = JNIEnv.GetMethodID (class_ref, "findHeaderPositionUnder", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_findHeaderPositionUnder_II, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findHeaderPositionUnder", "(II)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getHeaderView_Landroid_support_v7_widget_RecyclerView_I;
#pragma warning disable 0169
		static Delegate GetGetHeaderView_Landroid_support_v7_widget_RecyclerView_IHandler ()
		{
			if (cb_getHeaderView_Landroid_support_v7_widget_RecyclerView_I == null)
				cb_getHeaderView_Landroid_support_v7_widget_RecyclerView_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_GetHeaderView_Landroid_support_v7_widget_RecyclerView_I);
			return cb_getHeaderView_Landroid_support_v7_widget_RecyclerView_I;
		}

		static IntPtr n_GetHeaderView_Landroid_support_v7_widget_RecyclerView_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Liveperson.Infra.UI.View.Header.StickyRecyclerHeadersDecoration __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Header.StickyRecyclerHeadersDecoration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.RecyclerView p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetHeaderView (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getHeaderView_Landroid_support_v7_widget_RecyclerView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.header']/class[@name='StickyRecyclerHeadersDecoration']/method[@name='getHeaderView' and count(parameter)=2 and parameter[1][@type='android.support.v7.widget.RecyclerView'] and parameter[2][@type='int']]"
		[Register ("getHeaderView", "(Landroid/support/v7/widget/RecyclerView;I)Landroid/view/View;", "GetGetHeaderView_Landroid_support_v7_widget_RecyclerView_IHandler")]
		public virtual unsafe global::Android.Views.View GetHeaderView (global::Android.Support.V7.Widget.RecyclerView p0, int p1)
		{
			if (id_getHeaderView_Landroid_support_v7_widget_RecyclerView_I == IntPtr.Zero)
				id_getHeaderView_Landroid_support_v7_widget_RecyclerView_I = JNIEnv.GetMethodID (class_ref, "getHeaderView", "(Landroid/support/v7/widget/RecyclerView;I)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Android.Views.View __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeaderView_Landroid_support_v7_widget_RecyclerView_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaderView", "(Landroid/support/v7/widget/RecyclerView;I)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_invalidateHeaders;
#pragma warning disable 0169
		static Delegate GetInvalidateHeadersHandler ()
		{
			if (cb_invalidateHeaders == null)
				cb_invalidateHeaders = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InvalidateHeaders);
			return cb_invalidateHeaders;
		}

		static void n_InvalidateHeaders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.Header.StickyRecyclerHeadersDecoration __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Header.StickyRecyclerHeadersDecoration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InvalidateHeaders ();
		}
#pragma warning restore 0169

		static IntPtr id_invalidateHeaders;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.header']/class[@name='StickyRecyclerHeadersDecoration']/method[@name='invalidateHeaders' and count(parameter)=0]"
		[Register ("invalidateHeaders", "()V", "GetInvalidateHeadersHandler")]
		public virtual unsafe void InvalidateHeaders ()
		{
			if (id_invalidateHeaders == IntPtr.Zero)
				id_invalidateHeaders = JNIEnv.GetMethodID (class_ref, "invalidateHeaders", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_invalidateHeaders);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invalidateHeaders", "()V"));
			} finally {
			}
		}

	}
}
