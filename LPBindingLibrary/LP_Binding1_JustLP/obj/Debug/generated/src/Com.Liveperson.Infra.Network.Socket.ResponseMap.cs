using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Network.Socket {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='ResponseMap']"
	[global::Android.Runtime.Register ("com/liveperson/infra/network/socket/ResponseMap", DoNotGenerateAcw=true)]
	public partial class ResponseMap : global::Java.Lang.Object, global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDown {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='ResponseMap']/field[@name='RESPONSE_TAG']"
		[Register ("RESPONSE_TAG")]
		public const string ResponseTag = (string) "FLOW_RESPONSES_";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/network/socket/ResponseMap", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResponseMap); }
		}

		protected ResponseMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='ResponseMap']/constructor[@name='ResponseMap' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResponseMap ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ResponseMap)) {
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

		static Delegate cb_getRequestIdHandler_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetGetRequestIdHandler_Ljava_lang_String_JHandler ()
		{
			if (cb_getRequestIdHandler_Ljava_lang_String_J == null)
				cb_getRequestIdHandler_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_GetRequestIdHandler_Ljava_lang_String_J);
			return cb_getRequestIdHandler_Ljava_lang_String_J;
		}

		static IntPtr n_GetRequestIdHandler_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Liveperson.Infra.Network.Socket.ResponseMap __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.ResponseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRequestIdHandler (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRequestIdHandler_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='ResponseMap']/method[@name='getRequestIdHandler' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("getRequestIdHandler", "(Ljava/lang/String;J)Lcom/liveperson/infra/network/socket/BaseResponseHandler;", "GetGetRequestIdHandler_Ljava_lang_String_JHandler")]
		public virtual unsafe global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler GetRequestIdHandler (string p0, long p1)
		{
			if (id_getRequestIdHandler_Ljava_lang_String_J == IntPtr.Zero)
				id_getRequestIdHandler_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "getRequestIdHandler", "(Ljava/lang/String;J)Lcom/liveperson/infra/network/socket/BaseResponseHandler;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestIdHandler_Ljava_lang_String_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestIdHandler", "(Ljava/lang/String;J)Lcom/liveperson/infra/network/socket/BaseResponseHandler;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onRequestHandled_J;
#pragma warning disable 0169
		static Delegate GetOnRequestHandled_JHandler ()
		{
			if (cb_onRequestHandled_J == null)
				cb_onRequestHandled_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_OnRequestHandled_J);
			return cb_onRequestHandled_J;
		}

		static void n_OnRequestHandled_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Infra.Network.Socket.ResponseMap __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.ResponseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRequestHandled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onRequestHandled_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='ResponseMap']/method[@name='onRequestHandled' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("onRequestHandled", "(J)V", "GetOnRequestHandled_JHandler")]
		public virtual unsafe void OnRequestHandled (long p0)
		{
			if (id_onRequestHandled_J == IntPtr.Zero)
				id_onRequestHandled_J = JNIEnv.GetMethodID (class_ref, "onRequestHandled", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRequestHandled_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRequestHandled", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSocketClosed;
#pragma warning disable 0169
		static Delegate GetOnSocketClosedHandler ()
		{
			if (cb_onSocketClosed == null)
				cb_onSocketClosed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSocketClosed);
			return cb_onSocketClosed;
		}

		static void n_OnSocketClosed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Socket.ResponseMap __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.ResponseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSocketClosed ();
		}
#pragma warning restore 0169

		static IntPtr id_onSocketClosed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='ResponseMap']/method[@name='onSocketClosed' and count(parameter)=0]"
		[Register ("onSocketClosed", "()V", "GetOnSocketClosedHandler")]
		public virtual unsafe void OnSocketClosed ()
		{
			if (id_onSocketClosed == IntPtr.Zero)
				id_onSocketClosed = JNIEnv.GetMethodID (class_ref, "onSocketClosed", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSocketClosed);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSocketClosed", "()V"));
			} finally {
			}
		}

		static Delegate cb_putGeneralHandler_Lcom_liveperson_infra_network_socket_GeneralResponseHandler_;
#pragma warning disable 0169
		static Delegate GetPutGeneralHandler_Lcom_liveperson_infra_network_socket_GeneralResponseHandler_Handler ()
		{
			if (cb_putGeneralHandler_Lcom_liveperson_infra_network_socket_GeneralResponseHandler_ == null)
				cb_putGeneralHandler_Lcom_liveperson_infra_network_socket_GeneralResponseHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutGeneralHandler_Lcom_liveperson_infra_network_socket_GeneralResponseHandler_);
			return cb_putGeneralHandler_Lcom_liveperson_infra_network_socket_GeneralResponseHandler_;
		}

		static void n_PutGeneralHandler_Lcom_liveperson_infra_network_socket_GeneralResponseHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Network.Socket.ResponseMap __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.ResponseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Network.Socket.GeneralResponseHandler p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.GeneralResponseHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutGeneralHandler (p0);
		}
#pragma warning restore 0169

		static IntPtr id_putGeneralHandler_Lcom_liveperson_infra_network_socket_GeneralResponseHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='ResponseMap']/method[@name='putGeneralHandler' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.network.socket.GeneralResponseHandler']]"
		[Register ("putGeneralHandler", "(Lcom/liveperson/infra/network/socket/GeneralResponseHandler;)V", "GetPutGeneralHandler_Lcom_liveperson_infra_network_socket_GeneralResponseHandler_Handler")]
		public virtual unsafe void PutGeneralHandler (global::Com.Liveperson.Infra.Network.Socket.GeneralResponseHandler p0)
		{
			if (id_putGeneralHandler_Lcom_liveperson_infra_network_socket_GeneralResponseHandler_ == IntPtr.Zero)
				id_putGeneralHandler_Lcom_liveperson_infra_network_socket_GeneralResponseHandler_ = JNIEnv.GetMethodID (class_ref, "putGeneralHandler", "(Lcom/liveperson/infra/network/socket/GeneralResponseHandler;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putGeneralHandler_Lcom_liveperson_infra_network_socket_GeneralResponseHandler_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putGeneralHandler", "(Lcom/liveperson/infra/network/socket/GeneralResponseHandler;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_putGeneralHandler_Ljava_lang_String_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetPutGeneralHandler_Ljava_lang_String_Ljava_lang_Class_Handler ()
		{
			if (cb_putGeneralHandler_Ljava_lang_String_Ljava_lang_Class_ == null)
				cb_putGeneralHandler_Ljava_lang_String_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PutGeneralHandler_Ljava_lang_String_Ljava_lang_Class_);
			return cb_putGeneralHandler_Ljava_lang_String_Ljava_lang_Class_;
		}

		static void n_PutGeneralHandler_Ljava_lang_String_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Network.Socket.ResponseMap __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.ResponseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PutGeneralHandler (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_putGeneralHandler_Ljava_lang_String_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='ResponseMap']/method[@name='putGeneralHandler' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;? extends com.liveperson.infra.network.socket.BaseResponseHandler&gt;']]"
		[Register ("putGeneralHandler", "(Ljava/lang/String;Ljava/lang/Class;)V", "GetPutGeneralHandler_Ljava_lang_String_Ljava_lang_Class_Handler")]
		public virtual unsafe void PutGeneralHandler (string p0, global::Java.Lang.Class p1)
		{
			if (id_putGeneralHandler_Ljava_lang_String_Ljava_lang_Class_ == IntPtr.Zero)
				id_putGeneralHandler_Ljava_lang_String_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "putGeneralHandler", "(Ljava/lang/String;Ljava/lang/Class;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putGeneralHandler_Ljava_lang_String_Ljava_lang_Class_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putGeneralHandler", "(Ljava/lang/String;Ljava/lang/Class;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putRequestIdHandler_JLcom_liveperson_infra_network_socket_BaseResponseHandler_;
#pragma warning disable 0169
		static Delegate GetPutRequestIdHandler_JLcom_liveperson_infra_network_socket_BaseResponseHandler_Handler ()
		{
			if (cb_putRequestIdHandler_JLcom_liveperson_infra_network_socket_BaseResponseHandler_ == null)
				cb_putRequestIdHandler_JLcom_liveperson_infra_network_socket_BaseResponseHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_PutRequestIdHandler_JLcom_liveperson_infra_network_socket_BaseResponseHandler_);
			return cb_putRequestIdHandler_JLcom_liveperson_infra_network_socket_BaseResponseHandler_;
		}

		static void n_PutRequestIdHandler_JLcom_liveperson_infra_network_socket_BaseResponseHandler_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Network.Socket.ResponseMap __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.ResponseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PutRequestIdHandler (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_putRequestIdHandler_JLcom_liveperson_infra_network_socket_BaseResponseHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='ResponseMap']/method[@name='putRequestIdHandler' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.liveperson.infra.network.socket.BaseResponseHandler']]"
		[Register ("putRequestIdHandler", "(JLcom/liveperson/infra/network/socket/BaseResponseHandler;)V", "GetPutRequestIdHandler_JLcom_liveperson_infra_network_socket_BaseResponseHandler_Handler")]
		public virtual unsafe void PutRequestIdHandler (long p0, global::Com.Liveperson.Infra.Network.Socket.BaseResponseHandler p1)
		{
			if (id_putRequestIdHandler_JLcom_liveperson_infra_network_socket_BaseResponseHandler_ == IntPtr.Zero)
				id_putRequestIdHandler_JLcom_liveperson_infra_network_socket_BaseResponseHandler_ = JNIEnv.GetMethodID (class_ref, "putRequestIdHandler", "(JLcom/liveperson/infra/network/socket/BaseResponseHandler;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putRequestIdHandler_JLcom_liveperson_infra_network_socket_BaseResponseHandler_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putRequestIdHandler", "(JLcom/liveperson/infra/network/socket/BaseResponseHandler;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_shutDown;
#pragma warning disable 0169
		static Delegate GetShutDownHandler ()
		{
			if (cb_shutDown == null)
				cb_shutDown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShutDown);
			return cb_shutDown;
		}

		static void n_ShutDown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.Socket.ResponseMap __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.ResponseMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShutDown ();
		}
#pragma warning restore 0169

		static IntPtr id_shutDown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='ResponseMap']/method[@name='shutDown' and count(parameter)=0]"
		[Register ("shutDown", "()V", "GetShutDownHandler")]
		public virtual unsafe void ShutDown ()
		{
			if (id_shutDown == IntPtr.Zero)
				id_shutDown = JNIEnv.GetMethodID (class_ref, "shutDown", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutDown);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shutDown", "()V"));
			} finally {
			}
		}

	}
}
