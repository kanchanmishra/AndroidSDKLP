using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent']/class[@name='TouchyWebView']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/structuredcontent/TouchyWebView", DoNotGenerateAcw=true)]
	public partial class TouchyWebView : global::Android.Webkit.WebView {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/structuredcontent/TouchyWebView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TouchyWebView); }
		}

		protected TouchyWebView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent']/class[@name='TouchyWebView']/constructor[@name='TouchyWebView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe TouchyWebView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (TouchyWebView)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent']/class[@name='TouchyWebView']/constructor[@name='TouchyWebView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe TouchyWebView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (TouchyWebView)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent']/class[@name='TouchyWebView']/constructor[@name='TouchyWebView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe TouchyWebView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (TouchyWebView)) {
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

		static Delegate cb_setWebViewOnClickListener_Landroid_content_Context_Ljava_lang_String_Lcom_liveperson_messaging_structuredcontent_model_actions_BaseAction_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_;
#pragma warning disable 0169
		static Delegate GetSetWebViewOnClickListener_Landroid_content_Context_Ljava_lang_String_Lcom_liveperson_messaging_structuredcontent_model_actions_BaseAction_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Handler ()
		{
			if (cb_setWebViewOnClickListener_Landroid_content_Context_Ljava_lang_String_Lcom_liveperson_messaging_structuredcontent_model_actions_BaseAction_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_ == null)
				cb_setWebViewOnClickListener_Landroid_content_Context_Ljava_lang_String_Lcom_liveperson_messaging_structuredcontent_model_actions_BaseAction_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetWebViewOnClickListener_Landroid_content_Context_Ljava_lang_String_Lcom_liveperson_messaging_structuredcontent_model_actions_BaseAction_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_);
			return cb_setWebViewOnClickListener_Landroid_content_Context_Ljava_lang_String_Lcom_liveperson_messaging_structuredcontent_model_actions_BaseAction_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_;
		}

		static void n_SetWebViewOnClickListener_Landroid_content_Context_Ljava_lang_String_Lcom_liveperson_messaging_structuredcontent_model_actions_BaseAction_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.TouchyWebView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.TouchyWebView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.BaseAction p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.BaseAction> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.OnSCActionClickListener p3 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.OnSCActionClickListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SetWebViewOnClickListener (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_setWebViewOnClickListener_Landroid_content_Context_Ljava_lang_String_Lcom_liveperson_messaging_structuredcontent_model_actions_BaseAction_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent']/class[@name='TouchyWebView']/method[@name='setWebViewOnClickListener' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.messaging.structuredcontent.model.actions.BaseAction'] and parameter[4][@type='com.liveperson.infra.messaging_ui.uicomponents.list.OnSCActionClickListener']]"
		[Register ("setWebViewOnClickListener", "(Landroid/content/Context;Ljava/lang/String;Lcom/liveperson/messaging/structuredcontent/model/actions/BaseAction;Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;)V", "GetSetWebViewOnClickListener_Landroid_content_Context_Ljava_lang_String_Lcom_liveperson_messaging_structuredcontent_model_actions_BaseAction_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Handler")]
		public virtual unsafe void SetWebViewOnClickListener (global::Android.Content.Context p0, string p1, global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.BaseAction p2, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.OnSCActionClickListener p3)
		{
			if (id_setWebViewOnClickListener_Landroid_content_Context_Ljava_lang_String_Lcom_liveperson_messaging_structuredcontent_model_actions_BaseAction_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_ == IntPtr.Zero)
				id_setWebViewOnClickListener_Landroid_content_Context_Ljava_lang_String_Lcom_liveperson_messaging_structuredcontent_model_actions_BaseAction_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_ = JNIEnv.GetMethodID (class_ref, "setWebViewOnClickListener", "(Landroid/content/Context;Ljava/lang/String;Lcom/liveperson/messaging/structuredcontent/model/actions/BaseAction;Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWebViewOnClickListener_Landroid_content_Context_Ljava_lang_String_Lcom_liveperson_messaging_structuredcontent_model_actions_BaseAction_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWebViewOnClickListener", "(Landroid/content/Context;Ljava/lang/String;Lcom/liveperson/messaging/structuredcontent/model/actions/BaseAction;Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
