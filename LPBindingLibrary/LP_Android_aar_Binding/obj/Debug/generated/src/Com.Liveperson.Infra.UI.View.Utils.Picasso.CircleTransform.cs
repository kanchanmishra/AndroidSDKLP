using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Utils.Picasso {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils.picasso']/class[@name='CircleTransform']"
	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/utils/picasso/CircleTransform", DoNotGenerateAcw=true)]
	public partial class CircleTransform : global::Java.Lang.Object, global::Square.Picasso.ITransformation {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/ui/view/utils/picasso/CircleTransform", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CircleTransform); }
		}

		protected CircleTransform (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils.picasso']/class[@name='CircleTransform']/constructor[@name='CircleTransform' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CircleTransform ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CircleTransform)) {
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

		static Delegate cb_key;
#pragma warning disable 0169
		static Delegate GetInvokeKeyHandler ()
		{
			if (cb_key == null)
				cb_key = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InvokeKey);
			return cb_key;
		}

		static IntPtr n_InvokeKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.Utils.Picasso.CircleTransform __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Utils.Picasso.CircleTransform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.InvokeKey ());
		}
#pragma warning restore 0169

		static IntPtr id_key;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils.picasso']/class[@name='CircleTransform']/method[@name='key' and count(parameter)=0]"
		[Register ("key", "()Ljava/lang/String;", "GetInvokeKeyHandler")]
		public virtual unsafe string InvokeKey ()
		{
			if (id_key == IntPtr.Zero)
				id_key = JNIEnv.GetMethodID (class_ref, "key", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_key), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "key", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_transform_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetTransform_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_transform_Landroid_graphics_Bitmap_ == null)
				cb_transform_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Transform_Landroid_graphics_Bitmap_);
			return cb_transform_Landroid_graphics_Bitmap_;
		}

		static IntPtr n_Transform_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.Utils.Picasso.CircleTransform __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Utils.Picasso.CircleTransform> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Transform (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_transform_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils.picasso']/class[@name='CircleTransform']/method[@name='transform' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("transform", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;", "GetTransform_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap Transform (global::Android.Graphics.Bitmap p0)
		{
			if (id_transform_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_transform_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "transform", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Graphics.Bitmap __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_transform_Landroid_graphics_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transform", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
