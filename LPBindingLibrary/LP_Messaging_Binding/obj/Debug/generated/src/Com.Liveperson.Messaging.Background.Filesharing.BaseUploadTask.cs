using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Background.Filesharing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/background/filesharing/BaseUploadTask", DoNotGenerateAcw=true)]
	public abstract partial class BaseUploadTask : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "BaseUploadTask";

		static IntPtr mFileRowId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/field[@name='mFileRowId']"
		[Register ("mFileRowId")]
		protected long MFileRowId {
			get {
				if (mFileRowId_jfieldId == IntPtr.Zero)
					mFileRowId_jfieldId = JNIEnv.GetFieldID (class_ref, "mFileRowId", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, mFileRowId_jfieldId);
			}
			set {
				if (mFileRowId_jfieldId == IntPtr.Zero)
					mFileRowId_jfieldId = JNIEnv.GetFieldID (class_ref, "mFileRowId", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFileRowId_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mMessageRowId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/field[@name='mMessageRowId']"
		[Register ("mMessageRowId")]
		protected long MMessageRowId {
			get {
				if (mMessageRowId_jfieldId == IntPtr.Zero)
					mMessageRowId_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessageRowId", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, mMessageRowId_jfieldId);
			}
			set {
				if (mMessageRowId_jfieldId == IntPtr.Zero)
					mMessageRowId_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessageRowId", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMessageRowId_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mOriginalFileByteArray_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/field[@name='mOriginalFileByteArray']"
		[Register ("mOriginalFileByteArray")]
		protected IList<byte> MOriginalFileByteArray {
			get {
				if (mOriginalFileByteArray_jfieldId == IntPtr.Zero)
					mOriginalFileByteArray_jfieldId = JNIEnv.GetFieldID (class_ref, "mOriginalFileByteArray", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mOriginalFileByteArray_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mOriginalFileByteArray_jfieldId == IntPtr.Zero)
					mOriginalFileByteArray_jfieldId = JNIEnv.GetFieldID (class_ref, "mOriginalFileByteArray", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mOriginalFileByteArray_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mRelativePath_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/field[@name='mRelativePath']"
		[Register ("mRelativePath")]
		protected string MRelativePath {
			get {
				if (mRelativePath_jfieldId == IntPtr.Zero)
					mRelativePath_jfieldId = JNIEnv.GetFieldID (class_ref, "mRelativePath", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mRelativePath_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mRelativePath_jfieldId == IntPtr.Zero)
					mRelativePath_jfieldId = JNIEnv.GetFieldID (class_ref, "mRelativePath", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mRelativePath_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mStatus_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/field[@name='mStatus']"
		[Register ("mStatus")]
		protected global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus MStatus {
			get {
				if (mStatus_jfieldId == IntPtr.Zero)
					mStatus_jfieldId = JNIEnv.GetFieldID (class_ref, "mStatus", "Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mStatus_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mStatus_jfieldId == IntPtr.Zero)
					mStatus_jfieldId = JNIEnv.GetFieldID (class_ref, "mStatus", "Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mStatus_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mUploadTimeout_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/field[@name='mUploadTimeout']"
		[Register ("mUploadTimeout")]
		protected int MUploadTimeout {
			get {
				if (mUploadTimeout_jfieldId == IntPtr.Zero)
					mUploadTimeout_jfieldId = JNIEnv.GetFieldID (class_ref, "mUploadTimeout", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mUploadTimeout_jfieldId);
			}
			set {
				if (mUploadTimeout_jfieldId == IntPtr.Zero)
					mUploadTimeout_jfieldId = JNIEnv.GetFieldID (class_ref, "mUploadTimeout", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mUploadTimeout_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr sendMessageCommand_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/field[@name='sendMessageCommand']"
		[Register ("sendMessageCommand")]
		protected global::Com.Liveperson.Messaging.Commands.SendFileCommand SendMessageCommand {
			get {
				if (sendMessageCommand_jfieldId == IntPtr.Zero)
					sendMessageCommand_jfieldId = JNIEnv.GetFieldID (class_ref, "sendMessageCommand", "Lcom/liveperson/messaging/commands/SendFileCommand;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, sendMessageCommand_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.SendFileCommand> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sendMessageCommand_jfieldId == IntPtr.Zero)
					sendMessageCommand_jfieldId = JNIEnv.GetFieldID (class_ref, "sendMessageCommand", "Lcom/liveperson/messaging/commands/SendFileCommand;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sendMessageCommand_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/background/filesharing/BaseUploadTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseUploadTask); }
		}

		protected BaseUploadTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Integer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/constructor[@name='BaseUploadTask' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register (".ctor", "(Ljava/lang/Integer;)V", "")]
		public unsafe BaseUploadTask (global::Java.Lang.Integer p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (BaseUploadTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Integer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Integer;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Integer_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Integer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Integer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Integer_, __args);
			} finally {
			}
		}

		static Delegate cb_getEventId;
#pragma warning disable 0169
		static Delegate GetGetEventIdHandler ()
		{
			if (cb_getEventId == null)
				cb_getEventId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventId);
			return cb_getEventId;
		}

		static IntPtr n_GetEventId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EventId);
		}
#pragma warning restore 0169

		static IntPtr id_getEventId;
		public virtual unsafe string EventId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/method[@name='getEventId' and count(parameter)=0]"
			[Register ("getEventId", "()Ljava/lang/String;", "GetGetEventIdHandler")]
			get {
				if (id_getEventId == IntPtr.Zero)
					id_getEventId = JNIEnv.GetMethodID (class_ref, "getEventId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEventId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEventId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isUploadCompleted;
#pragma warning disable 0169
		static Delegate GetIsUploadCompletedHandler ()
		{
			if (cb_isUploadCompleted == null)
				cb_isUploadCompleted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUploadCompleted);
			return cb_isUploadCompleted;
		}

		static bool n_IsUploadCompleted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUploadCompleted;
		}
#pragma warning restore 0169

		static IntPtr id_isUploadCompleted;
		public virtual unsafe bool IsUploadCompleted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/method[@name='isUploadCompleted' and count(parameter)=0]"
			[Register ("isUploadCompleted", "()Z", "GetIsUploadCompletedHandler")]
			get {
				if (id_isUploadCompleted == IntPtr.Zero)
					id_isUploadCompleted = JNIEnv.GetMethodID (class_ref, "isUploadCompleted", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUploadCompleted);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUploadCompleted", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isUploadFailed;
#pragma warning disable 0169
		static Delegate GetIsUploadFailedHandler ()
		{
			if (cb_isUploadFailed == null)
				cb_isUploadFailed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUploadFailed);
			return cb_isUploadFailed;
		}

		static bool n_IsUploadFailed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUploadFailed;
		}
#pragma warning restore 0169

		static IntPtr id_isUploadFailed;
		public virtual unsafe bool IsUploadFailed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/method[@name='isUploadFailed' and count(parameter)=0]"
			[Register ("isUploadFailed", "()Z", "GetIsUploadFailedHandler")]
			get {
				if (id_isUploadFailed == IntPtr.Zero)
					id_isUploadFailed = JNIEnv.GetMethodID (class_ref, "isUploadFailed", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUploadFailed);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUploadFailed", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMessageRowId;
#pragma warning disable 0169
		static Delegate GetGetMessageRowIdHandler ()
		{
			if (cb_getMessageRowId == null)
				cb_getMessageRowId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMessageRowId);
			return cb_getMessageRowId;
		}

		static long n_GetMessageRowId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageRowId;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageRowId;
		public virtual unsafe long MessageRowId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/method[@name='getMessageRowId' and count(parameter)=0]"
			[Register ("getMessageRowId", "()J", "GetGetMessageRowIdHandler")]
			get {
				if (id_getMessageRowId == IntPtr.Zero)
					id_getMessageRowId = JNIEnv.GetMethodID (class_ref, "getMessageRowId", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getMessageRowId);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageRowId", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getTaskId;
#pragma warning disable 0169
		static Delegate GetGetTaskIdHandler ()
		{
			if (cb_getTaskId == null)
				cb_getTaskId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTaskId);
			return cb_getTaskId;
		}

		static int n_GetTaskId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TaskId;
		}
#pragma warning restore 0169

		public abstract int TaskId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/method[@name='getTaskId' and count(parameter)=0]"
			[Register ("getTaskId", "()I", "GetGetTaskIdHandler")] get;
		}

		static Delegate cb_getThumbnailBase64;
#pragma warning disable 0169
		static Delegate GetGetThumbnailBase64Handler ()
		{
			if (cb_getThumbnailBase64 == null)
				cb_getThumbnailBase64 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThumbnailBase64);
			return cb_getThumbnailBase64;
		}

		static IntPtr n_GetThumbnailBase64 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ThumbnailBase64);
		}
#pragma warning restore 0169

		public abstract string ThumbnailBase64 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/method[@name='getThumbnailBase64' and count(parameter)=0]"
			[Register ("getThumbnailBase64", "()Ljava/lang/String;", "GetGetThumbnailBase64Handler")] get;
		}

		static Delegate cb_getUploadTaskBundle;
#pragma warning disable 0169
		static Delegate GetGetUploadTaskBundleHandler ()
		{
			if (cb_getUploadTaskBundle == null)
				cb_getUploadTaskBundle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUploadTaskBundle);
			return cb_getUploadTaskBundle;
		}

		static IntPtr n_GetUploadTaskBundle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UploadTaskBundle);
		}
#pragma warning restore 0169

		protected abstract global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle UploadTaskBundle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/method[@name='getUploadTaskBundle' and count(parameter)=0]"
			[Register ("getUploadTaskBundle", "()Lcom/liveperson/messaging/background/filesharing/UploadFileTaskBundle;", "GetGetUploadTaskBundleHandler")] get;
		}

		static Delegate cb_getFileByteArray;
#pragma warning disable 0169
		static Delegate GetGetFileByteArrayHandler ()
		{
			if (cb_getFileByteArray == null)
				cb_getFileByteArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileByteArray);
			return cb_getFileByteArray;
		}

		static IntPtr n_GetFileByteArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetFileByteArray ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/method[@name='getFileByteArray' and count(parameter)=0]"
		[Register ("getFileByteArray", "()[B", "GetGetFileByteArrayHandler")]
		protected abstract byte[] GetFileByteArray ();

		static Delegate cb_onConnectionAvailable;
#pragma warning disable 0169
		static Delegate GetOnConnectionAvailableHandler ()
		{
			if (cb_onConnectionAvailable == null)
				cb_onConnectionAvailable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnConnectionAvailable);
			return cb_onConnectionAvailable;
		}

		static void n_OnConnectionAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionAvailable ();
		}
#pragma warning restore 0169

		static IntPtr id_onConnectionAvailable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/method[@name='onConnectionAvailable' and count(parameter)=0]"
		[Register ("onConnectionAvailable", "()V", "GetOnConnectionAvailableHandler")]
		public virtual unsafe void OnConnectionAvailable ()
		{
			if (id_onConnectionAvailable == IntPtr.Zero)
				id_onConnectionAvailable = JNIEnv.GetMethodID (class_ref, "onConnectionAvailable", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionAvailable);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnectionAvailable", "()V"));
			} finally {
			}
		}

		static Delegate cb_onConnectionUnavailable;
#pragma warning disable 0169
		static Delegate GetOnConnectionUnavailableHandler ()
		{
			if (cb_onConnectionUnavailable == null)
				cb_onConnectionUnavailable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnConnectionUnavailable);
			return cb_onConnectionUnavailable;
		}

		static void n_OnConnectionUnavailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionUnavailable ();
		}
#pragma warning restore 0169

		static IntPtr id_onConnectionUnavailable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/method[@name='onConnectionUnavailable' and count(parameter)=0]"
		[Register ("onConnectionUnavailable", "()V", "GetOnConnectionUnavailableHandler")]
		public virtual unsafe void OnConnectionUnavailable ()
		{
			if (id_onConnectionUnavailable == IntPtr.Zero)
				id_onConnectionUnavailable = JNIEnv.GetMethodID (class_ref, "onConnectionUnavailable", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionUnavailable);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnectionUnavailable", "()V"));
			} finally {
			}
		}

		static Delegate cb_onUploadFailed_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnUploadFailed_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onUploadFailed_Ljava_lang_Throwable_ == null)
				cb_onUploadFailed_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUploadFailed_Ljava_lang_Throwable_);
			return cb_onUploadFailed_Ljava_lang_Throwable_;
		}

		static void n_OnUploadFailed_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUploadFailed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onUploadFailed_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/method[@name='onUploadFailed' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("onUploadFailed", "(Ljava/lang/Throwable;)V", "GetOnUploadFailed_Ljava_lang_Throwable_Handler")]
		protected virtual unsafe void OnUploadFailed (global::Java.Lang.Throwable p0)
		{
			if (id_onUploadFailed_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onUploadFailed_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onUploadFailed", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUploadFailed_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUploadFailed", "(Ljava/lang/Throwable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sendPublishFile_Z;
#pragma warning disable 0169
		static Delegate GetSendPublishFile_ZHandler ()
		{
			if (cb_sendPublishFile_Z == null)
				cb_sendPublishFile_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SendPublishFile_Z);
			return cb_sendPublishFile_Z;
		}

		static void n_SendPublishFile_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendPublishFile (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendPublishFile_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/method[@name='sendPublishFile' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("sendPublishFile", "(Z)V", "GetSendPublishFile_ZHandler")]
		public virtual unsafe void SendPublishFile (bool p0)
		{
			if (id_sendPublishFile_Z == IntPtr.Zero)
				id_sendPublishFile_Z = JNIEnv.GetMethodID (class_ref, "sendPublishFile", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendPublishFile_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendPublishFile", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCallBack_Lcom_liveperson_messaging_background_UploadFileTaskCallback_;
#pragma warning disable 0169
		static Delegate GetSetCallBack_Lcom_liveperson_messaging_background_UploadFileTaskCallback_Handler ()
		{
			if (cb_setCallBack_Lcom_liveperson_messaging_background_UploadFileTaskCallback_ == null)
				cb_setCallBack_Lcom_liveperson_messaging_background_UploadFileTaskCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallBack_Lcom_liveperson_messaging_background_UploadFileTaskCallback_);
			return cb_setCallBack_Lcom_liveperson_messaging_background_UploadFileTaskCallback_;
		}

		static void n_SetCallBack_Lcom_liveperson_messaging_background_UploadFileTaskCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Background.IUploadFileTaskCallback p0 = (global::Com.Liveperson.Messaging.Background.IUploadFileTaskCallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.IUploadFileTaskCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCallBack (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCallBack_Lcom_liveperson_messaging_background_UploadFileTaskCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/method[@name='setCallBack' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.background.UploadFileTaskCallback']]"
		[Register ("setCallBack", "(Lcom/liveperson/messaging/background/UploadFileTaskCallback;)V", "GetSetCallBack_Lcom_liveperson_messaging_background_UploadFileTaskCallback_Handler")]
		public virtual unsafe void SetCallBack (global::Com.Liveperson.Messaging.Background.IUploadFileTaskCallback p0)
		{
			if (id_setCallBack_Lcom_liveperson_messaging_background_UploadFileTaskCallback_ == IntPtr.Zero)
				id_setCallBack_Lcom_liveperson_messaging_background_UploadFileTaskCallback_ = JNIEnv.GetMethodID (class_ref, "setCallBack", "(Lcom/liveperson/messaging/background/UploadFileTaskCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCallBack_Lcom_liveperson_messaging_background_UploadFileTaskCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallBack", "(Lcom/liveperson/messaging/background/UploadFileTaskCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSendMessageCommandCallback;
#pragma warning disable 0169
		static Delegate GetSetSendMessageCommandCallbackHandler ()
		{
			if (cb_setSendMessageCommandCallback == null)
				cb_setSendMessageCommandCallback = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetSendMessageCommandCallback);
			return cb_setSendMessageCommandCallback;
		}

		static void n_SetSendMessageCommandCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSendMessageCommandCallback ();
		}
#pragma warning restore 0169

		static IntPtr id_setSendMessageCommandCallback;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/method[@name='setSendMessageCommandCallback' and count(parameter)=0]"
		[Register ("setSendMessageCommandCallback", "()V", "GetSetSendMessageCommandCallbackHandler")]
		protected virtual unsafe void SetSendMessageCommandCallback ()
		{
			if (id_setSendMessageCommandCallback == IntPtr.Zero)
				id_setSendMessageCommandCallback = JNIEnv.GetMethodID (class_ref, "setSendMessageCommandCallback", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSendMessageCommandCallback);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSendMessageCommandCallback", "()V"));
			} finally {
			}
		}

		static Delegate cb_setStatus_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_;
#pragma warning disable 0169
		static Delegate GetSetStatus_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_Handler ()
		{
			if (cb_setStatus_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ == null)
				cb_setStatus_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStatus_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_);
			return cb_setStatus_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_;
		}

		static void n_SetStatus_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetStatus (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStatus_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.database.tables.FilesTable.LoadStatus']]"
		[Register ("setStatus", "(Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;)V", "GetSetStatus_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_Handler")]
		public virtual unsafe void SetStatus (global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus p0)
		{
			if (id_setStatus_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ == IntPtr.Zero)
				id_setStatus_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ = JNIEnv.GetMethodID (class_ref, "setStatus", "(Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStatus_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatus", "(Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startUpload;
#pragma warning disable 0169
		static Delegate GetStartUploadHandler ()
		{
			if (cb_startUpload == null)
				cb_startUpload = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartUpload);
			return cb_startUpload;
		}

		static void n_StartUpload (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartUpload ();
		}
#pragma warning restore 0169

		static IntPtr id_startUpload;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/method[@name='startUpload' and count(parameter)=0]"
		[Register ("startUpload", "()V", "GetStartUploadHandler")]
		public virtual unsafe void StartUpload ()
		{
			if (id_startUpload == IntPtr.Zero)
				id_startUpload = JNIEnv.GetMethodID (class_ref, "startUpload", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startUpload);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startUpload", "()V"));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/messaging/background/filesharing/BaseUploadTask", DoNotGenerateAcw=true)]
	internal partial class BaseUploadTaskInvoker : BaseUploadTask {

		public BaseUploadTaskInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseUploadTaskInvoker); }
		}

		static IntPtr id_getTaskId;
		public override unsafe int TaskId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/method[@name='getTaskId' and count(parameter)=0]"
			[Register ("getTaskId", "()I", "GetGetTaskIdHandler")]
			get {
				if (id_getTaskId == IntPtr.Zero)
					id_getTaskId = JNIEnv.GetMethodID (class_ref, "getTaskId", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTaskId);
				} finally {
				}
			}
		}

		static IntPtr id_getThumbnailBase64;
		public override unsafe string ThumbnailBase64 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/method[@name='getThumbnailBase64' and count(parameter)=0]"
			[Register ("getThumbnailBase64", "()Ljava/lang/String;", "GetGetThumbnailBase64Handler")]
			get {
				if (id_getThumbnailBase64 == IntPtr.Zero)
					id_getThumbnailBase64 = JNIEnv.GetMethodID (class_ref, "getThumbnailBase64", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getThumbnailBase64), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getUploadTaskBundle;
		protected override unsafe global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle UploadTaskBundle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/method[@name='getUploadTaskBundle' and count(parameter)=0]"
			[Register ("getUploadTaskBundle", "()Lcom/liveperson/messaging/background/filesharing/UploadFileTaskBundle;", "GetGetUploadTaskBundleHandler")]
			get {
				if (id_getUploadTaskBundle == IntPtr.Zero)
					id_getUploadTaskBundle = JNIEnv.GetMethodID (class_ref, "getUploadTaskBundle", "()Lcom/liveperson/messaging/background/filesharing/UploadFileTaskBundle;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUploadTaskBundle), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getFileByteArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='BaseUploadTask']/method[@name='getFileByteArray' and count(parameter)=0]"
		[Register ("getFileByteArray", "()[B", "GetGetFileByteArrayHandler")]
		protected override unsafe byte[] GetFileByteArray ()
		{
			if (id_getFileByteArray == IntPtr.Zero)
				id_getFileByteArray = JNIEnv.GetMethodID (class_ref, "getFileByteArray", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFileByteArray), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}

}
