using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='TTRManager']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/model/TTRManager", DoNotGenerateAcw=true)]
	public partial class TTRManager : global::Java.Lang.Object, global::Com.Liveperson.Infra.IClearable, global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDown {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='TTRManager.UpdateTTRRunnable']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/model/TTRManager$UpdateTTRRunnable", DoNotGenerateAcw=true)]
		public partial class UpdateTTRRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/model/TTRManager$UpdateTTRRunnable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UpdateTTRRunnable); }
			}

			protected UpdateTTRRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_messaging_model_TTRManager_JJLjava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='TTRManager.UpdateTTRRunnable']/constructor[@name='TTRManager.UpdateTTRRunnable' and count(parameter)=4 and parameter[1][@type='com.liveperson.messaging.model.TTRManager'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/liveperson/messaging/model/TTRManager;JJLjava/lang/String;)V", "")]
			public unsafe UpdateTTRRunnable (global::Com.Liveperson.Messaging.Model.TTRManager __self, long p1, long p2, string p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p3 = JNIEnv.NewString (p3);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (native_p3);
					if (((object) this).GetType () != typeof (UpdateTTRRunnable)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";JJLjava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";JJLjava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_messaging_model_TTRManager_JJLjava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_messaging_model_TTRManager_JJLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/model/TTRManager;JJLjava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_model_TTRManager_JJLjava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_model_TTRManager_JJLjava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Messaging.Model.TTRManager.UpdateTTRRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.TTRManager.UpdateTTRRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='TTRManager.UpdateTTRRunnable']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/model/TTRManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TTRManager); }
		}

		protected TTRManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='TTRManager']/constructor[@name='TTRManager' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe TTRManager (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (TTRManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_calculateEffectiveTTR_Ljava_lang_String_JJJJ;
#pragma warning disable 0169
		static Delegate GetCalculateEffectiveTTR_Ljava_lang_String_JJJJHandler ()
		{
			if (cb_calculateEffectiveTTR_Ljava_lang_String_JJJJ == null)
				cb_calculateEffectiveTTR_Ljava_lang_String_JJJJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, long, long, long, long>) n_CalculateEffectiveTTR_Ljava_lang_String_JJJJ);
			return cb_calculateEffectiveTTR_Ljava_lang_String_JJJJ;
		}

		static long n_CalculateEffectiveTTR_Ljava_lang_String_JJJJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2, long p3, long p4)
		{
			global::Com.Liveperson.Messaging.Model.TTRManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.TTRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.CalculateEffectiveTTR (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_calculateEffectiveTTR_Ljava_lang_String_JJJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='TTRManager']/method[@name='calculateEffectiveTTR' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='long']]"
		[Register ("calculateEffectiveTTR", "(Ljava/lang/String;JJJJ)J", "GetCalculateEffectiveTTR_Ljava_lang_String_JJJJHandler")]
		public virtual unsafe long CalculateEffectiveTTR (string p0, long p1, long p2, long p3, long p4)
		{
			if (id_calculateEffectiveTTR_Ljava_lang_String_JJJJ == IntPtr.Zero)
				id_calculateEffectiveTTR_Ljava_lang_String_JJJJ = JNIEnv.GetMethodID (class_ref, "calculateEffectiveTTR", "(Ljava/lang/String;JJJJ)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_calculateEffectiveTTR_Ljava_lang_String_JJJJ, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calculateEffectiveTTR", "(Ljava/lang/String;JJJJ)J"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_cancelAll;
#pragma warning disable 0169
		static Delegate GetCancelAllHandler ()
		{
			if (cb_cancelAll == null)
				cb_cancelAll = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CancelAll);
			return cb_cancelAll;
		}

		static void n_CancelAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.TTRManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.TTRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelAll ();
		}
#pragma warning restore 0169

		static IntPtr id_cancelAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='TTRManager']/method[@name='cancelAll' and count(parameter)=0]"
		[Register ("cancelAll", "()V", "GetCancelAllHandler")]
		public virtual unsafe void CancelAll ()
		{
			if (id_cancelAll == IntPtr.Zero)
				id_cancelAll = JNIEnv.GetMethodID (class_ref, "cancelAll", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelAll);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelAll", "()V"));
			} finally {
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.TTRManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.TTRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='TTRManager']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_resetEffectiveTTR;
#pragma warning disable 0169
		static Delegate GetResetEffectiveTTRHandler ()
		{
			if (cb_resetEffectiveTTR == null)
				cb_resetEffectiveTTR = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetEffectiveTTR);
			return cb_resetEffectiveTTR;
		}

		static void n_ResetEffectiveTTR (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.TTRManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.TTRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetEffectiveTTR ();
		}
#pragma warning restore 0169

		static IntPtr id_resetEffectiveTTR;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='TTRManager']/method[@name='resetEffectiveTTR' and count(parameter)=0]"
		[Register ("resetEffectiveTTR", "()V", "GetResetEffectiveTTRHandler")]
		public virtual unsafe void ResetEffectiveTTR ()
		{
			if (id_resetEffectiveTTR == IntPtr.Zero)
				id_resetEffectiveTTR = JNIEnv.GetMethodID (class_ref, "resetEffectiveTTR", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetEffectiveTTR);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetEffectiveTTR", "()V"));
			} finally {
			}
		}

		static Delegate cb_showTTR_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShowTTR_Ljava_lang_String_Handler ()
		{
			if (cb_showTTR_Ljava_lang_String_ == null)
				cb_showTTR_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowTTR_Ljava_lang_String_);
			return cb_showTTR_Ljava_lang_String_;
		}

		static void n_ShowTTR_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.TTRManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.TTRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShowTTR (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showTTR_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='TTRManager']/method[@name='showTTR' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("showTTR", "(Ljava/lang/String;)V", "GetShowTTR_Ljava_lang_String_Handler")]
		public virtual unsafe void ShowTTR (string p0)
		{
			if (id_showTTR_Ljava_lang_String_ == IntPtr.Zero)
				id_showTTR_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "showTTR", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showTTR_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showTTR", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_shutDown;
#pragma warning disable 0169
		static Delegate GetShutDownHandler ()
		{
			if (cb_shutDown == null)
				cb_shutDown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShutDown);
			return cb_shutDown;
		}

		static void n_ShutDown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.TTRManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.TTRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShutDown ();
		}
#pragma warning restore 0169

		static IntPtr id_shutDown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='TTRManager']/method[@name='shutDown' and count(parameter)=0]"
		[Register ("shutDown", "()V", "GetShutDownHandler")]
		public virtual unsafe void ShutDown ()
		{
			if (id_shutDown == IntPtr.Zero)
				id_shutDown = JNIEnv.GetMethodID (class_ref, "shutDown", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutDown);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shutDown", "()V"));
			} finally {
			}
		}

		static Delegate cb_updateIfOffHours_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateIfOffHours_Ljava_lang_String_Handler ()
		{
			if (cb_updateIfOffHours_Ljava_lang_String_ == null)
				cb_updateIfOffHours_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateIfOffHours_Ljava_lang_String_);
			return cb_updateIfOffHours_Ljava_lang_String_;
		}

		static void n_UpdateIfOffHours_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.TTRManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.TTRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateIfOffHours (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateIfOffHours_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='TTRManager']/method[@name='updateIfOffHours' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateIfOffHours", "(Ljava/lang/String;)V", "GetUpdateIfOffHours_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateIfOffHours (string p0)
		{
			if (id_updateIfOffHours_Ljava_lang_String_ == IntPtr.Zero)
				id_updateIfOffHours_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateIfOffHours", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateIfOffHours_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateIfOffHours", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateTTR_Ljava_lang_String_JJJ;
#pragma warning disable 0169
		static Delegate GetUpdateTTR_Ljava_lang_String_JJJHandler ()
		{
			if (cb_updateTTR_Ljava_lang_String_JJJ == null)
				cb_updateTTR_Ljava_lang_String_JJJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, long, long>) n_UpdateTTR_Ljava_lang_String_JJJ);
			return cb_updateTTR_Ljava_lang_String_JJJ;
		}

		static void n_UpdateTTR_Ljava_lang_String_JJJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2, long p3)
		{
			global::Com.Liveperson.Messaging.Model.TTRManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.TTRManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateTTR (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_updateTTR_Ljava_lang_String_JJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='TTRManager']/method[@name='updateTTR' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("updateTTR", "(Ljava/lang/String;JJJ)V", "GetUpdateTTR_Ljava_lang_String_JJJHandler")]
		public virtual unsafe void UpdateTTR (string p0, long p1, long p2, long p3)
		{
			if (id_updateTTR_Ljava_lang_String_JJJ == IntPtr.Zero)
				id_updateTTR_Ljava_lang_String_JJJ = JNIEnv.GetMethodID (class_ref, "updateTTR", "(Ljava/lang/String;JJJ)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateTTR_Ljava_lang_String_JJJ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateTTR", "(Ljava/lang/String;JJJ)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
