using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Fragment {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='SecuredFormFragment']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/fragment/SecuredFormFragment", DoNotGenerateAcw=true)]
	public partial class SecuredFormFragment : global::Android.Support.V4.App.Fragment {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='SecuredFormFragment']/field[@name='ABORTED']"
		[Register ("ABORTED")]
		public const string Aborted = (string) "aborted";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='SecuredFormFragment']/field[@name='ERROR']"
		[Register ("ERROR")]
		public const string Error = (string) "error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='SecuredFormFragment']/field[@name='ERROR_REASON']"
		[Register ("ERROR_REASON")]
		public const string ErrorReason = (string) "errorReason";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='SecuredFormFragment']/field[@name='FORM_TITLE']"
		[Register ("FORM_TITLE")]
		public const string FormTitle = (string) "form_title";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='SecuredFormFragment']/field[@name='GATEWAY_DOMAIN']"
		[Register ("GATEWAY_DOMAIN")]
		public const string GatewayDomain = (string) "gatewayDomain";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='SecuredFormFragment']/field[@name='INVITATION_ID']"
		[Register ("INVITATION_ID")]
		public const string InvitationId = (string) "invitation_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='SecuredFormFragment']/field[@name='JS_INTERFACE_OBJ_NAME']"
		[Register ("JS_INTERFACE_OBJ_NAME")]
		public const string JsInterfaceObjName = (string) "android";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='SecuredFormFragment']/field[@name='NOT_DEFINED_YET']"
		[Register ("NOT_DEFINED_YET")]
		public const int NotDefinedYet = (int) -9999;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='SecuredFormFragment']/field[@name='STATE']"
		[Register ("STATE")]
		public const string State = (string) "state";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='SecuredFormFragment']/field[@name='SUBMIT']"
		[Register ("SUBMIT")]
		public const string Submit = (string) "submit";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='SecuredFormFragment']/field[@name='TOKEN']"
		[Register ("TOKEN")]
		public const string Token = (string) "token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='SecuredFormFragment']/field[@name='URL']"
		[Register ("URL")]
		public const string Url = (string) "url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='SecuredFormFragment']/field[@name='VIEWED']"
		[Register ("VIEWED")]
		public const string Viewed = (string) "viewed";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='SecuredFormFragment.WebAppInterface']"
		[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/fragment/SecuredFormFragment$WebAppInterface", DoNotGenerateAcw=true)]
		public partial class WebAppInterface : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/fragment/SecuredFormFragment$WebAppInterface", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (WebAppInterface); }
			}

			protected WebAppInterface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_infra_messaging_ui_fragment_SecuredFormFragment_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='SecuredFormFragment.WebAppInterface']/constructor[@name='SecuredFormFragment.WebAppInterface' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.messaging_ui.fragment.SecuredFormFragment']]"
			[Register (".ctor", "(Lcom/liveperson/infra/messaging_ui/fragment/SecuredFormFragment;)V", "")]
			public unsafe WebAppInterface (global::Com.Liveperson.Infra.Messaging_ui.Fragment.SecuredFormFragment __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (WebAppInterface)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_infra_messaging_ui_fragment_SecuredFormFragment_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_infra_messaging_ui_fragment_SecuredFormFragment_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/messaging_ui/fragment/SecuredFormFragment;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_messaging_ui_fragment_SecuredFormFragment_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_messaging_ui_fragment_SecuredFormFragment_, __args);
				} finally {
				}
			}

			static Delegate cb_onPCIMessage_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnPCIMessage_Ljava_lang_String_Handler ()
			{
				if (cb_onPCIMessage_Ljava_lang_String_ == null)
					cb_onPCIMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPCIMessage_Ljava_lang_String_);
				return cb_onPCIMessage_Ljava_lang_String_;
			}

			static void n_OnPCIMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_state)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Fragment.SecuredFormFragment.WebAppInterface __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.SecuredFormFragment.WebAppInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string state = JNIEnv.GetString (native_state, JniHandleOwnership.DoNotTransfer);
				__this.OnPCIMessage (state);
			}
#pragma warning restore 0169

			static IntPtr id_onPCIMessage_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='SecuredFormFragment.WebAppInterface']/method[@name='onPCIMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onPCIMessage", "(Ljava/lang/String;)V", "GetOnPCIMessage_Ljava_lang_String_Handler")]
			public virtual unsafe void OnPCIMessage (string state)
			{
				if (id_onPCIMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_onPCIMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onPCIMessage", "(Ljava/lang/String;)V");
				IntPtr native_state = JNIEnv.NewString (state);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_state);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPCIMessage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPCIMessage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_state);
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/fragment/SecuredFormFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SecuredFormFragment); }
		}

		protected SecuredFormFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='SecuredFormFragment']/constructor[@name='SecuredFormFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SecuredFormFragment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SecuredFormFragment)) {
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

		static Delegate cb_slideOutFragment;
#pragma warning disable 0169
		static Delegate GetSlideOutFragmentHandler ()
		{
			if (cb_slideOutFragment == null)
				cb_slideOutFragment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_SlideOutFragment);
			return cb_slideOutFragment;
		}

		static bool n_SlideOutFragment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.SecuredFormFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.SecuredFormFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SlideOutFragment ();
		}
#pragma warning restore 0169

		static IntPtr id_slideOutFragment;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='SecuredFormFragment']/method[@name='slideOutFragment' and count(parameter)=0]"
		[Register ("slideOutFragment", "()Z", "GetSlideOutFragmentHandler")]
		public virtual unsafe bool SlideOutFragment ()
		{
			if (id_slideOutFragment == IntPtr.Zero)
				id_slideOutFragment = JNIEnv.GetMethodID (class_ref, "slideOutFragment", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_slideOutFragment);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "slideOutFragment", "()Z"));
			} finally {
			}
		}

		static Delegate cb_slideOutSecureFormFragment;
#pragma warning disable 0169
		static Delegate GetSlideOutSecureFormFragmentHandler ()
		{
			if (cb_slideOutSecureFormFragment == null)
				cb_slideOutSecureFormFragment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_SlideOutSecureFormFragment);
			return cb_slideOutSecureFormFragment;
		}

		static bool n_SlideOutSecureFormFragment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.SecuredFormFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.SecuredFormFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SlideOutSecureFormFragment ();
		}
#pragma warning restore 0169

		static IntPtr id_slideOutSecureFormFragment;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='SecuredFormFragment']/method[@name='slideOutSecureFormFragment' and count(parameter)=0]"
		[Register ("slideOutSecureFormFragment", "()Z", "GetSlideOutSecureFormFragmentHandler")]
		public virtual unsafe bool SlideOutSecureFormFragment ()
		{
			if (id_slideOutSecureFormFragment == IntPtr.Zero)
				id_slideOutSecureFormFragment = JNIEnv.GetMethodID (class_ref, "slideOutSecureFormFragment", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_slideOutSecureFormFragment);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "slideOutSecureFormFragment", "()Z"));
			} finally {
			}
		}

	}
}
