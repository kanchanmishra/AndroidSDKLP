using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils']"
	[global::Android.Runtime.Register ("com/liveperson/infra/utils/LPAudioUtils", DoNotGenerateAcw=true)]
	public partial class LPAudioUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "LPAudioUtils";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils.LPMediaPlayer']"
		[global::Android.Runtime.Register ("com/liveperson/infra/utils/LPAudioUtils$LPMediaPlayer", DoNotGenerateAcw=true)]
		public partial class LPMediaPlayer : global::Android.Media.MediaPlayer {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/utils/LPAudioUtils$LPMediaPlayer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LPMediaPlayer); }
			}

			protected LPMediaPlayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_infra_utils_LPAudioUtils_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils.LPMediaPlayer']/constructor[@name='LPAudioUtils.LPMediaPlayer' and count(parameter)=3 and parameter[1][@type='com.liveperson.infra.utils.LPAudioUtils'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/liveperson/infra/utils/LPAudioUtils;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe LPMediaPlayer (global::Com.Liveperson.Infra.Utils.LPAudioUtils __self, string p1, string p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					if (((object) this).GetType () != typeof (LPMediaPlayer)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_infra_utils_LPAudioUtils_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_infra_utils_LPAudioUtils_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/utils/LPAudioUtils;Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_utils_LPAudioUtils_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_utils_LPAudioUtils_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

			static Delegate cb_getCallbackId;
#pragma warning disable 0169
			static Delegate GetGetCallbackIdHandler ()
			{
				if (cb_getCallbackId == null)
					cb_getCallbackId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCallbackId);
				return cb_getCallbackId;
			}

			static IntPtr n_GetCallbackId (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.Utils.LPAudioUtils.LPMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils.LPMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.CallbackId);
			}
#pragma warning restore 0169

			static IntPtr id_getCallbackId;
			public virtual unsafe string CallbackId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils.LPMediaPlayer']/method[@name='getCallbackId' and count(parameter)=0]"
				[Register ("getCallbackId", "()Ljava/lang/String;", "GetGetCallbackIdHandler")]
				get {
					if (id_getCallbackId == IntPtr.Zero)
						id_getCallbackId = JNIEnv.GetMethodID (class_ref, "getCallbackId", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCallbackId), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCallbackId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_isCurrentlyPlaying;
#pragma warning disable 0169
			static Delegate GetIsCurrentlyPlayingHandler ()
			{
				if (cb_isCurrentlyPlaying == null)
					cb_isCurrentlyPlaying = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCurrentlyPlaying);
				return cb_isCurrentlyPlaying;
			}

			static bool n_IsCurrentlyPlaying (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.Utils.LPAudioUtils.LPMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils.LPMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsCurrentlyPlaying;
			}
#pragma warning restore 0169

			static IntPtr id_isCurrentlyPlaying;
			public virtual unsafe bool IsCurrentlyPlaying {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils.LPMediaPlayer']/method[@name='isCurrentlyPlaying' and count(parameter)=0]"
				[Register ("isCurrentlyPlaying", "()Z", "GetIsCurrentlyPlayingHandler")]
				get {
					if (id_isCurrentlyPlaying == IntPtr.Zero)
						id_isCurrentlyPlaying = JNIEnv.GetMethodID (class_ref, "isCurrentlyPlaying", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCurrentlyPlaying);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCurrentlyPlaying", "()Z"));
					} finally {
					}
				}
			}

			static Delegate cb_getLocalFileUrl;
#pragma warning disable 0169
			static Delegate GetGetLocalFileUrlHandler ()
			{
				if (cb_getLocalFileUrl == null)
					cb_getLocalFileUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocalFileUrl);
				return cb_getLocalFileUrl;
			}

			static IntPtr n_GetLocalFileUrl (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.Utils.LPAudioUtils.LPMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils.LPMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.LocalFileUrl);
			}
#pragma warning restore 0169

			static IntPtr id_getLocalFileUrl;
			public virtual unsafe string LocalFileUrl {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils.LPMediaPlayer']/method[@name='getLocalFileUrl' and count(parameter)=0]"
				[Register ("getLocalFileUrl", "()Ljava/lang/String;", "GetGetLocalFileUrlHandler")]
				get {
					if (id_getLocalFileUrl == IntPtr.Zero)
						id_getLocalFileUrl = JNIEnv.GetMethodID (class_ref, "getLocalFileUrl", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocalFileUrl), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocalFileUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_isPlaying_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetInvokeIsPlaying_Ljava_lang_String_Handler ()
			{
				if (cb_isPlaying_Ljava_lang_String_ == null)
					cb_isPlaying_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_InvokeIsPlaying_Ljava_lang_String_);
				return cb_isPlaying_Ljava_lang_String_;
			}

			static bool n_InvokeIsPlaying_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Infra.Utils.LPAudioUtils.LPMediaPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils.LPMediaPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.InvokeIsPlaying (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_isPlaying_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils.LPMediaPlayer']/method[@name='isPlaying' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("isPlaying", "(Ljava/lang/String;)Z", "GetInvokeIsPlaying_Ljava_lang_String_Handler")]
			public virtual unsafe bool InvokeIsPlaying (string p0)
			{
				if (id_isPlaying_Ljava_lang_String_ == IntPtr.Zero)
					id_isPlaying_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isPlaying", "(Ljava/lang/String;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					bool __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPlaying_Ljava_lang_String_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPlaying", "(Ljava/lang/String;)Z"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils.LPRecorderStatus']"
		[global::Android.Runtime.Register ("com/liveperson/infra/utils/LPAudioUtils$LPRecorderStatus", DoNotGenerateAcw=true)]
		public sealed partial class LPRecorderStatus : global::Java.Lang.Enum {


			static IntPtr Failed_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils.LPRecorderStatus']/field[@name='Failed']"
			[Register ("Failed")]
			public static global::Com.Liveperson.Infra.Utils.LPAudioUtils.LPRecorderStatus Failed {
				get {
					if (Failed_jfieldId == IntPtr.Zero)
						Failed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Failed", "Lcom/liveperson/infra/utils/LPAudioUtils$LPRecorderStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Failed_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils.LPRecorderStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Finished_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils.LPRecorderStatus']/field[@name='Finished']"
			[Register ("Finished")]
			public static global::Com.Liveperson.Infra.Utils.LPAudioUtils.LPRecorderStatus Finished {
				get {
					if (Finished_jfieldId == IntPtr.Zero)
						Finished_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Finished", "Lcom/liveperson/infra/utils/LPAudioUtils$LPRecorderStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Finished_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils.LPRecorderStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PermissionDenied_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils.LPRecorderStatus']/field[@name='PermissionDenied']"
			[Register ("PermissionDenied")]
			public static global::Com.Liveperson.Infra.Utils.LPAudioUtils.LPRecorderStatus PermissionDenied {
				get {
					if (PermissionDenied_jfieldId == IntPtr.Zero)
						PermissionDenied_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PermissionDenied", "Lcom/liveperson/infra/utils/LPAudioUtils$LPRecorderStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PermissionDenied_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils.LPRecorderStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Started_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils.LPRecorderStatus']/field[@name='Started']"
			[Register ("Started")]
			public static global::Com.Liveperson.Infra.Utils.LPAudioUtils.LPRecorderStatus Started {
				get {
					if (Started_jfieldId == IntPtr.Zero)
						Started_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Started", "Lcom/liveperson/infra/utils/LPAudioUtils$LPRecorderStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Started_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils.LPRecorderStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/utils/LPAudioUtils$LPRecorderStatus", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LPRecorderStatus); }
			}

			internal LPRecorderStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils.LPRecorderStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/utils/LPAudioUtils$LPRecorderStatus;", "")]
			public static unsafe global::Com.Liveperson.Infra.Utils.LPAudioUtils.LPRecorderStatus ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/utils/LPAudioUtils$LPRecorderStatus;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Liveperson.Infra.Utils.LPAudioUtils.LPRecorderStatus __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils.LPRecorderStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils.LPRecorderStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/liveperson/infra/utils/LPAudioUtils$LPRecorderStatus;", "")]
			public static unsafe global::Com.Liveperson.Infra.Utils.LPAudioUtils.LPRecorderStatus[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/infra/utils/LPAudioUtils$LPRecorderStatus;");
				try {
					return (global::Com.Liveperson.Infra.Utils.LPAudioUtils.LPRecorderStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Infra.Utils.LPAudioUtils.LPRecorderStatus));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.utils']/interface[@name='LPAudioUtils.MaxRecordingDurationReachedListener']"
		[Register ("com/liveperson/infra/utils/LPAudioUtils$MaxRecordingDurationReachedListener", "", "Com.Liveperson.Infra.Utils.LPAudioUtils/IMaxRecordingDurationReachedListenerInvoker")]
		public partial interface IMaxRecordingDurationReachedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/interface[@name='LPAudioUtils.MaxRecordingDurationReachedListener']/method[@name='onMaxRecordingDurationReached' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onMaxRecordingDurationReached", "(Ljava/lang/String;)V", "GetOnMaxRecordingDurationReached_Ljava_lang_String_Handler:Com.Liveperson.Infra.Utils.LPAudioUtils/IMaxRecordingDurationReachedListenerInvoker, LP_Android_aar_Binding")]
			void OnMaxRecordingDurationReached (string p0);

		}

		[global::Android.Runtime.Register ("com/liveperson/infra/utils/LPAudioUtils$MaxRecordingDurationReachedListener", DoNotGenerateAcw=true)]
		internal class IMaxRecordingDurationReachedListenerInvoker : global::Java.Lang.Object, IMaxRecordingDurationReachedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/utils/LPAudioUtils$MaxRecordingDurationReachedListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IMaxRecordingDurationReachedListenerInvoker); }
			}

			IntPtr class_ref;

			public static IMaxRecordingDurationReachedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMaxRecordingDurationReachedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.utils.LPAudioUtils.MaxRecordingDurationReachedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IMaxRecordingDurationReachedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMaxRecordingDurationReached_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnMaxRecordingDurationReached_Ljava_lang_String_Handler ()
			{
				if (cb_onMaxRecordingDurationReached_Ljava_lang_String_ == null)
					cb_onMaxRecordingDurationReached_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMaxRecordingDurationReached_Ljava_lang_String_);
				return cb_onMaxRecordingDurationReached_Ljava_lang_String_;
			}

			static void n_OnMaxRecordingDurationReached_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Infra.Utils.LPAudioUtils.IMaxRecordingDurationReachedListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils.IMaxRecordingDurationReachedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMaxRecordingDurationReached (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMaxRecordingDurationReached_Ljava_lang_String_;
			public unsafe void OnMaxRecordingDurationReached (string p0)
			{
				if (id_onMaxRecordingDurationReached_Ljava_lang_String_ == IntPtr.Zero)
					id_onMaxRecordingDurationReached_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onMaxRecordingDurationReached", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMaxRecordingDurationReached_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		public partial class MaxRecordingDurationReachedEventArgs : global::System.EventArgs {

			public MaxRecordingDurationReachedEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/liveperson/infra/utils/LPAudioUtils_MaxRecordingDurationReachedListenerImplementor")]
		internal sealed partial class IMaxRecordingDurationReachedListenerImplementor : global::Java.Lang.Object, IMaxRecordingDurationReachedListener {

			object sender;

			public IMaxRecordingDurationReachedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/liveperson/infra/utils/LPAudioUtils_MaxRecordingDurationReachedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MaxRecordingDurationReachedEventArgs> Handler;
#pragma warning restore 0649

			public void OnMaxRecordingDurationReached (string p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new MaxRecordingDurationReachedEventArgs (p0));
			}

			internal static bool __IsEmpty (IMaxRecordingDurationReachedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.utils']/interface[@name='LPAudioUtils.PlaybackCallback']"
		[Register ("com/liveperson/infra/utils/LPAudioUtils$PlaybackCallback", "", "Com.Liveperson.Infra.Utils.LPAudioUtils/IPlaybackCallbackInvoker")]
		public partial interface IPlaybackCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/interface[@name='LPAudioUtils.PlaybackCallback']/method[@name='onPlaybackCompleted' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
			[Register ("onPlaybackCompleted", "(ZLjava/lang/String;)V", "GetOnPlaybackCompleted_ZLjava_lang_String_Handler:Com.Liveperson.Infra.Utils.LPAudioUtils/IPlaybackCallbackInvoker, LP_Android_aar_Binding")]
			void OnPlaybackCompleted (bool p0, string p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/interface[@name='LPAudioUtils.PlaybackCallback']/method[@name='onPlaybackStarted' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
			[Register ("onPlaybackStarted", "(Ljava/lang/String;I)V", "GetOnPlaybackStarted_Ljava_lang_String_IHandler:Com.Liveperson.Infra.Utils.LPAudioUtils/IPlaybackCallbackInvoker, LP_Android_aar_Binding")]
			void OnPlaybackStarted (string p0, int p1);

		}

		[global::Android.Runtime.Register ("com/liveperson/infra/utils/LPAudioUtils$PlaybackCallback", DoNotGenerateAcw=true)]
		internal class IPlaybackCallbackInvoker : global::Java.Lang.Object, IPlaybackCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/utils/LPAudioUtils$PlaybackCallback");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IPlaybackCallbackInvoker); }
			}

			IntPtr class_ref;

			public static IPlaybackCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPlaybackCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.utils.LPAudioUtils.PlaybackCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPlaybackCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onPlaybackCompleted_ZLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnPlaybackCompleted_ZLjava_lang_String_Handler ()
			{
				if (cb_onPlaybackCompleted_ZLjava_lang_String_ == null)
					cb_onPlaybackCompleted_ZLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_OnPlaybackCompleted_ZLjava_lang_String_);
				return cb_onPlaybackCompleted_ZLjava_lang_String_;
			}

			static void n_OnPlaybackCompleted_ZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
			{
				global::Com.Liveperson.Infra.Utils.LPAudioUtils.IPlaybackCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils.IPlaybackCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnPlaybackCompleted (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onPlaybackCompleted_ZLjava_lang_String_;
			public unsafe void OnPlaybackCompleted (bool p0, string p1)
			{
				if (id_onPlaybackCompleted_ZLjava_lang_String_ == IntPtr.Zero)
					id_onPlaybackCompleted_ZLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onPlaybackCompleted", "(ZLjava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPlaybackCompleted_ZLjava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p1);
			}

			static Delegate cb_onPlaybackStarted_Ljava_lang_String_I;
#pragma warning disable 0169
			static Delegate GetOnPlaybackStarted_Ljava_lang_String_IHandler ()
			{
				if (cb_onPlaybackStarted_Ljava_lang_String_I == null)
					cb_onPlaybackStarted_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnPlaybackStarted_Ljava_lang_String_I);
				return cb_onPlaybackStarted_Ljava_lang_String_I;
			}

			static void n_OnPlaybackStarted_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::Com.Liveperson.Infra.Utils.LPAudioUtils.IPlaybackCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils.IPlaybackCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPlaybackStarted (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onPlaybackStarted_Ljava_lang_String_I;
			public unsafe void OnPlaybackStarted (string p0, int p1)
			{
				if (id_onPlaybackStarted_Ljava_lang_String_I == IntPtr.Zero)
					id_onPlaybackStarted_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onPlaybackStarted", "(Ljava/lang/String;I)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPlaybackStarted_Ljava_lang_String_I, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/utils/LPAudioUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LPAudioUtils); }
		}

		protected LPAudioUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils']/constructor[@name='LPAudioUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LPAudioUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LPAudioUtils)) {
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

		static Delegate cb_getCurrentPlayingDuration;
#pragma warning disable 0169
		static Delegate GetGetCurrentPlayingDurationHandler ()
		{
			if (cb_getCurrentPlayingDuration == null)
				cb_getCurrentPlayingDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentPlayingDuration);
			return cb_getCurrentPlayingDuration;
		}

		static int n_GetCurrentPlayingDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.LPAudioUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentPlayingDuration;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentPlayingDuration;
		public virtual unsafe int CurrentPlayingDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils']/method[@name='getCurrentPlayingDuration' and count(parameter)=0]"
			[Register ("getCurrentPlayingDuration", "()I", "GetGetCurrentPlayingDurationHandler")]
			get {
				if (id_getCurrentPlayingDuration == IntPtr.Zero)
					id_getCurrentPlayingDuration = JNIEnv.GetMethodID (class_ref, "getCurrentPlayingDuration", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentPlayingDuration);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentPlayingDuration", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentPlayingLocation;
#pragma warning disable 0169
		static Delegate GetGetCurrentPlayingLocationHandler ()
		{
			if (cb_getCurrentPlayingLocation == null)
				cb_getCurrentPlayingLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentPlayingLocation);
			return cb_getCurrentPlayingLocation;
		}

		static int n_GetCurrentPlayingLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.LPAudioUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentPlayingLocation;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentPlayingLocation;
		public virtual unsafe int CurrentPlayingLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils']/method[@name='getCurrentPlayingLocation' and count(parameter)=0]"
			[Register ("getCurrentPlayingLocation", "()I", "GetGetCurrentPlayingLocationHandler")]
			get {
				if (id_getCurrentPlayingLocation == IntPtr.Zero)
					id_getCurrentPlayingLocation = JNIEnv.GetMethodID (class_ref, "getCurrentPlayingLocation", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentPlayingLocation);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentPlayingLocation", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isRecording;
#pragma warning disable 0169
		static Delegate GetIsRecordingHandler ()
		{
			if (cb_isRecording == null)
				cb_isRecording = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRecording);
			return cb_isRecording;
		}

		static bool n_IsRecording (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.LPAudioUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRecording;
		}
#pragma warning restore 0169

		static IntPtr id_isRecording;
		public virtual unsafe bool IsRecording {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils']/method[@name='isRecording' and count(parameter)=0]"
			[Register ("isRecording", "()Z", "GetIsRecordingHandler")]
			get {
				if (id_isRecording == IntPtr.Zero)
					id_isRecording = JNIEnv.GetMethodID (class_ref, "isRecording", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRecording);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRecording", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getPlayingAudioManager;
#pragma warning disable 0169
		static Delegate GetGetPlayingAudioManagerHandler ()
		{
			if (cb_getPlayingAudioManager == null)
				cb_getPlayingAudioManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlayingAudioManager);
			return cb_getPlayingAudioManager;
		}

		static IntPtr n_GetPlayingAudioManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.LPAudioUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PlayingAudioManager);
		}
#pragma warning restore 0169

		static IntPtr id_getPlayingAudioManager;
		public virtual unsafe global::Com.Liveperson.Infra.Controller.PlayingAudioManager PlayingAudioManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils']/method[@name='getPlayingAudioManager' and count(parameter)=0]"
			[Register ("getPlayingAudioManager", "()Lcom/liveperson/infra/controller/PlayingAudioManager;", "GetGetPlayingAudioManagerHandler")]
			get {
				if (id_getPlayingAudioManager == IntPtr.Zero)
					id_getPlayingAudioManager = JNIEnv.GetMethodID (class_ref, "getPlayingAudioManager", "()Lcom/liveperson/infra/controller/PlayingAudioManager;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Controller.PlayingAudioManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlayingAudioManager), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Controller.PlayingAudioManager> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlayingAudioManager", "()Lcom/liveperson/infra/controller/PlayingAudioManager;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVoiceFolder;
#pragma warning disable 0169
		static Delegate GetGetVoiceFolderHandler ()
		{
			if (cb_getVoiceFolder == null)
				cb_getVoiceFolder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVoiceFolder);
			return cb_getVoiceFolder;
		}

		static IntPtr n_GetVoiceFolder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.LPAudioUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VoiceFolder);
		}
#pragma warning restore 0169

		static IntPtr id_getVoiceFolder;
		public virtual unsafe string VoiceFolder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils']/method[@name='getVoiceFolder' and count(parameter)=0]"
			[Register ("getVoiceFolder", "()Ljava/lang/String;", "GetGetVoiceFolderHandler")]
			get {
				if (id_getVoiceFolder == IntPtr.Zero)
					id_getVoiceFolder = JNIEnv.GetMethodID (class_ref, "getVoiceFolder", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVoiceFolder), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVoiceFolder", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_bindPlayingAudio_Ljava_lang_String_Lcom_liveperson_infra_utils_LPAudioUtils_PlaybackCallback_;
#pragma warning disable 0169
		static Delegate GetBindPlayingAudio_Ljava_lang_String_Lcom_liveperson_infra_utils_LPAudioUtils_PlaybackCallback_Handler ()
		{
			if (cb_bindPlayingAudio_Ljava_lang_String_Lcom_liveperson_infra_utils_LPAudioUtils_PlaybackCallback_ == null)
				cb_bindPlayingAudio_Ljava_lang_String_Lcom_liveperson_infra_utils_LPAudioUtils_PlaybackCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_BindPlayingAudio_Ljava_lang_String_Lcom_liveperson_infra_utils_LPAudioUtils_PlaybackCallback_);
			return cb_bindPlayingAudio_Ljava_lang_String_Lcom_liveperson_infra_utils_LPAudioUtils_PlaybackCallback_;
		}

		static void n_BindPlayingAudio_Ljava_lang_String_Lcom_liveperson_infra_utils_LPAudioUtils_PlaybackCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Utils.LPAudioUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Utils.LPAudioUtils.IPlaybackCallback p1 = (global::Com.Liveperson.Infra.Utils.LPAudioUtils.IPlaybackCallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils.IPlaybackCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.BindPlayingAudio (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_bindPlayingAudio_Ljava_lang_String_Lcom_liveperson_infra_utils_LPAudioUtils_PlaybackCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils']/method[@name='bindPlayingAudio' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.utils.LPAudioUtils.PlaybackCallback']]"
		[Register ("bindPlayingAudio", "(Ljava/lang/String;Lcom/liveperson/infra/utils/LPAudioUtils$PlaybackCallback;)V", "GetBindPlayingAudio_Ljava_lang_String_Lcom_liveperson_infra_utils_LPAudioUtils_PlaybackCallback_Handler")]
		public virtual unsafe void BindPlayingAudio (string p0, global::Com.Liveperson.Infra.Utils.LPAudioUtils.IPlaybackCallback p1)
		{
			if (id_bindPlayingAudio_Ljava_lang_String_Lcom_liveperson_infra_utils_LPAudioUtils_PlaybackCallback_ == IntPtr.Zero)
				id_bindPlayingAudio_Ljava_lang_String_Lcom_liveperson_infra_utils_LPAudioUtils_PlaybackCallback_ = JNIEnv.GetMethodID (class_ref, "bindPlayingAudio", "(Ljava/lang/String;Lcom/liveperson/infra/utils/LPAudioUtils$PlaybackCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bindPlayingAudio_Ljava_lang_String_Lcom_liveperson_infra_utils_LPAudioUtils_PlaybackCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bindPlayingAudio", "(Ljava/lang/String;Lcom/liveperson/infra/utils/LPAudioUtils$PlaybackCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_cancelAndDeleteRecording_Lcom_liveperson_infra_ICallback_;
#pragma warning disable 0169
		static Delegate GetCancelAndDeleteRecording_Lcom_liveperson_infra_ICallback_Handler ()
		{
			if (cb_cancelAndDeleteRecording_Lcom_liveperson_infra_ICallback_ == null)
				cb_cancelAndDeleteRecording_Lcom_liveperson_infra_ICallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CancelAndDeleteRecording_Lcom_liveperson_infra_ICallback_);
			return cb_cancelAndDeleteRecording_Lcom_liveperson_infra_ICallback_;
		}

		static void n_CancelAndDeleteRecording_Lcom_liveperson_infra_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.LPAudioUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ICallback p0 = (global::Com.Liveperson.Infra.ICallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CancelAndDeleteRecording (p0);
		}
#pragma warning restore 0169

		static IntPtr id_cancelAndDeleteRecording_Lcom_liveperson_infra_ICallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils']/method[@name='cancelAndDeleteRecording' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.ICallback&lt;java.lang.Boolean, java.lang.Exception&gt;']]"
		[Register ("cancelAndDeleteRecording", "(Lcom/liveperson/infra/ICallback;)V", "GetCancelAndDeleteRecording_Lcom_liveperson_infra_ICallback_Handler")]
		public virtual unsafe void CancelAndDeleteRecording (global::Com.Liveperson.Infra.ICallback p0)
		{
			if (id_cancelAndDeleteRecording_Lcom_liveperson_infra_ICallback_ == IntPtr.Zero)
				id_cancelAndDeleteRecording_Lcom_liveperson_infra_ICallback_ = JNIEnv.GetMethodID (class_ref, "cancelAndDeleteRecording", "(Lcom/liveperson/infra/ICallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelAndDeleteRecording_Lcom_liveperson_infra_ICallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelAndDeleteRecording", "(Lcom/liveperson/infra/ICallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_deleteVoiceFolder;
#pragma warning disable 0169
		static Delegate GetDeleteVoiceFolderHandler ()
		{
			if (cb_deleteVoiceFolder == null)
				cb_deleteVoiceFolder = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DeleteVoiceFolder);
			return cb_deleteVoiceFolder;
		}

		static void n_DeleteVoiceFolder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.LPAudioUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteVoiceFolder ();
		}
#pragma warning restore 0169

		static IntPtr id_deleteVoiceFolder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils']/method[@name='deleteVoiceFolder' and count(parameter)=0]"
		[Register ("deleteVoiceFolder", "()V", "GetDeleteVoiceFolderHandler")]
		public virtual unsafe void DeleteVoiceFolder ()
		{
			if (id_deleteVoiceFolder == IntPtr.Zero)
				id_deleteVoiceFolder = JNIEnv.GetMethodID (class_ref, "deleteVoiceFolder", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteVoiceFolder);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteVoiceFolder", "()V"));
			} finally {
			}
		}

		static IntPtr id_generateVoiceFileName;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils']/method[@name='generateVoiceFileName' and count(parameter)=0]"
		[Register ("generateVoiceFileName", "()Ljava/lang/String;", "")]
		public static unsafe string GenerateVoiceFileName ()
		{
			if (id_generateVoiceFileName == IntPtr.Zero)
				id_generateVoiceFileName = JNIEnv.GetStaticMethodID (class_ref, "generateVoiceFileName", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateVoiceFileName), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getDuration_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils']/method[@name='getDuration' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.ICallback&lt;java.lang.Integer, java.lang.Exception&gt;']]"
		[Register ("getDuration", "(Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V", "")]
		public static unsafe void GetDuration (string p0, global::Com.Liveperson.Infra.ICallback p1)
		{
			if (id_getDuration_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ == IntPtr.Zero)
				id_getDuration_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ = JNIEnv.GetStaticMethodID (class_ref, "getDuration", "(Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getDuration_Ljava_lang_String_Lcom_liveperson_infra_ICallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isPlaying_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsPlaying_Ljava_lang_String_Handler ()
		{
			if (cb_isPlaying_Ljava_lang_String_ == null)
				cb_isPlaying_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsPlaying_Ljava_lang_String_);
			return cb_isPlaying_Ljava_lang_String_;
		}

		static bool n_IsPlaying_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.LPAudioUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsPlaying (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isPlaying_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils']/method[@name='isPlaying' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isPlaying", "(Ljava/lang/String;)Z", "GetIsPlaying_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsPlaying (string p0)
		{
			if (id_isPlaying_Ljava_lang_String_ == IntPtr.Zero)
				id_isPlaying_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isPlaying", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPlaying_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPlaying", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Pause);
			return cb_pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.LPAudioUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public virtual unsafe void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pause);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pause", "()V"));
			} finally {
			}
		}

		static Delegate cb_playAudio_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_LPAudioUtils_PlaybackCallback_;
#pragma warning disable 0169
		static Delegate GetPlayAudio_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_LPAudioUtils_PlaybackCallback_Handler ()
		{
			if (cb_playAudio_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_LPAudioUtils_PlaybackCallback_ == null)
				cb_playAudio_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_LPAudioUtils_PlaybackCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PlayAudio_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_LPAudioUtils_PlaybackCallback_);
			return cb_playAudio_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_LPAudioUtils_PlaybackCallback_;
		}

		static void n_PlayAudio_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_LPAudioUtils_PlaybackCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Infra.Utils.LPAudioUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Utils.LPAudioUtils.IPlaybackCallback p2 = (global::Com.Liveperson.Infra.Utils.LPAudioUtils.IPlaybackCallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils.IPlaybackCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.PlayAudio (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_playAudio_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_LPAudioUtils_PlaybackCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils']/method[@name='playAudio' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.infra.utils.LPAudioUtils.PlaybackCallback']]"
		[Register ("playAudio", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/utils/LPAudioUtils$PlaybackCallback;)V", "GetPlayAudio_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_LPAudioUtils_PlaybackCallback_Handler")]
		public virtual unsafe void PlayAudio (string p0, string p1, global::Com.Liveperson.Infra.Utils.LPAudioUtils.IPlaybackCallback p2)
		{
			if (id_playAudio_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_LPAudioUtils_PlaybackCallback_ == IntPtr.Zero)
				id_playAudio_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_LPAudioUtils_PlaybackCallback_ = JNIEnv.GetMethodID (class_ref, "playAudio", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/utils/LPAudioUtils$PlaybackCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_playAudio_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_LPAudioUtils_PlaybackCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "playAudio", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/utils/LPAudioUtils$PlaybackCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_playSound_I;
#pragma warning disable 0169
		static Delegate GetPlaySound_IHandler ()
		{
			if (cb_playSound_I == null)
				cb_playSound_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_PlaySound_I);
			return cb_playSound_I;
		}

		static void n_PlaySound_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Infra.Utils.LPAudioUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PlaySound (p0);
		}
#pragma warning restore 0169

		static IntPtr id_playSound_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils']/method[@name='playSound' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("playSound", "(I)V", "GetPlaySound_IHandler")]
		public virtual unsafe void PlaySound (int p0)
		{
			if (id_playSound_I == IntPtr.Zero)
				id_playSound_I = JNIEnv.GetMethodID (class_ref, "playSound", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_playSound_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "playSound", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_saveByteArrayToDisk_arrayB;
#pragma warning disable 0169
		static Delegate GetSaveByteArrayToDisk_arrayBHandler ()
		{
			if (cb_saveByteArrayToDisk_arrayB == null)
				cb_saveByteArrayToDisk_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SaveByteArrayToDisk_arrayB);
			return cb_saveByteArrayToDisk_arrayB;
		}

		static IntPtr n_SaveByteArrayToDisk_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.LPAudioUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewString (__this.SaveByteArrayToDisk (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_saveByteArrayToDisk_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils']/method[@name='saveByteArrayToDisk' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("saveByteArrayToDisk", "([B)Ljava/lang/String;", "GetSaveByteArrayToDisk_arrayBHandler")]
		public virtual unsafe string SaveByteArrayToDisk (byte[] p0)
		{
			if (id_saveByteArrayToDisk_arrayB == IntPtr.Zero)
				id_saveByteArrayToDisk_arrayB = JNIEnv.GetMethodID (class_ref, "saveByteArrayToDisk", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_saveByteArrayToDisk_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveByteArrayToDisk", "([B)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_startRecording_Ljava_lang_String_ILcom_liveperson_infra_utils_LPAudioUtils_MaxRecordingDurationReachedListener_;
#pragma warning disable 0169
		static Delegate GetStartRecording_Ljava_lang_String_ILcom_liveperson_infra_utils_LPAudioUtils_MaxRecordingDurationReachedListener_Handler ()
		{
			if (cb_startRecording_Ljava_lang_String_ILcom_liveperson_infra_utils_LPAudioUtils_MaxRecordingDurationReachedListener_ == null)
				cb_startRecording_Ljava_lang_String_ILcom_liveperson_infra_utils_LPAudioUtils_MaxRecordingDurationReachedListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_StartRecording_Ljava_lang_String_ILcom_liveperson_infra_utils_LPAudioUtils_MaxRecordingDurationReachedListener_);
			return cb_startRecording_Ljava_lang_String_ILcom_liveperson_infra_utils_LPAudioUtils_MaxRecordingDurationReachedListener_;
		}

		static IntPtr n_StartRecording_Ljava_lang_String_ILcom_liveperson_infra_utils_LPAudioUtils_MaxRecordingDurationReachedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Infra.Utils.LPAudioUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Utils.LPAudioUtils.IMaxRecordingDurationReachedListener p2 = (global::Com.Liveperson.Infra.Utils.LPAudioUtils.IMaxRecordingDurationReachedListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils.IMaxRecordingDurationReachedListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StartRecording (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_startRecording_Ljava_lang_String_ILcom_liveperson_infra_utils_LPAudioUtils_MaxRecordingDurationReachedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils']/method[@name='startRecording' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='com.liveperson.infra.utils.LPAudioUtils.MaxRecordingDurationReachedListener']]"
		[Register ("startRecording", "(Ljava/lang/String;ILcom/liveperson/infra/utils/LPAudioUtils$MaxRecordingDurationReachedListener;)Lcom/liveperson/infra/utils/LPAudioUtils$LPRecorderStatus;", "GetStartRecording_Ljava_lang_String_ILcom_liveperson_infra_utils_LPAudioUtils_MaxRecordingDurationReachedListener_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Utils.LPAudioUtils.LPRecorderStatus StartRecording (string p0, int p1, global::Com.Liveperson.Infra.Utils.LPAudioUtils.IMaxRecordingDurationReachedListener p2)
		{
			if (id_startRecording_Ljava_lang_String_ILcom_liveperson_infra_utils_LPAudioUtils_MaxRecordingDurationReachedListener_ == IntPtr.Zero)
				id_startRecording_Ljava_lang_String_ILcom_liveperson_infra_utils_LPAudioUtils_MaxRecordingDurationReachedListener_ = JNIEnv.GetMethodID (class_ref, "startRecording", "(Ljava/lang/String;ILcom/liveperson/infra/utils/LPAudioUtils$MaxRecordingDurationReachedListener;)Lcom/liveperson/infra/utils/LPAudioUtils$LPRecorderStatus;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Com.Liveperson.Infra.Utils.LPAudioUtils.LPRecorderStatus __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils.LPRecorderStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_startRecording_Ljava_lang_String_ILcom_liveperson_infra_utils_LPAudioUtils_MaxRecordingDurationReachedListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils.LPRecorderStatus> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startRecording", "(Ljava/lang/String;ILcom/liveperson/infra/utils/LPAudioUtils$MaxRecordingDurationReachedListener;)Lcom/liveperson/infra/utils/LPAudioUtils$LPRecorderStatus;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_stopPlayback;
#pragma warning disable 0169
		static Delegate GetStopPlaybackHandler ()
		{
			if (cb_stopPlayback == null)
				cb_stopPlayback = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopPlayback);
			return cb_stopPlayback;
		}

		static void n_StopPlayback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.LPAudioUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopPlayback ();
		}
#pragma warning restore 0169

		static IntPtr id_stopPlayback;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils']/method[@name='stopPlayback' and count(parameter)=0]"
		[Register ("stopPlayback", "()V", "GetStopPlaybackHandler")]
		public virtual unsafe void StopPlayback ()
		{
			if (id_stopPlayback == IntPtr.Zero)
				id_stopPlayback = JNIEnv.GetMethodID (class_ref, "stopPlayback", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopPlayback);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopPlayback", "()V"));
			} finally {
			}
		}

		static Delegate cb_stopRecording_Lcom_liveperson_infra_ICallback_;
#pragma warning disable 0169
		static Delegate GetStopRecording_Lcom_liveperson_infra_ICallback_Handler ()
		{
			if (cb_stopRecording_Lcom_liveperson_infra_ICallback_ == null)
				cb_stopRecording_Lcom_liveperson_infra_ICallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StopRecording_Lcom_liveperson_infra_ICallback_);
			return cb_stopRecording_Lcom_liveperson_infra_ICallback_;
		}

		static void n_StopRecording_Lcom_liveperson_infra_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.LPAudioUtils __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.LPAudioUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ICallback p0 = (global::Com.Liveperson.Infra.ICallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StopRecording (p0);
		}
#pragma warning restore 0169

		static IntPtr id_stopRecording_Lcom_liveperson_infra_ICallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='LPAudioUtils']/method[@name='stopRecording' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.ICallback&lt;java.lang.String, java.lang.Exception&gt;']]"
		[Register ("stopRecording", "(Lcom/liveperson/infra/ICallback;)V", "GetStopRecording_Lcom_liveperson_infra_ICallback_Handler")]
		public virtual unsafe void StopRecording (global::Com.Liveperson.Infra.ICallback p0)
		{
			if (id_stopRecording_Lcom_liveperson_infra_ICallback_ == IntPtr.Zero)
				id_stopRecording_Lcom_liveperson_infra_ICallback_ = JNIEnv.GetMethodID (class_ref, "stopRecording", "(Lcom/liveperson/infra/ICallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopRecording_Lcom_liveperson_infra_ICallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopRecording", "(Lcom/liveperson/infra/ICallback;)V"), __args);
			} finally {
			}
		}

	}
}
