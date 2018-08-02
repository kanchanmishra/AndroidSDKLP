using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='PushMessage']"
	[global::Android.Runtime.Register ("com/liveperson/infra/model/PushMessage", DoNotGenerateAcw=true)]
	public partial class PushMessage : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/model/PushMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushMessage); }
		}

		protected PushMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='PushMessage']/constructor[@name='PushMessage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe PushMessage (string p0, string p1, string p2)
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
				if (((object) this).GetType () != typeof (PushMessage)) {
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

		static Delegate cb_getBackendService;
#pragma warning disable 0169
		static Delegate GetGetBackendServiceHandler ()
		{
			if (cb_getBackendService == null)
				cb_getBackendService = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBackendService);
			return cb_getBackendService;
		}

		static IntPtr n_GetBackendService (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Model.PushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.PushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BackendService);
		}
#pragma warning restore 0169

		static Delegate cb_setBackendService_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBackendService_Ljava_lang_String_Handler ()
		{
			if (cb_setBackendService_Ljava_lang_String_ == null)
				cb_setBackendService_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBackendService_Ljava_lang_String_);
			return cb_setBackendService_Ljava_lang_String_;
		}

		static void n_SetBackendService_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Model.PushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.PushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BackendService = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBackendService;
		static IntPtr id_setBackendService_Ljava_lang_String_;
		public virtual unsafe string BackendService {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='PushMessage']/method[@name='getBackendService' and count(parameter)=0]"
			[Register ("getBackendService", "()Ljava/lang/String;", "GetGetBackendServiceHandler")]
			get {
				if (id_getBackendService == IntPtr.Zero)
					id_getBackendService = JNIEnv.GetMethodID (class_ref, "getBackendService", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBackendService), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBackendService", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='PushMessage']/method[@name='setBackendService' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBackendService", "(Ljava/lang/String;)V", "GetSetBackendService_Ljava_lang_String_Handler")]
			set {
				if (id_setBackendService_Ljava_lang_String_ == IntPtr.Zero)
					id_setBackendService_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBackendService", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBackendService_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBackendService", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Liveperson.Infra.Model.PushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.PushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BrandId);
		}
#pragma warning restore 0169

		static IntPtr id_getBrandId;
		public virtual unsafe string BrandId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='PushMessage']/method[@name='getBrandId' and count(parameter)=0]"
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

		static Delegate cb_getCollapseKey;
#pragma warning disable 0169
		static Delegate GetGetCollapseKeyHandler ()
		{
			if (cb_getCollapseKey == null)
				cb_getCollapseKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCollapseKey);
			return cb_getCollapseKey;
		}

		static IntPtr n_GetCollapseKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Model.PushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.PushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CollapseKey);
		}
#pragma warning restore 0169

		static Delegate cb_setCollapseKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCollapseKey_Ljava_lang_String_Handler ()
		{
			if (cb_setCollapseKey_Ljava_lang_String_ == null)
				cb_setCollapseKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCollapseKey_Ljava_lang_String_);
			return cb_setCollapseKey_Ljava_lang_String_;
		}

		static void n_SetCollapseKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Model.PushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.PushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CollapseKey = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCollapseKey;
		static IntPtr id_setCollapseKey_Ljava_lang_String_;
		public virtual unsafe string CollapseKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='PushMessage']/method[@name='getCollapseKey' and count(parameter)=0]"
			[Register ("getCollapseKey", "()Ljava/lang/String;", "GetGetCollapseKeyHandler")]
			get {
				if (id_getCollapseKey == IntPtr.Zero)
					id_getCollapseKey = JNIEnv.GetMethodID (class_ref, "getCollapseKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCollapseKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCollapseKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='PushMessage']/method[@name='setCollapseKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCollapseKey", "(Ljava/lang/String;)V", "GetSetCollapseKey_Ljava_lang_String_Handler")]
			set {
				if (id_setCollapseKey_Ljava_lang_String_ == IntPtr.Zero)
					id_setCollapseKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCollapseKey", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCollapseKey_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCollapseKey", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Liveperson.Infra.Model.PushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.PushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Liveperson.Infra.Model.PushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.PushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConversationId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getConversationId;
		static IntPtr id_setConversationId_Ljava_lang_String_;
		public virtual unsafe string ConversationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='PushMessage']/method[@name='getConversationId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='PushMessage']/method[@name='setConversationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getCurrentUnreadMessgesCounter;
#pragma warning disable 0169
		static Delegate GetGetCurrentUnreadMessgesCounterHandler ()
		{
			if (cb_getCurrentUnreadMessgesCounter == null)
				cb_getCurrentUnreadMessgesCounter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentUnreadMessgesCounter);
			return cb_getCurrentUnreadMessgesCounter;
		}

		static int n_GetCurrentUnreadMessgesCounter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Model.PushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.PushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentUnreadMessgesCounter;
		}
#pragma warning restore 0169

		static Delegate cb_setCurrentUnreadMessgesCounter_I;
#pragma warning disable 0169
		static Delegate GetSetCurrentUnreadMessgesCounter_IHandler ()
		{
			if (cb_setCurrentUnreadMessgesCounter_I == null)
				cb_setCurrentUnreadMessgesCounter_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCurrentUnreadMessgesCounter_I);
			return cb_setCurrentUnreadMessgesCounter_I;
		}

		static void n_SetCurrentUnreadMessgesCounter_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Infra.Model.PushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.PushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CurrentUnreadMessgesCounter = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentUnreadMessgesCounter;
		static IntPtr id_setCurrentUnreadMessgesCounter_I;
		public virtual unsafe int CurrentUnreadMessgesCounter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='PushMessage']/method[@name='getCurrentUnreadMessgesCounter' and count(parameter)=0]"
			[Register ("getCurrentUnreadMessgesCounter", "()I", "GetGetCurrentUnreadMessgesCounterHandler")]
			get {
				if (id_getCurrentUnreadMessgesCounter == IntPtr.Zero)
					id_getCurrentUnreadMessgesCounter = JNIEnv.GetMethodID (class_ref, "getCurrentUnreadMessgesCounter", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentUnreadMessgesCounter);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentUnreadMessgesCounter", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='PushMessage']/method[@name='setCurrentUnreadMessgesCounter' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCurrentUnreadMessgesCounter", "(I)V", "GetSetCurrentUnreadMessgesCounter_IHandler")]
			set {
				if (id_setCurrentUnreadMessgesCounter_I == IntPtr.Zero)
					id_setCurrentUnreadMessgesCounter_I = JNIEnv.GetMethodID (class_ref, "setCurrentUnreadMessgesCounter", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCurrentUnreadMessgesCounter_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurrentUnreadMessgesCounter", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFrom;
#pragma warning disable 0169
		static Delegate GetGetFromHandler ()
		{
			if (cb_getFrom == null)
				cb_getFrom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFrom);
			return cb_getFrom;
		}

		static IntPtr n_GetFrom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Model.PushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.PushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.From);
		}
#pragma warning restore 0169

		static IntPtr id_getFrom;
		public virtual unsafe string From {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='PushMessage']/method[@name='getFrom' and count(parameter)=0]"
			[Register ("getFrom", "()Ljava/lang/String;", "GetGetFromHandler")]
			get {
				if (id_getFrom == IntPtr.Zero)
					id_getFrom = JNIEnv.GetMethodID (class_ref, "getFrom", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFrom), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrom", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Liveperson.Infra.Model.PushMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.PushMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='PushMessage']/method[@name='getMessage' and count(parameter)=0]"
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

	}
}
