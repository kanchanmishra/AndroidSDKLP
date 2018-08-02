using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='CopyBehavior']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior", DoNotGenerateAcw=true)]
	public abstract partial class CopyBehavior : global::Java.Lang.Object {


		static IntPtr mActivityProvider_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='CopyBehavior']/field[@name='mActivityProvider']"
		[Register ("mActivityProvider")]
		protected global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.IActivityProvider MActivityProvider {
			get {
				if (mActivityProvider_jfieldId == IntPtr.Zero)
					mActivityProvider_jfieldId = JNIEnv.GetFieldID (class_ref, "mActivityProvider", "Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/IActivityProvider;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mActivityProvider_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.IActivityProvider> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mActivityProvider_jfieldId == IntPtr.Zero)
					mActivityProvider_jfieldId = JNIEnv.GetFieldID (class_ref, "mActivityProvider", "Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/IActivityProvider;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mActivityProvider_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mMenuCallback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='CopyBehavior']/field[@name='mMenuCallback']"
		[Register ("mMenuCallback")]
		protected global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.IMenuCallback MMenuCallback {
			get {
				if (mMenuCallback_jfieldId == IntPtr.Zero)
					mMenuCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mMenuCallback", "Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/IMenuCallback;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMenuCallback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.IMenuCallback> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMenuCallback_jfieldId == IntPtr.Zero)
					mMenuCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mMenuCallback", "Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/IMenuCallback;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMenuCallback_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CopyBehavior); }
		}

		protected CopyBehavior (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSelectable;
		}
#pragma warning restore 0169

		public abstract bool IsSelectable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='CopyBehavior']/method[@name='isSelectable' and count(parameter)=0]"
			[Register ("isSelectable", "()Z", "GetIsSelectableHandler")] get;
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
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ApplyCopyCapability (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='CopyBehavior']/method[@name='applyCopyCapability' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.liveperson.infra.ui.view.adapter.viewholder.BaseViewHolder']]"
		[Register ("applyCopyCapability", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)V", "GetApplyCopyCapability_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Handler")]
		public abstract void ApplyCopyCapability (int p0, global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p1);

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
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetOnClickListener (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='CopyBehavior']/method[@name='getOnClickListener' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.liveperson.infra.ui.view.adapter.viewholder.BaseViewHolder']]"
		[Register ("getOnClickListener", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)Landroid/view/View$OnClickListener;", "GetGetOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Handler")]
		public abstract global::Android.Views.View.IOnClickListener GetOnClickListener (int p0, global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p1);

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
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetOnLongClickListener (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='CopyBehavior']/method[@name='getOnLongClickListener' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.liveperson.infra.ui.view.adapter.viewholder.BaseViewHolder']]"
		[Register ("getOnLongClickListener", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)Landroid/view/View$OnLongClickListener;", "GetGetOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Handler")]
		public abstract global::Android.Views.View.IOnLongClickListener GetOnLongClickListener (int p0, global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p1);

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
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnViewRecycled (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='CopyBehavior']/method[@name='onViewRecycled' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder']]"
		[Register ("onViewRecycled", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V", "GetOnViewRecycled_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler")]
		public abstract void OnViewRecycled (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0);

		static Delegate cb_setActivityProvider_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_IActivityProvider_;
#pragma warning disable 0169
		static Delegate GetSetActivityProvider_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_IActivityProvider_Handler ()
		{
			if (cb_setActivityProvider_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_IActivityProvider_ == null)
				cb_setActivityProvider_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_IActivityProvider_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActivityProvider_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_IActivityProvider_);
			return cb_setActivityProvider_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_IActivityProvider_;
		}

		static void n_SetActivityProvider_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_IActivityProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.IActivityProvider p0 = (global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.IActivityProvider)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.IActivityProvider> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetActivityProvider (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setActivityProvider_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_IActivityProvider_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='CopyBehavior']/method[@name='setActivityProvider' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.messaging_ui.view.adapter.copybehavior.IActivityProvider']]"
		[Register ("setActivityProvider", "(Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/IActivityProvider;)V", "GetSetActivityProvider_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_IActivityProvider_Handler")]
		public virtual unsafe void SetActivityProvider (global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.IActivityProvider p0)
		{
			if (id_setActivityProvider_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_IActivityProvider_ == IntPtr.Zero)
				id_setActivityProvider_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_IActivityProvider_ = JNIEnv.GetMethodID (class_ref, "setActivityProvider", "(Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/IActivityProvider;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActivityProvider_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_IActivityProvider_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActivityProvider", "(Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/IActivityProvider;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMenuStateListener_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_IMenuCallback_;
#pragma warning disable 0169
		static Delegate GetSetMenuStateListener_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_IMenuCallback_Handler ()
		{
			if (cb_setMenuStateListener_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_IMenuCallback_ == null)
				cb_setMenuStateListener_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_IMenuCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMenuStateListener_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_IMenuCallback_);
			return cb_setMenuStateListener_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_IMenuCallback_;
		}

		static void n_SetMenuStateListener_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_IMenuCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.IMenuCallback p0 = (global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.IMenuCallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.IMenuCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMenuStateListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMenuStateListener_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_IMenuCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='CopyBehavior']/method[@name='setMenuStateListener' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.messaging_ui.view.adapter.copybehavior.IMenuCallback']]"
		[Register ("setMenuStateListener", "(Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/IMenuCallback;)V", "GetSetMenuStateListener_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_IMenuCallback_Handler")]
		public virtual unsafe void SetMenuStateListener (global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.IMenuCallback p0)
		{
			if (id_setMenuStateListener_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_IMenuCallback_ == IntPtr.Zero)
				id_setMenuStateListener_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_IMenuCallback_ = JNIEnv.GetMethodID (class_ref, "setMenuStateListener", "(Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/IMenuCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMenuStateListener_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_IMenuCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMenuStateListener", "(Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/IMenuCallback;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior", DoNotGenerateAcw=true)]
	internal partial class CopyBehaviorInvoker : CopyBehavior {

		public CopyBehaviorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (CopyBehaviorInvoker); }
		}

		static IntPtr id_isSelectable;
		public override unsafe bool IsSelectable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='CopyBehavior']/method[@name='isSelectable' and count(parameter)=0]"
			[Register ("isSelectable", "()Z", "GetIsSelectableHandler")]
			get {
				if (id_isSelectable == IntPtr.Zero)
					id_isSelectable = JNIEnv.GetMethodID (class_ref, "isSelectable", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSelectable);
				} finally {
				}
			}
		}

		static IntPtr id_applyCopyCapability_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='CopyBehavior']/method[@name='applyCopyCapability' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.liveperson.infra.ui.view.adapter.viewholder.BaseViewHolder']]"
		[Register ("applyCopyCapability", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)V", "GetApplyCopyCapability_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Handler")]
		public override unsafe void ApplyCopyCapability (int p0, global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p1)
		{
			if (id_applyCopyCapability_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ == IntPtr.Zero)
				id_applyCopyCapability_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ = JNIEnv.GetMethodID (class_ref, "applyCopyCapability", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_applyCopyCapability_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_, __args);
			} finally {
			}
		}

		static IntPtr id_getOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='CopyBehavior']/method[@name='getOnClickListener' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.liveperson.infra.ui.view.adapter.viewholder.BaseViewHolder']]"
		[Register ("getOnClickListener", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)Landroid/view/View$OnClickListener;", "GetGetOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Handler")]
		public override unsafe global::Android.Views.View.IOnClickListener GetOnClickListener (int p0, global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p1)
		{
			if (id_getOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ == IntPtr.Zero)
				id_getOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ = JNIEnv.GetMethodID (class_ref, "getOnClickListener", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)Landroid/view/View$OnClickListener;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Views.View.IOnClickListener __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='CopyBehavior']/method[@name='getOnLongClickListener' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.liveperson.infra.ui.view.adapter.viewholder.BaseViewHolder']]"
		[Register ("getOnLongClickListener", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)Landroid/view/View$OnLongClickListener;", "GetGetOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Handler")]
		public override unsafe global::Android.Views.View.IOnLongClickListener GetOnLongClickListener (int p0, global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p1)
		{
			if (id_getOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ == IntPtr.Zero)
				id_getOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ = JNIEnv.GetMethodID (class_ref, "getOnLongClickListener", "(ILcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)Landroid/view/View$OnLongClickListener;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Views.View.IOnLongClickListener __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnLongClickListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnLongClickListener_ILcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onViewRecycled_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.copybehavior']/class[@name='CopyBehavior']/method[@name='onViewRecycled' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder']]"
		[Register ("onViewRecycled", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V", "GetOnViewRecycled_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler")]
		public override unsafe void OnViewRecycled (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0)
		{
			if (id_onViewRecycled_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == IntPtr.Zero)
				id_onViewRecycled_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNIEnv.GetMethodID (class_ref, "onViewRecycled", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onViewRecycled_Landroid_support_v7_widget_RecyclerView_ViewHolder_, __args);
			} finally {
			}
		}

	}

}
