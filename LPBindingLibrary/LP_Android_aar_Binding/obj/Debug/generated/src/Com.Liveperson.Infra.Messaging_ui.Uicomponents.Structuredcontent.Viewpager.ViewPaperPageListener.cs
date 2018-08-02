using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Viewpager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.viewpager']/class[@name='ViewPaperPageListener']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/structuredcontent/viewpager/ViewPaperPageListener", DoNotGenerateAcw=true)]
	public partial class ViewPaperPageListener : global::Android.Support.V4.View.ViewPager.SimpleOnPageChangeListener {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.viewpager']/class[@name='ViewPaperPageListener']/field[@name='TAG']"
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
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/structuredcontent/viewpager/ViewPaperPageListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewPaperPageListener); }
		}

		protected ViewPaperPageListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_visitor_ViewBuilderVisitor_StructuredContentContainerOperations_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.viewpager']/class[@name='ViewPaperPageListener']/constructor[@name='ViewPaperPageListener' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor.ViewBuilderVisitor.StructuredContentContainerOperations']]"
		[Register (".ctor", "(Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/ViewBuilderVisitor$StructuredContentContainerOperations;)V", "")]
		public unsafe ViewPaperPageListener (global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor.IStructuredContentContainerOperations p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ViewPaperPageListener)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/ViewBuilderVisitor$StructuredContentContainerOperations;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/ViewBuilderVisitor$StructuredContentContainerOperations;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_visitor_ViewBuilderVisitor_StructuredContentContainerOperations_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_visitor_ViewBuilderVisitor_StructuredContentContainerOperations_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/ViewBuilderVisitor$StructuredContentContainerOperations;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_visitor_ViewBuilderVisitor_StructuredContentContainerOperations_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_visitor_ViewBuilderVisitor_StructuredContentContainerOperations_, __args);
			} finally {
			}
		}

	}
}
