using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='UIUtils']"
	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/utils/UIUtils", DoNotGenerateAcw=true)]
	public partial class UIUtils : global::Java.Lang.Object {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='UIUtils']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/ui/view/utils/UIUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UIUtils); }
		}

		protected UIUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='UIUtils']/constructor[@name='UIUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UIUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UIUtils)) {
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

		static IntPtr id_changeCustomTextViewFont_Landroid_widget_TextView_Landroid_content_Context_Landroid_util_AttributeSet_arrayII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='UIUtils']/method[@name='changeCustomTextViewFont' and count(parameter)=5 and parameter[1][@type='android.widget.TextView'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='android.util.AttributeSet'] and parameter[4][@type='int[]'] and parameter[5][@type='int']]"
		[Register ("changeCustomTextViewFont", "(Landroid/widget/TextView;Landroid/content/Context;Landroid/util/AttributeSet;[II)V", "")]
		public static unsafe void ChangeCustomTextViewFont (global::Android.Widget.TextView p0, global::Android.Content.Context p1, global::Android.Util.IAttributeSet p2, int[] p3, int p4)
		{
			if (id_changeCustomTextViewFont_Landroid_widget_TextView_Landroid_content_Context_Landroid_util_AttributeSet_arrayII == IntPtr.Zero)
				id_changeCustomTextViewFont_Landroid_widget_TextView_Landroid_content_Context_Landroid_util_AttributeSet_arrayII = JNIEnv.GetStaticMethodID (class_ref, "changeCustomTextViewFont", "(Landroid/widget/TextView;Landroid/content/Context;Landroid/util/AttributeSet;[II)V");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_changeCustomTextViewFont_Landroid_widget_TextView_Landroid_content_Context_Landroid_util_AttributeSet_arrayII, __args);
			} finally {
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_createDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_DialogInterface_OnClickListener_Ljava_lang_String_Landroid_content_DialogInterface_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='UIUtils']/method[@name='createDialog' and count(parameter)=7 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='android.content.DialogInterface.OnClickListener'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='android.content.DialogInterface.OnClickListener']]"
		[Register ("createDialog", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/content/DialogInterface$OnClickListener;Ljava/lang/String;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog;", "")]
		public static unsafe global::Android.App.AlertDialog CreateDialog (global::Android.Content.Context p0, string p1, string p2, string p3, global::Android.Content.IDialogInterfaceOnClickListener p4, string p5, global::Android.Content.IDialogInterfaceOnClickListener p6)
		{
			if (id_createDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_DialogInterface_OnClickListener_Ljava_lang_String_Landroid_content_DialogInterface_OnClickListener_ == IntPtr.Zero)
				id_createDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_DialogInterface_OnClickListener_Ljava_lang_String_Landroid_content_DialogInterface_OnClickListener_ = JNIEnv.GetStaticMethodID (class_ref, "createDialog", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/content/DialogInterface$OnClickListener;Ljava/lang/String;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				global::Android.App.AlertDialog __ret = global::Java.Lang.Object.GetObject<global::Android.App.AlertDialog> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createDialog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_content_DialogInterface_OnClickListener_Ljava_lang_String_Landroid_content_DialogInterface_OnClickListener_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_detectEmojis_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='UIUtils']/method[@name='detectEmojis' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("detectEmojis", "(Ljava/lang/String;)I", "")]
		public static unsafe int DetectEmojis (string p0)
		{
			if (id_detectEmojis_Ljava_lang_String_ == IntPtr.Zero)
				id_detectEmojis_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "detectEmojis", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_detectEmojis_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_hideKeyboard_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='UIUtils']/method[@name='hideKeyboard' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("hideKeyboard", "(Landroid/app/Activity;)V", "")]
		public static unsafe void HideKeyboard (global::Android.App.Activity p0)
		{
			if (id_hideKeyboard_Landroid_app_Activity_ == IntPtr.Zero)
				id_hideKeyboard_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "hideKeyboard", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_hideKeyboard_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_startProgressBarAnimation_Landroid_widget_ImageView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='UIUtils']/method[@name='startProgressBarAnimation' and count(parameter)=2 and parameter[1][@type='android.widget.ImageView'] and parameter[2][@type='int']]"
		[Register ("startProgressBarAnimation", "(Landroid/widget/ImageView;I)V", "")]
		public static unsafe void StartProgressBarAnimation (global::Android.Widget.ImageView p0, int p1)
		{
			if (id_startProgressBarAnimation_Landroid_widget_ImageView_I == IntPtr.Zero)
				id_startProgressBarAnimation_Landroid_widget_ImageView_I = JNIEnv.GetStaticMethodID (class_ref, "startProgressBarAnimation", "(Landroid/widget/ImageView;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_startProgressBarAnimation_Landroid_widget_ImageView_I, __args);
			} finally {
			}
		}

	}
}
