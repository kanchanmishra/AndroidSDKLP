using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Request.Message {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='BasePublishMessage']"
	[global::Android.Runtime.Register ("com/liveperson/api/request/message/BasePublishMessage", DoNotGenerateAcw=true)]
	public abstract partial class BasePublishMessage : global::Java.Lang.Object, global::Com.Liveperson.Api.Request.Message.IPublishMessage {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='BasePublishMessage.PublishMessageType']"
		[global::Android.Runtime.Register ("com/liveperson/api/request/message/BasePublishMessage$PublishMessageType", DoNotGenerateAcw=true)]
		public sealed partial class PublishMessageType : global::Java.Lang.Enum {


			static IntPtr FILE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='BasePublishMessage.PublishMessageType']/field[@name='FILE']"
			[Register ("FILE")]
			public static global::Com.Liveperson.Api.Request.Message.BasePublishMessage.PublishMessageType File {
				get {
					if (FILE_jfieldId == IntPtr.Zero)
						FILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FILE", "Lcom/liveperson/api/request/message/BasePublishMessage$PublishMessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FILE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.BasePublishMessage.PublishMessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FORM_INVITATION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='BasePublishMessage.PublishMessageType']/field[@name='FORM_INVITATION']"
			[Register ("FORM_INVITATION")]
			public static global::Com.Liveperson.Api.Request.Message.BasePublishMessage.PublishMessageType FormInvitation {
				get {
					if (FORM_INVITATION_jfieldId == IntPtr.Zero)
						FORM_INVITATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FORM_INVITATION", "Lcom/liveperson/api/request/message/BasePublishMessage$PublishMessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FORM_INVITATION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.BasePublishMessage.PublishMessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FORM_SUBMISSION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='BasePublishMessage.PublishMessageType']/field[@name='FORM_SUBMISSION']"
			[Register ("FORM_SUBMISSION")]
			public static global::Com.Liveperson.Api.Request.Message.BasePublishMessage.PublishMessageType FormSubmission {
				get {
					if (FORM_SUBMISSION_jfieldId == IntPtr.Zero)
						FORM_SUBMISSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FORM_SUBMISSION", "Lcom/liveperson/api/request/message/BasePublishMessage$PublishMessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FORM_SUBMISSION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.BasePublishMessage.PublishMessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr JSON_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='BasePublishMessage.PublishMessageType']/field[@name='JSON']"
			[Register ("JSON")]
			public static global::Com.Liveperson.Api.Request.Message.BasePublishMessage.PublishMessageType Json {
				get {
					if (JSON_jfieldId == IntPtr.Zero)
						JSON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JSON", "Lcom/liveperson/api/request/message/BasePublishMessage$PublishMessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JSON_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.BasePublishMessage.PublishMessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr STRUCTURED_CONTENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='BasePublishMessage.PublishMessageType']/field[@name='STRUCTURED_CONTENT']"
			[Register ("STRUCTURED_CONTENT")]
			public static global::Com.Liveperson.Api.Request.Message.BasePublishMessage.PublishMessageType StructuredContent {
				get {
					if (STRUCTURED_CONTENT_jfieldId == IntPtr.Zero)
						STRUCTURED_CONTENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRUCTURED_CONTENT", "Lcom/liveperson/api/request/message/BasePublishMessage$PublishMessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STRUCTURED_CONTENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.BasePublishMessage.PublishMessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TEXT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='BasePublishMessage.PublishMessageType']/field[@name='TEXT']"
			[Register ("TEXT")]
			public static global::Com.Liveperson.Api.Request.Message.BasePublishMessage.PublishMessageType Text {
				get {
					if (TEXT_jfieldId == IntPtr.Zero)
						TEXT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXT", "Lcom/liveperson/api/request/message/BasePublishMessage$PublishMessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEXT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.BasePublishMessage.PublishMessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/api/request/message/BasePublishMessage$PublishMessageType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PublishMessageType); }
			}

			internal PublishMessageType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='BasePublishMessage.PublishMessageType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/request/message/BasePublishMessage$PublishMessageType;", "")]
			public static unsafe global::Com.Liveperson.Api.Request.Message.BasePublishMessage.PublishMessageType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/request/message/BasePublishMessage$PublishMessageType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Liveperson.Api.Request.Message.BasePublishMessage.PublishMessageType __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.BasePublishMessage.PublishMessageType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='BasePublishMessage.PublishMessageType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/liveperson/api/request/message/BasePublishMessage$PublishMessageType;", "")]
			public static unsafe global::Com.Liveperson.Api.Request.Message.BasePublishMessage.PublishMessageType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/api/request/message/BasePublishMessage$PublishMessageType;");
				try {
					return (global::Com.Liveperson.Api.Request.Message.BasePublishMessage.PublishMessageType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Api.Request.Message.BasePublishMessage.PublishMessageType));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/request/message/BasePublishMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BasePublishMessage); }
		}

		protected BasePublishMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='BasePublishMessage']/constructor[@name='BasePublishMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BasePublishMessage ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BasePublishMessage)) {
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
			global::Com.Liveperson.Api.Request.Message.BasePublishMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.BasePublishMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageText);
		}
#pragma warning restore 0169

		public abstract string MessageText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='BasePublishMessage']/method[@name='getMessageText' and count(parameter)=0]"
			[Register ("getMessageText", "()Ljava/lang/String;", "GetGetMessageTextHandler")] get;
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
			global::Com.Liveperson.Api.Request.Message.BasePublishMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.BasePublishMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		public abstract global::Com.Liveperson.Api.Request.Message.BasePublishMessage.PublishMessageType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='BasePublishMessage']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/liveperson/api/request/message/BasePublishMessage$PublishMessageType;", "GetGetTypeHandler")] get;
		}

		static Delegate cb_getMessageTextWithoutSpecialChars_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMessageTextWithoutSpecialChars_Ljava_lang_String_Handler ()
		{
			if (cb_getMessageTextWithoutSpecialChars_Ljava_lang_String_ == null)
				cb_getMessageTextWithoutSpecialChars_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMessageTextWithoutSpecialChars_Ljava_lang_String_);
			return cb_getMessageTextWithoutSpecialChars_Ljava_lang_String_;
		}

		static IntPtr n_GetMessageTextWithoutSpecialChars_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Api.Request.Message.BasePublishMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.BasePublishMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetMessageTextWithoutSpecialChars (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageTextWithoutSpecialChars_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='BasePublishMessage']/method[@name='getMessageTextWithoutSpecialChars' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMessageTextWithoutSpecialChars", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetMessageTextWithoutSpecialChars_Ljava_lang_String_Handler")]
		public virtual unsafe string GetMessageTextWithoutSpecialChars (string p0)
		{
			if (id_getMessageTextWithoutSpecialChars_Ljava_lang_String_ == IntPtr.Zero)
				id_getMessageTextWithoutSpecialChars_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMessageTextWithoutSpecialChars", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageTextWithoutSpecialChars_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageTextWithoutSpecialChars", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Liveperson.Api.Request.Message.BasePublishMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.BasePublishMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Message);
		}
#pragma warning restore 0169

		public abstract global::Java.Lang.Object Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='BasePublishMessage']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/Object;", "GetGetMessageHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/api/request/message/BasePublishMessage", DoNotGenerateAcw=true)]
	internal partial class BasePublishMessageInvoker : BasePublishMessage {

		public BasePublishMessageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BasePublishMessageInvoker); }
		}

		static IntPtr id_getMessageText;
		public override unsafe string MessageText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='BasePublishMessage']/method[@name='getMessageText' and count(parameter)=0]"
			[Register ("getMessageText", "()Ljava/lang/String;", "GetGetMessageTextHandler")]
			get {
				if (id_getMessageText == IntPtr.Zero)
					id_getMessageText = JNIEnv.GetMethodID (class_ref, "getMessageText", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageText), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getType;
		public override unsafe global::Com.Liveperson.Api.Request.Message.BasePublishMessage.PublishMessageType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='BasePublishMessage']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/liveperson/api/request/message/BasePublishMessage$PublishMessageType;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/liveperson/api/request/message/BasePublishMessage$PublishMessageType;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.BasePublishMessage.PublishMessageType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMessage;
		public override unsafe global::Java.Lang.Object Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='BasePublishMessage']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/Object;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/Object;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

}
