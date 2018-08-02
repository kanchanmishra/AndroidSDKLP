using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/Messaging", DoNotGenerateAcw=true)]
	public partial class Messaging : global::Java.Lang.Object, global::Com.Liveperson.Infra.IClearable, global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownAsync, global::Com.Liveperson.Messaging.IMessaging {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/field[@name='FORM_TITLE']"
		[Register ("FORM_TITLE")]
		public const string FormTitle = (string) "formTitle";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/field[@name='INVITATION_ID']"
		[Register ("INVITATION_ID")]
		public const string InvitationId = (string) "invitationId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/field[@name='NO_FILE_ROW_ID']"
		[Register ("NO_FILE_ROW_ID")]
		public const int NoFileRowId = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/field[@name='SUBMISSION_ID']"
		[Register ("SUBMISSION_ID")]
		public const string SubmissionId = (string) "submissionId";

		static IntPtr amsConversations_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/field[@name='amsConversations']"
		[Register ("amsConversations")]
		public global::Com.Liveperson.Messaging.Model.AmsConversations AmsConversations {
			get {
				if (amsConversations_jfieldId == IntPtr.Zero)
					amsConversations_jfieldId = JNIEnv.GetFieldID (class_ref, "amsConversations", "Lcom/liveperson/messaging/model/AmsConversations;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, amsConversations_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsConversations> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (amsConversations_jfieldId == IntPtr.Zero)
					amsConversations_jfieldId = JNIEnv.GetFieldID (class_ref, "amsConversations", "Lcom/liveperson/messaging/model/AmsConversations;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, amsConversations_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr amsFiles_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/field[@name='amsFiles']"
		[Register ("amsFiles")]
		public global::Com.Liveperson.Messaging.Model.AmsFiles AmsFiles {
			get {
				if (amsFiles_jfieldId == IntPtr.Zero)
					amsFiles_jfieldId = JNIEnv.GetFieldID (class_ref, "amsFiles", "Lcom/liveperson/messaging/model/AmsFiles;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, amsFiles_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsFiles> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (amsFiles_jfieldId == IntPtr.Zero)
					amsFiles_jfieldId = JNIEnv.GetFieldID (class_ref, "amsFiles", "Lcom/liveperson/messaging/model/AmsFiles;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, amsFiles_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr amsMessages_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/field[@name='amsMessages']"
		[Register ("amsMessages")]
		public global::Com.Liveperson.Messaging.Model.AmsMessages AmsMessages {
			get {
				if (amsMessages_jfieldId == IntPtr.Zero)
					amsMessages_jfieldId = JNIEnv.GetFieldID (class_ref, "amsMessages", "Lcom/liveperson/messaging/model/AmsMessages;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, amsMessages_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (amsMessages_jfieldId == IntPtr.Zero)
					amsMessages_jfieldId = JNIEnv.GetFieldID (class_ref, "amsMessages", "Lcom/liveperson/messaging/model/AmsMessages;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, amsMessages_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr amsReadController_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/field[@name='amsReadController']"
		[Register ("amsReadController")]
		public global::Com.Liveperson.Messaging.Controller.AmsReadController AmsReadController {
			get {
				if (amsReadController_jfieldId == IntPtr.Zero)
					amsReadController_jfieldId = JNIEnv.GetFieldID (class_ref, "amsReadController", "Lcom/liveperson/messaging/controller/AmsReadController;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, amsReadController_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.AmsReadController> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (amsReadController_jfieldId == IntPtr.Zero)
					amsReadController_jfieldId = JNIEnv.GetFieldID (class_ref, "amsReadController", "Lcom/liveperson/messaging/controller/AmsReadController;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, amsReadController_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr amsUsers_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/field[@name='amsUsers']"
		[Register ("amsUsers")]
		public global::Com.Liveperson.Messaging.Model.AmsUsers AmsUsers {
			get {
				if (amsUsers_jfieldId == IntPtr.Zero)
					amsUsers_jfieldId = JNIEnv.GetFieldID (class_ref, "amsUsers", "Lcom/liveperson/messaging/model/AmsUsers;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, amsUsers_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsUsers> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (amsUsers_jfieldId == IntPtr.Zero)
					amsUsers_jfieldId = JNIEnv.GetFieldID (class_ref, "amsUsers", "Lcom/liveperson/messaging/model/AmsUsers;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, amsUsers_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mAccountsController_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/field[@name='mAccountsController']"
		[Register ("mAccountsController")]
		public global::Com.Liveperson.Messaging.Controller.AccountsController MAccountsController {
			get {
				if (mAccountsController_jfieldId == IntPtr.Zero)
					mAccountsController_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccountsController", "Lcom/liveperson/messaging/controller/AccountsController;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAccountsController_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.AccountsController> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAccountsController_jfieldId == IntPtr.Zero)
					mAccountsController_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccountsController", "Lcom/liveperson/messaging/controller/AccountsController;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAccountsController_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mConnectionController_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/field[@name='mConnectionController']"
		[Register ("mConnectionController")]
		public global::Com.Liveperson.Messaging.Controller.ConnectionsController MConnectionController {
			get {
				if (mConnectionController_jfieldId == IntPtr.Zero)
					mConnectionController_jfieldId = JNIEnv.GetFieldID (class_ref, "mConnectionController", "Lcom/liveperson/messaging/controller/ConnectionsController;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mConnectionController_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ConnectionsController> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mConnectionController_jfieldId == IntPtr.Zero)
					mConnectionController_jfieldId = JNIEnv.GetFieldID (class_ref, "mConnectionController", "Lcom/liveperson/messaging/controller/ConnectionsController;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mConnectionController_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mEventsProxy_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/field[@name='mEventsProxy']"
		[Register ("mEventsProxy")]
		public global::Com.Liveperson.Messaging.LivePersonEventsProxy MEventsProxy {
			get {
				if (mEventsProxy_jfieldId == IntPtr.Zero)
					mEventsProxy_jfieldId = JNIEnv.GetFieldID (class_ref, "mEventsProxy", "Lcom/liveperson/messaging/LivePersonEventsProxy;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mEventsProxy_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.LivePersonEventsProxy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mEventsProxy_jfieldId == IntPtr.Zero)
					mEventsProxy_jfieldId = JNIEnv.GetFieldID (class_ref, "mEventsProxy", "Lcom/liveperson/messaging/LivePersonEventsProxy;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mEventsProxy_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/Messaging", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Messaging); }
		}

		protected Messaging (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/constructor[@name='Messaging' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Messaging ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Messaging)) {
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

		static Delegate cb_getAudioUtils;
#pragma warning disable 0169
		static Delegate GetGetAudioUtilsHandler ()
		{
			if (cb_getAudioUtils == null)
				cb_getAudioUtils = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAudioUtils);
			return cb_getAudioUtils;
		}

		static IntPtr n_GetAudioUtils (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AudioUtils);
		}
#pragma warning restore 0169

		static IntPtr id_getAudioUtils;
		public virtual unsafe global::Com.Liveperson.Infra.Utils.LPAudioUtils AudioUtils {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='getAudioUtils' and count(parameter)=0]"
			[Register ("getAudioUtils", "()Lcom/liveperson/infra/utils/LPAudioUtils;", "GetGetAudioUtilsHandler")]
			get {
				if (id_getAudioUtils == IntPtr.Zero)
					id_getAudioUtils = JNIEnv.GetMethodID (class_ref, "getAudioUtils", "()Lcom/liveperson/infra/utils/LPAudioUtils;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAudioUtils), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAudioUtils", "()Lcom/liveperson/infra/utils/LPAudioUtils;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConversationViewParams;
#pragma warning disable 0169
		static Delegate GetGetConversationViewParamsHandler ()
		{
			if (cb_getConversationViewParams == null)
				cb_getConversationViewParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConversationViewParams);
			return cb_getConversationViewParams;
		}

		static IntPtr n_GetConversationViewParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConversationViewParams);
		}
#pragma warning restore 0169

		static Delegate cb_setConversationViewParams_Lcom_liveperson_infra_ConversationViewParams_;
#pragma warning disable 0169
		static Delegate GetSetConversationViewParams_Lcom_liveperson_infra_ConversationViewParams_Handler ()
		{
			if (cb_setConversationViewParams_Lcom_liveperson_infra_ConversationViewParams_ == null)
				cb_setConversationViewParams_Lcom_liveperson_infra_ConversationViewParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConversationViewParams_Lcom_liveperson_infra_ConversationViewParams_);
			return cb_setConversationViewParams_Lcom_liveperson_infra_ConversationViewParams_;
		}

		static void n_SetConversationViewParams_Lcom_liveperson_infra_ConversationViewParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ConversationViewParams p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConversationViewParams = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getConversationViewParams;
		static IntPtr id_setConversationViewParams_Lcom_liveperson_infra_ConversationViewParams_;
		public virtual unsafe global::Com.Liveperson.Infra.ConversationViewParams ConversationViewParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='getConversationViewParams' and count(parameter)=0]"
			[Register ("getConversationViewParams", "()Lcom/liveperson/infra/ConversationViewParams;", "GetGetConversationViewParamsHandler")]
			get {
				if (id_getConversationViewParams == IntPtr.Zero)
					id_getConversationViewParams = JNIEnv.GetMethodID (class_ref, "getConversationViewParams", "()Lcom/liveperson/infra/ConversationViewParams;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationViewParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationViewParams", "()Lcom/liveperson/infra/ConversationViewParams;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='setConversationViewParams' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.ConversationViewParams']]"
			[Register ("setConversationViewParams", "(Lcom/liveperson/infra/ConversationViewParams;)V", "GetSetConversationViewParams_Lcom_liveperson_infra_ConversationViewParams_Handler")]
			set {
				if (id_setConversationViewParams_Lcom_liveperson_infra_ConversationViewParams_ == IntPtr.Zero)
					id_setConversationViewParams_Lcom_liveperson_infra_ConversationViewParams_ = JNIEnv.GetMethodID (class_ref, "setConversationViewParams", "(Lcom/liveperson/infra/ConversationViewParams;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConversationViewParams_Lcom_liveperson_infra_ConversationViewParams_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConversationViewParams", "(Lcom/liveperson/infra/ConversationViewParams;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFileSharingManager;
#pragma warning disable 0169
		static Delegate GetGetFileSharingManagerHandler ()
		{
			if (cb_getFileSharingManager == null)
				cb_getFileSharingManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileSharingManager);
			return cb_getFileSharingManager;
		}

		static IntPtr n_GetFileSharingManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FileSharingManager);
		}
#pragma warning restore 0169

		static IntPtr id_getFileSharingManager;
		public virtual unsafe global::Com.Liveperson.Messaging.Background.FileSharingManager FileSharingManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='getFileSharingManager' and count(parameter)=0]"
			[Register ("getFileSharingManager", "()Lcom/liveperson/messaging/background/FileSharingManager;", "GetGetFileSharingManagerHandler")]
			get {
				if (id_getFileSharingManager == IntPtr.Zero)
					id_getFileSharingManager = JNIEnv.GetMethodID (class_ref, "getFileSharingManager", "()Lcom/liveperson/messaging/background/FileSharingManager;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.FileSharingManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFileSharingManager), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.FileSharingManager> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileSharingManager", "()Lcom/liveperson/messaging/background/FileSharingManager;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getImageForegroundServiceDownloadNotificationBuilder;
#pragma warning disable 0169
		static Delegate GetGetImageForegroundServiceDownloadNotificationBuilderHandler ()
		{
			if (cb_getImageForegroundServiceDownloadNotificationBuilder == null)
				cb_getImageForegroundServiceDownloadNotificationBuilder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageForegroundServiceDownloadNotificationBuilder);
			return cb_getImageForegroundServiceDownloadNotificationBuilder;
		}

		static IntPtr n_GetImageForegroundServiceDownloadNotificationBuilder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageForegroundServiceDownloadNotificationBuilder);
		}
#pragma warning restore 0169

		static Delegate cb_setImageForegroundServiceDownloadNotificationBuilder_Landroid_app_Notification_Builder_;
#pragma warning disable 0169
		static Delegate GetSetImageForegroundServiceDownloadNotificationBuilder_Landroid_app_Notification_Builder_Handler ()
		{
			if (cb_setImageForegroundServiceDownloadNotificationBuilder_Landroid_app_Notification_Builder_ == null)
				cb_setImageForegroundServiceDownloadNotificationBuilder_Landroid_app_Notification_Builder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageForegroundServiceDownloadNotificationBuilder_Landroid_app_Notification_Builder_);
			return cb_setImageForegroundServiceDownloadNotificationBuilder_Landroid_app_Notification_Builder_;
		}

		static void n_SetImageForegroundServiceDownloadNotificationBuilder_Landroid_app_Notification_Builder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Notification.Builder p0 = global::Java.Lang.Object.GetObject<global::Android.App.Notification.Builder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ImageForegroundServiceDownloadNotificationBuilder = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImageForegroundServiceDownloadNotificationBuilder;
		static IntPtr id_setImageForegroundServiceDownloadNotificationBuilder_Landroid_app_Notification_Builder_;
		public virtual unsafe global::Android.App.Notification.Builder ImageForegroundServiceDownloadNotificationBuilder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='getImageForegroundServiceDownloadNotificationBuilder' and count(parameter)=0]"
			[Register ("getImageForegroundServiceDownloadNotificationBuilder", "()Landroid/app/Notification$Builder;", "GetGetImageForegroundServiceDownloadNotificationBuilderHandler")]
			get {
				if (id_getImageForegroundServiceDownloadNotificationBuilder == IntPtr.Zero)
					id_getImageForegroundServiceDownloadNotificationBuilder = JNIEnv.GetMethodID (class_ref, "getImageForegroundServiceDownloadNotificationBuilder", "()Landroid/app/Notification$Builder;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.App.Notification.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageForegroundServiceDownloadNotificationBuilder), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.App.Notification.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageForegroundServiceDownloadNotificationBuilder", "()Landroid/app/Notification$Builder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='setImageForegroundServiceDownloadNotificationBuilder' and count(parameter)=1 and parameter[1][@type='android.app.Notification.Builder']]"
			[Register ("setImageForegroundServiceDownloadNotificationBuilder", "(Landroid/app/Notification$Builder;)V", "GetSetImageForegroundServiceDownloadNotificationBuilder_Landroid_app_Notification_Builder_Handler")]
			set {
				if (id_setImageForegroundServiceDownloadNotificationBuilder_Landroid_app_Notification_Builder_ == IntPtr.Zero)
					id_setImageForegroundServiceDownloadNotificationBuilder_Landroid_app_Notification_Builder_ = JNIEnv.GetMethodID (class_ref, "setImageForegroundServiceDownloadNotificationBuilder", "(Landroid/app/Notification$Builder;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImageForegroundServiceDownloadNotificationBuilder_Landroid_app_Notification_Builder_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageForegroundServiceDownloadNotificationBuilder", "(Landroid/app/Notification$Builder;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getImageForegroundServiceUploadNotificationBuilder;
#pragma warning disable 0169
		static Delegate GetGetImageForegroundServiceUploadNotificationBuilderHandler ()
		{
			if (cb_getImageForegroundServiceUploadNotificationBuilder == null)
				cb_getImageForegroundServiceUploadNotificationBuilder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageForegroundServiceUploadNotificationBuilder);
			return cb_getImageForegroundServiceUploadNotificationBuilder;
		}

		static IntPtr n_GetImageForegroundServiceUploadNotificationBuilder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageForegroundServiceUploadNotificationBuilder);
		}
#pragma warning restore 0169

		static Delegate cb_setImageForegroundServiceUploadNotificationBuilder_Landroid_app_Notification_Builder_;
#pragma warning disable 0169
		static Delegate GetSetImageForegroundServiceUploadNotificationBuilder_Landroid_app_Notification_Builder_Handler ()
		{
			if (cb_setImageForegroundServiceUploadNotificationBuilder_Landroid_app_Notification_Builder_ == null)
				cb_setImageForegroundServiceUploadNotificationBuilder_Landroid_app_Notification_Builder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageForegroundServiceUploadNotificationBuilder_Landroid_app_Notification_Builder_);
			return cb_setImageForegroundServiceUploadNotificationBuilder_Landroid_app_Notification_Builder_;
		}

		static void n_SetImageForegroundServiceUploadNotificationBuilder_Landroid_app_Notification_Builder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Notification.Builder p0 = global::Java.Lang.Object.GetObject<global::Android.App.Notification.Builder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ImageForegroundServiceUploadNotificationBuilder = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImageForegroundServiceUploadNotificationBuilder;
		static IntPtr id_setImageForegroundServiceUploadNotificationBuilder_Landroid_app_Notification_Builder_;
		public virtual unsafe global::Android.App.Notification.Builder ImageForegroundServiceUploadNotificationBuilder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='getImageForegroundServiceUploadNotificationBuilder' and count(parameter)=0]"
			[Register ("getImageForegroundServiceUploadNotificationBuilder", "()Landroid/app/Notification$Builder;", "GetGetImageForegroundServiceUploadNotificationBuilderHandler")]
			get {
				if (id_getImageForegroundServiceUploadNotificationBuilder == IntPtr.Zero)
					id_getImageForegroundServiceUploadNotificationBuilder = JNIEnv.GetMethodID (class_ref, "getImageForegroundServiceUploadNotificationBuilder", "()Landroid/app/Notification$Builder;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.App.Notification.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageForegroundServiceUploadNotificationBuilder), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.App.Notification.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageForegroundServiceUploadNotificationBuilder", "()Landroid/app/Notification$Builder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='setImageForegroundServiceUploadNotificationBuilder' and count(parameter)=1 and parameter[1][@type='android.app.Notification.Builder']]"
			[Register ("setImageForegroundServiceUploadNotificationBuilder", "(Landroid/app/Notification$Builder;)V", "GetSetImageForegroundServiceUploadNotificationBuilder_Landroid_app_Notification_Builder_Handler")]
			set {
				if (id_setImageForegroundServiceUploadNotificationBuilder_Landroid_app_Notification_Builder_ == IntPtr.Zero)
					id_setImageForegroundServiceUploadNotificationBuilder_Landroid_app_Notification_Builder_ = JNIEnv.GetMethodID (class_ref, "setImageForegroundServiceUploadNotificationBuilder", "(Landroid/app/Notification$Builder;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImageForegroundServiceUploadNotificationBuilder_Landroid_app_Notification_Builder_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageForegroundServiceUploadNotificationBuilder", "(Landroid/app/Notification$Builder;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getImageServicePendingIntent;
#pragma warning disable 0169
		static Delegate GetGetImageServicePendingIntentHandler ()
		{
			if (cb_getImageServicePendingIntent == null)
				cb_getImageServicePendingIntent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageServicePendingIntent);
			return cb_getImageServicePendingIntent;
		}

		static IntPtr n_GetImageServicePendingIntent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageServicePendingIntent);
		}
#pragma warning restore 0169

		static Delegate cb_setImageServicePendingIntent_Landroid_app_PendingIntent_;
#pragma warning disable 0169
		static Delegate GetSetImageServicePendingIntent_Landroid_app_PendingIntent_Handler ()
		{
			if (cb_setImageServicePendingIntent_Landroid_app_PendingIntent_ == null)
				cb_setImageServicePendingIntent_Landroid_app_PendingIntent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageServicePendingIntent_Landroid_app_PendingIntent_);
			return cb_setImageServicePendingIntent_Landroid_app_PendingIntent_;
		}

		static void n_SetImageServicePendingIntent_Landroid_app_PendingIntent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.PendingIntent p0 = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ImageServicePendingIntent = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImageServicePendingIntent;
		static IntPtr id_setImageServicePendingIntent_Landroid_app_PendingIntent_;
		public virtual unsafe global::Android.App.PendingIntent ImageServicePendingIntent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='getImageServicePendingIntent' and count(parameter)=0]"
			[Register ("getImageServicePendingIntent", "()Landroid/app/PendingIntent;", "GetGetImageServicePendingIntentHandler")]
			get {
				if (id_getImageServicePendingIntent == IntPtr.Zero)
					id_getImageServicePendingIntent = JNIEnv.GetMethodID (class_ref, "getImageServicePendingIntent", "()Landroid/app/PendingIntent;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageServicePendingIntent), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageServicePendingIntent", "()Landroid/app/PendingIntent;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='setImageServicePendingIntent' and count(parameter)=1 and parameter[1][@type='android.app.PendingIntent']]"
			[Register ("setImageServicePendingIntent", "(Landroid/app/PendingIntent;)V", "GetSetImageServicePendingIntent_Landroid_app_PendingIntent_Handler")]
			set {
				if (id_setImageServicePendingIntent_Landroid_app_PendingIntent_ == IntPtr.Zero)
					id_setImageServicePendingIntent_Landroid_app_PendingIntent_ = JNIEnv.GetMethodID (class_ref, "setImageServicePendingIntent", "(Landroid/app/PendingIntent;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImageServicePendingIntent_Landroid_app_PendingIntent_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageServicePendingIntent", "(Landroid/app/PendingIntent;)V"), __args);
				} finally {
				}
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
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.InProgressUploadMessageRowIdsString);
		}
#pragma warning restore 0169

		static IntPtr id_getInProgressUploadMessageRowIdsString;
		public virtual unsafe string InProgressUploadMessageRowIdsString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='getInProgressUploadMessageRowIdsString' and count(parameter)=0]"
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

		static Delegate cb_isEnableStructuredContent;
#pragma warning disable 0169
		static Delegate GetIsEnableStructuredContentHandler ()
		{
			if (cb_isEnableStructuredContent == null)
				cb_isEnableStructuredContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnableStructuredContent);
			return cb_isEnableStructuredContent;
		}

		static bool n_IsEnableStructuredContent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnableStructuredContent;
		}
#pragma warning restore 0169

		static IntPtr id_isEnableStructuredContent;
		public virtual unsafe bool IsEnableStructuredContent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='isEnableStructuredContent' and count(parameter)=0]"
			[Register ("isEnableStructuredContent", "()Z", "GetIsEnableStructuredContentHandler")]
			get {
				if (id_isEnableStructuredContent == IntPtr.Zero)
					id_isEnableStructuredContent = JNIEnv.GetMethodID (class_ref, "isEnableStructuredContent", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnableStructuredContent);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEnableStructuredContent", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isInitialized;
#pragma warning disable 0169
		static Delegate GetIsInitializedHandler ()
		{
			if (cb_isInitialized == null)
				cb_isInitialized = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInitialized);
			return cb_isInitialized;
		}

		static bool n_IsInitialized (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInitialized;
		}
#pragma warning restore 0169

		static IntPtr id_isInitialized;
		public virtual unsafe bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "GetIsInitializedHandler")]
			get {
				if (id_isInitialized == IntPtr.Zero)
					id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInitialized);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInitialized", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMessagingEventSubscriptionManager;
#pragma warning disable 0169
		static Delegate GetGetMessagingEventSubscriptionManagerHandler ()
		{
			if (cb_getMessagingEventSubscriptionManager == null)
				cb_getMessagingEventSubscriptionManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessagingEventSubscriptionManager);
			return cb_getMessagingEventSubscriptionManager;
		}

		static IntPtr n_GetMessagingEventSubscriptionManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MessagingEventSubscriptionManager);
		}
#pragma warning restore 0169

		static IntPtr id_getMessagingEventSubscriptionManager;
		public virtual unsafe global::Com.Liveperson.Messaging.Commands.Tasks.MessagingEventSubscriptionManager MessagingEventSubscriptionManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='getMessagingEventSubscriptionManager' and count(parameter)=0]"
			[Register ("getMessagingEventSubscriptionManager", "()Lcom/liveperson/messaging/commands/tasks/MessagingEventSubscriptionManager;", "GetGetMessagingEventSubscriptionManagerHandler")]
			get {
				if (id_getMessagingEventSubscriptionManager == IntPtr.Zero)
					id_getMessagingEventSubscriptionManager = JNIEnv.GetMethodID (class_ref, "getMessagingEventSubscriptionManager", "()Lcom/liveperson/messaging/commands/tasks/MessagingEventSubscriptionManager;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.MessagingEventSubscriptionManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessagingEventSubscriptionManager), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.MessagingEventSubscriptionManager> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessagingEventSubscriptionManager", "()Lcom/liveperson/messaging/commands/tasks/MessagingEventSubscriptionManager;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_bootstrapRegistration;
#pragma warning disable 0169
		static Delegate GetBootstrapRegistrationHandler ()
		{
			if (cb_bootstrapRegistration == null)
				cb_bootstrapRegistration = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_BootstrapRegistration);
			return cb_bootstrapRegistration;
		}

		static void n_BootstrapRegistration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BootstrapRegistration ();
		}
#pragma warning restore 0169

		static IntPtr id_bootstrapRegistration;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='bootstrapRegistration' and count(parameter)=0]"
		[Register ("bootstrapRegistration", "()V", "GetBootstrapRegistrationHandler")]
		protected virtual unsafe void BootstrapRegistration ()
		{
			if (id_bootstrapRegistration == IntPtr.Zero)
				id_bootstrapRegistration = JNIEnv.GetMethodID (class_ref, "bootstrapRegistration", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bootstrapRegistration);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bootstrapRegistration", "()V"));
			} finally {
			}
		}

		static Delegate cb_changeChatState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_model_types_ChatState_;
#pragma warning disable 0169
		static Delegate GetChangeChatState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_model_types_ChatState_Handler ()
		{
			if (cb_changeChatState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_model_types_ChatState_ == null)
				cb_changeChatState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_model_types_ChatState_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ChangeChatState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_model_types_ChatState_);
			return cb_changeChatState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_model_types_ChatState_;
		}

		static IntPtr n_ChangeChatState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_model_types_ChatState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Model.Types.ChatState p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Types.ChatState> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ChangeChatState (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_changeChatState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_model_types_ChatState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='changeChatState' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.infra.model.types.ChatState']]"
		[Register ("changeChatState", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/model/types/ChatState;)Lcom/liveperson/messaging/ConversationActionFailedReason;", "GetChangeChatState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_model_types_ChatState_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.ConversationActionFailedReason ChangeChatState (string p0, string p1, global::Com.Liveperson.Infra.Model.Types.ChatState p2)
		{
			if (id_changeChatState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_model_types_ChatState_ == IntPtr.Zero)
				id_changeChatState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_model_types_ChatState_ = JNIEnv.GetMethodID (class_ref, "changeChatState", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/model/types/ChatState;)Lcom/liveperson/messaging/ConversationActionFailedReason;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				global::Com.Liveperson.Messaging.ConversationActionFailedReason __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.ConversationActionFailedReason> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_changeChatState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_model_types_ChatState_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.ConversationActionFailedReason> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "changeChatState", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/model/types/ChatState;)Lcom/liveperson/messaging/ConversationActionFailedReason;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_checkActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
#pragma warning disable 0169
		static Delegate GetCheckActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Handler ()
		{
			if (cb_checkActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ == null)
				cb_checkActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CheckActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_);
			return cb_checkActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
		}

		static void n_CheckActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ICallback p1 = (global::Com.Liveperson.Infra.ICallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CheckActiveConversation (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_checkActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='checkActiveConversation' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.ICallback&lt;java.lang.Boolean, java.lang.Exception&gt;']]"
		[Register ("checkActiveConversation", "(Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V", "GetCheckActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Handler")]
		public virtual unsafe void CheckActiveConversation (string p0, global::Com.Liveperson.Infra.ICallback p1)
		{
			if (id_checkActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ == IntPtr.Zero)
				id_checkActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ = JNIEnv.GetMethodID (class_ref, "checkActiveConversation", "(Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkActiveConversation", "(Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_checkAgentID_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
#pragma warning disable 0169
		static Delegate GetCheckAgentID_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Handler ()
		{
			if (cb_checkAgentID_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ == null)
				cb_checkAgentID_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CheckAgentID_Ljava_lang_String_Lcom_liveperson_infra_ICallback_);
			return cb_checkAgentID_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
		}

		static void n_CheckAgentID_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ICallback p1 = (global::Com.Liveperson.Infra.ICallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CheckAgentID (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_checkAgentID_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='checkAgentID' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.ICallback&lt;com.liveperson.messaging.model.AgentData, java.lang.Exception&gt;']]"
		[Register ("checkAgentID", "(Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V", "GetCheckAgentID_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Handler")]
		public virtual unsafe void CheckAgentID (string p0, global::Com.Liveperson.Infra.ICallback p1)
		{
			if (id_checkAgentID_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ == IntPtr.Zero)
				id_checkAgentID_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ = JNIEnv.GetMethodID (class_ref, "checkAgentID", "(Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkAgentID_Ljava_lang_String_Lcom_liveperson_infra_ICallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkAgentID", "(Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_checkConversationIsMarkedAsUrgent_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
#pragma warning disable 0169
		static Delegate GetCheckConversationIsMarkedAsUrgent_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Handler ()
		{
			if (cb_checkConversationIsMarkedAsUrgent_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ == null)
				cb_checkConversationIsMarkedAsUrgent_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CheckConversationIsMarkedAsUrgent_Ljava_lang_String_Lcom_liveperson_infra_ICallback_);
			return cb_checkConversationIsMarkedAsUrgent_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
		}

		static void n_CheckConversationIsMarkedAsUrgent_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ICallback p1 = (global::Com.Liveperson.Infra.ICallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CheckConversationIsMarkedAsUrgent (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_checkConversationIsMarkedAsUrgent_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='checkConversationIsMarkedAsUrgent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.ICallback&lt;java.lang.Boolean, java.lang.Exception&gt;']]"
		[Register ("checkConversationIsMarkedAsUrgent", "(Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V", "GetCheckConversationIsMarkedAsUrgent_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Handler")]
		public virtual unsafe void CheckConversationIsMarkedAsUrgent (string p0, global::Com.Liveperson.Infra.ICallback p1)
		{
			if (id_checkConversationIsMarkedAsUrgent_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ == IntPtr.Zero)
				id_checkConversationIsMarkedAsUrgent_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ = JNIEnv.GetMethodID (class_ref, "checkConversationIsMarkedAsUrgent", "(Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkConversationIsMarkedAsUrgent_Ljava_lang_String_Lcom_liveperson_infra_ICallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkConversationIsMarkedAsUrgent", "(Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_clearHistory_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetClearHistory_Ljava_lang_String_Handler ()
		{
			if (cb_clearHistory_Ljava_lang_String_ == null)
				cb_clearHistory_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ClearHistory_Ljava_lang_String_);
			return cb_clearHistory_Ljava_lang_String_;
		}

		static bool n_ClearHistory_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ClearHistory (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_clearHistory_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='clearHistory' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("clearHistory", "(Ljava/lang/String;)Z", "GetClearHistory_Ljava_lang_String_Handler")]
		public virtual unsafe bool ClearHistory (string p0)
		{
			if (id_clearHistory_Ljava_lang_String_ == IntPtr.Zero)
				id_clearHistory_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "clearHistory", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_clearHistory_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearHistory", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Handler ()
		{
			if (cb_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ == null)
				cb_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_);
			return cb_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_;
		}

		static void n_Connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.LPAuthenticationParams p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ConversationViewParams p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='connect' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.LPAuthenticationParams'] and parameter[3][@type='com.liveperson.infra.ConversationViewParams']]"
		[Register ("connect", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ConversationViewParams;)V", "GetConnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Handler")]
		public virtual unsafe void Connect (string p0, global::Com.Liveperson.Infra.LPAuthenticationParams p1, global::Com.Liveperson.Infra.ConversationViewParams p2)
		{
			if (id_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ == IntPtr.Zero)
				id_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ = JNIEnv.GetMethodID (class_ref, "connect", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ConversationViewParams;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ConversationViewParams;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Z;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ZHandler ()
		{
			if (cb_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Z == null)
				cb_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Z);
			return cb_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Z;
		}

		static void n_Connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.LPAuthenticationParams p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ConversationViewParams p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='connect' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.LPAuthenticationParams'] and parameter[3][@type='com.liveperson.infra.ConversationViewParams'] and parameter[4][@type='boolean']]"
		[Register ("connect", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ConversationViewParams;Z)V", "GetConnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ZHandler")]
		public virtual unsafe void Connect (string p0, global::Com.Liveperson.Infra.LPAuthenticationParams p1, global::Com.Liveperson.Infra.ConversationViewParams p2, bool p3)
		{
			if (id_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Z == IntPtr.Zero)
				id_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Z = JNIEnv.GetMethodID (class_ref, "connect", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ConversationViewParams;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ConversationViewParams;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_disconnect_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDisconnect_Ljava_lang_String_Handler ()
		{
			if (cb_disconnect_Ljava_lang_String_ == null)
				cb_disconnect_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Disconnect_Ljava_lang_String_);
			return cb_disconnect_Ljava_lang_String_;
		}

		static void n_Disconnect_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect (p0);
		}
#pragma warning restore 0169

		static IntPtr id_disconnect_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='disconnect' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("disconnect", "(Ljava/lang/String;)V", "GetDisconnect_Ljava_lang_String_Handler")]
		public virtual unsafe void Disconnect (string p0)
		{
			if (id_disconnect_Ljava_lang_String_ == IntPtr.Zero)
				id_disconnect_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "disconnect", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnect_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnect", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_downloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ;
#pragma warning disable 0169
		static Delegate GetDownloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJHandler ()
		{
			if (cb_downloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ == null)
				cb_downloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long, long>) n_DownloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ);
			return cb_downloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ;
		}

		static void n_DownloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, long p4, long p5)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.DownloadFile (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_downloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='downloadFile' and count(parameter)=6 and parameter[1][@type='com.liveperson.messaging.background.filesharing.FileSharingType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='long'] and parameter[6][@type='long']]"
		[Register ("downloadFile", "(Lcom/liveperson/messaging/background/filesharing/FileSharingType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JJ)V", "GetDownloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJHandler")]
		public virtual unsafe void DownloadFile (global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType p0, string p1, string p2, string p3, long p4, long p5)
		{
			if (id_downloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ == IntPtr.Zero)
				id_downloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ = JNIEnv.GetMethodID (class_ref, "downloadFile", "(Lcom/liveperson/messaging/background/filesharing/FileSharingType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JJ)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_downloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "downloadFile", "(Lcom/liveperson/messaging/background/filesharing/FileSharingType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JJ)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_generateUploadToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGenerateUploadToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_generateUploadToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_generateUploadToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GenerateUploadToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_generateUploadToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_GenerateUploadToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.GenerateUploadToken (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_generateUploadToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='generateUploadToken' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("generateUploadToken", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetGenerateUploadToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void GenerateUploadToken (string p0, string p1, string p2)
		{
			if (id_generateUploadToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_generateUploadToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "generateUploadToken", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_generateUploadToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "generateUploadToken", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
#pragma warning disable 0169
		static Delegate GetGetActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Handler ()
		{
			if (cb_getActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ == null)
				cb_getActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_);
			return cb_getActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
		}

		static void n_GetActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ICallback p1 = (global::Com.Liveperson.Infra.ICallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetActiveConversation (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_getActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='getActiveConversation' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.ICallback&lt;com.liveperson.messaging.model.Conversation, java.lang.Exception&gt;']]"
		[Register ("getActiveConversation", "(Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V", "GetGetActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Handler")]
		public virtual unsafe void GetActiveConversation (string p0, global::Com.Liveperson.Infra.ICallback p1)
		{
			if (id_getActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ == IntPtr.Zero)
				id_getActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ = JNIEnv.GetMethodID (class_ref, "getActiveConversation", "(Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActiveConversation", "(Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getMaskedMessage_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMaskedMessage_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getMaskedMessage_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getMaskedMessage_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMaskedMessage_Ljava_lang_String_Ljava_lang_String_);
			return cb_getMaskedMessage_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetMaskedMessage_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMaskedMessage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMaskedMessage_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='getMaskedMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getMaskedMessage", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/infra/utils/MaskedMessage;", "GetGetMaskedMessage_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Utils.MaskedMessage GetMaskedMessage (string p0, string p1)
		{
			if (id_getMaskedMessage_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getMaskedMessage_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMaskedMessage", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/infra/utils/MaskedMessage;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Liveperson.Infra.Utils.MaskedMessage __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.MaskedMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMaskedMessage_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.MaskedMessage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaskedMessage", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/infra/utils/MaskedMessage;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getOriginatorId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetOriginatorId_Ljava_lang_String_Handler ()
		{
			if (cb_getOriginatorId_Ljava_lang_String_ == null)
				cb_getOriginatorId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetOriginatorId_Ljava_lang_String_);
			return cb_getOriginatorId_Ljava_lang_String_;
		}

		static IntPtr n_GetOriginatorId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetOriginatorId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getOriginatorId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='getOriginatorId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getOriginatorId", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetOriginatorId_Ljava_lang_String_Handler")]
		public virtual unsafe string GetOriginatorId (string p0)
		{
			if (id_getOriginatorId_Ljava_lang_String_ == IntPtr.Zero)
				id_getOriginatorId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getOriginatorId", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOriginatorId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOriginatorId", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getUnreadMessagesCount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
#pragma warning disable 0169
		static Delegate GetGetUnreadMessagesCount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Handler ()
		{
			if (cb_getUnreadMessagesCount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ == null)
				cb_getUnreadMessagesCount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUnreadMessagesCount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_);
			return cb_getUnreadMessagesCount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
		}

		static void n_GetUnreadMessagesCount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ICallback p2 = (global::Com.Liveperson.Infra.ICallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.GetUnreadMessagesCount (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_getUnreadMessagesCount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='getUnreadMessagesCount' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.infra.ICallback&lt;java.lang.Integer, java.lang.Exception&gt;']]"
		[Register ("getUnreadMessagesCount", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V", "GetGetUnreadMessagesCount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Handler")]
		public virtual unsafe void GetUnreadMessagesCount (string p0, string p1, global::Com.Liveperson.Infra.ICallback p2)
		{
			if (id_getUnreadMessagesCount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ == IntPtr.Zero)
				id_getUnreadMessagesCount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ = JNIEnv.GetMethodID (class_ref, "getUnreadMessagesCount", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getUnreadMessagesCount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUnreadMessagesCount", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_Handler ()
		{
			if (cb_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_ == null)
				cb_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_);
			return cb_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_;
		}

		static void n_Init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.MessagingInitData p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.MessagingInitData> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack p2 = (global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='init' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.liveperson.messaging.MessagingInitData'] and parameter[3][@type='com.liveperson.infra.callbacks.InitLivePersonCallBack']]"
		[Register ("init", "(Landroid/content/Context;Lcom/liveperson/messaging/MessagingInitData;Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;)V", "GetInit_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_Handler")]
		public virtual unsafe void Init (global::Android.Content.Context p0, global::Com.Liveperson.Messaging.MessagingInitData p1, global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack p2)
		{
			if (id_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_ == IntPtr.Zero)
				id_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_ = JNIEnv.GetMethodID (class_ref, "init", "(Landroid/content/Context;Lcom/liveperson/messaging/MessagingInitData;Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Landroid/content/Context;Lcom/liveperson/messaging/MessagingInitData;Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_Handler ()
		{
			if (cb_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_ == null)
				cb_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_);
			return cb_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_;
		}

		static void n_Init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.MessagingInitData p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.MessagingInitData> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.InitProcess p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.InitProcess> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='init' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.liveperson.messaging.MessagingInitData'] and parameter[3][@type='com.liveperson.infra.statemachine.InitProcess']]"
		[Register ("init", "(Landroid/content/Context;Lcom/liveperson/messaging/MessagingInitData;Lcom/liveperson/infra/statemachine/InitProcess;)V", "GetInit_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_Handler")]
		public virtual unsafe void Init (global::Android.Content.Context p0, global::Com.Liveperson.Messaging.MessagingInitData p1, global::Com.Liveperson.Infra.Statemachine.InitProcess p2)
		{
			if (id_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_ == IntPtr.Zero)
				id_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_ = JNIEnv.GetMethodID (class_ref, "init", "(Landroid/content/Context;Lcom/liveperson/messaging/MessagingInitData;Lcom/liveperson/infra/statemachine/InitProcess;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Landroid/content/Context;Lcom/liveperson/messaging/MessagingInitData;Lcom/liveperson/infra/statemachine/InitProcess;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_initBrand_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_;
#pragma warning disable 0169
		static Delegate GetInitBrand_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Handler ()
		{
			if (cb_initBrand_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ == null)
				cb_initBrand_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InitBrand_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_);
			return cb_initBrand_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_;
		}

		static void n_InitBrand_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.LPAuthenticationParams p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ConversationViewParams p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.InitBrand (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_initBrand_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='initBrand' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.LPAuthenticationParams'] and parameter[3][@type='com.liveperson.infra.ConversationViewParams']]"
		[Register ("initBrand", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ConversationViewParams;)V", "GetInitBrand_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Handler")]
		protected virtual unsafe void InitBrand (string p0, global::Com.Liveperson.Infra.LPAuthenticationParams p1, global::Com.Liveperson.Infra.ConversationViewParams p2)
		{
			if (id_initBrand_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ == IntPtr.Zero)
				id_initBrand_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ = JNIEnv.GetMethodID (class_ref, "initBrand", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ConversationViewParams;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initBrand_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initBrand", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ConversationViewParams;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isConversationClosed_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsConversationClosed_Ljava_lang_String_Handler ()
		{
			if (cb_isConversationClosed_Ljava_lang_String_ == null)
				cb_isConversationClosed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsConversationClosed_Ljava_lang_String_);
			return cb_isConversationClosed_Ljava_lang_String_;
		}

		static bool n_IsConversationClosed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsConversationClosed (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isConversationClosed_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='isConversationClosed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isConversationClosed", "(Ljava/lang/String;)Z", "GetIsConversationClosed_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsConversationClosed (string p0)
		{
			if (id_isConversationClosed_Ljava_lang_String_ == IntPtr.Zero)
				id_isConversationClosed_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isConversationClosed", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConversationClosed_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConversationClosed", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isSocketOpen_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsSocketOpen_Ljava_lang_String_Handler ()
		{
			if (cb_isSocketOpen_Ljava_lang_String_ == null)
				cb_isSocketOpen_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsSocketOpen_Ljava_lang_String_);
			return cb_isSocketOpen_Ljava_lang_String_;
		}

		static bool n_IsSocketOpen_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsSocketOpen (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isSocketOpen_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='isSocketOpen' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isSocketOpen", "(Ljava/lang/String;)Z", "GetIsSocketOpen_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsSocketOpen (string p0)
		{
			if (id_isSocketOpen_Ljava_lang_String_ == IntPtr.Zero)
				id_isSocketOpen_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isSocketOpen", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSocketOpen_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSocketOpen", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_;
#pragma warning disable 0169
		static Delegate GetLogout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_Handler ()
		{
			if (cb_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_ == null)
				cb_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_);
			return cb_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_;
		}

		static void n_Logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.MessagingInitData p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.MessagingInitData> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBack p2 = (global::Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBack)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBack> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Logout (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='logout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.liveperson.messaging.MessagingInitData'] and parameter[3][@type='com.liveperson.infra.callbacks.LogoutLivePersonCallBack']]"
		[Register ("logout", "(Landroid/content/Context;Lcom/liveperson/messaging/MessagingInitData;Lcom/liveperson/infra/callbacks/LogoutLivePersonCallBack;)V", "GetLogout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_Handler")]
		public virtual unsafe void Logout (global::Android.Content.Context p0, global::Com.Liveperson.Messaging.MessagingInitData p1, global::Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBack p2)
		{
			if (id_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_ == IntPtr.Zero)
				id_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_ = JNIEnv.GetMethodID (class_ref, "logout", "(Landroid/content/Context;Lcom/liveperson/messaging/MessagingInitData;Lcom/liveperson/infra/callbacks/LogoutLivePersonCallBack;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logout", "(Landroid/content/Context;Lcom/liveperson/messaging/MessagingInitData;Lcom/liveperson/infra/callbacks/LogoutLivePersonCallBack;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_;
#pragma warning disable 0169
		static Delegate GetLogout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_Handler ()
		{
			if (cb_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_ == null)
				cb_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_);
			return cb_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_;
		}

		static void n_Logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.MessagingInitData p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.MessagingInitData> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.LogoutProcess p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.LogoutProcess> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Logout (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='logout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.liveperson.messaging.MessagingInitData'] and parameter[3][@type='com.liveperson.infra.statemachine.LogoutProcess']]"
		[Register ("logout", "(Landroid/content/Context;Lcom/liveperson/messaging/MessagingInitData;Lcom/liveperson/infra/statemachine/LogoutProcess;)V", "GetLogout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_Handler")]
		public virtual unsafe void Logout (global::Android.Content.Context p0, global::Com.Liveperson.Messaging.MessagingInitData p1, global::Com.Liveperson.Infra.Statemachine.LogoutProcess p2)
		{
			if (id_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_ == IntPtr.Zero)
				id_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_ = JNIEnv.GetMethodID (class_ref, "logout", "(Landroid/content/Context;Lcom/liveperson/messaging/MessagingInitData;Lcom/liveperson/infra/statemachine/LogoutProcess;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logout", "(Landroid/content/Context;Lcom/liveperson/messaging/MessagingInitData;Lcom/liveperson/infra/statemachine/LogoutProcess;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_markConversationAsNormal_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMarkConversationAsNormal_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_markConversationAsNormal_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_markConversationAsNormal_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MarkConversationAsNormal_Ljava_lang_String_Ljava_lang_String_);
			return cb_markConversationAsNormal_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_MarkConversationAsNormal_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MarkConversationAsNormal (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_markConversationAsNormal_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='markConversationAsNormal' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("markConversationAsNormal", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/messaging/ConversationActionFailedReason;", "GetMarkConversationAsNormal_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.ConversationActionFailedReason MarkConversationAsNormal (string p0, string p1)
		{
			if (id_markConversationAsNormal_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_markConversationAsNormal_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "markConversationAsNormal", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/messaging/ConversationActionFailedReason;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Liveperson.Messaging.ConversationActionFailedReason __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.ConversationActionFailedReason> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_markConversationAsNormal_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.ConversationActionFailedReason> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "markConversationAsNormal", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/messaging/ConversationActionFailedReason;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_markConversationAsUrgent_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMarkConversationAsUrgent_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_markConversationAsUrgent_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_markConversationAsUrgent_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MarkConversationAsUrgent_Ljava_lang_String_Ljava_lang_String_);
			return cb_markConversationAsUrgent_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_MarkConversationAsUrgent_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MarkConversationAsUrgent (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_markConversationAsUrgent_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='markConversationAsUrgent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("markConversationAsUrgent", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/messaging/ConversationActionFailedReason;", "GetMarkConversationAsUrgent_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.ConversationActionFailedReason MarkConversationAsUrgent (string p0, string p1)
		{
			if (id_markConversationAsUrgent_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_markConversationAsUrgent_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "markConversationAsUrgent", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/messaging/ConversationActionFailedReason;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Liveperson.Messaging.ConversationActionFailedReason __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.ConversationActionFailedReason> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_markConversationAsUrgent_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.ConversationActionFailedReason> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "markConversationAsUrgent", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/messaging/ConversationActionFailedReason;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_moveToBackground_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetMoveToBackground_Ljava_lang_String_JHandler ()
		{
			if (cb_moveToBackground_Ljava_lang_String_J == null)
				cb_moveToBackground_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_MoveToBackground_Ljava_lang_String_J);
			return cb_moveToBackground_Ljava_lang_String_J;
		}

		static void n_MoveToBackground_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MoveToBackground (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_moveToBackground_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='moveToBackground' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("moveToBackground", "(Ljava/lang/String;J)V", "GetMoveToBackground_Ljava_lang_String_JHandler")]
		public virtual unsafe void MoveToBackground (string p0, long p1)
		{
			if (id_moveToBackground_Ljava_lang_String_J == IntPtr.Zero)
				id_moveToBackground_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "moveToBackground", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_moveToBackground_Ljava_lang_String_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moveToBackground", "(Ljava/lang/String;J)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_moveToForeground_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_;
#pragma warning disable 0169
		static Delegate GetMoveToForeground_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Handler ()
		{
			if (cb_moveToForeground_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ == null)
				cb_moveToForeground_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MoveToForeground_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_);
			return cb_moveToForeground_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_;
		}

		static void n_MoveToForeground_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.LPAuthenticationParams p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ConversationViewParams p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.MoveToForeground (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_moveToForeground_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='moveToForeground' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.LPAuthenticationParams'] and parameter[3][@type='com.liveperson.infra.ConversationViewParams']]"
		[Register ("moveToForeground", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ConversationViewParams;)V", "GetMoveToForeground_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Handler")]
		public virtual unsafe void MoveToForeground (string p0, global::Com.Liveperson.Infra.LPAuthenticationParams p1, global::Com.Liveperson.Infra.ConversationViewParams p2)
		{
			if (id_moveToForeground_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ == IntPtr.Zero)
				id_moveToForeground_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ = JNIEnv.GetMethodID (class_ref, "moveToForeground", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ConversationViewParams;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_moveToForeground_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moveToForeground", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ConversationViewParams;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onAgentDetailsChanged_Lcom_liveperson_messaging_model_MessagingUserProfile_Z;
#pragma warning disable 0169
		static Delegate GetOnAgentDetailsChanged_Lcom_liveperson_messaging_model_MessagingUserProfile_ZHandler ()
		{
			if (cb_onAgentDetailsChanged_Lcom_liveperson_messaging_model_MessagingUserProfile_Z == null)
				cb_onAgentDetailsChanged_Lcom_liveperson_messaging_model_MessagingUserProfile_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnAgentDetailsChanged_Lcom_liveperson_messaging_model_MessagingUserProfile_Z);
			return cb_onAgentDetailsChanged_Lcom_liveperson_messaging_model_MessagingUserProfile_Z;
		}

		static void n_OnAgentDetailsChanged_Lcom_liveperson_messaging_model_MessagingUserProfile_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.MessagingUserProfile p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingUserProfile> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAgentDetailsChanged (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onAgentDetailsChanged_Lcom_liveperson_messaging_model_MessagingUserProfile_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='onAgentDetailsChanged' and count(parameter)=2 and parameter[1][@type='com.liveperson.messaging.model.MessagingUserProfile'] and parameter[2][@type='boolean']]"
		[Register ("onAgentDetailsChanged", "(Lcom/liveperson/messaging/model/MessagingUserProfile;Z)V", "GetOnAgentDetailsChanged_Lcom_liveperson_messaging_model_MessagingUserProfile_ZHandler")]
		public virtual unsafe void OnAgentDetailsChanged (global::Com.Liveperson.Messaging.Model.MessagingUserProfile p0, bool p1)
		{
			if (id_onAgentDetailsChanged_Lcom_liveperson_messaging_model_MessagingUserProfile_Z == IntPtr.Zero)
				id_onAgentDetailsChanged_Lcom_liveperson_messaging_model_MessagingUserProfile_Z = JNIEnv.GetMethodID (class_ref, "onAgentDetailsChanged", "(Lcom/liveperson/messaging/model/MessagingUserProfile;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAgentDetailsChanged_Lcom_liveperson_messaging_model_MessagingUserProfile_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAgentDetailsChanged", "(Lcom/liveperson/messaging/model/MessagingUserProfile;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onMessageTimeout_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnMessageTimeout_Ljava_lang_String_Handler ()
		{
			if (cb_onMessageTimeout_Ljava_lang_String_ == null)
				cb_onMessageTimeout_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMessageTimeout_Ljava_lang_String_);
			return cb_onMessageTimeout_Ljava_lang_String_;
		}

		static void n_OnMessageTimeout_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMessageTimeout (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onMessageTimeout_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='onMessageTimeout' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onMessageTimeout", "(Ljava/lang/String;)V", "GetOnMessageTimeout_Ljava_lang_String_Handler")]
		public virtual unsafe void OnMessageTimeout (string p0)
		{
			if (id_onMessageTimeout_Ljava_lang_String_ == IntPtr.Zero)
				id_onMessageTimeout_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onMessageTimeout", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMessageTimeout_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMessageTimeout", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_reconnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_;
#pragma warning disable 0169
		static Delegate GetReconnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Handler ()
		{
			if (cb_reconnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_ == null)
				cb_reconnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Reconnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_);
			return cb_reconnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_;
		}

		static void n_Reconnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.LPAuthenticationParams p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Reconnect (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_reconnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='reconnect' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.LPAuthenticationParams']]"
		[Register ("reconnect", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;)V", "GetReconnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Handler")]
		public virtual unsafe void Reconnect (string p0, global::Com.Liveperson.Infra.LPAuthenticationParams p1)
		{
			if (id_reconnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_ == IntPtr.Zero)
				id_reconnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_ = JNIEnv.GetMethodID (class_ref, "reconnect", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reconnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reconnect", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_registerPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_;
#pragma warning disable 0169
		static Delegate GetRegisterPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_Handler ()
		{
			if (cb_registerPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_ == null)
				cb_registerPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_);
			return cb_registerPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_;
		}

		static void n_RegisterPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.LPAuthenticationParams p3 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ICallback p4 = (global::Com.Liveperson.Infra.ICallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.RegisterPusher (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_registerPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='registerPusher' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.liveperson.infra.LPAuthenticationParams'] and parameter[5][@type='com.liveperson.infra.ICallback&lt;java.lang.Void, java.lang.Exception&gt;']]"
		[Register ("registerPusher", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ICallback;)V", "GetRegisterPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_Handler")]
		public virtual unsafe void RegisterPusher (string p0, string p1, string p2, global::Com.Liveperson.Infra.LPAuthenticationParams p3, global::Com.Liveperson.Infra.ICallback p4)
		{
			if (id_registerPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_ == IntPtr.Zero)
				id_registerPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_ = JNIEnv.GetMethodID (class_ref, "registerPusher", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerPusher", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ICallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_removeCallback;
#pragma warning disable 0169
		static Delegate GetRemoveCallbackHandler ()
		{
			if (cb_removeCallback == null)
				cb_removeCallback = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveCallback);
			return cb_removeCallback;
		}

		static void n_RemoveCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveCallback ();
		}
#pragma warning restore 0169

		static IntPtr id_removeCallback;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='removeCallback' and count(parameter)=0]"
		[Register ("removeCallback", "()V", "GetRemoveCallbackHandler")]
		public virtual unsafe void RemoveCallback ()
		{
			if (id_removeCallback == IntPtr.Zero)
				id_removeCallback = JNIEnv.GetMethodID (class_ref, "removeCallback", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeCallback);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeCallback", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeMultipleOlderImages_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveMultipleOlderImages_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_removeMultipleOlderImages_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_removeMultipleOlderImages_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveMultipleOlderImages_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_);
			return cb_removeMultipleOlderImages_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_RemoveMultipleOlderImages_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMultipleOlderImages (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_removeMultipleOlderImages_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='removeMultipleOlderImages' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("removeMultipleOlderImages", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "GetRemoveMultipleOlderImages_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveMultipleOlderImages (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_removeMultipleOlderImages_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_removeMultipleOlderImages_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeMultipleOlderImages", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeMultipleOlderImages_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeMultipleOlderImages", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_resendMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
#pragma warning disable 0169
		static Delegate GetResendMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Handler ()
		{
			if (cb_resendMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ == null)
				cb_resendMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ResendMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_);
			return cb_resendMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
		}

		static int n_ResendMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ResendMessage (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_resendMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='resendMessage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageType']]"
		[Register ("resendMessage", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)I", "GetResendMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Handler")]
		public virtual unsafe int ResendMessage (string p0, string p1, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p2)
		{
			if (id_resendMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ == IntPtr.Zero)
				id_resendMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ = JNIEnv.GetMethodID (class_ref, "resendMessage", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_resendMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resendMessage", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_resendMessage_Ljava_lang_String_Ljava_lang_String_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
#pragma warning disable 0169
		static Delegate GetResendMessage_Ljava_lang_String_Ljava_lang_String_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Handler ()
		{
			if (cb_resendMessage_Ljava_lang_String_Ljava_lang_String_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ == null)
				cb_resendMessage_Ljava_lang_String_Ljava_lang_String_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr, int>) n_ResendMessage_Ljava_lang_String_Ljava_lang_String_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageType_);
			return cb_resendMessage_Ljava_lang_String_Ljava_lang_String_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
		}

		static int n_ResendMessage_Ljava_lang_String_Ljava_lang_String_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2, IntPtr native_p3)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p3 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (native_p3, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ResendMessage (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_resendMessage_Ljava_lang_String_Ljava_lang_String_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='resendMessage' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageType']]"
		[Register ("resendMessage", "(Ljava/lang/String;Ljava/lang/String;JLcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)I", "GetResendMessage_Ljava_lang_String_Ljava_lang_String_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Handler")]
		public virtual unsafe int ResendMessage (string p0, string p1, long p2, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p3)
		{
			if (id_resendMessage_Ljava_lang_String_Ljava_lang_String_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ == IntPtr.Zero)
				id_resendMessage_Ljava_lang_String_Ljava_lang_String_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ = JNIEnv.GetMethodID (class_ref, "resendMessage", "(Ljava/lang/String;Ljava/lang/String;JLcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_resendMessage_Ljava_lang_String_Ljava_lang_String_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageType_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resendMessage", "(Ljava/lang/String;Ljava/lang/String;JLcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_resolveConversation_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetResolveConversation_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_resolveConversation_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_resolveConversation_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ResolveConversation_Ljava_lang_String_Ljava_lang_String_);
			return cb_resolveConversation_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_ResolveConversation_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ResolveConversation (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_resolveConversation_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='resolveConversation' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("resolveConversation", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/messaging/ConversationActionFailedReason;", "GetResolveConversation_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.ConversationActionFailedReason ResolveConversation (string p0, string p1)
		{
			if (id_resolveConversation_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_resolveConversation_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "resolveConversation", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/messaging/ConversationActionFailedReason;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Liveperson.Messaging.ConversationActionFailedReason __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.ConversationActionFailedReason> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_resolveConversation_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.ConversationActionFailedReason> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resolveConversation", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/messaging/ConversationActionFailedReason;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_sendCSAT_Ljava_lang_String_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetSendCSAT_Ljava_lang_String_Ljava_lang_String_IIHandler ()
		{
			if (cb_sendCSAT_Ljava_lang_String_Ljava_lang_String_II == null)
				cb_sendCSAT_Ljava_lang_String_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_SendCSAT_Ljava_lang_String_Ljava_lang_String_II);
			return cb_sendCSAT_Ljava_lang_String_Ljava_lang_String_II;
		}

		static void n_SendCSAT_Ljava_lang_String_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendCSAT (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_sendCSAT_Ljava_lang_String_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='sendCSAT' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("sendCSAT", "(Ljava/lang/String;Ljava/lang/String;II)V", "GetSendCSAT_Ljava_lang_String_Ljava_lang_String_IIHandler")]
		public virtual unsafe void SendCSAT (string p0, string p1, int p2, int p3)
		{
			if (id_sendCSAT_Ljava_lang_String_Ljava_lang_String_II == IntPtr.Zero)
				id_sendCSAT_Ljava_lang_String_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "sendCSAT", "(Ljava/lang/String;Ljava/lang/String;II)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendCSAT_Ljava_lang_String_Ljava_lang_String_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendCSAT", "(Ljava/lang/String;Ljava/lang/String;II)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_sendDeliveryStatusUpdateCommand_Ljava_lang_String_Ljava_lang_String_ILcom_liveperson_api_response_types_DeliveryStatus_Lcom_liveperson_api_response_model_DeliveryStatusUpdateInfo_;
#pragma warning disable 0169
		static Delegate GetSendDeliveryStatusUpdateCommand_Ljava_lang_String_Ljava_lang_String_ILcom_liveperson_api_response_types_DeliveryStatus_Lcom_liveperson_api_response_model_DeliveryStatusUpdateInfo_Handler ()
		{
			if (cb_sendDeliveryStatusUpdateCommand_Ljava_lang_String_Ljava_lang_String_ILcom_liveperson_api_response_types_DeliveryStatus_Lcom_liveperson_api_response_model_DeliveryStatusUpdateInfo_ == null)
				cb_sendDeliveryStatusUpdateCommand_Ljava_lang_String_Ljava_lang_String_ILcom_liveperson_api_response_types_DeliveryStatus_Lcom_liveperson_api_response_model_DeliveryStatusUpdateInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SendDeliveryStatusUpdateCommand_Ljava_lang_String_Ljava_lang_String_ILcom_liveperson_api_response_types_DeliveryStatus_Lcom_liveperson_api_response_model_DeliveryStatusUpdateInfo_);
			return cb_sendDeliveryStatusUpdateCommand_Ljava_lang_String_Ljava_lang_String_ILcom_liveperson_api_response_types_DeliveryStatus_Lcom_liveperson_api_response_model_DeliveryStatusUpdateInfo_;
		}

		static void n_SendDeliveryStatusUpdateCommand_Ljava_lang_String_Ljava_lang_String_ILcom_liveperson_api_response_types_DeliveryStatus_Lcom_liveperson_api_response_model_DeliveryStatusUpdateInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Response.Types.DeliveryStatus p3 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.DeliveryStatus> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Response.Model.DeliveryStatusUpdateInfo p4 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.DeliveryStatusUpdateInfo> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.SendDeliveryStatusUpdateCommand (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_sendDeliveryStatusUpdateCommand_Ljava_lang_String_Ljava_lang_String_ILcom_liveperson_api_response_types_DeliveryStatus_Lcom_liveperson_api_response_model_DeliveryStatusUpdateInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='sendDeliveryStatusUpdateCommand' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='com.liveperson.api.response.types.DeliveryStatus'] and parameter[5][@type='com.liveperson.api.response.model.DeliveryStatusUpdateInfo']]"
		[Register ("sendDeliveryStatusUpdateCommand", "(Ljava/lang/String;Ljava/lang/String;ILcom/liveperson/api/response/types/DeliveryStatus;Lcom/liveperson/api/response/model/DeliveryStatusUpdateInfo;)V", "GetSendDeliveryStatusUpdateCommand_Ljava_lang_String_Ljava_lang_String_ILcom_liveperson_api_response_types_DeliveryStatus_Lcom_liveperson_api_response_model_DeliveryStatusUpdateInfo_Handler")]
		public virtual unsafe void SendDeliveryStatusUpdateCommand (string p0, string p1, int p2, global::Com.Liveperson.Api.Response.Types.DeliveryStatus p3, global::Com.Liveperson.Api.Response.Model.DeliveryStatusUpdateInfo p4)
		{
			if (id_sendDeliveryStatusUpdateCommand_Ljava_lang_String_Ljava_lang_String_ILcom_liveperson_api_response_types_DeliveryStatus_Lcom_liveperson_api_response_model_DeliveryStatusUpdateInfo_ == IntPtr.Zero)
				id_sendDeliveryStatusUpdateCommand_Ljava_lang_String_Ljava_lang_String_ILcom_liveperson_api_response_types_DeliveryStatus_Lcom_liveperson_api_response_model_DeliveryStatusUpdateInfo_ = JNIEnv.GetMethodID (class_ref, "sendDeliveryStatusUpdateCommand", "(Ljava/lang/String;Ljava/lang/String;ILcom/liveperson/api/response/types/DeliveryStatus;Lcom/liveperson/api/response/model/DeliveryStatusUpdateInfo;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendDeliveryStatusUpdateCommand_Ljava_lang_String_Ljava_lang_String_ILcom_liveperson_api_response_types_DeliveryStatus_Lcom_liveperson_api_response_model_DeliveryStatusUpdateInfo_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendDeliveryStatusUpdateCommand", "(Ljava/lang/String;Ljava/lang/String;ILcom/liveperson/api/response/types/DeliveryStatus;Lcom/liveperson/api/response/model/DeliveryStatusUpdateInfo;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_sendFileMessage_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSendFileMessage_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_sendFileMessage_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_sendFileMessage_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_SendFileMessage_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_sendFileMessage_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static void n_SendFileMessage_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, bool p5)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.SendFileMessage (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_sendFileMessage_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='sendFileMessage' and count(parameter)=6 and parameter[1][@type='com.liveperson.messaging.background.filesharing.FileSharingType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='boolean']]"
		[Register ("sendFileMessage", "(Lcom/liveperson/messaging/background/filesharing/FileSharingType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "GetSendFileMessage_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZHandler")]
		public virtual unsafe void SendFileMessage (global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType p0, string p1, string p2, string p3, string p4, bool p5)
		{
			if (id_sendFileMessage_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_sendFileMessage_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "sendFileMessage", "(Lcom/liveperson/messaging/background/filesharing/FileSharingType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendFileMessage_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendFileMessage", "(Lcom/liveperson/messaging/background/filesharing/FileSharingType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_sendFormSubmissionMessageCommand_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendFormSubmissionMessageCommand_Ljava_lang_String_Handler ()
		{
			if (cb_sendFormSubmissionMessageCommand_Ljava_lang_String_ == null)
				cb_sendFormSubmissionMessageCommand_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendFormSubmissionMessageCommand_Ljava_lang_String_);
			return cb_sendFormSubmissionMessageCommand_Ljava_lang_String_;
		}

		static void n_SendFormSubmissionMessageCommand_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendFormSubmissionMessageCommand (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendFormSubmissionMessageCommand_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='sendFormSubmissionMessageCommand' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sendFormSubmissionMessageCommand", "(Ljava/lang/String;)V", "GetSendFormSubmissionMessageCommand_Ljava_lang_String_Handler")]
		public virtual unsafe void SendFormSubmissionMessageCommand (string p0)
		{
			if (id_sendFormSubmissionMessageCommand_Ljava_lang_String_ == IntPtr.Zero)
				id_sendFormSubmissionMessageCommand_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendFormSubmissionMessageCommand", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendFormSubmissionMessageCommand_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendFormSubmissionMessageCommand", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_sendMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_sendMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_sendMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SendMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_sendMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='sendMessage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("sendMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSendMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SendMessage (string p0, string p1, string p2)
		{
			if (id_sendMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_sendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_sendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_sendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_sendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			string p7 = JNIEnv.GetString (native_p7, JniHandleOwnership.DoNotTransfer);
			__this.SendMessageWithURL (p0, p1, p2, p3, p4, p5, p6, p7);
		}
#pragma warning restore 0169

		static IntPtr id_sendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='sendMessageWithURL' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String']]"
		[Register ("sendMessageWithURL", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SendMessageWithURL (string p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7)
		{
			if (id_sendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendMessageWithURL", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			IntPtr native_p7 = JNIEnv.NewString (p7);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (native_p7);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendMessageWithURL", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
				JNIEnv.DeleteLocalRef (native_p7);
			}
		}

		static Delegate cb_sendUserProfile_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_;
#pragma warning disable 0169
		static Delegate GetSendUserProfile_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_Handler ()
		{
			if (cb_sendUserProfile_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_ == null)
				cb_sendUserProfile_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendUserProfile_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_);
			return cb_sendUserProfile_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_;
		}

		static void n_SendUserProfile_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.UserProfileBundle p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.UserProfileBundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendUserProfile (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendUserProfile_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='sendUserProfile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.messaging.model.UserProfileBundle']]"
		[Register ("sendUserProfile", "(Ljava/lang/String;Lcom/liveperson/messaging/model/UserProfileBundle;)V", "GetSendUserProfile_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_Handler")]
		public virtual unsafe void SendUserProfile (string p0, global::Com.Liveperson.Messaging.Model.UserProfileBundle p1)
		{
			if (id_sendUserProfile_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_ == IntPtr.Zero)
				id_sendUserProfile_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_ = JNIEnv.GetMethodID (class_ref, "sendUserProfile", "(Ljava/lang/String;Lcom/liveperson/messaging/model/UserProfileBundle;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendUserProfile_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendUserProfile", "(Ljava/lang/String;Lcom/liveperson/messaging/model/UserProfileBundle;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_serviceStarted_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetServiceStarted_Ljava_lang_String_Handler ()
		{
			if (cb_serviceStarted_Ljava_lang_String_ == null)
				cb_serviceStarted_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ServiceStarted_Ljava_lang_String_);
			return cb_serviceStarted_Ljava_lang_String_;
		}

		static void n_ServiceStarted_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ServiceStarted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_serviceStarted_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='serviceStarted' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("serviceStarted", "(Ljava/lang/String;)V", "GetServiceStarted_Ljava_lang_String_Handler")]
		public virtual unsafe void ServiceStarted (string p0)
		{
			if (id_serviceStarted_Ljava_lang_String_ == IntPtr.Zero)
				id_serviceStarted_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "serviceStarted", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_serviceStarted_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "serviceStarted", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_serviceStopped_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetServiceStopped_Ljava_lang_String_Handler ()
		{
			if (cb_serviceStopped_Ljava_lang_String_ == null)
				cb_serviceStopped_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ServiceStopped_Ljava_lang_String_);
			return cb_serviceStopped_Ljava_lang_String_;
		}

		static void n_ServiceStopped_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ServiceStopped (p0);
		}
#pragma warning restore 0169

		static IntPtr id_serviceStopped_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='serviceStopped' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("serviceStopped", "(Ljava/lang/String;)V", "GetServiceStopped_Ljava_lang_String_Handler")]
		public virtual unsafe void ServiceStopped (string p0)
		{
			if (id_serviceStopped_Ljava_lang_String_ == IntPtr.Zero)
				id_serviceStopped_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "serviceStopped", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_serviceStopped_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "serviceStopped", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setCallback_Lcom_liveperson_api_LivePersonCallback_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lcom_liveperson_api_LivePersonCallback_Handler ()
		{
			if (cb_setCallback_Lcom_liveperson_api_LivePersonCallback_ == null)
				cb_setCallback_Lcom_liveperson_api_LivePersonCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallback_Lcom_liveperson_api_LivePersonCallback_);
			return cb_setCallback_Lcom_liveperson_api_LivePersonCallback_;
		}

		static void n_SetCallback_Lcom_liveperson_api_LivePersonCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.ILivePersonCallback p0 = (global::Com.Liveperson.Api.ILivePersonCallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.ILivePersonCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCallback_Lcom_liveperson_api_LivePersonCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.liveperson.api.LivePersonCallback']]"
		[Register ("setCallback", "(Lcom/liveperson/api/LivePersonCallback;)V", "GetSetCallback_Lcom_liveperson_api_LivePersonCallback_Handler")]
		public virtual unsafe void SetCallback (global::Com.Liveperson.Api.ILivePersonCallback p0)
		{
			if (id_setCallback_Lcom_liveperson_api_LivePersonCallback_ == IntPtr.Zero)
				id_setCallback_Lcom_liveperson_api_LivePersonCallback_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lcom/liveperson/api/LivePersonCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCallback_Lcom_liveperson_api_LivePersonCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallback", "(Lcom/liveperson/api/LivePersonCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_;
#pragma warning disable 0169
		static Delegate GetShutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_Handler ()
		{
			if (cb_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ == null)
				cb_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_);
			return cb_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_;
		}

		static void n_ShutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener p0 = (global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShutDown (p0);
		}
#pragma warning restore 0169

		static IntPtr id_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='shutDown' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.shutdown.ShutDownCompletionListener']]"
		[Register ("shutDown", "(Lcom/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener;)V", "GetShutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_Handler")]
		public virtual unsafe void ShutDown (global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListener p0)
		{
			if (id_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ == IntPtr.Zero)
				id_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_ = JNIEnv.GetMethodID (class_ref, "shutDown", "(Lcom/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutDown_Lcom_liveperson_infra_sdkstatemachine_shutdown_ShutDownCompletionListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shutDown", "(Lcom/liveperson/infra/sdkstatemachine/shutdown/ShutDownCompletionListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_;
#pragma warning disable 0169
		static Delegate GetShutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_Handler ()
		{
			if (cb_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_ == null)
				cb_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_);
			return cb_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_;
		}

		static void n_ShutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.ShutDownProcess p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.ShutDownProcess> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShutDown (p0);
		}
#pragma warning restore 0169

		static IntPtr id_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='shutDown' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.ShutDownProcess']]"
		[Register ("shutDown", "(Lcom/liveperson/infra/statemachine/ShutDownProcess;)V", "GetShutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_Handler")]
		public virtual unsafe void ShutDown (global::Com.Liveperson.Infra.Statemachine.ShutDownProcess p0)
		{
			if (id_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_ == IntPtr.Zero)
				id_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_ = JNIEnv.GetMethodID (class_ref, "shutDown", "(Lcom/liveperson/infra/statemachine/ShutDownProcess;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shutDown", "(Lcom/liveperson/infra/statemachine/ShutDownProcess;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_unregisterPusher_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Z;
#pragma warning disable 0169
		static Delegate GetUnregisterPusher_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ZHandler ()
		{
			if (cb_unregisterPusher_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Z == null)
				cb_unregisterPusher_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_UnregisterPusher_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Z);
			return cb_unregisterPusher_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Z;
		}

		static void n_UnregisterPusher_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ICallback p2 = (global::Com.Liveperson.Infra.ICallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterPusher (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_unregisterPusher_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='unregisterPusher' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.infra.ICallback&lt;java.lang.Void, java.lang.Exception&gt;'] and parameter[4][@type='boolean']]"
		[Register ("unregisterPusher", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/ICallback;Z)V", "GetUnregisterPusher_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ZHandler")]
		public virtual unsafe void UnregisterPusher (string p0, string p1, global::Com.Liveperson.Infra.ICallback p2, bool p3)
		{
			if (id_unregisterPusher_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Z == IntPtr.Zero)
				id_unregisterPusher_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Z = JNIEnv.GetMethodID (class_ref, "unregisterPusher", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/ICallback;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterPusher_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregisterPusher", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/ICallback;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_;
#pragma warning disable 0169
		static Delegate GetUpdateMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Handler ()
		{
			if (cb_updateMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ == null)
				cb_updateMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_);
			return cb_updateMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_;
		}

		static void n_UpdateMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Liveperson.Messaging.Messaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState p3 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.UpdateMessage (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_updateMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='Messaging']/method[@name='updateMessage' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageType'] and parameter[4][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageState']]"
		[Register ("updateMessage", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;)V", "GetUpdateMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Handler")]
		public virtual unsafe void UpdateMessage (string p0, string p1, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p2, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState p3)
		{
			if (id_updateMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ == IntPtr.Zero)
				id_updateMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ = JNIEnv.GetMethodID (class_ref, "updateMessage", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateMessage", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
