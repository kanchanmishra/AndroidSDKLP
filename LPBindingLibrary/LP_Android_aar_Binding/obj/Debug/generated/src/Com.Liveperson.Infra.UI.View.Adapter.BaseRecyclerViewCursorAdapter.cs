using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='BaseRecyclerViewCursorAdapter']"
	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/adapter/BaseRecyclerViewCursorAdapter", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "V extends android.support.v7.widget.RecyclerView.ViewHolder"})]
	public abstract partial class BaseRecyclerViewCursorAdapter : global::Android.Support.V7.Widget.RecyclerView.Adapter {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='BaseRecyclerViewCursorAdapter']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr mContext_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='BaseRecyclerViewCursorAdapter']/field[@name='mContext']"
		[Register ("mContext")]
		protected global::Android.Content.Context MContext {
			get {
				if (mContext_jfieldId == IntPtr.Zero)
					mContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mContext", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mContext_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mContext_jfieldId == IntPtr.Zero)
					mContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mContext", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mContext_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCount_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='BaseRecyclerViewCursorAdapter']/field[@name='mCount']"
		[Register ("mCount")]
		protected int MCount {
			get {
				if (mCount_jfieldId == IntPtr.Zero)
					mCount_jfieldId = JNIEnv.GetFieldID (class_ref, "mCount", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mCount_jfieldId);
			}
			set {
				if (mCount_jfieldId == IntPtr.Zero)
					mCount_jfieldId = JNIEnv.GetFieldID (class_ref, "mCount", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCount_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mCursor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='BaseRecyclerViewCursorAdapter']/field[@name='mCursor']"
		[Register ("mCursor")]
		protected global::Android.Database.ICursor MCursor {
			get {
				if (mCursor_jfieldId == IntPtr.Zero)
					mCursor_jfieldId = JNIEnv.GetFieldID (class_ref, "mCursor", "Landroid/database/Cursor;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCursor_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCursor_jfieldId == IntPtr.Zero)
					mCursor_jfieldId = JNIEnv.GetFieldID (class_ref, "mCursor", "Landroid/database/Cursor;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCursor_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mResourse_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='BaseRecyclerViewCursorAdapter']/field[@name='mResourse']"
		[Register ("mResourse")]
		protected global::Android.Content.Res.Resources MResourse {
			get {
				if (mResourse_jfieldId == IntPtr.Zero)
					mResourse_jfieldId = JNIEnv.GetFieldID (class_ref, "mResourse", "Landroid/content/res/Resources;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mResourse_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mResourse_jfieldId == IntPtr.Zero)
					mResourse_jfieldId = JNIEnv.GetFieldID (class_ref, "mResourse", "Landroid/content/res/Resources;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mResourse_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mRowIdColumn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='BaseRecyclerViewCursorAdapter']/field[@name='mRowIdColumn']"
		[Register ("mRowIdColumn")]
		protected int MRowIdColumn {
			get {
				if (mRowIdColumn_jfieldId == IntPtr.Zero)
					mRowIdColumn_jfieldId = JNIEnv.GetFieldID (class_ref, "mRowIdColumn", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mRowIdColumn_jfieldId);
			}
			set {
				if (mRowIdColumn_jfieldId == IntPtr.Zero)
					mRowIdColumn_jfieldId = JNIEnv.GetFieldID (class_ref, "mRowIdColumn", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mRowIdColumn_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mSelectedPosition_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='BaseRecyclerViewCursorAdapter']/field[@name='mSelectedPosition']"
		[Register ("mSelectedPosition")]
		protected int MSelectedPosition {
			get {
				if (mSelectedPosition_jfieldId == IntPtr.Zero)
					mSelectedPosition_jfieldId = JNIEnv.GetFieldID (class_ref, "mSelectedPosition", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mSelectedPosition_jfieldId);
			}
			set {
				if (mSelectedPosition_jfieldId == IntPtr.Zero)
					mSelectedPosition_jfieldId = JNIEnv.GetFieldID (class_ref, "mSelectedPosition", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSelectedPosition_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/ui/view/adapter/BaseRecyclerViewCursorAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseRecyclerViewCursorAdapter); }
		}

		protected BaseRecyclerViewCursorAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_database_Cursor_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='BaseRecyclerViewCursorAdapter']/constructor[@name='BaseRecyclerViewCursorAdapter' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.database.Cursor']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/database/Cursor;)V", "")]
		public unsafe BaseRecyclerViewCursorAdapter (global::Android.Content.Context p0, global::Android.Database.ICursor p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (BaseRecyclerViewCursorAdapter)) {
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

		static Delegate cb_getCursor;
#pragma warning disable 0169
		static Delegate GetGetCursorHandler ()
		{
			if (cb_getCursor == null)
				cb_getCursor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCursor);
			return cb_getCursor;
		}

		static IntPtr n_GetCursor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.BaseRecyclerViewCursorAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.BaseRecyclerViewCursorAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Cursor);
		}
#pragma warning restore 0169

		static IntPtr id_getCursor;
		public virtual unsafe global::Android.Database.ICursor Cursor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='BaseRecyclerViewCursorAdapter']/method[@name='getCursor' and count(parameter)=0]"
			[Register ("getCursor", "()Landroid/database/Cursor;", "GetGetCursorHandler")]
			get {
				if (id_getCursor == IntPtr.Zero)
					id_getCursor = JNIEnv.GetMethodID (class_ref, "getCursor", "()Landroid/database/Cursor;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCursor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCursor", "()Landroid/database/Cursor;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isCursorValid;
#pragma warning disable 0169
		static Delegate GetIsCursorValidHandler ()
		{
			if (cb_isCursorValid == null)
				cb_isCursorValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCursorValid);
			return cb_isCursorValid;
		}

		static bool n_IsCursorValid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.BaseRecyclerViewCursorAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.BaseRecyclerViewCursorAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCursorValid;
		}
#pragma warning restore 0169

		static IntPtr id_isCursorValid;
		protected virtual unsafe bool IsCursorValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='BaseRecyclerViewCursorAdapter']/method[@name='isCursorValid' and count(parameter)=0]"
			[Register ("isCursorValid", "()Z", "GetIsCursorValidHandler")]
			get {
				if (id_isCursorValid == IntPtr.Zero)
					id_isCursorValid = JNIEnv.GetMethodID (class_ref, "isCursorValid", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCursorValid);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCursorValid", "()Z"));
				} finally {
				}
			}
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
			global::Com.Liveperson.Infra.UI.View.Adapter.BaseRecyclerViewCursorAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.BaseRecyclerViewCursorAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemCount;
		}
#pragma warning restore 0169

		static IntPtr id_getItemCount;
		public override unsafe int ItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='BaseRecyclerViewCursorAdapter']/method[@name='getItemCount' and count(parameter)=0]"
			[Register ("getItemCount", "()I", "GetGetItemCountHandler")]
			get {
				if (id_getItemCount == IntPtr.Zero)
					id_getItemCount = JNIEnv.GetMethodID (class_ref, "getItemCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_changeCursor_Landroid_database_Cursor_;
#pragma warning disable 0169
		static Delegate GetChangeCursor_Landroid_database_Cursor_Handler ()
		{
			if (cb_changeCursor_Landroid_database_Cursor_ == null)
				cb_changeCursor_Landroid_database_Cursor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ChangeCursor_Landroid_database_Cursor_);
			return cb_changeCursor_Landroid_database_Cursor_;
		}

		static void n_ChangeCursor_Landroid_database_Cursor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.BaseRecyclerViewCursorAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.BaseRecyclerViewCursorAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.ICursor p0 = (global::Android.Database.ICursor)global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChangeCursor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_changeCursor_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='BaseRecyclerViewCursorAdapter']/method[@name='changeCursor' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("changeCursor", "(Landroid/database/Cursor;)V", "GetChangeCursor_Landroid_database_Cursor_Handler")]
		public virtual unsafe void ChangeCursor (global::Android.Database.ICursor p0)
		{
			if (id_changeCursor_Landroid_database_Cursor_ == IntPtr.Zero)
				id_changeCursor_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "changeCursor", "(Landroid/database/Cursor;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_changeCursor_Landroid_database_Cursor_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "changeCursor", "(Landroid/database/Cursor;)V"), __args);
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
			global::Com.Liveperson.Infra.UI.View.Adapter.BaseRecyclerViewCursorAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.BaseRecyclerViewCursorAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetItemViewType (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='BaseRecyclerViewCursorAdapter']/method[@name='getItemViewType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItemViewType", "(I)I", "GetGetItemViewType_IHandler")]
		public abstract int GetItemViewType (int p0);

		static Delegate cb_getObjectAt_I;
#pragma warning disable 0169
		static Delegate GetGetObjectAt_IHandler ()
		{
			if (cb_getObjectAt_I == null)
				cb_getObjectAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetObjectAt_I);
			return cb_getObjectAt_I;
		}

		static IntPtr n_GetObjectAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.BaseRecyclerViewCursorAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.BaseRecyclerViewCursorAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetObjectAt (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getObjectAt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='BaseRecyclerViewCursorAdapter']/method[@name='getObjectAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getObjectAt", "(I)Ljava/lang/Object;", "GetGetObjectAt_IHandler")]
		public virtual unsafe global::Java.Lang.Object GetObjectAt (int p0)
		{
			if (id_getObjectAt_I == IntPtr.Zero)
				id_getObjectAt_I = JNIEnv.GetMethodID (class_ref, "getObjectAt", "(I)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getObjectAt_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getObjectAt", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
#pragma warning disable 0169
		static Delegate GetOnBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_IHandler ()
		{
			if (cb_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I == null)
				cb_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I);
			return cb_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
		}

		static void n_OnBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.BaseRecyclerViewCursorAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.BaseRecyclerViewCursorAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBindViewHolder (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='BaseRecyclerViewCursorAdapter']/method[@name='onBindViewHolder' and count(parameter)=2 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder'] and parameter[2][@type='int']]"
		[Register ("onBindViewHolder", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V", "GetOnBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_IHandler")]
		public override unsafe void OnBindViewHolder (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1)
		{
			if (id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I == IntPtr.Zero)
				id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I = JNIEnv.GetMethodID (class_ref, "onBindViewHolder", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBindViewHolder", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V"), __args);
			} finally {
			}
		}

		static IntPtr id_onCreateViewHolder_Landroid_view_ViewGroup_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='BaseRecyclerViewCursorAdapter']/method[@name='onCreateViewHolder' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
		[Register ("onCreateViewHolder", "(Landroid/view/ViewGroup;I)Landroid/support/v7/widget/RecyclerView$ViewHolder;", "")]
		public override sealed unsafe global::Android.Support.V7.Widget.RecyclerView.ViewHolder OnCreateViewHolder (global::Android.Views.ViewGroup p0, int p1)
		{
			if (id_onCreateViewHolder_Landroid_view_ViewGroup_I == IntPtr.Zero)
				id_onCreateViewHolder_Landroid_view_ViewGroup_I = JNIEnv.GetMethodID (class_ref, "onCreateViewHolder", "(Landroid/view/ViewGroup;I)Landroid/support/v7/widget/RecyclerView$ViewHolder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Support.V7.Widget.RecyclerView.ViewHolder __ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onCreateViewHolder_Landroid_view_ViewGroup_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setSelectedPosition_I;
#pragma warning disable 0169
		static Delegate GetSetSelectedPosition_IHandler ()
		{
			if (cb_setSelectedPosition_I == null)
				cb_setSelectedPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelectedPosition_I);
			return cb_setSelectedPosition_I;
		}

		static void n_SetSelectedPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.BaseRecyclerViewCursorAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.BaseRecyclerViewCursorAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectedPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSelectedPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='BaseRecyclerViewCursorAdapter']/method[@name='setSelectedPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSelectedPosition", "(I)V", "GetSetSelectedPosition_IHandler")]
		public virtual unsafe void SetSelectedPosition (int p0)
		{
			if (id_setSelectedPosition_I == IntPtr.Zero)
				id_setSelectedPosition_I = JNIEnv.GetMethodID (class_ref, "setSelectedPosition", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectedPosition_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectedPosition", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_swapCursor_Landroid_database_Cursor_;
#pragma warning disable 0169
		static Delegate GetSwapCursor_Landroid_database_Cursor_Handler ()
		{
			if (cb_swapCursor_Landroid_database_Cursor_ == null)
				cb_swapCursor_Landroid_database_Cursor_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SwapCursor_Landroid_database_Cursor_);
			return cb_swapCursor_Landroid_database_Cursor_;
		}

		static IntPtr n_SwapCursor_Landroid_database_Cursor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.BaseRecyclerViewCursorAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.BaseRecyclerViewCursorAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.ICursor p0 = (global::Android.Database.ICursor)global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SwapCursor (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_swapCursor_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter']/class[@name='BaseRecyclerViewCursorAdapter']/method[@name='swapCursor' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("swapCursor", "(Landroid/database/Cursor;)Landroid/database/Cursor;", "GetSwapCursor_Landroid_database_Cursor_Handler")]
		protected virtual unsafe global::Android.Database.ICursor SwapCursor (global::Android.Database.ICursor p0)
		{
			if (id_swapCursor_Landroid_database_Cursor_ == IntPtr.Zero)
				id_swapCursor_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "swapCursor", "(Landroid/database/Cursor;)Landroid/database/Cursor;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Database.ICursor __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_swapCursor_Landroid_database_Cursor_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "swapCursor", "(Landroid/database/Cursor;)Landroid/database/Cursor;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/adapter/BaseRecyclerViewCursorAdapter", DoNotGenerateAcw=true)]
	internal partial class BaseRecyclerViewCursorAdapterInvoker : BaseRecyclerViewCursorAdapter {

		public BaseRecyclerViewCursorAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseRecyclerViewCursorAdapterInvoker); }
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
