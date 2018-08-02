using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Background.Filesharing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='UploadFileTaskBundle']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/background/filesharing/UploadFileTaskBundle", DoNotGenerateAcw=true)]
	public partial class UploadFileTaskBundle : global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='UploadFileTaskBundle']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "UploadFileTaskBundle";

		static IntPtr mFileContentType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='UploadFileTaskBundle']/field[@name='mFileContentType']"
		[Register ("mFileContentType")]
		protected string MFileContentType {
			get {
				if (mFileContentType_jfieldId == IntPtr.Zero)
					mFileContentType_jfieldId = JNIEnv.GetFieldID (class_ref, "mFileContentType", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mFileContentType_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mFileContentType_jfieldId == IntPtr.Zero)
					mFileContentType_jfieldId = JNIEnv.GetFieldID (class_ref, "mFileContentType", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFileContentType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mFilePath_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='UploadFileTaskBundle']/field[@name='mFilePath']"
		[Register ("mFilePath")]
		protected string MFilePath {
			get {
				if (mFilePath_jfieldId == IntPtr.Zero)
					mFilePath_jfieldId = JNIEnv.GetFieldID (class_ref, "mFilePath", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mFilePath_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mFilePath_jfieldId == IntPtr.Zero)
					mFilePath_jfieldId = JNIEnv.GetFieldID (class_ref, "mFilePath", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFilePath_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mFileTypeExtension_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='UploadFileTaskBundle']/field[@name='mFileTypeExtension']"
		[Register ("mFileTypeExtension")]
		protected string MFileTypeExtension {
			get {
				if (mFileTypeExtension_jfieldId == IntPtr.Zero)
					mFileTypeExtension_jfieldId = JNIEnv.GetFieldID (class_ref, "mFileTypeExtension", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mFileTypeExtension_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mFileTypeExtension_jfieldId == IntPtr.Zero)
					mFileTypeExtension_jfieldId = JNIEnv.GetFieldID (class_ref, "mFileTypeExtension", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFileTypeExtension_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mFileUri_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='UploadFileTaskBundle']/field[@name='mFileUri']"
		[Register ("mFileUri")]
		protected global::Android.Net.Uri MFileUri {
			get {
				if (mFileUri_jfieldId == IntPtr.Zero)
					mFileUri_jfieldId = JNIEnv.GetFieldID (class_ref, "mFileUri", "Landroid/net/Uri;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mFileUri_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mFileUri_jfieldId == IntPtr.Zero)
					mFileUri_jfieldId = JNIEnv.GetFieldID (class_ref, "mFileUri", "Landroid/net/Uri;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFileUri_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/background/filesharing/UploadFileTaskBundle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UploadFileTaskBundle); }
		}

		protected UploadFileTaskBundle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='UploadFileTaskBundle']/constructor[@name='UploadFileTaskBundle' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UploadFileTaskBundle ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UploadFileTaskBundle)) {
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

		static Delegate cb_getFileContentType;
#pragma warning disable 0169
		static Delegate GetGetFileContentTypeHandler ()
		{
			if (cb_getFileContentType == null)
				cb_getFileContentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileContentType);
			return cb_getFileContentType;
		}

		static IntPtr n_GetFileContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FileContentType);
		}
#pragma warning restore 0169

		static IntPtr id_getFileContentType;
		public virtual unsafe string FileContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='UploadFileTaskBundle']/method[@name='getFileContentType' and count(parameter)=0]"
			[Register ("getFileContentType", "()Ljava/lang/String;", "GetGetFileContentTypeHandler")]
			get {
				if (id_getFileContentType == IntPtr.Zero)
					id_getFileContentType = JNIEnv.GetMethodID (class_ref, "getFileContentType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFileContentType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileContentType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFilePath;
#pragma warning disable 0169
		static Delegate GetGetFilePathHandler ()
		{
			if (cb_getFilePath == null)
				cb_getFilePath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFilePath);
			return cb_getFilePath;
		}

		static IntPtr n_GetFilePath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FilePath);
		}
#pragma warning restore 0169

		static IntPtr id_getFilePath;
		public virtual unsafe string FilePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='UploadFileTaskBundle']/method[@name='getFilePath' and count(parameter)=0]"
			[Register ("getFilePath", "()Ljava/lang/String;", "GetGetFilePathHandler")]
			get {
				if (id_getFilePath == IntPtr.Zero)
					id_getFilePath = JNIEnv.GetMethodID (class_ref, "getFilePath", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFilePath), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFilePath", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFileTypeExtension;
#pragma warning disable 0169
		static Delegate GetGetFileTypeExtensionHandler ()
		{
			if (cb_getFileTypeExtension == null)
				cb_getFileTypeExtension = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileTypeExtension);
			return cb_getFileTypeExtension;
		}

		static IntPtr n_GetFileTypeExtension (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FileTypeExtension);
		}
#pragma warning restore 0169

		static Delegate cb_setFileTypeExtension_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFileTypeExtension_Ljava_lang_String_Handler ()
		{
			if (cb_setFileTypeExtension_Ljava_lang_String_ == null)
				cb_setFileTypeExtension_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFileTypeExtension_Ljava_lang_String_);
			return cb_setFileTypeExtension_Ljava_lang_String_;
		}

		static void n_SetFileTypeExtension_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FileTypeExtension = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFileTypeExtension;
		static IntPtr id_setFileTypeExtension_Ljava_lang_String_;
		public virtual unsafe string FileTypeExtension {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='UploadFileTaskBundle']/method[@name='getFileTypeExtension' and count(parameter)=0]"
			[Register ("getFileTypeExtension", "()Ljava/lang/String;", "GetGetFileTypeExtensionHandler")]
			get {
				if (id_getFileTypeExtension == IntPtr.Zero)
					id_getFileTypeExtension = JNIEnv.GetMethodID (class_ref, "getFileTypeExtension", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFileTypeExtension), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileTypeExtension", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='UploadFileTaskBundle']/method[@name='setFileTypeExtension' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFileTypeExtension", "(Ljava/lang/String;)V", "GetSetFileTypeExtension_Ljava_lang_String_Handler")]
			set {
				if (id_setFileTypeExtension_Ljava_lang_String_ == IntPtr.Zero)
					id_setFileTypeExtension_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFileTypeExtension", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFileTypeExtension_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFileTypeExtension", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFileUri;
#pragma warning disable 0169
		static Delegate GetGetFileUriHandler ()
		{
			if (cb_getFileUri == null)
				cb_getFileUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileUri);
			return cb_getFileUri;
		}

		static IntPtr n_GetFileUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FileUri);
		}
#pragma warning restore 0169

		static IntPtr id_getFileUri;
		public virtual unsafe global::Android.Net.Uri FileUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='UploadFileTaskBundle']/method[@name='getFileUri' and count(parameter)=0]"
			[Register ("getFileUri", "()Landroid/net/Uri;", "GetGetFileUriHandler")]
			get {
				if (id_getFileUri == IntPtr.Zero)
					id_getFileUri = JNIEnv.GetMethodID (class_ref, "getFileUri", "()Landroid/net/Uri;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFileUri), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileUri", "()Landroid/net/Uri;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Message);
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		public virtual unsafe global::Com.Liveperson.Infra.Utils.MaskedMessage Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='UploadFileTaskBundle']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Lcom/liveperson/infra/utils/MaskedMessage;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Lcom/liveperson/infra/utils/MaskedMessage;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.MaskedMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.MaskedMessage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "()Lcom/liveperson/infra/utils/MaskedMessage;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRestParams;
#pragma warning disable 0169
		static Delegate GetGetRestParamsHandler ()
		{
			if (cb_getRestParams == null)
				cb_getRestParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRestParams);
			return cb_getRestParams;
		}

		static IntPtr n_GetRestParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RestParams);
		}
#pragma warning restore 0169

		static IntPtr id_getRestParams;
		public virtual unsafe global::Com.Liveperson.Messaging.Network.Http.RestRequestParams RestParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='UploadFileTaskBundle']/method[@name='getRestParams' and count(parameter)=0]"
			[Register ("getRestParams", "()Lcom/liveperson/messaging/network/http/RestRequestParams;", "GetGetRestParamsHandler")]
			get {
				if (id_getRestParams == IntPtr.Zero)
					id_getRestParams = JNIEnv.GetMethodID (class_ref, "getRestParams", "()Lcom/liveperson/messaging/network/http/RestRequestParams;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.RestRequestParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRestParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.RestRequestParams> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRestParams", "()Lcom/liveperson/messaging/network/http/RestRequestParams;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TaskId;
		}
#pragma warning restore 0169

		static IntPtr id_getTaskId;
		public virtual unsafe int TaskId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='UploadFileTaskBundle']/method[@name='getTaskId' and count(parameter)=0]"
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

		static Delegate cb_addFileUri_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetAddFileUri_Landroid_net_Uri_Handler ()
		{
			if (cb_addFileUri_Landroid_net_Uri_ == null)
				cb_addFileUri_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddFileUri_Landroid_net_Uri_);
			return cb_addFileUri_Landroid_net_Uri_;
		}

		static IntPtr n_AddFileUri_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddFileUri (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addFileUri_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='UploadFileTaskBundle']/method[@name='addFileUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("addFileUri", "(Landroid/net/Uri;)Lcom/liveperson/messaging/background/filesharing/UploadFileTaskBundle;", "GetAddFileUri_Landroid_net_Uri_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle AddFileUri (global::Android.Net.Uri p0)
		{
			if (id_addFileUri_Landroid_net_Uri_ == IntPtr.Zero)
				id_addFileUri_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "addFileUri", "(Landroid/net/Uri;)Lcom/liveperson/messaging/background/filesharing/UploadFileTaskBundle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addFileUri_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFileUri", "(Landroid/net/Uri;)Lcom/liveperson/messaging/background/filesharing/UploadFileTaskBundle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_addMessage_Lcom_liveperson_infra_utils_MaskedMessage_;
#pragma warning disable 0169
		static Delegate GetAddMessage_Lcom_liveperson_infra_utils_MaskedMessage_Handler ()
		{
			if (cb_addMessage_Lcom_liveperson_infra_utils_MaskedMessage_ == null)
				cb_addMessage_Lcom_liveperson_infra_utils_MaskedMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMessage_Lcom_liveperson_infra_utils_MaskedMessage_);
			return cb_addMessage_Lcom_liveperson_infra_utils_MaskedMessage_;
		}

		static IntPtr n_AddMessage_Lcom_liveperson_infra_utils_MaskedMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Utils.MaskedMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.MaskedMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddMessage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMessage_Lcom_liveperson_infra_utils_MaskedMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='UploadFileTaskBundle']/method[@name='addMessage' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.utils.MaskedMessage']]"
		[Register ("addMessage", "(Lcom/liveperson/infra/utils/MaskedMessage;)Lcom/liveperson/messaging/background/filesharing/UploadFileTaskBundle;", "GetAddMessage_Lcom_liveperson_infra_utils_MaskedMessage_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle AddMessage (global::Com.Liveperson.Infra.Utils.MaskedMessage p0)
		{
			if (id_addMessage_Lcom_liveperson_infra_utils_MaskedMessage_ == IntPtr.Zero)
				id_addMessage_Lcom_liveperson_infra_utils_MaskedMessage_ = JNIEnv.GetMethodID (class_ref, "addMessage", "(Lcom/liveperson/infra/utils/MaskedMessage;)Lcom/liveperson/messaging/background/filesharing/UploadFileTaskBundle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMessage_Lcom_liveperson_infra_utils_MaskedMessage_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMessage", "(Lcom/liveperson/infra/utils/MaskedMessage;)Lcom/liveperson/messaging/background/filesharing/UploadFileTaskBundle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_build_ILandroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetBuild_ILandroid_content_Context_Handler ()
		{
			if (cb_build_ILandroid_content_Context_ == null)
				cb_build_ILandroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_Build_ILandroid_content_Context_);
			return cb_build_ILandroid_content_Context_;
		}

		static IntPtr n_Build_ILandroid_content_Context_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Build (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_build_ILandroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='UploadFileTaskBundle']/method[@name='build' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Context']]"
		[Register ("build", "(ILandroid/content/Context;)Lcom/liveperson/messaging/background/filesharing/UploadFileTaskBundle;", "GetBuild_ILandroid_content_Context_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle Build (int p0, global::Android.Content.Context p1)
		{
			if (id_build_ILandroid_content_Context_ == IntPtr.Zero)
				id_build_ILandroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "build", "(ILandroid/content/Context;)Lcom/liveperson/messaging/background/filesharing/UploadFileTaskBundle;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build_ILandroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "(ILandroid/content/Context;)Lcom/liveperson/messaging/background/filesharing/UploadFileTaskBundle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setTaskID_I;
#pragma warning disable 0169
		static Delegate GetSetTaskID_IHandler ()
		{
			if (cb_setTaskID_I == null)
				cb_setTaskID_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTaskID_I);
			return cb_setTaskID_I;
		}

		static void n_SetTaskID_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTaskID (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTaskID_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='UploadFileTaskBundle']/method[@name='setTaskID' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTaskID", "(I)V", "GetSetTaskID_IHandler")]
		protected virtual unsafe void SetTaskID (int p0)
		{
			if (id_setTaskID_I == IntPtr.Zero)
				id_setTaskID_I = JNIEnv.GetMethodID (class_ref, "setTaskID", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTaskID_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTaskID", "(I)V"), __args);
			} finally {
			}
		}

	}
}
