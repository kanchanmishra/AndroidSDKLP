using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Background.Filesharing.Voice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.voice']/class[@name='DownloadVoiceTask']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/background/filesharing/voice/DownloadVoiceTask", DoNotGenerateAcw=true)]
	public partial class DownloadVoiceTask : global::Com.Liveperson.Messaging.Background.DownloadFileTask {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/background/filesharing/voice/DownloadVoiceTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DownloadVoiceTask); }
		}

		protected DownloadVoiceTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_background_filesharing_DownloadFileTaskBundle_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.voice']/class[@name='DownloadVoiceTask']/constructor[@name='DownloadVoiceTask' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.background.filesharing.DownloadFileTaskBundle']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/background/filesharing/DownloadFileTaskBundle;)V", "")]
		public unsafe DownloadVoiceTask (global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (DownloadVoiceTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/background/filesharing/DownloadFileTaskBundle;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/background/filesharing/DownloadFileTaskBundle;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_background_filesharing_DownloadFileTaskBundle_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_background_filesharing_DownloadFileTaskBundle_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/background/filesharing/DownloadFileTaskBundle;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_background_filesharing_DownloadFileTaskBundle_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_background_filesharing_DownloadFileTaskBundle_, __args);
			} finally {
			}
		}

		static Delegate cb_saveFileToDisk_arrayB;
#pragma warning disable 0169
		static Delegate GetSaveFileToDisk_arrayBHandler ()
		{
			if (cb_saveFileToDisk_arrayB == null)
				cb_saveFileToDisk_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SaveFileToDisk_arrayB);
			return cb_saveFileToDisk_arrayB;
		}

		static IntPtr n_SaveFileToDisk_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.Voice.DownloadVoiceTask __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Voice.DownloadVoiceTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewString (__this.SaveFileToDisk (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_saveFileToDisk_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.voice']/class[@name='DownloadVoiceTask']/method[@name='saveFileToDisk' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("saveFileToDisk", "([B)Ljava/lang/String;", "GetSaveFileToDisk_arrayBHandler")]
		protected override unsafe string SaveFileToDisk (byte[] p0)
		{
			if (id_saveFileToDisk_arrayB == IntPtr.Zero)
				id_saveFileToDisk_arrayB = JNIEnv.GetMethodID (class_ref, "saveFileToDisk", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_saveFileToDisk_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveFileToDisk", "([B)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
