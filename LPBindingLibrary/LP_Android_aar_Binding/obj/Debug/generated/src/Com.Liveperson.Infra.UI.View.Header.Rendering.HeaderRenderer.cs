using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Header.Rendering {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.header.rendering']/class[@name='HeaderRenderer']"
	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/header/rendering/HeaderRenderer", DoNotGenerateAcw=true)]
	public partial class HeaderRenderer : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/ui/view/header/rendering/HeaderRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HeaderRenderer); }
		}

		protected HeaderRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_infra_ui_view_header_util_OrientationProvider_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.header.rendering']/class[@name='HeaderRenderer']/constructor[@name='HeaderRenderer' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.ui.view.header.util.OrientationProvider']]"
		[Register (".ctor", "(Lcom/liveperson/infra/ui/view/header/util/OrientationProvider;)V", "")]
		public unsafe HeaderRenderer (global::Com.Liveperson.Infra.UI.View.Header.Util.IOrientationProvider p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (HeaderRenderer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/infra/ui/view/header/util/OrientationProvider;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/infra/ui/view/header/util/OrientationProvider;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_infra_ui_view_header_util_OrientationProvider_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_infra_ui_view_header_util_OrientationProvider_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/ui/view/header/util/OrientationProvider;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_ui_view_header_util_OrientationProvider_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_ui_view_header_util_OrientationProvider_, __args);
			} finally {
			}
		}

		static Delegate cb_drawHeader_Landroid_support_v7_widget_RecyclerView_Landroid_graphics_Canvas_Landroid_view_View_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetDrawHeader_Landroid_support_v7_widget_RecyclerView_Landroid_graphics_Canvas_Landroid_view_View_Landroid_graphics_Rect_Handler ()
		{
			if (cb_drawHeader_Landroid_support_v7_widget_RecyclerView_Landroid_graphics_Canvas_Landroid_view_View_Landroid_graphics_Rect_ == null)
				cb_drawHeader_Landroid_support_v7_widget_RecyclerView_Landroid_graphics_Canvas_Landroid_view_View_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DrawHeader_Landroid_support_v7_widget_RecyclerView_Landroid_graphics_Canvas_Landroid_view_View_Landroid_graphics_Rect_);
			return cb_drawHeader_Landroid_support_v7_widget_RecyclerView_Landroid_graphics_Canvas_Landroid_view_View_Landroid_graphics_Rect_;
		}

		static void n_DrawHeader_Landroid_support_v7_widget_RecyclerView_Landroid_graphics_Canvas_Landroid_view_View_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Liveperson.Infra.UI.View.Header.Rendering.HeaderRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Header.Rendering.HeaderRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.RecyclerView p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p2 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect p3 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.DrawHeader (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_drawHeader_Landroid_support_v7_widget_RecyclerView_Landroid_graphics_Canvas_Landroid_view_View_Landroid_graphics_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.header.rendering']/class[@name='HeaderRenderer']/method[@name='drawHeader' and count(parameter)=4 and parameter[1][@type='android.support.v7.widget.RecyclerView'] and parameter[2][@type='android.graphics.Canvas'] and parameter[3][@type='android.view.View'] and parameter[4][@type='android.graphics.Rect']]"
		[Register ("drawHeader", "(Landroid/support/v7/widget/RecyclerView;Landroid/graphics/Canvas;Landroid/view/View;Landroid/graphics/Rect;)V", "GetDrawHeader_Landroid_support_v7_widget_RecyclerView_Landroid_graphics_Canvas_Landroid_view_View_Landroid_graphics_Rect_Handler")]
		public virtual unsafe void DrawHeader (global::Android.Support.V7.Widget.RecyclerView p0, global::Android.Graphics.Canvas p1, global::Android.Views.View p2, global::Android.Graphics.Rect p3)
		{
			if (id_drawHeader_Landroid_support_v7_widget_RecyclerView_Landroid_graphics_Canvas_Landroid_view_View_Landroid_graphics_Rect_ == IntPtr.Zero)
				id_drawHeader_Landroid_support_v7_widget_RecyclerView_Landroid_graphics_Canvas_Landroid_view_View_Landroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "drawHeader", "(Landroid/support/v7/widget/RecyclerView;Landroid/graphics/Canvas;Landroid/view/View;Landroid/graphics/Rect;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_drawHeader_Landroid_support_v7_widget_RecyclerView_Landroid_graphics_Canvas_Landroid_view_View_Landroid_graphics_Rect_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawHeader", "(Landroid/support/v7/widget/RecyclerView;Landroid/graphics/Canvas;Landroid/view/View;Landroid/graphics/Rect;)V"), __args);
			} finally {
			}
		}

	}
}
