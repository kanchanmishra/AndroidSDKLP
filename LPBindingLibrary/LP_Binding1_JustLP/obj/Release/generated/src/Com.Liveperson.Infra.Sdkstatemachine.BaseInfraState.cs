using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Sdkstatemachine {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='BaseInfraState']"
	[global::Android.Runtime.Register ("com/liveperson/infra/sdkstatemachine/BaseInfraState", DoNotGenerateAcw=true)]
	public abstract partial class BaseInfraState : global::Java.Lang.Object, global::Com.Liveperson.Infra.Statemachine.Interfaces.IState {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='BaseInfraState']/field[@name='TAG']"
		[Register ("TAG")]
		protected string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, TAG_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='BaseInfraState']/field[@name='name']"
		[Register ("name")]
		protected string Name {
			get {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, name_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, name_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/sdkstatemachine/BaseInfraState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseInfraState); }
		}

		protected BaseInfraState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='BaseInfraState']/constructor[@name='BaseInfraState' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe BaseInfraState (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (BaseInfraState)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_actionOnEntry;
#pragma warning disable 0169
		static Delegate GetActionOnEntryHandler ()
		{
			if (cb_actionOnEntry == null)
				cb_actionOnEntry = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ActionOnEntry);
			return cb_actionOnEntry;
		}

		static void n_ActionOnEntry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Sdkstatemachine.BaseInfraState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.BaseInfraState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ActionOnEntry ();
		}
#pragma warning restore 0169

		static IntPtr id_actionOnEntry;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='BaseInfraState']/method[@name='actionOnEntry' and count(parameter)=0]"
		[Register ("actionOnEntry", "()V", "GetActionOnEntryHandler")]
		public virtual unsafe void ActionOnEntry ()
		{
			if (id_actionOnEntry == IntPtr.Zero)
				id_actionOnEntry = JNIEnv.GetMethodID (class_ref, "actionOnEntry", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_actionOnEntry);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "actionOnEntry", "()V"));
			} finally {
			}
		}

		static Delegate cb_actionOnExit;
#pragma warning disable 0169
		static Delegate GetActionOnExitHandler ()
		{
			if (cb_actionOnExit == null)
				cb_actionOnExit = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ActionOnExit);
			return cb_actionOnExit;
		}

		static void n_ActionOnExit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Sdkstatemachine.BaseInfraState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.BaseInfraState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ActionOnExit ();
		}
#pragma warning restore 0169

		static IntPtr id_actionOnExit;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='BaseInfraState']/method[@name='actionOnExit' and count(parameter)=0]"
		[Register ("actionOnExit", "()V", "GetActionOnExitHandler")]
		public virtual unsafe void ActionOnExit ()
		{
			if (id_actionOnExit == IntPtr.Zero)
				id_actionOnExit = JNIEnv.GetMethodID (class_ref, "actionOnExit", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_actionOnExit);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "actionOnExit", "()V"));
			} finally {
			}
		}

		static Delegate cb_visit_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_Handler ()
		{
			if (cb_visit_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_ == null)
				cb_visit_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_);
			return cb_visit_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_;
		}

		static void n_Visit_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Sdkstatemachine.BaseInfraState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.BaseInfraState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Sdkstatemachine.Events.InitEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Events.InitEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='BaseInfraState']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.events.InitEvent']]"
		[Register ("visit", "(Lcom/liveperson/infra/sdkstatemachine/events/InitEvent;)V", "GetVisit_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_Handler")]
		public virtual unsafe void Visit (global::Com.Liveperson.Infra.Sdkstatemachine.Events.InitEvent p0)
		{
			if (id_visit_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/infra/sdkstatemachine/events/InitEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/infra/sdkstatemachine/events/InitEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_visit_Lcom_liveperson_infra_sdkstatemachine_events_LogoutEvent_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_infra_sdkstatemachine_events_LogoutEvent_Handler ()
		{
			if (cb_visit_Lcom_liveperson_infra_sdkstatemachine_events_LogoutEvent_ == null)
				cb_visit_Lcom_liveperson_infra_sdkstatemachine_events_LogoutEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_infra_sdkstatemachine_events_LogoutEvent_);
			return cb_visit_Lcom_liveperson_infra_sdkstatemachine_events_LogoutEvent_;
		}

		static void n_Visit_Lcom_liveperson_infra_sdkstatemachine_events_LogoutEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Sdkstatemachine.BaseInfraState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.BaseInfraState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Sdkstatemachine.Events.LogoutEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Events.LogoutEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_infra_sdkstatemachine_events_LogoutEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='BaseInfraState']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.events.LogoutEvent']]"
		[Register ("visit", "(Lcom/liveperson/infra/sdkstatemachine/events/LogoutEvent;)V", "GetVisit_Lcom_liveperson_infra_sdkstatemachine_events_LogoutEvent_Handler")]
		public virtual unsafe void Visit (global::Com.Liveperson.Infra.Sdkstatemachine.Events.LogoutEvent p0)
		{
			if (id_visit_Lcom_liveperson_infra_sdkstatemachine_events_LogoutEvent_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_infra_sdkstatemachine_events_LogoutEvent_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/infra/sdkstatemachine/events/LogoutEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_infra_sdkstatemachine_events_LogoutEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/infra/sdkstatemachine/events/LogoutEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_visit_Lcom_liveperson_infra_sdkstatemachine_events_PreLogoutCompletedEvent_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_infra_sdkstatemachine_events_PreLogoutCompletedEvent_Handler ()
		{
			if (cb_visit_Lcom_liveperson_infra_sdkstatemachine_events_PreLogoutCompletedEvent_ == null)
				cb_visit_Lcom_liveperson_infra_sdkstatemachine_events_PreLogoutCompletedEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_infra_sdkstatemachine_events_PreLogoutCompletedEvent_);
			return cb_visit_Lcom_liveperson_infra_sdkstatemachine_events_PreLogoutCompletedEvent_;
		}

		static void n_Visit_Lcom_liveperson_infra_sdkstatemachine_events_PreLogoutCompletedEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Sdkstatemachine.BaseInfraState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.BaseInfraState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Sdkstatemachine.Events.PreLogoutCompletedEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Events.PreLogoutCompletedEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_infra_sdkstatemachine_events_PreLogoutCompletedEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='BaseInfraState']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.events.PreLogoutCompletedEvent']]"
		[Register ("visit", "(Lcom/liveperson/infra/sdkstatemachine/events/PreLogoutCompletedEvent;)V", "GetVisit_Lcom_liveperson_infra_sdkstatemachine_events_PreLogoutCompletedEvent_Handler")]
		public virtual unsafe void Visit (global::Com.Liveperson.Infra.Sdkstatemachine.Events.PreLogoutCompletedEvent p0)
		{
			if (id_visit_Lcom_liveperson_infra_sdkstatemachine_events_PreLogoutCompletedEvent_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_infra_sdkstatemachine_events_PreLogoutCompletedEvent_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/infra/sdkstatemachine/events/PreLogoutCompletedEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_infra_sdkstatemachine_events_PreLogoutCompletedEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/infra/sdkstatemachine/events/PreLogoutCompletedEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_visit_Lcom_liveperson_infra_sdkstatemachine_events_ShutDownCompletedEvent_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_infra_sdkstatemachine_events_ShutDownCompletedEvent_Handler ()
		{
			if (cb_visit_Lcom_liveperson_infra_sdkstatemachine_events_ShutDownCompletedEvent_ == null)
				cb_visit_Lcom_liveperson_infra_sdkstatemachine_events_ShutDownCompletedEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_infra_sdkstatemachine_events_ShutDownCompletedEvent_);
			return cb_visit_Lcom_liveperson_infra_sdkstatemachine_events_ShutDownCompletedEvent_;
		}

		static void n_Visit_Lcom_liveperson_infra_sdkstatemachine_events_ShutDownCompletedEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Sdkstatemachine.BaseInfraState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.BaseInfraState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Sdkstatemachine.Events.ShutDownCompletedEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Events.ShutDownCompletedEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_infra_sdkstatemachine_events_ShutDownCompletedEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='BaseInfraState']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.events.ShutDownCompletedEvent']]"
		[Register ("visit", "(Lcom/liveperson/infra/sdkstatemachine/events/ShutDownCompletedEvent;)V", "GetVisit_Lcom_liveperson_infra_sdkstatemachine_events_ShutDownCompletedEvent_Handler")]
		public virtual unsafe void Visit (global::Com.Liveperson.Infra.Sdkstatemachine.Events.ShutDownCompletedEvent p0)
		{
			if (id_visit_Lcom_liveperson_infra_sdkstatemachine_events_ShutDownCompletedEvent_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_infra_sdkstatemachine_events_ShutDownCompletedEvent_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/infra/sdkstatemachine/events/ShutDownCompletedEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_infra_sdkstatemachine_events_ShutDownCompletedEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/infra/sdkstatemachine/events/ShutDownCompletedEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_visit_Lcom_liveperson_infra_sdkstatemachine_events_ShutDownEvent_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_infra_sdkstatemachine_events_ShutDownEvent_Handler ()
		{
			if (cb_visit_Lcom_liveperson_infra_sdkstatemachine_events_ShutDownEvent_ == null)
				cb_visit_Lcom_liveperson_infra_sdkstatemachine_events_ShutDownEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_infra_sdkstatemachine_events_ShutDownEvent_);
			return cb_visit_Lcom_liveperson_infra_sdkstatemachine_events_ShutDownEvent_;
		}

		static void n_Visit_Lcom_liveperson_infra_sdkstatemachine_events_ShutDownEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Sdkstatemachine.BaseInfraState __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.BaseInfraState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Sdkstatemachine.Events.ShutDownEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Events.ShutDownEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_visit_Lcom_liveperson_infra_sdkstatemachine_events_ShutDownEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='BaseInfraState']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.events.ShutDownEvent']]"
		[Register ("visit", "(Lcom/liveperson/infra/sdkstatemachine/events/ShutDownEvent;)V", "GetVisit_Lcom_liveperson_infra_sdkstatemachine_events_ShutDownEvent_Handler")]
		public virtual unsafe void Visit (global::Com.Liveperson.Infra.Sdkstatemachine.Events.ShutDownEvent p0)
		{
			if (id_visit_Lcom_liveperson_infra_sdkstatemachine_events_ShutDownEvent_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_infra_sdkstatemachine_events_ShutDownEvent_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/infra/sdkstatemachine/events/ShutDownEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_infra_sdkstatemachine_events_ShutDownEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "visit", "(Lcom/liveperson/infra/sdkstatemachine/events/ShutDownEvent;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/sdkstatemachine/BaseInfraState", DoNotGenerateAcw=true)]
	internal partial class BaseInfraStateInvoker : BaseInfraState {

		public BaseInfraStateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseInfraStateInvoker); }
		}

	}

}
