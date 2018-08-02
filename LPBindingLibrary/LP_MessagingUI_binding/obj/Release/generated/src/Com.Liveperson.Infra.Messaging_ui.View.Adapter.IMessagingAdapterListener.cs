using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.View.Adapter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/interface[@name='MessagingAdapterListener']"
	[Register ("com/liveperson/infra/messaging_ui/view/adapter/MessagingAdapterListener", "", "Com.Liveperson.Infra.Messaging_ui.View.Adapter.IMessagingAdapterListenerInvoker")]
	public partial interface IMessagingAdapterListener : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/MessagingAdapterListener", DoNotGenerateAcw=true)]
	internal class IMessagingAdapterListenerInvoker : global::Java.Lang.Object, IMessagingAdapterListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/view/adapter/MessagingAdapterListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMessagingAdapterListenerInvoker); }
		}

		IntPtr class_ref;

		public static IMessagingAdapterListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMessagingAdapterListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.messaging_ui.view.adapter.MessagingAdapterListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMessagingAdapterListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

	[global::Android.Runtime.Register ("mono/com/liveperson/infra/messaging_ui/view/adapter/MessagingAdapterListenerImplementor")]
	internal sealed partial class IMessagingAdapterListenerImplementor : global::Java.Lang.Object, IMessagingAdapterListener {

		public IMessagingAdapterListenerImplementor ()
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/liveperson/infra/messaging_ui/view/adapter/MessagingAdapterListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
		}


		internal static bool __IsEmpty (IMessagingAdapterListenerImplementor value)
		{
			return true;
		}
	}

}
