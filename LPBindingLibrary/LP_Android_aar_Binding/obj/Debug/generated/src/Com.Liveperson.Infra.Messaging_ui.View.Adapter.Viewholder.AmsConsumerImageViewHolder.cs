using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerImageViewHolder']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsConsumerImageViewHolder", DoNotGenerateAcw=true)]
	public partial class AmsConsumerImageViewHolder : global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsDownloadableFileViewHolder {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerImageViewHolder']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr mMessageImageView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerImageViewHolder']/field[@name='mMessageImageView']"
		[Register ("mMessageImageView")]
		protected global::Android.Widget.ImageView MMessageImageView {
			get {
				if (mMessageImageView_jfieldId == IntPtr.Zero)
					mMessageImageView_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessageImageView", "Landroid/widget/ImageView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMessageImageView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMessageImageView_jfieldId == IntPtr.Zero)
					mMessageImageView_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessageImageView", "Landroid/widget/ImageView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMessageImageView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsConsumerImageViewHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsConsumerImageViewHolder); }
		}

		protected AmsConsumerImageViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerImageViewHolder']/constructor[@name='AmsConsumerImageViewHolder' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageType']]"
		[Register (".ctor", "(Landroid/view/View;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)V", "")]
		public unsafe AmsConsumerImageViewHolder (global::Android.Views.View p0, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (AmsConsumerImageViewHolder)) {
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
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerImageViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerImageViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCompletedAction ();
		}
#pragma warning restore 0169

		static IntPtr id_onCompletedAction;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerImageViewHolder']/method[@name='onCompletedAction' and count(parameter)=0]"
		[Register ("onCompletedAction", "()V", "GetOnCompletedActionHandler")]
		protected override unsafe void OnCompletedAction ()
		{
			if (id_onCompletedAction == IntPtr.Zero)
				id_onCompletedAction = JNIEnv.GetMethodID (class_ref, "onCompletedAction", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCompletedAction);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCompletedAction", "()V"));
			} finally {
			}
		}

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
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerImageViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerImageViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNotStartedAction ();
		}
#pragma warning restore 0169

		static IntPtr id_onNotStartedAction;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerImageViewHolder']/method[@name='onNotStartedAction' and count(parameter)=0]"
		[Register ("onNotStartedAction", "()V", "GetOnNotStartedActionHandler")]
		protected override unsafe void OnNotStartedAction ()
		{
			if (id_onNotStartedAction == IntPtr.Zero)
				id_onNotStartedAction = JNIEnv.GetMethodID (class_ref, "onNotStartedAction", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNotStartedAction);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNotStartedAction", "()V"));
			} finally {
			}
		}

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
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerImageViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerImageViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRequestingUrlAction ();
		}
#pragma warning restore 0169

		static IntPtr id_onRequestingUrlAction;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerImageViewHolder']/method[@name='onRequestingUrlAction' and count(parameter)=0]"
		[Register ("onRequestingUrlAction", "()V", "GetOnRequestingUrlActionHandler")]
		protected override unsafe void OnRequestingUrlAction ()
		{
			if (id_onRequestingUrlAction == IntPtr.Zero)
				id_onRequestingUrlAction = JNIEnv.GetMethodID (class_ref, "onRequestingUrlAction", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRequestingUrlAction);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRequestingUrlAction", "()V"));
			} finally {
			}
		}

		static Delegate cb_setImageClickListener_Landroid_view_View_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetImageClickListener_Landroid_view_View_OnClickListener_Handler ()
		{
			if (cb_setImageClickListener_Landroid_view_View_OnClickListener_ == null)
				cb_setImageClickListener_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageClickListener_Landroid_view_View_OnClickListener_);
			return cb_setImageClickListener_Landroid_view_View_OnClickListener_;
		}

		static void n_SetImageClickListener_Landroid_view_View_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerImageViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerImageViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View.IOnClickListener p0 = (global::Android.Views.View.IOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetImageClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setImageClickListener_Landroid_view_View_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerImageViewHolder']/method[@name='setImageClickListener' and count(parameter)=1 and parameter[1][@type='android.view.View.OnClickListener']]"
		[Register ("setImageClickListener", "(Landroid/view/View$OnClickListener;)V", "GetSetImageClickListener_Landroid_view_View_OnClickListener_Handler")]
		public virtual unsafe void SetImageClickListener (global::Android.Views.View.IOnClickListener p0)
		{
			if (id_setImageClickListener_Landroid_view_View_OnClickListener_ == IntPtr.Zero)
				id_setImageClickListener_Landroid_view_View_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setImageClickListener", "(Landroid/view/View$OnClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImageClickListener_Landroid_view_View_OnClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageClickListener", "(Landroid/view/View$OnClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMessageImage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_;
#pragma warning disable 0169
		static Delegate GetSetMessageImage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_Handler ()
		{
			if (cb_setMessageImage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ == null)
				cb_setMessageImage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMessageImage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_);
			return cb_setMessageImage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_;
		}

		static void n_SetMessageImage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerImageViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerImageViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetMessageImage (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setMessageImage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerImageViewHolder']/method[@name='setMessageImage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.infra.database.tables.FilesTable.LoadStatus']]"
		[Register ("setMessageImage", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;)V", "GetSetMessageImage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_Handler")]
		public virtual unsafe void SetMessageImage (string p0, string p1, global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus p2)
		{
			if (id_setMessageImage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ == IntPtr.Zero)
				id_setMessageImage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ = JNIEnv.GetMethodID (class_ref, "setMessageImage", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessageImage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_database_tables_FilesTable_LoadStatus_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageImage", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
