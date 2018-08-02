using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LocalBroadcastReceiver']"
	[global::Android.Runtime.Register ("com/liveperson/infra/LocalBroadcastReceiver", DoNotGenerateAcw=true)]
	public partial class LocalBroadcastReceiver : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LocalBroadcastReceiver.Builder']"
		[global::Android.Runtime.Register ("com/liveperson/infra/LocalBroadcastReceiver$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/LocalBroadcastReceiver$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LocalBroadcastReceiver.Builder']/constructor[@name='LocalBroadcastReceiver.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Builder)) {
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

			static Delegate cb_addAction_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAddAction_Ljava_lang_String_Handler ()
			{
				if (cb_addAction_Ljava_lang_String_ == null)
					cb_addAction_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddAction_Ljava_lang_String_);
				return cb_addAction_Ljava_lang_String_;
			}

			static IntPtr n_AddAction_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Infra.LocalBroadcastReceiver.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LocalBroadcastReceiver.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddAction (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_addAction_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LocalBroadcastReceiver.Builder']/method[@name='addAction' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("addAction", "(Ljava/lang/String;)Lcom/liveperson/infra/LocalBroadcastReceiver$Builder;", "GetAddAction_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Liveperson.Infra.LocalBroadcastReceiver.Builder AddAction (string p0)
			{
				if (id_addAction_Ljava_lang_String_ == IntPtr.Zero)
					id_addAction_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addAction", "(Ljava/lang/String;)Lcom/liveperson/infra/LocalBroadcastReceiver$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Liveperson.Infra.LocalBroadcastReceiver.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LocalBroadcastReceiver.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addAction_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LocalBroadcastReceiver.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAction", "(Ljava/lang/String;)Lcom/liveperson/infra/LocalBroadcastReceiver$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_build_Lcom_liveperson_infra_LocalBroadcastReceiver_IOnReceive_;
#pragma warning disable 0169
			static Delegate GetBuild_Lcom_liveperson_infra_LocalBroadcastReceiver_IOnReceive_Handler ()
			{
				if (cb_build_Lcom_liveperson_infra_LocalBroadcastReceiver_IOnReceive_ == null)
					cb_build_Lcom_liveperson_infra_LocalBroadcastReceiver_IOnReceive_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Build_Lcom_liveperson_infra_LocalBroadcastReceiver_IOnReceive_);
				return cb_build_Lcom_liveperson_infra_LocalBroadcastReceiver_IOnReceive_;
			}

			static IntPtr n_Build_Lcom_liveperson_infra_LocalBroadcastReceiver_IOnReceive_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Infra.LocalBroadcastReceiver.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LocalBroadcastReceiver.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Liveperson.Infra.LocalBroadcastReceiver.IOnReceive p0 = (global::Com.Liveperson.Infra.LocalBroadcastReceiver.IOnReceive)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LocalBroadcastReceiver.IOnReceive> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Build (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_build_Lcom_liveperson_infra_LocalBroadcastReceiver_IOnReceive_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LocalBroadcastReceiver.Builder']/method[@name='build' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.LocalBroadcastReceiver.IOnReceive']]"
			[Register ("build", "(Lcom/liveperson/infra/LocalBroadcastReceiver$IOnReceive;)Lcom/liveperson/infra/LocalBroadcastReceiver;", "GetBuild_Lcom_liveperson_infra_LocalBroadcastReceiver_IOnReceive_Handler")]
			public virtual unsafe global::Com.Liveperson.Infra.LocalBroadcastReceiver Build (global::Com.Liveperson.Infra.LocalBroadcastReceiver.IOnReceive p0)
			{
				if (id_build_Lcom_liveperson_infra_LocalBroadcastReceiver_IOnReceive_ == IntPtr.Zero)
					id_build_Lcom_liveperson_infra_LocalBroadcastReceiver_IOnReceive_ = JNIEnv.GetMethodID (class_ref, "build", "(Lcom/liveperson/infra/LocalBroadcastReceiver$IOnReceive;)Lcom/liveperson/infra/LocalBroadcastReceiver;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Liveperson.Infra.LocalBroadcastReceiver __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LocalBroadcastReceiver> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build_Lcom_liveperson_infra_LocalBroadcastReceiver_IOnReceive_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LocalBroadcastReceiver> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "(Lcom/liveperson/infra/LocalBroadcastReceiver$IOnReceive;)Lcom/liveperson/infra/LocalBroadcastReceiver;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setSingleCallback;
#pragma warning disable 0169
			static Delegate GetSetSingleCallbackHandler ()
			{
				if (cb_setSingleCallback == null)
					cb_setSingleCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SetSingleCallback);
				return cb_setSingleCallback;
			}

			static IntPtr n_SetSingleCallback (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.LocalBroadcastReceiver.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LocalBroadcastReceiver.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetSingleCallback ());
			}
#pragma warning restore 0169

			static IntPtr id_setSingleCallback;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LocalBroadcastReceiver.Builder']/method[@name='setSingleCallback' and count(parameter)=0]"
			[Register ("setSingleCallback", "()Lcom/liveperson/infra/LocalBroadcastReceiver$Builder;", "GetSetSingleCallbackHandler")]
			public virtual unsafe global::Com.Liveperson.Infra.LocalBroadcastReceiver.Builder SetSingleCallback ()
			{
				if (id_setSingleCallback == IntPtr.Zero)
					id_setSingleCallback = JNIEnv.GetMethodID (class_ref, "setSingleCallback", "()Lcom/liveperson/infra/LocalBroadcastReceiver$Builder;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LocalBroadcastReceiver.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setSingleCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LocalBroadcastReceiver.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSingleCallback", "()Lcom/liveperson/infra/LocalBroadcastReceiver$Builder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra']/interface[@name='LocalBroadcastReceiver.IOnReceive']"
		[Register ("com/liveperson/infra/LocalBroadcastReceiver$IOnReceive", "", "Com.Liveperson.Infra.LocalBroadcastReceiver/IOnReceiveInvoker")]
		public partial interface IOnReceive : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/interface[@name='LocalBroadcastReceiver.IOnReceive']/method[@name='onBroadcastReceived' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
			[Register ("onBroadcastReceived", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnBroadcastReceived_Landroid_content_Context_Landroid_content_Intent_Handler:Com.Liveperson.Infra.LocalBroadcastReceiver/IOnReceiveInvoker, LP_Infra_Binding")]
			void OnBroadcastReceived (global::Android.Content.Context p0, global::Android.Content.Intent p1);

		}

		[global::Android.Runtime.Register ("com/liveperson/infra/LocalBroadcastReceiver$IOnReceive", DoNotGenerateAcw=true)]
		internal class IOnReceiveInvoker : global::Java.Lang.Object, IOnReceive {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/LocalBroadcastReceiver$IOnReceive");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnReceiveInvoker); }
			}

			IntPtr class_ref;

			public static IOnReceive GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnReceive> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.LocalBroadcastReceiver.IOnReceive"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnReceiveInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onBroadcastReceived_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
			static Delegate GetOnBroadcastReceived_Landroid_content_Context_Landroid_content_Intent_Handler ()
			{
				if (cb_onBroadcastReceived_Landroid_content_Context_Landroid_content_Intent_ == null)
					cb_onBroadcastReceived_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnBroadcastReceived_Landroid_content_Context_Landroid_content_Intent_);
				return cb_onBroadcastReceived_Landroid_content_Context_Landroid_content_Intent_;
			}

			static void n_OnBroadcastReceived_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Liveperson.Infra.LocalBroadcastReceiver.IOnReceive __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LocalBroadcastReceiver.IOnReceive> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnBroadcastReceived (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onBroadcastReceived_Landroid_content_Context_Landroid_content_Intent_;
			public unsafe void OnBroadcastReceived (global::Android.Content.Context p0, global::Android.Content.Intent p1)
			{
				if (id_onBroadcastReceived_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
					id_onBroadcastReceived_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onBroadcastReceived", "(Landroid/content/Context;Landroid/content/Intent;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBroadcastReceived_Landroid_content_Context_Landroid_content_Intent_, __args);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LocalBroadcastReceiver.LPBroadcastReceiver']"
		[global::Android.Runtime.Register ("com/liveperson/infra/LocalBroadcastReceiver$LPBroadcastReceiver", DoNotGenerateAcw=true)]
		public partial class LPBroadcastReceiver : global::Android.Content.BroadcastReceiver {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/LocalBroadcastReceiver$LPBroadcastReceiver", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LPBroadcastReceiver); }
			}

			protected LPBroadcastReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_infra_LocalBroadcastReceiver_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LocalBroadcastReceiver.LPBroadcastReceiver']/constructor[@name='LocalBroadcastReceiver.LPBroadcastReceiver' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.LocalBroadcastReceiver']]"
			[Register (".ctor", "(Lcom/liveperson/infra/LocalBroadcastReceiver;)V", "")]
			public unsafe LPBroadcastReceiver (global::Com.Liveperson.Infra.LocalBroadcastReceiver __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (LPBroadcastReceiver)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_infra_LocalBroadcastReceiver_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_infra_LocalBroadcastReceiver_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/LocalBroadcastReceiver;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_LocalBroadcastReceiver_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_LocalBroadcastReceiver_, __args);
				} finally {
				}
			}

			static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
			static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler ()
			{
				if (cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
					cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReceive_Landroid_content_Context_Landroid_content_Intent_);
				return cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
			}

			static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Liveperson.Infra.LocalBroadcastReceiver.LPBroadcastReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LocalBroadcastReceiver.LPBroadcastReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnReceive (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onReceive_Landroid_content_Context_Landroid_content_Intent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LocalBroadcastReceiver.LPBroadcastReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
			[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
			public override unsafe void OnReceive (global::Android.Content.Context p0, global::Android.Content.Intent p1)
			{
				if (id_onReceive_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
					id_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceive_Landroid_content_Context_Landroid_content_Intent_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_register;
#pragma warning disable 0169
			static Delegate GetRegisterHandler ()
			{
				if (cb_register == null)
					cb_register = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Register);
				return cb_register;
			}

			static void n_Register (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.LocalBroadcastReceiver.LPBroadcastReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LocalBroadcastReceiver.LPBroadcastReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Register ();
			}
#pragma warning restore 0169

			static IntPtr id_register;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LocalBroadcastReceiver.LPBroadcastReceiver']/method[@name='register' and count(parameter)=0]"
			[Register ("register", "()V", "GetRegisterHandler")]
			public virtual unsafe void Register ()
			{
				if (id_register == IntPtr.Zero)
					id_register = JNIEnv.GetMethodID (class_ref, "register", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "register", "()V"));
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
				global::Com.Liveperson.Infra.LocalBroadcastReceiver.LPBroadcastReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LocalBroadcastReceiver.LPBroadcastReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Unregister ();
			}
#pragma warning restore 0169

			static IntPtr id_unregister;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LocalBroadcastReceiver.LPBroadcastReceiver']/method[@name='unregister' and count(parameter)=0]"
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

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/LocalBroadcastReceiver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocalBroadcastReceiver); }
		}

		protected LocalBroadcastReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_register;
#pragma warning disable 0169
		static Delegate GetRegisterHandler ()
		{
			if (cb_register == null)
				cb_register = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Register);
			return cb_register;
		}

		static void n_Register (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.LocalBroadcastReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LocalBroadcastReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Register ();
		}
#pragma warning restore 0169

		static IntPtr id_register;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LocalBroadcastReceiver']/method[@name='register' and count(parameter)=0]"
		[Register ("register", "()V", "GetRegisterHandler")]
		public virtual unsafe void Register ()
		{
			if (id_register == IntPtr.Zero)
				id_register = JNIEnv.GetMethodID (class_ref, "register", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "register", "()V"));
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
			global::Com.Liveperson.Infra.LocalBroadcastReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LocalBroadcastReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Unregister ();
		}
#pragma warning restore 0169

		static IntPtr id_unregister;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='LocalBroadcastReceiver']/method[@name='unregister' and count(parameter)=0]"
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
