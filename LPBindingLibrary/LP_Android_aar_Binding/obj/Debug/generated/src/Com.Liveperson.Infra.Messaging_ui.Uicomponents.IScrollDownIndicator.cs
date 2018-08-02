using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='IScrollDownIndicator.NullImplementation']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/IScrollDownIndicator$NullImplementation", DoNotGenerateAcw=true)]
	public partial class ScrollDownIndicatorNullImplementation : global::Java.Lang.Object, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.IScrollDownIndicator {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/IScrollDownIndicator$NullImplementation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScrollDownIndicatorNullImplementation); }
		}

		protected ScrollDownIndicatorNullImplementation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='IScrollDownIndicator.NullImplementation']/constructor[@name='IScrollDownIndicator.NullImplementation' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ScrollDownIndicatorNullImplementation ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ScrollDownIndicatorNullImplementation)) {
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

		static Delegate cb_isExpand;
#pragma warning disable 0169
		static Delegate GetIsExpandHandler ()
		{
			if (cb_isExpand == null)
				cb_isExpand = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsExpand);
			return cb_isExpand;
		}

		static bool n_IsExpand (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ScrollDownIndicatorNullImplementation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ScrollDownIndicatorNullImplementation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExpand;
		}
#pragma warning restore 0169

		static IntPtr id_isExpand;
		public virtual unsafe bool IsExpand {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='IScrollDownIndicator.NullImplementation']/method[@name='isExpand' and count(parameter)=0]"
			[Register ("isExpand", "()Z", "GetIsExpandHandler")]
			get {
				if (id_isExpand == IntPtr.Zero)
					id_isExpand = JNIEnv.GetMethodID (class_ref, "isExpand", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isExpand);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isExpand", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_resetAndHide;
#pragma warning disable 0169
		static Delegate GetResetAndHideHandler ()
		{
			if (cb_resetAndHide == null)
				cb_resetAndHide = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetAndHide);
			return cb_resetAndHide;
		}

		static void n_ResetAndHide (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ScrollDownIndicatorNullImplementation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ScrollDownIndicatorNullImplementation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetAndHide ();
		}
#pragma warning restore 0169

		static IntPtr id_resetAndHide;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='IScrollDownIndicator.NullImplementation']/method[@name='resetAndHide' and count(parameter)=0]"
		[Register ("resetAndHide", "()V", "GetResetAndHideHandler")]
		public virtual unsafe void ResetAndHide ()
		{
			if (id_resetAndHide == IntPtr.Zero)
				id_resetAndHide = JNIEnv.GetMethodID (class_ref, "resetAndHide", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetAndHide);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetAndHide", "()V"));
			} finally {
			}
		}

		static Delegate cb_resetAndShowCollapsed;
#pragma warning disable 0169
		static Delegate GetResetAndShowCollapsedHandler ()
		{
			if (cb_resetAndShowCollapsed == null)
				cb_resetAndShowCollapsed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetAndShowCollapsed);
			return cb_resetAndShowCollapsed;
		}

		static void n_ResetAndShowCollapsed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ScrollDownIndicatorNullImplementation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ScrollDownIndicatorNullImplementation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetAndShowCollapsed ();
		}
#pragma warning restore 0169

		static IntPtr id_resetAndShowCollapsed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='IScrollDownIndicator.NullImplementation']/method[@name='resetAndShowCollapsed' and count(parameter)=0]"
		[Register ("resetAndShowCollapsed", "()V", "GetResetAndShowCollapsedHandler")]
		public virtual unsafe void ResetAndShowCollapsed ()
		{
			if (id_resetAndShowCollapsed == IntPtr.Zero)
				id_resetAndShowCollapsed = JNIEnv.GetMethodID (class_ref, "resetAndShowCollapsed", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetAndShowCollapsed);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetAndShowCollapsed", "()V"));
			} finally {
			}
		}

		static Delegate cb_setOnClickListener_Landroid_view_View_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnClickListener_Landroid_view_View_OnClickListener_Handler ()
		{
			if (cb_setOnClickListener_Landroid_view_View_OnClickListener_ == null)
				cb_setOnClickListener_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnClickListener_Landroid_view_View_OnClickListener_);
			return cb_setOnClickListener_Landroid_view_View_OnClickListener_;
		}

		static void n_SetOnClickListener_Landroid_view_View_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ScrollDownIndicatorNullImplementation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ScrollDownIndicatorNullImplementation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View.IOnClickListener p0 = (global::Android.Views.View.IOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnClickListener_Landroid_view_View_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='IScrollDownIndicator.NullImplementation']/method[@name='setOnClickListener' and count(parameter)=1 and parameter[1][@type='android.view.View.OnClickListener']]"
		[Register ("setOnClickListener", "(Landroid/view/View$OnClickListener;)V", "GetSetOnClickListener_Landroid_view_View_OnClickListener_Handler")]
		public virtual unsafe void SetOnClickListener (global::Android.Views.View.IOnClickListener p0)
		{
			if (id_setOnClickListener_Landroid_view_View_OnClickListener_ == IntPtr.Zero)
				id_setOnClickListener_Landroid_view_View_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnClickListener", "(Landroid/view/View$OnClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnClickListener_Landroid_view_View_OnClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnClickListener", "(Landroid/view/View$OnClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_show_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShow_ILjava_lang_String_Handler ()
		{
			if (cb_show_ILjava_lang_String_ == null)
				cb_show_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Show_ILjava_lang_String_);
			return cb_show_ILjava_lang_String_;
		}

		static void n_Show_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ScrollDownIndicatorNullImplementation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ScrollDownIndicatorNullImplementation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Show (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_show_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='IScrollDownIndicator.NullImplementation']/method[@name='show' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("show", "(ILjava/lang/String;)V", "GetShow_ILjava_lang_String_Handler")]
		public virtual unsafe void Show (int p0, string p1)
		{
			if (id_show_ILjava_lang_String_ == IntPtr.Zero)
				id_show_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "show", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_show_ILjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "show", "(ILjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/interface[@name='IScrollDownIndicator']"
	[Register ("com/liveperson/infra/messaging_ui/uicomponents/IScrollDownIndicator", "", "Com.Liveperson.Infra.Messaging_ui.Uicomponents.IScrollDownIndicatorInvoker")]
	public partial interface IScrollDownIndicator : IJavaObject {

		bool IsExpand {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/interface[@name='IScrollDownIndicator']/method[@name='isExpand' and count(parameter)=0]"
			[Register ("isExpand", "()Z", "GetIsExpandHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.IScrollDownIndicatorInvoker, LP_Android_aar_Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/interface[@name='IScrollDownIndicator']/method[@name='resetAndHide' and count(parameter)=0]"
		[Register ("resetAndHide", "()V", "GetResetAndHideHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.IScrollDownIndicatorInvoker, LP_Android_aar_Binding")]
		void ResetAndHide ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/interface[@name='IScrollDownIndicator']/method[@name='resetAndShowCollapsed' and count(parameter)=0]"
		[Register ("resetAndShowCollapsed", "()V", "GetResetAndShowCollapsedHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.IScrollDownIndicatorInvoker, LP_Android_aar_Binding")]
		void ResetAndShowCollapsed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/interface[@name='IScrollDownIndicator']/method[@name='setOnClickListener' and count(parameter)=1 and parameter[1][@type='android.view.View.OnClickListener']]"
		[Register ("setOnClickListener", "(Landroid/view/View$OnClickListener;)V", "GetSetOnClickListener_Landroid_view_View_OnClickListener_Handler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.IScrollDownIndicatorInvoker, LP_Android_aar_Binding")]
		void SetOnClickListener (global::Android.Views.View.IOnClickListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/interface[@name='IScrollDownIndicator']/method[@name='show' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("show", "(ILjava/lang/String;)V", "GetShow_ILjava_lang_String_Handler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.IScrollDownIndicatorInvoker, LP_Android_aar_Binding")]
		void Show (int p0, string p1);

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/IScrollDownIndicator", DoNotGenerateAcw=true)]
	internal class IScrollDownIndicatorInvoker : global::Java.Lang.Object, IScrollDownIndicator {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/IScrollDownIndicator");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IScrollDownIndicatorInvoker); }
		}

		IntPtr class_ref;

		public static IScrollDownIndicator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IScrollDownIndicator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.messaging_ui.uicomponents.IScrollDownIndicator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IScrollDownIndicatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isExpand;
#pragma warning disable 0169
		static Delegate GetIsExpandHandler ()
		{
			if (cb_isExpand == null)
				cb_isExpand = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsExpand);
			return cb_isExpand;
		}

		static bool n_IsExpand (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.IScrollDownIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.IScrollDownIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExpand;
		}
#pragma warning restore 0169

		IntPtr id_isExpand;
		public unsafe bool IsExpand {
			get {
				if (id_isExpand == IntPtr.Zero)
					id_isExpand = JNIEnv.GetMethodID (class_ref, "isExpand", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isExpand);
			}
		}

		static Delegate cb_resetAndHide;
#pragma warning disable 0169
		static Delegate GetResetAndHideHandler ()
		{
			if (cb_resetAndHide == null)
				cb_resetAndHide = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetAndHide);
			return cb_resetAndHide;
		}

		static void n_ResetAndHide (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.IScrollDownIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.IScrollDownIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetAndHide ();
		}
#pragma warning restore 0169

		IntPtr id_resetAndHide;
		public unsafe void ResetAndHide ()
		{
			if (id_resetAndHide == IntPtr.Zero)
				id_resetAndHide = JNIEnv.GetMethodID (class_ref, "resetAndHide", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetAndHide);
		}

		static Delegate cb_resetAndShowCollapsed;
#pragma warning disable 0169
		static Delegate GetResetAndShowCollapsedHandler ()
		{
			if (cb_resetAndShowCollapsed == null)
				cb_resetAndShowCollapsed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetAndShowCollapsed);
			return cb_resetAndShowCollapsed;
		}

		static void n_ResetAndShowCollapsed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.IScrollDownIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.IScrollDownIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetAndShowCollapsed ();
		}
#pragma warning restore 0169

		IntPtr id_resetAndShowCollapsed;
		public unsafe void ResetAndShowCollapsed ()
		{
			if (id_resetAndShowCollapsed == IntPtr.Zero)
				id_resetAndShowCollapsed = JNIEnv.GetMethodID (class_ref, "resetAndShowCollapsed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetAndShowCollapsed);
		}

		static Delegate cb_setOnClickListener_Landroid_view_View_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnClickListener_Landroid_view_View_OnClickListener_Handler ()
		{
			if (cb_setOnClickListener_Landroid_view_View_OnClickListener_ == null)
				cb_setOnClickListener_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnClickListener_Landroid_view_View_OnClickListener_);
			return cb_setOnClickListener_Landroid_view_View_OnClickListener_;
		}

		static void n_SetOnClickListener_Landroid_view_View_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.IScrollDownIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.IScrollDownIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View.IOnClickListener p0 = (global::Android.Views.View.IOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnClickListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setOnClickListener_Landroid_view_View_OnClickListener_;
		public unsafe void SetOnClickListener (global::Android.Views.View.IOnClickListener p0)
		{
			if (id_setOnClickListener_Landroid_view_View_OnClickListener_ == IntPtr.Zero)
				id_setOnClickListener_Landroid_view_View_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnClickListener", "(Landroid/view/View$OnClickListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnClickListener_Landroid_view_View_OnClickListener_, __args);
		}

		static Delegate cb_show_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShow_ILjava_lang_String_Handler ()
		{
			if (cb_show_ILjava_lang_String_ == null)
				cb_show_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Show_ILjava_lang_String_);
			return cb_show_ILjava_lang_String_;
		}

		static void n_Show_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.IScrollDownIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.IScrollDownIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Show (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_show_ILjava_lang_String_;
		public unsafe void Show (int p0, string p1)
		{
			if (id_show_ILjava_lang_String_ == IntPtr.Zero)
				id_show_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "show", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_show_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
