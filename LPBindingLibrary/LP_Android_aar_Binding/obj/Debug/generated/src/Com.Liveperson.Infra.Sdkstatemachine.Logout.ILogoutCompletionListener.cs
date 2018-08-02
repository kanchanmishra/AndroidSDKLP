using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Sdkstatemachine.Logout {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine.logout']/interface[@name='LogoutCompletionListener']"
	[Register ("com/liveperson/infra/sdkstatemachine/logout/LogoutCompletionListener", "", "Com.Liveperson.Infra.Sdkstatemachine.Logout.ILogoutCompletionListenerInvoker")]
	public partial interface ILogoutCompletionListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine.logout']/interface[@name='LogoutCompletionListener']/method[@name='logoutCompleted' and count(parameter)=0]"
		[Register ("logoutCompleted", "()V", "GetLogoutCompletedHandler:Com.Liveperson.Infra.Sdkstatemachine.Logout.ILogoutCompletionListenerInvoker, LP_Android_aar_Binding")]
		void LogoutCompleted ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/sdkstatemachine/logout/LogoutCompletionListener", DoNotGenerateAcw=true)]
	internal class ILogoutCompletionListenerInvoker : global::Java.Lang.Object, ILogoutCompletionListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/sdkstatemachine/logout/LogoutCompletionListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILogoutCompletionListenerInvoker); }
		}

		IntPtr class_ref;

		public static ILogoutCompletionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILogoutCompletionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.sdkstatemachine.logout.LogoutCompletionListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILogoutCompletionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_logoutCompleted;
#pragma warning disable 0169
		static Delegate GetLogoutCompletedHandler ()
		{
			if (cb_logoutCompleted == null)
				cb_logoutCompleted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LogoutCompleted);
			return cb_logoutCompleted;
		}

		static void n_LogoutCompleted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Sdkstatemachine.Logout.ILogoutCompletionListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Logout.ILogoutCompletionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LogoutCompleted ();
		}
#pragma warning restore 0169

		IntPtr id_logoutCompleted;
		public unsafe void LogoutCompleted ()
		{
			if (id_logoutCompleted == IntPtr.Zero)
				id_logoutCompleted = JNIEnv.GetMethodID (class_ref, "logoutCompleted", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_logoutCompleted);
		}

	}

	[global::Android.Runtime.Register ("mono/com/liveperson/infra/sdkstatemachine/logout/LogoutCompletionListenerImplementor")]
	internal sealed partial class ILogoutCompletionListenerImplementor : global::Java.Lang.Object, ILogoutCompletionListener {

		object sender;

		public ILogoutCompletionListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/liveperson/infra/sdkstatemachine/logout/LogoutCompletionListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void LogoutCompleted ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (ILogoutCompletionListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
