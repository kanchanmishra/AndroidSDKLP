using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Response.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ConversationHistoryDetails']"
	[global::Android.Runtime.Register ("com/liveperson/api/response/model/ConversationHistoryDetails", DoNotGenerateAcw=true)]
	public abstract partial class ConversationHistoryDetails : global::Java.Lang.Object {


		static IntPtr closeReason_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ConversationHistoryDetails']/field[@name='closeReason']"
		[Register ("closeReason")]
		public global::Com.Liveperson.Api.Response.Types.CloseReason CloseReason {
			get {
				if (closeReason_jfieldId == IntPtr.Zero)
					closeReason_jfieldId = JNIEnv.GetFieldID (class_ref, "closeReason", "Lcom/liveperson/api/response/types/CloseReason;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, closeReason_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CloseReason> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (closeReason_jfieldId == IntPtr.Zero)
					closeReason_jfieldId = JNIEnv.GetFieldID (class_ref, "closeReason", "Lcom/liveperson/api/response/types/CloseReason;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, closeReason_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr csat_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ConversationHistoryDetails']/field[@name='csat']"
		[Register ("csat")]
		public global::Com.Liveperson.Api.Response.Types.CSAT Csat {
			get {
				if (csat_jfieldId == IntPtr.Zero)
					csat_jfieldId = JNIEnv.GetFieldID (class_ref, "csat", "Lcom/liveperson/api/response/types/CSAT;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, csat_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CSAT> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (csat_jfieldId == IntPtr.Zero)
					csat_jfieldId = JNIEnv.GetFieldID (class_ref, "csat", "Lcom/liveperson/api/response/types/CSAT;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, csat_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr endTs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ConversationHistoryDetails']/field[@name='endTs']"
		[Register ("endTs")]
		public long EndTs {
			get {
				if (endTs_jfieldId == IntPtr.Zero)
					endTs_jfieldId = JNIEnv.GetFieldID (class_ref, "endTs", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, endTs_jfieldId);
			}
			set {
				if (endTs_jfieldId == IntPtr.Zero)
					endTs_jfieldId = JNIEnv.GetFieldID (class_ref, "endTs", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, endTs_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr participants_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ConversationHistoryDetails']/field[@name='participants']"
		[Register ("participants")]
		public global::Com.Liveperson.Api.Response.Model.Participants Participants {
			get {
				if (participants_jfieldId == IntPtr.Zero)
					participants_jfieldId = JNIEnv.GetFieldID (class_ref, "participants", "Lcom/liveperson/api/response/model/Participants;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, participants_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.Participants> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (participants_jfieldId == IntPtr.Zero)
					participants_jfieldId = JNIEnv.GetFieldID (class_ref, "participants", "Lcom/liveperson/api/response/model/Participants;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, participants_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr startTs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ConversationHistoryDetails']/field[@name='startTs']"
		[Register ("startTs")]
		public long StartTs {
			get {
				if (startTs_jfieldId == IntPtr.Zero)
					startTs_jfieldId = JNIEnv.GetFieldID (class_ref, "startTs", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, startTs_jfieldId);
			}
			set {
				if (startTs_jfieldId == IntPtr.Zero)
					startTs_jfieldId = JNIEnv.GetFieldID (class_ref, "startTs", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, startTs_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr state_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ConversationHistoryDetails']/field[@name='state']"
		[Register ("state")]
		public global::Com.Liveperson.Api.Response.Types.ConversationState State {
			get {
				if (state_jfieldId == IntPtr.Zero)
					state_jfieldId = JNIEnv.GetFieldID (class_ref, "state", "Lcom/liveperson/api/response/types/ConversationState;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, state_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.ConversationState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (state_jfieldId == IntPtr.Zero)
					state_jfieldId = JNIEnv.GetFieldID (class_ref, "state", "Lcom/liveperson/api/response/types/ConversationState;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, state_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/response/model/ConversationHistoryDetails", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConversationHistoryDetails); }
		}

		protected ConversationHistoryDetails (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ConversationHistoryDetails']/constructor[@name='ConversationHistoryDetails' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe ConversationHistoryDetails (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ConversationHistoryDetails)) {
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

	}

	[global::Android.Runtime.Register ("com/liveperson/api/response/model/ConversationHistoryDetails", DoNotGenerateAcw=true)]
	internal partial class ConversationHistoryDetailsInvoker : ConversationHistoryDetails {

		public ConversationHistoryDetailsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConversationHistoryDetailsInvoker); }
		}

	}

}
