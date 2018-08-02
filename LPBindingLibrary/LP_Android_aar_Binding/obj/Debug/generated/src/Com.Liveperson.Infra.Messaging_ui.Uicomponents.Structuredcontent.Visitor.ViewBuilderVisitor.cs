using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='ViewBuilderVisitor']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/ViewBuilderVisitor", DoNotGenerateAcw=true)]
	public partial class ViewBuilderVisitor : global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.BaseViewBuilderVisitor {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='ViewBuilderVisitor']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr mQuickRepliesActionListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='ViewBuilderVisitor']/field[@name='mQuickRepliesActionListener']"
		[Register ("mQuickRepliesActionListener")]
		protected global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListener MQuickRepliesActionListener {
			get {
				if (mQuickRepliesActionListener_jfieldId == IntPtr.Zero)
					mQuickRepliesActionListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mQuickRepliesActionListener", "Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/QRActionClickListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mQuickRepliesActionListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mQuickRepliesActionListener_jfieldId == IntPtr.Zero)
					mQuickRepliesActionListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mQuickRepliesActionListener", "Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/QRActionClickListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mQuickRepliesActionListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/interface[@name='ViewBuilderVisitor.StructuredContentContainerOperations']"
		[Register ("com/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/ViewBuilderVisitor$StructuredContentContainerOperations", "", "Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor/IStructuredContentContainerOperationsInvoker")]
		public partial interface IStructuredContentContainerOperations : IJavaObject {

			int LeftPadding {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/interface[@name='ViewBuilderVisitor.StructuredContentContainerOperations']/method[@name='getLeftPadding' and count(parameter)=0]"
				[Register ("getLeftPadding", "()I", "GetGetLeftPaddingHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor/IStructuredContentContainerOperationsInvoker, LP_Android_aar_Binding")] get;
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/interface[@name='ViewBuilderVisitor.StructuredContentContainerOperations']/method[@name='onChangeContainerSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onChangeContainerSize", "(I)V", "GetOnChangeContainerSize_IHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor/IStructuredContentContainerOperationsInvoker, LP_Android_aar_Binding")]
			void OnChangeContainerSize (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/interface[@name='ViewBuilderVisitor.StructuredContentContainerOperations']/method[@name='showAvatar' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("showAvatar", "(Z)V", "GetShowAvatar_ZHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor/IStructuredContentContainerOperationsInvoker, LP_Android_aar_Binding")]
			void ShowAvatar (bool p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/interface[@name='ViewBuilderVisitor.StructuredContentContainerOperations']/method[@name='showTimestamp' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("showTimestamp", "(Z)V", "GetShowTimestamp_ZHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor/IStructuredContentContainerOperationsInvoker, LP_Android_aar_Binding")]
			void ShowTimestamp (bool p0);

		}

		[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/ViewBuilderVisitor$StructuredContentContainerOperations", DoNotGenerateAcw=true)]
		internal class IStructuredContentContainerOperationsInvoker : global::Java.Lang.Object, IStructuredContentContainerOperations {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/ViewBuilderVisitor$StructuredContentContainerOperations");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IStructuredContentContainerOperationsInvoker); }
			}

			IntPtr class_ref;

			public static IStructuredContentContainerOperations GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IStructuredContentContainerOperations> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor.ViewBuilderVisitor.StructuredContentContainerOperations"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IStructuredContentContainerOperationsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
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
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor.IStructuredContentContainerOperations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor.IStructuredContentContainerOperations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.LeftPadding;
			}
#pragma warning restore 0169

			IntPtr id_getLeftPadding;
			public unsafe int LeftPadding {
				get {
					if (id_getLeftPadding == IntPtr.Zero)
						id_getLeftPadding = JNIEnv.GetMethodID (class_ref, "getLeftPadding", "()I");
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLeftPadding);
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
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor.IStructuredContentContainerOperations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor.IStructuredContentContainerOperations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnChangeContainerSize (p0);
			}
#pragma warning restore 0169

			IntPtr id_onChangeContainerSize_I;
			public unsafe void OnChangeContainerSize (int p0)
			{
				if (id_onChangeContainerSize_I == IntPtr.Zero)
					id_onChangeContainerSize_I = JNIEnv.GetMethodID (class_ref, "onChangeContainerSize", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onChangeContainerSize_I, __args);
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
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor.IStructuredContentContainerOperations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor.IStructuredContentContainerOperations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ShowAvatar (p0);
			}
#pragma warning restore 0169

			IntPtr id_showAvatar_Z;
			public unsafe void ShowAvatar (bool p0)
			{
				if (id_showAvatar_Z == IntPtr.Zero)
					id_showAvatar_Z = JNIEnv.GetMethodID (class_ref, "showAvatar", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showAvatar_Z, __args);
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
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor.IStructuredContentContainerOperations __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor.IStructuredContentContainerOperations> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ShowTimestamp (p0);
			}
#pragma warning restore 0169

			IntPtr id_showTimestamp_Z;
			public unsafe void ShowTimestamp (bool p0)
			{
				if (id_showTimestamp_Z == IntPtr.Zero)
					id_showTimestamp_Z = JNIEnv.GetMethodID (class_ref, "showTimestamp", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showTimestamp_Z, __args);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/ViewBuilderVisitor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewBuilderVisitor); }
		}

		protected ViewBuilderVisitor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Lcom_liveperson_infra_messaging_ui_uicomponents_list_OnSCActionClickListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_visitor_ViewBuilderVisitor_StructuredContentContainerOperations_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='ViewBuilderVisitor']/constructor[@name='ViewBuilderVisitor' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.infra.messaging_ui.uicomponents.list.OnSCActionClickListener'] and parameter[4][@type='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor.ViewBuilderVisitor.StructuredContentContainerOperations']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Lcom/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener;Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/visitor/ViewBuilderVisitor$StructuredContentContainerOperations;)V", "")]
		public unsafe ViewBuilderVisitor (global::Android.Content.Context p0, string p1, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.OnSCActionClickListener p2, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor.IStructuredContentContainerOperations p3)
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
				if (((object) this).GetType () != typeof (ViewBuilderVisitor)) {
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

		static Delegate cb_getViewGroup;
#pragma warning disable 0169
		static Delegate GetGetViewGroupHandler ()
		{
			if (cb_getViewGroup == null)
				cb_getViewGroup = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetViewGroup);
			return cb_getViewGroup;
		}

		static IntPtr n_GetViewGroup (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ViewGroup);
		}
#pragma warning restore 0169

		static IntPtr id_getViewGroup;
		public virtual unsafe global::Android.Views.ViewGroup ViewGroup {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='ViewBuilderVisitor']/method[@name='getViewGroup' and count(parameter)=0]"
			[Register ("getViewGroup", "()Landroid/view/ViewGroup;", "GetGetViewGroupHandler")]
			get {
				if (id_getViewGroup == IntPtr.Zero)
					id_getViewGroup = JNIEnv.GetMethodID (class_ref, "getViewGroup", "()Landroid/view/ViewGroup;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getViewGroup), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getViewGroup", "()Landroid/view/ViewGroup;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_createViewGroupIfMissing;
#pragma warning disable 0169
		static Delegate GetCreateViewGroupIfMissingHandler ()
		{
			if (cb_createViewGroupIfMissing == null)
				cb_createViewGroupIfMissing = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CreateViewGroupIfMissing);
			return cb_createViewGroupIfMissing;
		}

		static void n_CreateViewGroupIfMissing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CreateViewGroupIfMissing ();
		}
#pragma warning restore 0169

		static IntPtr id_createViewGroupIfMissing;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='ViewBuilderVisitor']/method[@name='createViewGroupIfMissing' and count(parameter)=0]"
		[Register ("createViewGroupIfMissing", "()V", "GetCreateViewGroupIfMissingHandler")]
		public virtual unsafe void CreateViewGroupIfMissing ()
		{
			if (id_createViewGroupIfMissing == IntPtr.Zero)
				id_createViewGroupIfMissing = JNIEnv.GetMethodID (class_ref, "createViewGroupIfMissing", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createViewGroupIfMissing);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createViewGroupIfMissing", "()V"));
			} finally {
			}
		}

		static Delegate cb_setQuickRepliesActionListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_;
#pragma warning disable 0169
		static Delegate GetSetQuickRepliesActionListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_Handler ()
		{
			if (cb_setQuickRepliesActionListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_ == null)
				cb_setQuickRepliesActionListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetQuickRepliesActionListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_);
			return cb_setQuickRepliesActionListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_;
		}

		static void n_SetQuickRepliesActionListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListener p0 = (global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetQuickRepliesActionListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setQuickRepliesActionListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='ViewBuilderVisitor']/method[@name='setQuickRepliesActionListener' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.QRActionClickListener']]"
		[Register ("setQuickRepliesActionListener", "(Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/QRActionClickListener;)V", "GetSetQuickRepliesActionListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_Handler")]
		public virtual unsafe void SetQuickRepliesActionListener (global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListener p0)
		{
			if (id_setQuickRepliesActionListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_ == IntPtr.Zero)
				id_setQuickRepliesActionListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_ = JNIEnv.GetMethodID (class_ref, "setQuickRepliesActionListener", "(Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/QRActionClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setQuickRepliesActionListener_Lcom_liveperson_infra_messaging_ui_uicomponents_structuredcontent_QRActionClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setQuickRepliesActionListener", "(Lcom/liveperson/infra/messaging_ui/uicomponents/structuredcontent/QRActionClickListener;)V"), __args);
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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ButtonElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ButtonElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='ViewBuilderVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.ButtonElement']]"
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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ImageElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ImageElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='ViewBuilderVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.ImageElement']]"
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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.LinkElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.LinkElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='ViewBuilderVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.LinkElement']]"
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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.MapElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.MapElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='ViewBuilderVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.MapElement']]"
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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.TextElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.TextElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='ViewBuilderVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.TextElement']]"
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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.WebViewElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.WebViewElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='ViewBuilderVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.WebViewElement']]"
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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.CarouselElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.CarouselElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='ViewBuilderVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.complex.CarouselElement']]"
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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.LayoutElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.LayoutElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='ViewBuilderVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.complex.LayoutElement']]"
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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.Visitor.ViewBuilderVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.QuickRepliesElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.QuickRepliesElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.visitor']/class[@name='ViewBuilderVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.complex.QuickRepliesElement']]"
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

#region "Event implementation for Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListener"
		public event EventHandler QuickRepliesAction {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListener, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListenerImplementor>(
						ref weak_implementor_SetQuickRepliesActionListener,
						__CreateIQRActionClickListenerImplementor,
						SetQuickRepliesActionListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListener, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListenerImplementor>(
						ref weak_implementor_SetQuickRepliesActionListener,
						global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListenerImplementor.__IsEmpty,
						__v => SetQuickRepliesActionListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetQuickRepliesActionListener;

		global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListenerImplementor __CreateIQRActionClickListenerImplementor ()
		{
			return new global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListenerImplementor (this);
		}
#endregion
	}
}
