using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Header {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.header']/class[@name='HeaderPositionCalculator']"
	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/header/HeaderPositionCalculator", DoNotGenerateAcw=true)]
	public partial class HeaderPositionCalculator : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/ui/view/header/HeaderPositionCalculator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HeaderPositionCalculator); }
		}

		protected HeaderPositionCalculator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_infra_ui_view_header_StickyRecyclerHeadersAdapter_Lcom_liveperson_infra_ui_view_header_caching_HeaderProvider_Lcom_liveperson_infra_ui_view_header_util_OrientationProvider_Lcom_liveperson_infra_ui_view_header_calculation_DimensionCalculator_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.header']/class[@name='HeaderPositionCalculator']/constructor[@name='HeaderPositionCalculator' and count(parameter)=4 and parameter[1][@type='com.liveperson.infra.ui.view.header.StickyRecyclerHeadersAdapter'] and parameter[2][@type='com.liveperson.infra.ui.view.header.caching.HeaderProvider'] and parameter[3][@type='com.liveperson.infra.ui.view.header.util.OrientationProvider'] and parameter[4][@type='com.liveperson.infra.ui.view.header.calculation.DimensionCalculator']]"
		[Register (".ctor", "(Lcom/liveperson/infra/ui/view/header/StickyRecyclerHeadersAdapter;Lcom/liveperson/infra/ui/view/header/caching/HeaderProvider;Lcom/liveperson/infra/ui/view/header/util/OrientationProvider;Lcom/liveperson/infra/ui/view/header/calculation/DimensionCalculator;)V", "")]
		public unsafe HeaderPositionCalculator (global::Com.Liveperson.Infra.UI.View.Header.IStickyRecyclerHeadersAdapter p0, global::Com.Liveperson.Infra.UI.View.Header.Caching.IHeaderProvider p1, global::Com.Liveperson.Infra.UI.View.Header.Util.IOrientationProvider p2, global::Com.Liveperson.Infra.UI.View.Header.Calculation.DimensionCalculator p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (HeaderPositionCalculator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/infra/ui/view/header/StickyRecyclerHeadersAdapter;Lcom/liveperson/infra/ui/view/header/caching/HeaderProvider;Lcom/liveperson/infra/ui/view/header/util/OrientationProvider;Lcom/liveperson/infra/ui/view/header/calculation/DimensionCalculator;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/infra/ui/view/header/StickyRecyclerHeadersAdapter;Lcom/liveperson/infra/ui/view/header/caching/HeaderProvider;Lcom/liveperson/infra/ui/view/header/util/OrientationProvider;Lcom/liveperson/infra/ui/view/header/calculation/DimensionCalculator;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_infra_ui_view_header_StickyRecyclerHeadersAdapter_Lcom_liveperson_infra_ui_view_header_caching_HeaderProvider_Lcom_liveperson_infra_ui_view_header_util_OrientationProvider_Lcom_liveperson_infra_ui_view_header_calculation_DimensionCalculator_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_infra_ui_view_header_StickyRecyclerHeadersAdapter_Lcom_liveperson_infra_ui_view_header_caching_HeaderProvider_Lcom_liveperson_infra_ui_view_header_util_OrientationProvider_Lcom_liveperson_infra_ui_view_header_calculation_DimensionCalculator_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/ui/view/header/StickyRecyclerHeadersAdapter;Lcom/liveperson/infra/ui/view/header/caching/HeaderProvider;Lcom/liveperson/infra/ui/view/header/util/OrientationProvider;Lcom/liveperson/infra/ui/view/header/calculation/DimensionCalculator;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_ui_view_header_StickyRecyclerHeadersAdapter_Lcom_liveperson_infra_ui_view_header_caching_HeaderProvider_Lcom_liveperson_infra_ui_view_header_util_OrientationProvider_Lcom_liveperson_infra_ui_view_header_calculation_DimensionCalculator_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_ui_view_header_StickyRecyclerHeadersAdapter_Lcom_liveperson_infra_ui_view_header_caching_HeaderProvider_Lcom_liveperson_infra_ui_view_header_util_OrientationProvider_Lcom_liveperson_infra_ui_view_header_calculation_DimensionCalculator_, __args);
			} finally {
			}
		}

		static Delegate cb_hasNewHeader_IZ;
#pragma warning disable 0169
		static Delegate GetHasNewHeader_IZHandler ()
		{
			if (cb_hasNewHeader_IZ == null)
				cb_hasNewHeader_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, bool>) n_HasNewHeader_IZ);
			return cb_hasNewHeader_IZ;
		}

		static bool n_HasNewHeader_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Liveperson.Infra.UI.View.Header.HeaderPositionCalculator __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Header.HeaderPositionCalculator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNewHeader (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_hasNewHeader_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.header']/class[@name='HeaderPositionCalculator']/method[@name='hasNewHeader' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("hasNewHeader", "(IZ)Z", "GetHasNewHeader_IZHandler")]
		public virtual unsafe bool HasNewHeader (int p0, bool p1)
		{
			if (id_hasNewHeader_IZ == IntPtr.Zero)
				id_hasNewHeader_IZ = JNIEnv.GetMethodID (class_ref, "hasNewHeader", "(IZ)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasNewHeader_IZ, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasNewHeader", "(IZ)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_hasStickyHeader_Landroid_view_View_II;
#pragma warning disable 0169
		static Delegate GetHasStickyHeader_Landroid_view_View_IIHandler ()
		{
			if (cb_hasStickyHeader_Landroid_view_View_II == null)
				cb_hasStickyHeader_Landroid_view_View_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool>) n_HasStickyHeader_Landroid_view_View_II);
			return cb_hasStickyHeader_Landroid_view_View_II;
		}

		static bool n_HasStickyHeader_Landroid_view_View_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Liveperson.Infra.UI.View.Header.HeaderPositionCalculator __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Header.HeaderPositionCalculator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasStickyHeader (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_hasStickyHeader_Landroid_view_View_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.header']/class[@name='HeaderPositionCalculator']/method[@name='hasStickyHeader' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("hasStickyHeader", "(Landroid/view/View;II)Z", "GetHasStickyHeader_Landroid_view_View_IIHandler")]
		public virtual unsafe bool HasStickyHeader (global::Android.Views.View p0, int p1, int p2)
		{
			if (id_hasStickyHeader_Landroid_view_View_II == IntPtr.Zero)
				id_hasStickyHeader_Landroid_view_View_II = JNIEnv.GetMethodID (class_ref, "hasStickyHeader", "(Landroid/view/View;II)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasStickyHeader_Landroid_view_View_II, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasStickyHeader", "(Landroid/view/View;II)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_initHeaderBounds_Landroid_graphics_Rect_Landroid_support_v7_widget_RecyclerView_Landroid_view_View_Landroid_view_View_Z;
#pragma warning disable 0169
		static Delegate GetInitHeaderBounds_Landroid_graphics_Rect_Landroid_support_v7_widget_RecyclerView_Landroid_view_View_Landroid_view_View_ZHandler ()
		{
			if (cb_initHeaderBounds_Landroid_graphics_Rect_Landroid_support_v7_widget_RecyclerView_Landroid_view_View_Landroid_view_View_Z == null)
				cb_initHeaderBounds_Landroid_graphics_Rect_Landroid_support_v7_widget_RecyclerView_Landroid_view_View_Landroid_view_View_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_InitHeaderBounds_Landroid_graphics_Rect_Landroid_support_v7_widget_RecyclerView_Landroid_view_View_Landroid_view_View_Z);
			return cb_initHeaderBounds_Landroid_graphics_Rect_Landroid_support_v7_widget_RecyclerView_Landroid_view_View_Landroid_view_View_Z;
		}

		static void n_InitHeaderBounds_Landroid_graphics_Rect_Landroid_support_v7_widget_RecyclerView_Landroid_view_View_Landroid_view_View_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, bool p4)
		{
			global::Com.Liveperson.Infra.UI.View.Header.HeaderPositionCalculator __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Header.HeaderPositionCalculator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.RecyclerView p1 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p2 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p3 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.InitHeaderBounds (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_initHeaderBounds_Landroid_graphics_Rect_Landroid_support_v7_widget_RecyclerView_Landroid_view_View_Landroid_view_View_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.header']/class[@name='HeaderPositionCalculator']/method[@name='initHeaderBounds' and count(parameter)=5 and parameter[1][@type='android.graphics.Rect'] and parameter[2][@type='android.support.v7.widget.RecyclerView'] and parameter[3][@type='android.view.View'] and parameter[4][@type='android.view.View'] and parameter[5][@type='boolean']]"
		[Register ("initHeaderBounds", "(Landroid/graphics/Rect;Landroid/support/v7/widget/RecyclerView;Landroid/view/View;Landroid/view/View;Z)V", "GetInitHeaderBounds_Landroid_graphics_Rect_Landroid_support_v7_widget_RecyclerView_Landroid_view_View_Landroid_view_View_ZHandler")]
		public virtual unsafe void InitHeaderBounds (global::Android.Graphics.Rect p0, global::Android.Support.V7.Widget.RecyclerView p1, global::Android.Views.View p2, global::Android.Views.View p3, bool p4)
		{
			if (id_initHeaderBounds_Landroid_graphics_Rect_Landroid_support_v7_widget_RecyclerView_Landroid_view_View_Landroid_view_View_Z == IntPtr.Zero)
				id_initHeaderBounds_Landroid_graphics_Rect_Landroid_support_v7_widget_RecyclerView_Landroid_view_View_Landroid_view_View_Z = JNIEnv.GetMethodID (class_ref, "initHeaderBounds", "(Landroid/graphics/Rect;Landroid/support/v7/widget/RecyclerView;Landroid/view/View;Landroid/view/View;Z)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initHeaderBounds_Landroid_graphics_Rect_Landroid_support_v7_widget_RecyclerView_Landroid_view_View_Landroid_view_View_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initHeaderBounds", "(Landroid/graphics/Rect;Landroid/support/v7/widget/RecyclerView;Landroid/view/View;Landroid/view/View;Z)V"), __args);
			} finally {
			}
		}

	}
}
