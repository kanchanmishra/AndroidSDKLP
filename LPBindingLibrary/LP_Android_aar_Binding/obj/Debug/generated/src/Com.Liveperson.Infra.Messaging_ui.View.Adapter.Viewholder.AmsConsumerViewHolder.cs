using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerViewHolder']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsConsumerViewHolder", DoNotGenerateAcw=true)]
	public partial class AmsConsumerViewHolder : global::Com.Liveperson.Infra.UI.View.Adapter.Viewholder.EndViewHolder, global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.IAmsViewHolder {


		static IntPtr mMessageErrorView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerViewHolder']/field[@name='mMessageErrorView']"
		[Register ("mMessageErrorView")]
		protected global::Android.Widget.ImageView MMessageErrorView {
			get {
				if (mMessageErrorView_jfieldId == IntPtr.Zero)
					mMessageErrorView_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessageErrorView", "Landroid/widget/ImageView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMessageErrorView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMessageErrorView_jfieldId == IntPtr.Zero)
					mMessageErrorView_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessageErrorView", "Landroid/widget/ImageView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMessageErrorView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mMessageStateIcon_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerViewHolder']/field[@name='mMessageStateIcon']"
		[Register ("mMessageStateIcon")]
		protected global::Android.Widget.ImageView MMessageStateIcon {
			get {
				if (mMessageStateIcon_jfieldId == IntPtr.Zero)
					mMessageStateIcon_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessageStateIcon", "Landroid/widget/ImageView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMessageStateIcon_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMessageStateIcon_jfieldId == IntPtr.Zero)
					mMessageStateIcon_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessageStateIcon", "Landroid/widget/ImageView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMessageStateIcon_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mMessageStateText_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerViewHolder']/field[@name='mMessageStateText']"
		[Register ("mMessageStateText")]
		protected global::Android.Widget.TextView MMessageStateText {
			get {
				if (mMessageStateText_jfieldId == IntPtr.Zero)
					mMessageStateText_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessageStateText", "Landroid/widget/TextView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMessageStateText_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMessageStateText_jfieldId == IntPtr.Zero)
					mMessageStateText_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessageStateText", "Landroid/widget/TextView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMessageStateText_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mMessageStateTextArray_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerViewHolder']/field[@name='mMessageStateTextArray']"
		[Register ("mMessageStateTextArray")]
		protected static IList<string> MMessageStateTextArray {
			get {
				if (mMessageStateTextArray_jfieldId == IntPtr.Zero)
					mMessageStateTextArray_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mMessageStateTextArray", "[Ljava/lang/String;");
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, mMessageStateTextArray_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMessageStateTextArray_jfieldId == IntPtr.Zero)
					mMessageStateTextArray_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mMessageStateTextArray", "[Ljava/lang/String;");
				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, mMessageStateTextArray_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mMessageType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerViewHolder']/field[@name='mMessageType']"
		[Register ("mMessageType")]
		protected global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType MMessageType {
			get {
				if (mMessageType_jfieldId == IntPtr.Zero)
					mMessageType_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessageType", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMessageType_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMessageType_jfieldId == IntPtr.Zero)
					mMessageType_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessageType", "Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMessageType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mSdkMessageState_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerViewHolder']/field[@name='mSdkMessageState']"
		[Register ("mSdkMessageState")]
		protected static int MSdkMessageState {
			get {
				if (mSdkMessageState_jfieldId == IntPtr.Zero)
					mSdkMessageState_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mSdkMessageState", "I");
				return JNIEnv.GetStaticIntField (class_ref, mSdkMessageState_jfieldId);
			}
			set {
				if (mSdkMessageState_jfieldId == IntPtr.Zero)
					mSdkMessageState_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mSdkMessageState", "I");
				try {
					JNIEnv.SetStaticField (class_ref, mSdkMessageState_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mViewHolderType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerViewHolder']/field[@name='mViewHolderType']"
		[Register ("mViewHolderType")]
		protected global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerViewHolder.ViewHolderType MViewHolderType {
			get {
				if (mViewHolderType_jfieldId == IntPtr.Zero)
					mViewHolderType_jfieldId = JNIEnv.GetFieldID (class_ref, "mViewHolderType", "Lcom/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsConsumerViewHolder$ViewHolderType;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mViewHolderType_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerViewHolder.ViewHolderType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mViewHolderType_jfieldId == IntPtr.Zero)
					mViewHolderType_jfieldId = JNIEnv.GetFieldID (class_ref, "mViewHolderType", "Lcom/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsConsumerViewHolder$ViewHolderType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mViewHolderType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerViewHolder.ViewHolderType']"
		[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsConsumerViewHolder$ViewHolderType", DoNotGenerateAcw=true)]
		public sealed partial class ViewHolderType : global::Java.Lang.Enum {


			static IntPtr ICON_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerViewHolder.ViewHolderType']/field[@name='ICON']"
			[Register ("ICON")]
			public static global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerViewHolder.ViewHolderType Icon {
				get {
					if (ICON_jfieldId == IntPtr.Zero)
						ICON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ICON", "Lcom/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsConsumerViewHolder$ViewHolderType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ICON_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerViewHolder.ViewHolderType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TEXT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerViewHolder.ViewHolderType']/field[@name='TEXT']"
			[Register ("TEXT")]
			public static global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerViewHolder.ViewHolderType Text {
				get {
					if (TEXT_jfieldId == IntPtr.Zero)
						TEXT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXT", "Lcom/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsConsumerViewHolder$ViewHolderType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEXT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerViewHolder.ViewHolderType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsConsumerViewHolder$ViewHolderType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ViewHolderType); }
			}

			internal ViewHolderType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsConsumerViewHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsConsumerViewHolder); }
		}

		protected AmsConsumerViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerViewHolder']/constructor[@name='AmsConsumerViewHolder' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageType']]"
		[Register (".ctor", "(Landroid/view/View;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)V", "")]
		public unsafe AmsConsumerViewHolder (global::Android.Views.View p0, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (AmsConsumerViewHolder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/view/View;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/view/View;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)V", __args);
					return;
				}

				if (id_ctor_Landroid_view_View_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ == IntPtr.Zero)
					id_ctor_Landroid_view_View_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_view_View_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_, __args);
			} finally {
			}
		}

		static Delegate cb_getErrorView;
#pragma warning disable 0169
		static Delegate GetGetErrorViewHandler ()
		{
			if (cb_getErrorView == null)
				cb_getErrorView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorView);
			return cb_getErrorView;
		}

		static IntPtr n_GetErrorView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ErrorView);
		}
#pragma warning restore 0169

		static IntPtr id_getErrorView;
		public virtual unsafe global::Android.Widget.ImageView ErrorView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerViewHolder']/method[@name='getErrorView' and count(parameter)=0]"
			[Register ("getErrorView", "()Landroid/widget/ImageView;", "GetGetErrorViewHandler")]
			get {
				if (id_getErrorView == IntPtr.Zero)
					id_getErrorView = JNIEnv.GetMethodID (class_ref, "getErrorView", "()Landroid/widget/ImageView;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getErrorView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorView", "()Landroid/widget/ImageView;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ApplyColors ();
		}
#pragma warning restore 0169

		static IntPtr id_applyColors;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerViewHolder']/method[@name='applyColors' and count(parameter)=0]"
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

		static Delegate cb_resend_Lcom_liveperson_infra_model_Message_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
#pragma warning disable 0169
		static Delegate GetResend_Lcom_liveperson_infra_model_Message_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Handler ()
		{
			if (cb_resend_Lcom_liveperson_infra_model_Message_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ == null)
				cb_resend_Lcom_liveperson_infra_model_Message_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Resend_Lcom_liveperson_infra_model_Message_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_);
			return cb_resend_Lcom_liveperson_infra_model_Message_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
		}

		static int n_Resend_Lcom_liveperson_infra_model_Message_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Model.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Resend (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_resend_Lcom_liveperson_infra_model_Message_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerViewHolder']/method[@name='resend' and count(parameter)=2 and parameter[1][@type='com.liveperson.infra.model.Message'] and parameter[2][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageType']]"
		[Register ("resend", "(Lcom/liveperson/infra/model/Message;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)I", "GetResend_Lcom_liveperson_infra_model_Message_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Handler")]
		protected virtual unsafe int Resend (global::Com.Liveperson.Infra.Model.Message p0, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p1)
		{
			if (id_resend_Lcom_liveperson_infra_model_Message_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ == IntPtr.Zero)
				id_resend_Lcom_liveperson_infra_model_Message_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ = JNIEnv.GetMethodID (class_ref, "resend", "(Lcom/liveperson/infra/model/Message;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_resend_Lcom_liveperson_infra_model_Message_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resend", "(Lcom/liveperson/infra/model/Message;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)I"), __args);
				return __ret;
			} finally {
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
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMessageText (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setMessageText_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerViewHolder']/method[@name='setMessageText' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
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

		static Delegate cb_setStateVisibility_I;
#pragma warning disable 0169
		static Delegate GetSetStateVisibility_IHandler ()
		{
			if (cb_setStateVisibility_I == null)
				cb_setStateVisibility_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStateVisibility_I);
			return cb_setStateVisibility_I;
		}

		static void n_SetStateVisibility_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStateVisibility (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStateVisibility_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerViewHolder']/method[@name='setStateVisibility' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setStateVisibility", "(I)V", "GetSetStateVisibility_IHandler")]
		protected virtual unsafe void SetStateVisibility (int p0)
		{
			if (id_setStateVisibility_I == IntPtr.Zero)
				id_setStateVisibility_I = JNIEnv.GetMethodID (class_ref, "setStateVisibility", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStateVisibility_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStateVisibility", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setViewAppearanceByState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_infra_model_Message_;
#pragma warning disable 0169
		static Delegate GetSetViewAppearanceByState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_infra_model_Message_Handler ()
		{
			if (cb_setViewAppearanceByState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_infra_model_Message_ == null)
				cb_setViewAppearanceByState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_infra_model_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetViewAppearanceByState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_infra_model_Message_);
			return cb_setViewAppearanceByState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_infra_model_Message_;
		}

		static void n_SetViewAppearanceByState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_infra_model_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.AmsConsumerViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Model.Message p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Message> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetViewAppearanceByState (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setViewAppearanceByState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_infra_model_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/class[@name='AmsConsumerViewHolder']/method[@name='setViewAppearanceByState' and count(parameter)=3 and parameter[1][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageState'] and parameter[2][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageType'] and parameter[3][@type='com.liveperson.infra.model.Message']]"
		[Register ("setViewAppearanceByState", "(Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;Lcom/liveperson/infra/model/Message;)V", "GetSetViewAppearanceByState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_infra_model_Message_Handler")]
		public virtual unsafe void SetViewAppearanceByState (global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState p0, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p1, global::Com.Liveperson.Infra.Model.Message p2)
		{
			if (id_setViewAppearanceByState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_infra_model_Message_ == IntPtr.Zero)
				id_setViewAppearanceByState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_infra_model_Message_ = JNIEnv.GetMethodID (class_ref, "setViewAppearanceByState", "(Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;Lcom/liveperson/infra/model/Message;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setViewAppearanceByState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_infra_model_Message_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setViewAppearanceByState", "(Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;Lcom/liveperson/infra/model/Message;)V"), __args);
			} finally {
			}
		}

	}
}
