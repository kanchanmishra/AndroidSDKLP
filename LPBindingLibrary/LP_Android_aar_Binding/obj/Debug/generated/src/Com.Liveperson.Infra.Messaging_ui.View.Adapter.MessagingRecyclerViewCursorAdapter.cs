using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.View.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/class[@name='MessagingRecyclerViewCursorAdapter']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/MessagingRecyclerViewCursorAdapter", DoNotGenerateAcw=true)]
	public partial class MessagingRecyclerViewCursorAdapter : global::Com.Liveperson.Infra.UI.View.Adapter.StickyHeaderRecyclerViewCursorAdapter {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/class[@name='MessagingRecyclerViewCursorAdapter']/field[@name='TAG']"
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
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/view/adapter/MessagingRecyclerViewCursorAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessagingRecyclerViewCursorAdapter); }
		}

		protected MessagingRecyclerViewCursorAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_database_Cursor_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/class[@name='MessagingRecyclerViewCursorAdapter']/constructor[@name='MessagingRecyclerViewCursorAdapter' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.database.Cursor']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/database/Cursor;)V", "")]
		public unsafe MessagingRecyclerViewCursorAdapter (global::Android.Content.Context p0, global::Android.Database.ICursor p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MessagingRecyclerViewCursorAdapter)) {
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

		static Delegate cb_getCopyBehavior;
#pragma warning disable 0169
		static Delegate GetGetCopyBehaviorHandler ()
		{
			if (cb_getCopyBehavior == null)
				cb_getCopyBehavior = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCopyBehavior);
			return cb_getCopyBehavior;
		}

		static IntPtr n_GetCopyBehavior (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessagingRecyclerViewCursorAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessagingRecyclerViewCursorAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CopyBehavior);
		}
#pragma warning restore 0169

		static Delegate cb_setCopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_;
#pragma warning disable 0169
		static Delegate GetSetCopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_Handler ()
		{
			if (cb_setCopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_ == null)
				cb_setCopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_);
			return cb_setCopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_;
		}

		static void n_SetCopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessagingRecyclerViewCursorAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessagingRecyclerViewCursorAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CopyBehavior = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCopyBehavior;
		static IntPtr id_setCopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_;
		public virtual unsafe global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior CopyBehavior {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/class[@name='MessagingRecyclerViewCursorAdapter']/method[@name='getCopyBehavior' and count(parameter)=0]"
			[Register ("getCopyBehavior", "()Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior;", "GetGetCopyBehaviorHandler")]
			get {
				if (id_getCopyBehavior == IntPtr.Zero)
					id_getCopyBehavior = JNIEnv.GetMethodID (class_ref, "getCopyBehavior", "()Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCopyBehavior), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCopyBehavior", "()Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/class[@name='MessagingRecyclerViewCursorAdapter']/method[@name='setCopyBehavior' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.messaging_ui.view.adapter.copybehavior.CopyBehavior']]"
			[Register ("setCopyBehavior", "(Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior;)V", "GetSetCopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_Handler")]
			set {
				if (id_setCopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_ == IntPtr.Zero)
					id_setCopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_ = JNIEnv.GetMethodID (class_ref, "setCopyBehavior", "(Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCopyBehavior", "(Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior;)V"), __args);
				} finally {
				}
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
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessagingRecyclerViewCursorAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessagingRecyclerViewCursorAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.ICursor p0 = (global::Android.Database.ICursor)global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ExtractFromCursor (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_extractFromCursor_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/class[@name='MessagingRecyclerViewCursorAdapter']/method[@name='extractFromCursor' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("extractFromCursor", "(Landroid/database/Cursor;)Lcom/liveperson/infra/messaging_ui/view/adapter/ChatMessageRow;", "GetExtractFromCursor_Landroid_database_Cursor_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.ChatMessageRow ExtractFromCursor (global::Android.Database.ICursor p0)
		{
			if (id_extractFromCursor_Landroid_database_Cursor_ == IntPtr.Zero)
				id_extractFromCursor_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "extractFromCursor", "(Landroid/database/Cursor;)Lcom/liveperson/infra/messaging_ui/view/adapter/ChatMessageRow;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.ChatMessageRow __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.ChatMessageRow> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_extractFromCursor_Landroid_database_Cursor_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.ChatMessageRow> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "extractFromCursor", "(Landroid/database/Cursor;)Lcom/liveperson/infra/messaging_ui/view/adapter/ChatMessageRow;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessagingRecyclerViewCursorAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessagingRecyclerViewCursorAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetItemViewType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getItemViewType_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/class[@name='MessagingRecyclerViewCursorAdapter']/method[@name='getItemViewType' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_isLoadingItem_I;
#pragma warning disable 0169
		static Delegate GetIsLoadingItem_IHandler ()
		{
			if (cb_isLoadingItem_I == null)
				cb_isLoadingItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsLoadingItem_I);
			return cb_isLoadingItem_I;
		}

		static bool n_IsLoadingItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessagingRecyclerViewCursorAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessagingRecyclerViewCursorAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLoadingItem (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isLoadingItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/class[@name='MessagingRecyclerViewCursorAdapter']/method[@name='isLoadingItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isLoadingItem", "(I)Z", "GetIsLoadingItem_IHandler")]
		public virtual unsafe bool IsLoadingItem (int p0)
		{
			if (id_isLoadingItem_I == IntPtr.Zero)
				id_isLoadingItem_I = JNIEnv.GetMethodID (class_ref, "isLoadingItem", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLoadingItem_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLoadingItem", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_onAccessibilityEventAvailable_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
#pragma warning disable 0169
		static Delegate GetOnAccessibilityEventAvailable_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Handler ()
		{
			if (cb_onAccessibilityEventAvailable_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ == null)
				cb_onAccessibilityEventAvailable_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAccessibilityEventAvailable_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_);
			return cb_onAccessibilityEventAvailable_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
		}

		static void n_OnAccessibilityEventAvailable_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessagingRecyclerViewCursorAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessagingRecyclerViewCursorAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAccessibilityEventAvailable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onAccessibilityEventAvailable_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/class[@name='MessagingRecyclerViewCursorAdapter']/method[@name='onAccessibilityEventAvailable' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.ui.view.adapter.viewholder.BaseViewHolder']]"
		[Register ("onAccessibilityEventAvailable", "(Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)V", "GetOnAccessibilityEventAvailable_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Handler")]
		public virtual unsafe void OnAccessibilityEventAvailable (global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p0)
		{
			if (id_onAccessibilityEventAvailable_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ == IntPtr.Zero)
				id_onAccessibilityEventAvailable_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ = JNIEnv.GetMethodID (class_ref, "onAccessibilityEventAvailable", "(Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAccessibilityEventAvailable_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAccessibilityEventAvailable", "(Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onBind_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Lcom_liveperson_infra_messaging_ui_view_adapter_ChatMessageRow_II;
#pragma warning disable 0169
		static Delegate GetOnBind_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Lcom_liveperson_infra_messaging_ui_view_adapter_ChatMessageRow_IIHandler ()
		{
			if (cb_onBind_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Lcom_liveperson_infra_messaging_ui_view_adapter_ChatMessageRow_II == null)
				cb_onBind_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Lcom_liveperson_infra_messaging_ui_view_adapter_ChatMessageRow_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_OnBind_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Lcom_liveperson_infra_messaging_ui_view_adapter_ChatMessageRow_II);
			return cb_onBind_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Lcom_liveperson_infra_messaging_ui_view_adapter_ChatMessageRow_II;
		}

		static void n_OnBind_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Lcom_liveperson_infra_messaging_ui_view_adapter_ChatMessageRow_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessagingRecyclerViewCursorAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessagingRecyclerViewCursorAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.ChatMessageRow p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.ChatMessageRow> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnBind (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_onBind_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Lcom_liveperson_infra_messaging_ui_view_adapter_ChatMessageRow_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/class[@name='MessagingRecyclerViewCursorAdapter']/method[@name='onBind' and count(parameter)=4 and parameter[1][@type='com.liveperson.infra.ui.view.adapter.viewholder.BaseViewHolder'] and parameter[2][@type='com.liveperson.infra.messaging_ui.view.adapter.ChatMessageRow'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onBind", "(Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;Lcom/liveperson/infra/messaging_ui/view/adapter/ChatMessageRow;II)V", "GetOnBind_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Lcom_liveperson_infra_messaging_ui_view_adapter_ChatMessageRow_IIHandler")]
		public virtual unsafe void OnBind (global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p0, global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.ChatMessageRow p1, int p2, int p3)
		{
			if (id_onBind_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Lcom_liveperson_infra_messaging_ui_view_adapter_ChatMessageRow_II == IntPtr.Zero)
				id_onBind_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Lcom_liveperson_infra_messaging_ui_view_adapter_ChatMessageRow_II = JNIEnv.GetMethodID (class_ref, "onBind", "(Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;Lcom/liveperson/infra/messaging_ui/view/adapter/ChatMessageRow;II)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBind_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Lcom_liveperson_infra_messaging_ui_view_adapter_ChatMessageRow_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBind", "(Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;Lcom/liveperson/infra/messaging_ui/view/adapter/ChatMessageRow;II)V"), __args);
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
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessagingRecyclerViewCursorAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessagingRecyclerViewCursorAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreate (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onCreate_Landroid_view_ViewGroup_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/class[@name='MessagingRecyclerViewCursorAdapter']/method[@name='onCreate' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
		[Register ("onCreate", "(Landroid/view/ViewGroup;I)Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;", "GetOnCreate_Landroid_view_ViewGroup_IHandler")]
		public virtual unsafe global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder OnCreate (global::Android.Views.ViewGroup p0, int p1)
		{
			if (id_onCreate_Landroid_view_ViewGroup_I == IntPtr.Zero)
				id_onCreate_Landroid_view_ViewGroup_I = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/view/ViewGroup;I)Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onCreate_Landroid_view_ViewGroup_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreate", "(Landroid/view/ViewGroup;I)Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setListener_Lcom_liveperson_infra_messaging_ui_view_adapter_MessagingAdapterListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_liveperson_infra_messaging_ui_view_adapter_MessagingAdapterListener_Handler ()
		{
			if (cb_setListener_Lcom_liveperson_infra_messaging_ui_view_adapter_MessagingAdapterListener_ == null)
				cb_setListener_Lcom_liveperson_infra_messaging_ui_view_adapter_MessagingAdapterListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListener_Lcom_liveperson_infra_messaging_ui_view_adapter_MessagingAdapterListener_);
			return cb_setListener_Lcom_liveperson_infra_messaging_ui_view_adapter_MessagingAdapterListener_;
		}

		static void n_SetListener_Lcom_liveperson_infra_messaging_ui_view_adapter_MessagingAdapterListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessagingRecyclerViewCursorAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessagingRecyclerViewCursorAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.IMessagingAdapterListener p0 = (global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.IMessagingAdapterListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.IMessagingAdapterListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setListener_Lcom_liveperson_infra_messaging_ui_view_adapter_MessagingAdapterListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/class[@name='MessagingRecyclerViewCursorAdapter']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.messaging_ui.view.adapter.MessagingAdapterListener']]"
		[Register ("setListener", "(Lcom/liveperson/infra/messaging_ui/view/adapter/MessagingAdapterListener;)V", "GetSetListener_Lcom_liveperson_infra_messaging_ui_view_adapter_MessagingAdapterListener_Handler")]
		public virtual unsafe void SetListener (global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.IMessagingAdapterListener p0)
		{
			if (id_setListener_Lcom_liveperson_infra_messaging_ui_view_adapter_MessagingAdapterListener_ == IntPtr.Zero)
				id_setListener_Lcom_liveperson_infra_messaging_ui_view_adapter_MessagingAdapterListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcom/liveperson/infra/messaging_ui/view/adapter/MessagingAdapterListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setListener_Lcom_liveperson_infra_messaging_ui_view_adapter_MessagingAdapterListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setListener", "(Lcom/liveperson/infra/messaging_ui/view/adapter/MessagingAdapterListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Liveperson.Infra.Messaging_ui.View.Adapter.IMessagingAdapterListener"

		global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.IMessagingAdapterListenerImplementor __CreateIMessagingAdapterListenerImplementor ()
		{
			return new global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.IMessagingAdapterListenerImplementor (this);
		}
#endregion
	}
}
