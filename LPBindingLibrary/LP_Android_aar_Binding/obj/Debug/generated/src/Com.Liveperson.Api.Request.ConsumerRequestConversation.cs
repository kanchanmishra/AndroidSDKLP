using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='ConsumerRequestConversation']"
	[global::Android.Runtime.Register ("com/liveperson/api/request/ConsumerRequestConversation", DoNotGenerateAcw=true)]
	public partial class ConsumerRequestConversation : global::Com.Liveperson.Api.Request.RequestConversation {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='ConsumerRequestConversation']/field[@name='INTERACTION_CONTEXT_ID']"
		[Register ("INTERACTION_CONTEXT_ID")]
		public const string InteractionContextId = (string) "interactionContextId";

		static IntPtr appId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='ConsumerRequestConversation']/field[@name='appId']"
		[Register ("appId")]
		public string AppId {
			get {
				if (appId_jfieldId == IntPtr.Zero)
					appId_jfieldId = JNIEnv.GetFieldID (class_ref, "appId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, appId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (appId_jfieldId == IntPtr.Zero)
					appId_jfieldId = JNIEnv.GetFieldID (class_ref, "appId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, appId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr brandId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='ConsumerRequestConversation']/field[@name='brandId']"
		[Register ("brandId")]
		public string BrandId {
			get {
				if (brandId_jfieldId == IntPtr.Zero)
					brandId_jfieldId = JNIEnv.GetFieldID (class_ref, "brandId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, brandId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (brandId_jfieldId == IntPtr.Zero)
					brandId_jfieldId = JNIEnv.GetFieldID (class_ref, "brandId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, brandId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCampaignInfo_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='ConsumerRequestConversation']/field[@name='mCampaignInfo']"
		[Register ("mCampaignInfo")]
		public global::Com.Liveperson.Infra.CampaignInfo MCampaignInfo {
			get {
				if (mCampaignInfo_jfieldId == IntPtr.Zero)
					mCampaignInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "mCampaignInfo", "Lcom/liveperson/infra/CampaignInfo;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCampaignInfo_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.CampaignInfo> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCampaignInfo_jfieldId == IntPtr.Zero)
					mCampaignInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "mCampaignInfo", "Lcom/liveperson/infra/CampaignInfo;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCampaignInfo_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr skillId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='ConsumerRequestConversation']/field[@name='skillId']"
		[Register ("skillId")]
		public string SkillId {
			get {
				if (skillId_jfieldId == IntPtr.Zero)
					skillId_jfieldId = JNIEnv.GetFieldID (class_ref, "skillId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, skillId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (skillId_jfieldId == IntPtr.Zero)
					skillId_jfieldId = JNIEnv.GetFieldID (class_ref, "skillId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, skillId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ttrType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='ConsumerRequestConversation']/field[@name='ttrType']"
		[Register ("ttrType")]
		public global::Com.Liveperson.Api.Response.Types.TTRType TtrType {
			get {
				if (ttrType_jfieldId == IntPtr.Zero)
					ttrType_jfieldId = JNIEnv.GetFieldID (class_ref, "ttrType", "Lcom/liveperson/api/response/types/TTRType;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, ttrType_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.TTRType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ttrType_jfieldId == IntPtr.Zero)
					ttrType_jfieldId = JNIEnv.GetFieldID (class_ref, "ttrType", "Lcom/liveperson/api/response/types/TTRType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ttrType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/request/ConsumerRequestConversation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConsumerRequestConversation); }
		}

		protected ConsumerRequestConversation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_CampaignInfo_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='ConsumerRequestConversation']/constructor[@name='ConsumerRequestConversation' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.api.response.types.TTRType'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.liveperson.infra.CampaignInfo']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/liveperson/api/response/types/TTRType;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/CampaignInfo;)V", "")]
		public unsafe ConsumerRequestConversation (string p0, global::Com.Liveperson.Api.Response.Types.TTRType p1, string p2, string p3, global::Com.Liveperson.Infra.CampaignInfo p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				if (((object) this).GetType () != typeof (ConsumerRequestConversation)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Lcom/liveperson/api/response/types/TTRType;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/CampaignInfo;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lcom/liveperson/api/response/types/TTRType;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/CampaignInfo;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_CampaignInfo_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_CampaignInfo_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/liveperson/api/response/types/TTRType;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/CampaignInfo;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_CampaignInfo_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_CampaignInfo_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}
}
