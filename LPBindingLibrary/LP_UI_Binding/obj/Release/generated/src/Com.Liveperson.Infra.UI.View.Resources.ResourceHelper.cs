using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Resources {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.resources']/class[@name='ResourceHelper']"
	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/resources/ResourceHelper", DoNotGenerateAcw=true)]
	public partial class ResourceHelper : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/ui/view/resources/ResourceHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResourceHelper); }
		}

		protected ResourceHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.resources']/class[@name='ResourceHelper']/constructor[@name='ResourceHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResourceHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ResourceHelper)) {
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

		static IntPtr id_updateBackgroundColor_Landroid_view_View_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.resources']/class[@name='ResourceHelper']/method[@name='updateBackgroundColor' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("updateBackgroundColor", "(Landroid/view/View;I)V", "")]
		public static unsafe void UpdateBackgroundColor (global::Android.Views.View p0, int p1)
		{
			if (id_updateBackgroundColor_Landroid_view_View_I == IntPtr.Zero)
				id_updateBackgroundColor_Landroid_view_View_I = JNIEnv.GetStaticMethodID (class_ref, "updateBackgroundColor", "(Landroid/view/View;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_updateBackgroundColor_Landroid_view_View_I, __args);
			} finally {
			}
		}

		static IntPtr id_updateBackgroundDrawable_Landroid_view_View_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.resources']/class[@name='ResourceHelper']/method[@name='updateBackgroundDrawable' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("updateBackgroundDrawable", "(Landroid/view/View;I)V", "")]
		public static unsafe void UpdateBackgroundDrawable (global::Android.Views.View p0, int p1)
		{
			if (id_updateBackgroundDrawable_Landroid_view_View_I == IntPtr.Zero)
				id_updateBackgroundDrawable_Landroid_view_View_I = JNIEnv.GetStaticMethodID (class_ref, "updateBackgroundDrawable", "(Landroid/view/View;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_updateBackgroundDrawable_Landroid_view_View_I, __args);
			} finally {
			}
		}

		static IntPtr id_updateBackgroundSolidColor_Landroid_view_View_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.resources']/class[@name='ResourceHelper']/method[@name='updateBackgroundSolidColor' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("updateBackgroundSolidColor", "(Landroid/view/View;I)V", "")]
		public static unsafe void UpdateBackgroundSolidColor (global::Android.Views.View p0, int p1)
		{
			if (id_updateBackgroundSolidColor_Landroid_view_View_I == IntPtr.Zero)
				id_updateBackgroundSolidColor_Landroid_view_View_I = JNIEnv.GetStaticMethodID (class_ref, "updateBackgroundSolidColor", "(Landroid/view/View;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_updateBackgroundSolidColor_Landroid_view_View_I, __args);
			} finally {
			}
		}

		static IntPtr id_updateBackgroundStrokeColor_Landroid_view_View_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.resources']/class[@name='ResourceHelper']/method[@name='updateBackgroundStrokeColor' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("updateBackgroundStrokeColor", "(Landroid/view/View;II)V", "")]
		public static unsafe void UpdateBackgroundStrokeColor (global::Android.Views.View p0, int p1, int p2)
		{
			if (id_updateBackgroundStrokeColor_Landroid_view_View_II == IntPtr.Zero)
				id_updateBackgroundStrokeColor_Landroid_view_View_II = JNIEnv.GetStaticMethodID (class_ref, "updateBackgroundStrokeColor", "(Landroid/view/View;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_updateBackgroundStrokeColor_Landroid_view_View_II, __args);
			} finally {
			}
		}

		static IntPtr id_updateTextColor_Landroid_widget_TextView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.resources']/class[@name='ResourceHelper']/method[@name='updateTextColor' and count(parameter)=2 and parameter[1][@type='android.widget.TextView'] and parameter[2][@type='int']]"
		[Register ("updateTextColor", "(Landroid/widget/TextView;I)V", "")]
		public static unsafe void UpdateTextColor (global::Android.Widget.TextView p0, int p1)
		{
			if (id_updateTextColor_Landroid_widget_TextView_I == IntPtr.Zero)
				id_updateTextColor_Landroid_widget_TextView_I = JNIEnv.GetStaticMethodID (class_ref, "updateTextColor", "(Landroid/widget/TextView;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_updateTextColor_Landroid_widget_TextView_I, __args);
			} finally {
			}
		}

		static IntPtr id_updateTextColorLink_Landroid_widget_TextView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.resources']/class[@name='ResourceHelper']/method[@name='updateTextColorLink' and count(parameter)=2 and parameter[1][@type='android.widget.TextView'] and parameter[2][@type='int']]"
		[Register ("updateTextColorLink", "(Landroid/widget/TextView;I)V", "")]
		public static unsafe void UpdateTextColorLink (global::Android.Widget.TextView p0, int p1)
		{
			if (id_updateTextColorLink_Landroid_widget_TextView_I == IntPtr.Zero)
				id_updateTextColorLink_Landroid_widget_TextView_I = JNIEnv.GetStaticMethodID (class_ref, "updateTextColorLink", "(Landroid/widget/TextView;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_updateTextColorLink_Landroid_widget_TextView_I, __args);
			} finally {
			}
		}

	}
}
