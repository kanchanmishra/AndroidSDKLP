using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Network.Socket {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='GeneralResponseHandler']"
	[global::Android.Runtime.Register ("com/liveperson/infra/network/socket/GeneralResponseHandler", DoNotGenerateAcw=true)]
	public abstract partial class GeneralResponseHandler : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/network/socket/GeneralResponseHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeneralResponseHandler); }
		}

		protected GeneralResponseHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='GeneralResponseHandler']/constructor[@name='GeneralResponseHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GeneralResponseHandler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GeneralResponseHandler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_createInstance_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateInstance_Ljava_lang_String_Handler ()
		{
			if (cb_createInstance_Ljava_lang_String_ == null)
				cb_createInstance_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateInstance_Ljava_lang_String_);
			return cb_createInstance_Ljava_lang_String_;
		}

		static IntPtr n_CreateInstance_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Socket.GeneralResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.GeneralResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateInstance (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='GeneralResponseHandler']/method[@name='createInstance' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createInstance", "(Ljava/lang/String;)Lcom/liveperson/infra/network/socket/BaseResponseHandler;", "GetCreateInstance_Ljava_lang_String_Handler")]
		protected abstract global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler CreateInstance (string p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/network/socket/GeneralResponseHandler", DoNotGenerateAcw=true)]
	internal partial class GeneralResponseHandlerInvoker : GeneralResponseHandler {

		public GeneralResponseHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeneralResponseHandlerInvoker); }
		}

		static IntPtr id_createInstance_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='GeneralResponseHandler']/method[@name='createInstance' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createInstance", "(Ljava/lang/String;)Lcom/liveperson/infra/network/socket/BaseResponseHandler;", "GetCreateInstance_Ljava_lang_String_Handler")]
		protected override unsafe global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler CreateInstance (string p0)
		{
			if (id_createInstance_Ljava_lang_String_ == IntPtr.Zero)
				id_createInstance_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createInstance", "(Ljava/lang/String;)Lcom/liveperson/infra/network/socket/BaseResponseHandler;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createInstance_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
