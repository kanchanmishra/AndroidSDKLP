using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Controller {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.controller']/class[@name='PlayingAudioManager']"
	[global::Android.Runtime.Register ("com/liveperson/infra/controller/PlayingAudioManager", DoNotGenerateAcw=true)]
	public sealed partial class PlayingAudioManager : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/controller/PlayingAudioManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlayingAudioManager); }
		}

		internal PlayingAudioManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.controller']/class[@name='PlayingAudioManager']/constructor[@name='PlayingAudioManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PlayingAudioManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PlayingAudioManager)) {
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

		static IntPtr id_getMCurrentlyPlayingList;
		public unsafe global::System.Collections.Generic.ICollection<global::Com.Liveperson.Infra.Controller.IAudioPlayable> MCurrentlyPlayingList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.controller']/class[@name='PlayingAudioManager']/method[@name='getMCurrentlyPlayingList' and count(parameter)=0]"
			[Register ("getMCurrentlyPlayingList", "()Ljava/util/Set;", "GetGetMCurrentlyPlayingListHandler")]
			get {
				if (id_getMCurrentlyPlayingList == IntPtr.Zero)
					id_getMCurrentlyPlayingList = JNIEnv.GetMethodID (class_ref, "getMCurrentlyPlayingList", "()Ljava/util/Set;");
				try {
					return global::Android.Runtime.JavaSet<global::Com.Liveperson.Infra.Controller.IAudioPlayable>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMCurrentlyPlayingList), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_addPlayingAndStopOthers_Lcom_liveperson_infra_controller_AudioPlayable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.controller']/class[@name='PlayingAudioManager']/method[@name='addPlayingAndStopOthers' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.controller.AudioPlayable']]"
		[Register ("addPlayingAndStopOthers", "(Lcom/liveperson/infra/controller/AudioPlayable;)V", "")]
		public unsafe void AddPlayingAndStopOthers (global::Com.Liveperson.Infra.Controller.IAudioPlayable p0)
		{
			if (id_addPlayingAndStopOthers_Lcom_liveperson_infra_controller_AudioPlayable_ == IntPtr.Zero)
				id_addPlayingAndStopOthers_Lcom_liveperson_infra_controller_AudioPlayable_ = JNIEnv.GetMethodID (class_ref, "addPlayingAndStopOthers", "(Lcom/liveperson/infra/controller/AudioPlayable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addPlayingAndStopOthers_Lcom_liveperson_infra_controller_AudioPlayable_, __args);
			} finally {
			}
		}

		static IntPtr id_removePlaying_Lcom_liveperson_infra_controller_AudioPlayable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.controller']/class[@name='PlayingAudioManager']/method[@name='removePlaying' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.controller.AudioPlayable']]"
		[Register ("removePlaying", "(Lcom/liveperson/infra/controller/AudioPlayable;)V", "")]
		public unsafe void RemovePlaying (global::Com.Liveperson.Infra.Controller.IAudioPlayable p0)
		{
			if (id_removePlaying_Lcom_liveperson_infra_controller_AudioPlayable_ == IntPtr.Zero)
				id_removePlaying_Lcom_liveperson_infra_controller_AudioPlayable_ = JNIEnv.GetMethodID (class_ref, "removePlaying", "(Lcom/liveperson/infra/controller/AudioPlayable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removePlaying_Lcom_liveperson_infra_controller_AudioPlayable_, __args);
			} finally {
			}
		}

		static IntPtr id_stopAllCurrentlyPlaying;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.controller']/class[@name='PlayingAudioManager']/method[@name='stopAllCurrentlyPlaying' and count(parameter)=0]"
		[Register ("stopAllCurrentlyPlaying", "()V", "")]
		public unsafe void StopAllCurrentlyPlaying ()
		{
			if (id_stopAllCurrentlyPlaying == IntPtr.Zero)
				id_stopAllCurrentlyPlaying = JNIEnv.GetMethodID (class_ref, "stopAllCurrentlyPlaying", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopAllCurrentlyPlaying);
			} finally {
			}
		}

		static IntPtr id_stopPlaying_Lcom_liveperson_infra_controller_AudioPlayable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.controller']/class[@name='PlayingAudioManager']/method[@name='stopPlaying' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.controller.AudioPlayable']]"
		[Register ("stopPlaying", "(Lcom/liveperson/infra/controller/AudioPlayable;)V", "")]
		public unsafe void StopPlaying (global::Com.Liveperson.Infra.Controller.IAudioPlayable p0)
		{
			if (id_stopPlaying_Lcom_liveperson_infra_controller_AudioPlayable_ == IntPtr.Zero)
				id_stopPlaying_Lcom_liveperson_infra_controller_AudioPlayable_ = JNIEnv.GetMethodID (class_ref, "stopPlaying", "(Lcom/liveperson/infra/controller/AudioPlayable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopPlaying_Lcom_liveperson_infra_controller_AudioPlayable_, __args);
			} finally {
			}
		}

	}
}
