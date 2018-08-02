using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='GeneralMessagingResponseHandler']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/GeneralMessagingResponseHandler", DoNotGenerateAcw=true)]
	public partial class GeneralMessagingResponseHandler : global::Com.Liveperson.Infra.Network.Socket.GeneralResponseHandler {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/GeneralMessagingResponseHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeneralMessagingResponseHandler); }
		}

		protected GeneralMessagingResponseHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Liveperson.Messaging.GeneralMessagingResponseHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.GeneralMessagingResponseHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateInstance (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createInstance_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='GeneralMessagingResponseHandler']/method[@name='createInstance' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createInstance", "(Ljava/lang/String;)Lcom/liveperson/infra/network/socket/BaseResponseHandler;", "GetCreateInstance_Ljava_lang_String_Handler")]
		protected override unsafe global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler CreateInstance (string p0)
		{
			if (id_createInstance_Ljava_lang_String_ == IntPtr.Zero)
				id_createInstance_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createInstance", "(Ljava/lang/String;)Lcom/liveperson/infra/network/socket/BaseResponseHandler;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createInstance_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createInstance", "(Ljava/lang/String;)Lcom/liveperson/infra/network/socket/BaseResponseHandler;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
