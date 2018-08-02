using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Fragment {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='NestedFragmentsContainerCallbacks.NullNestedFragmentsContainerCallbacks']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/fragment/NestedFragmentsContainerCallbacks$NullNestedFragmentsContainerCallbacks", DoNotGenerateAcw=true)]
	public partial class NestedFragmentsContainerCallbacksNullNestedFragmentsContainerCallbacks : global::Java.Lang.Object, global::Com.Liveperson.Infra.Messaging_ui.Fragment.INestedFragmentsContainerCallbacks {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/fragment/NestedFragmentsContainerCallbacks$NullNestedFragmentsContainerCallbacks", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NestedFragmentsContainerCallbacksNullNestedFragmentsContainerCallbacks); }
		}

		protected NestedFragmentsContainerCallbacksNullNestedFragmentsContainerCallbacks (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='NestedFragmentsContainerCallbacks.NullNestedFragmentsContainerCallbacks']/constructor[@name='NestedFragmentsContainerCallbacks.NullNestedFragmentsContainerCallbacks' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NestedFragmentsContainerCallbacksNullNestedFragmentsContainerCallbacks ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (NestedFragmentsContainerCallbacksNullNestedFragmentsContainerCallbacks)) {
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

		static Delegate cb_onSurveySubmitted_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSurveySubmitted_Ljava_lang_String_Handler ()
		{
			if (cb_onSurveySubmitted_Ljava_lang_String_ == null)
				cb_onSurveySubmitted_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSurveySubmitted_Ljava_lang_String_);
			return cb_onSurveySubmitted_Ljava_lang_String_;
		}

		static void n_OnSurveySubmitted_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.NestedFragmentsContainerCallbacksNullNestedFragmentsContainerCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.NestedFragmentsContainerCallbacksNullNestedFragmentsContainerCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurveySubmitted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSurveySubmitted_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='NestedFragmentsContainerCallbacks.NullNestedFragmentsContainerCallbacks']/method[@name='onSurveySubmitted' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onSurveySubmitted", "(Ljava/lang/String;)V", "GetOnSurveySubmitted_Ljava_lang_String_Handler")]
		public virtual unsafe void OnSurveySubmitted (string p0)
		{
			if (id_onSurveySubmitted_Ljava_lang_String_ == IntPtr.Zero)
				id_onSurveySubmitted_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSurveySubmitted", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurveySubmitted_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurveySubmitted", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendCSAT_II;
#pragma warning disable 0169
		static Delegate GetSendCSAT_IIHandler ()
		{
			if (cb_sendCSAT_II == null)
				cb_sendCSAT_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SendCSAT_II);
			return cb_sendCSAT_II;
		}

		static void n_SendCSAT_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.NestedFragmentsContainerCallbacksNullNestedFragmentsContainerCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.NestedFragmentsContainerCallbacksNullNestedFragmentsContainerCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendCSAT (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendCSAT_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='NestedFragmentsContainerCallbacks.NullNestedFragmentsContainerCallbacks']/method[@name='sendCSAT' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("sendCSAT", "(II)V", "GetSendCSAT_IIHandler")]
		public virtual unsafe void SendCSAT (int p0, int p1)
		{
			if (id_sendCSAT_II == IntPtr.Zero)
				id_sendCSAT_II = JNIEnv.GetMethodID (class_ref, "sendCSAT", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendCSAT_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendCSAT", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSecureFormMode_ZLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSecureFormMode_ZLjava_lang_String_Handler ()
		{
			if (cb_setSecureFormMode_ZLjava_lang_String_ == null)
				cb_setSecureFormMode_ZLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_SetSecureFormMode_ZLjava_lang_String_);
			return cb_setSecureFormMode_ZLjava_lang_String_;
		}

		static void n_SetSecureFormMode_ZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.NestedFragmentsContainerCallbacksNullNestedFragmentsContainerCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.NestedFragmentsContainerCallbacksNullNestedFragmentsContainerCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetSecureFormMode (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setSecureFormMode_ZLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='NestedFragmentsContainerCallbacks.NullNestedFragmentsContainerCallbacks']/method[@name='setSecureFormMode' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
		[Register ("setSecureFormMode", "(ZLjava/lang/String;)V", "GetSetSecureFormMode_ZLjava_lang_String_Handler")]
		public virtual unsafe void SetSecureFormMode (bool p0, string p1)
		{
			if (id_setSecureFormMode_ZLjava_lang_String_ == IntPtr.Zero)
				id_setSecureFormMode_ZLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSecureFormMode", "(ZLjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSecureFormMode_ZLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSecureFormMode", "(ZLjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_slideOutFragment;
#pragma warning disable 0169
		static Delegate GetSlideOutFragmentHandler ()
		{
			if (cb_slideOutFragment == null)
				cb_slideOutFragment = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SlideOutFragment);
			return cb_slideOutFragment;
		}

		static void n_SlideOutFragment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.NestedFragmentsContainerCallbacksNullNestedFragmentsContainerCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.NestedFragmentsContainerCallbacksNullNestedFragmentsContainerCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SlideOutFragment ();
		}
#pragma warning restore 0169

		static IntPtr id_slideOutFragment;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='NestedFragmentsContainerCallbacks.NullNestedFragmentsContainerCallbacks']/method[@name='slideOutFragment' and count(parameter)=0]"
		[Register ("slideOutFragment", "()V", "GetSlideOutFragmentHandler")]
		public virtual unsafe void SlideOutFragment ()
		{
			if (id_slideOutFragment == IntPtr.Zero)
				id_slideOutFragment = JNIEnv.GetMethodID (class_ref, "slideOutFragment", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_slideOutFragment);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "slideOutFragment", "()V"));
			} finally {
			}
		}

		static Delegate cb_slideOutSecureFormFragment;
#pragma warning disable 0169
		static Delegate GetSlideOutSecureFormFragmentHandler ()
		{
			if (cb_slideOutSecureFormFragment == null)
				cb_slideOutSecureFormFragment = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SlideOutSecureFormFragment);
			return cb_slideOutSecureFormFragment;
		}

		static void n_SlideOutSecureFormFragment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.NestedFragmentsContainerCallbacksNullNestedFragmentsContainerCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.NestedFragmentsContainerCallbacksNullNestedFragmentsContainerCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SlideOutSecureFormFragment ();
		}
#pragma warning restore 0169

		static IntPtr id_slideOutSecureFormFragment;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='NestedFragmentsContainerCallbacks.NullNestedFragmentsContainerCallbacks']/method[@name='slideOutSecureFormFragment' and count(parameter)=0]"
		[Register ("slideOutSecureFormFragment", "()V", "GetSlideOutSecureFormFragmentHandler")]
		public virtual unsafe void SlideOutSecureFormFragment ()
		{
			if (id_slideOutSecureFormFragment == IntPtr.Zero)
				id_slideOutSecureFormFragment = JNIEnv.GetMethodID (class_ref, "slideOutSecureFormFragment", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_slideOutSecureFormFragment);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "slideOutSecureFormFragment", "()V"));
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/interface[@name='NestedFragmentsContainerCallbacks']"
	[Register ("com/liveperson/infra/messaging_ui/fragment/NestedFragmentsContainerCallbacks", "", "Com.Liveperson.Infra.Messaging_ui.Fragment.INestedFragmentsContainerCallbacksInvoker")]
	public partial interface INestedFragmentsContainerCallbacks : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/interface[@name='NestedFragmentsContainerCallbacks']/method[@name='onSurveySubmitted' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onSurveySubmitted", "(Ljava/lang/String;)V", "GetOnSurveySubmitted_Ljava_lang_String_Handler:Com.Liveperson.Infra.Messaging_ui.Fragment.INestedFragmentsContainerCallbacksInvoker, LP_Android_aar_Binding")]
		void OnSurveySubmitted (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/interface[@name='NestedFragmentsContainerCallbacks']/method[@name='sendCSAT' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("sendCSAT", "(II)V", "GetSendCSAT_IIHandler:Com.Liveperson.Infra.Messaging_ui.Fragment.INestedFragmentsContainerCallbacksInvoker, LP_Android_aar_Binding")]
		void SendCSAT (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/interface[@name='NestedFragmentsContainerCallbacks']/method[@name='setSecureFormMode' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
		[Register ("setSecureFormMode", "(ZLjava/lang/String;)V", "GetSetSecureFormMode_ZLjava_lang_String_Handler:Com.Liveperson.Infra.Messaging_ui.Fragment.INestedFragmentsContainerCallbacksInvoker, LP_Android_aar_Binding")]
		void SetSecureFormMode (bool p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/interface[@name='NestedFragmentsContainerCallbacks']/method[@name='slideOutFragment' and count(parameter)=0]"
		[Register ("slideOutFragment", "()V", "GetSlideOutFragmentHandler:Com.Liveperson.Infra.Messaging_ui.Fragment.INestedFragmentsContainerCallbacksInvoker, LP_Android_aar_Binding")]
		void SlideOutFragment ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/interface[@name='NestedFragmentsContainerCallbacks']/method[@name='slideOutSecureFormFragment' and count(parameter)=0]"
		[Register ("slideOutSecureFormFragment", "()V", "GetSlideOutSecureFormFragmentHandler:Com.Liveperson.Infra.Messaging_ui.Fragment.INestedFragmentsContainerCallbacksInvoker, LP_Android_aar_Binding")]
		void SlideOutSecureFormFragment ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/fragment/NestedFragmentsContainerCallbacks", DoNotGenerateAcw=true)]
	internal class INestedFragmentsContainerCallbacksInvoker : global::Java.Lang.Object, INestedFragmentsContainerCallbacks {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/fragment/NestedFragmentsContainerCallbacks");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (INestedFragmentsContainerCallbacksInvoker); }
		}

		IntPtr class_ref;

		public static INestedFragmentsContainerCallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INestedFragmentsContainerCallbacks> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.messaging_ui.fragment.NestedFragmentsContainerCallbacks"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INestedFragmentsContainerCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onSurveySubmitted_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSurveySubmitted_Ljava_lang_String_Handler ()
		{
			if (cb_onSurveySubmitted_Ljava_lang_String_ == null)
				cb_onSurveySubmitted_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSurveySubmitted_Ljava_lang_String_);
			return cb_onSurveySubmitted_Ljava_lang_String_;
		}

		static void n_OnSurveySubmitted_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.INestedFragmentsContainerCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.INestedFragmentsContainerCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurveySubmitted (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSurveySubmitted_Ljava_lang_String_;
		public unsafe void OnSurveySubmitted (string p0)
		{
			if (id_onSurveySubmitted_Ljava_lang_String_ == IntPtr.Zero)
				id_onSurveySubmitted_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSurveySubmitted", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurveySubmitted_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_sendCSAT_II;
#pragma warning disable 0169
		static Delegate GetSendCSAT_IIHandler ()
		{
			if (cb_sendCSAT_II == null)
				cb_sendCSAT_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SendCSAT_II);
			return cb_sendCSAT_II;
		}

		static void n_SendCSAT_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.INestedFragmentsContainerCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.INestedFragmentsContainerCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendCSAT (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_sendCSAT_II;
		public unsafe void SendCSAT (int p0, int p1)
		{
			if (id_sendCSAT_II == IntPtr.Zero)
				id_sendCSAT_II = JNIEnv.GetMethodID (class_ref, "sendCSAT", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendCSAT_II, __args);
		}

		static Delegate cb_setSecureFormMode_ZLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSecureFormMode_ZLjava_lang_String_Handler ()
		{
			if (cb_setSecureFormMode_ZLjava_lang_String_ == null)
				cb_setSecureFormMode_ZLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_SetSecureFormMode_ZLjava_lang_String_);
			return cb_setSecureFormMode_ZLjava_lang_String_;
		}

		static void n_SetSecureFormMode_ZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.INestedFragmentsContainerCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.INestedFragmentsContainerCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetSecureFormMode (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setSecureFormMode_ZLjava_lang_String_;
		public unsafe void SetSecureFormMode (bool p0, string p1)
		{
			if (id_setSecureFormMode_ZLjava_lang_String_ == IntPtr.Zero)
				id_setSecureFormMode_ZLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSecureFormMode", "(ZLjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSecureFormMode_ZLjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_slideOutFragment;
#pragma warning disable 0169
		static Delegate GetSlideOutFragmentHandler ()
		{
			if (cb_slideOutFragment == null)
				cb_slideOutFragment = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SlideOutFragment);
			return cb_slideOutFragment;
		}

		static void n_SlideOutFragment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.INestedFragmentsContainerCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.INestedFragmentsContainerCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SlideOutFragment ();
		}
#pragma warning restore 0169

		IntPtr id_slideOutFragment;
		public unsafe void SlideOutFragment ()
		{
			if (id_slideOutFragment == IntPtr.Zero)
				id_slideOutFragment = JNIEnv.GetMethodID (class_ref, "slideOutFragment", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_slideOutFragment);
		}

		static Delegate cb_slideOutSecureFormFragment;
#pragma warning disable 0169
		static Delegate GetSlideOutSecureFormFragmentHandler ()
		{
			if (cb_slideOutSecureFormFragment == null)
				cb_slideOutSecureFormFragment = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SlideOutSecureFormFragment);
			return cb_slideOutSecureFormFragment;
		}

		static void n_SlideOutSecureFormFragment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.INestedFragmentsContainerCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.INestedFragmentsContainerCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SlideOutSecureFormFragment ();
		}
#pragma warning restore 0169

		IntPtr id_slideOutSecureFormFragment;
		public unsafe void SlideOutSecureFormFragment ()
		{
			if (id_slideOutSecureFormFragment == IntPtr.Zero)
				id_slideOutSecureFormFragment = JNIEnv.GetMethodID (class_ref, "slideOutSecureFormFragment", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_slideOutSecureFormFragment);
		}

	}

}
