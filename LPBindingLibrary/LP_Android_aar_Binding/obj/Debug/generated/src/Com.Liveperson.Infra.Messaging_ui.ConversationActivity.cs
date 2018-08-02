using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='ConversationActivity']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/ConversationActivity", DoNotGenerateAcw=true)]
	public partial class ConversationActivity : global::Android.Support.V7.App.AppCompatActivity, global::Com.Liveperson.Infra.Messaging_ui.Fragment.IConversationFragmentCallbacks, global::Com.Liveperson.Infra.UI.View.Uicomponents.IConnectionChangedCustomView {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='ConversationActivity']/field[@name='INTENT_ACTION']"
		[Register ("INTENT_ACTION")]
		public const string IntentAction = (string) "conversation action";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='ConversationActivity']/field[@name='TYPE_CLOSE_CHAT']"
		[Register ("TYPE_CLOSE_CHAT")]
		public const int TypeCloseChat = (int) 17771;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/ConversationActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConversationActivity); }
		}

		protected ConversationActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='ConversationActivity']/constructor[@name='ConversationActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConversationActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ConversationActivity)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getUiUtils;
#pragma warning disable 0169
		static Delegate GetGetUiUtilsHandler ()
		{
			if (cb_getUiUtils == null)
				cb_getUiUtils = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUiUtils);
			return cb_getUiUtils;
		}

		static IntPtr n_GetUiUtils (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UiUtils);
		}
#pragma warning restore 0169

		static IntPtr id_getUiUtils;
		public virtual unsafe global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.MessagingUIUtils UiUtils {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='ConversationActivity']/method[@name='getUiUtils' and count(parameter)=0]"
			[Register ("getUiUtils", "()Lcom/liveperson/infra/messaging_ui/uicomponents/MessagingUIUtils;", "GetGetUiUtilsHandler")]
			get {
				if (id_getUiUtils == IntPtr.Zero)
					id_getUiUtils = JNIEnv.GetMethodID (class_ref, "getUiUtils", "()Lcom/liveperson/infra/messaging_ui/uicomponents/MessagingUIUtils;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.MessagingUIUtils> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUiUtils), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.MessagingUIUtils> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUiUtils", "()Lcom/liveperson/infra/messaging_ui/uicomponents/MessagingUIUtils;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_onClearHistoryClicked;
#pragma warning disable 0169
		static Delegate GetOnClearHistoryClickedHandler ()
		{
			if (cb_onClearHistoryClicked == null)
				cb_onClearHistoryClicked = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnClearHistoryClicked);
			return cb_onClearHistoryClicked;
		}

		static void n_OnClearHistoryClicked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnClearHistoryClicked ();
		}
#pragma warning restore 0169

		static IntPtr id_onClearHistoryClicked;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='ConversationActivity']/method[@name='onClearHistoryClicked' and count(parameter)=0]"
		[Register ("onClearHistoryClicked", "()V", "GetOnClearHistoryClickedHandler")]
		protected virtual unsafe void OnClearHistoryClicked ()
		{
			if (id_onClearHistoryClicked == IntPtr.Zero)
				id_onClearHistoryClicked = JNIEnv.GetMethodID (class_ref, "onClearHistoryClicked", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClearHistoryClicked);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onClearHistoryClicked", "()V"));
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
			global::Com.Liveperson.Infra.Messaging_ui.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConnectionChanged_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='ConversationActivity']/method[@name='onConnectionChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_onMarkAsUrgentClick_Lcom_liveperson_messaging_Messaging_;
#pragma warning disable 0169
		static Delegate GetOnMarkAsUrgentClick_Lcom_liveperson_messaging_Messaging_Handler ()
		{
			if (cb_onMarkAsUrgentClick_Lcom_liveperson_messaging_Messaging_ == null)
				cb_onMarkAsUrgentClick_Lcom_liveperson_messaging_Messaging_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMarkAsUrgentClick_Lcom_liveperson_messaging_Messaging_);
			return cb_onMarkAsUrgentClick_Lcom_liveperson_messaging_Messaging_;
		}

		static void n_OnMarkAsUrgentClick_Lcom_liveperson_messaging_Messaging_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Messaging p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMarkAsUrgentClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onMarkAsUrgentClick_Lcom_liveperson_messaging_Messaging_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='ConversationActivity']/method[@name='onMarkAsUrgentClick' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.Messaging']]"
		[Register ("onMarkAsUrgentClick", "(Lcom/liveperson/messaging/Messaging;)V", "GetOnMarkAsUrgentClick_Lcom_liveperson_messaging_Messaging_Handler")]
		protected virtual unsafe void OnMarkAsUrgentClick (global::Com.Liveperson.Messaging.Messaging p0)
		{
			if (id_onMarkAsUrgentClick_Lcom_liveperson_messaging_Messaging_ == IntPtr.Zero)
				id_onMarkAsUrgentClick_Lcom_liveperson_messaging_Messaging_ = JNIEnv.GetMethodID (class_ref, "onMarkAsUrgentClick", "(Lcom/liveperson/messaging/Messaging;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMarkAsUrgentClick_Lcom_liveperson_messaging_Messaging_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMarkAsUrgentClick", "(Lcom/liveperson/messaging/Messaging;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onResolveConversationClick_Lcom_liveperson_messaging_Messaging_;
#pragma warning disable 0169
		static Delegate GetOnResolveConversationClick_Lcom_liveperson_messaging_Messaging_Handler ()
		{
			if (cb_onResolveConversationClick_Lcom_liveperson_messaging_Messaging_ == null)
				cb_onResolveConversationClick_Lcom_liveperson_messaging_Messaging_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResolveConversationClick_Lcom_liveperson_messaging_Messaging_);
			return cb_onResolveConversationClick_Lcom_liveperson_messaging_Messaging_;
		}

		static void n_OnResolveConversationClick_Lcom_liveperson_messaging_Messaging_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Messaging p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResolveConversationClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onResolveConversationClick_Lcom_liveperson_messaging_Messaging_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='ConversationActivity']/method[@name='onResolveConversationClick' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.Messaging']]"
		[Register ("onResolveConversationClick", "(Lcom/liveperson/messaging/Messaging;)V", "GetOnResolveConversationClick_Lcom_liveperson_messaging_Messaging_Handler")]
		protected virtual unsafe void OnResolveConversationClick (global::Com.Liveperson.Messaging.Messaging p0)
		{
			if (id_onResolveConversationClick_Lcom_liveperson_messaging_Messaging_ == IntPtr.Zero)
				id_onResolveConversationClick_Lcom_liveperson_messaging_Messaging_ = JNIEnv.GetMethodID (class_ref, "onResolveConversationClick", "(Lcom/liveperson/messaging/Messaging;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResolveConversationClick_Lcom_liveperson_messaging_Messaging_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResolveConversationClick", "(Lcom/liveperson/messaging/Messaging;)V"), __args);
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

		static void n_OnSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions p0 = (global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurveySubmitted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='ConversationActivity']/method[@name='onSurveySubmitted' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.messaging_ui.fragment.IFeedbackActions']]"
		[Register ("onSurveySubmitted", "(Lcom/liveperson/infra/messaging_ui/fragment/IFeedbackActions;)V", "GetOnSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_Handler")]
		public virtual unsafe void OnSurveySubmitted (global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions p0)
		{
			if (id_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ == IntPtr.Zero)
				id_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ = JNIEnv.GetMethodID (class_ref, "onSurveySubmitted", "(Lcom/liveperson/infra/messaging_ui/fragment/IFeedbackActions;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurveySubmitted", "(Lcom/liveperson/infra/messaging_ui/fragment/IFeedbackActions;)V"), __args);
			} finally {
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

		static void n_SetFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions p1 = (global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetFeedBackMode (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='ConversationActivity']/method[@name='setFeedBackMode' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.liveperson.infra.messaging_ui.fragment.IFeedbackActions']]"
		[Register ("setFeedBackMode", "(ZLcom/liveperson/infra/messaging_ui/fragment/IFeedbackActions;)V", "GetSetFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_Handler")]
		public virtual unsafe void SetFeedBackMode (bool p0, global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions p1)
		{
			if (id_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ == IntPtr.Zero)
				id_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ = JNIEnv.GetMethodID (class_ref, "setFeedBackMode", "(ZLcom/liveperson/infra/messaging_ui/fragment/IFeedbackActions;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFeedBackMode", "(ZLcom/liveperson/infra/messaging_ui/fragment/IFeedbackActions;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPCIToolbar_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPCIToolbar_Ljava_lang_String_Handler ()
		{
			if (cb_setPCIToolbar_Ljava_lang_String_ == null)
				cb_setPCIToolbar_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPCIToolbar_Ljava_lang_String_);
			return cb_setPCIToolbar_Ljava_lang_String_;
		}

		static void n_SetPCIToolbar_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPCIToolbar (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPCIToolbar_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='ConversationActivity']/method[@name='setPCIToolbar' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPCIToolbar", "(Ljava/lang/String;)V", "GetSetPCIToolbar_Ljava_lang_String_Handler")]
		protected virtual unsafe void SetPCIToolbar (string p0)
		{
			if (id_setPCIToolbar_Ljava_lang_String_ == IntPtr.Zero)
				id_setPCIToolbar_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPCIToolbar", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPCIToolbar_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPCIToolbar", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setSecureFormMode_ZLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSecureFormMode_ZLjava_lang_String_Handler ()
		{
			if (cb_setSecureFormMode_ZLjava_lang_String_ == null)
				cb_setSecureFormMode_ZLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_SetSecureFormMode_ZLjava_lang_String_);
			return cb_setSecureFormMode_ZLjava_lang_String_;
		}

		static void n_SetSecureFormMode_ZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetSecureFormMode (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setSecureFormMode_ZLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='ConversationActivity']/method[@name='setSecureFormMode' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
		[Register ("setSecureFormMode", "(ZLjava/lang/String;)V", "GetSetSecureFormMode_ZLjava_lang_String_Handler")]
		public virtual unsafe void SetSecureFormMode (bool p0, string p1)
		{
			if (id_setSecureFormMode_ZLjava_lang_String_ == IntPtr.Zero)
				id_setSecureFormMode_ZLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSecureFormMode", "(ZLjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSecureFormMode_ZLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSecureFormMode", "(ZLjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
