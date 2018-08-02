using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsBrandMsgViewHolder']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsBrandMsgViewHolder", DoNotGenerateAcw=true)]
	public partial class AmsBrandMsgViewHolder : global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.StartViewHolder, global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.IAmsViewHolder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsBrandMsgViewHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsBrandMsgViewHolder); }
		}

		protected AmsBrandMsgViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsBrandMsgViewHolder']/constructor[@name='AmsBrandMsgViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/view/View;)V", "")]
		public unsafe AmsBrandMsgViewHolder (global::Android.Views.View p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AmsBrandMsgViewHolder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/view/View;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/view/View;)V", __args);
					return;
				}

				if (id_ctor_Landroid_view_View_ == IntPtr.Zero)
					id_ctor_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_view_View_, __args);
			} finally {
			}
		}

		static Delegate cb_applyColors;
#pragma warning disable 0169
		static Delegate GetApplyColorsHandler ()
		{
			if (cb_applyColors == null)
				cb_applyColors = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ApplyColors);
			return cb_applyColors;
		}

		static void n_ApplyColors (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsBrandMsgViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsBrandMsgViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ApplyColors ();
		}
#pragma warning restore 0169

		static IntPtr id_applyColors;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsBrandMsgViewHolder']/method[@name='applyColors' and count(parameter)=0]"
		[Register ("applyColors", "()V", "GetApplyColorsHandler")]
		public virtual unsafe void ApplyColors ()
		{
			if (id_applyColors == IntPtr.Zero)
				id_applyColors = JNIEnv.GetMethodID (class_ref, "applyColors", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_applyColors);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "applyColors", "()V"));
			} finally {
			}
		}

		static Delegate cb_setMessageText_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSetMessageText_Ljava_lang_String_ZHandler ()
		{
			if (cb_setMessageText_Ljava_lang_String_Z == null)
				cb_setMessageText_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetMessageText_Ljava_lang_String_Z);
			return cb_setMessageText_Ljava_lang_String_Z;
		}

		static void n_SetMessageText_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsBrandMsgViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsBrandMsgViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMessageText (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setMessageText_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsBrandMsgViewHolder']/method[@name='setMessageText' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("setMessageText", "(Ljava/lang/String;Z)V", "GetSetMessageText_Ljava_lang_String_ZHandler")]
		public virtual unsafe void SetMessageText (string p0, bool p1)
		{
			if (id_setMessageText_Ljava_lang_String_Z == IntPtr.Zero)
				id_setMessageText_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "setMessageText", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessageText_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageText", "(Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
