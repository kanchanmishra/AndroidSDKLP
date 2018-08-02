using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.inlinemessages']/interface[@name='IInlineMessage']"
	[Register ("com/liveperson/infra/messaging_ui/uicomponents/inlinemessages/IInlineMessage", "", "Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages.IInlineMessageInvoker")]
	public partial interface IInlineMessage : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.inlinemessages']/interface[@name='IInlineMessage']/method[@name='hide' and count(parameter)=0]"
		[Register ("hide", "()V", "GetHideHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages.IInlineMessageInvoker, LP_MessagingUI_binding")]
		void Hide ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.inlinemessages']/interface[@name='IInlineMessage']/method[@name='show' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("show", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetShow_Landroid_content_Context_Landroid_content_Intent_Handler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages.IInlineMessageInvoker, LP_MessagingUI_binding")]
		void Show (global::Android.Content.Context p0, global::Android.Content.Intent p1);

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/inlinemessages/IInlineMessage", DoNotGenerateAcw=true)]
	internal class IInlineMessageInvoker : global::Java.Lang.Object, IInlineMessage {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/inlinemessages/IInlineMessage");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IInlineMessageInvoker); }
		}

		IntPtr class_ref;

		public static IInlineMessage GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInlineMessage> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.messaging_ui.uicomponents.inlinemessages.IInlineMessage"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInlineMessageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_hide;
#pragma warning disable 0169
		static Delegate GetHideHandler ()
		{
			if (cb_hide == null)
				cb_hide = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Hide);
			return cb_hide;
		}

		static void n_Hide (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages.IInlineMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages.IInlineMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Hide ();
		}
#pragma warning restore 0169

		IntPtr id_hide;
		public unsafe void Hide ()
		{
			if (id_hide == IntPtr.Zero)
				id_hide = JNIEnv.GetMethodID (class_ref, "hide", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hide);
		}

		static Delegate cb_show_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetShow_Landroid_content_Context_Landroid_content_Intent_Handler ()
		{
			if (cb_show_Landroid_content_Context_Landroid_content_Intent_ == null)
				cb_show_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Show_Landroid_content_Context_Landroid_content_Intent_);
			return cb_show_Landroid_content_Context_Landroid_content_Intent_;
		}

		static void n_Show_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages.IInlineMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages.IInlineMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Show (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_show_Landroid_content_Context_Landroid_content_Intent_;
		public unsafe void Show (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_show_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_show_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "show", "(Landroid/content/Context;Landroid/content/Intent;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_show_Landroid_content_Context_Landroid_content_Intent_, __args);
		}

	}

}
