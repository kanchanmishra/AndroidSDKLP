using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Adapter.Viewholder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='EndViewHolder']"
	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/adapter/viewholder/EndViewHolder", DoNotGenerateAcw=true)]
	public abstract partial class EndViewHolder : global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder {


		static IntPtr mTimestampTextView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='EndViewHolder']/field[@name='mTimestampTextView']"
		[Register ("mTimestampTextView")]
		protected global::Android.Widget.TextView MTimestampTextView {
			get {
				if (mTimestampTextView_jfieldId == IntPtr.Zero)
					mTimestampTextView_jfieldId = JNIEnv.GetFieldID (class_ref, "mTimestampTextView", "Landroid/widget/TextView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mTimestampTextView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTimestampTextView_jfieldId == IntPtr.Zero)
					mTimestampTextView_jfieldId = JNIEnv.GetFieldID (class_ref, "mTimestampTextView", "Landroid/widget/TextView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mTimestampTextView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/ui/view/adapter/viewholder/EndViewHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EndViewHolder); }
		}

		protected EndViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='EndViewHolder']/constructor[@name='EndViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/view/View;)V", "")]
		public unsafe EndViewHolder (global::Android.Views.View p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (EndViewHolder)) {
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

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/adapter/viewholder/EndViewHolder", DoNotGenerateAcw=true)]
	internal partial class EndViewHolderInvoker : EndViewHolder {

		public EndViewHolderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (EndViewHolderInvoker); }
		}

	}

}
