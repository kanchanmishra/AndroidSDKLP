using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='QuickRepliesMessageHolder']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/model/QuickRepliesMessageHolder", DoNotGenerateAcw=true)]
	public partial class QuickRepliesMessageHolder : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='QuickRepliesMessageHolder']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "QuickRepliesMessageHolder";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/model/QuickRepliesMessageHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QuickRepliesMessageHolder); }
		}

		protected QuickRepliesMessageHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_IZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='QuickRepliesMessageHolder']/constructor[@name='QuickRepliesMessageHolder' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int'] and parameter[6][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;IZ)V", "")]
		public unsafe QuickRepliesMessageHolder (string p0, string p1, long p2, string p3, int p4, bool p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				if (((object) this).GetType () != typeof (QuickRepliesMessageHolder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;IZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;IZ)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_IZ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_IZ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;IZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_IZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_IZ, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_isValid;
#pragma warning disable 0169
		static Delegate GetIsValidHandler ()
		{
			if (cb_isValid == null)
				cb_isValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsValid);
			return cb_isValid;
		}

		static bool n_IsValid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsValid;
		}
#pragma warning restore 0169

		static IntPtr id_isValid;
		public virtual unsafe bool IsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='QuickRepliesMessageHolder']/method[@name='isValid' and count(parameter)=0]"
			[Register ("isValid", "()Z", "GetIsValidHandler")]
			get {
				if (id_isValid == IntPtr.Zero)
					id_isValid = JNIEnv.GetMethodID (class_ref, "isValid", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isValid);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isValid", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getJsonString;
#pragma warning disable 0169
		static Delegate GetGetJsonStringHandler ()
		{
			if (cb_getJsonString == null)
				cb_getJsonString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJsonString);
			return cb_getJsonString;
		}

		static IntPtr n_GetJsonString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.JsonString);
		}
#pragma warning restore 0169

		static IntPtr id_getJsonString;
		public virtual unsafe string JsonString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='QuickRepliesMessageHolder']/method[@name='getJsonString' and count(parameter)=0]"
			[Register ("getJsonString", "()Ljava/lang/String;", "GetGetJsonStringHandler")]
			get {
				if (id_getJsonString == IntPtr.Zero)
					id_getJsonString = JNIEnv.GetMethodID (class_ref, "getJsonString", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getJsonString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJsonString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OriginatorId);
		}
#pragma warning restore 0169

		static IntPtr id_getOriginatorId;
		public virtual unsafe string OriginatorId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='QuickRepliesMessageHolder']/method[@name='getOriginatorId' and count(parameter)=0]"
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

		static Delegate cb_getQuickRepliesString;
#pragma warning disable 0169
		static Delegate GetGetQuickRepliesStringHandler ()
		{
			if (cb_getQuickRepliesString == null)
				cb_getQuickRepliesString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetQuickRepliesString);
			return cb_getQuickRepliesString;
		}

		static IntPtr n_GetQuickRepliesString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.QuickRepliesString);
		}
#pragma warning restore 0169

		static IntPtr id_getQuickRepliesString;
		public virtual unsafe string QuickRepliesString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='QuickRepliesMessageHolder']/method[@name='getQuickRepliesString' and count(parameter)=0]"
			[Register ("getQuickRepliesString", "()Ljava/lang/String;", "GetGetQuickRepliesStringHandler")]
			get {
				if (id_getQuickRepliesString == IntPtr.Zero)
					id_getQuickRepliesString = JNIEnv.GetMethodID (class_ref, "getQuickRepliesString", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getQuickRepliesString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQuickRepliesString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSequence;
#pragma warning disable 0169
		static Delegate GetGetSequenceHandler ()
		{
			if (cb_getSequence == null)
				cb_getSequence = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSequence);
			return cb_getSequence;
		}

		static int n_GetSequence (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Sequence;
		}
#pragma warning restore 0169

		static IntPtr id_getSequence;
		public virtual unsafe int Sequence {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='QuickRepliesMessageHolder']/method[@name='getSequence' and count(parameter)=0]"
			[Register ("getSequence", "()I", "GetGetSequenceHandler")]
			get {
				if (id_getSequence == IntPtr.Zero)
					id_getSequence = JNIEnv.GetMethodID (class_ref, "getSequence", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSequence);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSequence", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isShow;
#pragma warning disable 0169
		static Delegate GetIsShowHandler ()
		{
			if (cb_isShow == null)
				cb_isShow = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShow);
			return cb_isShow;
		}

		static bool n_IsShow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Show;
		}
#pragma warning restore 0169

		static Delegate cb_setShow_Z;
#pragma warning disable 0169
		static Delegate GetSetShow_ZHandler ()
		{
			if (cb_setShow_Z == null)
				cb_setShow_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShow_Z);
			return cb_setShow_Z;
		}

		static void n_SetShow_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Show = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isShow;
		static IntPtr id_setShow_Z;
		public virtual unsafe bool Show {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='QuickRepliesMessageHolder']/method[@name='isShow' and count(parameter)=0]"
			[Register ("isShow", "()Z", "GetIsShowHandler")]
			get {
				if (id_isShow == IntPtr.Zero)
					id_isShow = JNIEnv.GetMethodID (class_ref, "isShow", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isShow);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isShow", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='QuickRepliesMessageHolder']/method[@name='setShow' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShow", "(Z)V", "GetSetShow_ZHandler")]
			set {
				if (id_setShow_Z == IntPtr.Zero)
					id_setShow_Z = JNIEnv.GetMethodID (class_ref, "setShow", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShow_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShow", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTimestamp;
#pragma warning disable 0169
		static Delegate GetGetTimestampHandler ()
		{
			if (cb_getTimestamp == null)
				cb_getTimestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimestamp);
			return cb_getTimestamp;
		}

		static long n_GetTimestamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timestamp;
		}
#pragma warning restore 0169

		static IntPtr id_getTimestamp;
		public virtual unsafe long Timestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='QuickRepliesMessageHolder']/method[@name='getTimestamp' and count(parameter)=0]"
			[Register ("getTimestamp", "()J", "GetGetTimestampHandler")]
			get {
				if (id_getTimestamp == IntPtr.Zero)
					id_getTimestamp = JNIEnv.GetMethodID (class_ref, "getTimestamp", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTimestamp);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimestamp", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_deleteFromSharedPreferences;
#pragma warning disable 0169
		static Delegate GetDeleteFromSharedPreferencesHandler ()
		{
			if (cb_deleteFromSharedPreferences == null)
				cb_deleteFromSharedPreferences = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DeleteFromSharedPreferences);
			return cb_deleteFromSharedPreferences;
		}

		static void n_DeleteFromSharedPreferences (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteFromSharedPreferences ();
		}
#pragma warning restore 0169

		static IntPtr id_deleteFromSharedPreferences;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='QuickRepliesMessageHolder']/method[@name='deleteFromSharedPreferences' and count(parameter)=0]"
		[Register ("deleteFromSharedPreferences", "()V", "GetDeleteFromSharedPreferencesHandler")]
		public virtual unsafe void DeleteFromSharedPreferences ()
		{
			if (id_deleteFromSharedPreferences == IntPtr.Zero)
				id_deleteFromSharedPreferences = JNIEnv.GetMethodID (class_ref, "deleteFromSharedPreferences", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteFromSharedPreferences);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteFromSharedPreferences", "()V"));
			} finally {
			}
		}

		static IntPtr id_fromContentEventNotification_Ljava_lang_String_Lcom_liveperson_api_response_events_ContentEventNotification_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='QuickRepliesMessageHolder']/method[@name='fromContentEventNotification' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.api.response.events.ContentEventNotification']]"
		[Register ("fromContentEventNotification", "(Ljava/lang/String;Lcom/liveperson/api/response/events/ContentEventNotification;)Lcom/liveperson/messaging/model/QuickRepliesMessageHolder;", "")]
		public static unsafe global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder FromContentEventNotification (string p0, global::Com.Liveperson.Api.Response.Events.ContentEventNotification p1)
		{
			if (id_fromContentEventNotification_Ljava_lang_String_Lcom_liveperson_api_response_events_ContentEventNotification_ == IntPtr.Zero)
				id_fromContentEventNotification_Ljava_lang_String_Lcom_liveperson_api_response_events_ContentEventNotification_ = JNIEnv.GetStaticMethodID (class_ref, "fromContentEventNotification", "(Ljava/lang/String;Lcom/liveperson/api/response/events/ContentEventNotification;)Lcom/liveperson/messaging/model/QuickRepliesMessageHolder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromContentEventNotification_Ljava_lang_String_Lcom_liveperson_api_response_events_ContentEventNotification_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_fromJsonString_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='QuickRepliesMessageHolder']/method[@name='fromJsonString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("fromJsonString", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/messaging/model/QuickRepliesMessageHolder;", "")]
		public static unsafe global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder FromJsonString (string p0, string p1)
		{
			if (id_fromJsonString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_fromJsonString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromJsonString", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/messaging/model/QuickRepliesMessageHolder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromJsonString_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_loadFromSharedPreferences_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='QuickRepliesMessageHolder']/method[@name='loadFromSharedPreferences' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadFromSharedPreferences", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/QuickRepliesMessageHolder;", "")]
		public static unsafe global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder LoadFromSharedPreferences (string p0)
		{
			if (id_loadFromSharedPreferences_Ljava_lang_String_ == IntPtr.Zero)
				id_loadFromSharedPreferences_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "loadFromSharedPreferences", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/QuickRepliesMessageHolder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_loadFromSharedPreferences_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_newerOrEqualThan_Lcom_liveperson_messaging_model_QuickRepliesMessageHolder_;
#pragma warning disable 0169
		static Delegate GetNewerOrEqualThan_Lcom_liveperson_messaging_model_QuickRepliesMessageHolder_Handler ()
		{
			if (cb_newerOrEqualThan_Lcom_liveperson_messaging_model_QuickRepliesMessageHolder_ == null)
				cb_newerOrEqualThan_Lcom_liveperson_messaging_model_QuickRepliesMessageHolder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_NewerOrEqualThan_Lcom_liveperson_messaging_model_QuickRepliesMessageHolder_);
			return cb_newerOrEqualThan_Lcom_liveperson_messaging_model_QuickRepliesMessageHolder_;
		}

		static bool n_NewerOrEqualThan_Lcom_liveperson_messaging_model_QuickRepliesMessageHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.NewerOrEqualThan (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newerOrEqualThan_Lcom_liveperson_messaging_model_QuickRepliesMessageHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='QuickRepliesMessageHolder']/method[@name='newerOrEqualThan' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.QuickRepliesMessageHolder']]"
		[Register ("newerOrEqualThan", "(Lcom/liveperson/messaging/model/QuickRepliesMessageHolder;)Z", "GetNewerOrEqualThan_Lcom_liveperson_messaging_model_QuickRepliesMessageHolder_Handler")]
		public virtual unsafe bool NewerOrEqualThan (global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder p0)
		{
			if (id_newerOrEqualThan_Lcom_liveperson_messaging_model_QuickRepliesMessageHolder_ == IntPtr.Zero)
				id_newerOrEqualThan_Lcom_liveperson_messaging_model_QuickRepliesMessageHolder_ = JNIEnv.GetMethodID (class_ref, "newerOrEqualThan", "(Lcom/liveperson/messaging/model/QuickRepliesMessageHolder;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_newerOrEqualThan_Lcom_liveperson_messaging_model_QuickRepliesMessageHolder_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newerOrEqualThan", "(Lcom/liveperson/messaging/model/QuickRepliesMessageHolder;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_newerThan_Lcom_liveperson_messaging_model_QuickRepliesMessageHolder_;
#pragma warning disable 0169
		static Delegate GetNewerThan_Lcom_liveperson_messaging_model_QuickRepliesMessageHolder_Handler ()
		{
			if (cb_newerThan_Lcom_liveperson_messaging_model_QuickRepliesMessageHolder_ == null)
				cb_newerThan_Lcom_liveperson_messaging_model_QuickRepliesMessageHolder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_NewerThan_Lcom_liveperson_messaging_model_QuickRepliesMessageHolder_);
			return cb_newerThan_Lcom_liveperson_messaging_model_QuickRepliesMessageHolder_;
		}

		static bool n_NewerThan_Lcom_liveperson_messaging_model_QuickRepliesMessageHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.NewerThan (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newerThan_Lcom_liveperson_messaging_model_QuickRepliesMessageHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='QuickRepliesMessageHolder']/method[@name='newerThan' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.QuickRepliesMessageHolder']]"
		[Register ("newerThan", "(Lcom/liveperson/messaging/model/QuickRepliesMessageHolder;)Z", "GetNewerThan_Lcom_liveperson_messaging_model_QuickRepliesMessageHolder_Handler")]
		public virtual unsafe bool NewerThan (global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder p0)
		{
			if (id_newerThan_Lcom_liveperson_messaging_model_QuickRepliesMessageHolder_ == IntPtr.Zero)
				id_newerThan_Lcom_liveperson_messaging_model_QuickRepliesMessageHolder_ = JNIEnv.GetMethodID (class_ref, "newerThan", "(Lcom/liveperson/messaging/model/QuickRepliesMessageHolder;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_newerThan_Lcom_liveperson_messaging_model_QuickRepliesMessageHolder_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newerThan", "(Lcom/liveperson/messaging/model/QuickRepliesMessageHolder;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_writeToSharedPreferences;
#pragma warning disable 0169
		static Delegate GetWriteToSharedPreferencesHandler ()
		{
			if (cb_writeToSharedPreferences == null)
				cb_writeToSharedPreferences = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WriteToSharedPreferences);
			return cb_writeToSharedPreferences;
		}

		static void n_WriteToSharedPreferences (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteToSharedPreferences ();
		}
#pragma warning restore 0169

		static IntPtr id_writeToSharedPreferences;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='QuickRepliesMessageHolder']/method[@name='writeToSharedPreferences' and count(parameter)=0]"
		[Register ("writeToSharedPreferences", "()V", "GetWriteToSharedPreferencesHandler")]
		public virtual unsafe void WriteToSharedPreferences ()
		{
			if (id_writeToSharedPreferences == IntPtr.Zero)
				id_writeToSharedPreferences = JNIEnv.GetMethodID (class_ref, "writeToSharedPreferences", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToSharedPreferences);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToSharedPreferences", "()V"));
			} finally {
			}
		}

	}
}
