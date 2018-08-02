using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Uicomponents {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/interface[@name='IEnterMessageListener']"
	[Register ("com/liveperson/infra/ui/view/uicomponents/IEnterMessageListener", "", "Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListenerInvoker")]
	public partial interface IEnterMessageListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/interface[@name='IEnterMessageListener']/method[@name='onMessageSent' and count(parameter)=0]"
		[Register ("onMessageSent", "()V", "GetOnMessageSentHandler:Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListenerInvoker, LP_Android_aar_Binding")]
		void OnMessageSent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/interface[@name='IEnterMessageListener']/method[@name='onVoiceRecordingPermissionRequired' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.IPermissionCallback']]"
		[Register ("onVoiceRecordingPermissionRequired", "(Lcom/liveperson/infra/IPermissionCallback;)V", "GetOnVoiceRecordingPermissionRequired_Lcom_liveperson_infra_IPermissionCallback_Handler:Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListenerInvoker, LP_Android_aar_Binding")]
		void OnVoiceRecordingPermissionRequired (global::Com.Liveperson.Infra.IPermissionCallback p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/uicomponents/IEnterMessageListener", DoNotGenerateAcw=true)]
	internal class IEnterMessageListenerInvoker : global::Java.Lang.Object, IEnterMessageListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/ui/view/uicomponents/IEnterMessageListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IEnterMessageListenerInvoker); }
		}

		IntPtr class_ref;

		public static IEnterMessageListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEnterMessageListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.ui.view.uicomponents.IEnterMessageListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEnterMessageListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onMessageSent;
#pragma warning disable 0169
		static Delegate GetOnMessageSentHandler ()
		{
			if (cb_onMessageSent == null)
				cb_onMessageSent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMessageSent);
			return cb_onMessageSent;
		}

		static void n_OnMessageSent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMessageSent ();
		}
#pragma warning restore 0169

		IntPtr id_onMessageSent;
		public unsafe void OnMessageSent ()
		{
			if (id_onMessageSent == IntPtr.Zero)
				id_onMessageSent = JNIEnv.GetMethodID (class_ref, "onMessageSent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMessageSent);
		}

		static Delegate cb_onVoiceRecordingPermissionRequired_Lcom_liveperson_infra_IPermissionCallback_;
#pragma warning disable 0169
		static Delegate GetOnVoiceRecordingPermissionRequired_Lcom_liveperson_infra_IPermissionCallback_Handler ()
		{
			if (cb_onVoiceRecordingPermissionRequired_Lcom_liveperson_infra_IPermissionCallback_ == null)
				cb_onVoiceRecordingPermissionRequired_Lcom_liveperson_infra_IPermissionCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnVoiceRecordingPermissionRequired_Lcom_liveperson_infra_IPermissionCallback_);
			return cb_onVoiceRecordingPermissionRequired_Lcom_liveperson_infra_IPermissionCallback_;
		}

		static void n_OnVoiceRecordingPermissionRequired_Lcom_liveperson_infra_IPermissionCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.IPermissionCallback p0 = (global::Com.Liveperson.Infra.IPermissionCallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.IPermissionCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnVoiceRecordingPermissionRequired (p0);
		}
#pragma warning restore 0169

		IntPtr id_onVoiceRecordingPermissionRequired_Lcom_liveperson_infra_IPermissionCallback_;
		public unsafe void OnVoiceRecordingPermissionRequired (global::Com.Liveperson.Infra.IPermissionCallback p0)
		{
			if (id_onVoiceRecordingPermissionRequired_Lcom_liveperson_infra_IPermissionCallback_ == IntPtr.Zero)
				id_onVoiceRecordingPermissionRequired_Lcom_liveperson_infra_IPermissionCallback_ = JNIEnv.GetMethodID (class_ref, "onVoiceRecordingPermissionRequired", "(Lcom/liveperson/infra/IPermissionCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVoiceRecordingPermissionRequired_Lcom_liveperson_infra_IPermissionCallback_, __args);
		}

	}

	public partial class VoiceRecordingPermissionRequiredEventArgs : global::System.EventArgs {

		public VoiceRecordingPermissionRequiredEventArgs (global::Com.Liveperson.Infra.IPermissionCallback p0)
		{
			this.p0 = p0;
		}

		global::Com.Liveperson.Infra.IPermissionCallback p0;
		public global::Com.Liveperson.Infra.IPermissionCallback P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/liveperson/infra/ui/view/uicomponents/IEnterMessageListenerImplementor")]
	internal sealed partial class IEnterMessageListenerImplementor : global::Java.Lang.Object, IEnterMessageListener {

		object sender;

		public IEnterMessageListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/liveperson/infra/ui/view/uicomponents/IEnterMessageListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler OnMessageSentHandler;
#pragma warning restore 0649

		public void OnMessageSent ()
		{
			var __h = OnMessageSentHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<VoiceRecordingPermissionRequiredEventArgs> OnVoiceRecordingPermissionRequiredHandler;
#pragma warning restore 0649

		public void OnVoiceRecordingPermissionRequired (global::Com.Liveperson.Infra.IPermissionCallback p0)
		{
			var __h = OnVoiceRecordingPermissionRequiredHandler;
			if (__h != null)
				__h (sender, new VoiceRecordingPermissionRequiredEventArgs (p0));
		}

		internal static bool __IsEmpty (IEnterMessageListenerImplementor value)
		{
			return value.OnMessageSentHandler == null && value.OnVoiceRecordingPermissionRequiredHandler == null;
		}
	}

}
