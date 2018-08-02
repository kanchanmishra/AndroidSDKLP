using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Network {

	[Register ("com/liveperson/infra/network/BackOff", DoNotGenerateAcw=true)]
	public abstract class BackOff : Java.Lang.Object {

		internal BackOff ()
		{
		}

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

		new static IntPtr class_ref = JNIEnv.FindClass ("com/liveperson/infra/network/BackOff");
	}

	[Register ("com/liveperson/infra/network/BackOff", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'BackOff' type. This type will be removed in a future release.")]
	public abstract class BackOffConsts : BackOff {

		private BackOffConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.network']/interface[@name='BackOff']"
	[Register ("com/liveperson/infra/network/BackOff", "", "Com.Liveperson.Infra.Network.IBackOffInvoker")]
	public partial interface IBackOff : IJavaObject {

		long NextBackOffMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network']/interface[@name='BackOff']/method[@name='getNextBackOffMillis' and count(parameter)=0]"
			[Register ("getNextBackOffMillis", "()J", "GetGetNextBackOffMillisHandler:Com.Liveperson.Infra.Network.IBackOffInvoker, LP_Android_aar_Binding")] get;
		}

		int RetryNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network']/interface[@name='BackOff']/method[@name='getRetryNumber' and count(parameter)=0]"
			[Register ("getRetryNumber", "()I", "GetGetRetryNumberHandler:Com.Liveperson.Infra.Network.IBackOffInvoker, LP_Android_aar_Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network']/interface[@name='BackOff']/method[@name='calculateNextBackOffMillis' and count(parameter)=0]"
		[Register ("calculateNextBackOffMillis", "()V", "GetCalculateNextBackOffMillisHandler:Com.Liveperson.Infra.Network.IBackOffInvoker, LP_Android_aar_Binding")]
		void CalculateNextBackOffMillis ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network']/interface[@name='BackOff']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler:Com.Liveperson.Infra.Network.IBackOffInvoker, LP_Android_aar_Binding")]
		void Reset ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/network/BackOff", DoNotGenerateAcw=true)]
	internal class IBackOffInvoker : global::Java.Lang.Object, IBackOff {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/network/BackOff");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBackOffInvoker); }
		}

		IntPtr class_ref;

		public static IBackOff GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBackOff> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.network.BackOff"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBackOffInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

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
			global::Com.Liveperson.Infra.Network.IBackOff __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.IBackOff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextBackOffMillis;
		}
#pragma warning restore 0169

		IntPtr id_getNextBackOffMillis;
		public unsafe long NextBackOffMillis {
			get {
				if (id_getNextBackOffMillis == IntPtr.Zero)
					id_getNextBackOffMillis = JNIEnv.GetMethodID (class_ref, "getNextBackOffMillis", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getNextBackOffMillis);
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
			global::Com.Liveperson.Infra.Network.IBackOff __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.IBackOff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RetryNumber;
		}
#pragma warning restore 0169

		IntPtr id_getRetryNumber;
		public unsafe int RetryNumber {
			get {
				if (id_getRetryNumber == IntPtr.Zero)
					id_getRetryNumber = JNIEnv.GetMethodID (class_ref, "getRetryNumber", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRetryNumber);
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
			global::Com.Liveperson.Infra.Network.IBackOff __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.IBackOff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalculateNextBackOffMillis ();
		}
#pragma warning restore 0169

		IntPtr id_calculateNextBackOffMillis;
		public unsafe void CalculateNextBackOffMillis ()
		{
			if (id_calculateNextBackOffMillis == IntPtr.Zero)
				id_calculateNextBackOffMillis = JNIEnv.GetMethodID (class_ref, "calculateNextBackOffMillis", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_calculateNextBackOffMillis);
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
			global::Com.Liveperson.Infra.Network.IBackOff __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.IBackOff> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		IntPtr id_reset;
		public unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
		}

	}

}
