using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField']"
	[global::Android.Runtime.Register ("com/liveperson/api/request/UpdateConversationField", DoNotGenerateAcw=true)]
	public partial class UpdateConversationField : global::Com.Liveperson.Api.Request.AbstractRequest {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField']/field[@name='CONVERSATION_CSAT']"
		[Register ("CONVERSATION_CSAT")]
		public const string ConversationCsat = (string) "csatRate";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField']/field[@name='CONVERSATION_CSAT_RATE']"
		[Register ("CONVERSATION_CSAT_RATE")]
		public const string ConversationCsatRate = (string) "CSATRate";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField']/field[@name='CONVERSATION_CSAT_STATUS']"
		[Register ("CONVERSATION_CSAT_STATUS")]
		public const string ConversationCsatStatus = (string) "status";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField']/field[@name='CONVERSATION_CSAT_YESNO_VALUE']"
		[Register ("CONVERSATION_CSAT_YESNO_VALUE")]
		public const string ConversationCsatYesnoValue = (string) "csatResolutionConfirmation";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField']/field[@name='CONVERSATION_FIELD']"
		[Register ("CONVERSATION_FIELD")]
		public const string ConversationField = (string) "conversationField";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField']/field[@name='CONVERSATION_ID']"
		[Register ("CONVERSATION_ID")]
		public const string ConversationId = (string) "conversationId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField']/field[@name='CONVERSATION_STATE_FIELD']"
		[Register ("CONVERSATION_STATE_FIELD")]
		public const string ConversationStateField = (string) "ConversationStateField";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField']/field[@name='FIELD']"
		[Register ("FIELD")]
		public const string Field = (string) "field";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField']/field[@name='PARTICIPANTS_CHANGE_FIELD']"
		[Register ("PARTICIPANTS_CHANGE_FIELD")]
		public const string ParticipantsChangeField = (string) "ParticipantsChange";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField']/field[@name='TTR']"
		[Register ("TTR")]
		public const string Ttr = (string) "ttrType";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField']/field[@name='TTR_FIELD']"
		[Register ("TTR_FIELD")]
		public const string TtrField = (string) "TTRField";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField']/field[@name='UPDATE_CONVERSATION_FIELD_TYPE']"
		[Register ("UPDATE_CONVERSATION_FIELD_TYPE")]
		public const string UpdateConversationFieldType = (string) "cm.UpdateConversationField";

		static IntPtr csatNumberOfStars_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField']/field[@name='csatNumberOfStars']"
		[Register ("csatNumberOfStars")]
		public int CsatNumberOfStars {
			get {
				if (csatNumberOfStars_jfieldId == IntPtr.Zero)
					csatNumberOfStars_jfieldId = JNIEnv.GetFieldID (class_ref, "csatNumberOfStars", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, csatNumberOfStars_jfieldId);
			}
			set {
				if (csatNumberOfStars_jfieldId == IntPtr.Zero)
					csatNumberOfStars_jfieldId = JNIEnv.GetFieldID (class_ref, "csatNumberOfStars", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, csatNumberOfStars_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr csatStatus_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField']/field[@name='csatStatus']"
		[Register ("csatStatus")]
		public global::Com.Liveperson.Api.Response.Types.CsatStatus CsatStatus {
			get {
				if (csatStatus_jfieldId == IntPtr.Zero)
					csatStatus_jfieldId = JNIEnv.GetFieldID (class_ref, "csatStatus", "Lcom/liveperson/api/response/types/CsatStatus;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, csatStatus_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CsatStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (csatStatus_jfieldId == IntPtr.Zero)
					csatStatus_jfieldId = JNIEnv.GetFieldID (class_ref, "csatStatus", "Lcom/liveperson/api/response/types/CsatStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, csatStatus_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr csatYesNoValue_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField']/field[@name='csatYesNoValue']"
		[Register ("csatYesNoValue")]
		public int CsatYesNoValue {
			get {
				if (csatYesNoValue_jfieldId == IntPtr.Zero)
					csatYesNoValue_jfieldId = JNIEnv.GetFieldID (class_ref, "csatYesNoValue", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, csatYesNoValue_jfieldId);
			}
			set {
				if (csatYesNoValue_jfieldId == IntPtr.Zero)
					csatYesNoValue_jfieldId = JNIEnv.GetFieldID (class_ref, "csatYesNoValue", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, csatYesNoValue_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr ttrType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField']/field[@name='ttrType']"
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

		static IntPtr ttrValue_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField']/field[@name='ttrValue']"
		[Register ("ttrValue")]
		public int TtrValue {
			get {
				if (ttrValue_jfieldId == IntPtr.Zero)
					ttrValue_jfieldId = JNIEnv.GetFieldID (class_ref, "ttrValue", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, ttrValue_jfieldId);
			}
			set {
				if (ttrValue_jfieldId == IntPtr.Zero)
					ttrValue_jfieldId = JNIEnv.GetFieldID (class_ref, "ttrValue", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ttrValue_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField']/field[@name='type']"
		[Register ("type")]
		public string Type {
			get {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, type_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, type_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField.ConversationState']"
		[global::Android.Runtime.Register ("com/liveperson/api/request/UpdateConversationField$ConversationState", DoNotGenerateAcw=true)]
		public sealed partial class ConversationState : global::Java.Lang.Enum {


			static IntPtr CLOSE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField.ConversationState']/field[@name='CLOSE']"
			[Register ("CLOSE")]
			public static global::Com.Liveperson.Api.Request.UpdateConversationField.ConversationState Close {
				get {
					if (CLOSE_jfieldId == IntPtr.Zero)
						CLOSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLOSE", "Lcom/liveperson/api/request/UpdateConversationField$ConversationState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLOSE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.UpdateConversationField.ConversationState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OPEN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField.ConversationState']/field[@name='OPEN']"
			[Register ("OPEN")]
			public static global::Com.Liveperson.Api.Request.UpdateConversationField.ConversationState Open {
				get {
					if (OPEN_jfieldId == IntPtr.Zero)
						OPEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPEN", "Lcom/liveperson/api/request/UpdateConversationField$ConversationState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OPEN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.UpdateConversationField.ConversationState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/api/request/UpdateConversationField$ConversationState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ConversationState); }
			}

			internal ConversationState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField.ConversationState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/request/UpdateConversationField$ConversationState;", "")]
			public static unsafe global::Com.Liveperson.Api.Request.UpdateConversationField.ConversationState ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/request/UpdateConversationField$ConversationState;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Liveperson.Api.Request.UpdateConversationField.ConversationState __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.UpdateConversationField.ConversationState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField.ConversationState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/liveperson/api/request/UpdateConversationField$ConversationState;", "")]
			public static unsafe global::Com.Liveperson.Api.Request.UpdateConversationField.ConversationState[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/api/request/UpdateConversationField$ConversationState;");
				try {
					return (global::Com.Liveperson.Api.Request.UpdateConversationField.ConversationState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Api.Request.UpdateConversationField.ConversationState));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/request/UpdateConversationField", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UpdateConversationField); }
		}

		protected UpdateConversationField (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField']/constructor[@name='UpdateConversationField' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.api.response.types.TTRType'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/types/TTRType;I)V", "")]
		public unsafe UpdateConversationField (string p0, string p1, global::Com.Liveperson.Api.Response.Types.TTRType p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (UpdateConversationField)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/types/TTRType;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/types/TTRType;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_I == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/response/types/TTRType;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_response_types_TTRType_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_IILcom_liveperson_api_response_types_CsatStatus_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField']/constructor[@name='UpdateConversationField' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='com.liveperson.api.response.types.CsatStatus']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;IILcom/liveperson/api/response/types/CsatStatus;)V", "")]
		public unsafe UpdateConversationField (string p0, string p1, int p2, int p3, global::Com.Liveperson.Api.Response.Types.CsatStatus p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (((object) this).GetType () != typeof (UpdateConversationField)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;IILcom/liveperson/api/response/types/CsatStatus;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;IILcom/liveperson/api/response/types/CsatStatus;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_IILcom_liveperson_api_response_types_CsatStatus_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_IILcom_liveperson_api_response_types_CsatStatus_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;IILcom/liveperson/api/response/types/CsatStatus;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_IILcom_liveperson_api_response_types_CsatStatus_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_IILcom_liveperson_api_response_types_CsatStatus_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_request_UpdateConversationField_ConversationState_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField']/constructor[@name='UpdateConversationField' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.api.request.UpdateConversationField.ConversationState']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/request/UpdateConversationField$ConversationState;)V", "")]
		public unsafe UpdateConversationField (string p0, string p1, global::Com.Liveperson.Api.Request.UpdateConversationField.ConversationState p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (UpdateConversationField)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/request/UpdateConversationField$ConversationState;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/request/UpdateConversationField$ConversationState;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_request_UpdateConversationField_ConversationState_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_request_UpdateConversationField_ConversationState_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/api/request/UpdateConversationField$ConversationState;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_request_UpdateConversationField_ConversationState_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_api_request_UpdateConversationField_ConversationState_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField']/constructor[@name='UpdateConversationField' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe UpdateConversationField (string p0, string p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (UpdateConversationField)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getMessageType;
#pragma warning disable 0169
		static Delegate GetGetMessageTypeHandler ()
		{
			if (cb_getMessageType == null)
				cb_getMessageType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageType);
			return cb_getMessageType;
		}

		static IntPtr n_GetMessageType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Request.UpdateConversationField __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.UpdateConversationField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageType);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageType;
		public override unsafe string MessageType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField']/method[@name='getMessageType' and count(parameter)=0]"
			[Register ("getMessageType", "()Ljava/lang/String;", "GetGetMessageTypeHandler")]
			get {
				if (id_getMessageType == IntPtr.Zero)
					id_getMessageType = JNIEnv.GetMethodID (class_ref, "getMessageType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_toJson_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetToJson_Lorg_json_JSONObject_Handler ()
		{
			if (cb_toJson_Lorg_json_JSONObject_ == null)
				cb_toJson_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ToJson_Lorg_json_JSONObject_);
			return cb_toJson_Lorg_json_JSONObject_;
		}

		static void n_ToJson_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Api.Request.UpdateConversationField __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.UpdateConversationField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ToJson (p0);
		}
#pragma warning restore 0169

		static IntPtr id_toJson_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request']/class[@name='UpdateConversationField']/method[@name='toJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("toJson", "(Lorg/json/JSONObject;)V", "GetToJson_Lorg_json_JSONObject_Handler")]
		protected override unsafe void ToJson (global::Org.Json.JSONObject p0)
		{
			if (id_toJson_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_toJson_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "toJson", "(Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toJson_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toJson", "(Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

	}
}
