using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsSystemMaskedViewHolder']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsSystemMaskedViewHolder", DoNotGenerateAcw=true)]
	public partial class AmsSystemMaskedViewHolder : global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.MiddleViewHolder, global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.IAmsViewHolder {


		static IntPtr mMessageSequence_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsSystemMaskedViewHolder']/field[@name='mMessageSequence']"
		[Register ("mMessageSequence")]
		protected long MMessageSequence {
			get {
				if (mMessageSequence_jfieldId == IntPtr.Zero)
					mMessageSequence_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessageSequence", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, mMessageSequence_jfieldId);
			}
			set {
				if (mMessageSequence_jfieldId == IntPtr.Zero)
					mMessageSequence_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessageSequence", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMessageSequence_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsSystemMaskedViewHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsSystemMaskedViewHolder); }
		}

		protected AmsSystemMaskedViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsSystemMaskedViewHolder']/constructor[@name='AmsSystemMaskedViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/view/View;)V", "")]
		public unsafe AmsSystemMaskedViewHolder (global::Android.Views.View p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AmsSystemMaskedViewHolder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/view/View;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/view/View;)V", __args);
					return;
				}

				if (id_ctor_Landroid_view_View_ == IntPtr.Zero)
					id_ctor_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_view_View_, __args);
			} finally {
			}
		}

		static Delegate cb_getMessageSequence;
#pragma warning disable 0169
		static Delegate GetGetMessageSequenceHandler ()
		{
			if (cb_getMessageSequence == null)
				cb_getMessageSequence = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMessageSequence);
			return cb_getMessageSequence;
		}

		static long n_GetMessageSequence (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsSystemMaskedViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsSystemMaskedViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageSequence;
		}
#pragma warning restore 0169

		static Delegate cb_setMessageSequence_J;
#pragma warning disable 0169
		static Delegate GetSetMessageSequence_JHandler ()
		{
			if (cb_setMessageSequence_J == null)
				cb_setMessageSequence_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetMessageSequence_J);
			return cb_setMessageSequence_J;
		}

		static void n_SetMessageSequence_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsSystemMaskedViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsSystemMaskedViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MessageSequence = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageSequence;
		static IntPtr id_setMessageSequence_J;
		public virtual unsafe long MessageSequence {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsSystemMaskedViewHolder']/method[@name='getMessageSequence' and count(parameter)=0]"
			[Register ("getMessageSequence", "()J", "GetGetMessageSequenceHandler")]
			get {
				if (id_getMessageSequence == IntPtr.Zero)
					id_getMessageSequence = JNIEnv.GetMethodID (class_ref, "getMessageSequence", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getMessageSequence);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageSequence", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsSystemMaskedViewHolder']/method[@name='setMessageSequence' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setMessageSequence", "(J)V", "GetSetMessageSequence_JHandler")]
			set {
				if (id_setMessageSequence_J == IntPtr.Zero)
					id_setMessageSequence_J = JNIEnv.GetMethodID (class_ref, "setMessageSequence", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessageSequence_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageSequence", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_applyColors;
#pragma warning disable 0169
		static Delegate GetApplyColorsHandler ()
		{
			if (cb_applyColors == null)
				cb_applyColors = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ApplyColors);
			return cb_applyColors;
		}

		static void n_ApplyColors (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsSystemMaskedViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsSystemMaskedViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ApplyColors ();
		}
#pragma warning restore 0169

		static IntPtr id_applyColors;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsSystemMaskedViewHolder']/method[@name='applyColors' and count(parameter)=0]"
		[Register ("applyColors", "()V", "GetApplyColorsHandler")]
		public virtual unsafe void ApplyColors ()
		{
			if (id_applyColors == IntPtr.Zero)
				id_applyColors = JNIEnv.GetMethodID (class_ref, "applyColors", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_applyColors);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "applyColors", "()V"));
			} finally {
			}
		}

	}
}
