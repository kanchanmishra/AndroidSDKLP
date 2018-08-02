using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentURLViewHolder']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsAgentURLViewHolder", DoNotGenerateAcw=true)]
	public partial class AmsAgentURLViewHolder : global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentViewHolder {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentURLViewHolder.MyLinkPreviewCallback']"
		[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsAgentURLViewHolder$MyLinkPreviewCallback", DoNotGenerateAcw=true)]
		public partial class MyLinkPreviewCallback : global::Java.Lang.Object, global::Com.Liveperson.Infra.Utils.ILinkPreviewCallback {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsAgentURLViewHolder$MyLinkPreviewCallback", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MyLinkPreviewCallback); }
			}

			protected MyLinkPreviewCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getText;
#pragma warning disable 0169
			static Delegate GetGetTextHandler ()
			{
				if (cb_getText == null)
					cb_getText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetText);
				return cb_getText;
			}

			static IntPtr n_GetText (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentURLViewHolder.MyLinkPreviewCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentURLViewHolder.MyLinkPreviewCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Text);
			}
#pragma warning restore 0169

			static Delegate cb_setText_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetText_Ljava_lang_String_Handler ()
			{
				if (cb_setText_Ljava_lang_String_ == null)
					cb_setText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetText_Ljava_lang_String_);
				return cb_setText_Ljava_lang_String_;
			}

			static void n_SetText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentURLViewHolder.MyLinkPreviewCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentURLViewHolder.MyLinkPreviewCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Text = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getText;
			static IntPtr id_setText_Ljava_lang_String_;
			public virtual unsafe string Text {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentURLViewHolder.MyLinkPreviewCallback']/method[@name='getText' and count(parameter)=0]"
				[Register ("getText", "()Ljava/lang/String;", "GetGetTextHandler")]
				get {
					if (id_getText == IntPtr.Zero)
						id_getText = JNIEnv.GetMethodID (class_ref, "getText", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getText), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentURLViewHolder.MyLinkPreviewCallback']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setText", "(Ljava/lang/String;)V", "GetSetText_Ljava_lang_String_Handler")]
				set {
					if (id_setText_Ljava_lang_String_ == IntPtr.Zero)
						id_setText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setText", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setText_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setText", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_clean;
#pragma warning disable 0169
			static Delegate GetCleanHandler ()
			{
				if (cb_clean == null)
					cb_clean = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clean);
				return cb_clean;
			}

			static void n_Clean (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentURLViewHolder.MyLinkPreviewCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentURLViewHolder.MyLinkPreviewCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Clean ();
			}
#pragma warning restore 0169

			static IntPtr id_clean;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentURLViewHolder.MyLinkPreviewCallback']/method[@name='clean' and count(parameter)=0]"
			[Register ("clean", "()V", "GetCleanHandler")]
			public virtual unsafe void Clean ()
			{
				if (id_clean == IntPtr.Zero)
					id_clean = JNIEnv.GetMethodID (class_ref, "clean", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clean);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clean", "()V"));
				} finally {
				}
			}

			static Delegate cb_onPos_Lcom_liveperson_infra_utils_SourceContent_Z;
#pragma warning disable 0169
			static Delegate GetOnPos_Lcom_liveperson_infra_utils_SourceContent_ZHandler ()
			{
				if (cb_onPos_Lcom_liveperson_infra_utils_SourceContent_Z == null)
					cb_onPos_Lcom_liveperson_infra_utils_SourceContent_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnPos_Lcom_liveperson_infra_utils_SourceContent_Z);
				return cb_onPos_Lcom_liveperson_infra_utils_SourceContent_Z;
			}

			static void n_OnPos_Lcom_liveperson_infra_utils_SourceContent_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
			{
				global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentURLViewHolder.MyLinkPreviewCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentURLViewHolder.MyLinkPreviewCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Liveperson.Infra.Utils.SourceContent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPos (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onPos_Lcom_liveperson_infra_utils_SourceContent_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentURLViewHolder.MyLinkPreviewCallback']/method[@name='onPos' and count(parameter)=2 and parameter[1][@type='com.liveperson.infra.utils.SourceContent'] and parameter[2][@type='boolean']]"
			[Register ("onPos", "(Lcom/liveperson/infra/utils/SourceContent;Z)V", "GetOnPos_Lcom_liveperson_infra_utils_SourceContent_ZHandler")]
			public virtual unsafe void OnPos (global::Com.Liveperson.Infra.Utils.SourceContent p0, bool p1)
			{
				if (id_onPos_Lcom_liveperson_infra_utils_SourceContent_Z == IntPtr.Zero)
					id_onPos_Lcom_liveperson_infra_utils_SourceContent_Z = JNIEnv.GetMethodID (class_ref, "onPos", "(Lcom/liveperson/infra/utils/SourceContent;Z)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPos_Lcom_liveperson_infra_utils_SourceContent_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPos", "(Lcom/liveperson/infra/utils/SourceContent;Z)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onPre;
#pragma warning disable 0169
			static Delegate GetOnPreHandler ()
			{
				if (cb_onPre == null)
					cb_onPre = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPre);
				return cb_onPre;
			}

			static void n_OnPre (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentURLViewHolder.MyLinkPreviewCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentURLViewHolder.MyLinkPreviewCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPre ();
			}
#pragma warning restore 0169

			static IntPtr id_onPre;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentURLViewHolder.MyLinkPreviewCallback']/method[@name='onPre' and count(parameter)=0]"
			[Register ("onPre", "()V", "GetOnPreHandler")]
			public virtual unsafe void OnPre ()
			{
				if (id_onPre == IntPtr.Zero)
					id_onPre = JNIEnv.GetMethodID (class_ref, "onPre", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPre);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPre", "()V"));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsAgentURLViewHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsAgentURLViewHolder); }
		}

		protected AmsAgentURLViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentURLViewHolder']/constructor[@name='AmsAgentURLViewHolder' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.liveperson.infra.messaging_ui.view.adapter.copybehavior.CopyBehavior']]"
		[Register (".ctor", "(Landroid/view/View;Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior;)V", "")]
		public unsafe AmsAgentURLViewHolder (global::Android.Views.View p0, global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (AmsAgentURLViewHolder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/view/View;Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/view/View;Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior;)V", __args);
					return;
				}

				if (id_ctor_Landroid_view_View_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_ == IntPtr.Zero)
					id_ctor_Landroid_view_View_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_view_View_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_, __args);
			} finally {
			}
		}

		static Delegate cb_setTimestamp_J;
#pragma warning disable 0169
		static Delegate GetSetTimestamp_JHandler ()
		{
			if (cb_setTimestamp_J == null)
				cb_setTimestamp_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTimestamp_J);
			return cb_setTimestamp_J;
		}

		static void n_SetTimestamp_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentURLViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsAgentURLViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTimestamp (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTimestamp_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsAgentURLViewHolder']/method[@name='setTimestamp' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setTimestamp", "(J)V", "GetSetTimestamp_JHandler")]
		public virtual unsafe void SetTimestamp (long p0)
		{
			if (id_setTimestamp_J == IntPtr.Zero)
				id_setTimestamp_J = JNIEnv.GetMethodID (class_ref, "setTimestamp", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTimestamp_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimestamp", "(J)V"), __args);
			} finally {
			}
		}

	}
}
