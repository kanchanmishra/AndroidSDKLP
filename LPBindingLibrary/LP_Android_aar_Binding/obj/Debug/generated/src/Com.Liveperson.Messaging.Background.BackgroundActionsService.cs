using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Background {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='BackgroundActionsService']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/background/BackgroundActionsService", DoNotGenerateAcw=true)]
	public partial class BackgroundActionsService : global::Android.App.Service {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='BackgroundActionsService']/field[@name='EXTRA_ACTION_TYPE']"
		[Register ("EXTRA_ACTION_TYPE")]
		public const string ExtraActionType = (string) "extra_action_type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='BackgroundActionsService']/field[@name='EXTRA_ACTION_TYPE_UPLOAD']"
		[Register ("EXTRA_ACTION_TYPE_UPLOAD")]
		public const int ExtraActionTypeUpload = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='BackgroundActionsService']/field[@name='EXTRA_FILE_TYPE']"
		[Register ("EXTRA_FILE_TYPE")]
		public const string ExtraFileType = (string) "extra_file_type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='BackgroundActionsService']/field[@name='EXTRA_TYPE_ACTION_DOWNLOAD']"
		[Register ("EXTRA_TYPE_ACTION_DOWNLOAD")]
		public const int ExtraTypeActionDownload = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='BackgroundActionsService']/field[@name='EXTRA_TYPE_ACTION_REUPLOAD']"
		[Register ("EXTRA_TYPE_ACTION_REUPLOAD")]
		public const int ExtraTypeActionReupload = (int) 3;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.messaging.background']/interface[@name='BackgroundActionsService.ServiceActionCallbackListener']"
		[Register ("com/liveperson/messaging/background/BackgroundActionsService$ServiceActionCallbackListener", "", "Com.Liveperson.Messaging.Background.BackgroundActionsService/IServiceActionCallbackListenerInvoker")]
		public partial interface IServiceActionCallbackListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/interface[@name='BackgroundActionsService.ServiceActionCallbackListener']/method[@name='onFail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onFail", "(Ljava/lang/String;)V", "GetOnFail_Ljava_lang_String_Handler:Com.Liveperson.Messaging.Background.BackgroundActionsService/IServiceActionCallbackListenerInvoker, LP_Android_aar_Binding")]
			void OnFail (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/interface[@name='BackgroundActionsService.ServiceActionCallbackListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onSuccess", "(Ljava/lang/String;)V", "GetOnSuccess_Ljava_lang_String_Handler:Com.Liveperson.Messaging.Background.BackgroundActionsService/IServiceActionCallbackListenerInvoker, LP_Android_aar_Binding")]
			void OnSuccess (string p0);

		}

		[global::Android.Runtime.Register ("com/liveperson/messaging/background/BackgroundActionsService$ServiceActionCallbackListener", DoNotGenerateAcw=true)]
		internal class IServiceActionCallbackListenerInvoker : global::Java.Lang.Object, IServiceActionCallbackListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/messaging/background/BackgroundActionsService$ServiceActionCallbackListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IServiceActionCallbackListenerInvoker); }
			}

			IntPtr class_ref;

			public static IServiceActionCallbackListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IServiceActionCallbackListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.messaging.background.BackgroundActionsService.ServiceActionCallbackListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IServiceActionCallbackListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onFail_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnFail_Ljava_lang_String_Handler ()
			{
				if (cb_onFail_Ljava_lang_String_ == null)
					cb_onFail_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFail_Ljava_lang_String_);
				return cb_onFail_Ljava_lang_String_;
			}

			static void n_OnFail_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Messaging.Background.BackgroundActionsService.IServiceActionCallbackListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.BackgroundActionsService.IServiceActionCallbackListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFail (p0);
			}
#pragma warning restore 0169

			IntPtr id_onFail_Ljava_lang_String_;
			public unsafe void OnFail (string p0)
			{
				if (id_onFail_Ljava_lang_String_ == IntPtr.Zero)
					id_onFail_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onFail", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFail_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onSuccess_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnSuccess_Ljava_lang_String_Handler ()
			{
				if (cb_onSuccess_Ljava_lang_String_ == null)
					cb_onSuccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Ljava_lang_String_);
				return cb_onSuccess_Ljava_lang_String_;
			}

			static void n_OnSuccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Messaging.Background.BackgroundActionsService.IServiceActionCallbackListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.BackgroundActionsService.IServiceActionCallbackListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSuccess_Ljava_lang_String_;
			public unsafe void OnSuccess (string p0)
			{
				if (id_onSuccess_Ljava_lang_String_ == IntPtr.Zero)
					id_onSuccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		public partial class FailEventArgs : global::System.EventArgs {

			public FailEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		public partial class SuccessEventArgs : global::System.EventArgs {

			public SuccessEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/liveperson/messaging/background/BackgroundActionsService_ServiceActionCallbackListenerImplementor")]
		internal sealed partial class IServiceActionCallbackListenerImplementor : global::Java.Lang.Object, IServiceActionCallbackListener {

			object sender;

			public IServiceActionCallbackListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/liveperson/messaging/background/BackgroundActionsService_ServiceActionCallbackListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<FailEventArgs> OnFailHandler;
#pragma warning restore 0649

			public void OnFail (string p0)
			{
				var __h = OnFailHandler;
				if (__h != null)
					__h (sender, new FailEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<SuccessEventArgs> OnSuccessHandler;
#pragma warning restore 0649

			public void OnSuccess (string p0)
			{
				var __h = OnSuccessHandler;
				if (__h != null)
					__h (sender, new SuccessEventArgs (p0));
			}

			internal static bool __IsEmpty (IServiceActionCallbackListenerImplementor value)
			{
				return value.OnFailHandler == null && value.OnSuccessHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.messaging.background']/interface[@name='BackgroundActionsService.ServiceActioner']"
		[Register ("com/liveperson/messaging/background/BackgroundActionsService$ServiceActioner", "", "Com.Liveperson.Messaging.Background.BackgroundActionsService/IServiceActionerInvoker")]
		public partial interface IServiceActioner : IJavaObject {

			bool IsPendingActions {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/interface[@name='BackgroundActionsService.ServiceActioner']/method[@name='isPendingActions' and count(parameter)=0]"
				[Register ("isPendingActions", "()Z", "GetIsPendingActionsHandler:Com.Liveperson.Messaging.Background.BackgroundActionsService/IServiceActionerInvoker, LP_Android_aar_Binding")] get;
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/interface[@name='BackgroundActionsService.ServiceActioner']/method[@name='actionFromService' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.liveperson.messaging.background.BackgroundActionsService.ServiceActionCallbackListener']]"
			[Register ("actionFromService", "(Landroid/content/Intent;Lcom/liveperson/messaging/background/BackgroundActionsService$ServiceActionCallbackListener;)V", "GetActionFromService_Landroid_content_Intent_Lcom_liveperson_messaging_background_BackgroundActionsService_ServiceActionCallbackListener_Handler:Com.Liveperson.Messaging.Background.BackgroundActionsService/IServiceActionerInvoker, LP_Android_aar_Binding")]
			void ActionFromService (global::Android.Content.Intent p0, global::Com.Liveperson.Messaging.Background.BackgroundActionsService.IServiceActionCallbackListener p1);

		}

		[global::Android.Runtime.Register ("com/liveperson/messaging/background/BackgroundActionsService$ServiceActioner", DoNotGenerateAcw=true)]
		internal class IServiceActionerInvoker : global::Java.Lang.Object, IServiceActioner {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/messaging/background/BackgroundActionsService$ServiceActioner");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IServiceActionerInvoker); }
			}

			IntPtr class_ref;

			public static IServiceActioner GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IServiceActioner> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.messaging.background.BackgroundActionsService.ServiceActioner"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IServiceActionerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_isPendingActions;
#pragma warning disable 0169
			static Delegate GetIsPendingActionsHandler ()
			{
				if (cb_isPendingActions == null)
					cb_isPendingActions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPendingActions);
				return cb_isPendingActions;
			}

			static bool n_IsPendingActions (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Messaging.Background.BackgroundActionsService.IServiceActioner __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.BackgroundActionsService.IServiceActioner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsPendingActions;
			}
#pragma warning restore 0169

			IntPtr id_isPendingActions;
			public unsafe bool IsPendingActions {
				get {
					if (id_isPendingActions == IntPtr.Zero)
						id_isPendingActions = JNIEnv.GetMethodID (class_ref, "isPendingActions", "()Z");
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPendingActions);
				}
			}

			static Delegate cb_actionFromService_Landroid_content_Intent_Lcom_liveperson_messaging_background_BackgroundActionsService_ServiceActionCallbackListener_;
#pragma warning disable 0169
			static Delegate GetActionFromService_Landroid_content_Intent_Lcom_liveperson_messaging_background_BackgroundActionsService_ServiceActionCallbackListener_Handler ()
			{
				if (cb_actionFromService_Landroid_content_Intent_Lcom_liveperson_messaging_background_BackgroundActionsService_ServiceActionCallbackListener_ == null)
					cb_actionFromService_Landroid_content_Intent_Lcom_liveperson_messaging_background_BackgroundActionsService_ServiceActionCallbackListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ActionFromService_Landroid_content_Intent_Lcom_liveperson_messaging_background_BackgroundActionsService_ServiceActionCallbackListener_);
				return cb_actionFromService_Landroid_content_Intent_Lcom_liveperson_messaging_background_BackgroundActionsService_ServiceActionCallbackListener_;
			}

			static void n_ActionFromService_Landroid_content_Intent_Lcom_liveperson_messaging_background_BackgroundActionsService_ServiceActionCallbackListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Liveperson.Messaging.Background.BackgroundActionsService.IServiceActioner __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.BackgroundActionsService.IServiceActioner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Liveperson.Messaging.Background.BackgroundActionsService.IServiceActionCallbackListener p1 = (global::Com.Liveperson.Messaging.Background.BackgroundActionsService.IServiceActionCallbackListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.BackgroundActionsService.IServiceActionCallbackListener> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.ActionFromService (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_actionFromService_Landroid_content_Intent_Lcom_liveperson_messaging_background_BackgroundActionsService_ServiceActionCallbackListener_;
			public unsafe void ActionFromService (global::Android.Content.Intent p0, global::Com.Liveperson.Messaging.Background.BackgroundActionsService.IServiceActionCallbackListener p1)
			{
				if (id_actionFromService_Landroid_content_Intent_Lcom_liveperson_messaging_background_BackgroundActionsService_ServiceActionCallbackListener_ == IntPtr.Zero)
					id_actionFromService_Landroid_content_Intent_Lcom_liveperson_messaging_background_BackgroundActionsService_ServiceActionCallbackListener_ = JNIEnv.GetMethodID (class_ref, "actionFromService", "(Landroid/content/Intent;Lcom/liveperson/messaging/background/BackgroundActionsService$ServiceActionCallbackListener;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_actionFromService_Landroid_content_Intent_Lcom_liveperson_messaging_background_BackgroundActionsService_ServiceActionCallbackListener_, __args);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/background/BackgroundActionsService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BackgroundActionsService); }
		}

		protected BackgroundActionsService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='BackgroundActionsService']/constructor[@name='BackgroundActionsService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BackgroundActionsService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BackgroundActionsService)) {
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

		static Delegate cb_onBind_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnBind_Landroid_content_Intent_Handler ()
		{
			if (cb_onBind_Landroid_content_Intent_ == null)
				cb_onBind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnBind_Landroid_content_Intent_);
			return cb_onBind_Landroid_content_Intent_;
		}

		static IntPtr n_OnBind_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Background.BackgroundActionsService __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.BackgroundActionsService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBind (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onBind_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background']/class[@name='BackgroundActionsService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "GetOnBind_Landroid_content_Intent_Handler")]
		public override unsafe global::Android.OS.IBinder OnBind (global::Android.Content.Intent p0)
		{
			if (id_onBind_Landroid_content_Intent_ == IntPtr.Zero)
				id_onBind_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.OS.IBinder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onBind_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
