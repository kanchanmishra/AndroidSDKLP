using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FileMessage']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/model/FileMessage", DoNotGenerateAcw=true)]
	public partial class FileMessage : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FileMessage']/field[@name='EXTRA_FILE_ROW_ID']"
		[Register ("EXTRA_FILE_ROW_ID")]
		public const string ExtraFileRowId = (string) "EXTRA_FILE_ROW_ID";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FileMessage']/field[@name='EXTRA_FULL_IMAGE_EXISTS']"
		[Register ("EXTRA_FULL_IMAGE_EXISTS")]
		public const string ExtraFullImageExists = (string) "EXTRA_FULL_IMAGE_EXISTS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FileMessage']/field[@name='EXTRA_LOAD_STATUS']"
		[Register ("EXTRA_LOAD_STATUS")]
		public const string ExtraLoadStatus = (string) "EXTRA_LOAD_STATUS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FileMessage']/field[@name='EXTRA_LOCAL_URL']"
		[Register ("EXTRA_LOCAL_URL")]
		public const string ExtraLocalUrl = (string) "EXTRA_LOCAL_URL";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FileMessage']/field[@name='EXTRA_PREVIEW']"
		[Register ("EXTRA_PREVIEW")]
		public const string ExtraPreview = (string) "EXTRA_PREVIEW";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FileMessage']/field[@name='EXTRA_PREVIEW_IMAGE_EXISTS']"
		[Register ("EXTRA_PREVIEW_IMAGE_EXISTS")]
		public const string ExtraPreviewImageExists = (string) "EXTRA_PREVIEW_IMAGE_EXISTS";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/model/FileMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileMessage); }
		}

		protected FileMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FileMessage']/constructor[@name='FileMessage' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='long']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V", "")]
		public unsafe FileMessage (string p0, string p1, string p2, string p3, long p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				if (((object) this).GetType () != typeof (FileMessage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_getAllFileChanges;
#pragma warning disable 0169
		static Delegate GetGetAllFileChangesHandler ()
		{
			if (cb_getAllFileChanges == null)
				cb_getAllFileChanges = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllFileChanges);
			return cb_getAllFileChanges;
		}

		static IntPtr n_GetAllFileChanges (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.FileMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FileMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AllFileChanges);
		}
#pragma warning restore 0169

		static IntPtr id_getAllFileChanges;
		public virtual unsafe global::Android.OS.Bundle AllFileChanges {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FileMessage']/method[@name='getAllFileChanges' and count(parameter)=0]"
			[Register ("getAllFileChanges", "()Landroid/os/Bundle;", "GetGetAllFileChangesHandler")]
			get {
				if (id_getAllFileChanges == IntPtr.Zero)
					id_getAllFileChanges = JNIEnv.GetMethodID (class_ref, "getAllFileChanges", "()Landroid/os/Bundle;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllFileChanges), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllFileChanges", "()Landroid/os/Bundle;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFileRowId;
#pragma warning disable 0169
		static Delegate GetGetFileRowIdHandler ()
		{
			if (cb_getFileRowId == null)
				cb_getFileRowId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetFileRowId);
			return cb_getFileRowId;
		}

		static long n_GetFileRowId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.FileMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FileMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FileRowId;
		}
#pragma warning restore 0169

		static IntPtr id_getFileRowId;
		public virtual unsafe long FileRowId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FileMessage']/method[@name='getFileRowId' and count(parameter)=0]"
			[Register ("getFileRowId", "()J", "GetGetFileRowIdHandler")]
			get {
				if (id_getFileRowId == IntPtr.Zero)
					id_getFileRowId = JNIEnv.GetMethodID (class_ref, "getFileRowId", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getFileRowId);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileRowId", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getFileType;
#pragma warning disable 0169
		static Delegate GetGetFileTypeHandler ()
		{
			if (cb_getFileType == null)
				cb_getFileType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileType);
			return cb_getFileType;
		}

		static IntPtr n_GetFileType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.FileMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FileMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FileType);
		}
#pragma warning restore 0169

		static IntPtr id_getFileType;
		public virtual unsafe string FileType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FileMessage']/method[@name='getFileType' and count(parameter)=0]"
			[Register ("getFileType", "()Ljava/lang/String;", "GetGetFileTypeHandler")]
			get {
				if (id_getFileType == IntPtr.Zero)
					id_getFileType = JNIEnv.GetMethodID (class_ref, "getFileType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFileType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLoadStatus;
#pragma warning disable 0169
		static Delegate GetGetLoadStatusHandler ()
		{
			if (cb_getLoadStatus == null)
				cb_getLoadStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLoadStatus);
			return cb_getLoadStatus;
		}

		static IntPtr n_GetLoadStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.FileMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FileMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LoadStatus);
		}
#pragma warning restore 0169

		static IntPtr id_getLoadStatus;
		public virtual unsafe global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus LoadStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FileMessage']/method[@name='getLoadStatus' and count(parameter)=0]"
			[Register ("getLoadStatus", "()Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;", "GetGetLoadStatusHandler")]
			get {
				if (id_getLoadStatus == IntPtr.Zero)
					id_getLoadStatus = JNIEnv.GetMethodID (class_ref, "getLoadStatus", "()Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLoadStatus), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLoadStatus", "()Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLocalUrl;
#pragma warning disable 0169
		static Delegate GetGetLocalUrlHandler ()
		{
			if (cb_getLocalUrl == null)
				cb_getLocalUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocalUrl);
			return cb_getLocalUrl;
		}

		static IntPtr n_GetLocalUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.FileMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FileMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocalUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getLocalUrl;
		public virtual unsafe string LocalUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FileMessage']/method[@name='getLocalUrl' and count(parameter)=0]"
			[Register ("getLocalUrl", "()Ljava/lang/String;", "GetGetLocalUrlHandler")]
			get {
				if (id_getLocalUrl == IntPtr.Zero)
					id_getLocalUrl = JNIEnv.GetMethodID (class_ref, "getLocalUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocalUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocalUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPreview;
#pragma warning disable 0169
		static Delegate GetGetPreviewHandler ()
		{
			if (cb_getPreview == null)
				cb_getPreview = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPreview);
			return cb_getPreview;
		}

		static IntPtr n_GetPreview (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.FileMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FileMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Preview);
		}
#pragma warning restore 0169

		static IntPtr id_getPreview;
		public virtual unsafe string Preview {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FileMessage']/method[@name='getPreview' and count(parameter)=0]"
			[Register ("getPreview", "()Ljava/lang/String;", "GetGetPreviewHandler")]
			get {
				if (id_getPreview == IntPtr.Zero)
					id_getPreview = JNIEnv.GetMethodID (class_ref, "getPreview", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPreview), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreview", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRelatedMessageRowID;
#pragma warning disable 0169
		static Delegate GetGetRelatedMessageRowIDHandler ()
		{
			if (cb_getRelatedMessageRowID == null)
				cb_getRelatedMessageRowID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetRelatedMessageRowID);
			return cb_getRelatedMessageRowID;
		}

		static long n_GetRelatedMessageRowID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.FileMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FileMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RelatedMessageRowID;
		}
#pragma warning restore 0169

		static IntPtr id_getRelatedMessageRowID;
		public virtual unsafe long RelatedMessageRowID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FileMessage']/method[@name='getRelatedMessageRowID' and count(parameter)=0]"
			[Register ("getRelatedMessageRowID", "()J", "GetGetRelatedMessageRowIDHandler")]
			get {
				if (id_getRelatedMessageRowID == IntPtr.Zero)
					id_getRelatedMessageRowID = JNIEnv.GetMethodID (class_ref, "getRelatedMessageRowID", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getRelatedMessageRowID);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRelatedMessageRowID", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getSwiftPath;
#pragma warning disable 0169
		static Delegate GetGetSwiftPathHandler ()
		{
			if (cb_getSwiftPath == null)
				cb_getSwiftPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSwiftPath);
			return cb_getSwiftPath;
		}

		static IntPtr n_GetSwiftPath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.FileMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FileMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SwiftPath);
		}
#pragma warning restore 0169

		static IntPtr id_getSwiftPath;
		public virtual unsafe string SwiftPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FileMessage']/method[@name='getSwiftPath' and count(parameter)=0]"
			[Register ("getSwiftPath", "()Ljava/lang/String;", "GetGetSwiftPathHandler")]
			get {
				if (id_getSwiftPath == IntPtr.Zero)
					id_getSwiftPath = JNIEnv.GetMethodID (class_ref, "getSwiftPath", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSwiftPath), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSwiftPath", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_fromCursor_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FileMessage']/method[@name='fromCursor' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("fromCursor", "(Landroid/database/Cursor;)Lcom/liveperson/messaging/model/FileMessage;", "")]
		public static unsafe global::Com.Liveperson.Messaging.Model.FileMessage FromCursor (global::Android.Database.ICursor p0)
		{
			if (id_fromCursor_Landroid_database_Cursor_ == IntPtr.Zero)
				id_fromCursor_Landroid_database_Cursor_ = JNIEnv.GetStaticMethodID (class_ref, "fromCursor", "(Landroid/database/Cursor;)Lcom/liveperson/messaging/model/FileMessage;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Liveperson.Messaging.Model.FileMessage __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FileMessage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromCursor_Landroid_database_Cursor_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_update_Lcom_liveperson_messaging_model_FileMessage_;
#pragma warning disable 0169
		static Delegate GetUpdate_Lcom_liveperson_messaging_model_FileMessage_Handler ()
		{
			if (cb_update_Lcom_liveperson_messaging_model_FileMessage_ == null)
				cb_update_Lcom_liveperson_messaging_model_FileMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Update_Lcom_liveperson_messaging_model_FileMessage_);
			return cb_update_Lcom_liveperson_messaging_model_FileMessage_;
		}

		static IntPtr n_Update_Lcom_liveperson_messaging_model_FileMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.FileMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FileMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.FileMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FileMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Update (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_update_Lcom_liveperson_messaging_model_FileMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FileMessage']/method[@name='update' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.FileMessage']]"
		[Register ("update", "(Lcom/liveperson/messaging/model/FileMessage;)Landroid/os/Bundle;", "GetUpdate_Lcom_liveperson_messaging_model_FileMessage_Handler")]
		public virtual unsafe global::Android.OS.Bundle Update (global::Com.Liveperson.Messaging.Model.FileMessage p0)
		{
			if (id_update_Lcom_liveperson_messaging_model_FileMessage_ == IntPtr.Zero)
				id_update_Lcom_liveperson_messaging_model_FileMessage_ = JNIEnv.GetMethodID (class_ref, "update", "(Lcom/liveperson/messaging/model/FileMessage;)Landroid/os/Bundle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.OS.Bundle __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_update_Lcom_liveperson_messaging_model_FileMessage_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "update", "(Lcom/liveperson/messaging/model/FileMessage;)Landroid/os/Bundle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
