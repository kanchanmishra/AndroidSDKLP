using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Network.Socket {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.network.socket']/interface[@name='SocketErrorCallback']"
	[Register ("com/liveperson/infra/network/socket/SocketErrorCallback", "", "Com.Liveperson.Infra.Network.Socket.ISocketErrorCallbackInvoker")]
	public partial interface ISocketErrorCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/interface[@name='SocketErrorCallback']/method[@name='onFatalError' and count(parameter)=0]"
		[Register ("onFatalError", "()V", "GetOnFatalErrorHandler:Com.Liveperson.Infra.Network.Socket.ISocketErrorCallbackInvoker, LP_Android_aar_Binding")]
		void OnFatalError ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/interface[@name='SocketErrorCallback']/method[@name='onParsingError' and count(parameter)=0]"
		[Register ("onParsingError", "()V", "GetOnParsingErrorHandler:Com.Liveperson.Infra.Network.Socket.ISocketErrorCallbackInvoker, LP_Android_aar_Binding")]
		void OnParsingError ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/network/socket/SocketErrorCallback", DoNotGenerateAcw=true)]
	internal class ISocketErrorCallbackInvoker : global::Java.Lang.Object, ISocketErrorCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/network/socket/SocketErrorCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISocketErrorCallbackInvoker); }
		}

		IntPtr class_ref;

		public static ISocketErrorCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISocketErrorCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.network.socket.SocketErrorCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISocketErrorCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFatalError;
#pragma warning disable 0169
		static Delegate GetOnFatalErrorHandler ()
		{
			if (cb_onFatalError == null)
				cb_onFatalError = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFatalError);
			return cb_onFatalError;
		}

		static void n_OnFatalError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Socket.ISocketErrorCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.ISocketErrorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFatalError ();
		}
#pragma warning restore 0169

		IntPtr id_onFatalError;
		public unsafe void OnFatalError ()
		{
			if (id_onFatalError == IntPtr.Zero)
				id_onFatalError = JNIEnv.GetMethodID (class_ref, "onFatalError", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFatalError);
		}

		static Delegate cb_onParsingError;
#pragma warning disable 0169
		static Delegate GetOnParsingErrorHandler ()
		{
			if (cb_onParsingError == null)
				cb_onParsingError = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnParsingError);
			return cb_onParsingError;
		}

		static void n_OnParsingError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Socket.ISocketErrorCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.ISocketErrorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnParsingError ();
		}
#pragma warning restore 0169

		IntPtr id_onParsingError;
		public unsafe void OnParsingError ()
		{
			if (id_onParsingError == IntPtr.Zero)
				id_onParsingError = JNIEnv.GetMethodID (class_ref, "onParsingError", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onParsingError);
		}

	}

}
