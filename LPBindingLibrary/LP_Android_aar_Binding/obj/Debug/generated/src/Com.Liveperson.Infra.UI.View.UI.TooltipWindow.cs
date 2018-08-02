using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.UI {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TooltipWindow']"
	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/ui/TooltipWindow", DoNotGenerateAcw=true)]
	public partial class TooltipWindow : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TooltipWindow']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "TooltipWindow";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/ui/view/ui/TooltipWindow", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TooltipWindow); }
		}

		protected TooltipWindow (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TooltipWindow']/constructor[@name='TooltipWindow' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe TooltipWindow (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (TooltipWindow)) {
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

		static Delegate cb_isTooltipShown;
#pragma warning disable 0169
		static Delegate GetIsTooltipShownHandler ()
		{
			if (cb_isTooltipShown == null)
				cb_isTooltipShown = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTooltipShown);
			return cb_isTooltipShown;
		}

		static bool n_IsTooltipShown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.UI.TooltipWindow __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.TooltipWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTooltipShown;
		}
#pragma warning restore 0169

		static IntPtr id_isTooltipShown;
		public virtual unsafe bool IsTooltipShown {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TooltipWindow']/method[@name='isTooltipShown' and count(parameter)=0]"
			[Register ("isTooltipShown", "()Z", "GetIsTooltipShownHandler")]
			get {
				if (id_isTooltipShown == IntPtr.Zero)
					id_isTooltipShown = JNIEnv.GetMethodID (class_ref, "isTooltipShown", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTooltipShown);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isTooltipShown", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_dismissTooltip;
#pragma warning disable 0169
		static Delegate GetDismissTooltipHandler ()
		{
			if (cb_dismissTooltip == null)
				cb_dismissTooltip = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DismissTooltip);
			return cb_dismissTooltip;
		}

		static void n_DismissTooltip (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.UI.TooltipWindow __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.TooltipWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DismissTooltip ();
		}
#pragma warning restore 0169

		static IntPtr id_dismissTooltip;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TooltipWindow']/method[@name='dismissTooltip' and count(parameter)=0]"
		[Register ("dismissTooltip", "()V", "GetDismissTooltipHandler")]
		public virtual unsafe void DismissTooltip ()
		{
			if (id_dismissTooltip == IntPtr.Zero)
				id_dismissTooltip = JNIEnv.GetMethodID (class_ref, "dismissTooltip", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dismissTooltip);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dismissTooltip", "()V"));
			} finally {
			}
		}

		static Delegate cb_enable_Z;
#pragma warning disable 0169
		static Delegate GetEnable_ZHandler ()
		{
			if (cb_enable_Z == null)
				cb_enable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_Enable_Z);
			return cb_enable_Z;
		}

		static void n_Enable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Infra.UI.View.UI.TooltipWindow __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.TooltipWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Enable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TooltipWindow']/method[@name='enable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enable", "(Z)V", "GetEnable_ZHandler")]
		public virtual unsafe void Enable (bool p0)
		{
			if (id_enable_Z == IntPtr.Zero)
				id_enable_Z = JNIEnv.GetMethodID (class_ref, "enable", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enable_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enable", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_showToolTip_Landroid_view_View_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShowToolTip_Landroid_view_View_Ljava_lang_String_Handler ()
		{
			if (cb_showToolTip_Landroid_view_View_Ljava_lang_String_ == null)
				cb_showToolTip_Landroid_view_View_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ShowToolTip_Landroid_view_View_Ljava_lang_String_);
			return cb_showToolTip_Landroid_view_View_Ljava_lang_String_;
		}

		static void n_ShowToolTip_Landroid_view_View_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.UI.View.UI.TooltipWindow __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.TooltipWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ShowToolTip (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_showToolTip_Landroid_view_View_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TooltipWindow']/method[@name='showToolTip' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.String']]"
		[Register ("showToolTip", "(Landroid/view/View;Ljava/lang/String;)V", "GetShowToolTip_Landroid_view_View_Ljava_lang_String_Handler")]
		public virtual unsafe void ShowToolTip (global::Android.Views.View p0, string p1)
		{
			if (id_showToolTip_Landroid_view_View_Ljava_lang_String_ == IntPtr.Zero)
				id_showToolTip_Landroid_view_View_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "showToolTip", "(Landroid/view/View;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showToolTip_Landroid_view_View_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showToolTip", "(Landroid/view/View;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_showToolTip_Landroid_view_View_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetShowToolTip_Landroid_view_View_Ljava_lang_String_ZHandler ()
		{
			if (cb_showToolTip_Landroid_view_View_Ljava_lang_String_Z == null)
				cb_showToolTip_Landroid_view_View_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_ShowToolTip_Landroid_view_View_Ljava_lang_String_Z);
			return cb_showToolTip_Landroid_view_View_Ljava_lang_String_Z;
		}

		static void n_ShowToolTip_Landroid_view_View_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Com.Liveperson.Infra.UI.View.UI.TooltipWindow __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.TooltipWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ShowToolTip (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_showToolTip_Landroid_view_View_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TooltipWindow']/method[@name='showToolTip' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("showToolTip", "(Landroid/view/View;Ljava/lang/String;Z)V", "GetShowToolTip_Landroid_view_View_Ljava_lang_String_ZHandler")]
		public virtual unsafe void ShowToolTip (global::Android.Views.View p0, string p1, bool p2)
		{
			if (id_showToolTip_Landroid_view_View_Ljava_lang_String_Z == IntPtr.Zero)
				id_showToolTip_Landroid_view_View_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "showToolTip", "(Landroid/view/View;Ljava/lang/String;Z)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showToolTip_Landroid_view_View_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showToolTip", "(Landroid/view/View;Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
