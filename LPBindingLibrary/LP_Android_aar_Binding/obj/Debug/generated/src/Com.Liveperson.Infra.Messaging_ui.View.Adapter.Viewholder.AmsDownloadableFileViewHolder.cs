using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsDownloadableFileViewHolder']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsDownloadableFileViewHolder", DoNotGenerateAcw=true)]
	public abstract partial class AmsDownloadableFileViewHolder : global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerViewHolder {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsDownloadableFileViewHolder']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "AmsDownloadableFileViewHolder";

		static IntPtr mFileRowId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsDownloadableFileViewHolder']/field[@name='mFileRowId']"
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

		static IntPtr mFileStatusView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsDownloadableFileViewHolder']/field[@name='mFileStatusView']"
		[Register ("mFileStatusView")]
		protected global::Android.Widget.ImageView MFileStatusView {
			get {
				if (mFileStatusView_jfieldId == IntPtr.Zero)
					mFileStatusView_jfieldId = JNIEnv.GetFieldID (class_ref, "mFileStatusView", "Landroid/widget/ImageView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mFileStatusView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mFileStatusView_jfieldId == IntPtr.Zero)
					mFileStatusView_jfieldId = JNIEnv.GetFieldID (class_ref, "mFileStatusView", "Landroid/widget/ImageView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFileStatusView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mFullFile_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsDownloadableFileViewHolder']/field[@name='mFullFile']"
		[Register ("mFullFile")]
		protected string MFullFile {
			get {
				if (mFullFile_jfieldId == IntPtr.Zero)
					mFullFile_jfieldId = JNIEnv.GetFieldID (class_ref, "mFullFile", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mFullFile_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mFullFile_jfieldId == IntPtr.Zero)
					mFullFile_jfieldId = JNIEnv.GetFieldID (class_ref, "mFullFile", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFullFile_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mPreviewImage_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsDownloadableFileViewHolder']/field[@name='mPreviewImage']"
		[Register ("mPreviewImage")]
		protected string MPreviewImage {
			get {
				if (mPreviewImage_jfieldId == IntPtr.Zero)
					mPreviewImage_jfieldId = JNIEnv.GetFieldID (class_ref, "mPreviewImage", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mPreviewImage_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPreviewImage_jfieldId == IntPtr.Zero)
					mPreviewImage_jfieldId = JNIEnv.GetFieldID (class_ref, "mPreviewImage", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mPreviewImage_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsDownloadableFileViewHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsDownloadableFileViewHolder); }
		}

		protected AmsDownloadableFileViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsDownloadableFileViewHolder']/constructor[@name='AmsDownloadableFileViewHolder' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageType']]"
		[Register (".ctor", "(Landroid/view/View;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)V", "")]
		public unsafe AmsDownloadableFileViewHolder (global::Android.Views.View p0, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (AmsDownloadableFileViewHolder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/view/View;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/view/View;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)V", __args);
					return;
				}

				if (id_ctor_Landroid_view_View_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ == IntPtr.Zero)
					id_ctor_Landroid_view_View_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_view_View_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_, __args);
			} finally {
			}
		}

		static Delegate cb_getFailedDownloadDrawableResourceId;
#pragma warning disable 0169
		static Delegate GetGetFailedDownloadDrawableResourceIdHandler ()
		{
			if (cb_getFailedDownloadDrawableResourceId == null)
				cb_getFailedDownloadDrawableResourceId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFailedDownloadDrawableResourceId);
			return cb_getFailedDownloadDrawableResourceId;
		}

		static int n_GetFailedDownloadDrawableResourceId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsDownloadableFileViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsDownloadableFileViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FailedDownloadDrawableResourceId;
		}
#pragma warning restore 0169

		static IntPtr id_getFailedDownloadDrawableResourceId;
		protected virtual unsafe int FailedDownloadDrawableResourceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsDownloadableFileViewHolder']/method[@name='getFailedDownloadDrawableResourceId' and count(parameter)=0]"
			[Register ("getFailedDownloadDrawableResourceId", "()I", "GetGetFailedDownloadDrawableResourceIdHandler")]
			get {
				if (id_getFailedDownloadDrawableResourceId == IntPtr.Zero)
					id_getFailedDownloadDrawableResourceId = JNIEnv.GetMethodID (class_ref, "getFailedDownloadDrawableResourceId", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFailedDownloadDrawableResourceId);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFailedDownloadDrawableResourceId", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_additionalFailAction;
#pragma warning disable 0169
		static Delegate GetAdditionalFailActionHandler ()
		{
			if (cb_additionalFailAction == null)
				cb_additionalFailAction = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AdditionalFailAction);
			return cb_additionalFailAction;
		}

		static void n_AdditionalFailAction (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsDownloadableFileViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsDownloadableFileViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AdditionalFailAction ();
		}
#pragma warning restore 0169

		static IntPtr id_additionalFailAction;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsDownloadableFileViewHolder']/method[@name='additionalFailAction' and count(parameter)=0]"
		[Register ("additionalFailAction", "()V", "GetAdditionalFailActionHandler")]
		protected virtual unsafe void AdditionalFailAction ()
		{
			if (id_additionalFailAction == IntPtr.Zero)
				id_additionalFailAction = JNIEnv.GetMethodID (class_ref, "additionalFailAction", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_additionalFailAction);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "additionalFailAction", "()V"));
			} finally {
			}
		}

		static Delegate cb_applyLoadStatusForDownloadFlow_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_;
#pragma warning disable 0169
		static Delegate GetApplyLoadStatusForDownloadFlow_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_Handler ()
		{
			if (cb_applyLoadStatusForDownloadFlow_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ == null)
				cb_applyLoadStatusForDownloadFlow_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ApplyLoadStatusForDownloadFlow_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_);
			return cb_applyLoadStatusForDownloadFlow_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_;
		}

		static void n_ApplyLoadStatusForDownloadFlow_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsDownloadableFileViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsDownloadableFileViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ApplyLoadStatusForDownloadFlow (p0);
		}
#pragma warning restore 0169

		static IntPtr id_applyLoadStatusForDownloadFlow_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsDownloadableFileViewHolder']/method[@name='applyLoadStatusForDownloadFlow' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.database.tables.FilesTable.LoadStatus']]"
		[Register ("applyLoadStatusForDownloadFlow", "(Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;)V", "GetApplyLoadStatusForDownloadFlow_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_Handler")]
		protected virtual unsafe void ApplyLoadStatusForDownloadFlow (global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus p0)
		{
			if (id_applyLoadStatusForDownloadFlow_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ == IntPtr.Zero)
				id_applyLoadStatusForDownloadFlow_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ = JNIEnv.GetMethodID (class_ref, "applyLoadStatusForDownloadFlow", "(Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_applyLoadStatusForDownloadFlow_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "applyLoadStatusForDownloadFlow", "(Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_applyLoadStatusForUploadFlow_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_;
#pragma warning disable 0169
		static Delegate GetApplyLoadStatusForUploadFlow_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_Handler ()
		{
			if (cb_applyLoadStatusForUploadFlow_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ == null)
				cb_applyLoadStatusForUploadFlow_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ApplyLoadStatusForUploadFlow_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_);
			return cb_applyLoadStatusForUploadFlow_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_;
		}

		static void n_ApplyLoadStatusForUploadFlow_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsDownloadableFileViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsDownloadableFileViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ApplyLoadStatusForUploadFlow (p0);
		}
#pragma warning restore 0169

		static IntPtr id_applyLoadStatusForUploadFlow_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsDownloadableFileViewHolder']/method[@name='applyLoadStatusForUploadFlow' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.database.tables.FilesTable.LoadStatus']]"
		[Register ("applyLoadStatusForUploadFlow", "(Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;)V", "GetApplyLoadStatusForUploadFlow_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_Handler")]
		protected virtual unsafe void ApplyLoadStatusForUploadFlow (global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus p0)
		{
			if (id_applyLoadStatusForUploadFlow_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ == IntPtr.Zero)
				id_applyLoadStatusForUploadFlow_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ = JNIEnv.GetMethodID (class_ref, "applyLoadStatusForUploadFlow", "(Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_applyLoadStatusForUploadFlow_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "applyLoadStatusForUploadFlow", "(Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onCompletedAction;
#pragma warning disable 0169
		static Delegate GetOnCompletedActionHandler ()
		{
			if (cb_onCompletedAction == null)
				cb_onCompletedAction = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCompletedAction);
			return cb_onCompletedAction;
		}

		static void n_OnCompletedAction (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsDownloadableFileViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsDownloadableFileViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCompletedAction ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsDownloadableFileViewHolder']/method[@name='onCompletedAction' and count(parameter)=0]"
		[Register ("onCompletedAction", "()V", "GetOnCompletedActionHandler")]
		protected abstract void OnCompletedAction ();

		static Delegate cb_onNotStartedAction;
#pragma warning disable 0169
		static Delegate GetOnNotStartedActionHandler ()
		{
			if (cb_onNotStartedAction == null)
				cb_onNotStartedAction = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnNotStartedAction);
			return cb_onNotStartedAction;
		}

		static void n_OnNotStartedAction (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsDownloadableFileViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsDownloadableFileViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNotStartedAction ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsDownloadableFileViewHolder']/method[@name='onNotStartedAction' and count(parameter)=0]"
		[Register ("onNotStartedAction", "()V", "GetOnNotStartedActionHandler")]
		protected abstract void OnNotStartedAction ();

		static Delegate cb_onRequestingUrlAction;
#pragma warning disable 0169
		static Delegate GetOnRequestingUrlActionHandler ()
		{
			if (cb_onRequestingUrlAction == null)
				cb_onRequestingUrlAction = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRequestingUrlAction);
			return cb_onRequestingUrlAction;
		}

		static void n_OnRequestingUrlAction (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsDownloadableFileViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsDownloadableFileViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRequestingUrlAction ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsDownloadableFileViewHolder']/method[@name='onRequestingUrlAction' and count(parameter)=0]"
		[Register ("onRequestingUrlAction", "()V", "GetOnRequestingUrlActionHandler")]
		protected abstract void OnRequestingUrlAction ();

		static Delegate cb_setFileRowId_J;
#pragma warning disable 0169
		static Delegate GetSetFileRowId_JHandler ()
		{
			if (cb_setFileRowId_J == null)
				cb_setFileRowId_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetFileRowId_J);
			return cb_setFileRowId_J;
		}

		static void n_SetFileRowId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsDownloadableFileViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsDownloadableFileViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFileRowId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFileRowId_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsDownloadableFileViewHolder']/method[@name='setFileRowId' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setFileRowId", "(J)V", "GetSetFileRowId_JHandler")]
		public virtual unsafe void SetFileRowId (long p0)
		{
			if (id_setFileRowId_J == IntPtr.Zero)
				id_setFileRowId_J = JNIEnv.GetMethodID (class_ref, "setFileRowId", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFileRowId_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFileRowId", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startFailedAnimation;
#pragma warning disable 0169
		static Delegate GetStartFailedAnimationHandler ()
		{
			if (cb_startFailedAnimation == null)
				cb_startFailedAnimation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartFailedAnimation);
			return cb_startFailedAnimation;
		}

		static void n_StartFailedAnimation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsDownloadableFileViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsDownloadableFileViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartFailedAnimation ();
		}
#pragma warning restore 0169

		static IntPtr id_startFailedAnimation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsDownloadableFileViewHolder']/method[@name='startFailedAnimation' and count(parameter)=0]"
		[Register ("startFailedAnimation", "()V", "GetStartFailedAnimationHandler")]
		public virtual unsafe void StartFailedAnimation ()
		{
			if (id_startFailedAnimation == IntPtr.Zero)
				id_startFailedAnimation = JNIEnv.GetMethodID (class_ref, "startFailedAnimation", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startFailedAnimation);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startFailedAnimation", "()V"));
			} finally {
			}
		}

		static Delegate cb_startProgressBar;
#pragma warning disable 0169
		static Delegate GetStartProgressBarHandler ()
		{
			if (cb_startProgressBar == null)
				cb_startProgressBar = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartProgressBar);
			return cb_startProgressBar;
		}

		static void n_StartProgressBar (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsDownloadableFileViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsDownloadableFileViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartProgressBar ();
		}
#pragma warning restore 0169

		static IntPtr id_startProgressBar;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsDownloadableFileViewHolder']/method[@name='startProgressBar' and count(parameter)=0]"
		[Register ("startProgressBar", "()V", "GetStartProgressBarHandler")]
		protected virtual unsafe void StartProgressBar ()
		{
			if (id_startProgressBar == IntPtr.Zero)
				id_startProgressBar = JNIEnv.GetMethodID (class_ref, "startProgressBar", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startProgressBar);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startProgressBar", "()V"));
			} finally {
			}
		}

		static Delegate cb_stopAnimation;
#pragma warning disable 0169
		static Delegate GetStopAnimationHandler ()
		{
			if (cb_stopAnimation == null)
				cb_stopAnimation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopAnimation);
			return cb_stopAnimation;
		}

		static void n_StopAnimation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsDownloadableFileViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsDownloadableFileViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopAnimation ();
		}
#pragma warning restore 0169

		static IntPtr id_stopAnimation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsDownloadableFileViewHolder']/method[@name='stopAnimation' and count(parameter)=0]"
		[Register ("stopAnimation", "()V", "GetStopAnimationHandler")]
		protected virtual unsafe void StopAnimation ()
		{
			if (id_stopAnimation == IntPtr.Zero)
				id_stopAnimation = JNIEnv.GetMethodID (class_ref, "stopAnimation", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopAnimation);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopAnimation", "()V"));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsDownloadableFileViewHolder", DoNotGenerateAcw=true)]
	internal partial class AmsDownloadableFileViewHolderInvoker : AmsDownloadableFileViewHolder {

		public AmsDownloadableFileViewHolderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsDownloadableFileViewHolderInvoker); }
		}

		static IntPtr id_onCompletedAction;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsDownloadableFileViewHolder']/method[@name='onCompletedAction' and count(parameter)=0]"
		[Register ("onCompletedAction", "()V", "GetOnCompletedActionHandler")]
		protected override unsafe void OnCompletedAction ()
		{
			if (id_onCompletedAction == IntPtr.Zero)
				id_onCompletedAction = JNIEnv.GetMethodID (class_ref, "onCompletedAction", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCompletedAction);
			} finally {
			}
		}

		static IntPtr id_onNotStartedAction;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsDownloadableFileViewHolder']/method[@name='onNotStartedAction' and count(parameter)=0]"
		[Register ("onNotStartedAction", "()V", "GetOnNotStartedActionHandler")]
		protected override unsafe void OnNotStartedAction ()
		{
			if (id_onNotStartedAction == IntPtr.Zero)
				id_onNotStartedAction = JNIEnv.GetMethodID (class_ref, "onNotStartedAction", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNotStartedAction);
			} finally {
			}
		}

		static IntPtr id_onRequestingUrlAction;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsDownloadableFileViewHolder']/method[@name='onRequestingUrlAction' and count(parameter)=0]"
		[Register ("onRequestingUrlAction", "()V", "GetOnRequestingUrlActionHandler")]
		protected override unsafe void OnRequestingUrlAction ()
		{
			if (id_onRequestingUrlAction == IntPtr.Zero)
				id_onRequestingUrlAction = JNIEnv.GetMethodID (class_ref, "onRequestingUrlAction", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRequestingUrlAction);
			} finally {
			}
		}

	}

}
