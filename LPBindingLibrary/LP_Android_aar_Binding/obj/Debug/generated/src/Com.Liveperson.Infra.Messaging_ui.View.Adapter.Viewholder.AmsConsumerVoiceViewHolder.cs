using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerVoiceViewHolder']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsConsumerVoiceViewHolder", DoNotGenerateAcw=true)]
	public partial class AmsConsumerVoiceViewHolder : global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsDownloadableFileViewHolder, global::Com.Liveperson.Infra.Controller.IAudioPlayable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerVoiceViewHolder']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "AmsConsumerVoiceViewHolder";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsConsumerVoiceViewHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsConsumerVoiceViewHolder); }
		}

		protected AmsConsumerVoiceViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerVoiceViewHolder']/constructor[@name='AmsConsumerVoiceViewHolder' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageType'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/view/View;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;Ljava/lang/String;)V", "")]
		public unsafe AmsConsumerVoiceViewHolder (global::Android.Views.View p0, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (AmsConsumerVoiceViewHolder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/view/View;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/view/View;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_view_View_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_view_View_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_view_View_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
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
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerVoiceViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerVoiceViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCompletedAction ();
		}
#pragma warning restore 0169

		static IntPtr id_onCompletedAction;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerVoiceViewHolder']/method[@name='onCompletedAction' and count(parameter)=0]"
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
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerVoiceViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerVoiceViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNotStartedAction ();
		}
#pragma warning restore 0169

		static IntPtr id_onNotStartedAction;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerVoiceViewHolder']/method[@name='onNotStartedAction' and count(parameter)=0]"
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
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerVoiceViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerVoiceViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRequestingUrlAction ();
		}
#pragma warning restore 0169

		static IntPtr id_onRequestingUrlAction;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerVoiceViewHolder']/method[@name='onRequestingUrlAction' and count(parameter)=0]"
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

		static Delegate cb_playVoiceMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPlayVoiceMessage_Ljava_lang_String_Handler ()
		{
			if (cb_playVoiceMessage_Ljava_lang_String_ == null)
				cb_playVoiceMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PlayVoiceMessage_Ljava_lang_String_);
			return cb_playVoiceMessage_Ljava_lang_String_;
		}

		static void n_PlayVoiceMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerVoiceViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerVoiceViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PlayVoiceMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_playVoiceMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerVoiceViewHolder']/method[@name='playVoiceMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("playVoiceMessage", "(Ljava/lang/String;)V", "GetPlayVoiceMessage_Ljava_lang_String_Handler")]
		public virtual unsafe void PlayVoiceMessage (string p0)
		{
			if (id_playVoiceMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_playVoiceMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "playVoiceMessage", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_playVoiceMessage_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "playVoiceMessage", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setCurrentPlaying_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetSetCurrentPlaying_Ljava_lang_String_IIHandler ()
		{
			if (cb_setCurrentPlaying_Ljava_lang_String_II == null)
				cb_setCurrentPlaying_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_SetCurrentPlaying_Ljava_lang_String_II);
			return cb_setCurrentPlaying_Ljava_lang_String_II;
		}

		static void n_SetCurrentPlaying_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerVoiceViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerVoiceViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCurrentPlaying (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setCurrentPlaying_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerVoiceViewHolder']/method[@name='setCurrentPlaying' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("setCurrentPlaying", "(Ljava/lang/String;II)V", "GetSetCurrentPlaying_Ljava_lang_String_IIHandler")]
		public virtual unsafe void SetCurrentPlaying (string p0, int p1, int p2)
		{
			if (id_setCurrentPlaying_Ljava_lang_String_II == IntPtr.Zero)
				id_setCurrentPlaying_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "setCurrentPlaying", "(Ljava/lang/String;II)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCurrentPlaying_Ljava_lang_String_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurrentPlaying", "(Ljava/lang/String;II)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setVoiceProperties_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_infra_database_tables_FilesTable_LoadStatus_;
#pragma warning disable 0169
		static Delegate GetSetVoiceProperties_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_infra_database_tables_FilesTable_LoadStatus_Handler ()
		{
			if (cb_setVoiceProperties_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ == null)
				cb_setVoiceProperties_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long, long, IntPtr>) n_SetVoiceProperties_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_infra_database_tables_FilesTable_LoadStatus_);
			return cb_setVoiceProperties_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_infra_database_tables_FilesTable_LoadStatus_;
		}

		static void n_SetVoiceProperties_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2, long p3, IntPtr native_p4)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerVoiceViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerVoiceViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus p4 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.SetVoiceProperties (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_setVoiceProperties_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_infra_database_tables_FilesTable_LoadStatus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerVoiceViewHolder']/method[@name='setVoiceProperties' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='com.liveperson.infra.database.tables.FilesTable.LoadStatus']]"
		[Register ("setVoiceProperties", "(Ljava/lang/String;Ljava/lang/String;JJLcom/liveperson/infra/database/tables/FilesTable$LoadStatus;)V", "GetSetVoiceProperties_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_infra_database_tables_FilesTable_LoadStatus_Handler")]
		public virtual unsafe void SetVoiceProperties (string p0, string p1, long p2, long p3, global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus p4)
		{
			if (id_setVoiceProperties_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ == IntPtr.Zero)
				id_setVoiceProperties_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_infra_database_tables_FilesTable_LoadStatus_ = JNIEnv.GetMethodID (class_ref, "setVoiceProperties", "(Ljava/lang/String;Ljava/lang/String;JJLcom/liveperson/infra/database/tables/FilesTable$LoadStatus;)V");
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
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVoiceProperties_Ljava_lang_String_Ljava_lang_String_JJLcom_liveperson_infra_database_tables_FilesTable_LoadStatus_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVoiceProperties", "(Ljava/lang/String;Ljava/lang/String;JJLcom/liveperson/infra/database/tables/FilesTable$LoadStatus;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_stopPlaying;
#pragma warning disable 0169
		static Delegate GetStopPlayingHandler ()
		{
			if (cb_stopPlaying == null)
				cb_stopPlaying = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopPlaying);
			return cb_stopPlaying;
		}

		static void n_StopPlaying (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerVoiceViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerVoiceViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopPlaying ();
		}
#pragma warning restore 0169

		static IntPtr id_stopPlaying;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerVoiceViewHolder']/method[@name='stopPlaying' and count(parameter)=0]"
		[Register ("stopPlaying", "()V", "GetStopPlayingHandler")]
		public virtual unsafe void StopPlaying ()
		{
			if (id_stopPlaying == IntPtr.Zero)
				id_stopPlaying = JNIEnv.GetMethodID (class_ref, "stopPlaying", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopPlaying);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopPlaying", "()V"));
			} finally {
			}
		}

	}
}
