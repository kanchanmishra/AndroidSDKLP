using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentViewHolder']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsAgentViewHolder", DoNotGenerateAcw=true)]
	public partial class AmsAgentViewHolder : global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.StartViewHolder, global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.IAmsViewHolder {


		static IntPtr mAgentAvatar_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentViewHolder']/field[@name='mAgentAvatar']"
		[Register ("mAgentAvatar")]
		protected global::Android.Widget.ImageView MAgentAvatar {
			get {
				if (mAgentAvatar_jfieldId == IntPtr.Zero)
					mAgentAvatar_jfieldId = JNIEnv.GetFieldID (class_ref, "mAgentAvatar", "Landroid/widget/ImageView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAgentAvatar_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAgentAvatar_jfieldId == IntPtr.Zero)
					mAgentAvatar_jfieldId = JNIEnv.GetFieldID (class_ref, "mAgentAvatar", "Landroid/widget/ImageView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAgentAvatar_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mAgentNickName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentViewHolder']/field[@name='mAgentNickName']"
		[Register ("mAgentNickName")]
		protected string MAgentNickName {
			get {
				if (mAgentNickName_jfieldId == IntPtr.Zero)
					mAgentNickName_jfieldId = JNIEnv.GetFieldID (class_ref, "mAgentNickName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAgentNickName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAgentNickName_jfieldId == IntPtr.Zero)
					mAgentNickName_jfieldId = JNIEnv.GetFieldID (class_ref, "mAgentNickName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAgentNickName_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsAgentViewHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsAgentViewHolder); }
		}

		protected AmsAgentViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentViewHolder']/constructor[@name='AmsAgentViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/view/View;)V", "")]
		public unsafe AmsAgentViewHolder (global::Android.Views.View p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AmsAgentViewHolder)) {
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
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ApplyColors ();
		}
#pragma warning restore 0169

		static IntPtr id_applyColors;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentViewHolder']/method[@name='applyColors' and count(parameter)=0]"
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

		static Delegate cb_setAgentAvatar_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAgentAvatar_Ljava_lang_String_Handler ()
		{
			if (cb_setAgentAvatar_Ljava_lang_String_ == null)
				cb_setAgentAvatar_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAgentAvatar_Ljava_lang_String_);
			return cb_setAgentAvatar_Ljava_lang_String_;
		}

		static void n_SetAgentAvatar_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAgentAvatar (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAgentAvatar_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentViewHolder']/method[@name='setAgentAvatar' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAgentAvatar", "(Ljava/lang/String;)V", "GetSetAgentAvatar_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAgentAvatar (string p0)
		{
			if (id_setAgentAvatar_Ljava_lang_String_ == IntPtr.Zero)
				id_setAgentAvatar_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAgentAvatar", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAgentAvatar_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAgentAvatar", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setAgentNickName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAgentNickName_Ljava_lang_String_Handler ()
		{
			if (cb_setAgentNickName_Ljava_lang_String_ == null)
				cb_setAgentNickName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAgentNickName_Ljava_lang_String_);
			return cb_setAgentNickName_Ljava_lang_String_;
		}

		static void n_SetAgentNickName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAgentNickName (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAgentNickName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentViewHolder']/method[@name='setAgentNickName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAgentNickName", "(Ljava/lang/String;)V", "GetSetAgentNickName_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAgentNickName (string p0)
		{
			if (id_setAgentNickName_Ljava_lang_String_ == IntPtr.Zero)
				id_setAgentNickName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAgentNickName", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAgentNickName_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAgentNickName", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setMessageText_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSetMessageText_Ljava_lang_String_ZHandler ()
		{
			if (cb_setMessageText_Ljava_lang_String_Z == null)
				cb_setMessageText_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetMessageText_Ljava_lang_String_Z);
			return cb_setMessageText_Ljava_lang_String_Z;
		}

		static void n_SetMessageText_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMessageText (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setMessageText_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentViewHolder']/method[@name='setMessageText' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("setMessageText", "(Ljava/lang/String;Z)V", "GetSetMessageText_Ljava_lang_String_ZHandler")]
		public virtual unsafe void SetMessageText (string p0, bool p1)
		{
			if (id_setMessageText_Ljava_lang_String_Z == IntPtr.Zero)
				id_setMessageText_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "setMessageText", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessageText_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageText", "(Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setOnAgentAvatarClicked_Landroid_view_View_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnAgentAvatarClicked_Landroid_view_View_OnClickListener_Handler ()
		{
			if (cb_setOnAgentAvatarClicked_Landroid_view_View_OnClickListener_ == null)
				cb_setOnAgentAvatarClicked_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnAgentAvatarClicked_Landroid_view_View_OnClickListener_);
			return cb_setOnAgentAvatarClicked_Landroid_view_View_OnClickListener_;
		}

		static void n_SetOnAgentAvatarClicked_Landroid_view_View_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View.IOnClickListener p0 = (global::Android.Views.View.IOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnAgentAvatarClicked (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnAgentAvatarClicked_Landroid_view_View_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentViewHolder']/method[@name='setOnAgentAvatarClicked' and count(parameter)=1 and parameter[1][@type='android.view.View.OnClickListener']]"
		[Register ("setOnAgentAvatarClicked", "(Landroid/view/View$OnClickListener;)V", "GetSetOnAgentAvatarClicked_Landroid_view_View_OnClickListener_Handler")]
		public virtual unsafe void SetOnAgentAvatarClicked (global::Android.Views.View.IOnClickListener p0)
		{
			if (id_setOnAgentAvatarClicked_Landroid_view_View_OnClickListener_ == IntPtr.Zero)
				id_setOnAgentAvatarClicked_Landroid_view_View_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnAgentAvatarClicked", "(Landroid/view/View$OnClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnAgentAvatarClicked_Landroid_view_View_OnClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnAgentAvatarClicked", "(Landroid/view/View$OnClickListener;)V"), __args);
			} finally {
			}
		}

	}
}
