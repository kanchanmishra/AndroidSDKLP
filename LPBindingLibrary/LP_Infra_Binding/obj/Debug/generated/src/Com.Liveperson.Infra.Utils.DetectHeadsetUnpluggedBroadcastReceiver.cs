using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DetectHeadsetUnpluggedBroadcastReceiver']"
	[global::Android.Runtime.Register ("com/liveperson/infra/utils/DetectHeadsetUnpluggedBroadcastReceiver", DoNotGenerateAcw=true)]
	public abstract partial class DetectHeadsetUnpluggedBroadcastReceiver : global::Android.Content.BroadcastReceiver {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DetectHeadsetUnpluggedBroadcastReceiver']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "DetectHeadsetUnpluggedBroadcastReceiver";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/utils/DetectHeadsetUnpluggedBroadcastReceiver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DetectHeadsetUnpluggedBroadcastReceiver); }
		}

		protected DetectHeadsetUnpluggedBroadcastReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DetectHeadsetUnpluggedBroadcastReceiver']/constructor[@name='DetectHeadsetUnpluggedBroadcastReceiver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DetectHeadsetUnpluggedBroadcastReceiver ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DetectHeadsetUnpluggedBroadcastReceiver)) {
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

		static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler ()
		{
			if (cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
				cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReceive_Landroid_content_Context_Landroid_content_Intent_);
			return cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		}

		static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Utils.DetectHeadsetUnpluggedBroadcastReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.DetectHeadsetUnpluggedBroadcastReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnReceive (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DetectHeadsetUnpluggedBroadcastReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
		public override unsafe void OnReceive (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_onReceive_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceive_Landroid_content_Context_Landroid_content_Intent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onUnpluggedHeadset;
#pragma warning disable 0169
		static Delegate GetOnUnpluggedHeadsetHandler ()
		{
			if (cb_onUnpluggedHeadset == null)
				cb_onUnpluggedHeadset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnUnpluggedHeadset);
			return cb_onUnpluggedHeadset;
		}

		static void n_OnUnpluggedHeadset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.DetectHeadsetUnpluggedBroadcastReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.DetectHeadsetUnpluggedBroadcastReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUnpluggedHeadset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DetectHeadsetUnpluggedBroadcastReceiver']/method[@name='onUnpluggedHeadset' and count(parameter)=0]"
		[Register ("onUnpluggedHeadset", "()V", "GetOnUnpluggedHeadsetHandler")]
		protected abstract void OnUnpluggedHeadset ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/utils/DetectHeadsetUnpluggedBroadcastReceiver", DoNotGenerateAcw=true)]
	internal partial class DetectHeadsetUnpluggedBroadcastReceiverInvoker : DetectHeadsetUnpluggedBroadcastReceiver {

		public DetectHeadsetUnpluggedBroadcastReceiverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (DetectHeadsetUnpluggedBroadcastReceiverInvoker); }
		}

		static IntPtr id_onUnpluggedHeadset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DetectHeadsetUnpluggedBroadcastReceiver']/method[@name='onUnpluggedHeadset' and count(parameter)=0]"
		[Register ("onUnpluggedHeadset", "()V", "GetOnUnpluggedHeadsetHandler")]
		protected override unsafe void OnUnpluggedHeadset ()
		{
			if (id_onUnpluggedHeadset == IntPtr.Zero)
				id_onUnpluggedHeadset = JNIEnv.GetMethodID (class_ref, "onUnpluggedHeadset", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUnpluggedHeadset);
			} finally {
			}
		}

	}

}
