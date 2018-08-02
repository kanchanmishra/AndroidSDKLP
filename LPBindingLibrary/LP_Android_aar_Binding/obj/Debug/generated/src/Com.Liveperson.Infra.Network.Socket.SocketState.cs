using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Network.Socket {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketState']"
	[global::Android.Runtime.Register ("com/liveperson/infra/network/socket/SocketState", DoNotGenerateAcw=true)]
	public sealed partial class SocketState : global::Java.Lang.Enum {


		static IntPtr CLOSED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketState']/field[@name='CLOSED']"
		[Register ("CLOSED")]
		public static global::Com.Liveperson.Infra.Network.Socket.SocketState Closed {
			get {
				if (CLOSED_jfieldId == IntPtr.Zero)
					CLOSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLOSED", "Lcom/liveperson/infra/network/socket/SocketState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLOSED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CLOSING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketState']/field[@name='CLOSING']"
		[Register ("CLOSING")]
		public static global::Com.Liveperson.Infra.Network.Socket.SocketState Closing {
			get {
				if (CLOSING_jfieldId == IntPtr.Zero)
					CLOSING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLOSING", "Lcom/liveperson/infra/network/socket/SocketState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLOSING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CONNECTING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketState']/field[@name='CONNECTING']"
		[Register ("CONNECTING")]
		public static global::Com.Liveperson.Infra.Network.Socket.SocketState Connecting {
			get {
				if (CONNECTING_jfieldId == IntPtr.Zero)
					CONNECTING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTING", "Lcom/liveperson/infra/network/socket/SocketState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONNECTING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketState']/field[@name='ERROR']"
		[Register ("ERROR")]
		public static global::Com.Liveperson.Infra.Network.Socket.SocketState Error {
			get {
				if (ERROR_jfieldId == IntPtr.Zero)
					ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lcom/liveperson/infra/network/socket/SocketState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INIT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketState']/field[@name='INIT']"
		[Register ("INIT")]
		public static global::Com.Liveperson.Infra.Network.Socket.SocketState Init {
			get {
				if (INIT_jfieldId == IntPtr.Zero)
					INIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INIT", "Lcom/liveperson/infra/network/socket/SocketState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INIT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr OPEN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketState']/field[@name='OPEN']"
		[Register ("OPEN")]
		public static global::Com.Liveperson.Infra.Network.Socket.SocketState Open {
			get {
				if (OPEN_jfieldId == IntPtr.Zero)
					OPEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPEN", "Lcom/liveperson/infra/network/socket/SocketState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OPEN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/network/socket/SocketState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocketState); }
		}

		internal SocketState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/network/socket/SocketState;", "")]
		public static unsafe global::Com.Liveperson.Infra.Network.Socket.SocketState ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/network/socket/SocketState;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Infra.Network.Socket.SocketState __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Socket.SocketState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.socket']/class[@name='SocketState']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/liveperson/infra/network/socket/SocketState;", "")]
		public static unsafe global::Com.Liveperson.Infra.Network.Socket.SocketState[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/infra/network/socket/SocketState;");
			try {
				return (global::Com.Liveperson.Infra.Network.Socket.SocketState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Infra.Network.Socket.SocketState));
			} finally {
			}
		}

	}
}
