using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.View.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/class[@name='MessageRow']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/MessageRow", DoNotGenerateAcw=true)]
	public partial class MessageRow : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/view/adapter/MessageRow", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageRow); }
		}

		protected MessageRow (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_JI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/class[@name='MessageRow']/constructor[@name='MessageRow' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;JI)V", "")]
		public unsafe MessageRow (string message, long timestamp, int messageTypeInt)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_message);
				__args [1] = new JValue (timestamp);
				__args [2] = new JValue (messageTypeInt);
				if (((object) this).GetType () != typeof (MessageRow)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;JI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;JI)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_JI == IntPtr.Zero)
					id_ctor_Ljava_lang_String_JI = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;JI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_JI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_JI, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_getAgentAvatarUrl;
#pragma warning disable 0169
		static Delegate GetGetAgentAvatarUrlHandler ()
		{
			if (cb_getAgentAvatarUrl == null)
				cb_getAgentAvatarUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAgentAvatarUrl);
			return cb_getAgentAvatarUrl;
		}

		static IntPtr n_GetAgentAvatarUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessageRow __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessageRow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AgentAvatarUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setAgentAvatarUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAgentAvatarUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setAgentAvatarUrl_Ljava_lang_String_ == null)
				cb_setAgentAvatarUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAgentAvatarUrl_Ljava_lang_String_);
			return cb_setAgentAvatarUrl_Ljava_lang_String_;
		}

		static void n_SetAgentAvatarUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_avatarUrl)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessageRow __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessageRow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string avatarUrl = JNIEnv.GetString (native_avatarUrl, JniHandleOwnership.DoNotTransfer);
			__this.AgentAvatarUrl = avatarUrl;
		}
#pragma warning restore 0169

		static IntPtr id_getAgentAvatarUrl;
		static IntPtr id_setAgentAvatarUrl_Ljava_lang_String_;
		public virtual unsafe string AgentAvatarUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/class[@name='MessageRow']/method[@name='getAgentAvatarUrl' and count(parameter)=0]"
			[Register ("getAgentAvatarUrl", "()Ljava/lang/String;", "GetGetAgentAvatarUrlHandler")]
			get {
				if (id_getAgentAvatarUrl == IntPtr.Zero)
					id_getAgentAvatarUrl = JNIEnv.GetMethodID (class_ref, "getAgentAvatarUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAgentAvatarUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAgentAvatarUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/class[@name='MessageRow']/method[@name='setAgentAvatarUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAgentAvatarUrl", "(Ljava/lang/String;)V", "GetSetAgentAvatarUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setAgentAvatarUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setAgentAvatarUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAgentAvatarUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAgentAvatarUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAgentAvatarUrl", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessageRow __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessageRow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetEventId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventId)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessageRow __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessageRow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string eventId = JNIEnv.GetString (native_eventId, JniHandleOwnership.DoNotTransfer);
			__this.EventId = eventId;
		}
#pragma warning restore 0169

		static IntPtr id_getEventId;
		static IntPtr id_setEventId_Ljava_lang_String_;
		public virtual unsafe string EventId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/class[@name='MessageRow']/method[@name='getEventId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/class[@name='MessageRow']/method[@name='setEventId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessageRow __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessageRow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/class[@name='MessageRow']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
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
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessageRow __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessageRow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timestamp;
		}
#pragma warning restore 0169

		static IntPtr id_getTimestamp;
		public virtual unsafe long Timestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/class[@name='MessageRow']/method[@name='getTimestamp' and count(parameter)=0]"
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

		static Delegate cb_setMessageState_I;
#pragma warning disable 0169
		static Delegate GetSetMessageState_IHandler ()
		{
			if (cb_setMessageState_I == null)
				cb_setMessageState_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMessageState_I);
			return cb_setMessageState_I;
		}

		static void n_SetMessageState_I (IntPtr jnienv, IntPtr native__this, int messageStateInt)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessageRow __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.MessageRow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMessageState (messageStateInt);
		}
#pragma warning restore 0169

		static IntPtr id_setMessageState_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/class[@name='MessageRow']/method[@name='setMessageState' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMessageState", "(I)V", "GetSetMessageState_IHandler")]
		public virtual unsafe void SetMessageState (int messageStateInt)
		{
			if (id_setMessageState_I == IntPtr.Zero)
				id_setMessageState_I = JNIEnv.GetMethodID (class_ref, "setMessageState", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (messageStateInt);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessageState_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageState", "(I)V"), __args);
			} finally {
			}
		}

	}
}
