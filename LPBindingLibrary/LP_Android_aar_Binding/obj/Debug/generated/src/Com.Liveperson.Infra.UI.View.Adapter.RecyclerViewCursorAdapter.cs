using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='RecyclerViewCursorAdapter']"
	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/adapter/RecyclerViewCursorAdapter", DoNotGenerateAcw=true)]
	public abstract partial class RecyclerViewCursorAdapter : global::Com.Liveperson.Infra.UI.View.Adapter.BaseRecyclerViewCursorAdapter {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='RecyclerViewCursorAdapter']/field[@name='TAG']"
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
				return JNIEnv.FindClass ("com/liveperson/infra/ui/view/adapter/RecyclerViewCursorAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RecyclerViewCursorAdapter); }
		}

		protected RecyclerViewCursorAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_database_Cursor_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='RecyclerViewCursorAdapter']/constructor[@name='RecyclerViewCursorAdapter' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.database.Cursor']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/database/Cursor;)V", "")]
		public unsafe RecyclerViewCursorAdapter (global::Android.Content.Context p0, global::Android.Database.ICursor p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (RecyclerViewCursorAdapter)) {
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

		static Delegate cb_extractFromCursor_Landroid_database_Cursor_;
#pragma warning disable 0169
		static Delegate GetExtractFromCursor_Landroid_database_Cursor_Handler ()
		{
			if (cb_extractFromCursor_Landroid_database_Cursor_ == null)
				cb_extractFromCursor_Landroid_database_Cursor_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ExtractFromCursor_Landroid_database_Cursor_);
			return cb_extractFromCursor_Landroid_database_Cursor_;
		}

		static IntPtr n_ExtractFromCursor_Landroid_database_Cursor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.RecyclerViewCursorAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.RecyclerViewCursorAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.ICursor p0 = (global::Android.Database.ICursor)global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ExtractFromCursor (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_extractFromCursor_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='RecyclerViewCursorAdapter']/method[@name='extractFromCursor' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("extractFromCursor", "(Landroid/database/Cursor;)Lcom/liveperson/infra/model/Message;", "GetExtractFromCursor_Landroid_database_Cursor_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Model.Message ExtractFromCursor (global::Android.Database.ICursor p0)
		{
			if (id_extractFromCursor_Landroid_database_Cursor_ == IntPtr.Zero)
				id_extractFromCursor_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "extractFromCursor", "(Landroid/database/Cursor;)Lcom/liveperson/infra/model/Message;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Liveperson.Infra.Model.Message __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Message> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_extractFromCursor_Landroid_database_Cursor_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Message> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "extractFromCursor", "(Landroid/database/Cursor;)Lcom/liveperson/infra/model/Message;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getItemViewType_I;
#pragma warning disable 0169
		static Delegate GetGetItemViewType_IHandler ()
		{
			if (cb_getItemViewType_I == null)
				cb_getItemViewType_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetItemViewType_I);
			return cb_getItemViewType_I;
		}

		static int n_GetItemViewType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.RecyclerViewCursorAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.RecyclerViewCursorAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetItemViewType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getItemViewType_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='RecyclerViewCursorAdapter']/method[@name='getItemViewType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItemViewType", "(I)I", "GetGetItemViewType_IHandler")]
		public override unsafe int GetItemViewType (int p0)
		{
			if (id_getItemViewType_I == IntPtr.Zero)
				id_getItemViewType_I = JNIEnv.GetMethodID (class_ref, "getItemViewType", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemViewType_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemViewType", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_onBind_Lcom_liveperson_infra_ui_view_adapter_viewholder_MiddleViewHolder_Lcom_liveperson_infra_model_Message_II;
#pragma warning disable 0169
		static Delegate GetOnBind_Lcom_liveperson_infra_ui_view_adapter_viewholder_MiddleViewHolder_Lcom_liveperson_infra_model_Message_IIHandler ()
		{
			if (cb_onBind_Lcom_liveperson_infra_ui_view_adapter_viewholder_MiddleViewHolder_Lcom_liveperson_infra_model_Message_II == null)
				cb_onBind_Lcom_liveperson_infra_ui_view_adapter_viewholder_MiddleViewHolder_Lcom_liveperson_infra_model_Message_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_OnBind_Lcom_liveperson_infra_ui_view_adapter_viewholder_MiddleViewHolder_Lcom_liveperson_infra_model_Message_II);
			return cb_onBind_Lcom_liveperson_infra_ui_view_adapter_viewholder_MiddleViewHolder_Lcom_liveperson_infra_model_Message_II;
		}

		static void n_OnBind_Lcom_liveperson_infra_ui_view_adapter_viewholder_MiddleViewHolder_Lcom_liveperson_infra_model_Message_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.RecyclerViewCursorAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.RecyclerViewCursorAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.MiddleViewHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.MiddleViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Model.Message p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Message> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnBind (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_onBind_Lcom_liveperson_infra_ui_view_adapter_viewholder_MiddleViewHolder_Lcom_liveperson_infra_model_Message_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='RecyclerViewCursorAdapter']/method[@name='onBind' and count(parameter)=4 and parameter[1][@type='com.liveperson.infra.ui.view.adapter.viewholder.MiddleViewHolder'] and parameter[2][@type='com.liveperson.infra.model.Message'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onBind", "(Lcom/liveperson/infra/ui/view/adapter/viewholder/MiddleViewHolder;Lcom/liveperson/infra/model/Message;II)V", "GetOnBind_Lcom_liveperson_infra_ui_view_adapter_viewholder_MiddleViewHolder_Lcom_liveperson_infra_model_Message_IIHandler")]
		public virtual unsafe void OnBind (global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.MiddleViewHolder p0, global::Com.Liveperson.Infra.Model.Message p1, int p2, int p3)
		{
			if (id_onBind_Lcom_liveperson_infra_ui_view_adapter_viewholder_MiddleViewHolder_Lcom_liveperson_infra_model_Message_II == IntPtr.Zero)
				id_onBind_Lcom_liveperson_infra_ui_view_adapter_viewholder_MiddleViewHolder_Lcom_liveperson_infra_model_Message_II = JNIEnv.GetMethodID (class_ref, "onBind", "(Lcom/liveperson/infra/ui/view/adapter/viewholder/MiddleViewHolder;Lcom/liveperson/infra/model/Message;II)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBind_Lcom_liveperson_infra_ui_view_adapter_viewholder_MiddleViewHolder_Lcom_liveperson_infra_model_Message_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBind", "(Lcom/liveperson/infra/ui/view/adapter/viewholder/MiddleViewHolder;Lcom/liveperson/infra/model/Message;II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onCreate_Landroid_view_ViewGroup_I;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_view_ViewGroup_IHandler ()
		{
			if (cb_onCreate_Landroid_view_ViewGroup_I == null)
				cb_onCreate_Landroid_view_ViewGroup_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnCreate_Landroid_view_ViewGroup_I);
			return cb_onCreate_Landroid_view_ViewGroup_I;
		}

		static IntPtr n_OnCreate_Landroid_view_ViewGroup_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.RecyclerViewCursorAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.RecyclerViewCursorAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreate (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onCreate_Landroid_view_ViewGroup_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='RecyclerViewCursorAdapter']/method[@name='onCreate' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
		[Register ("onCreate", "(Landroid/view/ViewGroup;I)Lcom/liveperson/infra/ui/view/adapter/viewholder/MiddleViewHolder;", "GetOnCreate_Landroid_view_ViewGroup_IHandler")]
		public virtual unsafe global::Java.Lang.Object OnCreate (global::Android.Views.ViewGroup p0, int p1)
		{
			if (id_onCreate_Landroid_view_ViewGroup_I == IntPtr.Zero)
				id_onCreate_Landroid_view_ViewGroup_I = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/view/ViewGroup;I)Lcom/liveperson/infra/ui/view/adapter/viewholder/MiddleViewHolder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onCreate_Landroid_view_ViewGroup_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreate", "(Landroid/view/ViewGroup;I)Lcom/liveperson/infra/ui/view/adapter/viewholder/MiddleViewHolder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/adapter/RecyclerViewCursorAdapter", DoNotGenerateAcw=true)]
	internal partial class RecyclerViewCursorAdapterInvoker : RecyclerViewCursorAdapter {

		public RecyclerViewCursorAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (RecyclerViewCursorAdapterInvoker); }
		}

	}

}
