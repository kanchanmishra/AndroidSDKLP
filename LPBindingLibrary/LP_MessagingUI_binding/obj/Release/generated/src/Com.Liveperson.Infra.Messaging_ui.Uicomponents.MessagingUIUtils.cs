using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='MessagingUIUtils']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/MessagingUIUtils", DoNotGenerateAcw=true)]
	public partial class MessagingUIUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/MessagingUIUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessagingUIUtils); }
		}

		protected MessagingUIUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_showActionNotAvailableMessage_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetShowActionNotAvailableMessage_Landroid_content_Context_Handler ()
		{
			if (cb_showActionNotAvailableMessage_Landroid_content_Context_ == null)
				cb_showActionNotAvailableMessage_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowActionNotAvailableMessage_Landroid_content_Context_);
			return cb_showActionNotAvailableMessage_Landroid_content_Context_;
		}

		static void n_ShowActionNotAvailableMessage_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.MessagingUIUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.MessagingUIUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.ShowActionNotAvailableMessage (context);
		}
#pragma warning restore 0169

		static IntPtr id_showActionNotAvailableMessage_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='MessagingUIUtils']/method[@name='showActionNotAvailableMessage' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("showActionNotAvailableMessage", "(Landroid/content/Context;)V", "GetShowActionNotAvailableMessage_Landroid_content_Context_Handler")]
		public virtual unsafe void ShowActionNotAvailableMessage (global::Android.Content.Context context)
		{
			if (id_showActionNotAvailableMessage_Landroid_content_Context_ == IntPtr.Zero)
				id_showActionNotAvailableMessage_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "showActionNotAvailableMessage", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showActionNotAvailableMessage_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showActionNotAvailableMessage", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_showMarkAsNormalDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShowMarkAsNormalDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_showMarkAsNormalDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_showMarkAsNormalDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ShowMarkAsNormalDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_);
			return cb_showMarkAsNormalDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_ShowMarkAsNormalDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_targetId, IntPtr native_brandId)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.MessagingUIUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.MessagingUIUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			string targetId = JNIEnv.GetString (native_targetId, JniHandleOwnership.DoNotTransfer);
			string brandId = JNIEnv.GetString (native_brandId, JniHandleOwnership.DoNotTransfer);
			__this.ShowMarkAsNormalDialog (context, targetId, brandId);
		}
#pragma warning restore 0169

		static IntPtr id_showMarkAsNormalDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='MessagingUIUtils']/method[@name='showMarkAsNormalDialog' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("showMarkAsNormalDialog", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "GetShowMarkAsNormalDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void ShowMarkAsNormalDialog (global::Android.Content.Context context, string targetId, string brandId)
		{
			if (id_showMarkAsNormalDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_showMarkAsNormalDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "showMarkAsNormalDialog", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_targetId = JNIEnv.NewString (targetId);
			IntPtr native_brandId = JNIEnv.NewString (brandId);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_targetId);
				__args [2] = new JValue (native_brandId);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showMarkAsNormalDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showMarkAsNormalDialog", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_targetId);
				JNIEnv.DeleteLocalRef (native_brandId);
			}
		}

		static Delegate cb_showMarkAsUrgentDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShowMarkAsUrgentDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_showMarkAsUrgentDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_showMarkAsUrgentDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ShowMarkAsUrgentDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_);
			return cb_showMarkAsUrgentDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_ShowMarkAsUrgentDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_targetId, IntPtr native_brandId)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.MessagingUIUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.MessagingUIUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			string targetId = JNIEnv.GetString (native_targetId, JniHandleOwnership.DoNotTransfer);
			string brandId = JNIEnv.GetString (native_brandId, JniHandleOwnership.DoNotTransfer);
			__this.ShowMarkAsUrgentDialog (context, targetId, brandId);
		}
#pragma warning restore 0169

		static IntPtr id_showMarkAsUrgentDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='MessagingUIUtils']/method[@name='showMarkAsUrgentDialog' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("showMarkAsUrgentDialog", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "GetShowMarkAsUrgentDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void ShowMarkAsUrgentDialog (global::Android.Content.Context context, string targetId, string brandId)
		{
			if (id_showMarkAsUrgentDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_showMarkAsUrgentDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "showMarkAsUrgentDialog", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_targetId = JNIEnv.NewString (targetId);
			IntPtr native_brandId = JNIEnv.NewString (brandId);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_targetId);
				__args [2] = new JValue (native_brandId);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showMarkAsUrgentDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showMarkAsUrgentDialog", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_targetId);
				JNIEnv.DeleteLocalRef (native_brandId);
			}
		}

		static Delegate cb_showNoNetworkMessage_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetShowNoNetworkMessage_Landroid_content_Context_Handler ()
		{
			if (cb_showNoNetworkMessage_Landroid_content_Context_ == null)
				cb_showNoNetworkMessage_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowNoNetworkMessage_Landroid_content_Context_);
			return cb_showNoNetworkMessage_Landroid_content_Context_;
		}

		static void n_ShowNoNetworkMessage_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.MessagingUIUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.MessagingUIUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.ShowNoNetworkMessage (context);
		}
#pragma warning restore 0169

		static IntPtr id_showNoNetworkMessage_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='MessagingUIUtils']/method[@name='showNoNetworkMessage' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("showNoNetworkMessage", "(Landroid/content/Context;)V", "GetShowNoNetworkMessage_Landroid_content_Context_Handler")]
		public virtual unsafe void ShowNoNetworkMessage (global::Android.Content.Context context)
		{
			if (id_showNoNetworkMessage_Landroid_content_Context_ == IntPtr.Zero)
				id_showNoNetworkMessage_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "showNoNetworkMessage", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showNoNetworkMessage_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showNoNetworkMessage", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_showResolveDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShowResolveDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_showResolveDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_showResolveDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ShowResolveDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_);
			return cb_showResolveDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_ShowResolveDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_targetId, IntPtr native_brandId)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.MessagingUIUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.MessagingUIUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			string targetId = JNIEnv.GetString (native_targetId, JniHandleOwnership.DoNotTransfer);
			string brandId = JNIEnv.GetString (native_brandId, JniHandleOwnership.DoNotTransfer);
			__this.ShowResolveDialog (context, targetId, brandId);
		}
#pragma warning restore 0169

		static IntPtr id_showResolveDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='MessagingUIUtils']/method[@name='showResolveDialog' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("showResolveDialog", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "GetShowResolveDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void ShowResolveDialog (global::Android.Content.Context context, string targetId, string brandId)
		{
			if (id_showResolveDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_showResolveDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "showResolveDialog", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_targetId = JNIEnv.NewString (targetId);
			IntPtr native_brandId = JNIEnv.NewString (brandId);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_targetId);
				__args [2] = new JValue (native_brandId);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showResolveDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showResolveDialog", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_targetId);
				JNIEnv.DeleteLocalRef (native_brandId);
			}
		}

	}
}
