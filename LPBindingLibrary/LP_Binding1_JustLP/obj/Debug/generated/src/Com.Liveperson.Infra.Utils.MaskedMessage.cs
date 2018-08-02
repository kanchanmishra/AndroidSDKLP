using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='MaskedMessage']"
	[global::Android.Runtime.Register ("com/liveperson/infra/utils/MaskedMessage", DoNotGenerateAcw=true)]
	public partial class MaskedMessage : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/utils/MaskedMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MaskedMessage); }
		}

		protected MaskedMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_ZLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='MaskedMessage']/constructor[@name='MaskedMessage' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;ZLjava/lang/String;)V", "")]
		public unsafe MaskedMessage (string p0, string p1, bool p2, string p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				if (((object) this).GetType () != typeof (MaskedMessage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;ZLjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;ZLjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ZLjava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ZLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;ZLjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_ZLjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_ZLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_getDbMessage;
#pragma warning disable 0169
		static Delegate GetGetDbMessageHandler ()
		{
			if (cb_getDbMessage == null)
				cb_getDbMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDbMessage);
			return cb_getDbMessage;
		}

		static IntPtr n_GetDbMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.MaskedMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.MaskedMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DbMessage);
		}
#pragma warning restore 0169

		static Delegate cb_setDbMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDbMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setDbMessage_Ljava_lang_String_ == null)
				cb_setDbMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDbMessage_Ljava_lang_String_);
			return cb_setDbMessage_Ljava_lang_String_;
		}

		static void n_SetDbMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.MaskedMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.MaskedMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DbMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDbMessage;
		static IntPtr id_setDbMessage_Ljava_lang_String_;
		public virtual unsafe string DbMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='MaskedMessage']/method[@name='getDbMessage' and count(parameter)=0]"
			[Register ("getDbMessage", "()Ljava/lang/String;", "GetGetDbMessageHandler")]
			get {
				if (id_getDbMessage == IntPtr.Zero)
					id_getDbMessage = JNIEnv.GetMethodID (class_ref, "getDbMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDbMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDbMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='MaskedMessage']/method[@name='setDbMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDbMessage", "(Ljava/lang/String;)V", "GetSetDbMessage_Ljava_lang_String_Handler")]
			set {
				if (id_setDbMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setDbMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDbMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDbMessage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDbMessage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isMasked;
#pragma warning disable 0169
		static Delegate GetIsMaskedHandler ()
		{
			if (cb_isMasked == null)
				cb_isMasked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMasked);
			return cb_isMasked;
		}

		static bool n_IsMasked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.MaskedMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.MaskedMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMasked;
		}
#pragma warning restore 0169

		static IntPtr id_isMasked;
		public virtual unsafe bool IsMasked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='MaskedMessage']/method[@name='isMasked' and count(parameter)=0]"
			[Register ("isMasked", "()Z", "GetIsMaskedHandler")]
			get {
				if (id_isMasked == IntPtr.Zero)
					id_isMasked = JNIEnv.GetMethodID (class_ref, "isMasked", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMasked);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMasked", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMaskedSystemMessage;
#pragma warning disable 0169
		static Delegate GetGetMaskedSystemMessageHandler ()
		{
			if (cb_getMaskedSystemMessage == null)
				cb_getMaskedSystemMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMaskedSystemMessage);
			return cb_getMaskedSystemMessage;
		}

		static IntPtr n_GetMaskedSystemMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.MaskedMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.MaskedMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MaskedSystemMessage);
		}
#pragma warning restore 0169

		static IntPtr id_getMaskedSystemMessage;
		public virtual unsafe string MaskedSystemMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='MaskedMessage']/method[@name='getMaskedSystemMessage' and count(parameter)=0]"
			[Register ("getMaskedSystemMessage", "()Ljava/lang/String;", "GetGetMaskedSystemMessageHandler")]
			get {
				if (id_getMaskedSystemMessage == IntPtr.Zero)
					id_getMaskedSystemMessage = JNIEnv.GetMethodID (class_ref, "getMaskedSystemMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMaskedSystemMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaskedSystemMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getServerMessage;
#pragma warning disable 0169
		static Delegate GetGetServerMessageHandler ()
		{
			if (cb_getServerMessage == null)
				cb_getServerMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServerMessage);
			return cb_getServerMessage;
		}

		static IntPtr n_GetServerMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.MaskedMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.MaskedMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServerMessage);
		}
#pragma warning restore 0169

		static Delegate cb_setServerMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetServerMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setServerMessage_Ljava_lang_String_ == null)
				cb_setServerMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetServerMessage_Ljava_lang_String_);
			return cb_setServerMessage_Ljava_lang_String_;
		}

		static void n_SetServerMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.MaskedMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.MaskedMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ServerMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getServerMessage;
		static IntPtr id_setServerMessage_Ljava_lang_String_;
		public virtual unsafe string ServerMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='MaskedMessage']/method[@name='getServerMessage' and count(parameter)=0]"
			[Register ("getServerMessage", "()Ljava/lang/String;", "GetGetServerMessageHandler")]
			get {
				if (id_getServerMessage == IntPtr.Zero)
					id_getServerMessage = JNIEnv.GetMethodID (class_ref, "getServerMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServerMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServerMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='MaskedMessage']/method[@name='setServerMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setServerMessage", "(Ljava/lang/String;)V", "GetSetServerMessage_Ljava_lang_String_Handler")]
			set {
				if (id_setServerMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setServerMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setServerMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setServerMessage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setServerMessage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
