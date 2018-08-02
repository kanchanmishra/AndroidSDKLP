using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='BitmapLruCache']"
	[global::Android.Runtime.Register ("com/liveperson/infra/utils/BitmapLruCache", DoNotGenerateAcw=true)]
	public partial class BitmapLruCache : global::Java.Lang.Object {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='BitmapLruCache']/field[@name='TAG']"
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
				return JNIEnv.FindClass ("com/liveperson/infra/utils/BitmapLruCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BitmapLruCache); }
		}

		protected BitmapLruCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='BitmapLruCache']/constructor[@name='BitmapLruCache' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe BitmapLruCache (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (BitmapLruCache)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_addBitmapToCache_Ljava_lang_String_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetAddBitmapToCache_Ljava_lang_String_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_addBitmapToCache_Ljava_lang_String_Landroid_graphics_Bitmap_ == null)
				cb_addBitmapToCache_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddBitmapToCache_Ljava_lang_String_Landroid_graphics_Bitmap_);
			return cb_addBitmapToCache_Ljava_lang_String_Landroid_graphics_Bitmap_;
		}

		static void n_AddBitmapToCache_Ljava_lang_String_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Utils.BitmapLruCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.BitmapLruCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddBitmapToCache (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addBitmapToCache_Ljava_lang_String_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='BitmapLruCache']/method[@name='addBitmapToCache' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("addBitmapToCache", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V", "GetAddBitmapToCache_Ljava_lang_String_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void AddBitmapToCache (string p0, global::Android.Graphics.Bitmap p1)
		{
			if (id_addBitmapToCache_Ljava_lang_String_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_addBitmapToCache_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "addBitmapToCache", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addBitmapToCache_Ljava_lang_String_Landroid_graphics_Bitmap_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addBitmapToCache", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getBitmapFromCache_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBitmapFromCache_Ljava_lang_String_Handler ()
		{
			if (cb_getBitmapFromCache_Ljava_lang_String_ == null)
				cb_getBitmapFromCache_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBitmapFromCache_Ljava_lang_String_);
			return cb_getBitmapFromCache_Ljava_lang_String_;
		}

		static IntPtr n_GetBitmapFromCache_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.BitmapLruCache __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.BitmapLruCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBitmapFromCache (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBitmapFromCache_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='BitmapLruCache']/method[@name='getBitmapFromCache' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBitmapFromCache", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "GetGetBitmapFromCache_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap GetBitmapFromCache (string p0)
		{
			if (id_getBitmapFromCache_Ljava_lang_String_ == IntPtr.Zero)
				id_getBitmapFromCache_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getBitmapFromCache", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Android.Graphics.Bitmap __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBitmapFromCache_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBitmapFromCache", "(Ljava/lang/String;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
