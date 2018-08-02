using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents.List {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/list/MessagesAsListAdapter", DoNotGenerateAcw=true)]
	public partial class MessagesAsListAdapter : global::Android.Support.V7.Widget.RecyclerView.Adapter, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.IChatMessageBgFgListener, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IOnListUpdated, global::Com.Liveperson.Infra.UI.View.Header.IStickyRecyclerHeadersAdapter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/list/MessagesAsListAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessagesAsListAdapter); }
		}

		protected MessagesAsListAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_infra_messaging_ui_uicomponents_list_ChatMessageListRecyclerView_Landroid_view_View_Lcom_liveperson_infra_messaging_ui_uicomponents_IScrollDownIndicator_Lcom_liveperson_messaging_model_AmsMessagesLoaderProvider_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/constructor[@name='MessagesAsListAdapter' and count(parameter)=5 and parameter[1][@type='com.liveperson.infra.messaging_ui.uicomponents.list.ChatMessageListRecyclerView'] and parameter[2][@type='android.view.View'] and parameter[3][@type='com.liveperson.infra.messaging_ui.uicomponents.IScrollDownIndicator'] and parameter[4][@type='com.liveperson.messaging.model.AmsMessagesLoaderProvider'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/liveperson/infra/messaging_ui/uicomponents/list/ChatMessageListRecyclerView;Landroid/view/View;Lcom/liveperson/infra/messaging_ui/uicomponents/IScrollDownIndicator;Lcom/liveperson/messaging/model/AmsMessagesLoaderProvider;Ljava/lang/String;)V", "")]
		public unsafe MessagesAsListAdapter (global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.ChatMessageListRecyclerView p0, global::Android.Views.View p1, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.IScrollDownIndicator p2, global::Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProvider p3, string p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				if (((object) this).GetType () != typeof (MessagesAsListAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/infra/messaging_ui/uicomponents/list/ChatMessageListRecyclerView;Landroid/view/View;Lcom/liveperson/infra/messaging_ui/uicomponents/IScrollDownIndicator;Lcom/liveperson/messaging/model/AmsMessagesLoaderProvider;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/infra/messaging_ui/uicomponents/list/ChatMessageListRecyclerView;Landroid/view/View;Lcom/liveperson/infra/messaging_ui/uicomponents/IScrollDownIndicator;Lcom/liveperson/messaging/model/AmsMessagesLoaderProvider;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_infra_messaging_ui_uicomponents_list_ChatMessageListRecyclerView_Landroid_view_View_Lcom_liveperson_infra_messaging_ui_uicomponents_IScrollDownIndicator_Lcom_liveperson_messaging_model_AmsMessagesLoaderProvider_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_infra_messaging_ui_uicomponents_list_ChatMessageListRecyclerView_Landroid_view_View_Lcom_liveperson_infra_messaging_ui_uicomponents_IScrollDownIndicator_Lcom_liveperson_messaging_model_AmsMessagesLoaderProvider_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/messaging_ui/uicomponents/list/ChatMessageListRecyclerView;Landroid/view/View;Lcom/liveperson/infra/messaging_ui/uicomponents/IScrollDownIndicator;Lcom/liveperson/messaging/model/AmsMessagesLoaderProvider;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_messaging_ui_uicomponents_list_ChatMessageListRecyclerView_Landroid_view_View_Lcom_liveperson_infra_messaging_ui_uicomponents_IScrollDownIndicator_Lcom_liveperson_messaging_model_AmsMessagesLoaderProvider_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_messaging_ui_uicomponents_list_ChatMessageListRecyclerView_Landroid_view_View_Lcom_liveperson_infra_messaging_ui_uicomponents_IScrollDownIndicator_Lcom_liveperson_messaging_model_AmsMessagesLoaderProvider_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CopyBehavior = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCopyBehavior;
		static IntPtr id_setCopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_;
		public virtual unsafe global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior CopyBehavior {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='getCopyBehavior' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='setCopyBehavior' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.messaging_ui.view.adapter.copybehavior.CopyBehavior']]"
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

		static Delegate cb_getFirstVisibleItemPosition;
#pragma warning disable 0169
		static Delegate GetGetFirstVisibleItemPositionHandler ()
		{
			if (cb_getFirstVisibleItemPosition == null)
				cb_getFirstVisibleItemPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFirstVisibleItemPosition);
			return cb_getFirstVisibleItemPosition;
		}

		static int n_GetFirstVisibleItemPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FirstVisibleItemPosition;
		}
#pragma warning restore 0169

		static IntPtr id_getFirstVisibleItemPosition;
		public virtual unsafe int FirstVisibleItemPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='getFirstVisibleItemPosition' and count(parameter)=0]"
			[Register ("getFirstVisibleItemPosition", "()I", "GetGetFirstVisibleItemPositionHandler")]
			get {
				if (id_getFirstVisibleItemPosition == IntPtr.Zero)
					id_getFirstVisibleItemPosition = JNIEnv.GetMethodID (class_ref, "getFirstVisibleItemPosition", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFirstVisibleItemPosition);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirstVisibleItemPosition", "()I"));
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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemCount;
		}
#pragma warning restore 0169

		static IntPtr id_getItemCount;
		public override unsafe int ItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='getItemCount' and count(parameter)=0]"
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

		static Delegate cb_getLastVisibleItemPosition;
#pragma warning disable 0169
		static Delegate GetGetLastVisibleItemPositionHandler ()
		{
			if (cb_getLastVisibleItemPosition == null)
				cb_getLastVisibleItemPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLastVisibleItemPosition);
			return cb_getLastVisibleItemPosition;
		}

		static int n_GetLastVisibleItemPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastVisibleItemPosition;
		}
#pragma warning restore 0169

		static IntPtr id_getLastVisibleItemPosition;
		public virtual unsafe int LastVisibleItemPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='getLastVisibleItemPosition' and count(parameter)=0]"
			[Register ("getLastVisibleItemPosition", "()I", "GetGetLastVisibleItemPositionHandler")]
			get {
				if (id_getLastVisibleItemPosition == IntPtr.Zero)
					id_getLastVisibleItemPosition = JNIEnv.GetMethodID (class_ref, "getLastVisibleItemPosition", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLastVisibleItemPosition);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastVisibleItemPosition", "()I"));
				} finally {
				}
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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHeaderId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getHeaderId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='getHeaderId' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_getItem_I;
#pragma warning disable 0169
		static Delegate GetGetItem_IHandler ()
		{
			if (cb_getItem_I == null)
				cb_getItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetItem_I);
			return cb_getItem_I;
		}

		static IntPtr n_GetItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetItem (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItem", "(I)Lcom/liveperson/messaging/model/FullMessageRow;", "GetGetItem_IHandler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Model.FullMessageRow GetItem (int p0)
		{
			if (id_getItem_I == IntPtr.Zero)
				id_getItem_I = JNIEnv.GetMethodID (class_ref, "getItem", "(I)Lcom/liveperson/messaging/model/FullMessageRow;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FullMessageRow> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getItem_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FullMessageRow> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItem", "(I)Lcom/liveperson/messaging/model/FullMessageRow;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hideAgentIsTyping;
#pragma warning disable 0169
		static Delegate GetHideAgentIsTypingHandler ()
		{
			if (cb_hideAgentIsTyping == null)
				cb_hideAgentIsTyping = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HideAgentIsTyping);
			return cb_hideAgentIsTyping;
		}

		static void n_HideAgentIsTyping (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideAgentIsTyping ();
		}
#pragma warning restore 0169

		static IntPtr id_hideAgentIsTyping;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='hideAgentIsTyping' and count(parameter)=0]"
		[Register ("hideAgentIsTyping", "()V", "GetHideAgentIsTypingHandler")]
		public virtual unsafe void HideAgentIsTyping ()
		{
			if (id_hideAgentIsTyping == IntPtr.Zero)
				id_hideAgentIsTyping = JNIEnv.GetMethodID (class_ref, "hideAgentIsTyping", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hideAgentIsTyping);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hideAgentIsTyping", "()V"));
			} finally {
			}
		}

		static Delegate cb_notifyUnreadMessagesChanged_ILjava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetNotifyUnreadMessagesChanged_ILjava_lang_String_IHandler ()
		{
			if (cb_notifyUnreadMessagesChanged_ILjava_lang_String_I == null)
				cb_notifyUnreadMessagesChanged_ILjava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, int>) n_NotifyUnreadMessagesChanged_ILjava_lang_String_I);
			return cb_notifyUnreadMessagesChanged_ILjava_lang_String_I;
		}

		static void n_NotifyUnreadMessagesChanged_ILjava_lang_String_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.NotifyUnreadMessagesChanged (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_notifyUnreadMessagesChanged_ILjava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='notifyUnreadMessagesChanged' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("notifyUnreadMessagesChanged", "(ILjava/lang/String;I)V", "GetNotifyUnreadMessagesChanged_ILjava_lang_String_IHandler")]
		public virtual unsafe void NotifyUnreadMessagesChanged (int p0, string p1, int p2)
		{
			if (id_notifyUnreadMessagesChanged_ILjava_lang_String_I == IntPtr.Zero)
				id_notifyUnreadMessagesChanged_ILjava_lang_String_I = JNIEnv.GetMethodID (class_ref, "notifyUnreadMessagesChanged", "(ILjava/lang/String;I)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyUnreadMessagesChanged_ILjava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyUnreadMessagesChanged", "(ILjava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_onBackground;
#pragma warning disable 0169
		static Delegate GetOnBackgroundHandler ()
		{
			if (cb_onBackground == null)
				cb_onBackground = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBackground);
			return cb_onBackground;
		}

		static void n_OnBackground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBackground ();
		}
#pragma warning restore 0169

		static IntPtr id_onBackground;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='onBackground' and count(parameter)=0]"
		[Register ("onBackground", "()V", "GetOnBackgroundHandler")]
		public virtual unsafe void OnBackground ()
		{
			if (id_onBackground == IntPtr.Zero)
				id_onBackground = JNIEnv.GetMethodID (class_ref, "onBackground", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBackground);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBackground", "()V"));
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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBindHeaderViewHolder (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onBindHeaderViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='onBindHeaderViewHolder' and count(parameter)=2 and parameter[1][@type='com.liveperson.infra.ui.view.adapter.viewholder.BaseViewHolder'] and parameter[2][@type='int']]"
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

		static Delegate cb_onBindViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_I;
#pragma warning disable 0169
		static Delegate GetOnBindViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_IHandler ()
		{
			if (cb_onBindViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_I == null)
				cb_onBindViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnBindViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_I);
			return cb_onBindViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_I;
		}

		static void n_OnBindViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBindViewHolder (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onBindViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='onBindViewHolder' and count(parameter)=2 and parameter[1][@type='com.liveperson.infra.ui.view.adapter.viewholder.BaseViewHolder'] and parameter[2][@type='int']]"
		[Register ("onBindViewHolder", "(Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;I)V", "GetOnBindViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_IHandler")]
		public virtual unsafe void OnBindViewHolder (global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p0, int p1)
		{
			if (id_onBindViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_I == IntPtr.Zero)
				id_onBindViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_I = JNIEnv.GetMethodID (class_ref, "onBindViewHolder", "(Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBindViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBindViewHolder", "(Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onBindViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ILjava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnBindViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ILjava_util_List_Handler ()
		{
			if (cb_onBindViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ILjava_util_List_ == null)
				cb_onBindViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ILjava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnBindViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ILjava_util_List_);
			return cb_onBindViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ILjava_util_List_;
		}

		static void n_OnBindViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ILjava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::Java.Lang.Object>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnBindViewHolder (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onBindViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ILjava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='onBindViewHolder' and count(parameter)=3 and parameter[1][@type='com.liveperson.infra.ui.view.adapter.viewholder.BaseViewHolder'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;java.lang.Object&gt;']]"
		[Register ("onBindViewHolder", "(Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;ILjava/util/List;)V", "GetOnBindViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ILjava_util_List_Handler")]
		public virtual unsafe void OnBindViewHolder (global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p0, int p1, global::System.Collections.Generic.IList<global::Java.Lang.Object> p2)
		{
			if (id_onBindViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ILjava_util_List_ == IntPtr.Zero)
				id_onBindViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ILjava_util_List_ = JNIEnv.GetMethodID (class_ref, "onBindViewHolder", "(Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;ILjava/util/List;)V");
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Java.Lang.Object>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBindViewHolder_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ILjava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBindViewHolder", "(Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;ILjava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_onClearAllMessages_II;
#pragma warning disable 0169
		static Delegate GetOnClearAllMessages_IIHandler ()
		{
			if (cb_onClearAllMessages_II == null)
				cb_onClearAllMessages_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnClearAllMessages_II);
			return cb_onClearAllMessages_II;
		}

		static void n_OnClearAllMessages_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnClearAllMessages (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onClearAllMessages_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='onClearAllMessages' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onClearAllMessages", "(II)V", "GetOnClearAllMessages_IIHandler")]
		public virtual unsafe void OnClearAllMessages (int p0, int p1)
		{
			if (id_onClearAllMessages_II == IntPtr.Zero)
				id_onClearAllMessages_II = JNIEnv.GetMethodID (class_ref, "onClearAllMessages", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClearAllMessages_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onClearAllMessages", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onConnectionAvailable;
#pragma warning disable 0169
		static Delegate GetOnConnectionAvailableHandler ()
		{
			if (cb_onConnectionAvailable == null)
				cb_onConnectionAvailable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnConnectionAvailable);
			return cb_onConnectionAvailable;
		}

		static void n_OnConnectionAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionAvailable ();
		}
#pragma warning restore 0169

		static IntPtr id_onConnectionAvailable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='onConnectionAvailable' and count(parameter)=0]"
		[Register ("onConnectionAvailable", "()V", "GetOnConnectionAvailableHandler")]
		public virtual unsafe void OnConnectionAvailable ()
		{
			if (id_onConnectionAvailable == IntPtr.Zero)
				id_onConnectionAvailable = JNIEnv.GetMethodID (class_ref, "onConnectionAvailable", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionAvailable);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnectionAvailable", "()V"));
			} finally {
			}
		}

		static Delegate cb_onConnectionLost;
#pragma warning disable 0169
		static Delegate GetOnConnectionLostHandler ()
		{
			if (cb_onConnectionLost == null)
				cb_onConnectionLost = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnConnectionLost);
			return cb_onConnectionLost;
		}

		static void n_OnConnectionLost (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionLost ();
		}
#pragma warning restore 0169

		static IntPtr id_onConnectionLost;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='onConnectionLost' and count(parameter)=0]"
		[Register ("onConnectionLost", "()V", "GetOnConnectionLostHandler")]
		public virtual unsafe void OnConnectionLost ()
		{
			if (id_onConnectionLost == IntPtr.Zero)
				id_onConnectionLost = JNIEnv.GetMethodID (class_ref, "onConnectionLost", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionLost);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnectionLost", "()V"));
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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateHeaderViewHolder (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onCreateHeaderViewHolder_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='onCreateHeaderViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
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

		static Delegate cb_onCreateViewHolder_Landroid_view_ViewGroup_I;
#pragma warning disable 0169
		static Delegate GetOnCreateViewHolder_Landroid_view_ViewGroup_IHandler ()
		{
			if (cb_onCreateViewHolder_Landroid_view_ViewGroup_I == null)
				cb_onCreateViewHolder_Landroid_view_ViewGroup_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnCreateViewHolder_Landroid_view_ViewGroup_I);
			return cb_onCreateViewHolder_Landroid_view_ViewGroup_I;
		}

		static IntPtr n_OnCreateViewHolder_Landroid_view_ViewGroup_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateViewHolder (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onCreateViewHolder_Landroid_view_ViewGroup_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='onCreateViewHolder' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
		[Register ("onCreateViewHolder", "(Landroid/view/ViewGroup;I)Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;", "GetOnCreateViewHolder_Landroid_view_ViewGroup_IHandler")]
		public override unsafe global::Android.Support.V7.Widget.RecyclerView.ViewHolder OnCreateViewHolder (global::Android.Views.ViewGroup p0, int p1)
		{
			if (id_onCreateViewHolder_Landroid_view_ViewGroup_I == IntPtr.Zero)
				id_onCreateViewHolder_Landroid_view_ViewGroup_I = JNIEnv.GetMethodID (class_ref, "onCreateViewHolder", "(Landroid/view/ViewGroup;I)Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Android.Support.V7.Widget.RecyclerView.ViewHolder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onCreateViewHolder_Landroid_view_ViewGroup_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreateViewHolder", "(Landroid/view/ViewGroup;I)Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onForeground;
#pragma warning disable 0169
		static Delegate GetOnForegroundHandler ()
		{
			if (cb_onForeground == null)
				cb_onForeground = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnForeground);
			return cb_onForeground;
		}

		static void n_OnForeground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnForeground ();
		}
#pragma warning restore 0169

		static IntPtr id_onForeground;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='onForeground' and count(parameter)=0]"
		[Register ("onForeground", "()V", "GetOnForegroundHandler")]
		public virtual unsafe void OnForeground ()
		{
			if (id_onForeground == IntPtr.Zero)
				id_onForeground = JNIEnv.GetMethodID (class_ref, "onForeground", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onForeground);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onForeground", "()V"));
			} finally {
			}
		}

		static Delegate cb_onHistoryLoaded_IIZ;
#pragma warning disable 0169
		static Delegate GetOnHistoryLoaded_IIZHandler ()
		{
			if (cb_onHistoryLoaded_IIZ == null)
				cb_onHistoryLoaded_IIZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, bool>) n_OnHistoryLoaded_IIZ);
			return cb_onHistoryLoaded_IIZ;
		}

		static void n_OnHistoryLoaded_IIZ (IntPtr jnienv, IntPtr native__this, int p0, int p1, bool p2)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnHistoryLoaded (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onHistoryLoaded_IIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='onHistoryLoaded' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("onHistoryLoaded", "(IIZ)V", "GetOnHistoryLoaded_IIZHandler")]
		public virtual unsafe void OnHistoryLoaded (int p0, int p1, bool p2)
		{
			if (id_onHistoryLoaded_IIZ == IntPtr.Zero)
				id_onHistoryLoaded_IIZ = JNIEnv.GetMethodID (class_ref, "onHistoryLoaded", "(IIZ)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHistoryLoaded_IIZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onHistoryLoaded", "(IIZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onItemMoved_II;
#pragma warning disable 0169
		static Delegate GetOnItemMoved_IIHandler ()
		{
			if (cb_onItemMoved_II == null)
				cb_onItemMoved_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnItemMoved_II);
			return cb_onItemMoved_II;
		}

		static void n_OnItemMoved_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnItemMoved (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onItemMoved_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='onItemMoved' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onItemMoved", "(II)V", "GetOnItemMoved_IIHandler")]
		public virtual unsafe void OnItemMoved (int p0, int p1)
		{
			if (id_onItemMoved_II == IntPtr.Zero)
				id_onItemMoved_II = JNIEnv.GetMethodID (class_ref, "onItemMoved", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onItemMoved_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onItemMoved", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onItemRemoved_I;
#pragma warning disable 0169
		static Delegate GetOnItemRemoved_IHandler ()
		{
			if (cb_onItemRemoved_I == null)
				cb_onItemRemoved_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnItemRemoved_I);
			return cb_onItemRemoved_I;
		}

		static void n_OnItemRemoved_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnItemRemoved (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onItemRemoved_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='onItemRemoved' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onItemRemoved", "(I)V", "GetOnItemRemoved_IHandler")]
		public virtual unsafe void OnItemRemoved (int p0)
		{
			if (id_onItemRemoved_I == IntPtr.Zero)
				id_onItemRemoved_I = JNIEnv.GetMethodID (class_ref, "onItemRemoved", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onItemRemoved_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onItemRemoved", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onMessageUpdated_ILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnMessageUpdated_ILandroid_os_Bundle_Handler ()
		{
			if (cb_onMessageUpdated_ILandroid_os_Bundle_ == null)
				cb_onMessageUpdated_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnMessageUpdated_ILandroid_os_Bundle_);
			return cb_onMessageUpdated_ILandroid_os_Bundle_;
		}

		static void n_OnMessageUpdated_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnMessageUpdated (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onMessageUpdated_ILandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='onMessageUpdated' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onMessageUpdated", "(ILandroid/os/Bundle;)V", "GetOnMessageUpdated_ILandroid_os_Bundle_Handler")]
		public virtual unsafe void OnMessageUpdated (int p0, global::Android.OS.Bundle p1)
		{
			if (id_onMessageUpdated_ILandroid_os_Bundle_ == IntPtr.Zero)
				id_onMessageUpdated_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onMessageUpdated", "(ILandroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMessageUpdated_ILandroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMessageUpdated", "(ILandroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onNewAgentMessageReceived_ILcom_liveperson_messaging_model_FullMessageRow_;
#pragma warning disable 0169
		static Delegate GetOnNewAgentMessageReceived_ILcom_liveperson_messaging_model_FullMessageRow_Handler ()
		{
			if (cb_onNewAgentMessageReceived_ILcom_liveperson_messaging_model_FullMessageRow_ == null)
				cb_onNewAgentMessageReceived_ILcom_liveperson_messaging_model_FullMessageRow_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnNewAgentMessageReceived_ILcom_liveperson_messaging_model_FullMessageRow_);
			return cb_onNewAgentMessageReceived_ILcom_liveperson_messaging_model_FullMessageRow_;
		}

		static void n_OnNewAgentMessageReceived_ILcom_liveperson_messaging_model_FullMessageRow_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.FullMessageRow p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FullMessageRow> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnNewAgentMessageReceived (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onNewAgentMessageReceived_ILcom_liveperson_messaging_model_FullMessageRow_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='onNewAgentMessageReceived' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.liveperson.messaging.model.FullMessageRow']]"
		[Register ("onNewAgentMessageReceived", "(ILcom/liveperson/messaging/model/FullMessageRow;)V", "GetOnNewAgentMessageReceived_ILcom_liveperson_messaging_model_FullMessageRow_Handler")]
		public virtual unsafe void OnNewAgentMessageReceived (int p0, global::Com.Liveperson.Messaging.Model.FullMessageRow p1)
		{
			if (id_onNewAgentMessageReceived_ILcom_liveperson_messaging_model_FullMessageRow_ == IntPtr.Zero)
				id_onNewAgentMessageReceived_ILcom_liveperson_messaging_model_FullMessageRow_ = JNIEnv.GetMethodID (class_ref, "onNewAgentMessageReceived", "(ILcom/liveperson/messaging/model/FullMessageRow;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNewAgentMessageReceived_ILcom_liveperson_messaging_model_FullMessageRow_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNewAgentMessageReceived", "(ILcom/liveperson/messaging/model/FullMessageRow;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onNewAgentMessagesLoaded_II;
#pragma warning disable 0169
		static Delegate GetOnNewAgentMessagesLoaded_IIHandler ()
		{
			if (cb_onNewAgentMessagesLoaded_II == null)
				cb_onNewAgentMessagesLoaded_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnNewAgentMessagesLoaded_II);
			return cb_onNewAgentMessagesLoaded_II;
		}

		static void n_OnNewAgentMessagesLoaded_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNewAgentMessagesLoaded (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onNewAgentMessagesLoaded_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='onNewAgentMessagesLoaded' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onNewAgentMessagesLoaded", "(II)V", "GetOnNewAgentMessagesLoaded_IIHandler")]
		public virtual unsafe void OnNewAgentMessagesLoaded (int p0, int p1)
		{
			if (id_onNewAgentMessagesLoaded_II == IntPtr.Zero)
				id_onNewAgentMessagesLoaded_II = JNIEnv.GetMethodID (class_ref, "onNewAgentMessagesLoaded", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNewAgentMessagesLoaded_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNewAgentMessagesLoaded", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onNewMessagesLoaded_III;
#pragma warning disable 0169
		static Delegate GetOnNewMessagesLoaded_IIIHandler ()
		{
			if (cb_onNewMessagesLoaded_III == null)
				cb_onNewMessagesLoaded_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_OnNewMessagesLoaded_III);
			return cb_onNewMessagesLoaded_III;
		}

		static void n_OnNewMessagesLoaded_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNewMessagesLoaded (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onNewMessagesLoaded_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='onNewMessagesLoaded' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onNewMessagesLoaded", "(III)V", "GetOnNewMessagesLoaded_IIIHandler")]
		public virtual unsafe void OnNewMessagesLoaded (int p0, int p1, int p2)
		{
			if (id_onNewMessagesLoaded_III == IntPtr.Zero)
				id_onNewMessagesLoaded_III = JNIEnv.GetMethodID (class_ref, "onNewMessagesLoaded", "(III)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNewMessagesLoaded_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNewMessagesLoaded", "(III)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onNewSystemMessageAdded_ILcom_liveperson_messaging_model_FullMessageRow_;
#pragma warning disable 0169
		static Delegate GetOnNewSystemMessageAdded_ILcom_liveperson_messaging_model_FullMessageRow_Handler ()
		{
			if (cb_onNewSystemMessageAdded_ILcom_liveperson_messaging_model_FullMessageRow_ == null)
				cb_onNewSystemMessageAdded_ILcom_liveperson_messaging_model_FullMessageRow_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnNewSystemMessageAdded_ILcom_liveperson_messaging_model_FullMessageRow_);
			return cb_onNewSystemMessageAdded_ILcom_liveperson_messaging_model_FullMessageRow_;
		}

		static void n_OnNewSystemMessageAdded_ILcom_liveperson_messaging_model_FullMessageRow_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.FullMessageRow p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FullMessageRow> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnNewSystemMessageAdded (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onNewSystemMessageAdded_ILcom_liveperson_messaging_model_FullMessageRow_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='onNewSystemMessageAdded' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.liveperson.messaging.model.FullMessageRow']]"
		[Register ("onNewSystemMessageAdded", "(ILcom/liveperson/messaging/model/FullMessageRow;)V", "GetOnNewSystemMessageAdded_ILcom_liveperson_messaging_model_FullMessageRow_Handler")]
		public virtual unsafe void OnNewSystemMessageAdded (int p0, global::Com.Liveperson.Messaging.Model.FullMessageRow p1)
		{
			if (id_onNewSystemMessageAdded_ILcom_liveperson_messaging_model_FullMessageRow_ == IntPtr.Zero)
				id_onNewSystemMessageAdded_ILcom_liveperson_messaging_model_FullMessageRow_ = JNIEnv.GetMethodID (class_ref, "onNewSystemMessageAdded", "(ILcom/liveperson/messaging/model/FullMessageRow;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNewSystemMessageAdded_ILcom_liveperson_messaging_model_FullMessageRow_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNewSystemMessageAdded", "(ILcom/liveperson/messaging/model/FullMessageRow;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onNewUnreadMessages_I;
#pragma warning disable 0169
		static Delegate GetOnNewUnreadMessages_IHandler ()
		{
			if (cb_onNewUnreadMessages_I == null)
				cb_onNewUnreadMessages_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnNewUnreadMessages_I);
			return cb_onNewUnreadMessages_I;
		}

		static void n_OnNewUnreadMessages_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNewUnreadMessages (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onNewUnreadMessages_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='onNewUnreadMessages' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onNewUnreadMessages", "(I)V", "GetOnNewUnreadMessages_IHandler")]
		public virtual unsafe void OnNewUnreadMessages (int p0)
		{
			if (id_onNewUnreadMessages_I == IntPtr.Zero)
				id_onNewUnreadMessages_I = JNIEnv.GetMethodID (class_ref, "onNewUnreadMessages", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNewUnreadMessages_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNewUnreadMessages", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onNewUserMessageAdded_I;
#pragma warning disable 0169
		static Delegate GetOnNewUserMessageAdded_IHandler ()
		{
			if (cb_onNewUserMessageAdded_I == null)
				cb_onNewUserMessageAdded_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnNewUserMessageAdded_I);
			return cb_onNewUserMessageAdded_I;
		}

		static void n_OnNewUserMessageAdded_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNewUserMessageAdded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onNewUserMessageAdded_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='onNewUserMessageAdded' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onNewUserMessageAdded", "(I)V", "GetOnNewUserMessageAdded_IHandler")]
		public virtual unsafe void OnNewUserMessageAdded (int p0)
		{
			if (id_onNewUserMessageAdded_I == IntPtr.Zero)
				id_onNewUserMessageAdded_I = JNIEnv.GetMethodID (class_ref, "onNewUserMessageAdded", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNewUserMessageAdded_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNewUserMessageAdded", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onViewRecycled_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
#pragma warning disable 0169
		static Delegate GetOnViewRecycled_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Handler ()
		{
			if (cb_onViewRecycled_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ == null)
				cb_onViewRecycled_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnViewRecycled_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_);
			return cb_onViewRecycled_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
		}

		static void n_OnViewRecycled_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnViewRecycled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onViewRecycled_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='onViewRecycled' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.ui.view.adapter.viewholder.BaseViewHolder']]"
		[Register ("onViewRecycled", "(Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)V", "GetOnViewRecycled_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_Handler")]
		public virtual unsafe void OnViewRecycled (global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder p0)
		{
			if (id_onViewRecycled_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ == IntPtr.Zero)
				id_onViewRecycled_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_ = JNIEnv.GetMethodID (class_ref, "onViewRecycled", "(Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onViewRecycled_Lcom_liveperson_infra_ui_view_adapter_viewholder_BaseViewHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onViewRecycled", "(Lcom/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeQuickRepliesMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveQuickRepliesMessage_Ljava_lang_String_Handler ()
		{
			if (cb_removeQuickRepliesMessage_Ljava_lang_String_ == null)
				cb_removeQuickRepliesMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveQuickRepliesMessage_Ljava_lang_String_);
			return cb_removeQuickRepliesMessage_Ljava_lang_String_;
		}

		static void n_RemoveQuickRepliesMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveQuickRepliesMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeQuickRepliesMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='removeQuickRepliesMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeQuickRepliesMessage", "(Ljava/lang/String;)V", "GetRemoveQuickRepliesMessage_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveQuickRepliesMessage (string p0)
		{
			if (id_removeQuickRepliesMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_removeQuickRepliesMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeQuickRepliesMessage", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeQuickRepliesMessage_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeQuickRepliesMessage", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.IMessagingAdapterListener p0 = (global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.IMessagingAdapterListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.IMessagingAdapterListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setListener_Lcom_liveperson_infra_messaging_ui_view_adapter_MessagingAdapterListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.messaging_ui.view.adapter.MessagingAdapterListener']]"
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

		static Delegate cb_showAgentIsTyping_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShowAgentIsTyping_Ljava_lang_String_Handler ()
		{
			if (cb_showAgentIsTyping_Ljava_lang_String_ == null)
				cb_showAgentIsTyping_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowAgentIsTyping_Ljava_lang_String_);
			return cb_showAgentIsTyping_Ljava_lang_String_;
		}

		static void n_ShowAgentIsTyping_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShowAgentIsTyping (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showAgentIsTyping_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListAdapter']/method[@name='showAgentIsTyping' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("showAgentIsTyping", "(Ljava/lang/String;)V", "GetShowAgentIsTyping_Ljava_lang_String_Handler")]
		public virtual unsafe void ShowAgentIsTyping (string p0)
		{
			if (id_showAgentIsTyping_Ljava_lang_String_ == IntPtr.Zero)
				id_showAgentIsTyping_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "showAgentIsTyping", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showAgentIsTyping_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showAgentIsTyping", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

#region "Event implementation for Com.Liveperson.Infra.Messaging_ui.View.Adapter.IMessagingAdapterListener"

		global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.IMessagingAdapterListenerImplementor __CreateIMessagingAdapterListenerImplementor ()
		{
			return new global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.IMessagingAdapterListenerImplementor (this);
		}
#endregion
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
}
