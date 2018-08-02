using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Fragment {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/interface[@name='IFeedbackActions']"
	[Register ("com/liveperson/infra/messaging_ui/fragment/IFeedbackActions", "", "Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActionsInvoker")]
	public partial interface IFeedbackActions : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/interface[@name='IFeedbackActions']/method[@name='closeFeedBackScreen' and count(parameter)=0]"
		[Register ("closeFeedBackScreen", "()V", "GetCloseFeedBackScreenHandler:Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActionsInvoker, LP_Android_aar_Binding")]
		void CloseFeedBackScreen ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/interface[@name='IFeedbackActions']/method[@name='skipFeedBackScreen' and count(parameter)=0]"
		[Register ("skipFeedBackScreen", "()V", "GetSkipFeedBackScreenHandler:Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActionsInvoker, LP_Android_aar_Binding")]
		void SkipFeedBackScreen ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/fragment/IFeedbackActions", DoNotGenerateAcw=true)]
	internal class IFeedbackActionsInvoker : global::Java.Lang.Object, IFeedbackActions {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/fragment/IFeedbackActions");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFeedbackActionsInvoker); }
		}

		IntPtr class_ref;

		public static IFeedbackActions GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFeedbackActions> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.messaging_ui.fragment.IFeedbackActions"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFeedbackActionsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_closeFeedBackScreen;
#pragma warning disable 0169
		static Delegate GetCloseFeedBackScreenHandler ()
		{
			if (cb_closeFeedBackScreen == null)
				cb_closeFeedBackScreen = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CloseFeedBackScreen);
			return cb_closeFeedBackScreen;
		}

		static void n_CloseFeedBackScreen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseFeedBackScreen ();
		}
#pragma warning restore 0169

		IntPtr id_closeFeedBackScreen;
		public unsafe void CloseFeedBackScreen ()
		{
			if (id_closeFeedBackScreen == IntPtr.Zero)
				id_closeFeedBackScreen = JNIEnv.GetMethodID (class_ref, "closeFeedBackScreen", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeFeedBackScreen);
		}

		static Delegate cb_skipFeedBackScreen;
#pragma warning disable 0169
		static Delegate GetSkipFeedBackScreenHandler ()
		{
			if (cb_skipFeedBackScreen == null)
				cb_skipFeedBackScreen = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SkipFeedBackScreen);
			return cb_skipFeedBackScreen;
		}

		static void n_SkipFeedBackScreen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SkipFeedBackScreen ();
		}
#pragma warning restore 0169

		IntPtr id_skipFeedBackScreen;
		public unsafe void SkipFeedBackScreen ()
		{
			if (id_skipFeedBackScreen == IntPtr.Zero)
				id_skipFeedBackScreen = JNIEnv.GetMethodID (class_ref, "skipFeedBackScreen", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_skipFeedBackScreen);
		}

	}

}
