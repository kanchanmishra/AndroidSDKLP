using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Background {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='FileSharingManager']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/background/FileSharingManager", DoNotGenerateAcw=true)]
	public partial class FileSharingManager : global::Com.Liveperson.Infra.Utils.DispatchQueue, global::Com.Liveperson.Messaging.Background.BackgroundActionsService.IServiceActioner {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='FileSharingManager']/field[@name='SERVICE_EXTRA_BRAND_ID']"
		[Register ("SERVICE_EXTRA_BRAND_ID")]
		public const string ServiceExtraBrandId = (string) "service_extra_brand_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='FileSharingManager']/field[@name='SERVICE_EXTRA_EVENT_ID']"
		[Register ("SERVICE_EXTRA_EVENT_ID")]
		public const string ServiceExtraEventId = (string) "service_extra_event_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='FileSharingManager']/field[@name='SERVICE_EXTRA_FILE_CAPTION']"
		[Register ("SERVICE_EXTRA_FILE_CAPTION")]
		public const string ServiceExtraFileCaption = (string) "service_extra_file_caption";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='FileSharingManager']/field[@name='SERVICE_EXTRA_FILE_ROW_ID']"
		[Register ("SERVICE_EXTRA_FILE_ROW_ID")]
		public const string ServiceExtraFileRowId = (string) "service_extra_file_row_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='FileSharingManager']/field[@name='SERVICE_EXTRA_FILE_SHARING_TYPE']"
		[Register ("SERVICE_EXTRA_FILE_SHARING_TYPE")]
		public const string ServiceExtraFileSharingType = (string) "extra_file_sharing_type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='FileSharingManager']/field[@name='SERVICE_EXTRA_FILE_URI']"
		[Register ("SERVICE_EXTRA_FILE_URI")]
		public const string ServiceExtraFileUri = (string) "service_extra_file_uri";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='FileSharingManager']/field[@name='SERVICE_EXTRA_IMAGE_FROM_CAMERA']"
		[Register ("SERVICE_EXTRA_IMAGE_FROM_CAMERA")]
		public const string ServiceExtraImageFromCamera = (string) "service_extra_image_from_camera";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='FileSharingManager']/field[@name='SERVICE_EXTRA_MESSAGE']"
		[Register ("SERVICE_EXTRA_MESSAGE")]
		public const string ServiceExtraMessage = (string) "service_extra_message";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='FileSharingManager']/field[@name='SERVICE_EXTRA_MESSAGE_ROW_ID']"
		[Register ("SERVICE_EXTRA_MESSAGE_ROW_ID")]
		public const string ServiceExtraMessageRowId = (string) "service_extra_message_row_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='FileSharingManager']/field[@name='SERVICE_EXTRA_ORIGINAL_MESSAGE_TIME']"
		[Register ("SERVICE_EXTRA_ORIGINAL_MESSAGE_TIME")]
		public const string ServiceExtraOriginalMessageTime = (string) "extra_original_message_time";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='FileSharingManager']/field[@name='SERVICE_EXTRA_TARGET_ID']"
		[Register ("SERVICE_EXTRA_TARGET_ID")]
		public const string ServiceExtraTargetId = (string) "service_extra_target_id";
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.messaging.background']/interface[@name='FileSharingManager.FileDownloadProgressListener']"
		[Register ("com/liveperson/messaging/background/FileSharingManager$FileDownloadProgressListener", "", "Com.Liveperson.Messaging.Background.FileSharingManager/IFileDownloadProgressListenerInvoker")]
		public partial interface IFileDownloadProgressListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/interface[@name='FileSharingManager.FileDownloadProgressListener']/method[@name='onDoneDownload' and count(parameter)=0]"
			[Register ("onDoneDownload", "()V", "GetOnDoneDownloadHandler:Com.Liveperson.Messaging.Background.FileSharingManager/IFileDownloadProgressListenerInvoker, LP_Android_aar_Binding")]
			void OnDoneDownload ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/interface[@name='FileSharingManager.FileDownloadProgressListener']/method[@name='onFailedDownload' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register ("onFailedDownload", "(Ljava/lang/Throwable;)V", "GetOnFailedDownload_Ljava_lang_Throwable_Handler:Com.Liveperson.Messaging.Background.FileSharingManager/IFileDownloadProgressListenerInvoker, LP_Android_aar_Binding")]
			void OnFailedDownload (global::Java.Lang.Throwable p0);

		}

		[global::Android.Runtime.Register ("com/liveperson/messaging/background/FileSharingManager$FileDownloadProgressListener", DoNotGenerateAcw=true)]
		internal class IFileDownloadProgressListenerInvoker : global::Java.Lang.Object, IFileDownloadProgressListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/messaging/background/FileSharingManager$FileDownloadProgressListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IFileDownloadProgressListenerInvoker); }
			}

			IntPtr class_ref;

			public static IFileDownloadProgressListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFileDownloadProgressListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.messaging.background.FileSharingManager.FileDownloadProgressListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFileDownloadProgressListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDoneDownload;
#pragma warning disable 0169
			static Delegate GetOnDoneDownloadHandler ()
			{
				if (cb_onDoneDownload == null)
					cb_onDoneDownload = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDoneDownload);
				return cb_onDoneDownload;
			}

			static void n_OnDoneDownload (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Messaging.Background.FileSharingManager.IFileDownloadProgressListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.FileSharingManager.IFileDownloadProgressListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnDoneDownload ();
			}
#pragma warning restore 0169

			IntPtr id_onDoneDownload;
			public unsafe void OnDoneDownload ()
			{
				if (id_onDoneDownload == IntPtr.Zero)
					id_onDoneDownload = JNIEnv.GetMethodID (class_ref, "onDoneDownload", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDoneDownload);
			}

			static Delegate cb_onFailedDownload_Ljava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetOnFailedDownload_Ljava_lang_Throwable_Handler ()
			{
				if (cb_onFailedDownload_Ljava_lang_Throwable_ == null)
					cb_onFailedDownload_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailedDownload_Ljava_lang_Throwable_);
				return cb_onFailedDownload_Ljava_lang_Throwable_;
			}

			static void n_OnFailedDownload_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Messaging.Background.FileSharingManager.IFileDownloadProgressListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.FileSharingManager.IFileDownloadProgressListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFailedDownload (p0);
			}
#pragma warning restore 0169

			IntPtr id_onFailedDownload_Ljava_lang_Throwable_;
			public unsafe void OnFailedDownload (global::Java.Lang.Throwable p0)
			{
				if (id_onFailedDownload_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_onFailedDownload_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onFailedDownload", "(Ljava/lang/Throwable;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailedDownload_Ljava_lang_Throwable_, __args);
			}

		}

		public partial class FailedDownloadEventArgs : global::System.EventArgs {

			public FailedDownloadEventArgs (global::Java.Lang.Throwable p0)
			{
				this.p0 = p0;
			}

			global::Java.Lang.Throwable p0;
			public global::Java.Lang.Throwable P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/liveperson/messaging/background/FileSharingManager_FileDownloadProgressListenerImplementor")]
		internal sealed partial class IFileDownloadProgressListenerImplementor : global::Java.Lang.Object, IFileDownloadProgressListener {

			object sender;

			public IFileDownloadProgressListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/liveperson/messaging/background/FileSharingManager_FileDownloadProgressListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnDoneDownloadHandler;
#pragma warning restore 0649

			public void OnDoneDownload ()
			{
				var __h = OnDoneDownloadHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<FailedDownloadEventArgs> OnFailedDownloadHandler;
#pragma warning restore 0649

			public void OnFailedDownload (global::Java.Lang.Throwable p0)
			{
				var __h = OnFailedDownloadHandler;
				if (__h != null)
					__h (sender, new FailedDownloadEventArgs (p0));
			}

			internal static bool __IsEmpty (IFileDownloadProgressListenerImplementor value)
			{
				return value.OnDoneDownloadHandler == null && value.OnFailedDownloadHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.messaging.background']/interface[@name='FileSharingManager.FileUploadProgressListener']"
		[Register ("com/liveperson/messaging/background/FileSharingManager$FileUploadProgressListener", "", "Com.Liveperson.Messaging.Background.FileSharingManager/IFileUploadProgressListenerInvoker")]
		public partial interface IFileUploadProgressListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/interface[@name='FileSharingManager.FileUploadProgressListener']/method[@name='onDoneUpload' and count(parameter)=0]"
			[Register ("onDoneUpload", "()V", "GetOnDoneUploadHandler:Com.Liveperson.Messaging.Background.FileSharingManager/IFileUploadProgressListenerInvoker, LP_Android_aar_Binding")]
			void OnDoneUpload ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/interface[@name='FileSharingManager.FileUploadProgressListener']/method[@name='onFailedUpload' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register ("onFailedUpload", "(Ljava/lang/Throwable;)V", "GetOnFailedUpload_Ljava_lang_Throwable_Handler:Com.Liveperson.Messaging.Background.FileSharingManager/IFileUploadProgressListenerInvoker, LP_Android_aar_Binding")]
			void OnFailedUpload (global::Java.Lang.Throwable p0);

		}

		[global::Android.Runtime.Register ("com/liveperson/messaging/background/FileSharingManager$FileUploadProgressListener", DoNotGenerateAcw=true)]
		internal class IFileUploadProgressListenerInvoker : global::Java.Lang.Object, IFileUploadProgressListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/messaging/background/FileSharingManager$FileUploadProgressListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IFileUploadProgressListenerInvoker); }
			}

			IntPtr class_ref;

			public static IFileUploadProgressListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFileUploadProgressListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.messaging.background.FileSharingManager.FileUploadProgressListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFileUploadProgressListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDoneUpload;
#pragma warning disable 0169
			static Delegate GetOnDoneUploadHandler ()
			{
				if (cb_onDoneUpload == null)
					cb_onDoneUpload = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDoneUpload);
				return cb_onDoneUpload;
			}

			static void n_OnDoneUpload (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Messaging.Background.FileSharingManager.IFileUploadProgressListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.FileSharingManager.IFileUploadProgressListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnDoneUpload ();
			}
#pragma warning restore 0169

			IntPtr id_onDoneUpload;
			public unsafe void OnDoneUpload ()
			{
				if (id_onDoneUpload == IntPtr.Zero)
					id_onDoneUpload = JNIEnv.GetMethodID (class_ref, "onDoneUpload", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDoneUpload);
			}

			static Delegate cb_onFailedUpload_Ljava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetOnFailedUpload_Ljava_lang_Throwable_Handler ()
			{
				if (cb_onFailedUpload_Ljava_lang_Throwable_ == null)
					cb_onFailedUpload_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailedUpload_Ljava_lang_Throwable_);
				return cb_onFailedUpload_Ljava_lang_Throwable_;
			}

			static void n_OnFailedUpload_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Messaging.Background.FileSharingManager.IFileUploadProgressListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.FileSharingManager.IFileUploadProgressListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFailedUpload (p0);
			}
#pragma warning restore 0169

			IntPtr id_onFailedUpload_Ljava_lang_Throwable_;
			public unsafe void OnFailedUpload (global::Java.Lang.Throwable p0)
			{
				if (id_onFailedUpload_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_onFailedUpload_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onFailedUpload", "(Ljava/lang/Throwable;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailedUpload_Ljava_lang_Throwable_, __args);
			}

		}

		public partial class FailedUploadEventArgs : global::System.EventArgs {

			public FailedUploadEventArgs (global::Java.Lang.Throwable p0)
			{
				this.p0 = p0;
			}

			global::Java.Lang.Throwable p0;
			public global::Java.Lang.Throwable P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/liveperson/messaging/background/FileSharingManager_FileUploadProgressListenerImplementor")]
		internal sealed partial class IFileUploadProgressListenerImplementor : global::Java.Lang.Object, IFileUploadProgressListener {

			object sender;

			public IFileUploadProgressListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/liveperson/messaging/background/FileSharingManager_FileUploadProgressListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnDoneUploadHandler;
#pragma warning restore 0649

			public void OnDoneUpload ()
			{
				var __h = OnDoneUploadHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<FailedUploadEventArgs> OnFailedUploadHandler;
#pragma warning restore 0649

			public void OnFailedUpload (global::Java.Lang.Throwable p0)
			{
				var __h = OnFailedUploadHandler;
				if (__h != null)
					__h (sender, new FailedUploadEventArgs (p0));
			}

			internal static bool __IsEmpty (IFileUploadProgressListenerImplementor value)
			{
				return value.OnDoneUploadHandler == null && value.OnFailedUploadHandler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/background/FileSharingManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileSharingManager); }
		}

		protected FileSharingManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_Messaging_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='FileSharingManager']/constructor[@name='FileSharingManager' and count(parameter)=2 and parameter[1][@type='com.liveperson.messaging.Messaging'] and parameter[2][@type='android.content.Context']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/Messaging;Landroid/content/Context;)V", "")]
		public unsafe FileSharingManager (global::Com.Liveperson.Messaging.Messaging p0, global::Android.Content.Context p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (FileSharingManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/Messaging;Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/Messaging;Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_Messaging_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_Messaging_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/Messaging;Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getInProgressUploadMessageRowIdsString;
#pragma warning disable 0169
		static Delegate GetGetInProgressUploadMessageRowIdsStringHandler ()
		{
			if (cb_getInProgressUploadMessageRowIdsString == null)
				cb_getInProgressUploadMessageRowIdsString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInProgressUploadMessageRowIdsString);
			return cb_getInProgressUploadMessageRowIdsString;
		}

		static IntPtr n_GetInProgressUploadMessageRowIdsString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.FileSharingManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.FileSharingManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.InProgressUploadMessageRowIdsString);
		}
#pragma warning restore 0169

		static IntPtr id_getInProgressUploadMessageRowIdsString;
		public virtual unsafe string InProgressUploadMessageRowIdsString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='FileSharingManager']/method[@name='getInProgressUploadMessageRowIdsString' and count(parameter)=0]"
			[Register ("getInProgressUploadMessageRowIdsString", "()Ljava/lang/String;", "GetGetInProgressUploadMessageRowIdsStringHandler")]
			get {
				if (id_getInProgressUploadMessageRowIdsString == IntPtr.Zero)
					id_getInProgressUploadMessageRowIdsString = JNIEnv.GetMethodID (class_ref, "getInProgressUploadMessageRowIdsString", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInProgressUploadMessageRowIdsString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInProgressUploadMessageRowIdsString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isPendingActions;
#pragma warning disable 0169
		static Delegate GetIsPendingActionsHandler ()
		{
			if (cb_isPendingActions == null)
				cb_isPendingActions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPendingActions);
			return cb_isPendingActions;
		}

		static bool n_IsPendingActions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.FileSharingManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.FileSharingManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPendingActions;
		}
#pragma warning restore 0169

		static IntPtr id_isPendingActions;
		public virtual unsafe bool IsPendingActions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='FileSharingManager']/method[@name='isPendingActions' and count(parameter)=0]"
			[Register ("isPendingActions", "()Z", "GetIsPendingActionsHandler")]
			get {
				if (id_isPendingActions == IntPtr.Zero)
					id_isPendingActions = JNIEnv.GetMethodID (class_ref, "isPendingActions", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPendingActions);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPendingActions", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_actionFromService_Landroid_content_Intent_Lcom_liveperson_messaging_background_BackgroundActionsService_ServiceActionCallbackListener_;
#pragma warning disable 0169
		static Delegate GetActionFromService_Landroid_content_Intent_Lcom_liveperson_messaging_background_BackgroundActionsService_ServiceActionCallbackListener_Handler ()
		{
			if (cb_actionFromService_Landroid_content_Intent_Lcom_liveperson_messaging_background_BackgroundActionsService_ServiceActionCallbackListener_ == null)
				cb_actionFromService_Landroid_content_Intent_Lcom_liveperson_messaging_background_BackgroundActionsService_ServiceActionCallbackListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ActionFromService_Landroid_content_Intent_Lcom_liveperson_messaging_background_BackgroundActionsService_ServiceActionCallbackListener_);
			return cb_actionFromService_Landroid_content_Intent_Lcom_liveperson_messaging_background_BackgroundActionsService_ServiceActionCallbackListener_;
		}

		static void n_ActionFromService_Landroid_content_Intent_Lcom_liveperson_messaging_background_BackgroundActionsService_ServiceActionCallbackListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Background.FileSharingManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.FileSharingManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Background.BackgroundActionsService.IServiceActionCallbackListener p1 = (global::Com.Liveperson.Messaging.Background.BackgroundActionsService.IServiceActionCallbackListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.BackgroundActionsService.IServiceActionCallbackListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ActionFromService (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_actionFromService_Landroid_content_Intent_Lcom_liveperson_messaging_background_BackgroundActionsService_ServiceActionCallbackListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='FileSharingManager']/method[@name='actionFromService' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.liveperson.messaging.background.BackgroundActionsService.ServiceActionCallbackListener']]"
		[Register ("actionFromService", "(Landroid/content/Intent;Lcom/liveperson/messaging/background/BackgroundActionsService$ServiceActionCallbackListener;)V", "GetActionFromService_Landroid_content_Intent_Lcom_liveperson_messaging_background_BackgroundActionsService_ServiceActionCallbackListener_Handler")]
		public virtual unsafe void ActionFromService (global::Android.Content.Intent p0, global::Com.Liveperson.Messaging.Background.BackgroundActionsService.IServiceActionCallbackListener p1)
		{
			if (id_actionFromService_Landroid_content_Intent_Lcom_liveperson_messaging_background_BackgroundActionsService_ServiceActionCallbackListener_ == IntPtr.Zero)
				id_actionFromService_Landroid_content_Intent_Lcom_liveperson_messaging_background_BackgroundActionsService_ServiceActionCallbackListener_ = JNIEnv.GetMethodID (class_ref, "actionFromService", "(Landroid/content/Intent;Lcom/liveperson/messaging/background/BackgroundActionsService$ServiceActionCallbackListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_actionFromService_Landroid_content_Intent_Lcom_liveperson_messaging_background_BackgroundActionsService_ServiceActionCallbackListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "actionFromService", "(Landroid/content/Intent;Lcom/liveperson/messaging/background/BackgroundActionsService$ServiceActionCallbackListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_downloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_messaging_background_FileSharingManager_FileDownloadProgressListener_;
#pragma warning disable 0169
		static Delegate GetDownloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_messaging_background_FileSharingManager_FileDownloadProgressListener_Handler ()
		{
			if (cb_downloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_messaging_background_FileSharingManager_FileDownloadProgressListener_ == null)
				cb_downloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_messaging_background_FileSharingManager_FileDownloadProgressListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long, long, IntPtr>) n_DownloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_messaging_background_FileSharingManager_FileDownloadProgressListener_);
			return cb_downloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_messaging_background_FileSharingManager_FileDownloadProgressListener_;
		}

		static void n_DownloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_messaging_background_FileSharingManager_FileDownloadProgressListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, long p4, long p5, IntPtr native_p6)
		{
			global::Com.Liveperson.Messaging.Background.FileSharingManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.FileSharingManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Background.FileSharingManager.IFileDownloadProgressListener p6 = (global::Com.Liveperson.Messaging.Background.FileSharingManager.IFileDownloadProgressListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.FileSharingManager.IFileDownloadProgressListener> (native_p6, JniHandleOwnership.DoNotTransfer);
			__this.DownloadFile (p0, p1, p2, p3, p4, p5, p6);
		}
#pragma warning restore 0169

		static IntPtr id_downloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_messaging_background_FileSharingManager_FileDownloadProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='FileSharingManager']/method[@name='downloadFile' and count(parameter)=7 and parameter[1][@type='com.liveperson.messaging.background.filesharing.FileSharingType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='long'] and parameter[6][@type='long'] and parameter[7][@type='com.liveperson.messaging.background.FileSharingManager.FileDownloadProgressListener']]"
		[Register ("downloadFile", "(Lcom/liveperson/messaging/background/filesharing/FileSharingType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JJLcom/liveperson/messaging/background/FileSharingManager$FileDownloadProgressListener;)V", "GetDownloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_messaging_background_FileSharingManager_FileDownloadProgressListener_Handler")]
		public virtual unsafe void DownloadFile (global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType p0, string p1, string p2, string p3, long p4, long p5, global::Com.Liveperson.Messaging.Background.FileSharingManager.IFileDownloadProgressListener p6)
		{
			if (id_downloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_messaging_background_FileSharingManager_FileDownloadProgressListener_ == IntPtr.Zero)
				id_downloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_messaging_background_FileSharingManager_FileDownloadProgressListener_ = JNIEnv.GetMethodID (class_ref, "downloadFile", "(Lcom/liveperson/messaging/background/filesharing/FileSharingType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JJLcom/liveperson/messaging/background/FileSharingManager$FileDownloadProgressListener;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_downloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_messaging_background_FileSharingManager_FileDownloadProgressListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "downloadFile", "(Lcom/liveperson/messaging/background/filesharing/FileSharingType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JJLcom/liveperson/messaging/background/FileSharingManager$FileDownloadProgressListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_reUploadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_messaging_background_FileSharingManager_FileUploadProgressListener_;
#pragma warning disable 0169
		static Delegate GetReUploadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_messaging_background_FileSharingManager_FileUploadProgressListener_Handler ()
		{
			if (cb_reUploadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_messaging_background_FileSharingManager_FileUploadProgressListener_ == null)
				cb_reUploadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_messaging_background_FileSharingManager_FileUploadProgressListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long, long, IntPtr>) n_ReUploadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_messaging_background_FileSharingManager_FileUploadProgressListener_);
			return cb_reUploadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_messaging_background_FileSharingManager_FileUploadProgressListener_;
		}

		static void n_ReUploadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_messaging_background_FileSharingManager_FileUploadProgressListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, long p5, long p6, IntPtr native_p7)
		{
			global::Com.Liveperson.Messaging.Background.FileSharingManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.FileSharingManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Background.FileSharingManager.IFileUploadProgressListener p7 = (global::Com.Liveperson.Messaging.Background.FileSharingManager.IFileUploadProgressListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.FileSharingManager.IFileUploadProgressListener> (native_p7, JniHandleOwnership.DoNotTransfer);
			__this.ReUploadFile (p0, p1, p2, p3, p4, p5, p6, p7);
		}
#pragma warning restore 0169

		static IntPtr id_reUploadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_messaging_background_FileSharingManager_FileUploadProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='FileSharingManager']/method[@name='reUploadFile' and count(parameter)=8 and parameter[1][@type='com.liveperson.messaging.background.filesharing.FileSharingType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='long'] and parameter[7][@type='long'] and parameter[8][@type='com.liveperson.messaging.background.FileSharingManager.FileUploadProgressListener']]"
		[Register ("reUploadFile", "(Lcom/liveperson/messaging/background/filesharing/FileSharingType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JJLcom/liveperson/messaging/background/FileSharingManager$FileUploadProgressListener;)V", "GetReUploadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_messaging_background_FileSharingManager_FileUploadProgressListener_Handler")]
		public virtual unsafe void ReUploadFile (global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType p0, string p1, string p2, string p3, string p4, long p5, long p6, global::Com.Liveperson.Messaging.Background.FileSharingManager.IFileUploadProgressListener p7)
		{
			if (id_reUploadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_messaging_background_FileSharingManager_FileUploadProgressListener_ == IntPtr.Zero)
				id_reUploadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_messaging_background_FileSharingManager_FileUploadProgressListener_ = JNIEnv.GetMethodID (class_ref, "reUploadFile", "(Lcom/liveperson/messaging/background/filesharing/FileSharingType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JJLcom/liveperson/messaging/background/FileSharingManager$FileUploadProgressListener;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reUploadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_messaging_background_FileSharingManager_FileUploadProgressListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reUploadFile", "(Lcom/liveperson/messaging/background/filesharing/FileSharingType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JJLcom/liveperson/messaging/background/FileSharingManager$FileUploadProgressListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_removeMultipleOlderFiles_Ljava_lang_String_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveMultipleOlderFiles_Ljava_lang_String_ILjava_lang_String_Handler ()
		{
			if (cb_removeMultipleOlderFiles_Ljava_lang_String_ILjava_lang_String_ == null)
				cb_removeMultipleOlderFiles_Ljava_lang_String_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_RemoveMultipleOlderFiles_Ljava_lang_String_ILjava_lang_String_);
			return cb_removeMultipleOlderFiles_Ljava_lang_String_ILjava_lang_String_;
		}

		static void n_RemoveMultipleOlderFiles_Ljava_lang_String_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.Background.FileSharingManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.FileSharingManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMultipleOlderFiles (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_removeMultipleOlderFiles_Ljava_lang_String_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='FileSharingManager']/method[@name='removeMultipleOlderFiles' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("removeMultipleOlderFiles", "(Ljava/lang/String;ILjava/lang/String;)V", "GetRemoveMultipleOlderFiles_Ljava_lang_String_ILjava_lang_String_Handler")]
		public virtual unsafe void RemoveMultipleOlderFiles (string p0, int p1, string p2)
		{
			if (id_removeMultipleOlderFiles_Ljava_lang_String_ILjava_lang_String_ == IntPtr.Zero)
				id_removeMultipleOlderFiles_Ljava_lang_String_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeMultipleOlderFiles", "(Ljava/lang/String;ILjava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeMultipleOlderFiles_Ljava_lang_String_ILjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeMultipleOlderFiles", "(Ljava/lang/String;ILjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_uploadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_liveperson_messaging_background_FileSharingManager_FileUploadProgressListener_;
#pragma warning disable 0169
		static Delegate GetUploadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_liveperson_messaging_background_FileSharingManager_FileUploadProgressListener_Handler ()
		{
			if (cb_uploadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_liveperson_messaging_background_FileSharingManager_FileUploadProgressListener_ == null)
				cb_uploadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_liveperson_messaging_background_FileSharingManager_FileUploadProgressListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_UploadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_liveperson_messaging_background_FileSharingManager_FileUploadProgressListener_);
			return cb_uploadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_liveperson_messaging_background_FileSharingManager_FileUploadProgressListener_;
		}

		static void n_UploadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_liveperson_messaging_background_FileSharingManager_FileUploadProgressListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, bool p5, IntPtr native_p6)
		{
			global::Com.Liveperson.Messaging.Background.FileSharingManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.FileSharingManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Background.FileSharingManager.IFileUploadProgressListener p6 = (global::Com.Liveperson.Messaging.Background.FileSharingManager.IFileUploadProgressListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.FileSharingManager.IFileUploadProgressListener> (native_p6, JniHandleOwnership.DoNotTransfer);
			__this.UploadFile (p0, p1, p2, p3, p4, p5, p6);
		}
#pragma warning restore 0169

		static IntPtr id_uploadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_liveperson_messaging_background_FileSharingManager_FileUploadProgressListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='FileSharingManager']/method[@name='uploadFile' and count(parameter)=7 and parameter[1][@type='com.liveperson.messaging.background.filesharing.FileSharingType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='boolean'] and parameter[7][@type='com.liveperson.messaging.background.FileSharingManager.FileUploadProgressListener']]"
		[Register ("uploadFile", "(Lcom/liveperson/messaging/background/filesharing/FileSharingType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLcom/liveperson/messaging/background/FileSharingManager$FileUploadProgressListener;)V", "GetUploadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_liveperson_messaging_background_FileSharingManager_FileUploadProgressListener_Handler")]
		public virtual unsafe void UploadFile (global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType p0, string p1, string p2, string p3, string p4, bool p5, global::Com.Liveperson.Messaging.Background.FileSharingManager.IFileUploadProgressListener p6)
		{
			if (id_uploadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_liveperson_messaging_background_FileSharingManager_FileUploadProgressListener_ == IntPtr.Zero)
				id_uploadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_liveperson_messaging_background_FileSharingManager_FileUploadProgressListener_ = JNIEnv.GetMethodID (class_ref, "uploadFile", "(Lcom/liveperson/messaging/background/filesharing/FileSharingType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLcom/liveperson/messaging/background/FileSharingManager$FileUploadProgressListener;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_uploadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_liveperson_messaging_background_FileSharingManager_FileUploadProgressListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "uploadFile", "(Lcom/liveperson/messaging/background/filesharing/FileSharingType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLcom/liveperson/messaging/background/FileSharingManager$FileUploadProgressListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

	}
}
