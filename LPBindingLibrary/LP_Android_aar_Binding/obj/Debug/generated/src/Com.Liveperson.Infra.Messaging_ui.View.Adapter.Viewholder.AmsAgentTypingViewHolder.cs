using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentTypingViewHolder']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsAgentTypingViewHolder", DoNotGenerateAcw=true)]
	public partial class AmsAgentTypingViewHolder : global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentViewHolder {


		static IntPtr mAgentIsTypingAnimatedIndicator_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentTypingViewHolder']/field[@name='mAgentIsTypingAnimatedIndicator']"
		[Register ("mAgentIsTypingAnimatedIndicator")]
		protected global::Android.Widget.ImageView MAgentIsTypingAnimatedIndicator {
			get {
				if (mAgentIsTypingAnimatedIndicator_jfieldId == IntPtr.Zero)
					mAgentIsTypingAnimatedIndicator_jfieldId = JNIEnv.GetFieldID (class_ref, "mAgentIsTypingAnimatedIndicator", "Landroid/widget/ImageView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAgentIsTypingAnimatedIndicator_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAgentIsTypingAnimatedIndicator_jfieldId == IntPtr.Zero)
					mAgentIsTypingAnimatedIndicator_jfieldId = JNIEnv.GetFieldID (class_ref, "mAgentIsTypingAnimatedIndicator", "Landroid/widget/ImageView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAgentIsTypingAnimatedIndicator_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsAgentTypingViewHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsAgentTypingViewHolder); }
		}

		protected AmsAgentTypingViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentTypingViewHolder']/constructor[@name='AmsAgentTypingViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/view/View;)V", "")]
		public unsafe AmsAgentTypingViewHolder (global::Android.Views.View p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AmsAgentTypingViewHolder)) {
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

		static Delegate cb_showTypingAnimation;
#pragma warning disable 0169
		static Delegate GetShowTypingAnimationHandler ()
		{
			if (cb_showTypingAnimation == null)
				cb_showTypingAnimation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowTypingAnimation);
			return cb_showTypingAnimation;
		}

		static void n_ShowTypingAnimation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentTypingViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentTypingViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowTypingAnimation ();
		}
#pragma warning restore 0169

		static IntPtr id_showTypingAnimation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentTypingViewHolder']/method[@name='showTypingAnimation' and count(parameter)=0]"
		[Register ("showTypingAnimation", "()V", "GetShowTypingAnimationHandler")]
		public virtual unsafe void ShowTypingAnimation ()
		{
			if (id_showTypingAnimation == IntPtr.Zero)
				id_showTypingAnimation = JNIEnv.GetMethodID (class_ref, "showTypingAnimation", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showTypingAnimation);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showTypingAnimation", "()V"));
			} finally {
			}
		}

	}
}
