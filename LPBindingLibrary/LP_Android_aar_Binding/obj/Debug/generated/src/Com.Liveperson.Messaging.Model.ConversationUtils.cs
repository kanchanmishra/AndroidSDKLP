using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationUtils']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/model/ConversationUtils", DoNotGenerateAcw=true)]
	public partial class ConversationUtils : global::Java.Lang.Object {


		static IntPtr mController_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationUtils']/field[@name='mController']"
		[Register ("mController")]
		protected global::Com.Liveperson.Messaging.Messaging MController {
			get {
				if (mController_jfieldId == IntPtr.Zero)
					mController_jfieldId = JNIEnv.GetFieldID (class_ref, "mController", "Lcom/liveperson/messaging/Messaging;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mController_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mController_jfieldId == IntPtr.Zero)
					mController_jfieldId = JNIEnv.GetFieldID (class_ref, "mController", "Lcom/liveperson/messaging/Messaging;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mController_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/model/ConversationUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConversationUtils); }
		}

		protected ConversationUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_Messaging_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationUtils']/constructor[@name='ConversationUtils' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.Messaging']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/Messaging;)V", "")]
		public unsafe ConversationUtils (global::Com.Liveperson.Messaging.Messaging p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ConversationUtils)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/Messaging;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/Messaging;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_Messaging_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_Messaging_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/Messaging;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_, __args);
			} finally {
			}
		}

		static Delegate cb_addFirstMessage_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddFirstMessage_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addFirstMessage_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addFirstMessage_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddFirstMessage_Ljava_lang_String_Ljava_lang_String_);
			return cb_addFirstMessage_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddFirstMessage_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Model.ConversationUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.ConversationUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddFirstMessage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addFirstMessage_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationUtils']/method[@name='addFirstMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addFirstMessage", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddFirstMessage_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void AddFirstMessage (string p0, string p1)
		{
			if (id_addFirstMessage_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addFirstMessage_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addFirstMessage", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFirstMessage_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFirstMessage", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_addResolvedMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_CloseReason_JZLcom_liveperson_infra_ICallback_;
#pragma warning disable 0169
		static Delegate GetAddResolvedMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_CloseReason_JZLcom_liveperson_infra_ICallback_Handler ()
		{
			if (cb_addResolvedMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_CloseReason_JZLcom_liveperson_infra_ICallback_ == null)
				cb_addResolvedMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_CloseReason_JZLcom_liveperson_infra_ICallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long, bool, IntPtr>) n_AddResolvedMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_CloseReason_JZLcom_liveperson_infra_ICallback_);
			return cb_addResolvedMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_CloseReason_JZLcom_liveperson_infra_ICallback_;
		}

		static void n_AddResolvedMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_CloseReason_JZLcom_liveperson_infra_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, long p4, bool p5, IntPtr native_p6)
		{
			global::Com.Liveperson.Messaging.Model.ConversationUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.ConversationUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Response.Types.CloseReason p3 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CloseReason> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ICallback p6 = (global::Com.Liveperson.Infra.ICallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (native_p6, JniHandleOwnership.DoNotTransfer);
			__this.AddResolvedMessage (p0, p1, p2, p3, p4, p5, p6);
		}
#pragma warning restore 0169

		static IntPtr id_addResolvedMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_CloseReason_JZLcom_liveperson_infra_ICallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationUtils']/method[@name='addResolvedMessage' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.liveperson.api.response.types.CloseReason'] and parameter[5][@type='long'] and parameter[6][@type='boolean'] and parameter[7][@type='com.liveperson.infra.ICallback']]"
		[Register ("addResolvedMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/types/CloseReason;JZLcom/liveperson/infra/ICallback;)V", "GetAddResolvedMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_CloseReason_JZLcom_liveperson_infra_ICallback_Handler")]
		public virtual unsafe void AddResolvedMessage (string p0, string p1, string p2, global::Com.Liveperson.Api.Response.Types.CloseReason p3, long p4, bool p5, global::Com.Liveperson.Infra.ICallback p6)
		{
			if (id_addResolvedMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_CloseReason_JZLcom_liveperson_infra_ICallback_ == IntPtr.Zero)
				id_addResolvedMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_CloseReason_JZLcom_liveperson_infra_ICallback_ = JNIEnv.GetMethodID (class_ref, "addResolvedMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/types/CloseReason;JZLcom/liveperson/infra/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addResolvedMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_CloseReason_JZLcom_liveperson_infra_ICallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addResolvedMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/types/CloseReason;JZLcom/liveperson/infra/ICallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_calculateEffectiveTTR_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJ;
#pragma warning disable 0169
		static Delegate GetCalculateEffectiveTTR_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJHandler ()
		{
			if (cb_calculateEffectiveTTR_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJ == null)
				cb_calculateEffectiveTTR_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, long, long, long, long>) n_CalculateEffectiveTTR_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJ);
			return cb_calculateEffectiveTTR_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJ;
		}

		static long n_CalculateEffectiveTTR_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2, long p3, long p4)
		{
			global::Com.Liveperson.Messaging.Model.ConversationUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.ConversationUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Response.Types.TTRType p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.TTRType> (native_p1, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.CalculateEffectiveTTR (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_calculateEffectiveTTR_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationUtils']/method[@name='calculateEffectiveTTR' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.api.response.types.TTRType'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='long']]"
		[Register ("calculateEffectiveTTR", "(Ljava/lang/String;Lcom/liveperson/api/response/types/TTRType;JJJ)J", "GetCalculateEffectiveTTR_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJHandler")]
		public virtual unsafe long CalculateEffectiveTTR (string p0, global::Com.Liveperson.Api.Response.Types.TTRType p1, long p2, long p3, long p4)
		{
			if (id_calculateEffectiveTTR_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJ == IntPtr.Zero)
				id_calculateEffectiveTTR_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJ = JNIEnv.GetMethodID (class_ref, "calculateEffectiveTTR", "(Ljava/lang/String;Lcom/liveperson/api/response/types/TTRType;JJJ)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_calculateEffectiveTTR_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_JJJ, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calculateEffectiveTTR", "(Ljava/lang/String;Lcom/liveperson/api/response/types/TTRType;JJJ)J"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getResolveTextMessage_Ljava_lang_String_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetResolveTextMessage_Ljava_lang_String_JLjava_lang_String_Handler ()
		{
			if (cb_getResolveTextMessage_Ljava_lang_String_JLjava_lang_String_ == null)
				cb_getResolveTextMessage_Ljava_lang_String_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr>) n_GetResolveTextMessage_Ljava_lang_String_JLjava_lang_String_);
			return cb_getResolveTextMessage_Ljava_lang_String_JLjava_lang_String_;
		}

		static IntPtr n_GetResolveTextMessage_Ljava_lang_String_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.Model.ConversationUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.ConversationUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetResolveTextMessage (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getResolveTextMessage_Ljava_lang_String_JLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationUtils']/method[@name='getResolveTextMessage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String']]"
		[Register ("getResolveTextMessage", "(Ljava/lang/String;JLjava/lang/String;)Ljava/lang/String;", "GetGetResolveTextMessage_Ljava_lang_String_JLjava_lang_String_Handler")]
		protected virtual unsafe string GetResolveTextMessage (string p0, long p1, string p2)
		{
			if (id_getResolveTextMessage_Ljava_lang_String_JLjava_lang_String_ == IntPtr.Zero)
				id_getResolveTextMessage_Ljava_lang_String_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getResolveTextMessage", "(Ljava/lang/String;JLjava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResolveTextMessage_Ljava_lang_String_JLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResolveTextMessage", "(Ljava/lang/String;JLjava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_showTTR_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationUtils']/method[@name='showTTR' and count(parameter)=2 and parameter[1][@type='com.liveperson.messaging.Messaging'] and parameter[2][@type='java.lang.String']]"
		[Register ("showTTR", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;)V", "")]
		public static unsafe void ShowTTR (global::Com.Liveperson.Messaging.Messaging p0, string p1)
		{
			if (id_showTTR_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_ == IntPtr.Zero)
				id_showTTR_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "showTTR", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_showTTR_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateParticipants_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_Ljava_lang_String_ZZ;
#pragma warning disable 0169
		static Delegate GetUpdateParticipants_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_Ljava_lang_String_ZZHandler ()
		{
			if (cb_updateParticipants_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_Ljava_lang_String_ZZ == null)
				cb_updateParticipants_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_Ljava_lang_String_ZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, bool>) n_UpdateParticipants_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_Ljava_lang_String_ZZ);
			return cb_updateParticipants_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_Ljava_lang_String_ZZ;
		}

		static void n_UpdateParticipants_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_Ljava_lang_String_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, bool p5, bool p6)
		{
			global::Com.Liveperson.Messaging.Model.ConversationUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.ConversationUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string[] p2 = (string[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (string));
			global::Com.Liveperson.Api.Response.Model.UserProfile.UserType p3 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile.UserType> (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.UpdateParticipants (p0, p1, p2, p3, p4, p5, p6);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_updateParticipants_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_Ljava_lang_String_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationUtils']/method[@name='updateParticipants' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='com.liveperson.api.response.model.UserProfile.UserType'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean']]"
		[Register ("updateParticipants", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Lcom/liveperson/api/response/model/UserProfile$UserType;Ljava/lang/String;ZZ)V", "GetUpdateParticipants_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_Ljava_lang_String_ZZHandler")]
		public virtual unsafe void UpdateParticipants (string p0, string p1, string[] p2, global::Com.Liveperson.Api.Response.Model.UserProfile.UserType p3, string p4, bool p5, bool p6)
		{
			if (id_updateParticipants_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_Ljava_lang_String_ZZ == IntPtr.Zero)
				id_updateParticipants_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_Ljava_lang_String_ZZ = JNIEnv.GetMethodID (class_ref, "updateParticipants", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Lcom/liveperson/api/response/model/UserProfile$UserType;Ljava/lang/String;ZZ)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateParticipants_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_Ljava_lang_String_ZZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateParticipants", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Lcom/liveperson/api/response/model/UserProfile$UserType;Ljava/lang/String;ZZ)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_updateParticipants_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_Ljava_lang_String_ZZLcom_liveperson_infra_ICallback_;
#pragma warning disable 0169
		static Delegate GetUpdateParticipants_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_Ljava_lang_String_ZZLcom_liveperson_infra_ICallback_Handler ()
		{
			if (cb_updateParticipants_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_Ljava_lang_String_ZZLcom_liveperson_infra_ICallback_ == null)
				cb_updateParticipants_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_Ljava_lang_String_ZZLcom_liveperson_infra_ICallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, bool, IntPtr>) n_UpdateParticipants_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_Ljava_lang_String_ZZLcom_liveperson_infra_ICallback_);
			return cb_updateParticipants_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_Ljava_lang_String_ZZLcom_liveperson_infra_ICallback_;
		}

		static void n_UpdateParticipants_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_Ljava_lang_String_ZZLcom_liveperson_infra_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, bool p5, bool p6, IntPtr native_p7)
		{
			global::Com.Liveperson.Messaging.Model.ConversationUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.ConversationUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string[] p2 = (string[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (string));
			global::Com.Liveperson.Api.Response.Model.UserProfile.UserType p3 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.UserProfile.UserType> (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ICallback p7 = (global::Com.Liveperson.Infra.ICallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (native_p7, JniHandleOwnership.DoNotTransfer);
			__this.UpdateParticipants (p0, p1, p2, p3, p4, p5, p6, p7);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_updateParticipants_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_Ljava_lang_String_ZZLcom_liveperson_infra_ICallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationUtils']/method[@name='updateParticipants' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='com.liveperson.api.response.model.UserProfile.UserType'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean'] and parameter[8][@type='com.liveperson.infra.ICallback&lt;com.liveperson.messaging.model.MessagingUserProfile, java.lang.Exception&gt;']]"
		[Register ("updateParticipants", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Lcom/liveperson/api/response/model/UserProfile$UserType;Ljava/lang/String;ZZLcom/liveperson/infra/ICallback;)V", "GetUpdateParticipants_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_Ljava_lang_String_ZZLcom_liveperson_infra_ICallback_Handler")]
		public virtual unsafe void UpdateParticipants (string p0, string p1, string[] p2, global::Com.Liveperson.Api.Response.Model.UserProfile.UserType p3, string p4, bool p5, bool p6, global::Com.Liveperson.Infra.ICallback p7)
		{
			if (id_updateParticipants_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_Ljava_lang_String_ZZLcom_liveperson_infra_ICallback_ == IntPtr.Zero)
				id_updateParticipants_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_Ljava_lang_String_ZZLcom_liveperson_infra_ICallback_ = JNIEnv.GetMethodID (class_ref, "updateParticipants", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Lcom/liveperson/api/response/model/UserProfile$UserType;Ljava/lang/String;ZZLcom/liveperson/infra/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateParticipants_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Lcom_liveperson_api_response_model_UserProfile_UserType_Ljava_lang_String_ZZLcom_liveperson_infra_ICallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateParticipants", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Lcom/liveperson/api/response/model/UserProfile$UserType;Ljava/lang/String;ZZLcom/liveperson/infra/ICallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_updateTTR_Lcom_liveperson_api_response_types_TTRType_JJLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateTTR_Lcom_liveperson_api_response_types_TTRType_JJLjava_lang_String_Handler ()
		{
			if (cb_updateTTR_Lcom_liveperson_api_response_types_TTRType_JJLjava_lang_String_ == null)
				cb_updateTTR_Lcom_liveperson_api_response_types_TTRType_JJLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, long, IntPtr>) n_UpdateTTR_Lcom_liveperson_api_response_types_TTRType_JJLjava_lang_String_);
			return cb_updateTTR_Lcom_liveperson_api_response_types_TTRType_JJLjava_lang_String_;
		}

		static void n_UpdateTTR_Lcom_liveperson_api_response_types_TTRType_JJLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2, IntPtr native_p3)
		{
			global::Com.Liveperson.Messaging.Model.ConversationUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.ConversationUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Response.Types.TTRType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.TTRType> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.UpdateTTR (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_updateTTR_Lcom_liveperson_api_response_types_TTRType_JJLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='ConversationUtils']/method[@name='updateTTR' and count(parameter)=4 and parameter[1][@type='com.liveperson.api.response.types.TTRType'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String']]"
		[Register ("updateTTR", "(Lcom/liveperson/api/response/types/TTRType;JJLjava/lang/String;)V", "GetUpdateTTR_Lcom_liveperson_api_response_types_TTRType_JJLjava_lang_String_Handler")]
		public virtual unsafe void UpdateTTR (global::Com.Liveperson.Api.Response.Types.TTRType p0, long p1, long p2, string p3)
		{
			if (id_updateTTR_Lcom_liveperson_api_response_types_TTRType_JJLjava_lang_String_ == IntPtr.Zero)
				id_updateTTR_Lcom_liveperson_api_response_types_TTRType_JJLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateTTR", "(Lcom/liveperson/api/response/types/TTRType;JJLjava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateTTR_Lcom_liveperson_api_response_types_TTRType_JJLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateTTR", "(Lcom/liveperson/api/response/types/TTRType;JJLjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}
}
