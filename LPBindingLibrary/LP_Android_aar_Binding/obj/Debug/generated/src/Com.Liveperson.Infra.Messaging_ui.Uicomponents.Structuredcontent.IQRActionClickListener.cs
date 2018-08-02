using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent']/interface[@name='QRActionClickListener']"
	[Register ("com/liveperson/infra/messaging_ui/uicomponents/structuredcontent/QRActionClickListener", "", "Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListenerInvoker")]
	public partial interface IQRActionClickListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.structuredcontent']/interface[@name='QRActionClickListener']/method[@name='onClick' and count(parameter)=0]"
		[Register ("onClick", "()V", "GetOnClickHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListenerInvoker, LP_Android_aar_Binding")]
		void OnClick ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/structuredcontent/QRActionClickListener", DoNotGenerateAcw=true)]
	internal class IQRActionClickListenerInvoker : global::Java.Lang.Object, IQRActionClickListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/structuredcontent/QRActionClickListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IQRActionClickListenerInvoker); }
		}

		IntPtr class_ref;

		public static IQRActionClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IQRActionClickListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.QRActionClickListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IQRActionClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onClick;
#pragma warning disable 0169
		static Delegate GetOnClickHandler ()
		{
			if (cb_onClick == null)
				cb_onClick = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnClick);
			return cb_onClick;
		}

		static void n_OnClick (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnClick ();
		}
#pragma warning restore 0169

		IntPtr id_onClick;
		public unsafe void OnClick ()
		{
			if (id_onClick == IntPtr.Zero)
				id_onClick = JNIEnv.GetMethodID (class_ref, "onClick", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClick);
		}

	}

	[global::Android.Runtime.Register ("mono/com/liveperson/infra/messaging_ui/uicomponents/structuredcontent/QRActionClickListenerImplementor")]
	internal sealed partial class IQRActionClickListenerImplementor : global::Java.Lang.Object, IQRActionClickListener {

		object sender;

		public IQRActionClickListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/liveperson/infra/messaging_ui/uicomponents/structuredcontent/QRActionClickListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void OnClick ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IQRActionClickListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
