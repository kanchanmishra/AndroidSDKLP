using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ScrollDownIndicator']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/ScrollDownIndicator", DoNotGenerateAcw=true)]
	public partial class ScrollDownIndicator : global::Android.Support.Constraints.ConstraintLayout, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.IScrollDownIndicator {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ScrollDownIndicator.MODE']"
		[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/ScrollDownIndicator$MODE", DoNotGenerateAcw=true)]
		public sealed partial class MODE : global::Java.Lang.Enum {


			static IntPtr CLOSE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ScrollDownIndicator.MODE']/field[@name='CLOSE']"
			[Register ("CLOSE")]
			public static global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ScrollDownIndicator.MODE Close {
				get {
					if (CLOSE_jfieldId == IntPtr.Zero)
						CLOSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLOSE", "Lcom/liveperson/infra/messaging_ui/uicomponents/ScrollDownIndicator$MODE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLOSE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ScrollDownIndicator.MODE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OPEN_COLLAPSED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ScrollDownIndicator.MODE']/field[@name='OPEN_COLLAPSED']"
			[Register ("OPEN_COLLAPSED")]
			public static global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ScrollDownIndicator.MODE OpenCollapsed {
				get {
					if (OPEN_COLLAPSED_jfieldId == IntPtr.Zero)
						OPEN_COLLAPSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPEN_COLLAPSED", "Lcom/liveperson/infra/messaging_ui/uicomponents/ScrollDownIndicator$MODE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OPEN_COLLAPSED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ScrollDownIndicator.MODE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OPEN_EXPAND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ScrollDownIndicator.MODE']/field[@name='OPEN_EXPAND']"
			[Register ("OPEN_EXPAND")]
			public static global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ScrollDownIndicator.MODE OpenExpand {
				get {
					if (OPEN_EXPAND_jfieldId == IntPtr.Zero)
						OPEN_EXPAND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPEN_EXPAND", "Lcom/liveperson/infra/messaging_ui/uicomponents/ScrollDownIndicator$MODE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OPEN_EXPAND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ScrollDownIndicator.MODE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/ScrollDownIndicator$MODE", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MODE); }
			}

			internal MODE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/ScrollDownIndicator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScrollDownIndicator); }
		}

		protected ScrollDownIndicator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ScrollDownIndicator']/constructor[@name='ScrollDownIndicator' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe ScrollDownIndicator (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (ScrollDownIndicator)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ScrollDownIndicator']/constructor[@name='ScrollDownIndicator' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe ScrollDownIndicator (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ScrollDownIndicator)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ScrollDownIndicator']/constructor[@name='ScrollDownIndicator' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ScrollDownIndicator (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ScrollDownIndicator)) {
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

		static Delegate cb_isExpand;
#pragma warning disable 0169
		static Delegate GetIsExpandHandler ()
		{
			if (cb_isExpand == null)
				cb_isExpand = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsExpand);
			return cb_isExpand;
		}

		static bool n_IsExpand (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ScrollDownIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ScrollDownIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExpand;
		}
#pragma warning restore 0169

		static IntPtr id_isExpand;
		public virtual unsafe bool IsExpand {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ScrollDownIndicator']/method[@name='isExpand' and count(parameter)=0]"
			[Register ("isExpand", "()Z", "GetIsExpandHandler")]
			get {
				if (id_isExpand == IntPtr.Zero)
					id_isExpand = JNIEnv.GetMethodID (class_ref, "isExpand", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isExpand);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isExpand", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_resetAndHide;
#pragma warning disable 0169
		static Delegate GetResetAndHideHandler ()
		{
			if (cb_resetAndHide == null)
				cb_resetAndHide = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetAndHide);
			return cb_resetAndHide;
		}

		static void n_ResetAndHide (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ScrollDownIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ScrollDownIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetAndHide ();
		}
#pragma warning restore 0169

		static IntPtr id_resetAndHide;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ScrollDownIndicator']/method[@name='resetAndHide' and count(parameter)=0]"
		[Register ("resetAndHide", "()V", "GetResetAndHideHandler")]
		public virtual unsafe void ResetAndHide ()
		{
			if (id_resetAndHide == IntPtr.Zero)
				id_resetAndHide = JNIEnv.GetMethodID (class_ref, "resetAndHide", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetAndHide);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetAndHide", "()V"));
			} finally {
			}
		}

		static Delegate cb_resetAndShowCollapsed;
#pragma warning disable 0169
		static Delegate GetResetAndShowCollapsedHandler ()
		{
			if (cb_resetAndShowCollapsed == null)
				cb_resetAndShowCollapsed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetAndShowCollapsed);
			return cb_resetAndShowCollapsed;
		}

		static void n_ResetAndShowCollapsed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ScrollDownIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ScrollDownIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetAndShowCollapsed ();
		}
#pragma warning restore 0169

		static IntPtr id_resetAndShowCollapsed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ScrollDownIndicator']/method[@name='resetAndShowCollapsed' and count(parameter)=0]"
		[Register ("resetAndShowCollapsed", "()V", "GetResetAndShowCollapsedHandler")]
		public virtual unsafe void ResetAndShowCollapsed ()
		{
			if (id_resetAndShowCollapsed == IntPtr.Zero)
				id_resetAndShowCollapsed = JNIEnv.GetMethodID (class_ref, "resetAndShowCollapsed", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetAndShowCollapsed);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetAndShowCollapsed", "()V"));
			} finally {
			}
		}

		static Delegate cb_show_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShow_ILjava_lang_String_Handler ()
		{
			if (cb_show_ILjava_lang_String_ == null)
				cb_show_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Show_ILjava_lang_String_);
			return cb_show_ILjava_lang_String_;
		}

		static void n_Show_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ScrollDownIndicator __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ScrollDownIndicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Show (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_show_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ScrollDownIndicator']/method[@name='show' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("show", "(ILjava/lang/String;)V", "GetShow_ILjava_lang_String_Handler")]
		public virtual unsafe void Show (int p0, string p1)
		{
			if (id_show_ILjava_lang_String_ == IntPtr.Zero)
				id_show_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "show", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_show_ILjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "show", "(ILjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
