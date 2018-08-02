using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Header.Calculation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.header.calculation']/class[@name='DimensionCalculator']"
	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/header/calculation/DimensionCalculator", DoNotGenerateAcw=true)]
	public partial class DimensionCalculator : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/ui/view/header/calculation/DimensionCalculator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DimensionCalculator); }
		}

		protected DimensionCalculator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.header.calculation']/class[@name='DimensionCalculator']/constructor[@name='DimensionCalculator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DimensionCalculator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DimensionCalculator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_initMargins_Landroid_graphics_Rect_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetInitMargins_Landroid_graphics_Rect_Landroid_view_View_Handler ()
		{
			if (cb_initMargins_Landroid_graphics_Rect_Landroid_view_View_ == null)
				cb_initMargins_Landroid_graphics_Rect_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_InitMargins_Landroid_graphics_Rect_Landroid_view_View_);
			return cb_initMargins_Landroid_graphics_Rect_Landroid_view_View_;
		}

		static void n_InitMargins_Landroid_graphics_Rect_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.UI.View.Header.Calculation.DimensionCalculator __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Header.Calculation.DimensionCalculator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.InitMargins (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_initMargins_Landroid_graphics_Rect_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.header.calculation']/class[@name='DimensionCalculator']/method[@name='initMargins' and count(parameter)=2 and parameter[1][@type='android.graphics.Rect'] and parameter[2][@type='android.view.View']]"
		[Register ("initMargins", "(Landroid/graphics/Rect;Landroid/view/View;)V", "GetInitMargins_Landroid_graphics_Rect_Landroid_view_View_Handler")]
		public virtual unsafe void InitMargins (global::Android.Graphics.Rect p0, global::Android.Views.View p1)
		{
			if (id_initMargins_Landroid_graphics_Rect_Landroid_view_View_ == IntPtr.Zero)
				id_initMargins_Landroid_graphics_Rect_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "initMargins", "(Landroid/graphics/Rect;Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initMargins_Landroid_graphics_Rect_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initMargins", "(Landroid/graphics/Rect;Landroid/view/View;)V"), __args);
			} finally {
			}
		}

	}
}
