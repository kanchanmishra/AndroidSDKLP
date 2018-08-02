using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Adapter.Viewholder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='BaseViewHolder']"
	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder", DoNotGenerateAcw=true)]
	public abstract partial class BaseViewHolder : global::Android.Support.V7.Widget.RecyclerView.ViewHolder {


		static IntPtr mMessageTextView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='BaseViewHolder']/field[@name='mMessageTextView']"
		[Register ("mMessageTextView")]
		protected global::Android.Widget.TextView MMessageTextView {
			get {
				if (mMessageTextView_jfieldId == IntPtr.Zero)
					mMessageTextView_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessageTextView", "Landroid/widget/TextView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMessageTextView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMessageTextView_jfieldId == IntPtr.Zero)
					mMessageTextView_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessageTextView", "Landroid/widget/TextView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMessageTextView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mTimestampAccessibilityString_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='BaseViewHolder']/field[@name='mTimestampAccessibilityString']"
		[Register ("mTimestampAccessibilityString")]
		protected string MTimestampAccessibilityString {
			get {
				if (mTimestampAccessibilityString_jfieldId == IntPtr.Zero)
					mTimestampAccessibilityString_jfieldId = JNIEnv.GetFieldID (class_ref, "mTimestampAccessibilityString", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mTimestampAccessibilityString_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTimestampAccessibilityString_jfieldId == IntPtr.Zero)
					mTimestampAccessibilityString_jfieldId = JNIEnv.GetFieldID (class_ref, "mTimestampAccessibilityString", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mTimestampAccessibilityString_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseViewHolder); }
		}

		protected BaseViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='BaseViewHolder']/constructor[@name='BaseViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/view/View;)V", "")]
		public unsafe BaseViewHolder (global::Android.Views.View p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (BaseViewHolder)) {
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

		static Delegate cb_getTempPosition;
#pragma warning disable 0169
		static Delegate GetGetTempPositionHandler ()
		{
			if (cb_getTempPosition == null)
				cb_getTempPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTempPosition);
			return cb_getTempPosition;
		}

		static int n_GetTempPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TempPosition;
		}
#pragma warning restore 0169

		static Delegate cb_setTempPosition_I;
#pragma warning disable 0169
		static Delegate GetSetTempPosition_IHandler ()
		{
			if (cb_setTempPosition_I == null)
				cb_setTempPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTempPosition_I);
			return cb_setTempPosition_I;
		}

		static void n_SetTempPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TempPosition = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTempPosition;
		static IntPtr id_setTempPosition_I;
		public virtual unsafe int TempPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='BaseViewHolder']/method[@name='getTempPosition' and count(parameter)=0]"
			[Register ("getTempPosition", "()I", "GetGetTempPositionHandler")]
			get {
				if (id_getTempPosition == IntPtr.Zero)
					id_getTempPosition = JNIEnv.GetMethodID (class_ref, "getTempPosition", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTempPosition);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTempPosition", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='BaseViewHolder']/method[@name='setTempPosition' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTempPosition", "(I)V", "GetSetTempPosition_IHandler")]
			set {
				if (id_setTempPosition_I == IntPtr.Zero)
					id_setTempPosition_I = JNIEnv.GetMethodID (class_ref, "setTempPosition", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTempPosition_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTempPosition", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTextToCopy;
#pragma warning disable 0169
		static Delegate GetGetTextToCopyHandler ()
		{
			if (cb_getTextToCopy == null)
				cb_getTextToCopy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextToCopy);
			return cb_getTextToCopy;
		}

		static IntPtr n_GetTextToCopy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TextToCopy);
		}
#pragma warning restore 0169

		static IntPtr id_getTextToCopy;
		public virtual unsafe string TextToCopy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='BaseViewHolder']/method[@name='getTextToCopy' and count(parameter)=0]"
			[Register ("getTextToCopy", "()Ljava/lang/String;", "GetGetTextToCopyHandler")]
			get {
				if (id_getTextToCopy == IntPtr.Zero)
					id_getTextToCopy = JNIEnv.GetMethodID (class_ref, "getTextToCopy", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTextToCopy), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextToCopy", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_applyChanges_Landroid_os_Bundle_Lcom_liveperson_infra_model_Message_;
#pragma warning disable 0169
		static Delegate GetApplyChanges_Landroid_os_Bundle_Lcom_liveperson_infra_model_Message_Handler ()
		{
			if (cb_applyChanges_Landroid_os_Bundle_Lcom_liveperson_infra_model_Message_ == null)
				cb_applyChanges_Landroid_os_Bundle_Lcom_liveperson_infra_model_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ApplyChanges_Landroid_os_Bundle_Lcom_liveperson_infra_model_Message_);
			return cb_applyChanges_Landroid_os_Bundle_Lcom_liveperson_infra_model_Message_;
		}

		static void n_ApplyChanges_Landroid_os_Bundle_Lcom_liveperson_infra_model_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Model.Message p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Message> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ApplyChanges (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_applyChanges_Landroid_os_Bundle_Lcom_liveperson_infra_model_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='BaseViewHolder']/method[@name='applyChanges' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.liveperson.infra.model.Message']]"
		[Register ("applyChanges", "(Landroid/os/Bundle;Lcom/liveperson/infra/model/Message;)V", "GetApplyChanges_Landroid_os_Bundle_Lcom_liveperson_infra_model_Message_Handler")]
		public virtual unsafe void ApplyChanges (global::Android.OS.Bundle p0, global::Com.Liveperson.Infra.Model.Message p1)
		{
			if (id_applyChanges_Landroid_os_Bundle_Lcom_liveperson_infra_model_Message_ == IntPtr.Zero)
				id_applyChanges_Landroid_os_Bundle_Lcom_liveperson_infra_model_Message_ = JNIEnv.GetMethodID (class_ref, "applyChanges", "(Landroid/os/Bundle;Lcom/liveperson/infra/model/Message;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_applyChanges_Landroid_os_Bundle_Lcom_liveperson_infra_model_Message_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "applyChanges", "(Landroid/os/Bundle;Lcom/liveperson/infra/model/Message;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getAccessibilityDateTimeFormat_J;
#pragma warning disable 0169
		static Delegate GetGetAccessibilityDateTimeFormat_JHandler ()
		{
			if (cb_getAccessibilityDateTimeFormat_J == null)
				cb_getAccessibilityDateTimeFormat_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_GetAccessibilityDateTimeFormat_J);
			return cb_getAccessibilityDateTimeFormat_J;
		}

		static IntPtr n_GetAccessibilityDateTimeFormat_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetAccessibilityDateTimeFormat (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getAccessibilityDateTimeFormat_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='BaseViewHolder']/method[@name='getAccessibilityDateTimeFormat' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getAccessibilityDateTimeFormat", "(J)Ljava/lang/String;", "GetGetAccessibilityDateTimeFormat_JHandler")]
		protected virtual unsafe string GetAccessibilityDateTimeFormat (long p0)
		{
			if (id_getAccessibilityDateTimeFormat_J == IntPtr.Zero)
				id_getAccessibilityDateTimeFormat_J = JNIEnv.GetMethodID (class_ref, "getAccessibilityDateTimeFormat", "(J)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccessibilityDateTimeFormat_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccessibilityDateTimeFormat", "(J)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getTimeFormat_J;
#pragma warning disable 0169
		static Delegate GetGetTimeFormat_JHandler ()
		{
			if (cb_getTimeFormat_J == null)
				cb_getTimeFormat_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_GetTimeFormat_J);
			return cb_getTimeFormat_J;
		}

		static IntPtr n_GetTimeFormat_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetTimeFormat (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getTimeFormat_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='BaseViewHolder']/method[@name='getTimeFormat' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getTimeFormat", "(J)Ljava/lang/String;", "GetGetTimeFormat_JHandler")]
		protected virtual unsafe string GetTimeFormat (long p0)
		{
			if (id_getTimeFormat_J == IntPtr.Zero)
				id_getTimeFormat_J = JNIEnv.GetMethodID (class_ref, "getTimeFormat", "(J)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTimeFormat_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeFormat", "(J)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_linkifyText_Landroid_widget_TextView_;
#pragma warning disable 0169
		static Delegate GetLinkifyText_Landroid_widget_TextView_Handler ()
		{
			if (cb_linkifyText_Landroid_widget_TextView_ == null)
				cb_linkifyText_Landroid_widget_TextView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_LinkifyText_Landroid_widget_TextView_);
			return cb_linkifyText_Landroid_widget_TextView_;
		}

		static bool n_LinkifyText_Landroid_widget_TextView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.TextView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.LinkifyText (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_linkifyText_Landroid_widget_TextView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='BaseViewHolder']/method[@name='linkifyText' and count(parameter)=1 and parameter[1][@type='android.widget.TextView']]"
		[Register ("linkifyText", "(Landroid/widget/TextView;)Z", "GetLinkifyText_Landroid_widget_TextView_Handler")]
		protected virtual unsafe bool LinkifyText (global::Android.Widget.TextView p0)
		{
			if (id_linkifyText_Landroid_widget_TextView_ == IntPtr.Zero)
				id_linkifyText_Landroid_widget_TextView_ = JNIEnv.GetMethodID (class_ref, "linkifyText", "(Landroid/widget/TextView;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_linkifyText_Landroid_widget_TextView_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "linkifyText", "(Landroid/widget/TextView;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onBind;
#pragma warning disable 0169
		static Delegate GetOnBindHandler ()
		{
			if (cb_onBind == null)
				cb_onBind = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBind);
			return cb_onBind;
		}

		static void n_OnBind (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBind ();
		}
#pragma warning restore 0169

		static IntPtr id_onBind;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='BaseViewHolder']/method[@name='onBind' and count(parameter)=0]"
		[Register ("onBind", "()V", "GetOnBindHandler")]
		public virtual unsafe void OnBind ()
		{
			if (id_onBind == IntPtr.Zero)
				id_onBind = JNIEnv.GetMethodID (class_ref, "onBind", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBind);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBind", "()V"));
			} finally {
			}
		}

		static Delegate cb_recycle;
#pragma warning disable 0169
		static Delegate GetRecycleHandler ()
		{
			if (cb_recycle == null)
				cb_recycle = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Recycle);
			return cb_recycle;
		}

		static void n_Recycle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Recycle ();
		}
#pragma warning restore 0169

		static IntPtr id_recycle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='BaseViewHolder']/method[@name='recycle' and count(parameter)=0]"
		[Register ("recycle", "()V", "GetRecycleHandler")]
		public virtual unsafe void Recycle ()
		{
			if (id_recycle == IntPtr.Zero)
				id_recycle = JNIEnv.GetMethodID (class_ref, "recycle", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recycle);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recycle", "()V"));
			} finally {
			}
		}

		static Delegate cb_setContentDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentDescription_Ljava_lang_String_Handler ()
		{
			if (cb_setContentDescription_Ljava_lang_String_ == null)
				cb_setContentDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentDescription_Ljava_lang_String_);
			return cb_setContentDescription_Ljava_lang_String_;
		}

		static void n_SetContentDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetContentDescription (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setContentDescription_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='BaseViewHolder']/method[@name='setContentDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setContentDescription", "(Ljava/lang/String;)V", "GetSetContentDescription_Ljava_lang_String_Handler")]
		public virtual unsafe void SetContentDescription (string p0)
		{
			if (id_setContentDescription_Ljava_lang_String_ == IntPtr.Zero)
				id_setContentDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContentDescription", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContentDescription_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContentDescription", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setCopy_Landroid_view_View_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetCopy_Landroid_view_View_OnClickListener_Handler ()
		{
			if (cb_setCopy_Landroid_view_View_OnClickListener_ == null)
				cb_setCopy_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCopy_Landroid_view_View_OnClickListener_);
			return cb_setCopy_Landroid_view_View_OnClickListener_;
		}

		static void n_SetCopy_Landroid_view_View_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View.IOnClickListener p0 = (global::Android.Views.View.IOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCopy (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCopy_Landroid_view_View_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='BaseViewHolder']/method[@name='setCopy' and count(parameter)=1 and parameter[1][@type='android.view.View.OnClickListener']]"
		[Register ("setCopy", "(Landroid/view/View$OnClickListener;)V", "GetSetCopy_Landroid_view_View_OnClickListener_Handler")]
		protected virtual unsafe void SetCopy (global::Android.Views.View.IOnClickListener p0)
		{
			if (id_setCopy_Landroid_view_View_OnClickListener_ == IntPtr.Zero)
				id_setCopy_Landroid_view_View_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setCopy", "(Landroid/view/View$OnClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCopy_Landroid_view_View_OnClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCopy", "(Landroid/view/View$OnClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setLongCopy_Landroid_view_View_OnLongClickListener_;
#pragma warning disable 0169
		static Delegate GetSetLongCopy_Landroid_view_View_OnLongClickListener_Handler ()
		{
			if (cb_setLongCopy_Landroid_view_View_OnLongClickListener_ == null)
				cb_setLongCopy_Landroid_view_View_OnLongClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetLongCopy_Landroid_view_View_OnLongClickListener_);
			return cb_setLongCopy_Landroid_view_View_OnLongClickListener_;
		}

		static bool n_SetLongCopy_Landroid_view_View_OnLongClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View.IOnLongClickListener p0 = (global::Android.Views.View.IOnLongClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnLongClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetLongCopy (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setLongCopy_Landroid_view_View_OnLongClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='BaseViewHolder']/method[@name='setLongCopy' and count(parameter)=1 and parameter[1][@type='android.view.View.OnLongClickListener']]"
		[Register ("setLongCopy", "(Landroid/view/View$OnLongClickListener;)Z", "GetSetLongCopy_Landroid_view_View_OnLongClickListener_Handler")]
		protected virtual unsafe bool SetLongCopy (global::Android.Views.View.IOnLongClickListener p0)
		{
			if (id_setLongCopy_Landroid_view_View_OnLongClickListener_ == IntPtr.Zero)
				id_setLongCopy_Landroid_view_View_OnLongClickListener_ = JNIEnv.GetMethodID (class_ref, "setLongCopy", "(Landroid/view/View$OnLongClickListener;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setLongCopy_Landroid_view_View_OnLongClickListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLongCopy", "(Landroid/view/View$OnLongClickListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setMessageTextView_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessageTextView_Ljava_lang_String_Handler ()
		{
			if (cb_setMessageTextView_Ljava_lang_String_ == null)
				cb_setMessageTextView_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessageTextView_Ljava_lang_String_);
			return cb_setMessageTextView_Ljava_lang_String_;
		}

		static void n_SetMessageTextView_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMessageTextView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMessageTextView_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='BaseViewHolder']/method[@name='setMessageTextView' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMessageTextView", "(Ljava/lang/String;)V", "GetSetMessageTextView_Ljava_lang_String_Handler")]
		public virtual unsafe void SetMessageTextView (string p0)
		{
			if (id_setMessageTextView_Ljava_lang_String_ == IntPtr.Zero)
				id_setMessageTextView_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessageTextView", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessageTextView_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageTextView", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setOnClickListener_Landroid_view_View_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnClickListener_Landroid_view_View_OnClickListener_Handler ()
		{
			if (cb_setOnClickListener_Landroid_view_View_OnClickListener_ == null)
				cb_setOnClickListener_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnClickListener_Landroid_view_View_OnClickListener_);
			return cb_setOnClickListener_Landroid_view_View_OnClickListener_;
		}

		static void n_SetOnClickListener_Landroid_view_View_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View.IOnClickListener p0 = (global::Android.Views.View.IOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnClickListener_Landroid_view_View_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='BaseViewHolder']/method[@name='setOnClickListener' and count(parameter)=1 and parameter[1][@type='android.view.View.OnClickListener']]"
		[Register ("setOnClickListener", "(Landroid/view/View$OnClickListener;)V", "GetSetOnClickListener_Landroid_view_View_OnClickListener_Handler")]
		public virtual unsafe void SetOnClickListener (global::Android.Views.View.IOnClickListener p0)
		{
			if (id_setOnClickListener_Landroid_view_View_OnClickListener_ == IntPtr.Zero)
				id_setOnClickListener_Landroid_view_View_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnClickListener", "(Landroid/view/View$OnClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnClickListener_Landroid_view_View_OnClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnClickListener", "(Landroid/view/View$OnClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnLongClickListener_Landroid_view_View_OnLongClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnLongClickListener_Landroid_view_View_OnLongClickListener_Handler ()
		{
			if (cb_setOnLongClickListener_Landroid_view_View_OnLongClickListener_ == null)
				cb_setOnLongClickListener_Landroid_view_View_OnLongClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnLongClickListener_Landroid_view_View_OnLongClickListener_);
			return cb_setOnLongClickListener_Landroid_view_View_OnLongClickListener_;
		}

		static void n_SetOnLongClickListener_Landroid_view_View_OnLongClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View.IOnLongClickListener p0 = (global::Android.Views.View.IOnLongClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnLongClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnLongClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnLongClickListener_Landroid_view_View_OnLongClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='BaseViewHolder']/method[@name='setOnLongClickListener' and count(parameter)=1 and parameter[1][@type='android.view.View.OnLongClickListener']]"
		[Register ("setOnLongClickListener", "(Landroid/view/View$OnLongClickListener;)V", "GetSetOnLongClickListener_Landroid_view_View_OnLongClickListener_Handler")]
		public virtual unsafe void SetOnLongClickListener (global::Android.Views.View.IOnLongClickListener p0)
		{
			if (id_setOnLongClickListener_Landroid_view_View_OnLongClickListener_ == IntPtr.Zero)
				id_setOnLongClickListener_Landroid_view_View_OnLongClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnLongClickListener", "(Landroid/view/View$OnLongClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnLongClickListener_Landroid_view_View_OnLongClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnLongClickListener", "(Landroid/view/View$OnLongClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTimestampTextView_J;
#pragma warning disable 0169
		static Delegate GetSetTimestampTextView_JHandler ()
		{
			if (cb_setTimestampTextView_J == null)
				cb_setTimestampTextView_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTimestampTextView_J);
			return cb_setTimestampTextView_J;
		}

		static void n_SetTimestampTextView_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTimestampTextView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTimestampTextView_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='BaseViewHolder']/method[@name='setTimestampTextView' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setTimestampTextView", "(J)V", "GetSetTimestampTextView_JHandler")]
		public virtual unsafe void SetTimestampTextView (long p0)
		{
			if (id_setTimestampTextView_J == IntPtr.Zero)
				id_setTimestampTextView_J = JNIEnv.GetMethodID (class_ref, "setTimestampTextView", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTimestampTextView_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimestampTextView", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateContentDescription;
#pragma warning disable 0169
		static Delegate GetUpdateContentDescriptionHandler ()
		{
			if (cb_updateContentDescription == null)
				cb_updateContentDescription = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateContentDescription);
			return cb_updateContentDescription;
		}

		static void n_UpdateContentDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.BaseViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateContentDescription ();
		}
#pragma warning restore 0169

		static IntPtr id_updateContentDescription;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.adapter.viewholder']/class[@name='BaseViewHolder']/method[@name='updateContentDescription' and count(parameter)=0]"
		[Register ("updateContentDescription", "()V", "GetUpdateContentDescriptionHandler")]
		public virtual unsafe void UpdateContentDescription ()
		{
			if (id_updateContentDescription == IntPtr.Zero)
				id_updateContentDescription = JNIEnv.GetMethodID (class_ref, "updateContentDescription", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateContentDescription);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateContentDescription", "()V"));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/adapter/viewholder/BaseViewHolder", DoNotGenerateAcw=true)]
	internal partial class BaseViewHolderInvoker : BaseViewHolder {

		public BaseViewHolderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseViewHolderInvoker); }
		}

	}

}
