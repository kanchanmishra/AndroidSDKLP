using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AttachmentMenu']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/AttachmentMenu", DoNotGenerateAcw=true)]
	public partial class AttachmentMenu : global::Android.Widget.LinearLayout, global::Com.Liveperson.Infra.UI.View.Uicomponents.IOverflowMenu {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/interface[@name='AttachmentMenu.AttachmentMenuListener']"
		[Register ("com/liveperson/infra/messaging_ui/uicomponents/AttachmentMenu$AttachmentMenuListener", "", "Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu/IAttachmentMenuListenerInvoker")]
		public partial interface IAttachmentMenuListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/interface[@name='AttachmentMenu.AttachmentMenuListener']/method[@name='onCameraButtonPressed' and count(parameter)=0]"
			[Register ("onCameraButtonPressed", "()V", "GetOnCameraButtonPressedHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu/IAttachmentMenuListenerInvoker, LP_Android_aar_Binding")]
			void OnCameraButtonPressed ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/interface[@name='AttachmentMenu.AttachmentMenuListener']/method[@name='onGalleryButtonPressed' and count(parameter)=0]"
			[Register ("onGalleryButtonPressed", "()V", "GetOnGalleryButtonPressedHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu/IAttachmentMenuListenerInvoker, LP_Android_aar_Binding")]
			void OnGalleryButtonPressed ();

		}

		[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/AttachmentMenu$AttachmentMenuListener", DoNotGenerateAcw=true)]
		internal class IAttachmentMenuListenerInvoker : global::Java.Lang.Object, IAttachmentMenuListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/AttachmentMenu$AttachmentMenuListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IAttachmentMenuListenerInvoker); }
			}

			IntPtr class_ref;

			public static IAttachmentMenuListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAttachmentMenuListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.messaging_ui.uicomponents.AttachmentMenu.AttachmentMenuListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAttachmentMenuListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCameraButtonPressed;
#pragma warning disable 0169
			static Delegate GetOnCameraButtonPressedHandler ()
			{
				if (cb_onCameraButtonPressed == null)
					cb_onCameraButtonPressed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCameraButtonPressed);
				return cb_onCameraButtonPressed;
			}

			static void n_OnCameraButtonPressed (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu.IAttachmentMenuListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu.IAttachmentMenuListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraButtonPressed ();
			}
#pragma warning restore 0169

			IntPtr id_onCameraButtonPressed;
			public unsafe void OnCameraButtonPressed ()
			{
				if (id_onCameraButtonPressed == IntPtr.Zero)
					id_onCameraButtonPressed = JNIEnv.GetMethodID (class_ref, "onCameraButtonPressed", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraButtonPressed);
			}

			static Delegate cb_onGalleryButtonPressed;
#pragma warning disable 0169
			static Delegate GetOnGalleryButtonPressedHandler ()
			{
				if (cb_onGalleryButtonPressed == null)
					cb_onGalleryButtonPressed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnGalleryButtonPressed);
				return cb_onGalleryButtonPressed;
			}

			static void n_OnGalleryButtonPressed (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu.IAttachmentMenuListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu.IAttachmentMenuListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnGalleryButtonPressed ();
			}
#pragma warning restore 0169

			IntPtr id_onGalleryButtonPressed;
			public unsafe void OnGalleryButtonPressed ()
			{
				if (id_onGalleryButtonPressed == IntPtr.Zero)
					id_onGalleryButtonPressed = JNIEnv.GetMethodID (class_ref, "onGalleryButtonPressed", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGalleryButtonPressed);
			}

		}

		[global::Android.Runtime.Register ("mono/com/liveperson/infra/messaging_ui/uicomponents/AttachmentMenu_AttachmentMenuListenerImplementor")]
		internal sealed partial class IAttachmentMenuListenerImplementor : global::Java.Lang.Object, IAttachmentMenuListener {

			object sender;

			public IAttachmentMenuListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/liveperson/infra/messaging_ui/uicomponents/AttachmentMenu_AttachmentMenuListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnCameraButtonPressedHandler;
#pragma warning restore 0649

			public void OnCameraButtonPressed ()
			{
				var __h = OnCameraButtonPressedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnGalleryButtonPressedHandler;
#pragma warning restore 0649

			public void OnGalleryButtonPressed ()
			{
				var __h = OnGalleryButtonPressedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IAttachmentMenuListenerImplementor value)
			{
				return value.OnCameraButtonPressedHandler == null && value.OnGalleryButtonPressedHandler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/AttachmentMenu", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AttachmentMenu); }
		}

		protected AttachmentMenu (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AttachmentMenu']/constructor[@name='AttachmentMenu' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe AttachmentMenu (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (AttachmentMenu)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AttachmentMenu']/constructor[@name='AttachmentMenu' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe AttachmentMenu (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (AttachmentMenu)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AttachmentMenu']/constructor[@name='AttachmentMenu' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AttachmentMenu (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AttachmentMenu)) {
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

		static Delegate cb_isMenuOpen;
#pragma warning disable 0169
		static Delegate GetIsMenuOpenHandler ()
		{
			if (cb_isMenuOpen == null)
				cb_isMenuOpen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMenuOpen);
			return cb_isMenuOpen;
		}

		static bool n_IsMenuOpen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMenuOpen;
		}
#pragma warning restore 0169

		static IntPtr id_isMenuOpen;
		public virtual unsafe bool IsMenuOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AttachmentMenu']/method[@name='isMenuOpen' and count(parameter)=0]"
			[Register ("isMenuOpen", "()Z", "GetIsMenuOpenHandler")]
			get {
				if (id_isMenuOpen == IntPtr.Zero)
					id_isMenuOpen = JNIEnv.GetMethodID (class_ref, "isMenuOpen", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMenuOpen);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMenuOpen", "()Z"));
				} finally {
				}
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
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Hide ();
		}
#pragma warning restore 0169

		static IntPtr id_hide;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AttachmentMenu']/method[@name='hide' and count(parameter)=0]"
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

		static Delegate cb_setListener_Lcom_liveperson_infra_messaging_ui_uicomponents_AttachmentMenu_AttachmentMenuListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_liveperson_infra_messaging_ui_uicomponents_AttachmentMenu_AttachmentMenuListener_Handler ()
		{
			if (cb_setListener_Lcom_liveperson_infra_messaging_ui_uicomponents_AttachmentMenu_AttachmentMenuListener_ == null)
				cb_setListener_Lcom_liveperson_infra_messaging_ui_uicomponents_AttachmentMenu_AttachmentMenuListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListener_Lcom_liveperson_infra_messaging_ui_uicomponents_AttachmentMenu_AttachmentMenuListener_);
			return cb_setListener_Lcom_liveperson_infra_messaging_ui_uicomponents_AttachmentMenu_AttachmentMenuListener_;
		}

		static void n_SetListener_Lcom_liveperson_infra_messaging_ui_uicomponents_AttachmentMenu_AttachmentMenuListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu.IAttachmentMenuListener p0 = (global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu.IAttachmentMenuListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu.IAttachmentMenuListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setListener_Lcom_liveperson_infra_messaging_ui_uicomponents_AttachmentMenu_AttachmentMenuListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AttachmentMenu']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.messaging_ui.uicomponents.AttachmentMenu.AttachmentMenuListener']]"
		[Register ("setListener", "(Lcom/liveperson/infra/messaging_ui/uicomponents/AttachmentMenu$AttachmentMenuListener;)V", "GetSetListener_Lcom_liveperson_infra_messaging_ui_uicomponents_AttachmentMenu_AttachmentMenuListener_Handler")]
		public virtual unsafe void SetListener (global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu.IAttachmentMenuListener p0)
		{
			if (id_setListener_Lcom_liveperson_infra_messaging_ui_uicomponents_AttachmentMenu_AttachmentMenuListener_ == IntPtr.Zero)
				id_setListener_Lcom_liveperson_infra_messaging_ui_uicomponents_AttachmentMenu_AttachmentMenuListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcom/liveperson/infra/messaging_ui/uicomponents/AttachmentMenu$AttachmentMenuListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setListener_Lcom_liveperson_infra_messaging_ui_uicomponents_AttachmentMenu_AttachmentMenuListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setListener", "(Lcom/liveperson/infra/messaging_ui/uicomponents/AttachmentMenu$AttachmentMenuListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnCloseListener_Lcom_liveperson_infra_ui_view_uicomponents_ICloseMenuListener_;
#pragma warning disable 0169
		static Delegate GetSetOnCloseListener_Lcom_liveperson_infra_ui_view_uicomponents_ICloseMenuListener_Handler ()
		{
			if (cb_setOnCloseListener_Lcom_liveperson_infra_ui_view_uicomponents_ICloseMenuListener_ == null)
				cb_setOnCloseListener_Lcom_liveperson_infra_ui_view_uicomponents_ICloseMenuListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnCloseListener_Lcom_liveperson_infra_ui_view_uicomponents_ICloseMenuListener_);
			return cb_setOnCloseListener_Lcom_liveperson_infra_ui_view_uicomponents_ICloseMenuListener_;
		}

		static void n_SetOnCloseListener_Lcom_liveperson_infra_ui_view_uicomponents_ICloseMenuListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.UI.View.Uicomponents.ICloseMenuListener p0 = (global::Com.Liveperson.Infra.UI.View.Uicomponents.ICloseMenuListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.ICloseMenuListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnCloseListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnCloseListener_Lcom_liveperson_infra_ui_view_uicomponents_ICloseMenuListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AttachmentMenu']/method[@name='setOnCloseListener' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.ui.view.uicomponents.ICloseMenuListener']]"
		[Register ("setOnCloseListener", "(Lcom/liveperson/infra/ui/view/uicomponents/ICloseMenuListener;)V", "GetSetOnCloseListener_Lcom_liveperson_infra_ui_view_uicomponents_ICloseMenuListener_Handler")]
		public virtual unsafe void SetOnCloseListener (global::Com.Liveperson.Infra.UI.View.Uicomponents.ICloseMenuListener p0)
		{
			if (id_setOnCloseListener_Lcom_liveperson_infra_ui_view_uicomponents_ICloseMenuListener_ == IntPtr.Zero)
				id_setOnCloseListener_Lcom_liveperson_infra_ui_view_uicomponents_ICloseMenuListener_ = JNIEnv.GetMethodID (class_ref, "setOnCloseListener", "(Lcom/liveperson/infra/ui/view/uicomponents/ICloseMenuListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnCloseListener_Lcom_liveperson_infra_ui_view_uicomponents_ICloseMenuListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnCloseListener", "(Lcom/liveperson/infra/ui/view/uicomponents/ICloseMenuListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_show;
#pragma warning disable 0169
		static Delegate GetShowHandler ()
		{
			if (cb_show == null)
				cb_show = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Show);
			return cb_show;
		}

		static void n_Show (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Show ();
		}
#pragma warning restore 0169

		static IntPtr id_show;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AttachmentMenu']/method[@name='show' and count(parameter)=0]"
		[Register ("show", "()V", "GetShowHandler")]
		public virtual unsafe void Show ()
		{
			if (id_show == IntPtr.Zero)
				id_show = JNIEnv.GetMethodID (class_ref, "show", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_show);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "show", "()V"));
			} finally {
			}
		}

#region "Event implementation for Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu.IAttachmentMenuListener"

		global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu.IAttachmentMenuListenerImplementor __CreateIAttachmentMenuListenerImplementor ()
		{
			return new global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu.IAttachmentMenuListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Liveperson.Infra.UI.View.Uicomponents.ICloseMenuListener"
		public event EventHandler Close {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Liveperson.Infra.UI.View.Uicomponents.ICloseMenuListener, global::Com.Liveperson.Infra.UI.View.Uicomponents.ICloseMenuListenerImplementor>(
						ref weak_implementor_SetOnCloseListener,
						__CreateICloseMenuListenerImplementor,
						SetOnCloseListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Liveperson.Infra.UI.View.Uicomponents.ICloseMenuListener, global::Com.Liveperson.Infra.UI.View.Uicomponents.ICloseMenuListenerImplementor>(
						ref weak_implementor_SetOnCloseListener,
						global::Com.Liveperson.Infra.UI.View.Uicomponents.ICloseMenuListenerImplementor.__IsEmpty,
						__v => SetOnCloseListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnCloseListener;

		global::Com.Liveperson.Infra.UI.View.Uicomponents.ICloseMenuListenerImplementor __CreateICloseMenuListenerImplementor ()
		{
			return new global::Com.Liveperson.Infra.UI.View.Uicomponents.ICloseMenuListenerImplementor (this);
		}
#endregion
	}
}
