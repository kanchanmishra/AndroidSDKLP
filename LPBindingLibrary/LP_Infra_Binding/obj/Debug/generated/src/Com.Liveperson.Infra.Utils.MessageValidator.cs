using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='MessageValidator']"
	[global::Android.Runtime.Register ("com/liveperson/infra/utils/MessageValidator", DoNotGenerateAcw=true)]
	public partial class MessageValidator : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/utils/MessageValidator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageValidator); }
		}

		protected MessageValidator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='MessageValidator']/constructor[@name='MessageValidator' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;Z)V", "")]
		public unsafe MessageValidator (global::Android.Content.Context p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MessageValidator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Z)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Z == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Z, __args);
			} finally {
			}
		}

		static Delegate cb_maskMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMaskMessage_Ljava_lang_String_Handler ()
		{
			if (cb_maskMessage_Ljava_lang_String_ == null)
				cb_maskMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MaskMessage_Ljava_lang_String_);
			return cb_maskMessage_Ljava_lang_String_;
		}

		static IntPtr n_MaskMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.MessageValidator __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.MessageValidator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MaskMessage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_maskMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='MessageValidator']/method[@name='maskMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("maskMessage", "(Ljava/lang/String;)Lcom/liveperson/infra/utils/MaskedMessage;", "GetMaskMessage_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Utils.MaskedMessage MaskMessage (string p0)
		{
			if (id_maskMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_maskMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "maskMessage", "(Ljava/lang/String;)Lcom/liveperson/infra/utils/MaskedMessage;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Utils.MaskedMessage __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.MaskedMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_maskMessage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.MaskedMessage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "maskMessage", "(Ljava/lang/String;)Lcom/liveperson/infra/utils/MaskedMessage;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
