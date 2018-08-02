using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Handler {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.handler']/class[@name='NotificationHandler']"
	[global::Android.Runtime.Register ("com/liveperson/infra/handler/NotificationHandler", DoNotGenerateAcw=true)]
	public partial class NotificationHandler : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/handler/NotificationHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NotificationHandler); }
		}

		protected NotificationHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.handler']/class[@name='NotificationHandler']/constructor[@name='NotificationHandler' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public unsafe NotificationHandler (global::Android.Content.Context p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (NotificationHandler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Landroid_content_Context_Ljava_lang_Class_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.handler']/class[@name='NotificationHandler']/constructor[@name='NotificationHandler' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='java.lang.Class&lt;?&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Landroid/content/Context;Ljava/lang/Class;)V", "")]
		public unsafe NotificationHandler (string p0, global::Android.Content.Context p1, global::Java.Lang.Class p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (NotificationHandler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Landroid/content/Context;Ljava/lang/Class;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Landroid/content/Context;Ljava/lang/Class;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Landroid_content_Context_Ljava_lang_Class_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Landroid_content_Context_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Landroid/content/Context;Ljava/lang/Class;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Landroid_content_Context_Ljava_lang_Class_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Landroid_content_Context_Ljava_lang_Class_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Landroid_content_Context_Ljava_lang_Class_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.handler']/class[@name='NotificationHandler']/constructor[@name='NotificationHandler' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='java.lang.Class&lt;?&gt;'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Landroid/content/Context;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe NotificationHandler (string p0, global::Android.Content.Context p1, global::Java.Lang.Class p2, string p3, string p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				if (((object) this).GetType () != typeof (NotificationHandler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Landroid/content/Context;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Landroid/content/Context;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Landroid_content_Context_Ljava_lang_Class_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Landroid_content_Context_Ljava_lang_Class_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Landroid/content/Context;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Landroid_content_Context_Ljava_lang_Class_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Landroid_content_Context_Ljava_lang_Class_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_createForegroundServiceNotificationBuilder;
#pragma warning disable 0169
		static Delegate GetCreateForegroundServiceNotificationBuilderHandler ()
		{
			if (cb_createForegroundServiceNotificationBuilder == null)
				cb_createForegroundServiceNotificationBuilder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateForegroundServiceNotificationBuilder);
			return cb_createForegroundServiceNotificationBuilder;
		}

		static IntPtr n_CreateForegroundServiceNotificationBuilder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Handler.NotificationHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Handler.NotificationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateForegroundServiceNotificationBuilder ());
		}
#pragma warning restore 0169

		static IntPtr id_createForegroundServiceNotificationBuilder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.handler']/class[@name='NotificationHandler']/method[@name='createForegroundServiceNotificationBuilder' and count(parameter)=0]"
		[Register ("createForegroundServiceNotificationBuilder", "()Landroid/app/Notification$Builder;", "GetCreateForegroundServiceNotificationBuilderHandler")]
		public virtual unsafe global::Android.App.Notification.Builder CreateForegroundServiceNotificationBuilder ()
		{
			if (id_createForegroundServiceNotificationBuilder == IntPtr.Zero)
				id_createForegroundServiceNotificationBuilder = JNIEnv.GetMethodID (class_ref, "createForegroundServiceNotificationBuilder", "()Landroid/app/Notification$Builder;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.App.Notification.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createForegroundServiceNotificationBuilder), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.App.Notification.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createForegroundServiceNotificationBuilder", "()Landroid/app/Notification$Builder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_hideNotification_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.handler']/class[@name='NotificationHandler']/method[@name='hideNotification' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("hideNotification", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void HideNotification (global::Android.Content.Context p0, string p1)
		{
			if (id_hideNotification_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_hideNotification_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hideNotification", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_hideNotification_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setAutoCancel_Z;
#pragma warning disable 0169
		static Delegate GetSetAutoCancel_ZHandler ()
		{
			if (cb_setAutoCancel_Z == null)
				cb_setAutoCancel_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetAutoCancel_Z);
			return cb_setAutoCancel_Z;
		}

		static IntPtr n_SetAutoCancel_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Infra.Handler.NotificationHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Handler.NotificationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAutoCancel (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setAutoCancel_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.handler']/class[@name='NotificationHandler']/method[@name='setAutoCancel' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAutoCancel", "(Z)Lcom/liveperson/infra/handler/NotificationHandler;", "GetSetAutoCancel_ZHandler")]
		public virtual unsafe global::Com.Liveperson.Infra.Handler.NotificationHandler SetAutoCancel (bool p0)
		{
			if (id_setAutoCancel_Z == IntPtr.Zero)
				id_setAutoCancel_Z = JNIEnv.GetMethodID (class_ref, "setAutoCancel", "(Z)Lcom/liveperson/infra/handler/NotificationHandler;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Handler.NotificationHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAutoCancel_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Handler.NotificationHandler> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAutoCancel", "(Z)Lcom/liveperson/infra/handler/NotificationHandler;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setIconResourceId_I;
#pragma warning disable 0169
		static Delegate GetSetIconResourceId_IHandler ()
		{
			if (cb_setIconResourceId_I == null)
				cb_setIconResourceId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetIconResourceId_I);
			return cb_setIconResourceId_I;
		}

		static IntPtr n_SetIconResourceId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Infra.Handler.NotificationHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Handler.NotificationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetIconResourceId (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setIconResourceId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.handler']/class[@name='NotificationHandler']/method[@name='setIconResourceId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setIconResourceId", "(I)Lcom/liveperson/infra/handler/NotificationHandler;", "GetSetIconResourceId_IHandler")]
		public virtual unsafe global::Com.Liveperson.Infra.Handler.NotificationHandler SetIconResourceId (int p0)
		{
			if (id_setIconResourceId_I == IntPtr.Zero)
				id_setIconResourceId_I = JNIEnv.GetMethodID (class_ref, "setIconResourceId", "(I)Lcom/liveperson/infra/handler/NotificationHandler;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Handler.NotificationHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setIconResourceId_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Handler.NotificationHandler> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIconResourceId", "(I)Lcom/liveperson/infra/handler/NotificationHandler;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setNotificationDefaults_I;
#pragma warning disable 0169
		static Delegate GetSetNotificationDefaults_IHandler ()
		{
			if (cb_setNotificationDefaults_I == null)
				cb_setNotificationDefaults_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetNotificationDefaults_I);
			return cb_setNotificationDefaults_I;
		}

		static IntPtr n_SetNotificationDefaults_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Infra.Handler.NotificationHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Handler.NotificationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetNotificationDefaults (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setNotificationDefaults_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.handler']/class[@name='NotificationHandler']/method[@name='setNotificationDefaults' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setNotificationDefaults", "(I)Lcom/liveperson/infra/handler/NotificationHandler;", "GetSetNotificationDefaults_IHandler")]
		public virtual unsafe global::Com.Liveperson.Infra.Handler.NotificationHandler SetNotificationDefaults (int p0)
		{
			if (id_setNotificationDefaults_I == IntPtr.Zero)
				id_setNotificationDefaults_I = JNIEnv.GetMethodID (class_ref, "setNotificationDefaults", "(I)Lcom/liveperson/infra/handler/NotificationHandler;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Handler.NotificationHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setNotificationDefaults_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Handler.NotificationHandler> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotificationDefaults", "(I)Lcom/liveperson/infra/handler/NotificationHandler;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPendingIntent_Landroid_app_PendingIntent_;
#pragma warning disable 0169
		static Delegate GetSetPendingIntent_Landroid_app_PendingIntent_Handler ()
		{
			if (cb_setPendingIntent_Landroid_app_PendingIntent_ == null)
				cb_setPendingIntent_Landroid_app_PendingIntent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPendingIntent_Landroid_app_PendingIntent_);
			return cb_setPendingIntent_Landroid_app_PendingIntent_;
		}

		static IntPtr n_SetPendingIntent_Landroid_app_PendingIntent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Handler.NotificationHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Handler.NotificationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.PendingIntent p0 = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPendingIntent (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setPendingIntent_Landroid_app_PendingIntent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.handler']/class[@name='NotificationHandler']/method[@name='setPendingIntent' and count(parameter)=1 and parameter[1][@type='android.app.PendingIntent']]"
		[Register ("setPendingIntent", "(Landroid/app/PendingIntent;)Lcom/liveperson/infra/handler/NotificationHandler;", "GetSetPendingIntent_Landroid_app_PendingIntent_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Handler.NotificationHandler SetPendingIntent (global::Android.App.PendingIntent p0)
		{
			if (id_setPendingIntent_Landroid_app_PendingIntent_ == IntPtr.Zero)
				id_setPendingIntent_Landroid_app_PendingIntent_ = JNIEnv.GetMethodID (class_ref, "setPendingIntent", "(Landroid/app/PendingIntent;)Lcom/liveperson/infra/handler/NotificationHandler;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Liveperson.Infra.Handler.NotificationHandler __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Handler.NotificationHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPendingIntent_Landroid_app_PendingIntent_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Handler.NotificationHandler> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPendingIntent", "(Landroid/app/PendingIntent;)Lcom/liveperson/infra/handler/NotificationHandler;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_showNotification;
#pragma warning disable 0169
		static Delegate GetShowNotificationHandler ()
		{
			if (cb_showNotification == null)
				cb_showNotification = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowNotification);
			return cb_showNotification;
		}

		static void n_ShowNotification (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Handler.NotificationHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Handler.NotificationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowNotification ();
		}
#pragma warning restore 0169

		static IntPtr id_showNotification;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.handler']/class[@name='NotificationHandler']/method[@name='showNotification' and count(parameter)=0]"
		[Register ("showNotification", "()V", "GetShowNotificationHandler")]
		public virtual unsafe void ShowNotification ()
		{
			if (id_showNotification == IntPtr.Zero)
				id_showNotification = JNIEnv.GetMethodID (class_ref, "showNotification", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showNotification);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showNotification", "()V"));
			} finally {
			}
		}

	}
}
