using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Fragment {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='FullImageFragment']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/fragment/FullImageFragment", DoNotGenerateAcw=true)]
	public partial class FullImageFragment : global::Com.Liveperson.Infra.UI.View.Screen.BaseFragment {


		static IntPtr KEY_IMAGE_URI_STRING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='FullImageFragment']/field[@name='KEY_IMAGE_URI_STRING']"
		[Register ("KEY_IMAGE_URI_STRING")]
		public static string KeyImageUriString {
			get {
				if (KEY_IMAGE_URI_STRING_jfieldId == IntPtr.Zero)
					KEY_IMAGE_URI_STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "KEY_IMAGE_URI_STRING", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, KEY_IMAGE_URI_STRING_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (KEY_IMAGE_URI_STRING_jfieldId == IntPtr.Zero)
					KEY_IMAGE_URI_STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "KEY_IMAGE_URI_STRING", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, KEY_IMAGE_URI_STRING_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/fragment/FullImageFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FullImageFragment); }
		}

		protected FullImageFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='FullImageFragment']/constructor[@name='FullImageFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FullImageFragment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FullImageFragment)) {
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

		static IntPtr id_newInstance_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='FullImageFragment']/method[@name='newInstance' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("newInstance", "(Ljava/lang/String;)Lcom/liveperson/infra/messaging_ui/fragment/FullImageFragment;", "")]
		public static unsafe global::Com.Liveperson.Infra.Messaging_ui.Fragment.FullImageFragment NewInstance (string p0)
		{
			if (id_newInstance_Ljava_lang_String_ == IntPtr.Zero)
				id_newInstance_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Ljava/lang/String;)Lcom/liveperson/infra/messaging_ui/fragment/FullImageFragment;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Infra.Messaging_ui.Fragment.FullImageFragment __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.FullImageFragment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_toggleFullScreen;
#pragma warning disable 0169
		static Delegate GetToggleFullScreenHandler ()
		{
			if (cb_toggleFullScreen == null)
				cb_toggleFullScreen = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ToggleFullScreen);
			return cb_toggleFullScreen;
		}

		static void n_ToggleFullScreen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.FullImageFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.FullImageFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ToggleFullScreen ();
		}
#pragma warning restore 0169

		static IntPtr id_toggleFullScreen;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='FullImageFragment']/method[@name='toggleFullScreen' and count(parameter)=0]"
		[Register ("toggleFullScreen", "()V", "GetToggleFullScreenHandler")]
		public virtual unsafe void ToggleFullScreen ()
		{
			if (id_toggleFullScreen == IntPtr.Zero)
				id_toggleFullScreen = JNIEnv.GetMethodID (class_ref, "toggleFullScreen", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toggleFullScreen);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toggleFullScreen", "()V"));
			} finally {
			}
		}

	}
}
