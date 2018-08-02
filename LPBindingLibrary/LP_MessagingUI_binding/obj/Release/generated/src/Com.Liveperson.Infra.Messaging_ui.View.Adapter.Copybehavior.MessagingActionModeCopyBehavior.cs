using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='MessagingActionModeCopyBehavior']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/copybehavior/MessagingActionModeCopyBehavior", DoNotGenerateAcw=true)]
	public partial class MessagingActionModeCopyBehavior : global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/view/adapter/copybehavior/MessagingActionModeCopyBehavior", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessagingActionModeCopyBehavior); }
		}

		protected MessagingActionModeCopyBehavior (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='MessagingActionModeCopyBehavior']/constructor[@name='MessagingActionModeCopyBehavior' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MessagingActionModeCopyBehavior ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MessagingActionModeCopyBehavior)) {
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

		static Delegate cb_isSelectable;
#pragma warning disable 0169
		static Delegate GetIsSelectableHandler ()
		{
			if (cb_isSelectable == null)
				cb_isSelectable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSelectable);
			return cb_isSelectable;
		}

		static bool n_IsSelectable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.MessagingActionModeCopyBehavior __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.MessagingActionModeCopyBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSelectable;
		}
#pragma warning restore 0169

		static IntPtr id_isSelectable;
		public override unsafe bool IsSelectable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='MessagingActionModeCopyBehavior']/method[@name='isSelectable' and count(parameter)=0]"
			[Register ("isSelectable", "()Z", "GetIsSelectableHandler")]
			get {
				if (id_isSelectable == IntPtr.Zero)
					id_isSelectable = JNIEnv.GetMethodID (class_ref, "isSelectable", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSelectable);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSelectable", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getSelectionTextToCopy;
#pragma warning disable 0169
		static Delegate GetGetSelectionTextToCopyHandler ()
		{
			if (cb_getSelectionTextToCopy == null)
				cb_getSelectionTextToCopy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectionTextToCopy);
			return cb_getSelectionTextToCopy;
		}

		static IntPtr n_GetSelectionTextToCopy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.MessagingActionModeCopyBehavior __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.MessagingActionModeCopyBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SelectionTextToCopy);
		}
#pragma warning restore 0169

		static IntPtr id_getSelectionTextToCopy;
		public virtual unsafe string SelectionTextToCopy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='MessagingActionModeCopyBehavior']/method[@name='getSelectionTextToCopy' and count(parameter)=0]"
			[Register ("getSelectionTextToCopy", "()Ljava/lang/String;", "GetGetSelectionTextToCopyHandler")]
			get {
				if (id_getSelectionTextToCopy == IntPtr.Zero)
					id_getSelectionTextToCopy = JNIEnv.GetMethodID (class_ref, "getSelectionTextToCopy", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSelectionTextToCopy), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectionTextToCopy", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_onViewRecycled_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
#pragma warning disable 0169
		static Delegate GetOnViewRecycled_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler ()
		{
			if (cb_onViewRecycled_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == null)
				cb_onViewRecycled_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnViewRecycled_Landroid_support_v7_widget_RecyclerView_ViewHolder_);
			return cb_onViewRecycled_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
		}

		static void n_OnViewRecycled_Landroid_support_v7_widget_RecyclerView_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_holder)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.MessagingActionModeCopyBehavior __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.MessagingActionModeCopyBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.RecyclerView.ViewHolder holder = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_holder, JniHandleOwnership.DoNotTransfer);
			__this.OnViewRecycled (holder);
		}
#pragma warning restore 0169

		static IntPtr id_onViewRecycled_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='MessagingActionModeCopyBehavior']/method[@name='onViewRecycled' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder']]"
		[Register ("onViewRecycled", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V", "GetOnViewRecycled_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler")]
		public override unsafe void OnViewRecycled (global::Android.Support.V7.Widget.RecyclerView.ViewHolder holder)
		{
			if (id_onViewRecycled_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == IntPtr.Zero)
				id_onViewRecycled_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNIEnv.GetMethodID (class_ref, "onViewRecycled", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (holder);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onViewRecycled_Landroid_support_v7_widget_RecyclerView_ViewHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onViewRecycled", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V"), __args);
			} finally {
			}
		}

	}
}
