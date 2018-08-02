using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents.List {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='ChatMessageListRecyclerView']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/list/ChatMessageListRecyclerView", DoNotGenerateAcw=true)]
	public partial class ChatMessageListRecyclerView : global::Android.Support.V7.Widget.RecyclerView, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.IChatMessageBgFgListener, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IHandlerProvider, global::Com.Liveperson.Infra.UI.View.Uicomponents.IConnectionChangedCustomView {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/list/ChatMessageListRecyclerView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChatMessageListRecyclerView); }
		}

		protected ChatMessageListRecyclerView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='ChatMessageListRecyclerView']/constructor[@name='ChatMessageListRecyclerView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe ChatMessageListRecyclerView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (ChatMessageListRecyclerView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='ChatMessageListRecyclerView']/constructor[@name='ChatMessageListRecyclerView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe ChatMessageListRecyclerView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ChatMessageListRecyclerView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='ChatMessageListRecyclerView']/constructor[@name='ChatMessageListRecyclerView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ChatMessageListRecyclerView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ChatMessageListRecyclerView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.ChatMessageListRecyclerView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.ChatMessageListRecyclerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CopyBehavior);
		}
#pragma warning restore 0169

		static IntPtr id_getCopyBehavior;
		public virtual unsafe global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior CopyBehavior {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='ChatMessageListRecyclerView']/method[@name='getCopyBehavior' and count(parameter)=0]"
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
		}

		static Delegate cb_getView;
#pragma warning disable 0169
		static Delegate GetGetViewHandler ()
		{
			if (cb_getView == null)
				cb_getView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetView);
			return cb_getView;
		}

		static IntPtr n_GetView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.ChatMessageListRecyclerView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.ChatMessageListRecyclerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.View);
		}
#pragma warning restore 0169

		static IntPtr id_getView;
		public virtual unsafe global::Android.Views.View View {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='ChatMessageListRecyclerView']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Landroid/view/View;", "GetGetViewHandler")]
			get {
				if (id_getView == IntPtr.Zero)
					id_getView = JNIEnv.GetMethodID (class_ref, "getView", "()Landroid/view/View;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getView", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_focusLastItem;
#pragma warning disable 0169
		static Delegate GetFocusLastItemHandler ()
		{
			if (cb_focusLastItem == null)
				cb_focusLastItem = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FocusLastItem);
			return cb_focusLastItem;
		}

		static void n_FocusLastItem (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.ChatMessageListRecyclerView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.ChatMessageListRecyclerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FocusLastItem ();
		}
#pragma warning restore 0169

		static IntPtr id_focusLastItem;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='ChatMessageListRecyclerView']/method[@name='focusLastItem' and count(parameter)=0]"
		[Register ("focusLastItem", "()V", "GetFocusLastItemHandler")]
		public virtual unsafe void FocusLastItem ()
		{
			if (id_focusLastItem == IntPtr.Zero)
				id_focusLastItem = JNIEnv.GetMethodID (class_ref, "focusLastItem", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_focusLastItem);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "focusLastItem", "()V"));
			} finally {
			}
		}

		static Delegate cb_initData_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Landroid_view_View_Lcom_liveperson_infra_messaging_ui_uicomponents_IScrollDownIndicator_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_MessagingAdapterListener_;
#pragma warning disable 0169
		static Delegate GetInitData_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Landroid_view_View_Lcom_liveperson_infra_messaging_ui_uicomponents_IScrollDownIndicator_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_MessagingAdapterListener_Handler ()
		{
			if (cb_initData_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Landroid_view_View_Lcom_liveperson_infra_messaging_ui_uicomponents_IScrollDownIndicator_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_MessagingAdapterListener_ == null)
				cb_initData_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Landroid_view_View_Lcom_liveperson_infra_messaging_ui_uicomponents_IScrollDownIndicator_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_MessagingAdapterListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InitData_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Landroid_view_View_Lcom_liveperson_infra_messaging_ui_uicomponents_IScrollDownIndicator_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_MessagingAdapterListener_);
			return cb_initData_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Landroid_view_View_Lcom_liveperson_infra_messaging_ui_uicomponents_IScrollDownIndicator_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_MessagingAdapterListener_;
		}

		static void n_InitData_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Landroid_view_View_Lcom_liveperson_infra_messaging_ui_uicomponents_IScrollDownIndicator_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_MessagingAdapterListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.ChatMessageListRecyclerView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.ChatMessageListRecyclerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Messaging p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p2 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.IScrollDownIndicator p3 = (global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.IScrollDownIndicator)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.IScrollDownIndicator> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior p4 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior> (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.IMessagingAdapterListener p5 = (global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.IMessagingAdapterListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.IMessagingAdapterListener> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.InitData (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_initData_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Landroid_view_View_Lcom_liveperson_infra_messaging_ui_uicomponents_IScrollDownIndicator_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_MessagingAdapterListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='ChatMessageListRecyclerView']/method[@name='initData' and count(parameter)=6 and parameter[1][@type='com.liveperson.messaging.Messaging'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.view.View'] and parameter[4][@type='com.liveperson.infra.messaging_ui.uicomponents.IScrollDownIndicator'] and parameter[5][@type='com.liveperson.infra.messaging_ui.view.adapter.copybehavior.CopyBehavior'] and parameter[6][@type='com.liveperson.infra.messaging_ui.view.adapter.MessagingAdapterListener']]"
		[Register ("initData", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Landroid/view/View;Lcom/liveperson/infra/messaging_ui/uicomponents/IScrollDownIndicator;Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior;Lcom/liveperson/infra/messaging_ui/view/adapter/MessagingAdapterListener;)V", "GetInitData_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Landroid_view_View_Lcom_liveperson_infra_messaging_ui_uicomponents_IScrollDownIndicator_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_MessagingAdapterListener_Handler")]
		public virtual unsafe void InitData (global::Com.Liveperson.Messaging.Messaging p0, string p1, global::Android.Views.View p2, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.IScrollDownIndicator p3, global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior p4, global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.IMessagingAdapterListener p5)
		{
			if (id_initData_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Landroid_view_View_Lcom_liveperson_infra_messaging_ui_uicomponents_IScrollDownIndicator_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_MessagingAdapterListener_ == IntPtr.Zero)
				id_initData_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Landroid_view_View_Lcom_liveperson_infra_messaging_ui_uicomponents_IScrollDownIndicator_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_MessagingAdapterListener_ = JNIEnv.GetMethodID (class_ref, "initData", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Landroid/view/View;Lcom/liveperson/infra/messaging_ui/uicomponents/IScrollDownIndicator;Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior;Lcom/liveperson/infra/messaging_ui/view/adapter/MessagingAdapterListener;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initData_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Landroid_view_View_Lcom_liveperson_infra_messaging_ui_uicomponents_IScrollDownIndicator_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_MessagingAdapterListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initData", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Landroid/view/View;Lcom/liveperson/infra/messaging_ui/uicomponents/IScrollDownIndicator;Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior;Lcom/liveperson/infra/messaging_ui/view/adapter/MessagingAdapterListener;)V"), __args);
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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.ChatMessageListRecyclerView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.ChatMessageListRecyclerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBackground ();
		}
#pragma warning restore 0169

		static IntPtr id_onBackground;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='ChatMessageListRecyclerView']/method[@name='onBackground' and count(parameter)=0]"
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

		static Delegate cb_onConnectionChanged_Z;
#pragma warning disable 0169
		static Delegate GetOnConnectionChanged_ZHandler ()
		{
			if (cb_onConnectionChanged_Z == null)
				cb_onConnectionChanged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnConnectionChanged_Z);
			return cb_onConnectionChanged_Z;
		}

		static void n_OnConnectionChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.ChatMessageListRecyclerView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.ChatMessageListRecyclerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConnectionChanged_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='ChatMessageListRecyclerView']/method[@name='onConnectionChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onConnectionChanged", "(Z)V", "GetOnConnectionChanged_ZHandler")]
		public virtual unsafe void OnConnectionChanged (bool p0)
		{
			if (id_onConnectionChanged_Z == IntPtr.Zero)
				id_onConnectionChanged_Z = JNIEnv.GetMethodID (class_ref, "onConnectionChanged", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionChanged_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnectionChanged", "(Z)V"), __args);
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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.ChatMessageListRecyclerView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.ChatMessageListRecyclerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnForeground ();
		}
#pragma warning restore 0169

		static IntPtr id_onForeground;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='ChatMessageListRecyclerView']/method[@name='onForeground' and count(parameter)=0]"
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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.ChatMessageListRecyclerView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.ChatMessageListRecyclerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveQuickRepliesMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeQuickRepliesMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='ChatMessageListRecyclerView']/method[@name='removeQuickRepliesMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_setAgentIsTyping_ZLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAgentIsTyping_ZLjava_lang_String_Handler ()
		{
			if (cb_setAgentIsTyping_ZLjava_lang_String_ == null)
				cb_setAgentIsTyping_ZLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_SetAgentIsTyping_ZLjava_lang_String_);
			return cb_setAgentIsTyping_ZLjava_lang_String_;
		}

		static void n_SetAgentIsTyping_ZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.ChatMessageListRecyclerView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.ChatMessageListRecyclerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetAgentIsTyping (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setAgentIsTyping_ZLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='ChatMessageListRecyclerView']/method[@name='setAgentIsTyping' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
		[Register ("setAgentIsTyping", "(ZLjava/lang/String;)V", "GetSetAgentIsTyping_ZLjava_lang_String_Handler")]
		public virtual unsafe void SetAgentIsTyping (bool p0, string p1)
		{
			if (id_setAgentIsTyping_ZLjava_lang_String_ == IntPtr.Zero)
				id_setAgentIsTyping_ZLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAgentIsTyping", "(ZLjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAgentIsTyping_ZLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAgentIsTyping", "(ZLjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
