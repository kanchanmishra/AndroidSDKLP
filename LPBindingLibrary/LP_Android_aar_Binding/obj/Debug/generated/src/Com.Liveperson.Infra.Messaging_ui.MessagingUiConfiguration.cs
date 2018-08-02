using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='MessagingUiConfiguration']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/MessagingUiConfiguration", DoNotGenerateAcw=true)]
	public partial class MessagingUiConfiguration : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='MessagingUiConfiguration']/field[@name='CLEAR_HISTORY_SHOW_CONFIRM_DIALOG']"
		[Register ("CLEAR_HISTORY_SHOW_CONFIRM_DIALOG")]
		public const string ClearHistoryShowConfirmDialog = (string) "clear_history_hide_confirm_dialog";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='MessagingUiConfiguration']/field[@name='CONTEXTUAL_MENU_ON_TOOLBAR']"
		[Register ("CONTEXTUAL_MENU_ON_TOOLBAR")]
		public const string ContextualMenuOnToolbar = (string) "contextual_menu_on_toolbar";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='MessagingUiConfiguration']/field[@name='DISABLE_TTR_POPUP']"
		[Register ("DISABLE_TTR_POPUP")]
		public const string DisableTtrPopup = (string) "disableTTRPopup";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='MessagingUiConfiguration']/field[@name='ENABLE_PHOTO_SHARING']"
		[Register ("ENABLE_PHOTO_SHARING")]
		public const string EnablePhotoSharing = (string) "enable_photo_sharing";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='MessagingUiConfiguration']/field[@name='SHOW_AGENT_DETAILS_CSAT']"
		[Register ("SHOW_AGENT_DETAILS_CSAT")]
		public const string ShowAgentDetailsCsat = (string) "show_agent_details_csat";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='MessagingUiConfiguration']/field[@name='SHOW_CSAT_THANK_YOU']"
		[Register ("SHOW_CSAT_THANK_YOU")]
		public const string ShowCsatThankYou = (string) "show_csat_thank_you";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='MessagingUiConfiguration']/field[@name='SHOW_FEEDBACK']"
		[Register ("SHOW_FEEDBACK")]
		public const string ShowFeedback = (string) "show_feedback";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='MessagingUiConfiguration']/field[@name='SHOW_TIMESTAMP_IN_TTR_NOTIFICATION']"
		[Register ("SHOW_TIMESTAMP_IN_TTR_NOTIFICATION")]
		public const string ShowTimestampInTtrNotification = (string) "show_timestamp_in_ttr_notification";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='MessagingUiConfiguration']/field[@name='SHOW_YES_NO_QUESTION']"
		[Register ("SHOW_YES_NO_QUESTION")]
		public const string ShowYesNoQuestion = (string) "show_yes_no_question";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='MessagingUiConfiguration']/field[@name='TTR_MESSAGE_OFF_HOURS_ENABLED']"
		[Register ("TTR_MESSAGE_OFF_HOURS_ENABLED")]
		public const string TtrMessageOffHoursEnabled = (string) "ttr_message_off_hours_enabled";

		public static class InterfaceConsts {

			// The following are fields from: com.liveperson.infra.IConfiguration

			static IntPtr mFeaturesMap_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/interface[@name='IConfiguration']/field[@name='mFeaturesMap']"
			[Register ("mFeaturesMap")]
			public static global::System.Collections.IDictionary MFeaturesMap {
				get {
					if (mFeaturesMap_jfieldId == IntPtr.Zero)
						mFeaturesMap_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mFeaturesMap", "Ljava/util/HashMap;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, mFeaturesMap_jfieldId);
					return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/MessagingUiConfiguration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessagingUiConfiguration); }
		}

		protected MessagingUiConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_HashMap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='MessagingUiConfiguration']/constructor[@name='MessagingUiConfiguration' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.Boolean&gt;']]"
		[Register (".ctor", "(Ljava/util/HashMap;)V", "")]
		public unsafe MessagingUiConfiguration (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Boolean> p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (MessagingUiConfiguration)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/HashMap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/HashMap;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_HashMap_ == IntPtr.Zero)
					id_ctor_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/HashMap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_HashMap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_HashMap_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAllFeatures;
#pragma warning disable 0169
		static Delegate GetGetAllFeaturesHandler ()
		{
			if (cb_getAllFeatures == null)
				cb_getAllFeatures = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllFeatures);
			return cb_getAllFeatures;
		}

		static IntPtr n_GetAllFeatures (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.MessagingUiConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.MessagingUiConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.ToLocalJniHandle (__this.AllFeatures);
		}
#pragma warning restore 0169

		static IntPtr id_getAllFeatures;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Boolean> AllFeatures {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='MessagingUiConfiguration']/method[@name='getAllFeatures' and count(parameter)=0]"
			[Register ("getAllFeatures", "()Ljava/util/HashMap;", "GetGetAllFeaturesHandler")]
			get {
				if (id_getAllFeatures == IntPtr.Zero)
					id_getAllFeatures = JNIEnv.GetMethodID (class_ref, "getAllFeatures", "()Ljava/util/HashMap;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllFeatures), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllFeatures", "()Ljava/util/HashMap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFeature_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFeature_Ljava_lang_String_Handler ()
		{
			if (cb_getFeature_Ljava_lang_String_ == null)
				cb_getFeature_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetFeature_Ljava_lang_String_);
			return cb_getFeature_Ljava_lang_String_;
		}

		static bool n_GetFeature_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.MessagingUiConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.MessagingUiConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetFeature (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getFeature_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='MessagingUiConfiguration']/method[@name='getFeature' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFeature", "(Ljava/lang/String;)Z", "GetGetFeature_Ljava_lang_String_Handler")]
		public virtual unsafe bool GetFeature (string p0)
		{
			if (id_getFeature_Ljava_lang_String_ == IntPtr.Zero)
				id_getFeature_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getFeature", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getFeature_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFeature", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putFeature_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetPutFeature_Ljava_lang_String_ZHandler ()
		{
			if (cb_putFeature_Ljava_lang_String_Z == null)
				cb_putFeature_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_PutFeature_Ljava_lang_String_Z);
			return cb_putFeature_Ljava_lang_String_Z;
		}

		static void n_PutFeature_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.MessagingUiConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.MessagingUiConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutFeature (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_putFeature_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui']/class[@name='MessagingUiConfiguration']/method[@name='putFeature' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("putFeature", "(Ljava/lang/String;Z)V", "GetPutFeature_Ljava_lang_String_ZHandler")]
		public virtual unsafe void PutFeature (string p0, bool p1)
		{
			if (id_putFeature_Ljava_lang_String_Z == IntPtr.Zero)
				id_putFeature_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "putFeature", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putFeature_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putFeature", "(Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
