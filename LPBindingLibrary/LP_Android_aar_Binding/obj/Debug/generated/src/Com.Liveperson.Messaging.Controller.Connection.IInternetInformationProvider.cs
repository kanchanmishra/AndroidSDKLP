using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Controller.Connection {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='InternetInformationProvider']"
	[Register ("com/liveperson/messaging/controller/connection/InternetInformationProvider", "", "Com.Liveperson.Messaging.Controller.Connection.IInternetInformationProviderInvoker")]
	public partial interface IInternetInformationProvider : IJavaObject {

		bool IsNetworkAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='InternetInformationProvider']/method[@name='isNetworkAvailable' and count(parameter)=0]"
			[Register ("isNetworkAvailable", "()Z", "GetIsNetworkAvailableHandler:Com.Liveperson.Messaging.Controller.Connection.IInternetInformationProviderInvoker, LP_Android_aar_Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='InternetInformationProvider']/method[@name='registerToNetworkChanges' and count(parameter)=0]"
		[Register ("registerToNetworkChanges", "()V", "GetRegisterToNetworkChangesHandler:Com.Liveperson.Messaging.Controller.Connection.IInternetInformationProviderInvoker, LP_Android_aar_Binding")]
		void RegisterToNetworkChanges ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller.connection']/interface[@name='InternetInformationProvider']/method[@name='unregisterToNetworkChanges' and count(parameter)=0]"
		[Register ("unregisterToNetworkChanges", "()V", "GetUnregisterToNetworkChangesHandler:Com.Liveperson.Messaging.Controller.Connection.IInternetInformationProviderInvoker, LP_Android_aar_Binding")]
		void UnregisterToNetworkChanges ();

	}

	[global::Android.Runtime.Register ("com/liveperson/messaging/controller/connection/InternetInformationProvider", DoNotGenerateAcw=true)]
	internal class IInternetInformationProviderInvoker : global::Java.Lang.Object, IInternetInformationProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/messaging/controller/connection/InternetInformationProvider");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IInternetInformationProviderInvoker); }
		}

		IntPtr class_ref;

		public static IInternetInformationProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInternetInformationProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.messaging.controller.connection.InternetInformationProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInternetInformationProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isNetworkAvailable;
#pragma warning disable 0169
		static Delegate GetIsNetworkAvailableHandler ()
		{
			if (cb_isNetworkAvailable == null)
				cb_isNetworkAvailable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNetworkAvailable);
			return cb_isNetworkAvailable;
		}

		static bool n_IsNetworkAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.IInternetInformationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IInternetInformationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNetworkAvailable;
		}
#pragma warning restore 0169

		IntPtr id_isNetworkAvailable;
		public unsafe bool IsNetworkAvailable {
			get {
				if (id_isNetworkAvailable == IntPtr.Zero)
					id_isNetworkAvailable = JNIEnv.GetMethodID (class_ref, "isNetworkAvailable", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNetworkAvailable);
			}
		}

		static Delegate cb_registerToNetworkChanges;
#pragma warning disable 0169
		static Delegate GetRegisterToNetworkChangesHandler ()
		{
			if (cb_registerToNetworkChanges == null)
				cb_registerToNetworkChanges = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RegisterToNetworkChanges);
			return cb_registerToNetworkChanges;
		}

		static void n_RegisterToNetworkChanges (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.IInternetInformationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IInternetInformationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RegisterToNetworkChanges ();
		}
#pragma warning restore 0169

		IntPtr id_registerToNetworkChanges;
		public unsafe void RegisterToNetworkChanges ()
		{
			if (id_registerToNetworkChanges == IntPtr.Zero)
				id_registerToNetworkChanges = JNIEnv.GetMethodID (class_ref, "registerToNetworkChanges", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerToNetworkChanges);
		}

		static Delegate cb_unregisterToNetworkChanges;
#pragma warning disable 0169
		static Delegate GetUnregisterToNetworkChangesHandler ()
		{
			if (cb_unregisterToNetworkChanges == null)
				cb_unregisterToNetworkChanges = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnregisterToNetworkChanges);
			return cb_unregisterToNetworkChanges;
		}

		static void n_UnregisterToNetworkChanges (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.Connection.IInternetInformationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.Connection.IInternetInformationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterToNetworkChanges ();
		}
#pragma warning restore 0169

		IntPtr id_unregisterToNetworkChanges;
		public unsafe void UnregisterToNetworkChanges ()
		{
			if (id_unregisterToNetworkChanges == IntPtr.Zero)
				id_unregisterToNetworkChanges = JNIEnv.GetMethodID (class_ref, "unregisterToNetworkChanges", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterToNetworkChanges);
		}

	}

}
