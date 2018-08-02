using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/model/Conversation", DoNotGenerateAcw=true)]
	public partial class Conversation : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/model/Conversation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Conversation); }
		}

		protected Conversation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_database_Cursor_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/constructor[@name='Conversation' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register (".ctor", "(Landroid/database/Cursor;)V", "")]
		public unsafe Conversation (global::Android.Database.ICursor p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (Conversation)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/database/Cursor;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/database/Cursor;)V", __args);
					return;
				}

				if (id_ctor_Landroid_database_Cursor_ == IntPtr.Zero)
					id_ctor_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/database/Cursor;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_database_Cursor_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_database_Cursor_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_liveperson_messaging_model_ConversationData_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/constructor[@name='Conversation' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.ConversationData']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/model/ConversationData;)V", "")]
		public unsafe Conversation (global::Com.Liveperson.Messaging.Model.ConversationData p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (Conversation)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/model/ConversationData;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/model/ConversationData;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_model_ConversationData_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_model_ConversationData_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/model/ConversationData;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_model_ConversationData_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_model_ConversationData_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/constructor[@name='Conversation' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe Conversation (string p0, string p1)
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
				if (((object) this).GetType () != typeof (Conversation)) {
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

		static Delegate cb_getAssignedAgentServerId;
#pragma warning disable 0169
		static Delegate GetGetAssignedAgentServerIdHandler ()
		{
			if (cb_getAssignedAgentServerId == null)
				cb_getAssignedAgentServerId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAssignedAgentServerId);
			return cb_getAssignedAgentServerId;
		}

		static IntPtr n_GetAssignedAgentServerId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AssignedAgentServerId);
		}
#pragma warning restore 0169

		static IntPtr id_getAssignedAgentServerId;
		public virtual unsafe string AssignedAgentServerId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='getAssignedAgentServerId' and count(parameter)=0]"
			[Register ("getAssignedAgentServerId", "()Ljava/lang/String;", "GetGetAssignedAgentServerIdHandler")]
			get {
				if (id_getAssignedAgentServerId == IntPtr.Zero)
					id_getAssignedAgentServerId = JNIEnv.GetMethodID (class_ref, "getAssignedAgentServerId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAssignedAgentServerId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAssignedAgentServerId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBrandId;
#pragma warning disable 0169
		static Delegate GetGetBrandIdHandler ()
		{
			if (cb_getBrandId == null)
				cb_getBrandId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBrandId);
			return cb_getBrandId;
		}

		static IntPtr n_GetBrandId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BrandId);
		}
#pragma warning restore 0169

		static IntPtr id_getBrandId;
		public virtual unsafe string BrandId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='getBrandId' and count(parameter)=0]"
			[Register ("getBrandId", "()Ljava/lang/String;", "GetGetBrandIdHandler")]
			get {
				if (id_getBrandId == IntPtr.Zero)
					id_getBrandId = JNIEnv.GetMethodID (class_ref, "getBrandId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBrandId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBrandId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCloseReason;
#pragma warning disable 0169
		static Delegate GetGetCloseReasonHandler ()
		{
			if (cb_getCloseReason == null)
				cb_getCloseReason = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCloseReason);
			return cb_getCloseReason;
		}

		static IntPtr n_GetCloseReason (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CloseReason);
		}
#pragma warning restore 0169

		static Delegate cb_setCloseReason_Lcom_liveperson_api_response_types_CloseReason_;
#pragma warning disable 0169
		static Delegate GetSetCloseReason_Lcom_liveperson_api_response_types_CloseReason_Handler ()
		{
			if (cb_setCloseReason_Lcom_liveperson_api_response_types_CloseReason_ == null)
				cb_setCloseReason_Lcom_liveperson_api_response_types_CloseReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCloseReason_Lcom_liveperson_api_response_types_CloseReason_);
			return cb_setCloseReason_Lcom_liveperson_api_response_types_CloseReason_;
		}

		static void n_SetCloseReason_Lcom_liveperson_api_response_types_CloseReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Response.Types.CloseReason p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CloseReason> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CloseReason = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCloseReason;
		static IntPtr id_setCloseReason_Lcom_liveperson_api_response_types_CloseReason_;
		public virtual unsafe global::Com.Liveperson.Api.Response.Types.CloseReason CloseReason {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='getCloseReason' and count(parameter)=0]"
			[Register ("getCloseReason", "()Lcom/liveperson/api/response/types/CloseReason;", "GetGetCloseReasonHandler")]
			get {
				if (id_getCloseReason == IntPtr.Zero)
					id_getCloseReason = JNIEnv.GetMethodID (class_ref, "getCloseReason", "()Lcom/liveperson/api/response/types/CloseReason;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CloseReason> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCloseReason), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CloseReason> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCloseReason", "()Lcom/liveperson/api/response/types/CloseReason;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='setCloseReason' and count(parameter)=1 and parameter[1][@type='com.liveperson.api.response.types.CloseReason']]"
			[Register ("setCloseReason", "(Lcom/liveperson/api/response/types/CloseReason;)V", "GetSetCloseReason_Lcom_liveperson_api_response_types_CloseReason_Handler")]
			set {
				if (id_setCloseReason_Lcom_liveperson_api_response_types_CloseReason_ == IntPtr.Zero)
					id_setCloseReason_Lcom_liveperson_api_response_types_CloseReason_ = JNIEnv.GetMethodID (class_ref, "setCloseReason", "(Lcom/liveperson/api/response/types/CloseReason;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCloseReason_Lcom_liveperson_api_response_types_CloseReason_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCloseReason", "(Lcom/liveperson/api/response/types/CloseReason;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCloseTime;
#pragma warning disable 0169
		static Delegate GetGetCloseTimeHandler ()
		{
			if (cb_getCloseTime == null)
				cb_getCloseTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCloseTime);
			return cb_getCloseTime;
		}

		static long n_GetCloseTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CloseTime;
		}
#pragma warning restore 0169

		static Delegate cb_setCloseTime_J;
#pragma warning disable 0169
		static Delegate GetSetCloseTime_JHandler ()
		{
			if (cb_setCloseTime_J == null)
				cb_setCloseTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetCloseTime_J);
			return cb_setCloseTime_J;
		}

		static void n_SetCloseTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCloseTime;
		static IntPtr id_setCloseTime_J;
		public virtual unsafe long CloseTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='getCloseTime' and count(parameter)=0]"
			[Register ("getCloseTime", "()J", "GetGetCloseTimeHandler")]
			get {
				if (id_getCloseTime == IntPtr.Zero)
					id_getCloseTime = JNIEnv.GetMethodID (class_ref, "getCloseTime", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCloseTime);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCloseTime", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='setCloseTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setCloseTime", "(J)V", "GetSetCloseTime_JHandler")]
			set {
				if (id_setCloseTime_J == IntPtr.Zero)
					id_setCloseTime_J = JNIEnv.GetMethodID (class_ref, "setCloseTime", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCloseTime_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCloseTime", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getConversationServerId;
#pragma warning disable 0169
		static Delegate GetGetConversationServerIdHandler ()
		{
			if (cb_getConversationServerId == null)
				cb_getConversationServerId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConversationServerId);
			return cb_getConversationServerId;
		}

		static IntPtr n_GetConversationServerId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConversationServerId);
		}
#pragma warning restore 0169

		static IntPtr id_getConversationServerId;
		public virtual unsafe string ConversationServerId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='getConversationServerId' and count(parameter)=0]"
			[Register ("getConversationServerId", "()Ljava/lang/String;", "GetGetConversationServerIdHandler")]
			get {
				if (id_getConversationServerId == IntPtr.Zero)
					id_getConversationServerId = JNIEnv.GetMethodID (class_ref, "getConversationServerId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationServerId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationServerId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConversationTTRType;
#pragma warning disable 0169
		static Delegate GetGetConversationTTRTypeHandler ()
		{
			if (cb_getConversationTTRType == null)
				cb_getConversationTTRType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConversationTTRType);
			return cb_getConversationTTRType;
		}

		static IntPtr n_GetConversationTTRType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConversationTTRType);
		}
#pragma warning restore 0169

		static IntPtr id_getConversationTTRType;
		public virtual unsafe global::Com.Liveperson.Api.Response.Types.TTRType ConversationTTRType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='getConversationTTRType' and count(parameter)=0]"
			[Register ("getConversationTTRType", "()Lcom/liveperson/api/response/types/TTRType;", "GetGetConversationTTRTypeHandler")]
			get {
				if (id_getConversationTTRType == IntPtr.Zero)
					id_getConversationTTRType = JNIEnv.GetMethodID (class_ref, "getConversationTTRType", "()Lcom/liveperson/api/response/types/TTRType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.TTRType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationTTRType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.TTRType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationTTRType", "()Lcom/liveperson/api/response/types/TTRType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isConversationOpen;
#pragma warning disable 0169
		static Delegate GetIsConversationOpenHandler ()
		{
			if (cb_isConversationOpen == null)
				cb_isConversationOpen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConversationOpen);
			return cb_isConversationOpen;
		}

		static bool n_IsConversationOpen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConversationOpen;
		}
#pragma warning restore 0169

		static IntPtr id_isConversationOpen;
		public virtual unsafe bool IsConversationOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='isConversationOpen' and count(parameter)=0]"
			[Register ("isConversationOpen", "()Z", "GetIsConversationOpenHandler")]
			get {
				if (id_isConversationOpen == IntPtr.Zero)
					id_isConversationOpen = JNIEnv.GetMethodID (class_ref, "isConversationOpen", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConversationOpen);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConversationOpen", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getLastServerSequence;
#pragma warning disable 0169
		static Delegate GetGetLastServerSequenceHandler ()
		{
			if (cb_getLastServerSequence == null)
				cb_getLastServerSequence = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLastServerSequence);
			return cb_getLastServerSequence;
		}

		static int n_GetLastServerSequence (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastServerSequence;
		}
#pragma warning restore 0169

		static IntPtr id_getLastServerSequence;
		public virtual unsafe int LastServerSequence {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='getLastServerSequence' and count(parameter)=0]"
			[Register ("getLastServerSequence", "()I", "GetGetLastServerSequenceHandler")]
			get {
				if (id_getLastServerSequence == IntPtr.Zero)
					id_getLastServerSequence = JNIEnv.GetMethodID (class_ref, "getLastServerSequence", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLastServerSequence);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastServerSequence", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getPendingData;
#pragma warning disable 0169
		static Delegate GetGetPendingDataHandler ()
		{
			if (cb_getPendingData == null)
				cb_getPendingData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPendingData);
			return cb_getPendingData;
		}

		static IntPtr n_GetPendingData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PendingData);
		}
#pragma warning restore 0169

		static IntPtr id_getPendingData;
		public virtual unsafe global::Com.Liveperson.Messaging.Model.PendingConversationData PendingData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='getPendingData' and count(parameter)=0]"
			[Register ("getPendingData", "()Lcom/liveperson/messaging/model/PendingConversationData;", "GetGetPendingDataHandler")]
			get {
				if (id_getPendingData == IntPtr.Zero)
					id_getPendingData = JNIEnv.GetMethodID (class_ref, "getPendingData", "()Lcom/liveperson/messaging/model/PendingConversationData;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.PendingConversationData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPendingData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.PendingConversationData> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPendingData", "()Lcom/liveperson/messaging/model/PendingConversationData;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestId;
#pragma warning disable 0169
		static Delegate GetGetRequestIdHandler ()
		{
			if (cb_getRequestId == null)
				cb_getRequestId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetRequestId);
			return cb_getRequestId;
		}

		static long n_GetRequestId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequestId;
		}
#pragma warning restore 0169

		static IntPtr id_getRequestId;
		public virtual unsafe long RequestId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='getRequestId' and count(parameter)=0]"
			[Register ("getRequestId", "()J", "GetGetRequestIdHandler")]
			get {
				if (id_getRequestId == IntPtr.Zero)
					id_getRequestId = JNIEnv.GetMethodID (class_ref, "getRequestId", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getRequestId);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestId", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getStartTs;
#pragma warning disable 0169
		static Delegate GetGetStartTsHandler ()
		{
			if (cb_getStartTs == null)
				cb_getStartTs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetStartTs);
			return cb_getStartTs;
		}

		static long n_GetStartTs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartTs;
		}
#pragma warning restore 0169

		static Delegate cb_setStartTs_J;
#pragma warning disable 0169
		static Delegate GetSetStartTs_JHandler ()
		{
			if (cb_setStartTs_J == null)
				cb_setStartTs_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetStartTs_J);
			return cb_setStartTs_J;
		}

		static void n_SetStartTs_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartTs = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStartTs;
		static IntPtr id_setStartTs_J;
		public virtual unsafe long StartTs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='getStartTs' and count(parameter)=0]"
			[Register ("getStartTs", "()J", "GetGetStartTsHandler")]
			get {
				if (id_getStartTs == IntPtr.Zero)
					id_getStartTs = JNIEnv.GetMethodID (class_ref, "getStartTs", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getStartTs);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStartTs", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='setStartTs' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setStartTs", "(J)V", "GetSetStartTs_JHandler")]
			set {
				if (id_setStartTs_J == IntPtr.Zero)
					id_setStartTs_J = JNIEnv.GetMethodID (class_ref, "setStartTs", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStartTs_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStartTs", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetState);
			return cb_getState;
		}

		static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.State);
		}
#pragma warning restore 0169

		static IntPtr id_getState;
		public virtual unsafe global::Com.Liveperson.Api.Response.Types.ConversationState State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Lcom/liveperson/api/response/types/ConversationState;", "GetGetStateHandler")]
			get {
				if (id_getState == IntPtr.Zero)
					id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()Lcom/liveperson/api/response/types/ConversationState;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.ConversationState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getState), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.ConversationState> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getState", "()Lcom/liveperson/api/response/types/ConversationState;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTTRManager;
#pragma warning disable 0169
		static Delegate GetGetTTRManagerHandler ()
		{
			if (cb_getTTRManager == null)
				cb_getTTRManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTTRManager);
			return cb_getTTRManager;
		}

		static IntPtr n_GetTTRManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TTRManager);
		}
#pragma warning restore 0169

		static IntPtr id_getTTRManager;
		protected virtual unsafe global::Com.Liveperson.Messaging.Model.TTRManager TTRManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='getTTRManager' and count(parameter)=0]"
			[Register ("getTTRManager", "()Lcom/liveperson/messaging/model/TTRManager;", "GetGetTTRManagerHandler")]
			get {
				if (id_getTTRManager == IntPtr.Zero)
					id_getTTRManager = JNIEnv.GetMethodID (class_ref, "getTTRManager", "()Lcom/liveperson/messaging/model/TTRManager;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.TTRManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTTRManager), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.TTRManager> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTTRManager", "()Lcom/liveperson/messaging/model/TTRManager;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTargetId;
#pragma warning disable 0169
		static Delegate GetGetTargetIdHandler ()
		{
			if (cb_getTargetId == null)
				cb_getTargetId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTargetId);
			return cb_getTargetId;
		}

		static IntPtr n_GetTargetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TargetId);
		}
#pragma warning restore 0169

		static IntPtr id_getTargetId;
		public virtual unsafe string TargetId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='getTargetId' and count(parameter)=0]"
			[Register ("getTargetId", "()Ljava/lang/String;", "GetGetTargetIdHandler")]
			get {
				if (id_getTargetId == IntPtr.Zero)
					id_getTargetId = JNIEnv.GetMethodID (class_ref, "getTargetId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTargetId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTargetId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUnreadMessages;
#pragma warning disable 0169
		static Delegate GetGetUnreadMessagesHandler ()
		{
			if (cb_getUnreadMessages == null)
				cb_getUnreadMessages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUnreadMessages);
			return cb_getUnreadMessages;
		}

		static int n_GetUnreadMessages (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnreadMessages;
		}
#pragma warning restore 0169

		static Delegate cb_setUnreadMessages_I;
#pragma warning disable 0169
		static Delegate GetSetUnreadMessages_IHandler ()
		{
			if (cb_setUnreadMessages_I == null)
				cb_setUnreadMessages_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUnreadMessages_I);
			return cb_setUnreadMessages_I;
		}

		static void n_SetUnreadMessages_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnreadMessages = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUnreadMessages;
		static IntPtr id_setUnreadMessages_I;
		public virtual unsafe int UnreadMessages {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='getUnreadMessages' and count(parameter)=0]"
			[Register ("getUnreadMessages", "()I", "GetGetUnreadMessagesHandler")]
			get {
				if (id_getUnreadMessages == IntPtr.Zero)
					id_getUnreadMessages = JNIEnv.GetMethodID (class_ref, "getUnreadMessages", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getUnreadMessages);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUnreadMessages", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='setUnreadMessages' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUnreadMessages", "(I)V", "GetSetUnreadMessages_IHandler")]
			set {
				if (id_setUnreadMessages_I == IntPtr.Zero)
					id_setUnreadMessages_I = JNIEnv.GetMethodID (class_ref, "setUnreadMessages", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUnreadMessages_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUnreadMessages", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUpdateInProgress;
#pragma warning disable 0169
		static Delegate GetGetUpdateInProgressHandler ()
		{
			if (cb_getUpdateInProgress == null)
				cb_getUpdateInProgress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUpdateInProgress);
			return cb_getUpdateInProgress;
		}

		static int n_GetUpdateInProgress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UpdateInProgress;
		}
#pragma warning restore 0169

		static Delegate cb_setUpdateInProgress_I;
#pragma warning disable 0169
		static Delegate GetSetUpdateInProgress_IHandler ()
		{
			if (cb_setUpdateInProgress_I == null)
				cb_setUpdateInProgress_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUpdateInProgress_I);
			return cb_setUpdateInProgress_I;
		}

		static void n_SetUpdateInProgress_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateInProgress = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUpdateInProgress;
		static IntPtr id_setUpdateInProgress_I;
		public virtual unsafe int UpdateInProgress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='getUpdateInProgress' and count(parameter)=0]"
			[Register ("getUpdateInProgress", "()I", "GetGetUpdateInProgressHandler")]
			get {
				if (id_getUpdateInProgress == IntPtr.Zero)
					id_getUpdateInProgress = JNIEnv.GetMethodID (class_ref, "getUpdateInProgress", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getUpdateInProgress);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUpdateInProgress", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='setUpdateInProgress' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUpdateInProgress", "(I)V", "GetSetUpdateInProgress_IHandler")]
			set {
				if (id_setUpdateInProgress_I == IntPtr.Zero)
					id_setUpdateInProgress_I = JNIEnv.GetMethodID (class_ref, "setUpdateInProgress", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUpdateInProgress_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUpdateInProgress", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isShowedCSAT;
#pragma warning disable 0169
		static Delegate GetIsShowedCSATHandler ()
		{
			if (cb_isShowedCSAT == null)
				cb_isShowedCSAT = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsShowedCSAT);
			return cb_isShowedCSAT;
		}

		static IntPtr n_IsShowedCSAT (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsShowedCSAT ());
		}
#pragma warning restore 0169

		static IntPtr id_isShowedCSAT;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='isShowedCSAT' and count(parameter)=0]"
		[Register ("isShowedCSAT", "()Lcom/liveperson/api/response/types/CSAT$CSAT_SHOW_STATUS;", "GetIsShowedCSATHandler")]
		public virtual unsafe global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS IsShowedCSAT ()
		{
			if (id_isShowedCSAT == IntPtr.Zero)
				id_isShowedCSAT = JNIEnv.GetMethodID (class_ref, "isShowedCSAT", "()Lcom/liveperson/api/response/types/CSAT$CSAT_SHOW_STATUS;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_isShowedCSAT), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isShowedCSAT", "()Lcom/liveperson/api/response/types/CSAT$CSAT_SHOW_STATUS;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setAssignedAgentServerId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAssignedAgentServerId_Ljava_lang_String_Handler ()
		{
			if (cb_setAssignedAgentServerId_Ljava_lang_String_ == null)
				cb_setAssignedAgentServerId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAssignedAgentServerId_Ljava_lang_String_);
			return cb_setAssignedAgentServerId_Ljava_lang_String_;
		}

		static void n_SetAssignedAgentServerId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAssignedAgentServerId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAssignedAgentServerId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='setAssignedAgentServerId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAssignedAgentServerId", "(Ljava/lang/String;)V", "GetSetAssignedAgentServerId_Ljava_lang_String_Handler")]
		protected virtual unsafe void SetAssignedAgentServerId (string p0)
		{
			if (id_setAssignedAgentServerId_Ljava_lang_String_ == IntPtr.Zero)
				id_setAssignedAgentServerId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAssignedAgentServerId", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAssignedAgentServerId_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAssignedAgentServerId", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setBrandId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBrandId_Ljava_lang_String_Handler ()
		{
			if (cb_setBrandId_Ljava_lang_String_ == null)
				cb_setBrandId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBrandId_Ljava_lang_String_);
			return cb_setBrandId_Ljava_lang_String_;
		}

		static void n_SetBrandId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBrandId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBrandId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='setBrandId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setBrandId", "(Ljava/lang/String;)V", "GetSetBrandId_Ljava_lang_String_Handler")]
		protected virtual unsafe void SetBrandId (string p0)
		{
			if (id_setBrandId_Ljava_lang_String_ == IntPtr.Zero)
				id_setBrandId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBrandId", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBrandId_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBrandId", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setConversationTTRType_Lcom_liveperson_api_response_types_TTRType_;
#pragma warning disable 0169
		static Delegate GetSetConversationTTRType_Lcom_liveperson_api_response_types_TTRType_Handler ()
		{
			if (cb_setConversationTTRType_Lcom_liveperson_api_response_types_TTRType_ == null)
				cb_setConversationTTRType_Lcom_liveperson_api_response_types_TTRType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConversationTTRType_Lcom_liveperson_api_response_types_TTRType_);
			return cb_setConversationTTRType_Lcom_liveperson_api_response_types_TTRType_;
		}

		static void n_SetConversationTTRType_Lcom_liveperson_api_response_types_TTRType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Response.Types.TTRType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.TTRType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetConversationTTRType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setConversationTTRType_Lcom_liveperson_api_response_types_TTRType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='setConversationTTRType' and count(parameter)=1 and parameter[1][@type='com.liveperson.api.response.types.TTRType']]"
		[Register ("setConversationTTRType", "(Lcom/liveperson/api/response/types/TTRType;)V", "GetSetConversationTTRType_Lcom_liveperson_api_response_types_TTRType_Handler")]
		protected virtual unsafe void SetConversationTTRType (global::Com.Liveperson.Api.Response.Types.TTRType p0)
		{
			if (id_setConversationTTRType_Lcom_liveperson_api_response_types_TTRType_ == IntPtr.Zero)
				id_setConversationTTRType_Lcom_liveperson_api_response_types_TTRType_ = JNIEnv.GetMethodID (class_ref, "setConversationTTRType", "(Lcom/liveperson/api/response/types/TTRType;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConversationTTRType_Lcom_liveperson_api_response_types_TTRType_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConversationTTRType", "(Lcom/liveperson/api/response/types/TTRType;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setLastServerSequence_I;
#pragma warning disable 0169
		static Delegate GetSetLastServerSequence_IHandler ()
		{
			if (cb_setLastServerSequence_I == null)
				cb_setLastServerSequence_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLastServerSequence_I);
			return cb_setLastServerSequence_I;
		}

		static void n_SetLastServerSequence_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLastServerSequence (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLastServerSequence_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='setLastServerSequence' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLastServerSequence", "(I)V", "GetSetLastServerSequence_IHandler")]
		protected virtual unsafe void SetLastServerSequence (int p0)
		{
			if (id_setLastServerSequence_I == IntPtr.Zero)
				id_setLastServerSequence_I = JNIEnv.GetMethodID (class_ref, "setLastServerSequence", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastServerSequence_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastServerSequence", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setRequestId_J;
#pragma warning disable 0169
		static Delegate GetSetRequestId_JHandler ()
		{
			if (cb_setRequestId_J == null)
				cb_setRequestId_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetRequestId_J);
			return cb_setRequestId_J;
		}

		static void n_SetRequestId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRequestId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRequestId_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='setRequestId' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setRequestId", "(J)V", "GetSetRequestId_JHandler")]
		protected virtual unsafe void SetRequestId (long p0)
		{
			if (id_setRequestId_J == IntPtr.Zero)
				id_setRequestId_J = JNIEnv.GetMethodID (class_ref, "setRequestId", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRequestId_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequestId", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setServerId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetServerId_Ljava_lang_String_Handler ()
		{
			if (cb_setServerId_Ljava_lang_String_ == null)
				cb_setServerId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetServerId_Ljava_lang_String_);
			return cb_setServerId_Ljava_lang_String_;
		}

		static void n_SetServerId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetServerId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setServerId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='setServerId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setServerId", "(Ljava/lang/String;)V", "GetSetServerId_Ljava_lang_String_Handler")]
		protected virtual unsafe void SetServerId (string p0)
		{
			if (id_setServerId_Ljava_lang_String_ == IntPtr.Zero)
				id_setServerId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setServerId", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setServerId_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setServerId", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setShowedCSAT_Lcom_liveperson_api_response_types_CSAT_CSAT_SHOW_STATUS_;
#pragma warning disable 0169
		static Delegate GetSetShowedCSAT_Lcom_liveperson_api_response_types_CSAT_CSAT_SHOW_STATUS_Handler ()
		{
			if (cb_setShowedCSAT_Lcom_liveperson_api_response_types_CSAT_CSAT_SHOW_STATUS_ == null)
				cb_setShowedCSAT_Lcom_liveperson_api_response_types_CSAT_CSAT_SHOW_STATUS_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetShowedCSAT_Lcom_liveperson_api_response_types_CSAT_CSAT_SHOW_STATUS_);
			return cb_setShowedCSAT_Lcom_liveperson_api_response_types_CSAT_CSAT_SHOW_STATUS_;
		}

		static void n_SetShowedCSAT_Lcom_liveperson_api_response_types_CSAT_CSAT_SHOW_STATUS_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetShowedCSAT (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShowedCSAT_Lcom_liveperson_api_response_types_CSAT_CSAT_SHOW_STATUS_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='setShowedCSAT' and count(parameter)=1 and parameter[1][@type='com.liveperson.api.response.types.CSAT.CSAT_SHOW_STATUS']]"
		[Register ("setShowedCSAT", "(Lcom/liveperson/api/response/types/CSAT$CSAT_SHOW_STATUS;)V", "GetSetShowedCSAT_Lcom_liveperson_api_response_types_CSAT_CSAT_SHOW_STATUS_Handler")]
		protected virtual unsafe void SetShowedCSAT (global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS p0)
		{
			if (id_setShowedCSAT_Lcom_liveperson_api_response_types_CSAT_CSAT_SHOW_STATUS_ == IntPtr.Zero)
				id_setShowedCSAT_Lcom_liveperson_api_response_types_CSAT_CSAT_SHOW_STATUS_ = JNIEnv.GetMethodID (class_ref, "setShowedCSAT", "(Lcom/liveperson/api/response/types/CSAT$CSAT_SHOW_STATUS;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShowedCSAT_Lcom_liveperson_api_response_types_CSAT_CSAT_SHOW_STATUS_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShowedCSAT", "(Lcom/liveperson/api/response/types/CSAT$CSAT_SHOW_STATUS;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setState_Lcom_liveperson_api_response_types_ConversationState_;
#pragma warning disable 0169
		static Delegate GetSetState_Lcom_liveperson_api_response_types_ConversationState_Handler ()
		{
			if (cb_setState_Lcom_liveperson_api_response_types_ConversationState_ == null)
				cb_setState_Lcom_liveperson_api_response_types_ConversationState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetState_Lcom_liveperson_api_response_types_ConversationState_);
			return cb_setState_Lcom_liveperson_api_response_types_ConversationState_;
		}

		static void n_SetState_Lcom_liveperson_api_response_types_ConversationState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Response.Types.ConversationState p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.ConversationState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setState_Lcom_liveperson_api_response_types_ConversationState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Conversation']/method[@name='setState' and count(parameter)=1 and parameter[1][@type='com.liveperson.api.response.types.ConversationState']]"
		[Register ("setState", "(Lcom/liveperson/api/response/types/ConversationState;)V", "GetSetState_Lcom_liveperson_api_response_types_ConversationState_Handler")]
		protected virtual unsafe void SetState (global::Com.Liveperson.Api.Response.Types.ConversationState p0)
		{
			if (id_setState_Lcom_liveperson_api_response_types_ConversationState_ == IntPtr.Zero)
				id_setState_Lcom_liveperson_api_response_types_ConversationState_ = JNIEnv.GetMethodID (class_ref, "setState", "(Lcom/liveperson/api/response/types/ConversationState;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setState_Lcom_liveperson_api_response_types_ConversationState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setState", "(Lcom/liveperson/api/response/types/ConversationState;)V"), __args);
			} finally {
			}
		}

	}
}
