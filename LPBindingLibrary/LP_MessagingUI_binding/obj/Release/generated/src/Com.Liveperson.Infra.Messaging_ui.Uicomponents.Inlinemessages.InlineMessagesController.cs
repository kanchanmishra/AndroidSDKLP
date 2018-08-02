using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.inlinemessages']/class[@name='InlineMessagesController']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/inlinemessages/InlineMessagesController", DoNotGenerateAcw=true)]
	public partial class InlineMessagesController : global::Java.Lang.Object {

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

		static void n_Register_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_brandID)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages.InlineMessagesController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages.InlineMessagesController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string brandID = JNIEnv.GetString (native_brandID, JniHandleOwnership.DoNotTransfer);
			__this.Register (brandID);
		}
#pragma warning restore 0169

		static IntPtr id_register_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.inlinemessages']/class[@name='InlineMessagesController']/method[@name='register' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("register", "(Ljava/lang/String;)V", "GetRegister_Ljava_lang_String_Handler")]
		public virtual unsafe void Register (string brandID)
		{
			if (id_register_Ljava_lang_String_ == IntPtr.Zero)
				id_register_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "register", "(Ljava/lang/String;)V");
			IntPtr native_brandID = JNIEnv.NewString (brandID);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_brandID);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "register", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_brandID);
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
