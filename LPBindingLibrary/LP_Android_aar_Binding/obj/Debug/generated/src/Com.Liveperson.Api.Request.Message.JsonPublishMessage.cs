using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Request.Message {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='JsonPublishMessage']"
	[global::Android.Runtime.Register ("com/liveperson/api/request/message/JsonPublishMessage", DoNotGenerateAcw=true)]
	public partial class JsonPublishMessage : global::Com.Liveperson.Api.Request.Message.BasePublishMessage {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/request/message/JsonPublishMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JsonPublishMessage); }
		}

		protected JsonPublishMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='JsonPublishMessage']/constructor[@name='JsonPublishMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe JsonPublishMessage (string p0, string p1)
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
				if (((object) this).GetType () != typeof (JsonPublishMessage)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='JsonPublishMessage']/constructor[@name='JsonPublishMessage' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe JsonPublishMessage (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (JsonPublishMessage)) {
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

		static Delegate cb_getCaption;
#pragma warning disable 0169
		static Delegate GetGetCaptionHandler ()
		{
			if (cb_getCaption == null)
				cb_getCaption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCaption);
			return cb_getCaption;
		}

		static IntPtr n_GetCaption (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Request.Message.JsonPublishMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.JsonPublishMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Caption);
		}
#pragma warning restore 0169

		static IntPtr id_getCaption;
		public virtual unsafe string Caption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='JsonPublishMessage']/method[@name='getCaption' and count(parameter)=0]"
			[Register ("getCaption", "()Ljava/lang/String;", "GetGetCaptionHandler")]
			get {
				if (id_getCaption == IntPtr.Zero)
					id_getCaption = JNIEnv.GetMethodID (class_ref, "getCaption", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCaption), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCaption", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Liveperson.Api.Request.Message.JsonPublishMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.JsonPublishMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageText);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageText;
		public override unsafe string MessageText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='JsonPublishMessage']/method[@name='getMessageText' and count(parameter)=0]"
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
			global::Com.Liveperson.Api.Request.Message.JsonPublishMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.JsonPublishMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public override unsafe global::Com.Liveperson.Api.Request.Message.BasePublishMessage.PublishMessageType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='JsonPublishMessage']/method[@name='getType' and count(parameter)=0]"
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

	}
}
