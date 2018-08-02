using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Network.Socket {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.network.socket']/interface[@name='IdleQueueHandler']"
	[Register ("com/liveperson/infra/network/socket/IdleQueueHandler", "", "Com.Liveperson.Infra.Network.Socket.IIdleQueueHandlerInvoker")]
	public partial interface IIdleQueueHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/interface[@name='IdleQueueHandler']/method[@name='queueIdle' and count(parameter)=0]"
		[Register ("queueIdle", "()V", "GetQueueIdleHandler:Com.Liveperson.Infra.Network.Socket.IIdleQueueHandlerInvoker, LP_Infra_Binding")]
		void QueueIdle ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/network/socket/IdleQueueHandler", DoNotGenerateAcw=true)]
	internal class IIdleQueueHandlerInvoker : global::Java.Lang.Object, IIdleQueueHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/network/socket/IdleQueueHandler");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IIdleQueueHandlerInvoker); }
		}

		IntPtr class_ref;

		public static IIdleQueueHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIdleQueueHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.network.socket.IdleQueueHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIdleQueueHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_queueIdle;
#pragma warning disable 0169
		static Delegate GetQueueIdleHandler ()
		{
			if (cb_queueIdle == null)
				cb_queueIdle = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_QueueIdle);
			return cb_queueIdle;
		}

		static void n_QueueIdle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Socket.IIdleQueueHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.IIdleQueueHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.QueueIdle ();
		}
#pragma warning restore 0169

		IntPtr id_queueIdle;
		public unsafe void QueueIdle ()
		{
			if (id_queueIdle == IntPtr.Zero)
				id_queueIdle = JNIEnv.GetMethodID (class_ref, "queueIdle", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_queueIdle);
		}

	}

}
