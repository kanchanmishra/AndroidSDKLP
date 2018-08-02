using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Header.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.header.util']/class[@name='LinearLayoutOrientationProvider']"
	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/header/util/LinearLayoutOrientationProvider", DoNotGenerateAcw=true)]
	public partial class LinearLayoutOrientationProvider : global::Java.Lang.Object, global::Com.Liveperson.Infra.UI.View.Header.Util.IOrientationProvider {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/ui/view/header/util/LinearLayoutOrientationProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LinearLayoutOrientationProvider); }
		}

		protected LinearLayoutOrientationProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.header.util']/class[@name='LinearLayoutOrientationProvider']/constructor[@name='LinearLayoutOrientationProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LinearLayoutOrientationProvider ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LinearLayoutOrientationProvider)) {
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
			global::Com.Liveperson.Infra.UI.View.Header.Util.LinearLayoutOrientationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Header.Util.LinearLayoutOrientationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.RecyclerView p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetOrientation (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getOrientation_Landroid_support_v7_widget_RecyclerView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.header.util']/class[@name='LinearLayoutOrientationProvider']/method[@name='getOrientation' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView']]"
		[Register ("getOrientation", "(Landroid/support/v7/widget/RecyclerView;)I", "GetGetOrientation_Landroid_support_v7_widget_RecyclerView_Handler")]
		public virtual unsafe int GetOrientation (global::Android.Support.V7.Widget.RecyclerView p0)
		{
			if (id_getOrientation_Landroid_support_v7_widget_RecyclerView_ == IntPtr.Zero)
				id_getOrientation_Landroid_support_v7_widget_RecyclerView_ = JNIEnv.GetMethodID (class_ref, "getOrientation", "(Landroid/support/v7/widget/RecyclerView;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getOrientation_Landroid_support_v7_widget_RecyclerView_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrientation", "(Landroid/support/v7/widget/RecyclerView;)I"), __args);
				return __ret;
			} finally {
			}
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
			global::Com.Liveperson.Infra.UI.View.Header.Util.LinearLayoutOrientationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Header.Util.LinearLayoutOrientationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.RecyclerView p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsReverseLayout (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isReverseLayout_Landroid_support_v7_widget_RecyclerView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.header.util']/class[@name='LinearLayoutOrientationProvider']/method[@name='isReverseLayout' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView']]"
		[Register ("isReverseLayout", "(Landroid/support/v7/widget/RecyclerView;)Z", "GetIsReverseLayout_Landroid_support_v7_widget_RecyclerView_Handler")]
		public virtual unsafe bool IsReverseLayout (global::Android.Support.V7.Widget.RecyclerView p0)
		{
			if (id_isReverseLayout_Landroid_support_v7_widget_RecyclerView_ == IntPtr.Zero)
				id_isReverseLayout_Landroid_support_v7_widget_RecyclerView_ = JNIEnv.GetMethodID (class_ref, "isReverseLayout", "(Landroid/support/v7/widget/RecyclerView;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isReverseLayout_Landroid_support_v7_widget_RecyclerView_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isReverseLayout", "(Landroid/support/v7/widget/RecyclerView;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
