using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Network.Http {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.messaging.network.http']/interface[@name='MessageTimeoutListener']"
	[Register ("com/liveperson/messaging/network/http/MessageTimeoutListener", "", "Com.Liveperson.Messaging.Network.Http.IMessageTimeoutListenerInvoker")]
	public partial interface IMessageTimeoutListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.http']/interface[@name='MessageTimeoutListener']/method[@name='onMessageTimeout' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onMessageTimeout", "(Ljava/lang/String;)V", "GetOnMessageTimeout_Ljava_lang_String_Handler:Com.Liveperson.Messaging.Network.Http.IMessageTimeoutListenerInvoker, LP_Messaging_Binding")]
		void OnMessageTimeout (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.http']/interface[@name='MessageTimeoutListener']/method[@name='onPublishMessageTimeout' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("onPublishMessageTimeout", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetOnPublishMessageTimeout_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Liveperson.Messaging.Network.Http.IMessageTimeoutListenerInvoker, LP_Messaging_Binding")]
		void OnPublishMessageTimeout (string p0, string p1, string p2);

	}

	[global::Android.Runtime.Register ("com/liveperson/messaging/network/http/MessageTimeoutListener", DoNotGenerateAcw=true)]
	internal class IMessageTimeoutListenerInvoker : global::Java.Lang.Object, IMessageTimeoutListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/messaging/network/http/MessageTimeoutListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMessageTimeoutListenerInvoker); }
		}

		IntPtr class_ref;

		public static IMessageTimeoutListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMessageTimeoutListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.messaging.network.http.MessageTimeoutListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMessageTimeoutListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onMessageTimeout_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnMessageTimeout_Ljava_lang_String_Handler ()
		{
			if (cb_onMessageTimeout_Ljava_lang_String_ == null)
				cb_onMessageTimeout_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMessageTimeout_Ljava_lang_String_);
			return cb_onMessageTimeout_Ljava_lang_String_;
		}

		static void n_OnMessageTimeout_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Network.Http.IMessageTimeoutListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.IMessageTimeoutListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMessageTimeout (p0);
		}
#pragma warning restore 0169

		IntPtr id_onMessageTimeout_Ljava_lang_String_;
		public unsafe void OnMessageTimeout (string p0)
		{
			if (id_onMessageTimeout_Ljava_lang_String_ == IntPtr.Zero)
				id_onMessageTimeout_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onMessageTimeout", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMessageTimeout_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onPublishMessageTimeout_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnPublishMessageTimeout_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onPublishMessageTimeout_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onPublishMessageTimeout_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPublishMessageTimeout_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_onPublishMessageTimeout_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnPublishMessageTimeout_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.Network.Http.IMessageTimeoutListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.IMessageTimeoutListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnPublishMessageTimeout (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onPublishMessageTimeout_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void OnPublishMessageTimeout (string p0, string p1, string p2)
		{
			if (id_onPublishMessageTimeout_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onPublishMessageTimeout_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onPublishMessageTimeout", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPublishMessageTimeout_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

	public partial class MessageTimeoutEventArgs : global::System.EventArgs {

		public MessageTimeoutEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	public partial class PublishMessageTimeoutEventArgs : global::System.EventArgs {

		public PublishMessageTimeoutEventArgs (string p0, string p1, string p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}

		string p2;
		public string P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/liveperson/messaging/network/http/MessageTimeoutListenerImplementor")]
	internal sealed partial class IMessageTimeoutListenerImplementor : global::Java.Lang.Object, IMessageTimeoutListener {

		object sender;

		public IMessageTimeoutListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/liveperson/messaging/network/http/MessageTimeoutListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MessageTimeoutEventArgs> OnMessageTimeoutHandler;
#pragma warning restore 0649

		public void OnMessageTimeout (string p0)
		{
			var __h = OnMessageTimeoutHandler;
			if (__h != null)
				__h (sender, new MessageTimeoutEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<PublishMessageTimeoutEventArgs> OnPublishMessageTimeoutHandler;
#pragma warning restore 0649

		public void OnPublishMessageTimeout (string p0, string p1, string p2)
		{
			var __h = OnPublishMessageTimeoutHandler;
			if (__h != null)
				__h (sender, new PublishMessageTimeoutEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IMessageTimeoutListenerImplementor value)
		{
			return value.OnMessageTimeoutHandler == null && value.OnPublishMessageTimeoutHandler == null;
		}
	}

}
