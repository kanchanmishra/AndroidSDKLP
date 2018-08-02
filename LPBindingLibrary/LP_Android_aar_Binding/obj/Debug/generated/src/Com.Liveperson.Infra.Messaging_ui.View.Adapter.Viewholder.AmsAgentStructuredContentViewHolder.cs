using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentStructuredContentViewHolder']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsAgentStructuredContentViewHolder", DoNotGenerateAcw=true)]
	public partial class AmsAgentStructuredContentViewHolder : global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentViewHolder, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor.IStructuredContentContainerOperations, global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.IAmsViewHolder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsAgentStructuredContentViewHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsAgentStructuredContentViewHolder); }
		}

		protected AmsAgentStructuredContentViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentStructuredContentViewHolder']/constructor[@name='AmsAgentStructuredContentViewHolder' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/view/View;Ljava/lang/String;)V", "")]
		public unsafe AmsAgentStructuredContentViewHolder (global::Android.Views.View p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (AmsAgentStructuredContentViewHolder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/view/View;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/view/View;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_view_View_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_view_View_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_view_View_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getLeftPadding;
#pragma warning disable 0169
		static Delegate GetGetLeftPaddingHandler ()
		{
			if (cb_getLeftPadding == null)
				cb_getLeftPadding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLeftPadding);
			return cb_getLeftPadding;
		}

		static int n_GetLeftPadding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentStructuredContentViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentStructuredContentViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeftPadding;
		}
#pragma warning restore 0169

		static IntPtr id_getLeftPadding;
		public virtual unsafe int LeftPadding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentStructuredContentViewHolder']/method[@name='getLeftPadding' and count(parameter)=0]"
			[Register ("getLeftPadding", "()I", "GetGetLeftPaddingHandler")]
			get {
				if (id_getLeftPadding == IntPtr.Zero)
					id_getLeftPadding = JNIEnv.GetMethodID (class_ref, "getLeftPadding", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLeftPadding);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLeftPadding", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_onChangeContainerSize_I;
#pragma warning disable 0169
		static Delegate GetOnChangeContainerSize_IHandler ()
		{
			if (cb_onChangeContainerSize_I == null)
				cb_onChangeContainerSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnChangeContainerSize_I);
			return cb_onChangeContainerSize_I;
		}

		static void n_OnChangeContainerSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentStructuredContentViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentStructuredContentViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnChangeContainerSize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onChangeContainerSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentStructuredContentViewHolder']/method[@name='onChangeContainerSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onChangeContainerSize", "(I)V", "GetOnChangeContainerSize_IHandler")]
		public virtual unsafe void OnChangeContainerSize (int p0)
		{
			if (id_onChangeContainerSize_I == IntPtr.Zero)
				id_onChangeContainerSize_I = JNIEnv.GetMethodID (class_ref, "onChangeContainerSize", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onChangeContainerSize_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onChangeContainerSize", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_;
#pragma warning disable 0169
		static Delegate GetSetRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Handler ()
		{
			if (cb_setRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_ == null)
				cb_setRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_);
			return cb_setRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_;
		}

		static void n_SetRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentStructuredContentViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentStructuredContentViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.OnSCActionClickListener p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.OnSCActionClickListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetRootElement (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentStructuredContentViewHolder']/method[@name='setRootElement' and count(parameter)=2 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.SimpleElement'] and parameter[2][@type='com.liveperson.infra.messaging_ui.uicomponents.list.OnSCActionClickListener']]"
		[Register ("setRootElement", "(Lcom/liveperson/messaging/structuredcontent/model/elements/SimpleElement;Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;)V", "GetSetRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Handler")]
		public virtual unsafe void SetRootElement (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement p0, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.OnSCActionClickListener p1)
		{
			if (id_setRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_ == IntPtr.Zero)
				id_setRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_ = JNIEnv.GetMethodID (class_ref, "setRootElement", "(Lcom/liveperson/messaging/structuredcontent/model/elements/SimpleElement;Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRootElement", "(Lcom/liveperson/messaging/structuredcontent/model/elements/SimpleElement;Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_;
#pragma warning disable 0169
		static Delegate GetSetRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_Handler ()
		{
			if (cb_setRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_ == null)
				cb_setRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_);
			return cb_setRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_;
		}

		static void n_SetRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentStructuredContentViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentStructuredContentViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.OnSCActionClickListener p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.OnSCActionClickListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListener p2 = (global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetRootElement (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentStructuredContentViewHolder']/method[@name='setRootElement' and count(parameter)=3 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.SimpleElement'] and parameter[2][@type='com.liveperson.infra.messaging_ui.uicomponents.list.OnSCActionClickListener'] and parameter[3][@type='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.QRActionClickListener']]"
		[Register ("setRootElement", "(Lcom/liveperson/messaging/structuredcontent/model/elements/SimpleElement;Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/QRActionClickListener;)V", "GetSetRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_Handler")]
		public virtual unsafe void SetRootElement (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement p0, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.OnSCActionClickListener p1, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListener p2)
		{
			if (id_setRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_ == IntPtr.Zero)
				id_setRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_ = JNIEnv.GetMethodID (class_ref, "setRootElement", "(Lcom/liveperson/messaging/structuredcontent/model/elements/SimpleElement;Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/QRActionClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRootElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRootElement", "(Lcom/liveperson/messaging/structuredcontent/model/elements/SimpleElement;Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/QRActionClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_showAvatar_Z;
#pragma warning disable 0169
		static Delegate GetShowAvatar_ZHandler ()
		{
			if (cb_showAvatar_Z == null)
				cb_showAvatar_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ShowAvatar_Z);
			return cb_showAvatar_Z;
		}

		static void n_ShowAvatar_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentStructuredContentViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentStructuredContentViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowAvatar (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showAvatar_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentStructuredContentViewHolder']/method[@name='showAvatar' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showAvatar", "(Z)V", "GetShowAvatar_ZHandler")]
		public virtual unsafe void ShowAvatar (bool p0)
		{
			if (id_showAvatar_Z == IntPtr.Zero)
				id_showAvatar_Z = JNIEnv.GetMethodID (class_ref, "showAvatar", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showAvatar_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showAvatar", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_showTimestamp_Z;
#pragma warning disable 0169
		static Delegate GetShowTimestamp_ZHandler ()
		{
			if (cb_showTimestamp_Z == null)
				cb_showTimestamp_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ShowTimestamp_Z);
			return cb_showTimestamp_Z;
		}

		static void n_ShowTimestamp_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentStructuredContentViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentStructuredContentViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowTimestamp (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showTimestamp_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentStructuredContentViewHolder']/method[@name='showTimestamp' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showTimestamp", "(Z)V", "GetShowTimestamp_ZHandler")]
		public virtual unsafe void ShowTimestamp (bool p0)
		{
			if (id_showTimestamp_Z == IntPtr.Zero)
				id_showTimestamp_Z = JNIEnv.GetMethodID (class_ref, "showTimestamp", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showTimestamp_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showTimestamp", "(Z)V"), __args);
			} finally {
			}
		}

	}
}
