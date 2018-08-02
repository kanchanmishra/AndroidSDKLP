using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='StickyHeaderRecyclerViewCursorAdapter']"
	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/adapter/StickyHeaderRecyclerViewCursorAdapter", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "V extends android.support.v7.widget.RecyclerView.ViewHolder"})]
	public abstract partial class StickyHeaderRecyclerViewCursorAdapter : global::Com.Liveperson.Infra.UI.View.Adapter.BaseRecyclerViewCursorAdapter, global::Com.Liveperson.Infra.UI.View.Header.IStickyRecyclerHeadersAdapter {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='StickyHeaderRecyclerViewCursorAdapter']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/ui/view/adapter/StickyHeaderRecyclerViewCursorAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StickyHeaderRecyclerViewCursorAdapter); }
		}

		protected StickyHeaderRecyclerViewCursorAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_database_Cursor_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='StickyHeaderRecyclerViewCursorAdapter']/constructor[@name='StickyHeaderRecyclerViewCursorAdapter' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.database.Cursor']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/database/Cursor;)V", "")]
		public unsafe StickyHeaderRecyclerViewCursorAdapter (global::Android.Content.Context p0, global::Android.Database.ICursor p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (StickyHeaderRecyclerViewCursorAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/database/Cursor;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/database/Cursor;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_database_Cursor_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/database/Cursor;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_database_Cursor_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_database_Cursor_, __args);
			} finally {
			}
		}

		static Delegate cb_getHeaderId_I;
#pragma warning disable 0169
		static Delegate GetGetHeaderId_IHandler ()
		{
			if (cb_getHeaderId_I == null)
				cb_getHeaderId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_GetHeaderId_I);
			return cb_getHeaderId_I;
		}

		static long n_GetHeaderId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.StickyHeaderRecyclerViewCursorAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.StickyHeaderRecyclerViewCursorAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHeaderId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getHeaderId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='StickyHeaderRecyclerViewCursorAdapter']/method[@name='getHeaderId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getHeaderId", "(I)J", "GetGetHeaderId_IHandler")]
		public virtual unsafe long GetHeaderId (int p0)
		{
			if (id_getHeaderId_I == IntPtr.Zero)
				id_getHeaderId_I = JNIEnv.GetMethodID (class_ref, "getHeaderId", "(I)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getHeaderId_I, __args);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaderId", "(I)J"), __args);
			} finally {
			}
		}

		static Delegate cb_onBindHeaderViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_I;
#pragma warning disable 0169
		static Delegate GetOnBindHeaderViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_IHandler ()
		{
			if (cb_onBindHeaderViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_I == null)
				cb_onBindHeaderViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnBindHeaderViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_I);
			return cb_onBindHeaderViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_I;
		}

		static void n_OnBindHeaderViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.StickyHeaderRecyclerViewCursorAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.StickyHeaderRecyclerViewCursorAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBindHeaderViewHolder (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onBindHeaderViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='StickyHeaderRecyclerViewCursorAdapter']/method[@name='onBindHeaderViewHolder' and count(parameter)=2 and parameter[1][@type='com.liveperson.infra.ui.view.adapter.viewholder.BaseViewHolder'] and parameter[2][@type='int']]"
		[Register ("onBindHeaderViewHolder", "(Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;I)V", "GetOnBindHeaderViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_IHandler")]
		public virtual unsafe void OnBindHeaderViewHolder (global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p0, int p1)
		{
			if (id_onBindHeaderViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_I == IntPtr.Zero)
				id_onBindHeaderViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_I = JNIEnv.GetMethodID (class_ref, "onBindHeaderViewHolder", "(Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBindHeaderViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBindHeaderViewHolder", "(Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onCreateHeaderViewHolder_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetOnCreateHeaderViewHolder_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_onCreateHeaderViewHolder_Landroid_view_ViewGroup_ == null)
				cb_onCreateHeaderViewHolder_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCreateHeaderViewHolder_Landroid_view_ViewGroup_);
			return cb_onCreateHeaderViewHolder_Landroid_view_ViewGroup_;
		}

		static IntPtr n_OnCreateHeaderViewHolder_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.StickyHeaderRecyclerViewCursorAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.StickyHeaderRecyclerViewCursorAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateHeaderViewHolder (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onCreateHeaderViewHolder_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='StickyHeaderRecyclerViewCursorAdapter']/method[@name='onCreateHeaderViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
		[Register ("onCreateHeaderViewHolder", "(Landroid/view/ViewGroup;)Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;", "GetOnCreateHeaderViewHolder_Landroid_view_ViewGroup_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder OnCreateHeaderViewHolder (global::Android.Views.ViewGroup p0)
		{
			if (id_onCreateHeaderViewHolder_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_onCreateHeaderViewHolder_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "onCreateHeaderViewHolder", "(Landroid/view/ViewGroup;)Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onCreateHeaderViewHolder_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreateHeaderViewHolder", "(Landroid/view/ViewGroup;)Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Liveperson.Infra.UI.View.Header.IStickyRecyclerHeadersAdapter
		void global::Com.Liveperson.Infra.UI.View.Header.IStickyRecyclerHeadersAdapter.OnBindHeaderViewHolder (global::Java.Lang.Object p0, int p1)
		{
			OnBindHeaderViewHolder (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder>(p0), p1);
		}

		// This method is explicitly implemented as a member of an instantiated Com.Liveperson.Infra.UI.View.Header.IStickyRecyclerHeadersAdapter
		global::Java.Lang.Object global::Com.Liveperson.Infra.UI.View.Header.IStickyRecyclerHeadersAdapter.OnCreateHeaderViewHolder (global::Android.Views.ViewGroup p0)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(OnCreateHeaderViewHolder (p0));
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/adapter/StickyHeaderRecyclerViewCursorAdapter", DoNotGenerateAcw=true)]
	internal partial class StickyHeaderRecyclerViewCursorAdapterInvoker : StickyHeaderRecyclerViewCursorAdapter, global::Com.Liveperson.Infra.UI.View.Header.IStickyRecyclerHeadersAdapter {

		public StickyHeaderRecyclerViewCursorAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (StickyHeaderRecyclerViewCursorAdapterInvoker); }
		}

		static IntPtr id_getItemViewType_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='BaseRecyclerViewCursorAdapter']/method[@name='getItemViewType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItemViewType", "(I)I", "GetGetItemViewType_IHandler")]
		public override unsafe int GetItemViewType (int p0)
		{
			if (id_getItemViewType_I == IntPtr.Zero)
				id_getItemViewType_I = JNIEnv.GetMethodID (class_ref, "getItemViewType", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemViewType_I, __args);
			} finally {
			}
		}

	}

}
