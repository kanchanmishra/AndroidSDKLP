using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Viewpager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.viewpager']/class[@name='CustomViewPagerAdapter']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/structuredcontent/viewpager/CustomViewPagerAdapter", DoNotGenerateAcw=true)]
	public partial class CustomViewPagerAdapter : global::Android.Support.V4.View.PagerAdapter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/structuredcontent/viewpager/CustomViewPagerAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CustomViewPagerAdapter); }
		}

		protected CustomViewPagerAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_util_List_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_visitor_ViewBuilderVisitor_StructuredContentContainerOperations_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.viewpager']/class[@name='CustomViewPagerAdapter']/constructor[@name='CustomViewPagerAdapter' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;com.liveperson.messaging.structuredcontent.model.elements.BaseElement&gt;'] and parameter[4][@type='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor.ViewBuilderVisitor.StructuredContentContainerOperations'] and parameter[5][@type='com.liveperson.infra.messaging_ui.uicomponents.list.OnSCActionClickListener']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/List;Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/ViewBuilderVisitor$StructuredContentContainerOperations;Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;)V", "")]
		public unsafe CustomViewPagerAdapter (global::Android.Content.Context p0, string p1, global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.BaseElement> p2, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor.IStructuredContentContainerOperations p3, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.OnSCActionClickListener p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.BaseElement>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (((object) this).GetType () != typeof (CustomViewPagerAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/util/List;Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/ViewBuilderVisitor$StructuredContentContainerOperations;Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/util/List;Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/ViewBuilderVisitor$StructuredContentContainerOperations;Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_util_List_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_visitor_ViewBuilderVisitor_StructuredContentContainerOperations_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_util_List_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_visitor_ViewBuilderVisitor_StructuredContentContainerOperations_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/List;Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/ViewBuilderVisitor$StructuredContentContainerOperations;Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_util_List_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_visitor_ViewBuilderVisitor_StructuredContentContainerOperations_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_util_List_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_visitor_ViewBuilderVisitor_StructuredContentContainerOperations_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Viewpager.CustomViewPagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Viewpager.CustomViewPagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		static IntPtr id_getCount;
		public override unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.viewpager']/class[@name='CustomViewPagerAdapter']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isViewFromObject_Landroid_view_View_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetIsViewFromObject_Landroid_view_View_Ljava_lang_Object_Handler ()
		{
			if (cb_isViewFromObject_Landroid_view_View_Ljava_lang_Object_ == null)
				cb_isViewFromObject_Landroid_view_View_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_IsViewFromObject_Landroid_view_View_Ljava_lang_Object_);
			return cb_isViewFromObject_Landroid_view_View_Ljava_lang_Object_;
		}

		static bool n_IsViewFromObject_Landroid_view_View_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Viewpager.CustomViewPagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Viewpager.CustomViewPagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsViewFromObject (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isViewFromObject_Landroid_view_View_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.viewpager']/class[@name='CustomViewPagerAdapter']/method[@name='isViewFromObject' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.Object']]"
		[Register ("isViewFromObject", "(Landroid/view/View;Ljava/lang/Object;)Z", "GetIsViewFromObject_Landroid_view_View_Ljava_lang_Object_Handler")]
		public override unsafe bool IsViewFromObject (global::Android.Views.View p0, global::Java.Lang.Object p1)
		{
			if (id_isViewFromObject_Landroid_view_View_Ljava_lang_Object_ == IntPtr.Zero)
				id_isViewFromObject_Landroid_view_View_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "isViewFromObject", "(Landroid/view/View;Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isViewFromObject_Landroid_view_View_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isViewFromObject", "(Landroid/view/View;Ljava/lang/Object;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
