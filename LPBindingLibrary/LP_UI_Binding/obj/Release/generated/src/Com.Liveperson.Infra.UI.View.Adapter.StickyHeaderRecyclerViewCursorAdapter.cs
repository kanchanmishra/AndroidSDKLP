using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='StickyHeaderRecyclerViewCursorAdapter']"
	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/adapter/StickyHeaderRecyclerViewCursorAdapter", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "V extends android.support.v7.widget.RecyclerView.ViewHolder"})]
	public abstract partial class StickyHeaderRecyclerViewCursorAdapter : global::Com.Liveperson.Infra.UI.View.Adapter.BaseRecyclerViewCursorAdapter {


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

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/adapter/StickyHeaderRecyclerViewCursorAdapter", DoNotGenerateAcw=true)]
	internal partial class StickyHeaderRecyclerViewCursorAdapterInvoker : StickyHeaderRecyclerViewCursorAdapter {

		public StickyHeaderRecyclerViewCursorAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (StickyHeaderRecyclerViewCursorAdapterInvoker); }
		}

		static IntPtr id_extractFromCursor_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='BaseRecyclerViewCursorAdapter']/method[@name='extractFromCursor' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("extractFromCursor", "(Landroid/database/Cursor;)Ljava/lang/Object;", "GetExtractFromCursor_Landroid_database_Cursor_Handler")]
		public override unsafe global::Java.Lang.Object ExtractFromCursor (global::Android.Database.ICursor p0)
		{
			if (id_extractFromCursor_Landroid_database_Cursor_ == IntPtr.Zero)
				id_extractFromCursor_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "extractFromCursor", "(Landroid/database/Cursor;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_extractFromCursor_Landroid_database_Cursor_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
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

		static IntPtr id_onAccessibilityEventAvailable_Landroid_support_v7_widget_RecyclerView_ViewHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='BaseRecyclerViewCursorAdapter']/method[@name='onAccessibilityEventAvailable' and count(parameter)=1 and parameter[1][@type='V']]"
		[Register ("onAccessibilityEventAvailable", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V", "GetOnAccessibilityEventAvailable_Landroid_support_v7_widget_RecyclerView_ViewHolder_Handler")]
		public override unsafe void OnAccessibilityEventAvailable (global::Java.Lang.Object p0)
		{
			if (id_onAccessibilityEventAvailable_Landroid_support_v7_widget_RecyclerView_ViewHolder_ == IntPtr.Zero)
				id_onAccessibilityEventAvailable_Landroid_support_v7_widget_RecyclerView_ViewHolder_ = JNIEnv.GetMethodID (class_ref, "onAccessibilityEventAvailable", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAccessibilityEventAvailable_Landroid_support_v7_widget_RecyclerView_ViewHolder_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_onBind_Landroid_support_v7_widget_RecyclerView_ViewHolder_Ljava_lang_Object_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='BaseRecyclerViewCursorAdapter']/method[@name='onBind' and count(parameter)=4 and parameter[1][@type='V'] and parameter[2][@type='T'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onBind", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;Ljava/lang/Object;II)V", "GetOnBind_Landroid_support_v7_widget_RecyclerView_ViewHolder_Ljava_lang_Object_IIHandler")]
		public override unsafe void OnBind (global::Java.Lang.Object p0, global::Java.Lang.Object p1, int p2, int p3)
		{
			if (id_onBind_Landroid_support_v7_widget_RecyclerView_ViewHolder_Ljava_lang_Object_II == IntPtr.Zero)
				id_onBind_Landroid_support_v7_widget_RecyclerView_ViewHolder_Ljava_lang_Object_II = JNIEnv.GetMethodID (class_ref, "onBind", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;Ljava/lang/Object;II)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBind_Landroid_support_v7_widget_RecyclerView_ViewHolder_Ljava_lang_Object_II, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_onCreate_Landroid_view_ViewGroup_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='BaseRecyclerViewCursorAdapter']/method[@name='onCreate' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
		[Register ("onCreate", "(Landroid/view/ViewGroup;I)Landroid/support/v7/widget/RecyclerView$ViewHolder;", "GetOnCreate_Landroid_view_ViewGroup_IHandler")]
		public override unsafe global::Java.Lang.Object OnCreate (global::Android.Views.ViewGroup p0, int p1)
		{
			if (id_onCreate_Landroid_view_ViewGroup_I == IntPtr.Zero)
				id_onCreate_Landroid_view_ViewGroup_I = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/view/ViewGroup;I)Landroid/support/v7/widget/RecyclerView$ViewHolder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onCreate_Landroid_view_ViewGroup_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

}
