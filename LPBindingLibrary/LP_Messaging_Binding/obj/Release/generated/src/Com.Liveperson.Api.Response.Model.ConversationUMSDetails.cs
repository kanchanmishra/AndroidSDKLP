using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Response.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ConversationUMSDetails']"
	[global::Android.Runtime.Register ("com/liveperson/api/response/model/ConversationUMSDetails", DoNotGenerateAcw=true)]
	public partial class ConversationUMSDetails : global::Com.Liveperson.Api.Response.Model.ConversationHistoryDetails {


		static IntPtr delay_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ConversationUMSDetails']/field[@name='delay']"
		[Register ("delay")]
		public global::Com.Liveperson.Api.Response.Model.Delay Delay {
			get {
				if (delay_jfieldId == IntPtr.Zero)
					delay_jfieldId = JNIEnv.GetFieldID (class_ref, "delay", "Lcom/liveperson/api/response/model/Delay;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, delay_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.Delay> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (delay_jfieldId == IntPtr.Zero)
					delay_jfieldId = JNIEnv.GetFieldID (class_ref, "delay", "Lcom/liveperson/api/response/model/Delay;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, delay_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr dialogs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ConversationUMSDetails']/field[@name='dialogs']"
		[Register ("dialogs")]
		public IList<Com.Liveperson.Api.Response.Model.Dialog> Dialogs {
			get {
				if (dialogs_jfieldId == IntPtr.Zero)
					dialogs_jfieldId = JNIEnv.GetFieldID (class_ref, "dialogs", "[Lcom/liveperson/api/response/model/Dialog;");
				return global::Android.Runtime.JavaArray<global::Com.Liveperson.Api.Response.Model.Dialog>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, dialogs_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (dialogs_jfieldId == IntPtr.Zero)
					dialogs_jfieldId = JNIEnv.GetFieldID (class_ref, "dialogs", "[Lcom/liveperson/api/response/model/Dialog;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.Liveperson.Api.Response.Model.Dialog>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, dialogs_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr manualETTR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ConversationUMSDetails']/field[@name='manualETTR']"
		[Register ("manualETTR")]
		public long ManualETTR {
			get {
				if (manualETTR_jfieldId == IntPtr.Zero)
					manualETTR_jfieldId = JNIEnv.GetFieldID (class_ref, "manualETTR", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, manualETTR_jfieldId);
			}
			set {
				if (manualETTR_jfieldId == IntPtr.Zero)
					manualETTR_jfieldId = JNIEnv.GetFieldID (class_ref, "manualETTR", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, manualETTR_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr metaDataLastUpdateTs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ConversationUMSDetails']/field[@name='metaDataLastUpdateTs']"
		[Register ("metaDataLastUpdateTs")]
		public long MetaDataLastUpdateTs {
			get {
				if (metaDataLastUpdateTs_jfieldId == IntPtr.Zero)
					metaDataLastUpdateTs_jfieldId = JNIEnv.GetFieldID (class_ref, "metaDataLastUpdateTs", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, metaDataLastUpdateTs_jfieldId);
			}
			set {
				if (metaDataLastUpdateTs_jfieldId == IntPtr.Zero)
					metaDataLastUpdateTs_jfieldId = JNIEnv.GetFieldID (class_ref, "metaDataLastUpdateTs", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, metaDataLastUpdateTs_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr skillId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ConversationUMSDetails']/field[@name='skillId']"
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

		static IntPtr ttr_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ConversationUMSDetails']/field[@name='ttr']"
		[Register ("ttr")]
		public global::Com.Liveperson.Api.Response.Model.Ttr Ttr {
			get {
				if (ttr_jfieldId == IntPtr.Zero)
					ttr_jfieldId = JNIEnv.GetFieldID (class_ref, "ttr", "Lcom/liveperson/api/response/model/Ttr;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, ttr_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.Ttr> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ttr_jfieldId == IntPtr.Zero)
					ttr_jfieldId = JNIEnv.GetFieldID (class_ref, "ttr", "Lcom/liveperson/api/response/model/Ttr;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ttr_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/response/model/ConversationUMSDetails", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConversationUMSDetails); }
		}

		protected ConversationUMSDetails (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ConversationUMSDetails']/constructor[@name='ConversationUMSDetails' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe ConversationUMSDetails (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ConversationUMSDetails)) {
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

		static Delegate cb_getCalculatedTTR;
#pragma warning disable 0169
		static Delegate GetGetCalculatedTTRHandler ()
		{
			if (cb_getCalculatedTTR == null)
				cb_getCalculatedTTR = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCalculatedTTR);
			return cb_getCalculatedTTR;
		}

		static long n_GetCalculatedTTR (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Response.Model.ConversationUMSDetails __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.ConversationUMSDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CalculatedTTR;
		}
#pragma warning restore 0169

		static IntPtr id_getCalculatedTTR;
		public virtual unsafe long CalculatedTTR {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='ConversationUMSDetails']/method[@name='getCalculatedTTR' and count(parameter)=0]"
			[Register ("getCalculatedTTR", "()J", "GetGetCalculatedTTRHandler")]
			get {
				if (id_getCalculatedTTR == IntPtr.Zero)
					id_getCalculatedTTR = JNIEnv.GetMethodID (class_ref, "getCalculatedTTR", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCalculatedTTR);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCalculatedTTR", "()J"));
				} finally {
				}
			}
		}

	}
}
