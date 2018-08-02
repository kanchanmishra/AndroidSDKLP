using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Quickreplies {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.quickreplies']/class[@name='QuickRepliesControl']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/structuredcontent/quickreplies/QuickRepliesControl", DoNotGenerateAcw=true)]
	public partial class QuickRepliesControl : global::Android.Widget.ScrollView {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/structuredcontent/quickreplies/QuickRepliesControl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QuickRepliesControl); }
		}

		protected QuickRepliesControl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.quickreplies']/class[@name='QuickRepliesControl']/constructor[@name='QuickRepliesControl' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QuickRepliesControl (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (QuickRepliesControl)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.quickreplies']/class[@name='QuickRepliesControl']/constructor[@name='QuickRepliesControl' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QuickRepliesControl (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (QuickRepliesControl)) {
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

		static Delegate cb_setQuickRepliesElement_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_ILjava_lang_String_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_;
#pragma warning disable 0169
		static Delegate GetSetQuickRepliesElement_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_ILjava_lang_String_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_Handler ()
		{
			if (cb_setQuickRepliesElement_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_ILjava_lang_String_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_ == null)
				cb_setQuickRepliesElement_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_ILjava_lang_String_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_SetQuickRepliesElement_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_ILjava_lang_String_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_);
			return cb_setQuickRepliesElement_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_ILjava_lang_String_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_;
		}

		static void n_SetQuickRepliesElement_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_ILjava_lang_String_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Quickreplies.QuickRepliesControl __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Quickreplies.QuickRepliesControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.QuickRepliesElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.QuickRepliesElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.OnSCActionClickListener p3 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.OnSCActionClickListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListener p4 = (global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListener> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.SetQuickRepliesElement (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_setQuickRepliesElement_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_ILjava_lang_String_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.quickreplies']/class[@name='QuickRepliesControl']/method[@name='setQuickRepliesElement' and count(parameter)=5 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.complex.QuickRepliesElement'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.liveperson.infra.messaging_ui.uicomponents.list.OnSCActionClickListener'] and parameter[5][@type='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.QRActionClickListener']]"
		[Register ("setQuickRepliesElement", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/QuickRepliesElement;ILjava/lang/String;Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/QRActionClickListener;)V", "GetSetQuickRepliesElement_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_ILjava_lang_String_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_Handler")]
		public virtual unsafe void SetQuickRepliesElement (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.QuickRepliesElement p0, int p1, string p2, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.OnSCActionClickListener p3, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListener p4)
		{
			if (id_setQuickRepliesElement_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_ILjava_lang_String_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_ == IntPtr.Zero)
				id_setQuickRepliesElement_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_ILjava_lang_String_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_ = JNIEnv.GetMethodID (class_ref, "setQuickRepliesElement", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/QuickRepliesElement;ILjava/lang/String;Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/QRActionClickListener;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setQuickRepliesElement_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_ILjava_lang_String_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setQuickRepliesElement", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/QuickRepliesElement;ILjava/lang/String;Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/QRActionClickListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
