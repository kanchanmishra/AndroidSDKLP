using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents.List {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/interface[@name='ChatMessageBgFgListener']"
	[Register ("com/liveperson/infra/messaging_ui/uicomponents/list/ChatMessageBgFgListener", "", "Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.IChatMessageBgFgListenerInvoker")]
	public partial interface IChatMessageBgFgListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/interface[@name='ChatMessageBgFgListener']/method[@name='onBackground' and count(parameter)=0]"
		[Register ("onBackground", "()V", "GetOnBackgroundHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.IChatMessageBgFgListenerInvoker, LP_Android_aar_Binding")]
		void OnBackground ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/interface[@name='ChatMessageBgFgListener']/method[@name='onForeground' and count(parameter)=0]"
		[Register ("onForeground", "()V", "GetOnForegroundHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.IChatMessageBgFgListenerInvoker, LP_Android_aar_Binding")]
		void OnForeground ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/list/ChatMessageBgFgListener", DoNotGenerateAcw=true)]
	internal class IChatMessageBgFgListenerInvoker : global::Java.Lang.Object, IChatMessageBgFgListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/list/ChatMessageBgFgListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IChatMessageBgFgListenerInvoker); }
		}

		IntPtr class_ref;

		public static IChatMessageBgFgListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IChatMessageBgFgListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.messaging_ui.uicomponents.list.ChatMessageBgFgListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IChatMessageBgFgListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBackground;
#pragma warning disable 0169
		static Delegate GetOnBackgroundHandler ()
		{
			if (cb_onBackground == null)
				cb_onBackground = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBackground);
			return cb_onBackground;
		}

		static void n_OnBackground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.IChatMessageBgFgListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.IChatMessageBgFgListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBackground ();
		}
#pragma warning restore 0169

		IntPtr id_onBackground;
		public unsafe void OnBackground ()
		{
			if (id_onBackground == IntPtr.Zero)
				id_onBackground = JNIEnv.GetMethodID (class_ref, "onBackground", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBackground);
		}

		static Delegate cb_onForeground;
#pragma warning disable 0169
		static Delegate GetOnForegroundHandler ()
		{
			if (cb_onForeground == null)
				cb_onForeground = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnForeground);
			return cb_onForeground;
		}

		static void n_OnForeground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.IChatMessageBgFgListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.IChatMessageBgFgListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnForeground ();
		}
#pragma warning restore 0169

		IntPtr id_onForeground;
		public unsafe void OnForeground ()
		{
			if (id_onForeground == IntPtr.Zero)
				id_onForeground = JNIEnv.GetMethodID (class_ref, "onForeground", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onForeground);
		}

	}

	[global::Android.Runtime.Register ("mono/com/liveperson/infra/messaging_ui/uicomponents/list/ChatMessageBgFgListenerImplementor")]
	internal sealed partial class IChatMessageBgFgListenerImplementor : global::Java.Lang.Object, IChatMessageBgFgListener {

		object sender;

		public IChatMessageBgFgListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/liveperson/infra/messaging_ui/uicomponents/list/ChatMessageBgFgListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler OnBackgroundHandler;
#pragma warning restore 0649

		public void OnBackground ()
		{
			var __h = OnBackgroundHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnForegroundHandler;
#pragma warning restore 0649

		public void OnForeground ()
		{
			var __h = OnForegroundHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IChatMessageBgFgListenerImplementor value)
		{
			return value.OnBackgroundHandler == null && value.OnForegroundHandler == null;
		}
	}

}
