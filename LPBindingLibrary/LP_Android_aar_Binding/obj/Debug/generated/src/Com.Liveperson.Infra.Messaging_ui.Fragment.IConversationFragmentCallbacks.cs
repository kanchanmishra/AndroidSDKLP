using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Fragment {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragmentCallbacks.NullConversationFragmentCallbacks']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/fragment/ConversationFragmentCallbacks$NullConversationFragmentCallbacks", DoNotGenerateAcw=true)]
	public partial class ConversationFragmentCallbacksNullConversationFragmentCallbacks : global::Java.Lang.Object, global::Com.Liveperson.Infra.Messaging_ui.Fragment.IConversationFragmentCallbacks {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/fragment/ConversationFragmentCallbacks$NullConversationFragmentCallbacks", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConversationFragmentCallbacksNullConversationFragmentCallbacks); }
		}

		protected ConversationFragmentCallbacksNullConversationFragmentCallbacks (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragmentCallbacks.NullConversationFragmentCallbacks']/constructor[@name='ConversationFragmentCallbacks.NullConversationFragmentCallbacks' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConversationFragmentCallbacksNullConversationFragmentCallbacks ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ConversationFragmentCallbacksNullConversationFragmentCallbacks)) {
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

		static Delegate cb_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_;
#pragma warning disable 0169
		static Delegate GetOnSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_Handler ()
		{
			if (cb_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ == null)
				cb_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_);
			return cb_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_;
		}

		static void n_OnSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragmentCallbacksNullConversationFragmentCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragmentCallbacksNullConversationFragmentCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions p0 = (global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurveySubmitted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragmentCallbacks.NullConversationFragmentCallbacks']/method[@name='onSurveySubmitted' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.messaging_ui.fragment.IFeedbackActions']]"
		[Register ("onSurveySubmitted", "(Lcom/liveperson/infra/messaging_ui/fragment/IFeedbackActions;)V", "GetOnSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_Handler")]
		public virtual unsafe void OnSurveySubmitted (global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions p0)
		{
			if (id_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ == IntPtr.Zero)
				id_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ = JNIEnv.GetMethodID (class_ref, "onSurveySubmitted", "(Lcom/liveperson/infra/messaging_ui/fragment/IFeedbackActions;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurveySubmitted", "(Lcom/liveperson/infra/messaging_ui/fragment/IFeedbackActions;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_;
#pragma warning disable 0169
		static Delegate GetSetFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_Handler ()
		{
			if (cb_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ == null)
				cb_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_SetFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_);
			return cb_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_;
		}

		static void n_SetFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragmentCallbacksNullConversationFragmentCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragmentCallbacksNullConversationFragmentCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions p1 = (global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetFeedBackMode (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragmentCallbacks.NullConversationFragmentCallbacks']/method[@name='setFeedBackMode' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.liveperson.infra.messaging_ui.fragment.IFeedbackActions']]"
		[Register ("setFeedBackMode", "(ZLcom/liveperson/infra/messaging_ui/fragment/IFeedbackActions;)V", "GetSetFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_Handler")]
		public virtual unsafe void SetFeedBackMode (bool p0, global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions p1)
		{
			if (id_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ == IntPtr.Zero)
				id_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ = JNIEnv.GetMethodID (class_ref, "setFeedBackMode", "(ZLcom/liveperson/infra/messaging_ui/fragment/IFeedbackActions;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFeedBackMode", "(ZLcom/liveperson/infra/messaging_ui/fragment/IFeedbackActions;)V"), __args);
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
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragmentCallbacksNullConversationFragmentCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragmentCallbacksNullConversationFragmentCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetSecureFormMode (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setSecureFormMode_ZLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragmentCallbacks.NullConversationFragmentCallbacks']/method[@name='setSecureFormMode' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
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

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/interface[@name='ConversationFragmentCallbacks']"
	[Register ("com/liveperson/infra/messaging_ui/fragment/ConversationFragmentCallbacks", "", "Com.Liveperson.Infra.Messaging_ui.Fragment.IConversationFragmentCallbacksInvoker")]
	public partial interface IConversationFragmentCallbacks : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/interface[@name='ConversationFragmentCallbacks']/method[@name='onSurveySubmitted' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.messaging_ui.fragment.IFeedbackActions']]"
		[Register ("onSurveySubmitted", "(Lcom/liveperson/infra/messaging_ui/fragment/IFeedbackActions;)V", "GetOnSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_Handler:Com.Liveperson.Infra.Messaging_ui.Fragment.IConversationFragmentCallbacksInvoker, LP_Android_aar_Binding")]
		void OnSurveySubmitted (global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/interface[@name='ConversationFragmentCallbacks']/method[@name='setFeedBackMode' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.liveperson.infra.messaging_ui.fragment.IFeedbackActions']]"
		[Register ("setFeedBackMode", "(ZLcom/liveperson/infra/messaging_ui/fragment/IFeedbackActions;)V", "GetSetFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_Handler:Com.Liveperson.Infra.Messaging_ui.Fragment.IConversationFragmentCallbacksInvoker, LP_Android_aar_Binding")]
		void SetFeedBackMode (bool p0, global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/interface[@name='ConversationFragmentCallbacks']/method[@name='setSecureFormMode' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
		[Register ("setSecureFormMode", "(ZLjava/lang/String;)V", "GetSetSecureFormMode_ZLjava_lang_String_Handler:Com.Liveperson.Infra.Messaging_ui.Fragment.IConversationFragmentCallbacksInvoker, LP_Android_aar_Binding")]
		void SetSecureFormMode (bool p0, string p1);

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/fragment/ConversationFragmentCallbacks", DoNotGenerateAcw=true)]
	internal class IConversationFragmentCallbacksInvoker : global::Java.Lang.Object, IConversationFragmentCallbacks {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/fragment/ConversationFragmentCallbacks");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IConversationFragmentCallbacksInvoker); }
		}

		IntPtr class_ref;

		public static IConversationFragmentCallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConversationFragmentCallbacks> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.messaging_ui.fragment.ConversationFragmentCallbacks"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConversationFragmentCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_;
#pragma warning disable 0169
		static Delegate GetOnSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_Handler ()
		{
			if (cb_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ == null)
				cb_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_);
			return cb_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_;
		}

		static void n_OnSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.IConversationFragmentCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.IConversationFragmentCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions p0 = (global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurveySubmitted (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_;
		public unsafe void OnSurveySubmitted (global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions p0)
		{
			if (id_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ == IntPtr.Zero)
				id_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ = JNIEnv.GetMethodID (class_ref, "onSurveySubmitted", "(Lcom/liveperson/infra/messaging_ui/fragment/IFeedbackActions;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurveySubmitted_Lcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_, __args);
		}

		static Delegate cb_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_;
#pragma warning disable 0169
		static Delegate GetSetFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_Handler ()
		{
			if (cb_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ == null)
				cb_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_SetFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_);
			return cb_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_;
		}

		static void n_SetFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.IConversationFragmentCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.IConversationFragmentCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions p1 = (global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetFeedBackMode (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_;
		public unsafe void SetFeedBackMode (bool p0, global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions p1)
		{
			if (id_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ == IntPtr.Zero)
				id_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_ = JNIEnv.GetMethodID (class_ref, "setFeedBackMode", "(ZLcom/liveperson/infra/messaging_ui/fragment/IFeedbackActions;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFeedBackMode_ZLcom_liveperson_infra_messaging_ui_fragment_IFeedbackActions_, __args);
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
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.IConversationFragmentCallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.IConversationFragmentCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	}

}
