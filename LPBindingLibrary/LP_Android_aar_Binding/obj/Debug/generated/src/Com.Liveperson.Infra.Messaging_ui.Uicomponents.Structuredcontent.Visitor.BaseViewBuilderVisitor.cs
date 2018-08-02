using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='BaseViewBuilderVisitor']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/BaseViewBuilderVisitor", DoNotGenerateAcw=true)]
	public abstract partial class BaseViewBuilderVisitor : global::Java.Lang.Object, global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor {


		static IntPtr mBrandId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='BaseViewBuilderVisitor']/field[@name='mBrandId']"
		[Register ("mBrandId")]
		protected string MBrandId {
			get {
				if (mBrandId_jfieldId == IntPtr.Zero)
					mBrandId_jfieldId = JNIEnv.GetFieldID (class_ref, "mBrandId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mBrandId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mBrandId_jfieldId == IntPtr.Zero)
					mBrandId_jfieldId = JNIEnv.GetFieldID (class_ref, "mBrandId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mBrandId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mContentDescriptionStringBuilder_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='BaseViewBuilderVisitor']/field[@name='mContentDescriptionStringBuilder']"
		[Register ("mContentDescriptionStringBuilder")]
		protected global::Java.Lang.StringBuilder MContentDescriptionStringBuilder {
			get {
				if (mContentDescriptionStringBuilder_jfieldId == IntPtr.Zero)
					mContentDescriptionStringBuilder_jfieldId = JNIEnv.GetFieldID (class_ref, "mContentDescriptionStringBuilder", "Ljava/lang/StringBuilder;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mContentDescriptionStringBuilder_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mContentDescriptionStringBuilder_jfieldId == IntPtr.Zero)
					mContentDescriptionStringBuilder_jfieldId = JNIEnv.GetFieldID (class_ref, "mContentDescriptionStringBuilder", "Ljava/lang/StringBuilder;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mContentDescriptionStringBuilder_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mContext_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='BaseViewBuilderVisitor']/field[@name='mContext']"
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

		static IntPtr mGlobalListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='BaseViewBuilderVisitor']/field[@name='mGlobalListener']"
		[Register ("mGlobalListener")]
		protected global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.OnSCActionClickListener MGlobalListener {
			get {
				if (mGlobalListener_jfieldId == IntPtr.Zero)
					mGlobalListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mGlobalListener", "Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mGlobalListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.OnSCActionClickListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mGlobalListener_jfieldId == IntPtr.Zero)
					mGlobalListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mGlobalListener", "Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mGlobalListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mStructuredContentContainerOperations_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='BaseViewBuilderVisitor']/field[@name='mStructuredContentContainerOperations']"
		[Register ("mStructuredContentContainerOperations")]
		protected global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor.IStructuredContentContainerOperations MStructuredContentContainerOperations {
			get {
				if (mStructuredContentContainerOperations_jfieldId == IntPtr.Zero)
					mStructuredContentContainerOperations_jfieldId = JNIEnv.GetFieldID (class_ref, "mStructuredContentContainerOperations", "Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/ViewBuilderVisitor$StructuredContentContainerOperations;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mStructuredContentContainerOperations_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor.IStructuredContentContainerOperations> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mStructuredContentContainerOperations_jfieldId == IntPtr.Zero)
					mStructuredContentContainerOperations_jfieldId = JNIEnv.GetFieldID (class_ref, "mStructuredContentContainerOperations", "Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/ViewBuilderVisitor$StructuredContentContainerOperations;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mStructuredContentContainerOperations_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/BaseViewBuilderVisitor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseViewBuilderVisitor); }
		}

		protected BaseViewBuilderVisitor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_visitor_ViewBuilderVisitor_StructuredContentContainerOperations_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='BaseViewBuilderVisitor']/constructor[@name='BaseViewBuilderVisitor' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.infra.messaging_ui.uicomponents.list.OnSCActionClickListener'] and parameter[4][@type='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor.ViewBuilderVisitor.StructuredContentContainerOperations']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/ViewBuilderVisitor$StructuredContentContainerOperations;)V", "")]
		public unsafe BaseViewBuilderVisitor (global::Android.Content.Context p0, string p1, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.OnSCActionClickListener p2, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor.IStructuredContentContainerOperations p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (BaseViewBuilderVisitor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/lang/String;Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/ViewBuilderVisitor$StructuredContentContainerOperations;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/ViewBuilderVisitor$StructuredContentContainerOperations;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_visitor_ViewBuilderVisitor_StructuredContentContainerOperations_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_visitor_ViewBuilderVisitor_StructuredContentContainerOperations_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/ViewBuilderVisitor$StructuredContentContainerOperations;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_visitor_ViewBuilderVisitor_StructuredContentContainerOperations_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_visitor_ViewBuilderVisitor_StructuredContentContainerOperations_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_activateActions_Ljava_util_List_Lcom_liveperson_messaging_structuredcontent_model_elements_ActionableElement_;
#pragma warning disable 0169
		static Delegate GetActivateActions_Ljava_util_List_Lcom_liveperson_messaging_structuredcontent_model_elements_ActionableElement_Handler ()
		{
			if (cb_activateActions_Ljava_util_List_Lcom_liveperson_messaging_structuredcontent_model_elements_ActionableElement_ == null)
				cb_activateActions_Ljava_util_List_Lcom_liveperson_messaging_structuredcontent_model_elements_ActionableElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ActivateActions_Ljava_util_List_Lcom_liveperson_messaging_structuredcontent_model_elements_ActionableElement_);
			return cb_activateActions_Ljava_util_List_Lcom_liveperson_messaging_structuredcontent_model_elements_ActionableElement_;
		}

		static void n_ActivateActions_Ljava_util_List_Lcom_liveperson_messaging_structuredcontent_model_elements_ActionableElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.BaseAction>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.ActionableElement p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.ActionableElement> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ActivateActions (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_activateActions_Ljava_util_List_Lcom_liveperson_messaging_structuredcontent_model_elements_ActionableElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='BaseViewBuilderVisitor']/method[@name='activateActions' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.liveperson.messaging.structuredcontent.model.actions.BaseAction&gt;'] and parameter[2][@type='com.liveperson.messaging.structuredcontent.model.elements.ActionableElement']]"
		[Register ("activateActions", "(Ljava/util/List;Lcom/liveperson/messaging/structuredcontent/model/elements/ActionableElement;)V", "GetActivateActions_Ljava_util_List_Lcom_liveperson_messaging_structuredcontent_model_elements_ActionableElement_Handler")]
		protected virtual unsafe void ActivateActions (global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.BaseAction> p0, global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.ActionableElement p1)
		{
			if (id_activateActions_Ljava_util_List_Lcom_liveperson_messaging_structuredcontent_model_elements_ActionableElement_ == IntPtr.Zero)
				id_activateActions_Ljava_util_List_Lcom_liveperson_messaging_structuredcontent_model_elements_ActionableElement_ = JNIEnv.GetMethodID (class_ref, "activateActions", "(Ljava/util/List;Lcom/liveperson/messaging/structuredcontent/model/elements/ActionableElement;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.BaseAction>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_activateActions_Ljava_util_List_Lcom_liveperson_messaging_structuredcontent_model_elements_ActionableElement_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "activateActions", "(Ljava/util/List;Lcom/liveperson/messaging/structuredcontent/model/elements/ActionableElement;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_convertDip2Pixels_Landroid_content_Context_I;
#pragma warning disable 0169
		static Delegate GetConvertDip2Pixels_Landroid_content_Context_IHandler ()
		{
			if (cb_convertDip2Pixels_Landroid_content_Context_I == null)
				cb_convertDip2Pixels_Landroid_content_Context_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_ConvertDip2Pixels_Landroid_content_Context_I);
			return cb_convertDip2Pixels_Landroid_content_Context_I;
		}

		static int n_ConvertDip2Pixels_Landroid_content_Context_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ConvertDip2Pixels (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_convertDip2Pixels_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='BaseViewBuilderVisitor']/method[@name='convertDip2Pixels' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("convertDip2Pixels", "(Landroid/content/Context;I)I", "GetConvertDip2Pixels_Landroid_content_Context_IHandler")]
		protected virtual unsafe int ConvertDip2Pixels (global::Android.Content.Context p0, int p1)
		{
			if (id_convertDip2Pixels_Landroid_content_Context_I == IntPtr.Zero)
				id_convertDip2Pixels_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "convertDip2Pixels", "(Landroid/content/Context;I)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_convertDip2Pixels_Landroid_content_Context_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "convertDip2Pixels", "(Landroid/content/Context;I)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_createElementContentDescription_Landroid_view_View_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateElementContentDescription_Landroid_view_View_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_createElementContentDescription_Landroid_view_View_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_createElementContentDescription_Landroid_view_View_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateElementContentDescription_Landroid_view_View_Ljava_lang_String_Ljava_lang_String_);
			return cb_createElementContentDescription_Landroid_view_View_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_CreateElementContentDescription_Landroid_view_View_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.CreateElementContentDescription (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createElementContentDescription_Landroid_view_View_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='BaseViewBuilderVisitor']/method[@name='createElementContentDescription' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("createElementContentDescription", "(Landroid/view/View;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetCreateElementContentDescription_Landroid_view_View_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe string CreateElementContentDescription (global::Android.Views.View p0, string p1, string p2)
		{
			if (id_createElementContentDescription_Landroid_view_View_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_createElementContentDescription_Landroid_view_View_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createElementContentDescription", "(Landroid/view/View;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createElementContentDescription_Landroid_view_View_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createElementContentDescription", "(Landroid/view/View;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_setElementClickListener_Lcom_liveperson_messaging_structuredcontent_model_elements_ActionableElement_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetElementClickListener_Lcom_liveperson_messaging_structuredcontent_model_elements_ActionableElement_Landroid_view_View_Handler ()
		{
			if (cb_setElementClickListener_Lcom_liveperson_messaging_structuredcontent_model_elements_ActionableElement_Landroid_view_View_ == null)
				cb_setElementClickListener_Lcom_liveperson_messaging_structuredcontent_model_elements_ActionableElement_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetElementClickListener_Lcom_liveperson_messaging_structuredcontent_model_elements_ActionableElement_Landroid_view_View_);
			return cb_setElementClickListener_Lcom_liveperson_messaging_structuredcontent_model_elements_ActionableElement_Landroid_view_View_;
		}

		static void n_SetElementClickListener_Lcom_liveperson_messaging_structuredcontent_model_elements_ActionableElement_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.ActionableElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.ActionableElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetElementClickListener (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setElementClickListener_Lcom_liveperson_messaging_structuredcontent_model_elements_ActionableElement_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='BaseViewBuilderVisitor']/method[@name='setElementClickListener' and count(parameter)=2 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.ActionableElement'] and parameter[2][@type='android.view.View']]"
		[Register ("setElementClickListener", "(Lcom/liveperson/messaging/structuredcontent/model/elements/ActionableElement;Landroid/view/View;)V", "GetSetElementClickListener_Lcom_liveperson_messaging_structuredcontent_model_elements_ActionableElement_Landroid_view_View_Handler")]
		protected virtual unsafe void SetElementClickListener (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.ActionableElement p0, global::Android.Views.View p1)
		{
			if (id_setElementClickListener_Lcom_liveperson_messaging_structuredcontent_model_elements_ActionableElement_Landroid_view_View_ == IntPtr.Zero)
				id_setElementClickListener_Lcom_liveperson_messaging_structuredcontent_model_elements_ActionableElement_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setElementClickListener", "(Lcom/liveperson/messaging/structuredcontent/model/elements/ActionableElement;Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setElementClickListener_Lcom_liveperson_messaging_structuredcontent_model_elements_ActionableElement_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setElementClickListener", "(Lcom/liveperson/messaging/structuredcontent/model/elements/ActionableElement;Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setStyle_Landroid_widget_TextView_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ElementStyle_;
#pragma warning disable 0169
		static Delegate GetSetStyle_Landroid_widget_TextView_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ElementStyle_Handler ()
		{
			if (cb_setStyle_Landroid_widget_TextView_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ElementStyle_ == null)
				cb_setStyle_Landroid_widget_TextView_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ElementStyle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetStyle_Landroid_widget_TextView_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ElementStyle_);
			return cb_setStyle_Landroid_widget_TextView_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ElementStyle_;
		}

		static void n_SetStyle_Landroid_widget_TextView_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ElementStyle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.TextView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetStyle (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setStyle_Landroid_widget_TextView_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ElementStyle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='BaseViewBuilderVisitor']/method[@name='setStyle' and count(parameter)=2 and parameter[1][@type='android.widget.TextView'] and parameter[2][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.ElementStyle']]"
		[Register ("setStyle", "(Landroid/widget/TextView;Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ElementStyle;)V", "GetSetStyle_Landroid_widget_TextView_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ElementStyle_Handler")]
		protected virtual unsafe void SetStyle (global::Android.Widget.TextView p0, global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle p1)
		{
			if (id_setStyle_Landroid_widget_TextView_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ElementStyle_ == IntPtr.Zero)
				id_setStyle_Landroid_widget_TextView_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ElementStyle_ = JNIEnv.GetMethodID (class_ref, "setStyle", "(Landroid/widget/TextView;Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ElementStyle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStyle_Landroid_widget_TextView_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ElementStyle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStyle", "(Landroid/widget/TextView;Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ElementStyle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_ == null)
				cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_);
			return cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_;
		}

		static void n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ButtonElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ButtonElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.ButtonElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ButtonElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_Handler")]
		public abstract void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ButtonElement p0);

		static Delegate cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_ == null)
				cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_);
			return cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_;
		}

		static void n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ImageElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ImageElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.ImageElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ImageElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_Handler")]
		public abstract void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ImageElement p0);

		static Delegate cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_ == null)
				cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_);
			return cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_;
		}

		static void n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.LinkElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.LinkElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.LinkElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/LinkElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_Handler")]
		public abstract void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.LinkElement p0);

		static Delegate cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_ == null)
				cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_);
			return cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_;
		}

		static void n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.MapElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.MapElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.MapElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/MapElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_Handler")]
		public abstract void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.MapElement p0);

		static Delegate cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_ == null)
				cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_);
			return cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_;
		}

		static void n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.TextElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.TextElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.TextElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/TextElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_Handler")]
		public abstract void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.TextElement p0);

		static Delegate cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_ == null)
				cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_);
			return cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_;
		}

		static void n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.WebViewElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.WebViewElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.WebViewElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/WebViewElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_Handler")]
		public abstract void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.WebViewElement p0);

		static Delegate cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_ == null)
				cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_);
			return cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_;
		}

		static void n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.CarouselElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.CarouselElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.complex.CarouselElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/CarouselElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_Handler")]
		public abstract void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.CarouselElement p0);

		static Delegate cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_ == null)
				cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_);
			return cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_;
		}

		static void n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.LayoutElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.LayoutElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.complex.LayoutElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/LayoutElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_Handler")]
		public abstract void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.LayoutElement p0);

		static Delegate cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_ == null)
				cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_);
			return cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_;
		}

		static void n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.QuickRepliesElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.QuickRepliesElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.complex.QuickRepliesElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/QuickRepliesElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_Handler")]
		public abstract void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.QuickRepliesElement p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/BaseViewBuilderVisitor", DoNotGenerateAcw=true)]
	internal partial class BaseViewBuilderVisitorInvoker : BaseViewBuilderVisitor {

		public BaseViewBuilderVisitorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseViewBuilderVisitorInvoker); }
		}

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.ButtonElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ButtonElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_Handler")]
		public override unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ButtonElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ButtonElement;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_, __args);
			} finally {
			}
		}

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.ImageElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ImageElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_Handler")]
		public override unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ImageElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ImageElement;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_, __args);
			} finally {
			}
		}

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.LinkElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/LinkElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_Handler")]
		public override unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.LinkElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/LinkElement;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_, __args);
			} finally {
			}
		}

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.MapElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/MapElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_Handler")]
		public override unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.MapElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/MapElement;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_, __args);
			} finally {
			}
		}

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.TextElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/TextElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_Handler")]
		public override unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.TextElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/TextElement;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_, __args);
			} finally {
			}
		}

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.WebViewElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/WebViewElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_Handler")]
		public override unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.WebViewElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/WebViewElement;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_, __args);
			} finally {
			}
		}

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.complex.CarouselElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/CarouselElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_Handler")]
		public override unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.CarouselElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/CarouselElement;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_, __args);
			} finally {
			}
		}

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.complex.LayoutElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/LayoutElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_Handler")]
		public override unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.LayoutElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/LayoutElement;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_, __args);
			} finally {
			}
		}

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.complex.QuickRepliesElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/QuickRepliesElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_Handler")]
		public override unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.QuickRepliesElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/QuickRepliesElement;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_, __args);
			} finally {
			}
		}

	}

}
