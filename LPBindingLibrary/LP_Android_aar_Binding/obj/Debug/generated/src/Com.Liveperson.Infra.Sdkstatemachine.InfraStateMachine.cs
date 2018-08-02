using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Sdkstatemachine {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='InfraStateMachine']"
	[global::Android.Runtime.Register ("com/liveperson/infra/sdkstatemachine/InfraStateMachine", DoNotGenerateAcw=true)]
	public partial class InfraStateMachine : global::Com.Liveperson.Infra.Statemachine.BaseStateMachine {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='InfraStateMachine.Idle']"
		[global::Android.Runtime.Register ("com/liveperson/infra/sdkstatemachine/InfraStateMachine$Idle", DoNotGenerateAcw=true)]
		public partial class Idle : global::Com.Liveperson.Infra.Sdkstatemachine.BaseInfraState {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/sdkstatemachine/InfraStateMachine$Idle", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Idle); }
			}

			protected Idle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='InfraStateMachine.Idle']/constructor[@name='InfraStateMachine.Idle' and count(parameter)=3 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.InfraStateMachine'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/liveperson/infra/sdkstatemachine/InfraStateMachine;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe Idle (global::Com.Liveperson.Infra.Sdkstatemachine.InfraStateMachine __self, string p1, string p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					if (((object) this).GetType () != typeof (Idle)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/sdkstatemachine/InfraStateMachine;Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='InfraStateMachine.InProgressState']"
		[global::Android.Runtime.Register ("com/liveperson/infra/sdkstatemachine/InfraStateMachine$InProgressState", DoNotGenerateAcw=true)]
		public abstract partial class InProgressState : global::Com.Liveperson.Infra.Sdkstatemachine.BaseInfraState {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/sdkstatemachine/InfraStateMachine$InProgressState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InProgressState); }
			}

			protected InProgressState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='InfraStateMachine.InProgressState']/constructor[@name='InfraStateMachine.InProgressState' and count(parameter)=3 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.InfraStateMachine'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/liveperson/infra/sdkstatemachine/InfraStateMachine;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe InProgressState (global::Com.Liveperson.Infra.Sdkstatemachine.InfraStateMachine __self, string p1, string p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					if (((object) this).GetType () != typeof (InProgressState)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/sdkstatemachine/InfraStateMachine;Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

		}

		[global::Android.Runtime.Register ("com/liveperson/infra/sdkstatemachine/InfraStateMachine$InProgressState", DoNotGenerateAcw=true)]
		internal partial class InProgressStateInvoker : InProgressState {

			public InProgressStateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (InProgressStateInvoker); }
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='InfraStateMachine.Initialized']"
		[global::Android.Runtime.Register ("com/liveperson/infra/sdkstatemachine/InfraStateMachine$Initialized", DoNotGenerateAcw=true)]
		public partial class Initialized : global::Com.Liveperson.Infra.Sdkstatemachine.BaseInfraState {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/sdkstatemachine/InfraStateMachine$Initialized", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Initialized); }
			}

			protected Initialized (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='InfraStateMachine.Initialized']/constructor[@name='InfraStateMachine.Initialized' and count(parameter)=3 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.InfraStateMachine'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/liveperson/infra/sdkstatemachine/InfraStateMachine;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe Initialized (global::Com.Liveperson.Infra.Sdkstatemachine.InfraStateMachine __self, string p1, string p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					if (((object) this).GetType () != typeof (Initialized)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/sdkstatemachine/InfraStateMachine;Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='InfraStateMachine.Initializing']"
		[global::Android.Runtime.Register ("com/liveperson/infra/sdkstatemachine/InfraStateMachine$Initializing", DoNotGenerateAcw=true)]
		public partial class Initializing : global::Com.Liveperson.Infra.Sdkstatemachine.InfraStateMachine.InProgressState {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/sdkstatemachine/InfraStateMachine$Initializing", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Initializing); }
			}

			protected Initializing (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='InfraStateMachine.Initializing']/constructor[@name='InfraStateMachine.Initializing' and count(parameter)=3 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.InfraStateMachine'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/liveperson/infra/sdkstatemachine/InfraStateMachine;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe Initializing (global::Com.Liveperson.Infra.Sdkstatemachine.InfraStateMachine __self, string p1, string p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					if (((object) this).GetType () != typeof (Initializing)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/sdkstatemachine/InfraStateMachine;Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
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
				global::Com.Liveperson.Infra.Sdkstatemachine.InfraStateMachine.Initializing __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.InfraStateMachine.Initializing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Liveperson.Infra.Sdkstatemachine.Events.InitEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Events.InitEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Visit (p0);
			}
#pragma warning restore 0169

			static IntPtr id_visit_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='InfraStateMachine.Initializing']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.events.InitEvent']]"
			[Register ("visit", "(Lcom/liveperson/infra/sdkstatemachine/events/InitEvent;)V", "GetVisit_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_Handler")]
			public override unsafe void Visit (global::Com.Liveperson.Infra.Sdkstatemachine.Events.InitEvent p0)
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='InfraStateMachine.Logout']"
		[global::Android.Runtime.Register ("com/liveperson/infra/sdkstatemachine/InfraStateMachine$Logout", DoNotGenerateAcw=true)]
		public partial class Logout : global::Com.Liveperson.Infra.Sdkstatemachine.BaseInfraState {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/sdkstatemachine/InfraStateMachine$Logout", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Logout); }
			}

			protected Logout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='InfraStateMachine.Logout']/constructor[@name='InfraStateMachine.Logout' and count(parameter)=3 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.InfraStateMachine'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/liveperson/infra/sdkstatemachine/InfraStateMachine;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe Logout (global::Com.Liveperson.Infra.Sdkstatemachine.InfraStateMachine __self, string p1, string p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					if (((object) this).GetType () != typeof (Logout)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/sdkstatemachine/InfraStateMachine;Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='InfraStateMachine.ShuttingDown']"
		[global::Android.Runtime.Register ("com/liveperson/infra/sdkstatemachine/InfraStateMachine$ShuttingDown", DoNotGenerateAcw=true)]
		public partial class ShuttingDown : global::Com.Liveperson.Infra.Sdkstatemachine.InfraStateMachine.InProgressState {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/sdkstatemachine/InfraStateMachine$ShuttingDown", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ShuttingDown); }
			}

			protected ShuttingDown (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='InfraStateMachine.ShuttingDown']/constructor[@name='InfraStateMachine.ShuttingDown' and count(parameter)=3 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.InfraStateMachine'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/liveperson/infra/sdkstatemachine/InfraStateMachine;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe ShuttingDown (global::Com.Liveperson.Infra.Sdkstatemachine.InfraStateMachine __self, string p1, string p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					if (((object) this).GetType () != typeof (ShuttingDown)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/sdkstatemachine/InfraStateMachine;Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_sdkstatemachine_InfraStateMachine_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
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
				global::Com.Liveperson.Infra.Sdkstatemachine.InfraStateMachine.ShuttingDown __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.InfraStateMachine.ShuttingDown> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ActionOnEntry ();
			}
#pragma warning restore 0169

			static IntPtr id_actionOnEntry;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='InfraStateMachine.ShuttingDown']/method[@name='actionOnEntry' and count(parameter)=0]"
			[Register ("actionOnEntry", "()V", "GetActionOnEntryHandler")]
			public override unsafe void ActionOnEntry ()
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
				global::Com.Liveperson.Infra.Sdkstatemachine.InfraStateMachine.ShuttingDown __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.InfraStateMachine.ShuttingDown> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Liveperson.Infra.Sdkstatemachine.Events.InitEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Events.InitEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Visit (p0);
			}
#pragma warning restore 0169

			static IntPtr id_visit_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='InfraStateMachine.ShuttingDown']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.events.InitEvent']]"
			[Register ("visit", "(Lcom/liveperson/infra/sdkstatemachine/events/InitEvent;)V", "GetVisit_Lcom_liveperson_infra_sdkstatemachine_events_InitEvent_Handler")]
			public override unsafe void Visit (global::Com.Liveperson.Infra.Sdkstatemachine.Events.InitEvent p0)
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
				global::Com.Liveperson.Infra.Sdkstatemachine.InfraStateMachine.ShuttingDown __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.InfraStateMachine.ShuttingDown> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Liveperson.Infra.Sdkstatemachine.Events.LogoutEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Events.LogoutEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Visit (p0);
			}
#pragma warning restore 0169

			static IntPtr id_visit_Lcom_liveperson_infra_sdkstatemachine_events_LogoutEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='InfraStateMachine.ShuttingDown']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.events.LogoutEvent']]"
			[Register ("visit", "(Lcom/liveperson/infra/sdkstatemachine/events/LogoutEvent;)V", "GetVisit_Lcom_liveperson_infra_sdkstatemachine_events_LogoutEvent_Handler")]
			public override unsafe void Visit (global::Com.Liveperson.Infra.Sdkstatemachine.Events.LogoutEvent p0)
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
				global::Com.Liveperson.Infra.Sdkstatemachine.InfraStateMachine.ShuttingDown __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.InfraStateMachine.ShuttingDown> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Liveperson.Infra.Sdkstatemachine.Events.ShutDownEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.Events.ShutDownEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Visit (p0);
			}
#pragma warning restore 0169

			static IntPtr id_visit_Lcom_liveperson_infra_sdkstatemachine_events_ShutDownEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='InfraStateMachine.ShuttingDown']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.sdkstatemachine.events.ShutDownEvent']]"
			[Register ("visit", "(Lcom/liveperson/infra/sdkstatemachine/events/ShutDownEvent;)V", "GetVisit_Lcom_liveperson_infra_sdkstatemachine_events_ShutDownEvent_Handler")]
			public override unsafe void Visit (global::Com.Liveperson.Infra.Sdkstatemachine.Events.ShutDownEvent p0)
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

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/sdkstatemachine/InfraStateMachine", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InfraStateMachine); }
		}

		protected InfraStateMachine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='InfraStateMachine']/constructor[@name='InfraStateMachine' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InfraStateMachine ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (InfraStateMachine)) {
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

		static Delegate cb_isSDKInitialized;
#pragma warning disable 0169
		static Delegate GetIsSDKInitializedHandler ()
		{
			if (cb_isSDKInitialized == null)
				cb_isSDKInitialized = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSDKInitialized);
			return cb_isSDKInitialized;
		}

		static bool n_IsSDKInitialized (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Sdkstatemachine.InfraStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.InfraStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSDKInitialized;
		}
#pragma warning restore 0169

		static IntPtr id_isSDKInitialized;
		public virtual unsafe bool IsSDKInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='InfraStateMachine']/method[@name='isSDKInitialized' and count(parameter)=0]"
			[Register ("isSDKInitialized", "()Z", "GetIsSDKInitializedHandler")]
			get {
				if (id_isSDKInitialized == IntPtr.Zero)
					id_isSDKInitialized = JNIEnv.GetMethodID (class_ref, "isSDKInitialized", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSDKInitialized);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSDKInitialized", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_initSDK_Lcom_liveperson_infra_statemachine_InitProcess_;
#pragma warning disable 0169
		static Delegate GetInitSDK_Lcom_liveperson_infra_statemachine_InitProcess_Handler ()
		{
			if (cb_initSDK_Lcom_liveperson_infra_statemachine_InitProcess_ == null)
				cb_initSDK_Lcom_liveperson_infra_statemachine_InitProcess_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InitSDK_Lcom_liveperson_infra_statemachine_InitProcess_);
			return cb_initSDK_Lcom_liveperson_infra_statemachine_InitProcess_;
		}

		static void n_InitSDK_Lcom_liveperson_infra_statemachine_InitProcess_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Sdkstatemachine.InfraStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.InfraStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.InitProcess p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.InitProcess> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InitSDK (p0);
		}
#pragma warning restore 0169

		static IntPtr id_initSDK_Lcom_liveperson_infra_statemachine_InitProcess_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='InfraStateMachine']/method[@name='initSDK' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.InitProcess']]"
		[Register ("initSDK", "(Lcom/liveperson/infra/statemachine/InitProcess;)V", "GetInitSDK_Lcom_liveperson_infra_statemachine_InitProcess_Handler")]
		public virtual unsafe void InitSDK (global::Com.Liveperson.Infra.Statemachine.InitProcess p0)
		{
			if (id_initSDK_Lcom_liveperson_infra_statemachine_InitProcess_ == IntPtr.Zero)
				id_initSDK_Lcom_liveperson_infra_statemachine_InitProcess_ = JNIEnv.GetMethodID (class_ref, "initSDK", "(Lcom/liveperson/infra/statemachine/InitProcess;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initSDK_Lcom_liveperson_infra_statemachine_InitProcess_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initSDK", "(Lcom/liveperson/infra/statemachine/InitProcess;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_logoutSDK_Lcom_liveperson_infra_statemachine_LogoutProcess_;
#pragma warning disable 0169
		static Delegate GetLogoutSDK_Lcom_liveperson_infra_statemachine_LogoutProcess_Handler ()
		{
			if (cb_logoutSDK_Lcom_liveperson_infra_statemachine_LogoutProcess_ == null)
				cb_logoutSDK_Lcom_liveperson_infra_statemachine_LogoutProcess_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LogoutSDK_Lcom_liveperson_infra_statemachine_LogoutProcess_);
			return cb_logoutSDK_Lcom_liveperson_infra_statemachine_LogoutProcess_;
		}

		static void n_LogoutSDK_Lcom_liveperson_infra_statemachine_LogoutProcess_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Sdkstatemachine.InfraStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.InfraStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.LogoutProcess p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.LogoutProcess> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LogoutSDK (p0);
		}
#pragma warning restore 0169

		static IntPtr id_logoutSDK_Lcom_liveperson_infra_statemachine_LogoutProcess_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='InfraStateMachine']/method[@name='logoutSDK' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.LogoutProcess']]"
		[Register ("logoutSDK", "(Lcom/liveperson/infra/statemachine/LogoutProcess;)V", "GetLogoutSDK_Lcom_liveperson_infra_statemachine_LogoutProcess_Handler")]
		public virtual unsafe void LogoutSDK (global::Com.Liveperson.Infra.Statemachine.LogoutProcess p0)
		{
			if (id_logoutSDK_Lcom_liveperson_infra_statemachine_LogoutProcess_ == IntPtr.Zero)
				id_logoutSDK_Lcom_liveperson_infra_statemachine_LogoutProcess_ = JNIEnv.GetMethodID (class_ref, "logoutSDK", "(Lcom/liveperson/infra/statemachine/LogoutProcess;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_logoutSDK_Lcom_liveperson_infra_statemachine_LogoutProcess_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logoutSDK", "(Lcom/liveperson/infra/statemachine/LogoutProcess;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_shutDownSDK_Lcom_liveperson_infra_statemachine_ShutDownProcess_;
#pragma warning disable 0169
		static Delegate GetShutDownSDK_Lcom_liveperson_infra_statemachine_ShutDownProcess_Handler ()
		{
			if (cb_shutDownSDK_Lcom_liveperson_infra_statemachine_ShutDownProcess_ == null)
				cb_shutDownSDK_Lcom_liveperson_infra_statemachine_ShutDownProcess_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShutDownSDK_Lcom_liveperson_infra_statemachine_ShutDownProcess_);
			return cb_shutDownSDK_Lcom_liveperson_infra_statemachine_ShutDownProcess_;
		}

		static void n_ShutDownSDK_Lcom_liveperson_infra_statemachine_ShutDownProcess_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Sdkstatemachine.InfraStateMachine __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Sdkstatemachine.InfraStateMachine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.ShutDownProcess p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.ShutDownProcess> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShutDownSDK (p0);
		}
#pragma warning restore 0169

		static IntPtr id_shutDownSDK_Lcom_liveperson_infra_statemachine_ShutDownProcess_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.sdkstatemachine']/class[@name='InfraStateMachine']/method[@name='shutDownSDK' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.ShutDownProcess']]"
		[Register ("shutDownSDK", "(Lcom/liveperson/infra/statemachine/ShutDownProcess;)V", "GetShutDownSDK_Lcom_liveperson_infra_statemachine_ShutDownProcess_Handler")]
		public virtual unsafe void ShutDownSDK (global::Com.Liveperson.Infra.Statemachine.ShutDownProcess p0)
		{
			if (id_shutDownSDK_Lcom_liveperson_infra_statemachine_ShutDownProcess_ == IntPtr.Zero)
				id_shutDownSDK_Lcom_liveperson_infra_statemachine_ShutDownProcess_ = JNIEnv.GetMethodID (class_ref, "shutDownSDK", "(Lcom/liveperson/infra/statemachine/ShutDownProcess;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutDownSDK_Lcom_liveperson_infra_statemachine_ShutDownProcess_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shutDownSDK", "(Lcom/liveperson/infra/statemachine/ShutDownProcess;)V"), __args);
			} finally {
			}
		}

	}
}
