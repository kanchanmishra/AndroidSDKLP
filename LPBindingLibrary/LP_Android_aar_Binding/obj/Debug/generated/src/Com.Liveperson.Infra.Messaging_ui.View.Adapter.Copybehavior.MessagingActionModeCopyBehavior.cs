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

		static Delegate cb_applyCopyCapability_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
#pragma warning disable 0169
		static Delegate GetApplyCopyCapability_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Handler ()
		{
			if (cb_applyCopyCapability_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ == null)
				cb_applyCopyCapability_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_ApplyCopyCapability_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_);
			return cb_applyCopyCapability_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
		}

		static void n_ApplyCopyCapability_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.MessagingActionModeCopyBehavior __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.MessagingActionModeCopyBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ApplyCopyCapability (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_applyCopyCapability_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='MessagingActionModeCopyBehavior']/method[@name='applyCopyCapability' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.liveperson.infra.ui.view.adapter.viewholder.BaseViewHolder']]"
		[Register ("applyCopyCapability", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)V", "GetApplyCopyCapability_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Handler")]
		public override unsafe void ApplyCopyCapability (int p0, global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p1)
		{
			if (id_applyCopyCapability_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ == IntPtr.Zero)
				id_applyCopyCapability_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ = JNIEnv.GetMethodID (class_ref, "applyCopyCapability", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_applyCopyCapability_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "applyCopyCapability", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
#pragma warning disable 0169
		static Delegate GetGetOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Handler ()
		{
			if (cb_getOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ == null)
				cb_getOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_GetOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_);
			return cb_getOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
		}

		static IntPtr n_GetOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.MessagingActionModeCopyBehavior __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.MessagingActionModeCopyBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetOnClickListener (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='MessagingActionModeCopyBehavior']/method[@name='getOnClickListener' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.liveperson.infra.ui.view.adapter.viewholder.BaseViewHolder']]"
		[Register ("getOnClickListener", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)Landroid/view/View$OnClickListener;", "GetGetOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Handler")]
		public override unsafe global::Android.Views.View.IOnClickListener GetOnClickListener (int p0, global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p1)
		{
			if (id_getOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ == IntPtr.Zero)
				id_getOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ = JNIEnv.GetMethodID (class_ref, "getOnClickListener", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)Landroid/view/View$OnClickListener;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Android.Views.View.IOnClickListener __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnClickListener", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)Landroid/view/View$OnClickListener;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
#pragma warning disable 0169
		static Delegate GetGetOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Handler ()
		{
			if (cb_getOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ == null)
				cb_getOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_GetOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_);
			return cb_getOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
		}

		static IntPtr n_GetOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.MessagingActionModeCopyBehavior __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.MessagingActionModeCopyBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetOnLongClickListener (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='MessagingActionModeCopyBehavior']/method[@name='getOnLongClickListener' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.liveperson.infra.ui.view.adapter.viewholder.BaseViewHolder']]"
		[Register ("getOnLongClickListener", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)Landroid/view/View$OnLongClickListener;", "GetGetOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Handler")]
		public override unsafe global::Android.Views.View.IOnLongClickListener GetOnLongClickListener (int p0, global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p1)
		{
			if (id_getOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ == IntPtr.Zero)
				id_getOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ = JNIEnv.GetMethodID (class_ref, "getOnLongClickListener", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)Landroid/view/View$OnLongClickListener;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Android.Views.View.IOnLongClickListener __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnLongClickListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnLongClickListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnLongClickListener", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)Landroid/view/View$OnLongClickListener;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
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

		static void n_OnViewRecycled_Landroid_support_v7_widget_RecyclerView_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.MessagingActionModeCopyBehavior __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.MessagingActionModeCopyBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnViewRecycled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onViewRecycled_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='MessagingActionModeCopyBehavior']/method[@name='onViewRecycled' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder']]"
		[Register ("onViewRecycled", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V", "GetOnViewRecycled_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler")]
		public override unsafe void OnViewRecycled (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0)
		{
			if (id_onViewRecycled_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == IntPtr.Zero)
				id_onViewRecycled_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNIEnv.GetMethodID (class_ref, "onViewRecycled", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onViewRecycled_Landroid_support_v7_widget_RecyclerView_ViewHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onViewRecycled", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
#pragma warning disable 0169
		static Delegate GetSetOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Handler ()
		{
			if (cb_setOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ == null)
				cb_setOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_);
			return cb_setOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
		}

		static void n_SetOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.MessagingActionModeCopyBehavior __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.MessagingActionModeCopyBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetOnClickListener (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='MessagingActionModeCopyBehavior']/method[@name='setOnClickListener' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.liveperson.infra.ui.view.adapter.viewholder.BaseViewHolder']]"
		[Register ("setOnClickListener", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)V", "GetSetOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Handler")]
		public virtual unsafe void SetOnClickListener (int p0, global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p1)
		{
			if (id_setOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ == IntPtr.Zero)
				id_setOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ = JNIEnv.GetMethodID (class_ref, "setOnClickListener", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnClickListener", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
#pragma warning disable 0169
		static Delegate GetSetOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Handler ()
		{
			if (cb_setOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ == null)
				cb_setOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_);
			return cb_setOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
		}

		static void n_SetOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.MessagingActionModeCopyBehavior __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.MessagingActionModeCopyBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetOnLongClickListener (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='MessagingActionModeCopyBehavior']/method[@name='setOnLongClickListener' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.liveperson.infra.ui.view.adapter.viewholder.BaseViewHolder']]"
		[Register ("setOnLongClickListener", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)V", "GetSetOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Handler")]
		public virtual unsafe void SetOnLongClickListener (int p0, global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p1)
		{
			if (id_setOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ == IntPtr.Zero)
				id_setOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ = JNIEnv.GetMethodID (class_ref, "setOnLongClickListener", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnLongClickListener", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSelected_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
#pragma warning disable 0169
		static Delegate GetSetSelected_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Handler ()
		{
			if (cb_setSelected_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ == null)
				cb_setSelected_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetSelected_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_);
			return cb_setSelected_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
		}

		static void n_SetSelected_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.MessagingActionModeCopyBehavior __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.MessagingActionModeCopyBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetSelected (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setSelected_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='MessagingActionModeCopyBehavior']/method[@name='setSelected' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.liveperson.infra.ui.view.adapter.viewholder.BaseViewHolder']]"
		[Register ("setSelected", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)V", "GetSetSelected_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Handler")]
		public virtual unsafe void SetSelected (int p0, global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p1)
		{
			if (id_setSelected_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ == IntPtr.Zero)
				id_setSelected_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ = JNIEnv.GetMethodID (class_ref, "setSelected", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelected_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelected", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)V"), __args);
			} finally {
			}
		}

	}
}
