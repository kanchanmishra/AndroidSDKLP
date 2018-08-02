using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsSystemResolvedViewHolder']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsSystemResolvedViewHolder", DoNotGenerateAcw=true)]
	public partial class AmsSystemResolvedViewHolder : global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.MiddleViewHolder, global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.IAmsViewHolder {


		static IntPtr mMessageSequence_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsSystemResolvedViewHolder']/field[@name='mMessageSequence']"
		[Register ("mMessageSequence")]
		protected int MMessageSequence {
			get {
				if (mMessageSequence_jfieldId == IntPtr.Zero)
					mMessageSequence_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessageSequence", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mMessageSequence_jfieldId);
			}
			set {
				if (mMessageSequence_jfieldId == IntPtr.Zero)
					mMessageSequence_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessageSequence", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMessageSequence_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsSystemResolvedViewHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsSystemResolvedViewHolder); }
		}

		protected AmsSystemResolvedViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsSystemResolvedViewHolder']/constructor[@name='AmsSystemResolvedViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/view/View;)V", "")]
		public unsafe AmsSystemResolvedViewHolder (global::Android.Views.View p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AmsSystemResolvedViewHolder)) {
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
				cb_getMessageSequence = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMessageSequence);
			return cb_getMessageSequence;
		}

		static int n_GetMessageSequence (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsSystemResolvedViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsSystemResolvedViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageSequence;
		}
#pragma warning restore 0169

		static Delegate cb_setMessageSequence_I;
#pragma warning disable 0169
		static Delegate GetSetMessageSequence_IHandler ()
		{
			if (cb_setMessageSequence_I == null)
				cb_setMessageSequence_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMessageSequence_I);
			return cb_setMessageSequence_I;
		}

		static void n_SetMessageSequence_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsSystemResolvedViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsSystemResolvedViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MessageSequence = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageSequence;
		static IntPtr id_setMessageSequence_I;
		public virtual unsafe int MessageSequence {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsSystemResolvedViewHolder']/method[@name='getMessageSequence' and count(parameter)=0]"
			[Register ("getMessageSequence", "()I", "GetGetMessageSequenceHandler")]
			get {
				if (id_getMessageSequence == IntPtr.Zero)
					id_getMessageSequence = JNIEnv.GetMethodID (class_ref, "getMessageSequence", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMessageSequence);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageSequence", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsSystemResolvedViewHolder']/method[@name='setMessageSequence' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMessageSequence", "(I)V", "GetSetMessageSequence_IHandler")]
			set {
				if (id_setMessageSequence_I == IntPtr.Zero)
					id_setMessageSequence_I = JNIEnv.GetMethodID (class_ref, "setMessageSequence", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessageSequence_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageSequence", "(I)V"), __args);
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
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsSystemResolvedViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsSystemResolvedViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ApplyColors ();
		}
#pragma warning restore 0169

		static IntPtr id_applyColors;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsSystemResolvedViewHolder']/method[@name='applyColors' and count(parameter)=0]"
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

		static Delegate cb_hideSystemMessageView_ZZ;
#pragma warning disable 0169
		static Delegate GetHideSystemMessageView_ZZHandler ()
		{
			if (cb_hideSystemMessageView_ZZ == null)
				cb_hideSystemMessageView_ZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, bool>) n_HideSystemMessageView_ZZ);
			return cb_hideSystemMessageView_ZZ;
		}

		static void n_HideSystemMessageView_ZZ (IntPtr jnienv, IntPtr native__this, bool p0, bool p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsSystemResolvedViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsSystemResolvedViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideSystemMessageView (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_hideSystemMessageView_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsSystemResolvedViewHolder']/method[@name='hideSystemMessageView' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("hideSystemMessageView", "(ZZ)V", "GetHideSystemMessageView_ZZHandler")]
		public virtual unsafe void HideSystemMessageView (bool p0, bool p1)
		{
			if (id_hideSystemMessageView_ZZ == IntPtr.Zero)
				id_hideSystemMessageView_ZZ = JNIEnv.GetMethodID (class_ref, "hideSystemMessageView", "(ZZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hideSystemMessageView_ZZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hideSystemMessageView", "(ZZ)V"), __args);
			} finally {
			}
		}

	}
}
