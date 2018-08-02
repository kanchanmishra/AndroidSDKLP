using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Network.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='AgentProfileRequest']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/network/http/AgentProfileRequest", DoNotGenerateAcw=true)]
	public partial class AgentProfileRequest : global::Java.Lang.Object, global::Com.Liveperson.Infra.ICommand {


		static IntPtr mController_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='AgentProfileRequest']/field[@name='mController']"
		[Register ("mController")]
		protected global::Com.Liveperson.Messaging.Messaging MController {
			get {
				if (mController_jfieldId == IntPtr.Zero)
					mController_jfieldId = JNIEnv.GetFieldID (class_ref, "mController", "Lcom/liveperson/messaging/Messaging;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mController_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mController_jfieldId == IntPtr.Zero)
					mController_jfieldId = JNIEnv.GetFieldID (class_ref, "mController", "Lcom/liveperson/messaging/Messaging;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mController_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/network/http/AgentProfileRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AgentProfileRequest); }
		}

		protected AgentProfileRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='AgentProfileRequest']/constructor[@name='AgentProfileRequest' and count(parameter)=5 and parameter[1][@type='com.liveperson.messaging.Messaging'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='boolean']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "")]
		public unsafe AgentProfileRequest (global::Com.Liveperson.Messaging.Messaging p0, string p1, string p2, string p3, bool p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				if (((object) this).GetType () != typeof (AgentProfileRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_getCallback;
#pragma warning disable 0169
		static Delegate GetGetCallbackHandler ()
		{
			if (cb_getCallback == null)
				cb_getCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCallback);
			return cb_getCallback;
		}

		static IntPtr n_GetCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Network.Http.AgentProfileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.AgentProfileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Callback);
		}
#pragma warning restore 0169

		static IntPtr id_getCallback;
		public virtual unsafe global::Com.Liveperson.Infra.ICallback Callback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='AgentProfileRequest']/method[@name='getCallback' and count(parameter)=0]"
			[Register ("getCallback", "()Lcom/liveperson/infra/ICallback;", "GetGetCallbackHandler")]
			get {
				if (id_getCallback == IntPtr.Zero)
					id_getCallback = JNIEnv.GetMethodID (class_ref, "getCallback", "()Lcom/liveperson/infra/ICallback;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCallback", "()Lcom/liveperson/infra/ICallback;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_execute;
#pragma warning disable 0169
		static Delegate GetExecuteHandler ()
		{
			if (cb_execute == null)
				cb_execute = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Execute);
			return cb_execute;
		}

		static void n_Execute (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Network.Http.AgentProfileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.AgentProfileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		static IntPtr id_execute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='AgentProfileRequest']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()V", "GetExecuteHandler")]
		public virtual unsafe void Execute ()
		{
			if (id_execute == IntPtr.Zero)
				id_execute = JNIEnv.GetMethodID (class_ref, "execute", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_execute);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "()V"));
			} finally {
			}
		}

		static Delegate cb_setCallback_Lcom_liveperson_infra_ICallback_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lcom_liveperson_infra_ICallback_Handler ()
		{
			if (cb_setCallback_Lcom_liveperson_infra_ICallback_ == null)
				cb_setCallback_Lcom_liveperson_infra_ICallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCallback_Lcom_liveperson_infra_ICallback_);
			return cb_setCallback_Lcom_liveperson_infra_ICallback_;
		}

		static IntPtr n_SetCallback_Lcom_liveperson_infra_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Network.Http.AgentProfileRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.AgentProfileRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ICallback p0 = (global::Com.Liveperson.Infra.ICallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCallback (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setCallback_Lcom_liveperson_infra_ICallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='AgentProfileRequest']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.ICallback&lt;com.liveperson.messaging.model.MessagingUserProfile, java.lang.Exception&gt;']]"
		[Register ("setCallback", "(Lcom/liveperson/infra/ICallback;)Lcom/liveperson/messaging/network/http/AgentProfileRequest;", "GetSetCallback_Lcom_liveperson_infra_ICallback_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Network.Http.AgentProfileRequest SetCallback (global::Com.Liveperson.Infra.ICallback p0)
		{
			if (id_setCallback_Lcom_liveperson_infra_ICallback_ == IntPtr.Zero)
				id_setCallback_Lcom_liveperson_infra_ICallback_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lcom/liveperson/infra/ICallback;)Lcom/liveperson/messaging/network/http/AgentProfileRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Liveperson.Messaging.Network.Http.AgentProfileRequest __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.AgentProfileRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCallback_Lcom_liveperson_infra_ICallback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.AgentProfileRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallback", "(Lcom/liveperson/infra/ICallback;)Lcom/liveperson/messaging/network/http/AgentProfileRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
