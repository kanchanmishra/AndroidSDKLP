using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Fragment {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConnectionStatusController']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/fragment/ConnectionStatusController", DoNotGenerateAcw=true)]
	public partial class ConnectionStatusController : global::Com.Liveperson.Infra.UI.View.UI.CustomTextView {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConnectionStatusController']/field[@name='CONNECTING_DELAY']"
		[Register ("CONNECTING_DELAY")]
		public const int ConnectingDelay = (int) 2000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConnectionStatusController']/field[@name='TRYING_TO_CONNECT_DELAY']"
		[Register ("TRYING_TO_CONNECT_DELAY")]
		public const int TryingToConnectDelay = (int) 8000;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/fragment/ConnectionStatusController", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectionStatusController); }
		}

		protected ConnectionStatusController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConnectionStatusController']/constructor[@name='ConnectionStatusController' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe ConnectionStatusController (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (ConnectionStatusController)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConnectionStatusController']/constructor[@name='ConnectionStatusController' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe ConnectionStatusController (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ConnectionStatusController)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConnectionStatusController']/constructor[@name='ConnectionStatusController' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ConnectionStatusController (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ConnectionStatusController)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_initState_ZZ;
#pragma warning disable 0169
		static Delegate GetInitState_ZZHandler ()
		{
			if (cb_initState_ZZ == null)
				cb_initState_ZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, bool>) n_InitState_ZZ);
			return cb_initState_ZZ;
		}

		static void n_InitState_ZZ (IntPtr jnienv, IntPtr native__this, bool p0, bool p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConnectionStatusController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConnectionStatusController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitState (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_initState_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConnectionStatusController']/method[@name='initState' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("initState", "(ZZ)V", "GetInitState_ZZHandler")]
		public virtual unsafe void InitState (bool p0, bool p1)
		{
			if (id_initState_ZZ == IntPtr.Zero)
				id_initState_ZZ = JNIEnv.GetMethodID (class_ref, "initState", "(ZZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initState_ZZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initState", "(ZZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onConnected;
#pragma warning disable 0169
		static Delegate GetOnConnectedHandler ()
		{
			if (cb_onConnected == null)
				cb_onConnected = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnConnected);
			return cb_onConnected;
		}

		static void n_OnConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConnectionStatusController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConnectionStatusController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnected ();
		}
#pragma warning restore 0169

		static IntPtr id_onConnected;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConnectionStatusController']/method[@name='onConnected' and count(parameter)=0]"
		[Register ("onConnected", "()V", "GetOnConnectedHandler")]
		public virtual unsafe void OnConnected ()
		{
			if (id_onConnected == IntPtr.Zero)
				id_onConnected = JNIEnv.GetMethodID (class_ref, "onConnected", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnected);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnected", "()V"));
			} finally {
			}
		}

		static Delegate cb_onConnecting_Z;
#pragma warning disable 0169
		static Delegate GetOnConnecting_ZHandler ()
		{
			if (cb_onConnecting_Z == null)
				cb_onConnecting_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnConnecting_Z);
			return cb_onConnecting_Z;
		}

		static void n_OnConnecting_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConnectionStatusController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConnectionStatusController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnecting (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConnecting_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConnectionStatusController']/method[@name='onConnecting' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onConnecting", "(Z)V", "GetOnConnecting_ZHandler")]
		public virtual unsafe void OnConnecting (bool p0)
		{
			if (id_onConnecting_Z == IntPtr.Zero)
				id_onConnecting_Z = JNIEnv.GetMethodID (class_ref, "onConnecting", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnecting_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnecting", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onError;
#pragma warning disable 0169
		static Delegate GetOnErrorHandler ()
		{
			if (cb_onError == null)
				cb_onError = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnError);
			return cb_onError;
		}

		static void n_OnError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConnectionStatusController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConnectionStatusController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnError ();
		}
#pragma warning restore 0169

		static IntPtr id_onError;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConnectionStatusController']/method[@name='onError' and count(parameter)=0]"
		[Register ("onError", "()V", "GetOnErrorHandler")]
		public virtual unsafe void OnError ()
		{
			if (id_onError == IntPtr.Zero)
				id_onError = JNIEnv.GetMethodID (class_ref, "onError", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onError", "()V"));
			} finally {
			}
		}

		static Delegate cb_unregister;
#pragma warning disable 0169
		static Delegate GetUnregisterHandler ()
		{
			if (cb_unregister == null)
				cb_unregister = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Unregister);
			return cb_unregister;
		}

		static void n_Unregister (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConnectionStatusController __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConnectionStatusController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Unregister ();
		}
#pragma warning restore 0169

		static IntPtr id_unregister;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConnectionStatusController']/method[@name='unregister' and count(parameter)=0]"
		[Register ("unregister", "()V", "GetUnregisterHandler")]
		public virtual unsafe void Unregister ()
		{
			if (id_unregister == IntPtr.Zero)
				id_unregister = JNIEnv.GetMethodID (class_ref, "unregister", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregister);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregister", "()V"));
			} finally {
			}
		}

	}
}
