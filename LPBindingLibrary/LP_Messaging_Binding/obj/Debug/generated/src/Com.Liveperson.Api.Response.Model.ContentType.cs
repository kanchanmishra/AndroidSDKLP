using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Response.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ContentType']"
	[global::Android.Runtime.Register ("com/liveperson/api/response/model/ContentType", DoNotGenerateAcw=true)]
	public sealed partial class ContentType : global::Java.Lang.Enum {


		static IntPtr application_json_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ContentType']/field[@name='application_json']"
		[Register ("application_json")]
		public static global::Com.Liveperson.Api.Response.Model.ContentType ApplicationJson {
			get {
				if (application_json_jfieldId == IntPtr.Zero)
					application_json_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "application_json", "Lcom/liveperson/api/response/model/ContentType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, application_json_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr forms_secure_invitation_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ContentType']/field[@name='forms_secure_invitation']"
		[Register ("forms_secure_invitation")]
		public static global::Com.Liveperson.Api.Response.Model.ContentType FormsSecureInvitation {
			get {
				if (forms_secure_invitation_jfieldId == IntPtr.Zero)
					forms_secure_invitation_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "forms_secure_invitation", "Lcom/liveperson/api/response/model/ContentType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, forms_secure_invitation_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr forms_secure_submission_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ContentType']/field[@name='forms_secure_submission']"
		[Register ("forms_secure_submission")]
		public static global::Com.Liveperson.Api.Response.Model.ContentType FormsSecureSubmission {
			get {
				if (forms_secure_submission_jfieldId == IntPtr.Zero)
					forms_secure_submission_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "forms_secure_submission", "Lcom/liveperson/api/response/model/ContentType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, forms_secure_submission_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr hosted_file_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ContentType']/field[@name='hosted_file']"
		[Register ("hosted_file")]
		public static global::Com.Liveperson.Api.Response.Model.ContentType HostedFile {
			get {
				if (hosted_file_jfieldId == IntPtr.Zero)
					hosted_file_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "hosted_file", "Lcom/liveperson/api/response/model/ContentType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, hosted_file_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr text_html_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ContentType']/field[@name='text_html']"
		[Register ("text_html")]
		public static global::Com.Liveperson.Api.Response.Model.ContentType TextHtml {
			get {
				if (text_html_jfieldId == IntPtr.Zero)
					text_html_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "text_html", "Lcom/liveperson/api/response/model/ContentType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, text_html_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr text_plain_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ContentType']/field[@name='text_plain']"
		[Register ("text_plain")]
		public static global::Com.Liveperson.Api.Response.Model.ContentType TextPlain {
			get {
				if (text_plain_jfieldId == IntPtr.Zero)
					text_plain_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "text_plain", "Lcom/liveperson/api/response/model/ContentType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, text_plain_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr text_structured_content_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ContentType']/field[@name='text_structured_content']"
		[Register ("text_structured_content")]
		public static global::Com.Liveperson.Api.Response.Model.ContentType TextStructuredContent {
			get {
				if (text_structured_content_jfieldId == IntPtr.Zero)
					text_structured_content_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "text_structured_content", "Lcom/liveperson/api/response/model/ContentType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, text_structured_content_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/response/model/ContentType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContentType); }
		}

		internal ContentType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isFile;
		public unsafe bool IsFile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ContentType']/method[@name='isFile' and count(parameter)=0]"
			[Register ("isFile", "()Z", "GetIsFileHandler")]
			get {
				if (id_isFile == IntPtr.Zero)
					id_isFile = JNIEnv.GetMethodID (class_ref, "isFile", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFile);
				} finally {
				}
			}
		}

		static IntPtr id_isFormInvitation;
		public unsafe bool IsFormInvitation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ContentType']/method[@name='isFormInvitation' and count(parameter)=0]"
			[Register ("isFormInvitation", "()Z", "GetIsFormInvitationHandler")]
			get {
				if (id_isFormInvitation == IntPtr.Zero)
					id_isFormInvitation = JNIEnv.GetMethodID (class_ref, "isFormInvitation", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFormInvitation);
				} finally {
				}
			}
		}

		static IntPtr id_isFormSubmission;
		public unsafe bool IsFormSubmission {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ContentType']/method[@name='isFormSubmission' and count(parameter)=0]"
			[Register ("isFormSubmission", "()Z", "GetIsFormSubmissionHandler")]
			get {
				if (id_isFormSubmission == IntPtr.Zero)
					id_isFormSubmission = JNIEnv.GetMethodID (class_ref, "isFormSubmission", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFormSubmission);
				} finally {
				}
			}
		}

		static IntPtr id_isHtml;
		public unsafe bool IsHtml {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ContentType']/method[@name='isHtml' and count(parameter)=0]"
			[Register ("isHtml", "()Z", "GetIsHtmlHandler")]
			get {
				if (id_isHtml == IntPtr.Zero)
					id_isHtml = JNIEnv.GetMethodID (class_ref, "isHtml", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHtml);
				} finally {
				}
			}
		}

		static IntPtr id_isSimpleText;
		public unsafe bool IsSimpleText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ContentType']/method[@name='isSimpleText' and count(parameter)=0]"
			[Register ("isSimpleText", "()Z", "GetIsSimpleTextHandler")]
			get {
				if (id_isSimpleText == IntPtr.Zero)
					id_isSimpleText = JNIEnv.GetMethodID (class_ref, "isSimpleText", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSimpleText);
				} finally {
				}
			}
		}

		static IntPtr id_getText;
		public unsafe string Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ContentType']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Ljava/lang/String;", "GetGetTextHandler")]
			get {
				if (id_getText == IntPtr.Zero)
					id_getText = JNIEnv.GetMethodID (class_ref, "getText", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getText), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_fromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ContentType']/method[@name='fromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromString", "(Ljava/lang/String;)Lcom/liveperson/api/response/model/ContentType;", "")]
		public static unsafe global::Com.Liveperson.Api.Response.Model.ContentType FromString (string p0)
		{
			if (id_fromString_Ljava_lang_String_ == IntPtr.Zero)
				id_fromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromString", "(Ljava/lang/String;)Lcom/liveperson/api/response/model/ContentType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Api.Response.Model.ContentType __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.ContentType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ContentType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/response/model/ContentType;", "")]
		public static unsafe global::Com.Liveperson.Api.Response.Model.ContentType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/response/model/ContentType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Api.Response.Model.ContentType __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.ContentType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ContentType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/liveperson/api/response/model/ContentType;", "")]
		public static unsafe global::Com.Liveperson.Api.Response.Model.ContentType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/api/response/model/ContentType;");
			try {
				return (global::Com.Liveperson.Api.Response.Model.ContentType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Api.Response.Model.ContentType));
			} finally {
			}
		}

	}
}
