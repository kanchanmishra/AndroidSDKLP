using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Sdkstatemachine.Logout {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine.logout']/interface[@name='PreLogoutCompletionListener']"
	[Register ("com/liveperson/infra/sdkstatemachine/logout/PreLogoutCompletionListener", "", "Com.Liveperson.Infra.Sdkstatemachine.Logout.IPreLogoutCompletionListenerInvoker")]
	public partial interface IPreLogoutCompletionListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine.logout']/interface[@name='PreLogoutCompletionListener']/method[@name='preLogoutCompleted' and count(parameter)=0]"
		[Register ("preLogoutCompleted", "()V", "GetPreLogoutCompletedHandler:Com.Liveperson.Infra.Sdkstatemachine.Logout.IPreLogoutCompletionListenerInvoker, LP_Binding1_JustLP")]
		void PreLogoutCompleted ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine.logout']/interface[@name='PreLogoutCompletionListener']/method[@name='preLogoutFailed' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("preLogoutFailed", "(Ljava/lang/Exception;)V", "GetPreLogoutFailed_Ljava_lang_Exception_Handler:Com.Liveperson.Infra.Sdkstatemachine.Logout.IPreLogoutCompletionListenerInvoker, LP_Binding1_JustLP")]
		void PreLogoutFailed (global::Java.Lang.Exception p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/sdkstatemachine/logout/PreLogoutCompletionListener", DoNotGenerateAcw=true)]
	internal class IPreLogoutCompletionListenerInvoker : global::Java.Lang.Object, IPreLogoutCompletionListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/sdkstatemachine/logout/PreLogoutCompletionListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPreLogoutCompletionListenerInvoker); }
		}

		IntPtr class_ref;

		public static IPreLogoutCompletionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPreLogoutCompletionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.sdkstatemachine.logout.PreLogoutCompletionListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPreLogoutCompletionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_preLogoutCompleted;
#pragma warning disable 0169
		static Delegate GetPreLogoutCompletedHandler ()
		{
			if (cb_preLogoutCompleted == null)
				cb_preLogoutCompleted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PreLogoutCompleted);
			return cb_preLogoutCompleted;
		}

		static void n_PreLogoutCompleted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Sdkstatemachine.Logout.IPreLogoutCompletionListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Logout.IPreLogoutCompletionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PreLogoutCompleted ();
		}
#pragma warning restore 0169

		IntPtr id_preLogoutCompleted;
		public unsafe void PreLogoutCompleted ()
		{
			if (id_preLogoutCompleted == IntPtr.Zero)
				id_preLogoutCompleted = JNIEnv.GetMethodID (class_ref, "preLogoutCompleted", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_preLogoutCompleted);
		}

		static Delegate cb_preLogoutFailed_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetPreLogoutFailed_Ljava_lang_Exception_Handler ()
		{
			if (cb_preLogoutFailed_Ljava_lang_Exception_ == null)
				cb_preLogoutFailed_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PreLogoutFailed_Ljava_lang_Exception_);
			return cb_preLogoutFailed_Ljava_lang_Exception_;
		}

		static void n_PreLogoutFailed_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Sdkstatemachine.Logout.IPreLogoutCompletionListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Logout.IPreLogoutCompletionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PreLogoutFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_preLogoutFailed_Ljava_lang_Exception_;
		public unsafe void PreLogoutFailed (global::Java.Lang.Exception p0)
		{
			if (id_preLogoutFailed_Ljava_lang_Exception_ == IntPtr.Zero)
				id_preLogoutFailed_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "preLogoutFailed", "(Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_preLogoutFailed_Ljava_lang_Exception_, __args);
		}

	}

	public partial class PreLogoutFailedEventArgs : global::System.EventArgs {

		public PreLogoutFailedEventArgs (global::Java.Lang.Exception p0)
		{
			this.p0 = p0;
		}

		global::Java.Lang.Exception p0;
		public global::Java.Lang.Exception P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/liveperson/infra/sdkstatemachine/logout/PreLogoutCompletionListenerImplementor")]
	internal sealed partial class IPreLogoutCompletionListenerImplementor : global::Java.Lang.Object, IPreLogoutCompletionListener {

		object sender;

		public IPreLogoutCompletionListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/liveperson/infra/sdkstatemachine/logout/PreLogoutCompletionListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler PreLogoutCompletedHandler;
#pragma warning restore 0649

		public void PreLogoutCompleted ()
		{
			var __h = PreLogoutCompletedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<PreLogoutFailedEventArgs> PreLogoutFailedHandler;
#pragma warning restore 0649

		public void PreLogoutFailed (global::Java.Lang.Exception p0)
		{
			var __h = PreLogoutFailedHandler;
			if (__h != null)
				__h (sender, new PreLogoutFailedEventArgs (p0));
		}

		internal static bool __IsEmpty (IPreLogoutCompletionListenerImplementor value)
		{
			return value.PreLogoutCompletedHandler == null && value.PreLogoutFailedHandler == null;
		}
	}

}
