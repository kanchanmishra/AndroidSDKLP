using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='LivePersonEventsProxy']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/LivePersonEventsProxy", DoNotGenerateAcw=true)]
	public partial class LivePersonEventsProxy : global::Java.Lang.Object, global::Com.Liveperson.Api.ILivePersonCallback {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/LivePersonEventsProxy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LivePersonEventsProxy); }
		}

		protected LivePersonEventsProxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_onAgentAvatarTapped_Lcom_liveperson_messaging_model_AgentData_;
#pragma warning disable 0169
		static Delegate GetOnAgentAvatarTapped_Lcom_liveperson_messaging_model_AgentData_Handler ()
		{
			if (cb_onAgentAvatarTapped_Lcom_liveperson_messaging_model_AgentData_ == null)
				cb_onAgentAvatarTapped_Lcom_liveperson_messaging_model_AgentData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAgentAvatarTapped_Lcom_liveperson_messaging_model_AgentData_);
			return cb_onAgentAvatarTapped_Lcom_liveperson_messaging_model_AgentData_;
		}

		static void n_OnAgentAvatarTapped_Lcom_liveperson_messaging_model_AgentData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.LivePersonEventsProxy __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.LivePersonEventsProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.AgentData p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AgentData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAgentAvatarTapped (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onAgentAvatarTapped_Lcom_liveperson_messaging_model_AgentData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='LivePersonEventsProxy']/method[@name='onAgentAvatarTapped' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.AgentData']]"
		[Register ("onAgentAvatarTapped", "(Lcom/liveperson/messaging/model/AgentData;)V", "GetOnAgentAvatarTapped_Lcom_liveperson_messaging_model_AgentData_Handler")]
		public virtual unsafe void OnAgentAvatarTapped (global::Com.Liveperson.Messaging.Model.AgentData p0)
		{
			if (id_onAgentAvatarTapped_Lcom_liveperson_messaging_model_AgentData_ == IntPtr.Zero)
				id_onAgentAvatarTapped_Lcom_liveperson_messaging_model_AgentData_ = JNIEnv.GetMethodID (class_ref, "onAgentAvatarTapped", "(Lcom/liveperson/messaging/model/AgentData;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAgentAvatarTapped_Lcom_liveperson_messaging_model_AgentData_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAgentAvatarTapped", "(Lcom/liveperson/messaging/model/AgentData;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onAgentDetailsChanged_Lcom_liveperson_messaging_model_AgentData_;
#pragma warning disable 0169
		static Delegate GetOnAgentDetailsChanged_Lcom_liveperson_messaging_model_AgentData_Handler ()
		{
			if (cb_onAgentDetailsChanged_Lcom_liveperson_messaging_model_AgentData_ == null)
				cb_onAgentDetailsChanged_Lcom_liveperson_messaging_model_AgentData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAgentDetailsChanged_Lcom_liveperson_messaging_model_AgentData_);
			return cb_onAgentDetailsChanged_Lcom_liveperson_messaging_model_AgentData_;
		}

		static void n_OnAgentDetailsChanged_Lcom_liveperson_messaging_model_AgentData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.LivePersonEventsProxy __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.LivePersonEventsProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.AgentData p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AgentData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAgentDetailsChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onAgentDetailsChanged_Lcom_liveperson_messaging_model_AgentData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='LivePersonEventsProxy']/method[@name='onAgentDetailsChanged' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.AgentData']]"
		[Register ("onAgentDetailsChanged", "(Lcom/liveperson/messaging/model/AgentData;)V", "GetOnAgentDetailsChanged_Lcom_liveperson_messaging_model_AgentData_Handler")]
		public virtual unsafe void OnAgentDetailsChanged (global::Com.Liveperson.Messaging.Model.AgentData p0)
		{
			if (id_onAgentDetailsChanged_Lcom_liveperson_messaging_model_AgentData_ == IntPtr.Zero)
				id_onAgentDetailsChanged_Lcom_liveperson_messaging_model_AgentData_ = JNIEnv.GetMethodID (class_ref, "onAgentDetailsChanged", "(Lcom/liveperson/messaging/model/AgentData;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAgentDetailsChanged_Lcom_liveperson_messaging_model_AgentData_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAgentDetailsChanged", "(Lcom/liveperson/messaging/model/AgentData;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onAgentTyping_Z;
#pragma warning disable 0169
		static Delegate GetOnAgentTyping_ZHandler ()
		{
			if (cb_onAgentTyping_Z == null)
				cb_onAgentTyping_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnAgentTyping_Z);
			return cb_onAgentTyping_Z;
		}

		static void n_OnAgentTyping_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Messaging.LivePersonEventsProxy __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.LivePersonEventsProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAgentTyping (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onAgentTyping_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='LivePersonEventsProxy']/method[@name='onAgentTyping' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onAgentTyping", "(Z)V", "GetOnAgentTyping_ZHandler")]
		public virtual unsafe void OnAgentTyping (bool p0)
		{
			if (id_onAgentTyping_Z == IntPtr.Zero)
				id_onAgentTyping_Z = JNIEnv.GetMethodID (class_ref, "onAgentTyping", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAgentTyping_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAgentTyping", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onConnectionChanged_Z;
#pragma warning disable 0169
		static Delegate GetOnConnectionChanged_ZHandler ()
		{
			if (cb_onConnectionChanged_Z == null)
				cb_onConnectionChanged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnConnectionChanged_Z);
			return cb_onConnectionChanged_Z;
		}

		static void n_OnConnectionChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Messaging.LivePersonEventsProxy __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.LivePersonEventsProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConnectionChanged_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='LivePersonEventsProxy']/method[@name='onConnectionChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onConnectionChanged", "(Z)V", "GetOnConnectionChanged_ZHandler")]
		public virtual unsafe void OnConnectionChanged (bool p0)
		{
			if (id_onConnectionChanged_Z == IntPtr.Zero)
				id_onConnectionChanged_Z = JNIEnv.GetMethodID (class_ref, "onConnectionChanged", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionChanged_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnectionChanged", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onConversationMarkedAsNormal;
#pragma warning disable 0169
		static Delegate GetOnConversationMarkedAsNormalHandler ()
		{
			if (cb_onConversationMarkedAsNormal == null)
				cb_onConversationMarkedAsNormal = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnConversationMarkedAsNormal);
			return cb_onConversationMarkedAsNormal;
		}

		static void n_OnConversationMarkedAsNormal (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.LivePersonEventsProxy __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.LivePersonEventsProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConversationMarkedAsNormal ();
		}
#pragma warning restore 0169

		static IntPtr id_onConversationMarkedAsNormal;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='LivePersonEventsProxy']/method[@name='onConversationMarkedAsNormal' and count(parameter)=0]"
		[Register ("onConversationMarkedAsNormal", "()V", "GetOnConversationMarkedAsNormalHandler")]
		public virtual unsafe void OnConversationMarkedAsNormal ()
		{
			if (id_onConversationMarkedAsNormal == IntPtr.Zero)
				id_onConversationMarkedAsNormal = JNIEnv.GetMethodID (class_ref, "onConversationMarkedAsNormal", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConversationMarkedAsNormal);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConversationMarkedAsNormal", "()V"));
			} finally {
			}
		}

		static Delegate cb_onConversationMarkedAsUrgent;
#pragma warning disable 0169
		static Delegate GetOnConversationMarkedAsUrgentHandler ()
		{
			if (cb_onConversationMarkedAsUrgent == null)
				cb_onConversationMarkedAsUrgent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnConversationMarkedAsUrgent);
			return cb_onConversationMarkedAsUrgent;
		}

		static void n_OnConversationMarkedAsUrgent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.LivePersonEventsProxy __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.LivePersonEventsProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConversationMarkedAsUrgent ();
		}
#pragma warning restore 0169

		static IntPtr id_onConversationMarkedAsUrgent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='LivePersonEventsProxy']/method[@name='onConversationMarkedAsUrgent' and count(parameter)=0]"
		[Register ("onConversationMarkedAsUrgent", "()V", "GetOnConversationMarkedAsUrgentHandler")]
		public virtual unsafe void OnConversationMarkedAsUrgent ()
		{
			if (id_onConversationMarkedAsUrgent == IntPtr.Zero)
				id_onConversationMarkedAsUrgent = JNIEnv.GetMethodID (class_ref, "onConversationMarkedAsUrgent", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConversationMarkedAsUrgent);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConversationMarkedAsUrgent", "()V"));
			} finally {
			}
		}

		static Delegate cb_onConversationResolved;
#pragma warning disable 0169
		static Delegate GetOnConversationResolvedHandler ()
		{
			if (cb_onConversationResolved == null)
				cb_onConversationResolved = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnConversationResolved);
			return cb_onConversationResolved;
		}

		static void n_OnConversationResolved (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.LivePersonEventsProxy __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.LivePersonEventsProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConversationResolved ();
		}
#pragma warning restore 0169

		static IntPtr id_onConversationResolved;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='LivePersonEventsProxy']/method[@name='onConversationResolved' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("onConversationResolved", "()V", "GetOnConversationResolvedHandler")]
		public virtual unsafe void OnConversationResolved ()
		{
			if (id_onConversationResolved == IntPtr.Zero)
				id_onConversationResolved = JNIEnv.GetMethodID (class_ref, "onConversationResolved", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConversationResolved);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConversationResolved", "()V"));
			} finally {
			}
		}

		static Delegate cb_onConversationResolved_Lcom_liveperson_api_response_types_CloseReason_;
#pragma warning disable 0169
		static Delegate GetOnConversationResolved_Lcom_liveperson_api_response_types_CloseReason_Handler ()
		{
			if (cb_onConversationResolved_Lcom_liveperson_api_response_types_CloseReason_ == null)
				cb_onConversationResolved_Lcom_liveperson_api_response_types_CloseReason_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConversationResolved_Lcom_liveperson_api_response_types_CloseReason_);
			return cb_onConversationResolved_Lcom_liveperson_api_response_types_CloseReason_;
		}

		static void n_OnConversationResolved_Lcom_liveperson_api_response_types_CloseReason_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.LivePersonEventsProxy __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.LivePersonEventsProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Response.Types.CloseReason p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CloseReason> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConversationResolved (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConversationResolved_Lcom_liveperson_api_response_types_CloseReason_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='LivePersonEventsProxy']/method[@name='onConversationResolved' and count(parameter)=1 and parameter[1][@type='com.liveperson.api.response.types.CloseReason']]"
		[Obsolete (@"deprecated")]
		[Register ("onConversationResolved", "(Lcom/liveperson/api/response/types/CloseReason;)V", "GetOnConversationResolved_Lcom_liveperson_api_response_types_CloseReason_Handler")]
		public virtual unsafe void OnConversationResolved (global::Com.Liveperson.Api.Response.Types.CloseReason p0)
		{
			if (id_onConversationResolved_Lcom_liveperson_api_response_types_CloseReason_ == IntPtr.Zero)
				id_onConversationResolved_Lcom_liveperson_api_response_types_CloseReason_ = JNIEnv.GetMethodID (class_ref, "onConversationResolved", "(Lcom/liveperson/api/response/types/CloseReason;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConversationResolved_Lcom_liveperson_api_response_types_CloseReason_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConversationResolved", "(Lcom/liveperson/api/response/types/CloseReason;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onConversationResolved_Lcom_liveperson_api_sdk_LPConversationData_;
#pragma warning disable 0169
		static Delegate GetOnConversationResolved_Lcom_liveperson_api_sdk_LPConversationData_Handler ()
		{
			if (cb_onConversationResolved_Lcom_liveperson_api_sdk_LPConversationData_ == null)
				cb_onConversationResolved_Lcom_liveperson_api_sdk_LPConversationData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConversationResolved_Lcom_liveperson_api_sdk_LPConversationData_);
			return cb_onConversationResolved_Lcom_liveperson_api_sdk_LPConversationData_;
		}

		static void n_OnConversationResolved_Lcom_liveperson_api_sdk_LPConversationData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.LivePersonEventsProxy __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.LivePersonEventsProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Sdk.LPConversationData p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Sdk.LPConversationData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConversationResolved (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConversationResolved_Lcom_liveperson_api_sdk_LPConversationData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='LivePersonEventsProxy']/method[@name='onConversationResolved' and count(parameter)=1 and parameter[1][@type='com.liveperson.api.sdk.LPConversationData']]"
		[Register ("onConversationResolved", "(Lcom/liveperson/api/sdk/LPConversationData;)V", "GetOnConversationResolved_Lcom_liveperson_api_sdk_LPConversationData_Handler")]
		public virtual unsafe void OnConversationResolved (global::Com.Liveperson.Api.Sdk.LPConversationData p0)
		{
			if (id_onConversationResolved_Lcom_liveperson_api_sdk_LPConversationData_ == IntPtr.Zero)
				id_onConversationResolved_Lcom_liveperson_api_sdk_LPConversationData_ = JNIEnv.GetMethodID (class_ref, "onConversationResolved", "(Lcom/liveperson/api/sdk/LPConversationData;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConversationResolved_Lcom_liveperson_api_sdk_LPConversationData_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConversationResolved", "(Lcom/liveperson/api/sdk/LPConversationData;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onConversationStarted;
#pragma warning disable 0169
		static Delegate GetOnConversationStartedHandler ()
		{
			if (cb_onConversationStarted == null)
				cb_onConversationStarted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnConversationStarted);
			return cb_onConversationStarted;
		}

		static void n_OnConversationStarted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.LivePersonEventsProxy __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.LivePersonEventsProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConversationStarted ();
		}
#pragma warning restore 0169

		static IntPtr id_onConversationStarted;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='LivePersonEventsProxy']/method[@name='onConversationStarted' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("onConversationStarted", "()V", "GetOnConversationStartedHandler")]
		public virtual unsafe void OnConversationStarted ()
		{
			if (id_onConversationStarted == IntPtr.Zero)
				id_onConversationStarted = JNIEnv.GetMethodID (class_ref, "onConversationStarted", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConversationStarted);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConversationStarted", "()V"));
			} finally {
			}
		}

		static Delegate cb_onConversationStarted_Lcom_liveperson_api_sdk_LPConversationData_;
#pragma warning disable 0169
		static Delegate GetOnConversationStarted_Lcom_liveperson_api_sdk_LPConversationData_Handler ()
		{
			if (cb_onConversationStarted_Lcom_liveperson_api_sdk_LPConversationData_ == null)
				cb_onConversationStarted_Lcom_liveperson_api_sdk_LPConversationData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConversationStarted_Lcom_liveperson_api_sdk_LPConversationData_);
			return cb_onConversationStarted_Lcom_liveperson_api_sdk_LPConversationData_;
		}

		static void n_OnConversationStarted_Lcom_liveperson_api_sdk_LPConversationData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.LivePersonEventsProxy __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.LivePersonEventsProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Sdk.LPConversationData p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Sdk.LPConversationData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConversationStarted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConversationStarted_Lcom_liveperson_api_sdk_LPConversationData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='LivePersonEventsProxy']/method[@name='onConversationStarted' and count(parameter)=1 and parameter[1][@type='com.liveperson.api.sdk.LPConversationData']]"
		[Register ("onConversationStarted", "(Lcom/liveperson/api/sdk/LPConversationData;)V", "GetOnConversationStarted_Lcom_liveperson_api_sdk_LPConversationData_Handler")]
		public virtual unsafe void OnConversationStarted (global::Com.Liveperson.Api.Sdk.LPConversationData p0)
		{
			if (id_onConversationStarted_Lcom_liveperson_api_sdk_LPConversationData_ == IntPtr.Zero)
				id_onConversationStarted_Lcom_liveperson_api_sdk_LPConversationData_ = JNIEnv.GetMethodID (class_ref, "onConversationStarted", "(Lcom/liveperson/api/sdk/LPConversationData;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConversationStarted_Lcom_liveperson_api_sdk_LPConversationData_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConversationStarted", "(Lcom/liveperson/api/sdk/LPConversationData;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onCsatDismissed;
#pragma warning disable 0169
		static Delegate GetOnCsatDismissedHandler ()
		{
			if (cb_onCsatDismissed == null)
				cb_onCsatDismissed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCsatDismissed);
			return cb_onCsatDismissed;
		}

		static void n_OnCsatDismissed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.LivePersonEventsProxy __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.LivePersonEventsProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCsatDismissed ();
		}
#pragma warning restore 0169

		static IntPtr id_onCsatDismissed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='LivePersonEventsProxy']/method[@name='onCsatDismissed' and count(parameter)=0]"
		[Register ("onCsatDismissed", "()V", "GetOnCsatDismissedHandler")]
		public virtual unsafe void OnCsatDismissed ()
		{
			if (id_onCsatDismissed == IntPtr.Zero)
				id_onCsatDismissed = JNIEnv.GetMethodID (class_ref, "onCsatDismissed", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCsatDismissed);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCsatDismissed", "()V"));
			} finally {
			}
		}

		static Delegate cb_onCsatLaunched;
#pragma warning disable 0169
		static Delegate GetOnCsatLaunchedHandler ()
		{
			if (cb_onCsatLaunched == null)
				cb_onCsatLaunched = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCsatLaunched);
			return cb_onCsatLaunched;
		}

		static void n_OnCsatLaunched (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.LivePersonEventsProxy __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.LivePersonEventsProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCsatLaunched ();
		}
#pragma warning restore 0169

		static IntPtr id_onCsatLaunched;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='LivePersonEventsProxy']/method[@name='onCsatLaunched' and count(parameter)=0]"
		[Register ("onCsatLaunched", "()V", "GetOnCsatLaunchedHandler")]
		public virtual unsafe void OnCsatLaunched ()
		{
			if (id_onCsatLaunched == IntPtr.Zero)
				id_onCsatLaunched = JNIEnv.GetMethodID (class_ref, "onCsatLaunched", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCsatLaunched);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCsatLaunched", "()V"));
			} finally {
			}
		}

		static Delegate cb_onCsatSkipped;
#pragma warning disable 0169
		static Delegate GetOnCsatSkippedHandler ()
		{
			if (cb_onCsatSkipped == null)
				cb_onCsatSkipped = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCsatSkipped);
			return cb_onCsatSkipped;
		}

		static void n_OnCsatSkipped (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.LivePersonEventsProxy __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.LivePersonEventsProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCsatSkipped ();
		}
#pragma warning restore 0169

		static IntPtr id_onCsatSkipped;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='LivePersonEventsProxy']/method[@name='onCsatSkipped' and count(parameter)=0]"
		[Register ("onCsatSkipped", "()V", "GetOnCsatSkippedHandler")]
		public virtual unsafe void OnCsatSkipped ()
		{
			if (id_onCsatSkipped == IntPtr.Zero)
				id_onCsatSkipped = JNIEnv.GetMethodID (class_ref, "onCsatSkipped", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCsatSkipped);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCsatSkipped", "()V"));
			} finally {
			}
		}

		static Delegate cb_onCsatSubmitted_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnCsatSubmitted_Ljava_lang_String_Handler ()
		{
			if (cb_onCsatSubmitted_Ljava_lang_String_ == null)
				cb_onCsatSubmitted_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCsatSubmitted_Ljava_lang_String_);
			return cb_onCsatSubmitted_Ljava_lang_String_;
		}

		static void n_OnCsatSubmitted_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.LivePersonEventsProxy __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.LivePersonEventsProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCsatSubmitted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCsatSubmitted_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='LivePersonEventsProxy']/method[@name='onCsatSubmitted' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onCsatSubmitted", "(Ljava/lang/String;)V", "GetOnCsatSubmitted_Ljava_lang_String_Handler")]
		public virtual unsafe void OnCsatSubmitted (string p0)
		{
			if (id_onCsatSubmitted_Ljava_lang_String_ == IntPtr.Zero)
				id_onCsatSubmitted_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onCsatSubmitted", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCsatSubmitted_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCsatSubmitted", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onError_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_Handler ()
		{
			if (cb_onError_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_ == null)
				cb_onError_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnError_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_);
			return cb_onError_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_;
		}

		static void n_OnError_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.LivePersonEventsProxy __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.LivePersonEventsProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.TaskType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.TaskType> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onError_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='LivePersonEventsProxy']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='com.liveperson.messaging.TaskType'] and parameter[2][@type='java.lang.String']]"
		[Register ("onError", "(Lcom/liveperson/messaging/TaskType;Ljava/lang/String;)V", "GetOnError_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_Handler")]
		public virtual unsafe void OnError (global::Com.Liveperson.Messaging.TaskType p0, string p1)
		{
			if (id_onError_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_ == IntPtr.Zero)
				id_onError_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/liveperson/messaging/TaskType;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onError", "(Lcom/liveperson/messaging/TaskType;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_onOfflineHoursChanges_Z;
#pragma warning disable 0169
		static Delegate GetOnOfflineHoursChanges_ZHandler ()
		{
			if (cb_onOfflineHoursChanges_Z == null)
				cb_onOfflineHoursChanges_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnOfflineHoursChanges_Z);
			return cb_onOfflineHoursChanges_Z;
		}

		static void n_OnOfflineHoursChanges_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Messaging.LivePersonEventsProxy __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.LivePersonEventsProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnOfflineHoursChanges (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onOfflineHoursChanges_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='LivePersonEventsProxy']/method[@name='onOfflineHoursChanges' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onOfflineHoursChanges", "(Z)V", "GetOnOfflineHoursChanges_ZHandler")]
		public virtual unsafe void OnOfflineHoursChanges (bool p0)
		{
			if (id_onOfflineHoursChanges_Z == IntPtr.Zero)
				id_onOfflineHoursChanges_Z = JNIEnv.GetMethodID (class_ref, "onOfflineHoursChanges", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onOfflineHoursChanges_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onOfflineHoursChanges", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onStructuredContentLinkClicked_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnStructuredContentLinkClicked_Ljava_lang_String_Handler ()
		{
			if (cb_onStructuredContentLinkClicked_Ljava_lang_String_ == null)
				cb_onStructuredContentLinkClicked_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStructuredContentLinkClicked_Ljava_lang_String_);
			return cb_onStructuredContentLinkClicked_Ljava_lang_String_;
		}

		static void n_OnStructuredContentLinkClicked_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.LivePersonEventsProxy __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.LivePersonEventsProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnStructuredContentLinkClicked (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onStructuredContentLinkClicked_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='LivePersonEventsProxy']/method[@name='onStructuredContentLinkClicked' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onStructuredContentLinkClicked", "(Ljava/lang/String;)V", "GetOnStructuredContentLinkClicked_Ljava_lang_String_Handler")]
		public virtual unsafe void OnStructuredContentLinkClicked (string p0)
		{
			if (id_onStructuredContentLinkClicked_Ljava_lang_String_ == IntPtr.Zero)
				id_onStructuredContentLinkClicked_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onStructuredContentLinkClicked", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStructuredContentLinkClicked_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStructuredContentLinkClicked", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onTokenExpired;
#pragma warning disable 0169
		static Delegate GetOnTokenExpiredHandler ()
		{
			if (cb_onTokenExpired == null)
				cb_onTokenExpired = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnTokenExpired);
			return cb_onTokenExpired;
		}

		static void n_OnTokenExpired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.LivePersonEventsProxy __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.LivePersonEventsProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTokenExpired ();
		}
#pragma warning restore 0169

		static IntPtr id_onTokenExpired;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='LivePersonEventsProxy']/method[@name='onTokenExpired' and count(parameter)=0]"
		[Register ("onTokenExpired", "()V", "GetOnTokenExpiredHandler")]
		public virtual unsafe void OnTokenExpired ()
		{
			if (id_onTokenExpired == IntPtr.Zero)
				id_onTokenExpired = JNIEnv.GetMethodID (class_ref, "onTokenExpired", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTokenExpired);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTokenExpired", "()V"));
			} finally {
			}
		}

		static Delegate cb_onUnauthenticatedUserExpired;
#pragma warning disable 0169
		static Delegate GetOnUnauthenticatedUserExpiredHandler ()
		{
			if (cb_onUnauthenticatedUserExpired == null)
				cb_onUnauthenticatedUserExpired = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnUnauthenticatedUserExpired);
			return cb_onUnauthenticatedUserExpired;
		}

		static void n_OnUnauthenticatedUserExpired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.LivePersonEventsProxy __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.LivePersonEventsProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUnauthenticatedUserExpired ();
		}
#pragma warning restore 0169

		static IntPtr id_onUnauthenticatedUserExpired;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='LivePersonEventsProxy']/method[@name='onUnauthenticatedUserExpired' and count(parameter)=0]"
		[Register ("onUnauthenticatedUserExpired", "()V", "GetOnUnauthenticatedUserExpiredHandler")]
		public virtual unsafe void OnUnauthenticatedUserExpired ()
		{
			if (id_onUnauthenticatedUserExpired == IntPtr.Zero)
				id_onUnauthenticatedUserExpired = JNIEnv.GetMethodID (class_ref, "onUnauthenticatedUserExpired", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUnauthenticatedUserExpired);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUnauthenticatedUserExpired", "()V"));
			} finally {
			}
		}

		static Delegate cb_onUserActionOnPreventedPermission_Lcom_liveperson_api_sdk_PermissionType_;
#pragma warning disable 0169
		static Delegate GetOnUserActionOnPreventedPermission_Lcom_liveperson_api_sdk_PermissionType_Handler ()
		{
			if (cb_onUserActionOnPreventedPermission_Lcom_liveperson_api_sdk_PermissionType_ == null)
				cb_onUserActionOnPreventedPermission_Lcom_liveperson_api_sdk_PermissionType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUserActionOnPreventedPermission_Lcom_liveperson_api_sdk_PermissionType_);
			return cb_onUserActionOnPreventedPermission_Lcom_liveperson_api_sdk_PermissionType_;
		}

		static void n_OnUserActionOnPreventedPermission_Lcom_liveperson_api_sdk_PermissionType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.LivePersonEventsProxy __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.LivePersonEventsProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Sdk.PermissionType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Sdk.PermissionType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUserActionOnPreventedPermission (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onUserActionOnPreventedPermission_Lcom_liveperson_api_sdk_PermissionType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='LivePersonEventsProxy']/method[@name='onUserActionOnPreventedPermission' and count(parameter)=1 and parameter[1][@type='com.liveperson.api.sdk.PermissionType']]"
		[Register ("onUserActionOnPreventedPermission", "(Lcom/liveperson/api/sdk/PermissionType;)V", "GetOnUserActionOnPreventedPermission_Lcom_liveperson_api_sdk_PermissionType_Handler")]
		public virtual unsafe void OnUserActionOnPreventedPermission (global::Com.Liveperson.Api.Sdk.PermissionType p0)
		{
			if (id_onUserActionOnPreventedPermission_Lcom_liveperson_api_sdk_PermissionType_ == IntPtr.Zero)
				id_onUserActionOnPreventedPermission_Lcom_liveperson_api_sdk_PermissionType_ = JNIEnv.GetMethodID (class_ref, "onUserActionOnPreventedPermission", "(Lcom/liveperson/api/sdk/PermissionType;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUserActionOnPreventedPermission_Lcom_liveperson_api_sdk_PermissionType_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUserActionOnPreventedPermission", "(Lcom/liveperson/api/sdk/PermissionType;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onUserDeniedPermission_Lcom_liveperson_api_sdk_PermissionType_Z;
#pragma warning disable 0169
		static Delegate GetOnUserDeniedPermission_Lcom_liveperson_api_sdk_PermissionType_ZHandler ()
		{
			if (cb_onUserDeniedPermission_Lcom_liveperson_api_sdk_PermissionType_Z == null)
				cb_onUserDeniedPermission_Lcom_liveperson_api_sdk_PermissionType_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnUserDeniedPermission_Lcom_liveperson_api_sdk_PermissionType_Z);
			return cb_onUserDeniedPermission_Lcom_liveperson_api_sdk_PermissionType_Z;
		}

		static void n_OnUserDeniedPermission_Lcom_liveperson_api_sdk_PermissionType_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Liveperson.Messaging.LivePersonEventsProxy __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.LivePersonEventsProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Sdk.PermissionType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Sdk.PermissionType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUserDeniedPermission (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onUserDeniedPermission_Lcom_liveperson_api_sdk_PermissionType_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='LivePersonEventsProxy']/method[@name='onUserDeniedPermission' and count(parameter)=2 and parameter[1][@type='com.liveperson.api.sdk.PermissionType'] and parameter[2][@type='boolean']]"
		[Register ("onUserDeniedPermission", "(Lcom/liveperson/api/sdk/PermissionType;Z)V", "GetOnUserDeniedPermission_Lcom_liveperson_api_sdk_PermissionType_ZHandler")]
		public virtual unsafe void OnUserDeniedPermission (global::Com.Liveperson.Api.Sdk.PermissionType p0, bool p1)
		{
			if (id_onUserDeniedPermission_Lcom_liveperson_api_sdk_PermissionType_Z == IntPtr.Zero)
				id_onUserDeniedPermission_Lcom_liveperson_api_sdk_PermissionType_Z = JNIEnv.GetMethodID (class_ref, "onUserDeniedPermission", "(Lcom/liveperson/api/sdk/PermissionType;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUserDeniedPermission_Lcom_liveperson_api_sdk_PermissionType_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUserDeniedPermission", "(Lcom/liveperson/api/sdk/PermissionType;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeCallback;
#pragma warning disable 0169
		static Delegate GetRemoveCallbackHandler ()
		{
			if (cb_removeCallback == null)
				cb_removeCallback = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveCallback);
			return cb_removeCallback;
		}

		static void n_RemoveCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.LivePersonEventsProxy __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.LivePersonEventsProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveCallback ();
		}
#pragma warning restore 0169

		static IntPtr id_removeCallback;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='LivePersonEventsProxy']/method[@name='removeCallback' and count(parameter)=0]"
		[Register ("removeCallback", "()V", "GetRemoveCallbackHandler")]
		public virtual unsafe void RemoveCallback ()
		{
			if (id_removeCallback == IntPtr.Zero)
				id_removeCallback = JNIEnv.GetMethodID (class_ref, "removeCallback", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeCallback);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeCallback", "()V"));
			} finally {
			}
		}

		static Delegate cb_setCallback_Lcom_liveperson_api_LivePersonCallback_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lcom_liveperson_api_LivePersonCallback_Handler ()
		{
			if (cb_setCallback_Lcom_liveperson_api_LivePersonCallback_ == null)
				cb_setCallback_Lcom_liveperson_api_LivePersonCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallback_Lcom_liveperson_api_LivePersonCallback_);
			return cb_setCallback_Lcom_liveperson_api_LivePersonCallback_;
		}

		static void n_SetCallback_Lcom_liveperson_api_LivePersonCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.LivePersonEventsProxy __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.LivePersonEventsProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.ILivePersonCallback p0 = (global::Com.Liveperson.Api.ILivePersonCallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.ILivePersonCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCallback_Lcom_liveperson_api_LivePersonCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/class[@name='LivePersonEventsProxy']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.liveperson.api.LivePersonCallback']]"
		[Register ("setCallback", "(Lcom/liveperson/api/LivePersonCallback;)V", "GetSetCallback_Lcom_liveperson_api_LivePersonCallback_Handler")]
		public virtual unsafe void SetCallback (global::Com.Liveperson.Api.ILivePersonCallback p0)
		{
			if (id_setCallback_Lcom_liveperson_api_LivePersonCallback_ == IntPtr.Zero)
				id_setCallback_Lcom_liveperson_api_LivePersonCallback_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lcom/liveperson/api/LivePersonCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCallback_Lcom_liveperson_api_LivePersonCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallback", "(Lcom/liveperson/api/LivePersonCallback;)V"), __args);
			} finally {
			}
		}

	}
}
