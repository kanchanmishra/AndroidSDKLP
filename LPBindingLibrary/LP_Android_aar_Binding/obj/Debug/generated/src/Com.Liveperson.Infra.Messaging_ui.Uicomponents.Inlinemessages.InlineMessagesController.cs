using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.inlinemessages']/class[@name='InlineMessagesController']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/inlinemessages/InlineMessagesController", DoNotGenerateAcw=true)]
	public partial class InlineMessagesController : global::Java.Lang.Object {


		static IntPtr mTTRReceiver_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.inlinemessages']/class[@name='InlineMessagesController']/field[@name='mTTRReceiver']"
		[Register ("mTTRReceiver")]
		protected global::Com.Liveperson.Infra.LocalBroadcastReceiver MTTRReceiver {
			get {
				if (mTTRReceiver_jfieldId == IntPtr.Zero)
					mTTRReceiver_jfieldId = JNIEnv.GetFieldID (class_ref, "mTTRReceiver", "Lcom/liveperson/infra/LocalBroadcastReceiver;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mTTRReceiver_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LocalBroadcastReceiver> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTTRReceiver_jfieldId == IntPtr.Zero)
					mTTRReceiver_jfieldId = JNIEnv.GetFieldID (class_ref, "mTTRReceiver", "Lcom/liveperson/infra/LocalBroadcastReceiver;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mTTRReceiver_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/inlinemessages/InlineMessagesController", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InlineMessagesController); }
		}

		protected InlineMessagesController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_content_res_Resources_Landroid_view_View_Lcom_liveperson_infra_ui_view_uicomponents_IConversationProvider_Ljava_util_HashMap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.inlinemessages']/class[@name='InlineMessagesController']/constructor[@name='InlineMessagesController' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.res.Resources'] and parameter[3][@type='android.view.View'] and parameter[4][@type='com.liveperson.infra.ui.view.uicomponents.IConversationProvider'] and parameter[5][@type='java.util.HashMap&lt;java.lang.String, java.lang.Boolean&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/content/res/Resources;Landroid/view/View;Lcom/liveperson/infra/ui/view/uicomponents/IConversationProvider;Ljava/util/HashMap;)V", "")]
		public unsafe InlineMessagesController (global::Android.Content.Context p0, global::Android.Content.Res.Resources p1, global::Android.Views.View p2, global::Com.Liveperson.Infra.UI.View.Uicomponents.IConversationProvider p3, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Boolean> p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p4 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.ToLocalJniHandle (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				if (((object) this).GetType () != typeof (InlineMessagesController)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/content/res/Resources;Landroid/view/View;Lcom/liveperson/infra/ui/view/uicomponents/IConversationProvider;Ljava/util/HashMap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/content/res/Resources;Landroid/view/View;Lcom/liveperson/infra/ui/view/uicomponents/IConversationProvider;Ljava/util/HashMap;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_content_res_Resources_Landroid_view_View_Lcom_liveperson_infra_ui_view_uicomponents_IConversationProvider_Ljava_util_HashMap_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_content_res_Resources_Landroid_view_View_Lcom_liveperson_infra_ui_view_uicomponents_IConversationProvider_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/content/res/Resources;Landroid/view/View;Lcom/liveperson/infra/ui/view/uicomponents/IConversationProvider;Ljava/util/HashMap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_content_res_Resources_Landroid_view_View_Lcom_liveperson_infra_ui_view_uicomponents_IConversationProvider_Ljava_util_HashMap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_content_res_Resources_Landroid_view_View_Lcom_liveperson_infra_ui_view_uicomponents_IConversationProvider_Ljava_util_HashMap_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_hideAll;
#pragma warning disable 0169
		static Delegate GetHideAllHandler ()
		{
			if (cb_hideAll == null)
				cb_hideAll = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HideAll);
			return cb_hideAll;
		}

		static void n_HideAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages.InlineMessagesController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages.InlineMessagesController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideAll ();
		}
#pragma warning restore 0169

		static IntPtr id_hideAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.inlinemessages']/class[@name='InlineMessagesController']/method[@name='hideAll' and count(parameter)=0]"
		[Register ("hideAll", "()V", "GetHideAllHandler")]
		public virtual unsafe void HideAll ()
		{
			if (id_hideAll == IntPtr.Zero)
				id_hideAll = JNIEnv.GetMethodID (class_ref, "hideAll", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hideAll);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hideAll", "()V"));
			} finally {
			}
		}

		static Delegate cb_onConversationResolved;
#pragma warning disable 0169
		static Delegate GetOnConversationResolvedHandler ()
		{
			if (cb_onConversationResolved == null)
				cb_onConversationResolved = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnConversationResolved);
			return cb_onConversationResolved;
		}

		static void n_OnConversationResolved (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages.InlineMessagesController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages.InlineMessagesController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConversationResolved ();
		}
#pragma warning restore 0169

		static IntPtr id_onConversationResolved;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.inlinemessages']/class[@name='InlineMessagesController']/method[@name='onConversationResolved' and count(parameter)=0]"
		[Register ("onConversationResolved", "()V", "GetOnConversationResolvedHandler")]
		public virtual unsafe void OnConversationResolved ()
		{
			if (id_onConversationResolved == IntPtr.Zero)
				id_onConversationResolved = JNIEnv.GetMethodID (class_ref, "onConversationResolved", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConversationResolved);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConversationResolved", "()V"));
			} finally {
			}
		}

		static Delegate cb_register_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegister_Ljava_lang_String_Handler ()
		{
			if (cb_register_Ljava_lang_String_ == null)
				cb_register_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Register_Ljava_lang_String_);
			return cb_register_Ljava_lang_String_;
		}

		static void n_Register_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages.InlineMessagesController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages.InlineMessagesController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Register (p0);
		}
#pragma warning restore 0169

		static IntPtr id_register_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.inlinemessages']/class[@name='InlineMessagesController']/method[@name='register' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("register", "(Ljava/lang/String;)V", "GetRegister_Ljava_lang_String_Handler")]
		public virtual unsafe void Register (string p0)
		{
			if (id_register_Ljava_lang_String_ == IntPtr.Zero)
				id_register_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "register", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "register", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_registerTTRReceiver;
#pragma warning disable 0169
		static Delegate GetRegisterTTRReceiverHandler ()
		{
			if (cb_registerTTRReceiver == null)
				cb_registerTTRReceiver = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RegisterTTRReceiver);
			return cb_registerTTRReceiver;
		}

		static void n_RegisterTTRReceiver (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages.InlineMessagesController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages.InlineMessagesController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RegisterTTRReceiver ();
		}
#pragma warning restore 0169

		static IntPtr id_registerTTRReceiver;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.inlinemessages']/class[@name='InlineMessagesController']/method[@name='registerTTRReceiver' and count(parameter)=0]"
		[Register ("registerTTRReceiver", "()V", "GetRegisterTTRReceiverHandler")]
		protected virtual unsafe void RegisterTTRReceiver ()
		{
			if (id_registerTTRReceiver == IntPtr.Zero)
				id_registerTTRReceiver = JNIEnv.GetMethodID (class_ref, "registerTTRReceiver", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerTTRReceiver);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerTTRReceiver", "()V"));
			} finally {
			}
		}

		static Delegate cb_unregister;
#pragma warning disable 0169
		static Delegate GetUnregisterHandler ()
		{
			if (cb_unregister == null)
				cb_unregister = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Unregister);
			return cb_unregister;
		}

		static void n_Unregister (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages.InlineMessagesController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages.InlineMessagesController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Unregister ();
		}
#pragma warning restore 0169

		static IntPtr id_unregister;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.inlinemessages']/class[@name='InlineMessagesController']/method[@name='unregister' and count(parameter)=0]"
		[Register ("unregister", "()V", "GetUnregisterHandler")]
		public virtual unsafe void Unregister ()
		{
			if (id_unregister == IntPtr.Zero)
				id_unregister = JNIEnv.GetMethodID (class_ref, "unregister", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregister);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregister", "()V"));
			} finally {
			}
		}

	}
}
