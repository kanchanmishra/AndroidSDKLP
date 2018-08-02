using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='LptagData']"
	[global::Android.Runtime.Register ("com/liveperson/infra/model/LptagData", DoNotGenerateAcw=true)]
	public partial class LptagData : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/model/LptagData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LptagData); }
		}

		protected LptagData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='LptagData']/constructor[@name='LptagData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LptagData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LptagData)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_isAutoMessagesFeatureEnabled;
#pragma warning disable 0169
		static Delegate GetIsAutoMessagesFeatureEnabledHandler ()
		{
			if (cb_isAutoMessagesFeatureEnabled == null)
				cb_isAutoMessagesFeatureEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAutoMessagesFeatureEnabled);
			return cb_isAutoMessagesFeatureEnabled;
		}

		static bool n_IsAutoMessagesFeatureEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Model.LptagData __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.LptagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoMessagesFeatureEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setAutoMessagesFeatureEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetAutoMessagesFeatureEnabled_ZHandler ()
		{
			if (cb_setAutoMessagesFeatureEnabled_Z == null)
				cb_setAutoMessagesFeatureEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAutoMessagesFeatureEnabled_Z);
			return cb_setAutoMessagesFeatureEnabled_Z;
		}

		static void n_SetAutoMessagesFeatureEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Infra.Model.LptagData __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.LptagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AutoMessagesFeatureEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isAutoMessagesFeatureEnabled;
		static IntPtr id_setAutoMessagesFeatureEnabled_Z;
		public virtual unsafe bool AutoMessagesFeatureEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='LptagData']/method[@name='isAutoMessagesFeatureEnabled' and count(parameter)=0]"
			[Register ("isAutoMessagesFeatureEnabled", "()Z", "GetIsAutoMessagesFeatureEnabledHandler")]
			get {
				if (id_isAutoMessagesFeatureEnabled == IntPtr.Zero)
					id_isAutoMessagesFeatureEnabled = JNIEnv.GetMethodID (class_ref, "isAutoMessagesFeatureEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAutoMessagesFeatureEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAutoMessagesFeatureEnabled", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='LptagData']/method[@name='setAutoMessagesFeatureEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoMessagesFeatureEnabled", "(Z)V", "GetSetAutoMessagesFeatureEnabled_ZHandler")]
			set {
				if (id_setAutoMessagesFeatureEnabled_Z == IntPtr.Zero)
					id_setAutoMessagesFeatureEnabled_Z = JNIEnv.GetMethodID (class_ref, "setAutoMessagesFeatureEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAutoMessagesFeatureEnabled_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAutoMessagesFeatureEnabled", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxRetries;
#pragma warning disable 0169
		static Delegate GetGetMaxRetriesHandler ()
		{
			if (cb_getMaxRetries == null)
				cb_getMaxRetries = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxRetries);
			return cb_getMaxRetries;
		}

		static int n_GetMaxRetries (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Model.LptagData __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.LptagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxRetries;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxRetries_I;
#pragma warning disable 0169
		static Delegate GetSetMaxRetries_IHandler ()
		{
			if (cb_setMaxRetries_I == null)
				cb_setMaxRetries_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxRetries_I);
			return cb_setMaxRetries_I;
		}

		static void n_SetMaxRetries_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Infra.Model.LptagData __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.LptagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxRetries = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxRetries;
		static IntPtr id_setMaxRetries_I;
		public virtual unsafe int MaxRetries {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='LptagData']/method[@name='getMaxRetries' and count(parameter)=0]"
			[Register ("getMaxRetries", "()I", "GetGetMaxRetriesHandler")]
			get {
				if (id_getMaxRetries == IntPtr.Zero)
					id_getMaxRetries = JNIEnv.GetMethodID (class_ref, "getMaxRetries", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxRetries);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxRetries", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='LptagData']/method[@name='setMaxRetries' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxRetries", "(I)V", "GetSetMaxRetries_IHandler")]
			set {
				if (id_setMaxRetries_I == IntPtr.Zero)
					id_setMaxRetries_I = JNIEnv.GetMethodID (class_ref, "setMaxRetries", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaxRetries_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxRetries", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRetryTimeout;
#pragma warning disable 0169
		static Delegate GetGetRetryTimeoutHandler ()
		{
			if (cb_getRetryTimeout == null)
				cb_getRetryTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRetryTimeout);
			return cb_getRetryTimeout;
		}

		static int n_GetRetryTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Model.LptagData __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.LptagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RetryTimeout;
		}
#pragma warning restore 0169

		static Delegate cb_setRetryTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetRetryTimeout_IHandler ()
		{
			if (cb_setRetryTimeout_I == null)
				cb_setRetryTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRetryTimeout_I);
			return cb_setRetryTimeout_I;
		}

		static void n_SetRetryTimeout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Infra.Model.LptagData __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.LptagData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RetryTimeout = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRetryTimeout;
		static IntPtr id_setRetryTimeout_I;
		public virtual unsafe int RetryTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='LptagData']/method[@name='getRetryTimeout' and count(parameter)=0]"
			[Register ("getRetryTimeout", "()I", "GetGetRetryTimeoutHandler")]
			get {
				if (id_getRetryTimeout == IntPtr.Zero)
					id_getRetryTimeout = JNIEnv.GetMethodID (class_ref, "getRetryTimeout", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRetryTimeout);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRetryTimeout", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.model']/class[@name='LptagData']/method[@name='setRetryTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRetryTimeout", "(I)V", "GetSetRetryTimeout_IHandler")]
			set {
				if (id_setRetryTimeout_I == IntPtr.Zero)
					id_setRetryTimeout_I = JNIEnv.GetMethodID (class_ref, "setRetryTimeout", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRetryTimeout_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRetryTimeout", "(I)V"), __args);
				} finally {
				}
			}
		}

	}
}
