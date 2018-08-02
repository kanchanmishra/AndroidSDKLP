using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Background {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='UploadImageTask']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/background/UploadImageTask", DoNotGenerateAcw=true)]
	public partial class UploadImageTask : global::Com.Liveperson.Messaging.Background.Filesharing.BaseUploadTask {


		static IntPtr mBase64_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='UploadImageTask']/field[@name='mBase64']"
		[Register ("mBase64")]
		protected string MBase64 {
			get {
				if (mBase64_jfieldId == IntPtr.Zero)
					mBase64_jfieldId = JNIEnv.GetFieldID (class_ref, "mBase64", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mBase64_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mBase64_jfieldId == IntPtr.Zero)
					mBase64_jfieldId = JNIEnv.GetFieldID (class_ref, "mBase64", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mBase64_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/background/UploadImageTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UploadImageTask); }
		}

		protected UploadImageTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_background_filesharing_image_UploadImageTaskBundle_Ljava_lang_Integer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='UploadImageTask']/constructor[@name='UploadImageTask' and count(parameter)=2 and parameter[1][@type='com.liveperson.messaging.background.filesharing.image.UploadImageTaskBundle'] and parameter[2][@type='java.lang.Integer']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/background/filesharing/image/UploadImageTaskBundle;Ljava/lang/Integer;)V", "")]
		public unsafe UploadImageTask (global::Com.Liveperson.Messaging.Background.Filesharing.Image.UploadImageTaskBundle p0, global::Java.Lang.Integer p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (UploadImageTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/background/filesharing/image/UploadImageTaskBundle;Ljava/lang/Integer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/background/filesharing/image/UploadImageTaskBundle;Ljava/lang/Integer;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_background_filesharing_image_UploadImageTaskBundle_Ljava_lang_Integer_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_background_filesharing_image_UploadImageTaskBundle_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/background/filesharing/image/UploadImageTaskBundle;Ljava/lang/Integer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_background_filesharing_image_UploadImageTaskBundle_Ljava_lang_Integer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_background_filesharing_image_UploadImageTaskBundle_Ljava_lang_Integer_, __args);
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
			global::Com.Liveperson.Messaging.Background.UploadImageTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.UploadImageTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TaskId;
		}
#pragma warning restore 0169

		static IntPtr id_getTaskId;
		public override unsafe int TaskId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='UploadImageTask']/method[@name='getTaskId' and count(parameter)=0]"
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
			global::Com.Liveperson.Messaging.Background.UploadImageTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.UploadImageTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ThumbnailBase64);
		}
#pragma warning restore 0169

		static IntPtr id_getThumbnailBase64;
		public override unsafe string ThumbnailBase64 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='UploadImageTask']/method[@name='getThumbnailBase64' and count(parameter)=0]"
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

		static Delegate cb_getUploadImageTaskParams;
#pragma warning disable 0169
		static Delegate GetGetUploadImageTaskParamsHandler ()
		{
			if (cb_getUploadImageTaskParams == null)
				cb_getUploadImageTaskParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUploadImageTaskParams);
			return cb_getUploadImageTaskParams;
		}

		static IntPtr n_GetUploadImageTaskParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.UploadImageTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.UploadImageTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UploadImageTaskParams);
		}
#pragma warning restore 0169

		static IntPtr id_getUploadImageTaskParams;
		public virtual unsafe global::Com.Liveperson.Messaging.Background.Filesharing.Image.UploadImageTaskBundle UploadImageTaskParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='UploadImageTask']/method[@name='getUploadImageTaskParams' and count(parameter)=0]"
			[Register ("getUploadImageTaskParams", "()Lcom/liveperson/messaging/background/filesharing/image/UploadImageTaskBundle;", "GetGetUploadImageTaskParamsHandler")]
			get {
				if (id_getUploadImageTaskParams == IntPtr.Zero)
					id_getUploadImageTaskParams = JNIEnv.GetMethodID (class_ref, "getUploadImageTaskParams", "()Lcom/liveperson/messaging/background/filesharing/image/UploadImageTaskBundle;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Image.UploadImageTaskBundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUploadImageTaskParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Image.UploadImageTaskBundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUploadImageTaskParams", "()Lcom/liveperson/messaging/background/filesharing/image/UploadImageTaskBundle;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Liveperson.Messaging.Background.UploadImageTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.UploadImageTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UploadTaskBundle);
		}
#pragma warning restore 0169

		static IntPtr id_getUploadTaskBundle;
		protected override unsafe global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle UploadTaskBundle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='UploadImageTask']/method[@name='getUploadTaskBundle' and count(parameter)=0]"
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

		static Delegate cb_createOriginalImageByteArray_Landroid_graphics_Bitmap_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateOriginalImageByteArray_Landroid_graphics_Bitmap_Ljava_lang_String_Handler ()
		{
			if (cb_createOriginalImageByteArray_Landroid_graphics_Bitmap_Ljava_lang_String_ == null)
				cb_createOriginalImageByteArray_Landroid_graphics_Bitmap_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateOriginalImageByteArray_Landroid_graphics_Bitmap_Ljava_lang_String_);
			return cb_createOriginalImageByteArray_Landroid_graphics_Bitmap_Ljava_lang_String_;
		}

		static void n_CreateOriginalImageByteArray_Landroid_graphics_Bitmap_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Background.UploadImageTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.UploadImageTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CreateOriginalImageByteArray (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_createOriginalImageByteArray_Landroid_graphics_Bitmap_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='UploadImageTask']/method[@name='createOriginalImageByteArray' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='java.lang.String']]"
		[Register ("createOriginalImageByteArray", "(Landroid/graphics/Bitmap;Ljava/lang/String;)V", "GetCreateOriginalImageByteArray_Landroid_graphics_Bitmap_Ljava_lang_String_Handler")]
		protected virtual unsafe void CreateOriginalImageByteArray (global::Android.Graphics.Bitmap p0, string p1)
		{
			if (id_createOriginalImageByteArray_Landroid_graphics_Bitmap_Ljava_lang_String_ == IntPtr.Zero)
				id_createOriginalImageByteArray_Landroid_graphics_Bitmap_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createOriginalImageByteArray", "(Landroid/graphics/Bitmap;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createOriginalImageByteArray_Landroid_graphics_Bitmap_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createOriginalImageByteArray", "(Landroid/graphics/Bitmap;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Liveperson.Messaging.Background.UploadImageTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.UploadImageTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CreateSendMessageCommand (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_createSendMessageCommand_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='UploadImageTask']/method[@name='createSendMessageCommand' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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
			global::Com.Liveperson.Messaging.Background.UploadImageTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.UploadImageTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetFileByteArray ());
		}
#pragma warning restore 0169

		static IntPtr id_getFileByteArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='UploadImageTask']/method[@name='getFileByteArray' and count(parameter)=0]"
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

		static Delegate cb_processOriginalImage_IZ;
#pragma warning disable 0169
		static Delegate GetProcessOriginalImage_IZHandler ()
		{
			if (cb_processOriginalImage_IZ == null)
				cb_processOriginalImage_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, IntPtr>) n_ProcessOriginalImage_IZ);
			return cb_processOriginalImage_IZ;
		}

		static IntPtr n_ProcessOriginalImage_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Liveperson.Messaging.Background.UploadImageTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.UploadImageTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ProcessOriginalImage (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_processOriginalImage_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='UploadImageTask']/method[@name='processOriginalImage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("processOriginalImage", "(IZ)Landroid/graphics/Bitmap;", "GetProcessOriginalImage_IZHandler")]
		protected virtual unsafe global::Android.Graphics.Bitmap ProcessOriginalImage (int p0, bool p1)
		{
			if (id_processOriginalImage_IZ == IntPtr.Zero)
				id_processOriginalImage_IZ = JNIEnv.GetMethodID (class_ref, "processOriginalImage", "(IZ)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_processOriginalImage_IZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processOriginalImage", "(IZ)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_processThumbnailImage_IZ;
#pragma warning disable 0169
		static Delegate GetProcessThumbnailImage_IZHandler ()
		{
			if (cb_processThumbnailImage_IZ == null)
				cb_processThumbnailImage_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, IntPtr>) n_ProcessThumbnailImage_IZ);
			return cb_processThumbnailImage_IZ;
		}

		static IntPtr n_ProcessThumbnailImage_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Liveperson.Messaging.Background.UploadImageTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.UploadImageTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ProcessThumbnailImage (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_processThumbnailImage_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='UploadImageTask']/method[@name='processThumbnailImage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("processThumbnailImage", "(IZ)Landroid/graphics/Bitmap;", "GetProcessThumbnailImage_IZHandler")]
		protected virtual unsafe global::Android.Graphics.Bitmap ProcessThumbnailImage (int p0, bool p1)
		{
			if (id_processThumbnailImage_IZ == IntPtr.Zero)
				id_processThumbnailImage_IZ = JNIEnv.GetMethodID (class_ref, "processThumbnailImage", "(IZ)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_processThumbnailImage_IZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processThumbnailImage", "(IZ)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_saveOriginalImage_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSaveOriginalImage_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_saveOriginalImage_Landroid_graphics_Bitmap_ == null)
				cb_saveOriginalImage_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SaveOriginalImage_Landroid_graphics_Bitmap_);
			return cb_saveOriginalImage_Landroid_graphics_Bitmap_;
		}

		static IntPtr n_SaveOriginalImage_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Background.UploadImageTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.UploadImageTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SaveOriginalImage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_saveOriginalImage_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='UploadImageTask']/method[@name='saveOriginalImage' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("saveOriginalImage", "(Landroid/graphics/Bitmap;)Ljava/lang/String;", "GetSaveOriginalImage_Landroid_graphics_Bitmap_Handler")]
		protected virtual unsafe string SaveOriginalImage (global::Android.Graphics.Bitmap p0)
		{
			if (id_saveOriginalImage_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_saveOriginalImage_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "saveOriginalImage", "(Landroid/graphics/Bitmap;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_saveOriginalImage_Landroid_graphics_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveOriginalImage", "(Landroid/graphics/Bitmap;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_saveThumbnailImage_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSaveThumbnailImage_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_saveThumbnailImage_Landroid_graphics_Bitmap_ == null)
				cb_saveThumbnailImage_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SaveThumbnailImage_Landroid_graphics_Bitmap_);
			return cb_saveThumbnailImage_Landroid_graphics_Bitmap_;
		}

		static IntPtr n_SaveThumbnailImage_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Background.UploadImageTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.UploadImageTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SaveThumbnailImage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_saveThumbnailImage_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='UploadImageTask']/method[@name='saveThumbnailImage' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("saveThumbnailImage", "(Landroid/graphics/Bitmap;)Ljava/lang/String;", "GetSaveThumbnailImage_Landroid_graphics_Bitmap_Handler")]
		protected virtual unsafe string SaveThumbnailImage (global::Android.Graphics.Bitmap p0)
		{
			if (id_saveThumbnailImage_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_saveThumbnailImage_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "saveThumbnailImage", "(Landroid/graphics/Bitmap;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_saveThumbnailImage_Landroid_graphics_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveThumbnailImage", "(Landroid/graphics/Bitmap;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
