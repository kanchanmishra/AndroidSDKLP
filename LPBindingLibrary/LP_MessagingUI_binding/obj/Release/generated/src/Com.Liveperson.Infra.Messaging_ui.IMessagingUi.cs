using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/interface[@name='IMessagingUi']"
	[Register ("com/liveperson/infra/messaging_ui/IMessagingUi", "", "Com.Liveperson.Infra.Messaging_ui.IMessagingUiInvoker")]
	public partial interface IMessagingUi : IJavaObject {

		bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/interface[@name='IMessagingUi']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "GetIsInitializedHandler:Com.Liveperson.Infra.Messaging_ui.IMessagingUiInvoker, LP_MessagingUI_binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/interface[@name='IMessagingUi']/method[@name='hideConversation' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("hideConversation", "(Landroid/app/Activity;)V", "GetHideConversation_Landroid_app_Activity_Handler:Com.Liveperson.Infra.Messaging_ui.IMessagingUiInvoker, LP_MessagingUI_binding")]
		void HideConversation (global::Android.App.Activity p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/interface[@name='IMessagingUi']/method[@name='onAgentAvatarTapped' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onAgentAvatarTapped", "(Ljava/lang/String;)V", "GetOnAgentAvatarTapped_Ljava_lang_String_Handler:Com.Liveperson.Infra.Messaging_ui.IMessagingUiInvoker, LP_MessagingUI_binding")]
		void OnAgentAvatarTapped (string p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/IMessagingUi", DoNotGenerateAcw=true)]
	internal class IMessagingUiInvoker : global::Java.Lang.Object, IMessagingUi {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/IMessagingUi");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMessagingUiInvoker); }
		}

		IntPtr class_ref;

		public static IMessagingUi GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMessagingUi> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.messaging_ui.IMessagingUi"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMessagingUiInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isInitialized;
#pragma warning disable 0169
		static Delegate GetIsInitializedHandler ()
		{
			if (cb_isInitialized == null)
				cb_isInitialized = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInitialized);
			return cb_isInitialized;
		}

		static bool n_IsInitialized (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.IMessagingUi __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.IMessagingUi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInitialized;
		}
#pragma warning restore 0169

		IntPtr id_isInitialized;
		public unsafe bool IsInitialized {
			get {
				if (id_isInitialized == IntPtr.Zero)
					id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInitialized);
			}
		}

		static Delegate cb_hideConversation_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetHideConversation_Landroid_app_Activity_Handler ()
		{
			if (cb_hideConversation_Landroid_app_Activity_ == null)
				cb_hideConversation_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HideConversation_Landroid_app_Activity_);
			return cb_hideConversation_Landroid_app_Activity_;
		}

		static void n_HideConversation_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.IMessagingUi __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.IMessagingUi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HideConversation (p0);
		}
#pragma warning restore 0169

		IntPtr id_hideConversation_Landroid_app_Activity_;
		public unsafe void HideConversation (global::Android.App.Activity p0)
		{
			if (id_hideConversation_Landroid_app_Activity_ == IntPtr.Zero)
				id_hideConversation_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "hideConversation", "(Landroid/app/Activity;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hideConversation_Landroid_app_Activity_, __args);
		}

		static Delegate cb_onAgentAvatarTapped_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAgentAvatarTapped_Ljava_lang_String_Handler ()
		{
			if (cb_onAgentAvatarTapped_Ljava_lang_String_ == null)
				cb_onAgentAvatarTapped_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAgentAvatarTapped_Ljava_lang_String_);
			return cb_onAgentAvatarTapped_Ljava_lang_String_;
		}

		static void n_OnAgentAvatarTapped_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.IMessagingUi __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.IMessagingUi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAgentAvatarTapped (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAgentAvatarTapped_Ljava_lang_String_;
		public unsafe void OnAgentAvatarTapped (string p0)
		{
			if (id_onAgentAvatarTapped_Ljava_lang_String_ == IntPtr.Zero)
				id_onAgentAvatarTapped_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAgentAvatarTapped", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAgentAvatarTapped_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
