using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='RegexUtil']"
	[global::Android.Runtime.Register ("com/liveperson/infra/utils/RegexUtil", DoNotGenerateAcw=true)]
	public partial class RegexUtil : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='RegexUtil']/field[@name='ICON_REV_TAG_PATTERN']"
		[Register ("ICON_REV_TAG_PATTERN")]
		public const string IconRevTagPattern = (string) "<img(.*?)src=(\"|')(.+?)(gif|jpg|png|bmp)(\"|')(.*?)(/)?>(</img>)?";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='RegexUtil']/field[@name='ICON_TAG_PATTERN']"
		[Register ("ICON_TAG_PATTERN")]
		public const string IconTagPattern = (string) "<img(.*?)src=(\"|')(.+?)(gif|jpg|png|bmp)(\"|')(.*?)(/)?>(</img>)?";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='RegexUtil']/field[@name='IMAGE_PATTERN']"
		[Register ("IMAGE_PATTERN")]
		public const string ImagePattern = (string) "(.+?)\\.(jpg|png|gif|bmp)$";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='RegexUtil']/field[@name='IMAGE_TAG_PATTERN']"
		[Register ("IMAGE_TAG_PATTERN")]
		public const string ImageTagPattern = (string) "<img(.*?)src=(\"|')(.+?)(gif|jpg|png|bmp)(\"|')(.*?)(/)?>(</img>)?";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='RegexUtil']/field[@name='ITEMPROP_IMAGE_REV_TAG_PATTERN']"
		[Register ("ITEMPROP_IMAGE_REV_TAG_PATTERN")]
		public const string ItempropImageRevTagPattern = (string) "<img(.*?)src=(\"|')(.+?)(gif|jpg|png|bmp)(\"|')(.*?)(/)?>(</img>)?";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='RegexUtil']/field[@name='ITEMPROP_IMAGE_TAG_PATTERN']"
		[Register ("ITEMPROP_IMAGE_TAG_PATTERN")]
		public const string ItempropImageTagPattern = (string) "<img(.*?)src=(\"|')(.+?)(gif|jpg|png|bmp)(\"|')(.*?)(/)?>(</img>)?";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='RegexUtil']/field[@name='METATAG_CONTENT_PATTERN']"
		[Register ("METATAG_CONTENT_PATTERN")]
		public const string MetatagContentPattern = (string) "content=\"(.*?)\"";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='RegexUtil']/field[@name='METATAG_PATTERN']"
		[Register ("METATAG_PATTERN")]
		public const string MetatagPattern = (string) "<meta(.*?)>";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='RegexUtil']/field[@name='SCRIPT_PATTERN']"
		[Register ("SCRIPT_PATTERN")]
		public const string ScriptPattern = (string) "<script(.*?)>(.*?)</script>";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='RegexUtil']/field[@name='TITLE_PATTERN']"
		[Register ("TITLE_PATTERN")]
		public const string TitlePattern = (string) "<title(.*?)>(.*?)</title>";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='RegexUtil']/field[@name='URL_PATTERN']"
		[Register ("URL_PATTERN")]
		public const string UrlPattern = (string) "<\\b(https?|ftp|file)://[-a-zA-Z0-9+&@#/%?=~_|!:,.;]*[-a-zA-Z0-9+&@#/%=~_|]>";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/utils/RegexUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RegexUtil); }
		}

		protected RegexUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='RegexUtil']/constructor[@name='RegexUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RegexUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (RegexUtil)) {
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

		static IntPtr id_pregMatch_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='RegexUtil']/method[@name='pregMatch' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("pregMatch", "(Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;", "")]
		public static unsafe string PregMatch (string p0, string p1, int p2)
		{
			if (id_pregMatch_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_pregMatch_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "pregMatch", "(Ljava/lang/String;Ljava/lang/String;I)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_pregMatch_Ljava_lang_String_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_pregMatchAll_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='RegexUtil']/method[@name='pregMatchAll' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("pregMatchAll", "(Ljava/lang/String;Ljava/lang/String;I)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> PregMatchAll (string p0, string p1, int p2)
		{
			if (id_pregMatchAll_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_pregMatchAll_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "pregMatchAll", "(Ljava/lang/String;Ljava/lang/String;I)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_pregMatchAll_Ljava_lang_String_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_pregMatchAllExtraImages_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='RegexUtil']/method[@name='pregMatchAllExtraImages' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("pregMatchAllExtraImages", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> PregMatchAllExtraImages (string p0, string p1)
		{
			if (id_pregMatchAllExtraImages_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_pregMatchAllExtraImages_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "pregMatchAllExtraImages", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_pregMatchAllExtraImages_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_pregMatchAllImages_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='RegexUtil']/method[@name='pregMatchAllImages' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("pregMatchAllImages", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> PregMatchAllImages (string p0, string p1)
		{
			if (id_pregMatchAllImages_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_pregMatchAllImages_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "pregMatchAllImages", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_pregMatchAllImages_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
