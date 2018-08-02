using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/AmsEnterMessage", DoNotGenerateAcw=true)]
	public partial class AmsEnterMessage : global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage, global::Com.Liveperson.Infra.Controller.IAudioRecordable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage']/field[@name='MAX_RECORD_TIME_MS']"
		[Register ("MAX_RECORD_TIME_MS")]
		public const int MaxRecordTimeMs = (int) 120000;

		static IntPtr mHandler_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage']/field[@name='mHandler']"
		[Register ("mHandler")]
		public global::Android.OS.Handler MHandler {
			get {
				if (mHandler_jfieldId == IntPtr.Zero)
					mHandler_jfieldId = JNIEnv.GetFieldID (class_ref, "mHandler", "Landroid/os/Handler;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mHandler_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mHandler_jfieldId == IntPtr.Zero)
					mHandler_jfieldId = JNIEnv.GetFieldID (class_ref, "mHandler", "Landroid/os/Handler;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mHandler_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mMaxRecordTimeMs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage']/field[@name='mMaxRecordTimeMs']"
		[Register ("mMaxRecordTimeMs")]
		protected int MMaxRecordTimeMs {
			get {
				if (mMaxRecordTimeMs_jfieldId == IntPtr.Zero)
					mMaxRecordTimeMs_jfieldId = JNIEnv.GetFieldID (class_ref, "mMaxRecordTimeMs", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mMaxRecordTimeMs_jfieldId);
			}
			set {
				if (mMaxRecordTimeMs_jfieldId == IntPtr.Zero)
					mMaxRecordTimeMs_jfieldId = JNIEnv.GetFieldID (class_ref, "mMaxRecordTimeMs", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMaxRecordTimeMs_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mMaxRecordTimeTextView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage']/field[@name='mMaxRecordTimeTextView']"
		[Register ("mMaxRecordTimeTextView")]
		protected global::Android.Widget.TextView MMaxRecordTimeTextView {
			get {
				if (mMaxRecordTimeTextView_jfieldId == IntPtr.Zero)
					mMaxRecordTimeTextView_jfieldId = JNIEnv.GetFieldID (class_ref, "mMaxRecordTimeTextView", "Landroid/widget/TextView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMaxRecordTimeTextView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMaxRecordTimeTextView_jfieldId == IntPtr.Zero)
					mMaxRecordTimeTextView_jfieldId = JNIEnv.GetFieldID (class_ref, "mMaxRecordTimeTextView", "Landroid/widget/TextView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMaxRecordTimeTextView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mMicButton_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage']/field[@name='mMicButton']"
		[Register ("mMicButton")]
		protected global::Android.Widget.ImageButton MMicButton {
			get {
				if (mMicButton_jfieldId == IntPtr.Zero)
					mMicButton_jfieldId = JNIEnv.GetFieldID (class_ref, "mMicButton", "Landroid/widget/ImageButton;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMicButton_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageButton> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMicButton_jfieldId == IntPtr.Zero)
					mMicButton_jfieldId = JNIEnv.GetFieldID (class_ref, "mMicButton", "Landroid/widget/ImageButton;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMicButton_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mMicTooltipWindow_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage']/field[@name='mMicTooltipWindow']"
		[Register ("mMicTooltipWindow")]
		protected global::Com.Liveperson.Infra.UI.View.UI.TooltipWindow MMicTooltipWindow {
			get {
				if (mMicTooltipWindow_jfieldId == IntPtr.Zero)
					mMicTooltipWindow_jfieldId = JNIEnv.GetFieldID (class_ref, "mMicTooltipWindow", "Lcom/liveperson/infra/ui/view/ui/TooltipWindow;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMicTooltipWindow_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.TooltipWindow> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMicTooltipWindow_jfieldId == IntPtr.Zero)
					mMicTooltipWindow_jfieldId = JNIEnv.GetFieldID (class_ref, "mMicTooltipWindow", "Lcom/liveperson/infra/ui/view/ui/TooltipWindow;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMicTooltipWindow_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mRecordProgressBar_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage']/field[@name='mRecordProgressBar']"
		[Register ("mRecordProgressBar")]
		protected global::Android.Widget.ProgressBar MRecordProgressBar {
			get {
				if (mRecordProgressBar_jfieldId == IntPtr.Zero)
					mRecordProgressBar_jfieldId = JNIEnv.GetFieldID (class_ref, "mRecordProgressBar", "Landroid/widget/ProgressBar;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mRecordProgressBar_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ProgressBar> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mRecordProgressBar_jfieldId == IntPtr.Zero)
					mRecordProgressBar_jfieldId = JNIEnv.GetFieldID (class_ref, "mRecordProgressBar", "Landroid/widget/ProgressBar;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mRecordProgressBar_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mRecordProgressTimeTextView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage']/field[@name='mRecordProgressTimeTextView']"
		[Register ("mRecordProgressTimeTextView")]
		protected global::Android.Widget.TextView MRecordProgressTimeTextView {
			get {
				if (mRecordProgressTimeTextView_jfieldId == IntPtr.Zero)
					mRecordProgressTimeTextView_jfieldId = JNIEnv.GetFieldID (class_ref, "mRecordProgressTimeTextView", "Landroid/widget/TextView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mRecordProgressTimeTextView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mRecordProgressTimeTextView_jfieldId == IntPtr.Zero)
					mRecordProgressTimeTextView_jfieldId = JNIEnv.GetFieldID (class_ref, "mRecordProgressTimeTextView", "Landroid/widget/TextView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mRecordProgressTimeTextView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage.RecordingStatus']"
		[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/AmsEnterMessage$RecordingStatus", DoNotGenerateAcw=true)]
		public sealed partial class RecordingStatus : global::Java.Lang.Enum {


			static IntPtr MAX_REACHED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage.RecordingStatus']/field[@name='MAX_REACHED']"
			[Register ("MAX_REACHED")]
			public static global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage.RecordingStatus MaxReached {
				get {
					if (MAX_REACHED_jfieldId == IntPtr.Zero)
						MAX_REACHED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAX_REACHED", "Lcom/liveperson/infra/messaging_ui/uicomponents/AmsEnterMessage$RecordingStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MAX_REACHED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage.RecordingStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RECORDING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage.RecordingStatus']/field[@name='RECORDING']"
			[Register ("RECORDING")]
			public static global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage.RecordingStatus Recording {
				get {
					if (RECORDING_jfieldId == IntPtr.Zero)
						RECORDING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RECORDING", "Lcom/liveperson/infra/messaging_ui/uicomponents/AmsEnterMessage$RecordingStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RECORDING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage.RecordingStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr STOPPED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage.RecordingStatus']/field[@name='STOPPED']"
			[Register ("STOPPED")]
			public static global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage.RecordingStatus Stopped {
				get {
					if (STOPPED_jfieldId == IntPtr.Zero)
						STOPPED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STOPPED", "Lcom/liveperson/infra/messaging_ui/uicomponents/AmsEnterMessage$RecordingStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STOPPED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage.RecordingStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/AmsEnterMessage$RecordingStatus", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RecordingStatus); }
			}

			internal RecordingStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/AmsEnterMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsEnterMessage); }
		}

		protected AmsEnterMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage']/constructor[@name='AmsEnterMessage' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe AmsEnterMessage (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (AmsEnterMessage)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage']/constructor[@name='AmsEnterMessage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe AmsEnterMessage (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (AmsEnterMessage)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage']/constructor[@name='AmsEnterMessage' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AmsEnterMessage (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AmsEnterMessage)) {
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

		static Delegate cb_isRecordingInProgress;
#pragma warning disable 0169
		static Delegate GetIsRecordingInProgressHandler ()
		{
			if (cb_isRecordingInProgress == null)
				cb_isRecordingInProgress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRecordingInProgress);
			return cb_isRecordingInProgress;
		}

		static bool n_IsRecordingInProgress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRecordingInProgress;
		}
#pragma warning restore 0169

		static IntPtr id_isRecordingInProgress;
		protected virtual unsafe bool IsRecordingInProgress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage']/method[@name='isRecordingInProgress' and count(parameter)=0]"
			[Register ("isRecordingInProgress", "()Z", "GetIsRecordingInProgressHandler")]
			get {
				if (id_isRecordingInProgress == IntPtr.Zero)
					id_isRecordingInProgress = JNIEnv.GetMethodID (class_ref, "isRecordingInProgress", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRecordingInProgress);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRecordingInProgress", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_cancelRecording;
#pragma warning disable 0169
		static Delegate GetCancelRecordingHandler ()
		{
			if (cb_cancelRecording == null)
				cb_cancelRecording = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CancelRecording);
			return cb_cancelRecording;
		}

		static void n_CancelRecording (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelRecording ();
		}
#pragma warning restore 0169

		static IntPtr id_cancelRecording;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage']/method[@name='cancelRecording' and count(parameter)=0]"
		[Register ("cancelRecording", "()V", "GetCancelRecordingHandler")]
		public virtual unsafe void CancelRecording ()
		{
			if (id_cancelRecording == IntPtr.Zero)
				id_cancelRecording = JNIEnv.GetMethodID (class_ref, "cancelRecording", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelRecording);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelRecording", "()V"));
			} finally {
			}
		}

		static Delegate cb_changeState_Lcom_liveperson_infra_model_types_ChatState_;
#pragma warning disable 0169
		static Delegate GetChangeState_Lcom_liveperson_infra_model_types_ChatState_Handler ()
		{
			if (cb_changeState_Lcom_liveperson_infra_model_types_ChatState_ == null)
				cb_changeState_Lcom_liveperson_infra_model_types_ChatState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ChangeState_Lcom_liveperson_infra_model_types_ChatState_);
			return cb_changeState_Lcom_liveperson_infra_model_types_ChatState_;
		}

		static void n_ChangeState_Lcom_liveperson_infra_model_types_ChatState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Model.Types.ChatState p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Types.ChatState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChangeState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_changeState_Lcom_liveperson_infra_model_types_ChatState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage']/method[@name='changeState' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.model.types.ChatState']]"
		[Register ("changeState", "(Lcom/liveperson/infra/model/types/ChatState;)V", "GetChangeState_Lcom_liveperson_infra_model_types_ChatState_Handler")]
		protected virtual unsafe void ChangeState (global::Com.Liveperson.Infra.Model.Types.ChatState p0)
		{
			if (id_changeState_Lcom_liveperson_infra_model_types_ChatState_ == IntPtr.Zero)
				id_changeState_Lcom_liveperson_infra_model_types_ChatState_ = JNIEnv.GetMethodID (class_ref, "changeState", "(Lcom/liveperson/infra/model/types/ChatState;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_changeState_Lcom_liveperson_infra_model_types_ChatState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "changeState", "(Lcom/liveperson/infra/model/types/ChatState;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_enableMicButtonTooltips_Z;
#pragma warning disable 0169
		static Delegate GetEnableMicButtonTooltips_ZHandler ()
		{
			if (cb_enableMicButtonTooltips_Z == null)
				cb_enableMicButtonTooltips_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_EnableMicButtonTooltips_Z);
			return cb_enableMicButtonTooltips_Z;
		}

		static void n_EnableMicButtonTooltips_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableMicButtonTooltips (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enableMicButtonTooltips_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage']/method[@name='enableMicButtonTooltips' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableMicButtonTooltips", "(Z)V", "GetEnableMicButtonTooltips_ZHandler")]
		public virtual unsafe void EnableMicButtonTooltips (bool p0)
		{
			if (id_enableMicButtonTooltips_Z == IntPtr.Zero)
				id_enableMicButtonTooltips_Z = JNIEnv.GetMethodID (class_ref, "enableMicButtonTooltips", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enableMicButtonTooltips_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableMicButtonTooltips", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onAfterChangedText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAfterChangedText_Ljava_lang_String_Handler ()
		{
			if (cb_onAfterChangedText_Ljava_lang_String_ == null)
				cb_onAfterChangedText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAfterChangedText_Ljava_lang_String_);
			return cb_onAfterChangedText_Ljava_lang_String_;
		}

		static void n_OnAfterChangedText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAfterChangedText (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onAfterChangedText_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage']/method[@name='onAfterChangedText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onAfterChangedText", "(Ljava/lang/String;)V", "GetOnAfterChangedText_Ljava_lang_String_Handler")]
		protected override unsafe void OnAfterChangedText (string p0)
		{
			if (id_onAfterChangedText_Ljava_lang_String_ == IntPtr.Zero)
				id_onAfterChangedText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAfterChangedText", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAfterChangedText_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAfterChangedText", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onBeforeChangedText;
#pragma warning disable 0169
		static Delegate GetOnBeforeChangedTextHandler ()
		{
			if (cb_onBeforeChangedText == null)
				cb_onBeforeChangedText = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBeforeChangedText);
			return cb_onBeforeChangedText;
		}

		static void n_OnBeforeChangedText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBeforeChangedText ();
		}
#pragma warning restore 0169

		static IntPtr id_onBeforeChangedText;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage']/method[@name='onBeforeChangedText' and count(parameter)=0]"
		[Register ("onBeforeChangedText", "()V", "GetOnBeforeChangedTextHandler")]
		protected override unsafe void OnBeforeChangedText ()
		{
			if (id_onBeforeChangedText == IntPtr.Zero)
				id_onBeforeChangedText = JNIEnv.GetMethodID (class_ref, "onBeforeChangedText", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBeforeChangedText);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBeforeChangedText", "()V"));
			} finally {
			}
		}

		static Delegate cb_onCancelRecording;
#pragma warning disable 0169
		static Delegate GetOnCancelRecordingHandler ()
		{
			if (cb_onCancelRecording == null)
				cb_onCancelRecording = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCancelRecording);
			return cb_onCancelRecording;
		}

		static void n_OnCancelRecording (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCancelRecording ();
		}
#pragma warning restore 0169

		static IntPtr id_onCancelRecording;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage']/method[@name='onCancelRecording' and count(parameter)=0]"
		[Register ("onCancelRecording", "()V", "GetOnCancelRecordingHandler")]
		protected virtual unsafe void OnCancelRecording ()
		{
			if (id_onCancelRecording == IntPtr.Zero)
				id_onCancelRecording = JNIEnv.GetMethodID (class_ref, "onCancelRecording", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCancelRecording);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCancelRecording", "()V"));
			} finally {
			}
		}

		static Delegate cb_onHasText_Z;
#pragma warning disable 0169
		static Delegate GetOnHasText_ZHandler ()
		{
			if (cb_onHasText_Z == null)
				cb_onHasText_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnHasText_Z);
			return cb_onHasText_Z;
		}

		static void n_OnHasText_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnHasText (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onHasText_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage']/method[@name='onHasText' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onHasText", "(Z)V", "GetOnHasText_ZHandler")]
		protected override unsafe void OnHasText (bool p0)
		{
			if (id_onHasText_Z == IntPtr.Zero)
				id_onHasText_Z = JNIEnv.GetMethodID (class_ref, "onHasText", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHasText_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onHasText", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onRecordVoice;
#pragma warning disable 0169
		static Delegate GetOnRecordVoiceHandler ()
		{
			if (cb_onRecordVoice == null)
				cb_onRecordVoice = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRecordVoice);
			return cb_onRecordVoice;
		}

		static void n_OnRecordVoice (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRecordVoice ();
		}
#pragma warning restore 0169

		static IntPtr id_onRecordVoice;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage']/method[@name='onRecordVoice' and count(parameter)=0]"
		[Register ("onRecordVoice", "()V", "GetOnRecordVoiceHandler")]
		protected virtual unsafe void OnRecordVoice ()
		{
			if (id_onRecordVoice == IntPtr.Zero)
				id_onRecordVoice = JNIEnv.GetMethodID (class_ref, "onRecordVoice", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRecordVoice);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRecordVoice", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Ljava_lang_String_Handler ()
		{
			if (cb_sendMessage_Ljava_lang_String_ == null)
				cb_sendMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendMessage_Ljava_lang_String_);
			return cb_sendMessage_Ljava_lang_String_;
		}

		static void n_SendMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage']/method[@name='sendMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sendMessage", "(Ljava/lang/String;)V", "GetSendMessage_Ljava_lang_String_Handler")]
		protected override unsafe void SendMessage (string p0)
		{
			if (id_sendMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_sendMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendMessage", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_sendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_sendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_sendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.SendMessageWithURL (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_sendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage']/method[@name='sendMessageWithURL' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("sendMessageWithURL", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected override unsafe void SendMessageWithURL (string p0, string p1, string p2, string p3, string p4, string p5)
		{
			if (id_sendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendMessageWithURL", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendMessageWithURL", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_shouldUpdateSendButton;
#pragma warning disable 0169
		static Delegate GetShouldUpdateSendButtonHandler ()
		{
			if (cb_shouldUpdateSendButton == null)
				cb_shouldUpdateSendButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShouldUpdateSendButton);
			return cb_shouldUpdateSendButton;
		}

		static bool n_ShouldUpdateSendButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldUpdateSendButton ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldUpdateSendButton;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='AmsEnterMessage']/method[@name='shouldUpdateSendButton' and count(parameter)=0]"
		[Register ("shouldUpdateSendButton", "()Z", "GetShouldUpdateSendButtonHandler")]
		protected override unsafe bool ShouldUpdateSendButton ()
		{
			if (id_shouldUpdateSendButton == IntPtr.Zero)
				id_shouldUpdateSendButton = JNIEnv.GetMethodID (class_ref, "shouldUpdateSendButton", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_shouldUpdateSendButton);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldUpdateSendButton", "()Z"));
			} finally {
			}
		}

	}
}
