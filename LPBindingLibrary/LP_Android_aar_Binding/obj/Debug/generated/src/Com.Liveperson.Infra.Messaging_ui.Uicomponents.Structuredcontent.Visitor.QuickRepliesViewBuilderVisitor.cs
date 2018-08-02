using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='QuickRepliesViewBuilderVisitor']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/QuickRepliesViewBuilderVisitor", DoNotGenerateAcw=true)]
	public partial class QuickRepliesViewBuilderVisitor : global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='QuickRepliesViewBuilderVisitor']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "QuickRepliesViewBuilderVisitor";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/QuickRepliesViewBuilderVisitor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QuickRepliesViewBuilderVisitor); }
		}

		protected QuickRepliesViewBuilderVisitor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_view_ViewGroup_Ljava_lang_String_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_IILcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_visitor_ViewBuilderVisitor_StructuredContentContainerOperations_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='QuickRepliesViewBuilderVisitor']/constructor[@name='QuickRepliesViewBuilderVisitor' and count(parameter)=8 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.view.ViewGroup'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.liveperson.infra.messaging_ui.uicomponents.list.OnSCActionClickListener'] and parameter[5][@type='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.QRActionClickListener'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor.ViewBuilderVisitor.StructuredContentContainerOperations']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/view/ViewGroup;Ljava/lang/String;Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/QRActionClickListener;IILcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/ViewBuilderVisitor$StructuredContentContainerOperations;)V", "")]
		public unsafe QuickRepliesViewBuilderVisitor (global::Android.Content.Context p0, global::Android.Views.ViewGroup p1, string p2, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.OnSCActionClickListener p3, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListener p4, int p5, int p6, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor.IStructuredContentContainerOperations p7)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				if (((object) this).GetType () != typeof (QuickRepliesViewBuilderVisitor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/view/ViewGroup;Ljava/lang/String;Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/QRActionClickListener;IILcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/ViewBuilderVisitor$StructuredContentContainerOperations;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/view/ViewGroup;Ljava/lang/String;Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/QRActionClickListener;IILcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/ViewBuilderVisitor$StructuredContentContainerOperations;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_view_ViewGroup_Ljava_lang_String_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_IILcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_visitor_ViewBuilderVisitor_StructuredContentContainerOperations_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_view_ViewGroup_Ljava_lang_String_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_IILcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_visitor_ViewBuilderVisitor_StructuredContentContainerOperations_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/view/ViewGroup;Ljava/lang/String;Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/QRActionClickListener;IILcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/ViewBuilderVisitor$StructuredContentContainerOperations;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_view_ViewGroup_Ljava_lang_String_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_IILcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_visitor_ViewBuilderVisitor_StructuredContentContainerOperations_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_view_ViewGroup_Ljava_lang_String_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_IILcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_visitor_ViewBuilderVisitor_StructuredContentContainerOperations_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getOutputView;
#pragma warning disable 0169
		static Delegate GetGetOutputViewHandler ()
		{
			if (cb_getOutputView == null)
				cb_getOutputView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOutputView);
			return cb_getOutputView;
		}

		static IntPtr n_GetOutputView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.QuickRepliesViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.QuickRepliesViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OutputView);
		}
#pragma warning restore 0169

		static IntPtr id_getOutputView;
		public virtual unsafe global::Android.Views.View OutputView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='QuickRepliesViewBuilderVisitor']/method[@name='getOutputView' and count(parameter)=0]"
			[Register ("getOutputView", "()Landroid/view/View;", "GetGetOutputViewHandler")]
			get {
				if (id_getOutputView == IntPtr.Zero)
					id_getOutputView = JNIEnv.GetMethodID (class_ref, "getOutputView", "()Landroid/view/View;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOutputView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutputView", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.QuickRepliesViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.QuickRepliesViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ButtonElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ButtonElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='QuickRepliesViewBuilderVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.ButtonElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ButtonElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_Handler")]
		public override unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ButtonElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ButtonElement;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ButtonElement;)V"), __args);
			} finally {
			}
		}

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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.QuickRepliesViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.QuickRepliesViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ImageElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ImageElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='QuickRepliesViewBuilderVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.ImageElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ImageElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_Handler")]
		public override unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ImageElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ImageElement;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ImageElement;)V"), __args);
			} finally {
			}
		}

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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.QuickRepliesViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.QuickRepliesViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.LinkElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.LinkElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='QuickRepliesViewBuilderVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.LinkElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/LinkElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_Handler")]
		public override unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.LinkElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/LinkElement;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/LinkElement;)V"), __args);
			} finally {
			}
		}

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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.QuickRepliesViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.QuickRepliesViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.MapElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.MapElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='QuickRepliesViewBuilderVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.MapElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/MapElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_Handler")]
		public override unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.MapElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/MapElement;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/MapElement;)V"), __args);
			} finally {
			}
		}

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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.QuickRepliesViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.QuickRepliesViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.TextElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.TextElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='QuickRepliesViewBuilderVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.TextElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/TextElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_Handler")]
		public override unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.TextElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/TextElement;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/TextElement;)V"), __args);
			} finally {
			}
		}

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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.QuickRepliesViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.QuickRepliesViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.WebViewElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.WebViewElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='QuickRepliesViewBuilderVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.WebViewElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/WebViewElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_Handler")]
		public override unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.WebViewElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/WebViewElement;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/WebViewElement;)V"), __args);
			} finally {
			}
		}

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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.QuickRepliesViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.QuickRepliesViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.CarouselElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.CarouselElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='QuickRepliesViewBuilderVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.complex.CarouselElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/CarouselElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_Handler")]
		public override unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.CarouselElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/CarouselElement;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/CarouselElement;)V"), __args);
			} finally {
			}
		}

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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.QuickRepliesViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.QuickRepliesViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.LayoutElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.LayoutElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='QuickRepliesViewBuilderVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.complex.LayoutElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/LayoutElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_Handler")]
		public override unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.LayoutElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/LayoutElement;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/LayoutElement;)V"), __args);
			} finally {
			}
		}

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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.QuickRepliesViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.QuickRepliesViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.QuickRepliesElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.QuickRepliesElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='QuickRepliesViewBuilderVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.complex.QuickRepliesElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/QuickRepliesElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_Handler")]
		public override unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.QuickRepliesElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/QuickRepliesElement;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/QuickRepliesElement;)V"), __args);
			} finally {
			}
		}

	}
}
