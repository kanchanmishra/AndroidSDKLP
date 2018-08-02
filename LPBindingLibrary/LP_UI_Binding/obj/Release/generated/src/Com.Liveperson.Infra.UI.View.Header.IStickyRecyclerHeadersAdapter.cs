using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Header {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.ui.view.header']/interface[@name='StickyRecyclerHeadersAdapter']"
	[Register ("com/liveperson/infra/ui/view/header/StickyRecyclerHeadersAdapter", "", "Com.Liveperson.Infra.UI.View.Header.IStickyRecyclerHeadersAdapterInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"VH extends android.support.v7.widget.RecyclerView.ViewHolder"})]
	public partial interface IStickyRecyclerHeadersAdapter : IJavaObject {

		int ItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.header']/interface[@name='StickyRecyclerHeadersAdapter']/method[@name='getItemCount' and count(parameter)=0]"
			[Register ("getItemCount", "()I", "GetGetItemCountHandler:Com.Liveperson.Infra.UI.View.Header.IStickyRecyclerHeadersAdapterInvoker, LP_UI_Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.header']/interface[@name='StickyRecyclerHeadersAdapter']/method[@name='getHeaderId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getHeaderId", "(I)J", "GetGetHeaderId_IHandler:Com.Liveperson.Infra.UI.View.Header.IStickyRecyclerHeadersAdapterInvoker, LP_UI_Binding")]
		long GetHeaderId (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.header']/interface[@name='StickyRecyclerHeadersAdapter']/method[@name='onBindHeaderViewHolder' and count(parameter)=2 and parameter[1][@type='VH'] and parameter[2][@type='int']]"
		[Register ("onBindHeaderViewHolder", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V", "GetOnBindHeaderViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_IHandler:Com.Liveperson.Infra.UI.View.Header.IStickyRecyclerHeadersAdapterInvoker, LP_UI_Binding")]
		void OnBindHeaderViewHolder (global::Java.Lang.Object p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.header']/interface[@name='StickyRecyclerHeadersAdapter']/method[@name='onCreateHeaderViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
		[Register ("onCreateHeaderViewHolder", "(Landroid/view/ViewGroup;)Landroid/support/v7/widget/RecyclerView$ViewHolder;", "GetOnCreateHeaderViewHolder_Landroid_view_ViewGroup_Handler:Com.Liveperson.Infra.UI.View.Header.IStickyRecyclerHeadersAdapterInvoker, LP_UI_Binding")]
		global::Java.Lang.Object OnCreateHeaderViewHolder (global::Android.Views.ViewGroup p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/header/StickyRecyclerHeadersAdapter", DoNotGenerateAcw=true)]
	internal class IStickyRecyclerHeadersAdapterInvoker : global::Java.Lang.Object, IStickyRecyclerHeadersAdapter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/ui/view/header/StickyRecyclerHeadersAdapter");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IStickyRecyclerHeadersAdapterInvoker); }
		}

		IntPtr class_ref;

		public static IStickyRecyclerHeadersAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStickyRecyclerHeadersAdapter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.ui.view.header.StickyRecyclerHeadersAdapter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStickyRecyclerHeadersAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getItemCount;
#pragma warning disable 0169
		static Delegate GetGetItemCountHandler ()
		{
			if (cb_getItemCount == null)
				cb_getItemCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItemCount);
			return cb_getItemCount;
		}

		static int n_GetItemCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.Header.IStickyRecyclerHeadersAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Header.IStickyRecyclerHeadersAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemCount;
		}
#pragma warning restore 0169

		IntPtr id_getItemCount;
		public unsafe int ItemCount {
			get {
				if (id_getItemCount == IntPtr.Zero)
					id_getItemCount = JNIEnv.GetMethodID (class_ref, "getItemCount", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemCount);
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
			global::Com.Liveperson.Infra.UI.View.Header.IStickyRecyclerHeadersAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Header.IStickyRecyclerHeadersAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHeaderId (p0);
		}
#pragma warning restore 0169

		IntPtr id_getHeaderId_I;
		public unsafe long GetHeaderId (int p0)
		{
			if (id_getHeaderId_I == IntPtr.Zero)
				id_getHeaderId_I = JNIEnv.GetMethodID (class_ref, "getHeaderId", "(I)J");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getHeaderId_I, __args);
		}

		static Delegate cb_onBindHeaderViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
#pragma warning disable 0169
		static Delegate GetOnBindHeaderViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_IHandler ()
		{
			if (cb_onBindHeaderViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I == null)
				cb_onBindHeaderViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnBindHeaderViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I);
			return cb_onBindHeaderViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
		}

		static void n_OnBindHeaderViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Liveperson.Infra.UI.View.Header.IStickyRecyclerHeadersAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Header.IStickyRecyclerHeadersAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBindHeaderViewHolder (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onBindHeaderViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
		public unsafe void OnBindHeaderViewHolder (global::Java.Lang.Object p0, int p1)
		{
			if (id_onBindHeaderViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I == IntPtr.Zero)
				id_onBindHeaderViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I = JNIEnv.GetMethodID (class_ref, "onBindHeaderViewHolder", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBindHeaderViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Liveperson.Infra.UI.View.Header.IStickyRecyclerHeadersAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Header.IStickyRecyclerHeadersAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateHeaderViewHolder (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onCreateHeaderViewHolder_Landroid_view_ViewGroup_;
		public unsafe global::Java.Lang.Object OnCreateHeaderViewHolder (global::Android.Views.ViewGroup p0)
		{
			if (id_onCreateHeaderViewHolder_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_onCreateHeaderViewHolder_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "onCreateHeaderViewHolder", "(Landroid/view/ViewGroup;)Landroid/support/v7/widget/RecyclerView$ViewHolder;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onCreateHeaderViewHolder_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
