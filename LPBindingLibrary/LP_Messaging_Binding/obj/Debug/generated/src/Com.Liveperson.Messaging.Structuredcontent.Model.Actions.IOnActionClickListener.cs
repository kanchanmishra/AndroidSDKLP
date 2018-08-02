using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Structuredcontent.Model.Actions {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.actions']/interface[@name='OnActionClickListener']"
	[Register ("com/liveperson/messaging/structuredcontent/model/actions/OnActionClickListener", "", "Com.Liveperson.Messaging.Structuredcontent.Model.Actions.IOnActionClickListenerInvoker")]
	public partial interface IOnActionClickListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.actions']/interface[@name='OnActionClickListener']/method[@name='onClick' and count(parameter)=0]"
		[Register ("onClick", "()V", "GetOnClickHandler:Com.Liveperson.Messaging.Structuredcontent.Model.Actions.IOnActionClickListenerInvoker, LP_Messaging_Binding")]
		void OnClick ();

	}

	[global::Android.Runtime.Register ("com/liveperson/messaging/structuredcontent/model/actions/OnActionClickListener", DoNotGenerateAcw=true)]
	internal class IOnActionClickListenerInvoker : global::Java.Lang.Object, IOnActionClickListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/messaging/structuredcontent/model/actions/OnActionClickListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnActionClickListenerInvoker); }
		}

		IntPtr class_ref;

		public static IOnActionClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnActionClickListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.messaging.structuredcontent.model.actions.OnActionClickListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnActionClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.IOnActionClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.IOnActionClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	[global::Android.Runtime.Register ("mono/com/liveperson/messaging/structuredcontent/model/actions/OnActionClickListenerImplementor")]
	internal sealed partial class IOnActionClickListenerImplementor : global::Java.Lang.Object, IOnActionClickListener {

		object sender;

		public IOnActionClickListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/liveperson/messaging/structuredcontent/model/actions/OnActionClickListenerImplementor", "()V"),
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

		internal static bool __IsEmpty (IOnActionClickListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
