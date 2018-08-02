using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']"
	[global::Android.Runtime.Register ("com/liveperson/infra/utils/ImageUtils", DoNotGenerateAcw=true)]
	public partial class ImageUtils : global::Java.Lang.Object {


		static IntPtr FULL_IMAGE_FOLDER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/field[@name='FULL_IMAGE_FOLDER']"
		[Register ("FULL_IMAGE_FOLDER")]
		public static string FullImageFolder {
			get {
				if (FULL_IMAGE_FOLDER_jfieldId == IntPtr.Zero)
					FULL_IMAGE_FOLDER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FULL_IMAGE_FOLDER", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FULL_IMAGE_FOLDER_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FULL_IMAGE_FOLDER_jfieldId == IntPtr.Zero)
					FULL_IMAGE_FOLDER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FULL_IMAGE_FOLDER", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, FULL_IMAGE_FOLDER_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr IMAGES_FOLDER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/field[@name='IMAGES_FOLDER']"
		[Register ("IMAGES_FOLDER")]
		public static string ImagesFolder {
			get {
				if (IMAGES_FOLDER_jfieldId == IntPtr.Zero)
					IMAGES_FOLDER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IMAGES_FOLDER", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IMAGES_FOLDER_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (IMAGES_FOLDER_jfieldId == IntPtr.Zero)
					IMAGES_FOLDER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IMAGES_FOLDER", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, IMAGES_FOLDER_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/field[@name='JPG']"
		[Register ("JPG")]
		public const string Jpg = (string) "jpg";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/field[@name='PNG']"
		[Register ("PNG")]
		public const string Png = (string) "png";

		static IntPtr PREVIEW_IMAGE_FOLDER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/field[@name='PREVIEW_IMAGE_FOLDER']"
		[Register ("PREVIEW_IMAGE_FOLDER")]
		public static string PreviewImageFolder {
			get {
				if (PREVIEW_IMAGE_FOLDER_jfieldId == IntPtr.Zero)
					PREVIEW_IMAGE_FOLDER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREVIEW_IMAGE_FOLDER", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PREVIEW_IMAGE_FOLDER_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PREVIEW_IMAGE_FOLDER_jfieldId == IntPtr.Zero)
					PREVIEW_IMAGE_FOLDER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREVIEW_IMAGE_FOLDER", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, PREVIEW_IMAGE_FOLDER_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/field[@name='SAMSUNG']"
		[Register ("SAMSUNG")]
		public const string Samsung = (string) "samsung";

		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils.ImageFolderType']"
		[global::Android.Runtime.Register ("com/liveperson/infra/utils/ImageUtils$ImageFolderType", DoNotGenerateAcw=true)]
		public sealed partial class ImageFolderType : global::Java.Lang.Enum {


			static IntPtr FULL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils.ImageFolderType']/field[@name='FULL']"
			[Register ("FULL")]
			public static global::Com.Liveperson.Infra.Utils.ImageUtils.ImageFolderType Full {
				get {
					if (FULL_jfieldId == IntPtr.Zero)
						FULL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FULL", "Lcom/liveperson/infra/utils/ImageUtils$ImageFolderType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FULL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.ImageUtils.ImageFolderType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PREVIEW_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils.ImageFolderType']/field[@name='PREVIEW']"
			[Register ("PREVIEW")]
			public static global::Com.Liveperson.Infra.Utils.ImageUtils.ImageFolderType Preview {
				get {
					if (PREVIEW_jfieldId == IntPtr.Zero)
						PREVIEW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREVIEW", "Lcom/liveperson/infra/utils/ImageUtils$ImageFolderType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PREVIEW_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.ImageUtils.ImageFolderType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/utils/ImageUtils$ImageFolderType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ImageFolderType); }
			}

			internal ImageFolderType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils.ImageFolderType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/utils/ImageUtils$ImageFolderType;", "")]
			public static unsafe global::Com.Liveperson.Infra.Utils.ImageUtils.ImageFolderType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/utils/ImageUtils$ImageFolderType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Liveperson.Infra.Utils.ImageUtils.ImageFolderType __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.ImageUtils.ImageFolderType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils.ImageFolderType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/liveperson/infra/utils/ImageUtils$ImageFolderType;", "")]
			public static unsafe global::Com.Liveperson.Infra.Utils.ImageUtils.ImageFolderType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/infra/utils/ImageUtils$ImageFolderType;");
				try {
					return (global::Com.Liveperson.Infra.Utils.ImageUtils.ImageFolderType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Infra.Utils.ImageUtils.ImageFolderType));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/utils/ImageUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageUtils); }
		}

		protected ImageUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/constructor[@name='ImageUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ImageUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ImageUtils)) {
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

		static IntPtr id_base64ToBitmap_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/method[@name='base64ToBitmap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("base64ToBitmap", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap Base64ToBitmap (string p0)
		{
			if (id_base64ToBitmap_Ljava_lang_String_ == IntPtr.Zero)
				id_base64ToBitmap_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "base64ToBitmap", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_base64ToBitmap_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_base64ToByteArray_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/method[@name='base64ToByteArray' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("base64ToByteArray", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] Base64ToByteArray (string p0)
		{
			if (id_base64ToByteArray_Ljava_lang_String_ == IntPtr.Zero)
				id_base64ToByteArray_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "base64ToByteArray", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_base64ToByteArray_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_bitmapToBase64_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/method[@name='bitmapToBase64' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("bitmapToBase64", "(Landroid/graphics/Bitmap;)Ljava/lang/String;", "")]
		public static unsafe string BitmapToBase64 (global::Android.Graphics.Bitmap p0)
		{
			if (id_bitmapToBase64_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_bitmapToBase64_Landroid_graphics_Bitmap_ = JNIEnv.GetStaticMethodID (class_ref, "bitmapToBase64", "(Landroid/graphics/Bitmap;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_bitmapToBase64_Landroid_graphics_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_bitmapToBase64_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/method[@name='bitmapToBase64' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("bitmapToBase64", "([B)Ljava/lang/String;", "")]
		public static unsafe string BitmapToBase64 (byte[] p0)
		{
			if (id_bitmapToBase64_arrayB == IntPtr.Zero)
				id_bitmapToBase64_arrayB = JNIEnv.GetStaticMethodID (class_ref, "bitmapToBase64", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_bitmapToBase64_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_blur_Landroid_content_Context_Landroid_graphics_Bitmap_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/method[@name='blur' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='int']]"
		[Register ("blur", "(Landroid/content/Context;Landroid/graphics/Bitmap;I)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap Blur (global::Android.Content.Context p0, global::Android.Graphics.Bitmap p1, int p2)
		{
			if (id_blur_Landroid_content_Context_Landroid_graphics_Bitmap_I == IntPtr.Zero)
				id_blur_Landroid_content_Context_Landroid_graphics_Bitmap_I = JNIEnv.GetStaticMethodID (class_ref, "blur", "(Landroid/content/Context;Landroid/graphics/Bitmap;I)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_blur_Landroid_content_Context_Landroid_graphics_Bitmap_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createBitmap_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/method[@name='createBitmap' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("createBitmap", "(Landroid/net/Uri;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap CreateBitmap (global::Android.Net.Uri p0)
		{
			if (id_createBitmap_Landroid_net_Uri_ == IntPtr.Zero)
				id_createBitmap_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "createBitmap", "(Landroid/net/Uri;)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createBitmap_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createBitmapFromURL_Landroid_content_Context_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/method[@name='createBitmapFromURL' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("createBitmapFromURL", "(Landroid/content/Context;Ljava/lang/String;II)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap CreateBitmapFromURL (global::Android.Content.Context p0, string p1, int p2, int p3)
		{
			if (id_createBitmapFromURL_Landroid_content_Context_Ljava_lang_String_II == IntPtr.Zero)
				id_createBitmapFromURL_Landroid_content_Context_Ljava_lang_String_II = JNIEnv.GetStaticMethodID (class_ref, "createBitmapFromURL", "(Landroid/content/Context;Ljava/lang/String;II)Landroid/graphics/Bitmap;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createBitmapFromURL_Landroid_content_Context_Ljava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_createImageFileForCamera_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/method[@name='createImageFileForCamera' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("createImageFileForCamera", "(Landroid/content/Context;Ljava/lang/String;)Landroid/net/Uri;", "")]
		public static unsafe global::Android.Net.Uri CreateImageFileForCamera (global::Android.Content.Context p0, string p1)
		{
			if (id_createImageFileForCamera_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_createImageFileForCamera_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createImageFileForCamera", "(Landroid/content/Context;Ljava/lang/String;)Landroid/net/Uri;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createImageFileForCamera_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_createImageOnCanvas_Landroid_content_Context_Landroid_view_WindowManager_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/method[@name='createImageOnCanvas' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.view.WindowManager'] and parameter[3][@type='android.graphics.Bitmap']]"
		[Register ("createImageOnCanvas", "(Landroid/content/Context;Landroid/view/WindowManager;Landroid/graphics/Bitmap;)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable CreateImageOnCanvas (global::Android.Content.Context p0, global::Android.Views.IWindowManager p1, global::Android.Graphics.Bitmap p2)
		{
			if (id_createImageOnCanvas_Landroid_content_Context_Landroid_view_WindowManager_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_createImageOnCanvas_Landroid_content_Context_Landroid_view_WindowManager_Landroid_graphics_Bitmap_ = JNIEnv.GetStaticMethodID (class_ref, "createImageOnCanvas", "(Landroid/content/Context;Landroid/view/WindowManager;Landroid/graphics/Bitmap;)Landroid/graphics/drawable/Drawable;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Android.Graphics.Drawables.Drawable __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createImageOnCanvas_Landroid_content_Context_Landroid_view_WindowManager_Landroid_graphics_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createResizedBitmap_Landroid_net_Uri_IIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/method[@name='createResizedBitmap' and count(parameter)=4 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("createResizedBitmap", "(Landroid/net/Uri;IIZ)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap CreateResizedBitmap (global::Android.Net.Uri p0, int p1, int p2, bool p3)
		{
			if (id_createResizedBitmap_Landroid_net_Uri_IIZ == IntPtr.Zero)
				id_createResizedBitmap_Landroid_net_Uri_IIZ = JNIEnv.GetStaticMethodID (class_ref, "createResizedBitmap", "(Landroid/net/Uri;IIZ)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createResizedBitmap_Landroid_net_Uri_IIZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createResizedExactBitmap_Landroid_net_Uri_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/method[@name='createResizedExactBitmap' and count(parameter)=3 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("createResizedExactBitmap", "(Landroid/net/Uri;II)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap CreateResizedExactBitmap (global::Android.Net.Uri p0, int p1, int p2)
		{
			if (id_createResizedExactBitmap_Landroid_net_Uri_II == IntPtr.Zero)
				id_createResizedExactBitmap_Landroid_net_Uri_II = JNIEnv.GetStaticMethodID (class_ref, "createResizedExactBitmap", "(Landroid/net/Uri;II)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createResizedExactBitmap_Landroid_net_Uri_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_decodeExifOrientation_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/method[@name='decodeExifOrientation' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("decodeExifOrientation", "(IZ)I", "")]
		public static unsafe int DecodeExifOrientation (int p0, bool p1)
		{
			if (id_decodeExifOrientation_IZ == IntPtr.Zero)
				id_decodeExifOrientation_IZ = JNIEnv.GetStaticMethodID (class_ref, "decodeExifOrientation", "(IZ)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_decodeExifOrientation_IZ, __args);
			} finally {
			}
		}

		static IntPtr id_deleteImageFolder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/method[@name='deleteImageFolder' and count(parameter)=0]"
		[Register ("deleteImageFolder", "()V", "")]
		public static unsafe void DeleteImageFolder ()
		{
			if (id_deleteImageFolder == IntPtr.Zero)
				id_deleteImageFolder = JNIEnv.GetStaticMethodID (class_ref, "deleteImageFolder", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_deleteImageFolder);
			} finally {
			}
		}

		static IntPtr id_getBitmap_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/method[@name='getBitmap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBitmap", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetBitmap (string p0)
		{
			if (id_getBitmap_Ljava_lang_String_ == IntPtr.Zero)
				id_getBitmap_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBitmap", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBitmap_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getFilePath_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/method[@name='getFilePath' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getFilePath", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File GetFilePath (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_getFilePath_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getFilePath_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getFilePath", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Ljava/io/File;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFilePath_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_getImagePath_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/method[@name='getImagePath' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='java.lang.String']]"
		[Register ("getImagePath", "(Landroid/content/Context;Landroid/net/Uri;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetImagePath (global::Android.Content.Context p0, global::Android.Net.Uri p1, string p2)
		{
			if (id_getImagePath_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_ == IntPtr.Zero)
				id_getImagePath_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getImagePath", "(Landroid/content/Context;Landroid/net/Uri;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getImagePath_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_getImageRotation_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/method[@name='getImageRotation' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("getImageRotation", "(Ljava/lang/String;Z)I", "")]
		public static unsafe int GetImageRotation (string p0, bool p1)
		{
			if (id_getImageRotation_Ljava_lang_String_Z == IntPtr.Zero)
				id_getImageRotation_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "getImageRotation", "(Ljava/lang/String;Z)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getImageRotation_Ljava_lang_String_Z, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getOutputStreamFromBitmap_Landroid_graphics_Bitmap_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/method[@name='getOutputStreamFromBitmap' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("getOutputStreamFromBitmap", "(Landroid/graphics/Bitmap;ILjava/lang/String;)[B", "")]
		public static unsafe byte[] GetOutputStreamFromBitmap (global::Android.Graphics.Bitmap p0, int p1, string p2)
		{
			if (id_getOutputStreamFromBitmap_Landroid_graphics_Bitmap_ILjava_lang_String_ == IntPtr.Zero)
				id_getOutputStreamFromBitmap_Landroid_graphics_Bitmap_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getOutputStreamFromBitmap", "(Landroid/graphics/Bitmap;ILjava/lang/String;)[B");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOutputStreamFromBitmap_Landroid_graphics_Bitmap_ILjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_saveBase64ToDisk_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/method[@name='saveBase64ToDisk' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("saveBase64ToDisk", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string SaveBase64ToDisk (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_saveBase64ToDisk_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_saveBase64ToDisk_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "saveBase64ToDisk", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_saveBase64ToDisk_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_saveBitmapToDisk_Landroid_content_Context_arrayBLjava_lang_String_Lcom_liveperson_infra_utils_ImageUtils_ImageFolderType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/method[@name='saveBitmapToDisk' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.liveperson.infra.utils.ImageUtils.ImageFolderType'] and parameter[5][@type='java.lang.String']]"
		[Register ("saveBitmapToDisk", "(Landroid/content/Context;[BLjava/lang/String;Lcom/liveperson/infra/utils/ImageUtils$ImageFolderType;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string SaveBitmapToDisk (global::Android.Content.Context p0, byte[] p1, string p2, global::Com.Liveperson.Infra.Utils.ImageUtils.ImageFolderType p3, string p4)
		{
			if (id_saveBitmapToDisk_Landroid_content_Context_arrayBLjava_lang_String_Lcom_liveperson_infra_utils_ImageUtils_ImageFolderType_Ljava_lang_String_ == IntPtr.Zero)
				id_saveBitmapToDisk_Landroid_content_Context_arrayBLjava_lang_String_Lcom_liveperson_infra_utils_ImageUtils_ImageFolderType_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "saveBitmapToDisk", "(Landroid/content/Context;[BLjava/lang/String;Lcom/liveperson/infra/utils/ImageUtils$ImageFolderType;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_saveBitmapToDisk_Landroid_content_Context_arrayBLjava_lang_String_Lcom_liveperson_infra_utils_ImageUtils_ImageFolderType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_saveBitmapToDisk_Landroid_content_Context_arrayBLjava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_ImageUtils_ImageFolderType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/method[@name='saveBitmapToDisk' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.liveperson.infra.utils.ImageUtils.ImageFolderType']]"
		[Register ("saveBitmapToDisk", "(Landroid/content/Context;[BLjava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/utils/ImageUtils$ImageFolderType;)Ljava/lang/String;", "")]
		public static unsafe string SaveBitmapToDisk (global::Android.Content.Context p0, byte[] p1, string p2, string p3, global::Com.Liveperson.Infra.Utils.ImageUtils.ImageFolderType p4)
		{
			if (id_saveBitmapToDisk_Landroid_content_Context_arrayBLjava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_ImageUtils_ImageFolderType_ == IntPtr.Zero)
				id_saveBitmapToDisk_Landroid_content_Context_arrayBLjava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_ImageUtils_ImageFolderType_ = JNIEnv.GetStaticMethodID (class_ref, "saveBitmapToDisk", "(Landroid/content/Context;[BLjava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/utils/ImageUtils$ImageFolderType;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_saveBitmapToDisk_Landroid_content_Context_arrayBLjava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_ImageUtils_ImageFolderType_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_saveBitmapToDisk_arrayBLjava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='ImageUtils']/method[@name='saveBitmapToDisk' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.io.File']]"
		[Register ("saveBitmapToDisk", "([BLjava/io/File;)Ljava/lang/String;", "")]
		public static unsafe string SaveBitmapToDisk (byte[] p0, global::Java.IO.File p1)
		{
			if (id_saveBitmapToDisk_arrayBLjava_io_File_ == IntPtr.Zero)
				id_saveBitmapToDisk_arrayBLjava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "saveBitmapToDisk", "([BLjava/io/File;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_saveBitmapToDisk_arrayBLjava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
