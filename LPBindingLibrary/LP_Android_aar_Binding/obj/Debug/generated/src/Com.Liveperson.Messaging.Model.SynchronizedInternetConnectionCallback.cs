using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='SynchronizedInternetConnectionCallback']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/model/SynchronizedInternetConnectionCallback", DoNotGenerateAcw=true)]
	public partial class SynchronizedInternetConnectionCallback : global::Java.Lang.Object, global::Com.Liveperson.Infra.ICommand {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='SynchronizedInternetConnectionCallback']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr handled_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='SynchronizedInternetConnectionCallback']/field[@name='handled']"
		[Register ("handled")]
		protected bool Handled {
			get {
				if (handled_jfieldId == IntPtr.Zero)
					handled_jfieldId = JNIEnv.GetFieldID (class_ref, "handled", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, handled_jfieldId);
			}
			set {
				if (handled_jfieldId == IntPtr.Zero)
					handled_jfieldId = JNIEnv.GetFieldID (class_ref, "handled", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, handled_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mCallback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='SynchronizedInternetConnectionCallback']/field[@name='mCallback']"
		[Register ("mCallback")]
		protected global::Java.Lang.IRunnable MCallback {
			get {
				if (mCallback_jfieldId == IntPtr.Zero)
					mCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mCallback", "Ljava/lang/Runnable;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCallback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCallback_jfieldId == IntPtr.Zero)
					mCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mCallback", "Ljava/lang/Runnable;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCallback_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mLocalBroadcastReceiver_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='SynchronizedInternetConnectionCallback']/field[@name='mLocalBroadcastReceiver']"
		[Register ("mLocalBroadcastReceiver")]
		protected global::Com.Liveperson.Infra.LocalBroadcastReceiver MLocalBroadcastReceiver {
			get {
				if (mLocalBroadcastReceiver_jfieldId == IntPtr.Zero)
					mLocalBroadcastReceiver_jfieldId = JNIEnv.GetFieldID (class_ref, "mLocalBroadcastReceiver", "Lcom/liveperson/infra/LocalBroadcastReceiver;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mLocalBroadcastReceiver_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LocalBroadcastReceiver> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mLocalBroadcastReceiver_jfieldId == IntPtr.Zero)
					mLocalBroadcastReceiver_jfieldId = JNIEnv.GetFieldID (class_ref, "mLocalBroadcastReceiver", "Lcom/liveperson/infra/LocalBroadcastReceiver;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mLocalBroadcastReceiver_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/model/SynchronizedInternetConnectionCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SynchronizedInternetConnectionCallback); }
		}

		protected SynchronizedInternetConnectionCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Runnable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='SynchronizedInternetConnectionCallback']/constructor[@name='SynchronizedInternetConnectionCallback' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register (".ctor", "(Ljava/lang/Runnable;)V", "")]
		public unsafe SynchronizedInternetConnectionCallback (global::Java.Lang.IRunnable p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (SynchronizedInternetConnectionCallback)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Runnable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Runnable;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Runnable_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Runnable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Runnable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Runnable_, __args);
			} finally {
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
			global::Com.Liveperson.Messaging.Model.SynchronizedInternetConnectionCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.SynchronizedInternetConnectionCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		static IntPtr id_execute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='SynchronizedInternetConnectionCallback']/method[@name='execute' and count(parameter)=0]"
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

	}
}
