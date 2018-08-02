using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Request.Message {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='FilePublishMessage']"
	[global::Android.Runtime.Register ("com/liveperson/api/request/message/FilePublishMessage", DoNotGenerateAcw=true)]
	public partial class FilePublishMessage : global::Com.Liveperson.Api.Request.Message.BasePublishMessage {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/request/message/FilePublishMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FilePublishMessage); }
		}

		protected FilePublishMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='FilePublishMessage']/constructor[@name='FilePublishMessage' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe FilePublishMessage (string p0, string p1, string p2, string p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				if (((object) this).GetType () != typeof (FilePublishMessage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='FilePublishMessage']/constructor[@name='FilePublishMessage' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe FilePublishMessage (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (FilePublishMessage)) {
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
			global::Com.Liveperson.Api.Request.Message.FilePublishMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.FilePublishMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Caption);
		}
#pragma warning restore 0169

		static IntPtr id_getCaption;
		public virtual unsafe string Caption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='FilePublishMessage']/method[@name='getCaption' and count(parameter)=0]"
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

		static Delegate cb_getFileType;
#pragma warning disable 0169
		static Delegate GetGetFileTypeHandler ()
		{
			if (cb_getFileType == null)
				cb_getFileType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileType);
			return cb_getFileType;
		}

		static IntPtr n_GetFileType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Request.Message.FilePublishMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.FilePublishMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FileType);
		}
#pragma warning restore 0169

		static IntPtr id_getFileType;
		public virtual unsafe string FileType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='FilePublishMessage']/method[@name='getFileType' and count(parameter)=0]"
			[Register ("getFileType", "()Ljava/lang/String;", "GetGetFileTypeHandler")]
			get {
				if (id_getFileType == IntPtr.Zero)
					id_getFileType = JNIEnv.GetMethodID (class_ref, "getFileType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFileType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Liveperson.Api.Request.Message.FilePublishMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.FilePublishMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Message);
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		public override unsafe global::Java.Lang.Object Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='FilePublishMessage']/method[@name='getMessage' and count(parameter)=0]"
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
			global::Com.Liveperson.Api.Request.Message.FilePublishMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.FilePublishMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageText);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageText;
		public override unsafe string MessageText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='FilePublishMessage']/method[@name='getMessageText' and count(parameter)=0]"
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

		static Delegate cb_getPreview;
#pragma warning disable 0169
		static Delegate GetGetPreviewHandler ()
		{
			if (cb_getPreview == null)
				cb_getPreview = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPreview);
			return cb_getPreview;
		}

		static IntPtr n_GetPreview (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Request.Message.FilePublishMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.FilePublishMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Preview);
		}
#pragma warning restore 0169

		static IntPtr id_getPreview;
		public virtual unsafe string Preview {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='FilePublishMessage']/method[@name='getPreview' and count(parameter)=0]"
			[Register ("getPreview", "()Ljava/lang/String;", "GetGetPreviewHandler")]
			get {
				if (id_getPreview == IntPtr.Zero)
					id_getPreview = JNIEnv.GetMethodID (class_ref, "getPreview", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPreview), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreview", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRelativePath;
#pragma warning disable 0169
		static Delegate GetGetRelativePathHandler ()
		{
			if (cb_getRelativePath == null)
				cb_getRelativePath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRelativePath);
			return cb_getRelativePath;
		}

		static IntPtr n_GetRelativePath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Request.Message.FilePublishMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.FilePublishMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RelativePath);
		}
#pragma warning restore 0169

		static IntPtr id_getRelativePath;
		public virtual unsafe string RelativePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='FilePublishMessage']/method[@name='getRelativePath' and count(parameter)=0]"
			[Register ("getRelativePath", "()Ljava/lang/String;", "GetGetRelativePathHandler")]
			get {
				if (id_getRelativePath == IntPtr.Zero)
					id_getRelativePath = JNIEnv.GetMethodID (class_ref, "getRelativePath", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRelativePath), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRelativePath", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Liveperson.Api.Request.Message.FilePublishMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.FilePublishMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public override unsafe global::Com.Liveperson.Api.Request.Message.BasePublishMessage.PublishMessageType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='FilePublishMessage']/method[@name='getType' and count(parameter)=0]"
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
