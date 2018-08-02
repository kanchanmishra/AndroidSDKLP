using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Background {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.messaging.background']/interface[@name='UploadFileTaskCallback']"
	[Register ("com/liveperson/messaging/background/UploadFileTaskCallback", "", "Com.Liveperson.Messaging.Background.IUploadFileTaskCallbackInvoker")]
	public partial interface IUploadFileTaskCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/interface[@name='UploadFileTaskCallback']/method[@name='onFileAddedToDB' and count(parameter)=0]"
		[Register ("onFileAddedToDB", "()V", "GetOnFileAddedToDBHandler:Com.Liveperson.Messaging.Background.IUploadFileTaskCallbackInvoker, LP_Messaging_Binding")]
		void OnFileAddedToDB ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/interface[@name='UploadFileTaskCallback']/method[@name='onUploadFailed' and count(parameter)=2 and parameter[1][@type='com.liveperson.messaging.background.filesharing.BaseUploadTask'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("onUploadFailed", "(Lcom/liveperson/messaging/background/filesharing/BaseUploadTask;Ljava/lang/Throwable;)V", "GetOnUploadFailed_Lcom_liveperson_messaging_background_filesharing_BaseUploadTask_Ljava_lang_Throwable_Handler:Com.Liveperson.Messaging.Background.IUploadFileTaskCallbackInvoker, LP_Messaging_Binding")]
		void OnUploadFailed (global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask p0, global::Java.Lang.Throwable p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/interface[@name='UploadFileTaskCallback']/method[@name='onUploadFinishedSuccessfully' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.background.filesharing.BaseUploadTask']]"
		[Register ("onUploadFinishedSuccessfully", "(Lcom/liveperson/messaging/background/filesharing/BaseUploadTask;)V", "GetOnUploadFinishedSuccessfully_Lcom_liveperson_messaging_background_filesharing_BaseUploadTask_Handler:Com.Liveperson.Messaging.Background.IUploadFileTaskCallbackInvoker, LP_Messaging_Binding")]
		void OnUploadFinishedSuccessfully (global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/messaging/background/UploadFileTaskCallback", DoNotGenerateAcw=true)]
	internal class IUploadFileTaskCallbackInvoker : global::Java.Lang.Object, IUploadFileTaskCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/messaging/background/UploadFileTaskCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IUploadFileTaskCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IUploadFileTaskCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUploadFileTaskCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.messaging.background.UploadFileTaskCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUploadFileTaskCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFileAddedToDB;
#pragma warning disable 0169
		static Delegate GetOnFileAddedToDBHandler ()
		{
			if (cb_onFileAddedToDB == null)
				cb_onFileAddedToDB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFileAddedToDB);
			return cb_onFileAddedToDB;
		}

		static void n_OnFileAddedToDB (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.IUploadFileTaskCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.IUploadFileTaskCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFileAddedToDB ();
		}
#pragma warning restore 0169

		IntPtr id_onFileAddedToDB;
		public unsafe void OnFileAddedToDB ()
		{
			if (id_onFileAddedToDB == IntPtr.Zero)
				id_onFileAddedToDB = JNIEnv.GetMethodID (class_ref, "onFileAddedToDB", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFileAddedToDB);
		}

		static Delegate cb_onUploadFailed_Lcom_liveperson_messaging_background_filesharing_BaseUploadTask_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnUploadFailed_Lcom_liveperson_messaging_background_filesharing_BaseUploadTask_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onUploadFailed_Lcom_liveperson_messaging_background_filesharing_BaseUploadTask_Ljava_lang_Throwable_ == null)
				cb_onUploadFailed_Lcom_liveperson_messaging_background_filesharing_BaseUploadTask_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnUploadFailed_Lcom_liveperson_messaging_background_filesharing_BaseUploadTask_Ljava_lang_Throwable_);
			return cb_onUploadFailed_Lcom_liveperson_messaging_background_filesharing_BaseUploadTask_Ljava_lang_Throwable_;
		}

		static void n_OnUploadFailed_Lcom_liveperson_messaging_background_filesharing_BaseUploadTask_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Background.IUploadFileTaskCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.IUploadFileTaskCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnUploadFailed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onUploadFailed_Lcom_liveperson_messaging_background_filesharing_BaseUploadTask_Ljava_lang_Throwable_;
		public unsafe void OnUploadFailed (global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask p0, global::Java.Lang.Throwable p1)
		{
			if (id_onUploadFailed_Lcom_liveperson_messaging_background_filesharing_BaseUploadTask_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onUploadFailed_Lcom_liveperson_messaging_background_filesharing_BaseUploadTask_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onUploadFailed", "(Lcom/liveperson/messaging/background/filesharing/BaseUploadTask;Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUploadFailed_Lcom_liveperson_messaging_background_filesharing_BaseUploadTask_Ljava_lang_Throwable_, __args);
		}

		static Delegate cb_onUploadFinishedSuccessfully_Lcom_liveperson_messaging_background_filesharing_BaseUploadTask_;
#pragma warning disable 0169
		static Delegate GetOnUploadFinishedSuccessfully_Lcom_liveperson_messaging_background_filesharing_BaseUploadTask_Handler ()
		{
			if (cb_onUploadFinishedSuccessfully_Lcom_liveperson_messaging_background_filesharing_BaseUploadTask_ == null)
				cb_onUploadFinishedSuccessfully_Lcom_liveperson_messaging_background_filesharing_BaseUploadTask_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUploadFinishedSuccessfully_Lcom_liveperson_messaging_background_filesharing_BaseUploadTask_);
			return cb_onUploadFinishedSuccessfully_Lcom_liveperson_messaging_background_filesharing_BaseUploadTask_;
		}

		static void n_OnUploadFinishedSuccessfully_Lcom_liveperson_messaging_background_filesharing_BaseUploadTask_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Background.IUploadFileTaskCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.IUploadFileTaskCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUploadFinishedSuccessfully (p0);
		}
#pragma warning restore 0169

		IntPtr id_onUploadFinishedSuccessfully_Lcom_liveperson_messaging_background_filesharing_BaseUploadTask_;
		public unsafe void OnUploadFinishedSuccessfully (global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask p0)
		{
			if (id_onUploadFinishedSuccessfully_Lcom_liveperson_messaging_background_filesharing_BaseUploadTask_ == IntPtr.Zero)
				id_onUploadFinishedSuccessfully_Lcom_liveperson_messaging_background_filesharing_BaseUploadTask_ = JNIEnv.GetMethodID (class_ref, "onUploadFinishedSuccessfully", "(Lcom/liveperson/messaging/background/filesharing/BaseUploadTask;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUploadFinishedSuccessfully_Lcom_liveperson_messaging_background_filesharing_BaseUploadTask_, __args);
		}

	}

}
