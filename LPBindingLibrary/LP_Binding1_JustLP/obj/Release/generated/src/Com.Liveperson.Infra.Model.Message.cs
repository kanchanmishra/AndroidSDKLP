using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='Message']"
	[global::Android.Runtime.Register ("com/liveperson/infra/model/Message", DoNotGenerateAcw=true)]
	public partial class Message : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='Message']/field[@name='EXTRA_MESSAGE_TEXT']"
		[Register ("EXTRA_MESSAGE_TEXT")]
		public const string ExtraMessageText = (string) "EXTRA_MESSAGE_TEXT";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/model/Message", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Message); }
		}

		protected Message (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_EncryptionVersion_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='Message']/constructor[@name='Message' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.liveperson.infra.utils.EncryptionVersion']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/utils/EncryptionVersion;)V", "")]
		public unsafe Message (string p0, string p1, long p2, string p3, string p4, global::Com.Liveperson.Infra.Utils.EncryptionVersion p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				if (((object) this).GetType () != typeof (Message)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/utils/EncryptionVersion;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/utils/EncryptionVersion;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_EncryptionVersion_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_EncryptionVersion_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/utils/EncryptionVersion;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_EncryptionVersion_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_EncryptionVersion_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_getContentType;
#pragma warning disable 0169
		static Delegate GetGetContentTypeHandler ()
		{
			if (cb_getContentType == null)
				cb_getContentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentType);
			return cb_getContentType;
		}

		static IntPtr n_GetContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Model.Message __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentType);
		}
#pragma warning restore 0169

		static Delegate cb_setContentType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentType_Ljava_lang_String_Handler ()
		{
			if (cb_setContentType_Ljava_lang_String_ == null)
				cb_setContentType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentType_Ljava_lang_String_);
			return cb_setContentType_Ljava_lang_String_;
		}

		static void n_SetContentType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Model.Message __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ContentType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContentType;
		static IntPtr id_setContentType_Ljava_lang_String_;
		public virtual unsafe string ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='Message']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Ljava/lang/String;", "GetGetContentTypeHandler")]
			get {
				if (id_getContentType == IntPtr.Zero)
					id_getContentType = JNIEnv.GetMethodID (class_ref, "getContentType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='Message']/method[@name='setContentType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContentType", "(Ljava/lang/String;)V", "GetSetContentType_Ljava_lang_String_Handler")]
			set {
				if (id_setContentType_Ljava_lang_String_ == IntPtr.Zero)
					id_setContentType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContentType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContentType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContentType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getConversationId;
#pragma warning disable 0169
		static Delegate GetGetConversationIdHandler ()
		{
			if (cb_getConversationId == null)
				cb_getConversationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConversationId);
			return cb_getConversationId;
		}

		static IntPtr n_GetConversationId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Model.Message __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConversationId);
		}
#pragma warning restore 0169

		static Delegate cb_setConversationId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetConversationId_Ljava_lang_String_Handler ()
		{
			if (cb_setConversationId_Ljava_lang_String_ == null)
				cb_setConversationId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConversationId_Ljava_lang_String_);
			return cb_setConversationId_Ljava_lang_String_;
		}

		static void n_SetConversationId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Model.Message __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConversationId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getConversationId;
		static IntPtr id_setConversationId_Ljava_lang_String_;
		public virtual unsafe string ConversationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='Message']/method[@name='getConversationId' and count(parameter)=0]"
			[Register ("getConversationId", "()Ljava/lang/String;", "GetGetConversationIdHandler")]
			get {
				if (id_getConversationId == IntPtr.Zero)
					id_getConversationId = JNIEnv.GetMethodID (class_ref, "getConversationId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='Message']/method[@name='setConversationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setConversationId", "(Ljava/lang/String;)V", "GetSetConversationId_Ljava_lang_String_Handler")]
			set {
				if (id_setConversationId_Ljava_lang_String_ == IntPtr.Zero)
					id_setConversationId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setConversationId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConversationId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConversationId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEventId;
#pragma warning disable 0169
		static Delegate GetGetEventIdHandler ()
		{
			if (cb_getEventId == null)
				cb_getEventId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventId);
			return cb_getEventId;
		}

		static IntPtr n_GetEventId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Model.Message __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EventId);
		}
#pragma warning restore 0169

		static Delegate cb_setEventId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEventId_Ljava_lang_String_Handler ()
		{
			if (cb_setEventId_Ljava_lang_String_ == null)
				cb_setEventId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEventId_Ljava_lang_String_);
			return cb_setEventId_Ljava_lang_String_;
		}

		static void n_SetEventId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Model.Message __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EventId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEventId;
		static IntPtr id_setEventId_Ljava_lang_String_;
		public virtual unsafe string EventId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='Message']/method[@name='getEventId' and count(parameter)=0]"
			[Register ("getEventId", "()Ljava/lang/String;", "GetGetEventIdHandler")]
			get {
				if (id_getEventId == IntPtr.Zero)
					id_getEventId = JNIEnv.GetMethodID (class_ref, "getEventId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEventId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEventId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='Message']/method[@name='setEventId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEventId", "(Ljava/lang/String;)V", "GetSetEventId_Ljava_lang_String_Handler")]
			set {
				if (id_setEventId_Ljava_lang_String_ == IntPtr.Zero)
					id_setEventId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEventId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEventId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEventId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFullTimeString;
#pragma warning disable 0169
		static Delegate GetGetFullTimeStringHandler ()
		{
			if (cb_getFullTimeString == null)
				cb_getFullTimeString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFullTimeString);
			return cb_getFullTimeString;
		}

		static IntPtr n_GetFullTimeString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Model.Message __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FullTimeString);
		}
#pragma warning restore 0169

		static IntPtr id_getFullTimeString;
		public virtual unsafe string FullTimeString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='Message']/method[@name='getFullTimeString' and count(parameter)=0]"
			[Register ("getFullTimeString", "()Ljava/lang/String;", "GetGetFullTimeStringHandler")]
			get {
				if (id_getFullTimeString == IntPtr.Zero)
					id_getFullTimeString = JNIEnv.GetMethodID (class_ref, "getFullTimeString", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFullTimeString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFullTimeString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLocalId;
#pragma warning disable 0169
		static Delegate GetGetLocalIdHandler ()
		{
			if (cb_getLocalId == null)
				cb_getLocalId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLocalId);
			return cb_getLocalId;
		}

		static long n_GetLocalId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Model.Message __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LocalId;
		}
#pragma warning restore 0169

		static IntPtr id_getLocalId;
		public virtual unsafe long LocalId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='Message']/method[@name='getLocalId' and count(parameter)=0]"
			[Register ("getLocalId", "()J", "GetGetLocalIdHandler")]
			get {
				if (id_getLocalId == IntPtr.Zero)
					id_getLocalId = JNIEnv.GetMethodID (class_ref, "getLocalId", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLocalId);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocalId", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getOriginatorId;
#pragma warning disable 0169
		static Delegate GetGetOriginatorIdHandler ()
		{
			if (cb_getOriginatorId == null)
				cb_getOriginatorId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOriginatorId);
			return cb_getOriginatorId;
		}

		static IntPtr n_GetOriginatorId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Model.Message __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OriginatorId);
		}
#pragma warning restore 0169

		static IntPtr id_getOriginatorId;
		public virtual unsafe string OriginatorId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='Message']/method[@name='getOriginatorId' and count(parameter)=0]"
			[Register ("getOriginatorId", "()Ljava/lang/String;", "GetGetOriginatorIdHandler")]
			get {
				if (id_getOriginatorId == IntPtr.Zero)
					id_getOriginatorId = JNIEnv.GetMethodID (class_ref, "getOriginatorId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOriginatorId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOriginatorId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getServerSequence;
#pragma warning disable 0169
		static Delegate GetGetServerSequenceHandler ()
		{
			if (cb_getServerSequence == null)
				cb_getServerSequence = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetServerSequence);
			return cb_getServerSequence;
		}

		static int n_GetServerSequence (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Model.Message __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ServerSequence;
		}
#pragma warning restore 0169

		static Delegate cb_setServerSequence_I;
#pragma warning disable 0169
		static Delegate GetSetServerSequence_IHandler ()
		{
			if (cb_setServerSequence_I == null)
				cb_setServerSequence_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetServerSequence_I);
			return cb_setServerSequence_I;
		}

		static void n_SetServerSequence_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Infra.Model.Message __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ServerSequence = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getServerSequence;
		static IntPtr id_setServerSequence_I;
		public virtual unsafe int ServerSequence {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='Message']/method[@name='getServerSequence' and count(parameter)=0]"
			[Register ("getServerSequence", "()I", "GetGetServerSequenceHandler")]
			get {
				if (id_getServerSequence == IntPtr.Zero)
					id_getServerSequence = JNIEnv.GetMethodID (class_ref, "getServerSequence", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getServerSequence);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServerSequence", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='Message']/method[@name='setServerSequence' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setServerSequence", "(I)V", "GetSetServerSequence_IHandler")]
			set {
				if (id_setServerSequence_I == IntPtr.Zero)
					id_setServerSequence_I = JNIEnv.GetMethodID (class_ref, "setServerSequence", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setServerSequence_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setServerSequence", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTimeStamp;
#pragma warning disable 0169
		static Delegate GetGetTimeStampHandler ()
		{
			if (cb_getTimeStamp == null)
				cb_getTimeStamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimeStamp);
			return cb_getTimeStamp;
		}

		static long n_GetTimeStamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Model.Message __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeStamp;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeStamp;
		public virtual unsafe long TimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='Message']/method[@name='getTimeStamp' and count(parameter)=0]"
			[Register ("getTimeStamp", "()J", "GetGetTimeStampHandler")]
			get {
				if (id_getTimeStamp == IntPtr.Zero)
					id_getTimeStamp = JNIEnv.GetMethodID (class_ref, "getTimeStamp", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTimeStamp);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeStamp", "()J"));
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
			global::Com.Liveperson.Infra.Model.Message __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetMessage ());
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='Message']/method[@name='getMessage' and count(parameter)=0]"
		[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
		public virtual unsafe string GetMessage ()
		{
			if (id_getMessage == IntPtr.Zero)
				id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMessageId_J;
#pragma warning disable 0169
		static Delegate GetSetMessageId_JHandler ()
		{
			if (cb_setMessageId_J == null)
				cb_setMessageId_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetMessageId_J);
			return cb_setMessageId_J;
		}

		static void n_SetMessageId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Infra.Model.Message __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMessageId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMessageId_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='Message']/method[@name='setMessageId' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setMessageId", "(J)V", "GetSetMessageId_JHandler")]
		public virtual unsafe void SetMessageId (long p0)
		{
			if (id_setMessageId_J == IntPtr.Zero)
				id_setMessageId_J = JNIEnv.GetMethodID (class_ref, "setMessageId", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessageId_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageId", "(J)V"), __args);
			} finally {
			}
		}

	}
}
