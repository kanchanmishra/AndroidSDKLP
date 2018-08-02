using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsFiles']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/model/AmsFiles", DoNotGenerateAcw=true)]
	public partial class AmsFiles : global::Com.Liveperson.Infra.Database.BaseDBRepository {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/model/AmsFiles", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsFiles); }
		}

		protected AmsFiles (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsFiles']/constructor[@name='AmsFiles' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AmsFiles ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AmsFiles)) {
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

		static Delegate cb_addFile_JLcom_liveperson_messaging_model_FileMessage_;
#pragma warning disable 0169
		static Delegate GetAddFile_JLcom_liveperson_messaging_model_FileMessage_Handler ()
		{
			if (cb_addFile_JLcom_liveperson_messaging_model_FileMessage_ == null)
				cb_addFile_JLcom_liveperson_messaging_model_FileMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_AddFile_JLcom_liveperson_messaging_model_FileMessage_);
			return cb_addFile_JLcom_liveperson_messaging_model_FileMessage_;
		}

		static IntPtr n_AddFile_JLcom_liveperson_messaging_model_FileMessage_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Model.AmsFiles __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsFiles> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.FileMessage p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FileMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddFile (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addFile_JLcom_liveperson_messaging_model_FileMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsFiles']/method[@name='addFile' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.liveperson.messaging.model.FileMessage']]"
		[Register ("addFile", "(JLcom/liveperson/messaging/model/FileMessage;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetAddFile_JLcom_liveperson_messaging_model_FileMessage_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand AddFile (long p0, global::Com.Liveperson.Messaging.Model.FileMessage p1)
		{
			if (id_addFile_JLcom_liveperson_messaging_model_FileMessage_ == IntPtr.Zero)
				id_addFile_JLcom_liveperson_messaging_model_FileMessage_ = JNIEnv.GetMethodID (class_ref, "addFile", "(JLcom/liveperson/messaging/model/FileMessage;)Lcom/liveperson/infra/database/DataBaseCommand;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addFile_JLcom_liveperson_messaging_model_FileMessage_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFile", "(JLcom/liveperson/messaging/model/FileMessage;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getFileByFileRowId_J;
#pragma warning disable 0169
		static Delegate GetGetFileByFileRowId_JHandler ()
		{
			if (cb_getFileByFileRowId_J == null)
				cb_getFileByFileRowId_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_GetFileByFileRowId_J);
			return cb_getFileByFileRowId_J;
		}

		static IntPtr n_GetFileByFileRowId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsFiles __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsFiles> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetFileByFileRowId (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getFileByFileRowId_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsFiles']/method[@name='getFileByFileRowId' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getFileByFileRowId", "(J)Lcom/liveperson/infra/database/DataBaseCommand;", "GetGetFileByFileRowId_JHandler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand GetFileByFileRowId (long p0)
		{
			if (id_getFileByFileRowId_J == IntPtr.Zero)
				id_getFileByFileRowId_J = JNIEnv.GetMethodID (class_ref, "getFileByFileRowId", "(J)Lcom/liveperson/infra/database/DataBaseCommand;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFileByFileRowId_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileByFileRowId", "(J)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getFileByFileRowIdOnDbThread_J;
#pragma warning disable 0169
		static Delegate GetGetFileByFileRowIdOnDbThread_JHandler ()
		{
			if (cb_getFileByFileRowIdOnDbThread_J == null)
				cb_getFileByFileRowIdOnDbThread_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_GetFileByFileRowIdOnDbThread_J);
			return cb_getFileByFileRowIdOnDbThread_J;
		}

		static IntPtr n_GetFileByFileRowIdOnDbThread_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsFiles __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsFiles> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetFileByFileRowIdOnDbThread (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getFileByFileRowIdOnDbThread_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsFiles']/method[@name='getFileByFileRowIdOnDbThread' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getFileByFileRowIdOnDbThread", "(J)Lcom/liveperson/messaging/model/FileMessage;", "GetGetFileByFileRowIdOnDbThread_JHandler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Model.FileMessage GetFileByFileRowIdOnDbThread (long p0)
		{
			if (id_getFileByFileRowIdOnDbThread_J == IntPtr.Zero)
				id_getFileByFileRowIdOnDbThread_J = JNIEnv.GetMethodID (class_ref, "getFileByFileRowIdOnDbThread", "(J)Lcom/liveperson/messaging/model/FileMessage;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FileMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFileByFileRowIdOnDbThread_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FileMessage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileByFileRowIdOnDbThread", "(J)Lcom/liveperson/messaging/model/FileMessage;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getFileByMessageRowId_J;
#pragma warning disable 0169
		static Delegate GetGetFileByMessageRowId_JHandler ()
		{
			if (cb_getFileByMessageRowId_J == null)
				cb_getFileByMessageRowId_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_GetFileByMessageRowId_J);
			return cb_getFileByMessageRowId_J;
		}

		static IntPtr n_GetFileByMessageRowId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsFiles __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsFiles> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetFileByMessageRowId (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getFileByMessageRowId_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsFiles']/method[@name='getFileByMessageRowId' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getFileByMessageRowId", "(J)Lcom/liveperson/messaging/model/FileMessage;", "GetGetFileByMessageRowId_JHandler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Model.FileMessage GetFileByMessageRowId (long p0)
		{
			if (id_getFileByMessageRowId_J == IntPtr.Zero)
				id_getFileByMessageRowId_J = JNIEnv.GetMethodID (class_ref, "getFileByMessageRowId", "(J)Lcom/liveperson/messaging/model/FileMessage;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FileMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFileByMessageRowId_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FileMessage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileByMessageRowId", "(J)Lcom/liveperson/messaging/model/FileMessage;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getMultipleOldestLocalPathFromDB_Ljava_lang_String_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMultipleOldestLocalPathFromDB_Ljava_lang_String_ILjava_lang_String_Handler ()
		{
			if (cb_getMultipleOldestLocalPathFromDB_Ljava_lang_String_ILjava_lang_String_ == null)
				cb_getMultipleOldestLocalPathFromDB_Ljava_lang_String_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_GetMultipleOldestLocalPathFromDB_Ljava_lang_String_ILjava_lang_String_);
			return cb_getMultipleOldestLocalPathFromDB_Ljava_lang_String_ILjava_lang_String_;
		}

		static IntPtr n_GetMultipleOldestLocalPathFromDB_Ljava_lang_String_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.Model.AmsFiles __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsFiles> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMultipleOldestLocalPathFromDB (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMultipleOldestLocalPathFromDB_Ljava_lang_String_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsFiles']/method[@name='getMultipleOldestLocalPathFromDB' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("getMultipleOldestLocalPathFromDB", "(Ljava/lang/String;ILjava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetGetMultipleOldestLocalPathFromDB_Ljava_lang_String_ILjava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand GetMultipleOldestLocalPathFromDB (string p0, int p1, string p2)
		{
			if (id_getMultipleOldestLocalPathFromDB_Ljava_lang_String_ILjava_lang_String_ == IntPtr.Zero)
				id_getMultipleOldestLocalPathFromDB_Ljava_lang_String_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMultipleOldestLocalPathFromDB", "(Ljava/lang/String;ILjava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMultipleOldestLocalPathFromDB_Ljava_lang_String_ILjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMultipleOldestLocalPathFromDB", "(Ljava/lang/String;ILjava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getNumOfLocalPathFromDB_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetNumOfLocalPathFromDB_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getNumOfLocalPathFromDB_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getNumOfLocalPathFromDB_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetNumOfLocalPathFromDB_Ljava_lang_String_Ljava_lang_String_);
			return cb_getNumOfLocalPathFromDB_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetNumOfLocalPathFromDB_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Model.AmsFiles __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsFiles> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetNumOfLocalPathFromDB (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getNumOfLocalPathFromDB_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsFiles']/method[@name='getNumOfLocalPathFromDB' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getNumOfLocalPathFromDB", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetGetNumOfLocalPathFromDB_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand GetNumOfLocalPathFromDB (string p0, string p1)
		{
			if (id_getNumOfLocalPathFromDB_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getNumOfLocalPathFromDB_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getNumOfLocalPathFromDB", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNumOfLocalPathFromDB_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumOfLocalPathFromDB", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_removeLocalPathFromDB_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveLocalPathFromDB_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_removeLocalPathFromDB_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_removeLocalPathFromDB_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveLocalPathFromDB_Ljava_lang_String_Ljava_lang_String_);
			return cb_removeLocalPathFromDB_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_RemoveLocalPathFromDB_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Model.AmsFiles __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsFiles> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveLocalPathFromDB (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeLocalPathFromDB_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsFiles']/method[@name='removeLocalPathFromDB' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeLocalPathFromDB", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetRemoveLocalPathFromDB_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand RemoveLocalPathFromDB (string p0, string p1)
		{
			if (id_removeLocalPathFromDB_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_removeLocalPathFromDB_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeLocalPathFromDB", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeLocalPathFromDB_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeLocalPathFromDB", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateLocalPath_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateLocalPath_JLjava_lang_String_Handler ()
		{
			if (cb_updateLocalPath_JLjava_lang_String_ == null)
				cb_updateLocalPath_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_UpdateLocalPath_JLjava_lang_String_);
			return cb_updateLocalPath_JLjava_lang_String_;
		}

		static IntPtr n_UpdateLocalPath_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Model.AmsFiles __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsFiles> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UpdateLocalPath (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateLocalPath_JLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsFiles']/method[@name='updateLocalPath' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateLocalPath", "(JLjava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetUpdateLocalPath_JLjava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand UpdateLocalPath (long p0, string p1)
		{
			if (id_updateLocalPath_JLjava_lang_String_ == IntPtr.Zero)
				id_updateLocalPath_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateLocalPath", "(JLjava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_updateLocalPath_JLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateLocalPath", "(JLjava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateRelativePath_Ljava_lang_Long_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateRelativePath_Ljava_lang_Long_Ljava_lang_String_Handler ()
		{
			if (cb_updateRelativePath_Ljava_lang_Long_Ljava_lang_String_ == null)
				cb_updateRelativePath_Ljava_lang_Long_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateRelativePath_Ljava_lang_Long_Ljava_lang_String_);
			return cb_updateRelativePath_Ljava_lang_Long_Ljava_lang_String_;
		}

		static void n_UpdateRelativePath_Ljava_lang_Long_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Model.AmsFiles __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsFiles> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateRelativePath (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateRelativePath_Ljava_lang_Long_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsFiles']/method[@name='updateRelativePath' and count(parameter)=2 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateRelativePath", "(Ljava/lang/Long;Ljava/lang/String;)V", "GetUpdateRelativePath_Ljava_lang_Long_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateRelativePath (global::Java.Lang.Long p0, string p1)
		{
			if (id_updateRelativePath_Ljava_lang_Long_Ljava_lang_String_ == IntPtr.Zero)
				id_updateRelativePath_Ljava_lang_Long_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateRelativePath", "(Ljava/lang/Long;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateRelativePath_Ljava_lang_Long_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateRelativePath", "(Ljava/lang/Long;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateStatus_JLcom_liveperson_infra_database_tables_FilesTable_LoadStatus_;
#pragma warning disable 0169
		static Delegate GetUpdateStatus_JLcom_liveperson_infra_database_tables_FilesTable_LoadStatus_Handler ()
		{
			if (cb_updateStatus_JLcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ == null)
				cb_updateStatus_JLcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_UpdateStatus_JLcom_liveperson_infra_database_tables_FilesTable_LoadStatus_);
			return cb_updateStatus_JLcom_liveperson_infra_database_tables_FilesTable_LoadStatus_;
		}

		static void n_UpdateStatus_JLcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Model.AmsFiles __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsFiles> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateStatus (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateStatus_JLcom_liveperson_infra_database_tables_FilesTable_LoadStatus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsFiles']/method[@name='updateStatus' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.liveperson.infra.database.tables.FilesTable.LoadStatus']]"
		[Register ("updateStatus", "(JLcom/liveperson/infra/database/tables/FilesTable$LoadStatus;)V", "GetUpdateStatus_JLcom_liveperson_infra_database_tables_FilesTable_LoadStatus_Handler")]
		public virtual unsafe void UpdateStatus (long p0, global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus p1)
		{
			if (id_updateStatus_JLcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ == IntPtr.Zero)
				id_updateStatus_JLcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ = JNIEnv.GetMethodID (class_ref, "updateStatus", "(JLcom/liveperson/infra/database/tables/FilesTable$LoadStatus;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateStatus_JLcom_liveperson_infra_database_tables_FilesTable_LoadStatus_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateStatus", "(JLcom/liveperson/infra/database/tables/FilesTable$LoadStatus;)V"), __args);
			} finally {
			}
		}

	}
}
