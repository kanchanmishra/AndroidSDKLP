using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Background {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='DownloadFileTask']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/background/DownloadFileTask", DoNotGenerateAcw=true)]
	public abstract partial class DownloadFileTask : global::Java.Lang.Object {


		static IntPtr mDownloadFileTaskParams_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='DownloadFileTask']/field[@name='mDownloadFileTaskParams']"
		[Register ("mDownloadFileTaskParams")]
		protected global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle MDownloadFileTaskParams {
			get {
				if (mDownloadFileTaskParams_jfieldId == IntPtr.Zero)
					mDownloadFileTaskParams_jfieldId = JNIEnv.GetFieldID (class_ref, "mDownloadFileTaskParams", "Lcom/liveperson/messaging/background/filesharing/DownloadFileTaskBundle;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mDownloadFileTaskParams_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDownloadFileTaskParams_jfieldId == IntPtr.Zero)
					mDownloadFileTaskParams_jfieldId = JNIEnv.GetFieldID (class_ref, "mDownloadFileTaskParams", "Lcom/liveperson/messaging/background/filesharing/DownloadFileTaskBundle;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mDownloadFileTaskParams_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/background/DownloadFileTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DownloadFileTask); }
		}

		protected DownloadFileTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_background_filesharing_DownloadFileTaskBundle_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='DownloadFileTask']/constructor[@name='DownloadFileTask' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.background.filesharing.DownloadFileTaskBundle']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/background/filesharing/DownloadFileTaskBundle;)V", "")]
		public unsafe DownloadFileTask (global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (DownloadFileTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/background/filesharing/DownloadFileTaskBundle;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/background/filesharing/DownloadFileTaskBundle;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_background_filesharing_DownloadFileTaskBundle_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_background_filesharing_DownloadFileTaskBundle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/background/filesharing/DownloadFileTaskBundle;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_background_filesharing_DownloadFileTaskBundle_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_background_filesharing_DownloadFileTaskBundle_, __args);
			} finally {
			}
		}

		static Delegate cb_isDownloadCompleted;
#pragma warning disable 0169
		static Delegate GetIsDownloadCompletedHandler ()
		{
			if (cb_isDownloadCompleted == null)
				cb_isDownloadCompleted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDownloadCompleted);
			return cb_isDownloadCompleted;
		}

		static bool n_IsDownloadCompleted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.DownloadFileTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.DownloadFileTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDownloadCompleted;
		}
#pragma warning restore 0169

		static IntPtr id_isDownloadCompleted;
		public virtual unsafe bool IsDownloadCompleted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='DownloadFileTask']/method[@name='isDownloadCompleted' and count(parameter)=0]"
			[Register ("isDownloadCompleted", "()Z", "GetIsDownloadCompletedHandler")]
			get {
				if (id_isDownloadCompleted == IntPtr.Zero)
					id_isDownloadCompleted = JNIEnv.GetMethodID (class_ref, "isDownloadCompleted", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDownloadCompleted);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDownloadCompleted", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isDownloadFailed;
#pragma warning disable 0169
		static Delegate GetIsDownloadFailedHandler ()
		{
			if (cb_isDownloadFailed == null)
				cb_isDownloadFailed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDownloadFailed);
			return cb_isDownloadFailed;
		}

		static bool n_IsDownloadFailed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.DownloadFileTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.DownloadFileTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDownloadFailed;
		}
#pragma warning restore 0169

		static IntPtr id_isDownloadFailed;
		public virtual unsafe bool IsDownloadFailed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='DownloadFileTask']/method[@name='isDownloadFailed' and count(parameter)=0]"
			[Register ("isDownloadFailed", "()Z", "GetIsDownloadFailedHandler")]
			get {
				if (id_isDownloadFailed == IntPtr.Zero)
					id_isDownloadFailed = JNIEnv.GetMethodID (class_ref, "isDownloadFailed", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDownloadFailed);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDownloadFailed", "()Z"));
				} finally {
				}
			}
		}

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
			global::Com.Liveperson.Messaging.Background.DownloadFileTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.DownloadFileTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionAvailable ();
		}
#pragma warning restore 0169

		static IntPtr id_onConnectionAvailable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='DownloadFileTask']/method[@name='onConnectionAvailable' and count(parameter)=0]"
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
			global::Com.Liveperson.Messaging.Background.DownloadFileTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.DownloadFileTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionUnavailable ();
		}
#pragma warning restore 0169

		static IntPtr id_onConnectionUnavailable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='DownloadFileTask']/method[@name='onConnectionUnavailable' and count(parameter)=0]"
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

		static Delegate cb_saveFileToDisk_arrayB;
#pragma warning disable 0169
		static Delegate GetSaveFileToDisk_arrayBHandler ()
		{
			if (cb_saveFileToDisk_arrayB == null)
				cb_saveFileToDisk_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SaveFileToDisk_arrayB);
			return cb_saveFileToDisk_arrayB;
		}

		static IntPtr n_SaveFileToDisk_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Background.DownloadFileTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.DownloadFileTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewString (__this.SaveFileToDisk (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='DownloadFileTask']/method[@name='saveFileToDisk' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("saveFileToDisk", "([B)Ljava/lang/String;", "GetSaveFileToDisk_arrayBHandler")]
		protected abstract string SaveFileToDisk (byte[] p0);

		static Delegate cb_setCallBack_Lcom_liveperson_messaging_background_DownloadFileTaskCallback_;
#pragma warning disable 0169
		static Delegate GetSetCallBack_Lcom_liveperson_messaging_background_DownloadFileTaskCallback_Handler ()
		{
			if (cb_setCallBack_Lcom_liveperson_messaging_background_DownloadFileTaskCallback_ == null)
				cb_setCallBack_Lcom_liveperson_messaging_background_DownloadFileTaskCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallBack_Lcom_liveperson_messaging_background_DownloadFileTaskCallback_);
			return cb_setCallBack_Lcom_liveperson_messaging_background_DownloadFileTaskCallback_;
		}

		static void n_SetCallBack_Lcom_liveperson_messaging_background_DownloadFileTaskCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Background.DownloadFileTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.DownloadFileTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Background.IDownloadFileTaskCallback p0 = (global::Com.Liveperson.Messaging.Background.IDownloadFileTaskCallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.IDownloadFileTaskCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCallBack (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCallBack_Lcom_liveperson_messaging_background_DownloadFileTaskCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='DownloadFileTask']/method[@name='setCallBack' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.background.DownloadFileTaskCallback']]"
		[Register ("setCallBack", "(Lcom/liveperson/messaging/background/DownloadFileTaskCallback;)V", "GetSetCallBack_Lcom_liveperson_messaging_background_DownloadFileTaskCallback_Handler")]
		public virtual unsafe void SetCallBack (global::Com.Liveperson.Messaging.Background.IDownloadFileTaskCallback p0)
		{
			if (id_setCallBack_Lcom_liveperson_messaging_background_DownloadFileTaskCallback_ == IntPtr.Zero)
				id_setCallBack_Lcom_liveperson_messaging_background_DownloadFileTaskCallback_ = JNIEnv.GetMethodID (class_ref, "setCallBack", "(Lcom/liveperson/messaging/background/DownloadFileTaskCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCallBack_Lcom_liveperson_messaging_background_DownloadFileTaskCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallBack", "(Lcom/liveperson/messaging/background/DownloadFileTaskCallback;)V"), __args);
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
			global::Com.Liveperson.Messaging.Background.DownloadFileTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.DownloadFileTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetStatus (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStatus_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='DownloadFileTask']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.database.tables.FilesTable.LoadStatus']]"
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

		static Delegate cb_startDownload;
#pragma warning disable 0169
		static Delegate GetStartDownloadHandler ()
		{
			if (cb_startDownload == null)
				cb_startDownload = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartDownload);
			return cb_startDownload;
		}

		static void n_StartDownload (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.DownloadFileTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.DownloadFileTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartDownload ();
		}
#pragma warning restore 0169

		static IntPtr id_startDownload;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='DownloadFileTask']/method[@name='startDownload' and count(parameter)=0]"
		[Register ("startDownload", "()V", "GetStartDownloadHandler")]
		public virtual unsafe void StartDownload ()
		{
			if (id_startDownload == IntPtr.Zero)
				id_startDownload = JNIEnv.GetMethodID (class_ref, "startDownload", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startDownload);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startDownload", "()V"));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/messaging/background/DownloadFileTask", DoNotGenerateAcw=true)]
	internal partial class DownloadFileTaskInvoker : DownloadFileTask {

		public DownloadFileTaskInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (DownloadFileTaskInvoker); }
		}

		static IntPtr id_saveFileToDisk_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='DownloadFileTask']/method[@name='saveFileToDisk' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("saveFileToDisk", "([B)Ljava/lang/String;", "GetSaveFileToDisk_arrayBHandler")]
		protected override unsafe string SaveFileToDisk (byte[] p0)
		{
			if (id_saveFileToDisk_arrayB == IntPtr.Zero)
				id_saveFileToDisk_arrayB = JNIEnv.GetMethodID (class_ref, "saveFileToDisk", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_saveFileToDisk_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}

}
