using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Network.Socket.Requests {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='CsatRequest']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/network/socket/requests/CsatRequest", DoNotGenerateAcw=true)]
	public partial class CsatRequest : global::Com.Liveperson.Api.Request.BaseAMSSocketRequest {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/network/socket/requests/CsatRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CsatRequest); }
		}

		protected CsatRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='CsatRequest']/constructor[@name='CsatRequest' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;II)V", "")]
		public unsafe CsatRequest (string p0, string p1, int p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (CsatRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;II)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_II == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_II, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Network.Socket.Requests.CsatRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.CsatRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Data);
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		protected override unsafe string Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='CsatRequest']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/lang/String;", "GetGetDataHandler")]
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestName;
#pragma warning disable 0169
		static Delegate GetGetRequestNameHandler ()
		{
			if (cb_getRequestName == null)
				cb_getRequestName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestName);
			return cb_getRequestName;
		}

		static IntPtr n_GetRequestName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Network.Socket.Requests.CsatRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.CsatRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestName);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestName;
		protected override unsafe string RequestName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='CsatRequest']/method[@name='getRequestName' and count(parameter)=0]"
			[Register ("getRequestName", "()Ljava/lang/String;", "GetGetRequestNameHandler")]
			get {
				if (id_getRequestName == IntPtr.Zero)
					id_getRequestName = JNIEnv.GetMethodID (class_ref, "getRequestName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResponseHandler;
#pragma warning disable 0169
		static Delegate GetGetResponseHandlerHandler ()
		{
			if (cb_getResponseHandler == null)
				cb_getResponseHandler = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseHandler);
			return cb_getResponseHandler;
		}

		static IntPtr n_GetResponseHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Network.Socket.Requests.CsatRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Socket.Requests.CsatRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResponseHandler);
		}
#pragma warning restore 0169

		static IntPtr id_getResponseHandler;
		protected virtual unsafe global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler ResponseHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.socket.requests']/class[@name='CsatRequest']/method[@name='getResponseHandler' and count(parameter)=0]"
			[Register ("getResponseHandler", "()Lcom/liveperson/infra/network/socket/BaseResponseHandler;", "GetGetResponseHandlerHandler")]
			get {
				if (id_getResponseHandler == IntPtr.Zero)
					id_getResponseHandler = JNIEnv.GetMethodID (class_ref, "getResponseHandler", "()Lcom/liveperson/infra/network/socket/BaseResponseHandler;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseHandler), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseHandler", "()Lcom/liveperson/infra/network/socket/BaseResponseHandler;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
