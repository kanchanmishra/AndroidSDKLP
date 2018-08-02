using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Request.Message {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='FormSubmissionPublishMessage']"
	[global::Android.Runtime.Register ("com/liveperson/api/request/message/FormSubmissionPublishMessage", DoNotGenerateAcw=true)]
	public partial class FormSubmissionPublishMessage : global::Com.Liveperson.Api.Request.Message.BasePublishMessage {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='FormSubmissionPublishMessage']/field[@name='SUBMISSION_ID']"
		[Register ("SUBMISSION_ID")]
		public const string SubmissionId = (string) "submissionId";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/request/message/FormSubmissionPublishMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FormSubmissionPublishMessage); }
		}

		protected FormSubmissionPublishMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='FormSubmissionPublishMessage']/constructor[@name='FormSubmissionPublishMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe FormSubmissionPublishMessage (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (FormSubmissionPublishMessage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='FormSubmissionPublishMessage']/constructor[@name='FormSubmissionPublishMessage' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe FormSubmissionPublishMessage (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (FormSubmissionPublishMessage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/json/JSONObject;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/json/JSONObject;)V", __args);
					return;
				}

				if (id_ctor_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_ctor_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/json/JSONObject;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_json_JSONObject_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_json_JSONObject_, __args);
			} finally {
			}
		}

		static Delegate cb_getInvitationId;
#pragma warning disable 0169
		static Delegate GetGetInvitationIdHandler ()
		{
			if (cb_getInvitationId == null)
				cb_getInvitationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInvitationId);
			return cb_getInvitationId;
		}

		static IntPtr n_GetInvitationId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Request.Message.FormSubmissionPublishMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.FormSubmissionPublishMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.InvitationId);
		}
#pragma warning restore 0169

		static IntPtr id_getInvitationId;
		public virtual unsafe string InvitationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='FormSubmissionPublishMessage']/method[@name='getInvitationId' and count(parameter)=0]"
			[Register ("getInvitationId", "()Ljava/lang/String;", "GetGetInvitationIdHandler")]
			get {
				if (id_getInvitationId == IntPtr.Zero)
					id_getInvitationId = JNIEnv.GetMethodID (class_ref, "getInvitationId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInvitationId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInvitationId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Request.Message.FormSubmissionPublishMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.FormSubmissionPublishMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Message);
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		public override unsafe global::Java.Lang.Object Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='FormSubmissionPublishMessage']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Lorg/json/JSONObject;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Lorg/json/JSONObject;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMessageText;
#pragma warning disable 0169
		static Delegate GetGetMessageTextHandler ()
		{
			if (cb_getMessageText == null)
				cb_getMessageText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageText);
			return cb_getMessageText;
		}

		static IntPtr n_GetMessageText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Request.Message.FormSubmissionPublishMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.FormSubmissionPublishMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageText);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageText;
		public override unsafe string MessageText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='FormSubmissionPublishMessage']/method[@name='getMessageText' and count(parameter)=0]"
			[Register ("getMessageText", "()Ljava/lang/String;", "GetGetMessageTextHandler")]
			get {
				if (id_getMessageText == IntPtr.Zero)
					id_getMessageText = JNIEnv.GetMethodID (class_ref, "getMessageText", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Request.Message.FormSubmissionPublishMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.FormSubmissionPublishMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public override unsafe global::Com.Liveperson.Api.Request.Message.BasePublishMessage.PublishMessageType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='FormSubmissionPublishMessage']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/liveperson/api/request/message/BasePublishMessage$PublishMessageType;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/liveperson/api/request/message/BasePublishMessage$PublishMessageType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.BasePublishMessage.PublishMessageType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.BasePublishMessage.PublishMessageType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Lcom/liveperson/api/request/message/BasePublishMessage$PublishMessageType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getmSubmissionId;
#pragma warning disable 0169
		static Delegate GetGetmSubmissionIdHandler ()
		{
			if (cb_getmSubmissionId == null)
				cb_getmSubmissionId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetmSubmissionId);
			return cb_getmSubmissionId;
		}

		static IntPtr n_GetmSubmissionId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Request.Message.FormSubmissionPublishMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.FormSubmissionPublishMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetmSubmissionId ());
		}
#pragma warning restore 0169

		static IntPtr id_getmSubmissionId;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='FormSubmissionPublishMessage']/method[@name='getmSubmissionId' and count(parameter)=0]"
		[Register ("getmSubmissionId", "()Ljava/lang/String;", "GetGetmSubmissionIdHandler")]
		public virtual unsafe string GetmSubmissionId ()
		{
			if (id_getmSubmissionId == IntPtr.Zero)
				id_getmSubmissionId = JNIEnv.GetMethodID (class_ref, "getmSubmissionId", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getmSubmissionId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getmSubmissionId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
