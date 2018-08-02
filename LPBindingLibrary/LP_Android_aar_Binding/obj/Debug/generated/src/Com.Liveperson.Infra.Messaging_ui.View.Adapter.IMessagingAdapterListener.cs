using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.View.Adapter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/interface[@name='MessagingAdapterListener']"
	[Register ("com/liveperson/infra/messaging_ui/view/adapter/MessagingAdapterListener", "", "Com.Liveperson.Infra.Messaging_ui.View.Adapter.IMessagingAdapterListenerInvoker")]
	public partial interface IMessagingAdapterListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/interface[@name='MessagingAdapterListener']/method[@name='onFileClicked' and count(parameter)=5 and parameter[1][@type='com.liveperson.messaging.background.filesharing.FileSharingType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long'] and parameter[5][@type='long']]"
		[Register ("onFileClicked", "(Lcom/liveperson/messaging/background/filesharing/FileSharingType;Ljava/lang/String;Ljava/lang/String;JJ)V", "GetOnFileClicked_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_JJHandler:Com.Liveperson.Infra.Messaging_ui.View.Adapter.IMessagingAdapterListenerInvoker, LP_Android_aar_Binding")]
		void OnFileClicked (global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType p0, string p1, string p2, long p3, long p4);

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/MessagingAdapterListener", DoNotGenerateAcw=true)]
	internal class IMessagingAdapterListenerInvoker : global::Java.Lang.Object, IMessagingAdapterListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/view/adapter/MessagingAdapterListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMessagingAdapterListenerInvoker); }
		}

		IntPtr class_ref;

		public static IMessagingAdapterListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMessagingAdapterListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.messaging_ui.view.adapter.MessagingAdapterListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMessagingAdapterListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFileClicked_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_JJ;
#pragma warning disable 0169
		static Delegate GetOnFileClicked_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_JJHandler ()
		{
			if (cb_onFileClicked_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_JJ == null)
				cb_onFileClicked_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long, long>) n_OnFileClicked_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_JJ);
			return cb_onFileClicked_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_JJ;
		}

		static void n_OnFileClicked_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_JJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, long p3, long p4)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.IMessagingAdapterListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.IMessagingAdapterListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnFileClicked (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_onFileClicked_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_JJ;
		public unsafe void OnFileClicked (global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType p0, string p1, string p2, long p3, long p4)
		{
			if (id_onFileClicked_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_JJ == IntPtr.Zero)
				id_onFileClicked_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_JJ = JNIEnv.GetMethodID (class_ref, "onFileClicked", "(Lcom/liveperson/messaging/background/filesharing/FileSharingType;Ljava/lang/String;Ljava/lang/String;JJ)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFileClicked_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_JJ, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

	public partial class MessagingAdapterEventArgs : global::System.EventArgs {

		public MessagingAdapterEventArgs (global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType p0, string p1, string p2, long p3, long p4)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.p4 = p4;
		}

		global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType p0;
		public global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType P0 {
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

		long p3;
		public long P3 {
			get { return p3; }
		}

		long p4;
		public long P4 {
			get { return p4; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/liveperson/infra/messaging_ui/view/adapter/MessagingAdapterListenerImplementor")]
	internal sealed partial class IMessagingAdapterListenerImplementor : global::Java.Lang.Object, IMessagingAdapterListener {

		object sender;

		public IMessagingAdapterListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/liveperson/infra/messaging_ui/view/adapter/MessagingAdapterListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MessagingAdapterEventArgs> Handler;
#pragma warning restore 0649

		public void OnFileClicked (global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType p0, string p1, string p2, long p3, long p4)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new MessagingAdapterEventArgs (p0, p1, p2, p3, p4));
		}

		internal static bool __IsEmpty (IMessagingAdapterListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
