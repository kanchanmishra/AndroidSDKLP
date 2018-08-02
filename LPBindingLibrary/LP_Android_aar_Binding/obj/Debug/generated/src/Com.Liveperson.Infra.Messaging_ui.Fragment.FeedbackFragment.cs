using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Fragment {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='FeedbackFragment']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/fragment/FeedbackFragment", DoNotGenerateAcw=true)]
	public partial class FeedbackFragment : global::Android.Support.V4.App.Fragment, global::Com.Liveperson.Infra.Messaging_ui.Fragment.IFeedbackActions, global::Com.Liveperson.Infra.UI.View.Uicomponents.IConnectionChangedCustomView {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='FeedbackFragment']/field[@name='CSAT_FLOW_DEBUG']"
		[Register ("CSAT_FLOW_DEBUG")]
		public const bool CsatFlowDebug = (bool) true;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='FeedbackFragment.ScreenState']"
		[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/fragment/FeedbackFragment$ScreenState", DoNotGenerateAcw=true)]
		public sealed partial class ScreenState : global::Java.Lang.Enum {


			static IntPtr CSAT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='FeedbackFragment.ScreenState']/field[@name='CSAT']"
			[Register ("CSAT")]
			public static global::Com.Liveperson.Infra.Messaging_ui.Fragment.FeedbackFragment.ScreenState Csat {
				get {
					if (CSAT_jfieldId == IntPtr.Zero)
						CSAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CSAT", "Lcom/liveperson/infra/messaging_ui/fragment/FeedbackFragment$ScreenState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CSAT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.FeedbackFragment.ScreenState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr THANK_YOU_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='FeedbackFragment.ScreenState']/field[@name='THANK_YOU']"
			[Register ("THANK_YOU")]
			public static global::Com.Liveperson.Infra.Messaging_ui.Fragment.FeedbackFragment.ScreenState ThankYou {
				get {
					if (THANK_YOU_jfieldId == IntPtr.Zero)
						THANK_YOU_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THANK_YOU", "Lcom/liveperson/infra/messaging_ui/fragment/FeedbackFragment$ScreenState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THANK_YOU_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.FeedbackFragment.ScreenState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/fragment/FeedbackFragment$ScreenState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ScreenState); }
			}

			internal ScreenState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='FeedbackFragment.StarHandler']"
		[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/fragment/FeedbackFragment$StarHandler", DoNotGenerateAcw=true)]
		public partial class StarHandler : global::Android.OS.Handler {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/fragment/FeedbackFragment$StarHandler", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (StarHandler); }
			}

			protected StarHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_infra_messaging_ui_fragment_FeedbackFragment_Lcom_liveperson_infra_messaging_ui_fragment_FeedbackFragment_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='FeedbackFragment.StarHandler']/constructor[@name='FeedbackFragment.StarHandler' and count(parameter)=2 and parameter[1][@type='com.liveperson.infra.messaging_ui.fragment.FeedbackFragment'] and parameter[2][@type='com.liveperson.infra.messaging_ui.fragment.FeedbackFragment']]"
			[Register (".ctor", "(Lcom/liveperson/infra/messaging_ui/fragment/FeedbackFragment;Lcom/liveperson/infra/messaging_ui/fragment/FeedbackFragment;)V", "")]
			public unsafe StarHandler (global::Com.Liveperson.Infra.Messaging_ui.Fragment.FeedbackFragment __self, global::Com.Liveperson.Infra.Messaging_ui.Fragment.FeedbackFragment p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (((object) this).GetType () != typeof (StarHandler)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/liveperson/infra/messaging_ui/fragment/FeedbackFragment;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/liveperson/infra/messaging_ui/fragment/FeedbackFragment;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_infra_messaging_ui_fragment_FeedbackFragment_Lcom_liveperson_infra_messaging_ui_fragment_FeedbackFragment_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_infra_messaging_ui_fragment_FeedbackFragment_Lcom_liveperson_infra_messaging_ui_fragment_FeedbackFragment_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/messaging_ui/fragment/FeedbackFragment;Lcom/liveperson/infra/messaging_ui/fragment/FeedbackFragment;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_messaging_ui_fragment_FeedbackFragment_Lcom_liveperson_infra_messaging_ui_fragment_FeedbackFragment_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_messaging_ui_fragment_FeedbackFragment_Lcom_liveperson_infra_messaging_ui_fragment_FeedbackFragment_, __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/fragment/FeedbackFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FeedbackFragment); }
		}

		protected FeedbackFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='FeedbackFragment']/constructor[@name='FeedbackFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FeedbackFragment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FeedbackFragment)) {
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

		static Delegate cb_closeFeedBackScreen;
#pragma warning disable 0169
		static Delegate GetCloseFeedBackScreenHandler ()
		{
			if (cb_closeFeedBackScreen == null)
				cb_closeFeedBackScreen = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CloseFeedBackScreen);
			return cb_closeFeedBackScreen;
		}

		static void n_CloseFeedBackScreen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.FeedbackFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.FeedbackFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseFeedBackScreen ();
		}
#pragma warning restore 0169

		static IntPtr id_closeFeedBackScreen;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='FeedbackFragment']/method[@name='closeFeedBackScreen' and count(parameter)=0]"
		[Register ("closeFeedBackScreen", "()V", "GetCloseFeedBackScreenHandler")]
		public virtual unsafe void CloseFeedBackScreen ()
		{
			if (id_closeFeedBackScreen == IntPtr.Zero)
				id_closeFeedBackScreen = JNIEnv.GetMethodID (class_ref, "closeFeedBackScreen", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeFeedBackScreen);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "closeFeedBackScreen", "()V"));
			} finally {
			}
		}

		static IntPtr id_newInstance_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_HashMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='FeedbackFragment']/method[@name='newInstance' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.HashMap&lt;java.lang.String, java.lang.Boolean&gt;']]"
		[Register ("newInstance", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/HashMap;)Lcom/liveperson/infra/messaging_ui/fragment/FeedbackFragment;", "")]
		public static unsafe global::Com.Liveperson.Infra.Messaging_ui.Fragment.FeedbackFragment NewInstance (string p0, string p1, string p2, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Boolean> p3)
		{
			if (id_newInstance_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_HashMap_ == IntPtr.Zero)
				id_newInstance_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_HashMap_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/HashMap;)Lcom/liveperson/infra/messaging_ui/fragment/FeedbackFragment;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				global::Com.Liveperson.Infra.Messaging_ui.Fragment.FeedbackFragment __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.FeedbackFragment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_HashMap_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_onAttachFragment;
#pragma warning disable 0169
		static Delegate GetOnAttachFragmentHandler ()
		{
			if (cb_onAttachFragment == null)
				cb_onAttachFragment = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAttachFragment);
			return cb_onAttachFragment;
		}

		static void n_OnAttachFragment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.FeedbackFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.FeedbackFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAttachFragment ();
		}
#pragma warning restore 0169

		static IntPtr id_onAttachFragment;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='FeedbackFragment']/method[@name='onAttachFragment' and count(parameter)=0]"
		[Register ("onAttachFragment", "()V", "GetOnAttachFragmentHandler")]
		public virtual unsafe void OnAttachFragment ()
		{
			if (id_onAttachFragment == IntPtr.Zero)
				id_onAttachFragment = JNIEnv.GetMethodID (class_ref, "onAttachFragment", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAttachFragment);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAttachFragment", "()V"));
			} finally {
			}
		}

		static Delegate cb_onConnectionChanged_Z;
#pragma warning disable 0169
		static Delegate GetOnConnectionChanged_ZHandler ()
		{
			if (cb_onConnectionChanged_Z == null)
				cb_onConnectionChanged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnConnectionChanged_Z);
			return cb_onConnectionChanged_Z;
		}

		static void n_OnConnectionChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.FeedbackFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.FeedbackFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConnectionChanged_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='FeedbackFragment']/method[@name='onConnectionChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onConnectionChanged", "(Z)V", "GetOnConnectionChanged_ZHandler")]
		public virtual unsafe void OnConnectionChanged (bool p0)
		{
			if (id_onConnectionChanged_Z == IntPtr.Zero)
				id_onConnectionChanged_Z = JNIEnv.GetMethodID (class_ref, "onConnectionChanged", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionChanged_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnectionChanged", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_skipFeedBackScreen;
#pragma warning disable 0169
		static Delegate GetSkipFeedBackScreenHandler ()
		{
			if (cb_skipFeedBackScreen == null)
				cb_skipFeedBackScreen = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SkipFeedBackScreen);
			return cb_skipFeedBackScreen;
		}

		static void n_SkipFeedBackScreen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.FeedbackFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.FeedbackFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SkipFeedBackScreen ();
		}
#pragma warning restore 0169

		static IntPtr id_skipFeedBackScreen;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='FeedbackFragment']/method[@name='skipFeedBackScreen' and count(parameter)=0]"
		[Register ("skipFeedBackScreen", "()V", "GetSkipFeedBackScreenHandler")]
		public virtual unsafe void SkipFeedBackScreen ()
		{
			if (id_skipFeedBackScreen == IntPtr.Zero)
				id_skipFeedBackScreen = JNIEnv.GetMethodID (class_ref, "skipFeedBackScreen", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_skipFeedBackScreen);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "skipFeedBackScreen", "()V"));
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
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.FeedbackFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.FeedbackFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SlideOutFragment ();
		}
#pragma warning restore 0169

		static IntPtr id_slideOutFragment;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='FeedbackFragment']/method[@name='slideOutFragment' and count(parameter)=0]"
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

	}
}
