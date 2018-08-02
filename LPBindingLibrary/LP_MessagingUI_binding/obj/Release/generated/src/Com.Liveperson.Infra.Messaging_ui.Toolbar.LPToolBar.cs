using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Toolbar {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.toolbar']/class[@name='LPToolBar']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/toolbar/LPToolBar", DoNotGenerateAcw=true)]
	public abstract partial class LPToolBar : global::Android.Support.V7.Widget.Toolbar {


		static IntPtr mBrandId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.toolbar']/class[@name='LPToolBar']/field[@name='mBrandId']"
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
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/toolbar/LPToolBar", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LPToolBar); }
		}

		protected LPToolBar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.toolbar']/class[@name='LPToolBar']/constructor[@name='LPToolBar' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe LPToolBar (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				if (((object) this).GetType () != typeof (LPToolBar)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.toolbar']/class[@name='LPToolBar']/constructor[@name='LPToolBar' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe LPToolBar (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (attrs);
				if (((object) this).GetType () != typeof (LPToolBar)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.toolbar']/class[@name='LPToolBar']/constructor[@name='LPToolBar' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe LPToolBar (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (context);
				__args [1] = new JValue (attrs);
				__args [2] = new JValue (defStyle);
				if (((object) this).GetType () != typeof (LPToolBar)) {
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

		static Delegate cb_initReceivers;
#pragma warning disable 0169
		static Delegate GetInitReceiversHandler ()
		{
			if (cb_initReceivers == null)
				cb_initReceivers = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitReceivers);
			return cb_initReceivers;
		}

		static void n_InitReceivers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Toolbar.LPToolBar __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Toolbar.LPToolBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitReceivers ();
		}
#pragma warning restore 0169

		static IntPtr id_initReceivers;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.toolbar']/class[@name='LPToolBar']/method[@name='initReceivers' and count(parameter)=0]"
		[Register ("initReceivers", "()V", "GetInitReceiversHandler")]
		protected virtual unsafe void InitReceivers ()
		{
			if (id_initReceivers == IntPtr.Zero)
				id_initReceivers = JNIEnv.GetMethodID (class_ref, "initReceivers", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initReceivers);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initReceivers", "()V"));
			} finally {
			}
		}

		static Delegate cb_onInitCompleted;
#pragma warning disable 0169
		static Delegate GetOnInitCompletedHandler ()
		{
			if (cb_onInitCompleted == null)
				cb_onInitCompleted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInitCompleted);
			return cb_onInitCompleted;
		}

		static void n_OnInitCompleted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Toolbar.LPToolBar __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Toolbar.LPToolBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInitCompleted ();
		}
#pragma warning restore 0169

		static IntPtr id_onInitCompleted;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.toolbar']/class[@name='LPToolBar']/method[@name='onInitCompleted' and count(parameter)=0]"
		[Register ("onInitCompleted", "()V", "GetOnInitCompletedHandler")]
		public virtual unsafe void OnInitCompleted ()
		{
			if (id_onInitCompleted == IntPtr.Zero)
				id_onInitCompleted = JNIEnv.GetMethodID (class_ref, "onInitCompleted", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInitCompleted);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInitCompleted", "()V"));
			} finally {
			}
		}

		static Delegate cb_onPause;
#pragma warning disable 0169
		static Delegate GetOnPauseHandler ()
		{
			if (cb_onPause == null)
				cb_onPause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPause);
			return cb_onPause;
		}

		static void n_OnPause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Toolbar.LPToolBar __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Toolbar.LPToolBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		static IntPtr id_onPause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.toolbar']/class[@name='LPToolBar']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler")]
		public virtual unsafe void OnPause ()
		{
			if (id_onPause == IntPtr.Zero)
				id_onPause = JNIEnv.GetMethodID (class_ref, "onPause", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPause);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPause", "()V"));
			} finally {
			}
		}

		static Delegate cb_onResume;
#pragma warning disable 0169
		static Delegate GetOnResumeHandler ()
		{
			if (cb_onResume == null)
				cb_onResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResume);
			return cb_onResume;
		}

		static void n_OnResume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Toolbar.LPToolBar __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Toolbar.LPToolBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		static IntPtr id_onResume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.toolbar']/class[@name='LPToolBar']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler")]
		public virtual unsafe void OnResume ()
		{
			if (id_onResume == IntPtr.Zero)
				id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResume);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResume", "()V"));
			} finally {
			}
		}

		static Delegate cb_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_;
#pragma warning disable 0169
		static Delegate GetOnSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_Handler ()
		{
			if (cb_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ == null)
				cb_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_);
			return cb_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_;
		}

		static void n_OnSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_actions)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Toolbar.LPToolBar __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Toolbar.LPToolBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions actions = (global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions> (native_actions, JniHandleOwnership.DoNotTransfer);
			__this.OnSurveySubmitted (actions);
		}
#pragma warning restore 0169

		static IntPtr id_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.toolbar']/class[@name='LPToolBar']/method[@name='onSurveySubmitted' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.messaging_ui.fragment.IFeedbackActions']]"
		[Register ("onSurveySubmitted", "(Lcom/liveperson/infra/messaging_ui/fragment/IFeedbackActions;)V", "GetOnSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_Handler")]
		public virtual unsafe void OnSurveySubmitted (global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions actions)
		{
			if (id_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ == IntPtr.Zero)
				id_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ = JNIEnv.GetMethodID (class_ref, "onSurveySubmitted", "(Lcom/liveperson/infra/messaging_ui/fragment/IFeedbackActions;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (actions);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurveySubmitted", "(Lcom/liveperson/infra/messaging_ui/fragment/IFeedbackActions;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_registerReceivers;
#pragma warning disable 0169
		static Delegate GetRegisterReceiversHandler ()
		{
			if (cb_registerReceivers == null)
				cb_registerReceivers = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RegisterReceivers);
			return cb_registerReceivers;
		}

		static void n_RegisterReceivers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Toolbar.LPToolBar __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Toolbar.LPToolBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RegisterReceivers ();
		}
#pragma warning restore 0169

		static IntPtr id_registerReceivers;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.toolbar']/class[@name='LPToolBar']/method[@name='registerReceivers' and count(parameter)=0]"
		[Register ("registerReceivers", "()V", "GetRegisterReceiversHandler")]
		protected virtual unsafe void RegisterReceivers ()
		{
			if (id_registerReceivers == IntPtr.Zero)
				id_registerReceivers = JNIEnv.GetMethodID (class_ref, "registerReceivers", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerReceivers);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerReceivers", "()V"));
			} finally {
			}
		}

		static Delegate cb_setAgentName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAgentName_Ljava_lang_String_Handler ()
		{
			if (cb_setAgentName_Ljava_lang_String_ == null)
				cb_setAgentName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAgentName_Ljava_lang_String_);
			return cb_setAgentName_Ljava_lang_String_;
		}

		static void n_SetAgentName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_agentName)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Toolbar.LPToolBar __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Toolbar.LPToolBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string agentName = JNIEnv.GetString (native_agentName, JniHandleOwnership.DoNotTransfer);
			__this.SetAgentName (agentName);
		}
#pragma warning restore 0169

		static IntPtr id_setAgentName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.toolbar']/class[@name='LPToolBar']/method[@name='setAgentName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAgentName", "(Ljava/lang/String;)V", "GetSetAgentName_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAgentName (string agentName)
		{
			if (id_setAgentName_Ljava_lang_String_ == IntPtr.Zero)
				id_setAgentName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAgentName", "(Ljava/lang/String;)V");
			IntPtr native_agentName = JNIEnv.NewString (agentName);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_agentName);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAgentName_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAgentName", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_agentName);
			}
		}

		static Delegate cb_setBrandId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBrandId_Ljava_lang_String_Handler ()
		{
			if (cb_setBrandId_Ljava_lang_String_ == null)
				cb_setBrandId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBrandId_Ljava_lang_String_);
			return cb_setBrandId_Ljava_lang_String_;
		}

		static void n_SetBrandId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_brandId)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Toolbar.LPToolBar __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Toolbar.LPToolBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string brandId = JNIEnv.GetString (native_brandId, JniHandleOwnership.DoNotTransfer);
			__this.SetBrandId (brandId);
		}
#pragma warning restore 0169

		static IntPtr id_setBrandId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.toolbar']/class[@name='LPToolBar']/method[@name='setBrandId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setBrandId", "(Ljava/lang/String;)V", "GetSetBrandId_Ljava_lang_String_Handler")]
		public virtual unsafe void SetBrandId (string brandId)
		{
			if (id_setBrandId_Ljava_lang_String_ == IntPtr.Zero)
				id_setBrandId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBrandId", "(Ljava/lang/String;)V");
			IntPtr native_brandId = JNIEnv.NewString (brandId);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_brandId);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBrandId_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBrandId", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_brandId);
			}
		}

		static Delegate cb_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_;
#pragma warning disable 0169
		static Delegate GetSetFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_Handler ()
		{
			if (cb_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ == null)
				cb_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_SetFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_);
			return cb_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_;
		}

		static void n_SetFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ (IntPtr jnienv, IntPtr native__this, bool feedBackMode, IntPtr native_actions)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Toolbar.LPToolBar __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Toolbar.LPToolBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions actions = (global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions> (native_actions, JniHandleOwnership.DoNotTransfer);
			__this.SetFeedBackMode (feedBackMode, actions);
		}
#pragma warning restore 0169

		static IntPtr id_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.toolbar']/class[@name='LPToolBar']/method[@name='setFeedBackMode' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.liveperson.infra.messaging_ui.fragment.IFeedbackActions']]"
		[Register ("setFeedBackMode", "(ZLcom/liveperson/infra/messaging_ui/fragment/IFeedbackActions;)V", "GetSetFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_Handler")]
		public virtual unsafe void SetFeedBackMode (bool feedBackMode, global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions actions)
		{
			if (id_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ == IntPtr.Zero)
				id_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ = JNIEnv.GetMethodID (class_ref, "setFeedBackMode", "(ZLcom/liveperson/infra/messaging_ui/fragment/IFeedbackActions;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (feedBackMode);
				__args [1] = new JValue (actions);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFeedBackMode", "(ZLcom/liveperson/infra/messaging_ui/fragment/IFeedbackActions;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_unregisterReceivers;
#pragma warning disable 0169
		static Delegate GetUnregisterReceiversHandler ()
		{
			if (cb_unregisterReceivers == null)
				cb_unregisterReceivers = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnregisterReceivers);
			return cb_unregisterReceivers;
		}

		static void n_UnregisterReceivers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Toolbar.LPToolBar __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Toolbar.LPToolBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterReceivers ();
		}
#pragma warning restore 0169

		static IntPtr id_unregisterReceivers;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.toolbar']/class[@name='LPToolBar']/method[@name='unregisterReceivers' and count(parameter)=0]"
		[Register ("unregisterReceivers", "()V", "GetUnregisterReceiversHandler")]
		protected virtual unsafe void UnregisterReceivers ()
		{
			if (id_unregisterReceivers == IntPtr.Zero)
				id_unregisterReceivers = JNIEnv.GetMethodID (class_ref, "unregisterReceivers", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterReceivers);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregisterReceivers", "()V"));
			} finally {
			}
		}

		static Delegate cb_updateAgent;
#pragma warning disable 0169
		static Delegate GetUpdateAgentHandler ()
		{
			if (cb_updateAgent == null)
				cb_updateAgent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateAgent);
			return cb_updateAgent;
		}

		static void n_UpdateAgent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Toolbar.LPToolBar __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Toolbar.LPToolBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateAgent ();
		}
#pragma warning restore 0169

		static IntPtr id_updateAgent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.toolbar']/class[@name='LPToolBar']/method[@name='updateAgent' and count(parameter)=0]"
		[Register ("updateAgent", "()V", "GetUpdateAgentHandler")]
		protected virtual unsafe void UpdateAgent ()
		{
			if (id_updateAgent == IntPtr.Zero)
				id_updateAgent = JNIEnv.GetMethodID (class_ref, "updateAgent", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateAgent);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateAgent", "()V"));
			} finally {
			}
		}

		static Delegate cb_updateToolBarData;
#pragma warning disable 0169
		static Delegate GetUpdateToolBarDataHandler ()
		{
			if (cb_updateToolBarData == null)
				cb_updateToolBarData = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateToolBarData);
			return cb_updateToolBarData;
		}

		static void n_UpdateToolBarData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Toolbar.LPToolBar __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Toolbar.LPToolBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateToolBarData ();
		}
#pragma warning restore 0169

		static IntPtr id_updateToolBarData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.toolbar']/class[@name='LPToolBar']/method[@name='updateToolBarData' and count(parameter)=0]"
		[Register ("updateToolBarData", "()V", "GetUpdateToolBarDataHandler")]
		public virtual unsafe void UpdateToolBarData ()
		{
			if (id_updateToolBarData == IntPtr.Zero)
				id_updateToolBarData = JNIEnv.GetMethodID (class_ref, "updateToolBarData", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateToolBarData);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateToolBarData", "()V"));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/toolbar/LPToolBar", DoNotGenerateAcw=true)]
	internal partial class LPToolBarInvoker : LPToolBar {

		public LPToolBarInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (LPToolBarInvoker); }
		}

	}

}
