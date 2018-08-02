using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Adapter.Viewholder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='HeaderViewHolder']"
	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/adapter/viewholder/HeaderViewHolder", DoNotGenerateAcw=true)]
	public partial class HeaderViewHolder : global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/ui/view/adapter/viewholder/HeaderViewHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HeaderViewHolder); }
		}

		protected HeaderViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='HeaderViewHolder']/constructor[@name='HeaderViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/view/View;)V", "")]
		public unsafe HeaderViewHolder (global::Android.Views.View p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (HeaderViewHolder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/view/View;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/view/View;)V", __args);
					return;
				}

				if (id_ctor_Landroid_view_View_ == IntPtr.Zero)
					id_ctor_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_view_View_, __args);
			} finally {
			}
		}

		static Delegate cb_setHeaderText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHeaderText_Ljava_lang_String_Handler ()
		{
			if (cb_setHeaderText_Ljava_lang_String_ == null)
				cb_setHeaderText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHeaderText_Ljava_lang_String_);
			return cb_setHeaderText_Ljava_lang_String_;
		}

		static void n_SetHeaderText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.HeaderViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.HeaderViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetHeaderText (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHeaderText_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='HeaderViewHolder']/method[@name='setHeaderText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setHeaderText", "(Ljava/lang/String;)V", "GetSetHeaderText_Ljava_lang_String_Handler")]
		public virtual unsafe void SetHeaderText (string p0)
		{
			if (id_setHeaderText_Ljava_lang_String_ == IntPtr.Zero)
				id_setHeaderText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHeaderText", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHeaderText_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeaderText", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
