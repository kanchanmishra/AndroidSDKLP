using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.inlinemessages']/class[@name='OffHours']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/inlinemessages/OffHours", DoNotGenerateAcw=true)]
	public partial class OffHours : global::Java.Lang.Object, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages.IInlineMessage {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/inlinemessages/OffHours", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OffHours); }
		}

		protected OffHours (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_res_Resources_Landroid_widget_TextView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.inlinemessages']/class[@name='OffHours']/constructor[@name='OffHours' and count(parameter)=2 and parameter[1][@type='android.content.res.Resources'] and parameter[2][@type='android.widget.TextView']]"
		[Register (".ctor", "(Landroid/content/res/Resources;Landroid/widget/TextView;)V", "")]
		public unsafe OffHours (global::Android.Content.Res.Resources res, global::Android.Widget.TextView view)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (res);
				__args [1] = new JValue (view);
				if (((object) this).GetType () != typeof (OffHours)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/res/Resources;Landroid/widget/TextView;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/res/Resources;Landroid/widget/TextView;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_res_Resources_Landroid_widget_TextView_ == IntPtr.Zero)
					id_ctor_Landroid_content_res_Resources_Landroid_widget_TextView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/res/Resources;Landroid/widget/TextView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_res_Resources_Landroid_widget_TextView_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_res_Resources_Landroid_widget_TextView_, __args);
			} finally {
			}
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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages.OffHours __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages.OffHours> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Hide ();
		}
#pragma warning restore 0169

		static IntPtr id_hide;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.inlinemessages']/class[@name='OffHours']/method[@name='hide' and count(parameter)=0]"
		[Register ("hide", "()V", "GetHideHandler")]
		public virtual unsafe void Hide ()
		{
			if (id_hide == IntPtr.Zero)
				id_hide = JNIEnv.GetMethodID (class_ref, "hide", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hide);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hide", "()V"));
			} finally {
			}
		}

		static Delegate cb_show_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetShow_Landroid_content_Context_Landroid_content_Intent_Handler ()
		{
			if (cb_show_Landroid_content_Context_Landroid_content_Intent_ == null)
				cb_show_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Show_Landroid_content_Context_Landroid_content_Intent_);
			return cb_show_Landroid_content_Context_Landroid_content_Intent_;
		}

		static void n_Show_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_intent)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages.OffHours __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages.OffHours> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			__this.Show (context, intent);
		}
#pragma warning restore 0169

		static IntPtr id_show_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.inlinemessages']/class[@name='OffHours']/method[@name='show' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("show", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetShow_Landroid_content_Context_Landroid_content_Intent_Handler")]
		public virtual unsafe void Show (global::Android.Content.Context context, global::Android.Content.Intent intent)
		{
			if (id_show_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_show_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "show", "(Landroid/content/Context;Landroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (intent);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_show_Landroid_content_Context_Landroid_content_Intent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "show", "(Landroid/content/Context;Landroid/content/Intent;)V"), __args);
			} finally {
			}
		}

	}
}
