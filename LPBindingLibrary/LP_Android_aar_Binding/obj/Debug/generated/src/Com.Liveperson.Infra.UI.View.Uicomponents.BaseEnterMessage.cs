using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Uicomponents {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']"
	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/uicomponents/BaseEnterMessage", DoNotGenerateAcw=true)]
	public abstract partial class BaseEnterMessage : global::Android.Widget.LinearLayout, global::Com.Liveperson.Infra.UI.View.Uicomponents.IConnectionChangedCustomView {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/field[@name='RECORDING_LAYOUT_ANIMATION_DURATION_MILLIS']"
		[Register ("RECORDING_LAYOUT_ANIMATION_DURATION_MILLIS")]
		public const int RecordingLayoutAnimationDurationMillis = (int) 200;

		static IntPtr mBrandIdProvider_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/field[@name='mBrandIdProvider']"
		[Register ("mBrandIdProvider")]
		protected global::Com.Liveperson.Infra.UI.View.Uicomponents.IConversationProvider MBrandIdProvider {
			get {
				if (mBrandIdProvider_jfieldId == IntPtr.Zero)
					mBrandIdProvider_jfieldId = JNIEnv.GetFieldID (class_ref, "mBrandIdProvider", "Lcom/liveperson/infra/ui/view/uicomponents/IConversationProvider;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mBrandIdProvider_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.IConversationProvider> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mBrandIdProvider_jfieldId == IntPtr.Zero)
					mBrandIdProvider_jfieldId = JNIEnv.GetFieldID (class_ref, "mBrandIdProvider", "Lcom/liveperson/infra/ui/view/uicomponents/IConversationProvider;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mBrandIdProvider_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mEnterMessageLayoutSwitcher_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/field[@name='mEnterMessageLayoutSwitcher']"
		[Register ("mEnterMessageLayoutSwitcher")]
		protected global::Android.Widget.ViewSwitcher MEnterMessageLayoutSwitcher {
			get {
				if (mEnterMessageLayoutSwitcher_jfieldId == IntPtr.Zero)
					mEnterMessageLayoutSwitcher_jfieldId = JNIEnv.GetFieldID (class_ref, "mEnterMessageLayoutSwitcher", "Landroid/widget/ViewSwitcher;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mEnterMessageLayoutSwitcher_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ViewSwitcher> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mEnterMessageLayoutSwitcher_jfieldId == IntPtr.Zero)
					mEnterMessageLayoutSwitcher_jfieldId = JNIEnv.GetFieldID (class_ref, "mEnterMessageLayoutSwitcher", "Landroid/widget/ViewSwitcher;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mEnterMessageLayoutSwitcher_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mEnterMessageListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/field[@name='mEnterMessageListener']"
		[Register ("mEnterMessageListener")]
		protected global::Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListener MEnterMessageListener {
			get {
				if (mEnterMessageListener_jfieldId == IntPtr.Zero)
					mEnterMessageListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mEnterMessageListener", "Lcom/liveperson/infra/ui/view/uicomponents/IEnterMessageListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mEnterMessageListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mEnterMessageListener_jfieldId == IntPtr.Zero)
					mEnterMessageListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mEnterMessageListener", "Lcom/liveperson/infra/ui/view/uicomponents/IEnterMessageListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mEnterMessageListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mImageSendButton_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/field[@name='mImageSendButton']"
		[Register ("mImageSendButton")]
		protected global::Android.Widget.ImageButton MImageSendButton {
			get {
				if (mImageSendButton_jfieldId == IntPtr.Zero)
					mImageSendButton_jfieldId = JNIEnv.GetFieldID (class_ref, "mImageSendButton", "Landroid/widget/ImageButton;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mImageSendButton_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageButton> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mImageSendButton_jfieldId == IntPtr.Zero)
					mImageSendButton_jfieldId = JNIEnv.GetFieldID (class_ref, "mImageSendButton", "Landroid/widget/ImageButton;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mImageSendButton_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mIsConnected_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/field[@name='mIsConnected']"
		[Register ("mIsConnected")]
		protected bool MIsConnected {
			get {
				if (mIsConnected_jfieldId == IntPtr.Zero)
					mIsConnected_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsConnected", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mIsConnected_jfieldId);
			}
			set {
				if (mIsConnected_jfieldId == IntPtr.Zero)
					mIsConnected_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsConnected", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mIsConnected_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mTextSendButton_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/field[@name='mTextSendButton']"
		[Register ("mTextSendButton")]
		protected global::Android.Widget.Button MTextSendButton {
			get {
				if (mTextSendButton_jfieldId == IntPtr.Zero)
					mTextSendButton_jfieldId = JNIEnv.GetFieldID (class_ref, "mTextSendButton", "Landroid/widget/Button;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mTextSendButton_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.Button> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTextSendButton_jfieldId == IntPtr.Zero)
					mTextSendButton_jfieldId = JNIEnv.GetFieldID (class_ref, "mTextSendButton", "Landroid/widget/Button;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mTextSendButton_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mTrashButton_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/field[@name='mTrashButton']"
		[Register ("mTrashButton")]
		protected global::Android.Widget.ImageButton MTrashButton {
			get {
				if (mTrashButton_jfieldId == IntPtr.Zero)
					mTrashButton_jfieldId = JNIEnv.GetFieldID (class_ref, "mTrashButton", "Landroid/widget/ImageButton;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mTrashButton_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageButton> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTrashButton_jfieldId == IntPtr.Zero)
					mTrashButton_jfieldId = JNIEnv.GetFieldID (class_ref, "mTrashButton", "Landroid/widget/ImageButton;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mTrashButton_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage.InputState']"
		[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/uicomponents/BaseEnterMessage$InputState", DoNotGenerateAcw=true)]
		public sealed partial class InputState : global::Java.Lang.Enum {


			static IntPtr HAS_TEXT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage.InputState']/field[@name='HAS_TEXT']"
			[Register ("HAS_TEXT")]
			public static global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage.InputState HasText {
				get {
					if (HAS_TEXT_jfieldId == IntPtr.Zero)
						HAS_TEXT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HAS_TEXT", "Lcom/liveperson/infra/ui/view/uicomponents/BaseEnterMessage$InputState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HAS_TEXT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage.InputState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NONE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage.InputState']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage.InputState None {
				get {
					if (NONE_jfieldId == IntPtr.Zero)
						NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/liveperson/infra/ui/view/uicomponents/BaseEnterMessage$InputState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage.InputState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/ui/view/uicomponents/BaseEnterMessage$InputState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InputState); }
			}

			internal InputState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/ui/view/uicomponents/BaseEnterMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseEnterMessage); }
		}

		protected BaseEnterMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/constructor[@name='BaseEnterMessage' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe BaseEnterMessage (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (BaseEnterMessage)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/constructor[@name='BaseEnterMessage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe BaseEnterMessage (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (BaseEnterMessage)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/constructor[@name='BaseEnterMessage' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BaseEnterMessage (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (BaseEnterMessage)) {
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

		static Delegate cb_clearText;
#pragma warning disable 0169
		static Delegate GetClearTextHandler ()
		{
			if (cb_clearText == null)
				cb_clearText = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearText);
			return cb_clearText;
		}

		static void n_ClearText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearText ();
		}
#pragma warning restore 0169

		static IntPtr id_clearText;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/method[@name='clearText' and count(parameter)=0]"
		[Register ("clearText", "()V", "GetClearTextHandler")]
		protected virtual unsafe void ClearText ()
		{
			if (id_clearText == IntPtr.Zero)
				id_clearText = JNIEnv.GetMethodID (class_ref, "clearText", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearText);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearText", "()V"));
			} finally {
			}
		}

		static Delegate cb_enableSendButton;
#pragma warning disable 0169
		static Delegate GetEnableSendButtonHandler ()
		{
			if (cb_enableSendButton == null)
				cb_enableSendButton = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EnableSendButton);
			return cb_enableSendButton;
		}

		static void n_EnableSendButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableSendButton ();
		}
#pragma warning restore 0169

		static IntPtr id_enableSendButton;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/method[@name='enableSendButton' and count(parameter)=0]"
		[Register ("enableSendButton", "()V", "GetEnableSendButtonHandler")]
		protected virtual unsafe void EnableSendButton ()
		{
			if (id_enableSendButton == IntPtr.Zero)
				id_enableSendButton = JNIEnv.GetMethodID (class_ref, "enableSendButton", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enableSendButton);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableSendButton", "()V"));
			} finally {
			}
		}

		static IntPtr id_extractLinks_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/method[@name='extractLinks' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("extractLinks", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] ExtractLinks (string p0)
		{
			if (id_extractLinks_Ljava_lang_String_ == IntPtr.Zero)
				id_extractLinks_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "extractLinks", "(Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_extractLinks_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAfterChangedText (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/method[@name='onAfterChangedText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onAfterChangedText", "(Ljava/lang/String;)V", "GetOnAfterChangedText_Ljava_lang_String_Handler")]
		protected abstract void OnAfterChangedText (string p0);

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
			global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBeforeChangedText ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/method[@name='onBeforeChangedText' and count(parameter)=0]"
		[Register ("onBeforeChangedText", "()V", "GetOnBeforeChangedTextHandler")]
		protected abstract void OnBeforeChangedText ();

		static Delegate cb_onConnectionChanged_Z;
#pragma warning disable 0169
		static Delegate GetOnConnectionChanged_ZHandler ()
		{
			if (cb_onConnectionChanged_Z == null)
				cb_onConnectionChanged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnConnectionChanged_Z);
			return cb_onConnectionChanged_Z;
		}

		static void n_OnConnectionChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConnectionChanged_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/method[@name='onConnectionChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onConnectionChanged", "(Z)V", "GetOnConnectionChanged_ZHandler")]
		public virtual unsafe void OnConnectionChanged (bool p0)
		{
			if (id_onConnectionChanged_Z == IntPtr.Zero)
				id_onConnectionChanged_Z = JNIEnv.GetMethodID (class_ref, "onConnectionChanged", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionChanged_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnectionChanged", "(Z)V"), __args);
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
			global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnHasText (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/method[@name='onHasText' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onHasText", "(Z)V", "GetOnHasText_ZHandler")]
		protected abstract void OnHasText (bool p0);

		static Delegate cb_sendMessage;
#pragma warning disable 0169
		static Delegate GetSendMessageHandler ()
		{
			if (cb_sendMessage == null)
				cb_sendMessage = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendMessage);
			return cb_sendMessage;
		}

		static void n_SendMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage ();
		}
#pragma warning restore 0169

		static IntPtr id_sendMessage;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/method[@name='sendMessage' and count(parameter)=0]"
		[Register ("sendMessage", "()V", "GetSendMessageHandler")]
		protected virtual unsafe void SendMessage ()
		{
			if (id_sendMessage == IntPtr.Zero)
				id_sendMessage = JNIEnv.GetMethodID (class_ref, "sendMessage", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendMessage", "()V"));
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
			global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/method[@name='sendMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sendMessage", "(Ljava/lang/String;)V", "GetSendMessage_Ljava_lang_String_Handler")]
		protected abstract void SendMessage (string p0);

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
			global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.SendMessageWithURL (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/method[@name='sendMessageWithURL' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("sendMessageWithURL", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected abstract void SendMessageWithURL (string p0, string p1, string p2, string p3, string p4, string p5);

		static Delegate cb_setBrandIdProvider_Lcom_liveperson_infra_ui_view_uicomponents_IConversationProvider_;
#pragma warning disable 0169
		static Delegate GetSetBrandIdProvider_Lcom_liveperson_infra_ui_view_uicomponents_IConversationProvider_Handler ()
		{
			if (cb_setBrandIdProvider_Lcom_liveperson_infra_ui_view_uicomponents_IConversationProvider_ == null)
				cb_setBrandIdProvider_Lcom_liveperson_infra_ui_view_uicomponents_IConversationProvider_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBrandIdProvider_Lcom_liveperson_infra_ui_view_uicomponents_IConversationProvider_);
			return cb_setBrandIdProvider_Lcom_liveperson_infra_ui_view_uicomponents_IConversationProvider_;
		}

		static void n_SetBrandIdProvider_Lcom_liveperson_infra_ui_view_uicomponents_IConversationProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.UI.View.Uicomponents.IConversationProvider p0 = (global::Com.Liveperson.Infra.UI.View.Uicomponents.IConversationProvider)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.IConversationProvider> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBrandIdProvider (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBrandIdProvider_Lcom_liveperson_infra_ui_view_uicomponents_IConversationProvider_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/method[@name='setBrandIdProvider' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.ui.view.uicomponents.IConversationProvider']]"
		[Register ("setBrandIdProvider", "(Lcom/liveperson/infra/ui/view/uicomponents/IConversationProvider;)V", "GetSetBrandIdProvider_Lcom_liveperson_infra_ui_view_uicomponents_IConversationProvider_Handler")]
		public virtual unsafe void SetBrandIdProvider (global::Com.Liveperson.Infra.UI.View.Uicomponents.IConversationProvider p0)
		{
			if (id_setBrandIdProvider_Lcom_liveperson_infra_ui_view_uicomponents_IConversationProvider_ == IntPtr.Zero)
				id_setBrandIdProvider_Lcom_liveperson_infra_ui_view_uicomponents_IConversationProvider_ = JNIEnv.GetMethodID (class_ref, "setBrandIdProvider", "(Lcom/liveperson/infra/ui/view/uicomponents/IConversationProvider;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBrandIdProvider_Lcom_liveperson_infra_ui_view_uicomponents_IConversationProvider_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBrandIdProvider", "(Lcom/liveperson/infra/ui/view/uicomponents/IConversationProvider;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setEnterMessageListener_Lcom_liveperson_infra_ui_view_uicomponents_IEnterMessageListener_;
#pragma warning disable 0169
		static Delegate GetSetEnterMessageListener_Lcom_liveperson_infra_ui_view_uicomponents_IEnterMessageListener_Handler ()
		{
			if (cb_setEnterMessageListener_Lcom_liveperson_infra_ui_view_uicomponents_IEnterMessageListener_ == null)
				cb_setEnterMessageListener_Lcom_liveperson_infra_ui_view_uicomponents_IEnterMessageListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEnterMessageListener_Lcom_liveperson_infra_ui_view_uicomponents_IEnterMessageListener_);
			return cb_setEnterMessageListener_Lcom_liveperson_infra_ui_view_uicomponents_IEnterMessageListener_;
		}

		static void n_SetEnterMessageListener_Lcom_liveperson_infra_ui_view_uicomponents_IEnterMessageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListener p0 = (global::Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetEnterMessageListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setEnterMessageListener_Lcom_liveperson_infra_ui_view_uicomponents_IEnterMessageListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/method[@name='setEnterMessageListener' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.ui.view.uicomponents.IEnterMessageListener']]"
		[Register ("setEnterMessageListener", "(Lcom/liveperson/infra/ui/view/uicomponents/IEnterMessageListener;)V", "GetSetEnterMessageListener_Lcom_liveperson_infra_ui_view_uicomponents_IEnterMessageListener_Handler")]
		public virtual unsafe void SetEnterMessageListener (global::Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListener p0)
		{
			if (id_setEnterMessageListener_Lcom_liveperson_infra_ui_view_uicomponents_IEnterMessageListener_ == IntPtr.Zero)
				id_setEnterMessageListener_Lcom_liveperson_infra_ui_view_uicomponents_IEnterMessageListener_ = JNIEnv.GetMethodID (class_ref, "setEnterMessageListener", "(Lcom/liveperson/infra/ui/view/uicomponents/IEnterMessageListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEnterMessageListener_Lcom_liveperson_infra_ui_view_uicomponents_IEnterMessageListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEnterMessageListener", "(Lcom/liveperson/infra/ui/view/uicomponents/IEnterMessageListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOverflowMenu_Lcom_liveperson_infra_ui_view_uicomponents_IOverflowMenu_;
#pragma warning disable 0169
		static Delegate GetSetOverflowMenu_Lcom_liveperson_infra_ui_view_uicomponents_IOverflowMenu_Handler ()
		{
			if (cb_setOverflowMenu_Lcom_liveperson_infra_ui_view_uicomponents_IOverflowMenu_ == null)
				cb_setOverflowMenu_Lcom_liveperson_infra_ui_view_uicomponents_IOverflowMenu_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOverflowMenu_Lcom_liveperson_infra_ui_view_uicomponents_IOverflowMenu_);
			return cb_setOverflowMenu_Lcom_liveperson_infra_ui_view_uicomponents_IOverflowMenu_;
		}

		static void n_SetOverflowMenu_Lcom_liveperson_infra_ui_view_uicomponents_IOverflowMenu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.UI.View.Uicomponents.IOverflowMenu p0 = (global::Com.Liveperson.Infra.UI.View.Uicomponents.IOverflowMenu)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.IOverflowMenu> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOverflowMenu (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOverflowMenu_Lcom_liveperson_infra_ui_view_uicomponents_IOverflowMenu_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/method[@name='setOverflowMenu' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.ui.view.uicomponents.IOverflowMenu']]"
		[Register ("setOverflowMenu", "(Lcom/liveperson/infra/ui/view/uicomponents/IOverflowMenu;)V", "GetSetOverflowMenu_Lcom_liveperson_infra_ui_view_uicomponents_IOverflowMenu_Handler")]
		public virtual unsafe void SetOverflowMenu (global::Com.Liveperson.Infra.UI.View.Uicomponents.IOverflowMenu p0)
		{
			if (id_setOverflowMenu_Lcom_liveperson_infra_ui_view_uicomponents_IOverflowMenu_ == IntPtr.Zero)
				id_setOverflowMenu_Lcom_liveperson_infra_ui_view_uicomponents_IOverflowMenu_ = JNIEnv.GetMethodID (class_ref, "setOverflowMenu", "(Lcom/liveperson/infra/ui/view/uicomponents/IOverflowMenu;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOverflowMenu_Lcom_liveperson_infra_ui_view_uicomponents_IOverflowMenu_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOverflowMenu", "(Lcom/liveperson/infra/ui/view/uicomponents/IOverflowMenu;)V"), __args);
			} finally {
			}
		}

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
			global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetText (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setText_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setText", "(Ljava/lang/String;)V", "GetSetText_Ljava_lang_String_Handler")]
		public virtual unsafe void SetText (string p0)
		{
			if (id_setText_Ljava_lang_String_ == IntPtr.Zero)
				id_setText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setText", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setText_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setText", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldUpdateSendButton ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/method[@name='shouldUpdateSendButton' and count(parameter)=0]"
		[Register ("shouldUpdateSendButton", "()Z", "GetShouldUpdateSendButtonHandler")]
		protected abstract bool ShouldUpdateSendButton ();

		static Delegate cb_showNoNetworkMessage;
#pragma warning disable 0169
		static Delegate GetShowNoNetworkMessageHandler ()
		{
			if (cb_showNoNetworkMessage == null)
				cb_showNoNetworkMessage = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowNoNetworkMessage);
			return cb_showNoNetworkMessage;
		}

		static void n_ShowNoNetworkMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowNoNetworkMessage ();
		}
#pragma warning restore 0169

		static IntPtr id_showNoNetworkMessage;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/method[@name='showNoNetworkMessage' and count(parameter)=0]"
		[Register ("showNoNetworkMessage", "()V", "GetShowNoNetworkMessageHandler")]
		protected virtual unsafe void ShowNoNetworkMessage ()
		{
			if (id_showNoNetworkMessage == IntPtr.Zero)
				id_showNoNetworkMessage = JNIEnv.GetMethodID (class_ref, "showNoNetworkMessage", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showNoNetworkMessage);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showNoNetworkMessage", "()V"));
			} finally {
			}
		}

		static Delegate cb_updateSendButtonState;
#pragma warning disable 0169
		static Delegate GetUpdateSendButtonStateHandler ()
		{
			if (cb_updateSendButtonState == null)
				cb_updateSendButtonState = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateSendButtonState);
			return cb_updateSendButtonState;
		}

		static void n_UpdateSendButtonState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.BaseEnterMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateSendButtonState ();
		}
#pragma warning restore 0169

		static IntPtr id_updateSendButtonState;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/method[@name='updateSendButtonState' and count(parameter)=0]"
		[Register ("updateSendButtonState", "()V", "GetUpdateSendButtonStateHandler")]
		protected virtual unsafe void UpdateSendButtonState ()
		{
			if (id_updateSendButtonState == IntPtr.Zero)
				id_updateSendButtonState = JNIEnv.GetMethodID (class_ref, "updateSendButtonState", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateSendButtonState);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateSendButtonState", "()V"));
			} finally {
			}
		}

#region "Event implementation for Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListener"
		public event EventHandler MessageSent {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListener, global::Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListenerImplementor>(
						ref weak_implementor_SetEnterMessageListener,
						__CreateIEnterMessageListenerImplementor,
						SetEnterMessageListener,
						__h => __h.OnMessageSentHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListener, global::Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListenerImplementor>(
						ref weak_implementor_SetEnterMessageListener,
						global::Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListenerImplementor.__IsEmpty,
						__v => SetEnterMessageListener (null),
						__h => __h.OnMessageSentHandler -= value);
			}
		}

		public event EventHandler<global::Com.Liveperson.Infra.UI.View.Uicomponents.VoiceRecordingPermissionRequiredEventArgs> VoiceRecordingPermissionRequired {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListener, global::Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListenerImplementor>(
						ref weak_implementor_SetEnterMessageListener,
						__CreateIEnterMessageListenerImplementor,
						SetEnterMessageListener,
						__h => __h.OnVoiceRecordingPermissionRequiredHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListener, global::Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListenerImplementor>(
						ref weak_implementor_SetEnterMessageListener,
						global::Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListenerImplementor.__IsEmpty,
						__v => SetEnterMessageListener (null),
						__h => __h.OnVoiceRecordingPermissionRequiredHandler -= value);
			}
		}

		WeakReference weak_implementor_SetEnterMessageListener;

		global::Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListenerImplementor __CreateIEnterMessageListenerImplementor ()
		{
			return new global::Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/uicomponents/BaseEnterMessage", DoNotGenerateAcw=true)]
	internal partial class BaseEnterMessageInvoker : BaseEnterMessage {

		public BaseEnterMessageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseEnterMessageInvoker); }
		}

		static IntPtr id_onAfterChangedText_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/method[@name='onAfterChangedText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onAfterChangedText", "(Ljava/lang/String;)V", "GetOnAfterChangedText_Ljava_lang_String_Handler")]
		protected override unsafe void OnAfterChangedText (string p0)
		{
			if (id_onAfterChangedText_Ljava_lang_String_ == IntPtr.Zero)
				id_onAfterChangedText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAfterChangedText", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAfterChangedText_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_onBeforeChangedText;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/method[@name='onBeforeChangedText' and count(parameter)=0]"
		[Register ("onBeforeChangedText", "()V", "GetOnBeforeChangedTextHandler")]
		protected override unsafe void OnBeforeChangedText ()
		{
			if (id_onBeforeChangedText == IntPtr.Zero)
				id_onBeforeChangedText = JNIEnv.GetMethodID (class_ref, "onBeforeChangedText", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBeforeChangedText);
			} finally {
			}
		}

		static IntPtr id_onHasText_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/method[@name='onHasText' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onHasText", "(Z)V", "GetOnHasText_ZHandler")]
		protected override unsafe void OnHasText (bool p0)
		{
			if (id_onHasText_Z == IntPtr.Zero)
				id_onHasText_Z = JNIEnv.GetMethodID (class_ref, "onHasText", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHasText_Z, __args);
			} finally {
			}
		}

		static IntPtr id_sendMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/method[@name='sendMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sendMessage", "(Ljava/lang/String;)V", "GetSendMessage_Ljava_lang_String_Handler")]
		protected override unsafe void SendMessage (string p0)
		{
			if (id_sendMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_sendMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_sendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/method[@name='sendMessageWithURL' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
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
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_shouldUpdateSendButton;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/class[@name='BaseEnterMessage']/method[@name='shouldUpdateSendButton' and count(parameter)=0]"
		[Register ("shouldUpdateSendButton", "()Z", "GetShouldUpdateSendButtonHandler")]
		protected override unsafe bool ShouldUpdateSendButton ()
		{
			if (id_shouldUpdateSendButton == IntPtr.Zero)
				id_shouldUpdateSendButton = JNIEnv.GetMethodID (class_ref, "shouldUpdateSendButton", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_shouldUpdateSendButton);
			} finally {
			}
		}

	}

}
