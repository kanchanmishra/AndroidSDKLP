using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Background.Filesharing.Voice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.voice']/class[@name='UploadVoiceTask']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/background/filesharing/voice/UploadVoiceTask", DoNotGenerateAcw=true)]
	public partial class UploadVoiceTask : global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.voice']/class[@name='UploadVoiceTask']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "UploadVoiceTask";

		static IntPtr mPreviewContentType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.voice']/class[@name='UploadVoiceTask']/field[@name='mPreviewContentType']"
		[Register ("mPreviewContentType")]
		protected string MPreviewContentType {
			get {
				if (mPreviewContentType_jfieldId == IntPtr.Zero)
					mPreviewContentType_jfieldId = JNIEnv.GetFieldID (class_ref, "mPreviewContentType", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mPreviewContentType_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPreviewContentType_jfieldId == IntPtr.Zero)
					mPreviewContentType_jfieldId = JNIEnv.GetFieldID (class_ref, "mPreviewContentType", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mPreviewContentType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mUploadFileTaskBundle_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.voice']/class[@name='UploadVoiceTask']/field[@name='mUploadFileTaskBundle']"
		[Register ("mUploadFileTaskBundle")]
		protected global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle MUploadFileTaskBundle {
			get {
				if (mUploadFileTaskBundle_jfieldId == IntPtr.Zero)
					mUploadFileTaskBundle_jfieldId = JNIEnv.GetFieldID (class_ref, "mUploadFileTaskBundle", "Lcom/liveperson/messaging/background/filesharing/UploadFileTaskBundle;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mUploadFileTaskBundle_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mUploadFileTaskBundle_jfieldId == IntPtr.Zero)
					mUploadFileTaskBundle_jfieldId = JNIEnv.GetFieldID (class_ref, "mUploadFileTaskBundle", "Lcom/liveperson/messaging/background/filesharing/UploadFileTaskBundle;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mUploadFileTaskBundle_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/background/filesharing/voice/UploadVoiceTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UploadVoiceTask); }
		}

		protected UploadVoiceTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_background_filesharing_UploadFileTaskBundle_Ljava_lang_Integer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.voice']/class[@name='UploadVoiceTask']/constructor[@name='UploadVoiceTask' and count(parameter)=2 and parameter[1][@type='com.liveperson.messaging.background.filesharing.UploadFileTaskBundle'] and parameter[2][@type='java.lang.Integer']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/background/filesharing/UploadFileTaskBundle;Ljava/lang/Integer;)V", "")]
		public unsafe UploadVoiceTask (global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle p0, global::Java.Lang.Integer p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (UploadVoiceTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/background/filesharing/UploadFileTaskBundle;Ljava/lang/Integer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/background/filesharing/UploadFileTaskBundle;Ljava/lang/Integer;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_background_filesharing_UploadFileTaskBundle_Ljava_lang_Integer_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_background_filesharing_UploadFileTaskBundle_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/background/filesharing/UploadFileTaskBundle;Ljava/lang/Integer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_background_filesharing_UploadFileTaskBundle_Ljava_lang_Integer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_background_filesharing_UploadFileTaskBundle_Ljava_lang_Integer_, __args);
			} finally {
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
			global::Com.Liveperson.Messaging.Background.Filesharing.Voice.UploadVoiceTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Voice.UploadVoiceTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TaskId;
		}
#pragma warning restore 0169

		static IntPtr id_getTaskId;
		public override unsafe int TaskId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.voice']/class[@name='UploadVoiceTask']/method[@name='getTaskId' and count(parameter)=0]"
			[Register ("getTaskId", "()I", "GetGetTaskIdHandler")]
			get {
				if (id_getTaskId == IntPtr.Zero)
					id_getTaskId = JNIEnv.GetMethodID (class_ref, "getTaskId", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTaskId);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTaskId", "()I"));
				} finally {
				}
			}
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
			global::Com.Liveperson.Messaging.Background.Filesharing.Voice.UploadVoiceTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Voice.UploadVoiceTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ThumbnailBase64);
		}
#pragma warning restore 0169

		static IntPtr id_getThumbnailBase64;
		public override unsafe string ThumbnailBase64 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.voice']/class[@name='UploadVoiceTask']/method[@name='getThumbnailBase64' and count(parameter)=0]"
			[Register ("getThumbnailBase64", "()Ljava/lang/String;", "GetGetThumbnailBase64Handler")]
			get {
				if (id_getThumbnailBase64 == IntPtr.Zero)
					id_getThumbnailBase64 = JNIEnv.GetMethodID (class_ref, "getThumbnailBase64", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getThumbnailBase64), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThumbnailBase64", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
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
			global::Com.Liveperson.Messaging.Background.Filesharing.Voice.UploadVoiceTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Voice.UploadVoiceTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UploadTaskBundle);
		}
#pragma warning restore 0169

		static IntPtr id_getUploadTaskBundle;
		protected override unsafe global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle UploadTaskBundle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.voice']/class[@name='UploadVoiceTask']/method[@name='getUploadTaskBundle' and count(parameter)=0]"
			[Register ("getUploadTaskBundle", "()Lcom/liveperson/messaging/background/filesharing/UploadFileTaskBundle;", "GetGetUploadTaskBundleHandler")]
			get {
				if (id_getUploadTaskBundle == IntPtr.Zero)
					id_getUploadTaskBundle = JNIEnv.GetMethodID (class_ref, "getUploadTaskBundle", "()Lcom/liveperson/messaging/background/filesharing/UploadFileTaskBundle;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUploadTaskBundle), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUploadTaskBundle", "()Lcom/liveperson/messaging/background/filesharing/UploadFileTaskBundle;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_createSendMessageCommand_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateSendMessageCommand_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_createSendMessageCommand_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_createSendMessageCommand_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateSendMessageCommand_Ljava_lang_String_Ljava_lang_String_);
			return cb_createSendMessageCommand_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_CreateSendMessageCommand_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.Voice.UploadVoiceTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Voice.UploadVoiceTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CreateSendMessageCommand (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_createSendMessageCommand_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.voice']/class[@name='UploadVoiceTask']/method[@name='createSendMessageCommand' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("createSendMessageCommand", "(Ljava/lang/String;Ljava/lang/String;)V", "GetCreateSendMessageCommand_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe void CreateSendMessageCommand (string p0, string p1)
		{
			if (id_createSendMessageCommand_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_createSendMessageCommand_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createSendMessageCommand", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createSendMessageCommand_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createSendMessageCommand", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
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
			global::Com.Liveperson.Messaging.Background.Filesharing.Voice.UploadVoiceTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Voice.UploadVoiceTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetFileByteArray ());
		}
#pragma warning restore 0169

		static IntPtr id_getFileByteArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.voice']/class[@name='UploadVoiceTask']/method[@name='getFileByteArray' and count(parameter)=0]"
		[Register ("getFileByteArray", "()[B", "GetGetFileByteArrayHandler")]
		protected override unsafe byte[] GetFileByteArray ()
		{
			if (id_getFileByteArray == IntPtr.Zero)
				id_getFileByteArray = JNIEnv.GetMethodID (class_ref, "getFileByteArray", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFileByteArray), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileByteArray", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
