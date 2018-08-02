using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Background {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.messaging.background']/interface[@name='DownloadFileTaskCallback']"
	[Register ("com/liveperson/messaging/background/DownloadFileTaskCallback", "", "Com.Liveperson.Messaging.Background.IDownloadFileTaskCallbackInvoker")]
	public partial interface IDownloadFileTaskCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/interface[@name='DownloadFileTaskCallback']/method[@name='onDownloadFailed' and count(parameter)=2 and parameter[1][@type='com.liveperson.messaging.background.DownloadFileTask'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("onDownloadFailed", "(Lcom/liveperson/messaging/background/DownloadFileTask;Ljava/lang/Throwable;)V", "GetOnDownloadFailed_Lcom_liveperson_messaging_background_DownloadFileTask_Ljava_lang_Throwable_Handler:Com.Liveperson.Messaging.Background.IDownloadFileTaskCallbackInvoker, LP_Android_aar_Binding")]
		void OnDownloadFailed (global::Com.Liveperson.Messaging.Background.DownloadFileTask p0, global::Java.Lang.Throwable p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/interface[@name='DownloadFileTaskCallback']/method[@name='onDownloadFinishedSuccessfully' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onDownloadFinishedSuccessfully", "(Ljava/lang/String;)V", "GetOnDownloadFinishedSuccessfully_Ljava_lang_String_Handler:Com.Liveperson.Messaging.Background.IDownloadFileTaskCallbackInvoker, LP_Android_aar_Binding")]
		void OnDownloadFinishedSuccessfully (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/interface[@name='DownloadFileTaskCallback']/method[@name='onReadyToGetUrl' and count(parameter)=0]"
		[Register ("onReadyToGetUrl", "()V", "GetOnReadyToGetUrlHandler:Com.Liveperson.Messaging.Background.IDownloadFileTaskCallbackInvoker, LP_Android_aar_Binding")]
		void OnReadyToGetUrl ();

	}

	[global::Android.Runtime.Register ("com/liveperson/messaging/background/DownloadFileTaskCallback", DoNotGenerateAcw=true)]
	internal class IDownloadFileTaskCallbackInvoker : global::Java.Lang.Object, IDownloadFileTaskCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/messaging/background/DownloadFileTaskCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDownloadFileTaskCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IDownloadFileTaskCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDownloadFileTaskCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.messaging.background.DownloadFileTaskCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDownloadFileTaskCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDownloadFailed_Lcom_liveperson_messaging_background_DownloadFileTask_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnDownloadFailed_Lcom_liveperson_messaging_background_DownloadFileTask_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onDownloadFailed_Lcom_liveperson_messaging_background_DownloadFileTask_Ljava_lang_Throwable_ == null)
				cb_onDownloadFailed_Lcom_liveperson_messaging_background_DownloadFileTask_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDownloadFailed_Lcom_liveperson_messaging_background_DownloadFileTask_Ljava_lang_Throwable_);
			return cb_onDownloadFailed_Lcom_liveperson_messaging_background_DownloadFileTask_Ljava_lang_Throwable_;
		}

		static void n_OnDownloadFailed_Lcom_liveperson_messaging_background_DownloadFileTask_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Background.IDownloadFileTaskCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.IDownloadFileTaskCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Background.DownloadFileTask p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.DownloadFileTask> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnDownloadFailed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onDownloadFailed_Lcom_liveperson_messaging_background_DownloadFileTask_Ljava_lang_Throwable_;
		public unsafe void OnDownloadFailed (global::Com.Liveperson.Messaging.Background.DownloadFileTask p0, global::Java.Lang.Throwable p1)
		{
			if (id_onDownloadFailed_Lcom_liveperson_messaging_background_DownloadFileTask_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onDownloadFailed_Lcom_liveperson_messaging_background_DownloadFileTask_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onDownloadFailed", "(Lcom/liveperson/messaging/background/DownloadFileTask;Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDownloadFailed_Lcom_liveperson_messaging_background_DownloadFileTask_Ljava_lang_Throwable_, __args);
		}

		static Delegate cb_onDownloadFinishedSuccessfully_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnDownloadFinishedSuccessfully_Ljava_lang_String_Handler ()
		{
			if (cb_onDownloadFinishedSuccessfully_Ljava_lang_String_ == null)
				cb_onDownloadFinishedSuccessfully_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDownloadFinishedSuccessfully_Ljava_lang_String_);
			return cb_onDownloadFinishedSuccessfully_Ljava_lang_String_;
		}

		static void n_OnDownloadFinishedSuccessfully_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Background.IDownloadFileTaskCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.IDownloadFileTaskCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDownloadFinishedSuccessfully (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDownloadFinishedSuccessfully_Ljava_lang_String_;
		public unsafe void OnDownloadFinishedSuccessfully (string p0)
		{
			if (id_onDownloadFinishedSuccessfully_Ljava_lang_String_ == IntPtr.Zero)
				id_onDownloadFinishedSuccessfully_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onDownloadFinishedSuccessfully", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDownloadFinishedSuccessfully_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onReadyToGetUrl;
#pragma warning disable 0169
		static Delegate GetOnReadyToGetUrlHandler ()
		{
			if (cb_onReadyToGetUrl == null)
				cb_onReadyToGetUrl = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnReadyToGetUrl);
			return cb_onReadyToGetUrl;
		}

		static void n_OnReadyToGetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.IDownloadFileTaskCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.IDownloadFileTaskCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnReadyToGetUrl ();
		}
#pragma warning restore 0169

		IntPtr id_onReadyToGetUrl;
		public unsafe void OnReadyToGetUrl ()
		{
			if (id_onReadyToGetUrl == IntPtr.Zero)
				id_onReadyToGetUrl = JNIEnv.GetMethodID (class_ref, "onReadyToGetUrl", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReadyToGetUrl);
		}

	}

}
