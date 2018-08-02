using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Controller {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.controller']/interface[@name='AudioPlayable']"
	[Register ("com/liveperson/infra/controller/AudioPlayable", "", "Com.Liveperson.Infra.Controller.IAudioPlayableInvoker")]
	public partial interface IAudioPlayable : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.controller']/interface[@name='AudioPlayable']/method[@name='playVoiceMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("playVoiceMessage", "(Ljava/lang/String;)V", "GetPlayVoiceMessage_Ljava_lang_String_Handler:Com.Liveperson.Infra.Controller.IAudioPlayableInvoker, LP_Android_aar_Binding")]
		void PlayVoiceMessage (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.controller']/interface[@name='AudioPlayable']/method[@name='stopPlaying' and count(parameter)=0]"
		[Register ("stopPlaying", "()V", "GetStopPlayingHandler:Com.Liveperson.Infra.Controller.IAudioPlayableInvoker, LP_Android_aar_Binding")]
		void StopPlaying ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/controller/AudioPlayable", DoNotGenerateAcw=true)]
	internal class IAudioPlayableInvoker : global::Java.Lang.Object, IAudioPlayable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/controller/AudioPlayable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAudioPlayableInvoker); }
		}

		IntPtr class_ref;

		public static IAudioPlayable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAudioPlayable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.controller.AudioPlayable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAudioPlayableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_playVoiceMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPlayVoiceMessage_Ljava_lang_String_Handler ()
		{
			if (cb_playVoiceMessage_Ljava_lang_String_ == null)
				cb_playVoiceMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PlayVoiceMessage_Ljava_lang_String_);
			return cb_playVoiceMessage_Ljava_lang_String_;
		}

		static void n_PlayVoiceMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Controller.IAudioPlayable __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Controller.IAudioPlayable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PlayVoiceMessage (p0);
		}
#pragma warning restore 0169

		IntPtr id_playVoiceMessage_Ljava_lang_String_;
		public unsafe void PlayVoiceMessage (string p0)
		{
			if (id_playVoiceMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_playVoiceMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "playVoiceMessage", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_playVoiceMessage_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_stopPlaying;
#pragma warning disable 0169
		static Delegate GetStopPlayingHandler ()
		{
			if (cb_stopPlaying == null)
				cb_stopPlaying = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopPlaying);
			return cb_stopPlaying;
		}

		static void n_StopPlaying (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Controller.IAudioPlayable __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Controller.IAudioPlayable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopPlaying ();
		}
#pragma warning restore 0169

		IntPtr id_stopPlaying;
		public unsafe void StopPlaying ()
		{
			if (id_stopPlaying == IntPtr.Zero)
				id_stopPlaying = JNIEnv.GetMethodID (class_ref, "stopPlaying", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopPlaying);
		}

	}

}
