using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.network']/class[@name='ExponentialBackOff']"
	[global::Android.Runtime.Register ("com/liveperson/infra/network/ExponentialBackOff", DoNotGenerateAcw=true)]
	public partial class ExponentialBackOff : global::Java.Lang.Object, global::Com.Liveperson.Infra.Network.IBackOff {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network']/class[@name='ExponentialBackOff']/field[@name='DEFAULT_INITIAL_INTERVAL_MILLIS']"
		[Register ("DEFAULT_INITIAL_INTERVAL_MILLIS")]
		public const int DefaultInitialIntervalMillis = (int) 500;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network']/class[@name='ExponentialBackOff']/field[@name='DEFAULT_MAX_ELAPSED_TIME_MILLIS']"
		[Register ("DEFAULT_MAX_ELAPSED_TIME_MILLIS")]
		public const int DefaultMaxElapsedTimeMillis = (int) 900000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network']/class[@name='ExponentialBackOff']/field[@name='DEFAULT_MAX_INTERVAL_MILLIS']"
		[Register ("DEFAULT_MAX_INTERVAL_MILLIS")]
		public const int DefaultMaxIntervalMillis = (int) 60000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network']/class[@name='ExponentialBackOff']/field[@name='DEFAULT_MULTIPLIER']"
		[Register ("DEFAULT_MULTIPLIER")]
		public const double DefaultMultiplier = (double) 1.500000000000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network']/class[@name='ExponentialBackOff']/field[@name='DEFAULT_RANDOMIZATION_FACTOR']"
		[Register ("DEFAULT_RANDOMIZATION_FACTOR")]
		public const double DefaultRandomizationFactor = (double) 0.000000000000000;

		public static class InterfaceConsts {

			// The following are fields from: com.liveperson.infra.network.BackOff

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network']/interface[@name='BackOff']/field[@name='STOP']"
			[Register ("STOP")]
			public const long Stop = (long) -1L;

			static IntPtr STOP_BACKOFF_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network']/interface[@name='BackOff']/field[@name='STOP_BACKOFF']"
			[Register ("STOP_BACKOFF")]
			public static global::Com.Liveperson.Infra.Network.IBackOff StopBackoff {
				get {
					if (STOP_BACKOFF_jfieldId == IntPtr.Zero)
						STOP_BACKOFF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STOP_BACKOFF", "Lcom/liveperson/infra/network/BackOff;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STOP_BACKOFF_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.IBackOff> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network']/interface[@name='BackOff']/field[@name='ZERO']"
			[Register ("ZERO")]
			public const long Zero = (long) 0L;

			static IntPtr ZERO_BACKOFF_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.network']/interface[@name='BackOff']/field[@name='ZERO_BACKOFF']"
			[Register ("ZERO_BACKOFF")]
			public static global::Com.Liveperson.Infra.Network.IBackOff ZeroBackoff {
				get {
					if (ZERO_BACKOFF_jfieldId == IntPtr.Zero)
						ZERO_BACKOFF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ZERO_BACKOFF", "Lcom/liveperson/infra/network/BackOff;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ZERO_BACKOFF_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.IBackOff> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.network']/class[@name='ExponentialBackOff.Builder']"
		[global::Android.Runtime.Register ("com/liveperson/infra/network/ExponentialBackOff$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/network/ExponentialBackOff$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.network']/class[@name='ExponentialBackOff.Builder']/constructor[@name='ExponentialBackOff.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Builder)) {
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

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network']/class[@name='ExponentialBackOff.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/liveperson/infra/network/ExponentialBackOff;", "GetBuildHandler")]
			public virtual unsafe global::Com.Liveperson.Infra.Network.ExponentialBackOff Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/liveperson/infra/network/ExponentialBackOff;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.ExponentialBackOff> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.ExponentialBackOff> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/liveperson/infra/network/ExponentialBackOff;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setInitialIntervalMillis_I;
#pragma warning disable 0169
			static Delegate GetSetInitialIntervalMillis_IHandler ()
			{
				if (cb_setInitialIntervalMillis_I == null)
					cb_setInitialIntervalMillis_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetInitialIntervalMillis_I);
				return cb_setInitialIntervalMillis_I;
			}

			static IntPtr n_SetInitialIntervalMillis_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetInitialIntervalMillis (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setInitialIntervalMillis_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network']/class[@name='ExponentialBackOff.Builder']/method[@name='setInitialIntervalMillis' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setInitialIntervalMillis", "(I)Lcom/liveperson/infra/network/ExponentialBackOff$Builder;", "GetSetInitialIntervalMillis_IHandler")]
			public virtual unsafe global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder SetInitialIntervalMillis (int p0)
			{
				if (id_setInitialIntervalMillis_I == IntPtr.Zero)
					id_setInitialIntervalMillis_I = JNIEnv.GetMethodID (class_ref, "setInitialIntervalMillis", "(I)Lcom/liveperson/infra/network/ExponentialBackOff$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setInitialIntervalMillis_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInitialIntervalMillis", "(I)Lcom/liveperson/infra/network/ExponentialBackOff$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setMaxElapsedTimeMillis_I;
#pragma warning disable 0169
			static Delegate GetSetMaxElapsedTimeMillis_IHandler ()
			{
				if (cb_setMaxElapsedTimeMillis_I == null)
					cb_setMaxElapsedTimeMillis_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetMaxElapsedTimeMillis_I);
				return cb_setMaxElapsedTimeMillis_I;
			}

			static IntPtr n_SetMaxElapsedTimeMillis_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetMaxElapsedTimeMillis (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setMaxElapsedTimeMillis_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network']/class[@name='ExponentialBackOff.Builder']/method[@name='setMaxElapsedTimeMillis' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxElapsedTimeMillis", "(I)Lcom/liveperson/infra/network/ExponentialBackOff$Builder;", "GetSetMaxElapsedTimeMillis_IHandler")]
			public virtual unsafe global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder SetMaxElapsedTimeMillis (int p0)
			{
				if (id_setMaxElapsedTimeMillis_I == IntPtr.Zero)
					id_setMaxElapsedTimeMillis_I = JNIEnv.GetMethodID (class_ref, "setMaxElapsedTimeMillis", "(I)Lcom/liveperson/infra/network/ExponentialBackOff$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMaxElapsedTimeMillis_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxElapsedTimeMillis", "(I)Lcom/liveperson/infra/network/ExponentialBackOff$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setMaxIntervalMillis_I;
#pragma warning disable 0169
			static Delegate GetSetMaxIntervalMillis_IHandler ()
			{
				if (cb_setMaxIntervalMillis_I == null)
					cb_setMaxIntervalMillis_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetMaxIntervalMillis_I);
				return cb_setMaxIntervalMillis_I;
			}

			static IntPtr n_SetMaxIntervalMillis_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetMaxIntervalMillis (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setMaxIntervalMillis_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network']/class[@name='ExponentialBackOff.Builder']/method[@name='setMaxIntervalMillis' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxIntervalMillis", "(I)Lcom/liveperson/infra/network/ExponentialBackOff$Builder;", "GetSetMaxIntervalMillis_IHandler")]
			public virtual unsafe global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder SetMaxIntervalMillis (int p0)
			{
				if (id_setMaxIntervalMillis_I == IntPtr.Zero)
					id_setMaxIntervalMillis_I = JNIEnv.GetMethodID (class_ref, "setMaxIntervalMillis", "(I)Lcom/liveperson/infra/network/ExponentialBackOff$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMaxIntervalMillis_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxIntervalMillis", "(I)Lcom/liveperson/infra/network/ExponentialBackOff$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setMultiplier_D;
#pragma warning disable 0169
			static Delegate GetSetMultiplier_DHandler ()
			{
				if (cb_setMultiplier_D == null)
					cb_setMultiplier_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_SetMultiplier_D);
				return cb_setMultiplier_D;
			}

			static IntPtr n_SetMultiplier_D (IntPtr jnienv, IntPtr native__this, double p0)
			{
				global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetMultiplier (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setMultiplier_D;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network']/class[@name='ExponentialBackOff.Builder']/method[@name='setMultiplier' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setMultiplier", "(D)Lcom/liveperson/infra/network/ExponentialBackOff$Builder;", "GetSetMultiplier_DHandler")]
			public virtual unsafe global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder SetMultiplier (double p0)
			{
				if (id_setMultiplier_D == IntPtr.Zero)
					id_setMultiplier_D = JNIEnv.GetMethodID (class_ref, "setMultiplier", "(D)Lcom/liveperson/infra/network/ExponentialBackOff$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMultiplier_D, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMultiplier", "(D)Lcom/liveperson/infra/network/ExponentialBackOff$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setRandomizationFactor_D;
#pragma warning disable 0169
			static Delegate GetSetRandomizationFactor_DHandler ()
			{
				if (cb_setRandomizationFactor_D == null)
					cb_setRandomizationFactor_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_SetRandomizationFactor_D);
				return cb_setRandomizationFactor_D;
			}

			static IntPtr n_SetRandomizationFactor_D (IntPtr jnienv, IntPtr native__this, double p0)
			{
				global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetRandomizationFactor (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setRandomizationFactor_D;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network']/class[@name='ExponentialBackOff.Builder']/method[@name='setRandomizationFactor' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setRandomizationFactor", "(D)Lcom/liveperson/infra/network/ExponentialBackOff$Builder;", "GetSetRandomizationFactor_DHandler")]
			public virtual unsafe global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder SetRandomizationFactor (double p0)
			{
				if (id_setRandomizationFactor_D == IntPtr.Zero)
					id_setRandomizationFactor_D = JNIEnv.GetMethodID (class_ref, "setRandomizationFactor", "(D)Lcom/liveperson/infra/network/ExponentialBackOff$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setRandomizationFactor_D, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.ExponentialBackOff.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRandomizationFactor", "(D)Lcom/liveperson/infra/network/ExponentialBackOff$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/network/ExponentialBackOff", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExponentialBackOff); }
		}

		protected ExponentialBackOff (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getNextBackOffMillis;
#pragma warning disable 0169
		static Delegate GetGetNextBackOffMillisHandler ()
		{
			if (cb_getNextBackOffMillis == null)
				cb_getNextBackOffMillis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNextBackOffMillis);
			return cb_getNextBackOffMillis;
		}

		static long n_GetNextBackOffMillis (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.ExponentialBackOff __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.ExponentialBackOff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextBackOffMillis;
		}
#pragma warning restore 0169

		static IntPtr id_getNextBackOffMillis;
		public virtual unsafe long NextBackOffMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network']/class[@name='ExponentialBackOff']/method[@name='getNextBackOffMillis' and count(parameter)=0]"
			[Register ("getNextBackOffMillis", "()J", "GetGetNextBackOffMillisHandler")]
			get {
				if (id_getNextBackOffMillis == IntPtr.Zero)
					id_getNextBackOffMillis = JNIEnv.GetMethodID (class_ref, "getNextBackOffMillis", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getNextBackOffMillis);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNextBackOffMillis", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getRetryNumber;
#pragma warning disable 0169
		static Delegate GetGetRetryNumberHandler ()
		{
			if (cb_getRetryNumber == null)
				cb_getRetryNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRetryNumber);
			return cb_getRetryNumber;
		}

		static int n_GetRetryNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.ExponentialBackOff __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.ExponentialBackOff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RetryNumber;
		}
#pragma warning restore 0169

		static IntPtr id_getRetryNumber;
		public virtual unsafe int RetryNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network']/class[@name='ExponentialBackOff']/method[@name='getRetryNumber' and count(parameter)=0]"
			[Register ("getRetryNumber", "()I", "GetGetRetryNumberHandler")]
			get {
				if (id_getRetryNumber == IntPtr.Zero)
					id_getRetryNumber = JNIEnv.GetMethodID (class_ref, "getRetryNumber", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRetryNumber);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRetryNumber", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_calculateNextBackOffMillis;
#pragma warning disable 0169
		static Delegate GetCalculateNextBackOffMillisHandler ()
		{
			if (cb_calculateNextBackOffMillis == null)
				cb_calculateNextBackOffMillis = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CalculateNextBackOffMillis);
			return cb_calculateNextBackOffMillis;
		}

		static void n_CalculateNextBackOffMillis (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.ExponentialBackOff __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.ExponentialBackOff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalculateNextBackOffMillis ();
		}
#pragma warning restore 0169

		static IntPtr id_calculateNextBackOffMillis;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network']/class[@name='ExponentialBackOff']/method[@name='calculateNextBackOffMillis' and count(parameter)=0]"
		[Register ("calculateNextBackOffMillis", "()V", "GetCalculateNextBackOffMillisHandler")]
		public virtual unsafe void CalculateNextBackOffMillis ()
		{
			if (id_calculateNextBackOffMillis == IntPtr.Zero)
				id_calculateNextBackOffMillis = JNIEnv.GetMethodID (class_ref, "calculateNextBackOffMillis", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_calculateNextBackOffMillis);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calculateNextBackOffMillis", "()V"));
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Network.ExponentialBackOff __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.ExponentialBackOff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network']/class[@name='ExponentialBackOff']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
			} finally {
			}
		}

	}
}
